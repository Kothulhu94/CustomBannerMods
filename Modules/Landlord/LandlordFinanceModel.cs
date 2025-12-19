using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.Localization;

using Microsoft.Extensions.Logging;

namespace Landlord
{
    public class LandlordFinanceModel : DefaultClanFinanceModel
    {
        private readonly ILogger<LandlordFinanceModel> _logger;

        public LandlordFinanceModel(ILogger<LandlordFinanceModel> logger)
        {
            _logger = logger;
        }

        public override ExplainedNumber CalculateClanIncome(Clan clan, bool includeDescriptions = false, bool applyWithdrawals = false, bool includeDetails = false)
        {
            // Get base income (fiefs, workshops, etc.)
            ExplainedNumber baseIncome = base.CalculateClanIncome(clan, includeDescriptions, applyWithdrawals, includeDetails);

            // Add Estate Income
            if (LandlordManager.Instance.GlobalPlots != null)
            {
                int estateIncome = 0;

                foreach (var kvp in LandlordManager.Instance.GlobalPlots)
                {
                    foreach (var plot in kvp.Value)
                    {
                        if (plot.Owner != null && plot.Owner.Clan == clan)
                        {
                            estateIncome += plot.LastDailyIncome;
                        }
                    }
                }

                // Only add to income if we are NOT applying withdrawals (i.e., this is for UI display, not the actual daily gold change)
                // This prevents double payment since we use GiveGoldAction manually in EconomyBehavior.
                if (!applyWithdrawals && estateIncome != 0)
                {
                    baseIncome.Add(estateIncome, new TextObject("Estate Properties"));
                }

                // Debug for Player Clan
                if (clan == Clan.PlayerClan && includeDescriptions)
                {
                    // InformationManager.DisplayMessage(new InformationMessage($"[LandlordModel] Calculated Estate Income: {estateIncome} (UI Only: {!applyWithdrawals})"));
                }
            }

            return baseIncome;
        }
    }
}
