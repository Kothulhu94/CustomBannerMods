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
            if (_settings != null && _settings.DebugMode)
            {
                _logger.LogInformation($"RunLogistics: Checking at {settlement.Name}");
            }

            // Check if Squire is in party (Optimized check with fallback)
            var squireObj = Clan.PlayerClan?.Heroes.FirstOrDefault(h => 
                (h.StringId == SquireSpawnBehavior.SquireStringId || (h.Name != null && h.Name.ToString().Contains("Squire"))) 
                && h.PartyBelongedTo == MobileParty.MainParty);

            bool hasSquire = squireObj != null;

            if (_settings != null && _settings.DebugMode && !hasSquire)
            {
                _logger.LogInformation($"RunLogistics: Squire not found in party. (Clan Heroes: {Clan.PlayerClan?.Heroes.Count})");
            }

            if (!hasSquire) return;

            if (Hero.MainHero.Gold < 2000)
            {
                if (_settings.DebugMode) _logger.LogInformation("RunLogistics: Insufficient gold (below 2000 cushion).");
                return;
            }

            // Access Global Settings
            int foodThreshold = _settings?.FoodThreshold ?? 20;

            int totalCost = 0;
            float totalTradeXp = 0f;
            Dictionary<string, int> boughtItems = new Dictionary<string, int>();

            ItemRoster settlementRoster = settlement.ItemRoster;
            if (settlementRoster == null) return;

            // Get Squire's Trade skill for pricing calculation
            int squireTradeSkill = squireObj.GetSkillValue(DefaultSkills.Trade);
            // 0.2% penalty reduction per skill point, max 60% (300 skill)
            float tradePenaltyReduction = Math.Min(0.6f, squireTradeSkill * 0.002f);

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
                        
                        // Price calculation (using game's base market price)
                        int marketPrice = item.Value;
                        if (settlement.Town != null)
                            marketPrice = settlement.Town.GetItemPrice(item, MobileParty.MainParty, false);
                        else if (settlement.Village != null)
                            marketPrice = settlement.Village.GetItemPrice(item, MobileParty.MainParty, false);

                        // Apply Squire's trade discount to the "penalty" portion of the price
                        // In Bannerlord, buying price is item.Value * penalty_multiplier
                        // We simulate the Squire negotiating a better deal
                        int basePrice = item.Value;
                        int price = marketPrice;
                        
                        if (marketPrice > basePrice)
                        {
                            int penalty = marketPrice - basePrice;
                            price = basePrice + (int)(penalty * (1.0f - tradePenaltyReduction));
                        }

                        // Affordability Check
                        int maxAffordable = (Hero.MainHero.Gold - totalCost - 2000) / price;
                        toBuy = Math.Min(toBuy, maxAffordable);

                        if (toBuy > 0)
                        {
                            // Transfer items
                            MobileParty.MainParty.ItemRoster.AddToCounts(item, toBuy);
                            settlementRoster.AddToCounts(item, -toBuy);
                            
                            int batchCost = price * toBuy;
                            totalCost += batchCost;
                            
                            // Award XP based on the base value of the trade (not just the gold spent)
                            // Standard trade XP is often based on the profit or the transaction value
                            totalTradeXp += (batchCost * 0.1f);

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
                
                // Award Trade XP to the Squire
                if (totalTradeXp > 0f)
                {
                    squireObj.AddSkillXp(DefaultSkills.Trade, totalTradeXp);
                }

                string itemsStr = string.Join(", ", boughtItems.Select(x => $"{x.Value} {x.Key}"));
                string discMsg = squireTradeSkill > 0 ? $" (Trade Level {squireTradeSkill})" : "";
                string msg = $"Squire bought: {itemsStr} (-{totalCost} Gold){discMsg}.";
                InformationManager.DisplayMessage(new InformationMessage(msg));
                _logger.LogInformation($"RunLogistics: {msg} Awarded {totalTradeXp} Trade XP.");
            }
        }
    }
}
