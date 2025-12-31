using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Party.PartyComponents;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;
using System.Collections.Generic;
using TaleWorlds.SaveSystem;

namespace LivingLegend
{
    public class MilitiaPatrolComponent : PartyComponent
    {
        [SaveableField(1)]
        private readonly Settlement _homeSettlement;

        public MilitiaPatrolComponent(Settlement homeSettlement)
        {
            _homeSettlement = homeSettlement;
        }

        public MilitiaPatrolComponent() { }

        public override Settlement HomeSettlement => _homeSettlement;

        public override Hero PartyOwner => _homeSettlement?.OwnerClan?.Leader;

        public override TextObject Name
        {
            get
            {
                if (_homeSettlement != null)
                {
                    var text = new TextObject("{=MilitiaPatrol}Militia Patrol of {SETTLEMENT}");
                    text.SetTextVariable("SETTLEMENT", _homeSettlement.Name);
                    return text;
                }
                return new TextObject("Militia Patrol");
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
