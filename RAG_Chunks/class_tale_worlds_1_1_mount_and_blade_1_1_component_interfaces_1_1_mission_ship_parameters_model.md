--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_ship_parameters_model.html ---

TaleWorlds.MountAndBlade.ComponentInterfaces.MissionShipParametersModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [CalculateMainDeckCrewSize](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_ship_parameters_model.html#a2f15e7734b1b22ad5fcd137df5d837cc) ([IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) captain) |
| float | [CalculateWindBonus](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_ship_parameters_model.html#ad29557fb62b7b4b875099860f95fbca4) ([IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) shipOrigin, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) captain, float baseSailForceMagnitude) |
| float | [CalculateOarForceMultiplier](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_ship_parameters_model.html#a861e7a02d087c59677a0f1e7aa0ce43e) ([Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) pilotAgent, float baseOarForce) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_ship_parameters_model.html#a2f15e7734b1b22ad5fcd137df5d837cc)CalculateMainDeckCrewSize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.ComponentInterfaces.MissionShipParametersModel.CalculateMainDeckCrewSize | ( | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *shipOrigin*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *captain* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_ship_parameters_model.html#ad29557fb62b7b4b875099860f95fbca4)CalculateWindBonus()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.ComponentInterfaces.MissionShipParametersModel.CalculateWindBonus | ( | [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) | *shipOrigin*, | |  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *captain*, | |  |  | float | *baseSailForceMagnitude* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_component_interfaces_1_1_mission_ship_parameters_model.html#a861e7a02d087c59677a0f1e7aa0ce43e)CalculateOarForceMultiplier()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.ComponentInterfaces.MissionShipParametersModel.CalculateOarForceMultiplier | ( | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *pilotAgent*, | |  |  | float | *baseOarForce* ) | | abstract |

