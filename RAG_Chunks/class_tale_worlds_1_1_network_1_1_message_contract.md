--- SOURCE: class_tale_worlds_1_1_network_1_1_message_contract.html ---

TaleWorlds.Network.MessageContract Class Referenceabstract|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SerializeToNetworkMessage](class_tale_worlds_1_1_network_1_1_message_contract.html#ac2161be347a97fe2db219966ccce7d77) ([INetworkMessageWriter](interface_tale_worlds_1_1_network_1_1_i_network_message_writer.html) networkMessage) |
| void | [DeserializeFromNetworkMessage](class_tale_worlds_1_1_network_1_1_message_contract.html#a3659c8e3c13329b9a144427cf7dcc768) ([INetworkMessageReader](interface_tale_worlds_1_1_network_1_1_i_network_message_reader.html) networkMessage) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html#aacd39b2581b83d1dc6feb3f0995aabc0) | [CreateMessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html#a4999cb5f75a4d6039f90b1a1cabdf6d6) (Type messageContractType) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html#aacd39b2581b83d1dc6feb3f0995aabc0) () |

|  |  |
| --- | --- |
| Properties | |
| byte | [MessageId](class_tale_worlds_1_1_network_1_1_message_contract.html#a4ebbdd5dc93836d0a3ed5c0a89e25e63) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_network_1_1_message_contract.html#aacd39b2581b83d1dc6feb3f0995aabc0)MessageContract()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.Network.MessageContract.MessageContract | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_network_1_1_message_contract.html#a4999cb5f75a4d6039f90b1a1cabdf6d6)CreateMessageContract()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [MessageContract](class_tale_worlds_1_1_network_1_1_message_contract.html#aacd39b2581b83d1dc6feb3f0995aabc0) TaleWorlds.Network.MessageContract.CreateMessageContract | ( | Type | *messageContractType* | ) |  | | static |

[◆](class_tale_worlds_1_1_network_1_1_message_contract.html#ac2161be347a97fe2db219966ccce7d77)SerializeToNetworkMessage()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Network.MessageContract.SerializeToNetworkMessage | ( | [INetworkMessageWriter](interface_tale_worlds_1_1_network_1_1_i_network_message_writer.html) | *networkMessage* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_network_1_1_message_contract.html#a3659c8e3c13329b9a144427cf7dcc768)DeserializeFromNetworkMessage()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Network.MessageContract.DeserializeFromNetworkMessage | ( | [INetworkMessageReader](interface_tale_worlds_1_1_network_1_1_i_network_message_reader.html) | *networkMessage* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_network_1_1_message_contract.html#a4ebbdd5dc93836d0a3ed5c0a89e25e63)MessageId
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | byte TaleWorlds.Network.MessageContract.MessageId | | get |

