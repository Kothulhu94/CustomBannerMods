--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_value_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementValueModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementValueModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [FindMostSuitableHomeSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_value_model.html#a8b433fb0c2d00489e0034b29a9950499) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override float | [CalculateSettlementBaseValue](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_value_model.html#ad2b1c66772622c5fa9d471a3de463920) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override float | [CalculateSettlementValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_value_model.html#a820856c262339945efb6d0b4b91275a6) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| override float | [CalculateSettlementValueForEnemyHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_value_model.html#adfb4523818c725e19607e590e09b885b) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementValueModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_value_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_value_model.html#a8b433fb0c2d00489e0034b29a9950499)FindMostSuitableHomeSettlement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementValueModel.FindMostSuitableHomeSettlement | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_value_model.html#ad2b1c66772622c5fa9d471a3de463920)CalculateSettlementBaseValue()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementValueModel.CalculateSettlementBaseValue | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_value_model.html#a820856c262339945efb6d0b4b91275a6)CalculateSettlementValueForFaction()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementValueModel.CalculateSettlementValueForFaction | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_value_model.html#adfb4523818c725e19607e590e09b885b)CalculateSettlementValueForEnemyHero()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementValueModel.CalculateSettlementValueForEnemyHero | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

