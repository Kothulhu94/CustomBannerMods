using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Conversation.Tags;

namespace FieldSquire.Patches
{
    /// <summary>
    /// Defensive patch for PlayerIsAtSeaTag.IsApplicableTo.
    /// Prevents NRE if Hero.MainHero.PartyBelongedTo is null (e.g. during certain state transitions).
    /// </summary>
    [HarmonyPatch(typeof(PlayerIsAtSeaTag), "IsApplicableTo")]
    public static class PlayerIsAtSeaTagPatch
    {
        public static bool Prefix(CharacterObject character, ref bool __result)
        {
            // If the main hero has no party, they definitely aren't "at sea" in a way the game can calculate here.
            // Returning false early prevents the vanilla NRE.
            if (Hero.MainHero?.PartyBelongedTo == null)
            {
                __result = false;
                return false; // Skip vanilla
            }
            return true;
        }
    }
}
