--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeStrategyActionModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeStrategyActionModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_strategy_action_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [SiegeAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3ed) {     [ConstructNewSiegeEngine](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3edadd261601acc4dbb8754db06e17072625) ,     [DeploySiegeEngineFromReserve](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3eda77340107158d82309ab085206e627784) ,     [MoveSiegeEngineToReserve](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3eda631cd30799e26d61cc7258c2ac4d88f8) ,     [RemoveDeployedSiegeEngine](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3eda1afd48d72ccee3ed0897369296bd1db0) ,     [Hold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3edabcd8db575b47c838e5d551e3973db4ac)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [GetLogicalActionForStrategy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#aca3e5935485f5decaa156ff9a62e1b57) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) side, out [SiegeAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3ed) siegeAction, out [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, out int deploymentIndex, out int reserveIndex) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3ed)SiegeAction
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeStrategyActionModel.SiegeAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3ed) |

| Enumerator | |
| --- | --- |
| ConstructNewSiegeEngine |  |
| DeploySiegeEngineFromReserve |  |
| MoveSiegeEngineToReserve |  |
| RemoveDeployedSiegeEngine |  |
| Hold |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#aca3e5935485f5decaa156ff9a62e1b57)GetLogicalActionForStrategy()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeStrategyActionModel.GetLogicalActionForStrategy | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *side*, | |  |  | out [SiegeAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3ed) | *siegeAction*, | |  |  | out [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, | |  |  | out int | *deploymentIndex*, | |  |  | out int | *reserveIndex* ) | | abstract |

