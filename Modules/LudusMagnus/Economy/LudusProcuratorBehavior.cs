using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using LudusMagnus.Core;

namespace LudusMagnus.Economy
{
    // Stubbed for Agent B verification
    public class LudusProcuratorBehavior : CampaignBehaviorBase
    {
        private enum ProcuratorState
        {
            Thinking,
            BuyingFood,
            ReturningHome,
            SellingLoot
        }

        public override void RegisterEvents()
        {
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnDailyTick()
        {
            if (LudusManager.Instance == null) return;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                var ludus = kvp.Value;
                if (ludus.State != LudusState.Active || ludus.Settlement == null) continue;

                // Check if caravan exists
                bool hasCaravan = MobileParty.All.Any(p => 
                    p.PartyComponent is ProcuratorCaravanComponent comp && 
                    comp.Ludus == ludus && 
                    p.IsActive);

                if (!hasCaravan)
                {
                    SpawnProcurator(ludus);
                }
            }
        }

        private void SpawnProcurator(LudusLocation ludus)
        {
            if (ludus.Owner == null || ludus.Owner.Clan == null) return;

            MobileParty caravan = MobileParty.CreateParty("ludus_procurator_" + MBRandom.RandomInt(100000), new ProcuratorCaravanComponent(ludus));
             
            // Assign Leader if available
            Hero procuratorHero = null;
            if (ludus.Staff.ContainsKey(StaffRole.Procurator))
            {
                procuratorHero = ludus.Staff[StaffRole.Procurator];
                if (procuratorHero != null && procuratorHero.PartyBelongedTo == null && procuratorHero.GovernorOf == null)
                {
                   // Can't easily force them to lead without removing from other roles, assume "Remote Management" for now 
                   // OR just use their stats for the party without them being physically present leader.
                   // For "Four Pillars" compliance involving Heroes, let's keep it simple: No physical hero leader yet to avoid crashes.
                }
            }

            caravan.InitializeMobilePartyAtPosition(caravan.MemberRoster, caravan.PrisonRoster, ludus.Settlement.GatePosition);
            
            // Add Guards
            var culture = ludus.Owner.Clan.Culture;
            caravan.MemberRoster.AddToCounts(culture.CaravanMaster ?? culture.EliteBasicTroop, 1);
            caravan.MemberRoster.AddToCounts(culture.BasicTroop, 25); // Combined 15 + 10 since Archer property is uncertain

            // Configure
            caravan.SetPartyUsedByQuest(true); // Prevents some default AI
            caravan.Aggressiveness = 0f; // Passive
            caravan.Ai.DisableAi(); // We control it manually
            
            // Set initial movement
            caravan.SetMovePatrolAroundSettlement(ludus.Settlement, MobileParty.NavigationType.Default, true); 
        }

        private void OnHourlyTick()
        {
            if (LudusManager.Instance == null) return;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                var ludus = kvp.Value;
                MobileParty caravan = MobileParty.All.FirstOrDefault(p => 
                    p.PartyComponent is ProcuratorCaravanComponent comp && 
                    comp.Ludus == ludus && 
                    p.IsActive);

                if (caravan != null)
                {
                    RunProcuratorAi(caravan, ludus);
                }
            }
        }

        private void RunProcuratorAi(MobileParty caravan, LudusLocation ludus)
        {
            if (caravan.MapEvent != null || (caravan.CurrentSettlement != null && caravan.CurrentSettlement.IsUnderSiege)) return;

            // Simple State Machine

            
            bool isAtHome = caravan.CurrentSettlement == ludus.Settlement;
            int foodCount = ludus.Storage.GetItemNumber(DefaultItems.Grain);
            bool needsFood = foodCount < 1000;

            if (isAtHome)
            {
                // DUMP FOOD
                TransferGoods(caravan, ludus, true);

                if (needsFood)
                {
                     // FIND CHEAP FOOD
                     Settlement target = FindNearestTownWithFood(caravan);
                     if (target != null)
                     {
                         caravan.SetMoveGoToSettlement(target, (MobileParty.NavigationType)0, false);
                     }
                }
                else
                {
                    // TAKE LOOT & SELL
                    TransferGoods(caravan, ludus, false); // Turn Loot -> Caravan
                    Settlement target = FindRichTown(caravan);
                    if (target != null)
                    {
                        caravan.SetMoveGoToSettlement(target, (MobileParty.NavigationType)0, false);
                    }
                }
            }
            else
            {
                // ON THE ROAD
                if (caravan.TargetSettlement == null && caravan.ShortTermTargetSettlement == null)
                {
                     // Idle/Stuck? Go Home
                     caravan.SetMoveGoToSettlement(ludus.Settlement, (MobileParty.NavigationType)0, false);
                     return;
                }

                if (caravan.CurrentSettlement != null && caravan.CurrentSettlement != ludus.Settlement)
                {
                    // ARRIVED AT TARGET
                    if (needsFood)
                    {
                        BuyFood(caravan);
                    }
                    else
                    {
                        SellLoot(caravan);
                    }
                    // Return Home
                    caravan.SetMoveGoToSettlement(ludus.Settlement, (MobileParty.NavigationType)0, false);
                }
                // Else: Moving
            }
        }

