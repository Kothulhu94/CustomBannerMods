using System;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.ObjectSystem;
using Serilog;

using TaleWorlds.CampaignSystem.Settlements.Locations;

namespace HonestWork
{
    public class TownJobBehavior : CampaignBehaviorBase
    {
        private readonly ILogger _logger;
        private readonly GlobalSettings _settings;

        private CampaignTime _startTime;
        private int _hoursWorked;
        private int _totalContinuousHours;
        private string _currentJobId;

        private class JobDef
        {
            public string Id;
            public string Name;
            public string Description;
            public List<SkillObject> Skills; 
            public int TotalXp; 
            public bool IsGuard; 
            public bool IsThug;
            public bool IsNaval;
            public float WageMultiplier = 1.0f;
        }

        private List<JobDef> _jobs;
        private Dictionary<Hero, string> _aiLastJob = new Dictionary<Hero, string>();
        
        private Dictionary<string, float> _seasonalMultipliers = new Dictionary<string, float>(); 
        private Dictionary<Hero, CampaignTime> _crimeCooldowns = new Dictionary<Hero, CampaignTime>();
        private CampaignTime.Seasons _lastSeason = CampaignTime.Seasons.Winter;

        public TownJobBehavior(ILogger logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
            _jobs = new List<JobDef>();
        }
        
        private static List<Hero> _cachedWorkers = new List<Hero>(100);

        private void InitializeJobs()
        {
            if (_jobs.Count > 0) return;
            int xp = _settings.TownJobBaseXp;
            _jobs.Add(new JobDef { Id = "guard", Name = "{=lw_job_guardduty}Guard Duty", Description = "{=lw_job_patrolthewallsa}Patrol the walls and keep order. (Athletics/Combat) -> +Security, +Prosperity", IsGuard = true, TotalXp = xp, WageMultiplier = _settings.WageGuard });
            _jobs.Add(new JobDef { Id = "thug", Name = "{=lw_job_gangenforcer}Gang Enforcer", Description = "{=lw_job_muscleworkforlo}Muscle work for local gangs. (Roguery/Combat) -> -Security, -Loyalty", IsThug = true, TotalXp = xp, WageMultiplier = _settings.WageThug });
            _jobs.Add(new JobDef { Id = "artisan", Name = "{=lw_job_artisanbuilder}Artisan & Builder", Description = "{=lw_job_smithingandcons}Smithing and construction work. (Crafting/Engineering) -> +Prosperity, +Militia", Skills = new List<SkillObject> { DefaultSkills.Crafting, DefaultSkills.Engineering }, TotalXp = xp, WageMultiplier = _settings.WageArtisan });
            _jobs.Add(new JobDef { Id = "instructor", Name = "{=lw_job_militaryinstruc}Military Instructor", Description = "{=lw_job_drilltroopsandt}Drill troops and teach tactics. (Leadership/Tactics) -> +GarrisonXP, +Militia", Skills = new List<SkillObject> { DefaultSkills.Leadership, DefaultSkills.Tactics }, TotalXp = xp, WageMultiplier = _settings.WageInstructor });
            _jobs.Add(new JobDef { Id = "outrider", Name = "{=lw_job_outrider}Outrider", Description = "{=lw_job_scouttheperimet}Scout the perimeter and ride patrols. (Scouting/Riding) -> +Garrison, +GarrisonXP", Skills = new List<SkillObject> { DefaultSkills.Scouting, DefaultSkills.Riding }, TotalXp = xp, WageMultiplier = _settings.WageOutrider });
            _jobs.Add(new JobDef { Id = "physician", Name = "{=lw_job_courtphysician}Court Physician", Description = "{=lw_job_tendtothesickan}Tend to the sick and entertain the court. (Medicine/Charm) -> +Loyalty", Skills = new List<SkillObject> { DefaultSkills.Medicine, DefaultSkills.Charm }, TotalXp = xp, WageMultiplier = _settings.WagePhysician }); 
            _jobs.Add(new JobDef { Id = "official", Name = "{=lw_job_townofficial}Town Official", Description = "{=lw_job_managetradeledg}Manage trade ledgers and supplies. (Trade/Steward) -> +Prosperity, +Food", Skills = new List<SkillObject> { DefaultSkills.Trade, DefaultSkills.Steward }, TotalXp = xp, WageMultiplier = _settings.WageOfficial }); 

            // Naval DLC Jobs
            _jobs.Add(new JobDef { Id = "deckhand", Name = "{=lw_job_deckhand}Deckhand", Description = "{=lw_job_haulropesandscr}Haul ropes and scrub decks. (Mariner) -> +Prosperity", IsNaval = true, TotalXp = xp, WageMultiplier = 1.0f });
            _jobs.Add(new JobDef { Id = "shipwright", Name = "{=lw_job_shipwright}Shipwright", Description = "{=lw_job_repairandbuildm}Repair and build maritime vessels. (Boatswain/Engineering) -> +Prosperity, +Militia", IsNaval = true, TotalXp = xp, WageMultiplier = 1.5f, Skills = new List<SkillObject> { DefaultSkills.Engineering } });
            _jobs.Add(new JobDef { Id = "harbormaster", Name = "{=lw_job_harbormasterass}Harbor Master Assistant", Description = "{=lw_job_managedocktraff}Manage dock traffic and ledgers. (Shipmaster/Trade) -> +Prosperity, +Loyalty", IsNaval = true, TotalXp = xp, WageMultiplier = 2.0f, Skills = new List<SkillObject> { DefaultSkills.Trade } });
            
            UpdateSeasonalMultipliers();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
            CampaignEvents.AfterSettlementEntered.AddNonSerializedListener(this, OnAfterSettlementEntered);
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("_currentJobId", ref _currentJobId);
            dataStore.SyncData("_hoursWorked", ref _hoursWorked);
            dataStore.SyncData("_totalContinuousHours", ref _totalContinuousHours);
            dataStore.SyncData("_startTime", ref _startTime);
            dataStore.SyncData("_crimeCooldowns", ref _crimeCooldowns);
        }

