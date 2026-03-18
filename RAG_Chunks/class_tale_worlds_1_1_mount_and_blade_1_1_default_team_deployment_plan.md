--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html ---

TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultTeamDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ae5a9d5ed2cdfa952c15331973997981b) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a19175511f03c2aa66e43c76057a66670) team) |
| void | [SetSpawnWithHorses](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a9a3501d5543aad37521392ef24b8ddd3) (bool value) |
| void | [MakeDeploymentPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ab720b680a8f002a18e1ca3ea9f174bb7) ([FormationSceneSpawnEntry](struct_tale_worlds_1_1_mount_and_blade_1_1_formation_scene_spawn_entry.html)[,] formationSceneSpawnEntries, bool isReinforcement=false, float spawnPathOffset=0f, float targetOffset=0f) |
| void | [UpdateReinforcementPlans](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#aea4ec97a4801df0c466d753dbe20172b) () |
| void | [ClearPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#aff07bc8edb35f89bbe3eef5b2d55effd) (bool isReinforcement=false) |
| void | [ClearAddedTroops](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a97736a38368f57c12024a757705935fe) (bool isReinforcement=false) |
| void | [AddTroops](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#aff42e48222d3debf2921d3f7eddedfe9) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationClass, int footTroopCount, int mountedTroopCount, bool isReinforcement=false) |
| bool | [IsFirstPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a615acae41f545659b963e7a9cd173204) (bool isReinforcement=false) |
| bool | [IsPlanMade](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a322c5600727136032a6500ae4539835c) (bool isReinforcement=false) |
| float | [GetSpawnPathOffset](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#af51f3f0657edee51b74eb99ae1f36392) (bool isReinforcement=false) |
| float | [GetTargetOffset](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a64bf50857cc408b54b9571ce8f475647) (bool isReinforcement=false) |
| int | [GetTroopCount](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#af38ef880467a34d950f7c230b2c5576a) (bool isReinforcement=false) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetDeploymentFrame](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a15c5efc527f2da58f8a080c05c504ee8) () |
| bool | [HasDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a618003d4dae47faf4ff1a8f82c9bd533) () |
| [IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html) | [GetFormationPlan](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a03a58fa1e51c7acda3497a0471f254c6) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) fClass, bool isReinforcement=false) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetMeanPosition](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a18ea3057efbaf9f1ec86c9fb44774f4d) (bool isReinforcement=false) |
| bool | [IsInitialPlanSuitableForFormations](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a6c4f9d17abdb3bec67bb2d41a274a4b0) (ValueTuple< int, int >[] troopDataPerFormationClass) |
| bool | [IsPositionInsideDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ac3b65d512125d4e779802e6626dc0d22) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, out(string id, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points) containingBoundaryTuple) |
|  | Checks if the given position is within deployment boundaries. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetClosestDeploymentBoundaryPosition](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ac663f080b77be3c555c42a8b30066eb3) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| bool | [GetPathDeploymentBoundaryIntersection](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ab8d7735e0b07d12d27fa7e859570c03a) (in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) startPosition, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) endPosition, out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) intersection) |
|  | Searches the intersection of the path (from start position to end position) with the deployment boundaries. |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a19175511f03c2aa66e43c76057a66670) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [DeployZoneMinimumWidth](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a637f2a413d7dc658cb786e89c54b301d) = 100f |
| const float | [DeployZoneForwardMargin](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ad02faa36db2c465a56b87f4a3015424a) = 10f |
| const float | [DeployZoneExtraWidthPerTroop](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a12cb4aa4a5c3d6a01c5555322c0a4693) = 1.5f |
| const string | [DefenderSiegeDeploymentFrameEntityTag](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a20b9eb7dfd85c5c56f91fab489d1ff7a) = "defender\_infantry" |
| const string | [AttackerSiegeDeploymentFrameEntityTag](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ad498a727e155716152cf8c7a5e81dfa3) = "attacker\_infantry" |

