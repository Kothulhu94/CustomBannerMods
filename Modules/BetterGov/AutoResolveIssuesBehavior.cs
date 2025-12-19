using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Issues;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Library;

namespace BetterGov
{
    public class AutoResolveIssuesBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<AutoResolveIssuesBehavior> _logger;

        public AutoResolveIssuesBehavior(ILogger<AutoResolveIssuesBehavior> logger)
        {
            _logger = logger;
        }

        public override void RegisterEvents()
        {
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnHourlyTick()
        {
            if (CampaignTime.Now.CurrentHourInDay != 14) return;
            if (!GlobalSettings.Instance.AutoResolveIssues) return;

            foreach (var s in Settlement.All)
            {
                OnDailyTickSettlement(s);
            }
        }

        private void OnDailyTickSettlement(Settlement settlement)
        {
            // Target: Settlements with a Town component and a valid Governor
            if (!settlement.IsTown && !settlement.IsCastle)
            {
                return;
            }

            Town town = settlement.Town;
            if (town == null || town.Governor == null)
            {
                return;
            }

            // Iterate through Settlement.Notables
            var notables = settlement.Notables.ToList();

            foreach (var notable in notables)
            {
                if (notable.IsGangLeader) continue;

                IssueBase issue = notable.Issue;
                if (issue == null) continue;

                if (issue.IsSolvingWithQuest) continue;

                // Issue must be older than 7 days
                if (issue.IssueCreationTime.ElapsedDaysUntilNow > 7)
                {
                    try
                    {
                        ResolveIssue(town, notable, issue);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, $"Failed to resolve issue '{issue.Title}' in {town.Name}");
                    }
                }
            }
        }

        private void ResolveIssue(Town town, Hero notable, IssueBase issue)
        {
            _logger.LogInformation($"[DEBUG] Attempting to resolve issue '{issue.Title}' for {notable.Name} in {town.Name}");

            if (town.Governor.Clan == Clan.PlayerClan)
            {
                // Player gets credit
                var issueManager = Campaign.Current.IssueManager;
                var solveMethod = issueManager.GetType().GetMethod("SolveIssue", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance, null, new[] { typeof(IssueBase), typeof(Hero) }, null);
                
                if (solveMethod != null)
                {
                    solveMethod.Invoke(issueManager, new object[] { issue, town.Governor });
                    _logger.LogInformation($"Resolved issue '{issue.Title}' via Reflection: SolveIssue");
                }
                else
                {
                    issue.CompleteIssueWithAlternativeSolution();
                    _logger.LogInformation($"Resolved issue '{issue.Title}' via AlternativeSolution");
                }
            }
            else
            {
                // AI gets credit (Silent)
                ChangeRelationAction.ApplyRelationChangeBetweenHeroes(town.Governor, notable, 5);

                // Attempt to silently kill the issue
                Campaign.Current.IssueManager.DeactivateIssue(issue);
                _logger.LogInformation($"Resolved issue '{issue.Title}' via DeactivateIssue (AI)");
            }
        }
    }
}
