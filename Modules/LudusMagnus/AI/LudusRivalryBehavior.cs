using System.Linq;
using LudusMagnus.Core;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.Library;

namespace LudusMagnus.AI
{
    public class LudusRivalryBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.WeeklyTickEvent.AddNonSerializedListener(this, OnWeeklyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnWeeklyTick()
        {
            if (LudusManager.Instance == null || LudusManager.Instance.LudusRegistry == null) return;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                LudusLocation ludus = kvp.Value;
                if (ludus.State != LudusState.Active || ludus.Settlement == null) continue;

                if (MBRandom.RandomFloat > 0.1f) continue;

                LudusLocation rival = FindBestRival(ludus);
                if (rival != null && rival.Owner != null)
                {
                    // 50% chance for Sabotage, 50% for Tournament Challenge
                    if (MBRandom.RandomFloat < 0.5f)
                    {
                        SpawnSaboteur(rival.Owner, ludus);
                    }
                    else if (ludus.Owner == Hero.MainHero || rival.Owner == Hero.MainHero)
                    {
                        TriggerTournamentChallenge(rival.Owner == Hero.MainHero ? ludus : rival, rival.Owner == Hero.MainHero ? rival : ludus);
                    }
                }
            }
        }

        private void TriggerTournamentChallenge(LudusLocation challengerLudus, LudusLocation playerLudus)
        {
            if (playerLudus.Owner != Hero.MainHero) return;

            InformationManager.ShowInquiry(new InquiryData(
                new TextObject("{=ludus_chal}Rival Challenge!").ToString(),
                new TextObject($"The Master of {challengerLudus.Settlement.Name}, {challengerLudus.Owner.Name}, challenges you to a Tournament War! \n\nAccept: Win 50 Renown / Lose 20 Renown\nDecline: Lose 5 Renown").ToString(),
                true, true,
                new TextObject("{=ludus_acc}Accept Invitation").ToString(),
                new TextObject("{=ludus_dec}Decline").ToString(),
                () => 
                {
                    // Simulated Battle Logic
                    bool win = MBRandom.RandomFloat > 0.4f; // Slight bias to player
                    if (win)
                    {
                        GainRenownAction.Apply(Hero.MainHero, 50);
                        if (challengerLudus.Owner != null) GainRenownAction.Apply(challengerLudus.Owner, -30);
                        InformationManager.DisplayMessage(new InformationMessage($"Victory! You humbled {challengerLudus.Owner.Name} in the arena!", Colors.Green));
                    }
                    else
                    {
                        GainRenownAction.Apply(Hero.MainHero, -20);
                        if (challengerLudus.Owner != null) GainRenownAction.Apply(challengerLudus.Owner, 40);
                        InformationManager.DisplayMessage(new InformationMessage($"Defeat! {challengerLudus.Owner.Name} proved superior this time.", Colors.Red));
                    }
                },
                () => 
                {
                    GainRenownAction.Apply(Hero.MainHero, -5);
                    InformationManager.DisplayMessage(new InformationMessage("You declined the challenge. The crowd calls you a coward.", Colors.Yellow));
                }
            ));
        }

        private LudusLocation FindBestRival(LudusLocation source)
        {
            LudusLocation bestRival = null;
            float closestDist = 500f;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                if (kvp.Value == source) continue;
                if (kvp.Value.Settlement == null || source.Settlement == null) continue;
                if (kvp.Value.Owner.Clan == source.Owner.Clan) continue;

                float dist = source.Settlement.GatePosition.Distance(kvp.Value.Settlement.GatePosition);
                if (dist < closestDist)
                {
                    closestDist = dist;
                    bestRival = kvp.Value;
                }
            }
            return bestRival;
        }

        private void SpawnSaboteur(Hero employer, LudusLocation target)
        {
            Clan banditClan = Clan.All.FirstOrDefault(c => c.StringId == "looters");
            if (banditClan == null) return;

            // Updated CreateParty to remove 3rd arg (null)
            MobileParty saboteurParty = MobileParty.CreateParty("ludus_saboteur_" + MBRandom.RandomInt(10000), null);
            TextObject name = new TextObject("{=ludus_sab}Hired Saboteurs of {CLAN_NAME}");
            name.SetTextVariable("CLAN_NAME", employer.Clan.Name);
            
            // Removed SetCustomName

            Settlement origin = employer.HomeSettlement ?? target.Settlement;
            
            // Using 'var' for position
            var spawnPos = origin.GatePosition;

            CharacterObject troop = CharacterObject.All.FirstOrDefault(t => t.StringId == "mercenary_swordsman") ?? banditClan.BasicTroop;
            saboteurParty.MemberRoster.AddToCounts(troop, 15);
            saboteurParty.MemberRoster.AddToCounts(banditClan.BasicTroop, 10);

            saboteurParty.SetPartyUsedByQuest(true);
            saboteurParty.ActualClan = banditClan;
            
            saboteurParty.InitializeMobilePartyAtPosition(saboteurParty.MemberRoster, saboteurParty.PrisonRoster, spawnPos);

            saboteurParty.SetMovePatrolAroundSettlement(target.Settlement, MobileParty.NavigationType.Default, true);
            saboteurParty.Aggressiveness = 10f;

            if (target.Owner == Hero.MainHero)
            {
                InformationManager.DisplayMessage(new InformationMessage($"Spy reports: {employer.Name} has hired bandits to sabotage your Ludus!", Colors.Red));
            }
        }
    }
}
