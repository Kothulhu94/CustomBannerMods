using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Library;
using LivingLegend;
using System;

namespace Landlord.Patches
{
    public static class MilitiaPatrolNavalCrashFix
    {
        public static System.Reflection.MethodBase TargetMethod()
        {
            // Bannerlord 1.3.x uses GetNavalPatrolBehavior
            return AccessTools.Method(typeof(MobilePartyAi), "GetNavalPatrolBehavior");
        }

        public static bool Prefix(MobilePartyAi __instance, MobileParty mobileParty, ref AiBehavior patrolBehavior, ref CampaignVec2 patrolTargetPoint, CampaignVec2 patrollingCenterPoint, bool forceUpdate)
        {
            try
            {
                if (mobileParty != null && mobileParty.PartyComponent is MilitiaPatrolComponent)
                {
                    // For militia patrols, we skip the naval behavior calculation to avoid the crash
                    // We set default behavior to avoid unassigned refs
                    patrolBehavior = AiBehavior.None;
                    patrolTargetPoint = CampaignVec2.Invalid;
                    return false; // Skip original method
                }
            }
            catch (Exception) { }

            return true;
        }
    }
}
