using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Settlements.Locations;
using TaleWorlds.Core;
using TaleWorlds.Library;
using System;

namespace HappyParty.Patches
{
    [HarmonyPatch(typeof(CraftingCampaignBehavior), "CreateTownOrder")]
    public static class CraftingCrashFix
    {
        public static bool Prefix(Hero orderOwner, int orderSlot)
        {
            if (orderOwner == null) return false;

            if (orderOwner.CurrentSettlement == null)
            {
                return false; 
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(HeroKnownInformationCampaignBehavior), "LearnAboutLocationCharacters")]
    public static class HeroKnownInformationCrashFix
    {
        public static bool Prefix(Location location)
        {
            try
            {
                if (location == null) return false;

                foreach (LocationCharacter locationCharacter in location.GetCharacterList())
                {
                    if (locationCharacter != null && 
                        locationCharacter.Character != null && 
                        locationCharacter.Character.IsHero && 
                        locationCharacter.Character.HeroObject != null &&
                        locationCharacter.Character.HeroObject.CurrentSettlement != null && 
                        Settlement.CurrentSettlement != null &&
                        locationCharacter.Character.HeroObject.CurrentSettlement == Settlement.CurrentSettlement)
                    {
                        locationCharacter.Character.HeroObject.IsKnownToPlayer = true;
                    }
                }
                return false; // Skip original to run our safe version
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
