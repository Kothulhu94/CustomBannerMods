--- SOURCE: class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html ---

TaleWorlds.TwoDimension.TwoDimensionContext Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a465aa0bb7ce87d8c2c26fcc81762784e) ([ITwoDimensionPlatform](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html) platform, [ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) resourceContext, [ResourceDepot](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a1c1038202d6b792790f9ec04b97667eb) resourceDepot) |
| void | [PlaySound](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#aa96bee527a8a67449a420a3f5b2f0d89) (string soundName) |
| void | [CreateSoundEvent](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a3943bd0f90105a983295cf16d6d125a4) (string soundName) |
| void | [StopAndRemoveSoundEvent](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a0477fe575c280f0378e3ce5b3cb0f082) (string soundName) |
| void | [PlaySoundEvent](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a9062fb1297dc008d06341801d3c6073b) (string soundName) |
| void | [DrawImage](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#accc9c736d073780ec646d1d3d6c5d0bc) ([SimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_simple_material.html) material, in [ImageDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_image_draw_object.html) drawObject2D, int layer=0) |
| void | [DrawText](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a86193d78dc09e7167e9671dbd25a9c2c) ([TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) material, in [TextDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_text_draw_object.html) drawObject2D, int layer=0) |
| void | [BeginDebugPanel](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a6a81e9c809a98a47a50c408c0fd3a524) (string panelTitle) |
| void | [EndDebugPanel](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#abae02dfa8de070020079ac19cab99e54) () |
| void | [DrawDebugText](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a3c7e9cf3acff65fc91f81d371b9635bb) (string text) |
| bool | [DrawDebugTreeNode](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a77bac8d2a9ee17710a6316f9df05d987) (string text) |
| void | [PopDebugTreeNode](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#accc87b1b80cd02bca9a5d6a3503792bf) () |
| void | [DrawCheckbox](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a69a869749e04fbf0b27e48e908aaf1ea) (string label, ref bool isChecked) |
| bool | [IsDebugItemHovered](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a889c4b38372de736d8f0e01e5da2d8c8) () |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) | [LoadTexture](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a6911ba9710b3a15ddc820e34a4430b2c) (string name) |
| void | [SetScissor](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a476f7bbd335d8f1eb2928af3a796ed60) ([ScissorTestInfo](struct_tale_worlds_1_1_two_dimension_1_1_scissor_test_info.html) scissor) |
| void | [ResetScissor](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a606a86aa4f5de0ef7e5d265d2bb8c221) () |

|  |  |
| --- | --- |
| Properties | |
| float | [Width](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#ac55c4923d49345d7ea65009c98bdc495) `[get]` |
| float | [Height](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#ad35d9689a447f804b1428fd2531882dc) `[get]` |
| [ITwoDimensionPlatform](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html) | [Platform](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a69595a3a4b15b9bf8ea77d160e3da51e) `[get]` |
| [ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) | [ResourceContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a15700fccdbd251499c7aa449e81af1d8) `[get]` |
| ResourceDepot | [ResourceDepot](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a1c1038202d6b792790f9ec04b97667eb) `[get]` |
| bool | [IsDebugModeEnabled](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#ae7f02f2dc141bd9ba846c6f4d423973b) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a465aa0bb7ce87d8c2c26fcc81762784e)TwoDimensionContext()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.TwoDimension.TwoDimensionContext.TwoDimensionContext | ( | [ITwoDimensionPlatform](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html) | *platform*, |
|  |  | [ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) | *resourceContext*, |
|  |  | [ResourceDepot](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a1c1038202d6b792790f9ec04b97667eb) | *resourceDepot* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#aa96bee527a8a67449a420a3f5b2f0d89)PlaySound()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.PlaySound | ( | string | *soundName* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a3943bd0f90105a983295cf16d6d125a4)CreateSoundEvent()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.CreateSoundEvent | ( | string | *soundName* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a0477fe575c280f0378e3ce5b3cb0f082)StopAndRemoveSoundEvent()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.StopAndRemoveSoundEvent | ( | string | *soundName* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a9062fb1297dc008d06341801d3c6073b)PlaySoundEvent()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.PlaySoundEvent | ( | string | *soundName* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#accc9c736d073780ec646d1d3d6c5d0bc)DrawImage()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.DrawImage | ( | [SimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_simple_material.html) | *material*, |
|  |  | in [ImageDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_image_draw_object.html) | *drawObject2D*, |
|  |  | int | *layer* = 0 ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a86193d78dc09e7167e9671dbd25a9c2c)DrawText()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.DrawText | ( | [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) | *material*, |
|  |  | in [TextDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_text_draw_object.html) | *drawObject2D*, |
|  |  | int | *layer* = 0 ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a6a81e9c809a98a47a50c408c0fd3a524)BeginDebugPanel()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.BeginDebugPanel | ( | string | *panelTitle* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#abae02dfa8de070020079ac19cab99e54)EndDebugPanel()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.EndDebugPanel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a3c7e9cf3acff65fc91f81d371b9635bb)DrawDebugText()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.DrawDebugText | ( | string | *text* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a77bac8d2a9ee17710a6316f9df05d987)DrawDebugTreeNode()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.TwoDimensionContext.DrawDebugTreeNode | ( | string | *text* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#accc87b1b80cd02bca9a5d6a3503792bf)PopDebugTreeNode()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.PopDebugTreeNode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a69a869749e04fbf0b27e48e908aaf1ea)DrawCheckbox()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.DrawCheckbox | ( | string | *label*, |
|  |  | ref bool | *isChecked* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a889c4b38372de736d8f0e01e5da2d8c8)IsDebugItemHovered()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.TwoDimensionContext.IsDebugItemHovered | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a6911ba9710b3a15ddc820e34a4430b2c)LoadTexture()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Texture](class_tale_worlds_1_1_two_dimension_1_1_texture.html) TaleWorlds.TwoDimension.TwoDimensionContext.LoadTexture | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a476f7bbd335d8f1eb2928af3a796ed60)SetScissor()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.SetScissor | ( | [ScissorTestInfo](struct_tale_worlds_1_1_two_dimension_1_1_scissor_test_info.html) | *scissor* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a606a86aa4f5de0ef7e5d265d2bb8c221)ResetScissor()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionContext.ResetScissor | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#ac55c4923d49345d7ea65009c98bdc495)Width
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.TwoDimensionContext.Width | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#ad35d9689a447f804b1428fd2531882dc)Height
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.TwoDimensionContext.Height | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a69595a3a4b15b9bf8ea77d160e3da51e)Platform
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ITwoDimensionPlatform](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html) TaleWorlds.TwoDimension.TwoDimensionContext.Platform | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a15700fccdbd251499c7aa449e81af1d8)ResourceContext
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ITwoDimensionResourceContext](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_resource_context.html) TaleWorlds.TwoDimension.TwoDimensionContext.ResourceContext | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#a1c1038202d6b792790f9ec04b97667eb)ResourceDepot
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ResourceDepot TaleWorlds.TwoDimension.TwoDimensionContext.ResourceDepot | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html#ae7f02f2dc141bd9ba846c6f4d423973b)IsDebugModeEnabled
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.TwoDimensionContext.IsDebugModeEnabled | | get |

