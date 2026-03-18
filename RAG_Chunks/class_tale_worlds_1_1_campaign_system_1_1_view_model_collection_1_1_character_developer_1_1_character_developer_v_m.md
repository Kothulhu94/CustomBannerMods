--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CharacterDeveloperVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a3454b5c2fe2918f1e58656fa1880f15f) (Action closeCharacterDeveloper) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#af625398dbd3727b6693be163da5bd827) () |
|  | Used for updating localized texts. |
| void | [SelectHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a58cdd95a58917b2af9ca715d0a1a76ae) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [ExecuteReset](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a30bfa5f1c93b711c2d9ccd6773daa5e4) () |
| void | [ExecuteDone](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a593a48569be8004635474ab7f86c9fb1) () |
| void | [ExecuteCancel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a2ced40ca4158194e5faf684eda18c1bb) () |
| void | [ApplyAllChanges](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ac904fa2a14b846679d3e69091a9d432f) () |
| bool | [IsThereAnyChanges](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ad7e9d6667f708e7954274f20233945f6) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#aff3dae1a71842a86c3b2c9e2ef9dcca7) () |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a56b860159059ebfbecfcf57d5469be1d) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) gameKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#aaff01ee98e5a31efbb498c2756b8f149) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetResetInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a2fc1c8b02b3963539d553ef10e25be82) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetPreviousCharacterInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a16c477d5acca7f80b2e99748a556675a) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetNextCharacterInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ad6703cb42a60c891bd557b2a51054a90) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetGetKeyTextFromKeyIDFunc](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#af92a864f9a4a61c3b8452fae659e35d4) (Func< string, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > getKeyTextFromKeyId) |
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
| Public Attributes | |
| readonly ReadOnlyCollection< [CharacterDeveloperHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html) > | [HeroList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a3c2e63901c30f75d9c2b183cded12493) |

