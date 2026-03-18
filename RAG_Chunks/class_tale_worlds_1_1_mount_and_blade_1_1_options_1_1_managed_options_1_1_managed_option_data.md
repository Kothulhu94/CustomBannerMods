--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html ---

TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData Class ReferenceabstractInherits [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html).

Inherited by [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedBooleanOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_boolean_option_data.html), [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedNumericOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_numeric_option_data.html), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedSelectionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_selection_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| Public Attributes | |
| readonly [MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) | [Type](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aaf4843df823d285716fb1e3571b1c16a) |
|  | [string](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aebffb7b04729b445990a200ce9115320) |
| Public Attributes inherited from [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | |
|  | [string](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#adf2e41998906519c9ab40a682eac8082) |
|  | Returns if the option is disabled or not. If the option is disabled an explanation text id is expected. This is not a localized text but it's the text id for a localized text. |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#abb63aa51300399a8c030a5b255aafb71) ([MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) type) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#abb63aa51300399a8c030a5b255aafb71)ManagedOptionData()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.ManagedOptionData | ( | [MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) | *type* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ae0edadfe9156d1e2c16ea5fd8c1c5022)GetDefaultValue()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual float TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.GetDefaultValue | ( |  | ) |  | | virtual |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a00120c8527f7f4527e62c7a18f781974).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#a08f5e5a2ba16df62ed84ff746e33b32a)Commit()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.Commit | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f1c1b694ebc9ab0105a752d1d50198f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#a146781fb465ba0d2dd58029f4abaa763)GetValue()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.GetValue | ( | bool | *forceRefresh* | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f4873722ca7b9d7ae53c5d92299a881).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ad90620731bf0f7780c141958c5d46615)SetValue()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.SetValue | ( | float | *value* | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a76fa07ebab18da40db63d5a8f8320700).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ad75216122e5b9b8ec3f29bd16d58f889)GetOptionType()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| object TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.GetOptionType | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a2a9e89ef1bc8897079954999fd37c2e3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ab7c48209126ae5b44930e1e983322600)IsNative()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.IsNative | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a56d358b764efa059975b0ef924b5a468).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aed7c4e6abd07dc7a4789db21ce4daae2)IsAction()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.IsAction | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f60ea2bd06dc3bcaf7f983ad4e44b9e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#af955edc5ee809bf6b8cdedcd6016941b)GetIsDisabledAndReasonID()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.GetIsDisabledAndReasonID | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a6cdcac6933e325f55d35e784f97de372).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aaf4843df823d285716fb1e3571b1c16a)Type
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [MountAndBlade.ManagedOptions.ManagedOptionsType](class_tale_worlds_1_1_mount_and_blade_1_1_managed_options.html#a8cc69c007b27a91930052957f93415f3) TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.Type |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aebffb7b04729b445990a200ce9115320)string
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData.string |

