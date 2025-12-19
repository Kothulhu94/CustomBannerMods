using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.Actions;
using Microsoft.Extensions.Logging;

namespace Brigands.Merge
{
    public class SanityCheckBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<SanityCheckBehavior> _logger;
        private readonly GlobalSettings _settings;

        public SanityCheckBehavior(ILogger<SanityCheckBehavior> logger, GlobalSettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnDailyTick()
        {
            try
            {
                var parties = MobileParty.All.ToList();
                foreach (var party in parties)
                {
                    if (party == null || !party.IsActive) continue;
                    
                    bool isBandit = party.MapFaction != null && (party.MapFaction.IsBanditFaction || party.MapFaction.IsOutlaw || party.MapFaction.StringId == "TheSyndicate");
                    if (!isBandit) continue;

                    if (party.MemberRoster.TotalManCount <= 0)
                    {
                        if (_settings.DebugMode)
                            _logger.LogInformation($"[Sanity] Destroying empty bandit party: {party.Name}");
                        DestroyPartyAction.Apply(null, party);
                        continue;
                    }

                    if (party.Party == null)
                    {
                         continue;
                    }

                    if (party.MapFaction.StringId == "TheSyndicate" && party.LeaderHero == null)
                    {
                        if (party.Name != null && party.Name.ToString().Contains("Warlord"))
                        {
                             if (_settings.DebugMode)
                                 _logger.LogInformation($"[Sanity] Destroying leaderless Warlord party: {party.Name}");
                             DestroyPartyAction.Apply(null, party);
                             continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in SanityCheckBehavior");
            }
        }
    }
}

