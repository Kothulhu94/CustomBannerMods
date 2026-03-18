--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html ---

SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData Class ReferenceInherits [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [VisitPointNodeScoreData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a386ab7ccc48e2763546248abeb8eb63d) ([UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) visitPointData, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) possibleBlendPointPosition, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) visitPointPathStartPoint, float visitPointPathStartPointPathRatio, float score, float startingAngle, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) fWP, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) sWP, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) pathToVisitPoint, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) closestPointToBlendPoint) |
| override [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) | [GetPointOfInterestType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#ae3f6e109408f664f7f1cc3401bc417ad) () |
| override List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [GetPositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#acc8742c58c6b0b19a5072ae10dd20200) () |
| override bool | [IsInRadius](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a6337b97fe04edc232604497fa27462f3) ([PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) otherPointOfInterest) |
| override float | [GetLocationRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a9964a13c7bb6441307e4a98dbb847c79) () |
| Public Member Functions inherited from [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | |
| [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) | [GetPointOfInterestType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3a1e8f99f9e22c3ae32e16449e5fcbc9) () |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [GetPositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#ac0b7562b8ef30ad716134b858bae7580) () |
| bool | [IsInRadius](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a72ee6ef5cef0eca6d5e123eb75e0db40) ([PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) otherPointOfInterest) |
| float | [GetLocationRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a0556c5834548c475e4b2be638c0244e4) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) | [VisitPointData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#ab69f6a27e24038227a6aa62a4af647ee) |
| bool | [UsingAsInteractablePoint](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a2d3bc3be7c9bc14f67659d4b125134d0) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [PossibleBlendPointPosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a8604b43a4179f62f2a90507b8aa4f911) |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [PositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a6e76127574889d20209955f677c00cbe) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [VisitPointPathStartPoint](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#af2977ec22bcd21b47415856c9989e030) |
| float | [VisitPointPathStartPointPathRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#adacc5858894db387f9277fb7b2a12ca9) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [ClosestPointToBlendPoint](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#ad9149085c254d76020eae1387f61520a) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [FWP](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#ae41a51226c5730aa3345bb21a4aa1889) |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | [SWP](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#aa6e642a62e82378f7313f8fff2091362) |
| float | [StartingAngle](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a6a4cd93e5f7bd7efc4937459b97fdeaf) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [PathToVisitPoint](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#af5bcad19923033c88be533b606af2e63) |
| Public Attributes inherited from [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | |
| float | [Score](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3db6f9b713be4d931f85f16fa135cf4a) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a386ab7ccc48e2763546248abeb8eb63d)VisitPointNodeScoreData()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.VisitPointNodeScoreData | ( | [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) | *visitPointData*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *possibleBlendPointPosition*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *visitPointPathStartPoint*, |
|  |  | float | *visitPointPathStartPointPathRatio*, |
|  |  | float | *score*, |
|  |  | float | *startingAngle*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *fWP*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *sWP*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *pathToVisitPoint*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *closestPointToBlendPoint* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#ae3f6e109408f664f7f1cc3401bc417ad)GetPointOfInterestType()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.GetPointOfInterestType | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#acc8742c58c6b0b19a5072ae10dd20200)GetPositionAndRadiusPairs()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.GetPositionAndRadiusPairs | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a6337b97fe04edc232604497fa27462f3)IsInRadius()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.IsInRadius | ( | [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | *otherPointOfInterest* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a9964a13c7bb6441307e4a98dbb847c79)GetLocationRatio()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.GetLocationRatio | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#ab69f6a27e24038227a6aa62a4af647ee)VisitPointData
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.VisitPointData |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a2d3bc3be7c9bc14f67659d4b125134d0)UsingAsInteractablePoint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.UsingAsInteractablePoint |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a8604b43a4179f62f2a90507b8aa4f911)PossibleBlendPointPosition
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.PossibleBlendPointPosition |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a6e76127574889d20209955f677c00cbe)PositionAndRadiusPairs
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.PositionAndRadiusPairs |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#af2977ec22bcd21b47415856c9989e030)VisitPointPathStartPoint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.VisitPointPathStartPoint |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#adacc5858894db387f9277fb7b2a12ca9)VisitPointPathStartPointPathRatio
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.VisitPointPathStartPointPathRatio |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#ad9149085c254d76020eae1387f61520a)ClosestPointToBlendPoint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.ClosestPointToBlendPoint |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#ae41a51226c5730aa3345bb21a4aa1889)FWP
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.FWP |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#aa6e642a62e82378f7313f8fff2091362)SWP
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.SWP |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#a6a4cd93e5f7bd7efc4937459b97fdeaf)StartingAngle
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.StartingAngle |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_visit_point_node_score_data.html#af5bcad19923033c88be533b606af2e63)PathToVisitPoint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.VisitPointNodeScoreData.PathToVisitPoint |

