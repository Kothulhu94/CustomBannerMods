--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html ---

TaleWorlds.MountAndBlade.IMissionSystemHandler Interface ReferenceInherited by [TaleWorlds.MountAndBlade.View.Screens.MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnMissionAfterStarting](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a6f1c0a5fc5d2dc227d15e3112539b83b) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| void | [OnMissionLoadingFinished](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a652413ffdfae59c256e4775260c63dc7) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| void | [BeforeMissionTick](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#ab825e112ed679bc26ec2e7652021731f) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, float realDt) |
| void | [AfterMissionTick](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a99e5f8510a870e231eaed874f67f7c7d) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, float realDt) |
| void | [UpdateCamera](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a63146c00fb8211239f47a71628f597ec) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, float realDt) |
| bool | [RenderIsReady](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#ad29ef9e709fee7da4f48c6bf3806f5f1) () |
| IEnumerable< [MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) > | [OnAddBehaviors](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a6e49555e63bf36a0c9453732020e24b4) (IEnumerable< [MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) > behaviors, [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, string missionName, bool addDefaultMissionBehaviors) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a6f1c0a5fc5d2dc227d15e3112539b83b)OnMissionAfterStarting()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionSystemHandler.OnMissionAfterStarting | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a652413ffdfae59c256e4775260c63dc7)OnMissionLoadingFinished()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionSystemHandler.OnMissionLoadingFinished | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#ab825e112ed679bc26ec2e7652021731f)BeforeMissionTick()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionSystemHandler.BeforeMissionTick | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | float | *realDt* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a99e5f8510a870e231eaed874f67f7c7d)AfterMissionTick()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionSystemHandler.AfterMissionTick | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | float | *realDt* ) |

Implemented in [TaleWorlds.MountAndBlade.View.Screens.MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html#a9aa427ba35ba81f52b892336cfaf28ba).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a63146c00fb8211239f47a71628f597ec)UpdateCamera()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionSystemHandler.UpdateCamera | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | float | *realDt* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#ad29ef9e709fee7da4f48c6bf3806f5f1)RenderIsReady()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionSystemHandler.RenderIsReady | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_system_handler.html#a6e49555e63bf36a0c9453732020e24b4)OnAddBehaviors()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| IEnumerable< [MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) > TaleWorlds.MountAndBlade.IMissionSystemHandler.OnAddBehaviors | ( | IEnumerable< [MissionBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_mission_behavior.html) > | *behaviors*, |
|  |  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | string | *missionName*, |
|  |  | bool | *addDefaultMissionBehaviors* ) |

