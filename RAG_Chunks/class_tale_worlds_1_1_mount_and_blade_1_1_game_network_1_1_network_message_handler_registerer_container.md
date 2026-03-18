--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html ---

TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegistererContainer Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NetworkMessageHandlerRegistererContainer](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#ab7a300110527f1ca324efb72d0e9fdd8) () |
| void | [RegisterBaseHandler< T >](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#af97a01c04a21cb6af00e6db33a5b7021) (GameNetworkMessage.ServerMessageHandlerDelegate< [GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) > handler) |
| void | [Register< T >](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#a31d1994303da002f7d8eb91875e86484) (GameNetworkMessage.ServerMessageHandlerDelegate< T > handler) |
| void | [RegisterBaseHandler< T >](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#ab0af9bbab61cd2255a169543afc97644) (GameNetworkMessage.ClientMessageHandlerDelegate< [GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) > handler) |
| void | [Register< T >](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#aded16ff24c2d2aa5bc7d76cfec6b55a5) (GameNetworkMessage.ClientMessageHandlerDelegate< T > handler) |
| void | [RegisterMessages](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#ad7c90cd49cdbec3bd54a2644631213b4) () |
| void | [UnregisterMessages](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#a211904fbed883c186d636cd88cf94c12) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#ab7a300110527f1ca324efb72d0e9fdd8)NetworkMessageHandlerRegistererContainer()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegistererContainer.NetworkMessageHandlerRegistererContainer | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#af97a01c04a21cb6af00e6db33a5b7021)RegisterBaseHandler< T >() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegistererContainer.RegisterBaseHandler< T > | ( | GameNetworkMessage.ServerMessageHandlerDelegate< [GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) > | *handler* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *GameNetworkMessage* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#a31d1994303da002f7d8eb91875e86484)Register< T >() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegistererContainer.Register< T > | ( | GameNetworkMessage.ServerMessageHandlerDelegate< T > | *handler* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *GameNetworkMessage* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#ab0af9bbab61cd2255a169543afc97644)RegisterBaseHandler< T >() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegistererContainer.RegisterBaseHandler< T > | ( | GameNetworkMessage.ClientMessageHandlerDelegate< [GameNetworkMessage](class_tale_worlds_1_1_mount_and_blade_1_1_network_1_1_messages_1_1_game_network_message.html) > | *handler* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#aded16ff24c2d2aa5bc7d76cfec6b55a5)Register< T >() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegistererContainer.Register< T > | ( | GameNetworkMessage.ClientMessageHandlerDelegate< T > | *handler* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *GameNetworkMessage* |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#ad7c90cd49cdbec3bd54a2644631213b4)RegisterMessages()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegistererContainer.RegisterMessages | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_game_network_1_1_network_message_handler_registerer_container.html#a211904fbed883c186d636cd88cf94c12)UnregisterMessages()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GameNetwork.NetworkMessageHandlerRegistererContainer.UnregisterMessages | ( |  | ) |  |

