--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_initialization_model.html ---

TaleWorlds.MountAndBlade.CustomBattleInitializationModel Class ReferenceInherits [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override List< [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) > | [GetAllAvailableTroopTypes](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_initialization_model.html#a084614f85ce4c063a8b8f69465fbb627) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html) | |
| List< [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) > | [GetAllAvailableTroopTypes](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a2b1c1e4ff13ae601a005aa38c236d4b8) () |
| bool | [CanPlayerSideDeployWithOrderOfBattle](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a19ba029a2f8f93dfd0941f55337e076a) () |
| void | [InitializeModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#afd0b65cb5b6ca64c54ab4a1b6114373b) () |
| void | [FinalizeModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a301792f9e153915a1390f360440df84e) () |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override bool | [CanPlayerSideDeployWithOrderOfBattleAux](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_initialization_model.html#ae2ec15a1299b4b141276e942cef4c0ac) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html) | |
| bool | [CanPlayerSideDeployWithOrderOfBattleAux](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a250c05c77872b80bbf34a9b75e7c79a8) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Attributes inherited from [TaleWorlds.MountAndBlade.ComponentInterfaces.BattleInitializationModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html) | |
| const int | [MinimumTroopCountForPlayerDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_battle_initialization_model.html#a26ac8093e8df250ab2cc0b18609de4b5) = 20 |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_initialization_model.html#a084614f85ce4c063a8b8f69465fbb627)GetAllAvailableTroopTypes()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override List< [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) > TaleWorlds.MountAndBlade.CustomBattleInitializationModel.GetAllAvailableTroopTypes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_custom_battle_initialization_model.html#ae2ec15a1299b4b141276e942cef4c0ac)CanPlayerSideDeployWithOrderOfBattleAux()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.MountAndBlade.CustomBattleInitializationModel.CanPlayerSideDeployWithOrderOfBattleAux | ( |  | ) |  | | protected |

