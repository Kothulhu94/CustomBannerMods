using System.Collections.Generic;
using TaleWorlds.SaveSystem;
using TaleWorlds.CampaignSystem;

namespace LudusMagnus.Core
{
    public class LudusSaveDefiner : SaveableTypeDefiner
    {
        public LudusSaveDefiner() : base(20090) { }

        protected override void DefineClassTypes()
        {
            AddEnumDefinition(typeof(LudusState), 10);
            AddEnumDefinition(typeof(FacilityType), 20);
            AddEnumDefinition(typeof(StaffRole), 30);
            AddClassDefinition(typeof(LudusLocation), 40);
        }

        protected override void DefineContainerDefinitions()
        {
            ConstructContainerDefinition(typeof(Dictionary<Hero, LudusLocation>));
            ConstructContainerDefinition(typeof(Dictionary<FacilityType, int>));
            ConstructContainerDefinition(typeof(Dictionary<StaffRole, Hero>));
        }
    }
}
