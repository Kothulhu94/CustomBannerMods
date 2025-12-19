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
        }

        public override void SyncData(IDataStore dataStore)
        {
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
                    var allHeroes = new List<Hero>();
                    foreach (var h in settlement.HeroesWithoutParty) allHeroes.Add(h);

                    var potentialHires = allHeroes.Where(h => h.IsWanderer && h.CompanionOf == null && (h.Clan == null || h.Clan.IsEliminated || h.Clan.StringId.ToLower().Contains("wanderer"))).ToList();

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
    }
}
