--- SOURCE: class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html ---

SandBox.Missions.AgentBehaviors.ChangeLocationBehavior Class ReferenceInherits [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ChangeLocationBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a55a6dc0d05fcaf27eac7700037558983) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |
| override void | [Tick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#ab3400349f10613e5b6015ee1dd0d7ff8) (float dt, bool isSimulation) |
| override string | [GetDebugInfo](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a1dec430643e29f5c00931dcc1f79690e) () |
| override float | [GetAvailability](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a02e9fb0a7f6b4236d21b0b2031720adb) (bool isSimulation) |
| Public Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
| virtual void | [ConversationTick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#afa5beca25f8fc953fdd3c38cea775a0a) () |
| virtual bool | [CheckStartWithBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#ab67ef25aba3b17e7162b1f9fc6a2f68c) () |
| virtual void | [OnSpecialTargetChanged](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a60052b6748c7d6ae6ad34b656b948cb3) () |
| virtual void | [SetCustomWanderTarget](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#addd4c580a4eab2c7b0af850f896dcab9) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) customUsableMachine) |
| virtual void | [OnAgentRemoved](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a75ab1885309bb7fed79bf2e543ddff5f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| string | [GetDebugInfo](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#aa84b397201e256d34ce0e960860dd94b) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnActivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a6cc9f151eec45ad77134ecff77ec2cc7) () |
| override void | [OnDeactivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a9eec5653b2f9be054c9a64f42b17994b) () |
| Protected Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
|  | [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#abb1cebbe2df36d0833762f162065e447) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
| float | [CheckTime](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#abf25d3021e9714aff7fa604920e7c1df) = 15.0f |
| Protected Attributes inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
| readonly [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | [BehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a169af24a3a8e04d7e7f43b42f5d5c9ba) |
| Properties inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
| [AgentNavigator](class_sand_box_1_1_agent_navigator.html) | [Navigator](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a2bf16b0f03c3aa7de50c0d5190495ea8) `[get]` |
| bool | [IsActive](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a93ef21cdcaece9571e4a6c9de128ddde) `[get, set]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [OwnerAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a2b5bc0cac692424f595db9a6f9459512) `[get]` |
| Mission | [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a8dfeb8b1515f7922bed3889b5843d98c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a55a6dc0d05fcaf27eac7700037558983)ChangeLocationBehavior()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Missions.AgentBehaviors.ChangeLocationBehavior.ChangeLocationBehavior | ( | [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | *behaviorGroup* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#ab3400349f10613e5b6015ee1dd0d7ff8)Tick()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.ChangeLocationBehavior.Tick | ( | float | *dt*, | |  |  | bool | *isSimulation* ) | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a9caff05b7fc0ed2d9efdd8eb67a1e370).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a6cc9f151eec45ad77134ecff77ec2cc7)OnActivate()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.ChangeLocationBehavior.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#acf0d5c8ecf05946dbf2fd768039dd9e5).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a9eec5653b2f9be054c9a64f42b17994b)OnDeactivate()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.ChangeLocationBehavior.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a1968133eb73232ae45913aa06a07beed).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a1dec430643e29f5c00931dcc1f79690e)GetDebugInfo()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string SandBox.Missions.AgentBehaviors.ChangeLocationBehavior.GetDebugInfo | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a02e9fb0a7f6b4236d21b0b2031720adb)GetAvailability()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.Missions.AgentBehaviors.ChangeLocationBehavior.GetAvailability | ( | bool | *isSimulation* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a4d4f55329d601d2cc076786b7d264659).

