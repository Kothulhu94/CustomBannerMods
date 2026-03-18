--- SOURCE: class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html ---

SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup Class ReferenceInherits [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [AlarmedBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a70a8502efd589f18f1c508bf91801411) ([AgentNavigator](class_sand_box_1_1_agent_navigator.html) navigator, [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) mission) |
| void | [SetCanMoveWhenCautious](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a43a7013feebef7eacd99230bb36133ac) (bool value) |
| float | [GetVisualFactor](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aa8621b84141a5acd31f4502bdb99fa18) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) usedGlobalLookDirection, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) currentAgent, MBReadOnlyList< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > stealthIndoorLightingAreas, ref bool hasVisualOnCorpse, ref bool hasVisualOnEnemy) |
| void | [ResetAlarmFactor](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#ad69dbe8651f7579f5f8866b3499d1356) () |
| void | [AddAlarmFactor](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#ae857114f7ae7f744e994604de3afede8) (float addedAlarmFactor, in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) suspiciousPosition) |
| override void | [Tick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aa4b3a084112ac0cd211a0fd94c618dd0) (float dt, bool isSimulation) |
| override float | [GetScore](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a0e4d17d71d66534dcc2a4e0ebd338b6a) (bool isSimulation) |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [GetClosestAlarmSource](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a1dd4ad189ea1779df4297f838748c92f) (out float distanceSquared) |
| override void | [OnAgentRemoved](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a65c6812854cb28acdf994b844d5b7077) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override void | [ForceThink](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aec1155cf3a091f5af9edb9725022cf95) (float inSeconds) |
| Public Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | |
| T | [AddBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a39e9d0417242dbda9a888e70aab61f77) () |
| T | [GetBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a582fb5408cd87c05f9213df710b8892e) () |
| bool | [HasBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#abb258dc00c633f3d09774f3165fd9642) () |
| void | [RemoveBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#af8fcea62838e89c1baa1dc7f4e9e08ee) () |
| void | [SetScriptedBehavior< T >](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a6f0190a0ae9a14b6a5971fdd8cd5c097) () |
| void | [DisableScriptedBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a4843fa9415c1a955f0e6d686e6aaacbb) () |
| void | [DisableAllBehaviors](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ad5a5ddc146cc1e56b1210890c5e9816c) () |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | [GetActiveBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a212cd80a0081cd35bf4d48b988eb2605) () |
| virtual void | [ConversationTick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a2b034c8bf2bb16bfe82c9b7260411ff7) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [AlarmAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a413be8a665fc212c03d453dc8577aa8c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [DisableCalmDown](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a2784c3779499efa2d2dde23547077f53) = false |
| bool | [DoNotCheckForAlarmFactorIncrease](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#accf8808b0959b435a3b67ba145d10231) = false |
| bool | [DoNotIncreaseAlarmFactorDueToSeeingOrHearingTheEnemy](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a3ce2164138006a0ea820df33f546fd22) = false |
| Public Attributes inherited from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | |
| [AgentNavigator](class_sand_box_1_1_agent_navigator.html) | [Navigator](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a246bea1189ff3ab22077e209ca8b5df8) |
| List< [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) > | [Behaviors](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a19c465b7589adfb2763cd18a04fa36cd) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [SafetyDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aea777ab2aaae4ec54fce52b4f36fb04d) = 15 |
| const float | [SafetyDistanceSquared](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#ada5c2fbd4eef8bafb08cd312bc56dca2) = [SafetyDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aea777ab2aaae4ec54fce52b4f36fb04d) \* [SafetyDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aea777ab2aaae4ec54fce52b4f36fb04d) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnActivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#ac6c172021a51d6effe1e3be2740b17cb) () |
| override void | [OnDeactivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a215f1f22b68b8818e3c67598927bc9f9) () |
| Protected Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | |
|  | [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a32df764d335fbc961b8e17b7197e9ac4) ([AgentNavigator](class_sand_box_1_1_agent_navigator.html) navigator, [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) mission) |

|  |  |
| --- | --- |
| Properties | |
| float | [AlarmFactor](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#addd546aa04eb0388e761d8e971cb0e1f) `[get]` |
| Properties inherited from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [OwnerAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a5bc980731dc0635f2cd7cebcedd98f31) `[get]` |
| [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | [ScriptedBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ae74d8790a3ef1516c961a72d8bcb3f26) `[get]` |
| bool | [IsActive](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a4fcb577d6dcf949af86b1f0be28b0586) `[get, set]` |
| Mission | [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Attributes inherited from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | |
| float | [CheckBehaviorTime](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a295ec363790e3acc9fe43d8039903c1c) = 5.0f |
| [Timer](class_tale_worlds_1_1_core_1_1_timer.html) | [CheckBehaviorTimer](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a604598a8f19e4ad78ae0d9ef1c516718) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a70a8502efd589f18f1c508bf91801411)AlarmedBehaviorGroup()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.AlarmedBehaviorGroup | ( | [AgentNavigator](class_sand_box_1_1_agent_navigator.html) | *navigator*, |
|  |  | [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a44884a9d081bdab8c3413c579b8b0da5) | *mission* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a43a7013feebef7eacd99230bb36133ac)SetCanMoveWhenCautious()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.SetCanMoveWhenCautious | ( | bool | *value* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aa8621b84141a5acd31f4502bdb99fa18)GetVisualFactor()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.GetVisualFactor | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *usedGlobalLookDirection*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *currentAgent*, |
|  |  | MBReadOnlyList< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *stealthIndoorLightingAreas*, |
|  |  | ref bool | *hasVisualOnCorpse*, |
|  |  | ref bool | *hasVisualOnEnemy* ) |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#ad69dbe8651f7579f5f8866b3499d1356)ResetAlarmFactor()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.ResetAlarmFactor | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#ae857114f7ae7f744e994604de3afede8)AddAlarmFactor()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.AddAlarmFactor | ( | float | *addedAlarmFactor*, |
|  |  | in [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *suspiciousPosition* ) |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aa4b3a084112ac0cd211a0fd94c618dd0)Tick()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.Tick | ( | float | *dt*, | |  |  | bool | *isSimulation* ) | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ab6bdbd16818c340582179e430bbccf53).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a0e4d17d71d66534dcc2a4e0ebd338b6a)GetScore()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.GetScore | ( | bool | *isSimulation* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a50df7719e7f5b081c6a15b9ae386c668).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a1dd4ad189ea1779df4297f838748c92f)GetClosestAlarmSource()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.GetClosestAlarmSource | ( | out float | *distanceSquared* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a413be8a665fc212c03d453dc8577aa8c)AlarmAgent()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.AlarmAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#ac6c172021a51d6effe1e3be2740b17cb)OnActivate()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#a778f19cd14a6f98f1311ec353f0f19df).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a65c6812854cb28acdf994b844d5b7077)OnAgentRemoved()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ae83cb68cdacaaa6f701c6ac47012afa0).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a215f1f22b68b8818e3c67598927bc9f9)OnDeactivate()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#ab5efe10c6df868897fc4d162d1912786).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aec1155cf3a091f5af9edb9725022cf95)ForceThink()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.ForceThink | ( | float | *inSeconds* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html#afdcde11796441e4306e3695877cc5294).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aea777ab2aaae4ec54fce52b4f36fb04d)SafetyDistance
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.SafetyDistance = 15 | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#ada5c2fbd4eef8bafb08cd312bc56dca2)SafetyDistanceSquared
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.SafetyDistanceSquared = [SafetyDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aea777ab2aaae4ec54fce52b4f36fb04d) \* [SafetyDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#aea777ab2aaae4ec54fce52b4f36fb04d) | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a2784c3779499efa2d2dde23547077f53)DisableCalmDown
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.DisableCalmDown = false |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#accf8808b0959b435a3b67ba145d10231)DoNotCheckForAlarmFactorIncrease
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.DoNotCheckForAlarmFactorIncrease = false |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#a3ce2164138006a0ea820df33f546fd22)DoNotIncreaseAlarmFactorDueToSeeingOrHearingTheEnemy
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.DoNotIncreaseAlarmFactorDueToSeeingOrHearingTheEnemy = false |

Property Documentation
----------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_alarmed_behavior_group.html#addd546aa04eb0388e761d8e971cb0e1f)AlarmFactor
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.Missions.AgentBehaviors.AlarmedBehaviorGroup.AlarmFactor | | get |

