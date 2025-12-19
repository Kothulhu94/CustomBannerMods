using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using Microsoft.Extensions.DependencyInjection;
using Bannerlord.ButterLib.Common.Extensions;

namespace BetterGov.Patches
{
    [HarmonyPatch(typeof(MobileParty), "CurrentSettlement", MethodType.Setter)]
    public static class AutoGovernorPatches
    {
        public static void Prefix(MobileParty __instance, out Settlement __state)
        {
            __state = __instance.CurrentSettlement;
        }

        public static void Postfix(MobileParty __instance, Settlement __state)
        {
            if (__instance.CurrentSettlement != __state)
            {
                var serviceProvider = Game.Current?.GetServiceProvider();
                if (serviceProvider == null) return;

                var governorService = serviceProvider.GetService<GovernorService>();
                if (governorService == null) return;

                // Left old settlement
                if (__state != null)
                {
                    governorService.HandleSettlementLeft(__instance, __state);
                }

                // Entered new settlement
                if (__instance.CurrentSettlement != null)
                {
                    governorService.HandleSettlementEntered(__instance, __instance.CurrentSettlement);
                }
            }
        }
    }
}
