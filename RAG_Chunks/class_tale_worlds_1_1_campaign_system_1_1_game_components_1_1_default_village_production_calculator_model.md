--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_village_production_calculator_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultVillageProductionCalculatorModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.VillageProductionCalculatorModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_village_production_calculator_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyProductionAmount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_village_production_calculator_model.html#a9f047af7f346a46b19ec1ec4d8aa84d1) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| override float | [CalculateDailyFoodProductionAmount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_village_production_calculator_model.html#ac7892531cdb942881b1d90bd9beb3fec) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| override float | [CalculateProductionSpeedOfItemCategory](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_village_production_calculator_model.html#ab221f8157707effc7ccd2f3dc8c24687) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) item) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.VillageProductionCalculatorModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_village_production_calculator_model.html) | |
| float | [CalculateProductionSpeedOfItemCategory](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_village_production_calculator_model.html#afa6db9a37ac1a8bdab24d0ad3f9bd219) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) item) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyProductionAmount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_village_production_calculator_model.html#ac08df4533b6167136c68c081780eba32) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| float | [CalculateDailyFoodProductionAmount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_village_production_calculator_model.html#aeb4ec30d7edb1422c2d1dae30adec5e1) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_village_production_calculator_model.html#a9f047af7f346a46b19ec1ec4d8aa84d1)CalculateDailyProductionAmount()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultVillageProductionCalculatorModel.CalculateDailyProductionAmount | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village*, |
|  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_village_production_calculator_model.html#ac7892531cdb942881b1d90bd9beb3fec)CalculateDailyFoodProductionAmount()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultVillageProductionCalculatorModel.CalculateDailyFoodProductionAmount | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_village_production_calculator_model.html#ab221f8157707effc7ccd2f3dc8c24687)CalculateProductionSpeedOfItemCategory()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultVillageProductionCalculatorModel.CalculateProductionSpeedOfItemCategory | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *item* | ) |  |

