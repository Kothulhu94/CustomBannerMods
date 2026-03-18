--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html ---

TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan Class ReferenceInherits [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultMissionDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a0ea34fc048fbac8d576096f5b58ba0aa) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac52a3fe4c208ae2077de557cba229e13) () |
|  | Initializes deployment plans from mission. Required mission data must be set. |
| void | [ClearDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#af7b15fe948e2301b885ff1be53a0231e) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Clears the deployment plan for the given team. |
| void | [ClearReinforcementPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a94352ddeba1c6e2adff0d8a6430df313) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| bool | [HasPlayerSpawnFrame](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a54292336179d89b35e99d2e48302a5ec) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
|  | Returns true if the given battle side has a pre-specified player spawn frame. |
| bool | [GetPlayerSpawnFrame](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a9268cd001de15056e0dfac60c5d17dc3) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
|  | Returns the pre-specified spawn frame for the player if the associated battle side has one defined. |
| void | [ClearAddedTroops](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a793515378f4394f4fa99e682dba29091) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool isReinforcement=false) |
| void | [ClearAll](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ad3080573357c545a6e384bd94e93fdda) () |
|  | Clears both the current deployment plan and any troops added to the plan. |
| void | [AddTroops](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a6a79595c16da90c3434c1bd0d7a2257a) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass, int footTroopCount, int mountedTroopCount=0, bool isReinforcement=false) |
| void | [SetSpawnWithHorses](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a5b9ef7f7f39171366236c89f17ea57ae) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool spawnWithHorses) |
| void | [MakeDefaultDeploymentPlans](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a28b50b5819190a6366b6907bed217e29) () |
|  | Makes default deployment plans for missions where detailed planning is not needed (i.e. alley fights, quests etc). |
| void | [MakeDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a9e0a28fa9131754a6b09d872c66e36d1) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, float spawnPathOffset=0f, float targetOffset=0f) |
|  | Plans battle deployment for the given team. |
| void | [MakeReinforcementDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a896e0b12de44a65dae3b0390052dc102) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, float spawnPathOffset=0f, float targetOffset=0f) |
| bool | [RemakeDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a2748aeb30316228e5cafdc2c4ca8c068) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Re-Plans battle deployment for the given team. An existing plan must be prepared. Returns true if plan is re-made, false otherwise. |
| bool | [IsPositionInsideDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a5ac48f66b57a33c1134a40ec27f3d402) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
|  | Returns true if the given position is within the deployment boundaries of the given team. [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) should have its deployment made and its boundaries computed. Or the method returns false. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetClosestDeploymentBoundaryPosition](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#aaba1025609aa2b4d2eba73a58c9fdeea) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
|  | Returns the closest point on the deployment boundary of a team to the given position. |
| bool | [SupportsReinforcements](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a82c50739296f0851ec252bb4ca50a96f) () |
|  | Returns true if the deployment plan supports reinforcements. |
| bool | [SupportsNavmesh](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a904382f75719bc1b0d35944f21087f3e) () |
|  | Returns true if deployment plan supports navmesh. Plans made for agent formations on land battles support this. But plans made for ships during naval battles does not as open sea battles does not have a navmesh (except certain river battles) Interface calls that make use of WorldPositions (like complex boundary intersections and position projections) will be unavailable if the plan does not support navmeshes. |
| bool | [GetPathDeploymentBoundaryIntersection](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac9867c602d64870ceee16b09dca57ca0) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) startPosition, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) endPosition, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) intersection) |
|  | Searches the intersection of the navmesh path (from start position to end position) with the deployment boundaries of the specified team Deployment plan must support navmeshes for this call to work. Caller must check this. |
| bool | [IsPositionInsideSiegeDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#aae21d16469dde1b81412a1184355bdb4) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| float | [GetSpawnPathOffset](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a87bff6daea6c097d6b38a9473e08e50c) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns spawn path offset for the given team and plan type. This is only valid for plans which do use a spawn path. |
| float | [GetTargetOffset](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#af39e7b2375896e27969ed3d859f70d16) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| int | [GetTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a2b832a50369b760514d9d0c7ae4998e7) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool isReinforcement=false) |
| [IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html) | [GetFormationPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a7759e3d7f266cbabae59c97d2c4dd522) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) fClass, bool isReinforcement) |
|  | Returns the formation plan matching the given formation class and which belongs to the given team. |
| bool | [IsPlanMade](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a26b19d2680b4d1fe4976c948d5e0e143) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns whether if a deployment plan is made for the given team. |
| bool | [IsPlanMade](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a6e801b25898a426859102d05bc833ef8) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, out bool isFirstPlan) |
|  | Returns whether if a deployment plan is made for the given team. Also outputs if the plan was the first plan that is made. |
| bool | [IsReinforcementPlanMade](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ab2229d151a40f1977acc2eedb9f29975) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| bool | [IsInitialPlanSuitableForFormations](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#accc8c6873ae8e2af3833ec09d9633947) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team,(int footTroopCount, int mountedTroopCount)[] troopDataPerFormationClass) |
| bool | [HasDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a8c9ecdee393702a31ecb92eea607e37f) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns true if the given team has its initial deployment boundaries computed. |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetDeploymentFrame](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a79179f24859327277a3f775e2f0846ac) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns deployment frame of the given team. |
| void | [ProjectPositionToDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ae9a8885c21ae259826ea823a6627baad) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) endPosition) |
|  | Projects the given position onto the deployment boundary Alters the position to deployment boundary intersection if the position is not already within the boundaries Deployment plan must support navmeshes for this call to work. Caller must check this. |
| MBReadOnlyList<(string id, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points)> | [GetDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac304f481f420df5b00179a8ee1362821) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns a list describing the deployment boundaries of the given team Each deployment boundary has a string id describing the boundary and its associated points vector. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetMeanPosition](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac5cc4e112cf661c563ebb095fede3bb2) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool isReinforcement=false) |
| void | [UpdateReinforcementPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a87911a14b53aef95af57807da879b5f1) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetZoomFocusFrame](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#aa1a47161a458a37a8a754a9ac1993201) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team) |
|  | Returns zoom focus frame for the camera depending on where the deployment frames are located for formations. |
| float | [GetZoomOffset](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a1921207afe7493d1a3bfbcd99d0290d5) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, float fovAngle) |
|  | Returns zoom offset for the camera depending on how large the deployment area or unit count is Also takes field of view angle (in radians) into account when determining zoom offset. |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [HasSignificantMountedTroops](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac8acdf7eb76df6c27b23d6d76e2f0217) (int footTroopCount, int mountedTroopCount) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a0ea34fc048fbac8d576096f5b58ba0aa)DefaultMissionDeploymentPlan()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.DefaultMissionDeploymentPlan | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac52a3fe4c208ae2077de557cba229e13)Initialize()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.Initialize | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a1451afadddd81f21c6b1f6b50b5ad128).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#af7b15fe948e2301b885ff1be53a0231e)ClearDeploymentPlan()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.ClearDeploymentPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#aafbab48a0ded868281dbde98fd02abe5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a94352ddeba1c6e2adff0d8a6430df313)ClearReinforcementPlan()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.ClearReinforcementPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a54292336179d89b35e99d2e48302a5ec)HasPlayerSpawnFrame()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.HasPlayerSpawnFrame | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a991108d1f3482b30c53327999c9636e1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a9268cd001de15056e0dfac60c5d17dc3)GetPlayerSpawnFrame()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetPlayerSpawnFrame | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, |
|  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* ) |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ac5fc005ee8f8960b1f2693267ba51845).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac8acdf7eb76df6c27b23d6d76e2f0217)HasSignificantMountedTroops()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.HasSignificantMountedTroops | ( | int | *footTroopCount*, | |  |  | int | *mountedTroopCount* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a793515378f4394f4fa99e682dba29091)ClearAddedTroops()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.ClearAddedTroops | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | bool | *isReinforcement* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ad3080573357c545a6e384bd94e93fdda)ClearAll()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.ClearAll | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae663b14a405c95ee0ece79d408bf189a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a6a79595c16da90c3434c1bd0d7a2257a)AddTroops()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.AddTroops | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass*, |
|  |  | int | *footTroopCount*, |
|  |  | int | *mountedTroopCount* = 0, |
|  |  | bool | *isReinforcement* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a5b9ef7f7f39171366236c89f17ea57ae)SetSpawnWithHorses()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.SetSpawnWithHorses | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | bool | *spawnWithHorses* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a28b50b5819190a6366b6907bed217e29)MakeDefaultDeploymentPlans()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.MakeDefaultDeploymentPlans | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a7762a7fffa885519a4189beffd254775).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a9e0a28fa9131754a6b09d872c66e36d1)MakeDeploymentPlan()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.MakeDeploymentPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | float | *spawnPathOffset* = 0f, |
|  |  | float | *targetOffset* = 0f ) |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a5f04e04901618a0e6049fa88e01bc0d3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a896e0b12de44a65dae3b0390052dc102)MakeReinforcementDeploymentPlan()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.MakeReinforcementDeploymentPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | float | *spawnPathOffset* = 0f, |
|  |  | float | *targetOffset* = 0f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a2748aeb30316228e5cafdc2c4ca8c068)RemakeDeploymentPlan()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.RemakeDeploymentPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a5a397084cfe61349e86f9a8b320975d0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a5ac48f66b57a33c1134a40ec27f3d402)IsPositionInsideDeploymentBoundaries()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.IsPositionInsideDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* ) |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae8cf002ac02e898508640716a1dcc574).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#aaba1025609aa2b4d2eba73a58c9fdeea)GetClosestDeploymentBoundaryPosition()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetClosestDeploymentBoundaryPosition | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* ) |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a2c5d366238cc3dd17f0b8c0f29e2e7cf).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a82c50739296f0851ec252bb4ca50a96f)SupportsReinforcements()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.SupportsReinforcements | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a96ffeb0911939e55090b3f8b318db7ce).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a904382f75719bc1b0d35944f21087f3e)SupportsNavmesh()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.SupportsNavmesh | ( |  | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#af909348519e7c4ed33ef26b054835abf).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac9867c602d64870ceee16b09dca57ca0)GetPathDeploymentBoundaryIntersection()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetPathDeploymentBoundaryIntersection | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
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

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a625757c9a4393fb9cca0e249073f81f4).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#aae21d16469dde1b81412a1184355bdb4)IsPositionInsideSiegeDeploymentBoundaries()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.IsPositionInsideSiegeDeploymentBoundaries | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a87bff6daea6c097d6b38a9473e08e50c)GetSpawnPathOffset()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetSpawnPathOffset | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a8acb861b11280f0a680729b409dca8b2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#af39e7b2375896e27969ed3d859f70d16)GetTargetOffset()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetTargetOffset | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a2b832a50369b760514d9d0c7ae4998e7)GetTroopCount()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetTroopCount | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | bool | *isReinforcement* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a7759e3d7f266cbabae59c97d2c4dd522)GetFormationPlan()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html) TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetFormationPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *fClass*, |
|  |  | bool | *isReinforcement* ) |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a89722c6554823d956e2ac4e8033428e2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a26b19d2680b4d1fe4976c948d5e0e143)IsPlanMade() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.IsPlanMade | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ac2d5841ae4d2528a32dcbb1e17ae701f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a6e801b25898a426859102d05bc833ef8)IsPlanMade() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.IsPlanMade | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | out bool | *isFirstPlan* ) |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#af606a0b88e10c37c9c53bf213b8d1516).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ab2229d151a40f1977acc2eedb9f29975)IsReinforcementPlanMade()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.IsReinforcementPlanMade | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#accc8c6873ae8e2af3833ec09d9633947)IsInitialPlanSuitableForFormations()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.IsInitialPlanSuitableForFormations | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | (int footTroopCount, int mountedTroopCount)[] | *troopDataPerFormationClass* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a8c9ecdee393702a31ecb92eea607e37f)HasDeploymentBoundaries()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.HasDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#aa3f31326980a6d0b40bb16675fc3dbc8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a79179f24859327277a3f775e2f0846ac)GetDeploymentFrame()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetDeploymentFrame | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ad8abe87ebe199f7e97ccd80ccca6892d).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ae9a8885c21ae259826ea823a6627baad)ProjectPositionToDeploymentBoundaries()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.ProjectPositionToDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position* ) |

Parameters
:   |  |  |
    | --- | --- |
    | team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) owning the boundary |
    | position | Inout parameter which is set to the boundary intersection if its not already within the boundary |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a7c27be32e56c4825a226d03932a58a03).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac304f481f420df5b00179a8ee1362821)GetDeploymentBoundaries()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBReadOnlyList<(string id, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points)> TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetDeploymentBoundaries | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#ae83569634dd1162cfa156ab2a00c7745).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#ac5cc4e112cf661c563ebb095fede3bb2)GetMeanPosition()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetMeanPosition | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | bool | *isReinforcement* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a87911a14b53aef95af57807da879b5f1)UpdateReinforcementPlan()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.UpdateReinforcementPlan | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#aa1a47161a458a37a8a754a9ac1993201)GetZoomFocusFrame()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetZoomFocusFrame | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team* | ) |  |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a66ced365450255006e8d86ede8076bca).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_mission_deployment_plan.html#a1921207afe7493d1a3bfbcd99d0290d5)GetZoomOffset()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.DefaultMissionDeploymentPlan.GetZoomOffset | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | float | *fovAngle* ) |

Implements [TaleWorlds.MountAndBlade.IMissionDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_deployment_plan.html#a1f73dfde698cfd2ba9248bae177c0513).