        public string GetHeroJob(Hero hero)
        {
            if (hero == Hero.MainHero) 
            {
                 // Check if player is actually working (waiting in menu)
                 if (IsPlayerWorking()) return _currentJobId;
                 return null;
            }
            
            if (_aiLastJob.ContainsKey(hero)) return _aiLastJob[hero];
            return null;
        }

        public bool IsPlayerWorking()
        {
             return !string.IsNullOrEmpty(_currentJobId);
        }

        private void OnHourlyTick()
        {
            foreach (var settlement in Settlement.All)
            {
                if (settlement.IsTown)
                {
                    ProcessAIHourlyWork(settlement);
                }
            }

            if (CampaignTime.Now.GetSeasonOfYear != _lastSeason)
            {
                _lastSeason = CampaignTime.Now.GetSeasonOfYear;
                UpdateSeasonalMultipliers();
                InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_theseasonhascha}}The season has changed to {_lastSeason}. Job market wages have fluctuated!").ToString()));
            }

            CheckForSiegeInterrupt();
        }

        private void CheckForSiegeInterrupt()
        {
            // Only relevant if player is working (which we track via menu state or _currentJobId + 'Wait' menu)
            if (_currentJobId == null || Hero.MainHero.CurrentSettlement == null) return;
            
            string menuId = Campaign.Current.CurrentMenuContext?.GameMenu?.StringId;
            if (menuId != "town_job_wait") return;

            var settlement = Hero.MainHero.CurrentSettlement;
            if (settlement.SiegeEvent != null)
            {
                 // Siege Detected while working!
                 _currentJobId = null;
                 _hoursWorked = 0;
                 _startTime = CampaignTime.Now; // Reset to avoid elapsed time spikes if re-entering
                 
                 InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_workcancelledth}Work cancelled! The settlement is under siege!").ToString(), TaleWorlds.Library.Color.FromUint(0xFF0000)));
                 
                 GameMenu.SwitchToMenu("town");
            }
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            try
            {
                InitializeJobs();

                starter.AddGameMenu("town_jobs_hub", "{=lw_youlookatthetow}You look at the town board for available work.", (MenuCallbackArgs args) => { }, GameMenu.MenuOverlayType.SettlementWithBoth, GameMenu.MenuFlags.None, null);
                starter.AddGameMenuOption("town_jobs_hub", "town_jobs_hub_leave", "{=lw_returntotowncen}Return to town center", (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; }, (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("town"); }, true);

                foreach (var job in _jobs)
                {
                     try 
                     {
                         AddJobOption(starter, job);
                     }
                     catch(Exception innerEx)
                     {
                         _logger.Error(innerEx, $"Failed to add job {job.Id}");
                     }
                }

                starter.AddWaitGameMenu("town_job_wait", "You are working...",
                    (MenuCallbackArgs args) => 
                    { 
                    },
                    (MenuCallbackArgs args) => { return true; },
                    (MenuCallbackArgs args) => { },
                    (MenuCallbackArgs args, CampaignTime dt) => 
                    {
                        if (_startTime == CampaignTime.Zero || _currentJobId == null)
                        {
                             _startTime = CampaignTime.Now;
                             _hoursWorked = 0;
                             _currentJobId = "laborer";
                             _logger.Warning("HonestWork state repaired (Time/ID was missing).");
                        }

                        double elapsedHours = _startTime.ElapsedHoursUntilNow;
                        
                        if (elapsedHours - _hoursWorked > 24)
                        {
                            _logger.Warning($"HonestWork: Time desync detected ({elapsedHours} hours). Resetting timer.");
                            _startTime = CampaignTime.Now;
                            _hoursWorked = 0;
                            elapsedHours = 0;
                        }

                        if ((int)elapsedHours > _hoursWorked)
                        {
                            _hoursWorked++;
                            _totalContinuousHours++;
                            GivePlayerHourlyReward();
                            if (_hoursWorked % _settings.ShiftHours == 0) GivePlayerShiftReward();
                        }
                    },
                    GameMenu.MenuAndOptionType.WaitMenuShowOnlyProgressOption, GameMenu.MenuOverlayType.SettlementWithBoth, 0f, GameMenu.MenuFlags.None, null);
                
                starter.AddGameMenuOption("town_job_wait", "town_job_leave", "{=lw_stopworking}Stop Working", (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; }, (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("town_jobs_hub"); }, true);

                starter.AddGameMenuOption("town", "town_look_for_work", "{=lw_lookforwork}Look for Work",
                    (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Submenu; return MobileParty.MainParty.Army == null; },
                    (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("town_jobs_hub"); }, false, 4);



                 _logger.Information("HonestWork Game Menus initialized successfully.");
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "CRASH in HonestWork OnSessionLaunched");
            }
        }

        private void AddJobOption(CampaignGameStarter starter, JobDef job)
        {
            starter.AddGameMenuOption("town_jobs_hub", $"work_{job.Id}", job.Name,
                (MenuCallbackArgs args) => 
                { 
                    args.Tooltip = new TextObject(job.Description); 
                    args.optionLeaveType = GameMenuOption.LeaveType.Wait; 
                    if (job.IsNaval)
                    {
                        return NavalIntegration.HasShipyard(Settlement.CurrentSettlement.Town);
                    }
                    return true; 
                },
                (MenuCallbackArgs args) => 
                { 
                    _currentJobId = job.Id; 
                    _startTime = CampaignTime.Now; 
                    _hoursWorked = 0; 
                    _totalContinuousHours = 0; 
                    GameMenu.SwitchToMenu("town_job_wait"); 
                });
        }

        private void GivePlayerHourlyReward()
        {
            if (Settlement.CurrentSettlement == null || !Settlement.CurrentSettlement.IsTown) return;
            var town = Settlement.CurrentSettlement.Town;
            var job = _jobs.FirstOrDefault(j => j.Id == _currentJobId);
            
            int baseWage = _settings.TownBaseWage + (int)(town.Prosperity / _settings.TownProsperityDivisor);
            float seasonalMult = _seasonalMultipliers.ContainsKey(_currentJobId) ? _seasonalMultipliers[_currentJobId] : 1.0f;
            float jobMult = job?.WageMultiplier ?? 1.0f;
            
            int wage = (int)(baseWage * jobMult * seasonalMult);
            
            GiveGoldAction.ApplyForSettlementToCharacter(town.Settlement, Hero.MainHero, wage, false);
            _logger.Debug("HonestWork: Player wage calculated: {Wage} (Base: {Base}, JobMult: {JobMult}, Seasonal: {Seasonal})", 
                wage, baseWage, jobMult, seasonalMult);
            
            float companionBonus = 0f;
            if (Hero.MainHero.PartyBelongedTo != null)
            {
                foreach (var element in Hero.MainHero.PartyBelongedTo.MemberRoster.GetTroopRoster())
                {
                    if (element.Character.IsHero && element.Character.HeroObject != Hero.MainHero && !element.Character.HeroObject.IsWounded)
                    {
                        var comp = element.Character.HeroObject;
                        float contribution = CalculateCompanionContribution(comp, _currentJobId);
                        
                        if (contribution > 0)
                        {
                            companionBonus += contribution;
                        }
                    }
                }
            }
            
            ApplyJobEffects(town, _currentJobId, 1.0f + companionBonus, false, false);

            if (town.OwnerClan == Clan.PlayerClan && town.Governor == null)
            {
                town.Governor = Hero.MainHero;
            }

            if (_currentJobId == "thug")
            {
                CheckForArrest(town, Hero.MainHero);
            }

            // XP Logic
            int interval = _settings.XpIncreaseInterval > 0 ? _settings.XpIncreaseInterval : 4;
            int steps = Math.Max(0, _totalContinuousHours - 1) / interval;
            float xpMult = 1.0f + (steps * _settings.XpStepMultiplier);
            
            // Add companion bonus to multiplier
            xpMult += companionBonus;

            ApplyJobXP(Hero.MainHero, _currentJobId, xpMult);
        }

        private void CheckForArrest(Town town, Hero hero)
        {
            try
            {
                if (town.OwnerClan == hero.Clan)
                {
                    if (MBRandom.RandomFloat < _settings.ArrestRollEyesChance && hero == Hero.MainHero) 
                        InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_aguardrecognize}A guard recognized you and looked away nervously.").ToString()));
                    return;
                }
                float risk = (town.Security * _settings.ThugArrestBaseRisk);
                float safety = (hero.GetSkillValue(DefaultSkills.Roguery) * _settings.ThugRoguerySafety);
                float chance = risk - safety;

                if (town.OwnerClan == hero.Clan && _settings.PlayerTownExemption) 
                {
                     if (chance > 0.1f && MBRandom.RandomFloat < 0.2f)
                        InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_theguardslookth}The guards look the other way because you own this town.").ToString()));
                     return; 
                }
                
                if (chance < 0) chance = 0;
                
                if (MBRandom.RandomFloat < chance)
                {
                    // Find a valid captor (Garrison is the jailor)
                    PartyBase captorParty = null;
                    if (town.GarrisonParty != null && town.GarrisonParty.IsActive)
                    {
                        captorParty = town.GarrisonParty.Party;
                    }

                    if (hero == Hero.MainHero)
                    {
                        InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_youhavebeencaug}You have been caught by the guards!").ToString(), TaleWorlds.Library.Color.FromUint(0xFF0000FF)));
                        _currentJobId = null; 
                        
                        if (captorParty != null)
                        {
                            TakePrisonerAction.Apply(captorParty, hero);
                            
                            // Explicitly trigger the captivity menu/sequence
                            PlayerCaptivity.StartCaptivity(captorParty);
                        }
                        else
                        {
                            // Fallback if no jailor exists (e.g. no garrison)
                            InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_theguardstriedt}The guards tried to arrest you, but the dungeon is unguarded!").ToString()));
                            GameMenu.SwitchToMenu("town");
                        }
                    }
                    else
                    {
                        // AI Logic
                        if (captorParty != null)
                        {
                            InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_heronamewascaug}}{hero.Name} was caught committing crimes in {town.Name} and imprisoned!").ToString()));
                            TakePrisonerAction.Apply(captorParty, hero);
                            
                            StartCrimeCooldown(hero);
                            if (_aiLastJob.ContainsKey(hero)) _aiLastJob.Remove(hero);
                        }
                        // If no captor, AI escapes arrest effectively
                    }
                }
            }
            catch {}
        }

        private void StartCrimeCooldown(Hero hero)
        {
             _crimeCooldowns[hero] = CampaignTime.Now + CampaignTime.Days(5f);
        }

        private void OnAfterSettlementEntered(MobileParty party, Settlement settlement, Hero hero)
        {
             if (party != MobileParty.MainParty || settlement == null || !settlement.IsTown) return;
             CleanTavern(settlement);
        }

        private void CleanTavern(Settlement settlement)
        {
            try
            {
                if (settlement.LocationComplex == null) return;
                var tavern = settlement.LocationComplex.GetLocationWithId("tavern");
                if (tavern == null) return;

                // Reflection to get characters
                var bindingFlags = System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public;
                var charListField = typeof(Location).GetField("_locationCharacters", bindingFlags) 
                                 ?? typeof(Location).GetField("_characterList", bindingFlags);
                
                System.Collections.IEnumerable charList = null;
                if (charListField != null)
                {
                    charList = charListField.GetValue(tavern) as System.Collections.IEnumerable;
                }

                if (charList == null) return;

                // Remove heroes who are supposed to be working
                List<LocationCharacter> toRemove = new List<LocationCharacter>();
                List<Hero> toShoo = new List<Hero>();
                
                foreach (var obj in charList)
                {
                     var character = obj as LocationCharacter;
                     if (character != null && character.Character.IsHero)
                     {
                         var h = character.Character.HeroObject;
                         
                         // 2. Idle Commander Logic: Is Wanderer with Clan, No Party, Not Player Companion?
                         if (h.IsWanderer && h.Clan != null && h.Clan != Clan.PlayerClan && 
                             h.PartyBelongedTo == null && !h.IsPrisoner && !h.IsPlayerCompanion)
                         {
                             toShoo.Add(h);
                             toRemove.Add(character);
                         }
                     }
                }

                // Execute Shoo first (Logic)
                foreach (var h in toShoo)
                {
                     HappyParty.TavernShooBehavior.ExecuteShoo(h);
                }

                // Execute Visual Removal next
                foreach (var target in toRemove)
                {
                    tavern.RemoveLocationCharacter(target);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "HonestWork: Failed to clean tavern.");
            }
        }

        private float CalculateCompanionContribution(Hero hero, string jobId)
        {
            var job = _jobs.FirstOrDefault(j => j.Id == jobId);
            if (job == null) return 0f;

            float score = 0f;
            
            if (job.IsGuard)
            {
                score += hero.GetSkillValue(DefaultSkills.Athletics);
                score += hero.GetSkillValue(DefaultSkills.OneHanded);
                score += hero.GetSkillValue(DefaultSkills.TwoHanded);
            }
            else if (job.IsThug)
            {
                score += hero.GetSkillValue(DefaultSkills.Roguery);
                score += hero.GetSkillValue(DefaultSkills.Throwing);
            }
            else if (job.Id == "deckhand")
            {
                if (NavalIntegration.IsEnabled)
                    score += hero.GetSkillValue(NavalIntegration.Mariner);
            }
            else if (job.Id == "shipwright")
            {
                if (NavalIntegration.IsEnabled)
                    score += hero.GetSkillValue(NavalIntegration.Boatswain);
                score += hero.GetSkillValue(DefaultSkills.Engineering);
            }
            else if (job.Id == "harbormaster")
            {
                if (NavalIntegration.IsEnabled)
                    score += hero.GetSkillValue(NavalIntegration.Shipmaster);
                score += hero.GetSkillValue(DefaultSkills.Trade);
            }
            else if (job.Skills != null)
            {
                foreach (var skill in job.Skills)
                {
                    score += hero.GetSkillValue(skill);
                }
            }

            return score * _settings.CompanionEfficiencyFactor;
        }

        private void ApplyJobEffects(Town town, string jobId, float magnitude, bool isAi = false, bool applyStats = true)
        {
            try
            {
                bool finalApplyStats = applyStats && _settings.EnableTownStatIncreases;
                float baseMag = isAi ? _settings.AiEffectMagnitude : _settings.TownEffectMagnitude;
                float effectVal = baseMag * magnitude;

                if (jobId == "guard") 
                {
                    if (finalApplyStats)
                    {
                        town.Security += effectVal;
                        town.Prosperity += effectVal;
                    }
                }
                else if (jobId == "thug") 
                {
                    if (finalApplyStats)
                    {
                        town.Security -= effectVal;
                        town.Loyalty -= effectVal;
                    }
                }
                else if (jobId == "artisan") 
                {
                    if (finalApplyStats)
                    {
                        town.Prosperity += effectVal;
                        AddMilitia(town, effectVal);
                    }
                }
                else if (jobId == "official") 
                {
                    if (finalApplyStats)
                    {
                        town.Prosperity += effectVal;
                        int count = (int)(5 * magnitude);
                        AddRandomFoodToTown(town, count);
                    }
                }
                else if (jobId == "physician") 
                {
                    if (finalApplyStats)
                    {
                        town.Loyalty += effectVal;
                    }
                }
                else if (jobId == "outrider")
                {
                    if (finalApplyStats)
                    {
                        int overcrowding = HonestWorkHelpers.GetGarrisonOvercrowding(town);
                        if (overcrowding >= 10)
                        {
                             // Desertion Mode (Overcrowding): Double XP instead of troops
                             AddGarrisonXp(town, (int)(20 * magnitude)); 
                        }
                        else
                        {
                             AddGarrisonTroops(town, (int)(1 * magnitude)); 
                             AddGarrisonXp(town, (int)(10 * magnitude)); 
                        }
                    }
                }
                else if (jobId == "deckhand")
                {
                    if (finalApplyStats)
                    {
                        town.Prosperity += effectVal;
                    }
                }
                else if (jobId == "shipwright")
                {
                    if (finalApplyStats)
                    {
                        town.Prosperity += effectVal;
                        AddMilitia(town, effectVal);
                    }
                }
                else if (jobId == "harbormaster")
                {
                    if (finalApplyStats)
                    {
                        town.Prosperity += effectVal;
                        town.Loyalty += effectVal;
                    }
                }
                else if (jobId == "instructor")
                {
                    if (finalApplyStats)
                    {
                        AddGarrisonXp(town, (int)(10 * magnitude));
                        AddMilitia(town, effectVal);
                    }
                    
                    if (town.GarrisonParty != null)
                    {
                         HonestWorkHelpers.GiveRandomPartyXp(town.GarrisonParty, 30, 50, 150);
                    }

                    if (Hero.MainHero.PartyBelongedTo != null)
                    {
                        AddPartyXp(Hero.MainHero.PartyBelongedTo, (int)(5 * magnitude));
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "HonestWork Error in ApplyJobEffects");
            }
        }

        private void AddRandomFoodToTown(Town town, int count)
        {
            if (town.Settlement == null || town.Settlement.ItemRoster == null) return;
            
            try
            {
                var foodItems = MBObjectManager.Instance.GetObjectTypeList<ItemObject>()
                    .Where(i => i.IsFood)
                    .ToList();

                if (foodItems.Count == 0) return;

                for(int i=0; i<count; i++)
                {
                    var randomFood = foodItems[MBRandom.RandomInt(foodItems.Count)];
                    town.Settlement.ItemRoster.AddToCounts(randomFood, 1);
                }
            }
            catch {}
        }

        private void GivePlayerShiftReward()
        {
            _logger.Information($"Player finished {_settings.ShiftHours}-hour shift as {_currentJobId}.");
            if (Settlement.CurrentSettlement != null && Settlement.CurrentSettlement.Town != null)
            {
                ApplyShiftRewards(Hero.MainHero, Settlement.CurrentSettlement.Town, _currentJobId);
                
                float multiplier = 1.0f + (_totalContinuousHours * _settings.XpStepMultiplier);
                int hours = _settings.ShiftHours;

                if (Hero.MainHero.PartyBelongedTo != null)
                {
                    foreach (var element in Hero.MainHero.PartyBelongedTo.MemberRoster.GetTroopRoster())
                    {
                        if (element.Character.IsHero && element.Character.HeroObject != Hero.MainHero && !element.Character.HeroObject.IsWounded)
                        {
                           var comp = element.Character.HeroObject;
                           // Exclude FieldSquire (Passive Utility)
                           if (comp.StringId == "field_squire" || comp.Name.ToString().Contains("Squire")) continue;

                           float contribution = CalculateCompanionContribution(comp, _currentJobId);
                           if (contribution > 0)
                           {
                               ApplyJobXP(comp, _currentJobId, multiplier * 0.5f * hours);
                           }
                        }
                    }
                }
            }
            
            GainRenownAction.Apply(Hero.MainHero, 0.5f, false);
            InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_shiftcompleteyo}Shift complete. You continue your labor...").ToString()));
            _startTime = CampaignTime.Now;
            _hoursWorked = 0;
        }

        private void ApplyShiftRewards(Hero worker, Town town, string jobId)
        {
             bool isAi = worker != Hero.MainHero;
             ApplyJobEffects(town, jobId, 2.0f, isAi);

             if (jobId == "instructor")
             {
                  if (worker.PartyBelongedTo != null) AddPartyXp(worker.PartyBelongedTo, _settings.ShiftXpBonus);
                  AddGarrisonXp(town, _settings.ShiftXpBonus);
                  if (worker == Hero.MainHero) InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_shiftbonustroop}}Shift Bonus: Troops drilled intensely (+{_settings.ShiftXpBonus} XP).").ToString()));
             }

             if (jobId == "official")
             {
                 AddRandomFoodToTown(town, _settings.ShiftFoodBonus);
                 if (worker == Hero.MainHero) InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_shiftbonusmarke}}Shift Bonus: Market stocks replenished (+{_settings.ShiftFoodBonus} Extra Food).").ToString()));
             }

             if (town.Settlement.Notables.Count > 0)
             {
                 Hero notable = null;
                 var notables = town.Settlement.Notables;

                 if (jobId == "thug")
                 {
                     var gangLeaders = notables.Where(n => n.IsGangLeader).ToList();
                     if (gangLeaders.Count > 0) notable = gangLeaders.GetRandomElement();
                 }
                 else if (jobId == "guard")
                 {
                     var lawAbiding = notables.Where(n => !n.IsGangLeader).ToList();
                     if (lawAbiding.Count > 0) notable = lawAbiding.GetRandomElement();
                 }
                 else
                 {
                     notable = notables.GetRandomElement();
                 }

                 if (notable != null)
                 {
                     ChangeRelationAction.ApplyRelationChangeBetweenHeroes(worker, notable, _settings.ShiftRelationBonus, true);
                 }
             }

             if (worker.PartyBelongedTo != null && _settings.EnableTownItemRewards)
             {
                 int wage = _settings.TownBaseWage + (int)(town.Prosperity / _settings.TownProsperityDivisor);

                 float streakMult = (worker == Hero.MainHero) ? (1.0f + (_totalContinuousHours * _settings.XpStepMultiplier / 2)) : 1.1f;
                 
                 int maxVal = (int)(wage * 10 * streakMult);
                 var townRoster = town.Settlement.ItemRoster;
                 
                 if (townRoster != null)
                 {
                     var candidates = townRoster.Where(x => x.EquipmentElement.Item != null && x.EquipmentElement.Item.Value < maxVal).ToList();
                     if (candidates.Count > 0)
                     {
                         var chosen = candidates[MBRandom.RandomInt(candidates.Count)];
                         worker.PartyBelongedTo.ItemRoster.AddToCounts(chosen.EquipmentElement.Item, 1);
                         town.Settlement.ItemRoster.AddToCounts(chosen.EquipmentElement.Item, -1);
                         
                         if (worker == Hero.MainHero) 
                            InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_bonuschosenequi}}Bonus: {chosen.EquipmentElement.Item.Name}").ToString()));
                     }
                 }
             }
        }

        private void ApplyJobXP(Hero hero, string jobId, float multiplier = 1.0f)
        {
            var job = _jobs.FirstOrDefault(j => j.Id == jobId);
            if (job == null) return;

            List<string> xpMessages = new List<string>();

            if (job.IsGuard)
            {
                int athleticsXP = (int)(_settings.XpPrimary * multiplier);
                hero.AddSkillXp(DefaultSkills.Athletics, athleticsXP);
                if (hero == Hero.MainHero) xpMessages.Add($"{athleticsXP} Athletics XP");

                var combatSkills = new List<SkillObject> { DefaultSkills.OneHanded, DefaultSkills.TwoHanded, DefaultSkills.Polearm, DefaultSkills.Bow, DefaultSkills.Crossbow };
                var randomSkill = combatSkills[MBRandom.RandomInt(combatSkills.Count)];
                int combatXP = (int)(_settings.XpSecondary * multiplier);
                hero.AddSkillXp(randomSkill, combatXP);
                if (hero == Hero.MainHero) xpMessages.Add($"{combatXP} {randomSkill.Name} XP");
            }
            else if (job.IsThug)
            {
                int rogueryXP = (int)(_settings.XpPrimary * multiplier);
                hero.AddSkillXp(DefaultSkills.Roguery, rogueryXP);
                if (hero == Hero.MainHero) xpMessages.Add($"{rogueryXP} Roguery XP");

                var combatSkills = new List<SkillObject> { DefaultSkills.OneHanded, DefaultSkills.TwoHanded, DefaultSkills.Throwing, DefaultSkills.Bow, DefaultSkills.Crossbow };
                var randomSkill = combatSkills[MBRandom.RandomInt(combatSkills.Count)];
                int combatXP = (int)(_settings.XpSecondary * multiplier);
                hero.AddSkillXp(randomSkill, combatXP);
                if (hero == Hero.MainHero) xpMessages.Add($"{combatXP} {randomSkill.Name} XP");
            }
            else if (jobId == "deckhand")
            {
                if (NavalIntegration.IsEnabled)
                {
                    int primaryXP = (int)(_settings.XpPrimary * multiplier);
                    hero.AddSkillXp(NavalIntegration.Mariner, primaryXP);
                    if (hero == Hero.MainHero) xpMessages.Add($"{primaryXP} Mariner XP");
                    _logger.Debug("HonestWork: Awarded {Xp} Mariner XP to {HeroName}", primaryXP, hero.Name);
                }
                else
                {
                    _logger.Warning("HonestWork: NavalIntegration not enabled, skipping deckhand XP.");
                }
            }
            else if (jobId == "shipwright")
            {
                int primaryXP = (int)(_settings.XpPrimary * multiplier);
                int secondaryXP = (int)(_settings.XpSecondary * multiplier);
                if (NavalIntegration.IsEnabled)
                {
                    hero.AddSkillXp(NavalIntegration.Boatswain, primaryXP);
                    if (hero == Hero.MainHero) xpMessages.Add($"{primaryXP} Boatswain XP");
                    _logger.Debug("HonestWork: Awarded {Xp} Boatswain XP to {HeroName}", primaryXP, hero.Name);
                }
                else
                {
                    _logger.Warning("HonestWork: NavalIntegration not enabled, skipping shipwright Naval XP.");
                }
                hero.AddSkillXp(DefaultSkills.Engineering, secondaryXP);
                if (hero == Hero.MainHero) xpMessages.Add($"{secondaryXP} Engineering XP");
            }
            else if (jobId == "harbormaster")
            {
                int primaryXP = (int)(_settings.XpPrimary * multiplier);
                int secondaryXP = (int)(_settings.XpSecondary * multiplier);
                if (NavalIntegration.IsEnabled)
                {
                    hero.AddSkillXp(NavalIntegration.Shipmaster, primaryXP);
                    if (hero == Hero.MainHero) xpMessages.Add($"{primaryXP} Shipmaster XP");
                    _logger.Debug("HonestWork: Awarded {Xp} Shipmaster XP to {HeroName}", primaryXP, hero.Name);
                }
                else
                {
                    _logger.Warning("HonestWork: NavalIntegration not enabled, skipping harbormaster Naval XP.");
                }
                hero.AddSkillXp(DefaultSkills.Trade, secondaryXP);
                if (hero == Hero.MainHero) xpMessages.Add($"{secondaryXP} Trade XP");
            }
            else if (job.Skills != null && job.Skills.Count > 0)
            {
                int xpPerSkill = (int)((job.TotalXp / job.Skills.Count) * multiplier);
                foreach (var skill in job.Skills) 
                {
                    hero.AddSkillXp(skill, xpPerSkill);
                    if (hero == Hero.MainHero) xpMessages.Add($"{xpPerSkill} {skill.Name} XP");
                }
            }

            if (hero == Hero.MainHero && xpMessages.Count > 0)
            {
                InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_gainedstringjoi}}Gained: {string.Join(", ", xpMessages)}").ToString()));
            }
        }

        private void ProcessAIHourlyWork(Settlement settlement)
        {
            if (settlement.Town == null) return;

            // --- Siege Logic ---
            if (settlement.SiegeEvent != null)
            {
                // Stop all AI work immediately
                HandleSiegeForAI(settlement);
                return;
            }

            _cachedWorkers.Clear();
            HashSet<Hero> processedHeroes = new HashSet<Hero>();

            // 1. Heroes Staying in Town (Wanderers, Lords, Notables if we want?)
            if (settlement.HeroesWithoutParty != null)
            {
                foreach (var hero in settlement.HeroesWithoutParty)
                {
                    if (hero.IsAlive && !hero.IsPrisoner && hero.Clan != Clan.PlayerClan && (hero.IsWanderer || hero.IsLord || hero.IsPlayerCompanion))
                    {
                        // Exclude FieldSquire
                        if (hero.StringId == "field_squire" || hero.Name.ToString().Contains("Squire")) continue;
                        if (processedHeroes.Add(hero)) _cachedWorkers.Add(hero);
                    }
                }
            }

            // 2. Heroes in Parties (Leaders AND Companions)
            if (settlement.Parties != null)
            {
                foreach (var party in settlement.Parties)
                {
                    // Leaders
                    if (party.LeaderHero != null && party.LeaderHero != Hero.MainHero && party.LeaderHero.Clan != Clan.PlayerClan)
                    {
                        if (processedHeroes.Add(party.LeaderHero)) _cachedWorkers.Add(party.LeaderHero);
                    }
                    
                    // Members (Companions / Family in army)
                    if (party.MemberRoster != null)
                    {
                         for (int i = 0; i < party.MemberRoster.Count; i++)
                         {
                             var element = party.MemberRoster.GetElementCopyAtIndex(i);
                             if (element.Character.IsHero && element.Character.HeroObject != null)
                             {
                                 var h = element.Character.HeroObject;
                                 if (h != Hero.MainHero && h.IsAlive && !h.IsPrisoner)
                                 {
                                     // Exclude FieldSquire
                                     if (h.StringId == "field_squire" || h.Name.ToString().Contains("Squire")) continue;
                                     if (processedHeroes.Add(h)) _cachedWorkers.Add(h);
                                 }
                             }
                         }
                    }
                }
            }

            foreach (var worker in _cachedWorkers)
            {
                try
                {
                   long shiftBlock = (long)(CampaignTime.Now.ToHours / (double)_settings.ShiftHours);
                   int seed = worker.Id.GetHashCode() + (int)shiftBlock;
                   
                   JobDef chosenJob = null;
                   bool keptJob = false;
                   
                   string lastIdForExclusion = null;
                   if (_aiLastJob.ContainsKey(worker))
                   {
                       string lastId = _aiLastJob[worker];
                       lastIdForExclusion = lastId; // Capture for exclusion if we don't keep it
                       
                       int honor = worker.GetTraitLevel(DefaultTraits.Honor);
                       
                       // Cap retention to prevent "stuck" heroes - UPDATED
                       float retentionChance = 0.1f + (honor * 0.05f);  
                       if (retentionChance > 0.25f) retentionChance = 0.25f; 
                       if (retentionChance < 0.05f) retentionChance = 0.05f;
                       
                       System.Random rngRetain = new System.Random(seed);
                       if (rngRetain.NextDouble() < retentionChance)
                       {
                           var lastJobDef = _jobs.FirstOrDefault(j => j.Id == lastId);
                           if (lastJobDef != null)
                           {
                               chosenJob = lastJobDef;
                               keptJob = true;
                           }
                       }
                   }

                   if (!keptJob)
                   {
                       // Pass lastIdForExclusion to prevent re-picking same job
                       chosenJob = SelectJobForAI(worker, seed, settlement.Town, lastIdForExclusion);
                       if (chosenJob != null) _aiLastJob[worker] = chosenJob.Id;
                   }
                   
                   if (chosenJob != null)
                   {
                       float aiMag = 1.0f;
                       bool applyEffect = true;

                       if (chosenJob.IsThug)
                       {
                           aiMag = 0.25f;
                           if ((long)CampaignTime.Now.ToHours % 4 != 0) applyEffect = false;
                       }

                       if (applyEffect)
                           ApplyJobEffects(settlement.Town, chosenJob.Id, aiMag, false, false);
                       
                       int wage = GetWageForJob(settlement.Town, chosenJob);
                       GiveGoldAction.ApplyBetweenCharacters(null, worker, wage);

                       if (chosenJob.IsThug)
                       {
                           CheckForArrest(settlement.Town, worker);
                       }

                       if ((long)CampaignTime.Now.ToHours % _settings.ShiftHours == (_settings.ShiftHours - 1))
                       {
                           ApplyShiftRewards(worker, settlement.Town, chosenJob.Id);
                       }
                   }
                }
                catch {}
            }
        }

        private int GetWageForJob(Town town, JobDef job)
        {
            int baseWage = _settings.TownBaseWage + (int)(town.Prosperity / _settings.TownProsperityDivisor);
            float seasonalMult = 1.0f;
            if (_seasonalMultipliers.ContainsKey(job.Id)) seasonalMult = _seasonalMultipliers[job.Id];
            
            return (int)(baseWage * job.WageMultiplier * seasonalMult);
        }

        private void UpdateSeasonalMultipliers()
        {
            _seasonalMultipliers.Clear();
            if (!_settings.EnableSeasonalWages)
            {
                foreach(var key in _seasonalMultipliers.Keys.ToList()) _seasonalMultipliers[key] = 1.0f;
                return;
            }

            foreach (var job in _jobs)
            {
                bool isMental = job.Id == "official" || job.Id == "physician" || job.Id == "artisan" || job.Id == "instructor";
                
                float baseFluctuation = isMental ? 0.75f : 0.2f; 
                float volatility = baseFluctuation * _settings.SeasonalVolatility;
                
                float min = 1.0f - volatility;
                float max = 1.0f + volatility;
                
                if (min < 0.1f) min = 0.1f;
                
                float val = min + (MBRandom.RandomFloat * (max - min));
                _seasonalMultipliers[job.Id] = val;
            }
        }

        private JobDef SelectJobForAI(Hero hero, int seed, Town town, string excludedJobId = null)
        {
            List<JobDef> validJobs = new List<JobDef>();
            int mercy = hero.GetTraitLevel(DefaultTraits.Mercy);

            foreach (var job in _jobs)
            {
                if (job.IsGuard && mercy < 0) continue;
                
                if (job.IsThug)
                {
                    if (mercy > 0) continue;
                    if (_crimeCooldowns.TryGetValue(hero, out var releaseTime) && releaseTime > CampaignTime.Now) continue;
                }
                validJobs.Add(job);
            }

            if (validJobs.Count == 0) return null;

            JobDef bestJob = null;
            float bestScore = -99999f;
            System.Random rng = new System.Random(seed);

            foreach (var job in validJobs)
            {
                float score = 10f; 
                
                // Penalty for just-quit job to force rotation (Applied here where score matters)
                if (excludedJobId != null && job.Id == excludedJobId)
                {
                    score -= 5000f; 
                }
                
                if (job.IsGuard)
                {
                    score += hero.GetSkillValue(DefaultSkills.Athletics) * 2f;
                    score += hero.GetSkillValue(DefaultSkills.OneHanded);
                    score += hero.GetSkillValue(DefaultSkills.TwoHanded);
                }
                else if (job.IsThug)
                {
                    score += hero.GetSkillValue(DefaultSkills.Roguery) * 3f;
                    score += hero.GetSkillValue(DefaultSkills.Throwing);
                }
                else if (job.Id == "deckhand")
                {
                    if (NavalIntegration.IsEnabled)
                        score += hero.GetSkillValue(NavalIntegration.Mariner) * 2f;
                }
                else if (job.Id == "shipwright")
                {
                    if (NavalIntegration.IsEnabled)
                        score += hero.GetSkillValue(NavalIntegration.Boatswain) * 2f;
                    score += hero.GetSkillValue(DefaultSkills.Engineering);
                }
                else if (job.Id == "harbormaster")
                {
                    if (NavalIntegration.IsEnabled)
                        score += hero.GetSkillValue(NavalIntegration.Shipmaster) * 2f;
                    score += hero.GetSkillValue(DefaultSkills.Trade);
                }
                else if (job.Skills != null)
                {
                    foreach (var skill in job.Skills)
                    {
                        score += hero.GetSkillValue(skill) * 1.5f;
                    }
                }
                
                float jitter = (float)rng.NextDouble() * 20f; 
                score += jitter;

                if (hero.Gold < 5000)
                {
                     score += (job.WageMultiplier - 1.0f) * 100f; 
                }

                if (hero.PartyBelongedTo != null && hero.PartyBelongedTo.Food < 5)
                {
                    if (job.Id == "official") score += 200f; 
                }

                if (town.OwnerClan != null)
                {
                    int relation = hero.GetRelation(town.OwnerClan.Leader);
                    if (relation > 10) 
                    {
                        if (job.IsGuard || job.Id == "artisan" || job.Id == "official") score += relation * 2f;
                    }
                    else if (relation < -10 || hero.GetTraitLevel(DefaultTraits.Mercy) < 0) 
                    {
                        if (job.IsThug) score += 50f;
                    }
                }

                if (score > bestScore)
                {
                    bestScore = score;
                    bestJob = job;
                }
            }
            
            return bestJob;
        }

        private static System.Reflection.PropertyInfo _militiaPropTown;
        private static System.Reflection.PropertyInfo _militiaPropSettlement;
        private static System.Reflection.FieldInfo _militiaFieldFief;
        private static bool _reflectionInitialized = false;

        private void AddMilitia(Town town, float amount)
        {
            try
            {
                if (!_reflectionInitialized)
                {
                    var flags = System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance;
                    _militiaPropTown = typeof(Town).GetProperty("Militia", flags);
                    _militiaPropSettlement = typeof(Settlement).GetProperty("Militia", flags);
                    _militiaFieldFief = typeof(Fief).GetField("_militia", flags) ?? typeof(Fief).GetField("<Militia>k__BackingField", flags);
                    _reflectionInitialized = true;
                }
                
                if (_militiaPropTown != null && _militiaPropTown.CanWrite)
                {
                    _militiaPropTown.SetValue(town, (float)_militiaPropTown.GetValue(town) + amount);
                    return;
                }
                
                if (town.Settlement != null)
                {
                    if (_militiaPropSettlement != null && _militiaPropSettlement.CanWrite)
                    {
                        _militiaPropSettlement.SetValue(town.Settlement, (float)_militiaPropSettlement.GetValue(town.Settlement) + amount);
                        return;
                    }
                }

                if (_militiaFieldFief != null)
                {
                    float current = (float)_militiaFieldFief.GetValue(town);
                    _militiaFieldFief.SetValue(town, current + amount);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "HonestWork AddMilitia Error");
            }
        }

        private void AddPartyXp(MobileParty party, int amount)
        {
             if (party != null && party.MemberRoster != null)
             {
                 int multipliedAmount = (int)(amount * _settings.TroopXpMultiplier);
                 if (multipliedAmount <= 0) return;

                 for (int i = 0; i < party.MemberRoster.Count; i++)
                 {
                     var element = party.MemberRoster.GetElementCopyAtIndex(i);
                     party.MemberRoster.AddXpToTroop(element.Character, multipliedAmount);
                 }
             }
        }

        private void AddGarrisonXp(Town town, int amount)
        {
             if (town.GarrisonParty != null && town.GarrisonParty.MemberRoster != null)
             {
                 int multipliedAmount = (int)(amount * _settings.TroopXpMultiplier);
                 if (multipliedAmount <= 0) return;

                 for (int i = 0; i < town.GarrisonParty.MemberRoster.Count; i++)
                 {
                     var element = town.GarrisonParty.MemberRoster.GetElementCopyAtIndex(i);
                     town.GarrisonParty.MemberRoster.AddXpToTroop(element.Character, multipliedAmount);
                 }
             }
        }

        private void AddGarrisonTroops(Town town, int count)
        {
            if (town.GarrisonParty != null && town.GarrisonParty.MemberRoster != null)
            {
                var basicTroop = town.Culture.BasicTroop;
                if (basicTroop != null)
                {
                    town.GarrisonParty.MemberRoster.AddToCounts(basicTroop, count);
                }
            }
            }


        private void HandleSiegeForAI(Settlement settlement)
        {
            // Identify workers to stop
            List<Hero> workingHeroes = new List<Hero>();
            foreach(var hero in _aiLastJob.Keys.ToList())
            {
                if (hero.CurrentSettlement == settlement)
                {
                    workingHeroes.Add(hero);
                }
            }

            foreach(var hero in workingHeroes)
            {
                _logger.Debug("HonestWork: HandleSiegeForAI checking hero {HeroName} at {SettlementName}", hero.Name, settlement.Name);
                try
                {
                    _aiLastJob.Remove(hero); // Stop working -> Join defense (default behavior)

                    // Defection Logic
                    if (_settings.HonestWork_EnableSiegeBetrayal && 
                        settlement.SiegeEvent?.BesiegerCamp?.LeaderParty != null &&
                        hero.IsWanderer && 
                        hero.Clan != Clan.PlayerClan && 
                        hero.Clan?.StringId != "neutral") 
                    {
                        var besiegerParty = settlement.SiegeEvent.BesiegerCamp.LeaderParty;
                        if (hero.Culture == besiegerParty.Party.Culture && hero.PartyBelongedTo != besiegerParty)
                        {
                            // BETRAYAL!
                            _logger.Information("HonestWork: {HeroName} is defecting to besiegers ({BesiegerName}) at {SettlementName}!", hero.Name, besiegerParty.Name, settlement.Name);
                            
                            // Move to besieger party
                            AddHeroToPartyAction.Apply(hero, besiegerParty);
                            
                            if (Settlement.CurrentSettlement == settlement)
                            {
                                InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_heronamehasdefe}}{hero.Name} has defected to the besiegers!").ToString(), TaleWorlds.Library.Color.FromUint(0xFF0000)));
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    _logger.Error(ex, "HonestWork: Error in AI Siege Handling for hero {HeroName} at {SettlementName}", hero.Name, settlement.Name);
                }
            }
        }
    }
}
