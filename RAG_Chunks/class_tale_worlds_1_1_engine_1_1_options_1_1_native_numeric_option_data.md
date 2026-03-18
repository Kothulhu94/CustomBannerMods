--- SOURCE: class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html ---

TaleWorlds.Engine.Options.NativeNumericOptionData Class ReferenceInherits [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html), and [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NativeNumericOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a815be957966f0667b64567a553c5602f) ([NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) type) |
| float | [GetMinValue](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a080b460b8e1688abab2008b81a7bb762) () |
| float | [GetMaxValue](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a973174d7901970030634e641184aa87e) () |
| bool | [GetIsDiscrete](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a8b394e18e61a6549da3eb495cbe0747d) () |
| int | [GetDiscreteIncrementInterval](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#afec49314b858637ed53fb5becb614b43) () |
| bool | [GetShouldUpdateContinuously](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a2f162c1cad7fe5927e93a767f5b8839c) () |
|  | Represents if value should be updated while slider is moving rather than on release. |
| Public Member Functions inherited from [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html) | |
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
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html) | |
| readonly [NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | [Type](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#a570947abc13723ec74a2f42c7c67f6de) |
|  | [string](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#aa1f4a086256dc97a0fe209bb32038449) |
| Public Attributes inherited from [TaleWorlds.Engine.Options.IOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html) | |
|  | [string](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_option_data.html#adf2e41998906519c9ab40a682eac8082) |
|  | Returns if the option is disabled or not. If the option is disabled an explanation text id is expected. This is not a localized text but it's the text id for a localized text. |
| Protected Member Functions inherited from [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html) | |
|  | [NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html#ad296607eb4b9e573e0dd5aa8ffb2da7a) ([NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) type) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a815be957966f0667b64567a553c5602f)NativeNumericOptionData()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Engine.Options.NativeNumericOptionData.NativeNumericOptionData | ( | [NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | *type* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a080b460b8e1688abab2008b81a7bb762)GetMinValue()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Options.NativeNumericOptionData.GetMinValue | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#ae39e8944eb7f9376d7597ce6b4a997c1).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a973174d7901970030634e641184aa87e)GetMaxValue()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Options.NativeNumericOptionData.GetMaxValue | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a918e23d98b02ff3346f253589b5d8b17).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a8b394e18e61a6549da3eb495cbe0747d)GetIsDiscrete()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Options.NativeNumericOptionData.GetIsDiscrete | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a208a0c7ad79f9820a4b5c24e1fbf593f).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#afec49314b858637ed53fb5becb614b43)GetDiscreteIncrementInterval()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Options.NativeNumericOptionData.GetDiscreteIncrementInterval | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a97c7306e463595b071f15ff643135347).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_numeric_option_data.html#a2f162c1cad7fe5927e93a767f5b8839c)GetShouldUpdateContinuously()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Options.NativeNumericOptionData.GetShouldUpdateContinuously | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.INumericOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_numeric_option_data.html#a2b07652df874626bbae9615a009a9eb1).

