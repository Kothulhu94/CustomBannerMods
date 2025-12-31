using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.Actions;
using LudusMagnus.Core;

namespace LudusMagnus.AI
{
    public class LudusSiegeReliefBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnHourlyTick()
        {
            if (LudusManager.Instance == null) return;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                var ludus = kvp.Value;
                if (ludus.State != LudusState.Active || ludus.Settlement == null) continue;

                // Only check if we DON'T already have a relief force active
                bool hasReliefForce = MobileParty.All.Any(p => 
                    p.StringId != null && 
                    p.StringId.Contains("ludus_relief") && 
                    p.HomeSettlement == ludus.Settlement && 
                    p.IsActive);

                if (hasReliefForce) continue;

                CheckForSieges(ludus);
            }
        }

        private void CheckForSieges(LudusLocation ludus)
        {
            if (ludus.Owner == null || ludus.Owner.Clan == null) return;

            float range = 100f; // Check radius
            
            // Find Allied Towns under siege
            var besiegedAlly = Settlement.All.FirstOrDefault(s => 
                s.IsTown && 
                s.IsUnderSiege && 
                s.OwnerClan != null &&
                (s.OwnerClan == ludus.Owner.Clan || s.OwnerClan.Kingdom == ludus.Owner.Clan.Kingdom) && // Ally
                s.GatePosition.DistanceSquared(ludus.Settlement.GatePosition) < range * range
            );

            if (besiegedAlly != null)
            {
                SpawnReliefForce(ludus, besiegedAlly);
            }
        }

        private void SpawnReliefForce(LudusLocation ludus, Settlement target)
        {
            // Check Garrison Strength
            MobileParty garrison = ludus.Settlement.Town?.GarrisonParty ?? ludus.Settlement.Parties.FirstOrDefault(p => p.IsGarrison);
            if (garrison == null || garrison.MemberRoster.TotalHealthyCount < 50) return; // Too weak to help

            // Create Party
            MobileParty reliefForce = MobileParty.CreateParty("ludus_relief_" + MBRandom.RandomInt(100000), null); // Removed component for now to keep simple
            
            // Transfer Troops (Risk: 50% of Garrison)
            int troopsToTake = (int)(garrison.MemberRoster.TotalHealthyCount * 0.5f);
            
            // Logic to move troops from Garrison to Relief Force
            // Flatten roster, take top tier first? Or just simple chunk.
            // Simplified: Take ratio of each stack.
            
            foreach(var element in garrison.MemberRoster.GetTroopRoster().ToList())
            {
                 if (element.Character.IsHero) continue;
                 int amount = (int)(element.Number * 0.5f);
                 if (amount > 0)
                 {
                     reliefForce.MemberRoster.AddToCounts(element.Character, amount);
                     garrison.MemberRoster.AddToCounts(element.Character, -amount);
                 }
            }

            if (reliefForce.MemberRoster.TotalManCount == 0) 
            {
                DestroyPartyAction.Apply(null, reliefForce);
                return;
            }

            reliefForce.InitializeMobilePartyAtPosition(reliefForce.MemberRoster, reliefForce.PrisonRoster, ludus.Settlement.GatePosition);
            
            reliefForce.SetPartyUsedByQuest(true);
            reliefForce.Aggressiveness = 10f; // Very aggressive
            reliefForce.ActualClan = ludus.Owner.Clan;

            // Order to Attack Siege Camp
            if (target.SiegeEvent != null && target.SiegeEvent.BesiegerCamp != null && target.SiegeEvent.BesiegerCamp.LeaderParty != null)
            {
                // Fix: explicit cast for navigation type
                reliefForce.SetMoveEngageParty(target.SiegeEvent.BesiegerCamp.LeaderParty, (MobileParty.NavigationType)0);
                InformationManager.DisplayMessage(new InformationMessage($"{ludus.Settlement.Name} has dispatched a RELIEF FORCE to break the siege at {target.Name}!", Colors.Green));
            }
            else
            {
                 // Fallback
                 reliefForce.SetMoveGoToSettlement(target, (MobileParty.NavigationType)0, false);
            }
        }
    }
}
