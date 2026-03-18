--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html ---

TaleWorlds.MountAndBlade.TeamAIComponent Class ReferenceabstractThe strategy (larger, overall plan to win the battle) to be used is decided by team ai.

Inherited by [TaleWorlds.MountAndBlade.TeamAIGeneral](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_general.html), and [TaleWorlds.MountAndBlade.TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html).

|  |  |
| --- | --- |
| Classes | |
| class | [TacticOption](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component_1_1_tactic_option.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [TacticalDecisionDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ae941a52f414928ce324ce361f278b001) (in [TacticalDecision](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html) decision) |
| void | [AddStrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a4f909ab6393bc8d730de5d1fabb64d39) ([StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) strategicArea) |
| void | [RemoveStrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#aa5080725a617db3b41ed14838a7fccf7) ([StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) strategicArea) |
| void | [RemoveAllStrategicAreas](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a84e0221eb9008b99f9a8e0f3e563d32f) () |
| void | [AddTacticOption](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a31358c6523374570d2856b9d5e6db64f) ([TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) tacticOption) |
| void | [RemoveTacticOption](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ae13072c1b438b54a5ebeba0c9eb499a2) (Type tacticType) |
| void | [ClearTacticOptions](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a47a765fac0feaac859256c0b0579fd88) () |
| void | [AssertTeam](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a529e79db09ac7213460d0c3105ccc17a) ([Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1708ae0f8bafe90c6d66462a687f39b1) team) |
| void | [NotifyTacticalDecision](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a626e74ebf7afad505d728e5709b942d3) (in [TacticalDecision](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html) decision) |
|  | Notifies the registered subscribers about a tactical decision. |
| virtual void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ab06ffccff64d3de3bdb5c5180beb606c) () |
| virtual void | [OnFormationFrameChanged](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a73c2b896c1b8904c48e7a38362791299) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, bool isFrameEnabled, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) frame) |
| virtual void | [OnMissionEnded](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a63576f0227ebc97c387dd9ae1977ff4a) () |
| void | [ResetTacticalPositions](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a531b49d9e075c03a09e2e5d73ce75ec8) () |
| void | [ResetTactic](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#aff90cc58eada11e41c05a2ffff89f858) (bool keepCurrentTactic=true) |
| void | [CheckIsDefenseApplicable](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a18ede29233638d8c1e7186b1e0c7f1d4) () |
| void | [OnTacticAppliedForFirstTime](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ad1999372f880aec09c30c88091d37cb6) () |
| void | [TickOccasionally](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1d8dc0982e8dea5d3b1ca0288d6accf7) () |
| bool | [IsCurrentTactic](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a2ded1aa2a4a18bb006873c58261d0374) ([TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) tactic) |
| void | [OnUnitAddedToFormationForTheFirstTime](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5921f7d783bfc926e0dd059feb1dba99) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |

|  |  |
| --- | --- |
| Public Attributes | |
| [TacticalDecisionDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ae941a52f414928ce324ce361f278b001) | [OnNotifyTacticalDecision](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a25115ad1b1033f1d4813df25f1e7dd0b) |
| List< [TacticalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_position.html) > | [TacticalPositions](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5c7d24959b7cd3ae3ca086cf9a4cbd58) |
| List< [TacticalRegion](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_region.html) > | [TacticalRegions](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ac7ae0e0ec2a613832dfc306fec8d94d9) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [BattleTokenForceSize](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a128b168a2284a1851a678c190135ae1e) = 10 |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [TeamAIComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a9724532a8ebf8e6bd1a8b54a2def9d51) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1aaad201847b74bb82e35cc612f1b120) currentMission, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1708ae0f8bafe90c6d66462a687f39b1) currentTeam, float thinkTimerTime, float applyTimerTime) |
| virtual void | [DebugTick](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5a09e99d1f4c59eeed88bfa75bb6c065) (float dt) |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly Mission | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1aaad201847b74bb82e35cc612f1b120) |
| readonly Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1708ae0f8bafe90c6d66462a687f39b1) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) > | [StrategicAreas](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5bb819442454d7a495da83b86fc9560f) `[get]` |
| bool | [HasStrategicAreas](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ab6db99af3333735c59a05d1f5ce5b30c) `[get]` |
| bool | [IsDefenseApplicable](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a2f3aaaf9f02d4423fbee1a7c4a29949e) `[get]` |
| bool | [GetIsFirstTacticChosen](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a913e28be6871946f4396612342fa0ad6) = false `[get]` |
| [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | [CurrentTactic](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a03dee2a4140f42130f784e76363a7ba8) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a9724532a8ebf8e6bd1a8b54a2def9d51)TeamAIComponent()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.TeamAIComponent.TeamAIComponent | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1aaad201847b74bb82e35cc612f1b120) | *currentMission*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1708ae0f8bafe90c6d66462a687f39b1) | *currentTeam*, | |  |  | float | *thinkTimerTime*, | |  |  | float | *applyTimerTime* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ae941a52f414928ce324ce361f278b001)TacticalDecisionDelegate()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.TeamAIComponent.TacticalDecisionDelegate | ( | in [TacticalDecision](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html) | *decision* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a4f909ab6393bc8d730de5d1fabb64d39)AddStrategicArea()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.AddStrategicArea | ( | [StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) | *strategicArea* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#aa5080725a617db3b41ed14838a7fccf7)RemoveStrategicArea()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.RemoveStrategicArea | ( | [StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html) | *strategicArea* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a84e0221eb9008b99f9a8e0f3e563d32f)RemoveAllStrategicAreas()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.RemoveAllStrategicAreas | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a31358c6523374570d2856b9d5e6db64f)AddTacticOption()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.AddTacticOption | ( | [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | *tacticOption* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ae13072c1b438b54a5ebeba0c9eb499a2)RemoveTacticOption()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.RemoveTacticOption | ( | Type | *tacticType* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a47a765fac0feaac859256c0b0579fd88)ClearTacticOptions()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.ClearTacticOptions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a529e79db09ac7213460d0c3105ccc17a)AssertTeam()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.AssertTeam | ( | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1708ae0f8bafe90c6d66462a687f39b1) | *team* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a626e74ebf7afad505d728e5709b942d3)NotifyTacticalDecision()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.NotifyTacticalDecision | ( | in [TacticalDecision](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html) | *decision* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ab06ffccff64d3de3bdb5c5180beb606c)OnDeploymentFinished()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.TeamAIComponent.OnDeploymentFinished | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.TeamAISallyOutAttacker](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_attacker.html#a662a9e3387b9c42b584d85803a345468), [TaleWorlds.MountAndBlade.TeamAISallyOutDefender](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_sally_out_defender.html#adf49c994d49f4b84a07a59724fe68673), [TaleWorlds.MountAndBlade.TeamAISiegeAttacker](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_attacker.html#a87adc9d2c0c94e7bd1a1e4aa543eab7b), [TaleWorlds.MountAndBlade.TeamAISiegeComponent](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_component.html#a962aa7d35427e06306a5eb79861368dc), and [TaleWorlds.MountAndBlade.TeamAISiegeDefender](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_defender.html#ab808fefcf24aed3bbb9f01a1b137ac7f).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a73c2b896c1b8904c48e7a38362791299)OnFormationFrameChanged()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.TeamAIComponent.OnFormationFrameChanged | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | bool | *isFrameEnabled*, | |  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *frame* ) | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.TeamAISiegeAttacker](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_siege_attacker.html#aa26fcfabeef9e9379d667e36cc13c415).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a63576f0227ebc97c387dd9ae1977ff4a)OnMissionEnded()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.TeamAIComponent.OnMissionEnded | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a531b49d9e075c03a09e2e5d73ce75ec8)ResetTacticalPositions()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.ResetTacticalPositions | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#aff90cc58eada11e41c05a2ffff89f858)ResetTactic()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.ResetTactic | ( | bool | *keepCurrentTactic* = true | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a18ede29233638d8c1e7186b1e0c7f1d4)CheckIsDefenseApplicable()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.CheckIsDefenseApplicable | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ad1999372f880aec09c30c88091d37cb6)OnTacticAppliedForFirstTime()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.OnTacticAppliedForFirstTime | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1d8dc0982e8dea5d3b1ca0288d6accf7)TickOccasionally()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.TeamAIComponent.TickOccasionally | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a2ded1aa2a4a18bb006873c58261d0374)IsCurrentTactic()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.TeamAIComponent.IsCurrentTactic | ( | [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | *tactic* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5a09e99d1f4c59eeed88bfa75bb6c065)DebugTick()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.TeamAIComponent.DebugTick | ( | float | *dt* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.TeamAIGeneral](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_general.html#a47ccc982136d975276c34ce2e6da3350).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5921f7d783bfc926e0dd059feb1dba99)OnUnitAddedToFormationForTheFirstTime()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.TeamAIComponent.OnUnitAddedToFormationForTheFirstTime | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | abstract |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a25115ad1b1033f1d4813df25f1e7dd0b)OnNotifyTacticalDecision
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [TacticalDecisionDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ae941a52f414928ce324ce361f278b001) TaleWorlds.MountAndBlade.TeamAIComponent.OnNotifyTacticalDecision |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a128b168a2284a1851a678c190135ae1e)BattleTokenForceSize
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.TeamAIComponent.BattleTokenForceSize = 10 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1aaad201847b74bb82e35cc612f1b120)Mission
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly Mission TaleWorlds.MountAndBlade.TeamAIComponent.Mission | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a1708ae0f8bafe90c6d66462a687f39b1)Team
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly Team TaleWorlds.MountAndBlade.TeamAIComponent.Team | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5c7d24959b7cd3ae3ca086cf9a4cbd58)TacticalPositions
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[TacticalPosition](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_position.html)> TaleWorlds.MountAndBlade.TeamAIComponent.TacticalPositions |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ac7ae0e0ec2a613832dfc306fec8d94d9)TacticalRegions
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[TacticalRegion](class_tale_worlds_1_1_mount_and_blade_1_1_tactical_region.html)> TaleWorlds.MountAndBlade.TeamAIComponent.TacticalRegions |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a5bb819442454d7a495da83b86fc9560f)StrategicAreas
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[StrategicArea](class_tale_worlds_1_1_mount_and_blade_1_1_strategic_area.html)> TaleWorlds.MountAndBlade.TeamAIComponent.StrategicAreas | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#ab6db99af3333735c59a05d1f5ce5b30c)HasStrategicAreas
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.TeamAIComponent.HasStrategicAreas | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a2f3aaaf9f02d4423fbee1a7c4a29949e)IsDefenseApplicable
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.TeamAIComponent.IsDefenseApplicable | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a913e28be6871946f4396612342fa0ad6)GetIsFirstTacticChosen
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.TeamAIComponent.GetIsFirstTacticChosen = false | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_team_a_i_component.html#a03dee2a4140f42130f784e76363a7ba8)CurrentTactic
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) TaleWorlds.MountAndBlade.TeamAIComponent.CurrentTactic | | getprotected |

