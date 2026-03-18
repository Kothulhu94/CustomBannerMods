--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html ---

TaleWorlds.MountAndBlade.TacticalDecision Struct ReferenceKeeps decision data for critical tactical decisions that a reported through the TeamAI. This can be used to notify the player about critical tactical decisions of the friendly [AI](namespace_tale_worlds_1_1_mount_and_blade_1_1_a_i.html). In future this can also be used to coordinate decisions of ally teams.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TacticalDecision](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#a7f47bbafb5149a17585a95cba1ca8977) ([TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) decidingComponent, [TacticalDecisionCode](namespace_tale_worlds_1_1_mount_and_blade.html#ae3a1285bed89db125646c7f570be4253) decisionCode, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) subjectFormation=null, [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) targetFormation=null, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? targetPosition=null, [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) targetObject=null) |

|  |  |
| --- | --- |
| Properties | |
| [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | [DecidingComponent](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#a531b06661b4a720f8a4d1cd42a41d2a9) `[get]` |
|  | Tactic component making the tactical decision. |
| [TacticalDecisionCode](namespace_tale_worlds_1_1_mount_and_blade.html#ae3a1285bed89db125646c7f570be4253) | [DecisionCode](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#adbc9310ed0e84248ad9764d54427f64e) `[get]` |
|  | Generic decision code defining the tactical decision. It is up to the receiver/subscriber to interpret this code. |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [SubjectFormation](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#a6d3801a74bb74ea3f8bea141bfff365a) `[get]` |
|  | Subject formation for which the decision is made. Must belong to owning tactic component's team. Example: This team's infantry formation deciding to engage an enemy target. |
| [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | [TargetFormation](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#afea0da782e34100b2df31028deaefee7) `[get]` |
|  | The target formation of the tactical decision. May or may not belong to owning tactic component's team. Example: An enemy formation to which one of this team's formations (SubjectFormation) will attack next. |
| [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | [TargetPosition](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#a2354f0bc12757765d9d7e87d0df5a797) `[get]` |
|  | The target world position of the tactical decision. Example: This team's infantry formation is ordered to move to this position. |
| [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | [TargetObject](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#ad75986c264018044f8660318d62b7bd0) `[get]` |
|  | The target mission object of the tactical decision. Example: A sallying out cavalry formation is ordered to destroy an enemy siege engine. |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#a7f47bbafb5149a17585a95cba1ca8977)TacticalDecision()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.TacticalDecision.TacticalDecision | ( | [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) | *decidingComponent*, |
|  |  | [TacticalDecisionCode](namespace_tale_worlds_1_1_mount_and_blade.html#ae3a1285bed89db125646c7f570be4253) | *decisionCode*, |
|  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *subjectFormation* = null, |
|  |  | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *targetFormation* = null, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? | *targetPosition* = null, |
|  |  | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) | *targetObject* = null ) |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#a531b06661b4a720f8a4d1cd42a41d2a9)DecidingComponent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TacticComponent](class_tale_worlds_1_1_mount_and_blade_1_1_tactic_component.html) TaleWorlds.MountAndBlade.TacticalDecision.DecidingComponent | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#adbc9310ed0e84248ad9764d54427f64e)DecisionCode
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TacticalDecisionCode](namespace_tale_worlds_1_1_mount_and_blade.html#ae3a1285bed89db125646c7f570be4253) TaleWorlds.MountAndBlade.TacticalDecision.DecisionCode | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#a6d3801a74bb74ea3f8bea141bfff365a)SubjectFormation
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.TacticalDecision.SubjectFormation | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#afea0da782e34100b2df31028deaefee7)TargetFormation
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) TaleWorlds.MountAndBlade.TacticalDecision.TargetFormation | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#a2354f0bc12757765d9d7e87d0df5a797)TargetPosition
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html)? TaleWorlds.MountAndBlade.TacticalDecision.TargetPosition | | get |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_tactical_decision.html#ad75986c264018044f8660318d62b7bd0)TargetObject
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionObject](class_tale_worlds_1_1_mount_and_blade_1_1_mission_object.html) TaleWorlds.MountAndBlade.TacticalDecision.TargetObject | | get |

