--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html ---

TaleWorlds.MountAndBlade.SpawningBehaviorBase Class ReferenceabstractInherited by [TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html), [TaleWorlds.MountAndBlade.SiegeSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawning_behavior.html), and [TaleWorlds.MountAndBlade.WarmupSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnSpawningEndedEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac259df417458cf669813008963823f7e) () |
| virtual void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad3cb192971e84915169c2221bfdcbe8e) ([SpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a940a40b3c630dd3439353811d2a1d6b0) spawnComponent) |
| virtual void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aed6f63a0ee8388dcae7b59bea8e16187) () |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac4fb83023786413c9ff7d15f7d140a30) (float dt) |
| bool | [AreAgentsSpawning](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad501461cdcd635e34406a1afc68425ac) () |
| virtual void | [RequestStartSpawnSession](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa27778bb7816e029916b40cd03bdd34b) () |
| void | [RequestStopSpawnSession](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ae7aade170eda5db3232165932176a5d3) () |
| void | [SetRemainingAgentsInvulnerable](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad1946b86072f89fd8b90eafec1ab0d41) () |
| virtual bool | [CanUpdateSpawnEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a200a4cae01a79d5a756e7e0ecbf308a8) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer) |
| void | [ToggleUpdatingSpawnEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2141db64cb49302e701bfb3852cfdd4a) (bool canUpdate) |
| bool | [AllowEarlyAgentVisualsDespawning](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa37f818a6d37839e3e324e0c0770c53c) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer) |
| virtual int | [GetMaximumReSpawnPeriodForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a524175a60cdc3711516c4c98a74bdbe7) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| virtual void | [OnClearScene](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aee5981c3b4cbbb4ff9a4a141761735b7) () |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2b2bdd4957e05ca5083b387e9cd95238) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [ResetSpawnCounts](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aaf3a5f9a3ffc44f8b27b194cfb450695) () |
| void | [ResetSpawnTimers](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a6640198319129c85a3205e73b0bf922e) () |
| void | [SpawnAgents](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a752f5405257658342177818060abbc07) () |
| [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) | [GetBodyProperties](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad6ff6a4d802bd95e195734ee41e76c9a) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) cultureLimit) |
| void | [SpawnBot](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a6d36fa69db971302d676165ed3a2067b) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) agentTeam, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) cultureLimit) |
| bool | [IsRoundInProgress](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa2461bb1f51e8137a60fe713c3d1b225) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| [MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html) | [GameMode](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a3f395fa3ece134778dbf30208ae20dc9) |
| SpawnComponent | [SpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a940a40b3c630dd3439353811d2a1d6b0) |
| bool | [IsSpawningEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a4e8015e616ff5ae5f8631bc93cacfafc) |
| [Timer](class_tale_worlds_1_1_core_1_1_timer.html) | [SpawnCheckTimer](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a475ec4df6522546080389183232cc1ca) |
| float | [SpawningEndDelay](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2a49b23af747a16e157c0fda6cf367b8) = 1.0f |
| float | [SpawningDelayTimer](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a9423d0074dcb832fa0aace6d776dd4fd) |
| MissionLobbyComponent | [MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a7d179264e7b35fab8b50346a5be52155) |
| MissionLobbyEquipmentNetworkComponent | [MissionLobbyEquipmentNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a54e2ef37127a5484c4ff081cc6f4cf7b) |

