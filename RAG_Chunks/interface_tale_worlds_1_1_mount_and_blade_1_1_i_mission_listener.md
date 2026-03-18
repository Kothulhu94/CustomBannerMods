--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html ---

TaleWorlds.MountAndBlade.IMissionListener Interface ReferenceInherited by [TaleWorlds.MountAndBlade.GauntletUI.Mission.MissionGauntletCategoryLoadManager](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_mission_1_1_mission_gauntlet_category_load_manager.html), and [TaleWorlds.MountAndBlade.View.Screens.MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnEquipItemsFromSpawnEquipmentBegin](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#add1927aa66b8a7e797aa2e22b5c368eb) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent.CreationType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) creationType) |
| void | [OnEquipItemsFromSpawnEquipment](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#a6a3e6a027b5e192c1563e11baf40cb05) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [Agent.CreationType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) creationType) |
| void | [OnEndMission](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#ad92a10adb06f2abecb97e3c4c6012791) () |
| void | [OnMissionModeChange](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#a6b20eea9ed50ad5f2148dd530f675549) ([MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) oldMissionMode, bool atStart) |
| void | [OnConversationCharacterChanged](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#aff62999be7728c19f6085bdc86be75db) () |
| void | [OnResetMission](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#a381a932052ecf45bc531ccefa38ae428) () |
| void | [OnDeploymentPlanMade](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#a3e8d23ca1765c9162a2823565779390e) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool isFirstPlan) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#add1927aa66b8a7e797aa2e22b5c368eb)OnEquipItemsFromSpawnEquipmentBegin()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionListener.OnEquipItemsFromSpawnEquipmentBegin | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [Agent.CreationType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) | *creationType* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#a6a3e6a027b5e192c1563e11baf40cb05)OnEquipItemsFromSpawnEquipment()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionListener.OnEquipItemsFromSpawnEquipment | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | [Agent.CreationType](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#a98ba61b43dff1b7e80a874e6d42a4938) | *creationType* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#ad92a10adb06f2abecb97e3c4c6012791)OnEndMission()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionListener.OnEndMission | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#a6b20eea9ed50ad5f2148dd530f675549)OnMissionModeChange()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionListener.OnMissionModeChange | ( | [MissionMode](namespace_tale_worlds_1_1_core.html#a34f0ac611df16851fc92e4523aa834e1) | *oldMissionMode*, |
|  |  | bool | *atStart* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#aff62999be7728c19f6085bdc86be75db)OnConversationCharacterChanged()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionListener.OnConversationCharacterChanged | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#a381a932052ecf45bc531ccefa38ae428)OnResetMission()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionListener.OnResetMission | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_listener.html#a3e8d23ca1765c9162a2823565779390e)OnDeploymentPlanMade()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionListener.OnDeploymentPlanMade | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | bool | *isFirstPlan* ) |

