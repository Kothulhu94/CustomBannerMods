using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.MapEvents;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using LudusMagnus.Core;

namespace LudusMagnus.SettlementLogic
{
    public class LudusStateBehavior : CampaignBehaviorBase
    {
        private const int RepairCost = 250000;

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.MapEventEnded.AddNonSerializedListener(this, OnMapEventEnded);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSessionLaunched(CampaignGameStarter starter)
        {
            starter.AddGameMenuOption("ludus_menu", "repair_ludus", "{=ludus_repair}Repair Ludus ({REPAIR_COST} Gold)",
                (MenuCallbackArgs args) =>
                {
                    Hero owner = Hero.MainHero;
                    LudusLocation ludus = LudusManager.Instance.GetLudusFor(owner);
                    if (ludus == null || ludus.State != LudusState.Ruined) return false;

                    args.optionLeaveType = GameMenuOption.LeaveType.Manage;
                    MBTextManager.SetTextVariable("REPAIR_COST", RepairCost);

                    bool canAfford = owner.Gold >= RepairCost;
                    if (!canAfford)
                    {
                        args.IsEnabled = false;
                        args.Tooltip = new TextObject("{=ludus_repair_poor}You need {REPAIR_COST} gold to repair the Ludus.");
                    }
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    RepairLudus(Hero.MainHero);
                }, false, 2);
        }

        private void OnDailyTick()
        {
            foreach (var kvp in LudusManager.Instance.LudusRegistry)
            {
                LudusLocation ludus = kvp.Value;
                if (ludus.Settlement == null) continue;

                // Auto-repair for AI if rich enough
                if (ludus.State == LudusState.Ruined && ludus.Owner != Hero.MainHero)
                {
                    if (ludus.Owner.Gold >= RepairCost * 1.5f) // AI needs more buffer
                    {
                         RepairLudus(ludus.Owner);
                    }
                }
            }
        }

        private void OnMapEventEnded(MapEvent mapEvent)
        {
            if (mapEvent.IsRaid || mapEvent.IsSiegeAssault)
            {
                // Check if a Ludus settlement was raided or sacked
                LudusLocation raidedLudus = LudusManager.Instance.LudusRegistry.Values.FirstOrDefault(l => l.Settlement == mapEvent.MapEventSettlement);
                if (raidedLudus != null && raidedLudus.State == LudusState.Active)
                {
                    if (mapEvent.WinningSide == mapEvent.AttackerSide.MissionSide)
                    {
                        raidedLudus.State = LudusState.Ruined;
                        InformationManager.DisplayMessage(new InformationMessage($"{raidedLudus.Settlement.Name} has been SACKED and RUINED!", Colors.Red));
                        
                        // Flavor: Downgrade a facility
                        if (raidedLudus.Facilities != null && raidedLudus.Facilities.Count > 0)
                        {
                            var key = raidedLudus.Facilities.Keys.ToList().GetRandomElement();
                            if (raidedLudus.Facilities[key] > 0)
                            {
                                raidedLudus.Facilities[key]--;
                                InformationManager.DisplayMessage(new InformationMessage($"{key} was damaged in the assault!", Colors.Red));
                            }
                        }
                    }
                }
            }
        }

        private void RepairLudus(Hero owner)
        {
            LudusLocation ludus = LudusManager.Instance.GetLudusFor(owner);
            if (ludus == null) return;

            GiveGoldAction.ApplyBetweenCharacters(owner, null, RepairCost);
            ludus.State = LudusState.Active;
            InformationManager.DisplayMessage(new InformationMessage($"{ludus.Settlement.Name} has been repaired and is now Active.", Colors.Green));
        }
    }
}
