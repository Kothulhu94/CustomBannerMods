using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;
using FieldSquire.Behaviors;
using System.Linq;
using TaleWorlds.Localization;

namespace FieldSquire.Patches
{
    [HarmonyPatch(typeof(DefaultPartySizeLimitModel), "GetPartyMemberSizeLimit", new System.Type[] { typeof(PartyBase), typeof(bool) })]
    public static class PartySizeLimitPatch
    {
        public static void Postfix(PartyBase party, ref ExplainedNumber __result)
        {
            if (party != null && party.IsMobile && party.MobileParty == MobileParty.MainParty && Clan.PlayerClan != null)
            {
                // 1. Find the Squire in the Player's Clan (Fast, small list)
                var squire = Clan.PlayerClan.Heroes.FirstOrDefault(h => h.StringId == SquireSpawnBehavior.SquireStringId);

                // 2. Check if this specific Squire is in the party roster
                // We use memberRoster.Contains (or equivalent) to avoid GetTroopRoster() allocations which cause lag.
                if (squire != null && party.MobileParty.MemberRoster.Contains(squire.CharacterObject))
                {
                    __result.Add(1f, new TextObject("{=SquireSlot}Squire Slot"), null);
                }
            }
        }
    }
}
