--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MarriageOfferPopupHeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#aaf37aaa4076a7015602f34d576f8182c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a99d8a162670680f3c9ce217524323925) hero) |
| void | [Update](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a83c568f101f4a529a230d4f04b13e4e9) () |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#abb3fb83856acf22860cffbe47b40f895) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a17e72aff63871ace38b9b11ca466a6d7) () |
| void | [ExecuteHeroLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a7b0749eb5e5d799aba72b85b5a218d61) () |
| void | [ExecuteClanLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a4e62bd95533086537df915e32ed8898d) () |
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
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |

|  |  |
| --- | --- |
| Properties | |
| Hero | [Hero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a99d8a162670680f3c9ce217524323925) `[get]` |
| string | [EncyclopediaLinkWithName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a113fae15e69ce610cfe8955c2320152b) `[get, set]` |
| string | [AgeString](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a4f6fb8ca4899212538b0ae651eebd5ae) `[get, set]` |
| string | [OccupationString](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#aa502ee8ab1c0b4496c325ee3ecc1814e) `[get, set]` |
| int | [Relation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a485ac0882b53da5a4cb245d0b1ca4a6e) `[get, set]` |
| string | [ClanName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#aad6fc1935cb53634e37b07159095b2eb) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [ClanBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a31f08664a0414fbb64dcd6728f5633bb) `[get, set]` |
| [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) | [Model](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a952c462cacdf5f774736dbdd336a8f86) `[get, set]` |
| MBBindingList< [EncyclopediaTraitItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_trait_item_v_m.html) > | [Traits](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#aba5c9c585e3d0fab6f3665de67ff6671) `[get, set]` |
| MBBindingList< [MarriageOfferPopupHeroAttributeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popupb7bf100d28c9a8869addd829d3a897f6.html) > | [Attributes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#ae525dcb33c835b60f932a80dfc2b484a) `[get, set]` |
| MBBindingList< [EncyclopediaSkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_skill_v_m.html) > | [OtherSkills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a2403f92ae02ae3a526c16caf71294eea) `[get, set]` |
| bool | [HasOtherSkills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a1c6490e5509fd81de5dba7d27448dd16) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#aaf37aaa4076a7015602f34d576f8182c)MarriageOfferPopupHeroVM()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.MarriageOfferPopupHeroVM | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a99d8a162670680f3c9ce217524323925) | *hero* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a83c568f101f4a529a230d4f04b13e4e9)Update()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.Update | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#abb3fb83856acf22860cffbe47b40f895)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a17e72aff63871ace38b9b11ca466a6d7)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a7b0749eb5e5d799aba72b85b5a218d61)ExecuteHeroLink()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.ExecuteHeroLink | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a4e62bd95533086537df915e32ed8898d)ExecuteClanLink()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.ExecuteClanLink | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a99d8a162670680f3c9ce217524323925)Hero
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Hero TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.Hero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a113fae15e69ce610cfe8955c2320152b)EncyclopediaLinkWithName
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.EncyclopediaLinkWithName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a4f6fb8ca4899212538b0ae651eebd5ae)AgeString
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.AgeString | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#aa502ee8ab1c0b4496c325ee3ecc1814e)OccupationString
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.OccupationString | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a485ac0882b53da5a4cb245d0b1ca4a6e)Relation
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.Relation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#aad6fc1935cb53634e37b07159095b2eb)ClanName
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.ClanName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a31f08664a0414fbb64dcd6728f5633bb)ClanBanner
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.ClanBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a952c462cacdf5f774736dbdd336a8f86)Model
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.Model | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#aba5c9c585e3d0fab6f3665de67ff6671)Traits
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaTraitItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_trait_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.Traits | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#ae525dcb33c835b60f932a80dfc2b484a)Attributes
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[MarriageOfferPopupHeroAttributeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popupb7bf100d28c9a8869addd829d3a897f6.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.Attributes | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a2403f92ae02ae3a526c16caf71294eea)OtherSkills
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaSkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_skill_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.OtherSkills | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popup0e27e19de91af348f8c223cc6b937e1b.html#a1c6490e5509fd81de5dba7d27448dd16)HasOtherSkills
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MarriageOfferPopup.MarriageOfferPopupHeroVM.HasOtherSkills | | getset |

