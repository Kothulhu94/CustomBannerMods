--- SOURCE: interface_tale_worlds_1_1_engine_1_1_options_1_1_i_boolean_option_data.html ---

TaleWorlds.Engine.Options.IBooleanOptionData Interface ReferenceInherits [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html).

Inherited by [TaleWorlds.Engine.Options.NativeBooleanOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_boolean_option_data.html), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedBooleanOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_boolean_option_data.html).

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Member Functions inherited from [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | |
| float | [GetDefaultValue](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a00120c8527f7f4527e62c7a18f781974) () |
| void | [Commit](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f1c1b694ebc9ab0105a752d1d50198f) () |
| float | [GetValue](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f4873722ca7b9d7ae53c5d92299a881) (bool forceRefresh) |
| void | [SetValue](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a76fa07ebab18da40db63d5a8f8320700) (float value) |
| object | [GetOptionType](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a2a9e89ef1bc8897079954999fd37c2e3) () |
| bool | [IsNative](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a56d358b764efa059975b0ef924b5a468) () |
| bool | [IsAction](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f60ea2bd06dc3bcaf7f983ad4e44b9e) () |
|  | Not everything we show in [Options](namespace_tale_worlds_1_1_engine_1_1_options.html) has to be Managed or Native option. We might need to show Actions like "Open Benchmark". IsAction represents if this Option is an Action and does NOT represent an option value. |
| bool | [GetIsDisabledAndReasonID](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a6cdcac6933e325f55d35e784f97de372) () |
| Public Attributes inherited from [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | |
|  | [string](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#adf2e41998906519c9ab40a682eac8082) |
|  | Returns if the option is disabled or not. If the option is disabled an explanation text id is expected. This is not a localized text but it's the text id for a localized text. |

