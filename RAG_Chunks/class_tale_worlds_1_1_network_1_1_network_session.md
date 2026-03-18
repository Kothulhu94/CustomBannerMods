--- SOURCE: class_tale_worlds_1_1_network_1_1_network_session.html ---

TaleWorlds.Network.NetworkSession Class ReferenceabstractInherited by [TaleWorlds.Network.ClientsideSession](class_tale_worlds_1_1_network_1_1_clientside_session.html), and [TaleWorlds.Network.ServersideSession](class_tale_worlds_1_1_network_1_1_serverside_session.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [ComponentMessageHandlerDelegate](class_tale_worlds_1_1_network_1_1_network_session.html#a90f1840086da534f0573d1f754ba06f7) ([NetworkMessage](class_tale_worlds_1_1_network_1_1_network_message.html) networkMessage) |
| void | [SendDisconnectMessage](class_tale_worlds_1_1_network_1_1_network_session.html#a64b84161e6616d2019be107db0265001) () |
| virtual void | [Tick](class_tale_worlds_1_1_network_1_1_network_session.html#ad9889399a169e0c07c4a9da0250c00af) () |
| void | [AddMessageHandler< T >](class_tale_worlds_1_1_network_1_1_network_session.html#a5b6018b291bcc9384972caa5b2ab0c3a) (MessageContractHandlerDelegate< T > handler) |
| void | [SendMessage](class_tale_worlds_1_1_network_1_1_network_session.html#adf152e7d4d1abcf97446904c2bdf53d5) ([MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html) message) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const double | [AliveMessageIntervalInSecs](class_tale_worlds_1_1_network_1_1_network_session.html#a4d9512b828622058d5c9703b88cb41b8) = 5.0 |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [NetworkSession](class_tale_worlds_1_1_network_1_1_network_session.html#a63a124709e7ece031a559c3a9cbb13eb) () |
| void | [SendPlainMessage](class_tale_worlds_1_1_network_1_1_network_session.html#acab09623f2044497643b6e90091ee46b) ([MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html) message) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsActive](class_tale_worlds_1_1_network_1_1_network_session.html#a6a61cf4af302c949c33cc1ffc9962aa2) `[get]` |
| string | [Address](class_tale_worlds_1_1_network_1_1_network_session.html#a316f5fb548268c475312884cba6b7f62) `[get]` |
| int | [LastMessageSentTime](class_tale_worlds_1_1_network_1_1_network_session.html#a3e6fad2e885a34288a6e48cc5aab458f) `[get]` |
| bool | [IsConnected](class_tale_worlds_1_1_network_1_1_network_session.html#a21d82fdc11a427768214216170e888dc) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#a63a124709e7ece031a559c3a9cbb13eb)NetworkSession()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.Network.NetworkSession.NetworkSession | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#a90f1840086da534f0573d1f754ba06f7)ComponentMessageHandlerDelegate()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.Network.NetworkSession.ComponentMessageHandlerDelegate | ( | [NetworkMessage](class_tale_worlds_1_1_network_1_1_network_message.html) | *networkMessage* | ) |  |

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#a64b84161e6616d2019be107db0265001)SendDisconnectMessage()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Network.NetworkSession.SendDisconnectMessage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#ad9889399a169e0c07c4a9da0250c00af)Tick()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Network.NetworkSession.Tick | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.Network.ClientsideSession](class_tale_worlds_1_1_network_1_1_clientside_session.html#a700a0ccc368a83f8b52c6373a8fb4d89).

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#a5b6018b291bcc9384972caa5b2ab0c3a)AddMessageHandler< T >()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Network.NetworkSession.AddMessageHandler< T > | ( | MessageContractHandlerDelegate< T > | *handler* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html)* |  |

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#adf152e7d4d1abcf97446904c2bdf53d5)SendMessage()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Network.NetworkSession.SendMessage | ( | [MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html) | *message* | ) |  |

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#acab09623f2044497643b6e90091ee46b)SendPlainMessage()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Network.NetworkSession.SendPlainMessage | ( | [MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html) | *message* | ) |  | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#a4d9512b828622058d5c9703b88cb41b8)AliveMessageIntervalInSecs
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const double TaleWorlds.Network.NetworkSession.AliveMessageIntervalInSecs = 5.0 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#a6a61cf4af302c949c33cc1ffc9962aa2)IsActive
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Network.NetworkSession.IsActive | | get |

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#a316f5fb548268c475312884cba6b7f62)Address
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Network.NetworkSession.Address | | get |

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#a3e6fad2e885a34288a6e48cc5aab458f)LastMessageSentTime
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Network.NetworkSession.LastMessageSentTime | | get |

[◆](class_tale_worlds_1_1_network_1_1_network_session.html#a21d82fdc11a427768214216170e888dc)IsConnected
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Network.NetworkSession.IsConnected | | get |

