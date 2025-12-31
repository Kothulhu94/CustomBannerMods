using System.Linq;
using LudusMagnus.Core;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.Actions;
using Microsoft.Extensions.Logging;

namespace LudusMagnus.AI
{
    public class LudusSentinelBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnDailyTick()
        {
            if (LudusManager.Instance == null || LudusManager.Instance.LudusRegistry == null) return;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                LudusLocation ludus = kvp.Value;
                if (ludus.State != LudusState.Active || ludus.Settlement == null) continue;

                ManageSentinels(ludus);
                GuideSentinels(ludus);
            }
        }

        private void GuideSentinels(LudusLocation ludus)
        {
            if (ludus.Settlement == null) return;

            // Find Sentinels
            var sentinels = MobileParty.All.Where(p => 
                p.StringId != null &&
                p.StringId.Contains("ludus_sentinel") && 
                p.HomeSettlement == ludus.Settlement && 
                p.IsActive).ToList();

            if (!sentinels.Any()) return;

            // Find Raided Villages
            // 1. Bound Villages (if Town)
            var villages = ludus.Settlement.BoundVillages.ToList();
            
            // 2. Or just nearby villages if we want broader coverage
             // let's stick to bound villages for "Good Neighbor" strictness, 
             // but if none bound (e.g. Ludus is standalone?), look for nearby. 
             // Ludus is a standalone settlement type usually. It might not have bound villages.
             // So we should look for villages bound to the *nearest* town or castles, or just within radius.
            
            float radius = 50f;
            var nearbyVillages = Settlement.All.Where(s => s.IsVillage && s.GatePosition.DistanceSquared(ludus.Settlement.GatePosition) < radius * radius);

            foreach (var sentinel in sentinels)
            {
                if (sentinel.MapEvent != null) continue; // Busy

                // Priority: Engage Raiders
                foreach (var settlement in nearbyVillages)
                {
                   if (settlement.Village.VillageState == Village.VillageStates.BeingRaided)
                   {
                        // Find the raider party via Parties at the settlement
                        var raidParty = settlement.Parties.FirstOrDefault(p => p.MapEvent != null && p.MapEvent.IsRaid);
                        
                        if (raidParty != null && raidParty.MapEvent != null)
                        {
                            var side = raidParty.MapEvent.AttackerSide;
                            if (side != null && side.LeaderParty != null && side.LeaderParty.MobileParty != null)
                            {
                                sentinel.SetMoveEngageParty(side.LeaderParty.MobileParty, (MobileParty.NavigationType)0);
                                InformationManager.DisplayMessage(new InformationMessage($"{sentinel.Name} is moving to defend {settlement.Name}!", Colors.Green));
                                goto NextSentinel;
                            }
                        }
                   }
                }
                
                // Default: Patrol if idle
                // Removed invalid MoveTargetEnum checks. Just check if TargetParty/TargetSettlement is null.
                if (sentinel.TargetParty == null && sentinel.TargetSettlement == null)
                {
                     sentinel.SetMovePatrolAroundSettlement(ludus.Settlement, MobileParty.NavigationType.Default, true); 
                }

                NextSentinel:;
            }
        }

        private void ManageSentinels(LudusLocation ludus)
        {
            if (ludus.Owner == null || ludus.Owner.Clan == null) return;

            float renown = ludus.Owner.Clan.Renown;
            int limit = 1 + (int)(renown / 500f); 
            if (limit > 3) limit = 3; 

            int currentCount = MobileParty.All.Count(p => 
                p.StringId != null &&
                p.StringId.Contains("ludus_sentinel") && 
                p.HomeSettlement == ludus.Settlement && 
                p.IsActive);

            if (currentCount < limit)
            {
                SpawnSentinel(ludus);
            }
        }

        private void SpawnSentinel(LudusLocation ludus)
        {
            Clan ownerClan = ludus.Owner.Clan;
            // Passed settlement to constructor. Removed 3rd arg.
            MobileParty sentinel = MobileParty.CreateParty("ludus_sentinel_" + MBRandom.RandomInt(100000), new LudusSentinelComponent(ludus.Settlement));
            
            TextObject name = new TextObject("{=ludus_snt}Venatores of {CLAN}");
            name.SetTextVariable("CLAN", ownerClan.Name);
            // Removed sentinel.SetCustomName(name) if invalid

            // Removed assignment to Read-Only Property
            // sentinel.HomeSettlement = ludus.Settlement;
            
            // CRITICAL FIX: Set Clan BEFORE init to prevent NavalDLC/Culture NREs
            sentinel.ActualClan = ownerClan;

            try 
            {
                // Use Template if available
                var template = Campaign.Current.ObjectManager.GetObject<PartyTemplateObject>("ludus_sentinel_template");
                if (template != null)
                {
                     sentinel.InitializeMobilePartyAtPosition(template, ludus.Settlement.GatePosition);
                }
                else
                {
                     sentinel.InitializeMobilePartyAtPosition(sentinel.MemberRoster, sentinel.PrisonRoster, ludus.Settlement.GatePosition);
                     
                     CharacterObject troop = ownerClan.Culture.EliteBasicTroop;
                     if (troop != null)
                     {
                          sentinel.MemberRoster.AddToCounts(troop, 10);
                     }
                     else
                     {
                          sentinel.MemberRoster.AddToCounts(ownerClan.Culture.BasicTroop, 20);
                     }
                }
            }
            catch (System.Exception ex)
            {
                // Fail-safe: Destroy party if init crashes to prevent zombie party ticking
                if (sentinel != null) DestroyPartyAction.Apply(null, sentinel);
                LudusSubModule.InstanceLogger?.LogError(ex, "Failed to spawn Sentinel. Destroying party.");
                return;
            }

            sentinel.SetPartyUsedByQuest(true); 
            // sentinel.ActualClan = ownerClan; // Moved up
            
            sentinel.SetMovePatrolAroundSettlement(ludus.Settlement, MobileParty.NavigationType.Default, true);
            sentinel.Aggressiveness = 5f; 
        }
    }
}
