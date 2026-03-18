--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html ---

TaleWorlds.MountAndBlade.StonePileAI Class ReferenceInherits [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [StonePileAI](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#a153954f731c4defd2d3d4ce040f542bc) ([StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html) stonePile) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#aae23b5871d681a2acf3f699313db9163) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToCompareTo, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formationToCompareTo, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) potentialUsersTeam, float dt) |
| virtual void | [TeleportUserAgentsToMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a7dff9f1f1695f8f1295ac03eae84809b) (List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agentList) |
| void | [StopUsingStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a7493862104498c89042482a12e1310b2) ([StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetSuitableAgentForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#ace737acac396b1bf7641dad1d6c29a45) ([StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html) usableMachine, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > usedAgents) |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetSuitableAgentForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#a9f502863f3b942fd02a21700fd9075a4) ([StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html) stonePile, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > agents, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > usedAgents, float weight) |
| static bool | [IsAgentAssignable](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#ad5748e2569cefcec4b1edc12bdb19caa) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetSuitableAgentForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a5a10c1a229a97a1b46a0cca7be9cf540) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > usedAgents) |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetSuitableAgentForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ab69cadbada54b4ebe8ecb3afc12a2034) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > agents, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > usedAgents, float weight) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [HandleAgentStopUsingStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#affec8389c4480200fcbe45bba6452615) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
|  | [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a2757b3132ae99c61c831e86639c8df92) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine) |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ae03a7d5f2c35d688cd6c4bad91b8d9c9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToCompareTo, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formationToCompareTo, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) potentialUsersTeam, float dt) |
| [Agent.StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) | [GetStopUsingStandingPointFlags](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a06a94226f57ba3cbd8806c29dd086281) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| readonly UsableMachine | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) |
|  | The object which ai agents are/will be using. |
| Properties inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| virtual bool | [HasActionCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a80c69be886749fa453100300e4092e14) `[get]` |
| virtual [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) | [NextOrder](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a55c28a0a65795adce78313e4e7570a4f) `[get]` |
|  | The next action the ai agents will be ordered to do when this ai component's actions have been completed. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#a153954f731c4defd2d3d4ce040f542bc)StonePileAI()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.StonePileAI.StonePileAI | ( | [StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html) | *stonePile* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#ace737acac396b1bf7641dad1d6c29a45)GetSuitableAgentForStandingPoint() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.StonePileAI.GetSuitableAgentForStandingPoint | ( | [StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html) | *usableMachine*, | |  |  | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *standingPoint*, | |  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents*, | |  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *usedAgents* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#a9f502863f3b942fd02a21700fd9075a4)GetSuitableAgentForStandingPoint() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.StonePileAI.GetSuitableAgentForStandingPoint | ( | [StonePile](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile.html) | *stonePile*, | |  |  | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *standingPoint*, | |  |  | List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > | *agents*, | |  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *usedAgents*, | |  |  | float | *weight* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#ad5748e2569cefcec4b1edc12bdb19caa)IsAgentAssignable()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.StonePileAI.IsAgentAssignable | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#affec8389c4480200fcbe45bba6452615)HandleAgentStopUsingStandingPoint()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.StonePileAI.HandleAgentStopUsingStandingPoint | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *standingPoint* ) | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ae47b0cb5efcfb2e4c0fdf80f67a41c67).

