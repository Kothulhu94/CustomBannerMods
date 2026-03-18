--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html ---

TaleWorlds.MountAndBlade.PeerExtensions Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SendExistingObjects](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#adf0c8d74dcb65023cc5c79c80e2057ca) (this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) peer, [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| static [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | [GetPeer](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#aacb79318852b6b3652744cb56341a69d) (this [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) peerComponent) |
| static [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | [GetNetworkPeer](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a8b8fb7efa572c9af8c8f3dc98afd83c5) (this [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) peerComponent) |
| static T | [GetComponent< T >](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a2a12c56c2aea51bb4d7dc1629b3b407e) (this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| static void | [RemoveComponent< T >](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a9a37aa81ecbd815877593d32b3a8f563) (this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer, bool synched=true) |
| static void | [RemoveComponent](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a8dd53545cc99fd39e52ddc38a460f510) (this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer, [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) component) |
| static [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | [GetComponent](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#af4b303b46598fb29646ef0ae6a69b45b) (this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer, uint componentId) |
| static void | [AddComponent](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a63984488c17af49735fa2fff2d5562ea) (this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer, Type peerComponentType) |
| static void | [AddComponent](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a9d28dd39c28a078b1882d1bfee393a06) (this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer, uint componentId) |
| static T | [AddComponent< T >](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a4b979385f4129e1266d1c5736dd9a988) (this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| static T | [TellClientToAddComponent< T >](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a662242a7e64ccf67e4d54b77036b42e3) (this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#adf0c8d74dcb65023cc5c79c80e2057ca)SendExistingObjects()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.PeerExtensions.SendExistingObjects | ( | this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *peer*, | |  |  | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#aacb79318852b6b3652744cb56341a69d)GetPeer()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) TaleWorlds.MountAndBlade.PeerExtensions.GetPeer | ( | this [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | *peerComponent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a8b8fb7efa572c9af8c8f3dc98afd83c5)GetNetworkPeer()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) TaleWorlds.MountAndBlade.PeerExtensions.GetNetworkPeer | ( | this [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | *peerComponent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a2a12c56c2aea51bb4d7dc1629b3b407e)GetComponent< T >()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T [TaleWorlds.MountAndBlade.PeerExtensions.GetComponent](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#af4b303b46598fb29646ef0ae6a69b45b)< T > | ( | this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a9a37aa81ecbd815877593d32b3a8f563)RemoveComponent< T >()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void [TaleWorlds.MountAndBlade.PeerExtensions.RemoveComponent](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a8dd53545cc99fd39e52ddc38a460f510)< T > | ( | this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer*, | |  |  | bool | *synched* = true ) | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a8dd53545cc99fd39e52ddc38a460f510)RemoveComponent()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.PeerExtensions.RemoveComponent | ( | this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer*, | |  |  | [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) | *component* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#af4b303b46598fb29646ef0ae6a69b45b)GetComponent()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) TaleWorlds.MountAndBlade.PeerExtensions.GetComponent | ( | this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer*, | |  |  | uint | *componentId* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a63984488c17af49735fa2fff2d5562ea)AddComponent() [1/2]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.PeerExtensions.AddComponent | ( | this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer*, | |  |  | Type | *peerComponentType* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a9d28dd39c28a078b1882d1bfee393a06)AddComponent() [2/2]
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.PeerExtensions.AddComponent | ( | this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer*, | |  |  | uint | *componentId* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a4b979385f4129e1266d1c5736dd9a988)AddComponent< T >()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T [TaleWorlds.MountAndBlade.PeerExtensions.AddComponent](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a63984488c17af49735fa2fff2d5562ea)< T > | ( | this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html)* |  |
    | *T* | : | *new()* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_peer_extensions.html#a662242a7e64ccf67e4d54b77036b42e3)TellClientToAddComponent< T >()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.MountAndBlade.PeerExtensions.TellClientToAddComponent< T > | ( | this [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *PeerComponent* |  |
    | *T* | : | *new()* |  |

