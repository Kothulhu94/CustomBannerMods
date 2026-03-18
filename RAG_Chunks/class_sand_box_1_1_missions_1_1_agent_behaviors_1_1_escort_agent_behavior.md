--- SOURCE: class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html ---

SandBox.Missions.AgentBehaviors.EscortAgentBehavior Class ReferenceInherits [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate bool | [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8ef311fae3be234f8e7c38c87c3b7657) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent, ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) escortedAgent, ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent, ref [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) targetMachine, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)? targetPosition) |
|  | [EscortAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a9a9eecdd8c34428a4547248efde164c3) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |
| void | [Initialize](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a7f822d681ab0a676edc9aecda44ae7cc) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) escortedAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent, [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8ef311fae3be234f8e7c38c87c3b7657) onTargetReached=null) |
| void | [Initialize](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8466dce457c836ecdf12960cf0abf33b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) escortedAgent, [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) targetMachine, [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8ef311fae3be234f8e7c38c87c3b7657) onTargetReached=null) |
| void | [Initialize](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#abef37aeec4923cd963acf47b93126f4f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) escortedAgent, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)? targetPosition, [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8ef311fae3be234f8e7c38c87c3b7657) onTargetReached=null) |
| override void | [Tick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#ac6007efcf2671f670c0e8c379587272e) (float dt, bool isSimulation) |
| bool | [IsEscortFinished](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#aa157c55368d1079004f3e2238c508f4a) () |
| override float | [GetAvailability](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a05f8ce3bcf5e20d03b55bbf75dc6f931) (bool isSimulation) |
| override string | [GetDebugInfo](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#aad6c2cfd0500eafe4af87c72eae5e700) () |
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
| static void | [AddEscortAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a4e7ec226d46ef359bb6d66fb5fefe9c8) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ownerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent, [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8ef311fae3be234f8e7c38c87c3b7657) onTargetReached) |
| static void | [RemoveEscortBehaviorOfAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a03b71e63ea2235a7bc477949428e7dc1) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ownerAgent) |
| static bool | [CheckIfAgentIsEscortedBy](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#aad15aa37bbd6a0a24866cb5fb3d3ef00) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ownerAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) escortedAgent) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnDeactivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a6c7931e4bdde5f7d41dac40aaf5e3bc0) () |
| Protected Member Functions inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
|  | [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#abb1cebbe2df36d0833762f162065e447) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |
| virtual void | [OnActivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#acf0d5c8ecf05946dbf2fd768039dd9e5) () |

|  |  |
| --- | --- |
| Properties | |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [EscortedAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a4bae9dd37b68adf8b067cebf472982eb) `[get]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [TargetAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a91d06c139a0365fea13aa9f8d4df9a9a) `[get]` |
| Properties inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
| [AgentNavigator](class_sand_box_1_1_agent_navigator.html) | [Navigator](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a2bf16b0f03c3aa7de50c0d5190495ea8) `[get]` |
| bool | [IsActive](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a93ef21cdcaece9571e4a6c9de128ddde) `[get, set]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [OwnerAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a2b5bc0cac692424f595db9a6f9459512) `[get]` |
| Mission | [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a8dfeb8b1515f7922bed3889b5843d98c) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
| float | [CheckTime](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#abf25d3021e9714aff7fa604920e7c1df) = 15.0f |
| Protected Attributes inherited from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html) | |
| readonly [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | [BehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a169af24a3a8e04d7e7f43b42f5d5c9ba) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a9a9eecdd8c34428a4547248efde164c3)EscortAgentBehavior()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Missions.AgentBehaviors.EscortAgentBehavior.EscortAgentBehavior | ( | [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | *behaviorGroup* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8ef311fae3be234f8e7c38c87c3b7657)OnTargetReachedDelegate()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate bool SandBox.Missions.AgentBehaviors.EscortAgentBehavior.OnTargetReachedDelegate | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent*, |
|  |  | ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *escortedAgent*, |
|  |  | ref [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent*, |
|  |  | ref [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | *targetMachine*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)? | *targetPosition* ) |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a7f822d681ab0a676edc9aecda44ae7cc)Initialize() [1/3]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.EscortAgentBehavior.Initialize | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *escortedAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent*, |
|  |  | [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8ef311fae3be234f8e7c38c87c3b7657) | *onTargetReached* = null ) |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8466dce457c836ecdf12960cf0abf33b)Initialize() [2/3]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.EscortAgentBehavior.Initialize | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *escortedAgent*, |
|  |  | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | *targetMachine*, |
|  |  | [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8ef311fae3be234f8e7c38c87c3b7657) | *onTargetReached* = null ) |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#abef37aeec4923cd963acf47b93126f4f)Initialize() [3/3]
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Missions.AgentBehaviors.EscortAgentBehavior.Initialize | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *escortedAgent*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)? | *targetPosition*, |
|  |  | [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8ef311fae3be234f8e7c38c87c3b7657) | *onTargetReached* = null ) |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#ac6007efcf2671f670c0e8c379587272e)Tick()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.EscortAgentBehavior.Tick | ( | float | *dt*, | |  |  | bool | *isSimulation* ) | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a9caff05b7fc0ed2d9efdd8eb67a1e370).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#aa157c55368d1079004f3e2238c508f4a)IsEscortFinished()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.Missions.AgentBehaviors.EscortAgentBehavior.IsEscortFinished | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a05f8ce3bcf5e20d03b55bbf75dc6f931)GetAvailability()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.Missions.AgentBehaviors.EscortAgentBehavior.GetAvailability | ( | bool | *isSimulation* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a4d4f55329d601d2cc076786b7d264659).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a6c7931e4bdde5f7d41dac40aaf5e3bc0)OnDeactivate()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Missions.AgentBehaviors.EscortAgentBehavior.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a1968133eb73232ae45913aa06a07beed).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#aad6c2cfd0500eafe4af87c72eae5e700)GetDebugInfo()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string SandBox.Missions.AgentBehaviors.EscortAgentBehavior.GetDebugInfo | ( |  | ) |  |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a4e7ec226d46ef359bb6d66fb5fefe9c8)AddEscortAgentBehavior()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.Missions.AgentBehaviors.EscortAgentBehavior.AddEscortAgentBehavior | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ownerAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent*, | |  |  | [OnTargetReachedDelegate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a8ef311fae3be234f8e7c38c87c3b7657) | *onTargetReached* ) | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a03b71e63ea2235a7bc477949428e7dc1)RemoveEscortBehaviorOfAgent()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.Missions.AgentBehaviors.EscortAgentBehavior.RemoveEscortBehaviorOfAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ownerAgent* | ) |  | | static |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#aad15aa37bbd6a0a24866cb5fb3d3ef00)CheckIfAgentIsEscortedBy()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool SandBox.Missions.AgentBehaviors.EscortAgentBehavior.CheckIfAgentIsEscortedBy | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ownerAgent*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *escortedAgent* ) | | static |

Property Documentation
----------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a4bae9dd37b68adf8b067cebf472982eb)EscortedAgent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Missions.AgentBehaviors.EscortAgentBehavior.EscortedAgent | | get |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a91d06c139a0365fea13aa9f8d4df9a9a)TargetAgent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Missions.AgentBehaviors.EscortAgentBehavior.TargetAgent | | get |

