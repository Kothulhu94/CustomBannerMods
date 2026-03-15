using HarmonyLib;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.ViewModelCollection;
using TaleWorlds.Core;
using TaleWorlds.Core.ViewModelCollection.Information;
using TaleWorlds.Localization;
using Helpers;
using System.Reflection;

namespace FieldSquire.Patches
{
    [HarmonyPatch(typeof(TaleWorlds.CampaignSystem.ViewModelCollection.CampaignUIHelper), "GetHeroGovernorEffectsTooltip")]
    public static class CampaignUIHelperPatch
    {


        [HarmonyPrefix]
        public static bool Prefix(Hero hero, Settlement settlement, ref List<TooltipProperty> __result)
        {
            // 1. User Request: Suppress tooltip completely when managing via FieldSquire (Context Flag)
            if (FieldSquire.ViewModels.SquireTownManagementVM.IsActive)
            {
                 __result = new List<TooltipProperty>();
                 return false;
            }

            if (settlement == null) return true;

            if (settlement.Party == null)
            {
                __result = new List<TooltipProperty>(); // Suppress here as well to be safe/consistent
                return false; 
            }

            return true;
        }


    }
}
