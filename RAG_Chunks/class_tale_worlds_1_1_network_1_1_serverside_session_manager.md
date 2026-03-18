--- SOURCE: class_tale_worlds_1_1_network_1_1_serverside_session_manager.html ---

TaleWorlds.Network.ServersideSessionManager Class Referenceabstract|  |  |
| --- | --- |
| Public Types | |
| enum | [ThreadType](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a7a4884f71b1a8d40171c179a766f2804) {     [Single](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a7a4884f71b1a8d40171c179a766f2804a66ba162102bbf6ae31b522aec561735e) ,     [MultipleIOAndListener](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a7a4884f71b1a8d40171c179a766f2804a1d1c2b192224364a95a35a740a0b680f) ,     [MultipleSeperateIOAndListener](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a7a4884f71b1a8d40171c179a766f2804ae195f8846ac794e3545be16bb309cf0a)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Activate](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a4d703d5a66c053925702aa8076255680) (ushort port, [ThreadType](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a7a4884f71b1a8d40171c179a766f2804) threadType=[ThreadType.Single](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a7a4884f71b1a8d40171c179a766f2804a66ba162102bbf6ae31b522aec561735e), int readWriteThreadCount=1) |
| [ServersideSession](class_tale_worlds_1_1_network_1_1_serverside_session.html) | [GetPeer](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a9bba39ad091b5acbcc40ff91ee7ca912) (int peerIndex) |
| virtual void | [Tick](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a3e76daa14104767c5fb2deb82a06e644) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [ServersideSessionManager](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#aa28bfa873ed4d4b9da083ced103ccd4f) () |
| [ServersideSession](class_tale_worlds_1_1_network_1_1_serverside_session.html) | [OnNewConnection](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#aa15fcf04684810bda7245ef468afc924) () |
| void | [OnRemoveConnection](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a0cb8de4d17999f384bb790c4a642723d) ([ServersideSession](class_tale_worlds_1_1_network_1_1_serverside_session.html) peer) |

|  |  |
| --- | --- |
| Properties | |
| float | [PeerAliveCoeff](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#ae2f28d56b415bb81cc3cef77b0e42c4f) `[get, set]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a7a4884f71b1a8d40171c179a766f2804)ThreadType
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Network.ServersideSessionManager.ThreadType](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a7a4884f71b1a8d40171c179a766f2804) |

| Enumerator | |
| --- | --- |
| Single |  |
| MultipleIOAndListener |  |
| MultipleSeperateIOAndListener |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#aa28bfa873ed4d4b9da083ced103ccd4f)ServersideSessionManager()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | TaleWorlds.Network.ServersideSessionManager.ServersideSessionManager | ( |  | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a4d703d5a66c053925702aa8076255680)Activate()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Network.ServersideSessionManager.Activate | ( | ushort | *port*, |
|  |  | [ThreadType](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a7a4884f71b1a8d40171c179a766f2804) | *threadType* = [ThreadType::Single](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a7a4884f71b1a8d40171c179a766f2804a66ba162102bbf6ae31b522aec561735e), |
|  |  | int | *readWriteThreadCount* = 1 ) |

[◆](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a9bba39ad091b5acbcc40ff91ee7ca912)GetPeer()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ServersideSession](class_tale_worlds_1_1_network_1_1_serverside_session.html) TaleWorlds.Network.ServersideSessionManager.GetPeer | ( | int | *peerIndex* | ) |  |

[◆](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a3e76daa14104767c5fb2deb82a06e644)Tick()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.Network.ServersideSessionManager.Tick | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#aa15fcf04684810bda7245ef468afc924)OnNewConnection()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [ServersideSession](class_tale_worlds_1_1_network_1_1_serverside_session.html) TaleWorlds.Network.ServersideSessionManager.OnNewConnection | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#a0cb8de4d17999f384bb790c4a642723d)OnRemoveConnection()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Network.ServersideSessionManager.OnRemoveConnection | ( | [ServersideSession](class_tale_worlds_1_1_network_1_1_serverside_session.html) | *peer* | ) |  | | abstractprotected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_network_1_1_serverside_session_manager.html#ae2f28d56b415bb81cc3cef77b0e42c4f)PeerAliveCoeff
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Network.ServersideSessionManager.PeerAliveCoeff | | getset |

