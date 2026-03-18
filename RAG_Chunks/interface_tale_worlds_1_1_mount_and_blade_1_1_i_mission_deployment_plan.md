--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html ---

TaleWorlds.MountAndBlade.IMissionDeploymentPlan Interface ReferenceInherited by [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Initialize](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a1451afadddd81f21c6b1f6b50b5ad128) () |
|  | Initializes deployment plans from mission. Required mission data must be set. |
| void | [ClearAll](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae663b14a405c95ee0ece79d408bf189a) () |
|  | Clears both the current deployment plan and any troops added to the plan. |
| void | [MakeDefaultDeploymentPlans](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a7762a7fffa885519a4189beffd254775) () |
|  | Makes default deployment plans for missions where detailed planning is not needed (i.e. alley fights, quests etc). |
| void | [MakeDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a5f04e04901618a0e6049fa88e01bc0d3) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, float spawnPathOffset=0, float targetOffset=0f) |
|  | Plans battle deployment for the given team. |
| bool | [RemakeDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a5a397084cfe61349e86f9a8b320975d0) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Re-Plans battle deployment for the given team. An existing plan must be prepared. Returns true if plan is re-made, false otherwise. |
| void | [ClearDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#aafbab48a0ded868281dbde98fd02abe5) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Clears the deployment plan for the given team. |
| bool | [IsPlanMade](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ac2d5841ae4d2528a32dcbb1e17ae701f) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns whether if a deployment plan is made for the given team. |
| bool | [IsPlanMade](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#af606a0b88e10c37c9c53bf213b8d1516) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, out bool isFirstPlan) |
|  | Returns whether if a deployment plan is made for the given team. Also outputs if the plan was the first plan that is made. |
| bool | [IsPositionInsideDeploymentBoundaries](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae8cf002ac02e898508640716a1dcc574) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
|  | Returns true if the given position is within the deployment boundaries of the given team. [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) should have its deployment made and its boundaries computed. Or the method returns false. |
| bool | [HasDeploymentBoundaries](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#aa3f31326980a6d0b40bb16675fc3dbc8) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns true if the given team has its initial deployment boundaries computed. |
| MBReadOnlyList<(string id, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points)> | [GetDeploymentBoundaries](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae83569634dd1162cfa156ab2a00c7745) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns a list describing the deployment boundaries of the given team Each deployment boundary has a string id describing the boundary and its associated points vector. |
| bool | [SupportsReinforcements](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a96ffeb0911939e55090b3f8b318db7ce) () |
|  | Returns true if the deployment plan supports reinforcements. |
| bool | [SupportsNavmesh](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#af909348519e7c4ed33ef26b054835abf) () |
|  | Returns true if deployment plan supports navmesh. Plans made for agent formations on land battles support this. But plans made for ships during naval battles does not as open sea battles does not have a navmesh (except certain river battles) Interface calls that make use of WorldPositions (like complex boundary intersections and position projections) will be unavailable if the plan does not support navmeshes. |
| bool | [HasPlayerSpawnFrame](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a991108d1f3482b30c53327999c9636e1) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
|  | Returns true if the given battle side has a pre-specified player spawn frame. |
| bool | [GetPlayerSpawnFrame](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ac5fc005ee8f8960b1f2693267ba51845) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
|  | Returns the pre-specified spawn frame for the player if the associated battle side has one defined. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetClosestDeploymentBoundaryPosition](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a2c5d366238cc3dd17f0b8c0f29e2e7cf) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
|  | Returns the closest point on the deployment boundary of a team to the given position. |
| void | [ProjectPositionToDeploymentBoundaries](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a7c27be32e56c4825a226d03932a58a03) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position) |
|  | Projects the given position onto the deployment boundary Alters the position to deployment boundary intersection if the position is not already within the boundaries Deployment plan must support navmeshes for this call to work. Caller must check this. |
| bool | [GetPathDeploymentBoundaryIntersection](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a625757c9a4393fb9cca0e249073f81f4) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) startPosition, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) endPosition, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) intersection) |
|  | Searches the intersection of the navmesh path (from start position to end position) with the deployment boundaries of the specified team Deployment plan must support navmeshes for this call to work. Caller must check this. |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetDeploymentFrame](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ad8abe87ebe199f7e97ccd80ccca6892d) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns deployment frame of the given team. |
| [IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html) | [GetFormationPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a89722c6554823d956e2ac4e8033428e2) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) fClass, bool isReinforcement=false) |
|  | Returns the formation plan matching the given formation class and which belongs to the given team. |
| float | [GetSpawnPathOffset](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a8acb861b11280f0a680729b409dca8b2) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns spawn path offset for the given team and plan type. This is only valid for plans which do use a spawn path. |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetZoomFocusFrame](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a66ced365450255006e8d86ede8076bca) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns zoom focus frame for the camera depending on where the deployment frames are located for formations. |
| float | [GetZoomOffset](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a1f73dfde698cfd2ba9248bae177c0513) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, float fovAngle) |
|  | Returns zoom offset for the camera depending on how large the deployment area or unit count is Also takes field of view angle (in radians) into account when determining zoom offset. |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a1451afadddd81f21c6b1f6b50b5ad128)Initialize()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionDeploymentPlan.Initialize | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac52a3fe4c208ae2077de557cba229e13), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a3fc667cf74b13cdf3ad40cee118a71c8).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae663b14a405c95ee0ece79d408bf189a)ClearAll()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionDeploymentPlan.ClearAll | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ad3080573357c545a6e384bd94e93fdda), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#acd24eb707d299dc337d4521069a23fa0).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a7762a7fffa885519a4189beffd254775)MakeDefaultDeploymentPlans()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionDeploymentPlan.MakeDefaultDeploymentPlans | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a28b50b5819190a6366b6907bed217e29), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a325bee40fe020d897cb000b8b4dfacda).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a5f04e04901618a0e6049fa88e01bc0d3)MakeDeploymentPlan()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionDeploymentPlan.MakeDeploymentPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | float | *spawnPathOffset* = 0, |
|  |  | float | *targetOffset* = 0f ) |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a9e0a28fa9131754a6b09d872c66e36d1), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a5a4d7120099dbb02b402b0e7946a7b82).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a5a397084cfe61349e86f9a8b320975d0)RemakeDeploymentPlan()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionDeploymentPlan.RemakeDeploymentPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a2748aeb30316228e5cafdc2c4ca8c068), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a8585ee329435de403da3ca78196f4b7c).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#aafbab48a0ded868281dbde98fd02abe5)ClearDeploymentPlan()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionDeploymentPlan.ClearDeploymentPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#af7b15fe948e2301b885ff1be53a0231e), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a2037eaa729778e47e67d1e3e1a4ab0c2).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ac2d5841ae4d2528a32dcbb1e17ae701f)IsPlanMade() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionDeploymentPlan.IsPlanMade | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a26b19d2680b4d1fe4976c948d5e0e143), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a4553e03c5c6da0f3266b3fa62825a1b9).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#af606a0b88e10c37c9c53bf213b8d1516)IsPlanMade() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionDeploymentPlan.IsPlanMade | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | out bool | *isFirstPlan* ) |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a6e801b25898a426859102d05bc833ef8), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a06dab921bebe3222d50fd8c054b6ad1a).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae8cf002ac02e898508640716a1dcc574)IsPositionInsideDeploymentBoundaries()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionDeploymentPlan.IsPositionInsideDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* ) |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a5ac48f66b57a33c1134a40ec27f3d402), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a37452100dc51dcd368d639d07aa39a9b).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#aa3f31326980a6d0b40bb16675fc3dbc8)HasDeploymentBoundaries()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionDeploymentPlan.HasDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a8c9ecdee393702a31ecb92eea607e37f), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a074841800faf3151a9f5b38d5276b631).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae83569634dd1162cfa156ab2a00c7745)GetDeploymentBoundaries()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBReadOnlyList<(string id, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points)> TaleWorlds.MountAndBlade.IMissionDeploymentPlan.GetDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac304f481f420df5b00179a8ee1362821), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a8ce19818130ac06d871dbc11cfa05e71).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a96ffeb0911939e55090b3f8b318db7ce)SupportsReinforcements()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionDeploymentPlan.SupportsReinforcements | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a82c50739296f0851ec252bb4ca50a96f), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#aeb0f262a0329d237c4b965e37562dc9f).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#af909348519e7c4ed33ef26b054835abf)SupportsNavmesh()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionDeploymentPlan.SupportsNavmesh | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a904382f75719bc1b0d35944f21087f3e), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#aa95136a5d576efa3e6a5a7aeab43127d).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a991108d1f3482b30c53327999c9636e1)HasPlayerSpawnFrame()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionDeploymentPlan.HasPlayerSpawnFrame | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a54292336179d89b35e99d2e48302a5ec), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a6e6df0c4db444cf4c7b1b8b62a28fd5f).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ac5fc005ee8f8960b1f2693267ba51845)GetPlayerSpawnFrame()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionDeploymentPlan.GetPlayerSpawnFrame | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, |
|  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* ) |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a9268cd001de15056e0dfac60c5d17dc3), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a732ed706aeaef91bd19bc60b0c82f807).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a2c5d366238cc3dd17f0b8c0f29e2e7cf)GetClosestDeploymentBoundaryPosition()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.IMissionDeploymentPlan.GetClosestDeploymentBoundaryPosition | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* ) |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#aaba1025609aa2b4d2eba73a58c9fdeea), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#ab0197b5f8f58b829df55e4f793179d04).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a7c27be32e56c4825a226d03932a58a03)ProjectPositionToDeploymentBoundaries()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IMissionDeploymentPlan.ProjectPositionToDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position* ) |

