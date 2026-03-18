--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [EducationVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#ac63441224a374cc1391fd789cc5c7de5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, Action< bool > onDone, Action< [EducationCampaignBehavior.EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[]> onOptionSelect, Action< List< [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) >, List< [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) > > sendPossibleCharactersAndEquipment) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a64081faa9905aa8488453ce226a95269) () |
|  | Used for updating localized texts. |
| void | [ExecuteNextStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#af62e8c9b5b54b36d80ed394fdc197f7c) () |
| void | [ExecutePreviousStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#acd73c295c6442f809973faf3c2d21e1e) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aa414c5fea983447ce42fea580c65fa6e) () |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a0e5814c8cc17b2957c8b0ebf917bd723) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aa81b53ec5fa558db5314f9cd0b6827dc) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a40d04f47dc349b5c75ac1158ea084a4a) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aac7a515c6070463dd673c4523fa2c23a) `[get, set]` |
| string | [StageTitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aa99fec9d1e8a6e5a0cf1c0444a27bd39) `[get, set]` |
| string | [ChooseText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aea5d03dac23d165aedcce5b59fc17f61) `[get, set]` |
| string | [PageDescriptionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aa76ee29ee15373211ce5748fa992ddd6) `[get, set]` |
| string | [OptionEffectText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a42571114b5346ee56f86ee0d1ba46b13) `[get, set]` |
| string | [OptionDescriptionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#ac47ee69e1eee26b1c2bcadfad1508120) `[get, set]` |
| string | [NextText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a904f1db792f411c80e3c6eb65b33d44d) `[get, set]` |
| string | [PreviousText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#ae768d154e712d5d49db7b65d9bb37657) `[get, set]` |
| bool | [CanAdvance](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a4e3d70fa6dfa9a90e7c34a18d3bdba72) `[get, set]` |
| bool | [CanGoBack](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a02adb3d22c05bcfb62767aebfc4d98a0) `[get, set]` |
| bool | [OnlyHasOneOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a09ebc30acc0a5151bcc383f24ed0787b) `[get, set]` |
| MBBindingList< [EducationOptionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_option_v_m.html) > | [Options](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a6097084325b0886b8850143134100c51) `[get, set]` |
| [EducationGainedPropertiesVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_gained_properties_v_m.html) | [GainedPropertiesController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a5bc5395749169ee2bef96b6f74be20a4) `[get, set]` |
| [EducationReviewVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_review_v_m.html) | [Review](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a66c66a917bfb91514f54b0735f13c4db) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#ac63441224a374cc1391fd789cc5c7de5)EducationVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.EducationVM | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *child*, |
|  |  | Action< bool > | *onDone*, |
|  |  | Action< [EducationCampaignBehavior.EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[]> | *onOptionSelect*, |
|  |  | Action< List< [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) >, List< [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) > > | *sendPossibleCharactersAndEquipment* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a64081faa9905aa8488453ce226a95269)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#af62e8c9b5b54b36d80ed394fdc197f7c)ExecuteNextStage()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.ExecuteNextStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#acd73c295c6442f809973faf3c2d21e1e)ExecutePreviousStage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.ExecutePreviousStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aa414c5fea983447ce42fea580c65fa6e)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a0e5814c8cc17b2957c8b0ebf917bd723)SetCancelInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aa81b53ec5fa558db5314f9cd0b6827dc)SetDoneInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a40d04f47dc349b5c75ac1158ea084a4a)CancelInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aac7a515c6070463dd673c4523fa2c23a)DoneInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aa99fec9d1e8a6e5a0cf1c0444a27bd39)StageTitleText
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.StageTitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aea5d03dac23d165aedcce5b59fc17f61)ChooseText
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.ChooseText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#aa76ee29ee15373211ce5748fa992ddd6)PageDescriptionText
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.PageDescriptionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a42571114b5346ee56f86ee0d1ba46b13)OptionEffectText
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.OptionEffectText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#ac47ee69e1eee26b1c2bcadfad1508120)OptionDescriptionText
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.OptionDescriptionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a904f1db792f411c80e3c6eb65b33d44d)NextText
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.NextText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#ae768d154e712d5d49db7b65d9bb37657)PreviousText
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.PreviousText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a4e3d70fa6dfa9a90e7c34a18d3bdba72)CanAdvance
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.CanAdvance | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a02adb3d22c05bcfb62767aebfc4d98a0)CanGoBack
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.CanGoBack | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a09ebc30acc0a5151bcc383f24ed0787b)OnlyHasOneOption
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.OnlyHasOneOption | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a6097084325b0886b8850143134100c51)Options
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EducationOptionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_option_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.Options | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a5bc5395749169ee2bef96b6f74be20a4)GainedPropertiesController
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EducationGainedPropertiesVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_gained_properties_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.GainedPropertiesController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_v_m.html#a66c66a917bfb91514f54b0735f13c4db)Review
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EducationReviewVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_education_1_1_education_review_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Education.EducationVM.Review | | getset |

