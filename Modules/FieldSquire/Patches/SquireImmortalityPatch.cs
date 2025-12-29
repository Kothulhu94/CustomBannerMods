using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using FieldSquire.Behaviors;

namespace FieldSquire.Patches
{
    [HarmonyPatch(typeof(KillCharacterAction), "ApplyInternal")]
    public static class SquireImmortalityPatch
    {
        public static bool Prefix(Hero victim, Hero killer)
        {
            // Check Setting
            if (GlobalSettings.Instance != null && !GlobalSettings.Instance.SquireImmortality) return true;

            if (victim != null && (victim.StringId == SquireSpawnBehavior.SquireStringId || 
                                   (victim.Name != null && victim.Name.ToString().Contains("Squire"))))
            {
                // Prevent death sequence
                FieldSquireSubModule.Logger?.Information($"INTERCEPTED: {victim.Name} was about to be killed. Preventing death.");
                
                // Ensure they have HP
                victim.Heal(1); 
                
                return false; // Skip execution
            }
            return true;
        }
    }
}
