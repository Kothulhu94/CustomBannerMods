using System;
using Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.SaveSystem;
using TaleWorlds.CampaignSystem.Inventory;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.CampaignSystem.Settlements.Workshops;

using Microsoft.Extensions.Logging;

namespace Landlord
{
    public class EconomyBehavior : CampaignBehaviorBase
    {
        private readonly ILogger<EconomyBehavior> _logger;
        private int _selectedSlotIndex = -1;
        private VillagePlot _currentManagedPlot; 
        private string _selectedCategory = ""; 
        private Dictionary<string, List<VillagePlot>> _globalPlots = new Dictionary<string, List<VillagePlot>>();

        public EconomyBehavior(ILogger<EconomyBehavior> logger)
        {
            _logger = logger;
        }

        public override void RegisterEvents()
        {
            _logger.LogInformation("Landlord: Registering Events...");
            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, OnSessionLaunched);
            CampaignEvents.SettlementEntered.AddNonSerializedListener(this, OnSettlementEntered);
            CampaignEvents.WeeklyTickEvent.AddNonSerializedListener(this, OnWeeklyTick);
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, OnHourlyTick);
            _logger.LogInformation("Landlord: Events Registered.");
        }



        private List<ItemObject> GetItemsByCategory(string category)
        {
            var allItems = Game.Current.ObjectManager.GetObjectTypeList<ItemObject>();
            var filtered = new List<ItemObject>();

            foreach (var item in allItems)
            {
                if (category == "Food")
                {

                    if (item.IsFood && !item.IsAnimal) 
                    {
                        string id = item.StringId.ToLower();
                        if (!id.Contains("meat") && !id.Contains("beer") && !id.Contains("wine") && 
                            !id.Contains("oil") && !id.Contains("cheese") && !id.Contains("butter"))
                        {
                            filtered.Add(item);
                        }
                    }
                }
                else if (category == "Livestock")
                {

                    if (item.IsAnimal) 
                    {
                         string id = item.StringId.ToLower();
                         if (id.Contains("cow") || id.Contains("sheep") || id.Contains("hog")) 
                         {
                             filtered.Add(item);
                         }
                    }
                }
                else if (category == "Village Goods")
                {

                    string id = item.StringId.ToLower();
                    if (id == "clay" || id == "iron_ore" || id == "hardwood" || id == "silver_ore" || id == "salt" || 
                        id == "cotton" || id == "flax" || id == "pottery" || id == "linen" || id == "tools") 
                    {
                        filtered.Add(item);
                    }

                }
                else if (category == "Pack")
                {
                    if (item.ItemType == ItemObject.ItemTypeEnum.Horse && item.HorseComponent != null && item.HorseComponent.IsPackAnimal)
                    {
                        filtered.Add(item);
                    }
                }
                else if (category == "Mount")
                {
                     if (item.ItemType == ItemObject.ItemTypeEnum.Horse && item.HorseComponent != null && !item.HorseComponent.IsPackAnimal)
                     {
                         if (item.Tier < ItemObject.ItemTiers.Tier4 && !item.ItemCategory.StringId.ToLower().Contains("war"))
                         {
                             filtered.Add(item);
                         }
                     }
                }
                else if (category == "War")
                {
                    if (item.ItemType == ItemObject.ItemTypeEnum.Horse && item.HorseComponent != null && !item.HorseComponent.IsPackAnimal)
                    {
                         if (item.Tier >= ItemObject.ItemTiers.Tier4 || item.ItemCategory.StringId.ToLower().Contains("war"))
                         {
                             filtered.Add(item);
                         }
                    }
                }
            }

            return filtered.OrderBy(i => i.Name.ToString()).ToList();
        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("_globalPlots", ref _globalPlots);
            if (_globalPlots == null) _globalPlots = new Dictionary<string, List<VillagePlot>>();
            LandlordManager.Instance.SetPlots(_globalPlots);
        }

        private void OnSessionLaunched(CampaignGameStarter campaignStarter)
        {
            _logger.LogInformation("Landlord: OnSessionLaunched triggered.");
            if (_globalPlots == null) _globalPlots = new Dictionary<string, List<VillagePlot>>();
            LandlordManager.Instance.SetPlots(_globalPlots);

            // Buy Land Menu Option
            campaignStarter.AddGameMenuOption("village", "village_landlord_buy", "Buy Land",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Trade;
                    var settlement = Settlement.CurrentSettlement;
                    int playerOwnedCount = 0;
                    if (LandlordManager.Instance.GlobalPlots.ContainsKey(settlement.StringId))
                    {
                        playerOwnedCount = LandlordManager.Instance.GlobalPlots[settlement.StringId].Count(p => p.Owner == Hero.MainHero);
                    }
                    return playerOwnedCount < 3;
                },
                (MenuCallbackArgs args) =>
                {
                    GameMenu.SwitchToMenu("village_landlord_slot_selection");
                }, false, 1, false);

            // Slot Selection Menu
            campaignStarter.AddGameMenu("village_landlord_slot_selection", "Select a plot to purchase:",
                (MenuCallbackArgs args) => { },
                GameMenu.MenuOverlayType.SettlementWithBoth,
                GameMenu.MenuFlags.None,
                null);

            for (int i = 0; i < 3; i++)
            {
                int slotIndex = i;
                string baseName = GetSlotName(slotIndex); 
                campaignStarter.AddGameMenuOption("village_landlord_slot_selection", $"buy_slot_{i}", baseName,
                    (MenuCallbackArgs args) =>
                    {
                        var stats = GetSlotStats(slotIndex);
                        string plotName = GetSlotName(slotIndex);
                        bool isFree = IsSlotFree(Settlement.CurrentSettlement, slotIndex);

                        if (!isFree)
                        {
                            var plots = LandlordManager.Instance.GlobalPlots[Settlement.CurrentSettlement.StringId];
                            var plot = plots.First(p => p.SlotIndex == slotIndex);
                            string ownerName = (plot.Owner != null) ? plot.Owner.Name.ToString() : "Unknown";
                            
                            args.Text = new TextObject($"{plotName} (Owned by {ownerName})");
                            args.Tooltip = new TextObject($"This plot is currently owned by {ownerName}.");
                            
                            if (plot.Owner == Hero.MainHero) {
                                args.Text = new TextObject($"{plotName} (Yours)");
                                args.Tooltip = new TextObject("You own this plot.");
                            }
                        }
                        else
                        {
                            args.Text = new TextObject($"{plotName} ({stats.cost}g, {stats.yield:P0} Yield)");
                             
                            if (Hero.MainHero.Gold < stats.cost)
                            {
                                args.IsEnabled = false;
                                args.Tooltip = new TextObject("Not enough gold.");
                            }
                        }
                        
                        args.optionLeaveType = GameMenuOption.LeaveType.Continue;
                        return true;
                    },
                    (MenuCallbackArgs args) =>
                    {
                        if (!IsSlotFree(Settlement.CurrentSettlement, slotIndex))
                        {
                            var plots = LandlordManager.Instance.GlobalPlots[Settlement.CurrentSettlement.StringId];
                            var plot = plots.First(p => p.SlotIndex == slotIndex);
                            
                            if (plot.Owner == Hero.MainHero)
                            {
                                InformationManager.DisplayMessage(new InformationMessage($"You already own this plot."));
                                return;
                            }
                            LandlordManager.Instance.SelectedPlot = plot;
                            GameMenu.SwitchToMenu("village_landlord_raze_menu"); 
                            return; 
                        }

                        _selectedSlotIndex = slotIndex;
                        GameMenu.SwitchToMenu("village_landlord_category_selection"); // Go to Category first
                    }, false, -1, false);
            }

            campaignStarter.AddGameMenuOption("village_landlord_slot_selection", "leave_slots", "Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village"); }, true, -1, false);


            // Category Selection Menu (NEW)
            campaignStarter.AddGameMenu("village_landlord_category_selection", "Select production category:",
                (MenuCallbackArgs args) => { },
                GameMenu.MenuOverlayType.SettlementWithBoth,
                GameMenu.MenuFlags.None, null);

            var categories = new List<string> { "Food", "Livestock", "Village Goods", "Pack", "Mount", "War" };
            foreach(var cat in categories)
            {
                campaignStarter.AddGameMenuOption("village_landlord_category_selection", $"cat_{cat}", cat,
                (MenuCallbackArgs args) => { return true; },
                (MenuCallbackArgs args) =>
                {
                    _selectedCategory = cat;
                    GameMenu.SwitchToMenu("village_landlord_item_selection");
                }, false, -1, false);
            }

            campaignStarter.AddGameMenuOption("village_landlord_category_selection", "leave_cat", "Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village_landlord_slot_selection"); }, true, -1, false);


            // Item Selection Menu (Dynamic)
            campaignStarter.AddGameMenu("village_landlord_item_selection", "Select item to produce:",
                (MenuCallbackArgs args) => { },
                GameMenu.MenuOverlayType.SettlementWithBoth,
                GameMenu.MenuFlags.None, null);

            // Add dynamic options here? 
            // Bannerlord GameMenus are static. We can't loop inside the definition easily unless we pre-register ALL possible items.
            // SOLUTION: We must pre-register ALL items, but set IsVisible (args.Condition) based on _selectedCategory.
            
            // Register options for ALL categories
            var allValidItems = GetItemsByCategory("Food")
                .Concat(GetItemsByCategory("Livestock"))
                .Concat(GetItemsByCategory("Village Goods"))
                .Concat(GetItemsByCategory("Pack"))
                .Concat(GetItemsByCategory("Mount"))
                .Concat(GetItemsByCategory("War"))
                .Distinct()
                .ToList();

            foreach (var item in allValidItems)
            {
                campaignStarter.AddGameMenuOption("village_landlord_item_selection", $"crop_{item.StringId}", $"Invest in {item.Name}",
                    (MenuCallbackArgs args) =>
                    {
                        // VISIBILITY CHECK
                        // Determine item category
                        string itemCat = "Food";
                        if (item.ItemType == ItemObject.ItemTypeEnum.Animal) itemCat = "Livestock";
                        if (item.ItemType == ItemObject.ItemTypeEnum.Goods) itemCat = "Village Goods"; // Assume Goods if not Animal/Horse/Food, refinement below
                        if (item.ItemType == ItemObject.ItemTypeEnum.Horse)
                        {
                            if (item.HorseComponent.IsPackAnimal) itemCat = "Pack";
                            else if (item.Tier < ItemObject.ItemTiers.Tier4 && !item.ItemCategory.StringId.ToLower().Contains("war")) itemCat = "Mount";
                            else itemCat = "War";
                        }
                        
                         // Strict Refinement matches GetItemsByCategory logic
                        if (itemCat == "Village Goods")
                        {
                            // Verify it's in our allowlist for goods, otherwise it might be random good
                            // or fallback logic for non-food non-animal invalid items
                            // But since we iterate valid items, we assume it's correct category if it matches the type
                        }

                        if (item.IsFood && !item.IsAnimal) itemCat = "Food";
                        
                        // Handle Overlaps (e.g. Meat is Food but we excluded it in query, if present handle it)
                        
                        // Re-verify category against our query Logic to be safe
                        if (GetItemsByCategory("Livestock").Contains(item)) itemCat = "Livestock";
                        else if (GetItemsByCategory("Village Goods").Contains(item)) itemCat = "Village Goods";
                        else if (GetItemsByCategory("Pack").Contains(item)) itemCat = "Pack";
                        else if (GetItemsByCategory("Mount").Contains(item)) itemCat = "Mount";
                        else if (GetItemsByCategory("War").Contains(item)) itemCat = "War";
                        else if (GetItemsByCategory("Food").Contains(item)) itemCat = "Food";


                        if (itemCat != _selectedCategory) return false;

                        float eff = GetEfficiency(Settlement.CurrentSettlement, item.StringId);
                        int price = 0;
                        if (Settlement.CurrentSettlement.Village != null)
                        {
                             price = Settlement.CurrentSettlement.Village.GetItemPrice(item, MobileParty.MainParty, false);
                        }
                        args.Text = new TextObject($"Invest in {item.Name} (Price: {price}g, Eff: {eff:P0})");
                        args.optionLeaveType = GameMenuOption.LeaveType.Continue;
                        return true;
                    },
                    (MenuCallbackArgs args) =>
                    {
                        // Check if this is a "Change Prod" action or "New Buy" action?
                        // This menu is reached from "Slot Selection" -> "Category" -> "Item", so it implies Buying New Land.
                        // Ideally we reuse this for "Change Production" too? 
                        // Let's keep it simple: This flow is for BUYING.
                        
                        BuyLand(Settlement.CurrentSettlement, Hero.MainHero, item.StringId, _selectedSlotIndex);
                        GameMenu.SwitchToMenu("village");
                    }, false, -1, false);
            }

            campaignStarter.AddGameMenuOption("village_landlord_item_selection", "leave_item", "Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village_landlord_category_selection"); }, true, -1, false);


            // Change Production Menu (Refactored to use Categories too)
            // To save menu space, we'll duplicate the logic but point to a new "Change Prod" Item Selection.
            
            campaignStarter.AddGameMenu("village_landlord_change_prod_cat", "Select new category:",
                (MenuCallbackArgs args) => { }, GameMenu.MenuOverlayType.SettlementWithBoth, GameMenu.MenuFlags.None, null);

             foreach(var cat in categories)
            {
                campaignStarter.AddGameMenuOption("village_landlord_change_prod_cat", $"change_cat_{cat}", cat,
                (MenuCallbackArgs args) => { return true; },
                (MenuCallbackArgs args) =>
                {
                    _selectedCategory = cat;
                    GameMenu.SwitchToMenu("village_landlord_change_prod_item");
                }, false, -1, false);
            }
             campaignStarter.AddGameMenuOption("village_landlord_change_prod_cat", "leave_cp_cat", "Cancel",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village_landlord_manage"); }, true, -1, false);

            campaignStarter.AddGameMenu("village_landlord_change_prod_item", "Select new production (Cost: {COST}g):",
                (MenuCallbackArgs args) => { 
                    GameTexts.SetVariable("COST", GlobalSettings.Instance.ChangeProductionCost);
                }, GameMenu.MenuOverlayType.SettlementWithBoth, GameMenu.MenuFlags.None, null);

            foreach (var item in allValidItems)
            {
                campaignStarter.AddGameMenuOption("village_landlord_change_prod_item", $"change_item_{item.StringId}", item.Name.ToString(),
                    (MenuCallbackArgs args) =>
                    {
                         // CATEGORY LOGIC COPY
                        string itemCat = "Food";
                        if (item.ItemType == ItemObject.ItemTypeEnum.Animal) itemCat = "Livestock";
                        if (item.ItemType == ItemObject.ItemTypeEnum.Goods) itemCat = "Village Goods";
                        if (item.ItemType == ItemObject.ItemTypeEnum.Horse)
                        {
                            if (item.HorseComponent.IsPackAnimal) itemCat = "Pack";
                            else if (item.Tier < ItemObject.ItemTiers.Tier4 && !item.ItemCategory.StringId.ToLower().Contains("war")) itemCat = "Mount";
                            else itemCat = "War";
                        }
                        if (item.IsFood && !item.IsAnimal) itemCat = "Food";
                        
                        if (GetItemsByCategory("Livestock").Contains(item)) itemCat = "Livestock";
                        else if (GetItemsByCategory("Village Goods").Contains(item)) itemCat = "Village Goods";
                        else if (GetItemsByCategory("Pack").Contains(item)) itemCat = "Pack";
                        else if (GetItemsByCategory("Mount").Contains(item)) itemCat = "Mount";
                        else if (GetItemsByCategory("War").Contains(item)) itemCat = "War";
                        else if (GetItemsByCategory("Food").Contains(item)) itemCat = "Food";

                        if (itemCat != _selectedCategory) return false;

                         var plot = _currentManagedPlot;
                        if (plot == null) return false;

                        float eff = GetEfficiency(Settlement.CurrentSettlement, item.StringId);
                        args.Text = new TextObject($"Switch to {item.Name} (Eff: {eff:P0})");
                        
                        if (plot.ProductionId == item.StringId)
                        {
                            args.IsEnabled = false;
                            args.Tooltip = new TextObject("Currently producing this.");
                        }
                        else if (Hero.MainHero.Gold < GlobalSettings.Instance.ChangeProductionCost)
                        {
                            args.IsEnabled = false;
                            args.Tooltip = new TextObject($"Not enough gold ({GlobalSettings.Instance.ChangeProductionCost}g required).");
                        }
                        return true;
                    },
                    (MenuCallbackArgs args) =>
                    {
                        var plot = _currentManagedPlot;
                        int cost = GlobalSettings.Instance.ChangeProductionCost;
                        if (Hero.MainHero.Gold >= cost)
                        {
                             GiveGoldAction.ApplyForCharacterToSettlement(Hero.MainHero, Settlement.CurrentSettlement, cost, false);
                             plot.ProductionId = item.StringId;
                             InformationManager.DisplayMessage(new InformationMessage($"Estate now producing {item.Name}."));
                             GameMenu.SwitchToMenu("village_landlord_manage");
                        }
                    }, false, -1, false);
            }
            campaignStarter.AddGameMenuOption("village_landlord_change_prod_item", "leave_cp_item", "Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village_landlord_change_prod_cat"); }, true, -1, false);


            // Manage Plot Entry (Existing)
            campaignStarter.AddGameMenuOption("village", "village_landlord_manage_entry", "Manage Estate",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Manage;
                    var settlement = Settlement.CurrentSettlement;
                    if (!LandlordManager.Instance.GlobalPlots.ContainsKey(settlement.StringId)) return false;
                    return LandlordManager.Instance.GlobalPlots[settlement.StringId].Any(p => p.Owner == Hero.MainHero);
                },
                (MenuCallbackArgs args) =>
                {
                    var settlement = Settlement.CurrentSettlement;
                    var plots = LandlordManager.Instance.GlobalPlots[settlement.StringId].Where(p => p.Owner == Hero.MainHero).ToList();
                    
                    if (plots.Count == 1)
                    {
                        _currentManagedPlot = plots[0];
                        GameMenu.SwitchToMenu("village_landlord_manage");
                    }
                    else
                    {
                        GameMenu.SwitchToMenu("village_landlord_select_manage_plot");
                    }
                }, false, 2, false);

            // Select Plot to Manage Menu (Existing)
            campaignStarter.AddGameMenu("village_landlord_select_manage_plot", "Select a plot to manage:",
                (MenuCallbackArgs args) => { },
                GameMenu.MenuOverlayType.SettlementWithBoth,
                GameMenu.MenuFlags.None, null);

            for (int i = 0; i < 3; i++)
            {
                int slotIndex = i;
                campaignStarter.AddGameMenuOption("village_landlord_select_manage_plot", $"manage_slot_{i}", GetSlotName(slotIndex),
                    (MenuCallbackArgs args) =>
                    {
                        var settlement = Settlement.CurrentSettlement;
                         if (!LandlordManager.Instance.GlobalPlots.ContainsKey(settlement.StringId)) return false;
                        
                        var plot = LandlordManager.Instance.GlobalPlots[settlement.StringId].FirstOrDefault(p => p.SlotIndex == slotIndex && p.Owner == Hero.MainHero);
                        if (plot == null) return false;

                        string name = GetSlotName(slotIndex);
                        var item = Game.Current.ObjectManager.GetObject<ItemObject>(plot.ProductionId);
                        string prodName = item != null ? item.Name.ToString() : plot.ProductionId;

                        args.Text = new TextObject($"Manage {name} (Producing {prodName})");
                        args.optionLeaveType = GameMenuOption.LeaveType.Manage;
                        return true;
                    },
                    (MenuCallbackArgs args) =>
                    {
                         var settlement = Settlement.CurrentSettlement;
                         _currentManagedPlot = LandlordManager.Instance.GlobalPlots[settlement.StringId].First(p => p.SlotIndex == slotIndex && p.Owner == Hero.MainHero);
                         GameMenu.SwitchToMenu("village_landlord_manage");
                    }, false, -1, false);
            }
            
            campaignStarter.AddGameMenuOption("village_landlord_select_manage_plot", "leave_select", "Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; }, 
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village"); }, true, -1, false);

            // Manage Plot Menu Details (Modified Change Prod Link)
            campaignStarter.AddGameMenu("village_landlord_manage", "Manage your estate:",
                (MenuCallbackArgs args) => { 
                    if (_currentManagedPlot != null) {
                         string name = GetSlotName(_currentManagedPlot.SlotIndex);
                         args.MenuTitle = new TextObject($"Manage {name}");
                    }
                },
                GameMenu.MenuOverlayType.SettlementWithBoth,
                GameMenu.MenuFlags.None, null);

            campaignStarter.AddGameMenuOption("village_landlord_manage", "change_production", "Change Production",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Trade; return true; },
                (MenuCallbackArgs args) =>
                {
                     if (_currentManagedPlot == null) return;
                     GameMenu.SwitchToMenu("village_landlord_change_prod_cat");
                }, false, -1, false);

            // Upgrade Guardhouse (Existing)
            campaignStarter.AddGameMenuOption("village_landlord_manage", "upgrade_guardhouse", "Upgrade Guardhouse",
                (MenuCallbackArgs args) =>
                {
                    var plot = _currentManagedPlot;
                    if (plot == null) return false;
                    
                    int cost = (plot.GuardhouseLevel + 1) * 5000;
                    int nextLevel = plot.GuardhouseLevel + 1;
                    int nextGuardCap = GetGuardCap(nextLevel);
                    int nextStashCap = GetStashCap(nextLevel);

                    args.Text = new TextObject($"Upgrade Guardhouse to Level {nextLevel} (Cost: {cost}g)");
                    args.Tooltip = new TextObject($"Increases Garrison to {nextGuardCap} troops and Warehouse to {nextStashCap} items.");
                    
                    if (plot.GuardhouseLevel >= 3)
                    {
                        args.IsEnabled = false;
                        args.Text = new TextObject("Guardhouse Max Level");
                    }
                    else if (Hero.MainHero.Gold < cost)
                    {
                        args.IsEnabled = false;
                        args.Tooltip = new TextObject($"Not enough gold ({cost}g required).");
                    }
                    args.optionLeaveType = GameMenuOption.LeaveType.Continue;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    var plot = _currentManagedPlot;
                    int cost = (plot.GuardhouseLevel + 1) * 5000;
                    GiveGoldAction.ApplyForCharacterToSettlement(Hero.MainHero, Settlement.CurrentSettlement, cost, false);
                    plot.GuardhouseLevel++;
                    InformationManager.DisplayMessage(new InformationMessage($"Guardhouse upgraded to Level {plot.GuardhouseLevel}."));
                    GameMenu.SwitchToMenu("village_landlord_manage");
                }, false, -1, false);

            // Toggle Yield Split (Existing)
            campaignStarter.AddGameMenuOption("village_landlord_manage", "toggle_yield", "Toggle Yield Split",
                (MenuCallbackArgs args) =>
                {
                    var plot = _currentManagedPlot;
                    if (plot == null) return false;
                    args.Text = new TextObject($"Toggle Yield Split: {plot.StashYieldPct}% to Stash");
                    args.optionLeaveType = GameMenuOption.LeaveType.Continue;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    var plot = _currentManagedPlot;
                    plot.StashYieldPct += 25;
                    if (plot.StashYieldPct > 100) plot.StashYieldPct = 0;
                    InformationManager.DisplayMessage(new InformationMessage($"Yield Split set to {plot.StashYieldPct}% Stash"));
                    GameMenu.SwitchToMenu("village_landlord_manage");
                }, false, -1, false);

            // Station Guards (Existing)
            campaignStarter.AddGameMenuOption("village_landlord_manage", "station_guards", "Station Guards",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.TroopSelection;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    var plot = _currentManagedPlot;
                    int cap = GetGuardCap(plot.GuardhouseLevel);
                    PartyScreenHelper.OpenScreenAsLoot(plot.Garrison, TroopRoster.CreateDummyTroopRoster(), new TextObject("Garrison"), cap, null);
                }, false, -1, false);

            // Open Warehouse (Existing)
            campaignStarter.AddGameMenuOption("village_landlord_manage", "open_warehouse", "Open Warehouse",
                (MenuCallbackArgs args) =>
                {
                    args.optionLeaveType = GameMenuOption.LeaveType.Trade;
                    return true;
                },
                (MenuCallbackArgs args) =>
                {
                    var plot = _currentManagedPlot;
                    InventoryScreenHelper.OpenScreenAsStash(plot.Stash);
                }, false, -1, false);

            // Leave Manage
            campaignStarter.AddGameMenuOption("village_landlord_manage", "leave_manage", "Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village"); }, true, -1, false);
        }

        private void OnSettlementEntered(MobileParty party, Settlement settlement, Hero hero)
        {
            if (party == null || settlement == null || !settlement.IsVillage) return;
            
            // Caravan Logic
            if (party.IsCaravan && party.LeaderHero != null && (party.LeaderHero.Clan == Clan.PlayerClan || party.LeaderHero.IsPlayerCompanion))
            {
                 int slot = GetFirstFreeSlotIndex(settlement);
                 if (slot != -1)
                 {
                     InformationManager.ShowInquiry(new InquiryData("Land Opportunity", 
                         $"Your caravan in {settlement.Name} found available land. Buy for {GetSlotStats(slot).cost}?", 
                         true, true, "Yes", "No", 
                         () => { BuyLand(settlement, Hero.MainHero, "grain", slot); }, null));
                 }
            }

            // AI Lord Buying Logic
            if (party.LeaderHero != null && party.LeaderHero != Hero.MainHero && party.LeaderHero.IsLord)
            {
                if (party.LeaderHero.Gold > 150000 && !party.LeaderHero.MapFaction.IsAtWarWith(settlement.MapFaction))
                {
                    int slot = GetFirstFreeSlotIndex(settlement);
                    if (slot != -1)
                    {
                        var options = GetItemsByCategory("Food");
                        if (options.Count > 0)
                        {
                            var crop = options.GetRandomElement();
                            BuyLand(settlement, party.LeaderHero, crop.StringId, slot);
                        }
                    }
                }
            }
        }

        private void OnWeeklyTick()
        {
        }

        private void OnHourlyTick()
        {
            try 
            {
                // Safety check for Settings
                bool debug = false;
                try { debug = GlobalSettings.Instance != null && GlobalSettings.Instance.DebugMode; } catch { }


                if (CampaignTime.Now.CurrentHourInDay == 12) 
                {
                   _logger.LogInformation($"[Landlord] HEARTBEAT: Tick confirmed at Hour 12.");
                }

                if (CampaignTime.Now.CurrentHourInDay != 22) return;
                
                _logger.LogInformation("Landlord Hourly Tick (Hour 22) EXECUTION STARTED.");
                
                if (LandlordManager.Instance.GlobalPlots == null) 
                {
                    _logger.LogError("GlobalPlots is NULL! Production skipped.");
                    return;
                }

                if (debug && LandlordManager.Instance.GlobalPlots.Count == 0)
                {
                    _logger.LogInformation("GlobalPlots is Empty. No plots owned/initialized.");
                }

                foreach (var kvp in LandlordManager.Instance.GlobalPlots)
                {
                    var villageId = kvp.Key;
                    var plots = kvp.Value;
                    var settlement = Settlement.Find(villageId);
                    
                    if (settlement == null) 
                    {
                        if (debug) _logger.LogWarning($"Settlement not found for ID: {villageId}");
                        continue;
                    }

                    foreach (var plot in plots)
                    {
                        plot.LastDailyIncome = 0;

                        float yieldMult = GetSlotStats(plot.SlotIndex).yield;
                        float eff = GetEfficiency(settlement, plot.ProductionId);
                        float actualYield = 8f * yieldMult * eff;

                        if (debug)
                        {
                            _logger.LogInformation($"[Landlord Debug] Processing Plot {plot.SlotIndex} for {plot.Owner?.Name} in {settlement.Name}. Cost: {GetSlotStats(plot.SlotIndex).cost}, YieldMult: {yieldMult}, Eff: {eff}, ActualYield: {actualYield}");
                        }
                        

                        float foodNeeded = plot.Garrison.TotalManCount / 40f; 
                        float netSurplus = actualYield - foodNeeded;

                        if (netSurplus < 0)
                        {
                            bool hasFood = false;
                            foreach (var item in plot.Stash)
                            {
                                if (item.EquipmentElement.Item.IsFood)
                                {
                                    hasFood = true;
                                    break;
                                }
                            }

                            if (!hasFood)
                            {
                                int woundCount = (int)(plot.Garrison.TotalManCount * 0.1f);
                                if (woundCount > 0) plot.Garrison.WoundNumberOfNonHeroTroopsRandomly(woundCount); 
                            }
                        }
                        else
                        {
                            float toStashAmt = netSurplus * (plot.StashYieldPct / 100f);
                            float toSellAmt = netSurplus - toStashAmt;

                            var cropItem = Game.Current.ObjectManager.GetObject<ItemObject>(plot.ProductionId);
                            if (cropItem == null) 
                            {
                                if (debug) _logger.LogError($"Invalid Production ID: {plot.ProductionId}");
                                continue;
                            }

                            int stashCount = (int)toStashAmt;
                            int sellCount = (int)toSellAmt;

                            if (plot.Stash.Sum(i => i.GetRosterElementWeight()) + (stashCount * cropItem.Weight) > GetStashCap(plot.GuardhouseLevel))
                            {
                                sellCount += stashCount;
                                stashCount = 0; // Overflow stash to sell? No, usually loss or sell. Logic here sells overflow.
                                // Previous logic was: sellCount += stashCount; stashCount = 0;
                                // Wait, line 689 was `stashCount = 0;` which implies we sell EVERYTHING if stash is full?
                                // Let's keep it safe.
                            }

                            if (stashCount > 0)
                            {
                                plot.Stash.AddToCounts(cropItem, stashCount);
                            }

                            if (sellCount > 0)
                            {
                                // 1. Determine Price
                                int pricePerItem = cropItem.Value;
                                if (settlement.Village != null) 
                                {
                                    try { pricePerItem = settlement.Village.GetItemPrice(cropItem, MobileParty.MainParty, false); }
                                    catch { pricePerItem = cropItem.Value; }
                                }
                                if (pricePerItem <= 0) pricePerItem = cropItem.Value; 

                                int totalRevenue = sellCount * pricePerItem;
                                
                                // 2. Add to Village Inventory
                                settlement.ItemRoster.AddToCounts(cropItem, sellCount);

                                    // 3. Pay the Owner
                                    if (plot.Owner != null && plot.Owner.IsAlive)
                                    {
                                        int profit = totalRevenue;
                                        plot.LastDailyIncome = profit;

                                        try
                                        {
                                            // Liquidity Injection & Stimulus
                                            if (settlement.Village != null)
                                            {
                                                int currentGold = settlement.Village.Gold;
                                                int deficit = (profit > currentGold) ? (profit - currentGold) : 0;
                                                int stimulus = profit / 2; // User Request: Gain amount / 2
                                                int totalInjection = deficit + stimulus;

                                                if (totalInjection > 0)
                                                {
                                                    ModifyVillageGold(settlement.Village, totalInjection);
                                                    if (debug)
                                                        _logger.LogInformation($"[Landlord Debug] Injected {totalInjection}g into {settlement.Name} (Deficit: {deficit}, Stimulus: {stimulus}). New Gold: {settlement.Village.Gold}");
                                                }
                                            }

                                            if (debug)
                                                _logger.LogInformation($"[Landlord Debug] Attempting to payout {profit}g to {plot.Owner.Name}. Village Gold: {settlement.Village.Gold}");

                                            GiveGoldAction.ApplyForSettlementToCharacter(settlement, plot.Owner, profit, true);
                                            
                                            if (plot.Owner == Hero.MainHero)
                                            {
                                                var msg = $"[Estate] {settlement.Name}: Sold {sellCount}x {cropItem.Name} for {profit}g.";
                                                InformationManager.DisplayMessage(new InformationMessage(msg));
                                                if (debug) _logger.LogInformation($"[Landlord Debug] Notification sent: {msg}");
                                            }
                                        }
                                    catch (Exception ex)
                                    {
                                        _logger.LogError(ex, $"[Landlord Error] Failed to process gold payment for {plot.Owner.Name} in {settlement.Name}");
                                    }
                                }
                            }
                            else
                            {
                                    _logger.LogInformation($"[Landlord Debug] No surplus to sell. Yield: {actualYield}, FoodNeeded: {foodNeeded}");
                                }
                                
                                if (plot.Owner == Hero.MainHero)
                                {
                                     // ALWAYS Notify user of daily status to confirm system activity
                                     int stashTotal = plot.Stash.Sum(i => i.Amount);
                                     var msg = $"[Estate] {settlement.Name}: Produced {actualYield:F1} units. Garrison ate {foodNeeded:F1}. Stashed {stashCount}. Sold {sellCount}.";
                                     InformationManager.DisplayMessage(new InformationMessage(msg));
                                }

                                if (plot.Owner != null && !plot.Owner.IsHumanPlayerCharacter && debug)
                                {
                                     _logger.LogInformation($"[Landlord Debug AI] {plot.Owner.Name} in {settlement.Name}: Produced {actualYield:F1} (Item: {plot.ProductionId ?? "Unknown"}). Garrison ate {foodNeeded:F1}. Stashed {stashCount}. Sold {sellCount}.");
                                }

                            

                            if (sellCount > 0 || stashCount > 0)
                            {
                                 string pId = plot.ProductionId.ToLower();
                                 if (pId.Contains("cow") || pId.Contains("cattle"))
                                 {

                                      var butter = Game.Current.ObjectManager.GetObject<ItemObject>("butter");
                                      var cheese = Game.Current.ObjectManager.GetObject<ItemObject>("cheese");
                                      int bonusAmt = Math.Max(1, (int)(actualYield * 0.5f)); 
                                      
                                      if (butter != null) plot.Stash.AddToCounts(butter, bonusAmt);
                                      if (cheese != null) plot.Stash.AddToCounts(cheese, bonusAmt);
                                 }
                                 else if (pId.Contains("sheep"))
                                 {

                                      var wool = Game.Current.ObjectManager.GetObject<ItemObject>("wool");
                                      int bonusAmt = Math.Max(1, (int)(actualYield * 0.8f));
                                      if (wool != null) plot.Stash.AddToCounts(wool, bonusAmt);
                                 }
                            }
                        }

                        if (plot.Owner != null && !plot.Owner.IsHumanPlayerCharacter && plot.Owner.IsLord)
                        {
                            ManageAIPlot(plot, settlement, netSurplus);
                        }
                    }
                }
                if (debug) _logger.LogInformation("Landlord Hourly Tick Finished Successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Critical failure in OnHourlyTick");
            }
        }

        private bool IsSlotFree(Settlement settlement, int index)
        {
            if (!LandlordManager.Instance.GlobalPlots.ContainsKey(settlement.StringId)) return true;
            return !LandlordManager.Instance.GlobalPlots[settlement.StringId].Any(p => p.SlotIndex == index);
        }

        private int GetFirstFreeSlotIndex(Settlement settlement)
        {
            for (int i = 0; i < 3; i++)
            {
                if (IsSlotFree(settlement, i)) return i;
            }
            return -1;
        }

        private (int cost, float yield) GetSlotStats(int index)
        {
            if (index == 0) return (GlobalSettings.Instance.NormalPlotCost, 1.0f);
            if (index == 1) return (GlobalSettings.Instance.GoodPlotCost, 1.2f);
            return (GlobalSettings.Instance.GreatPlotCost, 1.5f);
        }

        private string GetSlotName(int index)
        {
            if (index == 0) return "Normal Plot";
            if (index == 1) return "Good Plot";
            return "Great Plot";
        }

        private float GetEfficiency(Settlement settlement, string productionId)
        {
            float baseEff = 0.8f;
            if (settlement.Village != null) baseEff += (settlement.Village.Hearth / 1000f);
            
            var season = CampaignTime.Now.GetSeasonOfYear;
            if (season == CampaignTime.Seasons.Spring || season == CampaignTime.Seasons.Summer) baseEff += 0.1f;
            else if (season == CampaignTime.Seasons.Winter) baseEff -= 0.2f;

            if (settlement.Culture != null)
            {
                string cultureId = settlement.Culture.StringId.ToLower();
                if (cultureId.Contains("aserai") && productionId.Contains("date")) baseEff += 0.3f;
                if (cultureId.Contains("empire") && productionId.Contains("olive")) baseEff += 0.3f;
                if (cultureId.Contains("nord") && (productionId.Contains("cow") || productionId.Contains("cattle") || productionId.Contains("meat"))) baseEff += 0.3f;
                if (cultureId.Contains("sturgia") && (productionId.Contains("fish") || productionId.Contains("fur") || productionId.Contains("flax") || productionId.Contains("linen"))) baseEff += 0.3f;
                if (cultureId.Contains("battania") && (productionId.Contains("wood"))) baseEff += 0.3f;
                if (cultureId.Contains("vlandia") && (productionId.Contains("horse"))) baseEff += 0.3f;
                if (cultureId.Contains("khuzait") && (productionId.Contains("sheep") || productionId.Contains("wool") || productionId.Contains("horse"))) baseEff += 0.3f;
            }

            return MathF.Max(0.1f, baseEff);
        }

        private void BuyLand(Settlement settlement, Hero buyer, string productionId, int slotIndex)
        {
            if (!IsSlotFree(settlement, slotIndex)) return;
            var stats = GetSlotStats(slotIndex);
            if (buyer.Gold < stats.cost) return;

            GiveGoldAction.ApplyForCharacterToSettlement(buyer, settlement, stats.cost, false);

            var plot = new VillagePlot
            {
                VillageStringId = settlement.StringId,
                SlotIndex = slotIndex,
                Owner = buyer,
                ProductionId = productionId,
                WageLevel = 1
            };

            if (!LandlordManager.Instance.GlobalPlots.ContainsKey(settlement.StringId))
            {
                LandlordManager.Instance.GlobalPlots[settlement.StringId] = new List<VillagePlot>();
            }
            LandlordManager.Instance.GlobalPlots[settlement.StringId].Add(plot);
            ModifyHearths(settlement.Village, 20f);
            InformationManager.DisplayMessage(new InformationMessage($"{buyer.Name} bought land in {settlement.Name}"));
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

        private void ModifyVillageGold(Village v, int amount)
        {
            try
            {
                // Try standard Property first
                PropertyInfo goldProp = typeof(Village).GetProperty("Gold");
                if (goldProp != null && goldProp.CanWrite)
                {
                    int current = (int)goldProp.GetValue(v);
                    goldProp.SetValue(v, current + amount);
                    return;
                }
                
                // Fallback to internal field if property is read-only
                FieldInfo goldField = typeof(Village).GetField("_gold", BindingFlags.Instance | BindingFlags.NonPublic);
                if (goldField != null)
                {
                    int current = (int)goldField.GetValue(v);
                    goldField.SetValue(v, current + amount);
                }
            }
            catch (Exception ex) 
            {
                // Log silently strictly to not spam, or use existing logger if accessible
            }
        }

        private int GetGuardCap(int level)
        {
            return level switch { 1 => 50, 2 => 100, 3 => 200, _ => 0 };
        }

        private int GetStashCap(int level)
        {
            return level switch { 1 => 200, 2 => 400, 3 => 600, _ => 100 };
        }

        private VillagePlot GetPlayerPlot(Settlement settlement)
        {
            if (!LandlordManager.Instance.GlobalPlots.ContainsKey(settlement.StringId)) return null;
            return LandlordManager.Instance.GlobalPlots[settlement.StringId].FirstOrDefault(p => p.Owner == Hero.MainHero);
        }

        private void ManageAIPlot(VillagePlot plot, Settlement settlement, float netSurplus)
        {
            if (netSurplus <= 0) return;

            int cap = GetGuardCap(plot.GuardhouseLevel);
            if (plot.GuardhouseLevel < 3 && plot.Garrison.TotalManCount >= cap * 0.8f)
            {
                if (netSurplus > 5.0f) 
                {
                    int cost = (plot.GuardhouseLevel + 1) * 5000;
                    if (plot.Owner.Gold >= cost * 1.5f) 
                    {
                        GiveGoldAction.ApplyForCharacterToSettlement(plot.Owner, settlement, cost, false);
                        plot.GuardhouseLevel++;
                    }
                }
            }
            if (plot.Garrison.TotalManCount < cap)
            {
                if (netSurplus > 1.0f)
                {
                    CharacterObject troop = settlement.Culture.BasicTroop;
                    if (troop != null)
                    {
                        int recruitCost = 50; 
                        if (plot.Owner.Gold >= recruitCost)
                        {
                            GiveGoldAction.ApplyForCharacterToSettlement(plot.Owner, settlement, recruitCost, false);
                            plot.Garrison.AddToCounts(troop, 1);
                        }
                    }
                }
            }
        }
    }
}
