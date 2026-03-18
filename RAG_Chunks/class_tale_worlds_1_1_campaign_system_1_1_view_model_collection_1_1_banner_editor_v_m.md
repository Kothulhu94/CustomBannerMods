--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BannerEditorVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ace6c41f4aae1876d7605c60901485d16) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, [Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner, Action< bool > onExit, Action refresh, int currentStageIndex, int totalStagesCount, int furthestIndex, Action< int > goToIndex) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a5503c6baa9295155c184f22bb5a46c5e) () |
|  | Used for updating localized texts. |
| void | [RefreshSelectedColorsAndSigils](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a97006947e950412bdf3d482595ebd072) () |
| void | [SetClanRelatedRules](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a6010a60a548db83f40dcd80c05c9c760) (bool canChangeBackgroundColor) |
| void | [ExecuteSwitchColors](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a6fc468076869c34d8a2b3d9401762f2c) () |
| void | [ExecuteDone](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a6e162e629f38899a9feabf52b17818d2) () |
| void | [ExecuteCancel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#aeabddc0d6a85ba9ea3369ac09d7fa652) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ae1c0c323e62304b6cd983474b06912cb) () |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a749000e6e11f926b3ec3799fcaefa968) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#aba46b428948e13793a06d9cf68881481) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#afe6c7e40fc716c6dd2246245ccdd255d) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#abab802c3ffede58e742658b4361fef3c) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a49709666ff95c1bc90c285da4c804b0b) ([GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) gameAxisKey, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) keyName) |
| void | [ExecuteGoToIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ad2bbdd37f96890625242e80a54664856) (int index) |
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
| int | [ShieldSlotIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a887026eecd20fc521dda87b612f1c2ca) = (int)EquipmentIndex.Weapon3 |
| int | [CurrentShieldIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#aacfb08b2c0ec19b9f62b6b96c9c84b58) = 0 |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | [ShieldRosterElement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#adc145f25f449874b6efd18c6d7a8a481) |

|  |  |
| --- | --- |
| Properties | |
| [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | [Character](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a345b01374baffa6c3bec34611a81e55f) `[get]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a3855426376f091b20934b7d576c61708) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a30e9c7dddd9e1364a1471ea233181ae9) `[get, set]` |
| MBBindingList< [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) > | [CameraControlKeys](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a4dbac35506b2dbdaa3de6ece82937cd3) `[get, set]` |
| MBBindingList< [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) > | [CategoryNames](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a4b94076b74681a54977668859d4fd456) `[get, set]` |
| MBBindingList< [BannerIconVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_banner_editor_1_1_banner_icon_v_m.html) > | [IconsList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a09074dfb17d244bf0c8e07b7ec947813) `[get, set]` |
| MBBindingList< [BannerColorVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_banner_editor_1_1_banner_color_v_m.html) > | [PrimaryColorList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a165bb38206781e3b1f404b5d76d65bc5) `[get, set]` |
| MBBindingList< [BannerColorVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_banner_editor_1_1_banner_color_v_m.html) > | [SigilColorList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#add655aff27aaa734484246d327985e03) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RandomizeHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a6c226e46e49e68e238e4e7b905408615) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UndoHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a81fd247d8a835356bc3f79c5786fef5b) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RedoHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a1160d08e7d665e71d16ab7baf8bb11bf) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ResetHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ab020de025225eeb5d72e188c684a2680) `[get, set]` |
| string | [CurrentShieldName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a5015b74883d10088f2f9bff3bfedc87f) `[get, set]` |
| int | [MinIconSize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a212fb42cad2d815d3bc7e0881453694c) `[get, set]` |
| int | [MaxIconSize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ae32b848552b8b7e32b8adcd0f3ccbd6e) `[get, set]` |
| int | [CurrentIconSize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a9b4b0855950307f5f96db58e24b9b91f) `[get, set]` |
| string | [PrimaryColorText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#aac270172f7ee76fdac08315eca7fef15) `[get, set]` |
| string | [SizeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a9e802b962c738c857335cab4b7426091) `[get, set]` |
| string | [SigilColorText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a8ada2bded93de191e9c03d405de33b1e) `[get, set]` |
| string | [CancelText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#abb57f5b3d2e13b81813fc0c910bcbcc8) `[get, set]` |
| string | [DoneText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a4e8fea5dfe8217d123a5f448b3ce841e) `[get, set]` |
| [BannerViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_banner_editor_1_1_banner_view_model.html) | [BannerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a5fb2b02293a63d3b94fad379d040a36d) `[get, set]` |
| string | [IconCodes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ac4c4fd25aba8e551a535c59f3f3c8494) `[get, set]` |
| string | [ColorCodes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a9d049494296ab1c14d1f97882fcde9bb) `[get, set]` |
| bool | [CanChangeBackgroundColor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#aeedea277782d71d76d0c85819105087a) `[get, set]` |
| bool | [CharacterGamepadControlsEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ab7d3285907898fc7429050ddf9c1efb2) `[get, set]` |
| string | [Title](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ae960aea286ff2931ac1a737ce50205ac) `[get, set]` |
| string | [Description](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a477b3913cabfd9edff927773707c2e92) `[get, set]` |
| int | [TotalStageCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a741327c26e6ba2af5439c661f04489c0) `[get, set]` |
| int | [CurrentStageIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ae5d7a9813a9ce1047470d7bbfefa86df) `[get, set]` |
| int | [FurthestIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a4b16263a57f9d275b8a00cfb3aab36f1) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ace6c41f4aae1876d7605c60901485d16)BannerEditorVM()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.BannerEditorVM | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, |
|  |  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner*, |
|  |  | Action< bool > | *onExit*, |
|  |  | Action | *refresh*, |
|  |  | int | *currentStageIndex*, |
|  |  | int | *totalStagesCount*, |
|  |  | int | *furthestIndex*, |
|  |  | Action< int > | *goToIndex* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a5503c6baa9295155c184f22bb5a46c5e)RefreshValues()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a97006947e950412bdf3d482595ebd072)RefreshSelectedColorsAndSigils()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.RefreshSelectedColorsAndSigils | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a6010a60a548db83f40dcd80c05c9c760)SetClanRelatedRules()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.SetClanRelatedRules | ( | bool | *canChangeBackgroundColor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a6fc468076869c34d8a2b3d9401762f2c)ExecuteSwitchColors()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.ExecuteSwitchColors | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a6e162e629f38899a9feabf52b17818d2)ExecuteDone()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.ExecuteDone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#aeabddc0d6a85ba9ea3369ac09d7fa652)ExecuteCancel()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.ExecuteCancel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ae1c0c323e62304b6cd983474b06912cb)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a749000e6e11f926b3ec3799fcaefa968)SetCancelInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#aba46b428948e13793a06d9cf68881481)SetDoneInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#afe6c7e40fc716c6dd2246245ccdd255d)AddCameraControlInputKey() [1/3]
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.AddCameraControlInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#abab802c3ffede58e742658b4361fef3c)AddCameraControlInputKey() [2/3]
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.AddCameraControlInputKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a49709666ff95c1bc90c285da4c804b0b)AddCameraControlInputKey() [3/3]
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.AddCameraControlInputKey | ( | [GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) | *gameAxisKey*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *keyName* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ad2bbdd37f96890625242e80a54664856)ExecuteGoToIndex()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.ExecuteGoToIndex | ( | int | *index* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a887026eecd20fc521dda87b612f1c2ca)ShieldSlotIndex
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.ShieldSlotIndex = (int)EquipmentIndex.Weapon3 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#aacfb08b2c0ec19b9f62b6b96c9c84b58)CurrentShieldIndex
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.CurrentShieldIndex = 0 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#adc145f25f449874b6efd18c6d7a8a481)ShieldRosterElement
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.ShieldRosterElement |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a345b01374baffa6c3bec34611a81e55f)Character
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.Character | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a3855426376f091b20934b7d576c61708)CancelInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a30e9c7dddd9e1364a1471ea233181ae9)DoneInputKey
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a4dbac35506b2dbdaa3de6ece82937cd3)CameraControlKeys
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.CameraControlKeys | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a4b94076b74681a54977668859d4fd456)CategoryNames
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html)> TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.CategoryNames | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a09074dfb17d244bf0c8e07b7ec947813)IconsList
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[BannerIconVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_banner_editor_1_1_banner_icon_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.IconsList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a165bb38206781e3b1f404b5d76d65bc5)PrimaryColorList
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[BannerColorVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_banner_editor_1_1_banner_color_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.PrimaryColorList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#add655aff27aaa734484246d327985e03)SigilColorList
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[BannerColorVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_banner_editor_1_1_banner_color_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.SigilColorList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a6c226e46e49e68e238e4e7b905408615)RandomizeHint
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.RandomizeHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a81fd247d8a835356bc3f79c5786fef5b)UndoHint
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.UndoHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a1160d08e7d665e71d16ab7baf8bb11bf)RedoHint
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.RedoHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ab020de025225eeb5d72e188c684a2680)ResetHint
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.ResetHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a5015b74883d10088f2f9bff3bfedc87f)CurrentShieldName
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.CurrentShieldName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a212fb42cad2d815d3bc7e0881453694c)MinIconSize
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.MinIconSize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ae32b848552b8b7e32b8adcd0f3ccbd6e)MaxIconSize
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.MaxIconSize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a9b4b0855950307f5f96db58e24b9b91f)CurrentIconSize
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.CurrentIconSize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#aac270172f7ee76fdac08315eca7fef15)PrimaryColorText
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.PrimaryColorText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a9e802b962c738c857335cab4b7426091)SizeText
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.SizeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a8ada2bded93de191e9c03d405de33b1e)SigilColorText
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.SigilColorText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#abb57f5b3d2e13b81813fc0c910bcbcc8)CancelText
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.CancelText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a4e8fea5dfe8217d123a5f448b3ce841e)DoneText
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.DoneText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a5fb2b02293a63d3b94fad379d040a36d)BannerVM
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_banner_editor_1_1_banner_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.BannerVM | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ac4c4fd25aba8e551a535c59f3f3c8494)IconCodes
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.IconCodes | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a9d049494296ab1c14d1f97882fcde9bb)ColorCodes
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.ColorCodes | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#aeedea277782d71d76d0c85819105087a)CanChangeBackgroundColor
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.CanChangeBackgroundColor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ab7d3285907898fc7429050ddf9c1efb2)CharacterGamepadControlsEnabled
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.CharacterGamepadControlsEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ae960aea286ff2931ac1a737ce50205ac)Title
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.Title | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a477b3913cabfd9edff927773707c2e92)Description
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.Description | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a741327c26e6ba2af5439c661f04489c0)TotalStageCount
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.TotalStageCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#ae5d7a9813a9ce1047470d7bbfefa86df)CurrentStageIndex
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.CurrentStageIndex | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_banner_editor_v_m.html#a4b16263a57f9d275b8a00cfb3aab36f1)FurthestIndex
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.BannerEditorVM.FurthestIndex | | getset |

