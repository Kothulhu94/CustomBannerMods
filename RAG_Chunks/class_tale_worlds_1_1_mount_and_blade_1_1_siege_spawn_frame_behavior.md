--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html ---

TaleWorlds.MountAndBlade.SiegeSpawnFrameBehavior Class ReferenceInherits [TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a34eb84c3470c023552e72b3f8dcc395e) () |
| override [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetSpawnFrame](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a56375e730d5fb8ac6c035fb84473c982) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool hasMount, bool isInitialSpawn) |
| void | [OnFlagDeactivated](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a15b3bec2120169150997cebdd97919a7) ([FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html) flag) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html) | |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetSpawnFrame](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#ae3f9ee7dc9a57fb215a0b421d06d59e9) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) team, bool hasMount, bool isInitialSpawn) |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a77c50c4fdf2705113db5754b1a50a0b3) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [SpawnZoneTagAffix](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a4aa5ccaa7dcbf91f0d3efea5033be951) = "sp\_zone\_" |
| const string | [SpawnZoneEnableTagAffix](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a0e46a90d2e3a944af5a593854c6f3ee8) = "enable\_" |
| const string | [SpawnZoneDisableTagAffix](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a306ff9d9f1c2bc7e1efff81649257b03) = "disable\_" |
| const int | [StartingActiveSpawnZoneIndex](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#ac61209c4f381d3af131894216653f25d) = 0 |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a34eb84c3470c023552e72b3f8dcc395e)Initialize()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.SiegeSpawnFrameBehavior.Initialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SpawnFrameBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawn_frame_behavior_base.html#a1d44aa35418343728c7e8d3eb25d9825).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a56375e730d5fb8ac6c035fb84473c982)GetSpawnFrame()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.SiegeSpawnFrameBehavior.GetSpawnFrame | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *team*, |
|  |  | bool | *hasMount*, |
|  |  | bool | *isInitialSpawn* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a15b3bec2120169150997cebdd97919a7)OnFlagDeactivated()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SiegeSpawnFrameBehavior.OnFlagDeactivated | ( | [FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html) | *flag* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a4aa5ccaa7dcbf91f0d3efea5033be951)SpawnZoneTagAffix
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.SiegeSpawnFrameBehavior.SpawnZoneTagAffix = "sp\_zone\_" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a0e46a90d2e3a944af5a593854c6f3ee8)SpawnZoneEnableTagAffix
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.SiegeSpawnFrameBehavior.SpawnZoneEnableTagAffix = "enable\_" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#a306ff9d9f1c2bc7e1efff81649257b03)SpawnZoneDisableTagAffix
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.SiegeSpawnFrameBehavior.SpawnZoneDisableTagAffix = "disable\_" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawn_frame_behavior.html#ac61209c4f381d3af131894216653f25d)StartingActiveSpawnZoneIndex
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.SiegeSpawnFrameBehavior.StartingActiveSpawnZoneIndex = 0 | | static |

