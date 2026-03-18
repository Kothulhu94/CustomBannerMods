--- SOURCE: class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html ---

SandBox.View.SandBoxViewSubModule Class ReferenceInherits [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnCampaignStart](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a1a0bbe1aaf2a72a18b64892aab7047dc) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
| override void | [OnGameLoaded](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#af5e8a2cbe55b4bca0d7d3e223f18e72d) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object initializerObject) |
|  | This function is called after game is created or loaded. |
| override void | [OnAfterGameInitializationFinished](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a836c368bbe34518b769c0544a6fcb5d6) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
| override void | [BeginGameStart](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#ae00159e99393e96196ed538ba3951b5f) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| override void | [OnGameEnd](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a740ebcdad957a7d89d5dfd9da8804b9f) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| override void | [OnInitialState](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a36b9074cddcbd0d386500664b62dd7df) () |
|  | Triggered when state returns to initial state. Works when related module is deactivated. |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html) | |
| virtual void | [OnConfigChanged](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a8c80398e339b7ba98cba88b76ceee2bf) () |
|  | This is the function called whenever a config is changed. Works when the related module is deactivated. |
| virtual void | [OnAfterGameLoaded](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#acb9f8c9ea14610f57a1e77d1371d71c7) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| virtual void | [OnNewGameCreated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a1db6c130f39f8f64af0dde6e56cf99df) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object initializerObject) |
| virtual void | [RegisterSubModuleObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#ab36ed8b2359fba1e4cc531ce65491226) (bool isSavedCampaign) |
| virtual void | [AfterRegisterSubModuleObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#aa9cf16123e433debb2792f4761de8c17) (bool isSavedCampaign) |
| virtual void | [OnMultiplayerGameStart](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a6549a0dd4893796c1a23601b94187290) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game, object starterObject) |
| virtual void | [OnGameInitializationFinished](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a005e6e214e4b45a723243ece208e1188) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| virtual bool | [DoLoading](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a17c519cb5b418e000d96ea579c5510b5) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |
| virtual void | [OnMissionBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#aa618c47aee28afab8054fdb6f3354c66) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnBeforeMissionBehaviorInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abd5023705e60f44d2ecdb6a937ccc9ba) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| virtual void | [OnSubModuleActivated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a11043f64a8f74a0881e3807e3e582f45) () |
| virtual void | [OnSubModuleDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abe66ad1e9da0c2c1bd85a2c362964959) () |
| virtual void | [InitializeSubModuleGameObjects](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#ac2c68a71f4799aaa0463b46caedf00f7) ([Game](class_tale_worlds_1_1_core_1_1_game.html) game) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SetMapConversationDataProvider](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a501cc2d6675d10fe54758579e6f67094) ([IMapConversationDataProvider](interface_sand_box_1_1_view_1_1_map_1_1_i_map_conversation_data_provider.html) mapConversationDataProvider) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnSubModuleLoad](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#ac010a3871213e161e563608358511bfd) () |
|  | This is the function which is called first when application is started. Works when the related module is deactivated. |
| override void | [OnSubModuleUnloaded](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a53223229185a80738ec9bb714d79f9d8) () |
|  | This is the function when application is about to get terminated. Works when the related module is deactivated. |
| override void | [OnApplicationTick](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#abf6673ea6c381baae40aee23ea095c5f) (float dt) |

|  |  |
| --- | --- |
| Properties | |
| static SandBoxViewVisualManager | [SandBoxViewVisualManager](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a376d46015b776520e91a968afce0bf7a) `[get]` |
| static ConversationViewManager | [ConversationViewManager](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a7ef8c330b2458c7eeebb17f7d23a027a) `[get]` |
| static [IMapConversationDataProvider](interface_sand_box_1_1_view_1_1_map_1_1_i_map_conversation_data_provider.html) | [MapConversationDataProvider](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a5ce537c69fe215cc364be14c983f1440) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#ac010a3871213e161e563608358511bfd)OnSubModuleLoad()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.SandBoxViewSubModule.OnSubModuleLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a53223229185a80738ec9bb714d79f9d8)OnSubModuleUnloaded()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.SandBoxViewSubModule.OnSubModuleUnloaded | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#abf6673ea6c381baae40aee23ea095c5f)OnApplicationTick()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.SandBoxViewSubModule.OnApplicationTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html).

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a1a0bbe1aaf2a72a18b64892aab7047dc)OnCampaignStart()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.View.SandBoxViewSubModule.OnCampaignStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *starterObject* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a40545a8fe14af634d742b71071c3bdef).

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#af5e8a2cbe55b4bca0d7d3e223f18e72d)OnGameLoaded()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.View.SandBoxViewSubModule.OnGameLoaded | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *initializerObject* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#abe3ccc72d0b6d71870da8ef3b0fc59d6).

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a836c368bbe34518b769c0544a6fcb5d6)OnAfterGameInitializationFinished()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.View.SandBoxViewSubModule.OnAfterGameInitializationFinished | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game*, | |  |  | object | *starterObject* ) | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a971056fd00e36a241fffafcdbfc3e1f1).

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#ae00159e99393e96196ed538ba3951b5f)BeginGameStart()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.SandBoxViewSubModule.BeginGameStart | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a1505c84ae2724012f25c1010c781d4e1).

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a740ebcdad957a7d89d5dfd9da8804b9f)OnGameEnd()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.View.SandBoxViewSubModule.OnGameEnd | ( | [Game](class_tale_worlds_1_1_core_1_1_game.html) | *game* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a19a3db1dbab60544f0b908c7e39da5ee).

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a36b9074cddcbd0d386500664b62dd7df)OnInitialState()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.View.SandBoxViewSubModule.OnInitialState | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MBSubModuleBase](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_sub_module_base.html#a99f049e0e89d4f73fda8eda6b83b53bf).

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a501cc2d6675d10fe54758579e6f67094)SetMapConversationDataProvider()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.View.SandBoxViewSubModule.SetMapConversationDataProvider | ( | [IMapConversationDataProvider](interface_sand_box_1_1_view_1_1_map_1_1_i_map_conversation_data_provider.html) | *mapConversationDataProvider* | ) |  | | static |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a376d46015b776520e91a968afce0bf7a)SandBoxViewVisualManager
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SandBoxViewVisualManager SandBox.View.SandBoxViewSubModule.SandBoxViewVisualManager | | staticget |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a7ef8c330b2458c7eeebb17f7d23a027a)ConversationViewManager
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ConversationViewManager SandBox.View.SandBoxViewSubModule.ConversationViewManager | | staticget |

[◆](class_sand_box_1_1_view_1_1_sand_box_view_sub_module.html#a5ce537c69fe215cc364be14c983f1440)MapConversationDataProvider
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMapConversationDataProvider](interface_sand_box_1_1_view_1_1_map_1_1_i_map_conversation_data_provider.html) SandBox.View.SandBoxViewSubModule.MapConversationDataProvider | | staticget |

