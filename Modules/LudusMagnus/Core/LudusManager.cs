using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.SaveSystem;

namespace LudusMagnus.Core
{
    [SaveableRootClass(20080)]
    public class LudusManager
    {
        public static LudusManager Instance { get; private set; }

        [SaveableProperty(1)]
        public Dictionary<Hero, LudusLocation> LudusRegistry { get; set; }

        public LudusManager()
        {
            LudusRegistry = new Dictionary<Hero, LudusLocation>();
        }

        public static void Initialize(LudusManager savedInstance = null)
        {
            Instance = savedInstance ?? new LudusManager();
        }

        public LudusLocation GetLudusFor(Hero hero)
        {
            if (LudusRegistry.TryGetValue(hero, out var ludus))
            {
                return ludus;
            }
            return null;
        }

        public void RegisterLudus(Hero hero, LudusLocation ludus)
        {
            if (!LudusRegistry.ContainsKey(hero))
            {
                LudusRegistry.Add(hero, ludus);
            }
        }
        public Dictionary<Hero, LudusLocation> GetAllLudusLocations()
        {
            return LudusRegistry;
        }

        public LudusLocation GetLudus(Hero hero)
        {
            return GetLudusFor(hero);
        }
    }
}
