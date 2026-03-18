--- SOURCE: class_tale_worlds_1_1_network_1_1_message_service_connection.html ---

TaleWorlds.Network.MessageServiceConnection Class Referenceabstract|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MessageServiceConnection](class_tale_worlds_1_1_network_1_1_message_service_connection.html#af782f3e5558faea6bf3b128ae7182dbc) () |
| Task | [SendAsync](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a63adf0277b1e669cf516d79f3c09d8f5) (string text) |
| void | [Init](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a213d195e875817837355057a040877dd) (string address, string token) |
| delegate Task | [ClosedDelegate](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a703056218f10599e2dd1d9206913c746) () |
| delegate void | [StateChangedDelegate](class_tale_worlds_1_1_network_1_1_message_service_connection.html#ad6b3f7eef3e9bab5e4cd7ca77a762490) ([ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) oldState, [ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) newState) |
| void | [RegisterProxyClient](class_tale_worlds_1_1_network_1_1_message_service_connection.html#aa22a970c6ed63aa389e69e37319389f2) (string name, [IMessageProxyClient](interface_tale_worlds_1_1_network_1_1_i_message_proxy_client.html) playerClient) |
| Task | [StartAsync](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a10076952edffb00261fd1612a2a1a5c0) () |
| Task | [StopAsync](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a1832289fa1af3f170c235c572820dcd8) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) | [State](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a527eb2c76eb109e1cb61d980f403c73e) |
| [ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) | [OldState](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a2fa954ed290f35a42ac5f44d90b100b8) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [InvokeClosed](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a9ce9be8ac3169b1fb77f8ddadca531f4) () |
| void | [InvokeStateChanged](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a1901080b5c25c3b4d99838e806553834) ([ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) oldState, [ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) newState) |

|  |  |
| --- | --- |
| Properties | |
| string | [Address](class_tale_worlds_1_1_network_1_1_message_service_connection.html#ad4f81bb030981b5f28f7d6bdfab2c76d) `[get, protected set]` |

|  |  |
| --- | --- |
| Events | |
| [ClosedDelegate](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a703056218f10599e2dd1d9206913c746) | [Closed](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a032ce96db73ab1ab978ea5f98dd46797) |
| [StateChangedDelegate](class_tale_worlds_1_1_network_1_1_message_service_connection.html#ad6b3f7eef3e9bab5e4cd7ca77a762490) | [StateChanged](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a17c2ba2cdda93be80bf1fa6059cf500a) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#af782f3e5558faea6bf3b128ae7182dbc)MessageServiceConnection()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Network.MessageServiceConnection.MessageServiceConnection | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a63adf0277b1e669cf516d79f3c09d8f5)SendAsync()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Task TaleWorlds.Network.MessageServiceConnection.SendAsync | ( | string | *text* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a213d195e875817837355057a040877dd)Init()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Network.MessageServiceConnection.Init | ( | string | *address*, | |  |  | string | *token* ) | | abstract |

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a703056218f10599e2dd1d9206913c746)ClosedDelegate()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| delegate Task TaleWorlds.Network.MessageServiceConnection.ClosedDelegate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#ad6b3f7eef3e9bab5e4cd7ca77a762490)StateChangedDelegate()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.Network.MessageServiceConnection.StateChangedDelegate | ( | [ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) | *oldState*, |
|  |  | [ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) | *newState* ) |

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#aa22a970c6ed63aa389e69e37319389f2)RegisterProxyClient()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Network.MessageServiceConnection.RegisterProxyClient | ( | string | *name*, | |  |  | [IMessageProxyClient](interface_tale_worlds_1_1_network_1_1_i_message_proxy_client.html) | *playerClient* ) | | abstract |

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a10076952edffb00261fd1612a2a1a5c0)StartAsync()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | Task TaleWorlds.Network.MessageServiceConnection.StartAsync | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a1832289fa1af3f170c235c572820dcd8)StopAsync()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | Task TaleWorlds.Network.MessageServiceConnection.StopAsync | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a9ce9be8ac3169b1fb77f8ddadca531f4)InvokeClosed()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Network.MessageServiceConnection.InvokeClosed | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a1901080b5c25c3b4d99838e806553834)InvokeStateChanged()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Network.MessageServiceConnection.InvokeStateChanged | ( | [ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) | *oldState*, | |  |  | [ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) | *newState* ) | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a527eb2c76eb109e1cb61d980f403c73e)State
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) TaleWorlds.Network.MessageServiceConnection.State |

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a2fa954ed290f35a42ac5f44d90b100b8)OldState
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ConnectionState](namespace_tale_worlds_1_1_network.html#ae7cb80b5b85cccf4a2180b348946c23a) TaleWorlds.Network.MessageServiceConnection.OldState |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#ad4f81bb030981b5f28f7d6bdfab2c76d)Address
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Network.MessageServiceConnection.Address | | getprotected set |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a032ce96db73ab1ab978ea5f98dd46797)Closed
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ClosedDelegate](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a703056218f10599e2dd1d9206913c746) TaleWorlds.Network.MessageServiceConnection.Closed |

[◆](class_tale_worlds_1_1_network_1_1_message_service_connection.html#a17c2ba2cdda93be80bf1fa6059cf500a)StateChanged
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [StateChangedDelegate](class_tale_worlds_1_1_network_1_1_message_service_connection.html#ad6b3f7eef3e9bab5e4cd7ca77a762490) TaleWorlds.Network.MessageServiceConnection.StateChanged |

