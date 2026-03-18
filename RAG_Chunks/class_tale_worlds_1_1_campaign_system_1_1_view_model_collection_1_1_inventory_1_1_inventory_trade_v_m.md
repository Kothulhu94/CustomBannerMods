--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [InventoryTradeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#ab442811f22165013347bb85fa414cfdf) ([InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html) inventoryLogic, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRoster, InventoryLogic.InventorySide side, Action< int, bool > onApplyTransaction) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a789bc32ff30c7a006203f195464c7648) () |
|  | Used for updating localized texts. |
| void | [UpdateItemData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a3716e3a032ed48ede73087ff6b0cf3bc) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRoster, InventoryLogic.InventorySide side, bool forceUpdate=true) |
| string | [GetAveragePrice](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#ab870e20db709e25f65da3ebb27eebc36) (int totalPrice, int lastPrice, bool isBuying) |
| void | [ExecuteIncreaseThisStock](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a9f4c4384260c06d2e40b0ba89bca7f6f) () |
| void | [ExecuteIncreaseOtherStock](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#adaa5cb9fbc5841d415dc2c8858bea392) () |
| void | [ExecuteReset](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a54c3378b5e9e3a83f7d82f93a03dd1aa) () |
| void | [ExecuteApplyTransaction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#aa89139bbb116a9860f4dd6c7b25fd899) () |
| void | [ExecuteRemoveZeroCounts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#aff4f95a800958f9268fb9cbf819da541) () |
| Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| void | [OnPropertyChanged](class_tale_worlds_1_1_library_1_1_view_model.html#a1a9dee9bab5986a33083d31a689dc7fe) ([CallerMemberName] string propertyName=null) |
|  | Method for notifying binded views about the changes in a property. Uses reflection to get the value of the property. If reflection is not needed or updated value of the property is already known, use [OnPropertyChangedWithValue()](class_tale_worlds_1_1_library_1_1_view_model.html#a0d6928eeec2b43ac9ae089830783bd7f) instead. |
| void | [OnPropertyChangedWithValue< T >](class_tale_worlds_1_1_library_1_1_view_model.html#ae5000d209ee6d4e7baec2fa8e8803c7e) (T value, [CallerMemberName]string propertyName=null) |
|  | Faster method for notifying binded views about the changes in a property. To avoid reflection, caller can pass changed value to this method. If caller does not have access rights to the value, use [OnPropertyChanged()](class_tale_worlds_1_1_library_1_1_view_model.html#a1a9dee9bab5986a33083d31a689dc7fe "Method for notifying binded views about the changes in a property. Uses reflection to get the value o...") instead. |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a0d6928eeec2b43ac9ae089830783bd7f) (bool value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#abf208d3c50803f5d1f70fa658c21dc96) (int value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a991eb5001ba6210a9fefb4a69f8883c2) (float value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#ac54722f74e27aa6143d62a9dc589fb95) (uint value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a62ff1ab710820c9583a4b6ee66bb05e8) ([Color](struct_tale_worlds_1_1_library_1_1_color.html) value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#adb40c37120d9480a9c61934104b3b0ee) (double value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3298a1b9a60a7057cac4df839915f49d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) value, [CallerMemberName] string propertyName=null) |
| object | [GetViewModelAtPath](class_tale_worlds_1_1_library_1_1_view_model.html#adab1a5fac562c67766ef900113c2fd48) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path, bool isList) |
| object | [GetViewModelAtPath](class_tale_worlds_1_1_library_1_1_view_model.html#a58ad0a333f63aeb396cf0282a65b3b73) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path) |
| object | [GetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#a870f5daf5e6f307138260ee84406bd4e) (string name, [PropertyTypeFeeder](namespace_tale_worlds_1_1_library.html#a74850bfe0b5488f44574810b7462b0f7) propertyTypeFeeder) |
| object | [GetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#a6c761a8baf9a75c1d8fd65dbaed24055) (string name) |
| Type | [GetPropertyType](class_tale_worlds_1_1_library_1_1_view_model.html#ade14a4f33f7022fa0b20393db6e5f1b1) (string name) |
| void | [SetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#ad53397f315ef866a738a5e65556043df) (string name, object value) |
| virtual void | [OnFinalize](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc) () |
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |

|  |  |
| --- | --- |
| Properties | |
| string | [ThisStockLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#acf0cd2dc9f32b653a01b8a8b8d7abcc4) `[get, set]` |
| string | [OtherStockLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a5cea9ab676fcc9b418076de5f9777322) `[get, set]` |
| string | [PieceLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a9af93b7be50219e33df6a902df5c7ad0) `[get, set]` |
| string | [AveragePriceLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a7154d61af5f90011fd70b1f18dcdb70e) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ApplyExchangeHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a735f33a89acb18baf29019e4ff25f55d) `[get, set]` |
| bool | [IsExchangeAvailable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#aacad0724e02c441b9f8d178b9b3f4d05) `[get, set]` |
| string | [PriceChange](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#abf4ac118600c84a01d7a6b35e3b1f1a9) `[get, set]` |
| string | [PieceChange](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a152baab17f49ec3c9db1a1d184ee8a74) `[get, set]` |
| string | [AveragePrice](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a3bcb77f301d8f88e31eded4bf4f8f28e) `[get, set]` |
| int | [ThisStock](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a5e409bd31ae3d7981d5b1a5f102661da) `[get, set]` |
| int | [InitialThisStock](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#aee57d951ef34c06ca672ee9992a4865a) `[get, set]` |
| int | [OtherStock](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#aa9068cf09fe4d7aa6b01d6d5c1d63955) `[get, set]` |
| int | [InitialOtherStock](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a6a4ad6443dc5792f5e46e941cfa1b74a) `[get, set]` |
| int | [TotalStock](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#ab883d07ac572563d09cea71a8faccfca) `[get, set]` |
| bool | [IsThisStockIncreasable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a26a6679379de4652490123edecc4e33c) `[get, set]` |
| bool | [IsOtherStockIncreasable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#af6491f0849ed254a4b7ff900e6eb48d5) `[get, set]` |
| bool | [IsTrading](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a45571cf890d08128af28e9baa00d6a44) `[get, set]` |
| bool | [IsTradeable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a421e6469f4f30b99463459de058f179b) `[get, set]` |

|  |  |
| --- | --- |
| Events | |
| static Action | [RemoveZeroCounts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a56eef4523bdb6df9c3269f8a4f7c9238) |
| Events inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| PropertyChangedEventHandler | [PropertyChanged](class_tale_worlds_1_1_library_1_1_view_model.html#a7f8d83700f17f8092632c1eaa406d665) `[add, remove]` |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#acad8d628c31163e3022bea1e04675de6) `[add, remove]` |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](class_tale_worlds_1_1_library_1_1_view_model.html#a4d3b2d6f05fc919dca9e764b9e36af5d) `[add, remove]` |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3b31df15300b9652b9b5f664e03a5af9) `[add, remove]` |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3cb9bd971256835c5f6169cb58d67470) `[add, remove]` |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](class_tale_worlds_1_1_library_1_1_view_model.html#a197c48c4f8ba00372fc86a548ccb86f7) `[add, remove]` |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](class_tale_worlds_1_1_library_1_1_view_model.html#aea6e76a6562fbdf20688565257699162) `[add, remove]` |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](class_tale_worlds_1_1_library_1_1_view_model.html#a7d6e829c2ae2ef0147ca5f05e554dfc4) `[add, remove]` |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](class_tale_worlds_1_1_library_1_1_view_model.html#a8d1fb5f70c9230599a24b5d89a9a18f4) `[add, remove]` |
| Events inherited from [TaleWorlds.Library.IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) | |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a19415fe20feafa29a4e6d8d61dd95834) |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ae0ed3e57e466612e46fcf77b394b9ba6) |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ad33c6216fef22f2e150e0c0673c3c6ef) |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#acef7bf697f161b4c0d742215107b0b8b) |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#afd24d3b78a5e7fab669c340045b8533f) |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a3bc123550acc0a47f8c061c5a8300fa1) |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a4b1a715b622570235d8224ecef32dc13) |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a5b8667b3ad8595517ada80e2928bd6ab) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#ab442811f22165013347bb85fa414cfdf)InventoryTradeVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.InventoryTradeVM | ( | [InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html) | *inventoryLogic*, |
|  |  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRoster*, |
|  |  | InventoryLogic.InventorySide | *side*, |
|  |  | Action< int, bool > | *onApplyTransaction* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a789bc32ff30c7a006203f195464c7648)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a3716e3a032ed48ede73087ff6b0cf3bc)UpdateItemData()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.UpdateItemData | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRoster*, |
|  |  | InventoryLogic.InventorySide | *side*, |
|  |  | bool | *forceUpdate* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#ab870e20db709e25f65da3ebb27eebc36)GetAveragePrice()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.GetAveragePrice | ( | int | *totalPrice*, |
|  |  | int | *lastPrice*, |
|  |  | bool | *isBuying* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a9f4c4384260c06d2e40b0ba89bca7f6f)ExecuteIncreaseThisStock()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.ExecuteIncreaseThisStock | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#adaa5cb9fbc5841d415dc2c8858bea392)ExecuteIncreaseOtherStock()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.ExecuteIncreaseOtherStock | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a54c3378b5e9e3a83f7d82f93a03dd1aa)ExecuteReset()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.ExecuteReset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#aa89139bbb116a9860f4dd6c7b25fd899)ExecuteApplyTransaction()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.ExecuteApplyTransaction | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#aff4f95a800958f9268fb9cbf819da541)ExecuteRemoveZeroCounts()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.ExecuteRemoveZeroCounts | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#acf0cd2dc9f32b653a01b8a8b8d7abcc4)ThisStockLbl
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.ThisStockLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a5cea9ab676fcc9b418076de5f9777322)OtherStockLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.OtherStockLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a9af93b7be50219e33df6a902df5c7ad0)PieceLbl
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.PieceLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a7154d61af5f90011fd70b1f18dcdb70e)AveragePriceLbl
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.AveragePriceLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a735f33a89acb18baf29019e4ff25f55d)ApplyExchangeHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.ApplyExchangeHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#aacad0724e02c441b9f8d178b9b3f4d05)IsExchangeAvailable
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.IsExchangeAvailable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#abf4ac118600c84a01d7a6b35e3b1f1a9)PriceChange
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.PriceChange | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a152baab17f49ec3c9db1a1d184ee8a74)PieceChange
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.PieceChange | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a3bcb77f301d8f88e31eded4bf4f8f28e)AveragePrice
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.AveragePrice | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a5e409bd31ae3d7981d5b1a5f102661da)ThisStock
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.ThisStock | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#aee57d951ef34c06ca672ee9992a4865a)InitialThisStock
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.InitialThisStock | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#aa9068cf09fe4d7aa6b01d6d5c1d63955)OtherStock
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.OtherStock | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a6a4ad6443dc5792f5e46e941cfa1b74a)InitialOtherStock
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.InitialOtherStock | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#ab883d07ac572563d09cea71a8faccfca)TotalStock
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.TotalStock | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a26a6679379de4652490123edecc4e33c)IsThisStockIncreasable
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.IsThisStockIncreasable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#af6491f0849ed254a4b7ff900e6eb48d5)IsOtherStockIncreasable
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.IsOtherStockIncreasable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a45571cf890d08128af28e9baa00d6a44)IsTrading
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.IsTrading | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a421e6469f4f30b99463459de058f179b)IsTradeable
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.IsTradeable | | getset |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_inventory_trade_v_m.html#a56eef4523bdb6df9c3269f8a4f7c9238)RemoveZeroCounts
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.InventoryTradeVM.RemoveZeroCounts | | static |

