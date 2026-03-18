--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_item_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [KingdomSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a33271c42ae2cf972b799655803bd471a) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#ac7adc07dca33511de9bb8deee3bb0dd3) settlement, Action< KingdomSettlementItemVM > onSelect) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a8e3a70192e8dda23099e387e61f4d498) () |
|  | Used for updating localized texts. |
| void | [ExecuteLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a5bc08ed687fde1f59923ae72fbd85503) () |
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
| Public Attributes | |
| readonly Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#ac7adc07dca33511de9bb8deee3bb0dd3) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [UpdateProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a630c2dbe8018413aea7964efca2318b4) () |
| override void | [OnSelect](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a0e14d05d6f51c2745a771ae15556bc39) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| int | [Garrison](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#afb039230403c789a358bbad15828c2de) `[get]` |
| int | [Militia](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a24ae95b3cbaa80087c58fea798e3b2a8) `[get]` |
| MBBindingList< [SelectableFiefItemPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_selectable_fief_item_property_v_m.html) > | [ItemProperties](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#acdc9672958df17cb385aa6bd9886d59d) `[get, set]` |
| MBBindingList< [KingdomSettlementVillageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie1a143965e9f5a1825804ad75b3cafc42.html) > | [Villages](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a8a1d27cb8de8dfcd6da716a26342a61e) `[get, set]` |
| string | [IconPath](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#afb4fd03fc6ca26910627d51af428c835) `[get, set]` |
| int | [Defenders](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a0bd4a6651203ad1141487a69ea2f9d5a) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a6686c26ae1b97727470f4ba71222d1ae) `[get, set]` |
| string | [ImageName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#ab1b4d344b807bea02e0d5c37cf4128ef) `[get, set]` |
| string | [SettlementImagePath](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a9d5a0858d04b3fe0c52e1192de027e6b) `[get, set]` |
| string | [GovernorName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a8141d865a4eac1b30b6441b8df7277e5) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [OwnerClanBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a5d9c3950d44e9660a346e275cc550845) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [OwnerClanBanner\_9](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#aaea4f8f2b105dd62c4a69d73209d0649) `[get, set]` |
| [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#af9250f3a48fc611a6ad5cd9f04a14abe) `[get, set]` |
| int | [WallLevel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a319d016b0de1da9784457fb661a4b5b2) `[get, set]` |
| int | [Prosperity](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a4e512451b0b13af8e79892b2b43ebd0d) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_item_v_m.html) | |
| bool | [IsNew](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_item_v_m.html#a80b662cee8354d73d9d5d3edc857e231) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_item_v_m.html#aa01a7d2009dd40706be95b96b2da319c) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a33271c42ae2cf972b799655803bd471a)KingdomSettlementItemVM()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.KingdomSettlementItemVM | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#ac7adc07dca33511de9bb8deee3bb0dd3) | *settlement*, |
|  |  | Action< KingdomSettlementItemVM > | *onSelect* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a8e3a70192e8dda23099e387e61f4d498)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a630c2dbe8018413aea7964efca2318b4)UpdateProperties()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.UpdateProperties | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a0e14d05d6f51c2745a771ae15556bc39)OnSelect()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.OnSelect | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_item_v_m.html#a372976ae6182b67226bded335cc17fa3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a5bc08ed687fde1f59923ae72fbd85503)ExecuteLink()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.ExecuteLink | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#ac7adc07dca33511de9bb8deee3bb0dd3)Settlement
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Settlement TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.Settlement |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#afb039230403c789a358bbad15828c2de)Garrison
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.Garrison | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a24ae95b3cbaa80087c58fea798e3b2a8)Militia
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.Militia | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#acdc9672958df17cb385aa6bd9886d59d)ItemProperties
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[SelectableFiefItemPropertyVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_selectable_fief_item_property_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.ItemProperties | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a8a1d27cb8de8dfcd6da716a26342a61e)Villages
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[KingdomSettlementVillageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie1a143965e9f5a1825804ad75b3cafc42.html)> TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.Villages | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#afb4fd03fc6ca26910627d51af428c835)IconPath
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.IconPath | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a0bd4a6651203ad1141487a69ea2f9d5a)Defenders
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.Defenders | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a6686c26ae1b97727470f4ba71222d1ae)Name
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.Name | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#ab1b4d344b807bea02e0d5c37cf4128ef)ImageName
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.ImageName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a9d5a0858d04b3fe0c52e1192de027e6b)SettlementImagePath
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.SettlementImagePath | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a8141d865a4eac1b30b6441b8df7277e5)GovernorName
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.GovernorName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a5d9c3950d44e9660a346e275cc550845)OwnerClanBanner
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.OwnerClanBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#aaea4f8f2b105dd62c4a69d73209d0649)OwnerClanBanner\_9
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.OwnerClanBanner\_9 | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#af9250f3a48fc611a6ad5cd9f04a14abe)Owner
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.Owner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a319d016b0de1da9784457fb661a4b5b2)WallLevel
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.WallLevel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html#a4e512451b0b13af8e79892b2b43ebd0d)Prosperity
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementItemVM.Prosperity | | getset |

