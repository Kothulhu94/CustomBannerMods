--- SOURCE: class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html ---

TaleWorlds.Engine.Options.NativeOptionData Class ReferenceabstractInherits [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html).

Inherited by [TaleWorlds.Engine.Options.NativeBooleanOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_boolean_option_data.html), [TaleWorlds.Engine.Options.NativeNumericOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html), and [TaleWorlds.Engine.Options.NativeSelectionOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_selection_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual float | [GetDefaultValue](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a96395d7a674050fdfb6e25075ef3afeb) () |
| void | [Commit](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a84aa397861ea883779a6f004bfa49262) () |
| float | [GetValue](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a23ab4432c57a1f2a8f569c7a6b5dae83) (bool forceRefresh) |
| void | [SetValue](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#ada10ef2c08698e014adf7a77e7e544bd) (float value) |
| object | [GetOptionType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#ad3cc9bc25cfc6debac9c7f2058a3644f) () |
| bool | [IsNative](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a35aa63260f42e3d917a52113c4b6398f) () |
| bool | [IsAction](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a1bdef0f2d2660b515e9b69965a5e053d) () |
|  | Not everything we show in [Options](namespace_tale_worlds_1_1_engine_1_1_options.html) has to be Managed or Native option. We might need to show Actions like "Open Benchmark". IsAction represents if this Option is an Action and does NOT represent an option value. |
| bool | [GetIsDisabledAndReasonID](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a339d35eb6e865875cbd84bcb2f8749d2) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | [Type](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a570947abc13723ec74a2f42c7c67f6de) |
|  | [string](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#aa1f4a086256dc97a0fe209bb32038449) |
| Public Attributes inherited from [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | |
|  | [string](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#adf2e41998906519c9ab40a682eac8082) |
|  | Returns if the option is disabled or not. If the option is disabled an explanation text id is expected. This is not a localized text but it's the text id for a localized text. |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#ad296607eb4b9e573e0dd5aa8ffb2da7a) ([NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) type) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#ad296607eb4b9e573e0dd5aa8ffb2da7a)NativeOptionData()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.Engine.Options.NativeOptionData.NativeOptionData | ( | [NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | *type* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a96395d7a674050fdfb6e25075ef3afeb)GetDefaultValue()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual float TaleWorlds.Engine.Options.NativeOptionData.GetDefaultValue | ( |  | ) |  | | virtual |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a00120c8527f7f4527e62c7a18f781974).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a84aa397861ea883779a6f004bfa49262)Commit()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Options.NativeOptionData.Commit | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f1c1b694ebc9ab0105a752d1d50198f).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a23ab4432c57a1f2a8f569c7a6b5dae83)GetValue()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Options.NativeOptionData.GetValue | ( | bool | *forceRefresh* | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f4873722ca7b9d7ae53c5d92299a881).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#ada10ef2c08698e014adf7a77e7e544bd)SetValue()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Options.NativeOptionData.SetValue | ( | float | *value* | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a76fa07ebab18da40db63d5a8f8320700).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#ad3cc9bc25cfc6debac9c7f2058a3644f)GetOptionType()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| object TaleWorlds.Engine.Options.NativeOptionData.GetOptionType | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a2a9e89ef1bc8897079954999fd37c2e3).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a35aa63260f42e3d917a52113c4b6398f)IsNative()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Options.NativeOptionData.IsNative | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a56d358b764efa059975b0ef924b5a468).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a1bdef0f2d2660b515e9b69965a5e053d)IsAction()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Options.NativeOptionData.IsAction | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a5f60ea2bd06dc3bcaf7f983ad4e44b9e).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a339d35eb6e865875cbd84bcb2f8749d2)GetIsDisabledAndReasonID()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Options.NativeOptionData.GetIsDisabledAndReasonID | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#a6cdcac6933e325f55d35e784f97de372).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a570947abc13723ec74a2f42c7c67f6de)Type
---------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) TaleWorlds.Engine.Options.NativeOptionData.Type |

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#aa1f4a086256dc97a0fe209bb32038449)string
-----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.Engine.Options.NativeOptionData.string |

