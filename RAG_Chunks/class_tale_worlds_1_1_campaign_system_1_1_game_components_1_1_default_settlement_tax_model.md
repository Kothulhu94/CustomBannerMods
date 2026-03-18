--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetTownTaxRatio](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#ab7bf8e5b0378b8dca3c7b470545c7e20) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override float | [GetVillageTaxRatio](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#a357d687d87d8f9d902a1ff240170e17d) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| override float | [GetTownCommissionChangeBasedOnSecurity](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#a428fa6794814b0a4d74c6c4e06930983) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, float commission) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateTownTax](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#ab25d3f5198b311f8305c03607e102a8f) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeDescriptions=false) |
| override int | [CalculateVillageTaxFromIncome](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#af2a32e2b1be22f5170b616c655852087) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village, int marketIncome) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html) | |
| float | [GetTownTaxRatio](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a115d89b7123572f2995efdce1f6bd887) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| float | [GetVillageTaxRatio](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a5436451e9663654959aada1cde3e4e81) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| float | [GetTownCommissionChangeBasedOnSecurity](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a62f974e01b6f72462269919c77189953) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, float commission) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateTownTax](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a49a923326b826531399a633fa0c7bfe6) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeDescriptions=false) |
| int | [CalculateVillageTaxFromIncome](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#ad08fd6e8dba8e6ad40b729e5cc0c0598) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village, int marketIncome) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override float | [SettlementCommissionRateTown](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#a3149c6eeec970148b69513eacf7892e0) `[get]` |
| override float | [SettlementCommissionRateVillage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#a4bce848359c28c91c331ad66ffe40a35) `[get]` |
| override int | [SettlementCommissionDecreaseSecurityThreshold](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#aab0d5ec0e7aefb668a3dfa5241e0cd52) `[get]` |
| override int | [MaximumDecreaseBasedOnSecuritySecurity](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#a14d4a8d60ecdcf6af944cd2e59f60d1d) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html) | |
| float | [SettlementCommissionRateTown](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#aef518fca914e509fe34d983485bd9e2b) `[get]` |
| float | [SettlementCommissionRateVillage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a7d055b41896bf1875771fd2df25f2336) `[get]` |
| int | [SettlementCommissionDecreaseSecurityThreshold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#ab85a3f2f71b7a9decdb2578e2f97c19e) `[get]` |
| int | [MaximumDecreaseBasedOnSecuritySecurity](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#acf34260f8b513f0e8a94d5720841f508) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#ab7bf8e5b0378b8dca3c7b470545c7e20)GetTownTaxRatio()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel.GetTownTaxRatio | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#a357d687d87d8f9d902a1ff240170e17d)GetVillageTaxRatio()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel.GetVillageTaxRatio | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#a428fa6794814b0a4d74c6c4e06930983)GetTownCommissionChangeBasedOnSecurity()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel.GetTownCommissionChangeBasedOnSecurity | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | float | *commission* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#ab25d3f5198b311f8305c03607e102a8f)CalculateTownTax()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel.CalculateTownTax | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#af2a32e2b1be22f5170b616c655852087)CalculateVillageTaxFromIncome()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel.CalculateVillageTaxFromIncome | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village*, |
|  |  | int | *marketIncome* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#a3149c6eeec970148b69513eacf7892e0)SettlementCommissionRateTown
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel.SettlementCommissionRateTown | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#a4bce848359c28c91c331ad66ffe40a35)SettlementCommissionRateVillage
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel.SettlementCommissionRateVillage | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#aab0d5ec0e7aefb668a3dfa5241e0cd52)SettlementCommissionDecreaseSecurityThreshold
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel.SettlementCommissionDecreaseSecurityThreshold | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html#a14d4a8d60ecdcf6af944cd2e59f60d1d)MaximumDecreaseBasedOnSecuritySecurity
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel.MaximumDecreaseBasedOnSecuritySecurity | | get |

