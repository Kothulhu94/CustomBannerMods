using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using LudusMagnus.Core;

namespace LudusMagnus.Economy
{
    public class LudusMarketModel
    {
        public int CalculateTicketSales(Clan clan)
        {
            // Placeholder base value
            int baseSales = 100;

            // Apply Lanista Bonus if exists
            var ludus = LudusManager.Instance?.GetLudus(clan.Leader);
            if (ludus != null && ludus.Staff.TryGetValue(StaffRole.Lanista, out var lanista) && lanista != null)
            {
                float bonus = CalculateStaffRevenueBonus(lanista);
                baseSales = (int)(baseSales * bonus);
            }

            return baseSales;
        }

        public float CalculateStaffUpkeepReduction(Hero lanista)
        {
            if (lanista == null) return 1.0f;
            int steward = lanista.GetSkillValue(DefaultSkills.Steward);
            // Max 60% reduction at 300 skill (0.002 * 300 = 0.6)
            float reduction = MathF.Min(0.6f, steward * 0.002f);
            return 1.0f - reduction;
        }

        public float CalculateStaffRevenueBonus(Hero lanista)
        {
            if (lanista == null) return 1.0f;
            int trade = lanista.GetSkillValue(DefaultSkills.Trade);
            // Max +150% income at 300 skill (0.005 * 300 = 1.5)
            float bonus = 1.0f + MathF.Min(1.5f, trade * 0.005f);
            return bonus;
        }
    }
}
