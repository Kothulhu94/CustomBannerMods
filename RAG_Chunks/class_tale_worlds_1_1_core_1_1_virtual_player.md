--- SOURCE: class_tale_worlds_1_1_core_1_1_virtual_player.html ---

TaleWorlds.Core.VirtualPlayer Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html#aeabd7db9100c8aa28ddb0b7b0ea1c1aa) (int index, string name, PlayerId playerID, [ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html) communicator) |
| T | [AddComponent< T >](class_tale_worlds_1_1_core_1_1_virtual_player.html#ab70d65234d7ab2f1f5a1231764566ffb) () |
| [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | [AddComponent](class_tale_worlds_1_1_core_1_1_virtual_player.html#aa7c39e1cb47833ee19007df56b7ea3c6) (Type peerComponentType) |
| [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | [AddComponent](class_tale_worlds_1_1_core_1_1_virtual_player.html#ac2b79e40a147208fd38b666d686ceb63) (uint componentId) |
| [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | [GetComponent](class_tale_worlds_1_1_core_1_1_virtual_player.html#af362747a5747f4285d646e1a7406043f) (uint componentId) |
| T | [GetComponent< T >](class_tale_worlds_1_1_core_1_1_virtual_player.html#abf1fc61e16795ca85e7ff8b75eb77694) () |
| [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | [GetComponent](class_tale_worlds_1_1_core_1_1_virtual_player.html#a705e1037cfdac5279c7d0f2788ecfbe7) (Type peerComponentType) |
| void | [RemoveComponent< T >](class_tale_worlds_1_1_core_1_1_virtual_player.html#a303c80bc50d255c778c276ab0b8abe91) (bool synched=true) |
| void | [RemoveComponent](class_tale_worlds_1_1_core_1_1_virtual_player.html#a0c4f1de3860afe5bbb0fb028896b2808) ([PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) component) |
| void | [OnDisconnect](class_tale_worlds_1_1_core_1_1_virtual_player.html#a93eb8ea1ee75b45afbd664d9580434ab) () |
| void | [SynchronizeComponentsTo](class_tale_worlds_1_1_core_1_1_virtual_player.html#a3547eb063cfc11d256bf1463762a71ff) ([VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html#aeabd7db9100c8aa28ddb0b7b0ea1c1aa) peer) |
| void | [UpdateIndexForReconnectingPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html#a13183a234b317c6405778f7586adc4d3) (int playerIndex) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static List< T > | [Peers< T >](class_tale_worlds_1_1_core_1_1_virtual_player.html#ad5c49ea4254bc01e9c6cbd0ab8e3b044) () |
| static void | [Reset](class_tale_worlds_1_1_core_1_1_virtual_player.html#a259c9f3b5e0992bddc331895f36c1ce0) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html) | [Communicator](class_tale_worlds_1_1_core_1_1_virtual_player.html#a75249af755a966211712a35de2ae431b) |
| Dictionary< int, List< int > > | [UsedCosmetics](class_tale_worlds_1_1_core_1_1_virtual_player.html#afa96e6853c27d6bb4948a6f19040a640) |

|  |  |
| --- | --- |
| Properties | |
| static Dictionary< Type, object > | [PeerComponents](class_tale_worlds_1_1_core_1_1_virtual_player.html#a4c199be7c4dad253e18f04d97e7198c3) `[get]` |
| string | [BannerCode](class_tale_worlds_1_1_core_1_1_virtual_player.html#ac5a7a457f9c63990252793a32cca480a) `[get, set]` |
| BodyProperties | [BodyProperties](class_tale_worlds_1_1_core_1_1_virtual_player.html#a978b3434cb2cbdf7089a12e8caa20a05) `[get, set]` |
| int | [Race](class_tale_worlds_1_1_core_1_1_virtual_player.html#a81de0c39ef745faf14e557e4f7b9c501) `[get, set]` |
| bool | [IsFemale](class_tale_worlds_1_1_core_1_1_virtual_player.html#ac2cbd17f575d16f122dd84c8f1298956) `[get, set]` |
| PlayerId | [Id](class_tale_worlds_1_1_core_1_1_virtual_player.html#a79d81349e7c497b849163727daff9733) `[get, set]` |
| int | [Index](class_tale_worlds_1_1_core_1_1_virtual_player.html#ab7b466a5308489a05e4a5a24737aa3e4) `[get]` |
| bool | [IsMine](class_tale_worlds_1_1_core_1_1_virtual_player.html#aad74281041a3d329ac1f8ed4ba03c2f1) `[get]` |
| string | [UserName](class_tale_worlds_1_1_core_1_1_virtual_player.html#ac8b7a21394705e5f00cf55ab5a8d8377) `[get]` |
|  | [Platform](namespace_tale_worlds_1_1_library.html#aab3fe05d1610830a919823c10105cc1c) provided (GDK, Steam, etc.) name of the peer. Used in logging. MissionPeer.DisplayedName is used to display the name in game. |
| int | [ChosenBadgeIndex](class_tale_worlds_1_1_core_1_1_virtual_player.html#a424dfac45152339d4aab5d215e965592) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#aeabd7db9100c8aa28ddb0b7b0ea1c1aa)VirtualPlayer()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.VirtualPlayer.VirtualPlayer | ( | int | *index*, |
|  |  | string | *name*, |
|  |  | PlayerId | *playerID*, |
|  |  | [ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html) | *communicator* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#ad5c49ea4254bc01e9c6cbd0ab8e3b044)Peers< T >()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List< T > TaleWorlds.Core.VirtualPlayer.Peers< T > | ( |  | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a259c9f3b5e0992bddc331895f36c1ce0)Reset()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Core.VirtualPlayer.Reset | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#ab70d65234d7ab2f1f5a1231764566ffb)AddComponent< T >()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T [TaleWorlds.Core.VirtualPlayer.AddComponent](class_tale_worlds_1_1_core_1_1_virtual_player.html#aa7c39e1cb47833ee19007df56b7ea3c6)< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#aa7c39e1cb47833ee19007df56b7ea3c6)AddComponent() [1/2]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) TaleWorlds.Core.VirtualPlayer.AddComponent | ( | Type | *peerComponentType* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#ac2b79e40a147208fd38b666d686ceb63)AddComponent() [2/2]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) TaleWorlds.Core.VirtualPlayer.AddComponent | ( | uint | *componentId* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#af362747a5747f4285d646e1a7406043f)GetComponent() [1/2]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) TaleWorlds.Core.VirtualPlayer.GetComponent | ( | uint | *componentId* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#abf1fc61e16795ca85e7ff8b75eb77694)GetComponent< T >()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| T [TaleWorlds.Core.VirtualPlayer.GetComponent](class_tale_worlds_1_1_core_1_1_virtual_player.html#af362747a5747f4285d646e1a7406043f)< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a705e1037cfdac5279c7d0f2788ecfbe7)GetComponent() [2/2]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) TaleWorlds.Core.VirtualPlayer.GetComponent | ( | Type | *peerComponentType* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a303c80bc50d255c778c276ab0b8abe91)RemoveComponent< T >()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void [TaleWorlds.Core.VirtualPlayer.RemoveComponent](class_tale_worlds_1_1_core_1_1_virtual_player.html#a0c4f1de3860afe5bbb0fb028896b2808)< T > | ( | bool | *synched* = true | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html)* |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a0c4f1de3860afe5bbb0fb028896b2808)RemoveComponent()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.VirtualPlayer.RemoveComponent | ( | [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | *component* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a93eb8ea1ee75b45afbd664d9580434ab)OnDisconnect()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.VirtualPlayer.OnDisconnect | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a3547eb063cfc11d256bf1463762a71ff)SynchronizeComponentsTo()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.VirtualPlayer.SynchronizeComponentsTo | ( | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html#aeabd7db9100c8aa28ddb0b7b0ea1c1aa) | *peer* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a13183a234b317c6405778f7586adc4d3)UpdateIndexForReconnectingPlayer()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.VirtualPlayer.UpdateIndexForReconnectingPlayer | ( | int | *playerIndex* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a75249af755a966211712a35de2ae431b)Communicator
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html) TaleWorlds.Core.VirtualPlayer.Communicator |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#afa96e6853c27d6bb4948a6f19040a640)UsedCosmetics
------------------------------------------------------------------------------------------------------

|  |
| --- |
| Dictionary<int, List<int> > TaleWorlds.Core.VirtualPlayer.UsedCosmetics |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a4c199be7c4dad253e18f04d97e7198c3)PeerComponents
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Dictionary<Type, object> TaleWorlds.Core.VirtualPlayer.PeerComponents | | staticget |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#ac5a7a457f9c63990252793a32cca480a)BannerCode
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.VirtualPlayer.BannerCode | | getset |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a978b3434cb2cbdf7089a12e8caa20a05)BodyProperties
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | BodyProperties TaleWorlds.Core.VirtualPlayer.BodyProperties | | getset |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a81de0c39ef745faf14e557e4f7b9c501)Race
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.VirtualPlayer.Race | | getset |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#ac2cbd17f575d16f122dd84c8f1298956)IsFemale
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.VirtualPlayer.IsFemale | | getset |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a79d81349e7c497b849163727daff9733)Id
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | PlayerId TaleWorlds.Core.VirtualPlayer.Id | | getset |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#ab7b466a5308489a05e4a5a24737aa3e4)Index
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.VirtualPlayer.Index | | get |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#aad74281041a3d329ac1f8ed4ba03c2f1)IsMine
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.VirtualPlayer.IsMine | | get |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#ac8b7a21394705e5f00cf55ab5a8d8377)UserName
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.VirtualPlayer.UserName | | get |

[◆](class_tale_worlds_1_1_core_1_1_virtual_player.html#a424dfac45152339d4aab5d215e965592)ChosenBadgeIndex
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.VirtualPlayer.ChosenBadgeIndex | | getset |

