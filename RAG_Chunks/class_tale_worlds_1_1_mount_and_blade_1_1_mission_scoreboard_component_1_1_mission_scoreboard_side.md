--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html ---

TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionScoreboardSide](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#ae593dc6e0558f5893d3cc17e612b3e5c) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [AddPlayer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a7e5acda8404cc06e96028bcec46fb157) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| void | [RemovePlayer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a57118fb3229d8f04d8c5367d5a695a28) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| string[] | [GetValuesOf](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#af9e6e484420f86ad79d71a7d93f3d3e4) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| string[] | [GetHeaderNames](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a3820146cc4668bf9d4a4fc6808250562) () |
| string[] | [GetHeaderIds](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a730e9179b72f6bc4f19af547cc422135) () |
| int | [GetScore](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a209f4dcde52427b9a287b43d2a8ed042) ([MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) peer) |
| void | [UpdateHeader](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a9d0de9b8549de53f342353bba36fe586) ([ScoreboardHeader](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_scoreboard_header.html)[] headers) |
| void | [Clear](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a44d48ff59f62b080096289030d3a1646) () |
| KeyValuePair< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html), int > | [CalculateAndGetMVPScoreWithPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a8004146329a17e51a06e094c69b8a9c6) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [Side](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a50d2bc6bc45ff91fd3f98be989b857e3) |
| [BotData](class_tale_worlds_1_1_mount_and_blade_1_1_bot_data.html) | [BotScores](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a0de03260621f70615a3c53a8fec4e324) |
| int | [SideScore](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a4e6afdff29f50b3e04966a2ea81504dd) |

|  |  |
| --- | --- |
| Properties | |
| int | [CurrentPlayerCount](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#afe39fb712fa3f44d77410257998f2d3f) `[get]` |
| IEnumerable< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) > | [Players](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a3281fc75d32d2707f5ed722e813c8fee) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#ae593dc6e0558f5893d3cc17e612b3e5c)MissionScoreboardSide()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.MissionScoreboardSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a7e5acda8404cc06e96028bcec46fb157)AddPlayer()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.AddPlayer | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a57118fb3229d8f04d8c5367d5a695a28)RemovePlayer()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.RemovePlayer | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#af9e6e484420f86ad79d71a7d93f3d3e4)GetValuesOf()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string[] TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.GetValuesOf | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a3820146cc4668bf9d4a4fc6808250562)GetHeaderNames()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string[] TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.GetHeaderNames | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a730e9179b72f6bc4f19af547cc422135)GetHeaderIds()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string[] TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.GetHeaderIds | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a209f4dcde52427b9a287b43d2a8ed042)GetScore()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.GetScore | ( | [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html) | *peer* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a9d0de9b8549de53f342353bba36fe586)UpdateHeader()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.UpdateHeader | ( | [ScoreboardHeader](struct_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_scoreboard_header.html)[] | *headers* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a44d48ff59f62b080096289030d3a1646)Clear()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a8004146329a17e51a06e094c69b8a9c6)CalculateAndGetMVPScoreWithPeer()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| KeyValuePair< [MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html), int > TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.CalculateAndGetMVPScoreWithPeer | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a50d2bc6bc45ff91fd3f98be989b857e3)Side
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.Side |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a0de03260621f70615a3c53a8fec4e324)BotScores
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [BotData](class_tale_worlds_1_1_mount_and_blade_1_1_bot_data.html) TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.BotScores |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a4e6afdff29f50b3e04966a2ea81504dd)SideScore
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.SideScore |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#afe39fb712fa3f44d77410257998f2d3f)CurrentPlayerCount
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.CurrentPlayerCount | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_mission_scoreboard_component_1_1_mission_scoreboard_side.html#a3281fc75d32d2707f5ed722e813c8fee)Players
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[MissionPeer](class_tale_worlds_1_1_mount_and_blade_1_1_mission_peer.html)> TaleWorlds.MountAndBlade.MissionScoreboardComponent.MissionScoreboardSide.Players | | get |

