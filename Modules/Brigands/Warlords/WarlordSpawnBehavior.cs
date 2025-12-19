using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Party.PartyComponents;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using Microsoft.Extensions.Logging;

namespace Brigands.Warlords
{
    public class WarlordSpawnBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<WarlordSpawnBehavior> _logger;
        private readonly GlobalSettings _settings;

        public WarlordSpawnBehavior(ILogger<WarlordSpawnBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.WeeklyTickEvent.AddNonSerializedListener(this, new Action(this.OnWeeklyTick));
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, new Action(this.OnHourlyTick));
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnHourlyTick()
        {
            try
            {
                 Clan syndicate = Clan.All.Find(x => x.StringId == "TheSyndicate");
                 if (syndicate == null) return;

                 var stuckHeroes = syndicate.Heroes.Where(h => 
                     h.IsAlive && 
                     !h.IsPrisoner && 
                     h.PartyBelongedTo == null && 
                     h.HeroState == Hero.CharacterStates.Active
                 ).ToList();

                 if (stuckHeroes.Count > 0)
                 {
                     if (_settings.DebugMode)
                        _logger.LogInformation($"Found {stuckHeroes.Count} stuck Syndicate Warlords. Redeploying...");
                     
                     var hideouts = Settlement.All.Where(s => s.IsHideout && s.IsActive).ToList();

                     foreach (var hero in stuckHeroes)
                     {
                         try
                         {
                             if (MBRandom.RandomInt(100) > _settings.WarlordRespawnChance) continue; 

                             Settlement targetSpawn = null;
                             if (hideouts.Count > 0) targetSpawn = hideouts[MBRandom.RandomInt(hideouts.Count)];
                             else targetSpawn = Settlement.All.FirstOrDefault(s => s.IsTown);

                             if (targetSpawn != null)
                             {
                                 if (_settings.DebugMode)
                                     _logger.LogInformation($"Redeploying {hero.Name} to {targetSpawn.Name}...");
                                 
                                 TeleportHeroAction.ApplyImmediateTeleportToSettlement(hero, targetSpawn);
                                 
                                 CreateWarlordParty(syndicate, hero, targetSpawn);
                             }
                         }
                         catch (Exception ex)
                         {
                             _logger.LogError(ex, $"Failed to redeploy {hero.Name}");
                         }
                     }
                 }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in WarlordSpawnBehavior.OnDailyTick");
            }
        }

        private void OnWeeklyTick()
        {
            try
            {
                Clan syndicate = Clan.All.Find(x => x.StringId == "TheSyndicate");
                if (syndicate == null)
                {
                    if (_settings.DebugMode) _logger.LogWarning("Syndicate clan not found. Skipping spawn.");
                    return;
                }

                foreach (Settlement settlement in Settlement.All)
                {
                    if (settlement.IsTown && settlement.HeroesWithoutParty.Count > 0)
                    {
                        foreach (Hero hero in settlement.HeroesWithoutParty.ToList())
                        {
                            if (hero.IsWanderer && hero.Clan == null && hero.PartyBelongedTo == null)
                            {
                                bool isCruel = hero.GetTraitLevel(DefaultTraits.Mercy) < 0;
                                bool highRoguery = hero.GetSkillValue(DefaultSkills.Roguery) >= 60;

                                if (isCruel && highRoguery)
                                {
                                    if (MBRandom.RandomInt(100) < _settings.WarlordSpawnChance)
                                    {
                                        if (_settings.DebugMode)
                                            _logger.LogInformation($"Spawning Warlord: {hero.Name} in {settlement.Name}");
                                        RecruitAndSpawnWarlord(syndicate, hero, settlement);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                 _logger.LogError(ex, "Error in WarlordSpawnBehavior.OnWeeklyTick");
            }
        }

        private void RecruitAndSpawnWarlord(Clan syndicate, Hero hero, Settlement settlement)
        {
            try 
            {
                AddCompanionAction.Apply(syndicate, hero);
                CreateWarlordParty(syndicate, hero, settlement);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in RecruitAndSpawnWarlord");
            }
        }

        private void CreateWarlordParty(Clan syndicate, Hero hero, Settlement settlement)
        {
            try
            {
                Vec2 vec2Pos = new Vec2(settlement.GatePosition.X, settlement.GatePosition.Y);
                CampaignVec2 spawnPos = new CampaignVec2(vec2Pos, true);

                MobileParty party = LordPartyComponent.CreateLordParty(
                    "syndicate_warlord_" + hero.StringId,
                    hero,
                    spawnPos,
                    5.0f,
                    settlement,
                    hero
                );

                if (party != null)
                {
                    party.SetPartyUsedByQuest(false);
                    party.ItemRoster.AddToCounts(DefaultItems.Grain, 20); 
                    party.RecentEventsMorale = 100f; 
                    
                    if (party.Ai != null)
                    {
                        party.Ai.SetDoNotMakeNewDecisions(false);
                    }
                    party.SetMoveModeHold();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error creating party for {hero.Name}");
            }
        }
    }
}

