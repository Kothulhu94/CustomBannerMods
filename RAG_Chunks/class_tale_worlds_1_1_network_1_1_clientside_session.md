--- SOURCE: class_tale_worlds_1_1_network_1_1_clientside_session.html ---

TaleWorlds.Network.ClientsideSession Class ReferenceabstractInherits [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [Connect](class_tale_worlds_1_1_network_1_1_clientside_session.html#a1c2f41a7476b9fe094808b0d71d43546) (string ip, int port, bool useSessionThread=true) |
| void | [Process](class_tale_worlds_1_1_network_1_1_clientside_session.html#a9c7cde093c8e191836d8bc9e1189db8c) () |
| override void | [Tick](class_tale_worlds_1_1_network_1_1_clientside_session.html#a700a0ccc368a83f8b52c6373a8fb4d89) () |
| Public Member Functions inherited from [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html) | |
| delegate void | [ComponentMessageHandlerDelegate](class_tale_worlds_1_1_network_1_1_network_session.html#a90f1840086da534f0573d1f754ba06f7) ([NetworkMessage](class_tale_worlds_1_1_network_1_1_network_message.html) networkMessage) |
| void | [SendDisconnectMessage](class_tale_worlds_1_1_network_1_1_network_session.html#a64b84161e6616d2019be107db0265001) () |
| void | [AddMessageHandler< T >](class_tale_worlds_1_1_network_1_1_network_session.html#a5b6018b291bcc9384972caa5b2ab0c3a) (MessageContractHandlerDelegate< T > handler) |
| void | [SendMessage](class_tale_worlds_1_1_network_1_1_network_session.html#adf152e7d4d1abcf97446904c2bdf53d5) ([MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html) message) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [SendMessagePeerAlive](class_tale_worlds_1_1_network_1_1_clientside_session.html#ad53e818060975affa21d28091035c410) () |
|  | [ClientsideSession](class_tale_worlds_1_1_network_1_1_clientside_session.html#a979fe2818c780be45eb78fa136ce12bf) () |
| Protected Member Functions inherited from [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html) | |
|  | [NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html#a63a124709e7ece031a559c3a9cbb13eb) () |
| void | [SendPlainMessage](class_tale_worlds_1_1_network_1_1_network_session.html#acab09623f2044497643b6e90091ee46b) ([MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html) message) |

|  |  |
| --- | --- |
| Properties | |
| int | [Port](class_tale_worlds_1_1_network_1_1_clientside_session.html#a38782dc01b3c64aa42baa93367de466b) `[get, set]` |
| Properties inherited from [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html) | |
| bool | [IsActive](class_tale_worlds_1_1_network_1_1_network_session.html#a6a61cf4af302c949c33cc1ffc9962aa2) `[get]` |
| string | [Address](class_tale_worlds_1_1_network_1_1_network_session.html#a316f5fb548268c475312884cba6b7f62) `[get]` |
| int | [LastMessageSentTime](class_tale_worlds_1_1_network_1_1_network_session.html#a3e6fad2e885a34288a6e48cc5aab458f) `[get]` |
| bool | [IsConnected](class_tale_worlds_1_1_network_1_1_network_session.html#a21d82fdc11a427768214216170e888dc) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Attributes inherited from [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html) | |
| const double | [AliveMessageIntervalInSecs](class_tale_worlds_1_1_network_1_1_network_session.html#a4d9512b828622058d5c9703b88cb41b8) = 5.0 |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_network_1_1_clientside_session.html#a979fe2818c780be45eb78fa136ce12bf)ClientsideSession()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.Network.ClientsideSession.ClientsideSession | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_network_1_1_clientside_session.html#ad53e818060975affa21d28091035c410)SendMessagePeerAlive()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Network.ClientsideSession.SendMessagePeerAlive | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_network_1_1_clientside_session.html#a1c2f41a7476b9fe094808b0d71d43546)Connect()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.Network.ClientsideSession.Connect | ( | string | *ip*, | |  |  | int | *port*, | |  |  | bool | *useSessionThread* = true ) | | virtual |

[◆](class_tale_worlds_1_1_network_1_1_clientside_session.html#a9c7cde093c8e191836d8bc9e1189db8c)Process()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Network.ClientsideSession.Process | ( |  | ) |  |

[◆](class_tale_worlds_1_1_network_1_1_clientside_session.html#a700a0ccc368a83f8b52c6373a8fb4d89)Tick()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Network.ClientsideSession.Tick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Network.NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html#ad9889399a169e0c07c4a9da0250c00af).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_network_1_1_clientside_session.html#a38782dc01b3c64aa42baa93367de466b)Port
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Network.ClientsideSession.Port | | getset |

