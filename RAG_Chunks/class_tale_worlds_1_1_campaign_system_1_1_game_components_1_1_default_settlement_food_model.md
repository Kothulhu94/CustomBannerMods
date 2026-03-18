--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementFoodModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementFoodModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateTownFoodStocksChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html#a3449387432a8f20b2b35e6d4de7a6e09) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeMarketStocks=true, bool includeDescriptions=false) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementFoodModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateTownFoodStocksChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a7ecb52aaa3b7cad90550bdb7c7bcf9da) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeMarketStocks=true, bool includeDescriptions=false) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [FoodStocksUpperLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html#a9588808907d818319aaba87ff3e8b85e) `[get]` |
| override int | [NumberOfProsperityToEatOneFood](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html#a68d63bdf33cf610043f2af3b3751d64b) `[get]` |
| override int | [NumberOfMenOnGarrisonToEatOneFood](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html#a29fbb430aa10b759c6573af37d565912) `[get]` |
| override int | [CastleFoodStockUpperLimitBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html#a1928596473abbcb999f93588df66a958) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementFoodModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html) | |
| int | [FoodStocksUpperLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a15a479b11472da7a882aeabe1467a565) `[get]` |
| int | [NumberOfProsperityToEatOneFood](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#ac5f445eadb017a83171626e90556e390) `[get]` |
| int | [NumberOfMenOnGarrisonToEatOneFood](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a1e4225103d2d85f2b44fb746a74ea209) `[get]` |
| int | [CastleFoodStockUpperLimitBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_food_model.html#a6059446d08a8adbcc820fe581372950d) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html#a3449387432a8f20b2b35e6d4de7a6e09)CalculateTownFoodStocksChange()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementFoodModel.CalculateTownFoodStocksChange | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | bool | *includeMarketStocks* = true, |
|  |  | bool | *includeDescriptions* = false ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html#a9588808907d818319aaba87ff3e8b85e)FoodStocksUpperLimit
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementFoodModel.FoodStocksUpperLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html#a68d63bdf33cf610043f2af3b3751d64b)NumberOfProsperityToEatOneFood
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementFoodModel.NumberOfProsperityToEatOneFood | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html#a29fbb430aa10b759c6573af37d565912)NumberOfMenOnGarrisonToEatOneFood
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementFoodModel.NumberOfMenOnGarrisonToEatOneFood | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_food_model.html#a1928596473abbcb999f93588df66a958)CastleFoodStockUpperLimitBonus
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementFoodModel.CastleFoodStockUpperLimitBonus | | get |

