--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html ---

TaleWorlds.GauntletUI.UIContext Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [MouseCursors](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8) {     [System](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8aa45da96d0bf6575970f2d27af22be28a) ,     [Default](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8a7a1920d61156abc05a60135aefe8bc67) ,     [Attack](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8adcfafcb4323b102c7e204555d313ba0a) ,     [Move](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8a6bc362dbf494c61ea117fe3c71ca48a5) ,     [HorizontalResize](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8aec283762599cd0bb0777b562a1d52a34) ,     [VerticalResize](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8ac5cc171df85d16a9660705ab64dddbb3) ,     [DiagonalRightResize](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8aea57a142119e17669ff33dde0aa242fa) ,     [DiagonalLeftResize](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8a0abd22469cc86b8320d5b1d7551de278) ,     [Rotate](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8a8d2de5368588552fbae54044ac5c7b3d) ,     [Custom](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8a90589c47f06eb971d548591f23c285af) ,     [Disabled](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8ab9f5c797ebbf55adccdd8539a65a0241) ,     [RightClickLink](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8abec046abe184bd3cb059d24c4a68399b)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aad1ffc0efa13b2337e62a2a3e5ac3b12) ([TwoDimensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab7a19dc2cbe6c94d2b7934ccb72df247) twoDimensionContext, [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) inputContext, [SpriteData](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a5d13ba97f8d6bd18c8e84707d3ee81c5) spriteData, [FontFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab81f4f6a6616ebe3c615ba7579ac41c1) fontFactory, [BrushFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab48292ecd047debf0d3144704a86a121) brushFactory) |
|  | [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a507ae176740f6645445591513c061a12) ([TwoDimensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab7a19dc2cbe6c94d2b7934ccb72df247) twoDimensionContext, [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) inputContext) |
| void | [Initialize](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a7b8523fc53465c313df547743a0bdebc) () |
| [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html) | [GetBrush](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ae2b235b775a37eccb69910d85ad0e687) (string name) |
| void | [RefreshResources](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a37bde21bb4202fbc8db6069de1079eb1) ([SpriteData](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a5d13ba97f8d6bd18c8e84707d3ee81c5) spriteData, [FontFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab81f4f6a6616ebe3c615ba7579ac41c1) fontFactory, [BrushFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab48292ecd047debf0d3144704a86a121) brushFactory) |
| void | [OnFinalize](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a88d316a3677058885d84047cec2e2f36) () |
| void | [Activate](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a68099a25cd9e006891e567847a4bfa1e) () |
| void | [Deactivate](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#afa8b2048da6b4febd84aaf4d1acf3093) () |
| void | [Update](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a0151eeaec4c6ec5d2f88414affae88bd) (float dt) |
| void | [LateUpdate](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a6e456972311ad5f22c0f3f89f9943d71) (float dt) |
| void | [RenderTick](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ad75dfb923dfbe1c559de67bd4ebc68ce) (float dt) |
| void | [InitializeGamepadNavigation](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a9cf7781147b1e5356d8a1253f174323e) ([IGamepadNavigationContext](interface_i_gamepad_navigation_context.html) context) |
| void | [OnOnScreenkeyboardTextInputDone](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aa0d27017e605f54b56a341acecec7ca5) (string inputText) |
| void | [OnOnScreenKeyboardCanceled](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a901e973c775e794fb5335e673f24b8d1) () |
| bool | [HitTest](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a9c2e1c40933246b9031f421bea435ce8) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) root, Vector2 position) |
| bool | [HitTest](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a49ca20a0842f84d83d3df3d4fa7b9622) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) root) |
| bool | [FocusTest](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a50f79dd03fbe9e0c9b84cd7d63103eb2) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) root) |
| void | [SetIsMouseEnabled](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ac7a4903e8bdb447b5b9cccd28ae3ca70) (bool isMouseEnabled) |
| void | [UpdateInput](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a0eee813f6016aabf8de869772f42f6da) ([InputType](namespace_tale_worlds_1_1_library.html#a2989ea5a8b573d6c49261568e1482bb4) handleInputs) |
| void | [OnMovieLoaded](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ae09c6d4f55592bea640e568e05899348) (string movieName) |
| void | [OnMovieReleased](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aab53dbd82d0bc4086c951bf031cdd9e8) (string movieName) |
| void | [DrawWidgetDebugInfo](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aa5addbf209e9ab9747da8010216d7831) () |

|  |  |
| --- | --- |
| Properties | |
| [MouseCursors](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8) | [ActiveCursorOfContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab4e2875b262af2b3dde3a114e91f2b67) `[get, set]` |
| bool | [IsDynamicScaleEnabled](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#add57cbe005acf653048c228fb01a3f00) = true `[get, set]` |
| float | [ScaleModifier](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a48e1a4d034d293cb875336f8e58da9c9) = 1 `[get, set]` |
| string | [Name](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ae02a82e522fc9ac895c486e6a4840f17) `[get, set]` |
| bool | [IsActive](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a0ce3faaa77c8cbb442e949d786e5b459) `[get]` |
| float | [ContextAlpha](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#afe2de9013249c509bdfb7411b30bca18) = 1f `[get, set]` |
|  | Used for setting alpha for the whole context. Every widget in this context will use this value to multiply/calculate their final alphavalues. |
| float | [Scale](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a37a48134cc042c3df196f095b79665d3) `[get]` |
| float | [CustomScale](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a5c54909096e884d66cbf9dba7223232d) `[get]` |
|  | Scale times with Custom modifier. |
| float | [CustomInverseScale](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a30a75579e68b9559dff101d9de78d8f8) `[get]` |
| string | [CurrentLanugageCode](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aab2b29a65b11e15236bd991cf21d4fb0) `[get]` |
| Random | [UIRandom](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a1ef73069b561b7d33b94ca731832afb6) `[get]` |
| float | [InverseScale](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a0d67c67d89a9cabd1132bee0e7b973a1) `[get]` |
| EventManager | [EventManager](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a50a762315e7906b0ccb3db9ac73b8c31) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [Root](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aba5e86ec3b24454ca63d59b6e5239f73) `[get]` |
| ResourceDepot | [ResourceDepot](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ae25cc0a7f92d5341dbb4af2d3f01c9f9) `[get]` |
| TwoDimensionContext | [TwoDimensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab7a19dc2cbe6c94d2b7934ccb72df247) `[get]` |
| IEnumerable< [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html) > | [Brushes](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a8d2ffb24e8aad8a4acfb52f57d49df57) `[get]` |
| [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html) | [DefaultBrush](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a3342b2afe3c77a7cfaf780e8e816ddc7) `[get]` |
| SpriteData | [SpriteData](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a5d13ba97f8d6bd18c8e84707d3ee81c5) `[get]` |
| BrushFactory | [BrushFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab48292ecd047debf0d3144704a86a121) `[get]` |
| FontFactory | [FontFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab81f4f6a6616ebe3c615ba7579ac41c1) `[get]` |
| [IReadonlyInputContext](interface_tale_worlds_1_1_gauntlet_u_i_1_1_gauntlet_input_1_1_i_readonly_input_context.html) | [InputContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a8e3d5fdd399f9a7300252702a4ebe11d) `[get]` |
| [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html) | [GamepadNavigation](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ad6b465b783c88ae585952ea365aef057) `[get]` |
| ulong | [LocalFrameNumber](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a264ebdbc9dce0f6766de8ffbdceb7991) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8)MouseCursors
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.GauntletUI.UIContext.MouseCursors](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8) |

| Enumerator | |
| --- | --- |
| System |  |
| Default |  |
| Attack |  |
| Move |  |
| HorizontalResize |  |
| VerticalResize |  |
| DiagonalRightResize |  |
| DiagonalLeftResize |  |
| Rotate |  |
| Custom |  |
| Disabled |  |
| RightClickLink |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aad1ffc0efa13b2337e62a2a3e5ac3b12)UIContext() [1/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.GauntletUI.UIContext.UIContext | ( | [TwoDimensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab7a19dc2cbe6c94d2b7934ccb72df247) | *twoDimensionContext*, |
|  |  | [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | *inputContext*, |
|  |  | [SpriteData](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a5d13ba97f8d6bd18c8e84707d3ee81c5) | *spriteData*, |
|  |  | [FontFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab81f4f6a6616ebe3c615ba7579ac41c1) | *fontFactory*, |
|  |  | [BrushFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab48292ecd047debf0d3144704a86a121) | *brushFactory* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a507ae176740f6645445591513c061a12)UIContext() [2/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.GauntletUI.UIContext.UIContext | ( | [TwoDimensionContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab7a19dc2cbe6c94d2b7934ccb72df247) | *twoDimensionContext*, |
|  |  | [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | *inputContext* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a7b8523fc53465c313df547743a0bdebc)Initialize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.Initialize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ae2b235b775a37eccb69910d85ad0e687)GetBrush()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html) TaleWorlds.GauntletUI.UIContext.GetBrush | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a37bde21bb4202fbc8db6069de1079eb1)RefreshResources()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.RefreshResources | ( | [SpriteData](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a5d13ba97f8d6bd18c8e84707d3ee81c5) | *spriteData*, |
|  |  | [FontFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab81f4f6a6616ebe3c615ba7579ac41c1) | *fontFactory*, |
|  |  | [BrushFactory](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab48292ecd047debf0d3144704a86a121) | *brushFactory* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a88d316a3677058885d84047cec2e2f36)OnFinalize()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.OnFinalize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a68099a25cd9e006891e567847a4bfa1e)Activate()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.Activate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#afa8b2048da6b4febd84aaf4d1acf3093)Deactivate()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.Deactivate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a0151eeaec4c6ec5d2f88414affae88bd)Update()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.Update | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a6e456972311ad5f22c0f3f89f9943d71)LateUpdate()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.LateUpdate | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ad75dfb923dfbe1c559de67bd4ebc68ce)RenderTick()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.RenderTick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a9cf7781147b1e5356d8a1253f174323e)InitializeGamepadNavigation()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.InitializeGamepadNavigation | ( | [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html) | *context* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aa0d27017e605f54b56a341acecec7ca5)OnOnScreenkeyboardTextInputDone()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.OnOnScreenkeyboardTextInputDone | ( | string | *inputText* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a901e973c775e794fb5335e673f24b8d1)OnOnScreenKeyboardCanceled()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.OnOnScreenKeyboardCanceled | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a9c2e1c40933246b9031f421bea435ce8)HitTest() [1/2]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.UIContext.HitTest | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *root*, |
|  |  | Vector2 | *position* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a49ca20a0842f84d83d3df3d4fa7b9622)HitTest() [2/2]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.UIContext.HitTest | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *root* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a50f79dd03fbe9e0c9b84cd7d63103eb2)FocusTest()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.UIContext.FocusTest | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *root* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ac7a4903e8bdb447b5b9cccd28ae3ca70)SetIsMouseEnabled()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.SetIsMouseEnabled | ( | bool | *isMouseEnabled* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a0eee813f6016aabf8de869772f42f6da)UpdateInput()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.UpdateInput | ( | [InputType](namespace_tale_worlds_1_1_library.html#a2989ea5a8b573d6c49261568e1482bb4) | *handleInputs* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ae09c6d4f55592bea640e568e05899348)OnMovieLoaded()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.OnMovieLoaded | ( | string | *movieName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aab53dbd82d0bc4086c951bf031cdd9e8)OnMovieReleased()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.OnMovieReleased | ( | string | *movieName* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aa5addbf209e9ab9747da8010216d7831)DrawWidgetDebugInfo()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.UIContext.DrawWidgetDebugInfo | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab4e2875b262af2b3dde3a114e91f2b67)ActiveCursorOfContext
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MouseCursors](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a69d02d5ab1dc7ac78b6182ec637923f8) TaleWorlds.GauntletUI.UIContext.ActiveCursorOfContext | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#add57cbe005acf653048c228fb01a3f00)IsDynamicScaleEnabled
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.UIContext.IsDynamicScaleEnabled = true | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a48e1a4d034d293cb875336f8e58da9c9)ScaleModifier
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.UIContext.ScaleModifier = 1 | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ae02a82e522fc9ac895c486e6a4840f17)Name
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.UIContext.Name | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a0ce3faaa77c8cbb442e949d786e5b459)IsActive
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.UIContext.IsActive | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#afe2de9013249c509bdfb7411b30bca18)ContextAlpha
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.UIContext.ContextAlpha = 1f | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a37a48134cc042c3df196f095b79665d3)Scale
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.UIContext.Scale | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a5c54909096e884d66cbf9dba7223232d)CustomScale
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.UIContext.CustomScale | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a30a75579e68b9559dff101d9de78d8f8)CustomInverseScale
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.UIContext.CustomInverseScale | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aab2b29a65b11e15236bd991cf21d4fb0)CurrentLanugageCode
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.UIContext.CurrentLanugageCode | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a1ef73069b561b7d33b94ca731832afb6)UIRandom
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Random TaleWorlds.GauntletUI.UIContext.UIRandom | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a0d67c67d89a9cabd1132bee0e7b973a1)InverseScale
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.UIContext.InverseScale | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a50a762315e7906b0ccb3db9ac73b8c31)EventManager
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | EventManager TaleWorlds.GauntletUI.UIContext.EventManager | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#aba5e86ec3b24454ca63d59b6e5239f73)Root
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.UIContext.Root | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ae25cc0a7f92d5341dbb4af2d3f01c9f9)ResourceDepot
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ResourceDepot TaleWorlds.GauntletUI.UIContext.ResourceDepot | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab7a19dc2cbe6c94d2b7934ccb72df247)TwoDimensionContext
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TwoDimensionContext TaleWorlds.GauntletUI.UIContext.TwoDimensionContext | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a8d2ffb24e8aad8a4acfb52f57d49df57)Brushes
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html)> TaleWorlds.GauntletUI.UIContext.Brushes | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a3342b2afe3c77a7cfaf780e8e816ddc7)DefaultBrush
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Brush](class_tale_worlds_1_1_gauntlet_u_i_1_1_brush.html) TaleWorlds.GauntletUI.UIContext.DefaultBrush | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a5d13ba97f8d6bd18c8e84707d3ee81c5)SpriteData
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SpriteData TaleWorlds.GauntletUI.UIContext.SpriteData | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab48292ecd047debf0d3144704a86a121)BrushFactory
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BrushFactory TaleWorlds.GauntletUI.UIContext.BrushFactory | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ab81f4f6a6616ebe3c615ba7579ac41c1)FontFactory
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | FontFactory TaleWorlds.GauntletUI.UIContext.FontFactory | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a8e3d5fdd399f9a7300252702a4ebe11d)InputContext
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IReadonlyInputContext](interface_tale_worlds_1_1_gauntlet_u_i_1_1_gauntlet_input_1_1_i_readonly_input_context.html) TaleWorlds.GauntletUI.UIContext.InputContext | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#ad6b465b783c88ae585952ea365aef057)GamepadNavigation
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html) TaleWorlds.GauntletUI.UIContext.GamepadNavigation | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html#a264ebdbc9dce0f6766de8ffbdceb7991)LocalFrameNumber
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.GauntletUI.UIContext.LocalFrameNumber | | get |