|  |  |
| --- | --- |
| Properties | |
| string | [CurrentCharacterNameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ab67a50def6b39c14554d671ce02cccef) `[get, set]` |
| [CharacterDeveloperHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html) | [CurrentCharacter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#afd5397bc43aef52954837794893668b2) `[get, set]` |
| SelectorVM< [SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html) > | [CharacterList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a0b8ead2e58c739afd5a3777b82e7eb37) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FocusVisualHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a44d36fefaf0eabdb408000ab0ef2df26) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ResetHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a923639919335553e48783f2706dd7e1f) `[get, set]` |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) | [TutorialNotification](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a08ace1f9be0d76e7912f4a44b5f11585) `[get, set]` |
| bool | [IsPlayerAccompanied](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a34f9416fbc87cad92b3bd720836ea8c0) `[get, set]` |
| string | [UnspentCharacterPointsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a8f924f69badf3e6a12fdb22195ba38f3) `[get, set]` |
| string | [TraitsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a07cce31f1c73c1e59bf47945ca05057e) `[get, set]` |
| string | [PartyRoleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#abbadd1dbfdc9e872a3c9e165fa80caf6) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UnspentCharacterPointsHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a5c856b10005d446d8036fc9f0789555f) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UnspentAttributePointsHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a03dd69fe18d90b086119520394045736) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [PreviousCharacterHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a5f90a448a27b2b28a7c7ecc925eec31c) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [NextCharacterHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#adc762d443f05950dffba1fe7576b7ca2) `[get, set]` |
| string | [DoneLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#aaec82ab5ee07cdd079f245eb8a75c99e) `[get, set]` |
| string | [ResetLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a464fc929cb75e9f7a1609e4b08d19286) `[get, set]` |
| string | [CancelLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a6cb667484a66f6bfa73af7a348d3b99c) `[get, set]` |
| string | [SkillFocusText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ae25a7f10cf400bde7ff7db3f336224ec) `[get, set]` |
| string | [AddFocusText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a7285a60fa5173cc7b191604057cd2af8) `[get, set]` |
| string | [SkillsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a5dd2f14f416b07db272b8cdfd15db6c5) `[get, set]` |
| int | [UnopenedPerksNumForOtherChars](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#aaff2872246e46ff0b8ea8b0f472cf8cb) `[get, set]` |
| bool | [HasUnopenedPerksForOtherCharacters](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ab4da2dfdec37a05c0765ebf7adbaf6a4) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#acbc01c92e95e7f99c32b21b1db4c2487) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a20a9503efafff7e30eb3abc3061bdb09) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ResetInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#adc9559149127f6dc60c194fbdfd5f573) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [PreviousCharacterInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a034c0a77e7af929154abe6fe8d969ecf) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [NextCharacterInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#aceee914dced82b7e13be3c794a4b2889) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a3454b5c2fe2918f1e58656fa1880f15f)CharacterDeveloperVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.CharacterDeveloperVM | ( | Action | *closeCharacterDeveloper* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#af625398dbd3727b6693be163da5bd827)RefreshValues()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a58cdd95a58917b2af9ca715d0a1a76ae)SelectHero()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.SelectHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a30bfa5f1c93b711c2d9ccd6773daa5e4)ExecuteReset()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.ExecuteReset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a593a48569be8004635474ab7f86c9fb1)ExecuteDone()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.ExecuteDone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a2ced40ca4158194e5faf684eda18c1bb)ExecuteCancel()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.ExecuteCancel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ac904fa2a14b846679d3e69091a9d432f)ApplyAllChanges()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.ApplyAllChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ad7e9d6667f708e7954274f20233945f6)IsThereAnyChanges()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.IsThereAnyChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#aff3dae1a71842a86c3b2c9e2ef9dcca7)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a56b860159059ebfbecfcf57d5469be1d)SetCancelInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#aaff01ee98e5a31efbb498c2756b8f149)SetDoneInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a2fc1c8b02b3963539d553ef10e25be82)SetResetInputKey()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.SetResetInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a16c477d5acca7f80b2e99748a556675a)SetPreviousCharacterInputKey()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.SetPreviousCharacterInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ad6703cb42a60c891bd557b2a51054a90)SetNextCharacterInputKey()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.SetNextCharacterInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#af92a864f9a4a61c3b8452fae659e35d4)SetGetKeyTextFromKeyIDFunc()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.SetGetKeyTextFromKeyIDFunc | ( | Func< string, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *getKeyTextFromKeyId* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a3c2e63901c30f75d9c2b183cded12493)HeroList
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly ReadOnlyCollection<[CharacterDeveloperHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.HeroList |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ab67a50def6b39c14554d671ce02cccef)CurrentCharacterNameText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.CurrentCharacterNameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#afd5397bc43aef52954837794893668b2)CurrentCharacter
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterDeveloperHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_hero_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.CurrentCharacter | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a0b8ead2e58c739afd5a3777b82e7eb37)CharacterList
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.CharacterList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a44d36fefaf0eabdb408000ab0ef2df26)FocusVisualHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.FocusVisualHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a923639919335553e48783f2706dd7e1f)ResetHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.ResetHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a08ace1f9be0d76e7912f4a44b5f11585)TutorialNotification
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.TutorialNotification | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a34f9416fbc87cad92b3bd720836ea8c0)IsPlayerAccompanied
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.IsPlayerAccompanied | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a8f924f69badf3e6a12fdb22195ba38f3)UnspentCharacterPointsText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.UnspentCharacterPointsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a07cce31f1c73c1e59bf47945ca05057e)TraitsText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.TraitsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#abbadd1dbfdc9e872a3c9e165fa80caf6)PartyRoleText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.PartyRoleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a5c856b10005d446d8036fc9f0789555f)UnspentCharacterPointsHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.UnspentCharacterPointsHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a03dd69fe18d90b086119520394045736)UnspentAttributePointsHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.UnspentAttributePointsHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a5f90a448a27b2b28a7c7ecc925eec31c)PreviousCharacterHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.PreviousCharacterHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#adc762d443f05950dffba1fe7576b7ca2)NextCharacterHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.NextCharacterHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#aaec82ab5ee07cdd079f245eb8a75c99e)DoneLbl
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.DoneLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a464fc929cb75e9f7a1609e4b08d19286)ResetLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.ResetLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a6cb667484a66f6bfa73af7a348d3b99c)CancelLbl
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.CancelLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ae25a7f10cf400bde7ff7db3f336224ec)SkillFocusText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.SkillFocusText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a7285a60fa5173cc7b191604057cd2af8)AddFocusText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.AddFocusText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a5dd2f14f416b07db272b8cdfd15db6c5)SkillsText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.SkillsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#aaff2872246e46ff0b8ea8b0f472cf8cb)UnopenedPerksNumForOtherChars
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.UnopenedPerksNumForOtherChars | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#ab4da2dfdec37a05c0765ebf7adbaf6a4)HasUnopenedPerksForOtherCharacters
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.HasUnopenedPerksForOtherCharacters | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#acbc01c92e95e7f99c32b21b1db4c2487)CancelInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a20a9503efafff7e30eb3abc3061bdb09)DoneInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#adc9559149127f6dc60c194fbdfd5f573)ResetInputKey
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.ResetInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#a034c0a77e7af929154abe6fe8d969ecf)PreviousCharacterInputKey
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.PreviousCharacterInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_character_developer_1_1_character_developer_v_m.html#aceee914dced82b7e13be3c794a4b2889)NextCharacterInputKey
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.CharacterDeveloper.CharacterDeveloperVM.NextCharacterInputKey | | getset |

