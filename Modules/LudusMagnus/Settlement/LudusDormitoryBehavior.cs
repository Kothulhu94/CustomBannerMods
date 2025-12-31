using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using LudusMagnus.Core;

namespace LudusMagnus.Settlements
{
    public class LudusDormitoryBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            // Data is stored in LudusLocation (Residents list), managed by LudusManager.
            // No local state to sync here.
        }

        private void OnDailyTick()
        {
            if (LudusManager.Instance == null) return;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                var ludus = kvp.Value;
                if (ludus == null || ludus.Residents == null) continue;

                if (ludus.Facilities.ContainsKey(FacilityType.Dormitory))
                {
                    ProcessDormitory(ludus);
                    EquipResidentsFromStash(ludus);
                }
            }
        }

        private void EquipResidentsFromStash(LudusLocation ludus)
        {
            if (ludus.Storage == null || ludus.Residents == null) return;

            foreach (var hero in ludus.Residents)
            {
                if (hero.IsDead) continue;
                
                // Very simple check: Does stash have a Tier 4+ weapon?
                // Real logic would compare stats. Simplification: Just grab highest tier unused weapon.
                
                ItemRosterElement bestWeapon = default;
                int bestTier = 0;

                for (int i = 0; i < ludus.Storage.Count; i++)
                {
                    var item = ludus.Storage[i];
                    if (item.EquipmentElement.Item.Type == ItemObject.ItemTypeEnum.OneHandedWeapon)
                    {
                        int tier = (int)item.EquipmentElement.Item.Tier;
                        if (tier > bestTier)
                        {
                            bestTier = tier;
                            bestWeapon = item;
                        }
                    }
                }

                if (bestTier >= 4 && bestWeapon.EquipmentElement.Item != null)
                {
                    // Check if better than current
                    var current = hero.BattleEquipment.GetEquipmentFromSlot(EquipmentIndex.Weapon0);
                    if (current.Item == null || (int)current.Item.Tier < bestTier)
                    {
                        hero.BattleEquipment.AddEquipmentToSlotWithoutAgent(EquipmentIndex.Weapon0, bestWeapon.EquipmentElement);
                        ludus.Storage.AddToCounts(bestWeapon.EquipmentElement, -1);
                        // InformationManager.DisplayMessage(new InformationMessage($"{hero.Name} equipped {bestWeapon.EquipmentElement.Item.Name}", Colors.White));
                    }
                }
            }
        }

        private float GetLibraryBonus(LudusLocation ludus)
        {
            if (ludus.Storage == null) return 0f;
            
            int bookCount = 0;
            for (int i = 0; i < ludus.Storage.Count; i++)
            {
                var item = ludus.Storage[i];
                if (item.EquipmentElement.Item != null && item.EquipmentElement.Item.StringId.ToLower().Contains("book"))
                {
                    bookCount += item.Amount;
                }
            }
            
            return bookCount * 0.01f; // 1% per book
        }

        private void ProcessDormitory(LudusLocation ludus)
        {
            int ludusLevel = 1; // Default
             // In a real implementation, we'd fetch the level from facilities dict if it stores level, or just presence.
             // implementation_plan says Facilities is Dict<Type, int>, implying level.
            if (ludus.Facilities.TryGetValue(FacilityType.Dormitory, out int level))
            {
                ludusLevel = level;
            }

            // Library Bonus
            float libraryMult = 1.0f + GetLibraryBonus(ludus);

            int dailyXp = (int)((100 * ludusLevel) * libraryMult);

            // Iterate backwards if we were removing, but we are just modifying.
            foreach (var hero in ludus.Residents)
            {
                if (hero.IsDead || hero.IsDisabled) continue;

                // Grant XP
                hero.AddSkillXp(DefaultSkills.Athletics, dailyXp); 
                hero.AddSkillXp(DefaultSkills.OneHanded, dailyXp);
                
                // Increase "Value" - We can't easily change the hiring cost directly as it's calculated dynamically.
                // But we can perhaps track a "Debt" or "TrainingCost" in a separate dictionary if we wanted strict enforcement.
                // For now, the "Hiring Cost increases" feature might be implicit: Higher skills = Higher hiring cost naturally.
            }
            
            if (libraryMult > 1.0f && ludus.Owner == Hero.MainHero)
            {
                 // Optional flavor text occasionally
                 if (TaleWorlds.Core.MBRandom.RandomFloat < 0.05f)
                    InformationManager.DisplayMessage(new InformationMessage($"The Library aids your students. XP Multiplier: x{libraryMult:0.00}", Colors.White));
            }
        }
    }
}
