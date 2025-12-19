using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.MapEvents;
using TaleWorlds.Core;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem.Party;

namespace Brigands.Merge.Patches
{
    [HarmonyPatch(typeof(MapEvent), "FinalizeEvent")]
    public static class MergePatches
    {
        public static void Postfix(MapEvent __instance)
        {
            try
            {
                if (__instance == null || __instance.WinningSide == BattleSideEnum.None) return;

                // Only care if Bandits or Syndicate won
                var winningSide = __instance.GetMapEventSide(__instance.WinningSide);
                if (winningSide == null) return;

                // Check if any winner is Bandit/Syndicate
                bool isBanditWin = false;
                List<MobileParty> winners = new List<MobileParty>();

                foreach(var mapEventParty in winningSide.Parties)
                {
                    if (mapEventParty.Party != null && mapEventParty.Party.MobileParty != null)
                    {
                        winners.Add(mapEventParty.Party.MobileParty);
                        if (mapEventParty.Party.MapFaction != null && (mapEventParty.Party.MapFaction.IsBanditFaction || mapEventParty.Party.MapFaction.StringId == "TheSyndicate"))
                        {
                            isBanditWin = true;
                        }
                    }
                }

                if (isBanditWin && winners.Count > 1)
                {
                    var behavior = Campaign.Current.GetCampaignBehavior<BanditCohesionBehavior>();
                    behavior?.MergeParties(winners);
                }
            }
            catch 
            {
                // Silently fail if systems aren't ready
            }
        }
    }
}

