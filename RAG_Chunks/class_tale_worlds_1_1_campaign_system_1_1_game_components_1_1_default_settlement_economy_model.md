--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementEconomyModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementEconomyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override ValueTuple< float, float > | [GetSupplyDemandForCategory](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#aba2e9b149617545a279048bdbbf2e475) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) category, float dailySupply, float dailyDemand, float oldSupply, float oldDemand) |
| override float | [GetDailyDemandForCategory](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#a0df87d1c3063491379af33bbdfd412db) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) category, int extraProsperity) |
| override int | [GetTownGoldChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#a547dc9f9aaf51fc04ddd30b22375d42d) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override float | [CalculateDailySettlementBudgetForItemCategory](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#a5ca3afc8fd432141c438f9b1fe9d967b) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, float demand, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) category) |
| override float | [GetDemandChangeFromValue](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#a8e516c3c2c7ffcad291b6a23ca7638fa) (float purchaseValue) |
| override float | [GetEstimatedDemandForCategory](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#a1c8bb391b9d9ce03e2982dbc8f68b7a8) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [ItemData](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_item_data.html) itemData, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) category) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementEconomyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html) | |
| float | [GetEstimatedDemandForCategory](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#a71f41714a7b9edfe8909048732a45702) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [ItemData](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_item_data.html) itemData, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) category) |
| float | [GetDailyDemandForCategory](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#ab6a8bcd32fab3124b692bce06cfa37c7) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) category, int extraProsperity=0) |
| float | [GetDemandChangeFromValue](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#a905bdec82fe81b2f6a207e84ca14bd4d) (float purchaseValue) |
| ValueTuple< float, float > | [GetSupplyDemandForCategory](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#aa4751e19190ea1f39be7da60fb8aebca) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) category, float dailySupply, float dailyDemand, float oldSupply, float oldDemand) |
| int | [GetTownGoldChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#a9b8597c986817e2d23786e61e76b0f10) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| float | [CalculateDailySettlementBudgetForItemCategory](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#a0ec9105de07389deacc7b8d0f21c7791) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, float demand, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) category) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#aba2e9b149617545a279048bdbbf2e475)GetSupplyDemandForCategory()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override ValueTuple< float, float > TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementEconomyModel.GetSupplyDemandForCategory | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *category*, |
|  |  | float | *dailySupply*, |
|  |  | float | *dailyDemand*, |
|  |  | float | *oldSupply*, |
|  |  | float | *oldDemand* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#a0df87d1c3063491379af33bbdfd412db)GetDailyDemandForCategory()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementEconomyModel.GetDailyDemandForCategory | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *category*, |
|  |  | int | *extraProsperity* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#a547dc9f9aaf51fc04ddd30b22375d42d)GetTownGoldChange()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementEconomyModel.GetTownGoldChange | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#a5ca3afc8fd432141c438f9b1fe9d967b)CalculateDailySettlementBudgetForItemCategory()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementEconomyModel.CalculateDailySettlementBudgetForItemCategory | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | float | *demand*, |
|  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *category* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#a8e516c3c2c7ffcad291b6a23ca7638fa)GetDemandChangeFromValue()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementEconomyModel.GetDemandChangeFromValue | ( | float | *purchaseValue* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html#a1c8bb391b9d9ce03e2982dbc8f68b7a8)GetEstimatedDemandForCategory()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementEconomyModel.GetEstimatedDemandForCategory | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | [ItemData](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_item_data.html) | *itemData*, |
|  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *category* ) |

