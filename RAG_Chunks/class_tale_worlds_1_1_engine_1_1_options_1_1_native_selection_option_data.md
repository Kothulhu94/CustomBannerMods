--- SOURCE: class_tale_worlds_1_1_engine_1_1_options_1_1_native_selection_option_data.html ---

TaleWorlds.Engine.Options.NativeSelectionOptionData Class ReferenceInherits [TaleWorlds.Engine.Options.NativeOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_option_data.html), and [TaleWorlds.Engine.Options.ISelectionOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_selection_option_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NativeSelectionOptionData](class_tale_worlds_1_1_engine_1_1_options_1_1_native_selection_option_data.html#a32a2f65414784b0e4dace1fb37b2347d) ([NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) type) |
| int | [GetSelectableOptionsLimit](class_tale_worlds_1_1_engine_1_1_options_1_1_native_selection_option_data.html#a16efa37041f8451be233ae8ea5b72a84) () |
| IEnumerable< [SelectionData](struct_tale_worlds_1_1_engine_1_1_options_1_1_selection_data.html) > | [GetSelectableOptionNames](class_tale_worlds_1_1_engine_1_1_options_1_1_native_selection_option_data.html#a8744286af20067682c46e98f6782c454) () |
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
| Static Public Member Functions | |
| static int | [GetOptionsLimit](class_tale_worlds_1_1_engine_1_1_options_1_1_native_selection_option_data.html#a1ddb3d28df0c52fc9332b8cf4842d171) ([NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) optionType) |

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

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_selection_option_data.html#a32a2f65414784b0e4dace1fb37b2347d)NativeSelectionOptionData()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Engine.Options.NativeSelectionOptionData.NativeSelectionOptionData | ( | [NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | *type* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_selection_option_data.html#a16efa37041f8451be233ae8ea5b72a84)GetSelectableOptionsLimit()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Options.NativeSelectionOptionData.GetSelectableOptionsLimit | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.ISelectionOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_selection_option_data.html#acc3af1136c431e8fe0a236113bf83c93).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_selection_option_data.html#a8744286af20067682c46e98f6782c454)GetSelectableOptionNames()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [SelectionData](struct_tale_worlds_1_1_engine_1_1_options_1_1_selection_data.html) > TaleWorlds.Engine.Options.NativeSelectionOptionData.GetSelectableOptionNames | ( |  | ) |  |

Implements [TaleWorlds.Engine.Options.ISelectionOptionData](interface_tale_worlds_1_1_engine_1_1_options_1_1_i_selection_option_data.html#a7aff06aa5001f57a770c410faaddd60e).

[◆](class_tale_worlds_1_1_engine_1_1_options_1_1_native_selection_option_data.html#a1ddb3d28df0c52fc9332b8cf4842d171)GetOptionsLimit()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Options.NativeSelectionOptionData.GetOptionsLimit | ( | [NativeOptions.NativeOptionsType](class_tale_worlds_1_1_engine_1_1_options_1_1_native_options.html#a0284cbb7f37a93bee1fecd97d7c995e6) | *optionType* | ) |  | | static |

