--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

Inherited by [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.MPOptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_m_p_options_v_m.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [OptionsDataType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4d) : int {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4da6adf97f83acf6453d4a6a4b1070f3754) = -1 ,     [BooleanOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4da036b2fdc94817e614e5ff9c06e252e40) = 0 ,     [NumericOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4da566785d4dd481ed42ea6d26cf4b1d4b0) = 1 ,     [MultipleSelectionOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4daa8f64bec42f4268948ad5519dde901dd) = 3 ,     [InputOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4dab528f62341cff96190c387404e0f5c04) = 4 ,     [ActionOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4dad9de0bce724d885ee0ad3c2c5994d601) = 5   } |
| enum | [OptionsMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdc) {     [MainMenu](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdcaad1111b48f98329333237912fc3b371b) ,     [Singleplayer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdca1dcc626e56db5397bea841d584be1e46) ,     [Multiplayer](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdca901a7320e77e54c4794bd577399eb0a6)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [OptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a5ab804e11bfcdf33ba6b8cd97f5f612f) (bool autoHandleClose, [OptionsMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdc) optionsMode, Action< [KeyOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_key_option_v_m.html) > onKeybindRequest, Action onBrightnessExecute=null, Action onExposureExecute=null) |
|  | [OptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a71584055a23ded89b4c03c574e270223) ([OptionsMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdc) optionsMode, Action onClose, Action< [KeyOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_key_option_v_m.html) > onKeybindRequest, Action onBrightnessExecute=null, Action onExposureExecute=null) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ab02ba508865f5c1eb4ae773f08502f7f) () |
|  | Used for updating localized texts. |
| void | [ExecuteCloseOptions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ad08512f1dfefb94c903f9e7da4980b57) () |
| [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) | [GetActiveCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a64ac0917a06cd4b1aedad15d5993b4a2) () |
| int | [GetIndexOfCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#af2966e28715e60eb4fdb7ea7ee285542) ([ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) categoryVM) |
| float | [GetConfig](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#af44f7da2efb65f1ddccda8d292ba5eb0) ([IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) data) |
| void | [SetConfig](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a767a089ed3392389451eaf226d44ca38) ([IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) data, float val) |
| void | [SelectPreviousCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a7be4b79423f341309ec4813d3b9c4a7f) () |
| void | [SelectNextCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#aefc63835d43292b1ee62a6d27fdcc143) () |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ac4fe69425e0432bc86b042137ec2712b) () |
| void | [ExecuteCancel](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ad1b23f9998bef19e9bba6d5b330c152c) () |
| void | [ExecuteDone](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#afa0d7678b708405de4007b4c4a41bd32) () |
| bool | [IsOptionsChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#af651749f62fb04eb8c7aaf5081efbdfd) () |
| void | [SetDoneInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a11098d90b58edf7c78dce90b0675acad) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [SetCancelInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a766591f9acae7fbc2f205a5aae587b74) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [SetPreviousTabInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a654a108a9300b1c5f8a0ecdad235cdeb) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [SetNextTabInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ae9f9d254e710293daafb46ac85cc0689) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [SetResetInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a279bd6674bea3e18c170e888c0b0f497) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
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
| Protected Member Functions | |
| void | [OnBrightnessClick](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a8e5ab929eb268ae3a216adb6d32fee6b) () |
| void | [OnExposureClick](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ab9010f1cb7499f81ea9b7a2c35fa9954) () |
| void | [HandleCancel](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a8805a9f0523059a4ad191cde1a18f872) (bool autoHandleClose) |
| void | [OnDone](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a91b4d1cfd04d3a7aea2234038f055ba0) () |
| void | [ExecuteBenchmark](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a25effec8b76dcdf0f725b0d5bda305ab) () |
| void | [ExecuteReset](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a083130a8272d2acec8d6c9110f11567d) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) | [\_gameplayOptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a1d93e842f7539ffeda532ea95db8632c) |
| readonly [GameKeyOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_game_keys_1_1_game_key_option_category_v_m.html) | [\_gameKeyCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#acee43e583ea79959cb5113b90d711762) |
| readonly [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) | [\_performanceOptionCategory](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a811e6ddf2441dec5ee1b7c4ef287fbca) |
| readonly List< [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) > | [\_groupedCategories](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a4c2e4c66af3be85de7a5623e9a5bf4e5) |

|  |  |
| --- | --- |
| Properties | |
| [OptionsMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdc) | [CurrentOptionsMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a21987f5fc1a5d50b5a85666ebad60ef3) `[get]` |
| int | [CategoryIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a20fdacab75f071d63f1dff2194a6137a) `[get, set]` |
| string | [OptionsLbl](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a87dea75f6df5b2214fceca589bc932f8) `[get, set]` |
| string | [CancelLbl](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a346432f0c9f2ff53778ea510067e7fc0) `[get, set]` |
| string | [DoneLbl](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#af3576543aa4ba06527d088571e48ef02) `[get, set]` |
| string | [ResetLbl](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a4f51a63f9d6e51750178e571d3b2de58) `[get, set]` |
| bool | [IsConsole](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ac7615dbe64e52ee2215b25a169c38cea) `[get, set]` |
| bool | [IsDevelopmentMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ac00a813ee077b5b2be28bc0008c54199) `[get, set]` |
| string | [VideoMemoryUsageName](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ab8228f717a924f9214e01daa1ccbb9c7) `[get, set]` |
| string | [VideoMemoryUsageText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#abf355c496c9c028797772e85e4e6588f) `[get, set]` |
| float | [VideoMemoryUsageNormalized](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a24f2e022926a54f7d37d0b0ec6f1da85) `[get, set]` |
| [GameKeyOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_game_keys_1_1_game_key_option_category_v_m.html) | [GameKeyOptionGroups](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ae58320a9483a952ba5bbcaab72805e6b) `[get]` |
| [GamepadOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html) | [GamepadOptions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#aba3bd5b48eb7508a8ef8dab07295e0b7) `[get]` |
| [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) | [PerformanceOptions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#acd8bce90fa2a9cce5437b67084aa7022) `[get]` |
| [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) | [AudioOptions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ad53b9ec453dd4dac901088d07d1bcb5d) `[get]` |
| [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) | [GameplayOptions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a1de89eb8ef58d2a28e44bbb97b7402f8) `[get]` |
| [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) | [VideoOptions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#af1e249a75502362c19fca6e055767315) `[get]` |
| [BrightnessOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_brightness_option_v_m.html) | [BrightnessPopUp](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a22bbb2b1b7659818e880b2d478d43eda) `[get, set]` |
| [ExposureOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_exposure_option_v_m.html) | [ExposurePopUp](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a7a0c0e04b29d7ff2428f33846945cce7) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a1243b658d7e12d242f60bff1629d5f95) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a861bbabf69b8d5a98065afaf04eb9e3f) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [PreviousTabInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0458929a802c1cceb038b5942ea58249) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [NextTabInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a98950c5e2117cad26cba5524ba286b20) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ResetInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a5e3aa761ee83aea1c7804d75b486aa05) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4d)OptionsDataType
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.OptionsDataType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4d) : int |

| Enumerator | |
| --- | --- |
| None |  |
| BooleanOption |  |
| NumericOption |  |
| MultipleSelectionOption |  |
| InputOption |  |
| ActionOption |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdc)OptionsMode
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.OptionsMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdc) |

| Enumerator | |
| --- | --- |
| MainMenu |  |
| Singleplayer |  |
| Multiplayer |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a5ab804e11bfcdf33ba6b8cd97f5f612f)OptionsVM() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.OptionsVM | ( | bool | *autoHandleClose*, |
|  |  | [OptionsMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdc) | *optionsMode*, |
|  |  | Action< [KeyOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_key_option_v_m.html) > | *onKeybindRequest*, |
|  |  | Action | *onBrightnessExecute* = null, |
|  |  | Action | *onExposureExecute* = null ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a71584055a23ded89b4c03c574e270223)OptionsVM() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.OptionsVM | ( | [OptionsMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdc) | *optionsMode*, |
|  |  | Action | *onClose*, |
|  |  | Action< [KeyOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_key_option_v_m.html) > | *onKeybindRequest*, |
|  |  | Action | *onBrightnessExecute* = null, |
|  |  | Action | *onExposureExecute* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ab02ba508865f5c1eb4ae773f08502f7f)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ad08512f1dfefb94c903f9e7da4980b57)ExecuteCloseOptions()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.ExecuteCloseOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a8e5ab929eb268ae3a216adb6d32fee6b)OnBrightnessClick()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.OnBrightnessClick | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ab9010f1cb7499f81ea9b7a2c35fa9954)OnExposureClick()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.OnExposureClick | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a64ac0917a06cd4b1aedad15d5993b4a2)GetActiveCategory()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.GetActiveCategory | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#af2966e28715e60eb4fdb7ea7ee285542)GetIndexOfCategory()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.GetIndexOfCategory | ( | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) | *categoryVM* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#af44f7da2efb65f1ddccda8d292ba5eb0)GetConfig()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.GetConfig | ( | [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | *data* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a767a089ed3392389451eaf226d44ca38)SetConfig()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.SetConfig | ( | [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | *data*, |
|  |  | float | *val* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a7be4b79423f341309ec4813d3b9c4a7f)SelectPreviousCategory()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.SelectPreviousCategory | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#aefc63835d43292b1ee62a6d27fdcc143)SelectNextCategory()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.SelectNextCategory | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ac4fe69425e0432bc86b042137ec2712b)OnFinalize()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a8805a9f0523059a4ad191cde1a18f872)HandleCancel()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.HandleCancel | ( | bool | *autoHandleClose* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ad1b23f9998bef19e9bba6d5b330c152c)ExecuteCancel()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.ExecuteCancel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a91b4d1cfd04d3a7aea2234038f055ba0)OnDone()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.OnDone | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a25effec8b76dcdf0f725b0d5bda305ab)ExecuteBenchmark()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.ExecuteBenchmark | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#afa0d7678b708405de4007b4c4a41bd32)ExecuteDone()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.ExecuteDone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a083130a8272d2acec8d6c9110f11567d)ExecuteReset()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.ExecuteReset | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#af651749f62fb04eb8c7aaf5081efbdfd)IsOptionsChanged()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.IsOptionsChanged | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a11098d90b58edf7c78dce90b0675acad)SetDoneInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a766591f9acae7fbc2f205a5aae587b74)SetCancelInputKey()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a654a108a9300b1c5f8a0ecdad235cdeb)SetPreviousTabInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.SetPreviousTabInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ae9f9d254e710293daafb46ac85cc0689)SetNextTabInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.SetNextTabInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a279bd6674bea3e18c170e888c0b0f497)SetResetInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.SetResetInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a1d93e842f7539ffeda532ea95db8632c)\_gameplayOptionCategory
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.\_gameplayOptionCategory | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#acee43e583ea79959cb5113b90d711762)\_gameKeyCategory
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [GameKeyOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_game_keys_1_1_game_key_option_category_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.\_gameKeyCategory | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a811e6ddf2441dec5ee1b7c4ef287fbca)\_performanceOptionCategory
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.\_performanceOptionCategory | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a4c2e4c66af3be85de7a5623e9a5bf4e5)\_groupedCategories
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly List<[GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.\_groupedCategories | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a21987f5fc1a5d50b5a85666ebad60ef3)CurrentOptionsMode
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OptionsMode](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a668845559b60989fdc8987170febbbdc) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.CurrentOptionsMode | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a20fdacab75f071d63f1dff2194a6137a)CategoryIndex
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.CategoryIndex | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a87dea75f6df5b2214fceca589bc932f8)OptionsLbl
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.OptionsLbl | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a346432f0c9f2ff53778ea510067e7fc0)CancelLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.CancelLbl | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#af3576543aa4ba06527d088571e48ef02)DoneLbl
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.DoneLbl | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a4f51a63f9d6e51750178e571d3b2de58)ResetLbl
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.ResetLbl | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ac7615dbe64e52ee2215b25a169c38cea)IsConsole
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.IsConsole | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ac00a813ee077b5b2be28bc0008c54199)IsDevelopmentMode
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.IsDevelopmentMode | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ab8228f717a924f9214e01daa1ccbb9c7)VideoMemoryUsageName
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.VideoMemoryUsageName | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#abf355c496c9c028797772e85e4e6588f)VideoMemoryUsageText
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.VideoMemoryUsageText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a24f2e022926a54f7d37d0b0ec6f1da85)VideoMemoryUsageNormalized
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.VideoMemoryUsageNormalized | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ae58320a9483a952ba5bbcaab72805e6b)GameKeyOptionGroups
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameKeyOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_game_keys_1_1_game_key_option_category_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.GameKeyOptionGroups | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#aba3bd5b48eb7508a8ef8dab07295e0b7)GamepadOptions
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GamepadOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_gamepad_opt26bf0e1535aae606ac9b74ae72badf45.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.GamepadOptions | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#acd8bce90fa2a9cce5437b67084aa7022)PerformanceOptions
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.PerformanceOptions | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#ad53b9ec453dd4dac901088d07d1bcb5d)AudioOptions
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.AudioOptions | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a1de89eb8ef58d2a28e44bbb97b7402f8)GameplayOptions
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.GameplayOptions | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#af1e249a75502362c19fca6e055767315)VideoOptions
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GroupedOptionCategoryVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_grouped_option_category_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.VideoOptions | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a22bbb2b1b7659818e880b2d478d43eda)BrightnessPopUp
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BrightnessOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_brightness_option_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.BrightnessPopUp | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a7a0c0e04b29d7ff2428f33846945cce7)ExposurePopUp
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExposureOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_exposure_option_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.ExposurePopUp | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a1243b658d7e12d242f60bff1629d5f95)DoneInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a861bbabf69b8d5a98065afaf04eb9e3f)CancelInputKey
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0458929a802c1cceb038b5942ea58249)PreviousTabInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.PreviousTabInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a98950c5e2117cad26cba5524ba286b20)NextTabInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.NextTabInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a5e3aa761ee83aea1c7804d75b486aa05)ResetInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.OptionsVM.ResetInputKey | | getset |

