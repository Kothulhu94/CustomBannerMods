--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| class | [ItemComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_98b02397f0786822ad96017d264a59d9.html) |
| class | [ItemTypeComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_5b6da37e50395ebabc1f7c4cc4508d9b.html) |
| class | [ItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_114780c65517d23ec12a743bdb8150e4.html) |
| class | [ItemQuantityComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_44dcddba5f9924006bf9cdfcb0aa9225.html) |
| class | [ItemCostComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_24c70effe4ce087ca0e873e765bfe127.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [InventoryItemSortState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a25d4b9d8aade304fbd228d7056b4757f) {     [Default](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a25d4b9d8aade304fbd228d7056b4757fa7a1920d61156abc05a60135aefe8bc67) = 0 ,     [Ascending](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a25d4b9d8aade304fbd228d7056b4757facf3fb1ff52ea1eed3347ac5401ee7f0c) ,     [Descending](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a25d4b9d8aade304fbd228d7056b4757fae3cf5ac19407b1a62c6fccaff675a53b)   } |
| enum | [InventoryItemSortOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8) {     [Type](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8aa1fa27779242b4902f7ae3bdd5c6d508) = 0 ,     [Name](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8a49ee3087348e8d44e1feda1917443987) ,     [Quantity](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8a694e8d1f2ee056f98ee488bdc4982d73) ,     [Cost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8a20b4f77bd00b4f63a49ec8e08f3bf6a6)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SPInventorySortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#ab98efb42069be4a539d6cbb3904c935e) (ref MBBindingList< [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) > listToControl) |
| void | [SortByOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a192f4df80a62fb065d85e13c898510fa) ([InventoryItemSortOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8) sortOption, [InventoryItemSortState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a25d4b9d8aade304fbd228d7056b4757f) sortState) |
| void | [SortByDefaultState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#aa89b56e583bd4867dd0d6f61fc61335a) () |
| void | [SortByCurrentState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#af5dd4d3e656c9f9043467f588b350ee6) () |
| void | [ExecuteSortByName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a3ad94b87c641e907ad453bb6c21051bc) () |
| void | [ExecuteSortByType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#afde0f68c8dda852cb97500cace98ab91) () |
| void | [ExecuteSortByQuantity](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#aabf2a10b9efbf7b2fad4d2aa90817a0f) () |
| void | [ExecuteSortByCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#aaaea174abe78cc392e36a9e9c695beb8) () |
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
| [InventoryItemSortOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8)? | [CurrentSortOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#aee454eff3b51f981e163d7c0dea3fc39) = null `[get]` |
| [InventoryItemSortState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a25d4b9d8aade304fbd228d7056b4757f)? | [CurrentSortState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a5ad5388dab9a248f16a536f7b624df25) = null `[get]` |
| int | [TypeState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a30c807c2bc94eda592e4050332207cb5) `[get, set]` |
| int | [NameState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a55364cf3b14447c4949d3fbb9b4e366a) `[get, set]` |
| int | [QuantityState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a868a2266b310b0d3b9b31ff6c2db0a1b) `[get, set]` |
| int | [CostState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a79af35405e269bea8896d863dbbb05d0) `[get, set]` |
| bool | [IsTypeSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0152f10bf8cee8aab3f176640f1f9b61) `[get, set]` |
| bool | [IsNameSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#ad88001bbc843e07d23e90d0b6c4cd015) `[get, set]` |
| bool | [IsQuantitySelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0a0736f5da6862be9fe2f32e0fad9d49) `[get, set]` |
| bool | [IsCostSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#af069fcbc396846e6089451e08ff7e21a) `[get, set]` |

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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a25d4b9d8aade304fbd228d7056b4757f)InventoryItemSortState
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.InventoryItemSortState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a25d4b9d8aade304fbd228d7056b4757f) |

| Enumerator | |
| --- | --- |
| Default |  |
| Ascending |  |
| Descending |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8)InventoryItemSortOption
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.InventoryItemSortOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8) |

| Enumerator | |
| --- | --- |
| Type |  |
| Name |  |
| Quantity |  |
| Cost |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#ab98efb42069be4a539d6cbb3904c935e)SPInventorySortControllerVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.SPInventorySortControllerVM | ( | ref MBBindingList< [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) > | *listToControl* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a192f4df80a62fb065d85e13c898510fa)SortByOption()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.SortByOption | ( | [InventoryItemSortOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8) | *sortOption*, |
|  |  | [InventoryItemSortState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a25d4b9d8aade304fbd228d7056b4757f) | *sortState* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#aa89b56e583bd4867dd0d6f61fc61335a)SortByDefaultState()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.SortByDefaultState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#af5dd4d3e656c9f9043467f588b350ee6)SortByCurrentState()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.SortByCurrentState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a3ad94b87c641e907ad453bb6c21051bc)ExecuteSortByName()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ExecuteSortByName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#afde0f68c8dda852cb97500cace98ab91)ExecuteSortByType()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ExecuteSortByType | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#aabf2a10b9efbf7b2fad4d2aa90817a0f)ExecuteSortByQuantity()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ExecuteSortByQuantity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#aaaea174abe78cc392e36a9e9c695beb8)ExecuteSortByCost()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ExecuteSortByCost | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#aee454eff3b51f981e163d7c0dea3fc39)CurrentSortOption
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InventoryItemSortOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0411c260ce646990d08f00c092b96fc8)? TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.CurrentSortOption = null | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a5ad5388dab9a248f16a536f7b624df25)CurrentSortState
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InventoryItemSortState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a25d4b9d8aade304fbd228d7056b4757f)? TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.CurrentSortState = null | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a30c807c2bc94eda592e4050332207cb5)TypeState
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.TypeState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a55364cf3b14447c4949d3fbb9b4e366a)NameState
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.NameState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a868a2266b310b0d3b9b31ff6c2db0a1b)QuantityState
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.QuantityState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a79af35405e269bea8896d863dbbb05d0)CostState
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.CostState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0152f10bf8cee8aab3f176640f1f9b61)IsTypeSelected
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.IsTypeSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#ad88001bbc843e07d23e90d0b6c4cd015)IsNameSelected
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.IsNameSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#a0a0736f5da6862be9fe2f32e0fad9d49)IsQuantitySelected
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.IsQuantitySelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_sort_controller_v_m.html#af069fcbc396846e6089451e08ff7e21a)IsCostSelected
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.IsCostSelected | | getset |

