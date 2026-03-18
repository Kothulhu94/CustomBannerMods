--- SOURCE: class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html ---

SandBox.Tournaments.AgentControllers.JoustingAgentController Class ReferenceInherits [TaleWorlds.MountAndBlade.AgentController](class_tale_worlds_1_1_mount_and_blade_1_1_agent_controller.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [JoustingAgentState](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920f) {     [GoingToBackStart](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920fa746973aeb74d70b6f40e5c739c1577f5) ,     [GoToStartPosition](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920fad67315f0b5ef539462333eac418b05cf) ,     [WaitInStartPosition](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920fadaa688355dca56a993e9fc8a8059604a) ,     [WaitingOpponent](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920fa0accc21445fcca7ff1ab1a3fab262b15) ,     [Ready](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920fae7d31fc0602fb2ede144d18cdffd816b) ,     [StartRiding](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920fa9132eedfeb6eeaa13306daee99652f4c) ,     [Riding](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920fa4bf5df68f29021215ca23f11e008f206) ,     [RidingAtWrongSide](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920fa9df0609b76d4c05e6b35db9ab12317c1) ,     [SwordDuel](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920fa594b5adb619b5e695540cb44908d7912)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnInitialize](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#aa8039af4661d39b2ff3f98a56b820d3e) () |
| void | [UpdateState](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a47de7ceb2bf4947681e9efffc3502fa9) () |
| void | [PrepareAgentToSwordDuel](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#ab734637256227386dbd1af2db48c205f) () |
| void | [PrepareEquipmentsForSwordDuel](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a13fd3ca1effd498ba4e4171f4b026f82) () |
| bool | [IsRiding](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#abe1be5aaa3b47136ef2a249a51fdd1eb) () |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [CurrentCornerIndex](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#ac5ec7ae19721f1d85ff465672c01298e) |
| int | [Score](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a2f15a29e0e9bc8811ad07c8cb6823e19) |

|  |  |
| --- | --- |
| Properties | |
| [JoustingAgentState](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920f) | [State](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a1c74c27e3f305fcb395048705feda588) `[get, set]` |
| [TournamentJoustingMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html) | [JoustingMissionController](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a34c3d0b754c089e22de1c2a6b238aada) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [Opponent](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a004f328172899b6c011c81c4d9f3f9f6) `[get]` |
| bool | [PrepareEquipmentsAfterDismount](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a5a1cf3cffd534ccbfdc786ad2c7eac7a) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.AgentController](class_tale_worlds_1_1_mount_and_blade_1_1_agent_controller.html) | |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [Owner](class_tale_worlds_1_1_mount_and_blade_1_1_agent_controller.html#ac6e105bbb93a2d1a3d564b57b6483c32) `[get, set]` |
| Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_agent_controller.html#a226958634f4be111e422b9fb45ec5776) `[get, set]` |

Member Enumeration Documentation
--------------------------------

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920f)JoustingAgentState
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.Tournaments.AgentControllers.JoustingAgentController.JoustingAgentState](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920f) |

| Enumerator | |
| --- | --- |
| GoingToBackStart |  |
| GoToStartPosition |  |
| WaitInStartPosition |  |
| WaitingOpponent |  |
| Ready |  |
| StartRiding |  |
| Riding |  |
| RidingAtWrongSide |  |
| SwordDuel |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#aa8039af4661d39b2ff3f98a56b820d3e)OnInitialize()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Tournaments.AgentControllers.JoustingAgentController.OnInitialize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.AgentController](class_tale_worlds_1_1_mount_and_blade_1_1_agent_controller.html#a71f4a0fe0fac4b47846ae51b224f295b).

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a47de7ceb2bf4947681e9efffc3502fa9)UpdateState()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Tournaments.AgentControllers.JoustingAgentController.UpdateState | ( |  | ) |  |

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#ab734637256227386dbd1af2db48c205f)PrepareAgentToSwordDuel()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Tournaments.AgentControllers.JoustingAgentController.PrepareAgentToSwordDuel | ( |  | ) |  |

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a13fd3ca1effd498ba4e4171f4b026f82)PrepareEquipmentsForSwordDuel()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Tournaments.AgentControllers.JoustingAgentController.PrepareEquipmentsForSwordDuel | ( |  | ) |  |

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#abe1be5aaa3b47136ef2a249a51fdd1eb)IsRiding()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.Tournaments.AgentControllers.JoustingAgentController.IsRiding | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#ac5ec7ae19721f1d85ff465672c01298e)CurrentCornerIndex
------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.Tournaments.AgentControllers.JoustingAgentController.CurrentCornerIndex |

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a2f15a29e0e9bc8811ad07c8cb6823e19)Score
-----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.Tournaments.AgentControllers.JoustingAgentController.Score |

Property Documentation
----------------------

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a1c74c27e3f305fcb395048705feda588)State
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [JoustingAgentState](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#af7e9f905aa6c13554518cbc682cb920f) SandBox.Tournaments.AgentControllers.JoustingAgentController.State | | getset |

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a34c3d0b754c089e22de1c2a6b238aada)JoustingMissionController
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentJoustingMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html) SandBox.Tournaments.AgentControllers.JoustingAgentController.JoustingMissionController | | get |

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a004f328172899b6c011c81c4d9f3f9f6)Opponent
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Tournaments.AgentControllers.JoustingAgentController.Opponent | | get |

[◆](class_sand_box_1_1_tournaments_1_1_agent_controllers_1_1_jousting_agent_controller.html#a5a1cf3cffd534ccbfdc786ad2c7eac7a)PrepareEquipmentsAfterDismount
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Tournaments.AgentControllers.JoustingAgentController.PrepareEquipmentsAfterDismount | | get |