|  |  |
| --- | --- |
| Properties | |
| bool | [SpawnWithHorses](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ab7ee1b227bef70ac4a5ebea1231eba8e) `[get]` |
| MBReadOnlyList<(string id, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points)> | [DeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a606b0a328bfc946c9b5668f76fb17715) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ae5a9d5ed2cdfa952c15331973997981b)DefaultTeamDeploymentPlan()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.DefaultTeamDeploymentPlan | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a19175511f03c2aa66e43c76057a66670) | *team* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a9a3501d5543aad37521392ef24b8ddd3)SetSpawnWithHorses()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.SetSpawnWithHorses | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ab720b680a8f002a18e1ca3ea9f174bb7)MakeDeploymentPlan()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.MakeDeploymentPlan | ( | [FormationSceneSpawnEntry](struct_tale_worlds_1_1_mount_and_blade_1_1_formation_scene_spawn_entry.html) | *formationSceneSpawnEntries*[,], |
|  |  | bool | *isReinforcement* = false, |
|  |  | float | *spawnPathOffset* = 0f, |
|  |  | float | *targetOffset* = 0f ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#aea4ec97a4801df0c466d753dbe20172b)UpdateReinforcementPlans()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.UpdateReinforcementPlans | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#aff07bc8edb35f89bbe3eef5b2d55effd)ClearPlan()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.ClearPlan | ( | bool | *isReinforcement* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a97736a38368f57c12024a757705935fe)ClearAddedTroops()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.ClearAddedTroops | ( | bool | *isReinforcement* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#aff42e48222d3debf2921d3f7eddedfe9)AddTroops()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.AddTroops | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationClass*, |
|  |  | int | *footTroopCount*, |
|  |  | int | *mountedTroopCount*, |
|  |  | bool | *isReinforcement* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a615acae41f545659b963e7a9cd173204)IsFirstPlan()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.IsFirstPlan | ( | bool | *isReinforcement* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a322c5600727136032a6500ae4539835c)IsPlanMade()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.IsPlanMade | ( | bool | *isReinforcement* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#af51f3f0657edee51b74eb99ae1f36392)GetSpawnPathOffset()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.GetSpawnPathOffset | ( | bool | *isReinforcement* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a64bf50857cc408b54b9571ce8f475647)GetTargetOffset()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.GetTargetOffset | ( | bool | *isReinforcement* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#af38ef880467a34d950f7c230b2c5576a)GetTroopCount()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.GetTroopCount | ( | bool | *isReinforcement* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a15c5efc527f2da58f8a080c05c504ee8)GetDeploymentFrame()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.GetDeploymentFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a618003d4dae47faf4ff1a8f82c9bd533)HasDeploymentBoundaries()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.HasDeploymentBoundaries | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a03a58fa1e51c7acda3497a0471f254c6)GetFormationPlan()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IFormationDeploymentPlan](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_deployment_plan.html) TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.GetFormationPlan | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *fClass*, |
|  |  | bool | *isReinforcement* = false ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a18ea3057efbaf9f1ec86c9fb44774f4d)GetMeanPosition()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.GetMeanPosition | ( | bool | *isReinforcement* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a6c4f9d17abdb3bec67bb2d41a274a4b0)IsInitialPlanSuitableForFormations()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.IsInitialPlanSuitableForFormations | ( | ValueTuple< int, int >[] | *troopDataPerFormationClass* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ac3b65d512125d4e779802e6626dc0d22)IsPositionInsideDeploymentBoundaries()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.IsPositionInsideDeploymentBoundaries | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | out(string id, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > points) | *containingBoundaryTuple* ) |

Parameters
:   |  |  |
    | --- | --- |
    | position | position to check |
    | containingBoundaryTuple | output parameter for found boundary tuple (with string id and points list) which contains the given position |

Returns
:   true if the position is inside a deployment boundary false otherwise

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ac663f080b77be3c555c42a8b30066eb3)GetClosestDeploymentBoundaryPosition()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.GetClosestDeploymentBoundaryPosition | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ab8d7735e0b07d12d27fa7e859570c03a)GetPathDeploymentBoundaryIntersection()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.GetPathDeploymentBoundaryIntersection | ( | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *startPosition*, |
|  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *endPosition*, |
|  |  | out [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *intersection* ) |

Start position must be within deployment boundaries. Both start and end positions must also be valid on navmesh. If the path exists entirely within deployment boundaries, method returns true and intersection will be set to endPosition

Parameters
:   |  |  |
    | --- | --- |
    | startPosition | Start world position of the path |
    | endPosition | End world position of the path |
    | intersection | Found intersection world position |

Returns
:   true if the intersection exists, false otherwise

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a637f2a413d7dc658cb786e89c54b301d)DeployZoneMinimumWidth
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.DeployZoneMinimumWidth = 100f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ad02faa36db2c465a56b87f4a3015424a)DeployZoneForwardMargin
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.DeployZoneForwardMargin = 10f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a12cb4aa4a5c3d6a01c5555322c0a4693)DeployZoneExtraWidthPerTroop
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.DeployZoneExtraWidthPerTroop = 1.5f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a20b9eb7dfd85c5c56f91fab489d1ff7a)DefenderSiegeDeploymentFrameEntityTag
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.DefenderSiegeDeploymentFrameEntityTag = "defender\_infantry" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ad498a727e155716152cf8c7a5e81dfa3)AttackerSiegeDeploymentFrameEntityTag
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.AttackerSiegeDeploymentFrameEntityTag = "attacker\_infantry" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a19175511f03c2aa66e43c76057a66670)Team
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Team TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.Team |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#ab7ee1b227bef70ac4a5ebea1231eba8e)SpawnWithHorses
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.SpawnWithHorses | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_default_team_deployment_plan.html#a606b0a328bfc946c9b5668f76fb17715)DeploymentBoundaries
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<(string id, MBList<[Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)> points)> TaleWorlds.MountAndBlade.DefaultTeamDeploymentPlan.DeploymentBoundaries | | get |

