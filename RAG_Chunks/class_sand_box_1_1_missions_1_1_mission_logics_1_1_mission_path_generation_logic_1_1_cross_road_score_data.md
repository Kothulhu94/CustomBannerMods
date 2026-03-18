--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html ---

SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadScoreData Class ReferenceInherits [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CrossRoadScoreData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a28f639d6f1e1ccf8bfcaf60c7f1056ca) ([UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) leftNode, [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) rightNode, float score) |
| override [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) | [GetPointOfInterestType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a4a6bc331aea4c45f6e788b665530762b) () |
| override List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [GetPositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a50fb39edf2eafa33fef793713f708621) () |
| override bool | [IsInRadius](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a1736642fbabc6af0237ef37ea76bb3ac) ([PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) otherPointOfInterest) |
| override float | [GetLocationRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#ae5ca10c4bed76faaa4c1d8daca113593) () |
| Public Member Functions inherited from [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | |
| [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) | [GetPointOfInterestType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3a1e8f99f9e22c3ae32e16449e5fcbc9) () |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [GetPositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#ac0b7562b8ef30ad716134b858bae7580) () |
| bool | [IsInRadius](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a72ee6ef5cef0eca6d5e123eb75e0db40) ([PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) otherPointOfInterest) |
| float | [GetLocationRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a0556c5834548c475e4b2be638c0244e4) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) | [LeftNode](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a2cb5a4562f1e8ff4922ddc5e750af7a0) |
| [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) | [RightNode](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#ac224e2d83d59376be2b6558b5012ac84) |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [PositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a90f893d313ccbcb0804a98cfb30a5e0a) |
| Public Attributes inherited from [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | |
| float | [Score](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3db6f9b713be4d931f85f16fa135cf4a) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a28f639d6f1e1ccf8bfcaf60c7f1056ca)CrossRoadScoreData()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadScoreData.CrossRoadScoreData | ( | [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) | *leftNode*, |
|  |  | [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) | *rightNode*, |
|  |  | float | *score* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a4a6bc331aea4c45f6e788b665530762b)GetPointOfInterestType()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadScoreData.GetPointOfInterestType | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a50fb39edf2eafa33fef793713f708621)GetPositionAndRadiusPairs()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadScoreData.GetPositionAndRadiusPairs | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a1736642fbabc6af0237ef37ea76bb3ac)IsInRadius()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadScoreData.IsInRadius | ( | [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | *otherPointOfInterest* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#ae5ca10c4bed76faaa4c1d8daca113593)GetLocationRatio()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadScoreData.GetLocationRatio | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a2cb5a4562f1e8ff4922ddc5e750af7a0)LeftNode
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadScoreData.LeftNode |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#ac224e2d83d59376be2b6558b5012ac84)RightNode
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadScoreData.RightNode |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_cross_road_score_data.html#a90f893d313ccbcb0804a98cfb30a5e0a)PositionAndRadiusPairs
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.CrossRoadScoreData.PositionAndRadiusPairs |

