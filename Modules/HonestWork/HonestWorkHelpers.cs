using System;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace HonestWork
{
    public static class HonestWorkHelpers
    {
        public static void GiveRandomPartyXp(MobileParty party, int chancePercent, int minXp, int maxXp)
        {
            if (party == null || party.MemberRoster == null) return;

            // Iterate through a copy or by index to satisfy modification rules (though AddXpToTroop handles internal logic)
            // GetTroopRoster returns a copy list usually, but let's be safe.
            var roster = party.MemberRoster;
            
            for (int i = 0; i < roster.Count; i++)
            {
                var element = roster.GetElementCopyAtIndex(i);
                if (element.Character.IsHero) continue; // Skip Heroes

                if (MBRandom.RandomInt(100) < chancePercent)
                {
                    int xp = MBRandom.RandomInt(minXp, maxXp);
                    roster.AddXpToTroop(element.Character, xp);
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
    }
}
