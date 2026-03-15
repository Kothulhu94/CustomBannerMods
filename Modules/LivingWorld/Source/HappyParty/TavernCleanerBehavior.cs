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
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
             FixGhostSettlementHeroes();
             
             // Bugged Party Fix (Run first so disbanding puts them in settlement for cleanup)
             FixBuggedWandererParties();
             
             // Stuck Companion Fix (Run on session start to clean up save state)
             FixStuckCompanions();
        }

        private void FixGhostSettlementHeroes()
        {
             try
             {
                 int ghostsFound = 0;
                 foreach(var settlement in Settlement.All)
                 {
                     if (settlement.HeroesWithoutParty != null && settlement.HeroesWithoutParty.Count > 0)
                     {
                         // Use ToList() to snapshot the list and avoid modification errors
                         var list = settlement.HeroesWithoutParty.ToList();
                         foreach(var hero in list)
                         {
                             // CORE CHECK: Is the hero actually here?
                             if (hero.CurrentSettlement != settlement)
                             {
                                 // Fix ghost hero desync: Hero listed in settlement but current position is mismatch.
                                 LeaveSettlementAction.ApplyForCharacterOnly(hero);
                                 ghostsFound++;
                             }
                         }
                     }
                 }
                 if (ghostsFound > 0 && _settings.DebugMode)
                      _logger.Information($"[GhostFix] Removed {ghostsFound} ghost heroes from settlement lists.");
             }
             catch(Exception ex)
             {
                 _logger.Error(ex, "Error in FixGhostSettlementHeroes");
             }
        }

        private void OnDailyTick()
        {
            if (_settings.DebugMode) _logger.Information("START: TavernCleanerBehavior.OnDailyTick");
            
            try
            {
                // REDUCED: We no longer aggressively "Shoo" AI-clan companions here.
                // The new CompanionManagementBehavior handles their lifecycle logically.
                // We only perform stability maintenance.
                
                // Ghost Prisoner Fix (Run daily is sufficient)
                FixGhostPrisoners();

                if (_settings.DebugMode)
                    _logger.Information("TavernCleaner Report: Maintenance completed.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "CRASH in TavernCleanerBehavior.OnDailyTick");
            }
        }

        private void FixStuckCompanions()
        {
            try
            {
                int fixedCompanions = 0;
                foreach (var settlement in Settlement.All)
                {
                    if (settlement.HeroesWithoutParty != null && settlement.HeroesWithoutParty.Count > 0)
                    {
                        var list = settlement.HeroesWithoutParty.ToList();
                        foreach (var hero in list)
                        {
                            if (hero.IsWanderer && hero.Clan != null && hero.Clan != Clan.PlayerClan)
                            {
                                // Condition: Wanderer in AI Clan, sitting in settlement, not leading party, not governor, not prisoner.
                                if (hero.PartyBelongedTo == null && 
                                    hero.GovernorOf == null && 
                                    !hero.IsPrisoner)
                                {
                                     // Fire stuck AI-hired wanderers to fix "Ghost Lord" bugs (blocking hiring/voting).
                                     if (_settings.DebugMode)
                                         _logger.Information($"[StuckCompanionFix] Firing {hero.Name} from {hero.Clan.Name} (Stuck in {settlement.Name})");

                                     if (hero.Clan != null)
                                     {
                                         // Force remove from clan to reset to neutral wanderer
                                         ForceRemoveFromClan(hero);
                                         fixedCompanions++;
                                     }
                                }
                            }
                        }
                    }
                }
                 if (fixedCompanions > 0 && _settings.DebugMode)
                      _logger.Information($"[StuckCompanionFix] Fixed {fixedCompanions} stuck companions.");
            }
            catch(Exception ex)
            {
                _logger.Error(ex, "Error in FixStuckCompanions");
            }
        }


        private void FixBuggedWandererParties()
        {
            try
            {
                int disbanded = 0;
                // Snapshot list to allow modification
                var activeParties = MobileParty.All.ToList();

                foreach (var party in activeParties)
                {
                    if (party.IsLordParty && party.LeaderHero != null)
                    {
                        var leader = party.LeaderHero;

                        // Detect Bugged Party: Active party led by non-player Wanderer (not promoted Lord).
                        if (leader.IsWanderer && 
                            leader.Clan != Clan.PlayerClan && 
                            leader.Occupation == Occupation.Wanderer)
                        {
                            if (_settings.DebugMode)
                                _logger.Information($"[PartyFix] Disbanding bugged Wanderer party: {party.Name} (Leader: {leader.Name})");

                            // Disband the party using confirmed DestroyPartyAction
                             DestroyPartyAction.Apply(null, party);
                             disbanded++;
                        }
                    }
                }

                if (disbanded > 0 && _settings.DebugMode)
                    _logger.Information($"[PartyFix] Disbanded {disbanded} invalid wanderer parties.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error in FixBuggedWandererParties");
            }
        }
        
        // Helper to force remove from clan via reflection since Actions are unreliable in this context
        public static void ForceRemoveFromClan(Hero hero)
        {
            try
            {
                if (hero.Clan == null) return;
                
                // Try Property Setter
                var clanProp = typeof(Hero).GetProperty("Clan", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                if (clanProp != null && clanProp.CanWrite)
                {
                    clanProp.SetValue(hero, null);
                    return;
                }
                
                // Try Backing Field
                var clanField = typeof(Hero).GetField("_clan", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                if (clanField != null)
                {
                    clanField.SetValue(hero, null);
                }
            }
            catch(Exception) {  }
        }

        private void FixGhostPrisoners()
        {
            int ghostPrisonersFixed = 0;
            foreach (var hero in Hero.AllAliveHeroes)
            {
                // Release "Ghost Prisoners" (Flagged as Prisoner, but no Captor Party)
                if (hero.IsPrisoner && hero.PartyBelongedToAsPrisoner == null)
                {
                    try 
                    {
                        if (_settings.DebugMode)
                            _logger.Warning($"[GhostPrisonerFix] Found stuck prisoner {hero.Name} (Clan: {hero.Clan?.Name}). Releasing...");

                        // Force release
                        EndCaptivityAction.ApplyByEscape(hero, null);
                        ghostPrisonersFixed++;
                    }
                    catch (Exception ex)
                    {
                        _logger.Error(ex, $"Failed to release ghost prisoner {hero.Name}");
                    }
                }
            }
            if (ghostPrisonersFixed > 0 && _settings.DebugMode)
            {
                _logger.Information($"[GhostPrisonerFix] Total ghosts released this daily tick: {ghostPrisonersFixed}");
            }
        }
    }
}
