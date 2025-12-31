using System.Linq;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;
using TaleWorlds.ObjectSystem;

namespace LudusMagnus.Economy
{
    public class LudusSmithyModel
    {
        public ItemObject ProcessDailyProduction(int level)
        {
            // Level 1: Tier 1 & 2
            // Level 2: Tier 3 & 4
            // Level 3: Tier 5 & 6
            
            // Default to Tier 1
            int minTier = 0; 
            int maxTier = 1;

            if (level >= 3) 
            {
                minTier = 4; // Tier 5 (Index 4)
                maxTier = 5; // Tier 6 (Index 5)
            }
            else if (level == 2)
            {
                minTier = 2; // Tier 3
                maxTier = 3; // Tier 4
            }
            // else Level 1 (0-1)

            var items = MBObjectManager.Instance.GetObjectTypeList<ItemObject>()
                .Where(i => (int)i.Tier >= minTier && (int)i.Tier <= maxTier && i.Culture != null)
                .ToList();

            if (items.Count == 0) return null;

            return items.GetRandomElement();
        }
    }
}
