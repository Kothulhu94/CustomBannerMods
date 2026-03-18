--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementFoodModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementFoodModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateTownFoodStocksChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a7ecb52aaa3b7cad90550bdb7c7bcf9da) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeMarketStocks=true, bool includeDescriptions=false) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [FoodStocksUpperLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a15a479b11472da7a882aeabe1467a565) `[get]` |
| int | [NumberOfProsperityToEatOneFood](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#ac5f445eadb017a83171626e90556e390) `[get]` |
| int | [NumberOfMenOnGarrisonToEatOneFood](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a1e4225103d2d85f2b44fb746a74ea209) `[get]` |
| int | [CastleFoodStockUpperLimitBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a6059446d08a8adbcc820fe581372950d) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a7ecb52aaa3b7cad90550bdb7c7bcf9da)CalculateTownFoodStocksChange()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementFoodModel.CalculateTownFoodStocksChange | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *includeMarketStocks* = true, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a15a479b11472da7a882aeabe1467a565)FoodStocksUpperLimit
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementFoodModel.FoodStocksUpperLimit | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#ac5f445eadb017a83171626e90556e390)NumberOfProsperityToEatOneFood
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementFoodModel.NumberOfProsperityToEatOneFood | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a1e4225103d2d85f2b44fb746a74ea209)NumberOfMenOnGarrisonToEatOneFood
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementFoodModel.NumberOfMenOnGarrisonToEatOneFood | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a6059446d08a8adbcc820fe581372950d)CastleFoodStockUpperLimitBonus
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementFoodModel.CastleFoodStockUpperLimitBonus | | getabstract |

