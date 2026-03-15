using System.Collections.Generic;
using TaleWorlds.SaveSystem;

namespace Landlord
{
    public class LandlordSaveDefiner : SaveableTypeDefiner
    {
        public LandlordSaveDefiner() : base(198_411_001) { }

        protected override void DefineClassTypes()
        {
            AddClassDefinition(typeof(VillagePlot), 1);
            AddClassDefinition(typeof(VillageWealthData), 2);
        }

        protected override void DefineContainerDefinitions()
        {
            ConstructContainerDefinition(typeof(List<VillagePlot>));
            ConstructContainerDefinition(typeof(Dictionary<string, List<VillagePlot>>));
            ConstructContainerDefinition(typeof(Dictionary<string, VillageWealthData>));
        }
    }
}
