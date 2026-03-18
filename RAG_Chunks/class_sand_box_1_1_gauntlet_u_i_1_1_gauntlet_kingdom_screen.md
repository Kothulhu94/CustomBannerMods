--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html ---

SandBox.GauntletUI.GauntletKingdomScreen Class ReferenceInherits ScreenBase, and [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletKingdomScreen](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#a73ccf2a66ab0065d20e88de1c20607bb) ([KingdomState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_kingdom_state.html) kingdomState) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnInitialize](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#ae9298bfbd8a55fd3ca6de201845afc68) () |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#a8fcd0ebeea07c57e23ddd9c95085dbf5) (float dt) |
| virtual [KingdomManagementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_management_v_m.html) | [CreateDataSource](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#ab64fd9a7ec667e6f3d13f80dd8d61dbe) () |
| void | [ShowArmyOnMap](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#afa4e2a0e0fb71722b62cf1e3e5401703) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army) |
| void | [OpenArmyManagement](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#a09608a8b73fdbb22e9d7bb8e0e363c0e) () |
| void | [CloseArmyManagement](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#a0edca057013a63bc4fc0ebb1eba97e6c) () |
| void | [CloseKingdomScreen](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#a1e9daab018ff403b8230ba01f7039bd3) () |

|  |  |
| --- | --- |
| Properties | |
| [KingdomManagementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_management_v_m.html) | [DataSource](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#aeeceff023007da4d5c3940b3c0121746) `[get]` |
| bool | [IsMakingDecision](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#ac314e7b81c073f8f545a50aa9d5cdd50) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#a73ccf2a66ab0065d20e88de1c20607bb)GauntletKingdomScreen()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.GauntletUI.GauntletKingdomScreen.GauntletKingdomScreen | ( | [KingdomState](class_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_kingdom_state.html) | *kingdomState* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#ae9298bfbd8a55fd3ca6de201845afc68)OnInitialize()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletKingdomScreen.OnInitialize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a8df8104360d9c66aedb341b13367b8e5).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#a8fcd0ebeea07c57e23ddd9c95085dbf5)OnFrameTick()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletKingdomScreen.OnFrameTick | ( | float | *dt* | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#ab64fd9a7ec667e6f3d13f80dd8d61dbe)CreateDataSource()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [KingdomManagementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_management_v_m.html) SandBox.GauntletUI.GauntletKingdomScreen.CreateDataSource | ( |  | ) |  | | protectedvirtual |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#afa4e2a0e0fb71722b62cf1e3e5401703)ShowArmyOnMap()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.GauntletUI.GauntletKingdomScreen.ShowArmyOnMap | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army* | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#a09608a8b73fdbb22e9d7bb8e0e363c0e)OpenArmyManagement()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.GauntletUI.GauntletKingdomScreen.OpenArmyManagement | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#a0edca057013a63bc4fc0ebb1eba97e6c)CloseArmyManagement()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.GauntletUI.GauntletKingdomScreen.CloseArmyManagement | ( |  | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#a1e9daab018ff403b8230ba01f7039bd3)CloseKingdomScreen()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.GauntletUI.GauntletKingdomScreen.CloseKingdomScreen | ( |  | ) |  | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#aeeceff023007da4d5c3940b3c0121746)DataSource
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [KingdomManagementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_management_v_m.html) SandBox.GauntletUI.GauntletKingdomScreen.DataSource | | get |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_kingdom_screen.html#ac314e7b81c073f8f545a50aa9d5cdd50)IsMakingDecision
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.GauntletUI.GauntletKingdomScreen.IsMakingDecision | | get |

