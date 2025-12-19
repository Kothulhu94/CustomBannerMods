using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Localization;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using NavalDLC; 
using NavalDLC.CharacterDevelopment;

namespace CoastalLife
{
    public class CoastalJobBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<CoastalJobBehavior> _logger;
        private readonly GlobalSettings _settings;
        
        private CampaignTime _startTime;
        private int _hoursWorked;
        private string _currentJob;

        public CoastalJobBehavior(ILogger<CoastalJobBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSessionLaunched(CampaignGameStarter campaignStarter)
        {
            _logger.LogDebug("CoastalLifeSubModule.OnSessionLaunched: Initializing Behaviors...");
            AddGameMenus(campaignStarter);
            _logger.LogDebug("CoastalLifeSubModule.OnSessionLaunched: Game Menus Added.");
        }

        private void AddGameMenus(CampaignGameStarter campaignStarter)
        {

            campaignStarter.AddGameMenu("coastal_jobs_menu", "The docks are bustling with activity. What kind of work are you looking for?",
                (MenuCallbackArgs args) => { },
                GameMenu.MenuOverlayType.None);

            campaignStarter.AddGameMenuOption("port_menu", "coastal_find_sea_work", "Find Sea Work",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Submenu;
                    var shipyard = NavalDLCExtensions.GetShipyard(Settlement.CurrentSettlement.Town);
                    if (shipyard == null) return false;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    GameMenu.SwitchToMenu("coastal_jobs_menu");
                }, false, -1, false);

            campaignStarter.AddGameMenuOption("coastal_jobs_menu", "port_work_deckhand", "Work as a Deckhand (Wait)",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Wait;
                    var shipyard = NavalDLCExtensions.GetShipyard(Settlement.CurrentSettlement.Town);
                    if (shipyard == null) return false;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    _currentJob = "Deckhand";
                    GameMenu.SwitchToMenu("port_work_wait");
                }, false, -1, false);

            campaignStarter.AddGameMenuOption("coastal_jobs_menu", "port_work_shipwright", "Work as a Shipwright (Wait)",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Wait;
                    var shipyard = NavalDLCExtensions.GetShipyard(Settlement.CurrentSettlement.Town);
                    if (shipyard == null) return false;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    _currentJob = "Shipwright";
                    GameMenu.SwitchToMenu("port_work_wait");
                }, false, -1, false);

            campaignStarter.AddGameMenuOption("coastal_jobs_menu", "port_work_harbormaster", "Assistant Harbor Master (Wait)",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Wait;
                    var shipyard = NavalDLCExtensions.GetShipyard(Settlement.CurrentSettlement.Town);
                    if (shipyard == null) return false;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    _currentJob = "HarborMaster";
                    GameMenu.SwitchToMenu("port_work_wait");
                }, false, -1, false);

            campaignStarter.AddGameMenuOption("coastal_jobs_menu", "coastal_jobs_back", "Back",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Leave;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    GameMenu.SwitchToMenu("port_menu");
                }, true, -1, false);


            campaignStarter.AddWaitGameMenu("port_work_wait", "You are working at the docks...",
                (MenuCallbackArgs args) => 
                {
                    _startTime = CampaignTime.Now;
                    _hoursWorked = 0;
                },
                (MenuCallbackArgs args) => 
                {
                    return true;
                },
                (MenuCallbackArgs args) => 
                {
                },
                (MenuCallbackArgs args, CampaignTime dt) => 
                {
                    double elapsedHours = _startTime.ElapsedHoursUntilNow;

                    if ((int)elapsedHours > _hoursWorked)
                    {
                        _hoursWorked++;
                        GiveHourlyReward();
                        
                        if (_hoursWorked % 8 == 0)
                        {
                            GiveShiftReward();
                        }
                    }
                },
                GameMenu.MenuAndOptionType.WaitMenuShowOnlyProgressOption,
                GameMenu.MenuOverlayType.SettlementWithBoth,
                0f,
                GameMenu.MenuFlags.None,
                null
            );
            
             campaignStarter.AddGameMenuOption("port_work_wait", "port_work_wait_leave", "Stop Working",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Leave;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    GameMenu.SwitchToMenu("town");
                }, true, -1, false);
        }

        private void GiveHourlyReward()
        {
            if (Settlement.CurrentSettlement == null) return;

            int goldAmount = 0;
            SkillObject skillToReward = null;
            int xpAmount = 0;

            float prosperity = Settlement.CurrentSettlement.Town.Prosperity;
            int baseWage = (int)(prosperity / 500f); 
            if (baseWage < 1) baseWage = 1;

            switch (_currentJob)
            {
                case "Deckhand":
                    goldAmount = baseWage;
                    skillToReward = NavalSkills.Mariner;
                    xpAmount = 10;
                    break;
                case "Shipwright":
                    goldAmount = (int)(baseWage * 1.5f);
                    skillToReward = NavalSkills.Boatswain;
                    xpAmount = 10;
                    break;
                case "HarborMaster":
                    goldAmount = baseWage * 2;
                    skillToReward = NavalSkills.Shipmaster;
                    xpAmount = 10;
                    break;
            }

            GiveGoldAction.ApplyForSettlementToParty(Settlement.CurrentSettlement, Hero.MainHero.PartyBelongedTo.Party, goldAmount, false);
            _logger.LogDebug($"CoastalJob: Paid {goldAmount} gold for {_currentJob} work.");
            
            if (skillToReward != null)
            {
                Hero.MainHero.AddSkillXp(skillToReward, xpAmount);
            }
        }

        private void GiveShiftReward()
        {
            InformationManager.DisplayMessage(new InformationMessage("Shift complete. The sea air fills your lungs."));
            GainRenownAction.Apply(Hero.MainHero, 0.5f, false);
            _logger.LogDebug("CoastalJob: Shift complete. Renown awarded.");
        }
    }
}
