using System.Collections.Generic;
using TaleWorlds.SaveSystem;
using TaleWorlds.CampaignSystem;

namespace CoastalLife
{
    public class CoastalLifeSaveDefiner : SaveableTypeDefiner
    {
        public CoastalLifeSaveDefiner() : base(21010) { }

        protected override void DefineClassTypes()
        {
            AddClassDefinition(typeof(CoastalPatrolComponent), 10);
        }

        protected override void DefineContainerDefinitions()
        {

            ConstructContainerDefinition(typeof(Dictionary<string, Hero>));
        }
    }
}
