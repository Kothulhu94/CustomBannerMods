--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html ---

SandBox.Missions.MissionLogics.MissionPathGenerationLogic.StandingGuardSpawnData Class ReferenceInherits [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [StandingGuardSpawnData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#ac7b9b0b138301a46393b9d7e7ff8f08d) ([UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) guardPointData, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) spawnDirection, float score) |
| override [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) | [GetPointOfInterestType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#a9a416f2d2ce45ba2a49da0aaa78a9e9b) () |
| override List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [GetPositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#ac905e2281d7453441da7a3e9c7420fc2) () |
| override bool | [IsInRadius](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#ad2c3a916e914fc9fcb446f98eb34652f) ([PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) otherPointOfInterest) |
| override float | [GetLocationRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#a7fe5a49706e8ceb2608d2cf74249dffa) () |
| Public Member Functions inherited from [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | |
| [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) | [GetPointOfInterestType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3a1e8f99f9e22c3ae32e16449e5fcbc9) () |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [GetPositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#ac0b7562b8ef30ad716134b858bae7580) () |
| bool | [IsInRadius](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a72ee6ef5cef0eca6d5e123eb75e0db40) ([PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) otherPointOfInterest) |
| float | [GetLocationRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a0556c5834548c475e4b2be638c0244e4) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) | [GuardPointData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#a27525af3f15f9f61e634f829b3fcc444) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [SpawnDirection](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#adedc3e32b00a11bb3725977ee8cfb1cb) |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [PositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#ac80fc26885cdfe78b710f0a803bf9b2b) |
| Public Attributes inherited from [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | |
| float | [Score](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3db6f9b713be4d931f85f16fa135cf4a) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#ac7b9b0b138301a46393b9d7e7ff8f08d)StandingGuardSpawnData()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Missions.MissionLogics.MissionPathGenerationLogic.StandingGuardSpawnData.StandingGuardSpawnData | ( | [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) | *guardPointData*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *spawnDirection*, |
|  |  | float | *score* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#a9a416f2d2ce45ba2a49da0aaa78a9e9b)GetPointOfInterestType()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.StandingGuardSpawnData.GetPointOfInterestType | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#ac905e2281d7453441da7a3e9c7420fc2)GetPositionAndRadiusPairs()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.StandingGuardSpawnData.GetPositionAndRadiusPairs | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#ad2c3a916e914fc9fcb446f98eb34652f)IsInRadius()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool SandBox.Missions.MissionLogics.MissionPathGenerationLogic.StandingGuardSpawnData.IsInRadius | ( | [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | *otherPointOfInterest* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#a7fe5a49706e8ceb2608d2cf74249dffa)GetLocationRatio()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.StandingGuardSpawnData.GetLocationRatio | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#a27525af3f15f9f61e634f829b3fcc444)GuardPointData
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.StandingGuardSpawnData.GuardPointData |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#adedc3e32b00a11bb3725977ee8cfb1cb)SpawnDirection
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.StandingGuardSpawnData.SpawnDirection |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_standing_guard_spawn_data.html#ac80fc26885cdfe78b710f0a803bf9b2b)PositionAndRadiusPairs
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.StandingGuardSpawnData.PositionAndRadiusPairs |

