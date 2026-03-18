--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM Class ReferenceInherits [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GamepadOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#afc5b81d4a76c61745f72fc2f5729cc1f) ([OptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html) options, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) category, bool isEnabled, bool isResetSupported=false) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#acc406b106ddd7075ee0b30c44a2b41b5) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a8df7265ca7b2487b489ae53757bd2537) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) | |
|  | [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#a930a8d4bcd768056dd3b994c075c1649) ([OptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html) options, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) category, bool isEnabled, bool isResetSupported=false) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#a47a828c3c576b649c06fce69db9a6688) () |
|  | Used for updating localized texts. |
| void | [ResetData](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#a2230ba9eebfb0dd84432f98510acf3a2) () |
| void | [ExecuteResetToDefault](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#adc19b5c8e65b5b12a41afcb67443ca6e) () |
| [GenericOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html) | [GetOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#abe37e65bce4a106ffb1510cea50a24cc) ([ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) optionType) |
| [GenericOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html) | [GetOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#a45e7bde6632c2bffcf922277b3c06d67) (NativeOptions.NativeOptionsType optionType) |
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
| int | [CurrentGamepadType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a91e423cd79fb23da31463bb9aa717a1c) `[get, set]` |
| MBBindingList< [GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html) > | [OtherKeys](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a1d4887b42e9edef7db8bb8e46d145ad3) `[get, set]` |
| MBBindingList< [GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html) > | [DpadKeys](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#aaf7fd7fda64880353cb3699071150056) `[get, set]` |
| MBBindingList< [GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html) > | [LeftTriggerAndBumperKeys](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#aa48ddafae67fb4156eeae832bfaf9d8a) `[get, set]` |
| MBBindingList< [GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html) > | [RightTriggerAndBumperKeys](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a19ed31d2d1a56eff4b0faa6afa40f206) `[get, set]` |
| MBBindingList< [GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html) > | [RightAnalogKeys](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a77917ddbc63aaf3c233fbee0b903553b) `[get, set]` |
| MBBindingList< [GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html) > | [LeftAnalogKeys](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a994829355eb566d5891435eb488d180d) `[get, set]` |
| MBBindingList< [GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html) > | [FaceKeys](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a2fe67699702794aceb0afb60f746540f) `[get, set]` |
| MBBindingList< SelectorVM< [SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html) > > | [Actions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#aee472679eb64c983a428c65fbe133ac3) `[get, set]` |
| Properties inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) | |
| IEnumerable< [GenericOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html) > | [AllOptions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#a3e73bc6fe31876b8640dfbe496f7fa61) `[get]` |
| bool | [IsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#ab034247515668fe766678b69888c24ee) `[get, set]` |
| bool | [IsResetSupported](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#a52376844b2e046ad466e7c2e839b21ca) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#ae6edd16e632208c68665a2096e617bde) `[get, set]` |
| string | [ResetText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#afac0095011d3991aee6d8e9ff70e6281) `[get, set]` |
| MBBindingList< [OptionGroupVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_option_group_v_m.html) > | [Groups](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#acc5e2a0277c4499405b2e494c5f558a5) `[get, set]` |
| MBBindingList< [GenericOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html) > | [BaseOptions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#a82ae97d95b98509da90cc3f261149745) `[get, set]` |

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
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) | |
| readonly [OptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html) | [\_options](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html#a0ce9769feaf80d8ba7444ace27fe58fe) |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#afc5b81d4a76c61745f72fc2f5729cc1f)GamepadOptionCategoryVM()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.GamepadOptionCategoryVM | ( | [OptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html) | *options*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [OptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_option_category.html) | *category*, |
|  |  | bool | *isEnabled*, |
|  |  | bool | *isResetSupported* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#acc406b106ddd7075ee0b30c44a2b41b5)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a8df7265ca7b2487b489ae53757bd2537)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a91e423cd79fb23da31463bb9aa717a1c)CurrentGamepadType
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.CurrentGamepadType | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a1d4887b42e9edef7db8bb8e46d145ad3)OtherKeys
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html)> TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.OtherKeys | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#aaf7fd7fda64880353cb3699071150056)DpadKeys
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html)> TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.DpadKeys | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#aa48ddafae67fb4156eeae832bfaf9d8a)LeftTriggerAndBumperKeys
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html)> TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.LeftTriggerAndBumperKeys | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a19ed31d2d1a56eff4b0faa6afa40f206)RightTriggerAndBumperKeys
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html)> TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.RightTriggerAndBumperKeys | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a77917ddbc63aaf3c233fbee0b903553b)RightAnalogKeys
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html)> TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.RightAnalogKeys | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a994829355eb566d5891435eb488d180d)LeftAnalogKeys
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html)> TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.LeftAnalogKeys | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#a2fe67699702794aceb0afb60f746540f)FaceKeys
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GamepadOptionKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt22329dfbdce6636c05a37a14edff08ee.html)> TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.FaceKeys | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html#aee472679eb64c983a428c65fbe133ac3)Actions
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<SelectorVM<[SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html)> > TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GamepadOptions.GamepadOptionCategoryVM.Actions | | getset |

