--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BannerBuilderVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#afdedfce57d0945b74c3524d82a8982ba) ([BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, string initialKey, Action< bool > onExit, Action refresh, Action copyBannerCode) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#aaad6b1c36481410dc60e6e8434924119) () |
|  | Used for updating localized texts. |
| void | [ExecuteCancel](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ada37f38c954f3a34d6945a38ce429adf) () |
| void | [ExecuteDone](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#adcea369791dd9f226986c13f344f8c5f) () |
| void | [ExecuteAddDefaultLayer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a0399adc76a19dcd8d501aa1c7e86dfc0) () |
| void | [ExecuteDuplicateCurrentLayer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a9e2a559a3a3bdc84e07fb0267a717e45) () |
| void | [ExecuteCopyBannerCode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a654d32b6955400ff25f9c727133ddc9e) () |
| void | [ExecuteReorderWithParameters](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a57d2576fef3c46015f95165f04a0d645) ([BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html) layer, int index, string targetTag) |
| void | [ExecuteReorderToEndWithParameters](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a16c36ed03ad2faaf94a18d20d70c4851) ([BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html) layer, int index, string targetTag) |
| string | [GetBannerCode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a7edec703753841c24fddc3aa40b6df20) () |
| void | [SetBannerCode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a0b17d159861098c6dbe169eb8baac4f5) (string v) |
| void | [TranslateCurrentLayerWith](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ab429a487167d8b0d272d79d3f8c98386) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) moveDirection) |
| void | [DeleteCurrentLayer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a92041efbdda2a0d255f1cdaf91ae387e) () |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#aeaf38d877eca569a24ee337100727c1f) () |
| void | [SetCancelInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ae40f581b0783ed173b99ee201eb2ff76) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a94c97f492263988625d1505fc4e0c26f) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| int | [ShieldSlotIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a219abd0538df3f00e6db4c01d831ebe0) = (int)EquipmentIndex.Weapon3 |
| int | [CurrentShieldIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a5adb05e23b1324c678602e0341c5b47b) = 0 |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | [ShieldRosterElement](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ad1ceb1fddcd1b21a7543ce92faaaaa22) |

