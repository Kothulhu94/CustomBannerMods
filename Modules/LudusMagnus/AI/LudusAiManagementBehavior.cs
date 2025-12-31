using System;
using System.Linq;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.Party;
using LudusMagnus.Core;
using LudusMagnus.Settlements;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using Serilog;
using Microsoft.Extensions.Logging;

namespace LudusMagnus.AI
{
    public class LudusAiManagementBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnDailyTick()
        {
            if (LudusManager.Instance == null) return;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                var ludus = kvp.Value;
                // AI Only
                if (ludus.State != LudusState.Active || ludus.Settlement == null || ludus.Owner == Hero.MainHero) continue;

                ManageUpgrades(ludus);
                ManageUpgrades(ludus);
                ManageStaff(ludus);
                ManageAscension(ludus);
            }
        }

        private void ManageUpgrades(LudusLocation ludus)
        {
             // 5% Chance Daily to attempt upgrade
             if (MBRandom.RandomFloat > 0.05f) return;

             var options = Enum.GetValues(typeof(FacilityType)).Cast<FacilityType>().ToList();
             
             // Weighted Selection
             var weightedOptions = new List<Tuple<FacilityType, float>>();
             
             foreach (var type in options)
             {
                 if (LudusUpgradeManager.Instance.CanUpgrade(ludus, type, out _))
                 {
                     float score = GetUpgradeScore(ludus, type);
                     weightedOptions.Add(new Tuple<FacilityType, float>(type, score));
                 }
             }

             if (weightedOptions.Count == 0) return;

             // Sort by score descending and take top
             var bestOption = weightedOptions.OrderByDescending(x => x.Item2).First();
             
             // AI Check: Reserve Gold (Don't spend last penny)
             int cost = LudusUpgradeManager.Instance.GetUpgradeCost(LudusUpgradeManager.Instance.GetUpgradeLevel(ludus, bestOption.Item1));
             
             if (ludus.Owner.Gold > cost * 1.5f)
             {
                 LudusUpgradeManager.Instance.UpgradeFacility(ludus, bestOption.Item1);
                 LudusSubModule.InstanceLogger?.LogInformation($"[AI Decision] {ludus.Owner.Name} upgraded {bestOption.Item1} at {ludus.Settlement.Name}. Score: {bestOption.Item2:F1}");
             }
        }

        private float GetUpgradeScore(LudusLocation ludus, FacilityType type)
        {
            float score = 10f; // Base score

            switch (type)
            {
                case FacilityType.MasterSmithy:
                    // Priority if poor (<50k gold)
                    if (ludus.Owner.Gold < 50000) score += 50f;
                    if (ludus.Owner.Gold < 20000) score += 100f;
                    break;
                
                case FacilityType.Dormitory:
                    // Priority if garrison is filling up
                    if (ludus.Settlement?.Town?.GarrisonParty != null)
                    {
                         int count = ludus.Settlement.Town.GarrisonParty.MemberRoster.TotalManCount;
                         int limit = ludus.Settlement.Town.GarrisonParty.Party.PartySizeLimit;
                         if (limit > 0 && count > limit * 0.8f) score += 80f;
                    }
                    break;

                case FacilityType.Temple:
                    // Priority if has high-tier troops for ascension
                    if (ludus.Settlement?.Town?.GarrisonParty != null)
                    {
                        var highTierCount = ludus.Settlement.Town.GarrisonParty.MemberRoster.GetTroopRoster()
                            .Where(t => t.Character.Tier >= 5).Sum(t => t.Number);
                        if (highTierCount > 10) score += 60f;
                    }
                    break;
                
                case FacilityType.Naumachia:
                    // General prestige, moderate boost if rich
                    if (ludus.Owner.Gold > 200000) score += 20f;
                    break;
            }
            
            // Random jitter to prevent rigid patterns
            score += MBRandom.RandomFloat * 10f;
            return score;
        }

        private void ManageStaff(LudusLocation ludus)
        {
             // 10% Chance Daily to hire staff
             if (MBRandom.RandomFloat > 0.1f) return;

             var roles = Enum.GetValues(typeof(StaffRole)).Cast<StaffRole>().ToList();
             foreach (var role in roles)
             {
                 if (!ludus.Staff.ContainsKey(role))
                 {
                     HireBestStaff(ludus, role);
                     return; // One per day
                 }
             }
        }

        private void HireBestStaff(LudusLocation ludus, StaffRole role)
        {
            int hiringCost = 5000;
            if (ludus.Owner.Gold < hiringCost * 2) return;

            // Find best wanderer
            var candidates = Hero.AllAliveHeroes.Where(h => 
                h.IsWanderer && 
                h.Clan == null && 
                h.PartyBelongedTo == null &&
                h.CurrentSettlement != null).ToList();

            if (candidates.Count == 0) return;

            Hero bestCandidate = null;
            float bestScore = -1f;

            foreach (var candidate in candidates)
            {
                float score = 0f;
                // Base skills with weightings
                switch (role)
                {
                    case StaffRole.Lanista:
                        score = candidate.GetSkillValue(DefaultSkills.Steward) + candidate.GetSkillValue(DefaultSkills.Roguery);
                        break;
                    case StaffRole.Doctore:
                        score = candidate.GetSkillValue(DefaultSkills.Leadership) + candidate.GetSkillValue(DefaultSkills.Athletics);
                        break;
                    case StaffRole.Medicus:
                        // Medicine is critical, weight highly
                        score = candidate.GetSkillValue(DefaultSkills.Medicine) * 2;
                        break;
                    case StaffRole.Procurator:
                        score = candidate.GetSkillValue(DefaultSkills.Trade) + candidate.GetSkillValue(DefaultSkills.Charm);
                        break;
                }
                
                if (score > bestScore)
                {
                    bestScore = score;
                    bestCandidate = candidate;
                }
            }

            if (bestCandidate != null)
            {
                 GiveGoldAction.ApplyBetweenCharacters(ludus.Owner, null, hiringCost);
                 AddCompanionAction.Apply(ludus.Owner.Clan, bestCandidate);
                 ludus.Staff[role] = bestCandidate;
                 
                 LudusSubModule.InstanceLogger?.LogInformation($"[AI Decision] {ludus.Owner.Name} hired {bestCandidate.Name} as {role}. Skill Score: {bestScore}");
            }
        }
        private void ManageAscension(LudusLocation ludus)
        {
            // Requirement: Temple Facility
            if (!ludus.Facilities.ContainsKey(FacilityType.Temple)) return;

            // Requirement: Garrison
            if (ludus.Settlement == null || ludus.Settlement.Town == null || ludus.Settlement.Town.GarrisonParty == null) return;

            var garrison = ludus.Settlement.Town.GarrisonParty;
            
            // Limit: Ascend 2-5 troops per day
            int limit = MBRandom.RandomInt(2, 6); // 2 to 5
            int ascendedCount = 0;

            // Find eligible troops
            // We use a copy of the roster to avoid modification errors during iteration if we were strictly iterating
            // But we will just find one type at a time.
            
            // Logic similar to AscensionTroopLogic.ShowInquiry but automated.
            var eligibleTroopNodes = garrison.MemberRoster.GetTroopRoster()
                .Where(t => !t.Character.IsHero && 
                            t.Character.Tier >= 5 && 
                            (t.Character.UpgradeTargets == null || t.Character.UpgradeTargets.Length == 0))
                .ToList();

            if (eligibleTroopNodes.Count == 0) return;

            // Shuffle or pick random? Let's just pick random types until limit reached.
            for (int i = 0; i < limit; i++)
            {
                if (eligibleTroopNodes.Count == 0) break;
                
                var node = eligibleTroopNodes.GetRandomElement();
                
                // Double check count in roster (it might have depleted in previous loop iteration)
                int currentCount = garrison.MemberRoster.GetTroopCount(node.Character);
                if (currentCount > 0)
                {
                    // Ascend ONE at a time
                    LudusMagnus.Ascension.AscensionTroopLogic.AscendTroop(garrison.Party, node.Character, 1);
                    ascendedCount++;

                    // If that was the last one, remove from eligible list for optimization (optional but good)
                    if (currentCount - 1 <= 0)
                    {
                        eligibleTroopNodes.Remove(node);
                    }
                }
                else
                {
                    eligibleTroopNodes.Remove(node);
                    i--; // Retry
                }
            }
            
            // Optional: Log or notify if player is nearby or debug enabled
            // if (ascendedCount > 0) InformationManager.DisplayMessage(new InformationMessage($"[AI] {ludus.Settlement.Name} ascended {ascendedCount} garrison troops."));
        }
    }
}
