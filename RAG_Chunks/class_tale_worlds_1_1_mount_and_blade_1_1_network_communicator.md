--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html ---

TaleWorlds.MountAndBlade.NetworkCommunicator Class ReferencesealedInherits [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetRelevantGameOptions](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a4adb690e0473fcfaf92bd14e2fb5fbac) (bool sendMeBloodEvents, bool sendMeSoundEvents) |
| uint | [GetHost](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ac278a667e7610d4f14a3bbc6e6486efc) () |
| uint | [GetReversedHost](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#aa10b7cafc12a593ed8897adf3b01331c) () |
| ushort | [GetPort](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a5e7edca69bfc211fd9ebd3d02bf47cfb) () |
| void | [UpdateConnectionInfoForReconnect](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ad2341fdad13eb62a2004eff9e64b7b07) ([PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a05cd776482f6417938b0cfb00c9c4623) playerConnectionInfo, bool isAdmin) |
| void | [UpdateIndexForReconnectingPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a70188cdf4f9a592a006e1b06f7dd5a72) (int newIndex) |
| void | [UpdateForJoiningCustomGame](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#abf3c06627b15b432de11a6f21ab0299a) (bool isAdmin) |

|  |  |
| --- | --- |
| Properties | |
| VirtualPlayer | [VirtualPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a82bc3a2d6739241287939d24bce93bf5) `[get]` |
| PlayerConnectionInfo | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a05cd776482f6417938b0cfb00c9c4623) `[get]` |
| bool | [QuitFromMission](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ac76ea4bb3d31e201b8592686b6d28969) `[get, set]` |
| int | [SessionKey](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a92b289647b3920985a548d36138074b9) `[get]` |
| bool | [JustReconnecting](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ae6b86afee247537134e0939cf9e84792) `[get]` |
| double | [AveragePingInMilliseconds](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a8aa2f3454dedb3a8560ee33e4e40647b) `[get]` |
| double | [AverageLossPercent](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a273eb90be89c364a78cade173804b04e) `[get]` |
| bool | [IsMine](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a4f7d1c30440b312c0ee51ec5958b6969) `[get]` |
| bool | [IsAdmin](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a8af8e47202ba30bb5c291cd05c9efd33) `[get]` |
| int | [Index](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a439682a8761ad8d6db51e6acb3f057af) `[get]` |
| string | [UserName](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a97da93a65e98427c89247465e45862c5) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [ControlledAgent](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a4ae3d67bf1f7150dd2b76bdd28ae444a) `[get, set]` |
| bool | [IsMuted](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a9017bc7b3ab7d255b6281e3af1bc3dc6) `[get, set]` |
| int | [ForcedAvatarIndex](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a4db44e3bf60423324a47a8b0f2ae6b57) = -1 `[get, set]` |
| bool | [IsNetworkActive](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ac3482a8bfe2615d36ac99293cf4a7ccf) `[get]` |
| bool | [IsConnectionActive](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a0cb01fe1f9e49ea16452012348900d36) `[get]` |
| bool | [IsSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ab8bb1cae4f6136bc087bb56b2018f32a) `[get, set]` |
| bool | [IsServerPeer](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a8d78eaed0ab2e053c319cfe4798c8b0d) `[get]` |
| NetworkMessages.FromServer.ServerPerformanceState | [ServerPerformanceProblemState](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a41f3f15b075a59fff2695653a53bfe65) `[get]` |

|  |  |
| --- | --- |
| Events | |
| static Action< [PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html) > | [OnPeerComponentAdded](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#abc6c21dc0d8a19732a80c2c31b972583) |
| static Action< NetworkCommunicator > | [OnPeerSynchronized](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a7f4c5f274561e958c7925985ac6beb8d) |
| static Action< NetworkCommunicator > | [OnPeerAveragePingUpdated](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a52c1e7e73df16340a70683b26d72dc20) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a4adb690e0473fcfaf92bd14e2fb5fbac)SetRelevantGameOptions()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.NetworkCommunicator.SetRelevantGameOptions | ( | bool | *sendMeBloodEvents*, |
|  |  | bool | *sendMeSoundEvents* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ac278a667e7610d4f14a3bbc6e6486efc)GetHost()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.MountAndBlade.NetworkCommunicator.GetHost | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#aa10b7cafc12a593ed8897adf3b01331c)GetReversedHost()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.MountAndBlade.NetworkCommunicator.GetReversedHost | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a5e7edca69bfc211fd9ebd3d02bf47cfb)GetPort()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ushort TaleWorlds.MountAndBlade.NetworkCommunicator.GetPort | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ad2341fdad13eb62a2004eff9e64b7b07)UpdateConnectionInfoForReconnect()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.NetworkCommunicator.UpdateConnectionInfoForReconnect | ( | [PlayerConnectionInfo](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a05cd776482f6417938b0cfb00c9c4623) | *playerConnectionInfo*, |
|  |  | bool | *isAdmin* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a70188cdf4f9a592a006e1b06f7dd5a72)UpdateIndexForReconnectingPlayer()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.NetworkCommunicator.UpdateIndexForReconnectingPlayer | ( | int | *newIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#abf3c06627b15b432de11a6f21ab0299a)UpdateForJoiningCustomGame()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.NetworkCommunicator.UpdateForJoiningCustomGame | ( | bool | *isAdmin* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a82bc3a2d6739241287939d24bce93bf5)VirtualPlayer
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | VirtualPlayer TaleWorlds.MountAndBlade.NetworkCommunicator.VirtualPlayer | | get |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a1468fba0d0b3ac6133c0d9faadf6b261).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a05cd776482f6417938b0cfb00c9c4623)PlayerConnectionInfo
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | PlayerConnectionInfo TaleWorlds.MountAndBlade.NetworkCommunicator.PlayerConnectionInfo | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ac76ea4bb3d31e201b8592686b6d28969)QuitFromMission
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.NetworkCommunicator.QuitFromMission | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a92b289647b3920985a548d36138074b9)SessionKey
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.NetworkCommunicator.SessionKey | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ae6b86afee247537134e0939cf9e84792)JustReconnecting
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.NetworkCommunicator.JustReconnecting | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a8aa2f3454dedb3a8560ee33e4e40647b)AveragePingInMilliseconds
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.MountAndBlade.NetworkCommunicator.AveragePingInMilliseconds | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a273eb90be89c364a78cade173804b04e)AverageLossPercent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.MountAndBlade.NetworkCommunicator.AverageLossPercent | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a4f7d1c30440b312c0ee51ec5958b6969)IsMine
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.NetworkCommunicator.IsMine | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a8af8e47202ba30bb5c291cd05c9efd33)IsAdmin
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.NetworkCommunicator.IsAdmin | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a439682a8761ad8d6db51e6acb3f057af)Index
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.NetworkCommunicator.Index | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a97da93a65e98427c89247465e45862c5)UserName
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.NetworkCommunicator.UserName | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a4ae3d67bf1f7150dd2b76bdd28ae444a)ControlledAgent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.NetworkCommunicator.ControlledAgent | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a9017bc7b3ab7d255b6281e3af1bc3dc6)IsMuted
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.NetworkCommunicator.IsMuted | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a4db44e3bf60423324a47a8b0f2ae6b57)ForcedAvatarIndex
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.NetworkCommunicator.ForcedAvatarIndex = -1 | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ac3482a8bfe2615d36ac99293cf4a7ccf)IsNetworkActive
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.NetworkCommunicator.IsNetworkActive | | get |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a6ce4a0e2c7fb1fff1d4620dd5383af87).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a0cb01fe1f9e49ea16452012348900d36)IsConnectionActive
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.NetworkCommunicator.IsConnectionActive | | get |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#afb6b77062a8d32497c6268d9fd0ec3ec).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#ab8bb1cae4f6136bc087bb56b2018f32a)IsSynchronized
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.NetworkCommunicator.IsSynchronized | | getset |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#ad04129b6ffe8fa21b3ff9a6c8c1b2084).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a8d78eaed0ab2e053c319cfe4798c8b0d)IsServerPeer
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.NetworkCommunicator.IsServerPeer | | get |

Implements [TaleWorlds.Core.ICommunicator](interface_tale_worlds_1_1_core_1_1_i_communicator.html#a81bfeafa382e4f00e937c22b83c55315).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a41f3f15b075a59fff2695653a53bfe65)ServerPerformanceProblemState
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | NetworkMessages.FromServer.ServerPerformanceState TaleWorlds.MountAndBlade.NetworkCommunicator.ServerPerformanceProblemState | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#abc6c21dc0d8a19732a80c2c31b972583)OnPeerComponentAdded
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[PeerComponent](class_tale_worlds_1_1_core_1_1_peer_component.html)> TaleWorlds.MountAndBlade.NetworkCommunicator.OnPeerComponentAdded | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a7f4c5f274561e958c7925985ac6beb8d)OnPeerSynchronized
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<NetworkCommunicator> TaleWorlds.MountAndBlade.NetworkCommunicator.OnPeerSynchronized | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_network_communicator.html#a52c1e7e73df16340a70683b26d72dc20)OnPeerAveragePingUpdated
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<NetworkCommunicator> TaleWorlds.MountAndBlade.NetworkCommunicator.OnPeerAveragePingUpdated | | static |

