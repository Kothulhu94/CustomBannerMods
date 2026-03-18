--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html ---

TaleWorlds.MountAndBlade.IFormation Interface ReferenceInherited by [TaleWorlds.MountAndBlade.Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [GetIsLocalPositionAvailable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a0d57cf338157ec70e42d90a16bf244b0) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) localPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? nearestAvailableUnitPositionLocal) |
|  | Checks if position is a valid point in the scene. |
| bool | [BatchUnitPositions](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a89a5b24d13cf7497dd6c32d096042237) (MBArrayList< [Vec2i](struct_tale_worlds_1_1_library_1_1_vec2i.html) > orderedPositionIndices, MBArrayList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > orderedLocalPositions, MBList2D< int > availabilityTable, MBList2D< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > globalPositionTable, int fileCount, int rankCount) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetClosestUnitTo](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#ad99c7ea07351d9d20875dd417889c35a) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) localPosition, MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > unitsWithSpaces=null, float? maxDistance=null) |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | [GetClosestUnitTo](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a8b913d3530b4aae120669dd3764e09f7) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) targetUnit, MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > unitsWithSpaces=null, float? maxDistance=null) |
| void | [OnUnitAddedOrRemoved](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a2bf4dcc8786b0d2b393602be998675f5) () |
| void | [SetUnitToFollow](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#aba1d87a77662688ef6edf91c4bb85e4e) ([IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) unit, [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) toFollow, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) vector) |

|  |  |
| --- | --- |
| Properties | |
| float | [Interval](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a2b2b71d662717848550b32c0cf741a5c) `[get]` |
|  | The lateral space between units on one same line. |
| float | [Distance](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a0dfa3c2a029427e6e4f9a41c51f2b13b) `[get]` |
|  | Space between units in the direction of depth. |
| float | [UnitDiameter](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a6aea59f8c1ab59b1c318d900e889b752) `[get]` |
|  | Size of a single unit. |
| float | [MinimumInterval](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a30d83f0b04fefbb407117325be800d74) `[get]` |
| float | [MaximumInterval](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a9c1f2688ca225b37f1697dfd8d466527) `[get]` |
| float | [MinimumDistance](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a469607d9ffa21a4115ad3abad9e9d852) `[get]` |
| float | [MaximumDistance](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#ac7b1fc89b7160caed506b47ed0da20f8) `[get]` |
| int? | [OverridenUnitCount](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#ae5ff51a1ccbcbe5e076371b5b3591dd5) `[get]` |
|  | Should only used by dummy formations or when the formation is spawning for the first time. |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a0d57cf338157ec70e42d90a16bf244b0)GetIsLocalPositionAvailable()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IFormation.GetIsLocalPositionAvailable | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *localPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)? | *nearestAvailableUnitPositionLocal* ) |

Parameters
:   |  |  |
    | --- | --- |
    | localPosition |  |

Returns

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a89a5b24d13cf7497dd6c32d096042237)BatchUnitPositions()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.IFormation.BatchUnitPositions | ( | MBArrayList< [Vec2i](struct_tale_worlds_1_1_library_1_1_vec2i.html) > | *orderedPositionIndices*, |
|  |  | MBArrayList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *orderedLocalPositions*, |
|  |  | MBList2D< int > | *availabilityTable*, |
|  |  | MBList2D< [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) > | *globalPositionTable*, |
|  |  | int | *fileCount*, |
|  |  | int | *rankCount* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#ad99c7ea07351d9d20875dd417889c35a)GetClosestUnitTo() [1/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.IFormation.GetClosestUnitTo | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *localPosition*, |
|  |  | MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | *unitsWithSpaces* = null, |
|  |  | float? | *maxDistance* = null ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a8b913d3530b4aae120669dd3764e09f7)GetClosestUnitTo() [2/2]
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) TaleWorlds.MountAndBlade.IFormation.GetClosestUnitTo | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *targetUnit*, |
|  |  | MBList< [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) > | *unitsWithSpaces* = null, |
|  |  | float? | *maxDistance* = null ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a2bf4dcc8786b0d2b393602be998675f5)OnUnitAddedOrRemoved()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormation.OnUnitAddedOrRemoved | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a4bb61b5e9b0b858c638efa8dbbae1e9e).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#aba1d87a77662688ef6edf91c4bb85e4e)SetUnitToFollow()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IFormation.SetUnitToFollow | ( | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *unit*, |
|  |  | [IFormationUnit](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation_unit.html) | *toFollow*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *vector* ) |

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a2b2b71d662717848550b32c0cf741a5c)Interval
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormation.Interval | | get |

Implemented in [TaleWorlds.MountAndBlade.Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a1d5338088d09866e5de87bbadc0c3a9e).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a0dfa3c2a029427e6e4f9a41c51f2b13b)Distance
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormation.Distance | | get |

Implemented in [TaleWorlds.MountAndBlade.Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#adae80886ca11f989758b8ea6651c6d44).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a6aea59f8c1ab59b1c318d900e889b752)UnitDiameter
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormation.UnitDiameter | | get |

Implemented in [TaleWorlds.MountAndBlade.Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a883436020c9ffb9e409373a354c297ee).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a30d83f0b04fefbb407117325be800d74)MinimumInterval
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormation.MinimumInterval | | get |

Implemented in [TaleWorlds.MountAndBlade.Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ac3995945c60b4b170a9432b35d7b5c1d).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a9c1f2688ca225b37f1697dfd8d466527)MaximumInterval
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormation.MaximumInterval | | get |

Implemented in [TaleWorlds.MountAndBlade.Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad566074c163536c2ee63cd83ac052077).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#a469607d9ffa21a4115ad3abad9e9d852)MinimumDistance
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormation.MinimumDistance | | get |

Implemented in [TaleWorlds.MountAndBlade.Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ab4d2d970278d71f1f8e28dde5a2f4215).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#ac7b1fc89b7160caed506b47ed0da20f8)MaximumDistance
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IFormation.MaximumDistance | | get |

Implemented in [TaleWorlds.MountAndBlade.Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#ad316f295a867b05295d9a061c0b9645c).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_formation.html#ae5ff51a1ccbcbe5e076371b5b3591dd5)OverridenUnitCount
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int? TaleWorlds.MountAndBlade.IFormation.OverridenUnitCount | | get |

Implemented in [TaleWorlds.MountAndBlade.Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html#a6bb3901a85a3cb45b5efcdada013191e).

