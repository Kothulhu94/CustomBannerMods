using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem.Actions;
using LudusMagnus.Core;

namespace LudusMagnus.AI
{
    public class AiVisitLudusBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.AiHourlyTickEvent.AddNonSerializedListener(this, OnAiHourlyTick);
            CampaignEvents.DailyTickPartyEvent.AddNonSerializedListener(this, OnDailyTickParty);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnAiHourlyTick(MobileParty mobileParty, PartyThinkParams thinkParams)
        {
            // Only Lord parties
            if (!mobileParty.IsLordParty || mobileParty.LeaderHero == null || mobileParty.IsMainParty) return;
            
            // Check if looking for troops/gear
            int limit = (int)Campaign.Current.Models.PartySizeLimitModel.GetPartyMemberSizeLimit(mobileParty.Party, false).ResultNumber;
            bool needsTroops = mobileParty.MemberRoster.TotalManCount < limit * 0.5f;
            bool rich = mobileParty.LeaderHero.Gold > 100000;

            if (rich && (needsTroops || mobileParty.LeaderHero.GetTraitLevel(DefaultTraits.Valor) > 0))
            {
                // Find nearest Ludus
                LudusLocation target = FindAttractiveLudus(mobileParty);
                if (target != null && target.Settlement != null)
                {
                    // Force move for simplicity (AI api is complex)
                    mobileParty.SetMoveGoToSettlement(target.Settlement, (MobileParty.NavigationType)0, false);
                }
            }
        }

        private void OnDailyTickParty(MobileParty mobileParty)
        {
            if (!mobileParty.IsLordParty || mobileParty.LeaderHero == null || mobileParty.CurrentSettlement == null) return;

            // Check if at a Ludus (that they don't own)
            if (LudusManager.Instance == null) return;
            
            var ludus = LudusManager.Instance.GetLudusFor(mobileParty.CurrentSettlement.OwnerClan?.Leader);
            
            // Should be the settlement they are AT
            // The GetLudusFor checks owner. We need to check if CurrentSettlement ID matches a Ludus.
            LudusLocation currentLudus = LudusManager.Instance.LudusRegistry.Values.FirstOrDefault(l => l.Settlement == mobileParty.CurrentSettlement);

            if (currentLudus != null && currentLudus.State == LudusState.Active && currentLudus.Owner != mobileParty.LeaderHero)
            {
                // Customer Logic: Pay Fee, Gain XP
                int fee = 200 + (mobileParty.LeaderHero.Level * 10);
                
                if (mobileParty.LeaderHero.Gold >= fee)
                {
                     GiveGoldAction.ApplyBetweenCharacters(mobileParty.LeaderHero, currentLudus.Owner, fee);
                     
                     // Train Troops (Simulated)
                     mobileParty.MemberRoster.AddXpToTroop(mobileParty.LeaderHero.CharacterObject, 100); // Hero XP
                     foreach(var troop in mobileParty.MemberRoster.GetTroopRoster())
                     {
                         if (!troop.Character.IsHero)
                         {
                             mobileParty.MemberRoster.AddXpToTroop(troop.Character, 50);
                         }
                     }
                }

                // Weekly Ascension Service (T4+ Clans Check)
                if ((int)CampaignTime.Now.ToDays % 7 == 0 && 
                    mobileParty.LeaderHero.Clan != null && 
                    mobileParty.LeaderHero.Clan.Tier >= 4 &&
                    currentLudus.Facilities.ContainsKey(FacilityType.Temple))
                {
                     // Ascension Service Fee (Expensive)
                     int ascensionFee = 5000;
                     if (mobileParty.LeaderHero.Gold > ascensionFee * 2) // Ensure they have buffer
                     {
                         var eligible = mobileParty.MemberRoster.GetTroopRoster()
                            .Where(t => !t.Character.IsHero && t.Character.Tier >= 5 && (t.Character.UpgradeTargets == null || t.Character.UpgradeTargets.Length == 0))
                            .ToList();

                         if (eligible.Count > 0)
                         {
                             int ascensionCount = MBRandom.RandomInt(1, 4); // 1-3 troops
                             int actualAscended = 0;
                             
                             for(int i=0; i < ascensionCount; i++)
                             {
                                 if (eligible.Count == 0) break;
                                 var node = eligible.GetRandomElement();
                                 if (mobileParty.MemberRoster.GetTroopCount(node.Character) > 0)
                                 {
                                     LudusMagnus.Ascension.AscensionTroopLogic.AscendTroop(mobileParty.Party, node.Character, 1);
                                     actualAscended++;
                                 }
                             }

                             if (actualAscended > 0)
                             {
                                 GiveGoldAction.ApplyBetweenCharacters(mobileParty.LeaderHero, currentLudus.Owner, ascensionFee);
                                 // Optional: Message if player owned
                                 if (currentLudus.Owner == Hero.MainHero) {
                                     TaleWorlds.Library.InformationManager.DisplayMessage(new TaleWorlds.Library.InformationMessage($"Lord {mobileParty.LeaderHero.Name} paid {ascensionFee}g for Ascension Rituals at your Ludus!", TaleWorlds.Library.Colors.Green));
                                 }
                             }
                         }
                     }
                }
            }
        }

        private LudusLocation FindAttractiveLudus(MobileParty party)
        {
            LudusLocation best = null;
            float bestDist = 200f; // Max range

            if (LudusManager.Instance == null) return null;

            foreach (var kvp in LudusManager.Instance.GetAllLudusLocations())
            {
                var ludus = kvp.Value;
                if (ludus.State != LudusState.Active || ludus.Settlement == null) continue;
                if (ludus.Owner.Clan == party.ActualClan) continue; // Don't visit own (handled by standard logic)

                // Use CampaignVec2.Distance(Vec2)
                float dist = party.Position.Distance(ludus.Settlement.GatePosition);
                if (dist < bestDist)
                {
                    bestDist = dist;
                    best = ludus;
                }
            }
            return best;
        }
    }
}
