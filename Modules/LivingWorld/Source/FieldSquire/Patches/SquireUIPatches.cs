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
using TaleWorlds.Core;

namespace FieldSquire.Patches
{
    public static class SquireUIPatches
    {
        private static bool _patchesApplied = false;

        public static void Apply(Harmony harmony)
        {
            if (_patchesApplied) return;

            // 1. Companion Limit (Keep this one)
            var originalLimit = AccessTools.Method(typeof(DefaultClanTierModel), "GetCompanionLimit");
            var postfixLimit = AccessTools.Method(typeof(SquireUIPatches), nameof(CompanionLimitPostfix));
            if (originalLimit != null) harmony.Patch(originalLimit, postfix: new HarmonyMethod(postfixLimit));

            _patchesApplied = true;
            FieldSquireSubModule.Logger?.Information("FieldSquire: Companion Limit patch applied (UI filters removed).");
        }

        public static void CompanionLimitPostfix(Clan clan, ref int __result)
        {
            if (clan != null && clan == Clan.PlayerClan)
            {
                var companionsWithId = clan.Companions.Where(h => h.StringId == SquireSpawnBehavior.SquireStringId).ToList();
                if (companionsWithId.Any())
                {
                    var squire = companionsWithId.First();
                    int stewardSkill = squire.GetSkillValue(DefaultSkills.Steward);
                    int divisor = GlobalSettings.Instance?.CompanionScaling ?? 50;
                    int bonus = 1 + (stewardSkill / divisor);

                    int originalValue = __result;
                    __result += bonus;
                    FieldSquireSubModule.Logger?.Debug($"FieldSquire: CompanionLimit Patch: Original={originalValue}, Found Squire with {stewardSkill} Steward, Divisor={divisor}, New Bonus={bonus}, New Total={__result}");
                }
            }
        }
    }
}


