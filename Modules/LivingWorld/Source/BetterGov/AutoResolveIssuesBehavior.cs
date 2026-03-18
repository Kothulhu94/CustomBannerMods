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
        private Serilog.ILogger _logger => LivingWorld.LivingWorldCore.Logger;
        
        
        private static readonly System.Reflection.FieldInfo _rewardGoldField;
        private static readonly System.Reflection.FieldInfo _relationField;
        private static readonly System.Reflection.FieldInfo _alternativeHeroField;
        private static readonly System.Reflection.MethodInfo _completeAlternativeMethod;

        static AutoResolveIssuesBehavior()
        {
            try
            {

                var issueBaseType = typeof(IssueBase);
                _rewardGoldField = issueBaseType.GetField("<RewardGold>k__BackingField", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                _relationField = issueBaseType.GetField("<RelationshipChangeWithIssueOwner>k__BackingField", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                _alternativeHeroField = issueBaseType.GetField("AlternativeSolutionHero", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                _completeAlternativeMethod = issueBaseType.GetMethod("CompleteIssueWithAlternativeSolution", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
            }
            catch (Exception)
            {
            }
        }

        public AutoResolveIssuesBehavior()
        {
            // Constructor doesn't need to do anything now that we use the static shared logger
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

            // Diagnostic: Log every 50 settlements to avoid spam, but prove it's ticking
            if (settlement.IsTown && settlement.OwnerClan?.Leader != null)
            {
                 // _logger.Information($"[BETTERGOV] Ticking town {settlement.Name}");
            }

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

            if (governor == null) return;

            var notables = settlement.Notables; 
            if (notables == null || notables.Count == 0) return;

            for (int i = 0; i < notables.Count; i++)
            {
                var notable = notables[i];
                if (notable.IsGangLeader) continue;

                IssueBase issue = notable.Issue;
                if (issue == null) continue;

                _logger.Information($"[BETTERGOV] Found issue '{issue.Title}' on {notable.Name} in {settlement.Name}. Elapsed: {issue.IssueCreationTime.ElapsedDaysUntilNow:F1} days.");

                if (issue.IsSolvingWithQuest) 
                {
                    _logger.Information($"[BETTERGOV] Skipping '{issue.Title}': Solving with quest.");
                    continue;
                }

                if (issue.IssueCreationTime.ElapsedDaysUntilNow > GlobalSettings.Instance.IssueResolveThresholdDays)
                {
                    try
                    {
                        ResolveIssue(governor, notable, issue);
                    }
                    catch (Exception ex)
                    {
                        _logger.Error(ex, $"[BETTERGOV] Failed to resolve issue '{issue.Title}' in {settlement.Name}");
                    }
                }
                else
                {
                     _logger.Information($"[BETTERGOV] Skipping '{issue.Title}': Threshold not met ({GlobalSettings.Instance.IssueResolveThresholdDays} days required).");
                }
            }
        }

        private void ResolveIssue(Hero governor, Hero notable, IssueBase issue)
        {
            _logger.Information($"[BETTERGOV] Starting ResolveIssue for '{issue.Title}'. Governor: {governor.Name}, Clan: {governor.Clan?.Name}");

            bool isAIClan = governor.Clan != Clan.PlayerClan;

            try
            {
                if (isAIClan)
                {
                    // AI Resolution: Capture rewards, Deactivate Issue, Apply Manually
                    int goldReward = 0;
                    if (_rewardGoldField != null)
                    {
                        var val = _rewardGoldField.GetValue(issue);
                        if (val is int intVal) goldReward = intVal;
                    }
                    int relationReward = issue.RelationshipChangeWithIssueOwner;

                    _logger.Information($"[BETTERGOV] AI Clan governor detected. Capturing rewards: {goldReward} Gold, {relationReward} Relation.");

                    // Silent Deactivation - prevents the game from firing standard resolution logic (and giving rewards to player)
                    Campaign.Current.IssueManager.DeactivateIssue(issue);

                    // Manual Reward Application to the AI governor
                    if (goldReward > 0)
                    {
                        GiveGoldAction.ApplyBetweenCharacters(null, governor, goldReward, true);
                        _logger.Information($"[BETTERGOV] Manually applied {goldReward} Gold to {governor.Name}.");
                    }

                    if (relationReward != 0)
                    {
                        ChangeRelationAction.ApplyRelationChangeBetweenHeroes(governor, notable, relationReward, true);
                        _logger.Information($"[BETTERGOV] Manually applied {relationReward} Relation between {governor.Name} and {notable.Name}.");
                    }
                    
                    _logger.Information($"[BETTERGOV] AI Silent Resolution finished for '{issue.Title}'.");
                }
                else
                {
                    // Player Clan Resolution: Standard native resolution (player gets rewards)
                    _logger.Information($"[BETTERGOV] Player Clan governor detected. Using native resolution.");
                    
                    if (_alternativeHeroField != null)
                    {
                        _alternativeHeroField.SetValue(issue, governor);
                    }

                    if (_completeAlternativeMethod != null)
                    {
                        _completeAlternativeMethod.Invoke(issue, null);
                    }
                    else
                    {
                        issue.CompleteIssueWithAlternativeSolution();
                    }
                    
                    _logger.Information($"[BETTERGOV] Player Resolution finished for '{issue.Title}'.");
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"[BETTERGOV] Error in Resolution for issue '{issue.Title}'");
                if (!isAIClan)
                {
                     issue.CompleteIssueWithAlternativeSolution();
                }
            }
        }
    }
}
