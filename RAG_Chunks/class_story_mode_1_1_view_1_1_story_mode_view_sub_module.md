--- SOURCE: class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html ---

StoryMode.View.StoryModeViewSubModule Class ReferenceInherits [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnGameInitializationFinished](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#acceff4e1e2511c311702061dc9d2cb67) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| override void | [OnGameEnd](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#abd8a777b23b84a6b39339fd5906092ea) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| override void | [OnSubModuleDeactivated](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a93882d2fdf94a51b2832c9107ea72eaf) () |
| override void | [OnSubModuleActivated](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a493021722235b10ff1e6e538e2fc826c) () |
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
| virtual void | [OnMultiplayerGameStart](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a6549a0dd4893796c1a23601b94187290) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
| virtual void | [OnAfterGameInitializationFinished](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a971056fd00e36a241fffafcdbfc3e1f1) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
| virtual bool | [DoLoading](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a17c519cb5b418e000d96ea579c5510b5) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| virtual void | [OnMissionBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#aa618c47aee28afab8054fdb6f3354c66) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnBeforeMissionBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abd5023705e60f44d2ecdb6a937ccc9ba) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnInitialState](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a99f049e0e89d4f73fda8eda6b83b53bf) () |
|  | Triggered when state returns to initial state. Works when related module is deactivated. |
| virtual void | [InitializeSubModuleGameObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#ac2c68a71f4799aaa0463b46caedf00f7) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnSubModuleLoad](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a32ac21a7c9045f0c72c7859bac880f4f) () |
|  | This is the function which is called first when application is started. Works when the related module is deactivated. |
| virtual void | [FillDataForCampaign](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a235cc2db51708f57edbca70cc8525ac7) () |
| override void | [OnSubModuleUnloaded](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a279f10185d39798a17d2919ec247343e) () |
|  | This is the function when application is about to get terminated. Works when the related module is deactivated. |
| override void | [OnBeforeGameStart](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a0a081df7357a41cd135012c7bf48f4c0) ([MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html) mbGameManager, List< string > disabledModules) |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#acceff4e1e2511c311702061dc9d2cb67)OnGameInitializationFinished()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void StoryMode.View.StoryModeViewSubModule.OnGameInitializationFinished | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a005e6e214e4b45a723243ece208e1188).

[◆](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#abd8a777b23b84a6b39339fd5906092ea)OnGameEnd()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void StoryMode.View.StoryModeViewSubModule.OnGameEnd | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a19a3db1dbab60544f0b908c7e39da5ee).

[◆](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a32ac21a7c9045f0c72c7859bac880f4f)OnSubModuleLoad()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void StoryMode.View.StoryModeViewSubModule.OnSubModuleLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a235cc2db51708f57edbca70cc8525ac7)FillDataForCampaign()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void StoryMode.View.StoryModeViewSubModule.FillDataForCampaign | ( |  | ) |  | | protectedvirtual |

[◆](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a279f10185d39798a17d2919ec247343e)OnSubModuleUnloaded()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void StoryMode.View.StoryModeViewSubModule.OnSubModuleUnloaded | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a93882d2fdf94a51b2832c9107ea72eaf)OnSubModuleDeactivated()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void StoryMode.View.StoryModeViewSubModule.OnSubModuleDeactivated | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abe66ad1e9da0c2c1bd85a2c362964959).

[◆](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a493021722235b10ff1e6e538e2fc826c)OnSubModuleActivated()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void StoryMode.View.StoryModeViewSubModule.OnSubModuleActivated | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a11043f64a8f74a0881e3807e3e582f45).

[◆](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a0a081df7357a41cd135012c7bf48f4c0)OnBeforeGameStart()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void StoryMode.View.StoryModeViewSubModule.OnBeforeGameStart | ( | [MBGameManager](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_game_manager.html) | *mbGameManager*, | |  |  | List< string > | *disabledModules* ) | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

