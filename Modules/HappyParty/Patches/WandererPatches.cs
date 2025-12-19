using HarmonyLib;
using TaleWorlds.CampaignSystem;
using System.Reflection;

namespace HappyParty.Patches
{
    [HarmonyPatch(typeof(HeroCreator), "CreateSpecialHero")]
    public static class WandererPatches
    {
        public static void Postfix(Hero __result)
        {
            if (__result != null && __result.IsWanderer)
            {
                var behavior = Campaign.Current?.GetCampaignBehavior<CustomWandererSpawnBehavior>();
                if (behavior != null)
                {
                    behavior.ValidateWanderer(__result);
                }
            }
        }
    }
}
