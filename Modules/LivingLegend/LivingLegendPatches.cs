using HarmonyLib;
using System.Reflection;
using TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.InputSystem;
using TaleWorlds.Localization;
using Microsoft.Extensions.Logging;

namespace LivingLegend
{
    public static class LivingLegendPatches
    {
        public static void Apply(Harmony harmony)
        {
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }

    [HarmonyPatch(typeof(ArmyManagementVM), "ExecuteDone")]
    public class ArmyManagementExecuteDonePatch
    {
        private static bool Prefix(ArmyManagementVM __instance)
        {
            // Check if Shift is held to trigger Renown recruitment
            if (Input.IsKeyDown(InputKey.LeftShift) || Input.IsKeyDown(InputKey.RightShift))
            {
                RecruitWithRenown(__instance);
                return false; // Skip original execution
            }
            return true;
        }

        private static void RecruitWithRenown(ArmyManagementVM vm)
        {
            var partiesInCart = vm.PartiesInCart;
            if (partiesInCart.Count == 0)
            {
                vm.ExecuteDone(); // Fallback to normal if empty, likely closes screen
                return;
            }

            var settings = GlobalSettings.Instance;
            // Fallback if settings null (shouldn't happen in game)
            int factor = settings != null ? settings.RenownToInfluenceCostFactor : 5;

            int totalRenownCost = 0;
            foreach (var item in partiesInCart)
            {
                totalRenownCost += (int)(item.Cost * factor); 
            }

            if (Clan.PlayerClan.Renown >= totalRenownCost)
            {
                Clan.PlayerClan.Renown -= totalRenownCost;
                
                foreach (var item in partiesInCart)
                {
                     var party = item.Party as MobileParty; 
                     if (party != null)
                     {
                         party.Army = MobileParty.MainParty.Army;
                         LivingLegendSubModule.Logger?.LogInformation($"Recruited {party.Name} for Renown.");
                     }
                }
                
                InformationManager.DisplayMessage(new InformationMessage($"Recruited {partiesInCart.Count} parties for {totalRenownCost} Renown.", Colors.Green));
            }
            else
            {
                InformationManager.DisplayMessage(new InformationMessage($"Not enough Renown! Needed: {totalRenownCost}.", Colors.Red));
            }
        }
    }

    [HarmonyPatch(typeof(ArmyManagementVM), "RefreshValues")]
    public class ArmyManagementRefreshValuesPatch
    {
        private static void Postfix(ArmyManagementVM __instance)
        {
            __instance.DoneText = __instance.DoneText + "\n(Shift: Pay Renown)";
        }
    }
}
