--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [PropertyType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585d) {     [None](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585da6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [Tax](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585da4b78ac8eb158840e9638a3aeb26c4a9d) ,     [Tariff](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585da742e367b489bd598edcb306560e3b1f4) ,     [Garrison](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585da107773a1c506b594d38ad905efda865c) ,     [Village](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585daabc63490c815af81276f930216c8d92b) ,     [Governor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585da511dedda590b2ded1572c99caee392ba)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ProfitItemPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a01ca6673faaf9e1cd603dc9608ddd3ed) (string name, int value, [PropertyType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585d) type=[PropertyType.None](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585da6adf97f83acf6453d4a6a4b1070f3754), [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) governorVisual=null, [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) hint=null) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#afa4f831f6a77d61e37a127694414002a) () |
|  | Used for updating localized texts. |
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
| int | [Type](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#ada6d88be1d0178bd908e8b5d6f9fa0b8) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#ab654bf8642b4ce7b972d9f91e9031cae) `[get, set]` |
| int | [Value](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a5b93bf05424eab8aa6ae6865266222f8) `[get, set]` |
| string | [ValueString](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a03f2e737468b5e0528db82c2a527ac52) `[get]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [Hint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#abd54ff52f6090d1d5970d8905af013a0) `[get, set]` |
| string | [ColonText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#afbde219b6efd8be0bc9bc43a0c73a428) `[get, set]` |
| [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) | [GovernorVisual](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#adef56e8c96df2ae91a78093f1fab965e) `[get, set]` |
| bool | [ShowGovernorPortrait](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a5ca8c2e425c0857112be14406c33da42) `[get]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585d)PropertyType
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.PropertyType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585d) |

| Enumerator | |
| --- | --- |
| None |  |
| Tax |  |
| Tariff |  |
| Garrison |  |
| Village |  |
| Governor |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a01ca6673faaf9e1cd603dc9608ddd3ed)ProfitItemPropertyVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.ProfitItemPropertyVM | ( | string | *name*, |
|  |  | int | *value*, |
|  |  | [PropertyType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585d) | *type* = [PropertyType::None](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a4b8336bea2269faf38a530688694585da6adf97f83acf6453d4a6a4b1070f3754), |
|  |  | [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) | *governorVisual* = null, |
|  |  | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | *hint* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#afa4f831f6a77d61e37a127694414002a)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#ada6d88be1d0178bd908e8b5d6f9fa0b8)Type
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.Type | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#ab654bf8642b4ce7b972d9f91e9031cae)Name
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.Name | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a5b93bf05424eab8aa6ae6865266222f8)Value
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.Value | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a03f2e737468b5e0528db82c2a527ac52)ValueString
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.ValueString | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#abd54ff52f6090d1d5970d8905af013a0)Hint
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.Hint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#afbde219b6efd8be0bc9bc43a0c73a428)ColonText
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.ColonText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#adef56e8c96df2ae91a78093f1fab965e)GovernorVisual
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.GovernorVisual | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_profit_item_property_v_m.html#a5ca8c2e425c0857112be14406c33da42)ShowGovernorPortrait
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ProfitItemPropertyVM.ShowGovernorPortrait | | get |

