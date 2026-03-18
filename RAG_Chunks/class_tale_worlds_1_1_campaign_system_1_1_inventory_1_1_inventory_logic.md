--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html ---

TaleWorlds.CampaignSystem.Inventory.InventoryLogic Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [CapacityData](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic_1_1_capacity_data.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [TransferType](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#afce1fcf794419a4ca37da2ec6deb0d3c) {     [Neutral](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#afce1fcf794419a4ca37da2ec6deb0d3cae9bb5320b3890b6747c91b5a71ae5a01) ,     [Sell](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#afce1fcf794419a4ca37da2ec6deb0d3ca3068c5a98c003498f1fec0c489212e8b) ,     [Buy](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#afce1fcf794419a4ca37da2ec6deb0d3ca831a28f1e8df07c553fcd59546465d13)   } |
| enum | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) : int {     [OtherInventory](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507fa0a74ca48a6f0d6056feb867f3383e316) = 0 ,     [PlayerInventory](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507fae824837ba609820b6233e969a989ee73) = 1 ,     [CivilianEquipment](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507fa0601656ad1c3b98f60f057dbb2df9265) = 2 ,     [BattleEquipment](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507fa47b82435cebbfaf8425bb67f87661e49) = 3 ,     [StealthEquipment](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507fa33502c3a3c8e5dfe3ce199d263fcecc8) = 4 ,     [None](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507fa6adf97f83acf6453d4a6a4b1070f3754) = -1   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [AfterResetDelegate](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a68086de6d865b683b6d03847b9660026) ([InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aa5bc01327dbb5f807ff3e9284a4de602) inventoryLogic, bool fromCancel) |
| delegate void | [TotalAmountChangeDelegate](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a4ab2ddcd1596181ff6285c8da7b2ab24) (int newTotalAmount) |
| delegate void | [ProcessResultListDelegate](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abfeadd4a39b19dbdc7c6d94b8af3e16c) ([InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aa5bc01327dbb5f807ff3e9284a4de602) inventoryLogic, List< [TransferCommandResult](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_transfer_command_result.html) > results) |
|  | [InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aa5bc01327dbb5f807ff3e9284a4de602) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) ownerParty, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) ownerCharacter, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) merchantParty) |
|  | [InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a47a2aadf2717b6c169c55fca1084034f) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) merchantParty) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af2f86a166b15ad32b7c2c36b7027c88b) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) leftItemRoster, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isTrading, bool isSpecialActionsPermitted, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) initialCharacterOfRightRoster, [InventoryScreenHelper.InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) merchantItemType, [IMarketData](interface_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_i_market_data.html) marketData, bool useBasePrices, [InventoryScreenHelper.InventoryMode](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5) inventoryMode, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftRosterName=null, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftMemberRoster=null, [CapacityData](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic_1_1_capacity_data.html) otherSideCapacityData=null) |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ac54bddf0771bbc6ddb8181b44300627e) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) leftItemRoster, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) rightItemRoster, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) rightMemberRoster, bool isTrading, bool isSpecialActionsPermitted, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) initialCharacterOfRightRoster, [InventoryScreenHelper.InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) merchantItemType, [IMarketData](interface_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_i_market_data.html) marketData, bool useBasePrices, [InventoryScreenHelper.InventoryMode](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5) inventoryMode, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) leftRosterName=null, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) leftMemberRoster=null, [CapacityData](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic_1_1_capacity_data.html) otherSideCapacityData=null) |
| int | [GetItemTotalPrice](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3de88fec009af0a0be2bc134e325c69f) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, int absStockChange, out int lastPrice, bool isBuying) |
| void | [SetPlayerAcceptTraderOffer](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a238a1e6b25e040619909f778fd7e591b) () |
| bool | [DoneLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a8e8dc477f8b73f808009ae2937a99215) () |
| List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > | [GetBoughtItems](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af38437205a5e66b74efb921dce20c8b5) () |
| List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > | [GetSoldItems](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aac69d35435e49bc0f7adc099080ad3d5) () |
| bool | [CanInventoryCapacityIncrease](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abe0b00e0539f216c94351960d5ccb85f) ([InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) side) |
| bool | [GetCanItemIncreaseInventoryCapacity](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a94fc72f1b5a6180d024c686f664cfa0c) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| float | [GetAveragePriceFactorItemCategory](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a37de9327c90eed2c86c624fd092d60c7) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) category) |
| bool | [IsThereAnyChanges](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#add15e200c175e3dac3ed6e69fa5502f6) () |
| void | [Reset](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ab7482b2025514c11a5e4d603fdc3281b) (bool fromCancel) |
| bool | [CanPlayerCompleteTransaction](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a04559c39269618709eacc5f7e6e33704) () |
| bool | [CanSlaughterItem](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ad3e30e1ffdbd313823f93982b33097b9) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) element, [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) sideOfItem) |
| bool | [IsSlaughterable](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aba04a3a5a3606bea4ad83cacb75007d7) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| bool | [CanDonateItem](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a9058ade92d3bd2a552df4eecd9b35feb) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) element, [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) sideOfItem) |
| bool | [IsDonatable](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a918a6196912cb3ea47dbae4da71ef202) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| void | [SetInventoryListener](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a1ecf37138f5beffcb6f4243225644df6) ([InventoryListener](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a6cd355e9709b01efb2ff3707138725c5) inventoryListener) |
| int | [GetItemPrice](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af826a5c735ef7827bdaf6b3b5fa73ad2) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) equipmentElement, bool isBuying=false) |
| int | [GetCostOfItemRosterElement](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af574eda0721eaee3d3b71e873ac38a21) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) side) |
| void | [AddTransferCommand](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af62ff319427d357af5c95b5cc887d312) ([TransferCommand](struct_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_transfer_command.html) command) |
| void | [AddTransferCommands](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ab3ed070d3fff7d74194f8f9e09477445) (IEnumerable< [TransferCommand](struct_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_transfer_command.html) > commands) |
| bool | [CheckItemRosterHasElement](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a041ce57696b26c6eaef3dd569e59ee18) ([InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) side, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) rosterElement, int number) |
| void | [SlaughterItem](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a8d413ad15a791a65aa10bd08485627c9) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement) |
| void | [DonateItem](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a8418b6281f0b90a5567a90654b9e1008) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement) |
| void | [TransferOne](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aa2dd8c650da418b231a60b0330418807) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement) |
| int | [GetElementCountOnSide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3c8a1e73c51ddce1381c32b5408ca7ae) ([InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) side) |
| IReadOnlyList< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > | [GetElementsInInitialRoster](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a619216257324de1e1b974091df301548) ([InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) side) |
| IReadOnlyList< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > | [GetElementsInRoster](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a6b9d45a14052dd8f6e834f25af2f42a2) ([InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) side) |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html)? | [FindItemFromSide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af956756fdb17f9f3f0c4c5c7b6500756) ([InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) side, [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) item) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsEquipmentSide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a0c676511a7ac16f498a28c6f66198765) ([InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) side) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [IsPreviewingItem](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a04726bb0704b0752d5f5d9e29b84375c) |
| [InventoryScreenHelper.InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) | [MerchantItemType](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a69c989d362fe7cece045d9cc388b458a) = InventoryScreenHelper.InventoryCategoryType.None |

