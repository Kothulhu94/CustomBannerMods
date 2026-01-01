using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.SaveSystem;
using TaleWorlds.Core;

namespace LudusMagnus.SettlementLogic
{
    [SaveableRootClass(20085)] 
    public class LudusSettlementComponent : SettlementComponent
    {
        [SaveableProperty(1)]
        public int ConstructionTier { get; set; }

        public override IFaction MapFaction => this.Settlement?.Party?.MapFaction ?? this.Settlement?.OwnerClan?.MapFaction;

        public LudusSettlementComponent() 
        {
            ConstructionTier = 1;
        }

        protected override void OnInventoryUpdated(ItemRosterElement item, int count)
        {
            // Required implementation
        }
    }
}
