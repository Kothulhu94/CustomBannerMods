--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ItemMenuVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a1a9a07b842553ae32a394ee7927a608b) (Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html), int > resetComparedItems, [InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html) inventoryLogic, Func< [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html), [ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) > getItemUsageSetFlags, Func< [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) > getEquipmentAtIndex) |
| void | [SetItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#af91dc4e536c626ddc727fb91dd96875c) ([SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) item, InventoryLogic.InventorySide currentEquipmentMode, [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) comparedItem=null, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character=null, int alternativeUsageIndex=0) |
| void | [SetTransactionCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a1b5b469803b186f140f544ecd74a32b0) (int getItemTotalPrice, int maxIndividualPrice) |
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
| virtual void | [RefreshValues](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd) () |
|  | Used for updating localized texts. |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsComparing](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a6ddf010d0a4061a85c971bcc23c79a7e) `[get, set]` |
| bool | [IsPlayerItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a650f99be1782951a2a65f39fd43dcb1a) `[get, set]` |
| [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) | [ImageIdentifier](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#ac951fc4112b303b7efd5fda0a480d500) `[get, set]` |
| [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) | [ComparedImageIdentifier](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#ab0df1ba59345dc4dfab9777ed1b1194b) `[get, set]` |
| int | [TransactionTotalCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#ac2c39e9764db2c1c3efa8ba957a5b624) `[get, set]` |
| bool | [IsInitializationOver](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a10c2fb73ad73fd066a81881294dca282) `[get, set]` |
| string | [ItemName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#abe6e77506344cbdb352cb8383040e63f) `[get, set]` |
| string | [ComparedItemName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a2034bd214b7e9a548209efe95ff27c60) `[get, set]` |
| bool | [IsStealthModeActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a7b9806ea734d66d672a2fb490f809775) `[get, set]` |
| MBBindingList< [ItemMenuTooltipPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_tooltip_property_v_m.html) > | [TargetItemProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#acf5c9b0daa8a53dfd042ed0a45aaff38) `[get, set]` |
| MBBindingList< [ItemMenuTooltipPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_tooltip_property_v_m.html) > | [ComparedItemProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#aa9cda69888bb79e1ef1e38c47c11b0a5) `[get, set]` |
| MBBindingList< [ItemFlagVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_flag_v_m.html) > | [TargetItemFlagList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a12b9df03bdfba11fb36e8fbff802d9a7) `[get, set]` |
| MBBindingList< [ItemFlagVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_flag_v_m.html) > | [ComparedItemFlagList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#af79599dbb2504ddc6d1c5a057bf94ecd) `[get, set]` |
| int | [AlternativeUsageIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a3b1269720fb0b59005bc91067ad14a73) `[get, set]` |
| MBBindingList< [StringItemWithHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_hint_v_m.html) > | [AlternativeUsages](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#ab845572e252ed3398dc1b69a04acba18) `[get, set]` |

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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a1a9a07b842553ae32a394ee7927a608b)ItemMenuVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.ItemMenuVM | ( | Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html), int > | *resetComparedItems*, |
|  |  | [InventoryLogic](class_tale_worlds_1_1_campaign_system_1_1_inventory_1_1_inventory_logic.html) | *inventoryLogic*, |
|  |  | Func< [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html), [ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) > | *getItemUsageSetFlags*, |
|  |  | Func< [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) > | *getEquipmentAtIndex* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#af91dc4e536c626ddc727fb91dd96875c)SetItem()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.SetItem | ( | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | *item*, |
|  |  | InventoryLogic.InventorySide | *currentEquipmentMode*, |
|  |  | [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html) | *comparedItem* = null, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character* = null, |
|  |  | int | *alternativeUsageIndex* = 0 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a1b5b469803b186f140f544ecd74a32b0)SetTransactionCost()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.SetTransactionCost | ( | int | *getItemTotalPrice*, |
|  |  | int | *maxIndividualPrice* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a6ddf010d0a4061a85c971bcc23c79a7e)IsComparing
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.IsComparing | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a650f99be1782951a2a65f39fd43dcb1a)IsPlayerItem
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.IsPlayerItem | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#ac951fc4112b303b7efd5fda0a480d500)ImageIdentifier
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.ImageIdentifier | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#ab0df1ba59345dc4dfab9777ed1b1194b)ComparedImageIdentifier
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.ComparedImageIdentifier | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#ac2c39e9764db2c1c3efa8ba957a5b624)TransactionTotalCost
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.TransactionTotalCost | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a10c2fb73ad73fd066a81881294dca282)IsInitializationOver
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.IsInitializationOver | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#abe6e77506344cbdb352cb8383040e63f)ItemName
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.ItemName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a2034bd214b7e9a548209efe95ff27c60)ComparedItemName
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.ComparedItemName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a7b9806ea734d66d672a2fb490f809775)IsStealthModeActive
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.IsStealthModeActive | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#acf5c9b0daa8a53dfd042ed0a45aaff38)TargetItemProperties
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ItemMenuTooltipPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_tooltip_property_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.TargetItemProperties | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#aa9cda69888bb79e1ef1e38c47c11b0a5)ComparedItemProperties
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ItemMenuTooltipPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_tooltip_property_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.ComparedItemProperties | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a12b9df03bdfba11fb36e8fbff802d9a7)TargetItemFlagList
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ItemFlagVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_flag_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.TargetItemFlagList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#af79599dbb2504ddc6d1c5a057bf94ecd)ComparedItemFlagList
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ItemFlagVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_flag_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.ComparedItemFlagList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#a3b1269720fb0b59005bc91067ad14a73)AlternativeUsageIndex
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.AlternativeUsageIndex | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_menu_v_m.html#ab845572e252ed3398dc1b69a04acba18)AlternativeUsages
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[StringItemWithHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_hint_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.ItemMenuVM.AlternativeUsages | | getset |

