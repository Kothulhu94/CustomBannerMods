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
using TaleWorlds.CampaignSystem.Party;

namespace HonestWork
{
    public class CastleJobBehavior : CampaignBehaviorBase
    {
        private readonly ILogger _logger;
        private readonly GlobalSettings _settings;

        private CampaignTime _startTime;
        private int _hoursWorked;
        private int _totalContinuousHours;

        public CastleJobBehavior(ILogger logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("_castle_hoursWorked", ref _hoursWorked);
            dataStore.SyncData("_castle_totalContinuousHours", ref _totalContinuousHours);
            dataStore.SyncData("_castle_startTime", ref _startTime);
        }

        private void OnSessionLaunched(CampaignGameStarter campaignStarter)
        {
            try
            {
                AddGameMenus(campaignStarter);
                _logger.Information("HonestWork: Castle Menus Initialized.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "HonestWork: Error initializing Castle Menus");
            }
        }

        private void OnHourlyTick()
        {
             if (!_settings.EnableAiCastles) return;

             foreach (var settlement in Settlement.All)
             {
                 if (settlement.IsCastle)
                 {
                     ProcessAIHourlyWork(settlement);
                 }
             }

             
             CheckForSiegeInterrupt();
        }

        private void CheckForSiegeInterrupt()
        {
            if (_startTime == CampaignTime.Zero || Hero.MainHero.CurrentSettlement == null) return;
            
            string menuId = Campaign.Current.CurrentMenuContext?.GameMenu?.StringId;
            if (menuId != "castle_work_wait") return;

            var settlement = Hero.MainHero.CurrentSettlement;
            if (settlement.SiegeEvent != null)
            {
                 // Siege Detected while working!
                 _hoursWorked = 0;
                 _startTime = CampaignTime.Now;
                 _totalContinuousHours = 0;
                 
                 InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_workcancelledth}Work cancelled! The settlement is under siege!").ToString(), TaleWorlds.Library.Color.FromUint(0xFF0000)));
                 GameMenu.SwitchToMenu("castle");
            }
        }
        
        private void ProcessAIHourlyWork(Settlement settlement)
        {
            if (settlement.Town == null) return; // Castles have Town components
            
            if (settlement.SiegeEvent != null) return; 

            System.Collections.Generic.List<Hero> workers = new System.Collections.Generic.List<Hero>();

            if (settlement.HeroesWithoutParty != null)
            {
                foreach(var hero in settlement.HeroesWithoutParty)
                {
                    if (hero.IsLord && hero.IsAlive && hero.Clan != Clan.PlayerClan)
                        workers.Add(hero);
                }
            }

            if (settlement.Parties != null)
            {
                foreach(var party in settlement.Parties)
                {
                    if (party.LeaderHero != null && party.LeaderHero.Clan != Clan.PlayerClan)
                        workers.Add(party.LeaderHero);
                }
            }
            
            foreach(var worker in workers)
            {
                if (MBRandom.RandomFloat < 0.3f)
                {
                    int wage = 25 + (int)(settlement.Town.Prosperity / 100f);
                    GiveGoldAction.ApplyBetweenCharacters(null, worker, wage);

                    settlement.Town.Security += 0.5f;
                    settlement.Town.Loyalty += 0.2f;

                    if (settlement.Town.GarrisonParty != null)
                    {
                        var garrison = settlement.Town.GarrisonParty;
                        int garrisonXp = (int)(15 * _settings.TroopXpMultiplier);
                        
                        if (garrisonXp > 0)
                        {
                            for(int i=0; i< garrison.MemberRoster.Count; i++)
                            {
                                var element = garrison.MemberRoster.GetElementCopyAtIndex(i);
                                if (!element.Character.IsHero)
                                {
                                    garrison.MemberRoster.AddXpToTroop(element.Character, garrisonXp);
                                }
                            }
                        }
                    }
                    
                    if (worker.PartyBelongedTo != null)
                    {
                        HonestWorkHelpers.GiveRandomPartyXp(worker.PartyBelongedTo, 50, 100, 200);
                    }

                    if ((long)CampaignTime.Now.ToHours % _settings.ShiftHours == (_settings.ShiftHours - 1))
                    {
                        ApplyCastleShiftRewards(settlement, worker);
                    }
                }
            }
        }
        
