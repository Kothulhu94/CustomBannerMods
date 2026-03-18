--- SOURCE: class_helpers_1_1_inventory_screen_helper.html ---

Helpers.InventoryScreenHelper Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [InventoryMode](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5) {     [Default](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5a7a1920d61156abc05a60135aefe8bc67) ,     [Trade](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5a5f390d80b20daad8f5d2f483fb0ae9d8) ,     [Loot](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5a6794e7b16f55b952b04e118ec3a7cc78) ,     [Stash](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5adc222b6dc104054f24d13f83636185d6) ,     [Warehouse](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5a6416e8cb5fc0a208d94fa7f5a300dbc4)   } |
| enum | [InventoryItemType](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40) {     [None](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a6adf97f83acf6453d4a6a4b1070f3754) = 0x0 ,     [Weapon](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a18c83669920215a818638ad0e5421e4b) = 0x1 ,     [Shield](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a970da5f1f2e32aeb9e488dd017160ab4) = 0x2 ,     [HeadArmor](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a71203c5a2afba5ec7534a2fd00abda52) = 0x4 ,     [BodyArmor](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a83939600fb52bedcfaa188694bb9905f) = 0x8 ,     [LegArmor](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40ac9093c346819e0748ad59b714a5ff372) = 0x10 ,     [HandArmor](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a49e0fc1e970ef9330bd5faffae326fd4) = 0x20 ,     [Horse](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a38069b4eb64e325cb7ac65bd641b2188) = 0x40 ,     [HorseHarness](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a4c2ce960d67fa946e5de7d3a1748ac47) = 0x80 ,     [Goods](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a9b2cfa29e7882e3649d5f3b9921afdb0) = 0x100 ,     [Book](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a2b1f94ef23b79bf90eb891cae1df7a90) = 0x200 ,     [Animal](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a161e7ce7bfdc89ab4b9f52c1d4c94212) = 0x400 ,     [Cape](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a679355c6c670c65aeddd96d9724159f2) = 0x800 ,     [Banner](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a6ff29916f99fff9d2494d28e721ae77e) = 0x1000 ,     [HorseCategory](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40acb77f4d46786fef20e4778f718940fd0) = Horse | HorseHarness ,     [Armors](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a975eacacebe9dc402dffa3eae65936c1) = HeadArmor | BodyArmor | LegArmor | HandArmor | Cape ,     [Equipable](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40a6503c037a813530c7729e1563e5c2fab) = Weapon | Shield | HeadArmor | BodyArmor | LegArmor | HandArmor | Horse | HorseHarness | Cape | Banner ,     [All](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40ab1c94ca2fbc3e78fc30069c8d0f01680) = Weapon | BodyArmor | Shield | HeadArmor | Goods | Horse | HorseHarness | LegArmor | HandArmor | Book | Animal | Cape   } |
| enum | [InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) {     [None](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0a6adf97f83acf6453d4a6a4b1070f3754) = -1 ,     [All](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0ab1c94ca2fbc3e78fc30069c8d0f01680) = 0 ,     [Armors](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0a975eacacebe9dc402dffa3eae65936c1) = 1 ,     [Weapon](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0a18c83669920215a818638ad0e5421e4b) ,     [Shield](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0a970da5f1f2e32aeb9e488dd017160ab4) ,     [HorseCategory](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0acb77f4d46786fef20e4778f718940fd0) ,     [Goods](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0a9b2cfa29e7882e3649d5f3b9921afdb0) ,     [CategoryTypeAmount](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0afab47dcaf914c5f7240cfd9b28cac224)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [InventoryFinishDelegate](class_helpers_1_1_inventory_screen_helper.html#a70ec19f8cc9604ac9362b93ecfc361b5) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [InventoryState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_inventory_state.html) | [GetActiveInventoryState](class_helpers_1_1_inventory_screen_helper.html#a879f245e2abf782448dbb3cc8b387441) () |
| static void | [PlayerAcceptTradeOffer](class_helpers_1_1_inventory_screen_helper.html#a381b5322fb88df94067071a59b476160) () |
| static void | [CloseScreen](class_helpers_1_1_inventory_screen_helper.html#a4e1a1e1ffcfad0acb3c2a4ebfec14d6f) (bool fromCancel) |
| static void | [OpenScreenAsInventoryOfSubParty](class_helpers_1_1_inventory_screen_helper.html#a853758baeb36a8ceffc5e39edf1a1d4c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) rightParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) leftParty, Action doneLogicExtrasDelegate) |
| static void | [OpenScreenAsInventoryForCraftedItemDecomposition](class_helpers_1_1_inventory_screen_helper.html#a4ab39806fd069c80a9a7e527df496d1c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, Action doneLogicExtrasDelegate) |
| static void | [OpenScreenAsInventoryOf](class_helpers_1_1_inventory_screen_helper.html#a948ac3e1a0f24ae38079fa7a0e19fecb) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| static void | [OpenScreenAsInventoryOf](class_helpers_1_1_inventory_screen_helper.html#a53902ed6467a61df15f73a63d665880c) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) rightParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) leftParty) |
| static void | [OpenScreenAsInventoryOf](class_helpers_1_1_inventory_screen_helper.html#aba35f8f2561e097ebecffb45e07c5a70) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) rightParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) leftParty, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftRosterName=null, InventoryLogic.CapacityData capacityData=null, Action doneLogicExtrasDelegate=null) |
| static void | [OpenScreenAsInventory](class_helpers_1_1_inventory_screen_helper.html#a07bfd4640ffe4e86ef849fd2b932214a) (Action doneLogicExtrasDelegate=null) |
| static void | [OpenCampaignBattleLootScreen](class_helpers_1_1_inventory_screen_helper.html#a7ea875595eaab27da3ae0c7c5ea89394) () |
| static void | [OpenScreenAsLoot](class_helpers_1_1_inventory_screen_helper.html#af8b879bd4ea28bbdedae56558b2bb6c8) (Dictionary< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) > itemRostersToLoot) |
| static void | [OpenScreenAsStash](class_helpers_1_1_inventory_screen_helper.html#a4967a40973bb1dbe7961db1f1aaa4fc0) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) stash) |
| static void | [OpenScreenAsWarehouse](class_helpers_1_1_inventory_screen_helper.html#a9ad38370b1e233492942a2fb3dbe0f29) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) stash, InventoryLogic.CapacityData otherSideCapacity) |
| static void | [OpenScreenAsReceiveItems](class_helpers_1_1_inventory_screen_helper.html#a96f58ddd5396d34a53f66beb4d960887) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) items, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftRosterName, Action doneLogicDelegate=null) |
| static void | [OpenTradeWithCaravanOrAlleyParty](class_helpers_1_1_inventory_screen_helper.html#a9fbb4db9cec1770e1e6947b4cb05b473) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) caravan, [InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) merchantItemType=[InventoryCategoryType.None](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0a6adf97f83acf6453d4a6a4b1070f3754)) |
| static void | [ActivateTradeWithCurrentSettlement](class_helpers_1_1_inventory_screen_helper.html#a62e16098401fd8e29f3652dfdd040633) () |
| static void | [OpenScreenAsTrade](class_helpers_1_1_inventory_screen_helper.html#a531f81eaa5f7124c6dcc23915c1fc3fc) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) leftRoster, [SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) settlementComponent, [InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) merchantItemType=[InventoryCategoryType.None](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0a6adf97f83acf6453d4a6a4b1070f3754), Action doneLogicExtrasDelegate=null) |
| static [InventoryItemType](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40) | [GetInventoryItemTypeOfItem](class_helpers_1_1_inventory_screen_helper.html#abf2d4b346eac428766c5e806a2fcb3fd) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |

Member Enumeration Documentation
--------------------------------

[◆](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5)InventoryMode
--------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [Helpers.InventoryScreenHelper.InventoryMode](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5) |

| Enumerator | |
| --- | --- |
| Default |  |
| Trade |  |
| Loot |  |
| Stash |  |
| Warehouse |  |

[◆](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40)InventoryItemType
------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [Helpers.InventoryScreenHelper.InventoryItemType](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40) |

| Enumerator | |
| --- | --- |
| None |  |
| Weapon |  |
| Shield |  |
| HeadArmor |  |
| BodyArmor |  |
| LegArmor |  |
| HandArmor |  |
| Horse |  |
| HorseHarness |  |
| Goods |  |
| Book |  |
| Animal |  |
| Cape |  |
| Banner |  |
| HorseCategory |  |
| Armors |  |
| Equipable |  |
| All |  |

[◆](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0)InventoryCategoryType
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [Helpers.InventoryScreenHelper.InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) |

| Enumerator | |
| --- | --- |
| None |  |
| All |  |
| Armors |  |
| Weapon |  |
| Shield |  |
| HorseCategory |  |
| Goods |  |
| CategoryTypeAmount |  |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_inventory_screen_helper.html#a70ec19f8cc9604ac9362b93ecfc361b5)InventoryFinishDelegate()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void Helpers.InventoryScreenHelper.InventoryFinishDelegate | ( |  | ) |  |

[◆](class_helpers_1_1_inventory_screen_helper.html#a879f245e2abf782448dbb3cc8b387441)GetActiveInventoryState()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [InventoryState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_inventory_state.html) Helpers.InventoryScreenHelper.GetActiveInventoryState | ( |  | ) |  | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a381b5322fb88df94067071a59b476160)PlayerAcceptTradeOffer()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.PlayerAcceptTradeOffer | ( |  | ) |  | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a4e1a1e1ffcfad0acb3c2a4ebfec14d6f)CloseScreen()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.CloseScreen | ( | bool | *fromCancel* | ) |  | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a853758baeb36a8ceffc5e39edf1a1d4c)OpenScreenAsInventoryOfSubParty()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsInventoryOfSubParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *rightParty*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *leftParty*, | |  |  | Action | *doneLogicExtrasDelegate* ) | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a4ab39806fd069c80a9a7e527df496d1c)OpenScreenAsInventoryForCraftedItemDecomposition()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsInventoryForCraftedItemDecomposition | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | Action | *doneLogicExtrasDelegate* ) | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a948ac3e1a0f24ae38079fa7a0e19fecb)OpenScreenAsInventoryOf() [1/3]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsInventoryOf | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* ) | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a53902ed6467a61df15f73a63d665880c)OpenScreenAsInventoryOf() [2/3]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsInventoryOf | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *rightParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *leftParty* ) | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#aba35f8f2561e097ebecffb45e07c5a70)OpenScreenAsInventoryOf() [3/3]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsInventoryOf | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *rightParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *leftParty*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftRosterName* = null, | |  |  | InventoryLogic.CapacityData | *capacityData* = null, | |  |  | Action | *doneLogicExtrasDelegate* = null ) | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a07bfd4640ffe4e86ef849fd2b932214a)OpenScreenAsInventory()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsInventory | ( | Action | *doneLogicExtrasDelegate* = null | ) |  | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a7ea875595eaab27da3ae0c7c5ea89394)OpenCampaignBattleLootScreen()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenCampaignBattleLootScreen | ( |  | ) |  | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#af8b879bd4ea28bbdedae56558b2bb6c8)OpenScreenAsLoot()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsLoot | ( | Dictionary< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) > | *itemRostersToLoot* | ) |  | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a4967a40973bb1dbe7961db1f1aaa4fc0)OpenScreenAsStash()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsStash | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *stash* | ) |  | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a9ad38370b1e233492942a2fb3dbe0f29)OpenScreenAsWarehouse()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsWarehouse | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *stash*, | |  |  | InventoryLogic.CapacityData | *otherSideCapacity* ) | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a96f58ddd5396d34a53f66beb4d960887)OpenScreenAsReceiveItems()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsReceiveItems | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *items*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftRosterName*, | |  |  | Action | *doneLogicDelegate* = null ) | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a9fbb4db9cec1770e1e6947b4cb05b473)OpenTradeWithCaravanOrAlleyParty()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenTradeWithCaravanOrAlleyParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *caravan*, | |  |  | [InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) | *merchantItemType* = [InventoryCategoryType::None](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0a6adf97f83acf6453d4a6a4b1070f3754) ) | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a62e16098401fd8e29f3652dfdd040633)ActivateTradeWithCurrentSettlement()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.ActivateTradeWithCurrentSettlement | ( |  | ) |  | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#a531f81eaa5f7124c6dcc23915c1fc3fc)OpenScreenAsTrade()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void Helpers.InventoryScreenHelper.OpenScreenAsTrade | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *leftRoster*, | |  |  | [SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) | *settlementComponent*, | |  |  | [InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) | *merchantItemType* = [InventoryCategoryType::None](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0a6adf97f83acf6453d4a6a4b1070f3754), | |  |  | Action | *doneLogicExtrasDelegate* = null ) | | static |

[◆](class_helpers_1_1_inventory_screen_helper.html#abf2d4b346eac428766c5e806a2fcb3fd)GetInventoryItemTypeOfItem()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [InventoryItemType](class_helpers_1_1_inventory_screen_helper.html#a83f8c6bcb5a3abc23816d8b143ad3b40) Helpers.InventoryScreenHelper.GetInventoryItemTypeOfItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  | | static |

