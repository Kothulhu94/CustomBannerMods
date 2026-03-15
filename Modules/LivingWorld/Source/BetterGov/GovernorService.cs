using System;
using Microsoft.Extensions.Logging;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;

namespace BetterGov
{
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
                

                if (settlement == null || (!settlement.IsTown && !settlement.IsCastle)) return;

                Town town = settlement.Town;
                if (town == null) return;


                if (town.Governor == null)
                {

                    if (settlement.OwnerClan != null && mobileParty.LeaderHero.Clan == settlement.OwnerClan)
                    {
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

                if (town.Governor == mobileParty.LeaderHero)
                {
                    town.Governor = null;
                    
                    _logger.LogInformation($"{mobileParty.LeaderHero.Name} vacated Governor seat of {settlement.Name}.");
                    
                    TryAssignNewGovernor(town);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in HandleSettlementLeft");
            }
        }


        private void TryAssignNewGovernor(Town town)
        {
            try
            {
                if (town == null || town.Settlement == null || town.OwnerClan == null) return;

                // Find best candidate
                Hero bestCandidate = null;
                int bestSkill = -1;

                foreach (Hero hero in town.Settlement.HeroesWithoutParty)
                {
                    // Must be in same clan (NPC or Player)
                    if (hero.Clan != town.OwnerClan) continue;

                    // Must be alive, active, not child, not prisoner
                    if (!hero.IsAlive || !hero.IsActive || hero.IsChild || hero.IsPrisoner) continue;
                    
                    // Don't re-assign if for some reason they are already governor (sanity check)
                    if (hero == town.Governor) continue;

                    int skill = hero.GetSkillValue(DefaultSkills.Steward);
                    if (skill > bestSkill)
                    {
                        bestSkill = skill;
                        bestCandidate = hero;
                    }
                }

                if (bestCandidate != null)
                {
                    town.Governor = bestCandidate;
                    _logger.LogInformation($"Auto-Assigned {bestCandidate.Name} as new Governor of {town.Name} (Steward: {bestSkill}).");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in TryAssignNewGovernor");
            }
        }
    }
}
