--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html ---

TaleWorlds.MountAndBlade.MBMultiplayerData Class ReferenceMultiplayerData provides functionality to mod creator about multi player data content.

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [GameServerInfoReceivedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a55ca4373a8bd490aeff2bfc79b206915) (CustomBattleId id, string gameServer, string gameModule, string gameType, string map, int currentPlayerCount, int maxPlayerCount, string address, int port) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [GetServerId](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a48294cb66c1a1f51f38cbcb44356dc66) () |
| static string | [GetServerName](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a108358aa270cc302af1dc12824b2557a) () |
| static string | [GetGameModule](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#ae7f6d4398e63960d1c9c8677f62a28c7) () |
| static string | [GetGameType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a72711d701aad4b3edf21e4b8e33a0e55) () |
| static string | [GetMap](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a319186b0abb0c86e804710882b57fe76) () |
| static int | [GetCurrentPlayerCount](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a7154af4814f062dfe3d836f31ff93d39) () |
| static int | [GetPlayerCountLimit](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a5a8f2da9ed0cdeaa5c602653c3191af4) () |
| static void | [UpdateGameServerInfo](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#afc3c9a533123e6d76fa09412a64f97b1) (string id, string gameServer, string gameModule, string gameType, string map, int currentPlayerCount, int maxPlayerCount, string address, int port) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static string | [ServerName](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a39a8b0c2daa7c3f12dbab80e5964ad1f) |
| static string | [GameModule](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a2f8f0dad3fa5d5a34547b19603ed02a8) |
| static string | [GameType](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#aa930f334185a7661312db7a5e2c45246) |
| static string | [Map](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#ab57b12c288b838e2dd29247d234113b7) |
| static int | [PlayerCountLimit](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a26e1e5f2be783d18f12cc4ba25a87201) |

|  |  |
| --- | --- |
| Properties | |
| static Guid | [ServerId](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a460a9ed8f26cec81750bb06c5674ebad) `[get, set]` |

|  |  |
| --- | --- |
| Events | |
| static [GameServerInfoReceivedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a55ca4373a8bd490aeff2bfc79b206915) | [GameServerInfoReceived](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a075b26b717f9bee0ecab88d037ee3f3d) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a48294cb66c1a1f51f38cbcb44356dc66)GetServerId()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBMultiplayerData.GetServerId | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a108358aa270cc302af1dc12824b2557a)GetServerName()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBMultiplayerData.GetServerName | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#ae7f6d4398e63960d1c9c8677f62a28c7)GetGameModule()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBMultiplayerData.GetGameModule | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a72711d701aad4b3edf21e4b8e33a0e55)GetGameType()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBMultiplayerData.GetGameType | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a319186b0abb0c86e804710882b57fe76)GetMap()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBMultiplayerData.GetMap | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a7154af4814f062dfe3d836f31ff93d39)GetCurrentPlayerCount()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBMultiplayerData.GetCurrentPlayerCount | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a5a8f2da9ed0cdeaa5c602653c3191af4)GetPlayerCountLimit()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.MBMultiplayerData.GetPlayerCountLimit | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a55ca4373a8bd490aeff2bfc79b206915)GameServerInfoReceivedDelegate()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.MBMultiplayerData.GameServerInfoReceivedDelegate | ( | CustomBattleId | *id*, |
|  |  | string | *gameServer*, |
|  |  | string | *gameModule*, |
|  |  | string | *gameType*, |
|  |  | string | *map*, |
|  |  | int | *currentPlayerCount*, |
|  |  | int | *maxPlayerCount*, |
|  |  | string | *address*, |
|  |  | int | *port* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#afc3c9a533123e6d76fa09412a64f97b1)UpdateGameServerInfo()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMultiplayerData.UpdateGameServerInfo | ( | string | *id*, | |  |  | string | *gameServer*, | |  |  | string | *gameModule*, | |  |  | string | *gameType*, | |  |  | string | *map*, | |  |  | int | *currentPlayerCount*, | |  |  | int | *maxPlayerCount*, | |  |  | string | *address*, | |  |  | int | *port* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a39a8b0c2daa7c3f12dbab80e5964ad1f)ServerName
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MBMultiplayerData.ServerName | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a2f8f0dad3fa5d5a34547b19603ed02a8)GameModule
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MBMultiplayerData.GameModule | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#aa930f334185a7661312db7a5e2c45246)GameType
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MBMultiplayerData.GameType | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#ab57b12c288b838e2dd29247d234113b7)Map
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.MBMultiplayerData.Map | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a26e1e5f2be783d18f12cc4ba25a87201)PlayerCountLimit
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MBMultiplayerData.PlayerCountLimit | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a460a9ed8f26cec81750bb06c5674ebad)ServerId
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Guid TaleWorlds.MountAndBlade.MBMultiplayerData.ServerId | | staticgetset |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a075b26b717f9bee0ecab88d037ee3f3d)GameServerInfoReceived
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameServerInfoReceivedDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_multiplayer_data.html#a55ca4373a8bd490aeff2bfc79b206915) TaleWorlds.MountAndBlade.MBMultiplayerData.GameServerInfoReceived | | static |

