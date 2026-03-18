--- SOURCE: class_tale_worlds_1_1_network_1_1_message_info.html ---

TaleWorlds.Network.MessageInfo Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [WriteTo](class_tale_worlds_1_1_network_1_1_message_info.html#a4df3c00c2da24fa535490db64da8883c) (Stream stream, bool fromServer) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MessageInfo](class_tale_worlds_1_1_network_1_1_message_info.html) | [ReadFrom](class_tale_worlds_1_1_network_1_1_message_info.html#acf3c6d33acbfbdb1a2c87f5063bfe8cd) (Stream stream, bool fromServer) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [DestinationIsPostBox](class_tale_worlds_1_1_network_1_1_message_info.html#a3cfce3ebec7a1d0f2f7678a2788c4c8e) = true |
|  | whether destination is set by [PostBoxId](class_tale_worlds_1_1_network_1_1_post_box_id.html) or ClientId |

|  |  |
| --- | --- |
| Properties | |
| string | [SourceIPAddress](class_tale_worlds_1_1_network_1_1_message_info.html#aade04b27ef77f2cfce4bad5729cf6f96) `[get, set]` |
|  | to be set by message bus |
| Guid | [SourceClientId](class_tale_worlds_1_1_network_1_1_message_info.html#a3aee16c33d320a79a517fca6c858bfa6) `[get, set]` |
|  | to be set by message bus |
| string | [SourceUserName](class_tale_worlds_1_1_network_1_1_message_info.html#a20f21cec91509009530f638b427db85e) `[get, set]` |
|  | to be set by message bus |
| string | [SourcePlatform](class_tale_worlds_1_1_network_1_1_message_info.html#a7068ab6d7444d7c3a47b4ee8c99019d2) `[get, set]` |
|  | to be set by message bus |
| string | [SourcePlatformId](class_tale_worlds_1_1_network_1_1_message_info.html#adaa321d6601ab2feead019a61ca9902f) `[get, set]` |
|  | to be set by message bus |
| string | [DestinationPostBox](class_tale_worlds_1_1_network_1_1_message_info.html#a71259c579c83d4531963185b1fc95f38) `[get, set]` |
| Guid | [DestinationClientId](class_tale_worlds_1_1_network_1_1_message_info.html#aed704ffd0188373a7c92c2b08b1e2138) `[get, set]` |
|  | to be set by message bus |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_network_1_1_message_info.html#a4df3c00c2da24fa535490db64da8883c)WriteTo()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Network.MessageInfo.WriteTo | ( | Stream | *stream*, |
|  |  | bool | *fromServer* ) |

[◆](class_tale_worlds_1_1_network_1_1_message_info.html#acf3c6d33acbfbdb1a2c87f5063bfe8cd)ReadFrom()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MessageInfo](class_tale_worlds_1_1_network_1_1_message_info.html) TaleWorlds.Network.MessageInfo.ReadFrom | ( | Stream | *stream*, | |  |  | bool | *fromServer* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_network_1_1_message_info.html#a3cfce3ebec7a1d0f2f7678a2788c4c8e)DestinationIsPostBox
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.Network.MessageInfo.DestinationIsPostBox = true |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_network_1_1_message_info.html#aade04b27ef77f2cfce4bad5729cf6f96)SourceIPAddress
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Network.MessageInfo.SourceIPAddress | | getset |

[◆](class_tale_worlds_1_1_network_1_1_message_info.html#a3aee16c33d320a79a517fca6c858bfa6)SourceClientId
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Guid TaleWorlds.Network.MessageInfo.SourceClientId | | getset |

[◆](class_tale_worlds_1_1_network_1_1_message_info.html#a20f21cec91509009530f638b427db85e)SourceUserName
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Network.MessageInfo.SourceUserName | | getset |

[◆](class_tale_worlds_1_1_network_1_1_message_info.html#a7068ab6d7444d7c3a47b4ee8c99019d2)SourcePlatform
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Network.MessageInfo.SourcePlatform | | getset |

[◆](class_tale_worlds_1_1_network_1_1_message_info.html#adaa321d6601ab2feead019a61ca9902f)SourcePlatformId
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Network.MessageInfo.SourcePlatformId | | getset |

[◆](class_tale_worlds_1_1_network_1_1_message_info.html#a71259c579c83d4531963185b1fc95f38)DestinationPostBox
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Network.MessageInfo.DestinationPostBox | | getset |

[◆](class_tale_worlds_1_1_network_1_1_message_info.html#aed704ffd0188373a7c92c2b08b1e2138)DestinationClientId
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Guid TaleWorlds.Network.MessageInfo.DestinationClientId | | getset |

