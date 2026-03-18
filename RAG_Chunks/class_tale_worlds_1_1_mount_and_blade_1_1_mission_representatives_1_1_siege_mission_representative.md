--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html ---

TaleWorlds.MountAndBlade.MissionRepresentatives.SiegeMissionRepresentative Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnAgentSpawned](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html#a9aab459178215edb84a2cc4773666bb4) () |
| int | [GetGoldGainsFromKillDataAndUpdateFlags](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html#a62cb9393f6230228183818845f9dae42) ([MPPerkObject.MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html) killerPerkHandler, [MPPerkObject.MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html) assistingHitterPerkHandler, [MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) victimClass, bool isAssist, bool isRanged, bool isFriendly) |
| int | [GetGoldGainsFromObjectiveAssist](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html#a297b6b9f65900d2e31e4d447655ed2c8) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) objectiveMostParentEntity, float contributionRatio, bool isCompleted) |
| int | [GetGoldGainsFromAllyDeathReward](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html#a9e6e6595719b25c7b1d2e95440ff6dfa) (int baseAmount) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | |
| void | [SetAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a12da572211c73f33384faaab23872807) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a33ebb20867a9611e7a2739baf6ac99ff) (float dt) |
| void | [UpdateGold](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a14b2495cc93c8d784f17be7a6a4e9740) (int gold) |
| Public Member Functions inherited from [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | |
| virtual void | [Initialize](class_tale_worlds_1_1_core_1_1_peer_component.html#a58487504c7c2600d31ad90c63cff06df) () |
| T | [GetComponent< T >](class_tale_worlds_1_1_core_1_1_peer_component.html#a10c7cee39e2ba15cdf532e4cbe947080) () |
| virtual void | [OnInitialize](class_tale_worlds_1_1_core_1_1_peer_component.html#a68180b2dc821f86d05865f69edfc1d0f) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_core_1_1_peer_component.html#a0c4362730984fd102625cb716e4632a6) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Types inherited from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | |
| enum | [PlayerTypes](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08e) {     [Bot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08ea1448e86d90e0feb307c2894c24e87767) ,     [Client](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08ea577d7068826de925ea2aec01dbadf5e4) ,     [Server](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08ea9aa1b03934893d7134a660af4204f2a9)   } |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | |
|  | [MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a431a5f14e923aaf06cf7edc1a928a48a) () |
| Properties inherited from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | |
| [PlayerTypes](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08e) | [PlayerType](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a2d612e849fdd77fdc4349108a7c93feb) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [ControlledAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a04af71921b475b1d139cad67327f2097) `[get]` |
| int | [Gold](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a24399664c46c7f5e74b27d4eedf7f3b7) `[get]` |
| MissionPeer | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357) `[get]` |
| Properties inherited from [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | |
| [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | [Peer](class_tale_worlds_1_1_core_1_1_peer_component.html#a0b55a99e5343ad8152dda65b6772fae3) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_core_1_1_peer_component.html#a2bf947d41e1e13df87c579ebfe013feb) `[get]` |
|  | [Platform](namespace_tale_worlds_1_1_library.html#aab3fe05d1610830a919823c10105cc1c) provided (GDK, Steam, etc.) name of the peer. Used in logging. MissionPeer.DisplayedName is used to display the name in game. |
| bool | [IsMine](class_tale_worlds_1_1_core_1_1_peer_component.html#a466560d242dc24f6cf2cbe4a156de7fd) `[get]` |
| uint | [TypeId](class_tale_worlds_1_1_core_1_1_peer_component.html#a51ed4bd65c904826b7a63e6fe908a06d) `[get, set]` |
| Events inherited from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | |
| Action | [OnGoldUpdated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a379937f55410fffb70c245ac4b4c7b73) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html#a9aab459178215edb84a2cc4773666bb4)OnAgentSpawned()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionRepresentatives.SiegeMissionRepresentative.OnAgentSpawned | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#aa8b28acaea68337baad76ee3b29cc3e2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html#a62cb9393f6230228183818845f9dae42)GetGoldGainsFromKillDataAndUpdateFlags()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionRepresentatives.SiegeMissionRepresentative.GetGoldGainsFromKillDataAndUpdateFlags | ( | [MPPerkObject.MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html) | *killerPerkHandler*, |
|  |  | [MPPerkObject.MPPerkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_m_p_perk_object_1_1_m_p_perk_handler.html) | *assistingHitterPerkHandler*, |
|  |  | [MultiplayerClassDivisions.MPHeroClass](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_class_divisions_1_1_m_p_hero_class.html) | *victimClass*, |
|  |  | bool | *isAssist*, |
|  |  | bool | *isRanged*, |
|  |  | bool | *isFriendly* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html#a297b6b9f65900d2e31e4d447655ed2c8)GetGoldGainsFromObjectiveAssist()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionRepresentatives.SiegeMissionRepresentative.GetGoldGainsFromObjectiveAssist | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *objectiveMostParentEntity*, |
|  |  | float | *contributionRatio*, |
|  |  | bool | *isCompleted* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html#a9e6e6595719b25c7b1d2e95440ff6dfa)GetGoldGainsFromAllyDeathReward()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionRepresentatives.SiegeMissionRepresentative.GetGoldGainsFromAllyDeathReward | ( | int | *baseAmount* | ) |  |

