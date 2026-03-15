using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using Serilog;

namespace HappyParty
{
    public class CompanionManagementBehavior : CampaignBehaviorBase
    {
        private readonly GlobalSettings _settings;
        private readonly ILogger _logger;

        public CompanionManagementBehavior(GlobalSettings settings, ILogger logger)
        {
            _settings = settings;
            _logger = logger.ForContext<CompanionManagementBehavior>();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.SettlementEntered.AddNonSerializedListener(this, OnSettlementEntered);
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnSettlementEntered(MobileParty mobileParty, Settlement settlement, Hero hero)
        {
            try
            {
                // Only for AI Lord parties
                if (mobileParty == null || mobileParty.IsMainParty || !mobileParty.IsLordParty) return;
                
                Hero leader = mobileParty.LeaderHero;
                if (leader == null || leader.Clan == null) return;

                // 1. Check for Clan Companions in the settlement
                if (settlement.HeroesWithoutParty != null && settlement.HeroesWithoutParty.Count > 0)
                {
                    // Snapshot to avoid modification errors
                    var companionsInTown = settlement.HeroesWithoutParty.Where(h => h.IsWanderer && h.Clan == leader.Clan).ToList();

                    foreach (var companion in companionsInTown)
                    {
                        if (mobileParty.MemberRoster.TotalManCount < mobileParty.Party.PartySizeLimit)
                        {
                            if (_settings.DebugMode)
                                _logger.Information($"[CompanionManagement] Re-hired {companion.Name} for {leader.Clan.Name} in {settlement.Name}");

                            LeaveSettlementAction.ApplyForCharacterOnly(companion);
                            AddHeroToPartyAction.Apply(companion, mobileParty);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error in CompanionManagementBehavior.OnSettlementEntered");
            }
        }

        private void OnDailyTick()
        {
            try
            {
                foreach (var hero in Hero.AllAliveHeroes)
                {
                    // Target AI-hired wanderers
                    if (hero.IsWanderer && hero.Clan != null && hero.Clan != Clan.PlayerClan)
                    {
                        ProcessAICOMpanion(hero);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error in CompanionManagementBehavior.OnDailyTick");
            }
        }

        private void ProcessAICOMpanion(Hero hero)
        {
            Hero leader = hero.Clan.Leader;
            
            // 1. Graceful Release Check
            // If leader is dead, or the clan is eliminated, release the hero.
            if (leader == null || !leader.IsAlive || hero.Clan.IsEliminated)
            {
                ReleaseHero(hero, "Clan Inactive/Leader Dead");
                return;
            }

            // 2. Capture Check
            // If leader has been a prisoner for a while (native doesn't give duration easily, but we can check state)
            // or if the hero themselves is a prisoner (native handles this, but safety first)
            if (leader.IsPrisoner)
            {
                // We'll give it a bit of time, but if the leader is captured, companions are effectively parentless.
                // For now, let's keep them in the clan but TavernCleaner will handle them if they are stuck.
                // Or we release if leader is prisoner to allow them to be hired elsewhere.
                // Decision: Release if leader is prisoner to keep the "Living World" moving.
                ReleaseHero(hero, "Leader Captured");
                return;
            }

            // 3. Catch-up Logic
            // If hero is NOT in a party and NOT a prisoner, try to teleport/move them to leader.
            if (hero.PartyBelongedTo == null && !hero.IsPrisoner && hero.GovernorOf == null)
            {
                if (leader.PartyBelongedTo != null && leader.PartyBelongedTo.IsActive)
                {
                    MobileParty leaderParty = leader.PartyBelongedTo;
                    if (leaderParty.MemberRoster.TotalManCount < leaderParty.Party.PartySizeLimit)
                    {
                        if (_settings.DebugMode)
                            _logger.Information($"[CompanionManagement] {hero.Name} is catching up with {leader.Name}.");

                        LeaveSettlementAction.ApplyForCharacterOnly(hero);
                        AddHeroToPartyAction.Apply(hero, leaderParty);
                    }
                }
            }
        }

        private void ReleaseHero(Hero hero, string reason)
        {
            try
            {
                if (_settings.DebugMode)
                    _logger.Information($"[CompanionManagement] Releasing {hero.Name} from {hero.Clan.Name} due to {reason}.");

                TavernCleanerBehavior.ForceRemoveFromClan(hero);
                
                if (hero.CurrentSettlement == null)
                {
                     // If in the middle of nowhere, put them in a neutral state for TavernCleaner to eventually handle 
                     // or native to respawn if they are "Disabled".
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Failed to release {hero.Name}");
            }
        }
    }
}
