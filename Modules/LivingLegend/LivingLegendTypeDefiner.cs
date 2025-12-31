using TaleWorlds.SaveSystem;
using System.Collections.Generic;

namespace LivingLegend
{
    public class LivingLegendTypeDefiner : SaveableTypeDefiner
    {
        public LivingLegendTypeDefiner() : base(990_000) { }

        protected override void DefineClassTypes()
        {
            AddClassDefinition(typeof(MilitiaPatrolComponent), 1);
        }

        protected override void DefineContainerDefinitions()
        {
            ConstructContainerDefinition(typeof(List<MilitiaPatrolComponent>));
        }
    }
}
