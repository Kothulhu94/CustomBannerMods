using HarmonyLib;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using FieldSquire.Behaviors;
using TaleWorlds.Core;

namespace FieldSquire.Patches
{
    // Fix: Target the correct overload: public Agent SpawnAgent(AgentBuildData agentBuildData, bool spawnFromAgentVisuals = false)
    [HarmonyPatch(typeof(Mission), "SpawnAgent", new System.Type[] { typeof(AgentBuildData), typeof(bool) })]
    public static class SquireCombatPatch
    {
        public static bool Prefix(AgentBuildData agentBuildData)
        {
            if (agentBuildData?.AgentOrigin?.Troop is CharacterObject character &&
                character.HeroObject != null &&
                character.HeroObject.StringId == SquireSpawnBehavior.SquireStringId)
            {
                 // Safer: Only BLOCK if it IS a battle.
                 if (Mission.Current != null)
                 {
                     var mode = Mission.Current.Mode;
                     if (mode == MissionMode.Battle ||
                         mode == MissionMode.Stealth ||
                         mode == MissionMode.Duel ||
                         mode == MissionMode.Deployment)
                     {
                         return false; // Block spawn
                     }
                 }
            }
            return true;
        }
    }
}
