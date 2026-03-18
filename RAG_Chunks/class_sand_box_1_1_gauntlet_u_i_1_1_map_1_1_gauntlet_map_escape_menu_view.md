--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html ---

SandBox.GauntletUI.Map.GauntletMapEscapeMenuView Class ReferenceInherits [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletMapEscapeMenuView](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#a862e3d274f0abd01bc5d971dc3a1a1d6) (List< [EscapeMenuItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_escape_menu_1_1_escape_menu_item_v_m.html) > items) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [CreateLayout](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#a190c9b7f319612ec1d2da5ed0b39fa19) () |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#a2ad68d2340b749e8490e146e2b1215bf) (float dt) |
| override void | [OnIdleTick](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#a52f7f865c5eb2b4872f6c4c51cd31f27) (float dt) |
| override bool | [IsEscaped](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#aa040dd9c2122df2de2c482f885472fd4) () |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#a9f18339796d84508313027029c90bc75) () |
| override [TutorialContexts](namespace_tale_worlds_1_1_core.html#a0e55f29880be385de604e852ae10794c) | [GetTutorialContext](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#aa9810dca6decb3d3a0e1b2dca2b02da9) () |

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

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#a862e3d274f0abd01bc5d971dc3a1a1d6)GauntletMapEscapeMenuView()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.GauntletUI.Map.GauntletMapEscapeMenuView.GauntletMapEscapeMenuView | ( | List< [EscapeMenuItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_escape_menu_1_1_escape_menu_item_v_m.html) > | *items* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#a190c9b7f319612ec1d2da5ed0b39fa19)CreateLayout()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapEscapeMenuView.CreateLayout | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#a2ad68d2340b749e8490e146e2b1215bf)OnFrameTick()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapEscapeMenuView.OnFrameTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#a52f7f865c5eb2b4872f6c4c51cd31f27)OnIdleTick()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapEscapeMenuView.OnIdleTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#aa040dd9c2122df2de2c482f885472fd4)IsEscaped()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool SandBox.GauntletUI.Map.GauntletMapEscapeMenuView.IsEscaped | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#a9f18339796d84508313027029c90bc75)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Map.GauntletMapEscapeMenuView.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_map_1_1_gauntlet_map_escape_menu_view.html#aa9810dca6decb3d3a0e1b2dca2b02da9)GetTutorialContext()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TutorialContexts](namespace_tale_worlds_1_1_core.html#a0e55f29880be385de604e852ae10794c) SandBox.GauntletUI.Map.GauntletMapEscapeMenuView.GetTutorialContext | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Map.MapView](class_sand_box_1_1_view_1_1_map_1_1_map_view.html).

