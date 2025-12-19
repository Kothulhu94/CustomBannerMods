using System;
using System.Linq;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.ObjectSystem;
using Serilog;

namespace HappyParty
{
    public class CustomWandererSpawnBehavior : CampaignBehaviorBase
    {
        private readonly GlobalSettings _settings;
        private readonly ILogger _logger;

        public CustomWandererSpawnBehavior(GlobalSettings settings, ILogger logger)
        {
            _settings = settings;
            _logger = logger.ForContext<CustomWandererSpawnBehavior>();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            // No saved data
        }

        private void OnDailyTick()
        {
            SpawnMissingWanderers();
        }

        private void SpawnMissingWanderers()
        {
            try
            {
                int currentWanderers = 0;
                int totalHeroesToCheck = 0;

                // Count active, UNHIRED wanderers
                foreach (var hero in Hero.AllAliveHeroes)
                {
                    totalHeroesToCheck++;
                    if (hero.IsWanderer && 
                        hero.HeroState != Hero.CharacterStates.Disabled && 
                        hero.HeroState != Hero.CharacterStates.Dead &&
                        hero.CompanionOf == null) // Only count those not currently hired
                    {
                        currentWanderers++;
                    }
                }
                
                int targetCount = _settings.TargetWandererCount;
                // User requested "infinite spawning" to ensure availability.
                // The hard cap is removed. We rely on TavernCleaner to clear out the hired ones so they don't clog taverns.
                if (currentWanderers >= targetCount) 
                {
                    return;
                }

                int needed = targetCount - currentWanderers;
                int toSpawn = Math.Min(needed, _settings.DailySpawnCap);

                if (_settings.DebugMode)
                    _logger.Information($"Validating Wanderer Count. Current: {currentWanderers}, Target: {targetCount}, Spawning: {toSpawn}");

                if (toSpawn <= 0) return;

                var templates = new List<CharacterObject>();
                foreach (var obj in Campaign.Current.ObjectManager.GetObjectTypeList<CharacterObject>())
                {
                    if (obj.IsTemplate && obj.Occupation == Occupation.Wanderer && (obj.Culture != null))
                    {
                        templates.Add(obj);
                    }
                }
                
                if (templates.Count == 0)
                {
                    _logger.Warning("No wanderer templates found!");
                    return;
                }

                int spawned = 0;
                for (int i = 0; i < toSpawn; i++)
                {
                    CharacterObject template = templates[MBRandom.RandomInt(templates.Count)];
                    if (template == null) continue;

                    Settlement settlement = Settlement.All.Where(s => s.IsTown && s.Culture == template.Culture).OrderBy(x => MBRandom.RandomFloat).FirstOrDefault();
                    if (settlement == null) settlement = Settlement.All.Where(s => s.IsTown).OrderBy(x => MBRandom.RandomFloat).FirstOrDefault();

                    if (settlement != null)
                    {
                        if (_settings.DebugMode)
                            _logger.Debug($"Attempting to spawn template '{template.Name}' at '{settlement.Name}'...");
                        
                        Hero newHero = HeroCreator.CreateSpecialHero(template, settlement, null, null, -1);
                        newHero.ChangeState(Hero.CharacterStates.Active);
                        
                        if (_settings.DebugMode)
                            _logger.Information($"SUCCESS - Spawned {newHero.Name} at {settlement.Name}");
                        
                        spawned++;
                    }
                    else
                    {
                        _logger.Warning($"FAILED to find settlement for template '{template.Name}'");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error in SpawnMissingWanderers");
            }
        }

        public void ValidateWanderer(Hero hero)
        {
            try
            {
                if (hero == null || !hero.IsWanderer) return;

                bool changed = false;

                if (hero.BattleEquipment == null || hero.BattleEquipment.IsEmpty())
                {
                    _logger.Warning($"Warning: Wanderer {hero.Name} has no equipment.");
                }

                if (hero.HeroState == Hero.CharacterStates.Active)
                {
                    // Valid
                }
                else
                {
                    if (hero.IsAlive && hero.Clan == null)
                    {
                         hero.ChangeState(Hero.CharacterStates.Active);
                         changed = true;
                    }
                }

                if (changed) 
                {
                    if (_settings.DebugMode) _logger.Information($"Validated and Fixed Wanderer: {hero.Name}");
                }
                else 
                {
                    if (_settings.DebugMode) _logger.Debug($"Validated Wanderer: {hero.Name} (OK)");
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error validating wanderer {hero?.Name}");
            }
        }
    }
}

