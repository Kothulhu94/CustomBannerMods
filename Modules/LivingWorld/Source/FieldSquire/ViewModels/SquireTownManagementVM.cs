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

        private System.Action _onClose;

        public SquireTownManagementVM(Settlement settlement, GauntletLayer layer, System.Action onClose) : base()
        {
            _layer = layer;
            _onClose = onClose;
            CurrentManagedSettlement = settlement;

            var field = typeof(TownManagementVM).GetField("_settlement", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (field != null)
            {
                field.SetValue(this, settlement);
            }
            else
            {
                TaleWorlds.Library.InformationManager.DisplayMessage(new TaleWorlds.Library.InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_warningledgerfa}Warning: Ledger fallback mode actived.").ToString()));
            }

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
            catch (System.Exception)
            {
               // Log but don't crash
               TaleWorlds.Library.InformationManager.DisplayMessage(new TaleWorlds.Library.InformationMessage(new TaleWorlds.Localization.TextObject("{=lw_warningfailedto}Warning: Failed to load UI sprites.").ToString()));
            }

            // Manually re-trigger the refresh since the constructor ran with (likely) null data initially.
            this.RefreshValues();
            IsActive = true;
        }

        public static bool IsActive { get; private set; }

        public static Settlement CurrentManagedSettlement { get; private set; }

        public override void OnFinalize()
        {
            IsActive = false;
            CurrentManagedSettlement = null;
            base.OnFinalize();
        }

        public new void ExecuteDone()
        {
            SafeExit();
        }

        public void ExecuteCancel()
        {
            SafeExit();
        }

        private void SafeExit()
        {
            if (_layer != null)
            {
                TaleWorlds.ScreenSystem.ScreenManager.TopScreen.RemoveLayer(_layer);
                _layer = null;
                _onClose?.Invoke();
            }
        }
    }
}
