--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateLoyaltyChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a7de0d5985864f6171eeeb7ca06407ab0) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeDescriptions=false) |
| void | [CalculateGoldGainDueToHighLoyalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#ac84fcae4431c7f6c7e599fb4d229a789) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| void | [CalculateGoldCutDueToLowLoyalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a76e16fe2f719c32b05dc13a4b2d48890) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [SettlementLoyaltyChangeDueToSecurityThreshold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a62e42a5d152ac2ab20db7414944fc53b) `[get]` |
| int | [MaximumLoyaltyInSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a885f0292d40626f12590c4c3069cb545) `[get]` |
| int | [LoyaltyDriftMedium](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#ade666e08b4882117e97b405331912f27) `[get]` |
| float | [HighLoyaltyProsperityEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a3ba82c1a325949d590bd7ec01f179071) `[get]` |
| int | [LowLoyaltyProsperityEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#adfc670e9abf92ae77700cb8095c8703a) `[get]` |
| int | [MilitiaBoostPercentage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a434c13ba5a391f87349b1bebb4147e44) `[get]` |
| float | [HighSecurityLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a2d4ee5de8dfe85488b00f8523d10f9ae) `[get]` |
| float | [LowSecurityLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a484c8af224cf793eea658d4d729179ad) `[get]` |
| float | [GovernorSameCultureLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#abf71558e16e9d0fd66229161a7ce7298) `[get]` |
| float | [GovernorDifferentCultureLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a5a4c97ed8951350d0e29c96043322d99) `[get]` |
| float | [SettlementOwnerDifferentCultureLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#ad25fff5fd643c4b9392ea64eee98616a) `[get]` |
| int | [ThresholdForTaxBoost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a3f6d0f030d04d438c8f1ddc7599958f9) `[get]` |
| int | [RebellionStartLoyaltyThreshold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a83f6e25960c987fb7335685c0ba2e48a) `[get]` |
| int | [ThresholdForTaxCorruption](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a586d3275ba4925f1801b3b1b12663dcc) `[get]` |
| int | [ThresholdForHigherTaxCorruption](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a16764907aadb81cb0a08aa16f1b85132) `[get]` |
| int | [ThresholdForProsperityBoost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a110e59038a9424aa42bae5213f29f645) `[get]` |
| int | [ThresholdForProsperityPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a367a0268a449826599553cfc3294f2e9) `[get]` |
| int | [AdditionalStarvationPenaltyStartDay](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#ad3454ef6dca1178194a353e8c2f54ca9) `[get]` |
| int | [AdditionalStarvationLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a359f2c1d9e46c2f13ddf45e53740314f) `[get]` |
| int | [RebelliousStateStartLoyaltyThreshold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a0ebe0c247b1e95e0fe3fcc2cd8091153) `[get]` |
| int | [LoyaltyBoostAfterRebellionStartValue](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a86bbf0c57b5029bba3ace14aebdc7ae9) `[get]` |
| float | [ThresholdForNotableRelationBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a3e69179f305ca37f29d9eccbc2f1a624) `[get]` |
| int | [DailyNotableRelationBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a0d4bfe20326b3ba11ccb469e5d1a96b7) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a7de0d5985864f6171eeeb7ca06407ab0)CalculateLoyaltyChange()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.CalculateLoyaltyChange | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#ac84fcae4431c7f6c7e599fb4d229a789)CalculateGoldGainDueToHighLoyalty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.CalculateGoldGainDueToHighLoyalty | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a76e16fe2f719c32b05dc13a4b2d48890)CalculateGoldCutDueToLowLoyalty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.CalculateGoldCutDueToLowLoyalty | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a62e42a5d152ac2ab20db7414944fc53b)SettlementLoyaltyChangeDueToSecurityThreshold
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.SettlementLoyaltyChangeDueToSecurityThreshold | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a885f0292d40626f12590c4c3069cb545)MaximumLoyaltyInSettlement
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.MaximumLoyaltyInSettlement | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#ade666e08b4882117e97b405331912f27)LoyaltyDriftMedium
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.LoyaltyDriftMedium | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a3ba82c1a325949d590bd7ec01f179071)HighLoyaltyProsperityEffect
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.HighLoyaltyProsperityEffect | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#adfc670e9abf92ae77700cb8095c8703a)LowLoyaltyProsperityEffect
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.LowLoyaltyProsperityEffect | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a434c13ba5a391f87349b1bebb4147e44)MilitiaBoostPercentage
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.MilitiaBoostPercentage | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a2d4ee5de8dfe85488b00f8523d10f9ae)HighSecurityLoyaltyEffect
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.HighSecurityLoyaltyEffect | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a484c8af224cf793eea658d4d729179ad)LowSecurityLoyaltyEffect
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.LowSecurityLoyaltyEffect | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#abf71558e16e9d0fd66229161a7ce7298)GovernorSameCultureLoyaltyEffect
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.GovernorSameCultureLoyaltyEffect | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a5a4c97ed8951350d0e29c96043322d99)GovernorDifferentCultureLoyaltyEffect
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.GovernorDifferentCultureLoyaltyEffect | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#ad25fff5fd643c4b9392ea64eee98616a)SettlementOwnerDifferentCultureLoyaltyEffect
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.SettlementOwnerDifferentCultureLoyaltyEffect | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a3f6d0f030d04d438c8f1ddc7599958f9)ThresholdForTaxBoost
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.ThresholdForTaxBoost | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a83f6e25960c987fb7335685c0ba2e48a)RebellionStartLoyaltyThreshold
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.RebellionStartLoyaltyThreshold | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a586d3275ba4925f1801b3b1b12663dcc)ThresholdForTaxCorruption
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.ThresholdForTaxCorruption | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a16764907aadb81cb0a08aa16f1b85132)ThresholdForHigherTaxCorruption
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.ThresholdForHigherTaxCorruption | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a110e59038a9424aa42bae5213f29f645)ThresholdForProsperityBoost
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.ThresholdForProsperityBoost | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a367a0268a449826599553cfc3294f2e9)ThresholdForProsperityPenalty
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.ThresholdForProsperityPenalty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#ad3454ef6dca1178194a353e8c2f54ca9)AdditionalStarvationPenaltyStartDay
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.AdditionalStarvationPenaltyStartDay | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a359f2c1d9e46c2f13ddf45e53740314f)AdditionalStarvationLoyaltyEffect
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.AdditionalStarvationLoyaltyEffect | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a0ebe0c247b1e95e0fe3fcc2cd8091153)RebelliousStateStartLoyaltyThreshold
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.RebelliousStateStartLoyaltyThreshold | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a86bbf0c57b5029bba3ace14aebdc7ae9)LoyaltyBoostAfterRebellionStartValue
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.LoyaltyBoostAfterRebellionStartValue | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a3e69179f305ca37f29d9eccbc2f1a624)ThresholdForNotableRelationBonus
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.ThresholdForNotableRelationBonus | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a0d4bfe20326b3ba11ccb469e5d1a96b7)DailyNotableRelationBonus
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel.DailyNotableRelationBonus | | getabstract |

