--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html ---

TaleWorlds.MountAndBlade.Options.ActionOptionData Class ReferenceInherits [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a28b3f862324e9c565904f35c769e7c0e) (ManagedOptionsType managedType, Action onAction) |
|  | [ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a52b57a4e1d571aa3d1a4b40e8bd9f99a) (NativeOptions.NativeOptionsType nativeType, Action onAction) |
|  | [ActionOptionData](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#ad21fade12e18895f715eb2a13f3d0b09) ([string](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a9b4d22cec6b25caa1b2ab868f4ccdf80) optionTypeId, Action onAction) |
| void | [Commit](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#ab6254012e29c1c53b5b2d3c01065f39a) () |
| float | [GetDefaultValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a3a40bc885346cc8c8d4de4e939ec556e) () |
| object | [GetOptionType](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a2da30be39fd8e8d3f4488734818cfdf2) () |
| float | [GetValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#aff840a5a143a03b9007920ddae5ed542) (bool forceRefresh) |
| bool | [IsNative](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a801ddf962b8fff9124a78459d49d910f) () |
| void | [SetValue](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a666dc931490cb57f1fbcd7cd8b3b7e74) (float value) |
| bool | [IsAction](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#ae95daad9c0e26789b049de6e04bd28c6) () |
|  | Not everything we show in [Options](namespace_tale_worlds_1_1_mount_and_blade_1_1_options.html) has to be Managed or Native option. We might need to show Actions like "Open Benchmark". IsAction represents if this Option is an Action and does NOT represent an option value. |
| bool | [GetIsDisabledAndReasonID](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a527368f0e701aae7c010f94f64c0b022) () |

|  |  |
| --- | --- |
| Public Attributes | |
|  | [string](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a9b4d22cec6b25caa1b2ab868f4ccdf80) |
| Public Attributes inherited from [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | |
|  | [string](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#adf2e41998906519c9ab40a682eac8082) |
|  | Returns if the option is disabled or not. If the option is disabled an explanation text id is expected. This is not a localized text but it's the text id for a localized text. |

|  |  |
| --- | --- |
| Properties | |
| Action | [OnAction](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a43bb0b8051c3f3b989475981a648d17c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a28b3f862324e9c565904f35c769e7c0e)ActionOptionData() [1/3]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Options.ActionOptionData.ActionOptionData | ( | ManagedOptionsType | *managedType*, |
|  |  | Action | *onAction* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a52b57a4e1d571aa3d1a4b40e8bd9f99a)ActionOptionData() [2/3]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Options.ActionOptionData.ActionOptionData | ( | NativeOptions.NativeOptionsType | *nativeType*, |
|  |  | Action | *onAction* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#ad21fade12e18895f715eb2a13f3d0b09)ActionOptionData() [3/3]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Options.ActionOptionData.ActionOptionData | ( | [string](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a9b4d22cec6b25caa1b2ab868f4ccdf80) | *optionTypeId*, |
|  |  | Action | *onAction* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#ab6254012e29c1c53b5b2d3c01065f39a)Commit()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Options.ActionOptionData.Commit | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f1c1b694ebc9ab0105a752d1d50198f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a3a40bc885346cc8c8d4de4e939ec556e)GetDefaultValue()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Options.ActionOptionData.GetDefaultValue | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a00120c8527f7f4527e62c7a18f781974).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a2da30be39fd8e8d3f4488734818cfdf2)GetOptionType()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| object TaleWorlds.MountAndBlade.Options.ActionOptionData.GetOptionType | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a2a9e89ef1bc8897079954999fd37c2e3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#aff840a5a143a03b9007920ddae5ed542)GetValue()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.Options.ActionOptionData.GetValue | ( | bool | *forceRefresh* | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f4873722ca7b9d7ae53c5d92299a881).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a801ddf962b8fff9124a78459d49d910f)IsNative()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Options.ActionOptionData.IsNative | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a56d358b764efa059975b0ef924b5a468).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a666dc931490cb57f1fbcd7cd8b3b7e74)SetValue()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Options.ActionOptionData.SetValue | ( | float | *value* | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a76fa07ebab18da40db63d5a8f8320700).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#ae95daad9c0e26789b049de6e04bd28c6)IsAction()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Options.ActionOptionData.IsAction | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f60ea2bd06dc3bcaf7f983ad4e44b9e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a527368f0e701aae7c010f94f64c0b022)GetIsDisabledAndReasonID()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Options.ActionOptionData.GetIsDisabledAndReasonID | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a6cdcac6933e325f55d35e784f97de372).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a9b4d22cec6b25caa1b2ab868f4ccdf80)string
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.MountAndBlade.Options.ActionOptionData.string |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_options_1_1_action_option_data.html#a43bb0b8051c3f3b989475981a648d17c)OnAction
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.MountAndBlade.Options.ActionOptionData.OnAction | | get |

