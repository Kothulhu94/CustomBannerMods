--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html ---

TaleWorlds.MountAndBlade.View.ViewSubModule Class ReferenceInherits [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnCampaignStart](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a1a35acccadea2d3b8467b317fdba9543) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
|  | This function is called when a new game is created. |
| override void | [OnMultiplayerGameStart](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#acd1fa6139031b80394da07448c583ff7) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
| override void | [OnGameLoaded](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a6319e552b110c2df1a2fbf8e0bad0c9d) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object initializerObject) |
|  | This function is called after game is created or loaded. |
| override void | [OnGameInitializationFinished](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a4f6993b12f5024834971636f305410f5) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| override void | [BeginGameStart](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a039dd7b9a6d208e31ee7f9b8e55770f3) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| override bool | [DoLoading](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ab5477bcea2ae03b234d47d35f11e315a) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| override void | [OnGameEnd](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ae3231ebecb7afa1f51edbda4e3d7f54c) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html) | |
| virtual void | [OnConfigChanged](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a8c80398e339b7ba98cba88b76ceee2bf) () |
|  | This is the function called whenever a config is changed. Works when the related module is deactivated. |
| virtual void | [OnAfterGameLoaded](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#acb9f8c9ea14610f57a1e77d1371d71c7) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| virtual void | [OnNewGameCreated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a1db6c130f39f8f64af0dde6e56cf99df) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object initializerObject) |
| virtual void | [RegisterSubModuleObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#ab36ed8b2359fba1e4cc531ce65491226) (bool isSavedCampaign) |
| virtual void | [AfterRegisterSubModuleObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#aa9cf16123e433debb2792f4761de8c17) (bool isSavedCampaign) |
| virtual void | [OnAfterGameInitializationFinished](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a971056fd00e36a241fffafcdbfc3e1f1) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
| virtual void | [OnMissionBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#aa618c47aee28afab8054fdb6f3354c66) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnBeforeMissionBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abd5023705e60f44d2ecdb6a937ccc9ba) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnInitialState](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a99f049e0e89d4f73fda8eda6b83b53bf) () |
|  | Triggered when state returns to initial state. Works when related module is deactivated. |
| virtual void | [OnSubModuleActivated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a11043f64a8f74a0881e3807e3e582f45) () |
| virtual void | [OnSubModuleDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abe66ad1e9da0c2c1bd85a2c362964959) () |
| virtual void | [InitializeSubModuleGameObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#ac2c68a71f4799aaa0463b46caedf00f7) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnSubModuleLoad](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a56bb1660e5e77dfdb69ad429bad516ef) () |
|  | This is the function which is called first when application is started. Works when the related module is deactivated. |
| override void | [OnSubModuleUnloaded](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ab4daf9076ad1e470f2cc5af3c7a473fb) () |
|  | This is the function when application is about to get terminated. Works when the related module is deactivated. |
| override void | [OnBeforeInitialModuleScreenSetAsRoot](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a17e7babce17f1203f2d625876fd3e815) () |
|  | This is the function called before the application initializes the initial screen. Works when the related module is deactivated. |
| override void | [OnNewModuleLoad](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ab2efd9636bbbb86db87f10b361dcfc95) () |
| override void | [OnApplicationTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a72e6f4c72f29486b3ba9acc752110b9b) (float dt) |
| override void | [AfterAsyncTickTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a83ef1df246718fa6c6276aff42c15f64) (float dt) |
| override void | [OnGameStart](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a1a8951d27914d6853fbfefdf26938125) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) gameStarterObject) |
|  | This is the function which is called first when game is started. |

|  |  |
| --- | --- |
| Properties | |
| static Dictionary< Tuple< [Material](class_tale_worlds_1_1_engine_1_1_material.html), [Banner](class_tale_worlds_1_1_core_1_1_banner.html) >, [Material](class_tale_worlds_1_1_engine_1_1_material.html) > | [BannerTexturedMaterialCache](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ada97a9c6701fd7180d264b56d7711b6c) `[get, set]` |
| static GameStateScreenManager | [GameStateScreenManager](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a803d2063fcfd2369555bb0fccfc63384) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a56bb1660e5e77dfdb69ad429bad516ef)OnSubModuleLoad()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnSubModuleLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ab4daf9076ad1e470f2cc5af3c7a473fb)OnSubModuleUnloaded()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnSubModuleUnloaded | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a17e7babce17f1203f2d625876fd3e815)OnBeforeInitialModuleScreenSetAsRoot()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnBeforeInitialModuleScreenSetAsRoot | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ab2efd9636bbbb86db87f10b361dcfc95)OnNewModuleLoad()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnNewModuleLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a72e6f4c72f29486b3ba9acc752110b9b)OnApplicationTick()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnApplicationTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a83ef1df246718fa6c6276aff42c15f64)AfterAsyncTickTick()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.AfterAsyncTickTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a1a8951d27914d6853fbfefdf26938125)OnGameStart()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) | *gameStarterObject* ) | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a1a35acccadea2d3b8467b317fdba9543)OnCampaignStart()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnCampaignStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *starterObject* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a40545a8fe14af634d742b71071c3bdef).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#acd1fa6139031b80394da07448c583ff7)OnMultiplayerGameStart()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnMultiplayerGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *starterObject* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a6549a0dd4893796c1a23601b94187290).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a6319e552b110c2df1a2fbf8e0bad0c9d)OnGameLoaded()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnGameLoaded | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *initializerObject* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abe3ccc72d0b6d71870da8ef3b0fc59d6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a4f6993b12f5024834971636f305410f5)OnGameInitializationFinished()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnGameInitializationFinished | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a005e6e214e4b45a723243ece208e1188).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a039dd7b9a6d208e31ee7f9b8e55770f3)BeginGameStart()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.BeginGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a1505c84ae2724012f25c1010c781d4e1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ab5477bcea2ae03b234d47d35f11e315a)DoLoading()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.View.ViewSubModule.DoLoading | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a17c519cb5b418e000d96ea579c5510b5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ae3231ebecb7afa1f51edbda4e3d7f54c)OnGameEnd()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.View.ViewSubModule.OnGameEnd | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a19a3db1dbab60544f0b908c7e39da5ee).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ada97a9c6701fd7180d264b56d7711b6c)BannerTexturedMaterialCache
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<Tuple<[Material](class_tale_worlds_1_1_engine_1_1_material.html), [Banner](class_tale_worlds_1_1_core_1_1_banner.html)>, [Material](class_tale_worlds_1_1_engine_1_1_material.html)> TaleWorlds.MountAndBlade.View.ViewSubModule.BannerTexturedMaterialCache | | staticgetset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a803d2063fcfd2369555bb0fccfc63384)GameStateScreenManager
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GameStateScreenManager TaleWorlds.MountAndBlade.View.ViewSubModule.GameStateScreenManager | | staticget |