        private void ApplyCastleShiftRewards(Settlement settlement, Hero worker)
        {
            try
            {
                if (settlement.MilitiaPartyComponent != null && settlement.MilitiaPartyComponent.MobileParty != null)
                {
                    var roster = settlement.MilitiaPartyComponent.MobileParty.MemberRoster;
                    int upgradesPerformed = 0;
                    
                    for (int i = 0; i < roster.Count; i++)
                    {
                        if (upgradesPerformed >= 5) break;

                        var element = roster.GetElementCopyAtIndex(i);
                        if (element.Character.UpgradeTargets != null && element.Character.UpgradeTargets.Length > 0)
                        {
                            if (element.Character.Tier <= 2) 
                            {
                                var target = element.Character.UpgradeTargets[0];
                                roster.AddToCounts(element.Character, -1);
                                roster.AddToCounts(target, 1);
                                upgradesPerformed++;
                            }
                        }
                    }
                    if (upgradesPerformed > 0 && worker == Hero.MainHero)
                        InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_drillresultsupg}}Drill Results: {upgradesPerformed} Militia promoted to veterans.").ToString()));
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "HonestWork: Error during Militia Upgrade reward.");
            }

            if (settlement.Culture != null && settlement.Culture.RangedEliteMilitiaTroop != null)
            {
                var troopToAdd = settlement.Culture.RangedEliteMilitiaTroop; 
                if (settlement.Town.GarrisonParty != null)
                {
                    settlement.Town.GarrisonParty.MemberRoster.AddToCounts(troopToAdd, 1);
                    if (worker == Hero.MainHero)
                        InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_recruitment1tro}}Recruitment: 1 {troopToAdd.Name} joined the garrison.").ToString()));
                }
            }

            var notable = settlement.Town.Governor;
            if (notable == null) notable = settlement.OwnerClan?.Leader;
            
            if (notable != null && notable != worker)
            {
                ChangeRelationAction.ApplyRelationChangeBetweenHeroes(worker, notable, 2, true);
            }

            settlement.Town.Security += 2.0f;
        }

        private void AddGameMenus(CampaignGameStarter campaignStarter)
        {
            // Add "Castle Service" button to the main Castle menu
            campaignStarter.AddGameMenuOption("castle", "castle_work", "{=lw_servethegarriso}Serve the Garrison (Wait)",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Wait;
                    
                    // Only available if not at war with the settlement owner
                    bool isEnemy = Hero.MainHero.MapFaction.IsAtWarWith(Settlement.CurrentSettlement.MapFaction);
                    if (isEnemy || MobileParty.MainParty.Army != null) return false;

                    args.Tooltip = new TextObject("Drill troops, inspect defenses, and organize patrols. (Leadership, Engineering, Combat XP)");
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    _startTime = CampaignTime.Now;
                    _hoursWorked = 0;
                    _totalContinuousHours = 0;
                    GameMenu.SwitchToMenu("castle_work_wait");
                }, false, 4, false);

            // The Wait Menu
            campaignStarter.AddWaitGameMenu("castle_work_wait", "You are drilling the garrison and inspecting the walls...",
                (MenuCallbackArgs args) => { },
                (MenuCallbackArgs args) => { return true; },
                (MenuCallbackArgs args) => { },
                (MenuCallbackArgs args, CampaignTime dt) =>
                {
                    double elapsedHours = _startTime.ElapsedHoursUntilNow;
                    if ((int)elapsedHours > _hoursWorked)
                    {
                        _hoursWorked++;
                        _totalContinuousHours++;
                        
                        GiveHourlyReward();

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

            // Leave Option
            campaignStarter.AddGameMenuOption("castle_work_wait", "castle_work_wait_leave", "{=lw_stopservice}Stop Service",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Leave;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    GameMenu.SwitchToMenu("castle");
                }, true, -1, false);
        }

        private void GiveHourlyReward()
        {
            var settlement = Settlement.CurrentSettlement;
            if (settlement == null || !settlement.IsCastle) return;

            float companionBonus = 0f;
            if (Hero.MainHero.PartyBelongedTo != null)
            {
                foreach (var element in Hero.MainHero.PartyBelongedTo.MemberRoster.GetTroopRoster())
                {
                    if (element.Character.IsHero && element.Character.HeroObject != Hero.MainHero && !element.Character.HeroObject.IsWounded)
                    {
                        var comp = element.Character.HeroObject;
                        float contribution = CalculateCompanionCastleContribution(comp);
                        
                        var skills = new[] { DefaultSkills.Leadership, DefaultSkills.Engineering, DefaultSkills.Steward, DefaultSkills.OneHanded, DefaultSkills.Bow };
                        var skill = skills[MBRandom.RandomInt(skills.Length)];
                        comp.AddSkillXp(skill, 20 * (1.0f + contribution)); 

                        companionBonus += contribution;
                    }
                }
            }

            if (Hero.MainHero.PartyBelongedTo != null)
            {
                 HonestWorkHelpers.GiveRandomPartyXp(Hero.MainHero.PartyBelongedTo, 50, 100, 200); 
            }

            int wage = 25 + (int)(settlement.Town.Prosperity / 100f);
            wage = (int)(wage * (1.0f + companionBonus));
            
            GiveGoldAction.ApplyForSettlementToCharacter(settlement, Hero.MainHero, wage, false);

            int interval = _settings.XpIncreaseInterval > 0 ? _settings.XpIncreaseInterval : 4;
            int steps = Math.Max(0, _totalContinuousHours - 1) / interval;
            float xpMult = 1.0f + (steps * _settings.XpStepMultiplier);
            xpMult += companionBonus; 
            
            int cycle = _totalContinuousHours % 4;
            if (cycle == 0) Hero.MainHero.AddSkillXp(DefaultSkills.Leadership, 40 * xpMult);
            else if (cycle == 1) Hero.MainHero.AddSkillXp(DefaultSkills.Engineering, 40 * xpMult);
            else if (cycle == 2) Hero.MainHero.AddSkillXp(DefaultSkills.Steward, 40 * xpMult);
            else 
            {
                Hero.MainHero.AddSkillXp(DefaultSkills.Bow, 30 * xpMult);
                Hero.MainHero.AddSkillXp(DefaultSkills.OneHanded, 30 * xpMult);
            }

            if (settlement.Town != null)
            {
                float secGain = 0.5f * (1.0f + companionBonus);
                float loyGain = 0.2f * (1.0f + companionBonus);
                
                settlement.Town.Security += secGain;
                settlement.Town.Loyalty += loyGain;

                if (settlement.Town.GarrisonParty != null)
                {
                    var garrison = settlement.Town.GarrisonParty;
                    int garrisonXp = (int)(15 * (1.0f + companionBonus) * _settings.TroopXpMultiplier);
                    
                    if (garrisonXp > 0)
                    {
                        for(int i=0; i< garrison.MemberRoster.Count; i++)
                        {
                            var element = garrison.MemberRoster.GetElementCopyAtIndex(i);
                            if (!element.Character.IsHero)
                            {
                                garrison.MemberRoster.AddXpToTroop(element.Character, garrisonXp);
                            }
                        }
                    }
                }

                if (settlement.OwnerClan == Clan.PlayerClan && settlement.Town.Governor == null)
                {
                    settlement.Town.Governor = Hero.MainHero;
                }
            }
        }

        private float CalculateCompanionCastleContribution(Hero hero)
        {
            float score = 0f;
            score += hero.GetSkillValue(DefaultSkills.Leadership);
            score += hero.GetSkillValue(DefaultSkills.Engineering);
            score += hero.GetSkillValue(DefaultSkills.Steward);
            score += hero.GetSkillValue(DefaultSkills.OneHanded);
            
            return score * 0.0005f;
        }

        private void GiveShiftReward()
        {
            var settlement = Settlement.CurrentSettlement;
            if (settlement == null || settlement.Town == null) return;

            _logger.Information($"Castle Shift Complete at {settlement.Name}");
            if (Hero.MainHero != null) InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_shiftcompletega}Shift Complete: Garrison Drills Finished.").ToString()));

            ApplyCastleShiftRewards(settlement, Hero.MainHero);

            // Reset loop
            _startTime = CampaignTime.Now;
            _hoursWorked = 0;
        }
    }
}
