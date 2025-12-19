using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using NavalDLC;

namespace CoastalLife
{
    public class PortEconomyBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<PortEconomyBehavior> _logger;
        private readonly GlobalSettings _settings;
        private List<string> _ownedDockingSlips = new List<string>();

        // Singleton for static access helper
        public static PortEconomyBehavior Instance { get; private set; }

        public PortEconomyBehavior(ILogger<PortEconomyBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
            Instance = this;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("_ownedDockingSlips", ref _ownedDockingSlips);
        }

        public static bool HasDockingSlip(Settlement settlement)
        {
            if (settlement == null) return false;
            return Instance != null && Instance._ownedDockingSlips.Contains(settlement.StringId);
        }

        private void OnSessionLaunched(CampaignGameStarter campaignStarter)
        {
            if (_ownedDockingSlips == null) 
                _ownedDockingSlips = new List<string>();

            // Changed from "town" to "town_port"
            campaignStarter.AddGameMenuOption("town_port", "buy_docking_slip", "Buy Docking Slip ({GOLD_COST}{GOLD_ICON})",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Trade;
                    
                    if (Settlement.CurrentSettlement == null || !Settlement.CurrentSettlement.IsTown) return false;

                    var shipyard = NavalDLCExtensions.GetShipyard(Settlement.CurrentSettlement.Town);
                    if (shipyard == null) return false;

                    if (_ownedDockingSlips.Contains(Settlement.CurrentSettlement.StringId)) return false;

                    MBTextManager.SetTextVariable("GOLD_COST", _settings.SlipCost);
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    // Safety check to prevent double-buying if UI didn't refresh
                    if (_ownedDockingSlips.Contains(Settlement.CurrentSettlement.StringId))
                    {
                        GameMenu.SwitchToMenu("town_port");
                        return;
                    }

                    if (Hero.MainHero.Gold >= _settings.SlipCost)
                    {
                        GiveGoldAction.ApplyBetweenCharacters(Hero.MainHero, null, _settings.SlipCost, true);
                        _ownedDockingSlips.Add(Settlement.CurrentSettlement.StringId);
                        InformationManager.DisplayMessage(new InformationMessage("Docking Slip Purchased! 25% Shipyard Discount Unlocked."));
                        _logger.LogInformation($"PortEconomy: Purchased docking slip at {Settlement.CurrentSettlement.Name}");
                        
                        // Force refresh of the town menu to hide the button
                        GameMenu.SwitchToMenu("town_port");
                    }
                    else
                    {
                        InformationManager.DisplayMessage(new InformationMessage("Not enough gold!"));
                    }
                }, false, -1, false);
                
            campaignStarter.AddGameMenuOption("town_port", "manage_docking_slip", "Manage Docking Slip",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Manage;
                    return Settlement.CurrentSettlement != null && _ownedDockingSlips.Contains(Settlement.CurrentSettlement.StringId);
                },
                (MenuCallbackArgs args) =>
                {
                    InformationManager.DisplayMessage(new InformationMessage("Your docking slip is generating income based on town prosperity."));
                }, false, -1, false);
        }

        private void OnHourlyTick()
        {
            if (CampaignTime.Now.CurrentHourInDay != 18) return;
            _logger.LogDebug("PortEconomy: Starting Daily Tick");
            foreach (var s in Settlement.All) 
            {
                 try { OnDailySettlementTick(s); }
                 catch (Exception sEx) { _logger.LogError($"Error processing settlement {s?.Name}: {sEx.Message}"); }
            }
            _logger.LogDebug("PortEconomy: Daily Tick Complete");
        }

        private void OnDailySettlementTick(Settlement settlement)
        {
            if (settlement != null && settlement.IsTown && _ownedDockingSlips.Contains(settlement.StringId))
            {
                if (settlement.Town == null) return;
                
                float prosperity = settlement.Town.Prosperity;
                int income = (int)(prosperity * _settings.DockingSlipIncomePercentage);
                
                GiveGoldAction.ApplyBetweenCharacters(null, Hero.MainHero, income, false);
                InformationManager.DisplayMessage(new InformationMessage($"Docking Slip in {settlement.Name} yielded {income} gold."));
                _logger.LogInformation($"PortEconomy: Income {income} from {settlement.Name}");
            }
        }
    }
}
