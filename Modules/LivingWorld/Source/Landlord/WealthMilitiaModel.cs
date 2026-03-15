using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace Landlord
{
    public class WealthMilitiaModel : DefaultSettlementMilitiaModel
    {
        public override ExplainedNumber CalculateMilitiaChange(Settlement settlement, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.CalculateMilitiaChange(settlement, includeDescriptions);

            if (settlement.IsVillage)
            {
                var wealthData = LandlordManager.Instance.GetWealthData(settlement.StringId);
                if (wealthData.MilitiaBonus > 0)
                {
                    result.Add(wealthData.MilitiaBonus, new TextObject("{=village_wealth_investment}Village Wealth Investment"));
                }
            }

            return result;
        }
    }
}
