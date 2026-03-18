--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html ---

TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule Class ReferenceInherits [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GauntletUISubModule](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#aef0fc91d038d86f65d47ff57ecbac906) () |
| override void | [OnMultiplayerGameStart](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#ad96b27f09ffbffe484f81b41392b2344) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
| override void | [OnGameEnd](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a648f0ff3c6041668e3bd99483d0e2718) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html) | |
| virtual void | [OnConfigChanged](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a8c80398e339b7ba98cba88b76ceee2bf) () |
|  | This is the function called whenever a config is changed. Works when the related module is deactivated. |
| virtual void | [OnGameLoaded](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abe3ccc72d0b6d71870da8ef3b0fc59d6) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object initializerObject) |
|  | This function is called on new session start (i.e. new game start or load game). |
| virtual void | [OnAfterGameLoaded](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#acb9f8c9ea14610f57a1e77d1371d71c7) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| virtual void | [OnNewGameCreated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a1db6c130f39f8f64af0dde6e56cf99df) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object initializerObject) |
| virtual void | [BeginGameStart](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a1505c84ae2724012f25c1010c781d4e1) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| virtual void | [OnCampaignStart](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a40545a8fe14af634d742b71071c3bdef) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
| virtual void | [RegisterSubModuleObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#ab36ed8b2359fba1e4cc531ce65491226) (bool isSavedCampaign) |
| virtual void | [AfterRegisterSubModuleObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#aa9cf16123e433debb2792f4761de8c17) (bool isSavedCampaign) |
| virtual void | [OnGameInitializationFinished](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a005e6e214e4b45a723243ece208e1188) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| virtual void | [OnAfterGameInitializationFinished](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a971056fd00e36a241fffafcdbfc3e1f1) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
| virtual bool | [DoLoading](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a17c519cb5b418e000d96ea579c5510b5) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| virtual void | [OnMissionBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#aa618c47aee28afab8054fdb6f3354c66) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnBeforeMissionBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abd5023705e60f44d2ecdb6a937ccc9ba) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnInitialState](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a99f049e0e89d4f73fda8eda6b83b53bf) () |
|  | Triggered when state returns to initial state. Works when related module is deactivated. |
| virtual void | [OnSubModuleActivated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a11043f64a8f74a0881e3807e3e582f45) () |
| virtual void | [OnSubModuleDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abe66ad1e9da0c2c1bd85a2c362964959) () |
| virtual void | [InitializeSubModuleGameObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#ac2c68a71f4799aaa0463b46caedf00f7) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [ClearChatLog](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#acc3ab31d2ea3f8122b1c9aa1f08f8287) (List< string > strings) |
| static string | [SetCanFocusWhileInMission](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a28f12229a308d3d21eb6b92ba1f410e2) (List< string > strings) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnSubModuleLoad](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#ac4c2af2a641a85fbf39d4a74264f8534) () |
|  | This is the function which is called first when application is started. Works when the related module is deactivated. |
| override void | [OnNewModuleLoad](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a4fb53ffc014bd0ea099ed20b97e12b76) () |
| override void | [OnSubModuleUnloaded](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a1a574df7307f781c3c9ef371d35a7a87) () |
|  | This is the function when application is about to get terminated. Works when the related module is deactivated. |
| override void | [OnBeforeInitialModuleScreenSetAsRoot](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a6fcd93c02532db0d988135f0075c5f7e) () |
|  | This is the function called before the application initializes the initial screen. Works when the related module is deactivated. |
| override void | [OnApplicationTick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a355630cbd4f4bb566ca9e4afc2697818) (float dt) |

|  |  |
| --- | --- |
| Properties | |
| static [GauntletUISubModule](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#aef0fc91d038d86f65d47ff57ecbac906) | [Instance](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a3d7943d3a5b1a068e588aa07cb399e3b) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#aef0fc91d038d86f65d47ff57ecbac906)GauntletUISubModule()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.GauntletUISubModule | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#ac4c2af2a641a85fbf39d4a74264f8534)OnSubModuleLoad()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.OnSubModuleLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a4fb53ffc014bd0ea099ed20b97e12b76)OnNewModuleLoad()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.OnNewModuleLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a1a574df7307f781c3c9ef371d35a7a87)OnSubModuleUnloaded()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.OnSubModuleUnloaded | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a6fcd93c02532db0d988135f0075c5f7e)OnBeforeInitialModuleScreenSetAsRoot()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.OnBeforeInitialModuleScreenSetAsRoot | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#ad96b27f09ffbffe484f81b41392b2344)OnMultiplayerGameStart()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.OnMultiplayerGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *starterObject* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a6549a0dd4893796c1a23601b94187290).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a648f0ff3c6041668e3bd99483d0e2718)OnGameEnd()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.OnGameEnd | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a19a3db1dbab60544f0b908c7e39da5ee).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a355630cbd4f4bb566ca9e4afc2697818)OnApplicationTick()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.OnApplicationTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#acc3ab31d2ea3f8122b1c9aa1f08f8287)ClearChatLog()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.ClearChatLog | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a28f12229a308d3d21eb6b92ba1f410e2)SetCanFocusWhileInMission()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.SetCanFocusWhileInMission | ( | List< string > | *strings* | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a3d7943d3a5b1a068e588aa07cb399e3b)Instance
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GauntletUISubModule](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#aef0fc91d038d86f65d47ff57ecbac906) TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule.Instance | | staticget |