        private void TransferGoods(MobileParty caravan, LudusLocation ludus, bool dumpingFood)
        {
            if (dumpingFood)
            {
                // Dump Grain, Meat, etc
                // Implementation: Iterate Roster and move ItemCategory.Food to Ludus.Storage
                for (int i = 0; i < caravan.ItemRoster.Count; i++)
                {
                    var element = caravan.ItemRoster[i];
                    if (element.EquipmentElement.Item.IsFood)
                    {
                        ludus.Storage.AddToCounts(element.EquipmentElement, element.Amount);
                        caravan.ItemRoster.AddToCounts(element.EquipmentElement, -element.Amount);
                    }
                }
            }
            else
            {
                // Load Loot (High Tier items) from Ludus to Caravan
                // Simplified: Grab everything that isn't food
               for (int i = 0; i < ludus.Storage.Count; i++)
                {
                    var element = ludus.Storage[i];
                    if (!element.EquipmentElement.Item.IsFood && element.EquipmentElement.Item.Tier >= ItemObject.ItemTiers.Tier3)
                    {
                         // Capacity Check?
                         caravan.ItemRoster.AddToCounts(element.EquipmentElement, element.Amount);
                         ludus.Storage.AddToCounts(element.EquipmentElement, -element.Amount);
                    }
                }
            }
        }

        private void BuyFood(MobileParty caravan)
        {
            if (caravan.CurrentSettlement?.Town == null) return;
            
            // Simplified: Just buy 500 Grain
            int quantity = 500;
            int price = caravan.CurrentSettlement.Town.MarketData.GetPrice(DefaultItems.Grain);
            int cost = price * quantity;

             // Ensure Clan has gold? For now, free magic trade or assume debt?
             // Let's deduct from Clan Owner
             if (caravan.Party?.Owner?.Clan != null)
             {
                 if (caravan.Party.Owner.Clan.Leader.Gold >= cost)
                 {
                     caravan.Party.Owner.Clan.Leader.ChangeHeroGold(-cost);
                     caravan.ItemRoster.AddToCounts(DefaultItems.Grain, quantity);
                 }
             }
        }

        private void SellLoot(MobileParty caravan)
        {
             if (caravan.CurrentSettlement?.Town == null) return;

             // Sell everything non-food
             int revenue = 0;
             for (int i = 0; i < caravan.ItemRoster.Count; i++)
             {
                 var element = caravan.ItemRoster[i];
                 if (!element.EquipmentElement.Item.IsFood)
                 {
                     int price = caravan.CurrentSettlement.Town.MarketData.GetPrice(element.EquipmentElement.Item);
                     revenue += price * element.Amount;
                     // Remove
                     caravan.ItemRoster.AddToCounts(element.EquipmentElement, -element.Amount);
                 }
             }

             if (revenue > 0 && caravan.Party?.Owner?.Clan != null)
             {
                 caravan.Party.Owner.Clan.Leader.ChangeHeroGold(revenue);
             }
        }

        private Settlement FindNearestTownWithFood(MobileParty caravan)
        {
            return Settlement.FindFirst(s => s.IsTown && s.Town.FoodStocks > 200 && s != caravan.CurrentSettlement);
        }

        private Settlement FindRichTown(MobileParty caravan)
        {
             return Settlement.FindFirst(s => s.IsTown && s.Town.Gold > 50000 && s != caravan.CurrentSettlement);
        }
    }
}
