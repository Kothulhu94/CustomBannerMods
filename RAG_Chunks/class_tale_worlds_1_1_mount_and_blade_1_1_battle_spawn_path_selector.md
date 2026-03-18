--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html ---

TaleWorlds.MountAndBlade.BattleSpawnPathSelector Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BattleSpawnPathSelector](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#a37054b106bd4c6c8af086504703cb1c1) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#aefbd4ee165eb806a72bb0167c68ba265) () |
| bool | [HasPath](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#acec53318a999716ecf13998155da1066) ([Path](class_tale_worlds_1_1_engine_1_1_path.html) path) |
| bool | [GetInitialPathDataOfSide](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#ac98b13fe8bbae062c9660b812fa3e70c) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, out [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) pathPathData) |
| MBReadOnlyList< [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) > | [GetReinforcementPathsDataOfSide](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#ad31844af0aec855292bb758b8a0d1530) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Path](class_tale_worlds_1_1_engine_1_1_path.html) | [FindBestInitialPath](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#a7f011487a2e8091f02e98611d2e5aa04) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, out float pivotRatio, out bool isInverted) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsInitialized](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#a230497acba9f572b3f63a16a01c71869) `[get]` |
| [Path](class_tale_worlds_1_1_engine_1_1_path.html) | [InitialPath](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#ae3c9d2b429ee27c1a0e4af9e97487860) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#a37054b106bd4c6c8af086504703cb1c1)BattleSpawnPathSelector()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.BattleSpawnPathSelector.BattleSpawnPathSelector | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#aefbd4ee165eb806a72bb0167c68ba265)Initialize()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BattleSpawnPathSelector.Initialize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#acec53318a999716ecf13998155da1066)HasPath()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.BattleSpawnPathSelector.HasPath | ( | [Path](class_tale_worlds_1_1_engine_1_1_path.html) | *path* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#ac98b13fe8bbae062c9660b812fa3e70c)GetInitialPathDataOfSide()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.BattleSpawnPathSelector.GetInitialPathDataOfSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | out [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) | *pathPathData* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#ad31844af0aec855292bb758b8a0d1530)GetReinforcementPathsDataOfSide()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBReadOnlyList< [SpawnPathData](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html) > TaleWorlds.MountAndBlade.BattleSpawnPathSelector.GetReinforcementPathsDataOfSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#a7f011487a2e8091f02e98611d2e5aa04)FindBestInitialPath()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Path](class_tale_worlds_1_1_engine_1_1_path.html) TaleWorlds.MountAndBlade.BattleSpawnPathSelector.FindBestInitialPath | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, | |  |  | out float | *pivotRatio*, | |  |  | out bool | *isInverted* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#a230497acba9f572b3f63a16a01c71869)IsInitialized
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.BattleSpawnPathSelector.IsInitialized | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_battle_spawn_path_selector.html#ae3c9d2b429ee27c1a0e4af9e97487860)InitialPath
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Path](class_tale_worlds_1_1_engine_1_1_path.html) TaleWorlds.MountAndBlade.BattleSpawnPathSelector.InitialPath | | get |

