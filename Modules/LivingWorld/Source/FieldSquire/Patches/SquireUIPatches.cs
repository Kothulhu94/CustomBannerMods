using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.ViewModelCollection.Inventory;
using TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper;
using TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement;
using TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Issues;
using FieldSquire.Behaviors;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.Library;
using System.Reflection;

namespace FieldSquire.Patches
{
    public static class SquireUIPatches
    {
        private static bool _patchesApplied = false;

        public static void Apply(Harmony harmony)
        {
            if (_patchesApplied) return;

            
            // 1. Inventory CanSelectHero
            var originalInvCanSelect = AccessTools.Method(typeof(SPInventoryVM), "CanSelectHero");
            var postfixInvCanSelect = AccessTools.Method(typeof(SquireUIPatches), nameof(InventoryCanSelectPostfix));
            if (originalInvCanSelect != null) harmony.Patch(originalInvCanSelect, postfix: new HarmonyMethod(postfixInvCanSelect));

            // 2. Inventory InitializeInventory
            var originalInvInit = AccessTools.Method(typeof(SPInventoryVM), "InitializeInventory");
            var postfixInvInit = AccessTools.Method(typeof(SquireUIPatches), nameof(InventoryInitializePostfix));
            if (originalInvInit != null) harmony.Patch(originalInvInit, postfix: new HarmonyMethod(postfixInvInit));

            // 3. Character Developer Applicable Heroes
            var originalCharApp = AccessTools.Method(typeof(CharacterDeveloperVM), "GetApplicableHeroes");
            var postfixCharApp = AccessTools.Method(typeof(SquireUIPatches), nameof(CharacterSheetPostfix));
            if (originalCharApp != null) harmony.Patch(originalCharApp, postfix: new HarmonyMethod(postfixCharApp));

            // 4. Character Developer Refresh
            var originalCharRefresh = AccessTools.Method(typeof(CharacterDeveloperVM), "RefreshCharacterSelector");
            var postfixCharRefresh = AccessTools.Method(typeof(SquireUIPatches), nameof(CharacterDevRefreshPostfix));
            if (originalCharRefresh != null) harmony.Patch(originalCharRefresh, postfix: new HarmonyMethod(postfixCharRefresh));

            // 5. Governor Candidates
            var originalGov = AccessTools.Method(typeof(ClanFiefsVM), "GetGovernorCandidates");
            var postfixGov = AccessTools.Method(typeof(SquireUIPatches), nameof(GovernorCandidatesPostfix));
            if (originalGov != null) harmony.Patch(originalGov, postfix: new HarmonyMethod(postfixGov));

            // 6. New Party Leader
            var originalNewParty = AccessTools.Method(typeof(ClanPartiesVM), "GetNewPartyLeaderCandidates");
            var postfixNewParty = AccessTools.Method(typeof(SquireUIPatches), nameof(NewPartyLeaderCandidatesPostfix));
            if (originalNewParty != null) harmony.Patch(originalNewParty, postfix: new HarmonyMethod(postfixNewParty));

            // 7. Change Party Leader
            var originalChangeParty = AccessTools.Method(typeof(ClanPartiesVM), "GetChangeLeaderCandidates");
            var postfixChangeParty = AccessTools.Method(typeof(SquireUIPatches), nameof(ChangeLeaderCandidatesPostfix));
            if (originalChangeParty != null) harmony.Patch(originalChangeParty, postfix: new HarmonyMethod(postfixChangeParty));

            // 8. Companion Limit
            var originalLimit = AccessTools.Method(typeof(DefaultClanTierModel), "GetCompanionLimit");
            var postfixLimit = AccessTools.Method(typeof(SquireUIPatches), nameof(CompanionLimitPostfix));
            if (originalLimit != null) harmony.Patch(originalLimit, postfix: new HarmonyMethod(postfixLimit));

            _patchesApplied = true;
            FieldSquireSubModule.Logger?.Information("FieldSquire: Manual UI and Limit patches applied.");
        }

