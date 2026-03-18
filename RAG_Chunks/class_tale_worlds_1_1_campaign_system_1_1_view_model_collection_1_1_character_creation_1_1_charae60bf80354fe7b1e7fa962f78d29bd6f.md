--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationStageBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CharacterCreationClanNamingStageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#ac4d5b075da9f13e2561d55e5901bcea6) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#abd6ce1244ce20eb6d509f2bf5ce40de5) characterCreationManager, Action affirmativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) affirmativeActionText, Action negativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) negativeActionText) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a8eca69e6a782be9aea801e57a4624ea1) () |
|  | Used for updating localized texts. |
| override bool | [CanAdvanceToNextStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a9e67df97a9d3be55d089f623899ba76d) () |
| override void | [OnNextStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#ab9ec4c21de64ca93db18677a0d2fc085) () |
| override void | [OnPreviousStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a7e9893404c8bdd49bc377254f89a28c5) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#ab7952032c7f4f8d66469df87a351ded3) () |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#ad00efa6fb21b5f729db2b3deac12790d) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a3e61134613c0bf61c18ed19da55c7bd5) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a16ca2118a8600be1324eb4bc4e69c2c1) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a1c0f020af5c761775e0b3f36c4f26cfd) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a2aed13436ea6d849b3a88eac36551708) ([GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) gameAxisKey, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) keyName) |
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

|  |  |
| --- | --- |
| Properties | |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [Character](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a2c924dd291b4b12a113a63f262dfc233) `[get]` |
| int | [ShieldSlotIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a326c839334b27ac069178f36a7476b71) = (int)EquipmentIndex.Weapon3 `[get]` |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | [ShieldRosterElement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a88de1f57d85a7f7434003505d66324b2) `[get]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a876c8742e024fb740ea3bcd7ba2499ce) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a679216dd78e7a07948e94d515e2399db) `[get, set]` |
| MBBindingList< [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) > | [CameraControlKeys](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a77793fa5b1a7964f876651d667782660) `[get, set]` |
| string | [ClanName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#aa7ff7935974c0a29ffb3a303dc143193) `[get, set]` |
| string | [ClanNameNotApplicableReason](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a0af803867a48de9b75ddd0c19525c305) `[get, set]` |
| string | [BottomHintText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a647720c699894f4b30e593a9a096e910) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [ClanBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a4cc403de3d2616dfa238b53370056f82) `[get, set]` |
| bool | [CharacterGamepadControlsEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a9bdb8c2c80ce8e44b6e32444c6e07bd7) `[get, set]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#ac4d5b075da9f13e2561d55e5901bcea6)CharacterCreationClanNamingStageVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.CharacterCreationClanNamingStageVM | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, |
|  |  | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#abd6ce1244ce20eb6d509f2bf5ce40de5) | *characterCreationManager*, |
|  |  | Action | *affirmativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *affirmativeActionText*, |
|  |  | Action | *negativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *negativeActionText* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a8eca69e6a782be9aea801e57a4624ea1)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a9e67df97a9d3be55d089f623899ba76d)CanAdvanceToNextStage()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.CanAdvanceToNextStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#ab9ec4c21de64ca93db18677a0d2fc085)OnNextStage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.OnNextStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a7e9893404c8bdd49bc377254f89a28c5)OnPreviousStage()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.OnPreviousStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#ab7952032c7f4f8d66469df87a351ded3)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#ad00efa6fb21b5f729db2b3deac12790d)SetCancelInputKey()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a3e61134613c0bf61c18ed19da55c7bd5)SetDoneInputKey()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a16ca2118a8600be1324eb4bc4e69c2c1)AddCameraControlInputKey() [1/3]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.AddCameraControlInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a1c0f020af5c761775e0b3f36c4f26cfd)AddCameraControlInputKey() [2/3]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.AddCameraControlInputKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a2aed13436ea6d849b3a88eac36551708)AddCameraControlInputKey() [3/3]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.AddCameraControlInputKey | ( | [GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) | *gameAxisKey*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *keyName* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a2c924dd291b4b12a113a63f262dfc233)Character
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.Character | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a326c839334b27ac069178f36a7476b71)ShieldSlotIndex
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.ShieldSlotIndex = (int)EquipmentIndex.Weapon3 | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a88de1f57d85a7f7434003505d66324b2)ShieldRosterElement
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.ShieldRosterElement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a876c8742e024fb740ea3bcd7ba2499ce)CancelInputKey
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a679216dd78e7a07948e94d515e2399db)DoneInputKey
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a77793fa5b1a7964f876651d667782660)CameraControlKeys
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.CameraControlKeys | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#aa7ff7935974c0a29ffb3a303dc143193)ClanName
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.ClanName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a0af803867a48de9b75ddd0c19525c305)ClanNameNotApplicableReason
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.ClanNameNotApplicableReason | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a647720c699894f4b30e593a9a096e910)BottomHintText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.BottomHintText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a4cc403de3d2616dfa238b53370056f82)ClanBanner
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.ClanBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charae60bf80354fe7b1e7fa962f78d29bd6f.html#a9bdb8c2c80ce8e44b6e32444c6e07bd7)CharacterGamepadControlsEnabled
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationClanNamingStageVM.CharacterGamepadControlsEnabled | | getset |

