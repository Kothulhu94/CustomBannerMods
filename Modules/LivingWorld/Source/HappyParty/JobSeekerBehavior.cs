using System;
using System.Linq;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Settlements.Locations;
using TaleWorlds.Core;
using TaleWorlds.Library;
using Serilog;

namespace HappyParty
{
    public class JobSeekerBehavior : CampaignBehaviorBase
    {
        private readonly GlobalSettings _settings;
        private readonly ILogger _logger;
        public JobSeekerBehavior(GlobalSettings settings, ILogger logger)
        {
            _settings = settings;
            _logger = logger.ForContext<JobSeekerBehavior>();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.SettlementEntered.AddNonSerializedListener(this, OnSettlementEntered);
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            AddDialogs(starter);
        }

        private void OnSettlementEntered(MobileParty mobileParty, Settlement settlement, Hero hero)
        {
            try
            {
                if (mobileParty == null || mobileParty.IsMainParty || !mobileParty.IsLordParty)
                {
                    return;
                }

                if (!settlement.IsTown)
                {
                    return;
                }
                
                int companionCount = 0;
                try
                {
                    companionCount = mobileParty.MemberRoster.GetTroopRoster().Count(x => x.Character != null && x.Character.IsHero && x.Character.HeroObject != mobileParty.LeaderHero);
                }
                catch (Exception ex) 
                { 
                     _logger.Error(ex, $"Error counting companions for {mobileParty.Name}");
                     return; 
                }
            
                if (companionCount >= 4)
                {
                    return;
                }

                Hero leader = mobileParty.LeaderHero;
                if (leader == null) return;

                try
                {
                    if (CheckAndHire(mobileParty, settlement, DefaultSkills.Medicine, "Surgeon")) return;
                    if (CheckAndHire(mobileParty, settlement, DefaultSkills.Engineering, "Engineer")) return;
                    if (CheckAndHire(mobileParty, settlement, DefaultSkills.Scouting, "Scout")) return;
                    if (CheckAndHire(mobileParty, settlement, DefaultSkills.Steward, "Quartermaster")) return;
                }
                catch (Exception ex)
                {
                     _logger.Error(ex, $"Error in CheckAndHire sequence for {mobileParty.Name}");
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Critical Error in JobSeekerBehavior.OnSettlementEntered");
            }
        }

        private bool CheckAndHire(MobileParty party, Settlement settlement, SkillObject skill, string roleName)
        {
            try
            {
                Hero leader = party.LeaderHero;
                Hero assignedHero = GetAssignedHeroForRole(party, roleName);

                int leaderSkill = leader.GetSkillValue(skill);
                int assignedSkill = assignedHero != null ? assignedHero.GetSkillValue(skill) : 0;

                bool needsHiring = leaderSkill < 50 && (assignedHero == null || assignedSkill < 60);

                if (!needsHiring) return false;

                if (settlement.HeroesWithoutParty != null)
                {
                    var potentialHires = settlement.HeroesWithoutParty.Where(h => h.IsWanderer && h.CompanionOf == null && (h.Clan == null || h.Clan.IsEliminated || h.Clan.StringId.ToLower().Contains("wanderer"))).ToList();

                    foreach (var wanderer in potentialHires)
                    {
                        int wandererSkill = wanderer.GetSkillValue(skill);
                        if (wandererSkill > 60)
                        {
                            int hiringCost = _settings.JobSeekerHireCost;
                    
                            if (leader.Gold >= hiringCost)
                            {
                                if (_settings.DebugMode)
                                    _logger.Information($"JobSeeker: {leader.Name} hiring {wanderer.Name} as {roleName}");

                                AddCompanionAction.Apply(party.Party.Owner.Clan, wanderer);
                                AddHeroToPartyAction.Apply(wanderer, party);
                                GiveGoldAction.ApplyBetweenCharacters(leader, null, hiringCost, true);
                                AssignRole(party, wanderer, roleName);
                                
                                return true; 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error in JobSeekerBehavior.CheckAndHire for {party.Name} hiring {roleName}");
            }
            return false;
        }

        private Hero GetAssignedHeroForRole(MobileParty party, string roleName)
        {
            switch (roleName)
            {
                case "Surgeon": return party.EffectiveSurgeon;
                case "Engineer": return party.EffectiveEngineer;
                case "Scout": return party.EffectiveScout;
                case "Quartermaster": return party.EffectiveQuartermaster;
                default: return null;
            }
        }

        private void AssignRole(MobileParty party, Hero hero, string roleName)
        {
            switch (roleName)
            {
                case "Surgeon": party.SetPartySurgeon(hero); break;
                case "Engineer": party.SetPartyEngineer(hero); break;
                case "Scout": party.SetPartyScout(hero); break;
                case "Quartermaster": party.SetPartyQuartermaster(hero); break;
            }
        }

        // --- Prisoner Dialogue Logic ---

        private void AddDialogs(CampaignGameStarter starter)
        {
            starter.AddDialogLine("jobseeker_prisoner_intro", "start", "jobseeker_prisoner_options",
                "{=jobseeker_intro}I yield. I am at your mercy.",
                Condition_IsJobSeekerPrisoner, null, 150, null);

            // Option 1: Release
            starter.AddPlayerLine("jobseeker_release", "jobseeker_prisoner_options", "jobseeker_release_verify",
                "{=jobseeker_release}You are free to go.",
                null, null, 100, null);

            // Option 2: Execute
            starter.AddPlayerLine("jobseeker_execute", "jobseeker_prisoner_options", "jobseeker_execute_verify",
                "{=jobseeker_execute}I have decided to execute you.",
                null, null, 100, null);

            // Option 3: Stay (End)
            starter.AddPlayerLine("jobseeker_stay", "jobseeker_prisoner_options", "close_window",
                "{=jobseeker_stay}You are my prisoner now.",
                null, null, 100, null);

            // --- Release Verification ---
            starter.AddDialogLine("jobseeker_release_response", "jobseeker_release_verify", "close_window",
                "{=jobseeker_release_thx}Thank you. I will not forget this.",
                null, Consequence_Release, 100, null);

            // --- Execute Verification ---
            starter.AddDialogLine("jobseeker_execute_response", "jobseeker_execute_verify", "jobseeker_execute_final",
                "{=jobseeker_exec_what}Is this the end then?",
                null, null, 100, null);

            starter.AddPlayerLine("jobseeker_execute_do_it", "jobseeker_execute_final", "close_window",
                "{=jobseeker_do_it}It must be done.",
                null, Consequence_Execute, 100, null);

            starter.AddPlayerLine("jobseeker_execute_cancel", "jobseeker_execute_final", "jobseeker_prisoner_options",
                "{=jobseeker_cancel}No, I have changed my mind.",
                null, null, 100, null);
        }

        private bool Condition_IsJobSeekerPrisoner()
        {
            Hero sharedHero = Hero.OneToOneConversationHero;
            if (sharedHero == null) return false;

            // Must be a prisoner of the player
            if (!sharedHero.IsPrisoner) return false;
            if (sharedHero.PartyBelongedToAsPrisoner != MobileParty.MainParty.Party) return false;

            // Target any Wanderer (catches AI-hired wanderers too as they keep Wanderer occupation)
            return sharedHero.IsWanderer;
        }

        private void Consequence_Release()
        {
            Hero sharedHero = Hero.OneToOneConversationHero;
            if (sharedHero != null)
            {
                EndCaptivityAction.ApplyByPeace(sharedHero, Hero.MainHero);
            }
        }

        private void Consequence_Execute()
        {
            Hero sharedHero = Hero.OneToOneConversationHero;
            if (sharedHero != null)
            {
                KillCharacterAction.ApplyByExecution(sharedHero, Hero.MainHero);
            }
        }
    }
}
