using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Library;
using LivingLegend;
using System;

namespace Landlord.Patches
{
    [HarmonyPatch(typeof(MobilePartyAi), "GetNavalPatrolBehavior")]
    public static class MilitiaPatrolNavalCrashFix
    {
        public static bool Prefix(MobilePartyAi __instance, ref AiBehavior patrolBehavior, ref CampaignVec2 patrolTargetPoint, CampaignVec2 patrollingCenterPoint, bool forceUpdate)
        {
            try
            {
                // Access private _mobileParty field via Reflection/Traverse
                var party = __instance.GetType().GetField("_mobileParty", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(__instance) as MobileParty;
                
                if (party != null && party.PartyComponent is MilitiaPatrolComponent)
                {
                    return false; // Skip original method
                }
            }
            catch (Exception) { }

            return true;
        }
    }
}
