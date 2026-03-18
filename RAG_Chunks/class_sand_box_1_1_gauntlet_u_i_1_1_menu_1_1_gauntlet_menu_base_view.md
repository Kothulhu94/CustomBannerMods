--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html ---

SandBox.GauntletUI.Menu.GauntletMenuBaseView Class ReferenceInherits [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html).

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a19ec2eb0024dac2902532c12e90814ab) () |
| override void | [OnActivate](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#ae954caa3a6b7c24d5674b1914178cd2a) () |
| override void | [OnDeactivate](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#aaee2d77babee9a0ea01363a7e2776505) () |
| override void | [OnResume](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a44eeb937e0278316576461ee4c16d61e) () |
| override void | [OnMenuContextRefreshed](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a4b727116e3ec33cc3c68315d4d375840) () |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#abc80af80b11fe050472bbd7effda75b9) () |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a1738768b0a7ae81016995e9c4b697985) (float dt) |
| override void | [OnMapConversationActivated](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#aeaa3c101f68c50df721b5e4c911f5f43) () |
| override void | [OnMapConversationDeactivated](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#aed94f91007769b92d053d4896a55adfc) () |
| override void | [OnMenuContextUpdated](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a2df90ff3b45a786278227d4acec147fb) ([MenuContext](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html#af9f746d2633f2cf9944e3450b8406482) newMenuContext) |
| override void | [OnBackgroundMeshNameSet](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a5bf65da7b42e23bd0bb45066849506f4) (string name) |

|  |  |
| --- | --- |
| Properties | |
| [GameMenuVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html) | [GameMenuDataSource](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a40c292fce18bdb5318d98198e977b816) `[get]` |
| Properties inherited from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html) | |
| virtual bool | [ShouldUpdateMenuAfterRemoved](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html#a94dc1ff8d31211f07f77d72acb69f287) `[get]` |
| MenuViewContext | [MenuViewContext](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html#a6f0b85a8a13e58673f56ae8d6014a682) `[get]` |
| MenuContext | [MenuContext](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html#af9f746d2633f2cf9944e3450b8406482) `[get]` |
| Properties inherited from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html) | |
| bool | [IsFinalized](class_sand_box_1_1_view_1_1_sandbox_view.html#a5807fb2c109c6715d7fae1a6cf2f4693) `[get, protected set]` |
| ScreenLayer | [Layer](class_sand_box_1_1_view_1_1_sandbox_view.html#a070dec1267ecf8ff4afadffc12374024) `[get, protected set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Protected Attributes inherited from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html) | |
| const float | [ContextAlphaModifier](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html#a29345cc9cb09e3dacc1cd01986e00050) = 8.5f |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a19ec2eb0024dac2902532c12e90814ab)OnInitialize()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#ae954caa3a6b7c24d5674b1914178cd2a)OnActivate()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#aaee2d77babee9a0ea01363a7e2776505)OnDeactivate()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a44eeb937e0278316576461ee4c16d61e)OnResume()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnResume | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a4b727116e3ec33cc3c68315d4d375840)OnMenuContextRefreshed()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnMenuContextRefreshed | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#abc80af80b11fe050472bbd7effda75b9)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a1738768b0a7ae81016995e9c4b697985)OnFrameTick()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnFrameTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.SandboxView](class_sand_box_1_1_view_1_1_sandbox_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#aeaa3c101f68c50df721b5e4c911f5f43)OnMapConversationActivated()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnMapConversationActivated | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#aed94f91007769b92d053d4896a55adfc)OnMapConversationDeactivated()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnMapConversationDeactivated | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a2df90ff3b45a786278227d4acec147fb)OnMenuContextUpdated()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnMenuContextUpdated | ( | [MenuContext](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html#af9f746d2633f2cf9944e3450b8406482) | *newMenuContext* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a5bf65da7b42e23bd0bb45066849506f4)OnBackgroundMeshNameSet()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.Menu.GauntletMenuBaseView.OnBackgroundMeshNameSet | ( | string | *name* | ) |  | | protectedvirtual |

Reimplemented from [SandBox.View.Menu.MenuView](class_sand_box_1_1_view_1_1_menu_1_1_menu_view.html).

Property Documentation
----------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_menu_1_1_gauntlet_menu_base_view.html#a40c292fce18bdb5318d98198e977b816)GameMenuDataSource
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameMenuVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html) SandBox.GauntletUI.Menu.GauntletMenuBaseView.GameMenuDataSource | | get |

