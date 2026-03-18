--- SOURCE: class_tale_worlds_1_1_network_1_1_serverside_session.html ---

TaleWorlds.Network.ServersideSession Class ReferenceabstractInherits [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html).

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [ServersideSession](class_tale_worlds_1_1_network_1_1_serverside_session.html#a40dbeeb318835a37111c6cb9d8799026) ([ServersideSessionManager](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html) server) |
| Protected Member Functions inherited from [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html) | |
|  | [NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html#a63a124709e7ece031a559c3a9cbb13eb) () |
| void | [SendPlainMessage](class_tale_worlds_1_1_network_1_1_network_session.html#acab09623f2044497643b6e90091ee46b) ([MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html) message) |

|  |  |
| --- | --- |
| Properties | |
| int | [Index](class_tale_worlds_1_1_network_1_1_serverside_session.html#accf144ed3df41a5184dd682c80836ea1) `[get]` |
| Properties inherited from [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html) | |
| bool | [IsActive](class_tale_worlds_1_1_network_1_1_network_session.html#a6a61cf4af302c949c33cc1ffc9962aa2) `[get]` |
| string | [Address](class_tale_worlds_1_1_network_1_1_network_session.html#a316f5fb548268c475312884cba6b7f62) `[get]` |
| int | [LastMessageSentTime](class_tale_worlds_1_1_network_1_1_network_session.html#a3e6fad2e885a34288a6e48cc5aab458f) `[get]` |
| bool | [IsConnected](class_tale_worlds_1_1_network_1_1_network_session.html#a21d82fdc11a427768214216170e888dc) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Member Functions inherited from [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html) | |
| delegate void | [ComponentMessageHandlerDelegate](class_tale_worlds_1_1_network_1_1_network_session.html#a90f1840086da534f0573d1f754ba06f7) ([NetworkMessage](class_tale_worlds_1_1_network_1_1_network_message.html) networkMessage) |
| void | [SendDisconnectMessage](class_tale_worlds_1_1_network_1_1_network_session.html#a64b84161e6616d2019be107db0265001) () |
| virtual void | [Tick](class_tale_worlds_1_1_network_1_1_network_session.html#ad9889399a169e0c07c4a9da0250c00af) () |
| void | [AddMessageHandler< T >](class_tale_worlds_1_1_network_1_1_network_session.html#a5b6018b291bcc9384972caa5b2ab0c3a) (MessageContractHandlerDelegate< T > handler) |
| void | [SendMessage](class_tale_worlds_1_1_network_1_1_network_session.html#adf152e7d4d1abcf97446904c2bdf53d5) ([MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html) message) |
| Static Public Attributes inherited from [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html) | |
| const double | [AliveMessageIntervalInSecs](class_tale_worlds_1_1_network_1_1_network_session.html#a4d9512b828622058d5c9703b88cb41b8) = 5.0 |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_network_1_1_serverside_session.html#a40dbeeb318835a37111c6cb9d8799026)ServersideSession()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.Network.ServersideSession.ServersideSession | ( | [ServersideSessionManager](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html) | *server* | ) |  | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_network_1_1_serverside_session.html#accf144ed3df41a5184dd682c80836ea1)Index
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Network.ServersideSession.Index | | get |

