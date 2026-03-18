--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html ---

TaleWorlds.MountAndBlade.Source.Objects.Siege.AgentPathNavMeshChecker Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [Direction](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#ab272466b40b1e9e3332d215928699d18) {     [ForwardOnly](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#ab272466b40b1e9e3332d215928699d18abaf091bcacd081bc1e0c1fc65d43e09b) ,     [BackwardOnly](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#ab272466b40b1e9e3332d215928699d18a9478b1b7d63175dc6e435f28fecaaac9) ,     [BothDirections](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#ab272466b40b1e9e3332d215928699d18a097bbd72736d38e96a8128b9b52d75e6)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [AgentPathNavMeshChecker](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#abe088e627b6a048bd180ed710d4452a3) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) pathFrameToCheck, float radiusToCheck, int navMeshId, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) teamToCollect, [Direction](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#ab272466b40b1e9e3332d215928699d18) directionToCollect, float maxDistanceCheck, float agentMoveTime) |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#a2cd86f0c42852061b34d17dd1d64d6f0) (float dt) |
| void | [TickOccasionally](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#af5938d0ea23135738a99d1c0db61b4b3) (float dt) |
| bool | [HasAgentsUsingPath](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#a681efee09c95274509cb37d8c2bc0487) () |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#ab272466b40b1e9e3332d215928699d18)Direction
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.Source.Objects.Siege.AgentPathNavMeshChecker.Direction](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#ab272466b40b1e9e3332d215928699d18) |

| Enumerator | |
| --- | --- |
| ForwardOnly |  |
| BackwardOnly |  |
| BothDirections |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#abe088e627b6a048bd180ed710d4452a3)AgentPathNavMeshChecker()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Source.Objects.Siege.AgentPathNavMeshChecker.AgentPathNavMeshChecker | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *pathFrameToCheck*, |
|  |  | float | *radiusToCheck*, |
|  |  | int | *navMeshId*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *teamToCollect*, |
|  |  | [Direction](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#ab272466b40b1e9e3332d215928699d18) | *directionToCollect*, |
|  |  | float | *maxDistanceCheck*, |
|  |  | float | *agentMoveTime* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#a2cd86f0c42852061b34d17dd1d64d6f0)Tick()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Source.Objects.Siege.AgentPathNavMeshChecker.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#af5938d0ea23135738a99d1c0db61b4b3)TickOccasionally()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Source.Objects.Siege.AgentPathNavMeshChecker.TickOccasionally | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_source_1_1_objects_1_1_siege_1_1_agent_path_nav_mesh_checker.html#a681efee09c95274509cb37d8c2bc0487)HasAgentsUsingPath()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.Source.Objects.Siege.AgentPathNavMeshChecker.HasAgentsUsingPath | ( |  | ) |  |

