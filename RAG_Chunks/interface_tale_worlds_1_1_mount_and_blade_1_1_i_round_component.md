--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html ---

TaleWorlds.MountAndBlade.IRoundComponent Interface ReferenceInherits [TaleWorlds.MountAndBlade.IMissionBehavior](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_behavior.html).

Inherited by [TaleWorlds.MountAndBlade.MultiplayerRoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_component.html), and [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html).

|  |  |
| --- | --- |
| Properties | |
| float | [LastRoundEndRemainingTime](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a7d8961d25ebd13ffcd04c4dc980122ba) `[get]` |
| float | [RemainingRoundTime](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#ab90f9e98a4883337bcbb69a30cfc8189) `[get]` |
| [MultiplayerRoundState](namespace_tale_worlds_1_1_mount_and_blade.html#a3c04e1d237e250053e0428ac79a66366) | [CurrentRoundState](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a79c050d87a503d10dc3df011ccde0381) `[get]` |
| int | [RoundCount](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a5cec07edd990a1782afde9a9b1d73c7a) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [RoundWinner](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a36a3ab0d12eb9128b17e9b64d04b9ab0) `[get]` |
| [RoundEndReason](namespace_tale_worlds_1_1_mount_and_blade.html#adb24fc7a6b1959aca1e1a30816ad27a3) | [RoundEndReason](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a9a4fa1029091d97f3eb3ec025f306a82) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [OnRoundStarted](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#ad446b12d52525d38b6d1583b5543783e) |
| Action | [OnPreparationEnded](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a0e5d56ab8671c2a4cc555bd0b6f45e6f) |
| Action | [OnPreRoundEnding](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a7feab5fbac47f7449ca0c12b7dfe089b) |
| Action | [OnRoundEnding](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#ad5481522eea2b4c4b11d1b96a85858f5) |
| Action | [OnPostRoundEnded](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a996f913b37534b572af0118aeadb6913) |
| Action | [OnCurrentRoundStateChanged](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#abbe153f25038a0fd04e84e39f7afeb03) |

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a7d8961d25ebd13ffcd04c4dc980122ba)LastRoundEndRemainingTime
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IRoundComponent.LastRoundEndRemainingTime | | get |

Implemented in [TaleWorlds.MountAndBlade.MultiplayerRoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_component.html#a500a9b6d059d147ffad58bff55fab42b), and [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#a5e7d9ef4c700b9868a400155d28777db).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#ab90f9e98a4883337bcbb69a30cfc8189)RemainingRoundTime
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.IRoundComponent.RemainingRoundTime | | get |

Implemented in [TaleWorlds.MountAndBlade.MultiplayerRoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_component.html#a8a741ecc9a7f01c83c2e2a75826889db), and [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#a41605810811729c2917efc5783c017eb).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a79c050d87a503d10dc3df011ccde0381)CurrentRoundState
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MultiplayerRoundState](namespace_tale_worlds_1_1_mount_and_blade.html#a3c04e1d237e250053e0428ac79a66366) TaleWorlds.MountAndBlade.IRoundComponent.CurrentRoundState | | get |

Implemented in [TaleWorlds.MountAndBlade.MultiplayerRoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_component.html#af3b84bf70aeeb85ffac014ae8ec85bba), and [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#a2d3444a2d70770fdaa77a8039323830b).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a5cec07edd990a1782afde9a9b1d73c7a)RoundCount
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.IRoundComponent.RoundCount | | get |

Implemented in [TaleWorlds.MountAndBlade.MultiplayerRoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_component.html#accaf2241bc4e96eb9b39f34626692c2d), and [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#aeab6516d64fda2d6ae823e358c94a6c8).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a36a3ab0d12eb9128b17e9b64d04b9ab0)RoundWinner
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.MountAndBlade.IRoundComponent.RoundWinner | | get |

Implemented in [TaleWorlds.MountAndBlade.MultiplayerRoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_component.html#aaa923be0c119140565a13b0259e1f744), and [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#aeec5e03decc99bfaf91c83c047c7c69a).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a9a4fa1029091d97f3eb3ec025f306a82)RoundEndReason
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RoundEndReason](namespace_tale_worlds_1_1_mount_and_blade.html#adb24fc7a6b1959aca1e1a30816ad27a3) TaleWorlds.MountAndBlade.IRoundComponent.RoundEndReason | | get |

Implemented in [TaleWorlds.MountAndBlade.MultiplayerRoundComponent](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_component.html#a106f20cd055fb5b09dfaf1723ae36e02), and [TaleWorlds.MountAndBlade.MultiplayerRoundController](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_round_controller.html#a29dd065e794d37452b2697ba7622a352).

Event Documentation
-------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#ad446b12d52525d38b6d1583b5543783e)OnRoundStarted
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.IRoundComponent.OnRoundStarted |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a0e5d56ab8671c2a4cc555bd0b6f45e6f)OnPreparationEnded
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.IRoundComponent.OnPreparationEnded |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a7feab5fbac47f7449ca0c12b7dfe089b)OnPreRoundEnding
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.IRoundComponent.OnPreRoundEnding |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#ad5481522eea2b4c4b11d1b96a85858f5)OnRoundEnding
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.IRoundComponent.OnRoundEnding |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#a996f913b37534b572af0118aeadb6913)OnPostRoundEnded
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.IRoundComponent.OnPostRoundEnded |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_round_component.html#abbe153f25038a0fd04e84e39f7afeb03)OnCurrentRoundStateChanged
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.IRoundComponent.OnCurrentRoundStateChanged |

