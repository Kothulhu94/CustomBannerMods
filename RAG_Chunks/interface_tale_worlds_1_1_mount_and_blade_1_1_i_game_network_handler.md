--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html ---

TaleWorlds.MountAndBlade.IGameNetworkHandler Interface Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnNewPlayerConnect](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a716f373fdc228faf345a8bb1cb31d540) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) playerConnectionInfo, [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) networkPeer) |
| void | [OnInitialize](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a5772ce6ea66338659947355a3a177638) () |
| void | [OnPlayerConnectedToServer](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#ac93bd76ded0da5b01258b28bc28b0af3) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) peer) |
| void | [OnPlayerDisconnectedFromServer](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#abcdcf52634f09a85d53615508fefb099) ([NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) peer) |
| void | [OnDisconnectedFromServer](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#ac45d04ce1fc2f5d9fdd6d909a5f3ad47) () |
| void | [OnStartMultiplayer](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#aa4a743a867d33e58bfb1e9f0a84901b9) () |
| void | [OnStartReplay](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a89810904d71f763fc45289358c5cda6c) () |
| void | [OnEndMultiplayer](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a389c0830f0def30a29bad0296fbf261a) () |
| void | [OnEndReplay](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a408bac43921d71e766ba52827926eeb7) () |
| void | [OnHandleConsoleCommand](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a78b48e87dba3ffeca1c05039f49f54a9) (string command) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a716f373fdc228faf345a8bb1cb31d540)OnNewPlayerConnect()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IGameNetworkHandler.OnNewPlayerConnect | ( | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_player_connection_info.html) | *playerConnectionInfo*, |
|  |  | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *networkPeer* ) |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a5772ce6ea66338659947355a3a177638)OnInitialize()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IGameNetworkHandler.OnInitialize | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#ac93bd76ded0da5b01258b28bc28b0af3)OnPlayerConnectedToServer()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IGameNetworkHandler.OnPlayerConnectedToServer | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *peer* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#abcdcf52634f09a85d53615508fefb099)OnPlayerDisconnectedFromServer()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IGameNetworkHandler.OnPlayerDisconnectedFromServer | ( | [NetworkCommunicator](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html) | *peer* | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#ac45d04ce1fc2f5d9fdd6d909a5f3ad47)OnDisconnectedFromServer()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IGameNetworkHandler.OnDisconnectedFromServer | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#aa4a743a867d33e58bfb1e9f0a84901b9)OnStartMultiplayer()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IGameNetworkHandler.OnStartMultiplayer | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a89810904d71f763fc45289358c5cda6c)OnStartReplay()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IGameNetworkHandler.OnStartReplay | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a389c0830f0def30a29bad0296fbf261a)OnEndMultiplayer()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IGameNetworkHandler.OnEndMultiplayer | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a408bac43921d71e766ba52827926eeb7)OnEndReplay()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IGameNetworkHandler.OnEndReplay | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_game_network_handler.html#a78b48e87dba3ffeca1c05039f49f54a9)OnHandleConsoleCommand()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.IGameNetworkHandler.OnHandleConsoleCommand | ( | string | *command* | ) |  |

