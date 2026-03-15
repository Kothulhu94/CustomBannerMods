using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Localization;
using FieldSquire.Behaviors;
using System;
using TaleWorlds.Core;

namespace FieldSquire.Patches
{
    // Wage Patch: Make Squire cost 0 wages
    [HarmonyPatch(typeof(DefaultPartyWageModel), "GetCharacterWage")]
    public static class SquireWagePatch
    {
        public static bool Prefix(CharacterObject character, ref int __result)
        {
            if (character != null && character.IsHero && character.HeroObject != null && 
                character.HeroObject.StringId == SquireSpawnBehavior.SquireStringId)
            {
                __result = 0;
                return false; 
            }
            return true;
        }
    }


}
