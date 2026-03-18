--- SOURCE: class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html ---

TaleWorlds.TwoDimension.TwoDimensionDrawContext Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TwoDimensionDrawContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#ab497a34002d0a9bc39e195983b0de275) () |
| void | [Reset](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a5e2c344c7f98c209c6b95242f95f5127) () |
| [SimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_simple_material.html) | [CreateSimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a3f454fd271edc0a4f4db9f7b7dd17ef4) () |
| [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) | [CreateTextMaterial](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a1f36bdfda99e8e4cbf57ff0ec3a24fd9) () |
| void | [PushScissor](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a2485518512c86d0683387e0fe1d69c6f) (in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) newScissorRectangle) |
| void | [PopScissor](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#ae3683a9778d51afe11d26cbb0104bbac) () |
| bool | [IsDiscardedByAnyScissor](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a527c00a2fb34b3cca0a3a5b83d1ca4c0) (in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) rect) |
| void | [SetCircualMask](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a45da5c3d92df79f48b078b579ba5c2d4) (Vector2 position, float radius, float smoothingRadius) |
| void | [ClearCircualMask](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a5613066d04222e65293bc1dcd67f26f3) () |
| void | [DrawTo](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#ab669230ca25ca3acb869dd7c4614a8e3) ([TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) twoDimensionContext) |
| void | [DrawSprite](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a65668d3d4678c5dfe72be0b6983e4984) ([Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) sprite, [SimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_simple_material.html) material, in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) rectangle, float scale) |
| void | [Draw](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#ae39a66d06d4b8578a42969aa1b9ea539) ([SimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_simple_material.html) material, in [ImageDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_image_draw_object.html) drawObject) |
| void | [Draw](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#af33d706b0e52617b0e71bf616831f92a) ([TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) material, in [TextDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_text_draw_object.html) drawObject) |
| void | [Draw](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a148c209af56103ab299d0ab01839080b) ([Text](class_tale_worlds_1_1_two_dimension_1_1_text.html) text, [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) materialOriginal, in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) parentRectangle, in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) rectangle) |

|  |  |
| --- | --- |
| Properties | |
| bool | [ScissorTestEnabled](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a444d28b7c62d33778d07e8c254d06189) `[get]` |
| bool | [CircularMaskEnabled](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#abfcd29cf9cef5956077fc82cd1201458) `[get]` |
| Vector2 | [CircularMaskCenter](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a2361f4895fd3746252b69f877a126515) `[get]` |
| float | [CircularMaskRadius](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a1a9d730f547579a0d2caef2d06dd9dc2) `[get]` |
| float | [CircularMaskSmoothingRadius](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#afbd6a96be2361d8b25bba700564b3228) `[get]` |
| [ScissorTestInfo](struct_tale_worlds_1_1_two_dimension_1_1_scissor_test_info.html) | [CurrentScissor](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#ad5afc79677d606a58c7bffab992b61c3) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#ab497a34002d0a9bc39e195983b0de275)TwoDimensionDrawContext()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.TwoDimension.TwoDimensionDrawContext.TwoDimensionDrawContext | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a5e2c344c7f98c209c6b95242f95f5127)Reset()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionDrawContext.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a3f454fd271edc0a4f4db9f7b7dd17ef4)CreateSimpleMaterial()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [SimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_simple_material.html) TaleWorlds.TwoDimension.TwoDimensionDrawContext.CreateSimpleMaterial | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a1f36bdfda99e8e4cbf57ff0ec3a24fd9)CreateTextMaterial()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) TaleWorlds.TwoDimension.TwoDimensionDrawContext.CreateTextMaterial | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a2485518512c86d0683387e0fe1d69c6f)PushScissor()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionDrawContext.PushScissor | ( | in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) | *newScissorRectangle* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#ae3683a9778d51afe11d26cbb0104bbac)PopScissor()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionDrawContext.PopScissor | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a527c00a2fb34b3cca0a3a5b83d1ca4c0)IsDiscardedByAnyScissor()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.TwoDimensionDrawContext.IsDiscardedByAnyScissor | ( | in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) | *rect* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a45da5c3d92df79f48b078b579ba5c2d4)SetCircualMask()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionDrawContext.SetCircualMask | ( | Vector2 | *position*, |
|  |  | float | *radius*, |
|  |  | float | *smoothingRadius* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a5613066d04222e65293bc1dcd67f26f3)ClearCircualMask()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionDrawContext.ClearCircualMask | ( |  | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#ab669230ca25ca3acb869dd7c4614a8e3)DrawTo()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionDrawContext.DrawTo | ( | [TwoDimensionContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_context.html) | *twoDimensionContext* | ) |  |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a65668d3d4678c5dfe72be0b6983e4984)DrawSprite()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionDrawContext.DrawSprite | ( | [Sprite](class_tale_worlds_1_1_two_dimension_1_1_sprite.html) | *sprite*, |
|  |  | [SimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_simple_material.html) | *material*, |
|  |  | in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) | *rectangle*, |
|  |  | float | *scale* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#ae39a66d06d4b8578a42969aa1b9ea539)Draw() [1/3]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionDrawContext.Draw | ( | [SimpleMaterial](class_tale_worlds_1_1_two_dimension_1_1_simple_material.html) | *material*, |
|  |  | in [ImageDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_image_draw_object.html) | *drawObject* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#af33d706b0e52617b0e71bf616831f92a)Draw() [2/3]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionDrawContext.Draw | ( | [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) | *material*, |
|  |  | in [TextDrawObject](struct_tale_worlds_1_1_two_dimension_1_1_text_draw_object.html) | *drawObject* ) |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a148c209af56103ab299d0ab01839080b)Draw() [3/3]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.TwoDimensionDrawContext.Draw | ( | [Text](class_tale_worlds_1_1_two_dimension_1_1_text.html) | *text*, |
|  |  | [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) | *materialOriginal*, |
|  |  | in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) | *parentRectangle*, |
|  |  | in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) | *rectangle* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a444d28b7c62d33778d07e8c254d06189)ScissorTestEnabled
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.TwoDimensionDrawContext.ScissorTestEnabled | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#abfcd29cf9cef5956077fc82cd1201458)CircularMaskEnabled
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.TwoDimension.TwoDimensionDrawContext.CircularMaskEnabled | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a2361f4895fd3746252b69f877a126515)CircularMaskCenter
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Vector2 TaleWorlds.TwoDimension.TwoDimensionDrawContext.CircularMaskCenter | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#a1a9d730f547579a0d2caef2d06dd9dc2)CircularMaskRadius
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.TwoDimensionDrawContext.CircularMaskRadius | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#afbd6a96be2361d8b25bba700564b3228)CircularMaskSmoothingRadius
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.TwoDimensionDrawContext.CircularMaskSmoothingRadius | | get |

[◆](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html#ad5afc79677d606a58c7bffab992b61c3)CurrentScissor
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ScissorTestInfo](struct_tale_worlds_1_1_two_dimension_1_1_scissor_test_info.html) TaleWorlds.TwoDimension.TwoDimensionDrawContext.CurrentScissor | | get |

