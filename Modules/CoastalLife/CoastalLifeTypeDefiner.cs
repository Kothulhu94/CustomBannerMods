using TaleWorlds.SaveSystem;
using System.Collections.Generic;

namespace CoastalLife
{
    public class CoastalLifeTypeDefiner : SaveableTypeDefiner
    {
        public CoastalLifeTypeDefiner() : base(2_200_000) { }

        protected override void DefineClassTypes()
        {
            AddClassDefinition(typeof(CoastalPatrolComponent), 1);
        }

        protected override void DefineContainerDefinitions()
        {
            ConstructContainerDefinition(typeof(List<CoastalPatrolComponent>));
        }
    }
}
