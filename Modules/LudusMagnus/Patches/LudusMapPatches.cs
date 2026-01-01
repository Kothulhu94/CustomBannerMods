using HarmonyLib;
using SandBox.View.Map;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Map;
using TaleWorlds.Library;
using TaleWorlds.Core;
using TaleWorlds.Engine;
using TaleWorlds.InputSystem;
using LudusMagnus.SettlementLogic;

namespace LudusMagnus.Patches
{
    [HarmonyPatch(typeof(MapScreen), "HandleLeftMouseButtonClick")]
    public static class LudusMapInputPatch
    {
        public static bool Prefix()
        {
            // Interactive Placement Removed. Patch Disabled.
            return true;
        }
    }
}
