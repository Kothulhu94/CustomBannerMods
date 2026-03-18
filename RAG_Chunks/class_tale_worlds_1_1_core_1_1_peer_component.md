--- SOURCE: class_tale_worlds_1_1_core_1_1_peer_component.html ---

TaleWorlds.Core.PeerComponent Class ReferenceabstractInherits [TaleWorlds.Core.IEntityComponent](interface_tale_worlds_1_1_core_1_1_i_entity_component.html).

Inherited by [TaleWorlds.MountAndBlade.MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html), and [TaleWorlds.MountAndBlade.MissionRepresentativeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representative_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [Initialize](class_tale_worlds_1_1_core_1_1_peer_component.html#a58487504c7c2600d31ad90c63cff06df) () |
| T | [GetComponent< T >](class_tale_worlds_1_1_core_1_1_peer_component.html#a10c7cee39e2ba15cdf532e4cbe947080) () |
| virtual void | [OnInitialize](class_tale_worlds_1_1_core_1_1_peer_component.html#a68180b2dc821f86d05865f69edfc1d0f) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_core_1_1_peer_component.html#a0c4362730984fd102625cb716e4632a6) () |

|  |  |
| --- | --- |
| Properties | |
| [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | [Peer](class_tale_worlds_1_1_core_1_1_peer_component.html#a0b55a99e5343ad8152dda65b6772fae3) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_core_1_1_peer_component.html#a2bf947d41e1e13df87c579ebfe013feb) `[get]` |
|  | [Platform](namespace_tale_worlds_1_1_library.html#aab3fe05d1610830a919823c10105cc1c) provided (GDK, Steam, etc.) name of the peer. Used in logging. MissionPeer.DisplayedName is used to display the name in game. |
| bool | [IsMine](class_tale_worlds_1_1_core_1_1_peer_component.html#a466560d242dc24f6cf2cbe4a156de7fd) `[get]` |
| uint | [TypeId](class_tale_worlds_1_1_core_1_1_peer_component.html#a51ed4bd65c904826b7a63e6fe908a06d) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_peer_component.html#a58487504c7c2600d31ad90c63cff06df)Initialize()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.PeerComponent.Initialize | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.MissionRepresentatives.DuelMissionRepresentative](class_tale_worlds_1_1_mount_and_blade_1_1_mission_representatives_1_1_duel_mission_representative.html#a20fb4f4c54f67b59e314706da029c055).

[◆](class_tale_worlds_1_1_core_1_1_peer_component.html#a10c7cee39e2ba15cdf532e4cbe947080)GetComponent< T >()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T TaleWorlds.Core.PeerComponent.GetComponent< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_peer_component.html#a68180b2dc821f86d05865f69edfc1d0f)OnInitialize()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.PeerComponent.OnInitialize | ( |  | ) |  | | virtual |

Implements [TaleWorlds.Core.IEntityComponent](interface_tale_worlds_1_1_core_1_1_i_entity_component.html#a3c72fe2025800ba4f834ad3e80400e02).

Reimplemented in [TaleWorlds.MountAndBlade.MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#a3980706690e7c9722d833d71171a1fe4).

[◆](class_tale_worlds_1_1_core_1_1_peer_component.html#a0c4362730984fd102625cb716e4632a6)OnFinalize()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Core.PeerComponent.OnFinalize | ( |  | ) |  | | virtual |

Implements [TaleWorlds.Core.IEntityComponent](interface_tale_worlds_1_1_core_1_1_i_entity_component.html#a549cc1f41ba91a20fe0e471be9da1e6e).

Reimplemented in [TaleWorlds.MountAndBlade.MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html#ab8b3a0f90175768ea884543db49f71a3).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_peer_component.html#a0b55a99e5343ad8152dda65b6772fae3)Peer
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) TaleWorlds.Core.PeerComponent.Peer | | getset |

[◆](class_tale_worlds_1_1_core_1_1_peer_component.html#a2bf947d41e1e13df87c579ebfe013feb)Name
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.PeerComponent.Name | | get |

[◆](class_tale_worlds_1_1_core_1_1_peer_component.html#a466560d242dc24f6cf2cbe4a156de7fd)IsMine
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.PeerComponent.IsMine | | get |

[◆](class_tale_worlds_1_1_core_1_1_peer_component.html#a51ed4bd65c904826b7a63e6fe908a06d)TypeId
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Core.PeerComponent.TypeId | | getset |

