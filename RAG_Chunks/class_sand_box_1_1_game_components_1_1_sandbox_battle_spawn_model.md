--- SOURCE: class_sand_box_1_1_game_components_1_1_sandbox_battle_spawn_model.html ---

SandBox.GameComponents.SandboxBattleSpawnModel Class ReferenceInherits [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleSpawnModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_spawn_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [OnMissionStart](class_sand_box_1_1_game_components_1_1_sandbox_battle_spawn_model.html#a608ce44fbef21adb4f6bb8ae2331e3fe) () |
| override void | [OnMissionEnd](class_sand_box_1_1_game_components_1_1_sandbox_battle_spawn_model.html#ad8d919497012305f0908076bda17b977) () |
| override List<([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) origin, int formationIndex)> | [GetInitialSpawnAssignments](class_sand_box_1_1_game_components_1_1_sandbox_battle_spawn_model.html#a31767147d2fafbfc98248919c4aaeefa) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, List< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > troopOrigins) |
| override List<([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) origin, int formationIndex)> | [GetReinforcementAssignments](class_sand_box_1_1_game_components_1_1_sandbox_battle_spawn_model.html#a995c58d2b6cd6f5641a7ccab3bd25a83) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, List< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > troopOrigins) |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleSpawnModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_spawn_model.html) | |
| List<([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) origin, int formationIndex)> | [GetInitialSpawnAssignments](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_spawn_model.html#a8ec76773df81f399a6ff485932ccb697) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, List< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > troopOrigins) |
| List<([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) origin, int formationIndex)> | [GetReinforcementAssignments](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_spawn_model.html#aa350c9995fdd8f4afb8a5767b4e14c35) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, List< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > troopOrigins) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_game_components_1_1_sandbox_battle_spawn_model.html#a608ce44fbef21adb4f6bb8ae2331e3fe)OnMissionStart()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GameComponents.SandboxBattleSpawnModel.OnMissionStart | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleSpawnModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_spawn_model.html#afe59a7bb00ca7c7247982c50fb8f1ffc).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_battle_spawn_model.html#ad8d919497012305f0908076bda17b977)OnMissionEnd()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.GameComponents.SandboxBattleSpawnModel.OnMissionEnd | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleSpawnModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_spawn_model.html#a5aebec42811d39994040acf5dd21bb0b).

[◆](class_sand_box_1_1_game_components_1_1_sandbox_battle_spawn_model.html#a31767147d2fafbfc98248919c4aaeefa)GetInitialSpawnAssignments()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override List<([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) origin, int formationIndex)> SandBox.GameComponents.SandboxBattleSpawnModel.GetInitialSpawnAssignments | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, |
|  |  | List< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > | *troopOrigins* ) |

[◆](class_sand_box_1_1_game_components_1_1_sandbox_battle_spawn_model.html#a995c58d2b6cd6f5641a7ccab3bd25a83)GetReinforcementAssignments()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override List<([IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) origin, int formationIndex)> SandBox.GameComponents.SandboxBattleSpawnModel.GetReinforcementAssignments | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, |
|  |  | List< [IAgentOriginBase](interface_tale_worlds_1_1_core_1_1_i_agent_origin_base.html) > | *troopOrigins* ) |

