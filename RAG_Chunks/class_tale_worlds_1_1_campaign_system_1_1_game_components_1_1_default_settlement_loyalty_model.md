--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateLoyaltyChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a51c555ec464da4210d9f48e2e9b3e0f3) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeDescriptions=false) |
| override void | [CalculateGoldGainDueToHighLoyalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a9ff07c36767605a6930bd4009fcff7ba) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| override void | [CalculateGoldCutDueToLowLoyalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a68d3e8b30f5a182474899245e0d8e5e5) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateLoyaltyChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a7de0d5985864f6171eeeb7ca06407ab0) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeDescriptions=false) |
| void | [CalculateGoldGainDueToHighLoyalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#ac84fcae4431c7f6c7e599fb4d229a789) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| void | [CalculateGoldCutDueToLowLoyalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html#a76e16fe2f719c32b05dc13a4b2d48890) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override float | [HighLoyaltyProsperityEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a5de3773ecad09b5b3ab02508b016e2cd) `[get]` |
| override int | [LowLoyaltyProsperityEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#af57b84bb456bb0557b28ca0e3abd9e5a) `[get]` |
| override int | [ThresholdForTaxBoost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a52e03018f65866bb360c5106f3ee62cb) `[get]` |
| override int | [ThresholdForTaxCorruption](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a13a8f2a15832b648f359f549294c8baa) `[get]` |
| override int | [ThresholdForHigherTaxCorruption](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#afd0f936842a1b3e71e76309b21d6712f) `[get]` |
| override int | [ThresholdForProsperityBoost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a516ce167cad04ff01a0c1e400a7710f0) `[get]` |
| override int | [ThresholdForProsperityPenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a886f2f226a12aab1bb5e1ca8c3cb0e20) `[get]` |
| override int | [AdditionalStarvationPenaltyStartDay](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#aa7dc0fd9910686ec7458bd8bc42e6e53) `[get]` |
| override int | [AdditionalStarvationLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a6c8eb2110a2c93f5c89fbc761d31ea50) `[get]` |
| override int | [RebellionStartLoyaltyThreshold](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a8e10521b3120376cc2779c032d9919ef) `[get]` |
| override int | [RebelliousStateStartLoyaltyThreshold](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#ada9d803394d904b06bad91b717020976) `[get]` |
| override int | [LoyaltyBoostAfterRebellionStartValue](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#ac67dd9597e1229b0415e67f2837c0ec5) `[get]` |
| override int | [MilitiaBoostPercentage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#aa16cda9ec90b5a1c9911ff41ddbf44ea) `[get]` |
| override float | [ThresholdForNotableRelationBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a1c05222976846909d5e546d60831176b) `[get]` |
| override int | [DailyNotableRelationBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#afb03982a2654cdd16a09edb647e82434) `[get]` |
| override int | [SettlementLoyaltyChangeDueToSecurityThreshold](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a386dee4b7ce2fddccd0812bf257a8f44) `[get]` |
| override int | [MaximumLoyaltyInSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a9513d988d782f5d52c14129f891f7faf) `[get]` |
| override int | [LoyaltyDriftMedium](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#ad23f57fe8dce8b6abfd656db2bd6f458) `[get]` |
| override float | [HighSecurityLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a847d930963ab9c0e68990a9896512915) `[get]` |
| override float | [LowSecurityLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a140f30bae4a9176f5c92a8264bff77d9) `[get]` |
| override float | [GovernorSameCultureLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#ae938b1164ab275276c99fd8222fb49f3) `[get]` |
| override float | [GovernorDifferentCultureLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a645aacb276fe97c2bfa2281b36d527fc) `[get]` |
| override float | [SettlementOwnerDifferentCultureLoyaltyEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#acba01917291363363be42c3d6288e3e2) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementLoyaltyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_loyalty_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a51c555ec464da4210d9f48e2e9b3e0f3)CalculateLoyaltyChange()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.CalculateLoyaltyChange | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a9ff07c36767605a6930bd4009fcff7ba)CalculateGoldGainDueToHighLoyalty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.CalculateGoldGainDueToHighLoyalty | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a68d3e8b30f5a182474899245e0d8e5e5)CalculateGoldCutDueToLowLoyalty()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.CalculateGoldCutDueToLowLoyalty | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a5de3773ecad09b5b3ab02508b016e2cd)HighLoyaltyProsperityEffect
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.HighLoyaltyProsperityEffect | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#af57b84bb456bb0557b28ca0e3abd9e5a)LowLoyaltyProsperityEffect
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.LowLoyaltyProsperityEffect | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a52e03018f65866bb360c5106f3ee62cb)ThresholdForTaxBoost
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.ThresholdForTaxBoost | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a13a8f2a15832b648f359f549294c8baa)ThresholdForTaxCorruption
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.ThresholdForTaxCorruption | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#afd0f936842a1b3e71e76309b21d6712f)ThresholdForHigherTaxCorruption
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.ThresholdForHigherTaxCorruption | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a516ce167cad04ff01a0c1e400a7710f0)ThresholdForProsperityBoost
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.ThresholdForProsperityBoost | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a886f2f226a12aab1bb5e1ca8c3cb0e20)ThresholdForProsperityPenalty
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.ThresholdForProsperityPenalty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#aa7dc0fd9910686ec7458bd8bc42e6e53)AdditionalStarvationPenaltyStartDay
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.AdditionalStarvationPenaltyStartDay | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a6c8eb2110a2c93f5c89fbc761d31ea50)AdditionalStarvationLoyaltyEffect
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.AdditionalStarvationLoyaltyEffect | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a8e10521b3120376cc2779c032d9919ef)RebellionStartLoyaltyThreshold
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.RebellionStartLoyaltyThreshold | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#ada9d803394d904b06bad91b717020976)RebelliousStateStartLoyaltyThreshold
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.RebelliousStateStartLoyaltyThreshold | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#ac67dd9597e1229b0415e67f2837c0ec5)LoyaltyBoostAfterRebellionStartValue
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.LoyaltyBoostAfterRebellionStartValue | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#aa16cda9ec90b5a1c9911ff41ddbf44ea)MilitiaBoostPercentage
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.MilitiaBoostPercentage | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a1c05222976846909d5e546d60831176b)ThresholdForNotableRelationBonus
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.ThresholdForNotableRelationBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#afb03982a2654cdd16a09edb647e82434)DailyNotableRelationBonus
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.DailyNotableRelationBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a386dee4b7ce2fddccd0812bf257a8f44)SettlementLoyaltyChangeDueToSecurityThreshold
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.SettlementLoyaltyChangeDueToSecurityThreshold | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a9513d988d782f5d52c14129f891f7faf)MaximumLoyaltyInSettlement
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.MaximumLoyaltyInSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#ad23f57fe8dce8b6abfd656db2bd6f458)LoyaltyDriftMedium
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.LoyaltyDriftMedium | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a847d930963ab9c0e68990a9896512915)HighSecurityLoyaltyEffect
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.HighSecurityLoyaltyEffect | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a140f30bae4a9176f5c92a8264bff77d9)LowSecurityLoyaltyEffect
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.LowSecurityLoyaltyEffect | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#ae938b1164ab275276c99fd8222fb49f3)GovernorSameCultureLoyaltyEffect
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.GovernorSameCultureLoyaltyEffect | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#a645aacb276fe97c2bfa2281b36d527fc)GovernorDifferentCultureLoyaltyEffect
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.GovernorDifferentCultureLoyaltyEffect | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_loyalty_model.html#acba01917291363363be42c3d6288e3e2)SettlementOwnerDifferentCultureLoyaltyEffect
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementLoyaltyModel.SettlementOwnerDifferentCultureLoyaltyEffect | | get |

