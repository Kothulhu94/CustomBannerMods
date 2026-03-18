--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html ---

TaleWorlds.MountAndBlade.ArcherPosition Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [GetLastAssignedFormation](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a8ddb1645a4ec0f4cd70a1c99d9078d90) (int teamIndex) |
|  | [ArcherPosition](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a8436a56c7112200aed61ddd689fa7324) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) \_entity, [SiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html) siegeQuerySystem, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| bool | [IsArcherPositionRelatedToSide](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a3b3ae748edd65921c0d621625298bdf9) ([FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) side) |
| [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | [GetArcherPositionClosestSide](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a1c65e7a4fa295706151530ddd57132f5) () |
| void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a7065309c6c87e44dec2a7e3bc48c52b0) ([SiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html) siegeQuerySystem, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| void | [SetLastAssignedFormation](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a7485fb92b18263befb76947a8c3c5807) (int teamIndex, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |

|  |  |
| --- | --- |
| Properties | |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [Entity](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#ab7828ab7d577cc08287ef67f2245243a) `[get]` |
| [TacticalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_position.html) | [TacticalArcherPosition](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a31d4f4ac6e3f61866d11c5a2c3e18d06) `[get]` |
| int | [ConnectedSides](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#ae0629c4556d214145298e84ebda87790) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a8436a56c7112200aed61ddd689fa7324)ArcherPosition()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ArcherPosition.ArcherPosition | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *\_entity*, |
|  |  | [SiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html) | *siegeQuerySystem*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a8ddb1645a4ec0f4cd70a1c99d9078d90)GetLastAssignedFormation()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.ArcherPosition.GetLastAssignedFormation | ( | int | *teamIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a3b3ae748edd65921c0d621625298bdf9)IsArcherPositionRelatedToSide()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ArcherPosition.IsArcherPositionRelatedToSide | ( | [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a1c65e7a4fa295706151530ddd57132f5)GetArcherPositionClosestSide()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [FormationAI.BehaviorSide](class_tale_worlds_1_1_mount_and_blade_1_1_formation_a_i.html#af0e557fbaea88404cb872c1bc2b7912b) TaleWorlds.MountAndBlade.ArcherPosition.GetArcherPositionClosestSide | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a7065309c6c87e44dec2a7e3bc48c52b0)OnDeploymentFinished()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ArcherPosition.OnDeploymentFinished | ( | [SiegeQuerySystem](class_tale_worlds_1_1_mount_and_blade_1_1_siege_query_system.html) | *siegeQuerySystem*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a7485fb92b18263befb76947a8c3c5807)SetLastAssignedFormation()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ArcherPosition.SetLastAssignedFormation | ( | int | *teamIndex*, |
|  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#ab7828ab7d577cc08287ef67f2245243a)Entity
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.MountAndBlade.ArcherPosition.Entity | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#a31d4f4ac6e3f61866d11c5a2c3e18d06)TacticalArcherPosition
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TacticalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_position.html) TaleWorlds.MountAndBlade.ArcherPosition.TacticalArcherPosition | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_archer_position.html#ae0629c4556d214145298e84ebda87790)ConnectedSides
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ArcherPosition.ConnectedSides | | get |

