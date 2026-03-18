--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementEconomyModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementEconomyModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_economy_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#a71f41714a7b9edfe8909048732a45702)GetEstimatedDemandForCategory()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementEconomyModel.GetEstimatedDemandForCategory | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [ItemData](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_item_data.html) | *itemData*, | |  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *category* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#ab6a8bcd32fab3124b692bce06cfa37c7)GetDailyDemandForCategory()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementEconomyModel.GetDailyDemandForCategory | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *category*, | |  |  | int | *extraProsperity* = 0 ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#a905bdec82fe81b2f6a207e84ca14bd4d)GetDemandChangeFromValue()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementEconomyModel.GetDemandChangeFromValue | ( | float | *purchaseValue* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#aa4751e19190ea1f39be7da60fb8aebca)GetSupplyDemandForCategory()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ValueTuple< float, float > TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementEconomyModel.GetSupplyDemandForCategory | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *category*, | |  |  | float | *dailySupply*, | |  |  | float | *dailyDemand*, | |  |  | float | *oldSupply*, | |  |  | float | *oldDemand* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#a9b8597c986817e2d23786e61e76b0f10)GetTownGoldChange()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementEconomyModel.GetTownGoldChange | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_economy_model.html#a0ec9105de07389deacc7b8d0f21c7791)CalculateDailySettlementBudgetForItemCategory()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementEconomyModel.CalculateDailySettlementBudgetForItemCategory | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | float | *demand*, | |  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *category* ) | | abstract |

