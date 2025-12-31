using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.Library;

namespace LudusMagnus.Political
{
    public class CouncilVotingModel : DefaultClanPoliticsModel
    {
        public float CalculateVoteWeight(Hero voter, Hero candidate)
        {
            if (voter == null || candidate == null) return 0f;

            float weight = 10f; // Base weight

            // Relation Factor (-100 to +100) -> (-50 to +50)
            weight += voter.GetRelation(candidate) * 0.5f;

            // Trait Factor
            if (voter.GetTraitLevel(DefaultTraits.Valor) > 0 && candidate.GetTraitLevel(DefaultTraits.Valor) > 0)
                weight += 10f;
            if (voter.GetTraitLevel(DefaultTraits.Honor) > 0 && candidate.GetTraitLevel(DefaultTraits.Honor) > 0)
                weight += 10f;

            // Clan Power Factor
            weight += voter.Clan.Renown * 0.01f;

            return MathF.Max(0f, weight);
        }
    }
}
