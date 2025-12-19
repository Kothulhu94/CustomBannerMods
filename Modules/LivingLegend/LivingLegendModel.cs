using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.CampaignSystem.Settlements;

namespace LivingLegend
{
    public class LivingLegendClanTierModel : DefaultClanTierModel
    {
        private readonly GlobalSettings _settings;

        public LivingLegendClanTierModel(GlobalSettings settings)
        {
            _settings = settings;
        }

        public override int GetCompanionLimit(Clan clan)
        {
            int baseLimit = base.GetCompanionLimit(clan);

            if (clan == Clan.PlayerClan && clan.Renown > _settings.RenownThreshold)
            {
                int bonus = (int)((clan.Renown - _settings.RenownThreshold) / 1000);
                return baseLimit + bonus;
            }

            return baseLimit;
        }

        public override int GetPartyLimitForTier(Clan clan, int clanTierToCheck)
        {
             return base.GetPartyLimitForTier(clan, clanTierToCheck);
        }
    }

    public class LivingLegendMilitiaModel : DefaultSettlementMilitiaModel
    {
        private readonly GlobalSettings _settings;

        public LivingLegendMilitiaModel(GlobalSettings settings)
        {
            _settings = settings;
        }

        public override ExplainedNumber CalculateMilitiaChange(Settlement settlement, bool includeDescriptions = false)
        {
            var result = base.CalculateMilitiaChange(settlement, includeDescriptions);

            if (settlement.OwnerClan == Clan.PlayerClan && 
                settlement.OwnerClan.Tier >= 6 && 
                settlement.OwnerClan.Renown > _settings.RenownThreshold)
            {
                result.Add(1f, new TextObject("{=legend_militia}The Legend's Aura"));
            }

            return result;
        }
    }

    public class LivingLegendLoyaltyModel : DefaultSettlementLoyaltyModel
    {
        private readonly GlobalSettings _settings;

        public LivingLegendLoyaltyModel(GlobalSettings settings)
        {
            _settings = settings;
        }

        public override ExplainedNumber CalculateLoyaltyChange(Town town, bool includeDescriptions = false)
        {
            var result = base.CalculateLoyaltyChange(town, includeDescriptions);
            
            if (town.Settlement.OwnerClan == Clan.PlayerClan && 
                town.Settlement.OwnerClan.Tier >= 6 && 
                town.Settlement.OwnerClan.Renown > _settings.RenownThreshold)
            {
                result.Add(2f, new TextObject("{=legend_loyalty}The Legend's Aura"));
            }
            return result;
        }
    }
}
