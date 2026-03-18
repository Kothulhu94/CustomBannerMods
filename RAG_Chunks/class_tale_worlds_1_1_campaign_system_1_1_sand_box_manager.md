--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html ---

TaleWorlds.CampaignSystem.SandBoxManager Class ReferenceInherits [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a1f2d09c32731d8684319c6120c62cf1c) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) gameStarter) |
| void | [OnCampaignStart](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a01854449ef2173fc3595fb778cc99aa0) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) gameInitializer, [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) gameManager, bool isSavedCampaign) |
|  | This function is called when a new game is created. |
| void | [InitializeSandboxXMLs](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#ac951b45c4285a8971aa9b001a88a17ad) (bool isSavedCampaign) |
| void | [InitializeCharactersAfterLoad](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#afa56574af77a8928582a982aaa5d4918) (bool isSavedCampaign) |
| override void | [OnBeforeSave](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a36fbe57eb3915920a00bcc3fbb46ba49) () |
| override void | [OnAfterSave](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a7c711eac771e0432989531fb4617f781) () |
| Public Member Functions inherited from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html) | |
| void | [OnBeforeSave](class_tale_worlds_1_1_core_1_1_game_handler.html#aa870791b625cc2ccd8dfa82303fa3c55) () |
| void | [OnAfterSave](class_tale_worlds_1_1_core_1_1_game_handler.html#a314d506531637f8f16076c1a24ed3bfb) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnGameStart](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a506074a9612aa2c6859743e7cb6ff13b) () |
| override void | [OnGameEnd](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#afaa89ca84f695aed490e4cc52414da9a) () |
| override void | [OnTick](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a4fb0cb971bf2cee556f58f6496766781) (float dt) |
| Protected Member Functions inherited from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html) | |
| virtual void | [OnInitialize](class_tale_worlds_1_1_core_1_1_game_handler.html#a748ff17ecab120adae549cb72d6c0560) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_core_1_1_game_handler.html#acc5cd06df93b85f63268875deddc18c2) () |

|  |  |
| --- | --- |
| Properties | |
| [ISandBoxMissionManager](interface_tale_worlds_1_1_campaign_system_1_1_i_sand_box_mission_manager.html) | [SandBoxMissionManager](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a0c40a40979543a83ddbf2f32c7b14e36) `[get, set]` |
| [IAgentBehaviorManager](interface_tale_worlds_1_1_campaign_system_1_1_i_agent_behavior_manager.html) | [AgentBehaviorManager](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#aed46ee082bea92955262e0f85139286f) `[get, set]` |
| [ISaveManager](interface_tale_worlds_1_1_campaign_system_1_1_i_save_manager.html) | [SandBoxSaveManager](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a01ddd1fee1ac192a922cea5222b37cb0) `[get, set]` |
| static [SandBoxManager](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html) | [Instance](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a3e62b0a4aae3bb7875c4b8aa7cdce668) `[get]` |
| [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | [GameStarter](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a26189b60fc3cd1212d8b6445d6f904de) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a1f2d09c32731d8684319c6120c62cf1c)Initialize()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.SandBoxManager.Initialize | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *gameStarter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a01854449ef2173fc3595fb778cc99aa0)OnCampaignStart()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.SandBoxManager.OnCampaignStart | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *gameInitializer*, |
|  |  | [GameManagerBase](class_tale_worlds_1_1_core_1_1_game_manager_base.html) | *gameManager*, |
|  |  | bool | *isSavedCampaign* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a506074a9612aa2c6859743e7cb6ff13b)OnGameStart()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.SandBoxManager.OnGameStart | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html).

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#afaa89ca84f695aed490e4cc52414da9a)OnGameEnd()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.SandBoxManager.OnGameEnd | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html).

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#ac951b45c4285a8971aa9b001a88a17ad)InitializeSandboxXMLs()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.SandBoxManager.InitializeSandboxXMLs | ( | bool | *isSavedCampaign* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#afa56574af77a8928582a982aaa5d4918)InitializeCharactersAfterLoad()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.SandBoxManager.InitializeCharactersAfterLoad | ( | bool | *isSavedCampaign* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a4fb0cb971bf2cee556f58f6496766781)OnTick()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.SandBoxManager.OnTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Core.GameHandler](class_tale_worlds_1_1_core_1_1_game_handler.html).

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a36fbe57eb3915920a00bcc3fbb46ba49)OnBeforeSave()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.SandBoxManager.OnBeforeSave | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a7c711eac771e0432989531fb4617f781)OnAfterSave()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.SandBoxManager.OnAfterSave | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a0c40a40979543a83ddbf2f32c7b14e36)SandBoxMissionManager
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ISandBoxMissionManager](interface_tale_worlds_1_1_campaign_system_1_1_i_sand_box_mission_manager.html) TaleWorlds.CampaignSystem.SandBoxManager.SandBoxMissionManager | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#aed46ee082bea92955262e0f85139286f)AgentBehaviorManager
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IAgentBehaviorManager](interface_tale_worlds_1_1_campaign_system_1_1_i_agent_behavior_manager.html) TaleWorlds.CampaignSystem.SandBoxManager.AgentBehaviorManager | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a01ddd1fee1ac192a922cea5222b37cb0)SandBoxSaveManager
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ISaveManager](interface_tale_worlds_1_1_campaign_system_1_1_i_save_manager.html) TaleWorlds.CampaignSystem.SandBoxManager.SandBoxSaveManager | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a3e62b0a4aae3bb7875c4b8aa7cdce668)Instance
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SandBoxManager](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html) TaleWorlds.CampaignSystem.SandBoxManager.Instance | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_sand_box_manager.html#a26189b60fc3cd1212d8b6445d6f904de)GameStarter
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) TaleWorlds.CampaignSystem.SandBoxManager.GameStarter | | get |

