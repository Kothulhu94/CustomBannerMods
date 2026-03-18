--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html ---

TaleWorlds.MountAndBlade.IUdpNetworkHandler Interface ReferenceInherited by [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html), and [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnUdpNetworkHandlerClose](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ae3fc906a54e62648f39d1e157a706a09) () |
| void | [OnUdpNetworkHandlerTick](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a6d64afd638edabb2e3eb49dd2ad0ef2a) (float dt) |
| void | [HandleNewClientConnect](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a2577e2329e028a06ff6fe4deb3c5b06f) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) clientConnectionInfo) |
| void | [HandleEarlyNewClientAfterLoadingFinished](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a4c381999e9264f3c0c95dcf609d594ba) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| void | [HandleNewClientAfterLoadingFinished](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a9a8829a2fd74b36209b4dcc787828da9) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| void | [HandleLateNewClientAfterLoadingFinished](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a00899e99b4f3d538040e38c98963d272) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| void | [HandleNewClientAfterSynchronized](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ac2ef1acaf956501169a85e41aa58b369) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| void | [HandleLateNewClientAfterSynchronized](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ac061ef8f78a1583556d9a5d665a6a2e3) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| void | [HandleEarlyPlayerDisconnect](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a3ef5a3685329e9e47e0d95a91dd449b1) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| void | [HandlePlayerDisconnect](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a415d85f8a29658fc85163947b9c70a6d) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| void | [OnPlayerDisconnectedFromServer](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#aa245a146f553ef5be8c85c57b64e9946) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| void | [OnDisconnectedFromServer](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a4f52298a084f6df46af49eb41f02c934) () |
| void | [OnEveryoneUnSynchronized](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a9247735619a081c74dbf054003b7603b) () |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ae3fc906a54e62648f39d1e157a706a09)OnUdpNetworkHandlerClose()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.OnUdpNetworkHandlerClose | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a454917317c2b983850f0e64fe7a8ca0b), [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a61aab8a2bbfe2e2bfbe70eb5646b02bd), [TaleWorlds.MountAndBlade.MultiplayerRoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_component.html#aa80b1e58206fcfb829fa68b55cdc48ba), [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#af8c93f99a5ddfafbf7cf4364b6e4741e), [TaleWorlds.MountAndBlade.MultiplayerWarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_warmup_component.html#af41bfa6d49f6f82a9eacadc9b85e02ce), and [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a63eb810fd430434c34a21ffe80581646).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a6d64afd638edabb2e3eb49dd2ad0ef2a)OnUdpNetworkHandlerTick()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.OnUdpNetworkHandlerTick | ( | float | *dt* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a3b9b57227b4728a73f2547293124c1f8), and [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a58a5ad2a7caa377a7e8b50524a77f7cd).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a2577e2329e028a06ff6fe4deb3c5b06f)HandleNewClientConnect()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.HandleNewClientConnect | ( | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) | *clientConnectionInfo* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a57a22b29f081c799cc95de1669f209b2), [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a684b2bb60226f55ad7752a417fbdce56), [TaleWorlds.MountAndBlade.MultiplayerGameNotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_notifications_component.html#ace06bdc251cf4b606c005fb003e56591), and [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#ada57d5fc4a8a3966ff8a35a099f224f4).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a4c381999e9264f3c0c95dcf609d594ba)HandleEarlyNewClientAfterLoadingFinished()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.HandleEarlyNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#acc6cccf85312c85632dd9a604cd95c3a), [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#afed58b68447f15d604fda7730ed32651), [TaleWorlds.MountAndBlade.MissionMultiplayerFlagDomination](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_flag_domination.html#ada3d0236ba5226c1b8e365c0bb4935e7), [TaleWorlds.MountAndBlade.MissionMultiplayerSiege](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ab601a5921633cb2fc2fac8c1082307ce), [TaleWorlds.MountAndBlade.MissionMultiplayerTeamDeathmatch](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_team_deathmatch.html#aede172103e06028cc584b2e632dc44b1), [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ada8d7710e31d528e4b7d7d60fee10477), [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#abf530eccd6698792eee860a641ba18db), and [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aa9eeea674decebb49db03756400c0546).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a9a8829a2fd74b36209b4dcc787828da9)HandleNewClientAfterLoadingFinished()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.HandleNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a341b3cefd3688db4701301e388684073), [TaleWorlds.MountAndBlade.MissionMultiplayerFlagDomination](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_flag_domination.html#a2cdf8faa59502be4374ee1e8ba15ac18), [TaleWorlds.MountAndBlade.MissionMultiplayerSiege](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#ac79fafd46c6ee8193eabdbd74f60ec4f), [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a2ae30190712925d7a1a02b9b76810fe9), and [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a5b17762ea71d49b6f68620bca718a916).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a00899e99b4f3d538040e38c98963d272)HandleLateNewClientAfterLoadingFinished()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.HandleLateNewClientAfterLoadingFinished | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#a3115ee26e3f364fdc18815d0430c03bd), [TaleWorlds.MountAndBlade.MissionLobbyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_lobby_component.html#a0e64052a5d2ea09cc3bafedddf3df61c), [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeBase](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_base.html#a62f7c0c25923498d662dc865ea95fed1), [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#aa603feaeccf8eed50a2cb893e296d9a9), [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#a0b57e2b28835c73fc66d797777b79801), [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#a8d40429a3a7f0af8b9508c0ac612bed3), and [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a7851ddece1d72caa3efce3b1d66112f7).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ac2ef1acaf956501169a85e41aa58b369)HandleNewClientAfterSynchronized()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.HandleNewClientAfterSynchronized | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#ab0e01d5b2cdd9d803dde5dbadf2ab794), [TaleWorlds.MountAndBlade.MissionMultiplayerFlagDomination](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_flag_domination.html#a5b2c6c22bf6f2ede034461d85c2604b6), [TaleWorlds.MountAndBlade.MissionMultiplayerSiege](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege.html#aaa0e8b299d8786d8b1372881a45362e8), [TaleWorlds.MountAndBlade.MissionMultiplayerTeamDeathmatch](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_team_deathmatch.html#a073731555c881e842a521ea52d4838f5), [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a73a47ad2db0dedde69dd82c59400e58a), [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#a78651e487efe4a9e2ff6e5704230a9d5), [TaleWorlds.MountAndBlade.MultiplayerWarmupComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_warmup_component.html#ae7e4da04dfdcbc81dc9d08a2b1a92a15), [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aea660d984f27f33ab47850a3b1625a2f), and [TaleWorlds.MountAndBlade.VoiceChatHandler](class_tale_worlds_1_1_mount_and_blade_1_1_voice_chat_handler.html#a078505a90cd2c16df103b450b606d9f3).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#ac061ef8f78a1583556d9a5d665a6a2e3)HandleLateNewClientAfterSynchronized()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.HandleLateNewClientAfterSynchronized | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#acde723ea5ce90d93d8bcb1adbd916249), [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#ab3ff3f8b34cff3bf3179abbd858838de), [TaleWorlds.MountAndBlade.MissionScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a9280137702bc824ef490bfa22e429a5e), and [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a5318fa94984c4036b2bf02e71e49ad5d).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a3ef5a3685329e9e47e0d95a91dd449b1)HandleEarlyPlayerDisconnect()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.HandleEarlyPlayerDisconnect | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#a18000e1a9d2457ff4ac960fad37f1907), [TaleWorlds.MountAndBlade.MissionMultiplayerFlagDomination](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_flag_domination.html#a812a55b6cb5a010f5f5cc6244ddc377d), [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a6ad7aa76f0bd9635689a16ecf697f24f), [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#a113618bb716c8bb74ce41367cd4436af), and [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#aef933a841be1bf6b828ab84bd2661629).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a415d85f8a29658fc85163947b9c70a6d)HandlePlayerDisconnect()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.HandlePlayerDisconnect | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.LobbyNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_lobby_network_component.html#ac3ff30dc1ac45bae01667dac1cbb87cb), [TaleWorlds.MountAndBlade.MissionMultiplayerDuel](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_duel.html#aea9cfee6a622fa4078c7f6d0d675a1ec), [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a42028d84ad1a39843cb532731fa76e14), [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#af226ba628ba092b6bcd2c5e3e927527d), [TaleWorlds.MountAndBlade.MultiplayerGameNotificationsComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_game_notifications_component.html#a97b22c8c2862e953a97b3fc4b38e7081), and [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#ad262f00d20125fb83f512f61dacf76cd).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#aa245a146f553ef5be8c85c57b64e9946)OnPlayerDisconnectedFromServer()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.OnPlayerDisconnectedFromServer | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MissionNetwork](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network.html#a331802321c1ab0c5e399a14522e49b4b), [TaleWorlds.MountAndBlade.MissionNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_network_component.html#ab0b3ab12f5e25c5d481b83a5fb45681b), [TaleWorlds.MountAndBlade.MissionScoreboardComponent](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component.html#a710a7b6356b8b3502770b4d1ea0db070), [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a59e92814e79b9492f7996054636410bd), and [TaleWorlds.MountAndBlade.VoiceChatHandler](class_tale_worlds_1_1_mount_and_blade_1_1_voice_chat_handler.html#a7bd9c738aa0412bfc2c6b32de25bf264).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a4f52298a084f6df46af49eb41f02c934)OnDisconnectedFromServer()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.OnDisconnectedFromServer | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a41d98669d28711ccd8936c3bddfb2da4).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html#a9247735619a081c74dbf054003b7603b)OnEveryoneUnSynchronized()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IUdpNetworkHandler.OnEveryoneUnSynchronized | ( |  | ) |  |

Implemented in [TaleWorlds.MountAndBlade.UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html#a6ad0800abfdf3967e5e5f2275f012b09).

