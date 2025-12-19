using System;
using Microsoft.Extensions.Logging;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;

namespace BetterGov
{
    /// <summary>
    /// Service logic for handling settlement entry/exit events.
    /// Replaces the old static AutoGovernorBehavior.
    /// </summary>
    public class GovernorService
    {
        private readonly ILogger<GovernorService> _logger;

        public GovernorService(ILogger<GovernorService> logger)
        {
            _logger = logger;
        }

        public void HandleSettlementEntered(MobileParty mobileParty, Settlement settlement)
        {
            try
            {
                if (!GlobalSettings.Instance.AutoAssignGovernor) return;

                if (mobileParty == null || mobileParty.LeaderHero == null) return;
                
                // Settlement sanity check
                if (settlement == null || (!settlement.IsTown && !settlement.IsCastle)) return;

                Town town = settlement.Town;
                if (town == null) return;

                // Check if Town.Governor is null (Empty seat)
                if (town.Governor == null)
                {
                    // Check if Party.LeaderHero belongs to the same Clan as the Settlement.OwnerClan
                    if (settlement.OwnerClan != null && mobileParty.LeaderHero.Clan == settlement.OwnerClan)
                    {
                        // Action: Town.Governor = Party.LeaderHero
                        town.Governor = mobileParty.LeaderHero;

                        _logger.LogInformation($"Auto-Assigned {mobileParty.LeaderHero.Name} as Governor of {settlement.Name}.");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in HandleSettlementEntered");
            }
        }

        public void HandleSettlementLeft(MobileParty mobileParty, Settlement settlement)
        {
            try
            {
                if (!GlobalSettings.Instance.AutoAssignGovernor) return;

                if (mobileParty == null || mobileParty.LeaderHero == null) return;

                if (settlement == null || (!settlement.IsTown && !settlement.IsCastle)) return;

                Town town = settlement.Town;
                if (town == null) return;

                // Check if Town.Governor is the Party.LeaderHero (the one leaving)
                if (town.Governor == mobileParty.LeaderHero)
                {
                    // Action: Town.Governor = null (Vacate the seat)
                    town.Governor = null;
                    
                    _logger.LogInformation($"{mobileParty.LeaderHero.Name} vacated Governor seat of {settlement.Name}.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in HandleSettlementLeft");
            }
        }
    }
}
