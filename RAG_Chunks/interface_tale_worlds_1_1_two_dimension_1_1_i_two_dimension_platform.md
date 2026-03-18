--- SOURCE: interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html ---

TaleWorlds.TwoDimension.ITwoDimensionPlatform Interface ReferenceInherited by [TaleWorlds.Engine.GauntletUI.TwoDimensionEnginePlatform](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_two_dimension_engine_platform.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnFrameBegin](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#add71fbaf578afa78dc7076e8e513f303) () |
| void | [OnFrameEnd](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a28919819166d9d6b9ebba88d7bcd72de) () |
| void | [Clear](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#af960cad51b190ff6a6ed2904a099d6b5) () |
| void | [DrawImage](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a62873343b23846cd0fdb8994ab2a03be) ([SimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_simple_material.html) material, in [ImageDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_image_draw_object.html) drawObject2D, int layer) |
| void | [DrawText](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a918f2d714b76e78a055966d249cd0d74) ([TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) material, in [TextDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_text_draw_object.html) drawObject2D, int layer) |
| void | [SetScissor](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a4afbc96b21d148cc7ad797ddfb228b98) ([ScissorTestInfo](struct_tale_worlds_1_1_two_dimension_1_1_scissor_test_info.html) scissorTestInfo) |
| void | [ResetScissors](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ad575b20e0e5b8a525ffec0682e6d9252) () |
| void | [PlaySound](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ab52e92b9b5b02bc39b8909d4a56d3eda) (string soundName) |
| void | [CreateSoundEvent](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a07e8ac4a394a487bc20cd40a78c3793f) (string soundName) |
| void | [PlaySoundEvent](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#afd57db4999972fa6943498be5c98c056) (string soundName) |
| void | [StopAndRemoveSoundEvent](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ac3a46e75bfa17fd08aae281fbc17c44c) (string soundName) |
| void | [OpenOnScreenKeyboard](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#addb4b372a2cc47b93a933386cf3eff58) (string initialText, string descriptionText, int maxLength, int keyboardTypeEnum) |
| void | [BeginDebugPanel](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a1c5c93b90d2c9c9ef62dc5e4e8d40530) (string panelTitle) |
| void | [EndDebugPanel](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#af2759c0e7a20d410b8c7f4382c90a6bf) () |
| void | [DrawDebugText](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a7f6999e64c57179431ebfba1da5663cf) (string text) |
| bool | [DrawDebugTreeNode](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#af0b758240b572b67edd594922b19d58f) (string text) |
| void | [PopDebugTreeNode](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ae92a47807170157ed82f917ba252e36b) () |
| void | [DrawCheckbox](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ad4f8d23db3a552020541a4733327a23e) (string label, ref bool isChecked) |
| bool | [IsDebugItemHovered](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ab8bc960bd1ee9a754b54676dfd2d8418) () |
| bool | [IsDebugModeEnabled](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a4a35dce8fb1534e9f6a2925c0b76516d) () |

|  |  |
| --- | --- |
| Properties | |
| float | [Width](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a5a5c1819833abbd10e150102dacfc5c4) `[get]` |
| float | [Height](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ac19595dd00d8cf05222a2463b6984b53) `[get]` |
| float | [ReferenceWidth](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a54dd0c8fdb1dd003d4585256f02d8b79) `[get]` |
| float | [ReferenceHeight](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a4708be562facb4cd100518fb0f837b02) `[get]` |
| float | [ApplicationTime](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a4bf0ce6fcf6a924d0b601886cffa166d) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#add71fbaf578afa78dc7076e8e513f303)OnFrameBegin()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.OnFrameBegin | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a28919819166d9d6b9ebba88d7bcd72de)OnFrameEnd()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.OnFrameEnd | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#af960cad51b190ff6a6ed2904a099d6b5)Clear()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.Clear | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a62873343b23846cd0fdb8994ab2a03be)DrawImage()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.DrawImage | ( | [SimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_simple_material.html) | *material*, |
|  |  | in [ImageDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_image_draw_object.html) | *drawObject2D*, |
|  |  | int | *layer* ) |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a918f2d714b76e78a055966d249cd0d74)DrawText()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.DrawText | ( | [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) | *material*, |
|  |  | in [TextDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_text_draw_object.html) | *drawObject2D*, |
|  |  | int | *layer* ) |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a4afbc96b21d148cc7ad797ddfb228b98)SetScissor()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.SetScissor | ( | [ScissorTestInfo](struct_tale_worlds_1_1_two_dimension_1_1_scissor_test_info.html) | *scissorTestInfo* | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ad575b20e0e5b8a525ffec0682e6d9252)ResetScissors()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.ResetScissors | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ab52e92b9b5b02bc39b8909d4a56d3eda)PlaySound()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.PlaySound | ( | string | *soundName* | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a07e8ac4a394a487bc20cd40a78c3793f)CreateSoundEvent()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.CreateSoundEvent | ( | string | *soundName* | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#afd57db4999972fa6943498be5c98c056)PlaySoundEvent()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.PlaySoundEvent | ( | string | *soundName* | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ac3a46e75bfa17fd08aae281fbc17c44c)StopAndRemoveSoundEvent()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.StopAndRemoveSoundEvent | ( | string | *soundName* | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#addb4b372a2cc47b93a933386cf3eff58)OpenOnScreenKeyboard()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.OpenOnScreenKeyboard | ( | string | *initialText*, |
|  |  | string | *descriptionText*, |
|  |  | int | *maxLength*, |
|  |  | int | *keyboardTypeEnum* ) |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a1c5c93b90d2c9c9ef62dc5e4e8d40530)BeginDebugPanel()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.BeginDebugPanel | ( | string | *panelTitle* | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#af2759c0e7a20d410b8c7f4382c90a6bf)EndDebugPanel()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.EndDebugPanel | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a7f6999e64c57179431ebfba1da5663cf)DrawDebugText()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.DrawDebugText | ( | string | *text* | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#af0b758240b572b67edd594922b19d58f)DrawDebugTreeNode()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.ITwoDimensionPlatform.DrawDebugTreeNode | ( | string | *text* | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ae92a47807170157ed82f917ba252e36b)PopDebugTreeNode()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.PopDebugTreeNode | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ad4f8d23db3a552020541a4733327a23e)DrawCheckbox()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.ITwoDimensionPlatform.DrawCheckbox | ( | string | *label*, |
|  |  | ref bool | *isChecked* ) |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ab8bc960bd1ee9a754b54676dfd2d8418)IsDebugItemHovered()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.ITwoDimensionPlatform.IsDebugItemHovered | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a4a35dce8fb1534e9f6a2925c0b76516d)IsDebugModeEnabled()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.ITwoDimensionPlatform.IsDebugModeEnabled | ( |  | ) |  |

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a5a5c1819833abbd10e150102dacfc5c4)Width
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.ITwoDimensionPlatform.Width | | get |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#ac19595dd00d8cf05222a2463b6984b53)Height
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.ITwoDimensionPlatform.Height | | get |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a54dd0c8fdb1dd003d4585256f02d8b79)ReferenceWidth
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.ITwoDimensionPlatform.ReferenceWidth | | get |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a4708be562facb4cd100518fb0f837b02)ReferenceHeight
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.ITwoDimensionPlatform.ReferenceHeight | | get |

[◆](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html#a4bf0ce6fcf6a924d0b601886cffa166d)ApplicationTime
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.ITwoDimensionPlatform.ApplicationTime | | get |

