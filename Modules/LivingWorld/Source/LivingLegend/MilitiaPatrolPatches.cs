using HarmonyLib;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;
using Microsoft.Extensions.Logging;

namespace LivingLegend
{
    public class MilitiaPatrolPatches
    {
        private static bool _patchesApplied = false;

        public static void Apply(Harmony harmony)
        {
            if (_patchesApplied) return;

            harmony.Patch(
                original: AccessTools.Method(typeof(DefaultArmyManagementCalculationModel), "GetMobilePartiesToCallToArmy"),
                postfix: new HarmonyMethod(typeof(MilitiaPatrolPatches), nameof(Postfix_GetMobilePartiesToCallToArmy))
            );

            harmony.Patch(
                original: AccessTools.Method(typeof(DefaultArmyManagementCalculationModel), "CalculatePartyInfluenceCost"),
                prefix: new HarmonyMethod(typeof(MilitiaPatrolPatches), nameof(Prefix_CalculatePartyInfluenceCost))
            );

            _patchesApplied = true;
        }

        // Prevention Patch: Stop them from being recruited
        public static void Postfix_GetMobilePartiesToCallToArmy(MobileParty leaderParty, ref List<MobileParty> __result)
        {
            if (__result != null && __result.Count > 0)
            {
                int removedCount = __result.RemoveAll(p => p.LeaderHero == null && p.StringId.StartsWith("militia_patrol_"));
                
                if (removedCount > 0 && LivingLegendSubModule.Logger != null)
                {
                    LivingLegendSubModule.Logger.LogDebug($"[MilitiaPatrolFix] Filtered {removedCount} leaderless militia parties from army selection.");
                }
            }
        }

        // Shield Patch: Prevent crash during influence calculation if they are already in an army
        public static bool Prefix_CalculatePartyInfluenceCost(MobileParty armyLeaderParty, MobileParty party, ref int __result)
        {
            if (party == null || armyLeaderParty == null) return true;

            if (party.LeaderHero == null || armyLeaderParty.LeaderHero == null)
            {
                __result = int.MaxValue;
                return false; // Skip original method
            }

            return true;
        }
    }
}
