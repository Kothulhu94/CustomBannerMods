--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html ---

TaleWorlds.MountAndBlade.LobbyNetworkComponent Class ReferenceInherits [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a3248508e4e822180a3590fb2f5b1c5cd) () |
| override void | [HandleEarlyNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#acc6cccf85312c85632dd9a604cd95c3a) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| override void | [HandleNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a341b3cefd3688db4701301e388684073) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| override void | [HandleLateNewClientAfterLoadingFinished](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a3115ee26e3f364fdc18815d0430c03bd) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| override void | [HandlePlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#ac3ff30dc1ac45bae01667dac1cbb87cb) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| override void | [OnUdpNetworkHandlerTick](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a3b9b57227b4728a73f2547293124c1f8) (float dt) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html) | |
| virtual void | [OnUdpNetworkHandlerClose](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a63eb810fd430434c34a21ffe80581646) () |
| virtual void | [HandleNewClientConnect](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#ada57d5fc4a8a3966ff8a35a099f224f4) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) clientConnectionInfo) |
| virtual void | [HandleNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aea660d984f27f33ab47850a3b1625a2f) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [HandleLateNewClientAfterSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a5318fa94984c4036b2bf02e71e49ad5d) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [OnEveryoneUnSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a6ad0800abfdf3967e5e5f2275f012b09) () |
| void | [HandleEarlyPlayerDisconnect](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aef933a841be1bf6b828ab84bd2661629) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [OnPlayerDisconnectedFromServer](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a59e92814e79b9492f7996054636410bd) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| virtual void | [OnDisconnectedFromServer](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a41d98669d28711ccd8936c3bddfb2da4) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaxForcedAvatarIndex](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a28e40c7df321ca117ea78c8edce00877) = 100 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [AddRemoveMessageHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#ab66c74382b7c5aa7cd1f305903039ac0) ([GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) registerer) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html) | |
|  | [UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a39812cf01e62538fb89bfd0242e76e85) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a3248508e4e822180a3590fb2f5b1c5cd)LobbyNetworkComponent()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.LobbyNetworkComponent.LobbyNetworkComponent | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#ab66c74382b7c5aa7cd1f305903039ac0)AddRemoveMessageHandlers()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.LobbyNetworkComponent.AddRemoveMessageHandlers | ( | [GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) | *registerer* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a8abf3622f9a30529a7edcd126ade38ff).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#acc6cccf85312c85632dd9a604cd95c3a)HandleEarlyNewClientAfterLoadingFinished()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.LobbyNetworkComponent.HandleEarlyNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aa9eeea674decebb49db03756400c0546).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a341b3cefd3688db4701301e388684073)HandleNewClientAfterLoadingFinished()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.LobbyNetworkComponent.HandleNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a5b17762ea71d49b6f68620bca718a916).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a3115ee26e3f364fdc18815d0430c03bd)HandleLateNewClientAfterLoadingFinished()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.LobbyNetworkComponent.HandleLateNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a7851ddece1d72caa3efce3b1d66112f7).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#ac3ff30dc1ac45bae01667dac1cbb87cb)HandlePlayerDisconnect()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.LobbyNetworkComponent.HandlePlayerDisconnect | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#ad262f00d20125fb83f512f61dacf76cd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a3b9b57227b4728a73f2547293124c1f8)OnUdpNetworkHandlerTick()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.LobbyNetworkComponent.OnUdpNetworkHandlerTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a58a5ad2a7caa377a7e8b50524a77f7cd).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a28e40c7df321ca117ea78c8edce00877)MaxForcedAvatarIndex
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.LobbyNetworkComponent.MaxForcedAvatarIndex = 100 | | static |

