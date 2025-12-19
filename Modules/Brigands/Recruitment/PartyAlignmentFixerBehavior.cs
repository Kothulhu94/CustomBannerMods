using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;
using Microsoft.Extensions.Logging;
using TaleWorlds.CampaignSystem.Actions;

namespace Brigands.Recruitment
{
    public class PartyAlignmentFixerBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<PartyAlignmentFixerBehavior> _logger;
        private readonly GlobalSettings _settings;

        public PartyAlignmentFixerBehavior(ILogger<PartyAlignmentFixerBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(OnSessionLaunched));
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
        }

        private void OnDailyTick()
        {
            try
            {
                foreach (var party in MobileParty.All.ToList())
                {
                    if (party == null || !party.IsActive) continue;

                    if (party.MapFaction != null && party.MapFaction.IsBanditFaction)
                    {
                        var leader = party.LeaderHero;
                        
                        // Condition: Leader is a Noble/Wanderer who actually belongs to a Non-Bandit Clan
                        if (leader != null && leader.Clan != null && !leader.Clan.IsBanditFaction && !leader.Clan.IsEliminated)
                        {
                            if (_settings.DebugMode)
                                _logger.LogInformation($"Fixing Glitched Party: {party.Name} (Leader: {leader.Name}, Clan: {leader.Clan.Name})");

                            try
                            {
                                party.ActualClan = leader.Clan;
                                
                                if (_settings.DebugMode)
                                     _logger.LogInformation($" > Fixed {party.Name} is now {party.MapFaction.Name}");
                            }
                            catch (Exception ex)
                            {
                                _logger.LogError(ex, $" > Failed to fix {party.Name}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in PartyAlignmentFixer");
            }
        }
    }
}