|  |  |
| --- | --- |
| Properties | |
| bool | [DisableNetwork](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a154ef49758087ef53b13dc47e1a448fe) `[get, set]` |
| Action< int > | [TotalAmountChange](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a0dc462a20c2832cdf3b5dcad64a4dce4) `[get, set]` |
| Action | [DonationXpChange](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a5928ade259b1dfbd604aa68e69c0cf54) `[get, set]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [RightMemberRoster](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a09a1539489ae6a72d6f67753eb80b2ed) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [LeftMemberRoster](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#adb4748a9065f2dbb132cedc275846262) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [InitialEquipmentCharacter](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a146e2dc408b4ef982b264e4c164b52ad) `[get]` |
| bool | [IsTrading](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abbf2102055801d8a2a2e4b00da5a326f) `[get]` |
| bool | [IsSpecialActionsPermitted](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a4ae4a4c9f03a2efa8b3a4baafa60ecec) `[get]` |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [OwnerCharacter](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a353e6e41104cce677e5e11e2e55eb5d4) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [OwnerParty](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a00f2837a0861252221ef9539c5063d5e) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [OtherParty](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ab743f01fa5b5adb770e7d2d3d8ec1179) `[get]` |
| [IMarketData](interface_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_i_market_data.html) | [MarketData](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#acd9feafc3946b976bd91d68a05a0bc3b) `[get]` |
| [CapacityData](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic_1_1_capacity_data.html) | [OtherSideCapacityData](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ac7abcdabaf00dbda9cb1bbef28fb77a9) `[get]` |
| int | [OtherSideCurrentWeight](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a9120585cecf80d6513cce61716183290) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [LeftRosterName](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abc9b7e7a80c0873e599355c85953524a) `[get]` |
| bool | [IsDiscardDonating](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a1a25063c164a30c7d209a5c7be279a07) `[get]` |
| bool | [IsOtherPartyFromPlayerClan](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a9b64820a1badd185a71bc1fb29a5fbb9) `[get]` |
| InventoryListener | [InventoryListener](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a6cd355e9709b01efb2ff3707138725c5) `[get]` |
| int | [TotalAmount](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#acd5bdc8d8ebfcf0d5defbd9553358586) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [OppositePartyFromListener](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a9146e2b0471061d17d2af0a9021946b7) `[get]` |
| [SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) | [CurrentSettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a93b97f35e5c85ed7dcabea2aa3cd0405) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [CurrentMobileParty](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af4db75c169d8bf4ccd4934fc6ee7a317) `[get]` |
| int | [TransactionDebt](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a9375b1ccd42a7dcb11e892bd70fd79a0) `[get]` |
| float | [XpGainFromDonations](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a7d3b56205c1ba9877a9474087e49c576) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [AfterResetDelegate](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a68086de6d865b683b6d03847b9660026) | [AfterReset](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abf01e19b6f82bf812476fb27e35492b1) |
| [ProcessResultListDelegate](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abfeadd4a39b19dbdc7c6d94b8af3e16c) | [AfterTransfer](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a1bd60a00bbee7e215d40513d59a04e6a) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#afce1fcf794419a4ca37da2ec6deb0d3c)TransferType
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Inventory.InventoryLogic.TransferType](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#afce1fcf794419a4ca37da2ec6deb0d3c) |

| Enumerator | |
| --- | --- |
| Neutral |  |
| Sell |  |
| Buy |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f)InventorySide
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Inventory.InventoryLogic.InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) : int |

| Enumerator | |
| --- | --- |
| OtherInventory |  |
| PlayerInventory |  |
| CivilianEquipment |  |
| BattleEquipment |  |
| StealthEquipment |  |
| None |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aa5bc01327dbb5f807ff3e9284a4de602)InventoryLogic() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Inventory.InventoryLogic.InventoryLogic | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *ownerParty*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *ownerCharacter*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *merchantParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a47a2aadf2717b6c169c55fca1084034f)InventoryLogic() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Inventory.InventoryLogic.InventoryLogic | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *merchantParty* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a68086de6d865b683b6d03847b9660026)AfterResetDelegate()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.AfterResetDelegate | ( | [InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aa5bc01327dbb5f807ff3e9284a4de602) | *inventoryLogic*, |
|  |  | bool | *fromCancel* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a4ab2ddcd1596181ff6285c8da7b2ab24)TotalAmountChangeDelegate()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.TotalAmountChangeDelegate | ( | int | *newTotalAmount* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abfeadd4a39b19dbdc7c6d94b8af3e16c)ProcessResultListDelegate()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.ProcessResultListDelegate | ( | [InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aa5bc01327dbb5f807ff3e9284a4de602) | *inventoryLogic*, |
|  |  | List< [TransferCommandResult](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_transfer_command_result.html) > | *results* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af2f86a166b15ad32b7c2c36b7027c88b)Initialize() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.Initialize | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *leftItemRoster*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | bool | *isTrading*, |
|  |  | bool | *isSpecialActionsPermitted*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *initialCharacterOfRightRoster*, |
|  |  | [InventoryScreenHelper.InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) | *merchantItemType*, |
|  |  | [IMarketData](interface_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_i_market_data.html) | *marketData*, |
|  |  | bool | *useBasePrices*, |
|  |  | [InventoryScreenHelper.InventoryMode](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5) | *inventoryMode*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftRosterName* = null, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftMemberRoster* = null, |
|  |  | [CapacityData](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic_1_1_capacity_data.html) | *otherSideCapacityData* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ac54bddf0771bbc6ddb8181b44300627e)Initialize() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.Initialize | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *leftItemRoster*, |
|  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *rightItemRoster*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *rightMemberRoster*, |
|  |  | bool | *isTrading*, |
|  |  | bool | *isSpecialActionsPermitted*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *initialCharacterOfRightRoster*, |
|  |  | [InventoryScreenHelper.InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) | *merchantItemType*, |
|  |  | [IMarketData](interface_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_i_market_data.html) | *marketData*, |
|  |  | bool | *useBasePrices*, |
|  |  | [InventoryScreenHelper.InventoryMode](class_helpers_1_1_inventory_screen_helper.html#a12e5bf31376d13be07b635d2026905d5) | *inventoryMode*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *leftRosterName* = null, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *leftMemberRoster* = null, |
|  |  | [CapacityData](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic_1_1_capacity_data.html) | *otherSideCapacityData* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3de88fec009af0a0be2bc134e325c69f)GetItemTotalPrice()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Inventory.InventoryLogic.GetItemTotalPrice | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement*, |
|  |  | int | *absStockChange*, |
|  |  | out int | *lastPrice*, |
|  |  | bool | *isBuying* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a238a1e6b25e040619909f778fd7e591b)SetPlayerAcceptTraderOffer()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.SetPlayerAcceptTraderOffer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a8e8dc477f8b73f808009ae2937a99215)DoneLogic()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.DoneLogic | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af38437205a5e66b74efb921dce20c8b5)GetBoughtItems()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > TaleWorlds.CampaignSystem.Inventory.InventoryLogic.GetBoughtItems | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aac69d35435e49bc0f7adc099080ad3d5)GetSoldItems()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > TaleWorlds.CampaignSystem.Inventory.InventoryLogic.GetSoldItems | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abe0b00e0539f216c94351960d5ccb85f)CanInventoryCapacityIncrease()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.CanInventoryCapacityIncrease | ( | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a94fc72f1b5a6180d024c686f664cfa0c)GetCanItemIncreaseInventoryCapacity()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.GetCanItemIncreaseInventoryCapacity | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a37de9327c90eed2c86c624fd092d60c7)GetAveragePriceFactorItemCategory()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Inventory.InventoryLogic.GetAveragePriceFactorItemCategory | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *category* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#add15e200c175e3dac3ed6e69fa5502f6)IsThereAnyChanges()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.IsThereAnyChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ab7482b2025514c11a5e4d603fdc3281b)Reset()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.Reset | ( | bool | *fromCancel* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a04559c39269618709eacc5f7e6e33704)CanPlayerCompleteTransaction()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.CanPlayerCompleteTransaction | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ad3e30e1ffdbd313823f93982b33097b9)CanSlaughterItem()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.CanSlaughterItem | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *element*, |
|  |  | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) | *sideOfItem* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aba04a3a5a3606bea4ad83cacb75007d7)IsSlaughterable()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.IsSlaughterable | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a9058ade92d3bd2a552df4eecd9b35feb)CanDonateItem()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.CanDonateItem | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *element*, |
|  |  | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) | *sideOfItem* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a918a6196912cb3ea47dbae4da71ef202)IsDonatable()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.IsDonatable | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a1ecf37138f5beffcb6f4243225644df6)SetInventoryListener()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.SetInventoryListener | ( | [InventoryListener](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a6cd355e9709b01efb2ff3707138725c5) | *inventoryListener* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af826a5c735ef7827bdaf6b3b5fa73ad2)GetItemPrice()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Inventory.InventoryLogic.GetItemPrice | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *equipmentElement*, |
|  |  | bool | *isBuying* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af574eda0721eaee3d3b71e873ac38a21)GetCostOfItemRosterElement()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Inventory.InventoryLogic.GetCostOfItemRosterElement | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement*, |
|  |  | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af62ff319427d357af5c95b5cc887d312)AddTransferCommand()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.AddTransferCommand | ( | [TransferCommand](struct_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_transfer_command.html) | *command* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ab3ed070d3fff7d74194f8f9e09477445)AddTransferCommands()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.AddTransferCommands | ( | IEnumerable< [TransferCommand](struct_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_transfer_command.html) > | *commands* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a041ce57696b26c6eaef3dd569e59ee18)CheckItemRosterHasElement()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.CheckItemRosterHasElement | ( | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) | *side*, |
|  |  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *rosterElement*, |
|  |  | int | *number* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a0c676511a7ac16f498a28c6f66198765)IsEquipmentSide()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.IsEquipmentSide | ( | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) | *side* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a8d413ad15a791a65aa10bd08485627c9)SlaughterItem()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.SlaughterItem | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a8418b6281f0b90a5567a90654b9e1008)DonateItem()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.DonateItem | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#aa2dd8c650da418b231a60b0330418807)TransferOne()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Inventory.InventoryLogic.TransferOne | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3c8a1e73c51ddce1381c32b5408ca7ae)GetElementCountOnSide()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Inventory.InventoryLogic.GetElementCountOnSide | ( | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a619216257324de1e1b974091df301548)GetElementsInInitialRoster()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IReadOnlyList< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > TaleWorlds.CampaignSystem.Inventory.InventoryLogic.GetElementsInInitialRoster | ( | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a6b9d45a14052dd8f6e834f25af2f42a2)GetElementsInRoster()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IReadOnlyList< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) > TaleWorlds.CampaignSystem.Inventory.InventoryLogic.GetElementsInRoster | ( | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af956756fdb17f9f3f0c4c5c7b6500756)FindItemFromSide()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html)? TaleWorlds.CampaignSystem.Inventory.InventoryLogic.FindItemFromSide | ( | [InventorySide](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a3248d9cf23d4b8391a504df17f8f507f) | *side*, |
|  |  | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *item* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a04726bb0704b0752d5f5d9e29b84375c)IsPreviewingItem
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.IsPreviewingItem |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a69c989d362fe7cece045d9cc388b458a)MerchantItemType
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [InventoryScreenHelper.InventoryCategoryType](class_helpers_1_1_inventory_screen_helper.html#a3e0b721f4a90909e120f1a657086beb0) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.MerchantItemType = InventoryScreenHelper.InventoryCategoryType.None |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a154ef49758087ef53b13dc47e1a448fe)DisableNetwork
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.DisableNetwork | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a0dc462a20c2832cdf3b5dcad64a4dce4)TotalAmountChange
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<int> TaleWorlds.CampaignSystem.Inventory.InventoryLogic.TotalAmountChange | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a5928ade259b1dfbd604aa68e69c0cf54)DonationXpChange
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.CampaignSystem.Inventory.InventoryLogic.DonationXpChange | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a09a1539489ae6a72d6f67753eb80b2ed)RightMemberRoster
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.RightMemberRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#adb4748a9065f2dbb132cedc275846262)LeftMemberRoster
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.LeftMemberRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a146e2dc408b4ef982b264e4c164b52ad)InitialEquipmentCharacter
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.InitialEquipmentCharacter | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abbf2102055801d8a2a2e4b00da5a326f)IsTrading
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.IsTrading | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a4ae4a4c9f03a2efa8b3a4baafa60ecec)IsSpecialActionsPermitted
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.IsSpecialActionsPermitted | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a353e6e41104cce677e5e11e2e55eb5d4)OwnerCharacter
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.OwnerCharacter | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a00f2837a0861252221ef9539c5063d5e)OwnerParty
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.OwnerParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ab743f01fa5b5adb770e7d2d3d8ec1179)OtherParty
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.OtherParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#acd9feafc3946b976bd91d68a05a0bc3b)MarketData
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMarketData](interface_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_i_market_data.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.MarketData | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#ac7abcdabaf00dbda9cb1bbef28fb77a9)OtherSideCapacityData
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CapacityData](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic_1_1_capacity_data.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.OtherSideCapacityData | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a9120585cecf80d6513cce61716183290)OtherSideCurrentWeight
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Inventory.InventoryLogic.OtherSideCurrentWeight | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abc9b7e7a80c0873e599355c85953524a)LeftRosterName
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.LeftRosterName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a1a25063c164a30c7d209a5c7be279a07)IsDiscardDonating
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.IsDiscardDonating | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a9b64820a1badd185a71bc1fb29a5fbb9)IsOtherPartyFromPlayerClan
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Inventory.InventoryLogic.IsOtherPartyFromPlayerClan | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a6cd355e9709b01efb2ff3707138725c5)InventoryListener
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | InventoryListener TaleWorlds.CampaignSystem.Inventory.InventoryLogic.InventoryListener | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#acd5bdc8d8ebfcf0d5defbd9553358586)TotalAmount
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Inventory.InventoryLogic.TotalAmount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a9146e2b0471061d17d2af0a9021946b7)OppositePartyFromListener
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.OppositePartyFromListener | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a93b97f35e5c85ed7dcabea2aa3cd0405)CurrentSettlementComponent
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement_component.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.CurrentSettlementComponent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#af4db75c169d8bf4ccd4934fc6ee7a317)CurrentMobileParty
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.CurrentMobileParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a9375b1ccd42a7dcb11e892bd70fd79a0)TransactionDebt
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Inventory.InventoryLogic.TransactionDebt | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a7d3b56205c1ba9877a9474087e49c576)XpGainFromDonations
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Inventory.InventoryLogic.XpGainFromDonations | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abf01e19b6f82bf812476fb27e35492b1)AfterReset
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [AfterResetDelegate](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a68086de6d865b683b6d03847b9660026) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.AfterReset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#a1bd60a00bbee7e215d40513d59a04e6a)AfterTransfer
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ProcessResultListDelegate](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html#abfeadd4a39b19dbdc7c6d94b8af3e16c) TaleWorlds.CampaignSystem.Inventory.InventoryLogic.AfterTransfer |

