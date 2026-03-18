--- SOURCE: class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html ---

TaleWorlds.Engine.GauntletUI.GauntletLayer Class ReferenceInherits ScreenLayer.

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnResourceRefreshBegin](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a462b3c537985eda2c4a159950b1289c6) (out List< [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) > previouslyLoadedMovies) |
| void | [OnResourceRefreshEnd](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a316c9414569f13f3426f044b2470fd2c) (List< [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) > previouslyLoadedMovies) |
|  | [GauntletLayer](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#aaa090cdff77652a60adb2aaad52fd943) (string name, int localOrder, bool shouldClear=false) |
| [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) | [GetMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a9068838a48762b5d59cafe7fe2b465ed) (string movieName) |
| [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) | [LoadMovie](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a2f6737db843e60608280fb55d42319e6) (string movieName, [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) dataSource) |
| void | [ReleaseMovie](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#aa988a92d5b9e838a2e20133d65531128) ([GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) identifier) |
| override void | [ProcessEvents](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a21ed231952800496babc41ae45d2a6b6) () |
| override bool | [HitTest](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a768100bfe823e46d88733f9e28eb83a2) (Vector2 position) |
| override bool | [HitTest](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a027b12b0d6c948e0668fe412486b7b3f) () |
| override bool | [FocusTest](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a51ec73b3b7a774b73912dd91b3762474) () |
| override bool | [IsFocusedOnInput](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#aa3bbf57624508219e242fc2da1e4c87b) () |
| override void | [OnOnScreenKeyboardDone](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a721fa317efcd78a175b502f227da122e) (string inputText) |
| override void | [OnOnScreenKeyboardCanceled](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a47c5404715780fb2c793ff5d14f1c6d5) () |
| override void | [UpdateLayout](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a2f698c6b0ca69c3eb6160fb222982001) () |
| bool | [GetIsAvailableForGamepadNavigation](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a4d9b959a9177baf125698428e66ca89c) () |
| override void | [DrawDebugInfo](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#ad31fb137b363b2278ffb55081d722ff2) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly TwoDimensionView | [TwoDimensionView](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a82d1765c531ad0b5c3910c8cf45b5b2e) |
| readonly [ITwoDimensionPlatform](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html) | [TwoDimensionPlatform](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a6b7ca62f34c4298b8ae3bf379e757fb6) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnActivate](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#afd713405a2d587d7ddfb014a81d83549) () |
| override void | [OnDeactivate](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a2eb77c6fb3d1dca34954ce34c8301478) () |
| override void | [Tick](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a24b85625574f22c6c0d41710dcc95538) (float dt) |
| override void | [LateUpdate](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#afc2084433801e0debfa11fc565c8f734) (float dt) |
| override void | [RenderTick](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a695763c81f14d6d035c7f86c6b347fba) (float dt) |
| override void | [Update](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a2c91754b5600f90858bd9f9670e742b6) (IReadOnlyList< int > lastKeysPressed) |
| override void | [OnFinalize](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a2e7dd685f1de1e450deae628f54b97d7) () |
| override void | [RefreshGlobalOrder](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#ae557be70e43216fea56986d20584b8c2) (ref int currentOrder) |
| override void | [OnLoseFocus](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#aec2d604c157e5ea111ae2fad076efd8e) () |

|  |  |
| --- | --- |
| Properties | |
| [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html) | [GamepadNavigationContext](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a6b61645764e35e85f2790fa28624cbaf) `[get]` |
| UIContext | [UIContext](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#afb15bce775da570fac87857e8b0ad832) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#aaa090cdff77652a60adb2aaad52fd943)GauntletLayer()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Engine.GauntletUI.GauntletLayer.GauntletLayer | ( | string | *name*, |
|  |  | int | *localOrder*, |
|  |  | bool | *shouldClear* = false ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a462b3c537985eda2c4a159950b1289c6)OnResourceRefreshBegin()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.GauntletUI.GauntletLayer.OnResourceRefreshBegin | ( | out List< [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) > | *previouslyLoadedMovies* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a316c9414569f13f3426f044b2470fd2c)OnResourceRefreshEnd()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.GauntletUI.GauntletLayer.OnResourceRefreshEnd | ( | List< [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) > | *previouslyLoadedMovies* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a9068838a48762b5d59cafe7fe2b465ed)GetMovieIdentifier()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) TaleWorlds.Engine.GauntletUI.GauntletLayer.GetMovieIdentifier | ( | string | *movieName* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a2f6737db843e60608280fb55d42319e6)LoadMovie()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) TaleWorlds.Engine.GauntletUI.GauntletLayer.LoadMovie | ( | string | *movieName*, |
|  |  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | *dataSource* ) |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#aa988a92d5b9e838a2e20133d65531128)ReleaseMovie()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.GauntletUI.GauntletLayer.ReleaseMovie | ( | [GauntletMovieIdentifier](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_movie_identifier.html) | *identifier* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#afd713405a2d587d7ddfb014a81d83549)OnActivate()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.GauntletUI.GauntletLayer.OnActivate | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a2eb77c6fb3d1dca34954ce34c8301478)OnDeactivate()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.GauntletUI.GauntletLayer.OnDeactivate | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a24b85625574f22c6c0d41710dcc95538)Tick()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.GauntletUI.GauntletLayer.Tick | ( | float | *dt* | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#afc2084433801e0debfa11fc565c8f734)LateUpdate()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.GauntletUI.GauntletLayer.LateUpdate | ( | float | *dt* | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a695763c81f14d6d035c7f86c6b347fba)RenderTick()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.GauntletUI.GauntletLayer.RenderTick | ( | float | *dt* | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a2c91754b5600f90858bd9f9670e742b6)Update()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.GauntletUI.GauntletLayer.Update | ( | IReadOnlyList< int > | *lastKeysPressed* | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a2e7dd685f1de1e450deae628f54b97d7)OnFinalize()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.GauntletUI.GauntletLayer.OnFinalize | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#ae557be70e43216fea56986d20584b8c2)RefreshGlobalOrder()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.GauntletUI.GauntletLayer.RefreshGlobalOrder | ( | ref int | *currentOrder* | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a21ed231952800496babc41ae45d2a6b6)ProcessEvents()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.Engine.GauntletUI.GauntletLayer.ProcessEvents | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a768100bfe823e46d88733f9e28eb83a2)HitTest() [1/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Engine.GauntletUI.GauntletLayer.HitTest | ( | Vector2 | *position* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a027b12b0d6c948e0668fe412486b7b3f)HitTest() [2/2]
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.Engine.GauntletUI.GauntletLayer.HitTest | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a51ec73b3b7a774b73912dd91b3762474)FocusTest()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.Engine.GauntletUI.GauntletLayer.FocusTest | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#aa3bbf57624508219e242fc2da1e4c87b)IsFocusedOnInput()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.Engine.GauntletUI.GauntletLayer.IsFocusedOnInput | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#aec2d604c157e5ea111ae2fad076efd8e)OnLoseFocus()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.GauntletUI.GauntletLayer.OnLoseFocus | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a721fa317efcd78a175b502f227da122e)OnOnScreenKeyboardDone()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.Engine.GauntletUI.GauntletLayer.OnOnScreenKeyboardDone | ( | string | *inputText* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a47c5404715780fb2c793ff5d14f1c6d5)OnOnScreenKeyboardCanceled()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.Engine.GauntletUI.GauntletLayer.OnOnScreenKeyboardCanceled | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a2f698c6b0ca69c3eb6160fb222982001)UpdateLayout()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.Engine.GauntletUI.GauntletLayer.UpdateLayout | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a4d9b959a9177baf125698428e66ca89c)GetIsAvailableForGamepadNavigation()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.GauntletUI.GauntletLayer.GetIsAvailableForGamepadNavigation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#ad31fb137b363b2278ffb55081d722ff2)DrawDebugInfo()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.Engine.GauntletUI.GauntletLayer.DrawDebugInfo | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a82d1765c531ad0b5c3910c8cf45b5b2e)TwoDimensionView
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly TwoDimensionView TaleWorlds.Engine.GauntletUI.GauntletLayer.TwoDimensionView |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a6b7ca62f34c4298b8ae3bf379e757fb6)TwoDimensionPlatform
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [ITwoDimensionPlatform](interface_tale_worlds_1_1_two_dimension_1_1_i_two_dimension_platform.html) TaleWorlds.Engine.GauntletUI.GauntletLayer.TwoDimensionPlatform |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#a6b61645764e35e85f2790fa28624cbaf)GamepadNavigationContext
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html) TaleWorlds.Engine.GauntletUI.GauntletLayer.GamepadNavigationContext | | get |

[◆](class_tale_worlds_1_1_engine_1_1_gauntlet_u_i_1_1_gauntlet_layer.html#afb15bce775da570fac87857e8b0ad832)UIContext
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | UIContext TaleWorlds.Engine.GauntletUI.GauntletLayer.UIContext | | get |