        public static void InventoryCanSelectPostfix(Hero hero, ref bool __result)
        {
            if (hero != null && hero.StringId == SquireSpawnBehavior.SquireStringId)
            {
                __result = false;
            }
        }

        public static void InventoryInitializePostfix(SPInventoryVM __instance)
        {
            if (__instance == null) return;

            var charList = __instance.CharacterList;
            if (charList != null)
            {
                var itemList = charList.ItemList;
                if (itemList != null)
                {
                    for (int i = itemList.Count - 1; i >= 0; i--)
                    {
                        var vm = itemList[i];
                        if (vm == null) continue;

                        var type = vm.GetType();
                        var prop = type.GetProperty("CharacterID", BindingFlags.Instance | BindingFlags.Public);
                        
                        if (prop != null)
                        {
                            var id = prop.GetValue(vm) as string;
                            if (id == SquireSpawnBehavior.SquireStringId)
                            {
                                itemList.RemoveAt(i);
                                if (charList.SelectedIndex == i) charList.SelectedIndex = 0;
                                else if (charList.SelectedIndex > i) charList.SelectedIndex--;
                            }
                        }
                    }
                }
            }
        }

        public static void CharacterSheetPostfix(ref List<Hero> __result)
        {
            if (__result != null)
            {
                __result.RemoveAll(h => h.StringId == SquireSpawnBehavior.SquireStringId);
            }
        }

        public static void CharacterDevRefreshPostfix(CharacterDeveloperVM __instance)
        {
            if (__instance == null) return;

            var charList = __instance.CharacterList;
            if (charList != null)
            {
                var itemList = charList.ItemList;
                if (itemList != null)
                {
                    for (int i = itemList.Count - 1; i >= 0; i--)
                    {
                        var vm = itemList[i];
                        if (vm == null) continue;

                        var type = vm.GetType();
                        var prop = type.GetProperty("Hero", BindingFlags.Instance | BindingFlags.Public);
                        
                        if (prop != null)
                        {
                            var hero = prop.GetValue(vm) as Hero;
                            if (hero != null && hero.StringId == SquireSpawnBehavior.SquireStringId)
                            {
                                itemList.RemoveAt(i);
                                if (charList.SelectedIndex == i) charList.SelectedIndex = 0; 
                                else if (charList.SelectedIndex > i) charList.SelectedIndex--;
                            }
                        }
                    }
                }
            }
        }

        public static void GovernorCandidatesPostfix(ref IEnumerable<ClanCardSelectionItemInfo> __result)
        {
            if (__result != null)
            {
                __result = __result.Where(i => !(i.Identifier is Hero h && h.StringId == SquireSpawnBehavior.SquireStringId)).ToList();
            }
        }

        public static void NewPartyLeaderCandidatesPostfix(ref IEnumerable<ClanCardSelectionItemInfo> __result)
        {
            if (__result != null)
            {
                __result = __result.Where(i => !(i.Identifier is Hero h && h.StringId == SquireSpawnBehavior.SquireStringId)).ToList();
            }
        }

        public static void ChangeLeaderCandidatesPostfix(ref IEnumerable<ClanCardSelectionItemInfo> __result)
        {
            if (__result != null)
            {
                __result = __result.Where(i => !(i.Identifier is Hero h && h.StringId == SquireSpawnBehavior.SquireStringId)).ToList();
            }
        }

        public static void CompanionLimitPostfix(Clan clan, ref int __result)
        {
            if (clan != null && clan == Clan.PlayerClan)
            {
                var companionsWithId = clan.Companions.Where(h => h.StringId == SquireSpawnBehavior.SquireStringId).ToList();
                if (companionsWithId.Any())
                {
                    int originalValue = __result;
                    __result += 1;
                    FieldSquireSubModule.Logger?.Debug($"FieldSquire: CompanionLimit Patch: Original={originalValue}, Found={companionsWithId.Count} squires, New={__result}");
                }
            }
        }
    }
}


