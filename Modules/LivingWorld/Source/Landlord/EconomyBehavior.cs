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
using HonestWork;
using Bannerlord.ButterLib.Extensions;
using Bannerlord.ButterLib.Common.Extensions;

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



        // Optimization: Cache Item Categories to prevent UI Lag
        private static Dictionary<string, List<ItemObject>> _itemCategoryCache = new Dictionary<string, List<ItemObject>>();

        private List<ItemObject> GetItemsByCategory(string category)
        {
            if (_itemCategoryCache.ContainsKey(category))
            {
                return _itemCategoryCache[category];
            }

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
                    if (id == "clay" || id == "silver" || id == "iron" || id == "charcoal" || 
                        id == "hardwood" || id == "salt" || id == "cotton" || id == "flax" || 
                        id == "pottery" || id == "linen" || id == "tools" || 
                        id == "fur" || id == "hides" || 
                        id == "walrus_tusk" || id == "whale_oil")
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
                         // War: Tier 4+, or "war" string, BUT NOT Noble (Tier 6)
                         if ((item.Tier >= ItemObject.ItemTiers.Tier4 || item.ItemCategory.StringId.ToLower().Contains("war")) && item.Tier < ItemObject.ItemTiers.Tier6)
                         {
                             filtered.Add(item);
                         }
                    }
                }
                else if (category == "Noble")
                {
                    if (item.ItemType == ItemObject.ItemTypeEnum.Horse && item.HorseComponent != null && !item.HorseComponent.IsPackAnimal)
                    {
                         // Noble: Tier 6+
                         if (item.Tier >= ItemObject.ItemTiers.Tier6)
                         {
                             filtered.Add(item);
                         }
                    }
                }
            }

            var result = filtered.OrderBy(i => i.Name.ToString()).ToList();
            _itemCategoryCache[category] = result;
            return result;
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
            campaignStarter.AddGameMenuOption("village", "village_landlord_buy", "{=lw_buyland}Buy Land",
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
            campaignStarter.AddGameMenu("village_landlord_slot_selection", "{=lw_selectaplottopu}Select a plot to purchase:",
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
                                // Allow them to click it to go to manage (logic handled in Consequence)
                            } else {
                                // NPC Owned - Disable purchase
                                args.IsEnabled = false;
                                args.Text = new TextObject($"{plotName} (Owned by {ownerName})");
                                args.Tooltip = new TextObject($"This plot is currently owned by {ownerName}. It is not for sale.");
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
                                // Manage directly if owned
                                _currentManagedPlot = plot;
                                GameMenu.SwitchToMenu("village_landlord_manage");
                                return;
                            }
                            // Show owner info if not owned by player (handled in text)
                        }

                        _selectedSlotIndex = slotIndex;
                        GameMenu.SwitchToMenu("village_landlord_category_selection"); // Go to Category first
                    }, false, -1, false);
            }

            campaignStarter.AddGameMenuOption("village_landlord_slot_selection", "leave_slots", "{=lw_back}Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village"); }, true, -1, false);


            // Category Selection Menu (NEW)
            campaignStarter.AddGameMenu("village_landlord_category_selection", "{=lw_selectproductio}Select production category:",
                (MenuCallbackArgs args) => { },
                GameMenu.MenuOverlayType.SettlementWithBoth,
                GameMenu.MenuFlags.None, null);

            var categories = new List<string> { "Food", "Livestock", "Village Goods", "Pack", "Mount", "War", "Noble" };
            foreach(var cat in categories)
            {
                campaignStarter.AddGameMenuOption("village_landlord_category_selection", $"cat_{cat}", cat,
                (MenuCallbackArgs args) => 
                { 
                     if (cat == "Food") return true;
                     if (GlobalSettings.Instance == null) return true;
                     if (cat == "Livestock") return GlobalSettings.Instance.AllowLivestock;
                     if (cat == "Village Goods") return GlobalSettings.Instance.AllowVillageGoods;
                     if (cat == "Pack") return GlobalSettings.Instance.AllowPack;
                     if (cat == "Mount") return GlobalSettings.Instance.AllowMounts;
                     if (cat == "War") return GlobalSettings.Instance.AllowWarMounts;
                     if (cat == "Noble") return GlobalSettings.Instance.AllowNobleMounts;
                     return true;
                },
                (MenuCallbackArgs args) =>
                {
                    _selectedCategory = cat;
                    GameMenu.SwitchToMenu("village_landlord_item_selection");
                }, false, -1, false);
            }

            campaignStarter.AddGameMenuOption("village_landlord_category_selection", "leave_cat", "{=lw_back}Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village_landlord_slot_selection"); }, true, -1, false);


            // Item Selection Menu (Dynamic)
            campaignStarter.AddGameMenu("village_landlord_item_selection", "{=lw_selectitemtopro}Select item to produce:",
                (MenuCallbackArgs args) => { },
                GameMenu.MenuOverlayType.SettlementWithBoth,
                GameMenu.MenuFlags.None, null);

            
            // Register options for ALL categories
            var allValidItems = GetItemsByCategory("Food")
                .Concat(GetItemsByCategory("Livestock"))
                .Concat(GetItemsByCategory("Village Goods"))
                .Concat(GetItemsByCategory("Pack"))
                .Concat(GetItemsByCategory("Mount"))
                .Concat(GetItemsByCategory("War"))
                .Concat(GetItemsByCategory("Noble"))
                .Distinct()
                .ToList();

            foreach (var item in allValidItems)
            {
                campaignStarter.AddGameMenuOption("village_landlord_item_selection", $"crop_{item.StringId}", $"{{=lw_investinitemnam}}Invest in {item.Name}",
                    (MenuCallbackArgs args) =>
                    {
                        string itemCat = "Food";
                        if (item.ItemType == ItemObject.ItemTypeEnum.Animal) itemCat = "Livestock";
                        if (item.ItemType == ItemObject.ItemTypeEnum.Goods) itemCat = "Village Goods"; // Assume Goods if not Animal/Horse/Food, refinement below
                        if (item.ItemType == ItemObject.ItemTypeEnum.Horse)
                        {
                            if (item.HorseComponent.IsPackAnimal) itemCat = "Pack";
                            else if (item.Tier < ItemObject.ItemTiers.Tier4 && !item.ItemCategory.StringId.ToLower().Contains("war")) itemCat = "Mount";
                            else if (item.Tier >= ItemObject.ItemTiers.Tier6) itemCat = "Noble";
                            else itemCat = "War";
                        }
                        
                         // Strict Refinement matches GetItemsByCategory logic
                        if (itemCat == "Village Goods")
                        {
                        }

                        if (item.IsFood && !item.IsAnimal) itemCat = "Food";
                        
                        // Handle Overlaps (e.g. Meat is Food but we excluded it in query, if present handle it)
                        
                        // Re-verify category against our query Logic to be safe
                        if (GetItemsByCategory("Livestock").Contains(item)) itemCat = "Livestock";
                        else if (GetItemsByCategory("Village Goods").Contains(item)) itemCat = "Village Goods";
                        else if (GetItemsByCategory("Pack").Contains(item)) itemCat = "Pack";
                        else if (GetItemsByCategory("Mount").Contains(item)) itemCat = "Mount";
                        else if (GetItemsByCategory("War").Contains(item)) itemCat = "War";
                        else if (GetItemsByCategory("Noble").Contains(item)) itemCat = "Noble";
                        else if (GetItemsByCategory("Food").Contains(item)) itemCat = "Food";


                        if (itemCat != _selectedCategory) return false;

                        float eff = GetEfficiency(Settlement.CurrentSettlement, item.StringId);
                        int itemPrice = 0;
                        if (Settlement.CurrentSettlement.Village != null)
                        {
                             itemPrice = Settlement.CurrentSettlement.Village.GetItemPrice(item, MobileParty.MainParty, false);
                        }
                        
                        var plotStats = GetSlotStats(_selectedSlotIndex);
                        int totalCost = plotStats.cost + (itemPrice * GlobalSettings.Instance.InitialInvestmentItemMultiplier);

                        args.Text = new TextObject($"Invest in {item.Name} (Cost: {totalCost}g, Eff: {eff:P0})");
                        
                        // Show breakdown in tooltip
                        args.Tooltip = new TextObject($"Plot Fee: {plotStats.cost}g\nInitial Stock & Tools: {itemPrice * GlobalSettings.Instance.InitialInvestmentItemMultiplier}g ({GlobalSettings.Instance.InitialInvestmentItemMultiplier}x Item Price)");

                        if (Hero.MainHero.Gold < totalCost)
                        {
                            args.IsEnabled = false;
                            args.Tooltip = new TextObject($"Not enough gold. Need {totalCost}g.");
                        }

                        args.optionLeaveType = GameMenuOption.LeaveType.Continue;
                        return true;
                    },
                    (MenuCallbackArgs args) =>
                    {
                        int itemPrice = 0;
                        if (Settlement.CurrentSettlement.Village != null)
                        {
                             itemPrice = Settlement.CurrentSettlement.Village.GetItemPrice(item, MobileParty.MainParty, false);
                        }
                        var plotStats = GetSlotStats(_selectedSlotIndex);
                        int totalCost = plotStats.cost + (itemPrice * GlobalSettings.Instance.InitialInvestmentItemMultiplier);

                        BuyLand(Settlement.CurrentSettlement, Hero.MainHero, item.StringId, _selectedSlotIndex, totalCost);
                        GameMenu.SwitchToMenu("village");
                    }, false, -1, false);
            }

            campaignStarter.AddGameMenuOption("village_landlord_item_selection", "leave_item", "{=lw_back}Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village_landlord_category_selection"); }, true, -1, false);


            // Change Production Menu

            
            campaignStarter.AddGameMenu("village_landlord_change_prod_cat", "{=lw_selectnewcatego}Select new category:",
                (MenuCallbackArgs args) => { }, GameMenu.MenuOverlayType.SettlementWithBoth, GameMenu.MenuFlags.None, null);

             foreach(var cat in categories)
            {
                campaignStarter.AddGameMenuOption("village_landlord_change_prod_cat", $"change_cat_{cat}", cat,
                (MenuCallbackArgs args) => 
                { 
                     if (cat == "Food") return true;
                     if (GlobalSettings.Instance == null) return true;
                     if (cat == "Livestock") return GlobalSettings.Instance.AllowLivestock;
                     if (cat == "Village Goods") return GlobalSettings.Instance.AllowVillageGoods;
                     if (cat == "Pack") return GlobalSettings.Instance.AllowPack;
                     if (cat == "Mount") return GlobalSettings.Instance.AllowMounts;
                     if (cat == "War") return GlobalSettings.Instance.AllowWarMounts;
                     if (cat == "Noble") return GlobalSettings.Instance.AllowNobleMounts;
                     return true;
                },
                (MenuCallbackArgs args) =>
                {
                    _selectedCategory = cat;
                    GameMenu.SwitchToMenu("village_landlord_change_prod_item");
                }, false, -1, false);
            }
             campaignStarter.AddGameMenuOption("village_landlord_change_prod_cat", "leave_cp_cat", "{=lw_cancel}Cancel",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village_landlord_manage"); }, true, -1, false);

            campaignStarter.AddGameMenu("village_landlord_change_prod_item", "{=lw_selectnewproduc}Select new production (Cost: {COST}g):",
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
                            else if (item.Tier >= ItemObject.ItemTiers.Tier6) itemCat = "Noble";
                            else itemCat = "War";
                        }
                        if (item.IsFood && !item.IsAnimal) itemCat = "Food";
                        
                        if (GetItemsByCategory("Livestock").Contains(item)) itemCat = "Livestock";
                        else if (GetItemsByCategory("Village Goods").Contains(item)) itemCat = "Village Goods";
                        else if (GetItemsByCategory("Pack").Contains(item)) itemCat = "Pack";
                        else if (GetItemsByCategory("Mount").Contains(item)) itemCat = "Mount";
                        else if (GetItemsByCategory("War").Contains(item)) itemCat = "War";
                        else if (GetItemsByCategory("Noble").Contains(item)) itemCat = "Noble";
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
                             InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_estatenowproduc}}Estate now producing {item.Name}.").ToString()));
                             GameMenu.SwitchToMenu("village_landlord_manage");
                        }
                    }, false, -1, false);
            }
            campaignStarter.AddGameMenuOption("village_landlord_change_prod_item", "leave_cp_item", "{=lw_back}Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; },
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village_landlord_change_prod_cat"); }, true, -1, false);


            // Manage Plot Entry (Existing)
            campaignStarter.AddGameMenuOption("village", "village_landlord_manage_entry", "{=lw_manageestate}Manage Estate",
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
            campaignStarter.AddGameMenu("village_landlord_select_manage_plot", "{=lw_selectaplottoma}Select a plot to manage:",
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

                        args.Text = new TextObject($"Manage {name}");
                        args.Tooltip = new TextObject($"Currently Producing: {prodName}");
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
            
            campaignStarter.AddGameMenuOption("village_landlord_select_manage_plot", "leave_select", "{=lw_back}Back",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Leave; return true; }, 
                (MenuCallbackArgs args) => { GameMenu.SwitchToMenu("village"); }, true, -1, false);

            // Manage Plot Menu Details (Modified Change Prod Link)
            campaignStarter.AddGameMenu("village_landlord_manage", "{=lw_manageyourestat}Manage your estate:",
                (MenuCallbackArgs args) => { 
                    if (_currentManagedPlot != null) {
                         string name = GetSlotName(_currentManagedPlot.SlotIndex);
                         args.MenuTitle = new TextObject($"Manage {name}");
                    }
                },
                GameMenu.MenuOverlayType.SettlementWithBoth,
                GameMenu.MenuFlags.None, null);

            campaignStarter.AddGameMenuOption("village_landlord_manage", "change_production", "{=lw_changeproductio}Change Production",
                (MenuCallbackArgs args) => { args.optionLeaveType = GameMenuOption.LeaveType.Trade; return true; },
                (MenuCallbackArgs args) =>
                {
                     if (_currentManagedPlot == null) return;
                     GameMenu.SwitchToMenu("village_landlord_change_prod_cat");
                }, false, -1, false);

            // Upgrade Guardhouse (Existing)
            campaignStarter.AddGameMenuOption("village_landlord_manage", "upgrade_guardhouse", "{=lw_upgradeguardhou}Upgrade Guardhouse",
                (MenuCallbackArgs args) =>
                {
                    var plot = _currentManagedPlot;
                    if (plot == null) return false;
                    
                    int cost = (plot.GuardhouseLevel + 1) * GlobalSettings.Instance.BaseUpgradeCost;
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
                    int cost = (plot.GuardhouseLevel + 1) * GlobalSettings.Instance.BaseUpgradeCost;
                    GiveGoldAction.ApplyForCharacterToSettlement(Hero.MainHero, Settlement.CurrentSettlement, cost, false);
                    plot.GuardhouseLevel++;
                    InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_guardhouseupgra}}Guardhouse upgraded to Level {plot.GuardhouseLevel}.").ToString()));
                    GameMenu.SwitchToMenu("village_landlord_manage");
                }, false, -1, false);

            // Toggle Yield Split (Existing)
            campaignStarter.AddGameMenuOption("village_landlord_manage", "toggle_yield", "{=lw_toggleyieldspli}Toggle Yield Split",
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
                    InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_yieldsplitsetto}}Yield Split set to {plot.StashYieldPct}% Stash").ToString()));
                    GameMenu.SwitchToMenu("village_landlord_manage");
                }, false, -1, false);

            // Station Guards (Existing)
            campaignStarter.AddGameMenuOption("village_landlord_manage", "station_guards", "{=lw_stationguards}Station Guards",
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
            campaignStarter.AddGameMenuOption("village_landlord_manage", "open_warehouse", "{=lw_openwarehouse}Open Warehouse",
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
            campaignStarter.AddGameMenuOption("village_landlord_manage", "leave_manage", "{=lw_back}Back",
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
                          () => { BuyLand(settlement, Hero.MainHero, "grain", slot, GetSlotStats(slot).cost); }, null));
                 }
            }

            // AI Lord Buying Logic
            if (party.LeaderHero != null && party.LeaderHero != Hero.MainHero && party.LeaderHero.IsLord)
            {
                if (party.LeaderHero.Gold > GlobalSettings.Instance.AIPlotBuyThreshold && !party.LeaderHero.MapFaction.IsAtWarWith(settlement.MapFaction))
                {
                    int slot = GetFirstFreeSlotIndex(settlement);
                    if (slot != -1)
                    {

                        List<string> validCats = new List<string> { "Food" };
                        if (GlobalSettings.Instance != null)
                        {
                            if (GlobalSettings.Instance.AllowLivestock) validCats.Add("Livestock");
                            if (GlobalSettings.Instance.AllowVillageGoods) validCats.Add("Village Goods");
                            if (GlobalSettings.Instance.AllowPack) validCats.Add("Pack");
                            if (GlobalSettings.Instance.AllowMounts) validCats.Add("Mount");
                            if (GlobalSettings.Instance.AllowWarMounts) validCats.Add("War");
                            if (GlobalSettings.Instance.AllowNobleMounts) validCats.Add("Noble");
                        }

                        string chosenCat = validCats[MBRandom.RandomInt(validCats.Count)];
                        var options = GetItemsByCategory(chosenCat);
                        if (options.Count > 0)
                        {

                            ItemObject bestCrop = null;
                            float bestScore = -1f;

                            foreach (var op in options)
                            {
                                float eff = GetEfficiency(settlement, op.StringId);
                                float val = op.Value * eff;
                                
                                // Random Jitter (+/- 10%) so they don't ALL pick the exact same thing always
                                val *= (0.9f + (MBRandom.RandomFloat * 0.2f));

                                if (val > bestScore)
                                {
                                    bestScore = val;
                                    bestCrop = op;
                                }
                            }

                            if (bestCrop != null)
                            {

                                int itemPrice = bestCrop.Value; 
                                int totalAICost = GetSlotStats(slot).cost + (itemPrice * GlobalSettings.Instance.InitialInvestmentItemMultiplier);

                                if (party.LeaderHero.Gold >= totalAICost)
                                {
                                    BuyLand(settlement, party.LeaderHero, bestCrop.StringId, slot, totalAICost);
                                }

                                try {
                                    if (GlobalSettings.Instance.DebugMode) 
                                        _logger.LogInformation($"[Landlord AI Decision] {party.LeaderHero.Name} bought land in {settlement.Name}. Picked {bestCrop.Name} (Score: {bestScore:F1})");
                                } catch {}
                            }
                        }
                    }
                }
            }
        }

        // Caching for ModifyVillageGold
        private static System.Reflection.FieldInfo _villageGoldField;
        private static bool _villageGoldInitialized = false;

        private void ModifyVillageGold(Village village, int amount)
        {
            try
            {
                if (!_villageGoldInitialized)
                {
                    _villageGoldField = typeof(Village).GetField("_gold", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
                    _villageGoldInitialized = true;
                }

                if (_villageGoldField != null)
                {
                    int current = (int)_villageGoldField.GetValue(village);
                    _villageGoldField.SetValue(village, current + amount);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to modify village gold");
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


                int currentHour = (int)CampaignTime.Now.CurrentHourInDay;

                if (currentHour != 22) 
                {
                    if (debug) _logger.LogDebug($"[Landlord Debug] Skipping tick at hour {CampaignTime.Now.CurrentHourInDay} (Int: {currentHour})");
                    return;
                }

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

                int playerTotalRevenue = 0;
                int playerTotalPlots = 0;

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

                        float actualYield = GlobalSettings.Instance.BaseYieldMultiplier * yieldMult * eff;

                        // Apply Manual Labor Boost (from HonestWork module)
                        if (Campaign.Current != null)
                        {
                            var laborBehavior = Campaign.Current.GetCampaignBehavior<VillageLaborBehavior>();
                            if (laborBehavior != null)
                            {
                                float boostFactor = laborBehavior.GetBoostMultiplier(settlement);
                                if (boostFactor > 1.0f)
                                {
                                    actualYield *= boostFactor;
                                    if (GlobalSettings.Instance.DebugMode)
                                        _logger.LogInformation($"[Landlord Debug] Applied {boostFactor}x Manual Labor Boost to {settlement.Name}. New Yield: {actualYield:F1}");
                                }
                            }
                        }

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

                            int stashCount = (int)MathF.Floor(toStashAmt);
                            int sellCount = (int)MathF.Floor(toSellAmt);

                            // Handle fractional carryover conceptually by rounding if total > 1
                            if (stashCount == 0 && toStashAmt >= 0.5f) stashCount = 1;
                            if (sellCount == 0 && toSellAmt >= 0.5f) sellCount = 1;

                            if (plot.Stash.Sum(i => i.Amount) + stashCount > GetStashCap(plot.GuardhouseLevel))
                            {
                                sellCount += stashCount;
                                stashCount = 0;
                            }

                            if (stashCount > 0)
                            {
                                plot.Stash.AddToCounts(cropItem, stashCount);
                            }

                            int totalRevenue = 0;
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

                                totalRevenue = sellCount * pricePerItem;
                                
                                // 2. Add to Village Inventory
                                settlement.ItemRoster.AddToCounts(cropItem, sellCount);

                                    // 3. Pay the Owner
                                    if (plot.Owner != null && plot.Owner.IsAlive)
                                    {
                                        int profit = (int)(totalRevenue * 0.25f);
                                        plot.LastDailyIncome = profit;

                                        try
                                        {
                                            // Liquidity Injection & Stimulus
                                            if (settlement.Village != null)
                                            {
                                                int currentGold = settlement.Village.Gold;
                                                int deficit = (profit > currentGold) ? (profit - currentGold) : 0;
                                                int stimulus = (int)(profit * GlobalSettings.Instance.VillageStimulusRatio);
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

                                            if (profit > 0)
                                            {
                                                plot.Owner.AddSkillXp(DefaultSkills.Trade, profit * 0.5f);
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
                                     // Aggregate for User Notification
                                     playerTotalPlots++;
                                     playerTotalRevenue += totalRevenue;
                                     
                                     // Detailed log for debugging
                                     if (debug) 
                                     {
                                         int stashTotal = plot.Stash.Sum(i => i.Amount);
                                         var msg = $"[Estate] {settlement.Name}: Produced {actualYield:F1}. Sold {sellCount} for {totalRevenue}g. (Garrison: {foodNeeded:F1}, Stashed: {stashCount})";
                                         _logger.LogInformation($"[Landlord Notification] {msg}"); 
                                     }
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
                    
                    float totalHearthBonus = 0f;
                    foreach(var plot in plots)
                    {
                        if (plot.SlotIndex == 0) totalHearthBonus += GlobalSettings.Instance.HearthBonusNormal;
                        else if (plot.SlotIndex == 1) totalHearthBonus += GlobalSettings.Instance.HearthBonusGood;
                        else if (plot.SlotIndex == 2) totalHearthBonus += GlobalSettings.Instance.HearthBonusGreat;
                    }
                    
                    if (totalHearthBonus > 0)
                    {
                        ModifyHearths(settlement.Village, totalHearthBonus);
                        if (debug) _logger.LogInformation($"[Landlord Debug] Applied +{totalHearthBonus:F1} hearths to {settlement.Name} from plot bonuses.");
                    }
                }
                
                // Display Daily Summary to Player
                if (playerTotalPlots > 0)
                {
                    try 
                    {
                        string summary = $"[Landlord] Daily Report: Earned {playerTotalRevenue}g from {playerTotalPlots} estates.";
                        InformationManager.DisplayMessage(new InformationMessage(summary, Color.FromUint(0xFFFFD700))); // Gold color
                    } 
                    catch {
                         // Fallback if Color.FromUint fails or is missing
                         string summary = $"[Landlord] Daily Report: Earned {playerTotalRevenue}g from {playerTotalPlots} estates.";
                         InformationManager.DisplayMessage(new InformationMessage(summary));
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
            if (index == 0) return (GlobalSettings.Instance.NormalPlotCost, GlobalSettings.Instance.NormalYield);
            if (index == 1) return (GlobalSettings.Instance.GoodPlotCost, GlobalSettings.Instance.GoodYield);
            return (GlobalSettings.Instance.GreatPlotCost, GlobalSettings.Instance.GreatYield);
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
            if (settlement.Village != null) baseEff += (settlement.Village.Hearth * 0.00002f);
            
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

            return baseEff;
        }

        private void BuyLand(Settlement settlement, Hero buyer, string productionId, int slotIndex, int totalCost)
        {
            if (!IsSlotFree(settlement, slotIndex)) return;
            // var stats = GetSlotStats(slotIndex); // Cost passed in
            if (buyer.Gold < totalCost) return;

            GiveGoldAction.ApplyForCharacterToSettlement(buyer, settlement, totalCost, false);

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
            InformationManager.DisplayMessage(new InformationMessage(new TaleWorlds.Localization.TextObject($"{{=lw_buyernamebought}}{buyer.Name} bought land in {settlement.Name}").ToString()));
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



        private int GetGuardCap(int level)
        {
            return level switch { 1 => GlobalSettings.Instance.GuardCapLvl1, 2 => GlobalSettings.Instance.GuardCapLvl2, 3 => GlobalSettings.Instance.GuardCapLvl3, _ => 0 };
        }

        private int GetStashCap(int level)
        {
            return level switch { 1 => GlobalSettings.Instance.StashCapLvl1, 2 => GlobalSettings.Instance.StashCapLvl2, 3 => GlobalSettings.Instance.StashCapLvl3, _ => 100 };
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
                    int cost = (plot.GuardhouseLevel + 1) * GlobalSettings.Instance.BaseUpgradeCost;
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