|  |  |
| --- | --- |
| Properties | |
| [MultiplayerMissionAgentVisualSpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_mission_agent_visual_spawn_component.html) | [AgentVisualSpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a15b82de4c33484c6f30dbd0eed9d4d0f) `[get]` |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a1576be9bccb53df758702803f41c05d3) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) > | [OnAllAgentsFromPeerSpawnedFromVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a0b712ebac9f5f03071cefa87f1522165) |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) > | [OnPeerSpawnedFromVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a02b4704568a45fb09d9cd4a2203f61cd) |
| [OnSpawningEndedEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac259df417458cf669813008963823f7e) | [OnSpawningEnded](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa5dae2c7cd83be846fb1e1c75d69c6c4) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac259df417458cf669813008963823f7e)OnSpawningEndedEventDelegate()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.SpawningBehaviorBase.OnSpawningEndedEventDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad3cb192971e84915169c2221bfdcbe8e)Initialize()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.SpawningBehaviorBase.Initialize | ( | [SpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a940a40b3c630dd3439353811d2a1d6b0) | *spawnComponent* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ab03ad67eb67d911dac40e380d7edf8c8), and [TaleWorlds.MountAndBlade.SiegeSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawning_behavior.html#ab4fdae96336ffee3b1d47fba138a42e6).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aed6f63a0ee8388dcae7b59bea8e16187)Clear()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.SpawningBehaviorBase.Clear | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a58c7e39329ef374d2c3cd16e7a45c891), [TaleWorlds.MountAndBlade.SiegeSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawning_behavior.html#a9fa36d497f6fb3410dba61317b7eecf3), and [TaleWorlds.MountAndBlade.WarmupSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a7f89ae00663c3ddb1f54e276fa81ccca).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac4fb83023786413c9ff7d15f7d140a30)OnTick()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.SpawningBehaviorBase.OnTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a8f913336ef00267e23905b146c0d6e0c), [TaleWorlds.MountAndBlade.SiegeSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawning_behavior.html#af56e88b0cc2e43371296cae5ac7dbad0), and [TaleWorlds.MountAndBlade.WarmupSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#a27fe818f92d0e1cac9cb9d83fd23c1b0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad501461cdcd635e34406a1afc68425ac)AreAgentsSpawning()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.SpawningBehaviorBase.AreAgentsSpawning | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aaf3a5f9a3ffc44f8b27b194cfb450695)ResetSpawnCounts()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.SpawningBehaviorBase.ResetSpawnCounts | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a6640198319129c85a3205e73b0bf922e)ResetSpawnTimers()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.SpawningBehaviorBase.ResetSpawnTimers | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa27778bb7816e029916b40cd03bdd34b)RequestStartSpawnSession()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.SpawningBehaviorBase.RequestStartSpawnSession | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a041ef9e271415fe9bcd6960df85c3b96).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ae7aade170eda5db3232165932176a5d3)RequestStopSpawnSession()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawningBehaviorBase.RequestStopSpawnSession | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad1946b86072f89fd8b90eafec1ab0d41)SetRemainingAgentsInvulnerable()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawningBehaviorBase.SetRemainingAgentsInvulnerable | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a752f5405257658342177818060abbc07)SpawnAgents()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.SpawningBehaviorBase.SpawnAgents | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad6ff6a4d802bd95e195734ee41e76c9a)GetBodyProperties()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [BodyProperties](struct_tale_worlds_1_1_core_1_1_body_properties.html) TaleWorlds.MountAndBlade.SpawningBehaviorBase.GetBodyProperties | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *missionPeer*, | |  |  | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *cultureLimit* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a6d36fa69db971302d676165ed3a2067b)SpawnBot()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.SpawningBehaviorBase.SpawnBot | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *agentTeam*, | |  |  | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *cultureLimit* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a200a4cae01a79d5a756e7e0ecbf308a8)CanUpdateSpawnEquipment()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.SpawningBehaviorBase.CanUpdateSpawnEquipment | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *missionPeer* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2141db64cb49302e701bfb3852cfdd4a)ToggleUpdatingSpawnEquipment()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawningBehaviorBase.ToggleUpdatingSpawnEquipment | ( | bool | *canUpdate* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa37f818a6d37839e3e324e0c0770c53c)AllowEarlyAgentVisualsDespawning()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.SpawningBehaviorBase.AllowEarlyAgentVisualsDespawning | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *missionPeer* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a524175a60cdc3711516c4c98a74bdbe7)GetMaximumReSpawnPeriodForPeer()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual int TaleWorlds.MountAndBlade.SpawningBehaviorBase.GetMaximumReSpawnPeriodForPeer | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.SiegeSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_siege_spawning_behavior.html#a576b0789ed9362f51c4c9c3db68281be), and [TaleWorlds.MountAndBlade.WarmupSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_warmup_spawning_behavior.html#add45bd38c00fc155bdbf1b5b496ae2f8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa2461bb1f51e8137a60fe713c3d1b225)IsRoundInProgress()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.SpawningBehaviorBase.IsRoundInProgress | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aee5981c3b4cbbb4ff9a4a141761735b7)OnClearScene()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.SpawningBehaviorBase.OnClearScene | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ae6a8033d7d65885ff8f4923b2ee6b94e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2b2bdd4957e05ca5083b387e9cd95238)OnAgentRemoved()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawningBehaviorBase.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectedAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, |
|  |  | [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) | *agentState*, |
|  |  | [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) | *blow* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a3f395fa3ece134778dbf30208ae20dc9)GameMode
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html) TaleWorlds.MountAndBlade.SpawningBehaviorBase.GameMode | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a940a40b3c630dd3439353811d2a1d6b0)SpawnComponent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SpawnComponent TaleWorlds.MountAndBlade.SpawningBehaviorBase.SpawnComponent | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a4e8015e616ff5ae5f8631bc93cacfafc)IsSpawningEnabled
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.SpawningBehaviorBase.IsSpawningEnabled | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a475ec4df6522546080389183232cc1ca)SpawnCheckTimer
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Timer](class_tale_worlds_1_1_core_1_1_timer.html) TaleWorlds.MountAndBlade.SpawningBehaviorBase.SpawnCheckTimer | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2a49b23af747a16e157c0fda6cf367b8)SpawningEndDelay
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.SpawningBehaviorBase.SpawningEndDelay = 1.0f | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a9423d0074dcb832fa0aace6d776dd4fd)SpawningDelayTimer
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.SpawningBehaviorBase.SpawningDelayTimer | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a7d179264e7b35fab8b50346a5be52155)MissionLobbyComponent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MissionLobbyComponent TaleWorlds.MountAndBlade.SpawningBehaviorBase.MissionLobbyComponent | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a54e2ef37127a5484c4ff081cc6f4cf7b)MissionLobbyEquipmentNetworkComponent
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MissionLobbyEquipmentNetworkComponent TaleWorlds.MountAndBlade.SpawningBehaviorBase.MissionLobbyEquipmentNetworkComponent | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a15b82de4c33484c6f30dbd0eed9d4d0f)AgentVisualSpawnComponent
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MultiplayerMissionAgentVisualSpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_mission_agent_visual_spawn_component.html) TaleWorlds.MountAndBlade.SpawningBehaviorBase.AgentVisualSpawnComponent | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a1576be9bccb53df758702803f41c05d3)Mission
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Mission TaleWorlds.MountAndBlade.SpawningBehaviorBase.Mission | | getprotected |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a0b712ebac9f5f03071cefa87f1522165)OnAllAgentsFromPeerSpawnedFromVisuals
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html)> TaleWorlds.MountAndBlade.SpawningBehaviorBase.OnAllAgentsFromPeerSpawnedFromVisuals | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a02b4704568a45fb09d9cd4a2203f61cd)OnPeerSpawnedFromVisuals
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html)> TaleWorlds.MountAndBlade.SpawningBehaviorBase.OnPeerSpawnedFromVisuals | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa5dae2c7cd83be846fb1e1c75d69c6c4)OnSpawningEnded
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnSpawningEndedEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac259df417458cf669813008963823f7e) TaleWorlds.MountAndBlade.SpawningBehaviorBase.OnSpawningEnded |

