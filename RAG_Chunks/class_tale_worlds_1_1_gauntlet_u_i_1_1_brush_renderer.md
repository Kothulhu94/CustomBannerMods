--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html ---

TaleWorlds.GauntletUI.BrushRenderer Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [BrushRendererAnimationState](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#ab937b41de0e827b9dd28c85f45f884d2) {     [None](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#ab937b41de0e827b9dd28c85f45f884d2a6adf97f83acf6453d4a6a4b1070f3754) ,     [PlayingAnimation](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#ab937b41de0e827b9dd28c85f45f884d2a1c60e361fd6a61c1561342dcad1a7fcd) ,     [PlayingBasicTranisition](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#ab937b41de0e827b9dd28c85f45f884d2a7dcdc7f1c817407777eb0fc869221845) ,     [Ended](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#ab937b41de0e827b9dd28c85f45f884d2a0157fbb99be9622bdaa6e544270c0622)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BrushRenderer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#ab16abd18a11a292e2432535c04f1c3ae) () |
| void | [Update](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#aa2d0218f5dfeb1bc0d4b72b4b008bc9c) (ulong frameNumber, float globalAnimTime, float dt) |
| bool | [IsUpdateNeeded](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#af5428f69fe66aad2d811c8d48a410d44) () |
| void | [Render](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a893d8ce521e14eff9cd3f00fd96dfe57) ([TwoDimensionDrawContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html) drawContext, in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) rect, float scale, float contextAlpha, Vector2 overlayOffset=default, Vector2 overlaySize=default) |
| [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) | [CreateTextMaterial](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a2079627f7b36c062aa5aa0fbec2855a3) ([TwoDimensionDrawContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html) drawContext) |
| void | [RestartAnimation](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a327fe60fdf54412b85979e34525415cc) () |
| void | [SetSeed](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a29528978dc17c13ca11f1d2fbc4507aa) (int seed) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [UseLocalTimer](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#af38273f9a1faa83a4dc8a77843479ff8) |

|  |  |
| --- | --- |
| Properties | |
| ulong | [LastUpdatedFrameNumber](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a60745635b6b83f4d4196671ccafc2103) `[get]` |
| bool | [ForcePixelPerfectPlacement](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a56b6da3845ee39aea08c9692ae167272) = false `[get, set]` |
| [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) | [CurrentStyle](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a1240889a45a14750fa1cb1c65e90fdf6) `[get]` |
| Brush | [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a02f06ff10fb290dde37c54b598636e5f) `[get, set]` |
| string | [CurrentState](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a2988b3a1ae21fdd60b56f0e2bf8a7e72) `[get, set]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#ab937b41de0e827b9dd28c85f45f884d2)BrushRendererAnimationState
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.GauntletUI.BrushRenderer.BrushRendererAnimationState](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#ab937b41de0e827b9dd28c85f45f884d2) |

| Enumerator | |
| --- | --- |
| None |  |
| PlayingAnimation |  |
| PlayingBasicTranisition |  |
| Ended |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#ab16abd18a11a292e2432535c04f1c3ae)BrushRenderer()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.GauntletUI.BrushRenderer.BrushRenderer | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#aa2d0218f5dfeb1bc0d4b72b4b008bc9c)Update()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushRenderer.Update | ( | ulong | *frameNumber*, |
|  |  | float | *globalAnimTime*, |
|  |  | float | *dt* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#af5428f69fe66aad2d811c8d48a410d44)IsUpdateNeeded()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.BrushRenderer.IsUpdateNeeded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a893d8ce521e14eff9cd3f00fd96dfe57)Render()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushRenderer.Render | ( | [TwoDimensionDrawContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html) | *drawContext*, |
|  |  | in [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) | *rect*, |
|  |  | float | *scale*, |
|  |  | float | *contextAlpha*, |
|  |  | Vector2 | *overlayOffset* = default, |
|  |  | Vector2 | *overlaySize* = default ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a2079627f7b36c062aa5aa0fbec2855a3)CreateTextMaterial()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextMaterial](class_tale_worlds_1_1_two_dimension_1_1_text_material.html) TaleWorlds.GauntletUI.BrushRenderer.CreateTextMaterial | ( | [TwoDimensionDrawContext](class_tale_worlds_1_1_two_dimension_1_1_two_dimension_draw_context.html) | *drawContext* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a327fe60fdf54412b85979e34525415cc)RestartAnimation()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushRenderer.RestartAnimation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a29528978dc17c13ca11f1d2fbc4507aa)SetSeed()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.BrushRenderer.SetSeed | ( | int | *seed* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#af38273f9a1faa83a4dc8a77843479ff8)UseLocalTimer
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.GauntletUI.BrushRenderer.UseLocalTimer |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a60745635b6b83f4d4196671ccafc2103)LastUpdatedFrameNumber
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.GauntletUI.BrushRenderer.LastUpdatedFrameNumber | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a56b6da3845ee39aea08c9692ae167272)ForcePixelPerfectPlacement
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.BrushRenderer.ForcePixelPerfectPlacement = false | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a1240889a45a14750fa1cb1c65e90fdf6)CurrentStyle
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Style](class_tale_worlds_1_1_gauntlet_u_i_1_1_style.html) TaleWorlds.GauntletUI.BrushRenderer.CurrentStyle | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a02f06ff10fb290dde37c54b598636e5f)Brush
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Brush TaleWorlds.GauntletUI.BrushRenderer.Brush | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush_renderer.html#a2988b3a1ae21fdd60b56f0e2bf8a7e72)CurrentState
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.BrushRenderer.CurrentState | | getset |

