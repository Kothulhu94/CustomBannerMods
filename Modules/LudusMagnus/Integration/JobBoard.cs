using System;
using TaleWorlds.CampaignSystem;
using LudusMagnus.Core;

namespace LudusMagnus.Integration
{
    public static class JobBoard
    {
        public static void AssignRole(Hero hero, StaffRole role)
        {
            if (hero == null) return;

            // Find the Ludus owned by this hero's clan leader (or himself)
            var ludus = LudusManager.Instance.GetLudusFor(hero.Clan?.Leader);
            if (ludus == null) return;

            // Remove from existing role if any
            RemoveRole(hero);

            // Assign new role
            if (ludus.Staff.ContainsKey(role))
            {
                // Unassign current holder of this role
                var currentHolder = ludus.Staff[role];
                if (currentHolder != null)
                {
                    // Notification?
                }
                ludus.Staff[role] = hero;
            }
            else
            {
                ludus.Staff.Add(role, hero);
            }
        }

        public static void RemoveRole(Hero hero)
        {
            var ludus = LudusManager.Instance.GetLudusFor(hero.Clan?.Leader);
            if (ludus == null) return;

            StaffRole? keyToRemove = null;
            foreach (var kvp in ludus.Staff)
            {
                if (kvp.Value == hero)
                {
                    keyToRemove = kvp.Key;
                    break;
                }
            }

            if (keyToRemove.HasValue)
            {
                ludus.Staff.Remove(keyToRemove.Value);
            }
        }
    }
}
