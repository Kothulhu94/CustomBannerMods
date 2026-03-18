--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_patrol_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementPatrolModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementPatrolModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_patrol_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetPatrolPartySpawnDuration](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_patrol_model.html#a03d9bc88e194b1dd1aadc2fd03fc54e6) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool naval) |
| bool | [CanSettlementHavePatrolParties](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_patrol_model.html#a91e4e50d3b96979a16a8fd0003a78a90) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool naval) |
| [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [GetPartyTemplateForPatrolParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_patrol_model.html#aec61861af16af10913cd37b2cafc78b9) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool naval) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_patrol_model.html#a03d9bc88e194b1dd1aadc2fd03fc54e6)GetPatrolPartySpawnDuration()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementPatrolModel.GetPatrolPartySpawnDuration | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *naval* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_patrol_model.html#a91e4e50d3b96979a16a8fd0003a78a90)CanSettlementHavePatrolParties()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementPatrolModel.CanSettlementHavePatrolParties | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *naval* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_patrol_model.html#aec61861af16af10913cd37b2cafc78b9)GetPartyTemplateForPatrolParty()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementPatrolModel.GetPartyTemplateForPatrolParty | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *naval* ) | | abstract |

