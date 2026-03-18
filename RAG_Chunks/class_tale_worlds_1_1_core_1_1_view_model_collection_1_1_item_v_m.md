--- SOURCE: class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html ---

TaleWorlds.Core.ViewModelCollection.ItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) () |
| override void | [RefreshValues](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a30db0f1bfa83b936a0118e94f2072b16) () |
|  | Used for updating localized texts. |
| void | [ExecutePreviewItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a9326b5708f320cadf1afc55d55366259) () |
| void | [ExecuteUnequipItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a0025d05d9ac0383d0ac68a727c8b709b) () |
| void | [ExecuteEquipItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a172e92e4c337fa04f8b414fb5309d464) () |
| void | [ExecuteRefreshTooltip](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aeb3974afee6d70819c0b9cb717eae365) () |
| void | [ExecuteCancelTooltip](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ac34005578ba90191dd685e59b7d44ffc) () |
| void | [ExecuteBuyItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a3867d27714c8ac7f7edfafb759aae031) () |
| void | [ExecuteSelectItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aea17d747055b0121accf3f07c2c131d3) () |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [GetItemTypeWithItemObject](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#af6dcc52d149b4b53bd9ee2bc0e80824e) () |
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
| Static Public Member Functions | |
| static void | [ReleaseStaticContent](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a89cb0605b82753cc7d2eb71aa1a72add) () |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |

|  |  |
| --- | --- |
| Public Attributes | |
| ItemRosterElement | [ItemRosterElement](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#abe03d6533296e9f39414046fe6f955b3) |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [\_itemType](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab10a3556d7798c11db0791e6498e37c0) = [EquipmentIndex.None](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61a6adf97f83acf6453d4a6a4b1070f3754) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) > | [ProcessEquipItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a830db0c6df7a7c96655bc1bed054a019) |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) > | [ProcessPreviewItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a755f953bc9d2488997337b2b49431348) |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) > | [ProcessUnequipItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab26b0066f53147e2a0ddce191c301c69) |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a), bool > | [ProcessBuyItem](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a331fb4411d3a4b400fe10175d69fedc0) |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) > | [ProcessItemSelect](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a44b7dc1679c3cfa586a3e5d69a425110) |
| static Action< [ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a) > | [ProcessItemTooltip](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aa1341ce1f6197150d5355c02984edef4) |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [OnItemTypeUpdated](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#af6058c2d39c52adb891c598b8933e3a6) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| int | [TypeId](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a3b421c2b214c6079ef7bb916afe17d2c) `[get]` |
| int | [Version](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a90c24cab7cf5caf31fd858b2b54a9d95) `[get, protected set]` |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | [ItemType](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aea8232d32a9d0238a90899517f733006) `[get]` |
| [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) | [ImageIdentifier](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a8b109d09e86f93e34c8721ba9524c2b8) `[get, set]` |
| string | [StringId](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a551620072c89a9e437d53bd5c9e9581f) `[get, set]` |
| string | [ItemDescription](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a6856d4b5a569c3530cd609feec3e8956) `[get, set]` |
| bool | [IsFiltered](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a6f89e0513da613928e39d9f41f801afd) `[get, set]` |
| int | [ItemCost](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ad80704703dab982a740f594dfbda9c4b) `[get, set]` |
| string | [TypeName](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a6e276951f161958cbeb8937b5e06c4d8) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [PreviewHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a08a9f247938d7a5e4fded0f72b148b70) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EquipHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ad549d241a4f2b680fd04aa9f15d68fc1) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UnequipHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#acf547a6c2c540b17fd107d3187dd9fdc) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SlaughterHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab6b50e1545a8b1c361268211d1aeab28) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [DonateHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a40a641e39025bd109ef0a36002c3c3df) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [BuyAndEquipHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a5b2ec53217d29f3ab2110ecfc88bddac) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SellHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a70116ceb38fe45f1aad4380cf9e83455) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [BuyHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab880e3c08f88bfa4e674ffc2c672a31a) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [LockHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#abfa0bb33af082b2cdaa55fa658b42d74) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
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

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a)ItemVM()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.ItemVM.ItemVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a30db0f1bfa83b936a0118e94f2072b16)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Core.ViewModelCollection.ItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html#af292455224f3879546d86696e30535cd).

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a9326b5708f320cadf1afc55d55366259)ExecutePreviewItem()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.ItemVM.ExecutePreviewItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a0025d05d9ac0383d0ac68a727c8b709b)ExecuteUnequipItem()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.ItemVM.ExecuteUnequipItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a172e92e4c337fa04f8b414fb5309d464)ExecuteEquipItem()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.ItemVM.ExecuteEquipItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a89cb0605b82753cc7d2eb71aa1a72add)ReleaseStaticContent()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.ViewModelCollection.ItemVM.ReleaseStaticContent | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aeb3974afee6d70819c0b9cb717eae365)ExecuteRefreshTooltip()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.ItemVM.ExecuteRefreshTooltip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ac34005578ba90191dd685e59b7d44ffc)ExecuteCancelTooltip()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.ItemVM.ExecuteCancelTooltip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a3867d27714c8ac7f7edfafb759aae031)ExecuteBuyItem()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.ItemVM.ExecuteBuyItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aea17d747055b0121accf3f07c2c131d3)ExecuteSelectItem()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.ItemVM.ExecuteSelectItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#af6dcc52d149b4b53bd9ee2bc0e80824e)GetItemTypeWithItemObject()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) TaleWorlds.Core.ViewModelCollection.ItemVM.GetItemTypeWithItemObject | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#af6058c2d39c52adb891c598b8933e3a6)OnItemTypeUpdated()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.ViewModelCollection.ItemVM.OnItemTypeUpdated | ( |  | ) |  | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a830db0c6df7a7c96655bc1bed054a019)ProcessEquipItem
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a)> TaleWorlds.Core.ViewModelCollection.ItemVM.ProcessEquipItem | | static |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a755f953bc9d2488997337b2b49431348)ProcessPreviewItem
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a)> TaleWorlds.Core.ViewModelCollection.ItemVM.ProcessPreviewItem | | static |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab26b0066f53147e2a0ddce191c301c69)ProcessUnequipItem
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a)> TaleWorlds.Core.ViewModelCollection.ItemVM.ProcessUnequipItem | | static |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a331fb4411d3a4b400fe10175d69fedc0)ProcessBuyItem
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a), bool> TaleWorlds.Core.ViewModelCollection.ItemVM.ProcessBuyItem | | static |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a44b7dc1679c3cfa586a3e5d69a425110)ProcessItemSelect
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a)> TaleWorlds.Core.ViewModelCollection.ItemVM.ProcessItemSelect | | static |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aa1341ce1f6197150d5355c02984edef4)ProcessItemTooltip
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[ItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a15a7764258f8f7cddca5e3ca1e9a7c7a)> TaleWorlds.Core.ViewModelCollection.ItemVM.ProcessItemTooltip | | static |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#abe03d6533296e9f39414046fe6f955b3)ItemRosterElement
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| ItemRosterElement TaleWorlds.Core.ViewModelCollection.ItemVM.ItemRosterElement |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab10a3556d7798c11db0791e6498e37c0)\_itemType
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) TaleWorlds.Core.ViewModelCollection.ItemVM.\_itemType = [EquipmentIndex.None](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61a6adf97f83acf6453d4a6a4b1070f3754) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a3b421c2b214c6079ef7bb916afe17d2c)TypeId
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ViewModelCollection.ItemVM.TypeId | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a90c24cab7cf5caf31fd858b2b54a9d95)Version
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ViewModelCollection.ItemVM.Version | | getprotected set |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#aea8232d32a9d0238a90899517f733006)ItemType
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) TaleWorlds.Core.ViewModelCollection.ItemVM.ItemType | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a8b109d09e86f93e34c8721ba9524c2b8)ImageIdentifier
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_item_image_identifier_v_m.html) TaleWorlds.Core.ViewModelCollection.ItemVM.ImageIdentifier | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a551620072c89a9e437d53bd5c9e9581f)StringId
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.ItemVM.StringId | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a6856d4b5a569c3530cd609feec3e8956)ItemDescription
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.ItemVM.ItemDescription | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a6f89e0513da613928e39d9f41f801afd)IsFiltered
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.ItemVM.IsFiltered | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ad80704703dab982a740f594dfbda9c4b)ItemCost
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ViewModelCollection.ItemVM.ItemCost | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a6e276951f161958cbeb8937b5e06c4d8)TypeName
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.ItemVM.TypeName | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a08a9f247938d7a5e4fded0f72b148b70)PreviewHint
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.Core.ViewModelCollection.ItemVM.PreviewHint | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ad549d241a4f2b680fd04aa9f15d68fc1)EquipHint
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.Core.ViewModelCollection.ItemVM.EquipHint | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#acf547a6c2c540b17fd107d3187dd9fdc)UnequipHint
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.Core.ViewModelCollection.ItemVM.UnequipHint | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab6b50e1545a8b1c361268211d1aeab28)SlaughterHint
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.Core.ViewModelCollection.ItemVM.SlaughterHint | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a40a641e39025bd109ef0a36002c3c3df)DonateHint
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.Core.ViewModelCollection.ItemVM.DonateHint | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a5b2ec53217d29f3ab2110ecfc88bddac)BuyAndEquipHint
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.Core.ViewModelCollection.ItemVM.BuyAndEquipHint | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#a70116ceb38fe45f1aad4380cf9e83455)SellHint
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.Core.ViewModelCollection.ItemVM.SellHint | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#ab880e3c08f88bfa4e674ffc2c672a31a)BuyHint
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.Core.ViewModelCollection.ItemVM.BuyHint | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_v_m.html#abfa0bb33af082b2cdaa55fa658b42d74)LockHint
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.Core.ViewModelCollection.ItemVM.LockHint | | getset |

