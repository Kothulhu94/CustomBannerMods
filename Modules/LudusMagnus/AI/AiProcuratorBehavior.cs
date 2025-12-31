using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.ObjectSystem;
using TaleWorlds.CampaignSystem.Roster; 
using System.Linq; 
using LudusMagnus.Core;
using LudusMagnus.Economy;

namespace LudusMagnus.AI
{
    public class AiProcuratorBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.AiHourlyTickEvent.AddNonSerializedListener(this, OnAiHourlyTick);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnAiHourlyTick(MobileParty mobileParty, PartyThinkParams thinkParams)
        {
            var component = mobileParty.PartyComponent as ProcuratorCaravanComponent;
            if (component == null || component.Ludus == null) return;

            if (mobileParty.CurrentSettlement != null)
            {
                if (mobileParty.CurrentSettlement == component.Ludus.Settlement)
                {
                    DumpFood(mobileParty, component.Ludus);
                    
                    var target = FindNearestFoodSource(mobileParty);
                    if (target != null)
                    {
                        mobileParty.SetMoveGoToSettlement(target, (MobileParty.NavigationType)0, false);
                    }
                }
                else
                {
                    BuyFood(mobileParty);
                    
                    if (component.Ludus.Settlement != null)
                    {
                        mobileParty.SetMoveGoToSettlement(component.Ludus.Settlement, (MobileParty.NavigationType)0, false);
                    }
                }
            }
        }

        private void DumpFood(MobileParty party, LudusLocation ludus)
        {
             if (ludus.Storage == null) ludus.Storage = new ItemRoster();

             for (int i = party.ItemRoster.Count - 1; i >= 0; i--)
            {
                var element = party.ItemRoster[i];
                if (element.EquipmentElement.Item.IsFood)
                {
                    ludus.Storage.AddToCounts(element.EquipmentElement, element.Amount);
                    party.ItemRoster.AddToCounts(element.EquipmentElement, -element.Amount);
                }
            }
        }

        private void BuyFood(MobileParty party)
        {
             if (party.CurrentSettlement != null && (party.CurrentSettlement.IsTown || party.CurrentSettlement.IsVillage))
             {
                 var grain = MBObjectManager.Instance.GetObject<ItemObject>("grain");
                 if (grain != null)
                 {
                     party.ItemRoster.AddToCounts(grain, 20);
                 }
             }
        }

        private Settlement FindNearestFoodSource(MobileParty party)
        {
             return Settlement.All.FirstOrDefault(s => (s.IsTown || s.IsVillage) && s != party.CurrentSettlement) ?? Settlement.All.GetRandomElement();
        }
    }
}
