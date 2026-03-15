using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Issues;
using TaleWorlds.CampaignSystem.Settlements;

using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Library;

namespace BetterGov
{
    public class AutoResolveIssuesBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<AutoResolveIssuesBehavior> _logger;
        

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
            CampaignEvents.DailyTickSettlementEvent.AddNonSerializedListener(this, OnDailyTickSettlement);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnDailyTickSettlement(Settlement settlement)
        {
            if (!GlobalSettings.Instance.AutoResolveIssues) return;

            // Support Villages by looking up their bound settlement's governor
            Hero governor = null;
            if (settlement.IsTown || settlement.IsCastle)
            {
                governor = settlement.Town?.Governor ?? settlement.OwnerClan?.Leader;
            }
            else if (settlement.IsVillage)
            {
                governor = settlement.Village?.Bound?.Town?.Governor ?? settlement.Village?.Bound?.OwnerClan?.Leader;
            }

            if (governor == null)
            {
                return;
            }

            var notables = settlement.Notables; 

            for (int i = 0; i < notables.Count; i++)
            {
                var notable = notables[i];
                if (notable.IsGangLeader) continue;

                IssueBase issue = notable.Issue;
                if (issue == null) continue;

                if (issue.IsSolvingWithQuest) continue;


                if (issue.IssueCreationTime.ElapsedDaysUntilNow > GlobalSettings.Instance.IssueResolveThresholdDays)
                {
                    try
                    {
                        ResolveIssue(governor, notable, issue);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, $"Failed to resolve issue '{issue.Title}' in {settlement.Name}");
                    }
                }
            }
        }

        private void ResolveIssue(Hero governor, Hero notable, IssueBase issue)
        {
            _logger.LogInformation($"[DEBUG] Attempting to resolve issue '{issue.Title}' for {notable.Name} in {notable.HomeSettlement?.Name}");

            if (governor.Clan == Clan.PlayerClan)
            {
                // Player Clan Logic
                if (_solveIssueMethod != null)
                {
                    _solveIssueMethod.Invoke(Campaign.Current.IssueManager, new object[] { issue, governor });
                    _logger.LogInformation($"Resolved player issue '{issue.Title}' via Reflection: SolveIssue");
                }
                else
                {
                    issue.CompleteIssueWithAlternativeSolution();
                    _logger.LogInformation($"Resolved player issue '{issue.Title}' via LordSolution fallback");
                }
            }
            else
            {
                int cost = GlobalSettings.Instance.IssueResolveCost;
                Hero payor = governor.Clan?.Leader ?? governor;

                if (payor != null && payor.Gold >= cost)
                {
                    // AI pays the fee to unlock the resolution
                    GiveGoldAction.ApplyBetweenCharacters(payor, null, cost, true);
                    
                    if (_solveIssueMethod != null)
                    {
                        _solveIssueMethod.Invoke(Campaign.Current.IssueManager, new object[] { issue, governor });
                        if (GlobalSettings.Instance.DebugMode)
                            _logger.LogInformation($"[AI Decision] {notable.HomeSettlement?.Name} Gov resolved '{issue.Title}' via SolveIssue (Cost: {cost}g).");
                    }
                    else
                    {
                        // Fallback if reflection fails
                        ChangeRelationAction.ApplyRelationChangeBetweenHeroes(governor, notable, 5);
                        issue.CompleteIssueWithAlternativeSolution();
                        
                        if (GlobalSettings.Instance.DebugMode)
                            _logger.LogInformation($"[AI Decision] {notable.HomeSettlement?.Name} Gov resolved '{issue.Title}' via LordSolution (Cost: {cost}g).");
                    }
                }
                else
                {
                    if (GlobalSettings.Instance.DebugMode)
                         _logger.LogInformation($"[AI Decision] {notable.HomeSettlement?.Name} Gov too poor to resolve '{issue.Title}' (Has: {payor?.Gold ?? 0}g).");
                }
            }
        }
    }
}
