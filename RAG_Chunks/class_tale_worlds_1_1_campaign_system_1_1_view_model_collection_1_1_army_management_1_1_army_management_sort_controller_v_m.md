--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| class | [ItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_mand7f4b12368e1552de3731dbe22b1e4d8.html) |
| class | [ItemDistanceComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_man417e4e1f97b85b3fad006bdeca5a404b.html) |
| class | [ItemCostComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_man659b116e25c19d767af2de2cc80d0ff5.html) |
| class | [ItemStrengthComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_man363ab4a3e62d9b4c7f97a5108826e2d0.html) |
| class | [ItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_man48cef6c2d4e9a69a620afcabf842a74a.html) |
| class | [ItemClanComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_man1dcf1c5461afbf40b292ab93f75ec5b5.html) |
| class | [ItemShipCountComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_manb6c4290ff9f64cedfd37ed84be7b9cfa.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ArmyManagementSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a50d922d5e30008f03d9bb3ea81544524) (MBBindingList< [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) > listToControl) |
| void | [ExecuteSortByDistance](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a02dc8aa62c5c4706931ce7c942ca3e91) () |
| void | [ExecuteSortByCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a15fbf40af52a88c54d7077ed010c62de) () |
| void | [ExecuteSortByStrength](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#ab2009a5315f531ec29c3d63be1b048e4) () |
| void | [ExecuteSortByName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a20d49c49dec4043a2b285285066208b1) () |
| void | [ExecuteSortByClan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a9aa8cda974dcbe9cfd879bedf6295c18) () |
| void | [ExecuteSortByShipCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a5789e55e06bb234427cf4cd352a50d16) () |
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
| int | [DistanceState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a84b85221c6dafa777641c3c334594d25) `[get, set]` |
| int | [CostState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a7d184649624205b0bfb446925ed76f25) `[get, set]` |
| int | [StrengthState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#aa0fc39501b669cd42502156b4282bde2) `[get, set]` |
| int | [NameState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a191fb33e3ccac5f4768884ecfa4045db) `[get, set]` |
| int | [ClanState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a969a86ff1380351824f62d40833379f1) `[get, set]` |
| int | [ShipCountState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#ae3d5a97b6add3bffb238cb2c10d115cc) `[get, set]` |
| bool | [IsNameSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#aefbdeda780f3fd51ff4023889bbd9ee5) `[get, set]` |
| bool | [IsCostSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a45c73daf4684a185db39d212732d2cea) `[get, set]` |
| bool | [IsStrengthSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a55eb1b042cba71e9b6e4d25c280f7b83) `[get, set]` |
| bool | [IsDistanceSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a5699d1a95a8ad7dbdb96de915f9e3733) `[get, set]` |
| bool | [IsClanSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#adaf3f7ad380f0581dec149b72964127c) `[get, set]` |
| bool | [IsShipCountSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a037c682c8e3724456d6bee11ace08b33) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a50d922d5e30008f03d9bb3ea81544524)ArmyManagementSortControllerVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ArmyManagementSortControllerVM | ( | MBBindingList< [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) > | *listToControl* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a02dc8aa62c5c4706931ce7c942ca3e91)ExecuteSortByDistance()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ExecuteSortByDistance | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a15fbf40af52a88c54d7077ed010c62de)ExecuteSortByCost()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ExecuteSortByCost | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#ab2009a5315f531ec29c3d63be1b048e4)ExecuteSortByStrength()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ExecuteSortByStrength | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a20d49c49dec4043a2b285285066208b1)ExecuteSortByName()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ExecuteSortByName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a9aa8cda974dcbe9cfd879bedf6295c18)ExecuteSortByClan()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ExecuteSortByClan | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a5789e55e06bb234427cf4cd352a50d16)ExecuteSortByShipCount()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ExecuteSortByShipCount | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a84b85221c6dafa777641c3c334594d25)DistanceState
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.DistanceState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a7d184649624205b0bfb446925ed76f25)CostState
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.CostState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#aa0fc39501b669cd42502156b4282bde2)StrengthState
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.StrengthState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a191fb33e3ccac5f4768884ecfa4045db)NameState
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.NameState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a969a86ff1380351824f62d40833379f1)ClanState
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ClanState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#ae3d5a97b6add3bffb238cb2c10d115cc)ShipCountState
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ShipCountState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#aefbdeda780f3fd51ff4023889bbd9ee5)IsNameSelected
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.IsNameSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a45c73daf4684a185db39d212732d2cea)IsCostSelected
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.IsCostSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a55eb1b042cba71e9b6e4d25c280f7b83)IsStrengthSelected
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.IsStrengthSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a5699d1a95a8ad7dbdb96de915f9e3733)IsDistanceSelected
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.IsDistanceSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#adaf3f7ad380f0581dec149b72964127c)IsClanSelected
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.IsClanSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_sort_controller_v_m.html#a037c682c8e3724456d6bee11ace08b33)IsShipCountSelected
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.IsShipCountSelected | | getset |

