using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Party.PartyComponents;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using LudusMagnus.Core;
using TaleWorlds.SaveSystem;
using System.Linq;

namespace LudusMagnus.Economy
{
    [SaveableRootClass(20060)]
    public class ProcuratorCaravanComponent : PartyComponent
    {
        [SaveableField(1)]
        private Settlement _settlement;

        public LudusLocation Ludus => LudusManager.Instance?.GetAllLudusLocations().Values.FirstOrDefault(l => l.Settlement == _settlement);

        public ProcuratorCaravanComponent(LudusLocation ludus)
        {
            _settlement = ludus?.Settlement;
        }

        public ProcuratorCaravanComponent() { }

        public override Hero PartyOwner => Ludus?.Owner;

        public override TextObject Name
        {
            get
            {
                var textObject = new TextObject("{=LudusCaravan}Procurator Caravan of {OWNER}");
                if (PartyOwner != null)
                {
                    textObject.SetTextVariable("OWNER", PartyOwner.Name);
                }
                else
                {
                    textObject.SetTextVariable("OWNER", new TextObject("Unknown"));
                }
                return textObject;
            }
        }

        public override Settlement HomeSettlement => _settlement;

        public override Banner GetDefaultComponentBanner()
        {
             return PartyOwner?.Clan?.Banner ?? Banner.CreateRandomBanner();
        }

        protected override void OnInitialize() { }
    }
}
