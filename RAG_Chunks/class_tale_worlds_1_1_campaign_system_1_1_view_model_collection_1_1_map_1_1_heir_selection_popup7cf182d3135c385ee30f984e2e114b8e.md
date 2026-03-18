--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [HeirSelectionPopupHeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a07d965fd82ec025271817fda66adf3d5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#aa5ba61d11df9bb523d30f58672adcabd) hero) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a195df9c2da4838e768bc57f3d0e506ad) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#afa54047067981f0212a29d0ffc56b9ee) () |
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
| Hero | [Hero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#aa5ba61d11df9bb523d30f58672adcabd) `[get]` |
| string | [Name](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a69f33e5e47fd499272d810d8eedaff9f) `[get, set]` |
| int | [Age](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#ae8641c5c1d06a8cf298a7b024d12c76b) `[get, set]` |
| string | [Culture](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a6c4e3f1d20401b8d8fb63143d13cb0e6) `[get, set]` |
| string | [Occupation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a27d009abe3038e70da2d8f43f36f21b6) `[get, set]` |
| string | [RelationToMainHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a843c386f36e1a9760589020c5f9b79e2) `[get, set]` |
| [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) | [Model](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#aff41ea5e262eee7bdce11b2f8c1d0f15) `[get, set]` |
| [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) | [ImageIdentifier](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#ae0c2f5f1f2b106ec52c3b8e97ee6e672) `[get, set]` |
| MBBindingList< [EncyclopediaTraitItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_trait_item_v_m.html) > | [Traits](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a7a0fc6c825c25599a1a4547a6110d71d) `[get, set]` |
| MBBindingList< [MarriageOfferPopupHeroAttributeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popupb7bf100d28c9a8869addd829d3a897f6.html) > | [Attributes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a66b4959c3adcca7ea078bd98473354f5) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a8f76a1154cf5b919a8a23e21b8bd7cee) `[get, set]` |
| MBBindingList< [EncyclopediaSkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_skill_v_m.html) > | [OtherSkills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#ab993fba82911c7796ea793f2125ab2d0) `[get, set]` |
| bool | [HasOtherSkills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#ae165b104c356ffa6426be91dc0bd71b1) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a07d965fd82ec025271817fda66adf3d5)HeirSelectionPopupHeroVM()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.HeirSelectionPopupHeroVM | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#aa5ba61d11df9bb523d30f58672adcabd) | *hero* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a195df9c2da4838e768bc57f3d0e506ad)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#afa54047067981f0212a29d0ffc56b9ee)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#aa5ba61d11df9bb523d30f58672adcabd)Hero
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Hero TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.Hero | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a69f33e5e47fd499272d810d8eedaff9f)Name
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.Name | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#ae8641c5c1d06a8cf298a7b024d12c76b)Age
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.Age | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a6c4e3f1d20401b8d8fb63143d13cb0e6)Culture
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.Culture | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a27d009abe3038e70da2d8f43f36f21b6)Occupation
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.Occupation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a843c386f36e1a9760589020c5f9b79e2)RelationToMainHero
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.RelationToMainHero | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#aff41ea5e262eee7bdce11b2f8c1d0f15)Model
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.Model | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#ae0c2f5f1f2b106ec52c3b8e97ee6e672)ImageIdentifier
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_character_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.ImageIdentifier | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a7a0fc6c825c25599a1a4547a6110d71d)Traits
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaTraitItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_trait_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.Traits | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a66b4959c3adcca7ea078bd98473354f5)Attributes
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[MarriageOfferPopupHeroAttributeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_marriage_offer_popupb7bf100d28c9a8869addd829d3a897f6.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.Attributes | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#a8f76a1154cf5b919a8a23e21b8bd7cee)IsSelected
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#ab993fba82911c7796ea793f2125ab2d0)OtherSkills
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaSkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_skill_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.OtherSkills | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html#ae165b104c356ffa6426be91dc0bd71b1)HasOtherSkills
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupHeroVM.HasOtherSkills | | getset |

