--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html ---

TaleWorlds.MountAndBlade.BattleSideSpawnPathSelector Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BattleSideSpawnPathSelector](class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html#a21f5c86e74141275e9ee850a685d3a18) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [Path](class_tale_worlds_1_1_engine_1_1_path.html) initialPath, float initialPivotRatio, bool initialPathIsInverted) |
| bool | [HasReinforcementPath](class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html#a71229299c581dddfadf369bbab01486f) ([Path](class_tale_worlds_1_1_engine_1_1_path.html) path) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [MaxNeighborCount](class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html#a8e3fe0a0da8fa22fbb2629ea977cc005) = 2 |

|  |  |
| --- | --- |
| Properties | |
| [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) | [InitialSpawnPath](class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html#aa20a0127ca830e372cd11046b15d6bf4) `[get]` |
| MBReadOnlyList< [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) > | [ReinforcementPaths](class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html#a714f18595618aff5bb297c3d5dde2118) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html#a21f5c86e74141275e9ee850a685d3a18)BattleSideSpawnPathSelector()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.BattleSideSpawnPathSelector.BattleSideSpawnPathSelector | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | [Path](class_tale_worlds_1_1_engine_1_1_path.html) | *initialPath*, |
|  |  | float | *initialPivotRatio*, |
|  |  | bool | *initialPathIsInverted* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html#a71229299c581dddfadf369bbab01486f)HasReinforcementPath()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.BattleSideSpawnPathSelector.HasReinforcementPath | ( | [Path](class_tale_worlds_1_1_engine_1_1_path.html) | *path* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html#a8e3fe0a0da8fa22fbb2629ea977cc005)MaxNeighborCount
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.BattleSideSpawnPathSelector.MaxNeighborCount = 2 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html#aa20a0127ca830e372cd11046b15d6bf4)InitialSpawnPath
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) TaleWorlds.MountAndBlade.BattleSideSpawnPathSelector.InitialSpawnPath | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_side_spawn_path_selector.html#a714f18595618aff5bb297c3d5dde2118)ReinforcementPaths
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html)> TaleWorlds.MountAndBlade.BattleSideSpawnPathSelector.ReinforcementPaths | | get |

