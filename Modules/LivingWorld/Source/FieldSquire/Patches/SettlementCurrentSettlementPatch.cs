using HarmonyLib;
using TaleWorlds.CampaignSystem.Settlements;
using FieldSquire.ViewModels;

namespace FieldSquire.Patches
{
    [HarmonyPatch(typeof(Settlement), "get_CurrentSettlement")]
    public static class SettlementCurrentSettlementPatch
    {
        public static void Postfix(ref Settlement __result)
        {
            if (__result == null && SquireTownManagementVM.IsActive)
            {
                __result = SquireTownManagementVM.CurrentManagedSettlement;
            }
        }
    }
}
