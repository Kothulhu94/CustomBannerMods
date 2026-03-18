--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [HeirSelectionPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#aea7e73bc014b57a89d53306710a12c84) (Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > heirApparents) |
| void | [Update](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a8221c58e6c81bed4cd9016a194881cc1) () |
| void | [ExecuteSelectHeir](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a7c1f37c7761906fafd860f0b733d5060) () |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a69a35e25f75048f8417f802a0cbea9e4) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a073bca56e97afb247177a78d05acb9b8) () |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a8376a7f691699b044206ce9611d75b4d) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| string | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#aad7bfb08245007fd2d567c8d4eba7d28) `[get, set]` |
| string | [ButtonOkLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#afc1b445103bff0a9d24968196bef198e) `[get, set]` |
| string | [NameLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a57a6156c5b9b9a6e97d59114a7bd178c) `[get, set]` |
| string | [AgeLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a5c60ae3087fcb9624b2be8df1618542e) `[get, set]` |
| string | [CultureLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#aa7fc24140dc74410c52ce8f82a008011) `[get, set]` |
| string | [OccupationLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#ac2c77254a9294ee3565466cc79b16e3a) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [ClanBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a2ae223059ec5a30a76c0c79dc42310df) `[get, set]` |
| MBBindingList< [HeirSelectionPopupHeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html) > | [HeirApparents](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#ab989b07508f27735f8eac296bf11711c) `[get, set]` |
| [HeirSelectionPopupHeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html) | [CurrentSelectedHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#af43c0f81632849c6e26c8c14108e7cbb) `[get, set]` |
| bool | [AreHotkeysVisible](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a0f5dc0a686039bb39c366c39a5a67bb0) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a6e6fcb631ca5a83a9929efb1f1003bfe) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#aea7e73bc014b57a89d53306710a12c84)HeirSelectionPopupVM()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.HeirSelectionPopupVM | ( | Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > | *heirApparents* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a8221c58e6c81bed4cd9016a194881cc1)Update()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.Update | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a7c1f37c7761906fafd860f0b733d5060)ExecuteSelectHeir()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.ExecuteSelectHeir | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a69a35e25f75048f8417f802a0cbea9e4)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a073bca56e97afb247177a78d05acb9b8)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a8376a7f691699b044206ce9611d75b4d)SetDoneInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#aad7bfb08245007fd2d567c8d4eba7d28)TitleText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#afc1b445103bff0a9d24968196bef198e)ButtonOkLabel
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.ButtonOkLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a57a6156c5b9b9a6e97d59114a7bd178c)NameLabel
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.NameLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a5c60ae3087fcb9624b2be8df1618542e)AgeLabel
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.AgeLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#aa7fc24140dc74410c52ce8f82a008011)CultureLabel
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.CultureLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#ac2c77254a9294ee3565466cc79b16e3a)OccupationLabel
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.OccupationLabel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a2ae223059ec5a30a76c0c79dc42310df)ClanBanner
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.ClanBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#ab989b07508f27735f8eac296bf11711c)HeirApparents
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[HeirSelectionPopupHeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.HeirApparents | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#af43c0f81632849c6e26c8c14108e7cbb)CurrentSelectedHero
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeirSelectionPopupHeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup7cf182d3135c385ee30f984e2e114b8e.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.CurrentSelectedHero | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a0f5dc0a686039bb39c366c39a5a67bb0)AreHotkeysVisible
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.AreHotkeysVisible | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_heir_selection_popup_1_1_heir_selection_popup_v_m.html#a6e6fcb631ca5a83a9929efb1f1003bfe)DoneInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.HeirSelectionPopup.HeirSelectionPopupVM.DoneInputKey | | getset |

