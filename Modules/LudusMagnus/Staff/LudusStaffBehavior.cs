using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using LudusMagnus.Core;
using Serilog;
using Microsoft.Extensions.Logging;

namespace LudusMagnus.Staff
{
    public class LudusStaffBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnDailyTick()
        {
            if (LudusManager.Instance == null) return;

            int count = 0;
            foreach (var kvp in LudusManager.Instance.GetAllLudusLocations())
            {
                var ludus = kvp.Value;
                if (ludus.State != LudusState.Active || ludus.Settlement == null) continue;

                ApplyDoctoreEffect(ludus);
                ApplyMedicusEffect(ludus);
                ApplyLanistaEffect(ludus);
                count++;
            }
            
            if (count > 0)
            {
                 LudusSubModule.InstanceLogger?.LogDebug("LudusStaffBehavior: Processed staff effects for {Count} locations.", count);
            }
        }

        private void ApplyLanistaEffect(LudusLocation ludus)
        {
            if (!ludus.Staff.TryGetValue(StaffRole.Lanista, out var lanista) || lanista == null) return;

            int steward = lanista.GetSkillValue(DefaultSkills.Steward);
            int income = steward * 10;

            if (ludus.Owner?.Clan != null)
            {
                ludus.Owner.Clan.Leader.ChangeHeroGold(income);
                LudusSubModule.InstanceLogger?.LogDebug("Lanista {Name} generated {Income} gold for {Clan} at {Settlement}.", lanista.Name, income, ludus.Owner.Clan.Name, ludus.Settlement?.Name);
            }
        }

        private void ApplyDoctoreEffect(LudusLocation ludus)
        {
            if (!ludus.Staff.TryGetValue(StaffRole.Doctore, out var doctore) || doctore == null) return;
            if (ludus.Settlement == null) return;

            int leadership = doctore.GetSkillValue(DefaultSkills.Leadership);
            int xpAmount = 50 + (leadership * 5);

            // Find garrison party
            MobileParty garrison = ludus.Settlement.Town?.GarrisonParty ?? ludus.Settlement.Parties.FirstOrDefault(p => p.IsGarrison);
            
            if (garrison != null)
            {
                int troopCount = 0;
                foreach (var trooper in garrison.MemberRoster.GetTroopRoster())
                {
                    if (!trooper.Character.IsHero)
                    {
                        garrison.MemberRoster.AddXpToTroop(trooper.Character, xpAmount);
                        troopCount++;
                    }
                }
                LudusSubModule.InstanceLogger?.LogDebug("Doctore {Name} granted {XP} XP to {Count} stacks in {Garrison}.", doctore.Name, xpAmount, garrison.MemberRoster.Count, ludus.Settlement?.Name);
            }
        }

        private void ApplyMedicusEffect(LudusLocation ludus)
        {
            if (!ludus.Staff.TryGetValue(StaffRole.Medicus, out var medicus) || medicus == null) return;
            if (ludus.Settlement == null) return;

            int medicine = medicus.GetSkillValue(DefaultSkills.Medicine);
            int totalHealCapacity = 1 + (medicine / 50);

            MobileParty garrison = ludus.Settlement.Town?.GarrisonParty ?? ludus.Settlement.Parties.FirstOrDefault(p => p.IsGarrison);

            if (garrison != null)
            {
                var roster = garrison.MemberRoster;
                // Get a snapshot of wounded troops to avoid enumeration issues if modification affects the list structure excessively
                // though AddToCounts usually handles in-place updates.
                var woundedTroops = roster.GetTroopRoster().Where(t => t.WoundedNumber > 0).ToList();

                int healedCount = 0;
                int remainingHeals = totalHealCapacity;

                foreach (var troop in woundedTroops)
                {
                    if (remainingHeals <= 0) break;

                    int healAmount = Math.Min(remainingHeals, troop.WoundedNumber);
                    if (healAmount > 0)
                    {
                        CharacterObject character = troop.Character;
                        // Reduce wounded count by healAmount
                        roster.AddToCounts(character, 0, false, -healAmount, 0, true, -1);
                        remainingHeals -= healAmount;
                        healedCount += healAmount;
                    }
                }

                if (healedCount > 0)
                {
                    LudusSubModule.InstanceLogger?.LogDebug("Medicus {Name} healed {Count} troops in {Garrison} (Capacity: {Total}).", medicus.Name, healedCount, ludus.Settlement?.Name, totalHealCapacity);
                }
            }
        }
    }
}
