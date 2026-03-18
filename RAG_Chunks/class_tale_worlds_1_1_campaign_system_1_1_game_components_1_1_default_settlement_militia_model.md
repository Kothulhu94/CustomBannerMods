--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_militia_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementMilitiaModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementMilitiaModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_militia_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [MilitiaToSpawnAfterSiege](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_militia_model.html#aff0cb9c95cc402d687ad5d48c4fa7741) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateMilitiaChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_militia_model.html#a3304a934e565b8ea3a28081d2de49265) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includeDescriptions=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateVeteranMilitiaSpawnChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_militia_model.html#a4cc186aba62fa45bd261c5b13e7cd41d) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override void | [CalculateMilitiaSpawnRate](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_militia_model.html#a715d011bca0b6c4967e18d71b067f021) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out float meleeTroopRate, out float rangedTroopRate) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementMilitiaModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_militia_model.html) | |
| int | [MilitiaToSpawnAfterSiege](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_militia_model.html#a048e6e1cac38a346ffedbfd8bd4921f3) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateMilitiaChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_militia_model.html#a04fdbb9e0e713b3d03ff59f27bd259bb) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includeDescriptions=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateVeteranMilitiaSpawnChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_militia_model.html#a2bb3eca9484633500b27e6a108ab5ba1) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [CalculateMilitiaSpawnRate](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_militia_model.html#acceb3be64aa2894c3e3460c4f8576827) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out float meleeTroopRate, out float rangedTroopRate) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_militia_model.html#aff0cb9c95cc402d687ad5d48c4fa7741)MilitiaToSpawnAfterSiege()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementMilitiaModel.MilitiaToSpawnAfterSiege | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_militia_model.html#a3304a934e565b8ea3a28081d2de49265)CalculateMilitiaChange()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementMilitiaModel.CalculateMilitiaChange | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_militia_model.html#a4cc186aba62fa45bd261c5b13e7cd41d)CalculateVeteranMilitiaSpawnChance()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementMilitiaModel.CalculateVeteranMilitiaSpawnChance | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_militia_model.html#a715d011bca0b6c4967e18d71b067f021)CalculateMilitiaSpawnRate()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementMilitiaModel.CalculateMilitiaSpawnRate | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | out float | *meleeTroopRate*, |
|  |  | out float | *rangedTroopRate* ) |

