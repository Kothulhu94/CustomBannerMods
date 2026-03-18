--- SOURCE: class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html ---

SandBox.Missions.AgentBehaviors.ScriptBehavior Class ReferenceInherits [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate bool | [SelectTargetDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a6772de09cc89c0af445493ce110485f6) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent, ref [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) targetUsableMachine, ref [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) targetFrame, ref float customTargetReachedRangeThreshold, ref float customTargetReachedRotationThreshold) |
| delegate bool | [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#ab2791ab9deb1b029aa5e2ff3a200e275) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent, ref [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) targetUsableMachine, ref [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) targetFrame) |
| delegate void | [OnTargetReachedWaitDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a12ac0b7e830ba6137238e230e4b19590) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, ref float waitTimeInSeconds) |
|  | [ScriptBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#aedc743db8844d7ba730a7e12f1e209d7) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |
| bool | [IsNearTarget](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a87829333f85ab4c93c1cc86116df510d) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent) |
| override void | [Tick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a86faa721b7959e517200f4cfa647830d) (float dt, bool isSimulation) |
| override float | [GetAvailability](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a0a132653fa8ec38d09d8b013ffd1d504) (bool isSimulation) |
| override string | [GetDebugInfo](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a59ece3197b9d6fffa13306da4a445329) () |
| Public Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
| virtual void | [ConversationTick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#afa5beca25f8fc953fdd3c38cea775a0a) () |
| virtual bool | [CheckStartWithBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#ab67ef25aba3b17e7162b1f9fc6a2f68c) () |
| virtual void | [OnSpecialTargetChanged](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a60052b6748c7d6ae6ad34b656b948cb3) () |
| virtual void | [SetCustomWanderTarget](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#addd4c580a4eab2c7b0af850f896dcab9) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) customUsableMachine) |
| virtual void | [OnAgentRemoved](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a75ab1885309bb7fed79bf2e543ddff5f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| string | [GetDebugInfo](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#aa84b397201e256d34ce0e960860dd94b) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [AddUsableMachineTarget](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#ac02f141ca5bef6dcb35a9e3a3e9a8e1b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ownerAgent, [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) targetUsableMachine) |
| static void | [AddAgentTarget](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#ad5e21494fd1e2c2986a33168f09f27a2) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ownerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent) |
| static void | [AddWorldFrameTarget](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a094a86549dfb777e1629231cfce0a7ea) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ownerAgent, [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) targetWorldFrame) |
| static void | [AddTargetWithDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#abf084d40bc90905c850110a3bc3c7b90) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ownerAgent, [SelectTargetDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a6772de09cc89c0af445493ce110485f6) selectTargetDelegate, [OnTargetReachedWaitDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a12ac0b7e830ba6137238e230e4b19590) onTargetReachWaitDelegate, [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#ab2791ab9deb1b029aa5e2ff3a200e275) onTargetReachedDelegate, float initialWaitInSeconds=0.0f) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnDeactivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a5c87e65566e36af7c18bb68a7b7f8118) () |
| Protected Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
|  | [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#abb1cebbe2df36d0833762f162065e447) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |
| virtual void | [OnActivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#acf0d5c8ecf05946dbf2fd768039dd9e5) () |

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

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#aedc743db8844d7ba730a7e12f1e209d7)ScriptBehavior()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Missions.AgentBehaviors.ScriptBehavior.ScriptBehavior | ( | [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | *behaviorGroup* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a6772de09cc89c0af445493ce110485f6)SelectTargetDelegate()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate bool SandBox.Missions.AgentBehaviors.ScriptBehavior.SelectTargetDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent*, |
|  |  | ref [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | *targetUsableMachine*, |
|  |  | ref [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) | *targetFrame*, |
|  |  | ref float | *customTargetReachedRangeThreshold*, |
|  |  | ref float | *customTargetReachedRotationThreshold* ) |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#ab2791ab9deb1b029aa5e2ff3a200e275)OnTargetReachedDelegate()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate bool SandBox.Missions.AgentBehaviors.ScriptBehavior.OnTargetReachedDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent*, |
|  |  | ref [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | *targetUsableMachine*, |
|  |  | ref [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) | *targetFrame* ) |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a12ac0b7e830ba6137238e230e4b19590)OnTargetReachedWaitDelegate()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void SandBox.Missions.AgentBehaviors.ScriptBehavior.OnTargetReachedWaitDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | ref float | *waitTimeInSeconds* ) |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#ac02f141ca5bef6dcb35a9e3a3e9a8e1b)AddUsableMachineTarget()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.Missions.AgentBehaviors.ScriptBehavior.AddUsableMachineTarget | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ownerAgent*, | |  |  | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | *targetUsableMachine* ) | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#ad5e21494fd1e2c2986a33168f09f27a2)AddAgentTarget()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.Missions.AgentBehaviors.ScriptBehavior.AddAgentTarget | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ownerAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent* ) | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a094a86549dfb777e1629231cfce0a7ea)AddWorldFrameTarget()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.Missions.AgentBehaviors.ScriptBehavior.AddWorldFrameTarget | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ownerAgent*, | |  |  | [WorldFrame](struct_tale_worlds_1_1_engine_1_1_world_frame.html) | *targetWorldFrame* ) | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#abf084d40bc90905c850110a3bc3c7b90)AddTargetWithDelegate()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.Missions.AgentBehaviors.ScriptBehavior.AddTargetWithDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ownerAgent*, | |  |  | [SelectTargetDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a6772de09cc89c0af445493ce110485f6) | *selectTargetDelegate*, | |  |  | [OnTargetReachedWaitDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a12ac0b7e830ba6137238e230e4b19590) | *onTargetReachWaitDelegate*, | |  |  | [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#ab2791ab9deb1b029aa5e2ff3a200e275) | *onTargetReachedDelegate*, | |  |  | float | *initialWaitInSeconds* = 0::0f ) | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a87829333f85ab4c93c1cc86116df510d)IsNearTarget()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.Missions.AgentBehaviors.ScriptBehavior.IsNearTarget | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent* | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a86faa721b7959e517200f4cfa647830d)Tick()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.ScriptBehavior.Tick | ( | float | *dt*, | |  |  | bool | *isSimulation* ) | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a9caff05b7fc0ed2d9efdd8eb67a1e370).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a0a132653fa8ec38d09d8b013ffd1d504)GetAvailability()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.Missions.AgentBehaviors.ScriptBehavior.GetAvailability | ( | bool | *isSimulation* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a4d4f55329d601d2cc076786b7d264659).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a5c87e65566e36af7c18bb68a7b7f8118)OnDeactivate()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.ScriptBehavior.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a1968133eb73232ae45913aa06a07beed).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a59ece3197b9d6fffa13306da4a445329)GetDebugInfo()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string SandBox.Missions.AgentBehaviors.ScriptBehavior.GetDebugInfo | ( |  | ) |  |

