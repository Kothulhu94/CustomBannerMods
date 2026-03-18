--- SOURCE: class_tale_worlds_1_1_network_1_1_web_socket_message.html ---

TaleWorlds.Network.WebSocketMessage Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a9d242aa235fa8b1e7b2c113d6ce9e806) () |
| void | [SetTextPayload](class_tale_worlds_1_1_network_1_1_web_socket_message.html#ae7515e35f7206b8c6d8964ea497e91bf) (string payload) |
| void | [WriteTo](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a3fe4a4e7b0e5772e40ffe37ee27f6ee0) (bool fromServer, Stream stream) |
| int | [GetCursor](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a35cbe1a4bf8adba8b07fb15299f0264d) () |
|  | Reads cursor from the payload of a cursor message, this is not the cursor of the message!! |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a9d242aa235fa8b1e7b2c113d6ce9e806) | [ReadFrom](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a4f4a1fc146c1d2de3aa1b80b51f8c933) (bool fromServer, byte[] payload) |
| static [WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a9d242aa235fa8b1e7b2c113d6ce9e806) | [ReadFrom](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a0cfb9b4d672cf5cb9d9afb092f52eae1) (bool fromServer, Stream stream) |
| static [WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a9d242aa235fa8b1e7b2c113d6ce9e806) | [CreateCursorMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#af97259817de2f8b6737e954a233987ac) (int cursor) |
| static [WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a9d242aa235fa8b1e7b2c113d6ce9e806) | [CreateCloseMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a5e1be0e924f15f2cf2f69b8b5a60ebd3) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static Encoding | [Encoding](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a1991b8c1b869468d6990f484d0eb2175) = UTF8Encoding.UTF8 |

|  |  |
| --- | --- |
| Properties | |
| byte[] | [Payload](class_tale_worlds_1_1_network_1_1_web_socket_message.html#ac87eda2234cbe544ab043982e7d6fddd) `[get, set]` |
| MessageInfo | [MessageInfo](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a6d41f669ae0aa85d6092f6788d3095dc) `[get, set]` |
| int | [Cursor](class_tale_worlds_1_1_network_1_1_web_socket_message.html#aea6290831ef2756d5a61bb1cf05de170) `[get, set]` |
|  | to be set by socket handler |
| [MessageTypes](namespace_tale_worlds_1_1_network.html#a3d526cacfeda080b42cfd66bfb904059) | [MessageType](class_tale_worlds_1_1_network_1_1_web_socket_message.html#aa83d645f92e9f5b8795c912f76fbf455) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a9d242aa235fa8b1e7b2c113d6ce9e806)WebSocketMessage()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Network.WebSocketMessage.WebSocketMessage | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#ae7515e35f7206b8c6d8964ea497e91bf)SetTextPayload()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Network.WebSocketMessage.SetTextPayload | ( | string | *payload* | ) |  |

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a3fe4a4e7b0e5772e40ffe37ee27f6ee0)WriteTo()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Network.WebSocketMessage.WriteTo | ( | bool | *fromServer*, |
|  |  | Stream | *stream* ) |

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a4f4a1fc146c1d2de3aa1b80b51f8c933)ReadFrom() [1/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a9d242aa235fa8b1e7b2c113d6ce9e806) TaleWorlds.Network.WebSocketMessage.ReadFrom | ( | bool | *fromServer*, | |  |  | byte[] | *payload* ) | | static |

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a0cfb9b4d672cf5cb9d9afb092f52eae1)ReadFrom() [2/2]
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a9d242aa235fa8b1e7b2c113d6ce9e806) TaleWorlds.Network.WebSocketMessage.ReadFrom | ( | bool | *fromServer*, | |  |  | Stream | *stream* ) | | static |

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#af97259817de2f8b6737e954a233987ac)CreateCursorMessage()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a9d242aa235fa8b1e7b2c113d6ce9e806) TaleWorlds.Network.WebSocketMessage.CreateCursorMessage | ( | int | *cursor* | ) |  | | static |

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a5e1be0e924f15f2cf2f69b8b5a60ebd3)CreateCloseMessage()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [WebSocketMessage](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a9d242aa235fa8b1e7b2c113d6ce9e806) TaleWorlds.Network.WebSocketMessage.CreateCloseMessage | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a35cbe1a4bf8adba8b07fb15299f0264d)GetCursor()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Network.WebSocketMessage.GetCursor | ( |  | ) |  |

Returns

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a1991b8c1b869468d6990f484d0eb2175)Encoding
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Encoding TaleWorlds.Network.WebSocketMessage.Encoding = UTF8Encoding.UTF8 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#ac87eda2234cbe544ab043982e7d6fddd)Payload
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | byte [] TaleWorlds.Network.WebSocketMessage.Payload | | getset |

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#a6d41f669ae0aa85d6092f6788d3095dc)MessageInfo
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MessageInfo TaleWorlds.Network.WebSocketMessage.MessageInfo | | getset |

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#aea6290831ef2756d5a61bb1cf05de170)Cursor
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Network.WebSocketMessage.Cursor | | getset |

[◆](class_tale_worlds_1_1_network_1_1_web_socket_message.html#aa83d645f92e9f5b8795c912f76fbf455)MessageType
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MessageTypes](namespace_tale_worlds_1_1_network.html#a3d526cacfeda080b42cfd66bfb904059) TaleWorlds.Network.WebSocketMessage.MessageType | | getset |

