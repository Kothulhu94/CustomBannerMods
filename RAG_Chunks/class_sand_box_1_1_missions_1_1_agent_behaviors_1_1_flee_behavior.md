--- SOURCE: class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html ---

SandBox.Missions.AgentBehaviors.FleeBehavior Class ReferenceInherits [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FleeBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a5912e7799284ba83418224f97698f4e7) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |
| override void | [Tick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#ab457fc65f0f3a6d6565eb455efae4e6e) (float dt, bool isSimulation) |
| override string | [GetDebugInfo](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a94840b9659de12371bd76b98b45ca1d6) () |
| override float | [GetAvailability](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a63ccbb6cd15443609c613cf8cf5362be) (bool isSimulation) |
| Public Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
| virtual void | [ConversationTick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#afa5beca25f8fc953fdd3c38cea775a0a) () |
| virtual bool | [CheckStartWithBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#ab67ef25aba3b17e7162b1f9fc6a2f68c) () |
| virtual void | [OnSpecialTargetChanged](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a60052b6748c7d6ae6ad34b656b948cb3) () |
| virtual void | [SetCustomWanderTarget](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#addd4c580a4eab2c7b0af850f896dcab9) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) customUsableMachine) |
| virtual void | [OnAgentRemoved](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a75ab1885309bb7fed79bf2e543ddff5f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| string | [GetDebugInfo](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#aa84b397201e256d34ce0e960860dd94b) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [ScoreThreshold](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a2962208ea8e5e9269e3dd5b1bf31a949) = 1.0f |
| const float | [DangerDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a9c16081ec1005459ad15e342cc87c2d0) = 5.0f |
| const float | [ImmediateDangerDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a44eb48160734cec94d5aeebde9113f3d) = 2.0f |
| const float | [DangerDistanceSquared](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#af23a1c4de1ce4c751e09671d3639822f) = [DangerDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a9c16081ec1005459ad15e342cc87c2d0) \* [DangerDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a9c16081ec1005459ad15e342cc87c2d0) |
| const float | [ImmediateDangerDistanceSquared](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#abe88790c11a387cefaa7ea74a5e108d7) = [ImmediateDangerDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a44eb48160734cec94d5aeebde9113f3d) \* [ImmediateDangerDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a44eb48160734cec94d5aeebde9113f3d) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnActivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#ae451c3b413f8a06c2fa9019307c913dd) () |
| Protected Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
|  | [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#abb1cebbe2df36d0833762f162065e447) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |
| virtual void | [OnDeactivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a1968133eb73232ae45913aa06a07beed) () |

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

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a5912e7799284ba83418224f97698f4e7)FleeBehavior()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Missions.AgentBehaviors.FleeBehavior.FleeBehavior | ( | [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | *behaviorGroup* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#ab457fc65f0f3a6d6565eb455efae4e6e)Tick()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.FleeBehavior.Tick | ( | float | *dt*, | |  |  | bool | *isSimulation* ) | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a9caff05b7fc0ed2d9efdd8eb67a1e370).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#ae451c3b413f8a06c2fa9019307c913dd)OnActivate()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.FleeBehavior.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#acf0d5c8ecf05946dbf2fd768039dd9e5).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a94840b9659de12371bd76b98b45ca1d6)GetDebugInfo()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string SandBox.Missions.AgentBehaviors.FleeBehavior.GetDebugInfo | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a63ccbb6cd15443609c613cf8cf5362be)GetAvailability()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.Missions.AgentBehaviors.FleeBehavior.GetAvailability | ( | bool | *isSimulation* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a4d4f55329d601d2cc076786b7d264659).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a2962208ea8e5e9269e3dd5b1bf31a949)ScoreThreshold
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.AgentBehaviors.FleeBehavior.ScoreThreshold = 1.0f | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a9c16081ec1005459ad15e342cc87c2d0)DangerDistance
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.AgentBehaviors.FleeBehavior.DangerDistance = 5.0f | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a44eb48160734cec94d5aeebde9113f3d)ImmediateDangerDistance
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.AgentBehaviors.FleeBehavior.ImmediateDangerDistance = 2.0f | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#af23a1c4de1ce4c751e09671d3639822f)DangerDistanceSquared
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.AgentBehaviors.FleeBehavior.DangerDistanceSquared = [DangerDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a9c16081ec1005459ad15e342cc87c2d0) \* [DangerDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a9c16081ec1005459ad15e342cc87c2d0) | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#abe88790c11a387cefaa7ea74a5e108d7)ImmediateDangerDistanceSquared
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.Missions.AgentBehaviors.FleeBehavior.ImmediateDangerDistanceSquared = [ImmediateDangerDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a44eb48160734cec94d5aeebde9113f3d) \* [ImmediateDangerDistance](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a44eb48160734cec94d5aeebde9113f3d) | | static |

