--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| class | [WorkshopItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori6deb1487846bbcfdfe7f7895bd6d858b.html) |
| class | [SupporterItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori5b879656277eccec247b98c3260a1570.html) |
| class | [AlleyItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categorie29685dc5d5caff3b6373942194fe7c6.html) |
| class | [WorkshopItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categoricf5dc047bb7d650e58ee49a82c2e4a94.html) |
| class | [SupporterItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categorib5ce897f73fadd3726f04e7520714042.html) |
| class | [AlleyItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori6b8e53595b51d5d7af10b6e2be44c5b9.html) |
| class | [WorkshopItemLocationComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori2f7b0ebeefd5224692686d635cad403a.html) |
| class | [AlleyItemLocationComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categorib9a33d356808dc9ede18941c5cc5d79f.html) |
| class | [WorkshopItemIncomeComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori9ce385737100442a5439bea5acb2faae.html) |
| class | [SupporterItemIncomeComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categoridade5d3f7210fb448bb52ad4636944f9.html) |
| class | [AlleyItemIncomeComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori91e0efff3a1a1d5612e0c17265bca202.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClanIncomeSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#aa5f71855361361b54b56a94f77d7385a) (MBBindingList< [ClanFinanceWorkshopItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin1a7490791e0e1d85ef10e8f3d93c3149.html) > workshopList, MBBindingList< [ClanSupporterGroupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_supporters_1_1_clan_supporter_group_v_m.html) > supporterList, MBBindingList< [ClanFinanceAlleyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fine6a6bfc2a7765425eb9acded8523354f.html) > alleyList) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a26f761c43e166e258e00e4c7ed1e763f) () |
|  | Used for updating localized texts. |
| void | [ExecuteSortByName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#aa1cae2fbdbbe122fae43705cbc17ecb7) () |
| void | [ExecuteSortByLocation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a2ddd0e513c52dcc6dee03de7f6f5bae7) () |
| void | [ExecuteSortByIncome](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#addb98faa10fdcfc71739678cc6aeb3ea) () |
| void | [ResetAllStates](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a8be640ecab377bf60671f69aeda9f85a) () |
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
| int | [NameState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a84b00424fd66037f9a564ea1bf24553f) `[get, set]` |
| int | [LocationState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a171cb5ea8eab878f49ce8f39b33bf45f) `[get, set]` |
| int | [IncomeState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#affb21bca4f604b8c640daf1fd5614e15) `[get, set]` |
| bool | [IsNameSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a3cfa10a69244f825aec5412f4c79a9ed) `[get, set]` |
| bool | [IsLocationSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a0b75ebc65c4c5049cd630441891b9d60) `[get, set]` |
| bool | [IsIncomeSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a48b9d00f3daa17745f46d4dd41e04d28) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#ac7ec5e1f4a19e4faf3765179853dc636) `[get, set]` |
| string | [LocationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a328b12b7c36a4b32804ef6cfc637cf4c) `[get, set]` |
| string | [IncomeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#aa470f6d0cd16eec820fd5d5bd1be3c98) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#aa5f71855361361b54b56a94f77d7385a)ClanIncomeSortControllerVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.ClanIncomeSortControllerVM | ( | MBBindingList< [ClanFinanceWorkshopItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin1a7490791e0e1d85ef10e8f3d93c3149.html) > | *workshopList*, |
|  |  | MBBindingList< [ClanSupporterGroupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_supporters_1_1_clan_supporter_group_v_m.html) > | *supporterList*, |
|  |  | MBBindingList< [ClanFinanceAlleyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fine6a6bfc2a7765425eb9acded8523354f.html) > | *alleyList* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a26f761c43e166e258e00e4c7ed1e763f)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#aa1cae2fbdbbe122fae43705cbc17ecb7)ExecuteSortByName()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.ExecuteSortByName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a2ddd0e513c52dcc6dee03de7f6f5bae7)ExecuteSortByLocation()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.ExecuteSortByLocation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#addb98faa10fdcfc71739678cc6aeb3ea)ExecuteSortByIncome()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.ExecuteSortByIncome | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a8be640ecab377bf60671f69aeda9f85a)ResetAllStates()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.ResetAllStates | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a84b00424fd66037f9a564ea1bf24553f)NameState
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.NameState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a171cb5ea8eab878f49ce8f39b33bf45f)LocationState
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.LocationState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#affb21bca4f604b8c640daf1fd5614e15)IncomeState
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.IncomeState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a3cfa10a69244f825aec5412f4c79a9ed)IsNameSelected
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.IsNameSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a0b75ebc65c4c5049cd630441891b9d60)IsLocationSelected
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.IsLocationSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a48b9d00f3daa17745f46d4dd41e04d28)IsIncomeSelected
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.IsIncomeSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#ac7ec5e1f4a19e4faf3765179853dc636)NameText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#a328b12b7c36a4b32804ef6cfc637cf4c)LocationText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.LocationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html#aa470f6d0cd16eec820fd5d5bd1be3c98)IncomeText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeSortControllerVM.IncomeText | | getset |

