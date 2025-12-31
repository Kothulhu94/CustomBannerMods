using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Party.PartyComponents;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;
using TaleWorlds.SaveSystem;
using TaleWorlds.Core;

namespace CoastalLife
{
    public class CoastalPatrolComponent : PartyComponent
    {
        [SaveableField(1)]
        private readonly Settlement _homeSettlement;

        public CoastalPatrolComponent(Settlement homeSettlement)
        {
            _homeSettlement = homeSettlement;
        }

        public CoastalPatrolComponent() { }

        public override Settlement HomeSettlement => _homeSettlement;

        public override Hero PartyOwner => _homeSettlement?.OwnerClan?.Leader;

        public override TextObject Name
        {
            get
            {
                if (_homeSettlement != null)
                {
                    var text = new TextObject("{=CoastGuard}Coast Guard of {SETTLEMENT}");
                    text.SetTextVariable("SETTLEMENT", _homeSettlement.Name);
                    return text;
                }
                return new TextObject("Coast Guard");
            }
        }
        
        protected override void OnInitialize() 
        {
        }

        public override TaleWorlds.Core.Banner GetDefaultComponentBanner()
        {
            return _homeSettlement?.OwnerClan?.Banner ?? _homeSettlement?.Banner;
        }
    }
}
