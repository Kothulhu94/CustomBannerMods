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
        
        // Caching Reflection
        private static readonly System.Reflection.MethodInfo _solveIssueMethod;

        static AutoResolveIssuesBehavior()
        {
            try
            {
                var issueManagerType = typeof(Campaign).Assembly.GetType("TaleWorlds.CampaignSystem.Issues.IssueManager");
                if (issueManagerType != null)
                {
                    _solveIssueMethod = issueManagerType.GetMethod("SolveIssue", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance, null, new[] { typeof(IssueBase), typeof(Hero) }, null);
                }
            }
            catch { }
        }

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

            // Optimization: Remove .ToList() allocation
            // Iterate directly over MBReadOnlyList
            var notables = settlement.Notables; 

            for (int i = 0; i < notables.Count; i++)
            {
                var notable = notables[i];
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
                
                if (_solveIssueMethod != null)
                {
                    _solveIssueMethod.Invoke(issueManager, new object[] { issue, town.Governor });
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
                // AI Cost Logic (Parity)
                // Deduct 500 Gold to simulate resource usage (Bribes, Troops, Time)
                int cost = 500;
                Hero payor = town.Governor.Clan?.Leader ?? town.Governor; // Clan Leader pays

                if (payor != null && payor.Gold >= cost)
                {
                    GiveGoldAction.ApplyBetweenCharacters(payor, null, cost, true);
                    
                    ChangeRelationAction.ApplyRelationChangeBetweenHeroes(town.Governor, notable, 5);
                    Campaign.Current.IssueManager.DeactivateIssue(issue);
                    
                    if (GlobalSettings.Instance.DebugMode)
                        _logger.LogInformation($"[AI Decision] {town.Name} Governor resolved '{issue.Title}' (Cost: {cost}g).");
                }
                else
                {
                    if (GlobalSettings.Instance.DebugMode)
                         _logger.LogInformation($"[AI Decision] {town.Name} Governor too poor to resolve '{issue.Title}' (Has: {payor?.Gold ?? 0}g).");
                }
            }
        }
    }
}
