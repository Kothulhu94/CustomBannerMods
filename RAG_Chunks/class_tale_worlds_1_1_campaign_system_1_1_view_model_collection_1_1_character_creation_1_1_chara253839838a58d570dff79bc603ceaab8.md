--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationStageBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CharacterCreationNarrativeStageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a9a7e2d5066754db7006b9f2f427fcceb) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#abd6ce1244ce20eb6d509f2bf5ce40de5) characterCreationManagerMenu, Action affirmativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) affirmativeActionText, Action negativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) negativeActionText, Action onMenuChanged) |
| void | [RefreshMenu](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#ab520a73f11c4538db5ee2da2d7a7666f) () |
| void | [OnOptionSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a26d51df71495d3588e18d1e206772e9c) ([CharacterCreationOptionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_option_v_m.html) option) |
| override void | [OnNextStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a1eb03b6df2a97cdb79bd71ae3594b7bc) () |
| override void | [OnPreviousStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#aeee8fdd04f04ae0fff1d86193acc525c) () |
| override bool | [CanAdvanceToNextStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#aa91e3c7b0b7e8f544b499560bc288f3b) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a09c50d7c635bceb43a967cef2ecded56) () |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#afb2f35b85dfcd8aa5ef159995f222766) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a895ad324e6fd5285f78f7b0ac1037548) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationStageBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html) | |
| void | [OnNextStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#ac19461abd87346febc05e26428215e2c) () |
| void | [OnPreviousStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a7dda77e1a98104f3e522a776d8253ec3) () |
| bool | [CanAdvanceToNextStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#af22ec43f441101f45fd0feadd3b33d23) () |
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
| virtual void | [RefreshValues](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd) () |
|  | Used for updating localized texts. |

|  |  |
| --- | --- |
| Public Attributes | |
| Action | [OnOptionSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a2bea406317d9b01dce9bf474434bf10c) |

|  |  |
| --- | --- |
| Properties | |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a384510f13863d918d7e2728fe1686c5e) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a57e1342b5929ca96d8873b0eefc33e29) `[get, set]` |
| [CharacterCreationGainedPropertiesVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charab36511ce36e3d97a6ecdb9a6cfc6ad2e.html) | [GainedPropertiesController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#ac0c85504ddc1cc651bd84e48463b4e64) `[get, set]` |
| [CharacterCreationOptionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_option_v_m.html) | [SelectedOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a05f6b7c3393a72b838a12910fa283b58) `[get, set]` |
| MBBindingList< [CharacterCreationOptionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_option_v_m.html) > | [SelectionList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a97807c1f5ff28a6aa9d190a6275814cd) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationStageBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html) | |
| string | [Title](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#abcc1cb08239a16f0c899010994f7f31d) `[get, set]` |
| string | [Description](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a4b79dcbd11fcefb7a5830a68e1924257) `[get, set]` |
| string | [SelectionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#acf4ffb0e1e773e9e41ae299ae1381564) `[get, set]` |
| string | [NextStageText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a0ce53519f9a8573e81c5022a5afa6188) `[get, set]` |
| string | [PreviousStageText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#ac134f2acc4466b94f8977947d3212056) `[get, set]` |
| int | [TotalStageCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a63da28bc09feb4552945b37711cdf309) `[get, set]` |
| int | [FurthestIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a27283e183248160ee705bb9f413568dd) `[get, set]` |
| int | [CurrentStageIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a6ebcc7fccaa050e0ceda88e178ceb8bf) `[get, set]` |
| bool | [AnyItemSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#ad71230028768441d5c37cd6c58d0d269) `[get, set]` |
| bool | [CanAdvance](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a79d3bedf7a82473fcc400df3cc9c57f3) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationStageBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html) | |
|  | [CharacterCreationStageBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a35c13b807cc8c55b6826ac5b2a0de54b) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#abd6ce1244ce20eb6d509f2bf5ce40de5) characterCreationManager, Action affirmativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) affirmativeActionText, Action negativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) negativeActionText) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationStageBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html) | |
| readonly CharacterCreationManager | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#abd6ce1244ce20eb6d509f2bf5ce40de5) |
| readonly Action | [\_affirmativeAction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a8a0802252fba3501c947a40492354320) |
| readonly Action | [\_negativeAction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#af29882b4f73257a35fdbd93cbbd8b52d) |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_affirmativeActionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a43dc8c9b69f66dd157abed55ddc64d4a) |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_negativeActionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#a2a03cea68189d99142261763b3ef1b53) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a9a7e2d5066754db7006b9f2f427fcceb)CharacterCreationNarrativeStageVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.CharacterCreationNarrativeStageVM | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#abd6ce1244ce20eb6d509f2bf5ce40de5) | *characterCreationManagerMenu*, |
|  |  | Action | *affirmativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *affirmativeActionText*, |
|  |  | Action | *negativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *negativeActionText*, |
|  |  | Action | *onMenuChanged* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#ab520a73f11c4538db5ee2da2d7a7666f)RefreshMenu()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.RefreshMenu | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a26d51df71495d3588e18d1e206772e9c)OnOptionSelected()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.OnOptionSelected | ( | [CharacterCreationOptionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_option_v_m.html) | *option* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a1eb03b6df2a97cdb79bd71ae3594b7bc)OnNextStage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.OnNextStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#aeee8fdd04f04ae0fff1d86193acc525c)OnPreviousStage()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.OnPreviousStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#aa91e3c7b0b7e8f544b499560bc288f3b)CanAdvanceToNextStage()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.CanAdvanceToNextStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a09c50d7c635bceb43a967cef2ecded56)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#afb2f35b85dfcd8aa5ef159995f222766)SetCancelInputKey()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a895ad324e6fd5285f78f7b0ac1037548)SetDoneInputKey()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a2bea406317d9b01dce9bf474434bf10c)OnOptionSelection
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.OnOptionSelection |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a384510f13863d918d7e2728fe1686c5e)CancelInputKey
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a57e1342b5929ca96d8873b0eefc33e29)DoneInputKey
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#ac0c85504ddc1cc651bd84e48463b4e64)GainedPropertiesController
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterCreationGainedPropertiesVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charab36511ce36e3d97a6ecdb9a6cfc6ad2e.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.GainedPropertiesController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a05f6b7c3393a72b838a12910fa283b58)SelectedOption
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterCreationOptionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_option_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.SelectedOption | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_chara253839838a58d570dff79bc603ceaab8.html#a97807c1f5ff28a6aa9d190a6275814cd)SelectionList
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[CharacterCreationOptionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_option_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationNarrativeStageVM.SelectionList | | getset |