Parameters
:   |  |  |
    | --- | --- |
    | team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) owning the boundary |
    | position | Inout parameter which is set to the boundary intersection if its not already within the boundary |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ae9a8885c21ae259826ea823a6627baad), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a46e6a2f39ec213104b60590438f51a93).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a625757c9a4393fb9cca0e249073f81f4)GetPathDeploymentBoundaryIntersection()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IMissionDeploymentPlan.GetPathDeploymentBoundaryIntersection | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *startPosition*, |
|  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *endPosition*, |
|  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *intersection* ) |

Start position must be within deployment boundaries. Both start and end positions must also be valid on navmesh. If the path exists entirely within deployment boundaries, method returns true and intersection will be set to endPosition

Parameters
:   |  |  |
    | --- | --- |
    | team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) for which the deployment plan is made |
    | startPosition | Start world position of the path |
    | endPosition | End world position of the path |
    | intersection | Found intersection world position |

Returns
:   true if the intersection exists, false otherwise

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac9867c602d64870ceee16b09dca57ca0), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#ab71fbee1853651209f8c14366715534a).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ad8abe87ebe199f7e97ccd80ccca6892d)GetDeploymentFrame()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.IMissionDeploymentPlan.GetDeploymentFrame | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a79179f24859327277a3f775e2f0846ac), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#aa37d268c8721ce51cdaf4e5e43bcbade).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a89722c6554823d956e2ac4e8033428e2)GetFormationPlan()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html) TaleWorlds.MountAndBlade.IMissionDeploymentPlan.GetFormationPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *fClass*, |
|  |  | bool | *isReinforcement* = false ) |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a7759e3d7f266cbabae59c97d2c4dd522), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#acb79bfa9cfc4483662472ae0dc76fbe8).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a8acb861b11280f0a680729b409dca8b2)GetSpawnPathOffset()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IMissionDeploymentPlan.GetSpawnPathOffset | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a87bff6daea6c097d6b38a9473e08e50c), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#ae335a2ec9ad3fca37b2671d3f1cb95c2).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a66ced365450255006e8d86ede8076bca)GetZoomFocusFrame()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.IMissionDeploymentPlan.GetZoomFocusFrame | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#aa1a47161a458a37a8a754a9ac1993201), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a30280473bbf9ea9c1c150ed7a177d48f).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a1f73dfde698cfd2ba9248bae177c0513)GetZoomOffset()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.IMissionDeploymentPlan.GetZoomOffset | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | float | *fovAngle* ) |

Implemented in [TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a1921207afe7493d1a3bfbcd99d0290d5), and [TaleWorlds.MountAndBlade.MissionDeploymentPlanningLogic](class_tale_worlds_1_1_mount_and_blade_1_1_mission_deployment_planning_logic.html#a31eca9deaabe34b67d36dcc8458a827b).

