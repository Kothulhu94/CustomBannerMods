--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClanIncomeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#aa5cf25e66078262e575cd541f5cd63e9) (Action onRefresh, Action< [ClanCardSelectionInfo](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_card_selection_info.html) > openCardSelectionPopup) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a22d8cc548f0079b7319a65213a94afe6) () |
|  | Used for updating localized texts. |
| void | [RefreshList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a65e8f259b6cbf95bff33beca0cf9c3ae) () |
| void | [SelectWorkshop](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a83ea559761ea6f73fbee805c13f6a182) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| void | [SelectAlley](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a1a62acf6d558a4b10d499903c40d0f44) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| void | [RefreshTotalIncome](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a0b3b4437a02c2d4b7a0ef2992359f5a8) () |
| void | [OnRefresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a8c91c9af8c978018abcd1951ec79293e) () |
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
| int | [TotalIncome](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#acc1dc17ba2ee6bb5900e10352f5ba164) `[get]` |
| [ClanFinanceAlleyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fine6a6bfc2a7765425eb9acded8523354f.html) | [CurrentSelectedAlley](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#ac98996a883a5b96be4ba55202a2d6744) `[get, set]` |
| [ClanFinanceWorkshopItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin1a7490791e0e1d85ef10e8f3d93c3149.html) | [CurrentSelectedIncome](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a606a7c9d614e7af7630b108701ce6e4d) `[get, set]` |
| [ClanSupporterGroupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_supporters_1_1_clan_supporter_group_v_m.html) | [CurrentSelectedSupporterGroup](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a845ec195d837b6976f4438e85aba3bad) `[get, set]` |
| bool | [IsAnyValidAlleySelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a90a21932ca146db8d46cfbcf0b23fb3b) `[get, set]` |
| bool | [IsAnyValidIncomeSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a52d3c4f8fa289dfb331522687d9be709) `[get, set]` |
| bool | [IsAnyValidSupporterSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a732fcf4889466f868961cfb15db881e9) `[get, set]` |
| string | [IncomeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a38ee8b2d1a05cd15156a6892c277e2f0) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#ac357b6afc5b1692b646120b7d63145d7) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a0cdf03f61726d3566b3e9b6755e51552) `[get, set]` |
| string | [LocationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#aba345a32463591e32183e873b00ff199) `[get, set]` |
| string | [WorkshopText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#ac598b8e13501ac3065f0c6250a7b0a48) `[get, set]` |
| string | [SupportersText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a309f57bf54444bd618174b485b5558e6) `[get, set]` |
| string | [AlleysText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a0ffb8315e5a273a79e4026b3ed0379a1) `[get, set]` |
| string | [NoAdditionalIncomesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#acbd98224d3ef063b42ad33be1eceb3a5) `[get, set]` |
| MBBindingList< [ClanFinanceWorkshopItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin1a7490791e0e1d85ef10e8f3d93c3149.html) > | [Incomes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a8e5acac8ab62307b2c9ab71fc82bb0b6) `[get, set]` |
| MBBindingList< [ClanSupporterGroupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_supporters_1_1_clan_supporter_group_v_m.html) > | [SupporterGroups](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#adc70f85d364bd6d758cfea6454ee10db) `[get, set]` |
| MBBindingList< [ClanFinanceAlleyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fine6a6bfc2a7765425eb9acded8523354f.html) > | [Alleys](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#ad1a79c132a4f6a5e9075d417962d2f6b) `[get, set]` |
| [ClanIncomeSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html) | [SortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a9e4273f28a4745da71afd4848a83e856) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#aa5cf25e66078262e575cd541f5cd63e9)ClanIncomeVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.ClanIncomeVM | ( | Action | *onRefresh*, |
|  |  | Action< [ClanCardSelectionInfo](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_card_selection_info.html) > | *openCardSelectionPopup* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a22d8cc548f0079b7319a65213a94afe6)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a65e8f259b6cbf95bff33beca0cf9c3ae)RefreshList()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.RefreshList | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a83ea559761ea6f73fbee805c13f6a182)SelectWorkshop()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.SelectWorkshop | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a1a62acf6d558a4b10d499903c40d0f44)SelectAlley()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.SelectAlley | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a0b3b4437a02c2d4b7a0ef2992359f5a8)RefreshTotalIncome()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.RefreshTotalIncome | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a8c91c9af8c978018abcd1951ec79293e)OnRefresh()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.OnRefresh | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#acc1dc17ba2ee6bb5900e10352f5ba164)TotalIncome
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.TotalIncome | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#ac98996a883a5b96be4ba55202a2d6744)CurrentSelectedAlley
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ClanFinanceAlleyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fine6a6bfc2a7765425eb9acded8523354f.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.CurrentSelectedAlley | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a606a7c9d614e7af7630b108701ce6e4d)CurrentSelectedIncome
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ClanFinanceWorkshopItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin1a7490791e0e1d85ef10e8f3d93c3149.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.CurrentSelectedIncome | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a845ec195d837b6976f4438e85aba3bad)CurrentSelectedSupporterGroup
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ClanSupporterGroupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_supporters_1_1_clan_supporter_group_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.CurrentSelectedSupporterGroup | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a90a21932ca146db8d46cfbcf0b23fb3b)IsAnyValidAlleySelected
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.IsAnyValidAlleySelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a52d3c4f8fa289dfb331522687d9be709)IsAnyValidIncomeSelected
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.IsAnyValidIncomeSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a732fcf4889466f868961cfb15db881e9)IsAnyValidSupporterSelected
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.IsAnyValidSupporterSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a38ee8b2d1a05cd15156a6892c277e2f0)IncomeText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.IncomeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#ac357b6afc5b1692b646120b7d63145d7)IsSelected
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a0cdf03f61726d3566b3e9b6755e51552)NameText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#aba345a32463591e32183e873b00ff199)LocationText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.LocationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#ac598b8e13501ac3065f0c6250a7b0a48)WorkshopText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.WorkshopText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a309f57bf54444bd618174b485b5558e6)SupportersText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.SupportersText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a0ffb8315e5a273a79e4026b3ed0379a1)AlleysText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.AlleysText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#acbd98224d3ef063b42ad33be1eceb3a5)NoAdditionalIncomesText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.NoAdditionalIncomesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a8e5acac8ab62307b2c9ab71fc82bb0b6)Incomes
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ClanFinanceWorkshopItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin1a7490791e0e1d85ef10e8f3d93c3149.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.Incomes | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#adc70f85d364bd6d758cfea6454ee10db)SupporterGroups
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ClanSupporterGroupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_supporters_1_1_clan_supporter_group_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.SupporterGroups | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#ad1a79c132a4f6a5e9075d417962d2f6b)Alleys
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ClanFinanceAlleyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fine6a6bfc2a7765425eb9acded8523354f.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.Alleys | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_income_v_m.html#a9e4273f28a4745da71afd4848a83e856)SortController
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ClanIncomeSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categori3530451f99419ef56eef148e55e2a9dc.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanIncomeVM.SortController | | getset |

