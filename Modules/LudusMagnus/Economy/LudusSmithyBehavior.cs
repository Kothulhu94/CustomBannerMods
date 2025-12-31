using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using LudusMagnus.Core;
using LudusMagnus.Settlements;
using Serilog;
using Microsoft.Extensions.Logging;

namespace LudusMagnus.Economy
{
    public class LudusSmithyBehavior : CampaignBehaviorBase
    {
        private LudusSmithyModel _model;

        public LudusSmithyBehavior()
        {
            _model = new LudusSmithyModel();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
        }

        public override void SyncData(IDataStore dataStore)
        {
            // Model implies no state.
        }

        private void OnDailyTick()
        {
            if (LudusManager.Instance == null) return;

            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                var ludus = kvp.Value;
                if (ludus == null) continue;

                // Use Upgrade Manager to get level (safety check included)
                int level = LudusUpgradeManager.Instance.GetUpgradeLevel(ludus, FacilityType.MasterSmithy);
                
                // Only produce if built (Level > 0)
                if (level > 0)
                {
                    var item = _model.ProcessDailyProduction(level);
                    if (item != null)
                    {
                        ludus.Storage.AddToCounts(item, 1);
                        LudusSubModule.InstanceLogger?.LogDebug("Smithy (Lvl {Level}) produced {Item} at {Settlement}.", level, item.Name, ludus.Settlement?.Name);
                    }
                    
                    // Chance to produce a Book (Treatise) - 10% daily if max level
                    if (level >= 3 && TaleWorlds.Core.MBRandom.RandomFloat < 0.1f)
                    {
                         // Add book
                         var bookId = TaleWorlds.Core.MBRandom.RandomFloat < 0.5f ? "ludus_book_a" : "ludus_book_b";
                         var book = TaleWorlds.Core.Game.Current.ObjectManager.GetObject<ItemObject>(bookId);
                         if (book != null)
                         {
                             ludus.Storage.AddToCounts(book, 1);
                             LudusSubModule.InstanceLogger?.LogInformation("Smithy discovered Ancient Treatise {BookId} at {Settlement}.", bookId, ludus.Settlement?.Name);
                             // Optional: Notify player
                             if (ludus.Owner == Hero.MainHero)
                                InformationManager.DisplayMessage(new InformationMessage("Assessment: Your Smithy has preserved an Ancient Treatise.", Colors.White));
                         }
                    }
                }
            }
        }
    }
}
