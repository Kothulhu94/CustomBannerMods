--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_base_network_component_data.html ---

TaleWorlds.MountAndBlade.BaseNetworkComponentData Class ReferenceInherits [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [UpdateCurrentBattleIndex](class_tale_worlds_1_1_mount_and_blade_1_1_base_network_component_data.html#a09163b37e8a80a78b4e56a121741afd1) (int currentBattleIndex) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html) | |
| virtual void | [OnUdpNetworkHandlerClose](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a63eb810fd430434c34a21ffe80581646) () |
| virtual void | [OnUdpNetworkHandlerTick](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a58a5ad2a7caa377a7e8b50524a77f7cd) (float dt) |
| virtual void | [HandleNewClientConnect](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#ada57d5fc4a8a3966ff8a35a099f224f4) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) clientConnectionInfo) |
| virtual void | [HandleEarlyNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aa9eeea674decebb49db03756400c0546) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a5b17762ea71d49b6f68620bca718a916) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleLateNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a7851ddece1d72caa3efce3b1d66112f7) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aea660d984f27f33ab47850a3b1625a2f) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleLateNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a5318fa94984c4036b2bf02e71e49ad5d) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [OnEveryoneUnSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a6ad0800abfdf3967e5e5f2275f012b09) () |
| void | [HandleEarlyPlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aef933a841be1bf6b828ab84bd2661629) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandlePlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#ad262f00d20125fb83f512f61dacf76cd) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [OnPlayerDisconnectedFromServer](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a59e92814e79b9492f7996054636410bd) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [OnDisconnectedFromServer](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a41d98669d28711ccd8936c3bddfb2da4) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [MaxIntermissionStateTime](class_tale_worlds_1_1_mount_and_blade_1_1_base_network_component_data.html#a956ac8739054fe9f0527037bbe8f1161) = 240.0f |

|  |  |
| --- | --- |
| Properties | |
| int | [CurrentBattleIndex](class_tale_worlds_1_1_mount_and_blade_1_1_base_network_component_data.html#a67c2a282ffc17a3668e7fc4638caee99) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html) | |
|  | [UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a39812cf01e62538fb89bfd0242e76e85) () |
| virtual void | [AddRemoveMessageHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a8abf3622f9a30529a7edcd126ade38ff) ([GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) registerer) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_base_network_component_data.html#a09163b37e8a80a78b4e56a121741afd1)UpdateCurrentBattleIndex()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.BaseNetworkComponentData.UpdateCurrentBattleIndex | ( | int | *currentBattleIndex* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_base_network_component_data.html#a956ac8739054fe9f0527037bbe8f1161)MaxIntermissionStateTime
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.BaseNetworkComponentData.MaxIntermissionStateTime = 240.0f | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_base_network_component_data.html#a67c2a282ffc17a3668e7fc4638caee99)CurrentBattleIndex
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.BaseNetworkComponentData.CurrentBattleIndex | | get |

