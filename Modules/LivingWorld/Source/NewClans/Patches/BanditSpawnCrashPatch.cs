using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using System.Linq;

namespace NewClans.Patches
{
    [HarmonyPatch(typeof(BanditSpawnCampaignBehavior), "IsBanditFaction")]
    public static class BanditSpawnCrashPatch
    {
        
        [HarmonyPrefix]
        public static bool Prefix(Clan clan, ref bool __result)
        {
            if (clan != null)
            {
                
                
                string id = clan.StringId;
                
                bool isVanillaBandit = 
                    id == "looters" || 
                    id == "mountain_bandits" || 
                    id == "forest_bandits" || 
                    id == "sea_raiders" || 
                    id == "steppe_bandits" || 
                    id == "desert_bandits";

                if (clan.IsBanditFaction && !isVanillaBandit)
                {
                    __result = false;
                    return false; // Skip original method, return false
                }
            }
            return true; // Continue to original method
        }
    }
}
