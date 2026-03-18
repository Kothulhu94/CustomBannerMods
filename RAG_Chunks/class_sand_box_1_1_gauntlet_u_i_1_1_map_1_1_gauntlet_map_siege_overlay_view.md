--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html ---

SandBox.GauntletUI.Map.GauntletMapSiegeOverlayView Class ReferenceInherits [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletMapSiegeOverlayView](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#a25977cfb02156a741be3e121042abb9e) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [CreateLayout](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#a865eb5f6837a60049a9399c65f56f585) () |
| override void | [OnMapScreenUpdate](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#a30a19c690bde07e1db2087e57deb6313) (float dt) |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#a9eb71a399fb7c5d95c721858f40d539d) () |
| override void | [OnMapConversationStart](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#ad40808e47b05cad19cc0c3ba39409174) () |
| override void | [OnMapConversationOver](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#aa97e82854a270b10d683714374236fbd) () |
| override void | [OnSiegeEngineClick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#a250332fc80e42fe88380ef49b3f935af) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) siegeEngineFrame) |
| override void | [OnMapTerrainClick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#adf2c83c0021643798ae47b313297e5c0) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Protected Attributes inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| const float | [ContextAlphaModifier](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#a9efbb55b721c1331986ba14d416c84f6) = 8.5f |
| Properties inherited from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html) | |
| MapScreen | [MapScreen](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#af4f77c9eec549e6d57cb4667f09ea0b4) `[get]` |
| MapState | [MapState](class_sand_box_1_1_view_1_1_map_1_1_map_view.html#abf6624dfb0331164523cae87d042e691) `[get]` |
| Properties inherited from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html) | |
| bool | [IsFinalized](class_sand_box_1_1_view_1_1_sandbox_view.html#a5807fb2c109c6715d7fae1a6cf2f4693) `[get, protected set]` |
| ScreenLayer | [Layer](class_sand_box_1_1_view_1_1_sandbox_view.html#a070dec1267ecf8ff4afadffc12374024) `[get, protected set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#a25977cfb02156a741be3e121042abb9e)GauntletMapSiegeOverlayView()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.GauntletUI.Map.GauntletMapSiegeOverlayView.GauntletMapSiegeOverlayView | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#a865eb5f6837a60049a9399c65f56f585)CreateLayout()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapSiegeOverlayView.CreateLayout | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#a30a19c690bde07e1db2087e57deb6313)OnMapScreenUpdate()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapSiegeOverlayView.OnMapScreenUpdate | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#a9eb71a399fb7c5d95c721858f40d539d)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapSiegeOverlayView.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#ad40808e47b05cad19cc0c3ba39409174)OnMapConversationStart()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapSiegeOverlayView.OnMapConversationStart | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#aa97e82854a270b10d683714374236fbd)OnMapConversationOver()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapSiegeOverlayView.OnMapConversationOver | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#a250332fc80e42fe88380ef49b3f935af)OnSiegeEngineClick()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapSiegeOverlayView.OnSiegeEngineClick | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *siegeEngineFrame* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_siege_overlay_view.html#adf2c83c0021643798ae47b313297e5c0)OnMapTerrainClick()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapSiegeOverlayView.OnMapTerrainClick | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

