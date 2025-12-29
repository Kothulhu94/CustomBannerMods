using HarmonyLib;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using FieldSquire.Behaviors;
using TaleWorlds.Core;

namespace FieldSquire.Patches
{
    // Fix: Target the correct overload: public Agent SpawnAgent(AgentBuildData agentBuildData, bool spawnFromAgentVisuals = false)
    // Fix: Target SpawnTroop instead of SpawnAgent to avoid NRE when returning null.
    // Signature: Agent SpawnTroop(IAgentOriginBase troopOrigin, bool isPlayerSide, bool hasFormation, bool spawnWithHorse, bool isReinforcement, int formationTroopCount, int formationTroopIndex, bool isAlarmed, bool wieldInitialWeapons, bool forceDismounted, Vec3? initialPosition, Vec2? initialDirection, string specialActionSetSuffix, ItemObject bannerItem, FormationClass formationIndex, bool useTroopClassForSpawn)
    [HarmonyPatch(typeof(Mission), "SpawnTroop", new System.Type[] { 
        typeof(IAgentOriginBase), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(bool), 
        typeof(TaleWorlds.Library.Vec3?), typeof(TaleWorlds.Library.Vec2?), typeof(string), typeof(ItemObject), typeof(FormationClass), typeof(bool) 
    })]
    public static class SquireCombatPatch
    {
        public static bool Prefix(
            IAgentOriginBase troopOrigin, 
            bool isPlayerSide, 
            bool hasFormation, 
            bool spawnWithHorse, 
            bool isReinforcement, 
            int formationTroopCount, 
            int formationTroopIndex, 
            bool isAlarmed, 
            bool wieldInitialWeapons, 
            bool forceDismounted, 
            TaleWorlds.Library.Vec3? initialPosition, 
            TaleWorlds.Library.Vec2? initialDirection, 
            string specialActionSetSuffix, 
            ItemObject bannerItem, 
            FormationClass formationIndex, 
            bool useTroopClassForSpawn, 
            ref Agent __result)
        {
            if (troopOrigin?.Troop is CharacterObject character &&
                character.HeroObject != null &&
                (character.HeroObject.StringId == SquireSpawnBehavior.SquireStringId || 
                 (character.HeroObject.Name != null && character.HeroObject.Name.ToString().Contains("Squire"))))
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
                         __result = null;
                         return false; // Block spawn
                     }
                 }
            }
            return true;
        }
    }
}
