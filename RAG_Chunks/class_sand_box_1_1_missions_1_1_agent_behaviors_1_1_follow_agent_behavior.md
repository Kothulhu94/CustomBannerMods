--- SOURCE: class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html ---

SandBox.Missions.AgentBehaviors.FollowAgentBehavior Class ReferenceInherits [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FollowAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#a2e31f27d2a05f0844364eeb232c77ad9) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |
| void | [SetTargetAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#a028260af861dfacaf29453bb943bcfaa) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override void | [Tick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#adb8e01a68f9a63fd7439bc7206c782b7) (float dt, bool isSimulation) |
| override void | [OnAgentRemoved](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#a6aeaef6b343e7f1ab8dcc01da081f44e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| override string | [GetDebugInfo](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#a0df21b4c82f2ef4f3821222051b1aa8c) () |
| override float | [GetAvailability](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#aeba8ce11694fa59faeb33a1cd7f83f70) (bool isSimulation) |
| Public Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
| virtual void | [ConversationTick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#afa5beca25f8fc953fdd3c38cea775a0a) () |
| virtual bool | [CheckStartWithBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#ab67ef25aba3b17e7162b1f9fc6a2f68c) () |
| virtual void | [OnSpecialTargetChanged](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a60052b6748c7d6ae6ad34b656b948cb3) () |
| virtual void | [SetCustomWanderTarget](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#addd4c580a4eab2c7b0af850f896dcab9) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) customUsableMachine) |
| string | [GetDebugInfo](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#aa84b397201e256d34ce0e960860dd94b) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnActivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#ae3b06ba9432de349fdbb8996b60ecd5b) () |
| override void | [OnDeactivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#ad697590afbaa12b1e0b461307770fd93) () |
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

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#a2e31f27d2a05f0844364eeb232c77ad9)FollowAgentBehavior()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Missions.AgentBehaviors.FollowAgentBehavior.FollowAgentBehavior | ( | [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | *behaviorGroup* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#a028260af861dfacaf29453bb943bcfaa)SetTargetAgent()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.FollowAgentBehavior.SetTargetAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#adb8e01a68f9a63fd7439bc7206c782b7)Tick()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.FollowAgentBehavior.Tick | ( | float | *dt*, | |  |  | bool | *isSimulation* ) | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a9caff05b7fc0ed2d9efdd8eb67a1e370).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#a6aeaef6b343e7f1ab8dcc01da081f44e)OnAgentRemoved()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.FollowAgentBehavior.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a75ab1885309bb7fed79bf2e543ddff5f).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#ae3b06ba9432de349fdbb8996b60ecd5b)OnActivate()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.FollowAgentBehavior.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#acf0d5c8ecf05946dbf2fd768039dd9e5).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#ad697590afbaa12b1e0b461307770fd93)OnDeactivate()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.FollowAgentBehavior.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a1968133eb73232ae45913aa06a07beed).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#a0df21b4c82f2ef4f3821222051b1aa8c)GetDebugInfo()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string SandBox.Missions.AgentBehaviors.FollowAgentBehavior.GetDebugInfo | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#aeba8ce11694fa59faeb33a1cd7f83f70)GetAvailability()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.Missions.AgentBehaviors.FollowAgentBehavior.GetAvailability | ( | bool | *isSimulation* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a4d4f55329d601d2cc076786b7d264659).

