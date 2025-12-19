using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Party.PartyComponents;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using Serilog;

namespace HappyParty
{
    public class TavernCleanerBehavior : CampaignBehaviorBase
    {
        private readonly GlobalSettings _settings;
        private readonly ILogger _logger;

        public TavernCleanerBehavior(GlobalSettings settings, ILogger logger)
        {
            _settings = settings;
            _logger = logger.ForContext<TavernCleanerBehavior>();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnHourlyTick()
        {
            if (CampaignTime.Now.CurrentHourInDay != 2) return;

            if (_settings.DebugMode) _logger.Information("START: TavernCleanerBehavior.OnHourlyTick");
            
            try
            {
                int processed = 0;
                int moved = 0;
                int spawned = 0;

                foreach (var settlement in Settlement.All)
                {
                    if (settlement.HeroesWithoutParty.Count > 0)
                    {
                        foreach (var hero in settlement.HeroesWithoutParty.ToList())
                        {
                            try
                            {
                                bool isTargetType = hero.IsWanderer || hero.Occupation == Occupation.Lord;

                                if (isTargetType && 
                                    !hero.IsPrisoner &&
                                    hero.GovernorOf == null &&
                                    (hero.Clan == null || (!hero.Clan.IsEliminated && hero.Clan != Clan.PlayerClan && hero.Clan.StringId != "TheSyndicate")))
                                {
                                    processed++;
                                    
                                    MobileParty targetParty = null;

                                    if (hero.Clan != null && hero.Clan.Leader != null && 
                                        hero.Clan.Leader.PartyBelongedTo != null && 
                                        hero.Clan.Leader.PartyBelongedTo.IsActive)
                                    {
                                        targetParty = hero.Clan.Leader.PartyBelongedTo;
                                    }

                                    if (targetParty == null && hero.Clan != null)
                                    {
                                        foreach(var warParty in hero.Clan.WarPartyComponents)
                                        {
                                            if (warParty.MobileParty != null && warParty.MobileParty.IsActive)
                                            {
                                                targetParty = warParty.MobileParty;
                                                break; 
                                            }
                                        }
                                    }

                                    if (targetParty != null)
                                    {
                                        if (_settings.DebugMode)
                                            _logger.Information($"TavernCleaner: Found stuck hero {hero.Name} in {settlement.Name}. Moving to {targetParty.Name}.");

                                        LeaveSettlementAction.ApplyForCharacterOnly(hero);
                                        AddHeroToPartyAction.Apply(hero, targetParty);
                                        moved++;
                                    }
                                    else
                                    {
                                        if (spawned >= 5) // Safety Cap per tick
                                        {
                                             continue;
                                        }

                                        if (_settings.DebugMode)
                                        {
                                            int activeParties = 0;
                                            foreach(var p in hero.Clan.WarPartyComponents) 
                                                if (p.MobileParty != null && p.MobileParty.IsActive) activeParties++;
                                                
                                            _logger.Warning($"TavernCleaner: Hero {hero.Name} (Clan: {hero.Clan.Name}) is stuck in {settlement.Name}. Attempting to spawn rescue party. (Active Clan Parties: {activeParties})");
                                        }

                                        // FIX: Instead of retiring, we allow them to FORM A NEW PARTY.
                                        // "pick one from each clan to start a party and have the extra join it"
                                        if (hero.IsWanderer && hero.Clan != null)
                                        {
                                            try
                                            {
                                                // Check if we should spawn (Soft limit check could go here, but user wants them out of the tavern)
                                                // We create a new Lord Party. 
                                                // Note: If the clan is at the party limit, the AI might disband this soon. 
                                                // But this at least gets them out of the tavern and into the world loop.
                                                
                                                // Use static factory method which is standard for LordPartyComponent
                                                MobileParty newParty = LordPartyComponent.CreateLordParty(
                                                    hero.StringId + "_party_" + MBRandom.RandomInt(10000), 
                                                    hero,
                                                    settlement.GatePosition, 
                                                    5f,
                                                    settlement,
                                                    hero
                                                );

                                                if (newParty != null)
                                                {
                                                    // Give them some initial strength so they don't instant-die
                                                    CharacterObject recruit = hero.Culture.BasicTroop;
                                                    if (recruit != null)
                                                    {
                                                        newParty.MemberRoster.AddToCounts(recruit, 20);
                                                    }
                                                    newParty.ItemRoster.AddToCounts(DefaultItems.Grain, 20);
                                                    
                                                    // No need to AddHeroToPartyAction, CreateLordParty does it.
                                                    // No need to SetLeader, CreateLordParty does it.

                                                    // Set initial behavior (Hold position, allow Campaign AI to take over next tick)
                                                    newParty.SetMoveModeHold();

                                                    spawned++;
                                                    if (_settings.DebugMode) 
                                                        _logger.Information($"TavernCleaner: Spawned NEW party for stuck wanderer {hero.Name}. (Chaos Mode!)");
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                _logger.Error(ex, $"Failed to spawn party for stuck wanderer {hero.Name}");
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                 _logger.Error(ex, $"Error processing hero {hero.Name} in TavernCleaner");
                            }
                        }
                    }
                }
                
                // Count total hirable wanderers for reporting
                int hirableWanderers = 0;
                foreach (var hero in Hero.AllAliveHeroes)
                {
                    if (hero.IsWanderer && hero.Clan == null && hero.HeroState != Hero.CharacterStates.Disabled && hero.HeroState != Hero.CharacterStates.Dead)
                    {
                        hirableWanderers++;
                    }
                }

                if (_settings.DebugMode)
                    _logger.Information($"TavernCleaner Report: Found {processed} stuck, Moved {moved}, Spawned {spawned}. Hirable Wanderers: {hirableWanderers}/{_settings.TargetWandererCount}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "CRASH in TavernCleanerBehavior.OnHourlyTick");
            }
        }
    }
}
