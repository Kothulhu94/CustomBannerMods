--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html ---

TaleWorlds.MountAndBlade.GameNetwork Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [NetworkMessageHandlerRegisterer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html) |
| class | [NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html) |
| struct | [DebugNetworkPositionCompressionStatisticsStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_debug_network_position_compression_statistics_struct.html) |
| struct | [DebugNetworkPacketStatisticsStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_debug_network_packet_statistics_struct.html) |
| struct | [AddPlayersResult](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_add_players_result.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [EventBroadcastFlags](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84e) {     [None](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84ea6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [ExcludeTargetPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84eab389528e2e4c61e08568fab5b760b270) = 0x00000001 ,     [ExcludeNoBloodStainsOption](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84ea8df72857e50dccb7eaf8c77afd040230) = 0x00000002 ,     [ExcludeNoParticlesOption](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84ea4856c8e9c24f71c7d8874113cc16c122) = 0x00000004 ,     [ExcludeNoSoundOption](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84eabb6edb021ff3cabfff287788e4ad2c7e) = 0x00000008 ,     [AddToMissionRecord](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84eafdf0dafe64aa46cf3948dda89af34de0) = 0x00000010 ,     [IncludeUnsynchronizedClients](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84eab4929a590a6c37699e5e5da9bbf280d2) = 0x00000020 ,     [ExcludeOtherTeamPlayers](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84ea290044e44fbd47938ef80635b2247b7c) = 0x00000040 ,     [ExcludePeerTeamPlayers](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84eadf55ebfd6335453fc278714ccae4e71e) = 0x00000080 ,     [DontSendToPeers](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84ea67ec1e32f4b963e4a6aba8a99f5d61a1) = 0x00000100   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [ClearAllPeers](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a69adb9cb9acb81c09ee458dd276d65da) () |
| static [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | [FindNetworkPeer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ab28e3332a140704a04f9edfcba58ddab) (int index) |
| static void | [Initialize](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a24124fce016768d57e2ca4478ef01eee) ([IGameNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html) handler) |
| static void | [EndMultiplayer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a4e2fac3e3d99d1ae94adce211d77e755) () |
| static void | [StartReplay](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ac666c5f661f89efae7e0812bdf7883b6) () |
| static void | [EndReplay](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a5a36cd721825ae1026b2b26fe9132763) () |
| static void | [PreStartMultiplayerOnServer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aab042a72b0f680bc6ac365a33b53126a) () |
| static void | [StartMultiplayerOnServer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a790c6a2c887413f121448e50e8d68eed) (int port) |
| static void | [HandleConsoleCommand](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ab794205d49a976dd2b001ca9b634fc5c) (string command) |
| static string | [GetActiveUdpSessionsIpAddress](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a656403763f0ff7c0a651e07ed4a39281) () |
| static [ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html) | [AddNewPlayerOnServer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae35fc296cc38d69334c626610be07bc1) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) playerConnectionInfo, bool serverPeer, bool isAdmin) |
| static [AddPlayersResult](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_add_players_result.html) | [AddNewPlayersOnServer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad172cc9584dcc54d4abb4b379ca41854) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html)[] playerConnectionInfos, bool serverPeer) |
| static void | [ClientFinishedLoading](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aa6709ac11d8d66dddedde1b7bdb6709f) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| static void | [BeginModuleEventAsClient](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8a9e0bb9041c9bb52c7f872fa287f0b3) () |
| static void | [EndModuleEventAsClient](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ab8ac0933c31143a977427748191bd611) () |
| static void | [BeginModuleEventAsClientUnreliable](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aefe5af6faa7862bca5c1e5311aaa4512) () |
| static void | [EndModuleEventAsClientUnreliable](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#af6f11d27a75c6c98e43e601d0fcd2387) () |
| static void | [BeginModuleEventAsServer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae42bb3a2de8392afdc06e007b7f3c1e5) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) communicator) |
| static void | [BeginModuleEventAsServerUnreliable](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8c81085f39ef32ff3e46192f87b905af) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) communicator) |
| static void | [BeginModuleEventAsServer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#abe4ab10898692117105e51975149eaf3) ([VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) peer) |
| static void | [EndModuleEventAsServer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a16b82117410b2b0b58c72673b497a4f7) () |
| static void | [BeginModuleEventAsServerUnreliable](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a78f2816351673e3051e45f3f78181786) ([VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) peer) |
| static void | [EndModuleEventAsServerUnreliable](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a0b44eef56045fb2e464dc8107fe76fd7) () |
| static void | [BeginBroadcastModuleEvent](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#af8a7dc59500c4ddaceaf5194ce5dfe9c) () |
| static void | [EndBroadcastModuleEvent](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a1ff5b0fab70c255209aec08c028147b8) ([EventBroadcastFlags](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84e) broadcastFlags, [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) targetPlayer=null) |
| static double | [ElapsedTimeSinceLastUdpPacketArrived](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#adc04fe109396caa616761f6f0674a70d) () |
| static void | [EndBroadcastModuleEventUnreliable](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a46190fb42cc4dc86f9dfe617ed6c3c16) ([EventBroadcastFlags](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84e) broadcastFlags, [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) targetPlayer=null) |
| static void | [UnSynchronizeEveryone](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a43dba235b1dc5da6178f66822194c067) () |
| static void | [AddRemoveMessageHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a25190e7475483e34916fb83540dbe167) ([NetworkMessageHandlerRegisterer.RegisterMode](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588) mode) |
| static void | [StartMultiplayerOnClient](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a7ec4e250f84f51843a62bc1922013e93) (string serverAddress, int port, int sessionKey, int playerIndex) |
| static [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | [HandleNewClientConnect](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aa4c3522007d09c8c13b027d5869a55dd) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) playerConnectionInfo, bool isAdmin) |
| static [AddPlayersResult](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_add_players_result.html) | [HandleNewClientsConnect](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a93e3c944ae90024210727a81447ecfd5) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html)[] playerConnectionInfos, bool isAdmin) |
| static void | [AddNetworkPeerToDisconnectAsServer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8fc85d59f00eb79ca3c05fa3f516d36f) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| static void | [InitializeClientSide](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#afcf4cff636d9c2e843841309f25ff3e1) (string serverAddress, int port, int sessionKey, int playerIndex) |
| static void | [TerminateClientSide](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a343556f31b0c758d9f422b46adb1132e) () |
| static Type | [GetSynchedMissionObjectReadableRecordTypeFromIndex](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a3231953eab35520942c9af7c9aae594f) (int typeIndex) |
| static int | [GetSynchedMissionObjectReadableRecordIndexFromType](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a4c85b04b895f56d9dbc49a2e60295b5d) (Type type) |
| static void | [DestroyComponent](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a4e893e5dbe22a0a94d04d4dc09011333) ([UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html) udpNetworkComponent) |
| static T | [AddNetworkComponent< T >](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a5b3cacc01fb5da31d82e64258b52eff1) () |
| static void | [AddNetworkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aa80651a50d31565251d8a5104df0e813) ([IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html) handler) |
| static void | [RemoveNetworkHandler](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a97fe8c609a248a4dbee5e40fde9de4fa) ([IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html) handler) |
| static T | [GetNetworkComponent< T >](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a4b87f975f55bdd7c7dc66bb800d09e32) () |
| static void | [WriteMessage](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8ce2342f919e4414335239e7ee24715c) ([GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) message) |
| static void | [SetServerBandwidthLimitInMbps](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a3abd3ec7ced430fd6749fa42a2247c36) (double value) |
| static void | [SetServerTickRate](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad4e595d13a6d052280551be486b8dff0) (double value) |
| static void | [SetServerFrameRate](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a00a3485553fd249035c4f3b491ec754a) (double value) |
| static void | [ResetDebugVariables](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#af235a15890ac521fba10b9768bcccd3d) () |
| static void | [PrintDebugStats](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8f33b4b27ab0df58cbf39d10948df133) () |
| static float | [GetAveragePacketLossRatio](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a59c88de067ad0aaf9de6862b852ba479) () |
| static void | [GetDebugUploadsInBits](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae68055434e9fd56524be7bbdeb4f6a1c) (ref [DebugNetworkPacketStatisticsStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_debug_network_packet_statistics_struct.html) networkStatisticsStruct, ref [DebugNetworkPositionCompressionStatisticsStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_debug_network_position_compression_statistics_struct.html) posStatisticsStruct) |
| static void | [PrintReplicationTableStatistics](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a23ba2cf4008eecdfde7aeacd981553cd) () |
| static void | [ClearReplicationTableStatistics](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a24139b27798c0b2cae270eff0905b204) () |
| static void | [ResetDebugUploads](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ac646d16ab3ede3855b6ea373db2aa951) () |
| static void | [ResetMissionData](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae9bfee51edd5b6e9a622f33b62cb8167) () |
| static void | [InitializeCompressionInfos](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a6e6bf1112d11395b3963f3e182c8df4a) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaxAutomatedBattleIndex](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ab34a3223660399b6d9a63492af01103d) = 10 |
| const int | [MaxPlayerCount](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aedd41b818a10f10f70ea30f96f1362bc) = 1023 |
| static int | [ClientPeerIndex](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a2ac109761376491173bdf4df2c077f77) |

|  |  |
| --- | --- |
| Properties | |
| static bool | [IsServer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a6a7bfd2e4f520ba5b74423c1b3f12a02) `[get]` |
| static bool | [IsServerOrRecorder](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a33358519633bab9125522f4c59d69de6) `[get]` |
| static bool | [IsClient](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a4870d689d15c7a21f228133479aa07da) `[get]` |
| static bool | [IsReplay](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a66b859c118bcd070c7b6976ad093055c) `[get]` |
| static bool | [IsClientOrReplay](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a0b8a76ae29f9ae89c255859d49afd185) `[get]` |
| static bool | [IsDedicatedServer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#af8d62c5f2bb0bf1a4b9099d0930fa9ec) `[get]` |
| static bool | [MultiplayerDisabled](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a98afd336972a6516504db222fd4318ad) `[get]` |
| static bool | [IsMultiplayer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae21c19665815c6ecf5709c9955efd43a) `[get]` |
| static bool | [IsMultiplayerOrReplay](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a9185ce7828bf8437c0ee5d64631c6f2e) `[get]` |
| static bool | [IsSessionActive](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ac0d916d6be502e493b6db383a27c15dc) `[get]` |
| static IEnumerable< [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) > | [NetworkPeersIncludingDisconnectedPeers](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a9b62fd6efc71eacdd05a16f04f397d5a) `[get]` |
| static [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html)[] | [VirtualPlayers](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ac274bb2dcffddc508191dce28799e17b) `[get]` |
| static List< [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) > | [NetworkPeers](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a1e46aa366aa39af3210882b5979e8150) `[get]` |
| static List< [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) > | [DisconnectedNetworkPeers](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#abc5d7334c7002ded90996afd2b6c93f2) `[get]` |
| static int | [NetworkPeerCount](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a82b034a5eb3be3dd1be4cb9ac747d3c0) `[get]` |
| static bool | [NetworkPeersValid](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad6669e28211627e32ceee6f63325b378) `[get]` |
| static List< [UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html) > | [NetworkComponents](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae6fe2e9a010c43f3ee2148cd207e7dc9) `[get]` |
| static List< [IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html) > | [NetworkHandlers](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae19f27f9315f7aaf049879ff84947504) `[get]` |
| static [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | [MyPeer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8a36f1cfcd61b8ef48ac00bc20c9f088) `[get]` |
| static bool | [IsMyPeerReady](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a577a43f2d397a45cb860fc13f504f2c4) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84e)EventBroadcastFlags
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.GameNetwork.EventBroadcastFlags](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84e) |

| Enumerator | |
| --- | --- |
| None |  |
| ExcludeTargetPlayer |  |
| ExcludeNoBloodStainsOption |  |
| ExcludeNoParticlesOption |  |
| ExcludeNoSoundOption |  |
| AddToMissionRecord |  |
| IncludeUnsynchronizedClients |  |
| ExcludeOtherTeamPlayers |  |
| ExcludePeerTeamPlayers |  |
| DontSendToPeers |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a69adb9cb9acb81c09ee458dd276d65da)ClearAllPeers()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.ClearAllPeers | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ab28e3332a140704a04f9edfcba58ddab)FindNetworkPeer()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) TaleWorlds.MountAndBlade.GameNetwork.FindNetworkPeer | ( | int | *index* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a24124fce016768d57e2ca4478ef01eee)Initialize()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.Initialize | ( | [IGameNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html) | *handler* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a4e2fac3e3d99d1ae94adce211d77e755)EndMultiplayer()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.EndMultiplayer | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ac666c5f661f89efae7e0812bdf7883b6)StartReplay()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.StartReplay | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a5a36cd721825ae1026b2b26fe9132763)EndReplay()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.EndReplay | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aab042a72b0f680bc6ac365a33b53126a)PreStartMultiplayerOnServer()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.PreStartMultiplayerOnServer | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a790c6a2c887413f121448e50e8d68eed)StartMultiplayerOnServer()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.StartMultiplayerOnServer | ( | int | *port* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ab794205d49a976dd2b001ca9b634fc5c)HandleConsoleCommand()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.HandleConsoleCommand | ( | string | *command* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a656403763f0ff7c0a651e07ed4a39281)GetActiveUdpSessionsIpAddress()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.GameNetwork.GetActiveUdpSessionsIpAddress | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae35fc296cc38d69334c626610be07bc1)AddNewPlayerOnServer()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html) TaleWorlds.MountAndBlade.GameNetwork.AddNewPlayerOnServer | ( | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) | *playerConnectionInfo*, | |  |  | bool | *serverPeer*, | |  |  | bool | *isAdmin* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad172cc9584dcc54d4abb4b379ca41854)AddNewPlayersOnServer()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [AddPlayersResult](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_add_players_result.html) TaleWorlds.MountAndBlade.GameNetwork.AddNewPlayersOnServer | ( | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html)[] | *playerConnectionInfos*, | |  |  | bool | *serverPeer* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aa6709ac11d8d66dddedde1b7bdb6709f)ClientFinishedLoading()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.ClientFinishedLoading | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8a9e0bb9041c9bb52c7f872fa287f0b3)BeginModuleEventAsClient()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.BeginModuleEventAsClient | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ab8ac0933c31143a977427748191bd611)EndModuleEventAsClient()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.EndModuleEventAsClient | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aefe5af6faa7862bca5c1e5311aaa4512)BeginModuleEventAsClientUnreliable()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.BeginModuleEventAsClientUnreliable | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#af6f11d27a75c6c98e43e601d0fcd2387)EndModuleEventAsClientUnreliable()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.EndModuleEventAsClientUnreliable | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae42bb3a2de8392afdc06e007b7f3c1e5)BeginModuleEventAsServer() [1/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.BeginModuleEventAsServer | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *communicator* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8c81085f39ef32ff3e46192f87b905af)BeginModuleEventAsServerUnreliable() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.BeginModuleEventAsServerUnreliable | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *communicator* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#abe4ab10898692117105e51975149eaf3)BeginModuleEventAsServer() [2/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.BeginModuleEventAsServer | ( | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | *peer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a16b82117410b2b0b58c72673b497a4f7)EndModuleEventAsServer()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.EndModuleEventAsServer | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a78f2816351673e3051e45f3f78181786)BeginModuleEventAsServerUnreliable() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.BeginModuleEventAsServerUnreliable | ( | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) | *peer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a0b44eef56045fb2e464dc8107fe76fd7)EndModuleEventAsServerUnreliable()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.EndModuleEventAsServerUnreliable | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#af8a7dc59500c4ddaceaf5194ce5dfe9c)BeginBroadcastModuleEvent()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.BeginBroadcastModuleEvent | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a1ff5b0fab70c255209aec08c028147b8)EndBroadcastModuleEvent()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.EndBroadcastModuleEvent | ( | [EventBroadcastFlags](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84e) | *broadcastFlags*, | |  |  | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *targetPlayer* = null ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#adc04fe109396caa616761f6f0674a70d)ElapsedTimeSinceLastUdpPacketArrived()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | double TaleWorlds.MountAndBlade.GameNetwork.ElapsedTimeSinceLastUdpPacketArrived | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a46190fb42cc4dc86f9dfe617ed6c3c16)EndBroadcastModuleEventUnreliable()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.EndBroadcastModuleEventUnreliable | ( | [EventBroadcastFlags](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad685bad93d7b23f6fa8971795c01a84e) | *broadcastFlags*, | |  |  | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *targetPlayer* = null ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a43dba235b1dc5da6178f66822194c067)UnSynchronizeEveryone()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.UnSynchronizeEveryone | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a25190e7475483e34916fb83540dbe167)AddRemoveMessageHandlers()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.AddRemoveMessageHandlers | ( | [NetworkMessageHandlerRegisterer.RegisterMode](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588) | *mode* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a7ec4e250f84f51843a62bc1922013e93)StartMultiplayerOnClient()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.StartMultiplayerOnClient | ( | string | *serverAddress*, | |  |  | int | *port*, | |  |  | int | *sessionKey*, | |  |  | int | *playerIndex* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aa4c3522007d09c8c13b027d5869a55dd)HandleNewClientConnect()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) TaleWorlds.MountAndBlade.GameNetwork.HandleNewClientConnect | ( | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) | *playerConnectionInfo*, | |  |  | bool | *isAdmin* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a93e3c944ae90024210727a81447ecfd5)HandleNewClientsConnect()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [AddPlayersResult](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_add_players_result.html) TaleWorlds.MountAndBlade.GameNetwork.HandleNewClientsConnect | ( | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html)[] | *playerConnectionInfos*, | |  |  | bool | *isAdmin* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8fc85d59f00eb79ca3c05fa3f516d36f)AddNetworkPeerToDisconnectAsServer()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.AddNetworkPeerToDisconnectAsServer | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#afcf4cff636d9c2e843841309f25ff3e1)InitializeClientSide()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.InitializeClientSide | ( | string | *serverAddress*, | |  |  | int | *port*, | |  |  | int | *sessionKey*, | |  |  | int | *playerIndex* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a343556f31b0c758d9f422b46adb1132e)TerminateClientSide()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.TerminateClientSide | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a3231953eab35520942c9af7c9aae594f)GetSynchedMissionObjectReadableRecordTypeFromIndex()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Type TaleWorlds.MountAndBlade.GameNetwork.GetSynchedMissionObjectReadableRecordTypeFromIndex | ( | int | *typeIndex* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a4c85b04b895f56d9dbc49a2e60295b5d)GetSynchedMissionObjectReadableRecordIndexFromType()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.GameNetwork.GetSynchedMissionObjectReadableRecordIndexFromType | ( | Type | *type* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a4e893e5dbe22a0a94d04d4dc09011333)DestroyComponent()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.DestroyComponent | ( | [UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html) | *udpNetworkComponent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a5b3cacc01fb5da31d82e64258b52eff1)AddNetworkComponent< T >()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | T TaleWorlds.MountAndBlade.GameNetwork.AddNetworkComponent< T > | ( |  | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aa80651a50d31565251d8a5104df0e813)AddNetworkHandler()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.AddNetworkHandler | ( | [IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html) | *handler* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a97fe8c609a248a4dbee5e40fde9de4fa)RemoveNetworkHandler()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.RemoveNetworkHandler | ( | [IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html) | *handler* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a4b87f975f55bdd7c7dc66bb800d09e32)GetNetworkComponent< T >()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | T TaleWorlds.MountAndBlade.GameNetwork.GetNetworkComponent< T > | ( |  | ) |  | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html)* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8ce2342f919e4414335239e7ee24715c)WriteMessage()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.WriteMessage | ( | [GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) | *message* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a3abd3ec7ced430fd6749fa42a2247c36)SetServerBandwidthLimitInMbps()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.SetServerBandwidthLimitInMbps | ( | double | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad4e595d13a6d052280551be486b8dff0)SetServerTickRate()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.SetServerTickRate | ( | double | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a00a3485553fd249035c4f3b491ec754a)SetServerFrameRate()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.SetServerFrameRate | ( | double | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#af235a15890ac521fba10b9768bcccd3d)ResetDebugVariables()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.ResetDebugVariables | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8f33b4b27ab0df58cbf39d10948df133)PrintDebugStats()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.PrintDebugStats | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a59c88de067ad0aaf9de6862b852ba479)GetAveragePacketLossRatio()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.GameNetwork.GetAveragePacketLossRatio | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae68055434e9fd56524be7bbdeb4f6a1c)GetDebugUploadsInBits()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.GetDebugUploadsInBits | ( | ref [DebugNetworkPacketStatisticsStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_debug_network_packet_statistics_struct.html) | *networkStatisticsStruct*, | |  |  | ref [DebugNetworkPositionCompressionStatisticsStruct](struct_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_debug_network_position_compression_statistics_struct.html) | *posStatisticsStruct* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a23ba2cf4008eecdfde7aeacd981553cd)PrintReplicationTableStatistics()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.PrintReplicationTableStatistics | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a24139b27798c0b2cae270eff0905b204)ClearReplicationTableStatistics()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.ClearReplicationTableStatistics | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ac646d16ab3ede3855b6ea373db2aa951)ResetDebugUploads()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.ResetDebugUploads | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae9bfee51edd5b6e9a622f33b62cb8167)ResetMissionData()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.ResetMissionData | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a6e6bf1112d11395b3963f3e182c8df4a)InitializeCompressionInfos()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.GameNetwork.InitializeCompressionInfos | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ab34a3223660399b6d9a63492af01103d)MaxAutomatedBattleIndex
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.GameNetwork.MaxAutomatedBattleIndex = 10 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#aedd41b818a10f10f70ea30f96f1362bc)MaxPlayerCount
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.GameNetwork.MaxPlayerCount = 1023 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a2ac109761376491173bdf4df2c077f77)ClientPeerIndex
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.GameNetwork.ClientPeerIndex | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a6a7bfd2e4f520ba5b74423c1b3f12a02)IsServer
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.IsServer | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a33358519633bab9125522f4c59d69de6)IsServerOrRecorder
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.IsServerOrRecorder | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a4870d689d15c7a21f228133479aa07da)IsClient
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.IsClient | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a66b859c118bcd070c7b6976ad093055c)IsReplay
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.IsReplay | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a0b8a76ae29f9ae89c255859d49afd185)IsClientOrReplay
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.IsClientOrReplay | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#af8d62c5f2bb0bf1a4b9099d0930fa9ec)IsDedicatedServer
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.IsDedicatedServer | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a98afd336972a6516504db222fd4318ad)MultiplayerDisabled
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.MultiplayerDisabled | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae21c19665815c6ecf5709c9955efd43a)IsMultiplayer
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.IsMultiplayer | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a9185ce7828bf8437c0ee5d64631c6f2e)IsMultiplayerOrReplay
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.IsMultiplayerOrReplay | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ac0d916d6be502e493b6db383a27c15dc)IsSessionActive
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.IsSessionActive | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a9b62fd6efc71eacdd05a16f04f397d5a)NetworkPeersIncludingDisconnectedPeers
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html)> TaleWorlds.MountAndBlade.GameNetwork.NetworkPeersIncludingDisconnectedPeers | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ac274bb2dcffddc508191dce28799e17b)VirtualPlayers
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [VirtualPlayer](class_tale_worlds_1_1_core_1_1_virtual_player.html) [] TaleWorlds.MountAndBlade.GameNetwork.VirtualPlayers | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a1e46aa366aa39af3210882b5979e8150)NetworkPeers
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html)> TaleWorlds.MountAndBlade.GameNetwork.NetworkPeers | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#abc5d7334c7002ded90996afd2b6c93f2)DisconnectedNetworkPeers
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html)> TaleWorlds.MountAndBlade.GameNetwork.DisconnectedNetworkPeers | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a82b034a5eb3be3dd1be4cb9ac747d3c0)NetworkPeerCount
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.GameNetwork.NetworkPeerCount | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ad6669e28211627e32ceee6f63325b378)NetworkPeersValid
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.NetworkPeersValid | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae6fe2e9a010c43f3ee2148cd207e7dc9)NetworkComponents
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[UdpNetworkComponent](class_tale_worlds_1_1_mount_and_blade_1_1_udp_network_component.html)> TaleWorlds.MountAndBlade.GameNetwork.NetworkComponents | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#ae19f27f9315f7aaf049879ff84947504)NetworkHandlers
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[IUdpNetworkHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_udp_network_handler.html)> TaleWorlds.MountAndBlade.GameNetwork.NetworkHandlers | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a8a36f1cfcd61b8ef48ac00bc20c9f088)MyPeer
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) TaleWorlds.MountAndBlade.GameNetwork.MyPeer | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network.html#a577a43f2d397a45cb860fc13f504f2c4)IsMyPeerReady
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.GameNetwork.IsMyPeerReady | | staticget |

