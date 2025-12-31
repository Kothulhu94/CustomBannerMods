using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.Party;
using LudusMagnus.Core;

namespace LudusMagnus.Political
{
    public class GrandCouncilCampaignBehavior : CampaignBehaviorBase
    {
        private Hero _currentHost;
        private CouncilVotingModel _votingModel;

        public GrandCouncilCampaignBehavior()
        {
            _votingModel = new CouncilVotingModel();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("LudusGrandGamesHost", ref _currentHost);
        }

        public Hero CurrentHost { get { return _currentHost; } }
        private CampaignTime _silenceEndTime;

        private void OnDailyTick()
        {
             // Spring 1: Election Day (Vote for Host)
            if (CampaignTime.Now.GetDayOfSeason == 1 && CampaignTime.Now.GetSeasonOfYear == CampaignTime.Seasons.Spring)
            {
                HoldElection();
            }
            
            // Summer 1: The Grand Games (1 Month / Season later)
            if (CampaignTime.Now.GetDayOfSeason == 1 && CampaignTime.Now.GetSeasonOfYear == CampaignTime.Seasons.Summer)
            {
                HoldGrandGames();
            }

            // Apply Year of Silence Penalty
            if (_silenceEndTime != null && _silenceEndTime.IsFuture)
            {
                ApplyGlobalDepression();
            }
        }

        public void StartYearOfSilence()
        {
            _silenceEndTime = CampaignTime.Now + CampaignTime.Years(1);
            InformationManager.DisplayMessage(new InformationMessage("THE YEAR OF SILENCE HAS BEGUN! The Grand Games are cancelled. Global Morale Penalty Active.", Colors.Red));
        }

        private void ApplyGlobalDepression()
        {
            foreach (var party in MobileParty.All)
            {
                if (party.IsActive && party.MemberRoster.TotalManCount > 0)
                {
                    if (party.RecentEventsMorale > -10f)
                    {
                         party.RecentEventsMorale -= 1f;
                    }
                }
            }
        }

        private void HoldGrandGames()
        {
             if (_currentHost == null) return;
             
             // Check if Host's Ludus is Ruined *Now*
             var hostLudus = LudusManager.Instance.GetLudusFor(_currentHost);
             if (hostLudus != null && hostLudus.State == LudusState.Ruined)
             {
                 StartYearOfSilence();
                 return;
             }
             
             // If not ruined, Games happen!
             string locName = hostLudus?.Settlement?.Name?.ToString() ?? "the Ludus";
             InformationManager.DisplayMessage(new InformationMessage($"The Grand Games are being held at {locName} by {_currentHost.Name}!", Colors.Green));
             GainRenownAction.Apply(_currentHost, 100); // Bonus for successful hosting
        }

        private void HoldElection()
        {
            if (LudusManager.Instance == null) return;
            
            if (_silenceEndTime != null && _silenceEndTime.IsFuture)
            {
                InformationManager.DisplayMessage(new InformationMessage("The Grand Council is suspended due to the Year of Silence.", Colors.Yellow));
                return;
            }

            var candidates = LudusManager.Instance.GetAllLudusLocations()
                .Where(kvp => kvp.Value.State == LudusState.Active && kvp.Value.Owner != null)
                .Select(kvp => kvp.Value.Owner)
                .ToList();

            if (candidates.Count == 0) return;

            // Determine Winner logic
            Hero winner = null;
            float maxVotes = -1f;

            // Simplified: All Clan Leaders vote
            foreach (var candidate in candidates)
            {
                float votes = 0f;
                foreach (var clan in Clan.All)
                {
                    if (clan.IsEliminated || clan.Leader == null || clan.Tier < 3) continue;
                    votes += _votingModel.CalculateVoteWeight(clan.Leader, candidate);
                }

                if (votes > maxVotes)
                {
                    maxVotes = votes;
                    winner = candidate;
                }
            }

            if (winner != null)
            {
                _currentHost = winner;
                ApplyWinnerRefards(winner);

                InformationManager.DisplayMessage(new InformationMessage($"Grand Council: {winner.Name} has been elected Magister Munerarius! The Grand Games will be held in Summer.", Colors.Green));
            }
        }

        private void ApplyWinnerRefards(Hero winner)
        {
            GainRenownAction.Apply(winner, 50);
            if (winner.Clan != null)
            {
                ChangeClanInfluenceAction.Apply(winner.Clan, 100);
            }
        }
    }
}
