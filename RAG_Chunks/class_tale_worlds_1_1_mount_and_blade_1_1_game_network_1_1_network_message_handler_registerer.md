--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html ---

TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegisterer Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [RegisterMode](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588) {     [Add](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588aec211f7c20af43e742bf2570c3cb84f9) ,     [Remove](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588a1063e38cb53d94d386f21227fcd84717)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NetworkMessageHandlerRegisterer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#aede4e2a785974e0f984c78ce69bc19d4) ([RegisterMode](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588) definitionMode) |
| void | [Register< T >](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#ae92c4ab45f8f05de5788d76c2102f028) (GameNetworkMessage.ServerMessageHandlerDelegate< T > handler) |
| void | [RegisterBaseHandler< T >](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a21b41a3cf3c7695025430d7fc31ead58) (GameNetworkMessage.ServerMessageHandlerDelegate< [GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) > handler) |
| void | [Register< T >](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a6a923fec947c6b04cce70283af8d7bc7) (GameNetworkMessage.ClientMessageHandlerDelegate< T > handler) |
| void | [RegisterBaseHandler< T >](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#aac326806bda83ca92ed2d24e40cc68d2) (GameNetworkMessage.ClientMessageHandlerDelegate< [GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) > handler) |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588)RegisterMode
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegisterer.RegisterMode](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588) |

| Enumerator | |
| --- | --- |
| Add |  |
| Remove |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#aede4e2a785974e0f984c78ce69bc19d4)NetworkMessageHandlerRegisterer()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegisterer.NetworkMessageHandlerRegisterer | ( | [RegisterMode](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a1af3e90a708db3fa84173e6172680588) | *definitionMode* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#ae92c4ab45f8f05de5788d76c2102f028)Register< T >() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegisterer.Register< T > | ( | GameNetworkMessage.ServerMessageHandlerDelegate< T > | *handler* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *GameNetworkMessage* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a21b41a3cf3c7695025430d7fc31ead58)RegisterBaseHandler< T >() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegisterer.RegisterBaseHandler< T > | ( | GameNetworkMessage.ServerMessageHandlerDelegate< [GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) > | *handler* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *GameNetworkMessage* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#a6a923fec947c6b04cce70283af8d7bc7)Register< T >() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegisterer.Register< T > | ( | GameNetworkMessage.ClientMessageHandlerDelegate< T > | *handler* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *GameNetworkMessage* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer.html#aac326806bda83ca92ed2d24e40cc68d2)RegisterBaseHandler< T >() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegisterer.RegisterBaseHandler< T > | ( | GameNetworkMessage.ClientMessageHandlerDelegate< [GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) > | *handler* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *GameNetworkMessage* |  |

