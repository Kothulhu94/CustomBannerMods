--- SOURCE: interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html ---

TaleWorlds.MountAndBlade.ICommanderInfo Interface ReferenceInherits [TaleWorlds.MountAndBlade.IMissionBehavior](interface_tale_worlds_1_1_mount_and_blade_1_1_i_mission_behavior.html).

Inherited by [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeFlagDominationClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_flag_domination_client.html), and [TaleWorlds.MountAndBlade.MissionMultiplayerSiegeClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege_client.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [GetFlagOwner](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#a69b30f237634ddefe7419c41a9915b8e) ([FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html) flag) |

|  |  |
| --- | --- |
| Properties | |
| IEnumerable< [FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html) > | [AllCapturePoints](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#ad60f1574fe9264c18a0c3cbca26f2a67) `[get]` |
| bool | [AreMoralesIndependent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#ae929590b8ef24fbb5b30b08f4df80037) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), float > | [OnMoraleChangedEvent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#a5b57833a248bbe72419c654321c986ee) |
| Action | [OnFlagNumberChangedEvent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#ab550ddd1b78fffd6c9e12bc43ce79f33) |
| Action< [FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html), [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) > | [OnCapturePointOwnerChangedEvent](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#a858623ca817db9ae8c73fd8575fd1547) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#a69b30f237634ddefe7419c41a9915b8e)GetFlagOwner()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.ICommanderInfo.GetFlagOwner | ( | [FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html) | *flag* | ) |  |

Implemented in [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeFlagDominationClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_flag_domination_client.html#ae361ff3d2e4396d53b81fbba08331701), and [TaleWorlds.MountAndBlade.MissionMultiplayerSiegeClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege_client.html#a4ba52de90e8c80ee226abc33eeb2d055).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#ad60f1574fe9264c18a0c3cbca26f2a67)AllCapturePoints
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html)> TaleWorlds.MountAndBlade.ICommanderInfo.AllCapturePoints | | get |

Implemented in [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeFlagDominationClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_flag_domination_client.html#ae0618f3b251b245115d1f224e60f6661), and [TaleWorlds.MountAndBlade.MissionMultiplayerSiegeClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege_client.html#a5e1b5005764ef66c6424144a9a01e703).

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#ae929590b8ef24fbb5b30b08f4df80037)AreMoralesIndependent
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ICommanderInfo.AreMoralesIndependent | | get |

Implemented in [TaleWorlds.MountAndBlade.MissionMultiplayerGameModeFlagDominationClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_game_mode_flag_domination_client.html#af55d4e518e3706ca54f0262529ae6acd), and [TaleWorlds.MountAndBlade.MissionMultiplayerSiegeClient](class_tale_worlds_1_1_mount_and_blade_1_1_mission_multiplayer_siege_client.html#a6dbe398366770ec839221d5fbb85f0dd).

Event Documentation
-------------------

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#a5b57833a248bbe72419c654321c986ee)OnMoraleChangedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), float> TaleWorlds.MountAndBlade.ICommanderInfo.OnMoraleChangedEvent |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#ab550ddd1b78fffd6c9e12bc43ce79f33)OnFlagNumberChangedEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.MountAndBlade.ICommanderInfo.OnFlagNumberChangedEvent |

[◆](interface_tale_worlds_1_1_mount_and_blade_1_1_i_commander_info.html#a858623ca817db9ae8c73fd8575fd1547)OnCapturePointOwnerChangedEvent
-----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[FlagCapturePoint](class_tale_worlds_1_1_mount_and_blade_1_1_objects_1_1_flag_capture_point.html), [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html)> TaleWorlds.MountAndBlade.ICommanderInfo.OnCapturePointOwnerChangedEvent |

