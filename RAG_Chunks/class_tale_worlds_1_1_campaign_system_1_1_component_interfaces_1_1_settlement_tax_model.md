--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementTaxModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_tax_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| float | [SettlementCommissionRateTown](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#aef518fca914e509fe34d983485bd9e2b) `[get]` |
| float | [SettlementCommissionRateVillage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a7d055b41896bf1875771fd2df25f2336) `[get]` |
| int | [SettlementCommissionDecreaseSecurityThreshold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#ab85a3f2f71b7a9decdb2578e2f97c19e) `[get]` |
| int | [MaximumDecreaseBasedOnSecuritySecurity](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#acf34260f8b513f0e8a94d5720841f508) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a115d89b7123572f2995efdce1f6bd887)GetTownTaxRatio()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel.GetTownTaxRatio | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a5436451e9663654959aada1cde3e4e81)GetVillageTaxRatio()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel.GetVillageTaxRatio | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a62f974e01b6f72462269919c77189953)GetTownCommissionChangeBasedOnSecurity()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel.GetTownCommissionChangeBasedOnSecurity | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | float | *commission* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a49a923326b826531399a633fa0c7bfe6)CalculateTownTax()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel.CalculateTownTax | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#ad08fd6e8dba8e6ad40b729e5cc0c0598)CalculateVillageTaxFromIncome()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel.CalculateVillageTaxFromIncome | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village*, | |  |  | int | *marketIncome* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#aef518fca914e509fe34d983485bd9e2b)SettlementCommissionRateTown
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel.SettlementCommissionRateTown | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#a7d055b41896bf1875771fd2df25f2336)SettlementCommissionRateVillage
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel.SettlementCommissionRateVillage | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#ab85a3f2f71b7a9decdb2578e2f97c19e)SettlementCommissionDecreaseSecurityThreshold
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel.SettlementCommissionDecreaseSecurityThreshold | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_tax_model.html#acf34260f8b513f0e8a94d5720841f508)MaximumDecreaseBasedOnSecuritySecurity
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementTaxModel.MaximumDecreaseBasedOnSecuritySecurity | | getabstract |

