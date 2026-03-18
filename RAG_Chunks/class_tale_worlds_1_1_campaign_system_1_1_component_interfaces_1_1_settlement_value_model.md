--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementValueModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementValueModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_value_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindMostSuitableHomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html#adaf2f322f6c05f15c23b2430b4d4b9af) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| float | [CalculateSettlementValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html#afcfb60d18f77b110c645f45eb4c49afe) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| float | [CalculateSettlementBaseValue](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html#a313443b2a784e620cfb4a217ecd532f3) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| float | [CalculateSettlementValueForEnemyHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html#ad1cc5e401e760eac3ff4847cf8947d59) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html#adaf2f322f6c05f15c23b2430b4d4b9af)FindMostSuitableHomeSettlement()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementValueModel.FindMostSuitableHomeSettlement | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html#afcfb60d18f77b110c645f45eb4c49afe)CalculateSettlementValueForFaction()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementValueModel.CalculateSettlementValueForFaction | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html#a313443b2a784e620cfb4a217ecd532f3)CalculateSettlementBaseValue()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementValueModel.CalculateSettlementBaseValue | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html#ad1cc5e401e760eac3ff4847cf8947d59)CalculateSettlementValueForEnemyHero()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementValueModel.CalculateSettlementValueForEnemyHero | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | abstract |

