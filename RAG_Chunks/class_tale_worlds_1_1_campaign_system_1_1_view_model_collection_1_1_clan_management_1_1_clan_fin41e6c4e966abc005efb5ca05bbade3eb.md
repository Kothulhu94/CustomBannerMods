--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClanFinanceTownItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a51c27657dd0279c4b0d936d2c322035f) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a2fe61930f0fb4fa0e393564f7590f56c) settlement, [TaxType](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management.html#aac4889800ed1d02b9ea73dbccce99425) taxType, Action< [ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#a879609ce6257ab5937deab4c03c7a9e5) > onSelection, Action onRefresh) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html) | |
| void | [OnIncomeSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#ad14ee7740d7c0a2b5874b6eb85378afe) () |
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
| Protected Member Functions | |
| override void | [PopulateActionList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a40423c2570b7a1724b23bf8598f20630) () |
| override void | [PopulateStatsList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a8532f228e07b86c07d2a9bf0248f8f0b) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html) | |
|  | [ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#a879609ce6257ab5937deab4c03c7a9e5) (Action< ClanFinanceIncomeItemBaseVM > onSelection, Action onRefresh) |
| string | [DetermineIncomeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#a80c3f94d404426faa5875297afbb4ef0) (int incomeAmount) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a2fe61930f0fb4fa0e393564f7590f56c) `[get]` |
| bool | [IsUnderSiege](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#ab95faaa247c87add43a1746e7dc8c322) `[get, set]` |
| bool | [IsUnderRebellion](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a45dfefc0429bc64b24610e04917d8460) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [IsUnderSiegeHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#ab57e21dc4e429cfa8da7c08d33413ab5) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [IsUnderRebellionHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a5beb9f5bedb0955ae481e9afd8d08186) `[get, set]` |
| bool | [HasGovernor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a2d69e94d89eb6be425bde5fbda452388) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [GovernorHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a8cf71e9db47fe4753be7d497b3705f85) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html) | |
| [IncomeTypes](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management.html#ae3457faaf32ababa883f718b4403df24) | [IncomeTypeAsEnum](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#a47f84b574e0dff67f3f7b336f7b2293f) `[get, protected set]` |
| MBBindingList< [SelectableItemPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_selectable_item_property_v_m.html) > | [ItemProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#ab3af4f224ea0d71ed1e312a35762ff9e) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#aa540c97d8a754dc7852eee126eeb5a6e) `[get, set]` |
| string | [Location](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#aa94a1ec871a5da01bc528579100922e8) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#ae47b1e671608f99a1aaa630e9d79543a) `[get, set]` |
| string | [IncomeValueText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#a32259f5764ee29b6d1fa25a37bbe27c0) `[get, set]` |
| string | [ImageName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#ab79e024e6906d66a0b06aa131d825fb1) `[get, set]` |
| int | [Income](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#ac481c0fe57d2862d4755e7cbb42c9fca) `[get, set]` |
| [ImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_image_identifier_v_m.html) | [Visual](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#a36dac6b32543d831dc690dfdd8e5929f) `[get, set]` |
| int | [IncomeType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#a6d9c2e7801b69ab08a7e6461ea45fa8f) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html) | |
| Action | [\_onRefresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#aeda868f44805224f3819e85f73cd2da8) |
| Action< [ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#a879609ce6257ab5937deab4c03c7a9e5) > | [\_onSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#a051e73abf5a16047967e0a51feee836b) |
| [IncomeTypes](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management.html#ae3457faaf32ababa883f718b4403df24) | [\_incomeTypeAsEnum](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#abc849744ca84e09147c3b8a2e9fdb297) = [IncomeTypes.None](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management.html#ae3457faaf32ababa883f718b4403df24a6adf97f83acf6453d4a6a4b1070f3754) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a51c27657dd0279c4b0d936d2c322035f)ClanFinanceTownItemVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM.ClanFinanceTownItemVM | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a2fe61930f0fb4fa0e393564f7590f56c) | *settlement*, |
|  |  | [TaxType](namespace_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management.html#aac4889800ed1d02b9ea73dbccce99425) | *taxType*, |
|  |  | Action< [ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#a879609ce6257ab5937deab4c03c7a9e5) > | *onSelection*, |
|  |  | Action | *onRefresh* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a40423c2570b7a1724b23bf8598f20630)PopulateActionList()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM.PopulateActionList | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#ad8dcb25a3ef353198c4d20a04385d294).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a8532f228e07b86c07d2a9bf0248f8f0b)PopulateStatsList()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM.PopulateStatsList | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinanceIncomeItemBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_finance_income_item_base_v_m.html#ad1d755d5b8099d3df1dd6d43e23ffd69).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a2fe61930f0fb4fa0e393564f7590f56c)Settlement
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Settlement TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM.Settlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#ab95faaa247c87add43a1746e7dc8c322)IsUnderSiege
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM.IsUnderSiege | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a45dfefc0429bc64b24610e04917d8460)IsUnderRebellion
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM.IsUnderRebellion | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#ab57e21dc4e429cfa8da7c08d33413ab5)IsUnderSiegeHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM.IsUnderSiegeHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a5beb9f5bedb0955ae481e9afd8d08186)IsUnderRebellionHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM.IsUnderRebellionHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a2d69e94d89eb6be425bde5fbda452388)HasGovernor
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM.HasGovernor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_fin41e6c4e966abc005efb5ca05bbade3eb.html#a8cf71e9db47fe4753be7d497b3705f85)GovernorHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.ClanFinance.ClanFinanceTownItemVM.GovernorHint | | getset |

