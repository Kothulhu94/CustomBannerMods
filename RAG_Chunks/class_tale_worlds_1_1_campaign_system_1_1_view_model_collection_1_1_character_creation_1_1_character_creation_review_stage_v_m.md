--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationStageBaseVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CharacterCreationReviewStageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#af767b6f2e90467f85bb4139ca16b1493) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#abd6ce1244ce20eb6d509f2bf5ce40de5) characterCreationManager, Action affirmativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) affirmativeActionText, Action negativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) negativeActionText, bool isBannerAndClanNameSet) |
| void | [ExecuteRandomizeName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a1d294d4d54b7895c28f788b2315b03e4) () |
| override void | [OnNextStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a2df067eecea76d5135df21cc5548e859) () |
| override void | [OnPreviousStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#ae59643f12907376421d680f19aabc339) () |
| override bool | [CanAdvanceToNextStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a62d71e7e3dc0dbe52eaa278ae2a85f6a) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a978adee80a980fa0982a0de8ae766bd0) () |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a3eb89e08fe54e7579251a9d97914e686) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a3077d70606720077ba2f66028e364adf) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a3bcd833ad883b83fe08951c501a08323) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a2134c2ee3a785f00be1bed95ddd7ae8c) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a276896a2bad95361805bc02a19071ea0) ([GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) gameAxisKey, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) keyName) |
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
| Properties | |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a6c61ca89788a50f6d64aba7247303ef2) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a9f293fcc407916ff9a19f9d9a046fac2) `[get, set]` |
| MBBindingList< [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) > | [CameraControlKeys](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a1efc0067d7af3faca7f1ab4a857daaad) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#aecbfab69a1a5684a256ea3b7b7725cc6) `[get, set]` |
| string | [NameTextQuestion](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a02b666be9a3804fbddbe79ad51e8ec96) `[get, set]` |
| MBBindingList< [CharacterCreationReviewStageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charab9714354c96ff12d0610cd7bfea65890.html) > | [ReviewList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#aed9d7ab0f5e2980007af5f16fea444b5) `[get, set]` |
| [CharacterCreationGainedPropertiesVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charab36511ce36e3d97a6ecdb9a6cfc6ad2e.html) | [GainedPropertiesController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#aa312e1f6f6ab539d77523096aa6fba13) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [ClanBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a3977db29fe66487806891521226f2102) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CannotAdvanceReasonHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#aaf5f1232257e6460cbd82b3250377533) `[get, set]` |
| bool | [CharacterGamepadControlsEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#ade433cec89728b863c81b120dbd2d565) `[get, set]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#af767b6f2e90467f85bb4139ca16b1493)CharacterCreationReviewStageVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.CharacterCreationReviewStageVM | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_stage_base_v_m.html#abd6ce1244ce20eb6d509f2bf5ce40de5) | *characterCreationManager*, |
|  |  | Action | *affirmativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *affirmativeActionText*, |
|  |  | Action | *negativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *negativeActionText*, |
|  |  | bool | *isBannerAndClanNameSet* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a1d294d4d54b7895c28f788b2315b03e4)ExecuteRandomizeName()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.ExecuteRandomizeName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a2df067eecea76d5135df21cc5548e859)OnNextStage()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.OnNextStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#ae59643f12907376421d680f19aabc339)OnPreviousStage()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.OnPreviousStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a62d71e7e3dc0dbe52eaa278ae2a85f6a)CanAdvanceToNextStage()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.CanAdvanceToNextStage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a978adee80a980fa0982a0de8ae766bd0)OnFinalize()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a3eb89e08fe54e7579251a9d97914e686)SetCancelInputKey()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a3077d70606720077ba2f66028e364adf)SetDoneInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a3bcd833ad883b83fe08951c501a08323)AddCameraControlInputKey() [1/3]
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.AddCameraControlInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a2134c2ee3a785f00be1bed95ddd7ae8c)AddCameraControlInputKey() [2/3]
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.AddCameraControlInputKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a276896a2bad95361805bc02a19071ea0)AddCameraControlInputKey() [3/3]
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.AddCameraControlInputKey | ( | [GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) | *gameAxisKey*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *keyName* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a6c61ca89788a50f6d64aba7247303ef2)CancelInputKey
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a9f293fcc407916ff9a19f9d9a046fac2)DoneInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a1efc0067d7af3faca7f1ab4a857daaad)CameraControlKeys
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.CameraControlKeys | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#aecbfab69a1a5684a256ea3b7b7725cc6)Name
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.Name | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a02b666be9a3804fbddbe79ad51e8ec96)NameTextQuestion
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.NameTextQuestion | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#aed9d7ab0f5e2980007af5f16fea444b5)ReviewList
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[CharacterCreationReviewStageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charab9714354c96ff12d0610cd7bfea65890.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.ReviewList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#aa312e1f6f6ab539d77523096aa6fba13)GainedPropertiesController
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterCreationGainedPropertiesVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_charab36511ce36e3d97a6ecdb9a6cfc6ad2e.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.GainedPropertiesController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#a3977db29fe66487806891521226f2102)ClanBanner
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.ClanBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#aaf5f1232257e6460cbd82b3250377533)CannotAdvanceReasonHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.CannotAdvanceReasonHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_creation_1_1_character_creation_review_stage_v_m.html#ade433cec89728b863c81b120dbd2d565)CharacterGamepadControlsEnabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation.CharacterCreationReviewStageVM.CharacterGamepadControlsEnabled | | getset |

