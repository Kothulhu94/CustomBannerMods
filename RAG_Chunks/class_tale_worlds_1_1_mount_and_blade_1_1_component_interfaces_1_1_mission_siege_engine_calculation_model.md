--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_siege_engine_calculation_model.html ---

TaleWorlds.MountAndBlade.ComponentInterfaces.MissionSiegeEngineCalculationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.MountAndBlade.ComponentInterfaces.DefaultSiegeEngineCalculationModel](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_default_siege_engine_calculation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [CalculateReloadSpeed](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_siege_engine_calculation_model.html#a1d8a3bf6585cf86cbca63c487427b449) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) userAgent, float baseSpeed) |
| int | [CalculateShipSiegeWeaponAmmoCount](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_siege_engine_calculation_model.html#a88ccceb40d3d5c467cc6bb511bc2b6dc) ([IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) captain, [RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) weapon) |
| int | [CalculateDamage](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_siege_engine_calculation_model.html#aabdef19dc94450b38bd1afce7ee3cf95) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) attackerAgent, float baseDamage) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_siege_engine_calculation_model.html#a1d8a3bf6585cf86cbca63c487427b449)CalculateReloadSpeed()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.ComponentInterfaces.MissionSiegeEngineCalculationModel.CalculateReloadSpeed | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *userAgent*, | |  |  | float | *baseSpeed* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_siege_engine_calculation_model.html#a88ccceb40d3d5c467cc6bb511bc2b6dc)CalculateShipSiegeWeaponAmmoCount()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.ComponentInterfaces.MissionSiegeEngineCalculationModel.CalculateShipSiegeWeaponAmmoCount | ( | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *shipOrigin*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *captain*, | |  |  | [RangedSiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_ranged_siege_weapon.html) | *weapon* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_siege_engine_calculation_model.html#aabdef19dc94450b38bd1afce7ee3cf95)CalculateDamage()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.ComponentInterfaces.MissionSiegeEngineCalculationModel.CalculateDamage | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *attackerAgent*, | |  |  | float | *baseDamage* ) | | abstract |

