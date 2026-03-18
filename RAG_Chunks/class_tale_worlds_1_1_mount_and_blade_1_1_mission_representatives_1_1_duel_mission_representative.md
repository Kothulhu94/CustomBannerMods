--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html ---

TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative Class ReferenceInherits [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a20fb4f4c54f67b59e314706da029c055) () |
| void | [AddRemoveMessageHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a9f2d8c6bff98aa26290cb9d54c2de43a) ([GameNetwork.NetworkMessageHandlerRegisterer.RegisterMode](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588) mode) |
| void | [OnInteraction](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a8025313c044a78eec2ec2e95d0f77bc9) () |
| void | [DuelRequested](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a68b08e92fb9d705bbbeb8a9424cfbe3d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) requesterAgent, [TroopType](namespace_tale_worlds_1_1_core.html#a5ecb53039bcaf288b346d49b66cd7f48) selectedAreaTroopType) |
| bool | [CheckHasRequestFromAndRemoveRequestIfNeeded](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a03d2b8097d9114e10e5f30d20e528fa8) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357) requestOwner) |
| void | [OnDuelPreparation](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a2a1dc054d4da5817d51ca9e75c363fb6) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357) requesterPeer, [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357) requesteePeer) |
| void | [OnObjectFocused](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a6452894cf53e666679c6f7c01db2059d) ([IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusedObject) |
| void | [OnObjectFocusLost](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#ada3e546c8131cbc4b553c552a6196f9a) () |
| override void | [OnAgentSpawned](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#ad5d2ebffd204d2bcb80b1010f59cc0f8) () |
| void | [ResetBountyAndNumberOfWins](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#ac1f0bc031ee557702e04987eb4dc4ac5) () |
| void | [OnDuelWon](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a061ea24b570382afd7b73ac6b71738c4) (float gainedScore) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | |
| void | [SetAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a12da572211c73f33384faaab23872807) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a33ebb20867a9611e7a2739baf6ac99ff) (float dt) |
| void | [UpdateGold](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a14b2495cc93c8d784f17be7a6a4e9740) (int gold) |
| Public Member Functions inherited from [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | |
| T | [GetComponent< T >](class_tale_worlds_1_1_core_1_1_peer_component.html#a10c7cee39e2ba15cdf532e4cbe947080) () |
| virtual void | [OnInitialize](class_tale_worlds_1_1_core_1_1_peer_component.html#a68180b2dc821f86d05865f69edfc1d0f) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_core_1_1_peer_component.html#a0c4362730984fd102625cb716e4632a6) () |

|  |  |
| --- | --- |
| Public Attributes | |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357), [TroopType](namespace_tale_worlds_1_1_core.html#a5ecb53039bcaf288b346d49b66cd7f48) > | [OnDuelRequestedEvent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a25eeeb61c1fca04be6e0f7a086791d77) |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357) > | [OnDuelRequestSentEvent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a832cb73f3eb92fcb47ba6abfa400c607) |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357), int > | [OnDuelPrepStartedEvent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a01766b923d38b5bf5dd84282c1134ee6) |
| Action | [OnAgentSpawnedWithoutDuelEvent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a680d788354a58e5d8fd75b4e360cb4dc) |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357), [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357), int > | [OnDuelPreparationStartedForTheFirstTimeEvent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#afb4dd1081cd713e8fcca851e8d042bd0) |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357) > | [OnDuelEndedEvent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a087a42cbbae7b2f35e6c1a75d970136b) |
| Action< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357) > | [OnDuelRoundEndedEvent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#ad44e6f05361486f7786f72c414d2b027) |
| Action< [TroopType](namespace_tale_worlds_1_1_core.html#a5ecb53039bcaf288b346d49b66cd7f48) > | [OnMyPreferredZoneChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a9937d4174752914ec1c17eb726899273) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [DuelPrepTime](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#acc86d2f11792a71f5b176fc78386304d) = 3 |

|  |  |
| --- | --- |
| Properties | |
| int | [Bounty](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#aadc781f35374b588a7e1577ecd5265d6) `[get]` |
| int | [Score](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a405f8b89a5b608a31346e4b335f2a969) `[get]` |
| int | [NumberOfWins](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a029affdb8b7601362c1d73598ba19f92) `[get]` |
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

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Types inherited from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | |
| enum | [PlayerTypes](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08e) {     [Bot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08ea1448e86d90e0feb307c2894c24e87767) ,     [Client](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08ea577d7068826de925ea2aec01dbadf5e4) ,     [Server](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08ea9aa1b03934893d7134a660af4204f2a9)   } |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | |
|  | [MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a431a5f14e923aaf06cf7edc1a928a48a) () |
| Events inherited from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html) | |
| Action | [OnGoldUpdated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a379937f55410fffb70c245ac4b4c7b73) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a20fb4f4c54f67b59e314706da029c055)Initialize()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.Initialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html#a58487504c7c2600d31ad90c63cff06df).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a9f2d8c6bff98aa26290cb9d54c2de43a)AddRemoveMessageHandlers()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.AddRemoveMessageHandlers | ( | [GameNetwork.NetworkMessageHandlerRegisterer.RegisterMode](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588) | *mode* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a8025313c044a78eec2ec2e95d0f77bc9)OnInteraction()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnInteraction | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a68b08e92fb9d705bbbeb8a9424cfbe3d)DuelRequested()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.DuelRequested | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *requesterAgent*, |
|  |  | [TroopType](namespace_tale_worlds_1_1_core.html#a5ecb53039bcaf288b346d49b66cd7f48) | *selectedAreaTroopType* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a03d2b8097d9114e10e5f30d20e528fa8)CheckHasRequestFromAndRemoveRequestIfNeeded()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.CheckHasRequestFromAndRemoveRequestIfNeeded | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357) | *requestOwner* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a2a1dc054d4da5817d51ca9e75c363fb6)OnDuelPreparation()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnDuelPreparation | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357) | *requesterPeer*, |
|  |  | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357) | *requesteePeer* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a6452894cf53e666679c6f7c01db2059d)OnObjectFocused()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnObjectFocused | ( | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusedObject* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#ada3e546c8131cbc4b553c552a6196f9a)OnObjectFocusLost()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnObjectFocusLost | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#ad5d2ebffd204d2bcb80b1010f59cc0f8)OnAgentSpawned()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnAgentSpawned | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#aa8b28acaea68337baad76ee3b29cc3e2).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#ac1f0bc031ee557702e04987eb4dc4ac5)ResetBountyAndNumberOfWins()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.ResetBountyAndNumberOfWins | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a061ea24b570382afd7b73ac6b71738c4)OnDuelWon()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnDuelWon | ( | float | *gainedScore* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#acc86d2f11792a71f5b176fc78386304d)DuelPrepTime
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.DuelPrepTime = 3 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a25eeeb61c1fca04be6e0f7a086791d77)OnDuelRequestedEvent
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357), [TroopType](namespace_tale_worlds_1_1_core.html#a5ecb53039bcaf288b346d49b66cd7f48)> TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnDuelRequestedEvent |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a832cb73f3eb92fcb47ba6abfa400c607)OnDuelRequestSentEvent
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357)> TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnDuelRequestSentEvent |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a01766b923d38b5bf5dd84282c1134ee6)OnDuelPrepStartedEvent
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357), int> TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnDuelPrepStartedEvent |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a680d788354a58e5d8fd75b4e360cb4dc)OnAgentSpawnedWithoutDuelEvent
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnAgentSpawnedWithoutDuelEvent |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#afb4dd1081cd713e8fcca851e8d042bd0)OnDuelPreparationStartedForTheFirstTimeEvent
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357), [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357), int> TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnDuelPreparationStartedForTheFirstTimeEvent |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a087a42cbbae7b2f35e6c1a75d970136b)OnDuelEndedEvent
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357)> TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnDuelEndedEvent |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#ad44e6f05361486f7786f72c414d2b027)OnDuelRoundEndedEvent
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357)> TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnDuelRoundEndedEvent |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a9937d4174752914ec1c17eb726899273)OnMyPreferredZoneChanged
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[TroopType](namespace_tale_worlds_1_1_core.html#a5ecb53039bcaf288b346d49b66cd7f48)> TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.OnMyPreferredZoneChanged |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#aadc781f35374b588a7e1577ecd5265d6)Bounty
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.Bounty | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a405f8b89a5b608a31346e4b335f2a969)Score
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.Score | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a029affdb8b7601362c1d73598ba19f92)NumberOfWins
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative.NumberOfWins | | get |

