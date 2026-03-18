--- SOURCE: class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html ---

TaleWorlds.Network.MessageContractHandlerManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MessageContractHandlerManager](class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html#ade847dd93adca6cd3f5c9166e0823125) () |
| void | [AddMessageHandler< T >](class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html#a56162282e5a95afa5545934ee36dca10) (MessageContractHandlerDelegate< T > handler) |
| void | [HandleMessage](class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html#a6ddaf1406c93be9f0842fe44fc1669ea) ([MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html) messageContract) |
| void | [HandleNetworkMessage](class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html#a91db909a9b8638dfa1fc6ed22faee674) ([NetworkMessage](class_tale_worlds_1_1_network_1_1_network_message.html) networkMessage) |
| bool | [ContainsMessageHandler](class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html#a7713d295657de1ce61707b07e6f611c6) (byte id) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html#ade847dd93adca6cd3f5c9166e0823125)MessageContractHandlerManager()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Network.MessageContractHandlerManager.MessageContractHandlerManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html#a56162282e5a95afa5545934ee36dca10)AddMessageHandler< T >()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Network.MessageContractHandlerManager.AddMessageHandler< T > | ( | MessageContractHandlerDelegate< T > | *handler* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html)* |  |

[◆](class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html#a6ddaf1406c93be9f0842fe44fc1669ea)HandleMessage()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Network.MessageContractHandlerManager.HandleMessage | ( | [MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html) | *messageContract* | ) |  |

[◆](class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html#a91db909a9b8638dfa1fc6ed22faee674)HandleNetworkMessage()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Network.MessageContractHandlerManager.HandleNetworkMessage | ( | [NetworkMessage](class_tale_worlds_1_1_network_1_1_network_message.html) | *networkMessage* | ) |  |

[◆](class_tale_worlds_1_1_network_1_1_message_contract_handler_manager.html#a7713d295657de1ce61707b07e6f611c6)ContainsMessageHandler()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Network.MessageContractHandlerManager.ContainsMessageHandler | ( | byte | *id* | ) |  |

