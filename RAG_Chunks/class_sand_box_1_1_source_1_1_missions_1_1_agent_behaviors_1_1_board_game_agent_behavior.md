--- SOURCE: class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html ---

SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior Class ReferenceInherits [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BoardGameAgentBehavior](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a0c2cf5c935dd576567314d1b9a0c95f3) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |
| override void | [Tick](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a79c4b44ca2dfce7b7f8c4c7c2f9c212c) (float dt, bool isSimulation) |
| override string | [GetDebugInfo](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a98653e5338acc7f53f0a27c7acd4b0ca) () |
| override float | [GetAvailability](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#ac0c29860677b0abc0394f75520b66f0d) (bool isSimulation) |
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
| static void | [AddTargetChair](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a3aa2e3360aa6ff4dfc5a5e0749f27306) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ownerAgent, [Chair](class_sand_box_1_1_objects_1_1_usables_1_1_chair.html) chair) |
| static void | [RemoveBoardGameBehaviorOfAgent](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#ae0d844a1e3edf24d3e969a194505c653) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ownerAgent) |
| static bool | [IsAgentMovingToChair](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a5a06fd2b167824786c9a9e51ff36f41c) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) ownerAgent) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnDeactivate](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a277a4cfa8db320d3695b557430c3187f) () |
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

[◆](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a0c2cf5c935dd576567314d1b9a0c95f3)BoardGameAgentBehavior()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior.BoardGameAgentBehavior | ( | [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | *behaviorGroup* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a79c4b44ca2dfce7b7f8c4c7c2f9c212c)Tick()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior.Tick | ( | float | *dt*, | |  |  | bool | *isSimulation* ) | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a9caff05b7fc0ed2d9efdd8eb67a1e370).

[◆](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a277a4cfa8db320d3695b557430c3187f)OnDeactivate()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a1968133eb73232ae45913aa06a07beed).

[◆](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a98653e5338acc7f53f0a27c7acd4b0ca)GetDebugInfo()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior.GetDebugInfo | ( |  | ) |  |

[◆](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#ac0c29860677b0abc0394f75520b66f0d)GetAvailability()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override float SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior.GetAvailability | ( | bool | *isSimulation* | ) |  | | virtual |

Reimplemented from [SandBox.Missions.AgentBehaviors.AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a4d4f55329d601d2cc076786b7d264659).

[◆](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a3aa2e3360aa6ff4dfc5a5e0749f27306)AddTargetChair()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior.AddTargetChair | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ownerAgent*, | |  |  | [Chair](class_sand_box_1_1_objects_1_1_usables_1_1_chair.html) | *chair* ) | | static |

[◆](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#ae0d844a1e3edf24d3e969a194505c653)RemoveBoardGameBehaviorOfAgent()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior.RemoveBoardGameBehaviorOfAgent | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ownerAgent* | ) |  | | static |

[◆](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a5a06fd2b167824786c9a9e51ff36f41c)IsAgentMovingToChair()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior.IsAgentMovingToChair | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *ownerAgent* | ) |  | | static |

