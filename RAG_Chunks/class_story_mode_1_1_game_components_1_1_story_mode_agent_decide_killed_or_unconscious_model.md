--- SOURCE: class_story_mode_1_1_game_components_1_1_story_mode_agent_decide_killed_or_unconscious_model.html ---

StoryMode.GameComponents.StoryModeAgentDecideKilledOrUnconsciousModel Class ReferenceInherits [TaleWorlds.MountAndBlade.ComponentInterfaces.AgentDecideKilledOrUnconsciousModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_decide_killed_or_unconscious_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetAgentStateProbability](class_story_mode_1_1_game_components_1_1_story_mode_agent_decide_killed_or_unconscious_model.html#a174bd34d7b695ed5750b9526840fb10b) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) effectedAgent, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) weaponFlags, out float useSurgeryProbability) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.AgentDecideKilledOrUnconsciousModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_decide_killed_or_unconscious_model.html) | |
| float | [GetAgentStateProbability](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_agent_decide_killed_or_unconscious_model.html#a7e25340864e4fdd3db185c59089d2ce0) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) affectorAgent, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) effectedAgent, [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) damageType, [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) weaponFlags, out float useSurgeryProbability) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_game_components_1_1_story_mode_agent_decide_killed_or_unconscious_model.html#a174bd34d7b695ed5750b9526840fb10b)GetAgentStateProbability()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeAgentDecideKilledOrUnconsciousModel.GetAgentStateProbability | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *affectorAgent*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *effectedAgent*, |
|  |  | [DamageTypes](namespace_tale_worlds_1_1_core.html#a11f8d73dd1ba5a068fb8f18431237478) | *damageType*, |
|  |  | [WeaponFlags](namespace_tale_worlds_1_1_core.html#a777ba058af61ad6bd9a4a27124c20051) | *weaponFlags*, |
|  |  | out float | *useSurgeryProbability* ) |

