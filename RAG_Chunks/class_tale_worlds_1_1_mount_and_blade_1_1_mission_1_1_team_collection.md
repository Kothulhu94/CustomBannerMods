--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html ---

TaleWorlds.MountAndBlade.Mission.TeamCollection Class ReferencesealedInherits List.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TeamCollection](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#adaed82438e14389fd37cc47a27911bd8) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adfc400efb4da1f8dfb2cffaa4fbb4758) mission) |
| new void | [Add](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#ae6fe0b29e378077c319948a0fd964b65) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) t) |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [Add](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#ae3fedeaf133ba205a6e5005af19273d3) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, uint color=0xFFFFFFFF, uint color2=0xFFFFFFFF, [Banner](class_tale_worlds_1_1_core_1_1_banner.html) banner=null, bool isPlayerGeneral=true, bool isPlayerSergeant=false, bool isSettingRelations=true) |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [Find](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a2f1f3084b8d5b71ae0427404b67638fb) ([MBTeam](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_team.html) mbTeam) |
| void | [ClearResources](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a415347fb6434b3b1c3db673849028113) () |
| new void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#afa2271d3b5412a46618db12431e6f847) () |

|  |  |
| --- | --- |
| Properties | |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [Attacker](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a870fc4b1625ebc0aa51af98941f06b05) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [Defender](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#aadd3ac2ad23fef7c5556339e3137d0d5) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [AttackerAlly](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a84635cff1ea7d842a6c1eea5ab25cbd1) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [DefenderAlly](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#afae128e2025d1f6e37ad9eeed736bd86) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [Player](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a09a7872ea298649004866fdbeb9d960a) `[get, set]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [PlayerEnemy](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#acc08bf70e9951059af7a65a5c9514a42) `[get]` |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | [PlayerAlly](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#aa150677f48d73770fefd609fd67b457f) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action< [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html), [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) > | [OnPlayerTeamChanged](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a20e28dc123982f398bf80f999b4e84a0) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#adaed82438e14389fd37cc47a27911bd8)TeamCollection()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.Mission.TeamCollection.TeamCollection | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html#adfc400efb4da1f8dfb2cffaa4fbb4758) | *mission* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#ae6fe0b29e378077c319948a0fd964b65)Add() [1/2]
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| new void TaleWorlds.MountAndBlade.Mission.TeamCollection.Add | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *t* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#ae3fedeaf133ba205a6e5005af19273d3)Add() [2/2]
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.TeamCollection.Add | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | uint | *color* = 0xFFFFFFFF, |
|  |  | uint | *color2* = 0xFFFFFFFF, |
|  |  | [Banner](class_tale_worlds_1_1_core_1_1_banner.html) | *banner* = null, |
|  |  | bool | *isPlayerGeneral* = true, |
|  |  | bool | *isPlayerSergeant* = false, |
|  |  | bool | *isSettingRelations* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a2f1f3084b8d5b71ae0427404b67638fb)Find()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.TeamCollection.Find | ( | [MBTeam](struct_tale_worlds_1_1_mount_and_blade_1_1_m_b_team.html) | *mbTeam* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a415347fb6434b3b1c3db673849028113)ClearResources()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.Mission.TeamCollection.ClearResources | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#afa2271d3b5412a46618db12431e6f847)Clear()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| new void TaleWorlds.MountAndBlade.Mission.TeamCollection.Clear | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a870fc4b1625ebc0aa51af98941f06b05)Attacker
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.TeamCollection.Attacker | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#aadd3ac2ad23fef7c5556339e3137d0d5)Defender
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.TeamCollection.Defender | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a84635cff1ea7d842a6c1eea5ab25cbd1)AttackerAlly
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.TeamCollection.AttackerAlly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#afae128e2025d1f6e37ad9eeed736bd86)DefenderAlly
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.TeamCollection.DefenderAlly | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a09a7872ea298649004866fdbeb9d960a)Player
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.TeamCollection.Player | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#acc08bf70e9951059af7a65a5c9514a42)PlayerEnemy
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.TeamCollection.PlayerEnemy | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#aa150677f48d73770fefd609fd67b457f)PlayerAlly
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) TaleWorlds.MountAndBlade.Mission.TeamCollection.PlayerAlly | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_1_1_team_collection.html#a20e28dc123982f398bf80f999b4e84a0)OnPlayerTeamChanged
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action<[Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html), [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html)> TaleWorlds.MountAndBlade.Mission.TeamCollection.OnPlayerTeamChanged |

