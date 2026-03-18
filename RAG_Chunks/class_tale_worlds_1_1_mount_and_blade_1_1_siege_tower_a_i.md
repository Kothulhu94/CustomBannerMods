--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower_a_i.html ---

TaleWorlds.MountAndBlade.SiegeTowerAI Class ReferencesealedInherits [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SiegeTowerAI](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower_a_i.html#af3eea525df56e27e50a4dc059f91a4e1) (SiegeTower siegeTower) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#aae23b5871d681a2acf3f699313db9163) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToCompareTo, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formationToCompareTo, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) potentialUsersTeam, float dt) |
| virtual void | [TeleportUserAgentsToMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a7dff9f1f1695f8f1295ac03eae84809b) (List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agentList) |
| void | [StopUsingStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a7493862104498c89042482a12e1310b2) ([StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |

|  |  |
| --- | --- |
| Properties | |
| override bool | [HasActionCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower_a_i.html#a466f54b86d0f61546f4aec8fa5af3c55) `[get]` |
| override [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) | [NextOrder](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower_a_i.html#ad935d64e30274b3e6b84b318187bf15e) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| virtual bool | [HasActionCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a80c69be886749fa453100300e4092e14) `[get]` |
| virtual [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) | [NextOrder](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a55c28a0a65795adce78313e4e7570a4f) `[get]` |
|  | The next action the ai agents will be ordered to do when this ai component's actions have been completed. |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetSuitableAgentForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a5a10c1a229a97a1b46a0cca7be9cf540) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > usedAgents) |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetSuitableAgentForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ab69cadbada54b4ebe8ecb3afc12a2034) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > agents, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > usedAgents, float weight) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
|  | [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a2757b3132ae99c61c831e86639c8df92) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine) |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ae03a7d5f2c35d688cd6c4bad91b8d9c9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToCompareTo, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formationToCompareTo, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) potentialUsersTeam, float dt) |
| [Agent.StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) | [GetStopUsingStandingPointFlags](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a06a94226f57ba3cbd8806c29dd086281) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |
| virtual void | [HandleAgentStopUsingStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ae47b0cb5efcfb2e4c0fdf80f67a41c67) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| readonly UsableMachine | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) |
|  | The object which ai agents are/will be using. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower_a_i.html#af3eea525df56e27e50a4dc059f91a4e1)SiegeTowerAI()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.SiegeTowerAI.SiegeTowerAI | ( | SiegeTower | *siegeTower* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower_a_i.html#a466f54b86d0f61546f4aec8fa5af3c55)HasActionCompleted
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override bool TaleWorlds.MountAndBlade.SiegeTowerAI.HasActionCompleted | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower_a_i.html#ad935d64e30274b3e6b84b318187bf15e)NextOrder
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) TaleWorlds.MountAndBlade.SiegeTowerAI.NextOrder | | getprotected |

