using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;
using TaleWorlds.InputSystem;

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
                int plotCount = 0;

                // First pass: Calculate Total
                foreach (var kvp in LandlordManager.Instance.GlobalPlots)
                {
                    foreach (var plot in kvp.Value)
                    {
                        if (plot.Owner != null && plot.Owner.Clan == clan)
                        {
                            estateIncome += plot.LastDailyIncome;
                            plotCount++;
                        }
                    }
                }

                if (!applyWithdrawals && estateIncome != 0)
                {
                    if (includeDescriptions && Input.IsKeyDown(InputKey.LeftAlt))
                    {
                         foreach (var kvp in LandlordManager.Instance.GlobalPlots)
                        {
                            foreach (var plot in kvp.Value)
                            {
                                if (plot.Owner != null && plot.Owner.Clan == clan)
                                {
                                    // "Plot in Poros (Grade: Normal)"
                                    var settlement = Settlement.Find(plot.VillageStringId);
                                    string name = settlement != null ? settlement.Name.ToString() : plot.VillageStringId;
                                    
                                    string efficiency = "Normal";
                                    if (plot.SlotIndex == 1) efficiency = "Good";
                                    else if (plot.SlotIndex == 2) efficiency = "Great";

                                    baseIncome.Add(plot.LastDailyIncome, new TextObject($"Plot in {name} ({efficiency})"));
                                }
                            }
                        }
                    }
                    else
                    {
                         // Standard View: "Plots (X)"
                        baseIncome.Add(estateIncome, new TextObject($"Plots ({plotCount})"));
                    }
                }

                // Debug for Player Clan
                if (clan == Clan.PlayerClan && includeDescriptions)
                {
                    // InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_landlordmodelca}}[LandlordModel] Calculated Estate Income: {estateIncome} (UI Only: {!applyWithdrawals})").ToString()));
                }
            }

            return baseIncome;
        }
    }
}
