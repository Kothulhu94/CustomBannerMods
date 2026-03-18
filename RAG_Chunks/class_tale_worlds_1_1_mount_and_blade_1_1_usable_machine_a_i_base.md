--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html ---

TaleWorlds.MountAndBlade.UsableMachineAIBase Class ReferenceabstractInherited by [SandBox.AI.PassageAI](class_sand_box_1_1_a_i_1_1_passage_a_i.html), [SandBox.AI.UsablePlaceAI](class_sand_box_1_1_a_i_1_1_usable_place_a_i.html), [TaleWorlds.MountAndBlade.BatteringRamAI](class_tale_worlds_1_1_mount_and_blade_1_1_battering_ram_a_i.html), [TaleWorlds.MountAndBlade.CastleGateAI](class_tale_worlds_1_1_mount_and_blade_1_1_castle_gate_a_i.html), [TaleWorlds.MountAndBlade.RangedSiegeWeaponAi](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html), [TaleWorlds.MountAndBlade.SiegeLadderAI](class_tale_worlds_1_1_mount_and_blade_1_1_siege_ladder_a_i.html), [TaleWorlds.MountAndBlade.SiegeTowerAI](class_tale_worlds_1_1_mount_and_blade_1_1_siege_tower_a_i.html), and [TaleWorlds.MountAndBlade.StonePileAI](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#aae23b5871d681a2acf3f699313db9163) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToCompareTo, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formationToCompareTo, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) potentialUsersTeam, float dt) |
| virtual void | [TeleportUserAgentsToMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a7dff9f1f1695f8f1295ac03eae84809b) (List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agentList) |
| void | [StopUsingStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a7493862104498c89042482a12e1310b2) ([StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetSuitableAgentForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a5a10c1a229a97a1b46a0cca7be9cf540) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > usedAgents) |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetSuitableAgentForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ab69cadbada54b4ebe8ecb3afc12a2034) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > agents, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > usedAgents, float weight) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a2757b3132ae99c61c831e86639c8df92) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine) |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ae03a7d5f2c35d688cd6c4bad91b8d9c9) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToCompareTo, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formationToCompareTo, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) potentialUsersTeam, float dt) |
| [Agent.StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) | [GetStopUsingStandingPointFlags](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a06a94226f57ba3cbd8806c29dd086281) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |
| virtual void | [HandleAgentStopUsingStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ae47b0cb5efcfb2e4c0fdf80f67a41c67) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly UsableMachine | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) |
|  | The object which ai agents are/will be using. |

|  |  |
| --- | --- |
| Properties | |
| virtual bool | [HasActionCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a80c69be886749fa453100300e4092e14) `[get]` |
| virtual [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) | [NextOrder](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a55c28a0a65795adce78313e4e7570a4f) `[get]` |
|  | The next action the ai agents will be ordered to do when this ai component's actions have been completed. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a2757b3132ae99c61c831e86639c8df92)UsableMachineAIBase()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.UsableMachineAIBase.UsableMachineAIBase | ( | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) | *usableMachine* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#aae23b5871d681a2acf3f699313db9163)Tick()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UsableMachineAIBase.Tick | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agentToCompareTo*, |
|  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formationToCompareTo*, |
|  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *potentialUsersTeam*, |
|  |  | float | *dt* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ae03a7d5f2c35d688cd6c4bad91b8d9c9)OnTick()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UsableMachineAIBase.OnTick | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agentToCompareTo*, | |  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formationToCompareTo*, | |  |  | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) | *potentialUsersTeam*, | |  |  | float | *dt* ) | | protectedvirtual |

Reimplemented in [SandBox.AI.PassageAI](class_sand_box_1_1_a_i_1_1_passage_a_i.html#a44ebe42b776aa26f2f49515ce01f266b), and [TaleWorlds.MountAndBlade.RangedSiegeWeaponAi](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html#a16119b9fc40f1f6c1355b795b6b05322).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a5a10c1a229a97a1b46a0cca7be9cf540)GetSuitableAgentForStandingPoint() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.UsableMachineAIBase.GetSuitableAgentForStandingPoint | ( | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) | *usableMachine*, | |  |  | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *standingPoint*, | |  |  | IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agents*, | |  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *usedAgents* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ab69cadbada54b4ebe8ecb3afc12a2034)GetSuitableAgentForStandingPoint() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) TaleWorlds.MountAndBlade.UsableMachineAIBase.GetSuitableAgentForStandingPoint | ( | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) | *usableMachine*, | |  |  | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *standingPoint*, | |  |  | List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > | *agents*, | |  |  | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *usedAgents*, | |  |  | float | *weight* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a7dff9f1f1695f8f1295ac03eae84809b)TeleportUserAgentsToMachine()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UsableMachineAIBase.TeleportUserAgentsToMachine | ( | List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > | *agentList* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a7493862104498c89042482a12e1310b2)StopUsingStandingPoint()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.UsableMachineAIBase.StopUsingStandingPoint | ( | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *standingPoint* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a06a94226f57ba3cbd8806c29dd086281)GetStopUsingStandingPointFlags()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Agent.StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) TaleWorlds.MountAndBlade.UsableMachineAIBase.GetStopUsingStandingPointFlags | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *standingPoint* ) | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ae47b0cb5efcfb2e4c0fdf80f67a41c67)HandleAgentStopUsingStandingPoint()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.UsableMachineAIBase.HandleAgentStopUsingStandingPoint | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, | |  |  | [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) | *standingPoint* ) | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.StonePileAI](class_tale_worlds_1_1_mount_and_blade_1_1_stone_pile_a_i.html#affec8389c4480200fcbe45bba6452615).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967)UsableMachine
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly UsableMachine TaleWorlds.MountAndBlade.UsableMachineAIBase.UsableMachine | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a80c69be886749fa453100300e4092e14)HasActionCompleted
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual bool TaleWorlds.MountAndBlade.UsableMachineAIBase.HasActionCompleted | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a55c28a0a65795adce78313e4e7570a4f)NextOrder
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) TaleWorlds.MountAndBlade.UsableMachineAIBase.NextOrder | | getprotected |

