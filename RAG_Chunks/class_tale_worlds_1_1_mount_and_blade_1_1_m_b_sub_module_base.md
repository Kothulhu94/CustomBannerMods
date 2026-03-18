--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html ---

TaleWorlds.MountAndBlade.MBSubModuleBase Class ReferenceabstractInherited by [SandBox.GauntletUI.SandBoxGauntletUISubModule](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_u_i_sub_module.html), [SandBox.SandBoxSubModule](class_sand_box_1_1_sand_box_sub_module.html), [SandBox.View.SandBoxViewSubModule](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html), [StoryMode.GauntletUI.StoryModeGauntletUISubModule](class_story_mode_1_1_gauntlet_u_i_1_1_story_mode_gauntlet_u_i_sub_module.html), [StoryMode.StoryModeSubModule](class_story_mode_1_1_story_mode_sub_module.html), [StoryMode.View.StoryModeViewSubModule](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html), [TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html), and [TaleWorlds.MountAndBlade.View.ViewSubModule](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| virtual void | [OnGameEnd](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a19a3db1dbab60544f0b908c7e39da5ee) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| virtual void | [OnMissionBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#aa618c47aee28afab8054fdb6f3354c66) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnBeforeMissionBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abd5023705e60f44d2ecdb6a937ccc9ba) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnInitialState](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a99f049e0e89d4f73fda8eda6b83b53bf) () |
|  | Triggered when state returns to initial state. Works when related module is deactivated. |
| virtual void | [OnSubModuleActivated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a11043f64a8f74a0881e3807e3e582f45) () |
| virtual void | [OnSubModuleDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abe66ad1e9da0c2c1bd85a2c362964959) () |
| virtual void | [InitializeSubModuleGameObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#ac2c68a71f4799aaa0463b46caedf00f7) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a8c80398e339b7ba98cba88b76ceee2bf)OnConfigChanged()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnConfigChanged | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.SandBoxSubModule](class_sand_box_1_1_sand_box_sub_module.html#a771e0f841d644e61ce07b9515a20a55d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abe3ccc72d0b6d71870da8ef3b0fc59d6)OnGameLoaded()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnGameLoaded | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *initializerObject* ) | | virtual |

Reimplemented in [SandBox.SandBoxSubModule](class_sand_box_1_1_sand_box_sub_module.html#a1dbe62d74a4c37e9572edf2594c66a71), [SandBox.View.SandBoxViewSubModule](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#af5e8a2cbe55b4bca0d7d3e223f18e72d), and [TaleWorlds.MountAndBlade.View.ViewSubModule](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a6319e552b110c2df1a2fbf8e0bad0c9d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#acb9f8c9ea14610f57a1e77d1371d71c7)OnAfterGameLoaded()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnAfterGameLoaded | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a1db6c130f39f8f64af0dde6e56cf99df)OnNewGameCreated()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnNewGameCreated | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *initializerObject* ) | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a1505c84ae2724012f25c1010c781d4e1)BeginGameStart()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.BeginGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented in [SandBox.GauntletUI.SandBoxGauntletUISubModule](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_u_i_sub_module.html#a1d4a16487c8024127ce07f163ae9eb6f), [SandBox.View.SandBoxViewSubModule](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#ae00159e99393e96196ed538ba3951b5f), and [TaleWorlds.MountAndBlade.View.ViewSubModule](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a039dd7b9a6d208e31ee7f9b8e55770f3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a40545a8fe14af634d742b71071c3bdef)OnCampaignStart()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnCampaignStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *starterObject* ) | | virtual |

Reimplemented in [SandBox.GauntletUI.SandBoxGauntletUISubModule](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_u_i_sub_module.html#a0d1702ba5b4d062711034cc90ec7f132), [SandBox.SandBoxSubModule](class_sand_box_1_1_sand_box_sub_module.html#a85e7f8a9caafb1c0b3b8478906eda083), [SandBox.View.SandBoxViewSubModule](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a1a0bbe1aaf2a72a18b64892aab7047dc), and [TaleWorlds.MountAndBlade.View.ViewSubModule](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a1a35acccadea2d3b8467b317fdba9543).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#ab36ed8b2359fba1e4cc531ce65491226)RegisterSubModuleObjects()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.RegisterSubModuleObjects | ( | bool | *isSavedCampaign* | ) |  | | virtual |

Reimplemented in [SandBox.SandBoxSubModule](class_sand_box_1_1_sand_box_sub_module.html#a701265d7dbbcd5fa955ecd956f79ddd7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#aa9cf16123e433debb2792f4761de8c17)AfterRegisterSubModuleObjects()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.AfterRegisterSubModuleObjects | ( | bool | *isSavedCampaign* | ) |  | | virtual |

Reimplemented in [SandBox.SandBoxSubModule](class_sand_box_1_1_sand_box_sub_module.html#a4b936bc27c24ad139da858e240b01797).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a6549a0dd4893796c1a23601b94187290)OnMultiplayerGameStart()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnMultiplayerGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *starterObject* ) | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#ad96b27f09ffbffe484f81b41392b2344), and [TaleWorlds.MountAndBlade.View.ViewSubModule](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#acd1fa6139031b80394da07448c583ff7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a005e6e214e4b45a723243ece208e1188)OnGameInitializationFinished()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnGameInitializationFinished | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented in [SandBox.SandBoxSubModule](class_sand_box_1_1_sand_box_sub_module.html#aee32cdf1098e510ed63d1a7152cedfc2), [StoryMode.GauntletUI.StoryModeGauntletUISubModule](class_story_mode_1_1_gauntlet_u_i_1_1_story_mode_gauntlet_u_i_sub_module.html#a29503c3b6a82f57a2a20ecc3c8cb0613), [StoryMode.View.StoryModeViewSubModule](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#acceff4e1e2511c311702061dc9d2cb67), and [TaleWorlds.MountAndBlade.View.ViewSubModule](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#a4f6993b12f5024834971636f305410f5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a971056fd00e36a241fffafcdbfc3e1f1)OnAfterGameInitializationFinished()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnAfterGameInitializationFinished | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *starterObject* ) | | virtual |

Reimplemented in [SandBox.View.SandBoxViewSubModule](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a836c368bbe34518b769c0544a6fcb5d6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a17c519cb5b418e000d96ea579c5510b5)DoLoading()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.MBSubModuleBase.DoLoading | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.View.ViewSubModule](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ab5477bcea2ae03b234d47d35f11e315a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a19a3db1dbab60544f0b908c7e39da5ee)OnGameEnd()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnGameEnd | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented in [SandBox.GauntletUI.SandBoxGauntletUISubModule](class_sand_box_1_1_gauntlet_u_i_1_1_sand_box_gauntlet_u_i_sub_module.html#a35ff6b7dbc0ec82be5d2033887e2f2d7), [SandBox.View.SandBoxViewSubModule](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a740ebcdad957a7d89d5dfd9da8804b9f), [StoryMode.GauntletUI.StoryModeGauntletUISubModule](class_story_mode_1_1_gauntlet_u_i_1_1_story_mode_gauntlet_u_i_sub_module.html#ad9c0f7a8d2910b8b73718aa51fe83a03), [StoryMode.StoryModeSubModule](class_story_mode_1_1_story_mode_sub_module.html#a77faf23fe5a9e15f5676a9014ccfcb16), [StoryMode.View.StoryModeViewSubModule](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#abd8a777b23b84a6b39339fd5906092ea), [TaleWorlds.MountAndBlade.GauntletUI.GauntletUISubModule](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_gauntlet_u_i_sub_module.html#a648f0ff3c6041668e3bd99483d0e2718), and [TaleWorlds.MountAndBlade.View.ViewSubModule](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_view_sub_module.html#ae3231ebecb7afa1f51edbda4e3d7f54c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#aa618c47aee28afab8054fdb6f3354c66)OnMissionBehaviorInitialize()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnMissionBehaviorInitialize | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abd5023705e60f44d2ecdb6a937ccc9ba)OnBeforeMissionBehaviorInitialize()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnBeforeMissionBehaviorInitialize | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a99f049e0e89d4f73fda8eda6b83b53bf)OnInitialState()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnInitialState | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.View.SandBoxViewSubModule](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a36b9074cddcbd0d386500664b62dd7df).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a11043f64a8f74a0881e3807e3e582f45)OnSubModuleActivated()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnSubModuleActivated | ( |  | ) |  | | virtual |

Reimplemented in [StoryMode.View.StoryModeViewSubModule](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a493021722235b10ff1e6e538e2fc826c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abe66ad1e9da0c2c1bd85a2c362964959)OnSubModuleDeactivated()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.OnSubModuleDeactivated | ( |  | ) |  | | virtual |

Reimplemented in [StoryMode.View.StoryModeViewSubModule](class_story_mode_1_1_view_1_1_story_mode_view_sub_module.html#a93882d2fdf94a51b2832c9107ea72eaf).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#ac2c68a71f4799aaa0463b46caedf00f7)InitializeSubModuleGameObjects()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MBSubModuleBase.InitializeSubModuleGameObjects | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

