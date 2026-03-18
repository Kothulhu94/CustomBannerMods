--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM Class ReferenceabstractInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

Inherited by [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.ActionOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_action_option_data_v_m.html), [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.BooleanOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_boolean_option_data_v_m.html), [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.NumericOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_numeric_option_data_v_m.html), and [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.StringOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_string_option_data_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [UpdateData](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a98cf06569cf73ac72c2f2fa565df02b8) (bool initUpdate) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a0cc81154f65129c538155efd93a155b6) () |
|  | Used for updating localized texts. |
| object | [GetOptionType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a9469526ed3de9b89d5627709b9b1a613) () |
| [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | [GetOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#ae999ff95ee6406362f78247f2fe8fef2) () |
| void | [ResetToDefault](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a7f1d37229bd04bba1bd3cca32773520a) () |
| void | [UpdateEnableState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a089bfeee1cee2d5017fa4231dd5c3a55) () |
| void | [UpdateValue](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a662ef76fef3accbd949dbfc477297215) () |
| void | [Cancel](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#ab4d6668b83975948cedfdb2ca6e3040c) () |
| bool | [IsChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a700929d9fb6c5b2026b883a4683a6592) () |
| void | [SetValue](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#afaa41df7e146fae4580af16997ef857b) (float value) |
| void | [ResetData](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a8b7f415424f4d0ee226e44e87c28f8cd) () |
| void | [ApplyValue](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#ae6abfe301d7ac4eeb47c17ffb29fd861) () |
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
| virtual void | [OnFinalize](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc) () |
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [GenericOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a0a547449093b7d2aa7dc35abfc0997e1) ([OptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html) optionsVM, [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) option, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, [OptionsVM.OptionsDataType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4d) typeID) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [OptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html) | [\_optionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a9cd57b723b03dc20eeab61d0b265d41e) |
| [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | [Option](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#abbfdedb7fb70025dbabe52cd34ec056b) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsNative](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#af6d5f2fba454626a4b644d56934ea092) `[get]` |
| bool | [IsAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#aa5299594d958b88d1cd758798438be7e) `[get]` |
| string | [Description](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a0422561d1549f3f49430a8c21f19721e) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a50dcac1597b9b4d01dfb397454c207e0) `[get, set]` |
| string[] | [ImageIDs](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a072f5905aed1b5358de69a4cae657740) `[get, set]` |
| int | [OptionTypeID](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a1f1d9a96b08a52ee5e6b50233cf3d7d9) `[get, set]` |
| bool | [IsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a0322bc6d073425973ede1c0941824fe0) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [Hint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a6c837903153e331da61c468063f076eb) `[get, set]` |

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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a0a547449093b7d2aa7dc35abfc0997e1)GenericOptionDataVM()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.GenericOptionDataVM | ( | [OptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html) | *optionsVM*, | |  |  | [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | *option*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, | |  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description*, | |  |  | [OptionsVM.OptionsDataType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html#a0f632655319d48b586abf9d385cb8c4d) | *typeID* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a98cf06569cf73ac72c2f2fa565df02b8)UpdateData()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.UpdateData | ( | bool | *initUpdate* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.StringOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_string_option_data_v_m.html#aaba804b5036ee010ff5f6709e02f488c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a0cc81154f65129c538155efd93a155b6)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

Reimplemented in [TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.StringOptionDataVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_string_option_data_v_m.html#abba2c9ee7aa5b9d2ed870e0edc0bde0f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a9469526ed3de9b89d5627709b9b1a613)GetOptionType()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| object TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.GetOptionType | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#ae999ff95ee6406362f78247f2fe8fef2)GetOptionData()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.GetOptionData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a7f1d37229bd04bba1bd3cca32773520a)ResetToDefault()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.ResetToDefault | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a089bfeee1cee2d5017fa4231dd5c3a55)UpdateEnableState()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.UpdateEnableState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a662ef76fef3accbd949dbfc477297215)UpdateValue()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.UpdateValue | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#ab4d6668b83975948cedfdb2ca6e3040c)Cancel()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.Cancel | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a700929d9fb6c5b2026b883a4683a6592)IsChanged()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.IsChanged | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#afaa41df7e146fae4580af16997ef857b)SetValue()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.SetValue | ( | float | *value* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a8b7f415424f4d0ee226e44e87c28f8cd)ResetData()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.ResetData | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#ae6abfe301d7ac4eeb47c17ffb29fd861)ApplyValue()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.ApplyValue | ( |  | ) |  | | abstract |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a9cd57b723b03dc20eeab61d0b265d41e)\_optionsVM
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OptionsVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_options_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.\_optionsVM | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#abbfdedb7fb70025dbabe52cd34ec056b)Option
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.Option | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#af6d5f2fba454626a4b644d56934ea092)IsNative
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.IsNative | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#aa5299594d958b88d1cd758798438be7e)IsAction
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.IsAction | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a0422561d1549f3f49430a8c21f19721e)Description
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.Description | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a50dcac1597b9b4d01dfb397454c207e0)Name
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.Name | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a072f5905aed1b5358de69a4cae657740)ImageIDs
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string [] TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.ImageIDs | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a1f1d9a96b08a52ee5e6b50233cf3d7d9)OptionTypeID
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.OptionTypeID | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a0322bc6d073425973ede1c0941824fe0)IsEnabled
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.IsEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_game_options_1_1_generic_option_data_v_m.html#a6c837903153e331da61c468063f076eb)Hint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.GameOptions.GenericOptionDataVM.Hint | | getset |

