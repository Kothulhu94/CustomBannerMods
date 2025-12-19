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
        }

        private List<JobDef> _jobs;

        public TownJobBehavior(ILogger logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
            _jobs = new List<JobDef>();
        }

        private void InitializeJobs()
        {
            if (_jobs.Count > 0) return;
            int xp = _settings.TownJobBaseXp;
            _jobs.Add(new JobDef { Id = "guard", Name = "Guard Duty", Description = "Patrol the walls and keep order. (Athletics + Combat)", IsGuard = true, TotalXp = xp });
            _jobs.Add(new JobDef { Id = "thug", Name = "Gang Enforcer", Description = "Muscle work for local gangs. (Roguery + Combat)", IsThug = true, TotalXp = xp });
            _jobs.Add(new JobDef { Id = "artisan", Name = "Artisan & Builder", Description = "Smithing and construction work.", Skills = new List<SkillObject> { DefaultSkills.Crafting, DefaultSkills.Engineering }, TotalXp = xp });
            _jobs.Add(new JobDef { Id = "instructor", Name = "Military Instructor", Description = "Drill troops and teach tactics.", Skills = new List<SkillObject> { DefaultSkills.Leadership, DefaultSkills.Tactics }, TotalXp = xp });
            _jobs.Add(new JobDef { Id = "outrider", Name = "Outrider", Description = "Scout the perimeter and ride patrols.", Skills = new List<SkillObject> { DefaultSkills.Scouting, DefaultSkills.Riding }, TotalXp = xp });
            _jobs.Add(new JobDef { Id = "physician", Name = "Court Physician", Description = "Tend to the sick and entertain the court.", Skills = new List<SkillObject> { DefaultSkills.Medicine, DefaultSkills.Charm }, TotalXp = xp });
            _jobs.Add(new JobDef { Id = "official", Name = "Town Official", Description = "Manage trade ledgers and supplies.", Skills = new List<SkillObject> { DefaultSkills.Trade, DefaultSkills.Steward }, TotalXp = xp });
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
            
            // Apply Effects (1.0 default hourly magnitude)
            ApplyJobEffects(town, _currentJobId, 1.0f);
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
                    AddMilitia(town, effectVal);
                    AddGarrisonXp(town, (int)(2 * magnitude));
                }
                else if (jobId == "instructor")
                {
                    AddGarrisonXp(town, (int)(2 * magnitude));
                    AddMilitia(town, effectVal);
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

            List<Hero> workers = new List<Hero>();

            if (settlement.HeroesWithoutParty != null)
            {
                foreach (var hero in settlement.HeroesWithoutParty)
                {
                    if (hero.IsAlive && (hero.IsWanderer || hero.IsLord || hero.IsNotable))
                    {
                        workers.Add(hero);
                    }
                }
            }

            if (settlement.Parties != null)
            {
                foreach (var party in settlement.Parties)
                {
                    if (party.LeaderHero != null && party.LeaderHero != Hero.MainHero && party.LeaderHero.Clan != Clan.PlayerClan)
                    {
                        workers.Add(party.LeaderHero);
                    }
                }
            }

            // 2. Process Work for Each
            foreach (var worker in workers)
            {
                try
                {
                   // Determine Job - Deterministic based on ID + Shift Block
                   long shiftBlock = (long)(CampaignTime.Now.ToHours / (double)_settings.ShiftHours);
                   int seed = worker.Id.GetHashCode() + (int)shiftBlock;
                   JobDef chosenJob = SelectJobForAI(worker, seed);
                   
                   if (chosenJob != null)
                   {
                       // Apply Hourly Effects
                       ApplyJobEffects(settlement.Town, chosenJob.Id, _settings.AiEffectMagnitude);
                       // XP (100%)
                       ApplyJobXP(worker, chosenJob.Id, 1.0f);

                       // Wage (Optional: give gold to AI? Improves their economy)
                       GiveGoldAction.ApplyBetweenCharacters(null, worker, 20); 

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

        private JobDef SelectJobForAI(Hero hero, int seed)
        {
            System.Random rng = new System.Random(seed);
            List<JobDef> validJobs = new List<JobDef>();
            int mercy = hero.GetTraitLevel(DefaultTraits.Mercy);

            foreach (var job in _jobs)
            {
                if (job.IsGuard && mercy < 0) continue;
                if (job.IsThug && mercy > 0) continue;
                validJobs.Add(job);
            }

            if (validJobs.Count == 0) return null;
            return validJobs[rng.Next(validJobs.Count)];
        }

        private void AddMilitia(Town town, float amount)
        {
            try
            {
                var flags = System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance;
                
                var prop = typeof(Town).GetProperty("Militia", flags);
                if (prop != null && prop.CanWrite)
                {
                    prop.SetValue(town, (float)prop.GetValue(town) + amount);
                    return;
                }
                
                if (town.Settlement != null)
                {
                    var sProp = typeof(Settlement).GetProperty("Militia", flags);
                    if (sProp != null && sProp.CanWrite)
                    {
                        sProp.SetValue(town.Settlement, (float)sProp.GetValue(town.Settlement) + amount);
                        return;
                    }
                }

                var field = typeof(Fief).GetField("_militia", flags) ?? typeof(Fief).GetField("<Militia>k__BackingField", flags);
                if (field != null)
                {
                    float current = (float)field.GetValue(town);
                    field.SetValue(town, current + amount);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "HonestWork AddMilitia Error");
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
    }
}
