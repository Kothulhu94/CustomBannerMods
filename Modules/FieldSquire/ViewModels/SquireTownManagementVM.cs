using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Engine.GauntletUI;
using TaleWorlds.ScreenSystem;


namespace FieldSquire.ViewModels
{
    public class SquireTownManagementVM : TownManagementVM
    {
        private GauntletLayer _layer;

        public SquireTownManagementVM(Settlement settlement, GauntletLayer layer) : base()
        {
            _layer = layer;

            // 1. REFLECTION CONFIGURATION
            // Inject the settlement into the private _settlement field so the VM operates on the correct target.
            // This is "Safe" reflection as it only affects this transient UI object, not global game state.
            var field = typeof(TownManagementVM).GetField("_settlement", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (field != null)
            {
                field.SetValue(this, settlement);
            }
            else
            {
                TaleWorlds.Library.InformationManager.DisplayMessage(new TaleWorlds.Library.InformationMessage("Warning: Ledger fallback mode actived."));
            }

            // 3. REFRESH
            // Load necessary Sprite Categories that might not be loaded since we are not in the settlement context
            try
            {
                var spriteData = UIResourceManager.SpriteData;
                var resourceContext = UIResourceManager.ResourceContext;
                var resourceDepot = UIResourceManager.ResourceDepot;

                if (spriteData != null)
                {
                    // Force load common categories for town management
                    if (spriteData.SpriteCategories.ContainsKey("ui_townmanagement"))
                        spriteData.SpriteCategories["ui_townmanagement"].Load(resourceContext, resourceDepot);
                    
                    if (spriteData.SpriteCategories.ContainsKey("ui_settlement"))
                        spriteData.SpriteCategories["ui_settlement"].Load(resourceContext, resourceDepot);
                }
            }
            catch (System.Exception ex)
            {
               // Log but don't crash
               TaleWorlds.Library.InformationManager.DisplayMessage(new TaleWorlds.Library.InformationMessage("Warning: Failed to load UI sprites."));
            }

            // Manually re-trigger the refresh since the constructor ran with (likely) null data initially.
            this.RefreshValues();
        }

        public new void ExecuteDone()
        {
            if (_layer != null)
            {
                TaleWorlds.ScreenSystem.ScreenManager.TopScreen.RemoveLayer(_layer);
                _layer = null;
            }
        }
    }
}
