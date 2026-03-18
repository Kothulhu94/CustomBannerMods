--- SOURCE: class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html ---

TaleWorlds.Network.ClientWebSocketHandler Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [MessageReceivedDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a89139694d813a593ddfc1fae024bb6c2) ([WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html) message, [ClientWebSocketHandler](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#ac9646211c8c742447a76e1af753e999c) socket) |
| delegate void | [OnErrorDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a150ad885a5a7415d7b38975ae1c92b9a) ([ClientWebSocketHandler](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#ac9646211c8c742447a76e1af753e999c) sender, Exception ex) |
| delegate Task | [DisconnectedDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a07db91ba8a652332cfe2f4f3c78924d6) ([ClientWebSocketHandler](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#ac9646211c8c742447a76e1af753e999c) sender, bool onDisconnectCommand) |
| delegate Task | [ConnectedDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a1c6b5a3ab4c25ec2f525a73fa0cc3d9e) ([ClientWebSocketHandler](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#ac9646211c8c742447a76e1af753e999c) sender) |
|  | [ClientWebSocketHandler](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#ac9646211c8c742447a76e1af753e999c) () |
| async Task | [Connect](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a54995cc051b49c1f5b5876fb2371a815) (string uri, string token, List< KeyValuePair< string, string > > headers=null) |
| async Task | [Disconnect](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a6ca2a6095b9a2da5c6b71a7ed2a04ba8) (string reason, bool onDisconnectCommand) |
| void | [SendTextMessage](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#aca4dd4fef505eee8990c2cc4ec79ba0f) (string postBoxId, string text) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsConnected](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a61edb361188c8b1ace3c5bd33664d2fa) `[get]` |

|  |  |
| --- | --- |
| Events | |
| [MessageReceivedDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a89139694d813a593ddfc1fae024bb6c2) | [MessageReceived](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a869ddd6e10408331c7760e15e21be6f5) |
| [OnErrorDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a150ad885a5a7415d7b38975ae1c92b9a) | [OnError](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a91b7f79fdc1b98733c4325920a1dbbe9) |
| [DisconnectedDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a07db91ba8a652332cfe2f4f3c78924d6) | [Disconnected](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a6209aa37d792711466f90d20a5feb03b) |
| [ConnectedDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a1c6b5a3ab4c25ec2f525a73fa0cc3d9e) | [Connected](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a6796496b08296cf6036a1d64be3c43f2) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#ac9646211c8c742447a76e1af753e999c)ClientWebSocketHandler()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Network.ClientWebSocketHandler.ClientWebSocketHandler | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a89139694d813a593ddfc1fae024bb6c2)MessageReceivedDelegate()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.Network.ClientWebSocketHandler.MessageReceivedDelegate | ( | [WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html) | *message*, |
|  |  | [ClientWebSocketHandler](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#ac9646211c8c742447a76e1af753e999c) | *socket* ) |

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a150ad885a5a7415d7b38975ae1c92b9a)OnErrorDelegate()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.Network.ClientWebSocketHandler.OnErrorDelegate | ( | [ClientWebSocketHandler](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#ac9646211c8c742447a76e1af753e999c) | *sender*, |
|  |  | Exception | *ex* ) |

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a07db91ba8a652332cfe2f4f3c78924d6)DisconnectedDelegate()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate Task TaleWorlds.Network.ClientWebSocketHandler.DisconnectedDelegate | ( | [ClientWebSocketHandler](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#ac9646211c8c742447a76e1af753e999c) | *sender*, |
|  |  | bool | *onDisconnectCommand* ) |

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a1c6b5a3ab4c25ec2f525a73fa0cc3d9e)ConnectedDelegate()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate Task TaleWorlds.Network.ClientWebSocketHandler.ConnectedDelegate | ( | [ClientWebSocketHandler](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#ac9646211c8c742447a76e1af753e999c) | *sender* | ) |  |

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a54995cc051b49c1f5b5876fb2371a815)Connect()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| async Task TaleWorlds.Network.ClientWebSocketHandler.Connect | ( | string | *uri*, |
|  |  | string | *token*, |
|  |  | List< KeyValuePair< string, string > > | *headers* = null ) |

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a6ca2a6095b9a2da5c6b71a7ed2a04ba8)Disconnect()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| async Task TaleWorlds.Network.ClientWebSocketHandler.Disconnect | ( | string | *reason*, |
|  |  | bool | *onDisconnectCommand* ) |

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#aca4dd4fef505eee8990c2cc4ec79ba0f)SendTextMessage()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Network.ClientWebSocketHandler.SendTextMessage | ( | string | *postBoxId*, |
|  |  | string | *text* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a61edb361188c8b1ace3c5bd33664d2fa)IsConnected
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Network.ClientWebSocketHandler.IsConnected | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a869ddd6e10408331c7760e15e21be6f5)MessageReceived
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MessageReceivedDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a89139694d813a593ddfc1fae024bb6c2) TaleWorlds.Network.ClientWebSocketHandler.MessageReceived |

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a91b7f79fdc1b98733c4325920a1dbbe9)OnError
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnErrorDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a150ad885a5a7415d7b38975ae1c92b9a) TaleWorlds.Network.ClientWebSocketHandler.OnError |

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a6209aa37d792711466f90d20a5feb03b)Disconnected
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [DisconnectedDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a07db91ba8a652332cfe2f4f3c78924d6) TaleWorlds.Network.ClientWebSocketHandler.Disconnected |

[◆](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a6796496b08296cf6036a1d64be3c43f2)Connected
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ConnectedDelegate](class_tale_worlds_1_1_network_1_1_client_web_socket_handler.html#a1c6b5a3ab4c25ec2f525a73fa0cc3d9e) TaleWorlds.Network.ClientWebSocketHandler.Connected |

