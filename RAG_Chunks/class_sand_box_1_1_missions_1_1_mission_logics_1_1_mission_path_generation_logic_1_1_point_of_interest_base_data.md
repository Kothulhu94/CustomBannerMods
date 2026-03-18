--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html ---

SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData Class ReferenceabstractInherited by [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadScoreData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html), [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.LookBackPointData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html), [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.StandingGuardSpawnData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html), and [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) | [GetPointOfInterestType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3a1e8f99f9e22c3ae32e16449e5fcbc9) () |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [GetPositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#ac0b7562b8ef30ad716134b858bae7580) () |
| bool | [IsInRadius](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a72ee6ef5cef0eca6d5e123eb75e0db40) ([PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) otherPointOfInterest) |
| float | [GetLocationRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a0556c5834548c475e4b2be638c0244e4) () |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [Score](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3db6f9b713be4d931f85f16fa135cf4a) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3a1e8f99f9e22c3ae32e16449e5fcbc9)GetPointOfInterestType()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData.GetPointOfInterestType | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#ac0b7562b8ef30ad716134b858bae7580)GetPositionAndRadiusPairs()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData.GetPositionAndRadiusPairs | ( |  | ) |  | | abstract |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a72ee6ef5cef0eca6d5e123eb75e0db40)IsInRadius()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData.IsInRadius | ( | [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | *otherPointOfInterest* | ) |  | | abstract |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a0556c5834548c475e4b2be638c0244e4)GetLocationRatio()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData.GetLocationRatio | ( |  | ) |  | | abstract |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3db6f9b713be4d931f85f16fa135cf4a)Score
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData.Score |

