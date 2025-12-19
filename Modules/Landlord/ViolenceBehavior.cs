using System;
using System.Linq;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.MapEvents;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

using Microsoft.Extensions.Logging;

namespace Landlord
{
    public class ViolenceBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<ViolenceBehavior> _logger;

        public ViolenceBehavior(ILogger<ViolenceBehavior> logger)
        {
            _logger = logger;
        }
        public override void RegisterEvents()
        {
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.MapEventEnded.AddNonSerializedListener(this, OnMapEventEnded);
            CampaignEvents.MapEventStarted.AddNonSerializedListener(this, OnMapEventStarted);
        }

        public override void SyncData(IDataStore dataStore) { }

        private void OnSessionLaunched(CampaignGameStarter campaignStarter)
        {
            campaignStarter.AddGameMenuOption("village", "village_landlord_raze", "Burn Hostile Plot",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Raid;
                    var settlement = Settlement.CurrentSettlement;
                    if (!LandlordManager.Instance.GlobalPlots.ContainsKey(settlement.StringId)) return false;
                    
                    foreach (var plot in LandlordManager.Instance.GlobalPlots[settlement.StringId])
                    {
                        if (plot.Owner != null && plot.Owner.MapFaction != null && Hero.MainHero.MapFaction != null && plot.Owner.MapFaction.IsAtWarWith(Hero.MainHero.MapFaction))
                        {
                            args.Text = new TextObject($"Burn {plot.Owner.Name}'s Plot");
                            return true;
                        }
                    }
                    return false;
                },
                (MenuCallbackArgs args) =>
                {
                    var settlement = Settlement.CurrentSettlement;
                    var plots = LandlordManager.Instance.GlobalPlots[settlement.StringId];
                    var hostilePlot = plots.FirstOrDefault(p => p.Owner.MapFaction.IsAtWarWith(Hero.MainHero.MapFaction));
                    
                    if (hostilePlot != null)
                    {
                        plots.Remove(hostilePlot);

                        ChangeRelationAction.ApplyRelationChangeBetweenHeroes(Hero.MainHero, hostilePlot.Owner, -GlobalSettings.Instance.RelationPenaltyOnRaze, true);
                        ModifyHearths(settlement.Village, -GlobalSettings.Instance.HearthDamageOnRaze);
                        InformationManager.DisplayMessage(new InformationMessage($"You burned {hostilePlot.Owner.Name}'s plot!"));
                    }
                    GameMenu.SwitchToMenu("village");
                }, false, 2, false);


            campaignStarter.AddGameMenu("village_landlord_raze_menu", "You approach the estate. It is currently owned by {OWNER_NAME}.",
                (MenuCallbackArgs args) => 
                {
                    var plot = LandlordManager.Instance.SelectedPlot;
                    if (plot != null && plot.Owner != null)
                        GameTexts.SetVariable("OWNER_NAME", plot.Owner.Name);
                    else
                        GameTexts.SetVariable("OWNER_NAME", "Unknown");
                },
                GameMenu.MenuOverlayType.SettlementWithBoth,
                GameMenu.MenuFlags.None,
                null);

