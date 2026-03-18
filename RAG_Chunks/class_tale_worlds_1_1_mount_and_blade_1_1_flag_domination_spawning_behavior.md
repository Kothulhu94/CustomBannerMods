--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html ---

TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior Class ReferenceInherits [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FlagDominationSpawningBehavior](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ab579628dbd994ef624cbcea8f1c22237) () |
| override void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ab03ad67eb67d911dac40e380d7edf8c8) ([SpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a940a40b3c630dd3439353811d2a1d6b0) spawnComponent) |
| override void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a58c7e39329ef374d2c3cd16e7a45c891) () |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a8f913336ef00267e23905b146c0d6e0c) (float dt) |
| override void | [RequestStartSpawnSession](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a041ef9e271415fe9bcd6960df85c3b96) () |
| override bool | [AllowEarlyAgentVisualsDespawning](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ac4d8247d8f079ecd03eeb7e868fe53ed) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) lobbyPeer) |
| override void | [OnClearScene](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ae6a8033d7d65885ff8f4923b2ee6b94e) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html) | |
| delegate void | [OnSpawningEndedEventDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac259df417458cf669813008963823f7e) () |
| bool | [AreAgentsSpawning](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad501461cdcd635e34406a1afc68425ac) () |
| void | [RequestStopSpawnSession](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ae7aade170eda5db3232165932176a5d3) () |
| void | [SetRemainingAgentsInvulnerable](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad1946b86072f89fd8b90eafec1ab0d41) () |
| virtual bool | [CanUpdateSpawnEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a200a4cae01a79d5a756e7e0ecbf308a8) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer) |
| void | [ToggleUpdatingSpawnEquipment](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2141db64cb49302e701bfb3852cfdd4a) (bool canUpdate) |
| bool | [AllowEarlyAgentVisualsDespawning](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa37f818a6d37839e3e324e0c0770c53c) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer) |
| virtual int | [GetMaximumReSpawnPeriodForPeer](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a524175a60cdc3711516c4c98a74bdbe7) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| void | [OnAgentRemoved](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a2b2bdd4957e05ca5083b387e9cd95238) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [AgentState](namespace_tale_worlds_1_1_core.html#a799bcc77ddb6372c7383f3340ed4d1c0) agentState, [KillingBlow](struct_tale_worlds_1_1_mount_and_blade_1_1_killing_blow.html) blow) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [SpawnAgents](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ac1b3e6317193666017650934d023f826) () |
| override bool | [IsRoundInProgress](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#abd7714940036695768245d84b5adb15c) () |
| void | [SpawnBotInBotFormation](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a46be7f43ef218b473e7ec6fb56b967b5) (int visualsIndex, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) agentTeam, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) cultureLimit, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| void | [SpawnBotVisualsInPlayerFormation](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a0e0a5ff81206eeaac81c1d1f22f42da7) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) missionPeer, int visualsIndex, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) agentTeam, [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) cultureLimit, string troopName, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation, bool updateExistingAgentVisuals, int totalCount, IEnumerable<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> alternativeEquipments) |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ab579628dbd994ef624cbcea8f1c22237)FlagDominationSpawningBehavior()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.FlagDominationSpawningBehavior | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ab03ad67eb67d911dac40e380d7edf8c8)Initialize()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.Initialize | ( | [SpawnComponent](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#a940a40b3c630dd3439353811d2a1d6b0) | *spawnComponent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ad3cb192971e84915169c2221bfdcbe8e).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a58c7e39329ef374d2c3cd16e7a45c891)Clear()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.Clear | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aed6f63a0ee8388dcae7b59bea8e16187).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a8f913336ef00267e23905b146c0d6e0c)OnTick()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.OnTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#ac4fb83023786413c9ff7d15f7d140a30).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a041ef9e271415fe9bcd6960df85c3b96)RequestStartSpawnSession()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.RequestStartSpawnSession | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aa27778bb7816e029916b40cd03bdd34b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ac1b3e6317193666017650934d023f826)SpawnAgents()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.SpawnAgents | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ac4d8247d8f079ecd03eeb7e868fe53ed)AllowEarlyAgentVisualsDespawning()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.AllowEarlyAgentVisualsDespawning | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *lobbyPeer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#abd7714940036695768245d84b5adb15c)IsRoundInProgress()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.IsRoundInProgress | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#ae6a8033d7d65885ff8f4923b2ee6b94e)OnClearScene()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.OnClearScene | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.SpawningBehaviorBase](class_tale_worlds_1_1_mount_and_blade_1_1_spawning_behavior_base.html#aee5981c3b4cbbb4ff9a4a141761735b7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a46be7f43ef218b473e7ec6fb56b967b5)SpawnBotInBotFormation()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.SpawnBotInBotFormation | ( | int | *visualsIndex*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *agentTeam*, | |  |  | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *cultureLimit*, | |  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, | |  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_flag_domination_spawning_behavior.html#a0e0a5ff81206eeaac81c1d1f22f42da7)SpawnBotVisualsInPlayerFormation()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.FlagDominationSpawningBehavior.SpawnBotVisualsInPlayerFormation | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *missionPeer*, | |  |  | int | *visualsIndex*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *agentTeam*, | |  |  | [BasicCultureObject](class_tale_worlds_1_1_core_1_1_basic_culture_object.html) | *cultureLimit*, | |  |  | string | *troopName*, | |  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation*, | |  |  | bool | *updateExistingAgentVisuals*, | |  |  | int | *totalCount*, | |  |  | IEnumerable<([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html))> | *alternativeEquipments* ) | | protected |

