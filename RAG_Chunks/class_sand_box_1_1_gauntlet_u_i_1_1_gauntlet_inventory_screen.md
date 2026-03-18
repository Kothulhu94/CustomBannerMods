--- SOURCE: class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html ---

SandBox.GauntletUI.GauntletInventoryScreen Class ReferenceInherits ScreenBase, [TaleWorlds.CampaignSystem.GameState.IInventoryStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_inventory_state_handler.html), [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html), and [SandBox.View.IChangeableScreen](interface_sand_box_1_1_view_1_1_i_changeable_screen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletInventoryScreen](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#aef2f5c9330adda19ab659cdae8f1f8f3) ([InventoryState](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#ac80fde050caad30288ed467a15f86d9e) inventoryState) |
| void | [ExecuteLootingScript](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a2ee3f65236624e691514198a0058d74e) () |
| void | [ExecuteSellAllLoot](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#af7f03764c517177d6bf7aeae53c15f47) () |
| void | [ExecuteCancel](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#aa7a1b28a972806e36855cf076835262a) () |
| void | [ExecuteConfirm](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a0f53f10c86fbf3c9ba98e5da9c2e5438) () |
| void | [ExecuteSwitchToPreviousTab](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a1d03823c1baab967516e898c3fdb7e84) () |
| void | [ExecuteSwitchToNextTab](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a836b1e2350981cb5c7b15c84c38dcb22) () |
| void | [ExecuteBuySingle](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a738c5a70b453d2c3b650f763aef6a360) () |
| void | [ExecuteSellSingle](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a4dd14d8d238381e5e5cbbff1a79cde7a) () |
| void | [ExecuteTakeAll](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#ab47e71dea7ea2b8c1ae0a9380e575d3e) () |
| void | [ExecuteGiveAll](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a57deb0d6b18930c4c57e92c6efad0308) () |
| void | [ExecuteBuyConsumableItem](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a87fa6a2072794d00475bb7e07fd94bb4) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnFrameTick](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a885665db95be21a24ea8387cd0b595ed) (float dt) |
| override void | [OnInitialize](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#ad29b9af5ee1e6b3c8af64ded28e0394e) () |
| override void | [OnDeactivate](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#abb5b2c23e96d9fd66ea20eba38571820) () |
| override void | [OnActivate](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#af6ba2bc8039cf608d0dace447a8ee637) () |
| override void | [OnFinalize](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a77e251f7f607a67eaf8fbc050421e7ac) () |

|  |  |
| --- | --- |
| Properties | |
| InventoryState | [InventoryState](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#ac80fde050caad30288ed467a15f86d9e) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#aef2f5c9330adda19ab659cdae8f1f8f3)GauntletInventoryScreen()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.GauntletUI.GauntletInventoryScreen.GauntletInventoryScreen | ( | [InventoryState](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#ac80fde050caad30288ed467a15f86d9e) | *inventoryState* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a885665db95be21a24ea8387cd0b595ed)OnFrameTick()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletInventoryScreen.OnFrameTick | ( | float | *dt* | ) |  | | protected |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#ad29b9af5ee1e6b3c8af64ded28e0394e)OnInitialize()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletInventoryScreen.OnInitialize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a8df8104360d9c66aedb341b13367b8e5).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#abb5b2c23e96d9fd66ea20eba38571820)OnDeactivate()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletInventoryScreen.OnDeactivate | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#a64ece7c9e2bec7a45b85be293166b6ef).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#af6ba2bc8039cf608d0dace447a8ee637)OnActivate()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletInventoryScreen.OnActivate | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#aa8b05eeab9e1f4691b9ef1ac12a05b77).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a77e251f7f607a67eaf8fbc050421e7ac)OnFinalize()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GauntletUI.GauntletInventoryScreen.OnFinalize | ( |  | ) |  | | protected |

Implements [TaleWorlds.Core.IGameStateListener](interface_tale_worlds_1_1_core_1_1_i_game_state_listener.html#ac916ee3e48edbf09b47eacac07b5c574).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a2ee3f65236624e691514198a0058d74e)ExecuteLootingScript()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteLootingScript | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.GameState.IInventoryStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_inventory_state_handler.html#a7eaf45759e8fc22cb81ef39b292c7d71).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#af7f03764c517177d6bf7aeae53c15f47)ExecuteSellAllLoot()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteSellAllLoot | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.GameState.IInventoryStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_inventory_state_handler.html#a6ee986a8dfd272577ef7f4fc9d1b9e9f).

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#aa7a1b28a972806e36855cf076835262a)ExecuteCancel()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteCancel | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a0f53f10c86fbf3c9ba98e5da9c2e5438)ExecuteConfirm()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteConfirm | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a1d03823c1baab967516e898c3fdb7e84)ExecuteSwitchToPreviousTab()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteSwitchToPreviousTab | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a836b1e2350981cb5c7b15c84c38dcb22)ExecuteSwitchToNextTab()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteSwitchToNextTab | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a738c5a70b453d2c3b650f763aef6a360)ExecuteBuySingle()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteBuySingle | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a4dd14d8d238381e5e5cbbff1a79cde7a)ExecuteSellSingle()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteSellSingle | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#ab47e71dea7ea2b8c1ae0a9380e575d3e)ExecuteTakeAll()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteTakeAll | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a57deb0d6b18930c4c57e92c6efad0308)ExecuteGiveAll()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteGiveAll | ( |  | ) |  |

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#a87fa6a2072794d00475bb7e07fd94bb4)ExecuteBuyConsumableItem()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.GauntletUI.GauntletInventoryScreen.ExecuteBuyConsumableItem | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.GameState.IInventoryStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_inventory_state_handler.html#a57c52fb34a81fe503f030f5c00366768).

Property Documentation
----------------------

[◆](class_sand_box_1_1_gauntlet_u_i_1_1_gauntlet_inventory_screen.html#ac80fde050caad30288ed467a15f86d9e)InventoryState
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | InventoryState SandBox.GauntletUI.GauntletInventoryScreen.InventoryState | | get |

