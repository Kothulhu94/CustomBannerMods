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
            public float WageMultiplier = 1.0f; // New: Multiplier for dynamic wage scaling
        }

        private List<JobDef> _jobs;
        // AI State Tracking
        private Dictionary<Hero, string> _aiLastJob = new Dictionary<Hero, string>();
        
        // Seasonal Logic
        private Dictionary<string, float> _seasonalMultipliers = new Dictionary<string, float>(); 
        private CampaignTime.Seasons _lastSeason = CampaignTime.Seasons.Winter; // Force update on start

        public TownJobBehavior(ILogger logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
            _jobs = new List<JobDef>();
        }
        
        // Optimization: Static Worker Cache to avoid hourly allocations
        private static List<Hero> _cachedWorkers = new List<Hero>(100);

        private void InitializeJobs()
        {
            if (_jobs.Count > 0) return;
            int xp = _settings.TownJobBaseXp;
            _jobs.Add(new JobDef { Id = "guard", Name = "Guard Duty", Description = "Patrol the walls and keep order. (Athletics/Combat) -> +Security, +Prosperity", IsGuard = true, TotalXp = xp, WageMultiplier = 1.0f });
            _jobs.Add(new JobDef { Id = "thug", Name = "Gang Enforcer", Description = "Muscle work for local gangs. (Roguery/Combat) -> -Security, -Loyalty", IsThug = true, TotalXp = xp, WageMultiplier = 1.5f }); // High Pay
            _jobs.Add(new JobDef { Id = "artisan", Name = "Artisan & Builder", Description = "Smithing and construction work. (Crafting/Engineering) -> +Prosperity, +Militia", Skills = new List<SkillObject> { DefaultSkills.Crafting, DefaultSkills.Engineering }, TotalXp = xp, WageMultiplier = 1.1f });
            _jobs.Add(new JobDef { Id = "instructor", Name = "Military Instructor", Description = "Drill troops and teach tactics. (Leadership/Tactics) -> +GarrisonXP, +Militia", Skills = new List<SkillObject> { DefaultSkills.Leadership, DefaultSkills.Tactics }, TotalXp = xp, WageMultiplier = 1.0f });
            _jobs.Add(new JobDef { Id = "outrider", Name = "Outrider", Description = "Scout the perimeter and ride patrols. (Scouting/Riding) -> +Garrison, +GarrisonXP", Skills = new List<SkillObject> { DefaultSkills.Scouting, DefaultSkills.Riding }, TotalXp = xp, WageMultiplier = 1.1f });
            _jobs.Add(new JobDef { Id = "physician", Name = "Court Physician", Description = "Tend to the sick and entertain the court. (Medicine/Charm) -> +Loyalty", Skills = new List<SkillObject> { DefaultSkills.Medicine, DefaultSkills.Charm }, TotalXp = xp, WageMultiplier = 1.2f }); // High Skill Pay
            _jobs.Add(new JobDef { Id = "official", Name = "Town Official", Description = "Manage trade ledgers and supplies. (Trade/Steward) -> +Prosperity, +Food", Skills = new List<SkillObject> { DefaultSkills.Trade, DefaultSkills.Steward }, TotalXp = xp, WageMultiplier = 1.2f }); // High Pay
            
            UpdateSeasonalMultipliers(); // Init
        }

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("_currentJobId", ref _currentJobId);
            dataStore.SyncData("_hoursWorked", ref _hoursWorked);
            dataStore.SyncData("_totalContinuousHours", ref _totalContinuousHours);
            dataStore.SyncData("_startTime", ref _startTime);
        }

        private void OnHourlyTick()
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            
            // 1. AI "Punch-Clock" Logic - Runs Every Hour
            foreach (var settlement in Settlement.All)
            {
                if (settlement.IsTown)
                {
                    ProcessAIHourlyWork(settlement);
                }
            }
            
            sw.Stop();
            if (sw.ElapsedMilliseconds > 5)
            {
                _logger.Warning($"[LAG SPOKE] HonestWork TownJobBehavior.OnHourlyTick took {sw.ElapsedMilliseconds}ms");
            }

            // Seasonal Check
            if (CampaignTime.Now.GetSeasonOfYear != _lastSeason)
            {
                _lastSeason = CampaignTime.Now.GetSeasonOfYear;
                UpdateSeasonalMultipliers();
                InformationManager.DisplayMessage(new InformationMessage($"The season has changed to {_lastSeason}. Job market wages have fluctuated!"));
            }
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            try
            {
                InitializeJobs();

                // 1. Create the Job Board Menu
                starter.AddGameMenu("town_jobs_hub", "You look at the town board for available work.", (MenuCallbackArgs args) => { }, GameMenu.MenuOverlayType.SettlementWithBoth, GameMenu.MenuFlags.None, null);
                starter.AddGameMenuOption("town_jobs_hub", "town_jobs_hub_leave", "Return to town center", (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; }, (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("town"); }, true);

                // 2. Add Jobs to Board
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

                // 3. Create the Work Wait Menu
                starter.AddWaitGameMenu("town_job_wait", "You are working...",
                    (MenuCallbackArgs args) => 
                    { 
                    },
                    (MenuCallbackArgs args) => { return true; },
                    (MenuCallbackArgs args) => { },
                    (MenuCallbackArgs args, CampaignTime dt) => 
                    {
                        // Sanity Check for Load-Game anomalies
                        if (_startTime == CampaignTime.Zero || _currentJobId == null)
                        {
                             // Fix state if broken
                             _startTime = CampaignTime.Now;
                             _hoursWorked = 0;
                             _currentJobId = "laborer"; // Fallback
                             _logger.Warning("HonestWork state repaired (Time/ID was missing).");
                        }

                        double elapsedHours = _startTime.ElapsedHoursUntilNow;
                        
                        // Prevent 'Death Spiral' if elapsed time is massive (e.g. invalid load magnitude)
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
                
                starter.AddGameMenuOption("town_job_wait", "town_job_leave", "Stop Working", (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; }, (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("town_jobs_hub"); }, true);

                // 4. Add Entry Point from Town Menu (Link to Hub)
                starter.AddGameMenuOption("town", "town_look_for_work", "Look for Work",
                    (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Submenu; return true; },
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
                (MenuCallbackArgs args) => { args.Tooltip = new TextObject(job.Description); args.optionLeaveType = GameMenuOption.LeaveType.Wait; return true; },
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
            int wage = _settings.TownBaseWage + (int)(town.Prosperity / _settings.TownProsperityDivisor);
            
            GiveGoldAction.ApplyForSettlementToCharacter(town.Settlement, Hero.MainHero, wage, false);
            
            float multiplier = 1.0f + (_totalContinuousHours * _settings.XpStreakMultiplier);
            ApplyJobXP(Hero.MainHero, _currentJobId, multiplier);

            // Companion Contribution
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
                            ApplyJobXP(comp, _currentJobId, multiplier * 0.5f);
                        }
                    }
                }
            }
            
            // Apply Effects (1.0 default + companion bonus)
            ApplyJobEffects(town, _currentJobId, 1.0f + companionBonus);

            // BetterGov: Ensure player is Governor if working in their own fief
            if (town.OwnerClan == Clan.PlayerClan && town.Governor == null)
            {
                town.Governor = Hero.MainHero;
            }

            // Risk Check for Thugs (Player)
            if (_currentJobId == "thug")
            {
                CheckForArrest(town, Hero.MainHero);
            }
        }

        private void CheckForArrest(Town town, Hero hero)
        {
            try
            {
                // Safety: Own Town Exemption
                if (town.OwnerClan == hero.Clan)
                {
                    if (MBRandom.RandomFloat < 0.05f && hero == Hero.MainHero) // 5% chance to roll eyes
                        InformationManager.DisplayMessage(new InformationMessage("A guard recognized you and looked away nervously."));
                    return;
                }
                // Chance to Catch = (Security * 0.01) - (Roguery * 0.005)
                // e.g., Security 50 -> 0.5. Roguery 100 -> 0.5. Chance = 0.
                // e.g., Security 100 -> 1.0. Roguery 0 -> 0. Chance = 100% (way too high per hour!)
                // Adjustment: Reduce base risk. (Security * 0.001) maybe?
                float risk = (town.Security * _settings.ThugArrestBaseRisk);
                float safety = (hero.GetSkillValue(DefaultSkills.Roguery) * _settings.ThugRoguerySafety);
                float chance = risk - safety;

                // Safety: Own Town Exemption
                if (town.OwnerClan == hero.Clan && _settings.PlayerTownExemption) 
                {
                     // Flavor text if risky but saved?
                     if (chance > 0.1f && MBRandom.RandomFloat < 0.2f)
                        InformationManager.DisplayMessage(new InformationMessage("The guards look the other way because you own this town."));
                     return; 
                }
                
                if (chance < 0) chance = 0;
                
                if (MBRandom.RandomFloat < chance)
                {
                    // ARRESTED!
                    if (hero == Hero.MainHero)
                    {
                        InformationManager.DisplayMessage(new InformationMessage("You have been caught by the guards!", TaleWorlds.Library.Color.FromUint(0xFF0000FF)));
                        // Stop Job
                        _currentJobId = null; 
                        GameMenu.SwitchToMenu("town");
                        
                        // Imprison
                        if (town.GarrisonParty != null)
                            TakePrisonerAction.Apply(town.GarrisonParty.Party, hero);
                    }
                    else
                    {
                        // AI Arrest
                        InformationManager.DisplayMessage(new InformationMessage($"{hero.Name} was caught committing crimes in {town.Name} and imprisoned!"));
                        if (town.GarrisonParty != null)
                            TakePrisonerAction.Apply(town.GarrisonParty.Party, hero);
                        
                        if (_aiLastJob.ContainsKey(hero)) _aiLastJob.Remove(hero);
                    }
                }
            }
            catch {}
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
            else if (job.Skills != null)
            {
                foreach (var skill in job.Skills)
                {
                    score += hero.GetSkillValue(skill);
                }
            }

            // Normalization: 200 score -> 0.2 (20%)
            return score * 0.001f;
        }

        private void ApplyJobEffects(Town town, string jobId, float magnitude)
        {
            try
            {
                float effectVal = _settings.TownEffectMagnitude * magnitude;

                if (jobId == "guard") 
                {
                    town.Security += effectVal;
                    town.Prosperity += effectVal;
                }
                else if (jobId == "thug") 
                {
                    town.Security -= effectVal;
                    town.Loyalty -= effectVal;
                }
                else if (jobId == "artisan") 
                {
                    town.Prosperity += effectVal;
                    AddMilitia(town, effectVal);
                }
                else if (jobId == "official") 
                {
                    town.Prosperity += effectVal;
                    
                    // Add 5 Random Food Items (Hourly) scaled by magnitude
                    // e.g., shift bonus (2.0) = 10 items
                    int count = (int)(5 * magnitude);
                    AddRandomFoodToTown(town, count);
                }
                else if (jobId == "physician") 
                {
                    town.Loyalty += effectVal;
                }
                else if (jobId == "outrider")
                {
                    // Outriders now boost Garrison count, NOT Militia
                    AddGarrisonTroops(town, (int)(1 * magnitude)); 
                    AddGarrisonXp(town, (int)(10 * magnitude)); // Significant XP Boost
                }
                else if (jobId == "instructor")
                {
                    AddGarrisonXp(town, (int)(10 * magnitude)); // Significant XP Boost
                    AddMilitia(town, effectVal);
                    
                    // New: Random Party XP for Instructor (Player favors own troops too)
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
            var settlement = Settlement.CurrentSettlement;
            if (settlement != null && settlement.Town != null)
            {
                 // 1. Double Effects Bonus (Requested: "reward all there town effects two times")
                 // This effectively triples the hourly effect for this specific hour (1x standard + 2x bonus)
                 ApplyJobEffects(settlement.Town, _currentJobId, 2.0f);

                  if (_currentJobId == "instructor")
                  {
                      AddPartyXp(Hero.MainHero.PartyBelongedTo, 25);
                      AddGarrisonXp(settlement.Town, 25);
                      InformationManager.DisplayMessage(new InformationMessage("Shift Bonus: Troops drilled intensely (+25 XP)."));
                  }

                  if (_currentJobId == "official")
                 {
                     AddRandomFoodToTown(settlement.Town, 10);
                     InformationManager.DisplayMessage(new InformationMessage("Shift Bonus: Market stocks replenished (+10 Extra Food)."));
                 }

                  if (settlement.Notables.Count > 0)
                  {
                      Hero notable = null;
                      var notables = settlement.Notables;

                      if (_currentJobId == "thug")
                      {
                          var gangLeaders = notables.Where(n => n.IsGangLeader).ToList();
                          if (gangLeaders.Count > 0) notable = gangLeaders.GetRandomElement();
                      }
                      else if (_currentJobId == "guard")
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
                          ChangeRelationAction.ApplyRelationChangeBetweenHeroes(Hero.MainHero, notable, 1, true);
                      }
                  }

                  int wage = _settings.TownBaseWage + (int)(settlement.Town.Prosperity / _settings.TownProsperityDivisor);
                  float priceMultiplier = 1.0f + (_totalContinuousHours * _settings.XpStreakMultiplier / 2); // 0.05 / 2 = 0.025
                  int maxVal = (int)(wage * 10 * priceMultiplier);
                  var townRoster = settlement.ItemRoster;
                  if (townRoster != null)
                  {
                      var candidates = townRoster.Where(x => x.EquipmentElement.Item != null && x.EquipmentElement.Item.Value < maxVal).ToList();
                      if (candidates.Count > 0)
                      {
                          var chosen = candidates[MBRandom.RandomInt(candidates.Count)];
                          Hero.MainHero.PartyBelongedTo.ItemRoster.AddToCounts(chosen.EquipmentElement.Item, 1);
                          settlement.ItemRoster.AddToCounts(chosen.EquipmentElement.Item, -1);
                          InformationManager.DisplayMessage(new InformationMessage($"Bonus: {chosen.EquipmentElement.Item.Name}"));
                      }
                  }
             }

            GainRenownAction.Apply(Hero.MainHero, 0.5f, false);
            InformationManager.DisplayMessage(new InformationMessage("Shift complete. You continue your labor..."));
            _startTime = CampaignTime.Now;
            _hoursWorked = 0;
        }

        private void ApplyJobXP(Hero hero, string jobId, float multiplier = 1.0f)
        {
            var job = _jobs.FirstOrDefault(j => j.Id == jobId);
            if (job == null) return;

            List<string> xpMessages = new List<string>();

            if (job.IsGuard)
            {
                int athleticsXP = (int)(20 * multiplier);
                hero.AddSkillXp(DefaultSkills.Athletics, athleticsXP);
                if (hero == Hero.MainHero) xpMessages.Add($"{athleticsXP} Athletics XP");

                var combatSkills = new List<SkillObject> { DefaultSkills.OneHanded, DefaultSkills.TwoHanded, DefaultSkills.Polearm, DefaultSkills.Bow, DefaultSkills.Crossbow };
                var randomSkill = combatSkills[MBRandom.RandomInt(combatSkills.Count)];
                int combatXP = (int)(30 * multiplier);
                hero.AddSkillXp(randomSkill, combatXP);
                if (hero == Hero.MainHero) xpMessages.Add($"{combatXP} {randomSkill.Name} XP");
            }
            else if (job.IsThug)
            {
                int rogueryXP = (int)(20 * multiplier);
                hero.AddSkillXp(DefaultSkills.Roguery, rogueryXP);
                if (hero == Hero.MainHero) xpMessages.Add($"{rogueryXP} Roguery XP");

                var combatSkills = new List<SkillObject> { DefaultSkills.OneHanded, DefaultSkills.TwoHanded, DefaultSkills.Throwing, DefaultSkills.Bow, DefaultSkills.Crossbow };
                var randomSkill = combatSkills[MBRandom.RandomInt(combatSkills.Count)];
                int combatXP = (int)(30 * multiplier);
                hero.AddSkillXp(randomSkill, combatXP);
                if (hero == Hero.MainHero) xpMessages.Add($"{combatXP} {randomSkill.Name} XP");
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
                InformationManager.DisplayMessage(new InformationMessage($"Gained: {string.Join(", ", xpMessages)}"));
            }
        }

        // ==========================================
        // AI WORK LOGIC (HOURLY)
        // ==========================================

        private void ProcessAIHourlyWork(Settlement settlement)
        {
            if (settlement.Town == null) return;

            // 1. Gather Workforce
            // - Wanderers in Tavern (HeroesWithoutParty)
            // - Nobles in Keep (HeroesWithoutParty)
            // - Visiting Party Leaders (Parties)

            // 1. Gather Workforce
            // - Wanderers in Tavern (HeroesWithoutParty)
            // - Nobles in Keep (HeroesWithoutParty)
            // - Visiting Party Leaders (Parties)

            _cachedWorkers.Clear();

            if (settlement.HeroesWithoutParty != null)
            {
                foreach (var hero in settlement.HeroesWithoutParty)
                {
                if (hero.IsAlive && (hero.IsWanderer || hero.IsLord || hero.IsNotable))
                {
                    _cachedWorkers.Add(hero);
                }
                }
            }

            if (settlement.Parties != null)
            {
                foreach (var party in settlement.Parties)
                {
                    if (party.LeaderHero != null && party.LeaderHero != Hero.MainHero && party.LeaderHero.Clan != Clan.PlayerClan)
                    {
                        _cachedWorkers.Add(party.LeaderHero);
                    }
                }
            }

            // 2. Process Work for Each
            foreach (var worker in _cachedWorkers)
            {
                try
                {
                   // Determine Job - Deterministic based on ID + Shift Block
                   long shiftBlock = (long)(CampaignTime.Now.ToHours / (double)_settings.ShiftHours);
                   int seed = worker.Id.GetHashCode() + (int)shiftBlock;
                   
                   // AI Decision Logic:
                   // 1. Honor Retention: Check if they should KEEP their job from last hour
                   JobDef chosenJob = null;
                   bool keptJob = false;
                   
                   if (_aiLastJob.ContainsKey(worker))
                   {
                       string lastId = _aiLastJob[worker];
                       int honor = worker.GetTraitLevel(DefaultTraits.Honor);
                       // Base 50% + 25% * Honor. (+2 Honor = 100% Retention)
                       float retentionChance = 0.5f + (honor * 0.25f); 
                       
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
                       chosenJob = SelectJobForAI(worker, seed, settlement.Town);
                       if (chosenJob != null) _aiLastJob[worker] = chosenJob.Id;
                   }
                   
                   if (chosenJob != null)
                   {
                       // Apply Hourly Effects
                       ApplyJobEffects(settlement.Town, chosenJob.Id, _settings.AiEffectMagnitude);
                       
                       // Wage: Standardized Formula (Base + Prosperity) * JobMultiplier * Seasonal
                       int wage = GetWageForJob(settlement.Town, chosenJob);
                       GiveGoldAction.ApplyBetweenCharacters(null, worker, wage);

                       // Thug Risk (AI)
                       if (chosenJob.IsThug)
                       {
                           CheckForArrest(settlement.Town, worker);
                       }

                       // Check for Shift Rewards (End of Shift)
                       // If this is the last hour of the shift block (hours % shift == shift-1)
                       if ((long)CampaignTime.Now.ToHours % _settings.ShiftHours == (_settings.ShiftHours - 1))
                       {
                           // Apply Shift Bonus Effects 
                           // 2x AI base
                           ApplyJobEffects(settlement.Town, chosenJob.Id, _settings.AiEffectMagnitude * 2f);
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
                // Mental jobs fluctuate more (0.5 to 2.0 default)
                // Physical jobs stable (0.8 to 1.2 default)
                
                bool isMental = job.Id == "official" || job.Id == "physician" || job.Id == "artisan" || job.Id == "instructor";
                
                float baseFluctuation = isMental ? 0.75f : 0.2f; // Width from center
                float volatility = baseFluctuation * _settings.SeasonalVolatility;
                
                float min = 1.0f - volatility;
                float max = 1.0f + volatility;
                
                // Clamp to sane values
                if (min < 0.1f) min = 0.1f;
                
                float val = min + (MBRandom.RandomFloat * (max - min));
                _seasonalMultipliers[job.Id] = val;
            }
        }

        private JobDef SelectJobForAI(Hero hero, int seed, Town town)
        {
            List<JobDef> validJobs = new List<JobDef>();
            int mercy = hero.GetTraitLevel(DefaultTraits.Mercy);

            foreach (var job in _jobs)
            {
                if (job.IsGuard && mercy < 0) continue;
                if (job.IsThug && mercy > 0) continue;
                validJobs.Add(job);
            }

            if (validJobs.Count == 0) return null;

            // Logic Refactor: Weighted Selection based on Skills
            JobDef bestJob = null;
            float bestScore = -1f;
            System.Random rng = new System.Random(seed);

            foreach (var job in validJobs)
            {
                float score = 10f; 
                
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
                else if (job.Skills != null)
                {
                    foreach (var skill in job.Skills)
                    {
                        score += hero.GetSkillValue(skill) * 1.5f;
                    }
                }
                
                // Deterministic Jitter (20%) using the seed to prevent randomness flicker per frame
                float jitter = (float)rng.NextDouble() * 20f; 
                score += jitter;

                // POVERTY LOGIC:
                // If poor (< 5000g), prioritize High Wage Multipliers heavily
                if (hero.Gold < 5000)
                {
                     // (1.5 - 1.0) * 100 = +50 score. Massive boost for Thug/Official.
                     score += (job.WageMultiplier - 1.0f) * 100f; 
                }

                // HUNGER LOGIC:
                // If party is starving, prioritize Official (Food)
                if (hero.PartyBelongedTo != null && hero.PartyBelongedTo.Food < 5)
                {
                    if (job.Id == "official") score += 200f; // Massive priority to survive
                }

                // POLITICAL LOGIC:
                // If friend of town owner -> Guard/Artisan (+Security/Prosperity)
                // If enemy/grudge -> Thug (-Security)
                if (town.OwnerClan != null)
                {
                    int relation = hero.GetRelation(town.OwnerClan.Leader);
                    if (relation > 10) // Friend
                    {
                        if (job.IsGuard || job.Id == "artisan" || job.Id == "official") score += relation * 2f;
                    }
                    else if (relation < -10 || hero.GetTraitLevel(DefaultTraits.Mercy) < 0) // Grudge/Cruel
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

        // Caching Reflection for AddMilitia
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
                 for (int i = 0; i < party.MemberRoster.Count; i++)
                 {
                     var element = party.MemberRoster.GetElementCopyAtIndex(i);
                     party.MemberRoster.AddXpToTroop(element.Character, amount);
                 }
             }
        }

        private void AddGarrisonXp(Town town, int amount)
        {
             if (town.GarrisonParty != null && town.GarrisonParty.MemberRoster != null)
             {
                 for (int i = 0; i < town.GarrisonParty.MemberRoster.Count; i++)
                 {
                     var element = town.GarrisonParty.MemberRoster.GetElementCopyAtIndex(i);
                     town.GarrisonParty.MemberRoster.AddXpToTroop(element.Character, amount);
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
    }
}