|  |  |
| --- | --- |
| Properties | |
| [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | [CurrentBanner](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a476581e91847d21f51aaeb9e2872afd1) `[get]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [BannerImageIdentifier](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a40964b54feb0edac78aa351215741731) `[get, set]` |
| string | [Title](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ac779c2483921c522dfc049d281286de4) `[get, set]` |
| MBBindingList< [BannerBuilderCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_category_v_m.html) > | [Categories](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#aa6da592aeef2afddd6338a5bbe3f9658) `[get, set]` |
| [BannerBuilderColorSelectionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_color_selection_v_m.html) | [ColorSelection](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a946739024d7b86045c3779e0520c7683) `[get, set]` |
| MBBindingList< [BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html) > | [Layers](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a401a325a7cee4a6d84d36a96ff56ff10) `[get, set]` |
| [BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html) | [CurrentSelectedLayer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a7830f4db020b14845059f2fa854e1a33) `[get, set]` |
| [BannerBuilderItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_item_v_m.html) | [CurrentSelectedItem](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a5ad341818ec3d40166a4fafc66183a69) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RandomizeHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#aa00d4b54c95b5446a4f2a4389523209d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UndoHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ae82a232d1f41c604b2fb7ffdc5c6ef8f) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RedoHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a6d24d70c4a3063827cacf8f892cad883) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ResetHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a253159b31c4d91ce09050a110f7151e3) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DrawStrokeHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a6f0c4cfe5049b829f1250d03e6198590) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CenterHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a6a61328699846d05763a88f51d7d145f) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ResetSizeHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#adf31d64f882349ed9b134283a693855f) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [MirrorHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a9f5e3062c349fca1ec04182a622eab5c) `[get, set]` |
| string | [CurrentShieldName](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a88d0e4900919b2dd2f5fbbc5bc633cbf) `[get, set]` |
| int | [MinIconSize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a27489fc94638eb8ccf8bada276031474) `[get, set]` |
| int | [MaxIconSize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ab125f8d6bca370ec7cda4a25fc2c0901) `[get, set]` |
| string | [BannerCodeAsString](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#afd02ddd9af8c4bc039889a19ac47023a) `[get, set]` |
| string | [CancelText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ae79e5e32db3013567be965acb4586c59) `[get, set]` |
| string | [DoneText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#aac406e6ae170eb19f1f7945e051a27fa) `[get, set]` |
| [BannerViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_banner_editor_1_1_banner_view_model.html) | [BannerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a9abce697ba9aac842a3d6688ad9bb2ad) `[get, set]` |
| string | [IconCodes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a6bdee45c07c9a95a3b27ccffd499dafe) `[get, set]` |
| string | [ColorCodes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ae79e32ce23010e542ce8432206dcf819) `[get, set]` |
| bool | [CanChangeBackgroundColor](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ab7c06a9ef31bee7e841850c07ead7608) `[get, set]` |
| bool | [IsBannerPreviewsActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a8dbdad302320d8e9dec6779816ef94b7) `[get, set]` |
| bool | [IsEditorPreviewActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ad5fd45fbca75163e1ad2ecc080b3f3c6) `[get, set]` |
| bool | [IsLayerPreviewActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#add3c1c2fd8906b70bf30c10f4204e270) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a34d57dd613b938b9fccf03e219cd99aa) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a3901e7dff34caf504d08494dba29a100) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#afdedfce57d0945b74c3524d82a8982ba)BannerBuilderVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.BannerBuilderVM | ( | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, |
|  |  | string | *initialKey*, |
|  |  | Action< bool > | *onExit*, |
|  |  | Action | *refresh*, |
|  |  | Action | *copyBannerCode* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#aaad6b1c36481410dc60e6e8434924119)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ada37f38c954f3a34d6945a38ce429adf)ExecuteCancel()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ExecuteCancel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#adcea369791dd9f226986c13f344f8c5f)ExecuteDone()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ExecuteDone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a0399adc76a19dcd8d501aa1c7e86dfc0)ExecuteAddDefaultLayer()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ExecuteAddDefaultLayer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a9e2a559a3a3bdc84e07fb0267a717e45)ExecuteDuplicateCurrentLayer()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ExecuteDuplicateCurrentLayer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a654d32b6955400ff25f9c727133ddc9e)ExecuteCopyBannerCode()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ExecuteCopyBannerCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a57d2576fef3c46015f95165f04a0d645)ExecuteReorderWithParameters()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ExecuteReorderWithParameters | ( | [BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html) | *layer*, |
|  |  | int | *index*, |
|  |  | string | *targetTag* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a16c36ed03ad2faaf94a18d20d70c4851)ExecuteReorderToEndWithParameters()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ExecuteReorderToEndWithParameters | ( | [BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html) | *layer*, |
|  |  | int | *index*, |
|  |  | string | *targetTag* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a7edec703753841c24fddc3aa40b6df20)GetBannerCode()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.GetBannerCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a0b17d159861098c6dbe169eb8baac4f5)SetBannerCode()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.SetBannerCode | ( | string | *v* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ab429a487167d8b0d272d79d3f8c98386)TranslateCurrentLayerWith()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.TranslateCurrentLayerWith | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *moveDirection* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a92041efbdda2a0d255f1cdaf91ae387e)DeleteCurrentLayer()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.DeleteCurrentLayer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#aeaf38d877eca569a24ee337100727c1f)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ae40f581b0783ed173b99ee201eb2ff76)SetCancelInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a94c97f492263988625d1505fc4e0c26f)SetDoneInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a219abd0538df3f00e6db4c01d831ebe0)ShieldSlotIndex
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ShieldSlotIndex = (int)EquipmentIndex.Weapon3 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a5adb05e23b1324c678602e0341c5b47b)CurrentShieldIndex
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.CurrentShieldIndex = 0 |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ad1ceb1fddcd1b21a7543ce92faaaaa22)ShieldRosterElement
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ShieldRosterElement |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a476581e91847d21f51aaeb9e2872afd1)CurrentBanner
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.CurrentBanner | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a40964b54feb0edac78aa351215741731)BannerImageIdentifier
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.BannerImageIdentifier | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ac779c2483921c522dfc049d281286de4)Title
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.Title | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#aa6da592aeef2afddd6338a5bbe3f9658)Categories
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[BannerBuilderCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_category_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.Categories | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a946739024d7b86045c3779e0520c7683)ColorSelection
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerBuilderColorSelectionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_color_selection_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ColorSelection | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a401a325a7cee4a6d84d36a96ff56ff10)Layers
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.Layers | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a7830f4db020b14845059f2fa854e1a33)CurrentSelectedLayer
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerBuilderLayerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_layer_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.CurrentSelectedLayer | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a5ad341818ec3d40166a4fafc66183a69)CurrentSelectedItem
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerBuilderItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.CurrentSelectedItem | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#aa00d4b54c95b5446a4f2a4389523209d)RandomizeHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.RandomizeHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ae82a232d1f41c604b2fb7ffdc5c6ef8f)UndoHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.UndoHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a6d24d70c4a3063827cacf8f892cad883)RedoHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.RedoHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a253159b31c4d91ce09050a110f7151e3)ResetHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ResetHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a6f0c4cfe5049b829f1250d03e6198590)DrawStrokeHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.DrawStrokeHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a6a61328699846d05763a88f51d7d145f)CenterHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.CenterHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#adf31d64f882349ed9b134283a693855f)ResetSizeHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ResetSizeHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a9f5e3062c349fca1ec04182a622eab5c)MirrorHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.MirrorHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a88d0e4900919b2dd2f5fbbc5bc633cbf)CurrentShieldName
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.CurrentShieldName | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a27489fc94638eb8ccf8bada276031474)MinIconSize
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.MinIconSize | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ab125f8d6bca370ec7cda4a25fc2c0901)MaxIconSize
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.MaxIconSize | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#afd02ddd9af8c4bc039889a19ac47023a)BannerCodeAsString
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.BannerCodeAsString | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ae79e5e32db3013567be965acb4586c59)CancelText
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.CancelText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#aac406e6ae170eb19f1f7945e051a27fa)DoneText
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.DoneText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a9abce697ba9aac842a3d6688ad9bb2ad)BannerVM
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_banner_editor_1_1_banner_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.BannerVM | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a6bdee45c07c9a95a3b27ccffd499dafe)IconCodes
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.IconCodes | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ae79e32ce23010e542ce8432206dcf819)ColorCodes
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.ColorCodes | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ab7c06a9ef31bee7e841850c07ead7608)CanChangeBackgroundColor
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.CanChangeBackgroundColor | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a8dbdad302320d8e9dec6779816ef94b7)IsBannerPreviewsActive
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.IsBannerPreviewsActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#ad5fd45fbca75163e1ad2ecc080b3f3c6)IsEditorPreviewActive
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.IsEditorPreviewActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#add3c1c2fd8906b70bf30c10f4204e270)IsLayerPreviewActive
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.IsLayerPreviewActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a34d57dd613b938b9fccf03e219cd99aa)CancelInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_banner_builder_1_1_banner_builder_v_m.html#a3901e7dff34caf504d08494dba29a100)DoneInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.BannerBuilder.BannerBuilderVM.DoneInputKey | | getset |

