using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using Serilog;

namespace HonestWork
{
    public class VillageLaborBehavior : CampaignBehaviorBase
    {
        private readonly ILogger _logger;
        private readonly GlobalSettings _settings;

        private CampaignTime _startTime;
        private int _hoursWorked;
        private int _totalContinuousHours;

        public VillageLaborBehavior(ILogger logger, GlobalSettings settings)
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
            _logger.Information("VillageLaborBehavior: Initializing Menus...");
            AddGameMenus(campaignStarter);
            _logger.Information("VillageLaborBehavior: Menus Initialized.");
        }

        private void AddGameMenus(CampaignGameStarter campaignStarter)
        {
            campaignStarter.AddGameMenuOption("village", "village_work", "Work in the fields (Wait)",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Wait;
                    return !Hero.MainHero.MapFaction.IsAtWarWith(Settlement.CurrentSettlement.MapFaction);
                },
                (MenuCallbackArgs args) =>
                {
                    _startTime = CampaignTime.Now;
                    _hoursWorked = 0;
                    _totalContinuousHours = 0;
                    GameMenu.SwitchToMenu("village_work_wait");
                }, false, -1, false);

            campaignStarter.AddWaitGameMenu("village_work_wait", "You help the locals with the harvest...",
                (MenuCallbackArgs args) => 
                {
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
                        _totalContinuousHours++;
                        GiveHourlyReward();
                        
                        // Bonus every Shift Length
                        if (_hoursWorked % _settings.ShiftHours == 0)
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
            
             campaignStarter.AddGameMenuOption("village_work_wait", "village_work_wait_leave", "Stop Working",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Leave;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    GameMenu.SwitchToMenu("village");
                }, true, -1, false);
        }

        private void GiveHourlyReward()
        {
            if (Settlement.CurrentSettlement != null && Hero.MainHero.PartyBelongedTo != null)
            {
                float hearths = 0f;
                // Use Reflection to get Hearth to be safe
                var hearthProp = typeof(Village).GetProperty("Hearth");
                if (hearthProp != null)
                {
                    hearths = (float)hearthProp.GetValue(Settlement.CurrentSettlement.Village);
                }
                
                int goldAmount = (int)Math.Ceiling(hearths / _settings.VillageHearthWageDivisor);
                if (goldAmount < 1) goldAmount = 1;

                // Step 1: Give the village its share (equal to player wage) to simulate value added
                try
                {
                    if (Settlement.CurrentSettlement != null && Settlement.CurrentSettlement.Village != null)
                    {
                        var changeGoldMethod = typeof(Village).GetMethod("ChangeGold") ?? typeof(SettlementComponent).GetMethod("ChangeGold");
                        if (changeGoldMethod != null)
                        {
                            // Add wage * 2 to village (One share for them, one share to be transferred to player)
                            changeGoldMethod.Invoke(Settlement.CurrentSettlement.Village, new object[] { goldAmount * 2 });
                        }
                    }
                }
                catch {}

                GiveGoldAction.ApplyForSettlementToParty(Settlement.CurrentSettlement, Hero.MainHero.PartyBelongedTo.Party, goldAmount, false);
            }
            
            // XP: Buff Athletics gain to Base + Streak * Multiplier
            float xpMultiplier = 1.0f + (_totalContinuousHours * _settings.XpStreakMultiplier);
            int xpAmount = (int)(_settings.VillageBaseXp * xpMultiplier);
            Hero.MainHero.AddSkillXp(DefaultSkills.Athletics, xpAmount);
            InformationManager.DisplayMessage(new InformationMessage($"Gained {xpAmount} Athletics XP."));

            // Hearth Increase: 
            try
            {
                if (Settlement.CurrentSettlement?.Village != null)
                {
                   var hearthProp = typeof(Village).GetProperty("Hearth");
                   if (hearthProp != null)
                   {
                       float current = (float)hearthProp.GetValue(Settlement.CurrentSettlement.Village);
                       hearthProp.SetValue(Settlement.CurrentSettlement.Village, current + _settings.VillageHearthGain);
                   }
                }
            }
            catch(Exception ex) 
            {
                _logger.Error(ex, "VillageLabor: Error updating hearths");
            }
        }

        private void GiveShiftReward()
        {
            var settlement = Settlement.CurrentSettlement;
            if (settlement != null && settlement.Village != null)
            {
                // Production: Add 5 Units of the village's primary production to the Village Market.
                if (settlement.Village.VillageType.PrimaryProduction != null)
                {
                    // Village Market is essentially the Settlement ItemRoster
                    settlement.ItemRoster.AddToCounts(settlement.Village.VillageType.PrimaryProduction, 5);
                }

                // Reward: Pick a random item from the Village Market and give it to the Player.
                if (settlement.ItemRoster.Count > 0)
                {
                     var randomItem = settlement.ItemRoster.GetRandomElement();
                     if (randomItem.EquipmentElement.Item != null)
                     {
                         Hero.MainHero.PartyBelongedTo.ItemRoster.AddToCounts(randomItem.EquipmentElement.Item, 1);
                         settlement.ItemRoster.AddToCounts(randomItem.EquipmentElement.Item, -1);
                         
                         InformationManager.DisplayMessage(new InformationMessage($"Received 1 {randomItem.EquipmentElement.Item.Name}"));
                     }
                }

                if (settlement.Notables.Count > 0)
                {
                    Hero notable = settlement.Notables.GetRandomElement();
                    ChangeRelationAction.ApplyRelationChangeBetweenHeroes(Hero.MainHero, notable, 1, true);
                    InformationManager.DisplayMessage(new InformationMessage($"Relationship increased with {notable.Name}"));
                }
            }

            GainRenownAction.Apply(Hero.MainHero, 0.5f, false);
            InformationManager.DisplayMessage(new InformationMessage("Shift complete. You continue your labor..."));
            
            // Loop Logic: RESET the start time and let the player continue waiting.
            _startTime = CampaignTime.Now;
            _hoursWorked = 0;
        }
    }
}
