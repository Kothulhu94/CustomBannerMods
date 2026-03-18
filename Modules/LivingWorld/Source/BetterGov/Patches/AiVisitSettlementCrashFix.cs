using HarmonyLib;
using System;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;

namespace BetterGov.Patches
{
    [HarmonyPatch]
    public static class AiVisitSettlementCrashFix
    {
        public static MethodBase TargetMethod()
        {
            return AccessTools.Method(
                AccessTools.TypeByName("TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiVisitSettlementBehavior"),
                "AiHourlyTick"
            );
        }

        public static bool Prefix(MobileParty mobileParty, object p)
        {
            if (mobileParty == null) return false;
            return true;
        }

        public static Exception Finalizer(Exception __exception)
        {
            if (__exception != null)
            {
                return null; // Swallow exception
            }
            return null;
        }
    }
}
