--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_patrol_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementPatrolModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementPatrolModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_patrol_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetPatrolPartySpawnDuration](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_patrol_model.html#a7a33ff429b30d5a9d0ab36ff1146447c) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool naval) |
| override bool | [CanSettlementHavePatrolParties](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_patrol_model.html#a749c50c128f48fec88b61c634c9600b1) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool naval) |
| override [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | [GetPartyTemplateForPatrolParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_patrol_model.html#ae5e0f301228d3a03bbcee1ff919b9249) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool naval) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementPatrolModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_patrol_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_patrol_model.html#a7a33ff429b30d5a9d0ab36ff1146447c)GetPatrolPartySpawnDuration()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementPatrolModel.GetPatrolPartySpawnDuration | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *naval* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_patrol_model.html#a749c50c128f48fec88b61c634c9600b1)CanSettlementHavePatrolParties()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementPatrolModel.CanSettlementHavePatrolParties | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *naval* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_patrol_model.html#ae5e0f301228d3a03bbcee1ff919b9249)GetPartyTemplateForPatrolParty()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementPatrolModel.GetPartyTemplateForPatrolParty | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *naval* ) |

