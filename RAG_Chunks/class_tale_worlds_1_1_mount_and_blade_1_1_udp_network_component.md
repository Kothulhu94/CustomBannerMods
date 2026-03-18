--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html ---

TaleWorlds.MountAndBlade.UdpNetworkComponent Class ReferenceabstractInherits [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html).

Inherited by [TaleWorlds.MountAndBlade.BaseNetworkComponentData](class_tale_worlds_1_1_mount_and_blade_1_1_base_network_component_data.html), and [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| Protected Member Functions | |
|  | [UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a39812cf01e62538fb89bfd0242e76e85) () |
| virtual void | [AddRemoveMessageHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a8abf3622f9a30529a7edcd126ade38ff) ([GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) registerer) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a39812cf01e62538fb89bfd0242e76e85)UdpNetworkComponent()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.UdpNetworkComponent.UdpNetworkComponent | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a8abf3622f9a30529a7edcd126ade38ff)AddRemoveMessageHandlers()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.AddRemoveMessageHandlers | ( | [GameNetwork.NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) | *registerer* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#ab66c74382b7c5aa7cd1f305903039ac0).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a63eb810fd430434c34a21ffe80581646)OnUdpNetworkHandlerClose()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.OnUdpNetworkHandlerClose | ( |  | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ae3fc906a54e62648f39d1e157a706a09).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a58a5ad2a7caa377a7e8b50524a77f7cd)OnUdpNetworkHandlerTick()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.OnUdpNetworkHandlerTick | ( | float | *dt* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a6d64afd638edabb2e3eb49dd2ad0ef2a).

Reimplemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a3b9b57227b4728a73f2547293124c1f8).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#ada57d5fc4a8a3966ff8a35a099f224f4)HandleNewClientConnect()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.HandleNewClientConnect | ( | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) | *clientConnectionInfo* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a2577e2329e028a06ff6fe4deb3c5b06f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aa9eeea674decebb49db03756400c0546)HandleEarlyNewClientAfterLoadingFinished()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.HandleEarlyNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a4c381999e9264f3c0c95dcf609d594ba).

Reimplemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#acc6cccf85312c85632dd9a604cd95c3a).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a5b17762ea71d49b6f68620bca718a916)HandleNewClientAfterLoadingFinished()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.HandleNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a9a8829a2fd74b36209b4dcc787828da9).

Reimplemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a341b3cefd3688db4701301e388684073).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a7851ddece1d72caa3efce3b1d66112f7)HandleLateNewClientAfterLoadingFinished()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.HandleLateNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a00899e99b4f3d538040e38c98963d272).

Reimplemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a3115ee26e3f364fdc18815d0430c03bd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aea660d984f27f33ab47850a3b1625a2f)HandleNewClientAfterSynchronized()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.HandleNewClientAfterSynchronized | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ac2ef1acaf956501169a85e41aa58b369).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a5318fa94984c4036b2bf02e71e49ad5d)HandleLateNewClientAfterSynchronized()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.HandleLateNewClientAfterSynchronized | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ac061ef8f78a1583556d9a5d665a6a2e3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a6ad0800abfdf3967e5e5f2275f012b09)OnEveryoneUnSynchronized()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.OnEveryoneUnSynchronized | ( |  | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a9247735619a081c74dbf054003b7603b).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aef933a841be1bf6b828ab84bd2661629)HandleEarlyPlayerDisconnect()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UdpNetworkComponent.HandleEarlyPlayerDisconnect | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a3ef5a3685329e9e47e0d95a91dd449b1).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#ad262f00d20125fb83f512f61dacf76cd)HandlePlayerDisconnect()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.HandlePlayerDisconnect | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a415d85f8a29658fc85163947b9c70a6d).

Reimplemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#ac3ff30dc1ac45bae01667dac1cbb87cb).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a59e92814e79b9492f7996054636410bd)OnPlayerDisconnectedFromServer()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.OnPlayerDisconnectedFromServer | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#aa245a146f553ef5be8c85c57b64e9946).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a41d98669d28711ccd8936c3bddfb2da4)OnDisconnectedFromServer()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UdpNetworkComponent.OnDisconnectedFromServer | ( |  | ) |  | | virtual |

Implements [TaleWorlds.MountAndBlade.IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a4f52298a084f6df46af49eb41f02c934).

