--- SOURCE: class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html ---

SandBox.Missions.MissionLogics.MissionPathGenerationLogic.NavigationPathData Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NavigationPathData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#ad801b14f7af785ab4ff90e3c3b31a370) (List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > allUsablePoints, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) startingEntity, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) endingEntity, int disabledFaceId) |
| [NavigationPathData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#ad801b14f7af785ab4ff90e3c3b31a370) | [ReverseClone](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#a0b3ebc9dac7e68382d775a46e9331c1f) () |
| void | [InitializeUsablePoints](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#ac9f799e8b6f8d06fffb20a00fd12816f) (List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > allUsableMachines) |

|  |  |
| --- | --- |
| Public Attributes | |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [StartingGameEntity](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#ad6a41c3481df627ebf5f85696e622706) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [EndingGameEntity](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#a17fb73968a08b2b7c0f1b32f1d945747) |
| [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) | [Path](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#abdfac801417298a0768c78be8c12bcae) |
| Dictionary< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float > | [PathNodeAndDistances](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#ab850a470a6388999045b1dce76b114fa) |
| List< [UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html) > | [ValidUsableMachinesData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#aa32d089da61cae83b413cc1dd7996d78) |
| float | [TotalDistance](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#a1b1b7c4b95edab74f1a51cbb5ba6b6b2) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#ad801b14f7af785ab4ff90e3c3b31a370)NavigationPathData()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Missions.MissionLogics.MissionPathGenerationLogic.NavigationPathData.NavigationPathData | ( | List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > | *allUsablePoints*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *startingEntity*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *endingEntity*, |
|  |  | int | *disabledFaceId* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#a0b3ebc9dac7e68382d775a46e9331c1f)ReverseClone()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [NavigationPathData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#ad801b14f7af785ab4ff90e3c3b31a370) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.NavigationPathData.ReverseClone | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#ac9f799e8b6f8d06fffb20a00fd12816f)InitializeUsablePoints()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.MissionLogics.MissionPathGenerationLogic.NavigationPathData.InitializeUsablePoints | ( | List< [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) > | *allUsableMachines* | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#ad6a41c3481df627ebf5f85696e622706)StartingGameEntity
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.NavigationPathData.StartingGameEntity |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#a17fb73968a08b2b7c0f1b32f1d945747)EndingGameEntity
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.NavigationPathData.EndingGameEntity |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#abdfac801417298a0768c78be8c12bcae)Path
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) SandBox.Missions.MissionLogics.MissionPathGenerationLogic.NavigationPathData.Path |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#ab850a470a6388999045b1dce76b114fa)PathNodeAndDistances
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Dictionary<[Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html), float> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.NavigationPathData.PathNodeAndDistances |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#aa32d089da61cae83b413cc1dd7996d78)ValidUsableMachinesData
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[UsableMachineData](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_usable_machine_data.html)> SandBox.Missions.MissionLogics.MissionPathGenerationLogic.NavigationPathData.ValidUsableMachinesData |

[◆](class_sand_box_1_1_missions_1_1_mission_logics_1_1_mission_path_generation_logic_1_1_navigation_path_data.html#a1b1b7c4b95edab74f1a51cbb5ba6b6b2)TotalDistance
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Missions.MissionLogics.MissionPathGenerationLogic.NavigationPathData.TotalDistance |

