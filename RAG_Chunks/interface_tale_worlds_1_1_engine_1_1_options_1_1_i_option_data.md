--- SOURCE: interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html ---

TaleWorlds.Engine.Options.IOptionData Interface ReferenceInherited by [TaleWorlds.Engine.Options.IBooleanOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_boolean_option_data.html), [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html), [TaleWorlds.Engine.Options.ISelectionOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_selection_option_data.html), [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html), [TaleWorlds.MountAndBlade.Options.ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| Public Attributes | |
|  | [string](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#adf2e41998906519c9ab40a682eac8082) |
|  | Returns if the option is disabled or not. If the option is disabled an explanation text id is expected. This is not a localized text but it's the text id for a localized text. |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a00120c8527f7f4527e62c7a18f781974)GetDefaultValue()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Options.IOptionData.GetDefaultValue | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a96395d7a674050fdfb6e25075ef3afeb), [TaleWorlds.MountAndBlade.Options.ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a3a40bc885346cc8c8d4de4e939ec556e), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ae0edadfe9156d1e2c16ea5fd8c1c5022).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f1c1b694ebc9ab0105a752d1d50198f)Commit()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Options.IOptionData.Commit | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a84aa397861ea883779a6f004bfa49262), [TaleWorlds.MountAndBlade.Options.ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#ab6254012e29c1c53b5b2d3c01065f39a), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#a08f5e5a2ba16df62ed84ff746e33b32a).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f4873722ca7b9d7ae53c5d92299a881)GetValue()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Options.IOptionData.GetValue | ( | bool | *forceRefresh* | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a23ab4432c57a1f2a8f569c7a6b5dae83), [TaleWorlds.MountAndBlade.Options.ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#aff840a5a143a03b9007920ddae5ed542), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#a146781fb465ba0d2dd58029f4abaa763).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a76fa07ebab18da40db63d5a8f8320700)SetValue()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Options.IOptionData.SetValue | ( | float | *value* | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#ada10ef2c08698e014adf7a77e7e544bd), [TaleWorlds.MountAndBlade.Options.ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a666dc931490cb57f1fbcd7cd8b3b7e74), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ad90620731bf0f7780c141958c5d46615).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a2a9e89ef1bc8897079954999fd37c2e3)GetOptionType()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| object TaleWorlds.Engine.Options.IOptionData.GetOptionType | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#ad3cc9bc25cfc6debac9c7f2058a3644f), [TaleWorlds.MountAndBlade.Options.ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a2da30be39fd8e8d3f4488734818cfdf2), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ad75216122e5b9b8ec3f29bd16d58f889).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a56d358b764efa059975b0ef924b5a468)IsNative()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Options.IOptionData.IsNative | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a35aa63260f42e3d917a52113c4b6398f), [TaleWorlds.MountAndBlade.Options.ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a801ddf962b8fff9124a78459d49d910f), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#ab7c48209126ae5b44930e1e983322600).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f60ea2bd06dc3bcaf7f983ad4e44b9e)IsAction()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Options.IOptionData.IsAction | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a1bdef0f2d2660b515e9b69965a5e053d), [TaleWorlds.MountAndBlade.Options.ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#ae95daad9c0e26789b049de6e04bd28c6), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#aed7c4e6abd07dc7a4789db21ce4daae2).

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a6cdcac6933e325f55d35e784f97de372)GetIsDisabledAndReasonID()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Options.IOptionData.GetIsDisabledAndReasonID | ( |  | ) |  |

Implemented in [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a339d35eb6e865875cbd84bcb2f8749d2), [TaleWorlds.MountAndBlade.Options.ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a527368f0e701aae7c010f94f64c0b022), and [TaleWorlds.MountAndBlade.Options.ManagedOptions.ManagedOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_managed_options_1_1_managed_option_data.html#af955edc5ee809bf6b8cdedcd6016941b).

Member Data Documentation
-------------------------

[◆](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#adf2e41998906519c9ab40a682eac8082)string
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.Engine.Options.IOptionData.string |

