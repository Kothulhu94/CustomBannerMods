--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html ---

TaleWorlds.MountAndBlade.WarmupSpawningBehavior Class ReferenceInherits [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WarmupSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a7ec5384d20389168d95534c346699a3a) () |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a27fe818f92d0e1cac9cb9d83fd23c1b0) (float dt) |
| override bool | [AllowEarlyAgentVisualsDespawning](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#ae58f67a7b83a679716e7a49b13896109) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) lobbyPeer) |
| override int | [GetMaximumReSpawnPeriodForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#add45bd38c00fc155bdbf1b5b496ae2f8) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| override void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a7f89ae00663c3ddb1f54e276fa81ccca) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html) | |
| delegate void | [OnSpawningEndedEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac259df417458cf669813008963823f7e) () |
| virtual void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad3cb192971e84915169c2221bfdcbe8e) ([SpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a940a40b3c630dd3439353811d2a1d6b0) spawnComponent) |
| bool | [AreAgentsSpawning](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad501461cdcd635e34406a1afc68425ac) () |
| virtual void | [RequestStartSpawnSession](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa27778bb7816e029916b40cd03bdd34b) () |
| void | [RequestStopSpawnSession](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ae7aade170eda5db3232165932176a5d3) () |
| void | [SetRemainingAgentsInvulnerable](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad1946b86072f89fd8b90eafec1ab0d41) () |
| virtual bool | [CanUpdateSpawnEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a200a4cae01a79d5a756e7e0ecbf308a8) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer) |
| void | [ToggleUpdatingSpawnEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2141db64cb49302e701bfb3852cfdd4a) (bool canUpdate) |
| bool | [AllowEarlyAgentVisualsDespawning](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa37f818a6d37839e3e324e0c0770c53c) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer) |
| virtual void | [OnClearScene](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aee5981c3b4cbbb4ff9a4a141761735b7) () |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2b2bdd4957e05ca5083b387e9cd95238) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [SpawnAgents](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a693d73630ae4a5c9b498ccb96679b910) () |
| override bool | [IsRoundInProgress](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a53a9f189d16d10d748e85b28676f069c) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html) | |
| void | [ResetSpawnCounts](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aaf3a5f9a3ffc44f8b27b194cfb450695) () |
| void | [ResetSpawnTimers](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a6640198319129c85a3205e73b0bf922e) () |
| void | [SpawnAgents](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a752f5405257658342177818060abbc07) () |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad6ff6a4d802bd95e195734ee41e76c9a) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) cultureLimit) |
| void | [SpawnBot](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a6d36fa69db971302d676165ed3a2067b) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) agentTeam, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) cultureLimit) |
| bool | [IsRoundInProgress](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa2461bb1f51e8137a60fe713c3d1b225) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html) | |
| [MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html) | [GameMode](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a3f395fa3ece134778dbf30208ae20dc9) |
| SpawnComponent | [SpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a940a40b3c630dd3439353811d2a1d6b0) |
| bool | [IsSpawningEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a4e8015e616ff5ae5f8631bc93cacfafc) |
| [Timer](class_tale_worlds_1_1_core_1_1_timer.html) | [SpawnCheckTimer](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a475ec4df6522546080389183232cc1ca) |
| float | [SpawningEndDelay](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2a49b23af747a16e157c0fda6cf367b8) = 1.0f |
| float | [SpawningDelayTimer](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a9423d0074dcb832fa0aace6d776dd4fd) |
| MissionLobbyComponent | [MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a7d179264e7b35fab8b50346a5be52155) |
| MissionLobbyEquipmentNetworkComponent | [MissionLobbyEquipmentNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a54e2ef37127a5484c4ff081cc6f4cf7b) |
| Properties inherited from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html) | |
| [MultiplayerMissionAgentVisualSpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_mission_agent_visual_spawn_component.html) | [AgentVisualSpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a15b82de4c33484c6f30dbd0eed9d4d0f) `[get]` |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a1576be9bccb53df758702803f41c05d3) `[get]` |
| Events inherited from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html) | |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) > | [OnAllAgentsFromPeerSpawnedFromVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a0b712ebac9f5f03071cefa87f1522165) |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) > | [OnPeerSpawnedFromVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a02b4704568a45fb09d9cd4a2203f61cd) |
| [OnSpawningEndedEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac259df417458cf669813008963823f7e) | [OnSpawningEnded](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa5dae2c7cd83be846fb1e1c75d69c6c4) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a7ec5384d20389168d95534c346699a3a)WarmupSpawningBehavior()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.WarmupSpawningBehavior.WarmupSpawningBehavior | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a27fe818f92d0e1cac9cb9d83fd23c1b0)OnTick()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.WarmupSpawningBehavior.OnTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac4fb83023786413c9ff7d15f7d140a30).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a693d73630ae4a5c9b498ccb96679b910)SpawnAgents()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.WarmupSpawningBehavior.SpawnAgents | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#ae58f67a7b83a679716e7a49b13896109)AllowEarlyAgentVisualsDespawning()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.WarmupSpawningBehavior.AllowEarlyAgentVisualsDespawning | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *lobbyPeer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#add45bd38c00fc155bdbf1b5b496ae2f8)GetMaximumReSpawnPeriodForPeer()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override int TaleWorlds.MountAndBlade.WarmupSpawningBehavior.GetMaximumReSpawnPeriodForPeer | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a524175a60cdc3711516c4c98a74bdbe7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a53a9f189d16d10d748e85b28676f069c)IsRoundInProgress()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.WarmupSpawningBehavior.IsRoundInProgress | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a7f89ae00663c3ddb1f54e276fa81ccca)Clear()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.WarmupSpawningBehavior.Clear | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aed6f63a0ee8388dcae7b59bea8e16187).

