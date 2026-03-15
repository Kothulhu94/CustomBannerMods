using System;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace HonestWork
{
    public static class HonestWorkHelpers
    {
        public static void GiveRandomPartyXp(MobileParty party, int chancePercent, int minXp, int maxXp)
        {
            if (party == null || party.MemberRoster == null) return;

            var roster = party.MemberRoster;
            float xpMult = GlobalSettings.Instance.TroopXpMultiplier;
            if (xpMult <= 0) return;
            
            for (int i = 0; i < roster.Count; i++)
            {
                var element = roster.GetElementCopyAtIndex(i);
                if (element.Character.IsHero) continue; // Skip Heroes

                if (MBRandom.RandomInt(100) < chancePercent)
                {
                    int xp = (int)(MBRandom.RandomInt(minXp, maxXp) * xpMult);
                    if (xp > 0)
                    {
                        roster.AddXpToTroop(element.Character, xp);
                    }
                }
            }
        }

        public static int GetPartyTotalTier(MobileParty party)
        {
            if (party == null || party.MemberRoster == null) return 0;
            
            int totalTier = 0;
            var roster = party.MemberRoster;
            for (int i = 0; i < roster.Count; i++)
            {
                var element = roster.GetElementCopyAtIndex(i);
                if (!element.Character.IsHero)
                {
                    totalTier += element.Character.Tier * element.Number;
                }
            }
            return totalTier;
        }
        public static int CalculateNativeGarrisonChange(Town town)
        {
            if (town == null || town.GarrisonParty == null || town.Settlement == null) return 0;
            
            int change = 0;
            var garrison = town.GarrisonParty;
            
            // 1. Food Shortage
            if (town.FoodStocks <= 0 && town.FoodChange < 0)
            {
                change -= 5; 
            }
            else if (town.Settlement.IsStarving) 
            {
                change -= 2;
            }

            if (garrison.HasLimitedWage() && garrison.TotalWage > garrison.PaymentLimit)
            {
                change -= 5;
            }

            // 3. Party Size Limit
            int excess = garrison.MemberRoster.TotalManCount - garrison.Party.PartySizeLimit;
            if (excess > 0)
            {
                change -= excess;
            }
            
            return change;
        }

        public static int GetGarrisonOvercrowding(Town town)
        {
            if (town == null || town.GarrisonParty == null) return 0;
            int limit = town.GarrisonParty.Party.PartySizeLimit;
            int count = town.GarrisonParty.MemberRoster.TotalManCount;
            return Math.Max(0, count - limit);
        }
    }
}
