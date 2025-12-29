using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using Serilog;

namespace HappyParty
{
    public class GourmetArmyBehavior : CampaignBehaviorBase
    {
        private readonly GlobalSettings _settings;
        private readonly ILogger _logger;

        public GourmetArmyBehavior(GlobalSettings settings, ILogger logger)
        {
            _settings = settings;
            _logger = logger.ForContext<GourmetArmyBehavior>();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.SettlementEntered.AddNonSerializedListener(this, OnSettlementEntered);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSettlementEntered(MobileParty mobileParty, Settlement settlement, Hero hero)
        {
            try
            {
                if (mobileParty == null || mobileParty.IsMainParty || !mobileParty.IsLordParty)
                {
                    return;
                }

                if (settlement.ItemRoster == null)
                {
                    return;
                }

                var roasterCopy = settlement.ItemRoster.ToList();

                foreach (var itemRosterElement in roasterCopy)
                {
                    var item = itemRosterElement.EquipmentElement.Item;

                    if (item != null && item.IsFood)
                    {
                        int totalTroops = mobileParty.MemberRoster.TotalManCount;
                        int divisor = _settings.TroopsPerFoodItem;
                        if (divisor < 1) divisor = 1;
                        
                        int targetAmount = totalTroops / divisor;
                        
                        if (targetAmount < 1) targetAmount = 1;

                        int currentHeld = mobileParty.ItemRoster.GetItemNumber(item);
                        int buyAmount = targetAmount - currentHeld;

                        if (buyAmount > 0)
                        {
                            int availableInSettlement = itemRosterElement.Amount;
                            int actualBuyAmount = Math.Min(buyAmount, availableInSettlement);

                            if (actualBuyAmount > 0)
                            {
                                int price = settlement.Town != null ? settlement.Town.GetItemPrice(item) : item.Value;
                                int totalCost = price * actualBuyAmount;

                                if (mobileParty.LeaderHero != null && mobileParty.LeaderHero.Gold >= totalCost)
                                {
                                    GiveGoldAction.ApplyBetweenCharacters(mobileParty.LeaderHero, null, totalCost, true);
                                    mobileParty.ItemRoster.AddToCounts(item, actualBuyAmount);
                                    
                                    // CRITICAL FIX: Remote items from Settlement to prevent inflation
                                    if (settlement.ItemRoster != null)
                                    {
                                        settlement.ItemRoster.AddToCounts(item, -actualBuyAmount);
                                    }

                                    if (_settings.DebugMode)
                                    {
                                        _logger.Information($"{mobileParty.Name} bought {actualBuyAmount}x {item.Name} in {settlement.Name} for {totalCost} gold.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error in GourmetArmyBehavior.OnSettlementEntered");
            }
        }
    }
}
