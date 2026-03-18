--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html ---

TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase Class ReferenceabstractInherited by [TaleWorlds.MountAndBlade.FFASpawnFrameBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_f_f_a_spawn_frame_behavior.html), [TaleWorlds.MountAndBlade.FlagDominationSpawnFrameBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawn_frame_behavior.html), and [TaleWorlds.MountAndBlade.SiegeSpawnFrameBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a1d44aa35418343728c7e8d3eb25d9825) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetSpawnFrame](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#ae3f9ee7dc9a57fb215a0b421d06d59e9) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool hasMount, bool isInitialSpawn) |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a77c50c4fdf2705113db5754b1a50a0b3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |

|  |  |
| --- | --- |
| Public Attributes | |
| IEnumerable< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [SpawnPoints](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#aaf2229b5a291a3cef6d601227c8c55db) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [SpawnFrameBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a5372a2b62da290bcdd65be3725b127fc) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetSpawnFrameFromSpawnPoints](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a484d8e0913013093341ac59bf034c27f) (IList< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > spawnPointsList, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool hasMount) |

|  |  |
| --- | --- |
| Static Protected Attributes | |
| const string | [SpawnPointTag](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a9de8872c641fbab3e311d7b48302c081) = "spawnpoint" |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a5372a2b62da290bcdd65be3725b127fc)SpawnFrameBehaviorBase()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase.SpawnFrameBehaviorBase | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a1d44aa35418343728c7e8d3eb25d9825)Initialize()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase.Initialize | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.FlagDominationSpawnFrameBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawn_frame_behavior.html#af7997c5093242eb46b724da9fa993a10), and [TaleWorlds.MountAndBlade.SiegeSpawnFrameBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a34eb84c3470c023552e72b3f8dcc395e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#ae3f9ee7dc9a57fb215a0b421d06d59e9)GetSpawnFrame()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase.GetSpawnFrame | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, | |  |  | bool | *hasMount*, | |  |  | bool | *isInitialSpawn* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a484d8e0913013093341ac59bf034c27f)GetSpawnFrameFromSpawnPoints()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase.GetSpawnFrameFromSpawnPoints | ( | IList< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *spawnPointsList*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, | |  |  | bool | *hasMount* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a77c50c4fdf2705113db5754b1a50a0b3)OnAgentRemoved()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, |
|  |  | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | *agentState*, |
|  |  | [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) | *blow* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a9de8872c641fbab3e311d7b48302c081)SpawnPointTag
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase.SpawnPointTag = "spawnpoint" | | staticprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#aaf2229b5a291a3cef6d601227c8c55db)SpawnPoints
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| IEnumerable<[GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html)> TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase.SpawnPoints |

