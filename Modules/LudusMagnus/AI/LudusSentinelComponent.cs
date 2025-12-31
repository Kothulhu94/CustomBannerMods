using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Party.PartyComponents;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;
using TaleWorlds.Core;

using TaleWorlds.SaveSystem;

namespace LudusMagnus.AI
{
    public class LudusSentinelComponent : PartyComponent
    {
        [SaveableField(1)]
        private Settlement _homeSettlement;

        public LudusSentinelComponent(Settlement homeSettlement)
        {
            _homeSettlement = homeSettlement;
        }

        // Default constructor for serialization if needed (though usually custom components require specific handling)
        public LudusSentinelComponent() { }

        public override Hero PartyOwner => null;
        
        public override TextObject Name => new TextObject("{=ludus_snt_comp}Sentinel Party");
        
        public override Settlement HomeSettlement => _homeSettlement;

        public override Banner GetDefaultComponentBanner()
        {
             return MobileParty?.ActualClan?.Banner ?? MobileParty?.Banner;
        }

        protected override void OnInitialize() 
        {
        }
    }
}
