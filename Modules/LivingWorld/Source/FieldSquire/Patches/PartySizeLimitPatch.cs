using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;
using FieldSquire.Behaviors;
using System.Linq;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace FieldSquire.Patches
{
    public static class PartySizeLimitPatch
    {
        private static bool _patchesApplied = false;

        public static void Apply(Harmony harmony)
        {
            if (_patchesApplied) return;

            var original = AccessTools.Method(typeof(DefaultPartySizeLimitModel), "GetPartyMemberSizeLimit", new System.Type[] { typeof(PartyBase), typeof(bool) });
            var postfix = AccessTools.Method(typeof(PartySizeLimitPatch), nameof(Postfix));
            if (original != null) harmony.Patch(original, postfix: new HarmonyMethod(postfix));

            _patchesApplied = true;
        }

        public static void Postfix(PartyBase party, ref ExplainedNumber __result)
        {
            if (party != null && party.IsMobile && party.MobileParty == MobileParty.MainParty && Clan.PlayerClan != null)
            {
                var squire = Clan.PlayerClan.Heroes.FirstOrDefault(h => 
                    h.StringId == SquireSpawnBehavior.SquireStringId || 
                    (h.Name != null && h.Name.ToString().Contains("Squire")));

                if (squire != null && party.MobileParty.MemberRoster.Contains(squire.CharacterObject))
                {
                    int stewardSkill = squire.GetSkillValue(DefaultSkills.Steward);
                    int divisor = GlobalSettings.Instance?.StewardshipScaling ?? 5;
                    float bonus = 1f + (stewardSkill / (float)divisor);
                    __result.Add(bonus, new TextObject("{=SquireSlot}Squire Slot (Stewardship)"), null);
                }
            }
        }
    }
}

