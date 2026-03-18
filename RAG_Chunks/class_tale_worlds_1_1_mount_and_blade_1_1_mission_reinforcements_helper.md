--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html ---

TaleWorlds.MountAndBlade.MissionReinforcementsHelper Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [ReinforcementFormationPreferenceComparer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper_1_1_reinforcement_formation_preference_comparer.html) |
| class | [ReinforcementFormationData](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper_1_1_reinforcement_formation_data.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [ReinforcementFormationPriority](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a25cae0608d09a8432e38644833e30e97) {     [Dominant](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a25cae0608d09a8432e38644833e30e97a727014c7464faaf7c7807e9b0f8aafc6) = 6 ,     [Common](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a25cae0608d09a8432e38644833e30e97ad13bc5b68b2bd9e18f29777db17cc563) = 5 ,     [EmptyRepresentativeMatch](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a25cae0608d09a8432e38644833e30e97a6ef1088bc83021d6b660a771e7616db8) = 4 ,     [EmptyNoMatch](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a25cae0608d09a8432e38644833e30e97a4bc396df448fae2726428c22e154e1f8) = 3 ,     [AlternativeDominant](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a25cae0608d09a8432e38644833e30e97a11d4a2da66f5f90836facb00c8e9e8b7) = 2 ,     [AlternativeCommon](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a25cae0608d09a8432e38644833e30e97a2248e487d73d17bea1c2b97f4b987f32) = 1 ,     [Default](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a25cae0608d09a8432e38644833e30e97a7a1920d61156abc05a60135aefe8bc67) = 0   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [OnMissionStart](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a9009f4887689a047054af4293d089d42) () |
| static List<([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) origin, int formationIndex)> | [GetReinforcementAssignments](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#ada3fd8d9ca41b48273c969ed432b7d2f) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, List< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > troopOrigins) |
| static void | [OnMissionEnd](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a6831f85371e3641397eba92a382b3e58) () |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a25cae0608d09a8432e38644833e30e97)ReinforcementFormationPriority
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.MissionReinforcementsHelper.ReinforcementFormationPriority](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a25cae0608d09a8432e38644833e30e97) |

| Enumerator | |
| --- | --- |
| Dominant |  |
| Common |  |
| EmptyRepresentativeMatch |  |
| EmptyNoMatch |  |
| AlternativeDominant |  |
| AlternativeCommon |  |
| Default |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a9009f4887689a047054af4293d089d42)OnMissionStart()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MissionReinforcementsHelper.OnMissionStart | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#ada3fd8d9ca41b48273c969ed432b7d2f)GetReinforcementAssignments()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | List<([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) origin, int formationIndex)> TaleWorlds.MountAndBlade.MissionReinforcementsHelper.GetReinforcementAssignments | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, | |  |  | List< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > | *troopOrigins* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_reinforcements_helper.html#a6831f85371e3641397eba92a382b3e58)OnMissionEnd()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MissionReinforcementsHelper.OnMissionEnd | ( |  | ) |  | | static |

