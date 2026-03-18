--- SOURCE: class_story_mode_1_1_story_mode_sub_module.html ---

StoryMode.StoryModeSubModule Class ReferenceInherits [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnGameEnd](class_story_mode_1_1_story_mode_sub_module.html#a77faf23fe5a9e15f5676a9014ccfcb16) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
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
| Protected Member Functions | |
| override void | [InitializeGameStarter](class_story_mode_1_1_story_mode_sub_module.html#a18d0d59df999ffcc37b588bbb4f4cc20) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) gameStarterObject) |
|  | [Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html) Models and Texts are initialized, [Campaign](class_tale_worlds_1_1_campaign_system_1_1_campaign.html) Behaviors, Conversations, [Objects(in ObjectManager)](namespace_tale_worlds_1_1_mount_and_blade_1_1_objects.html) are NOT initialized. |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_story_mode_sub_module.html#a18d0d59df999ffcc37b588bbb4f4cc20)InitializeGameStarter()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void StoryMode.StoryModeSubModule.InitializeGameStarter | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | [IGameStarter](interface_tale_worlds_1_1_core_1_1_i_game_starter.html) | *gameStarterObject* ) | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_story_mode_1_1_story_mode_sub_module.html#a77faf23fe5a9e15f5676a9014ccfcb16)OnGameEnd()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void StoryMode.StoryModeSubModule.OnGameEnd | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a19a3db1dbab60544f0b908c7e39da5ee).

