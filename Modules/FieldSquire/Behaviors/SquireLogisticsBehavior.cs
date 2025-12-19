using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.Core;
using TaleWorlds.Library;
using Microsoft.Extensions.Logging;

namespace FieldSquire.Behaviors
{
    public class SquireLogisticsBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<SquireLogisticsBehavior> _logger;
        private readonly GlobalSettings _settings;

        public SquireLogisticsBehavior(ILogger<SquireLogisticsBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.SettlementEntered.AddNonSerializedListener(this, OnSettlementEntered);
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            // Settings migrated to GlobalSettings (MCM)
        }

        private void OnSettlementEntered(MobileParty party, Settlement settlement, Hero hero)
        {
            if (party == MobileParty.MainParty && settlement != null)
            {
                RunLogistics(settlement);
            }
        }

        private void OnHourlyTick()
        {
            if (MobileParty.MainParty.CurrentSettlement != null)
            {
                RunLogistics(MobileParty.MainParty.CurrentSettlement);
            }
        }

        private void RunLogistics(Settlement settlement)
        {
            // Check if Squire is in party
            // Check if Squire is in party (Optimized check)
            bool hasSquire = Clan.PlayerClan?.Heroes.Any(h => h.StringId == SquireSpawnBehavior.SquireStringId && h.PartyBelongedTo == MobileParty.MainParty) ?? false;
            if (!hasSquire) return;

            if (Hero.MainHero.Gold < 2000) return;

            // Access Global Settings
            int foodThreshold = _settings?.FoodThreshold ?? 20;

            int totalCost = 0;
            Dictionary<string, int> boughtItems = new Dictionary<string, int>();

            ItemRoster settlementRoster = settlement.ItemRoster;
            if (settlementRoster == null) return;

            // Iterate through every item in the settlement market
            for (int i = settlementRoster.Count - 1; i >= 0; i--)
            {
                if (Hero.MainHero.Gold - totalCost < 2000) break;

                var element = settlementRoster.GetElementCopyAtIndex(i);
                var item = element.EquipmentElement.Item;
                
                // We only care about food
                if (item != null && item.IsFood)
                {
                    // Check how many we already have of this SPECIFIC item
                    int currentCount = MobileParty.MainParty.ItemRoster.GetItemNumber(item);
                    
                    // If we have less than the threshold for THIS item, try to buy more
                    if (currentCount < foodThreshold)
                    {
                        int needed = foodThreshold - currentCount;
                        int canBuy = element.Amount; // How many the settlement has
                        
                        int toBuy = Math.Min(canBuy, needed);
                        
                        // Price calculation
                        int price = item.Value;
                        if (settlement.Town != null)
                            price = settlement.Town.GetItemPrice(item, MobileParty.MainParty, true);
                        else if (settlement.Village != null)
                            price = settlement.Village.GetItemPrice(item, MobileParty.MainParty, true);

                        // Affordability Check
                        int maxAffordable = (Hero.MainHero.Gold - totalCost - 2000) / price;
                        toBuy = Math.Min(toBuy, maxAffordable);

                        if (toBuy > 0)
                        {
                            // Transfer items
                            MobileParty.MainParty.ItemRoster.AddToCounts(item, toBuy);
                            settlementRoster.AddToCounts(item, -toBuy);
                            
                            totalCost += price * toBuy;

                            string itemName = item.Name.ToString();
                            if (boughtItems.ContainsKey(itemName))
                                boughtItems[itemName] += toBuy;
                            else
                                boughtItems[itemName] = toBuy;
                        }
                    }
                }
            }

            if (totalCost > 0)
            {
                GiveGoldAction.ApplyBetweenCharacters(Hero.MainHero, null, totalCost, true); 
                
                string itemsStr = string.Join(", ", boughtItems.Select(x => $"{x.Value} {x.Key}"));
                string msg = $"Squire bought: {itemsStr} (-{totalCost} Gold).";
                InformationManager.DisplayMessage(new InformationMessage(msg));
                _logger.LogInformation($"RunLogistics: {msg}");
            }
        }
    }
}
