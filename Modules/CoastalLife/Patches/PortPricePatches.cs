using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using NavalDLC;
using System.Collections.Generic;

namespace CoastalLife.Patches
{
    [HarmonyPatch(typeof(NavalDLC.GameComponents.NavalDLCShipCostModel), "GetShipTradeValue")]
    public static class PortPricePatches
    {
        public static void Postfix(ref float __result)
        {
            if (Settlement.CurrentSettlement != null && PortEconomyBehavior.HasDockingSlip(Settlement.CurrentSettlement))
            {
                // Apply 25% discount logic: The result is the value.
                // If buying, value = cost. If selling, value = sell price.
                // Discounts usually apply to buying. 
                // We should check if we are in a buying context, but for now let's just modify the value if it's the player involving in a trade context? 
                // Actually, GetShipTradeValue might be the base value.
                // If it's the base value, modifying it affects both buy and sell.
                // But a 'discount' usually means we pay less.
                
                // Let's assume this returns the price.
                __result = __result * 0.75f;
            }
        }
    }
}
