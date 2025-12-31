using System.Collections.Generic;
using TaleWorlds.SaveSystem;
using TaleWorlds.CampaignSystem;

namespace LudusMagnus.Core
{
    [SaveableRootClass(20090)]
    public class LudusSaveData
    {
        [SaveableField(1)]
        public List<string> BuiltStructures = new List<string>();

        [SaveableField(2)]
        public int Renown = 0;
        
        [SaveableField(3)]
        public Dictionary<Hero, LudusLocation> LudusRegistry = new Dictionary<Hero, LudusLocation>();

        // Default constructor for SaveSystem
        public LudusSaveData()
        {
        }

        public LudusSaveData(Dictionary<Hero, LudusLocation> registry)
        {
            LudusRegistry = registry;
        }
    }
}
