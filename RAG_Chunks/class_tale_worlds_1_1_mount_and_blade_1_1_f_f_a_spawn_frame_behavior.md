--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_f_f_a_spawn_frame_behavior.html ---

TaleWorlds.MountAndBlade.FFASpawnFrameBehavior Class ReferenceInherits [TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetSpawnFrame](class_tale_worlds_1_1_mount_and_blade_1_1_f_f_a_spawn_frame_behavior.html#a0f8183ed1bdff780070470e3a4e05fe8) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool hasMount, bool isInitialSpawn) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html) | |
| virtual void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a1d44aa35418343728c7e8d3eb25d9825) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetSpawnFrame](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#ae3f9ee7dc9a57fb215a0b421d06d59e9) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool hasMount, bool isInitialSpawn) |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a77c50c4fdf2705113db5754b1a50a0b3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html) | |
| IEnumerable< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [SpawnPoints](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#aaf2229b5a291a3cef6d601227c8c55db) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html) | |
|  | [SpawnFrameBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a5372a2b62da290bcdd65be3725b127fc) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetSpawnFrameFromSpawnPoints](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a484d8e0913013093341ac59bf034c27f) (IList< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > spawnPointsList, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool hasMount) |
| Static Protected Attributes inherited from [TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html) | |
| const string | [SpawnPointTag](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a9de8872c641fbab3e311d7b48302c081) = "spawnpoint" |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_f_f_a_spawn_frame_behavior.html#a0f8183ed1bdff780070470e3a4e05fe8)GetSpawnFrame()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.FFASpawnFrameBehavior.GetSpawnFrame | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | bool | *hasMount*, |
|  |  | bool | *isInitialSpawn* ) |

