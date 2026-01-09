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
        }
        
        private void ProcessAIHourlyWork(Settlement settlement)
        {
            if (settlement.HeroesWithoutParty == null) return;
            
            // AI Logic: Nobles in Castles drill troops
            foreach(var hero in settlement.HeroesWithoutParty)
            {
                if (hero.IsLord && hero.IsAlive && hero.Clan != Clan.PlayerClan)
                {
                    // Simple check: 20% chance to work per hour if idle
                    if (MBRandom.RandomFloat < 0.2f)
                    {
                        // Give XP to their party (if they had one attached, but HeroesWithoutParty usually don't have mobile party attached directly right here without accessing Parties list... wait.)
                        // Actually, visiting parties are in settlement.Parties.
                    }
                }
            }
            
            // Check Visiting Parties for Nobles
            if (settlement.Parties != null)
            {
                foreach(var party in settlement.Parties)
                {
                    if (party.LeaderHero != null && party.LeaderHero.Clan != Clan.PlayerClan)
                    {
                         // 20% Chance to Drill
                         if (MBRandom.RandomFloat < 0.2f)
                         {
                             // Reward: XP for their party
                             HonestWorkHelpers.GiveRandomPartyXp(party, 50, 100, 200);
                             
                             // Reward: Garrison XP (Small contribution)
                             if (settlement.Town != null && settlement.Town.GarrisonParty != null)
                             {
                                  settlement.Town.GarrisonParty.MemberRoster.AddXpToTroop(settlement.Culture.BasicTroop, 50);
                             }
                         }
                    }
                }
            }
        }

        private void AddGameMenus(CampaignGameStarter campaignStarter)
        {
            // Add "Castle Service" button to the main Castle menu
            campaignStarter.AddGameMenuOption("castle", "castle_work", "Serve the Garrison (Wait)",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Wait;
                    
                    // Only available if not at war with the settlement owner
                    bool isEnemy = Hero.MainHero.MapFaction.IsAtWarWith(Settlement.CurrentSettlement.MapFaction);
                    if (isEnemy) return false;

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
            campaignStarter.AddGameMenuOption("castle_work_wait", "castle_work_wait_leave", "Stop Service",
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

            // Companion Contribution
            float companionBonus = 0f;
            if (Hero.MainHero.PartyBelongedTo != null)
            {
                foreach (var element in Hero.MainHero.PartyBelongedTo.MemberRoster.GetTroopRoster())
                {
                    if (element.Character.IsHero && element.Character.HeroObject != Hero.MainHero && !element.Character.HeroObject.IsWounded)
                    {
                        var comp = element.Character.HeroObject;
                        float contribution = CalculateCompanionCastleContribution(comp);
                        
                        // Grant Companion XP (Rotate like player or split?)
                        // Simpler: Give flat XP to one random relevant skill
                        var skills = new[] { DefaultSkills.Leadership, DefaultSkills.Engineering, DefaultSkills.Steward, DefaultSkills.OneHanded, DefaultSkills.Bow };
                        var skill = skills[MBRandom.RandomInt(skills.Length)];
                        comp.AddSkillXp(skill, 20 * (1.0f + contribution)); // Base 20

                        companionBonus += contribution;
                    }
                }
            }

            // XP for Player's Party troops (Drilling with them)
            if (Hero.MainHero.PartyBelongedTo != null)
            {
                 HonestWorkHelpers.GiveRandomPartyXp(Hero.MainHero.PartyBelongedTo, 50, 100, 200); 
            }

            // 1. Pay the Player
            // Castles: Base + Prosperity. Companions increase efficiency (more gold).
            int wage = 25 + (int)(settlement.Town.Prosperity / 100f);
            wage = (int)(wage * (1.0f + companionBonus));
            
            GiveGoldAction.ApplyForSettlementToCharacter(settlement, Hero.MainHero, wage, false);

            // 2. Player XP (Diverse Military Skills)
            float xpMult = 1.0f + (_totalContinuousHours * _settings.XpStreakMultiplier);
            xpMult += companionBonus; // Companions help you learn/work faster? Or just work harder? Let's say they handle grunt work allowing you to focus?
            
            // Rotation of skills: Leadership -> Engineering -> Steward -> Combat
            int cycle = _totalContinuousHours % 4;
            if (cycle == 0) Hero.MainHero.AddSkillXp(DefaultSkills.Leadership, 40 * xpMult);
            else if (cycle == 1) Hero.MainHero.AddSkillXp(DefaultSkills.Engineering, 40 * xpMult);
            else if (cycle == 2) Hero.MainHero.AddSkillXp(DefaultSkills.Steward, 40 * xpMult);
            else 
            {
                // Combat Skill
                Hero.MainHero.AddSkillXp(DefaultSkills.Bow, 30 * xpMult);
                Hero.MainHero.AddSkillXp(DefaultSkills.OneHanded, 30 * xpMult);
            }

            // 3. Castle Buffs (Hourly Tick)
            // Small increment to Security and Loyalty
            if (settlement.Town != null)
            {
                float secGain = 0.5f * (1.0f + companionBonus);
                float loyGain = 0.2f * (1.0f + companionBonus);
                
                settlement.Town.Security += secGain;
                settlement.Town.Loyalty += loyGain;

                // Garrison Train: Give 10 XP to every troop in garrison
                if (settlement.Town.GarrisonParty != null)
                {
                    var garrison = settlement.Town.GarrisonParty;
                    int garrisonXp = (int)(15 * (1.0f + companionBonus));
                    
                    for(int i=0; i< garrison.MemberRoster.Count; i++)
                    {
                        var element = garrison.MemberRoster.GetElementCopyAtIndex(i);
                        if (!element.Character.IsHero)
                        {
                            garrison.MemberRoster.AddXpToTroop(element.Character, garrisonXp);
                        }
                    }
                }

                // BetterGov: Governor Enforcement
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
            score += hero.GetSkillValue(DefaultSkills.OneHanded); // Combat competence
            
            // Normalize: 4 skills * 100 avg = 400.
            // Target ~20-30% bonus per strong companion.
            // 400 * 0.0005 = 0.2 (20%).
            return score * 0.0005f;
        }

        private void GiveShiftReward()
        {
            var settlement = Settlement.CurrentSettlement;
            if (settlement == null || settlement.Town == null) return;

            _logger.Information($"Castle Shift Complete at {settlement.Name}");
            InformationManager.DisplayMessage(new InformationMessage("Shift Complete: Garrison Drills Finished."));

            // 1. REWARD: Upgrade Militia (Veterancy)
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
                    if (upgradesPerformed > 0)
                        InformationManager.DisplayMessage(new InformationMessage($"Drill Results: {upgradesPerformed} Militia promoted to veterans."));
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "HonestWork: Error during Militia Upgrade reward.");
            }

            // 2. REWARD: Add Garrison Troop
            // Add a T3 troop of the settlement culture to the Garrison
            if (settlement.Culture != null && settlement.Culture.RangedEliteMilitiaTroop != null)
            {
                // Use Elite Militia type as a "free" garrison filler, or grab a basic professional soldier
                var troopToAdd = settlement.Culture.RangedEliteMilitiaTroop; 
                if (settlement.Town.GarrisonParty != null)
                {
                    settlement.Town.GarrisonParty.MemberRoster.AddToCounts(troopToAdd, 1);
                    InformationManager.DisplayMessage(new InformationMessage($"Recruitment: 1 {troopToAdd.Name} joined the garrison."));
                }
            }

            // 3. REWARD: Relation with Governor or Owner
            var notable = settlement.Town.Governor;
            if (notable == null) notable = settlement.OwnerClan?.Leader;
            
            if (notable != null && notable != Hero.MainHero)
            {
                ChangeRelationAction.ApplyRelationChangeBetweenHeroes(Hero.MainHero, notable, 2, true);
            }

            // 4. Heavy Security Boost
            settlement.Town.Security += 2.0f;

            // Reset loop
            _startTime = CampaignTime.Now;
            _hoursWorked = 0;
        }
    }
}
