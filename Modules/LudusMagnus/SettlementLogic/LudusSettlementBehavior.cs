using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Party;

namespace LudusMagnus.SettlementLogic
{
    public class LudusSettlementBehavior : CampaignBehaviorBase
    {
        private Settlement _ludusSettlement;

        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.SettlementEntered.AddNonSerializedListener(this, OnSettlementEntered);
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("_ludusSettlement", ref _ludusSettlement);
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            // Register Menu (User Step 8)
            starter.AddGameMenu("ludus_main_menu", "{=ludus_welcome}Welcome to Ludus Magnus.", OnInitLudusMenu, GameMenu.MenuOverlayType.SettlementWithBoth, GameMenu.MenuFlags.None, null);
            starter.AddGameMenuOption("ludus_main_menu", "ludus_leave", "{=ludus_leave}Leave", (MenuCallbackArgs args) => { return true; }, (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("town"); }, false, -1, false);
        }

        private void OnSettlementEntered(MobileParty party, Settlement settlement, Hero hero)
        {
            if (party == MobileParty.MainParty && settlement.StringId == "my_custom_ludus")
            {
                GameMenu.SwitchToMenu("ludus_main_menu");
            }
        }

        private void OnInitLudusMenu(MenuCallbackArgs args)
        {
             // Verify this is our Ludus
             if (Settlement.CurrentSettlement == null || Settlement.CurrentSettlement.StringId != "my_custom_ludus") return;
             
             args.MenuContext.SetBackgroundMeshName("empire_castle_hall"); // Placeholder
        }
    }
}
