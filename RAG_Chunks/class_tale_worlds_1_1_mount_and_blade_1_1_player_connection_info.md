--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html ---

TaleWorlds.MountAndBlade.PlayerConnectionInfo Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#ac29b788fc49356bbe450b722a9403a57) (PlayerId playerID) |
| void | [AddParameter](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a979545665d034453c687b9e1c4f3020e) (string name, object parameter) |
| T | [GetParameter< T >](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a734b1ac0b8699e91a2ffa25bebe9a3ed) (string name) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly PlayerId | [PlayerID](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a755b88a5aac7a1dab4bf8ae43bd55de1) |

|  |  |
| --- | --- |
| Properties | |
| int | [SessionKey](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a87aea03b6c40982a458f70b9822159b5) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a2e80b031eabfe1a6b571e7277b74fddf) `[get, set]` |
| [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | [NetworkPeer](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a12f614eed94721fc6fd089aa8a776462) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#ac29b788fc49356bbe450b722a9403a57)PlayerConnectionInfo()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.PlayerConnectionInfo.PlayerConnectionInfo | ( | PlayerId | *playerID* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a979545665d034453c687b9e1c4f3020e)AddParameter()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.PlayerConnectionInfo.AddParameter | ( | string | *name*, |
|  |  | object | *parameter* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a734b1ac0b8699e91a2ffa25bebe9a3ed)GetParameter< T >()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| T TaleWorlds.MountAndBlade.PlayerConnectionInfo.GetParameter< T > | ( | string | *name* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *class* |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a755b88a5aac7a1dab4bf8ae43bd55de1)PlayerID
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly PlayerId TaleWorlds.MountAndBlade.PlayerConnectionInfo.PlayerID |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a87aea03b6c40982a458f70b9822159b5)SessionKey
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.PlayerConnectionInfo.SessionKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a2e80b031eabfe1a6b571e7277b74fddf)Name
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.PlayerConnectionInfo.Name | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html#a12f614eed94721fc6fd089aa8a776462)NetworkPeer
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) TaleWorlds.MountAndBlade.PlayerConnectionInfo.NetworkPeer | | getset |

