--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet_a_i.html ---

TaleWorlds.MountAndBlade.TrebuchetAI Class ReferencesealedInherits [TaleWorlds.MountAndBlade.RangedSiegeWeaponAi](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TrebuchetAI](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet_a_i.html#a92446ae5ad57494290845b287f672f63) ([Trebuchet](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet.html) trebuchet) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeaponAi](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html) | |
|  | [RangedSiegeWeaponAi](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html#a41dc54aa56b113b5735298b7c24dca0d) ([RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) rangedSiegeWeapon) |
| void | [FindNextTarget](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html#aa74b61233645f6bb3728f11d5af08132) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#aae23b5871d681a2acf3f699313db9163) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToCompareTo, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formationToCompareTo, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) potentialUsersTeam, float dt) |
| virtual void | [TeleportUserAgentsToMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a7dff9f1f1695f8f1295ac03eae84809b) (List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agentList) |
| void | [StopUsingStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a7493862104498c89042482a12e1310b2) ([StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetSuitableAgentForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a5a10c1a229a97a1b46a0cca7be9cf540) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, IEnumerable< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > agents, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > usedAgents) |
| static [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetSuitableAgentForStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ab69cadbada54b4ebe8ecb3afc12a2034) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint, List< ValueTuple< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html), float > > agents, List< [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) > usedAgents, float weight) |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeaponAi](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html) | |
| const string | [ForceTargetEntityTag](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html#ad09e0960c0ce81930afd12f7906f0c48) = "attackMe" |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.RangedSiegeWeaponAi](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html) | |
| override void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html#a16119b9fc40f1f6c1355b795b6b05322) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agentToCompareTo, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formationToCompareTo, [Team](class_tale_worlds_1_1_mount_and_blade_1_1_team.html) potentialUsersTeam, float dt) |
| virtual void | [UpdateAim](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon_ai.html#a7077dd9cf49a401ded5b9e5968329681) ([RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) rangedSiegeWeapon, float dt) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
|  | [UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a2757b3132ae99c61c831e86639c8df92) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) usableMachine) |
| [Agent.StopUsingGameObjectFlags](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html#aea9aa9704df22d862e1558baff59c713) | [GetStopUsingStandingPointFlags](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a06a94226f57ba3cbd8806c29dd086281) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |
| virtual void | [HandleAgentStopUsingStandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#ae47b0cb5efcfb2e4c0fdf80f67a41c67) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, [StandingPoint](class_tale_worlds_1_1_mount_and_blade_1_1_standing_point.html) standingPoint) |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| readonly UsableMachine | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a375e58590f347866758fd26c405f4967) |
|  | The object which ai agents are/will be using. |
| Properties inherited from [TaleWorlds.MountAndBlade.UsableMachineAIBase](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html) | |
| virtual bool | [HasActionCompleted](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a80c69be886749fa453100300e4092e14) `[get]` |
| virtual [MovementOrder](struct_tale_worlds_1_1_mount_and_blade_1_1_movement_order.html) | [NextOrder](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine_a_i_base.html#a55c28a0a65795adce78313e4e7570a4f) `[get]` |
|  | The next action the ai agents will be ordered to do when this ai component's actions have been completed. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet_a_i.html#a92446ae5ad57494290845b287f672f63)TrebuchetAI()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.TrebuchetAI.TrebuchetAI | ( | [Trebuchet](class_tale_worlds_1_1_mount_and_blade_1_1_trebuchet.html) | *trebuchet* | ) |  |

