--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html ---

SandBox.Missions.MissionLogics.MissionPathGenerationLogic.LookBackPointData Class ReferenceInherits [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [LookBackPointData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#ae44e2842f78990bf44673b49df75c17c) ([WorldPosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a9ae78d554531c886256c541f0247d1ac) position, [WorldPosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a9ae78d554531c886256c541f0247d1ac) direction, float pathDistanceRatio) |
| override [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) | [GetPointOfInterestType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a6766acbba2d6a6d237bbdd402ba1affa) () |
| override List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [GetPositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#ac75061f40d8947ee9f580c9032f98469) () |
| override bool | [IsInRadius](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a7e577068773d9ef2069143f9219bd877) ([PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) otherPointOfInterest) |
| override float | [GetLocationRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a8fbd4827f9c53488430380927b337cc8) () |
| Public Member Functions inherited from [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | |
| [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) | [GetPointOfInterestType](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3a1e8f99f9e22c3ae32e16449e5fcbc9) () |
| List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> | [GetPositionAndRadiusPairs](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#ac0b7562b8ef30ad716134b858bae7580) () |
| bool | [IsInRadius](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a72ee6ef5cef0eca6d5e123eb75e0db40) ([PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) otherPointOfInterest) |
| float | [GetLocationRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a0556c5834548c475e4b2be638c0244e4) () |

|  |  |
| --- | --- |
| Public Attributes | |
| WorldPosition | [WorldPosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a9ae78d554531c886256c541f0247d1ac) |
| [WorldPosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a9ae78d554531c886256c541f0247d1ac) | [DirectionWorldPosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a49f4ad422021a0b3e210762b7c5b177a) |
| float | [PathDistanceRatio](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a040d9a40451e231cdf98ac878afc8908) |
| Public Attributes inherited from [SandBox.Missions.MissionLogics.MissionPathGenerationLogic.PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | |
| float | [Score](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html#a3db6f9b713be4d931f85f16fa135cf4a) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#ae44e2842f78990bf44673b49df75c17c)LookBackPointData()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Missions.MissionLogics.MissionPathGenerationLogic.LookBackPointData.LookBackPointData | ( | [WorldPosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a9ae78d554531c886256c541f0247d1ac) | *position*, |
|  |  | [WorldPosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a9ae78d554531c886256c541f0247d1ac) | *direction*, |
|  |  | float | *pathDistanceRatio* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a6766acbba2d6a6d237bbdd402ba1affa)GetPointOfInterestType()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [PointOfInterests](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic.html#a843e89bb9ec59f2f496028dd6b4ef921) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.LookBackPointData.GetPointOfInterestType | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#ac75061f40d8947ee9f580c9032f98469)GetPositionAndRadiusPairs()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override List<([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.LookBackPointData.GetPositionAndRadiusPairs | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a7e577068773d9ef2069143f9219bd877)IsInRadius()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool SandBox.Missions.MissionLogics.MissionPathGenerationLogic.LookBackPointData.IsInRadius | ( | [PointOfInterestBaseData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_point_of_interest_base_data.html) | *otherPointOfInterest* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a8fbd4827f9c53488430380927b337cc8)GetLocationRatio()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.LookBackPointData.GetLocationRatio | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a9ae78d554531c886256c541f0247d1ac)WorldPosition
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| WorldPosition SandBox.Missions.MissionLogics.MissionPathGenerationLogic.LookBackPointData.WorldPosition |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a49f4ad422021a0b3e210762b7c5b177a)DirectionWorldPosition
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [WorldPosition](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a9ae78d554531c886256c541f0247d1ac) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.LookBackPointData.DirectionWorldPosition |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_look_back_point_data.html#a040d9a40451e231cdf98ac878afc8908)PathDistanceRatio
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.LookBackPointData.PathDistanceRatio |

