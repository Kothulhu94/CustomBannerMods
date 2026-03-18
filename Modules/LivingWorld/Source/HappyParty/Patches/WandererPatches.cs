using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;


namespace HappyParty.Patches
{
    [HarmonyPatch(typeof(HeroCreator), "CreateSpecialHero", new[] { typeof(CharacterObject), typeof(Settlement), typeof(Clan), typeof(Clan), typeof(int) })]
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
