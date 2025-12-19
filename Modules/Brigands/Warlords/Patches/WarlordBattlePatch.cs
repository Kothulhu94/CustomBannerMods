using HarmonyLib;
using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.MapEvents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace Brigands.Warlords.Patches
{
    [HarmonyPatch(typeof(MapEvent), "FinalizeEvent")]
    public static class WarlordBattlePatch
    {
        public static void Postfix(MapEvent __instance)
        {
            try
            {
                if (__instance == null || __instance.WinningSide == BattleSideEnum.None) return;

                foreach (var party in __instance.GetMapEventSide(__instance.DefeatedSide).Parties)
                {
                    try
                    {
                        if (party.Party == null) continue;
                        MobileParty mobileParty = party.Party.MobileParty;
                        if (mobileParty == null) continue;

                        Hero leader = mobileParty.LeaderHero;
                        
                        if (leader != null && leader.Clan != null && leader.Clan.StringId == "TheSyndicate")
                        {
                            ApplyWarlordDefeatLogic(__instance, mobileParty, leader);
                        }
                    }
                    catch 
                    {
                    }
                }
            }
            catch 
            {
            }
        }

        private static void ApplyWarlordDefeatLogic(MapEvent mapEvent, MobileParty warlordParty, Hero warlord)
        {
            try
            {
                if (!warlord.IsAlive || warlord.IsPrisoner) return;

                PartyBase winnerParty = mapEvent.GetMapEventSide(mapEvent.WinningSide).LeaderParty;
                
                if (winnerParty == null && mapEvent.GetMapEventSide(mapEvent.WinningSide).Parties.Count > 0)
                {
                    winnerParty = mapEvent.GetMapEventSide(mapEvent.WinningSide).Parties.FirstOrDefault(x => x.Party != null)?.Party;
                }

                if (winnerParty != null)
                {
                     TakePrisonerAction.Apply(winnerParty, warlord);
                     
                     if (warlordParty.IsActive)
                     {
                         DestroyPartyAction.Apply(winnerParty, warlordParty);
                     }
                }
                else
                {
                     warlord.ChangeState(Hero.CharacterStates.Fugitive);
                     if (warlordParty.IsActive)
                     {
                         DestroyPartyAction.Apply(null, warlordParty);
                     }
                }
            }
            catch 
            {
            }
        }
    }
}

