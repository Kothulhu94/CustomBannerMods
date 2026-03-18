--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html ---

TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [SandBox.GameComponents.SandboxBattleInitializationModel](class_sand_box_1_1_game_components_1_1_sandbox_battle_initialization_model.html), [TaleWorlds.MountAndBlade.CustomBattleInitializationModel](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_initialization_model.html), and [TaleWorlds.MountAndBlade.MultiplayerBattleInitializationModel](class_tale_worlds_1_1_mount_and_blade_1_1_multiplayer_battle_initialization_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| List< [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) > | [GetAllAvailableTroopTypes](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a2b1c1e4ff13ae601a005aa38c236d4b8) () |
| bool | [CanPlayerSideDeployWithOrderOfBattle](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a19ba029a2f8f93dfd0941f55337e076a) () |
| void | [InitializeModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#afd0b65cb5b6ca64c54ab4a1b6114373b) () |
| void | [FinalizeModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a301792f9e153915a1390f360440df84e) () |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MinimumTroopCountForPlayerDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a26ac8093e8df250ab2cc0b18609de4b5) = 20 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| bool | [CanPlayerSideDeployWithOrderOfBattleAux](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a250c05c77872b80bbf34a9b75e7c79a8) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a2b1c1e4ff13ae601a005aa38c236d4b8)GetAllAvailableTroopTypes()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List< [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) > TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel.GetAllAvailableTroopTypes | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a250c05c77872b80bbf34a9b75e7c79a8)CanPlayerSideDeployWithOrderOfBattleAux()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel.CanPlayerSideDeployWithOrderOfBattleAux | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a19ba029a2f8f93dfd0941f55337e076a)CanPlayerSideDeployWithOrderOfBattle()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel.CanPlayerSideDeployWithOrderOfBattle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#afd0b65cb5b6ca64c54ab4a1b6114373b)InitializeModel()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel.InitializeModel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a301792f9e153915a1390f360440df84e)FinalizeModel()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel.FinalizeModel | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a26ac8093e8df250ab2cc0b18609de4b5)MinimumTroopCountForPlayerDeployment
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel.MinimumTroopCountForPlayerDeployment = 20 | | static |

