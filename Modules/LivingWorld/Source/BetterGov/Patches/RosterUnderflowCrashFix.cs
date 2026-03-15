using HarmonyLib;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Roster;

namespace BetterGov.Patches
{
    [HarmonyPatch(typeof(TroopRoster), "RemoveTroop")]
    public static class RosterUnderflowCrashFix
    {
        public static bool Prefix(TroopRoster __instance, CharacterObject troop, ref int numberToRemove)
        {
            if (__instance == null || troop == null || numberToRemove <= 0)
            {
                return true; // Let original method handle bad input or do nothing? Standard is usually let original run if input is weird, but here we want safety.
            }

            try
            {
                int actualCount = __instance.GetTroopCount(troop);

                if (actualCount == 0)
                {
                    return false; 
                }

                if (numberToRemove > actualCount)
                {
                    numberToRemove = actualCount;
                }
                
                // If we reduced it to 0 (shouldn't happen if actualCount > 0 check passed), but just in case
                if (numberToRemove == 0) return false;

                return true;
            }
            catch (Exception)
            {
                 return true;
            }
        }
    }
}