            campaignStarter.AddGameMenuOption("village_landlord_raze_menu", "raze_plot", "Raze Plot",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Raid;
                    var plot = LandlordManager.Instance.SelectedPlot;
                    if (plot == null || plot.Owner == null) return false;

                    var playerFaction = Hero.MainHero.MapFaction;
                    var ownerFaction = plot.Owner.MapFaction;
                    
                    if (playerFaction == null || ownerFaction == null) return false;

                    bool isAlly = (playerFaction == ownerFaction) || (plot.Owner.Clan == Clan.PlayerClan);
                    if (isAlly)
                    {
                        args.IsEnabled = false;
                        args.Tooltip = new TextObject("You cannot raid your allies.");
                    }
                    else if (playerFaction.IsAtWarWith(ownerFaction))
                    {
                        args.Tooltip = new TextObject("This will negatively impact relations with the owner.");
                    }
                    else
                    {
                        args.Tooltip = new TextObject("This will declare war on the faction!");
                    }

                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    var plot = LandlordManager.Instance.SelectedPlot;
                    if (plot != null)
                    {
                         var settlement = Settlement.CurrentSettlement;
                         var plots = LandlordManager.Instance.GlobalPlots[settlement.StringId];
                         

                         int lootGold = 0;
                         if (plot.SlotIndex == 0) lootGold = GlobalSettings.Instance.NormalPlotCost / 2;
                         else if (plot.SlotIndex == 1) lootGold = GlobalSettings.Instance.GoodPlotCost / 2;
                         else lootGold = GlobalSettings.Instance.GreatPlotCost / 2;

                         GiveGoldAction.ApplyForSettlementToCharacter(settlement, Hero.MainHero, lootGold, false);
                         
                         var productionItem = Game.Current.ObjectManager.GetObject<ItemObject>(plot.ProductionId);
                         if (productionItem != null)
                         {
                             Hero.MainHero.PartyBelongedTo.ItemRoster.AddToCounts(productionItem, 5);
                             InformationManager.DisplayMessage(new InformationMessage($"Pillaged: {lootGold} gold and 5 {productionItem.Name}"));
                         }
                         else
                         {
                             InformationManager.DisplayMessage(new InformationMessage($"Pillaged: {lootGold} gold"));
                         }

                         if (!Hero.MainHero.MapFaction.IsAtWarWith(plot.Owner.MapFaction))
                         {
                             DeclareWarAction.ApplyByPlayerHostility(Hero.MainHero.MapFaction, plot.Owner.MapFaction);
                             InformationManager.DisplayMessage(new InformationMessage("You have committed an act of war!"));
                         }
                         else
                         {
                             ChangeRelationAction.ApplyRelationChangeBetweenHeroes(Hero.MainHero, plot.Owner, -GlobalSettings.Instance.RelationPenaltyOnRaze, true);
                         }
                         
                         plots.Remove(plot);
                         ModifyHearths(settlement.Village, -GlobalSettings.Instance.HearthDamageOnRaze);
                         InformationManager.DisplayMessage(new InformationMessage($"You burned {plot.Owner.Name}'s plot!"));
                    }
                    GameMenu.SwitchToMenu("village");
                }, false, -1, false);

            campaignStarter.AddGameMenuOption("village_landlord_raze_menu", "leave_raze", "Leave",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village_landlord_slot_selection"); }, 
                true, -1, false);
        }

        private void OnMapEventStarted(MapEvent mapEvent, PartyBase attackerParty, PartyBase defenderParty)
        {
            var settlement = mapEvent.MapEventSettlement;
            if (settlement != null && settlement.IsVillage && LandlordManager.Instance.GlobalPlots.ContainsKey(settlement.StringId))
            {
                foreach (var plot in LandlordManager.Instance.GlobalPlots[settlement.StringId])
                {
                    if (plot.Owner != null && plot.Owner.MapFaction == settlement.MapFaction)
                    {
                        if (settlement.MilitiaPartyComponent != null && settlement.MilitiaPartyComponent.MobileParty != null)
                        {
                            settlement.MilitiaPartyComponent.MobileParty.MemberRoster.Add(plot.Garrison);
                            plot.Garrison.Clear(); 
                        }
                    }
                }
            }
        }

        private void OnMapEventEnded(MapEvent mapEvent)
        {
            var settlement = mapEvent.MapEventSettlement;
            if (settlement != null && settlement.IsVillage && LandlordManager.Instance.GlobalPlots.ContainsKey(settlement.StringId))
            {
                if (mapEvent.IsRaid && mapEvent.WinningSide == BattleSideEnum.Attacker)
                {
                    var attackerLeader = mapEvent.AttackerSide.LeaderParty?.LeaderHero;
                    if (attackerLeader != null)
                    {
                        var plots = LandlordManager.Instance.GlobalPlots[settlement.StringId];
                        var targetPlot = plots.FirstOrDefault(p => p.Owner != null && p.Owner.MapFaction != null && p.Owner.MapFaction.IsAtWarWith(attackerLeader.MapFaction));

                        if (targetPlot != null)
                        {
                            plots.Remove(targetPlot);
                            ModifyHearths(settlement.Village, -GlobalSettings.Instance.HearthDamageOnRaze);
                        }
                    }
                }

                foreach (var plot in LandlordManager.Instance.GlobalPlots[settlement.StringId])
                {

                    if (mapEvent.WinningSide != BattleSideEnum.Defender)
                    {
                        plot.Garrison.Clear();
                    }
                }
            }
        }

        private void ModifyHearths(Village v, float amount)
        {
            try
            {
                PropertyInfo hearthProp = typeof(Village).GetProperty("Hearth");
                if (hearthProp != null)
                {
                    float current = (float)hearthProp.GetValue(v);
                    hearthProp.SetValue(v, current + amount);
                }
            }
            catch { }
        }
    }
}
