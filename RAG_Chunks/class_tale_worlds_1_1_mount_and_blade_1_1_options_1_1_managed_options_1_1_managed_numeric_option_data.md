--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html ---

TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData Class ReferenceInherits [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html), and [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ManagedNumericOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#afeff255c2b0f723e3c98e2e2478e713f) ([MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) type) |
| float | [GetMinValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#a8d7178742689fa2d78dba9cafbb74150) () |
| float | [GetMaxValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#ad4a4f045ce848b9f750d5fa30173a71c) () |
| bool | [GetIsDiscrete](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#a9118b671b5fa897bf61774374ebb76f2) () |
| int | [GetDiscreteIncrementInterval](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#ac098c47620ff36bcdd958b62b1948501) () |
| bool | [GetShouldUpdateContinuously](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#a535ab44bac25fdee7b7c04d34b06d26e) () |
|  | Represents if value should be updated while slider is moving rather than on release. |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html) | |
| virtual float | [GetDefaultValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ae0edadfe9156d1e2c16ea5fd8c1c5022) () |
| void | [Commit](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#a08f5e5a2ba16df62ed84ff746e33b32a) () |
| float | [GetValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#a146781fb465ba0d2dd58029f4abaa763) (bool forceRefresh) |
| void | [SetValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ad90620731bf0f7780c141958c5d46615) (float value) |
| object | [GetOptionType](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ad75216122e5b9b8ec3f29bd16d58f889) () |
| bool | [IsNative](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ab7c48209126ae5b44930e1e983322600) () |
| bool | [IsAction](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aed7c4e6abd07dc7a4789db21ce4daae2) () |
|  | Not everything we show in [Options](namespace_tale_worlds_1_1_mount_and_blade_1_1_options.html) has to be Managed or Native option. We might need to show Actions like "Open Benchmark". IsAction represents if this Option is an Action and does NOT represent an option value. |
| bool | [GetIsDisabledAndReasonID](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#af955edc5ee809bf6b8cdedcd6016941b) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html) | |
| readonly [MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) | [Type](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aaf4843df823d285716fb1e3571b1c16a) |
|  | [string](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aebffb7b04729b445990a200ce9115320) |
| Public Attributes inherited from [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | |
|  | [string](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#adf2e41998906519c9ab40a682eac8082) |
|  | Returns if the option is disabled or not. If the option is disabled an explanation text id is expected. This is not a localized text but it's the text id for a localized text. |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html) | |
|  | [ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#abb63aa51300399a8c030a5b255aafb71) ([MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) type) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#afeff255c2b0f723e3c98e2e2478e713f)ManagedNumericOptionData()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData.ManagedNumericOptionData | ( | [MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) | *type* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#a8d7178742689fa2d78dba9cafbb74150)GetMinValue()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData.GetMinValue | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#ae39e8944eb7f9376d7597ce6b4a997c1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#ad4a4f045ce848b9f750d5fa30173a71c)GetMaxValue()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData.GetMaxValue | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a918e23d98b02ff3346f253589b5d8b17).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#a9118b671b5fa897bf61774374ebb76f2)GetIsDiscrete()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData.GetIsDiscrete | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a208a0c7ad79f9820a4b5c24e1fbf593f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#ac098c47620ff36bcdd958b62b1948501)GetDiscreteIncrementInterval()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData.GetDiscreteIncrementInterval | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a97c7306e463595b071f15ff643135347).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html#a535ab44bac25fdee7b7c04d34b06d26e)GetShouldUpdateContinuously()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData.GetShouldUpdateContinuously | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a2b07652df874626bbae9615a009a9eb1).

