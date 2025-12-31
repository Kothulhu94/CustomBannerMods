using TaleWorlds.SaveSystem;
using System.Collections.Generic;
using LudusMagnus.AI;

namespace LudusMagnus.Core
{
    public class LudusTypeDefiner : SaveableTypeDefiner
    {
        public LudusTypeDefiner() : base(980_000) { }

        protected override void DefineClassTypes()
        {
            AddClassDefinition(typeof(LudusSentinelComponent), 1);
        }

        protected override void DefineContainerDefinitions()
        {
            ConstructContainerDefinition(typeof(List<LudusSentinelComponent>));
        }
    }
}
