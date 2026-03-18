--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html ---

TaleWorlds.MountAndBlade.MissionRepresentativeBase Class ReferenceabstractInherits [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html).

Inherited by [TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html), [TaleWorlds.MountAndBlade.MissionRepresentatives.FFAMissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_f_f_a_mission_representative.html), [TaleWorlds.MountAndBlade.MissionRepresentatives.FlagDominationMissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_flag_domination_mission_representative.html), [TaleWorlds.MountAndBlade.MissionRepresentatives.SiegeMissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html), and [TaleWorlds.MountAndBlade.MissionRepresentatives.TeamDeathmatchMissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_team_deathmatch_mission_representative.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetAgent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a12da572211c73f33384faaab23872807) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| virtual void | [OnAgentSpawned](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#aa8b28acaea68337baad76ee3b29cc3e2) () |
| virtual void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a33ebb20867a9611e7a2739baf6ac99ff) (float dt) |
| void | [UpdateGold](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a14b2495cc93c8d784f17be7a6a4e9740) (int gold) |
| Public Member Functions inherited from [TaleWorlds.Core.PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | |
| virtual void | [Initialize](class_tale_worlds_1_1_core_1_1_peer_component.html#a58487504c7c2600d31ad90c63cff06df) () |
| T | [GetComponent< T >](class_tale_worlds_1_1_core_1_1_peer_component.html#a10c7cee39e2ba15cdf532e4cbe947080) () |
| virtual void | [OnInitialize](class_tale_worlds_1_1_core_1_1_peer_component.html#a68180b2dc821f86d05865f69edfc1d0f) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_core_1_1_peer_component.html#a0c4362730984fd102625cb716e4632a6) () |

|  |  |
| --- | --- |
| Protected Types | |
| enum | [PlayerTypes](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08e) {     [Bot](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08ea1448e86d90e0feb307c2894c24e87767) ,     [Client](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08ea577d7068826de925ea2aec01dbadf5e4) ,     [Server](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08ea9aa1b03934893d7134a660af4204f2a9)   } |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a431a5f14e923aaf06cf7edc1a928a48a) () |

|  |  |
| --- | --- |
| Properties | |
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
| Events | |
| Action | [OnGoldUpdated](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a379937f55410fffb70c245ac4b4c7b73) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08e)PlayerTypes
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | enum [TaleWorlds.MountAndBlade.MissionRepresentativeBase.PlayerTypes](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08e) | | protected |

| Enumerator | |
| --- | --- |
| Bot |  |
| Client |  |
| Server |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a431a5f14e923aaf06cf7edc1a928a48a)MissionRepresentativeBase()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.MissionRepresentativeBase.MissionRepresentativeBase | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a12da572211c73f33384faaab23872807)SetAgent()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRepresentativeBase.SetAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#aa8b28acaea68337baad76ee3b29cc3e2)OnAgentSpawned()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionRepresentativeBase.OnAgentSpawned | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#ad5d2ebffd204d2bcb80b1010f59cc0f8), [TaleWorlds.MountAndBlade.MissionRepresentatives.SiegeMissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_siege_mission_representative.html#a9aab459178215edb84a2cc4773666bb4), and [TaleWorlds.MountAndBlade.MissionRepresentatives.TeamDeathmatchMissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_team_deathmatch_mission_representative.html#ad11eeba169bd07fb6ee1ae0c7bb7d1ad).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a33ebb20867a9611e7a2739baf6ac99ff)Tick()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.MissionRepresentativeBase.Tick | ( | float | *dt* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a14b2495cc93c8d784f17be7a6a4e9740)UpdateGold()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionRepresentativeBase.UpdateGold | ( | int | *gold* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a2d612e849fdd77fdc4349108a7c93feb)PlayerType
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PlayerTypes](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ad44cab5d887865f96bd911606b72a08e) TaleWorlds.MountAndBlade.MissionRepresentativeBase.PlayerType | | getprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a04af71921b475b1d139cad67327f2097)ControlledAgent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.MissionRepresentativeBase.ControlledAgent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a24399664c46c7f5e74b27d4eedf7f3b7)Gold
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionRepresentativeBase.Gold | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#ac43fe9b378efe777a42a52a5b2d6b357)MissionPeer
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MissionPeer TaleWorlds.MountAndBlade.MissionRepresentativeBase.MissionPeer | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html#a379937f55410fffb70c245ac4b4c7b73)OnGoldUpdated
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.MissionRepresentativeBase.OnGoldUpdated |

