--- SOURCE: interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html ---

TaleWorlds.Engine.Options.INumericOptionData Interface ReferenceInherits [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html).

Inherited by [TaleWorlds.Engine.Options.NativeNumericOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetMinValue](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#ae39e8944eb7f9376d7597ce6b4a997c1) () |
| float | [GetMaxValue](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a918e23d98b02ff3346f253589b5d8b17) () |
| bool | [GetIsDiscrete](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a208a0c7ad79f9820a4b5c24e1fbf593f) () |
| int | [GetDiscreteIncrementInterval](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a97c7306e463595b071f15ff643135347) () |
| bool | [GetShouldUpdateContinuously](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a2b07652df874626bbae9615a009a9eb1) () |
|  | Represents if value should be updated while slider is moving rather than on release. |
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

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | |
|  | [string](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#adf2e41998906519c9ab40a682eac8082) |
|  | Returns if the option is disabled or not. If the option is disabled an explanation text id is expected. This is not a localized text but it's the text id for a localized text. |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#ae39e8944eb7f9376d7597ce6b4a997c1)GetMinValue()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Options.INumericOptionData.GetMinValue | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeNumericOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a080b460b8e1688abab2008b81a7bb762), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#a8d7178742689fa2d78dba9cafbb74150).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a918e23d98b02ff3346f253589b5d8b17)GetMaxValue()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Options.INumericOptionData.GetMaxValue | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeNumericOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a973174d7901970030634e641184aa87e), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#ad4a4f045ce848b9f750d5fa30173a71c).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a208a0c7ad79f9820a4b5c24e1fbf593f)GetIsDiscrete()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Options.INumericOptionData.GetIsDiscrete | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeNumericOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a8b394e18e61a6549da3eb495cbe0747d), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#a9118b671b5fa897bf61774374ebb76f2).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a97c7306e463595b071f15ff643135347)GetDiscreteIncrementInterval()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Options.INumericOptionData.GetDiscreteIncrementInterval | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeNumericOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#afec49314b858637ed53fb5becb614b43), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#ac098c47620ff36bcdd958b62b1948501).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a2b07652df874626bbae9615a009a9eb1)GetShouldUpdateContinuously()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Options.INumericOptionData.GetShouldUpdateContinuously | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeNumericOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a2f162c1cad7fe5927e93a767f5b8839c), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#a535ab44bac25fdee7b7c04d34b06d26e).

