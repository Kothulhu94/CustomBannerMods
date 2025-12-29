using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using System;

namespace Brigands.Warlords.Patches
{
    [HarmonyPatch(typeof(BanditSpawnCampaignBehavior), "IsBanditFaction")]
    public static class BanditSpawnPatch
    {
        // BanditSpawnCampaignBehavior.IsBanditFaction(Clan clan) is an internal method 
        // that determines if a clan should be processed by the bandit spawning logic 
        // (hideout infestation, etc).
        // The Syndicate clan is marked as IsBanditFaction = true to ensure persistent war 
        // and red nameplates, but it should NOT be handled by the vanilla bandit spawn behavior
        // because its culture (Empire/Neutral) might not be present in the behavior's internal hideout dictionary.
        
        [HarmonyPrefix]
        public static bool Prefix(Clan clan, ref bool __result)
        {
            if (clan != null && clan.StringId == "TheSyndicate")
            {
                __result = false;
                return false; // Skip original method
            }
            return true;
        }
    }
}
