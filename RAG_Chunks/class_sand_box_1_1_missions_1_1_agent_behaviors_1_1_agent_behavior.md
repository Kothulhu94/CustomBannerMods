--- SOURCE: class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html ---

SandBox.Missions.AgentBehaviors.AgentBehavior Class ReferenceabstractInherited by [SandBox.Missions.AgentBehaviors.CautiousBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_cautious_behavior.html), [SandBox.Missions.AgentBehaviors.ChangeLocationBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html), [SandBox.Missions.AgentBehaviors.EscortAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html), [SandBox.Missions.AgentBehaviors.FightBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_fight_behavior.html), [SandBox.Missions.AgentBehaviors.FleeBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html), [SandBox.Missions.AgentBehaviors.FollowAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html), [SandBox.Missions.AgentBehaviors.IdleAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_idle_agent_behavior.html), [SandBox.Missions.AgentBehaviors.PatrolAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_patrol_agent_behavior.html), [SandBox.Missions.AgentBehaviors.PatrollingGuardBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_patrolling_guard_behavior.html), [SandBox.Missions.AgentBehaviors.ScriptBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html), [SandBox.Missions.AgentBehaviors.StandGuardBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_stand_guard_behavior.html), [SandBox.Missions.AgentBehaviors.TalkBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_talk_behavior.html), [SandBox.Missions.AgentBehaviors.WalkingBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_walking_behavior.html), and [SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual float | [GetAvailability](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a4d4f55329d601d2cc076786b7d264659) (bool isSimulation) |
| virtual void | [Tick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a9caff05b7fc0ed2d9efdd8eb67a1e370) (float dt, bool isSimulation) |
| virtual void | [ConversationTick](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#afa5beca25f8fc953fdd3c38cea775a0a) () |
| virtual bool | [CheckStartWithBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#ab67ef25aba3b17e7162b1f9fc6a2f68c) () |
| virtual void | [OnSpecialTargetChanged](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a60052b6748c7d6ae6ad34b656b948cb3) () |
| virtual void | [SetCustomWanderTarget](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#addd4c580a4eab2c7b0af850f896dcab9) ([UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) customUsableMachine) |
| virtual void | [OnAgentRemoved](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a75ab1885309bb7fed79bf2e543ddff5f) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) agent) |
| string | [GetDebugInfo](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#aa84b397201e256d34ce0e960860dd94b) () |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [CheckTime](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#abf25d3021e9714aff7fa604920e7c1df) = 15.0f |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [AgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#abb1cebbe2df36d0833762f162065e447) ([AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) behaviorGroup) |
| virtual void | [OnActivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#acf0d5c8ecf05946dbf2fd768039dd9e5) () |
| virtual void | [OnDeactivate](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a1968133eb73232ae45913aa06a07beed) () |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | [BehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a169af24a3a8e04d7e7f43b42f5d5c9ba) |

|  |  |
| --- | --- |
| Properties | |
| [AgentNavigator](class_sand_box_1_1_agent_navigator.html) | [Navigator](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a2bf16b0f03c3aa7de50c0d5190495ea8) `[get]` |
| bool | [IsActive](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a93ef21cdcaece9571e4a6c9de128ddde) `[get, set]` |
| [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | [OwnerAgent](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a2b5bc0cac692424f595db9a6f9459512) `[get]` |
| Mission | [Mission](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a8dfeb8b1515f7922bed3889b5843d98c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#abb1cebbe2df36d0833762f162065e447)AgentBehavior()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | SandBox.Missions.AgentBehaviors.AgentBehavior.AgentBehavior | ( | [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) | *behaviorGroup* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a4d4f55329d601d2cc076786b7d264659)GetAvailability()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual float SandBox.Missions.AgentBehaviors.AgentBehavior.GetAvailability | ( | bool | *isSimulation* | ) |  | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.CautiousBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_cautious_behavior.html#a380a8f083e5ff2d0025b3076fe986cc6), [SandBox.Missions.AgentBehaviors.ChangeLocationBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a02e9fb0a7f6b4236d21b0b2031720adb), [SandBox.Missions.AgentBehaviors.EscortAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a05f8ce3bcf5e20d03b55bbf75dc6f931), [SandBox.Missions.AgentBehaviors.FightBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_fight_behavior.html#a1a15c5ee65e8e8f0b46804ecbe815138), [SandBox.Missions.AgentBehaviors.FleeBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#a63ccbb6cd15443609c613cf8cf5362be), [SandBox.Missions.AgentBehaviors.FollowAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#aeba8ce11694fa59faeb33a1cd7f83f70), [SandBox.Missions.AgentBehaviors.IdleAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_idle_agent_behavior.html#aed7ca70045adf12b300acfcdb2ff75ce), [SandBox.Missions.AgentBehaviors.PatrolAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_patrol_agent_behavior.html#ac9835ff8895c1c2f53dfde730f75c1a1), [SandBox.Missions.AgentBehaviors.PatrollingGuardBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_patrolling_guard_behavior.html#ae1e4e96dde74460cfbe47aa6565d7d56), [SandBox.Missions.AgentBehaviors.ScriptBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a0a132653fa8ec38d09d8b013ffd1d504), [SandBox.Missions.AgentBehaviors.StandGuardBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_stand_guard_behavior.html#a8a2990f8977efa13a5c81a1702feda2f), [SandBox.Missions.AgentBehaviors.TalkBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_talk_behavior.html#a2f2fcd3c61546f12c5e5318c147bd032), [SandBox.Missions.AgentBehaviors.WalkingBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_walking_behavior.html#af3644cecb013053c198c9f36ed90ba19), and [SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#ac0c29860677b0abc0394f75520b66f0d).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a9caff05b7fc0ed2d9efdd8eb67a1e370)Tick()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehavior.Tick | ( | float | *dt*, | |  |  | bool | *isSimulation* ) | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.CautiousBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_cautious_behavior.html#aa2c6e75c7ab0a2b3347bfb9c08a401ad), [SandBox.Missions.AgentBehaviors.ChangeLocationBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#ab3400349f10613e5b6015ee1dd0d7ff8), [SandBox.Missions.AgentBehaviors.EscortAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#ac6007efcf2671f670c0e8c379587272e), [SandBox.Missions.AgentBehaviors.FleeBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#ab457fc65f0f3a6d6565eb455efae4e6e), [SandBox.Missions.AgentBehaviors.FollowAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#adb8e01a68f9a63fd7439bc7206c782b7), [SandBox.Missions.AgentBehaviors.PatrolAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_patrol_agent_behavior.html#a0ef15a0ffd2d5878b70c00476a8205db), [SandBox.Missions.AgentBehaviors.PatrollingGuardBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_patrolling_guard_behavior.html#ae53bb1bd35f93ffef27f6e5e7a740a86), [SandBox.Missions.AgentBehaviors.ScriptBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a86faa721b7959e517200f4cfa647830d), [SandBox.Missions.AgentBehaviors.StandGuardBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_stand_guard_behavior.html#a39421eb257efdbbe20c92296e5294f28), [SandBox.Missions.AgentBehaviors.TalkBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_talk_behavior.html#aa23303cca8ae43540fd7b1c8e525d351), [SandBox.Missions.AgentBehaviors.WalkingBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_walking_behavior.html#a5db1e8b9a841bc942457376972076287), and [SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a79c4b44ca2dfce7b7f8c4c7c2f9c212c).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#afa5beca25f8fc953fdd3c38cea775a0a)ConversationTick()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehavior.ConversationTick | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.WalkingBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_walking_behavior.html#a438c0b11b5fc08d6389fb36c1c2ecfa7).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#acf0d5c8ecf05946dbf2fd768039dd9e5)OnActivate()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehavior.OnActivate | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.CautiousBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_cautious_behavior.html#aff467e864364533dc7371acbb6e75db3), [SandBox.Missions.AgentBehaviors.ChangeLocationBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a6cc9f151eec45ad77134ecff77ec2cc7), [SandBox.Missions.AgentBehaviors.FightBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_fight_behavior.html#ac29d3646877b91978c1c4339ccb303b9), [SandBox.Missions.AgentBehaviors.FleeBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_flee_behavior.html#ae451c3b413f8a06c2fa9019307c913dd), [SandBox.Missions.AgentBehaviors.FollowAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#ae3b06ba9432de349fdbb8996b60ecd5b), [SandBox.Missions.AgentBehaviors.IdleAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_idle_agent_behavior.html#a9431616875a0fa45b3b8a4ca5faab38b), and [SandBox.Missions.AgentBehaviors.PatrolAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_patrol_agent_behavior.html#acdf16134cbe253524386a6e4580ac528).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a1968133eb73232ae45913aa06a07beed)OnDeactivate()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehavior.OnDeactivate | ( |  | ) |  | | protectedvirtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.CautiousBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_cautious_behavior.html#ad5b5d93c4550eef2f87a2ef8316eb966), [SandBox.Missions.AgentBehaviors.ChangeLocationBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_change_location_behavior.html#a9eec5653b2f9be054c9a64f42b17994b), [SandBox.Missions.AgentBehaviors.EscortAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_escort_agent_behavior.html#a6c7931e4bdde5f7d41dac40aaf5e3bc0), [SandBox.Missions.AgentBehaviors.FightBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_fight_behavior.html#a9b3eb8b427e01ee1f0e9ebb0bfc4e281), [SandBox.Missions.AgentBehaviors.FollowAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#ad697590afbaa12b1e0b461307770fd93), [SandBox.Missions.AgentBehaviors.IdleAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_idle_agent_behavior.html#ab70f5161ba54588d11aa4c25c62ec926), [SandBox.Missions.AgentBehaviors.PatrolAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_patrol_agent_behavior.html#ab4d06d1080230e69045b3559b5822d3d), [SandBox.Missions.AgentBehaviors.PatrollingGuardBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_patrolling_guard_behavior.html#a9ace462cf2c3b6e1f43b924973c1a68f), [SandBox.Missions.AgentBehaviors.ScriptBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_script_behavior.html#a5c87e65566e36af7c18bb68a7b7f8118), [SandBox.Missions.AgentBehaviors.StandGuardBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_stand_guard_behavior.html#ad9d74f46e0f996c4c3444759f0f6e361), [SandBox.Missions.AgentBehaviors.TalkBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_talk_behavior.html#acbef167d103a6e0462464e8bcb9ccea7), [SandBox.Missions.AgentBehaviors.WalkingBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_walking_behavior.html#a574629d311584ecccccc68cc05e7d359), and [SandBox.Source.Missions.AgentBehaviors.BoardGameAgentBehavior](class_sand_box_1_1_source_1_1_missions_1_1_agent_behaviors_1_1_board_game_agent_behavior.html#a277a4cfa8db320d3695b557430c3187f).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#ab67ef25aba3b17e7162b1f9fc6a2f68c)CheckStartWithBehavior()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool SandBox.Missions.AgentBehaviors.AgentBehavior.CheckStartWithBehavior | ( |  | ) |  | | virtual |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a60052b6748c7d6ae6ad34b656b948cb3)OnSpecialTargetChanged()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehavior.OnSpecialTargetChanged | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.WalkingBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_walking_behavior.html#a671b51b93b4ab076a168695ef4cd6175).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#addd4c580a4eab2c7b0af850f896dcab9)SetCustomWanderTarget()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehavior.SetCustomWanderTarget | ( | [UsableMachine](class_tale_worlds_1_1_mount_and_blade_1_1_usable_machine.html) | *customUsableMachine* | ) |  | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.WalkingBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_walking_behavior.html#a9d9450cf13e0ad75422316791d1c9c32).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a75ab1885309bb7fed79bf2e543ddff5f)OnAgentRemoved()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.Missions.AgentBehaviors.AgentBehavior.OnAgentRemoved | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *agent* | ) |  | | virtual |

Reimplemented in [SandBox.Missions.AgentBehaviors.FollowAgentBehavior](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_follow_agent_behavior.html#a6aeaef6b343e7f1ab8dcc01da081f44e).

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#aa84b397201e256d34ce0e960860dd94b)GetDebugInfo()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string SandBox.Missions.AgentBehaviors.AgentBehavior.GetDebugInfo | ( |  | ) |  | | abstract |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#abf25d3021e9714aff7fa604920e7c1df)CheckTime
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float SandBox.Missions.AgentBehaviors.AgentBehavior.CheckTime = 15.0f |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a169af24a3a8e04d7e7f43b42f5d5c9ba)BehaviorGroup
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [AgentBehaviorGroup](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior_group.html) SandBox.Missions.AgentBehaviors.AgentBehavior.BehaviorGroup | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a2bf16b0f03c3aa7de50c0d5190495ea8)Navigator
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AgentNavigator](class_sand_box_1_1_agent_navigator.html) SandBox.Missions.AgentBehaviors.AgentBehavior.Navigator | | get |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a93ef21cdcaece9571e4a6c9de128ddde)IsActive
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.Missions.AgentBehaviors.AgentBehavior.IsActive | | getset |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a2b5bc0cac692424f595db9a6f9459512)OwnerAgent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) SandBox.Missions.AgentBehaviors.AgentBehavior.OwnerAgent | | get |

[◆](class_sand_box_1_1_missions_1_1_agent_behaviors_1_1_agent_behavior.html#a8dfeb8b1515f7922bed3889b5843d98c)Mission
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Mission SandBox.Missions.AgentBehaviors.AgentBehavior.Mission | | get |

