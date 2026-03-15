using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;

namespace BetterGov.Patches
{
    // Fixes crash in DefaultDiplomacyModel when calculating relation for Heroes with null data (e.g. ghost parties in armies)
    [HarmonyPatch(typeof(DefaultDiplomacyModel), "GetEffectiveRelation")]
    public static class DiplomacyCrashFix
    {
        public static bool Prefix(Hero hero1, Hero hero2, ref int __result)
        {
            if (hero1 == null || hero2 == null)
            {
                __result = 0; // Return neutral relation if data is missing
                return false; // Skip original method to prevent NullReferenceException
            }
            return true;
        }
    }
}
