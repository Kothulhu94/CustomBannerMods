using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using FieldSquire.Behaviors;

namespace FieldSquire.Patches
{
    // Patch to prevent the Squire from gaining any experience.
    [HarmonyPatch(typeof(Hero), "AddSkillXp")]
    public static class SquireXpBlockPatch
    {
        public static bool Prefix(Hero __instance, SkillObject skill, float xpAmount)
        {
            // Check if the hero gaining XP is the Squire
            if (__instance != null && 
               (__instance.StringId == SquireSpawnBehavior.SquireStringId || 
                (__instance.Name != null && __instance.Name.ToString().Contains("Squire"))))
            {
                // Return false to skip the original method execution, effectively preventing XP gain.
                return false; 
            }
            // For everyone else, run original logic.
            return true;
        }
    }
}
