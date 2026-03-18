--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetLootedNearbyPartySecurityEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a8ef35b7de1fa7c06ca91e80a5d02a905) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, float sumOfAttackedPartyStrengths) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateSecurityChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a3cdff9f6a1eccc7fc83512b8721c1a6a) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeDescriptions=false) |
| float | [GetNearbyBanditPartyDefeatedSecurityEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a75d0569e5723fdc7a749c3330913d525) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, float sumOfAttackedPartyStrengths) |
| void | [CalculateGoldGainDueToHighSecurity](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a5edaa128b7e873f26448e560cf71f6eb) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| void | [CalculateGoldCutDueToLowSecurity](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a288e2a9e6fa7aae1ec91b5755e41b993) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [MaximumSecurityInSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a915fa0487c4c99a52e057dcd466d60eb) `[get]` |
| int | [SecurityDriftMedium](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#ae5bf7c16fe83ad7e983509b5be36b919) `[get]` |
| float | [MapEventSecurityEffectRadius](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a0b6373e94112ac012b2781206994c811) `[get]` |
| float | [HideoutClearedSecurityEffectRadius](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#ad74f6feb8c277040cdeb0708327c8b17) `[get]` |
| int | [HideoutClearedSecurityGain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#ad866723e731e9c58b9502f02b204a85d) `[get]` |
| int | [ThresholdForTaxCorruption](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a9443af544bef3c96c9f1ce2475b01efc) `[get]` |
| int | [ThresholdForHigherTaxCorruption](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#aece81a582011243ffa2a2d305c0076e5) `[get]` |
| int | [ThresholdForTaxBoost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a5a439bf4bd66d13a7a6c92941c3c0adc) `[get]` |
| int | [SettlementTaxBoostPercentage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#abb21ee179fdecceb45778b132d21a355) `[get]` |
| int | [SettlementTaxPenaltyPercentage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#acb58c54840ef81a4b8883565c680448e) `[get]` |
| int | [ThresholdForNotableRelationBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#aff62f8a5cab2f74bd357f38fc192a5c4) `[get]` |
| int | [ThresholdForNotableRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a9a0d308b8e5af2909b2dd96215876a51) `[get]` |
| int | [DailyNotableRelationBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#aaeb0abafb00edbefc45b33b354395b68) `[get]` |
| int | [DailyNotableRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a064a49194d3dad037a80b65b8001b542) `[get]` |
| int | [DailyNotablePowerBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#aeaa695786b8691f74dab12ab2c1c97ad) `[get]` |
| int | [DailyNotablePowerPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a1a0647215eb72843d0e5c418f43a0c7f) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a8ef35b7de1fa7c06ca91e80a5d02a905)GetLootedNearbyPartySecurityEffect()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.GetLootedNearbyPartySecurityEffect | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | float | *sumOfAttackedPartyStrengths* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a3cdff9f6a1eccc7fc83512b8721c1a6a)CalculateSecurityChange()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.CalculateSecurityChange | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a75d0569e5723fdc7a749c3330913d525)GetNearbyBanditPartyDefeatedSecurityEffect()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.GetNearbyBanditPartyDefeatedSecurityEffect | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | float | *sumOfAttackedPartyStrengths* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a5edaa128b7e873f26448e560cf71f6eb)CalculateGoldGainDueToHighSecurity()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.CalculateGoldGainDueToHighSecurity | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a288e2a9e6fa7aae1ec91b5755e41b993)CalculateGoldCutDueToLowSecurity()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.CalculateGoldCutDueToLowSecurity | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a915fa0487c4c99a52e057dcd466d60eb)MaximumSecurityInSettlement
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.MaximumSecurityInSettlement | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#ae5bf7c16fe83ad7e983509b5be36b919)SecurityDriftMedium
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.SecurityDriftMedium | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a0b6373e94112ac012b2781206994c811)MapEventSecurityEffectRadius
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.MapEventSecurityEffectRadius | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#ad74f6feb8c277040cdeb0708327c8b17)HideoutClearedSecurityEffectRadius
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.HideoutClearedSecurityEffectRadius | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#ad866723e731e9c58b9502f02b204a85d)HideoutClearedSecurityGain
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.HideoutClearedSecurityGain | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a9443af544bef3c96c9f1ce2475b01efc)ThresholdForTaxCorruption
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.ThresholdForTaxCorruption | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#aece81a582011243ffa2a2d305c0076e5)ThresholdForHigherTaxCorruption
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.ThresholdForHigherTaxCorruption | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a5a439bf4bd66d13a7a6c92941c3c0adc)ThresholdForTaxBoost
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.ThresholdForTaxBoost | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#abb21ee179fdecceb45778b132d21a355)SettlementTaxBoostPercentage
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.SettlementTaxBoostPercentage | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#acb58c54840ef81a4b8883565c680448e)SettlementTaxPenaltyPercentage
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.SettlementTaxPenaltyPercentage | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#aff62f8a5cab2f74bd357f38fc192a5c4)ThresholdForNotableRelationBonus
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.ThresholdForNotableRelationBonus | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a9a0d308b8e5af2909b2dd96215876a51)ThresholdForNotableRelationPenalty
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.ThresholdForNotableRelationPenalty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#aaeb0abafb00edbefc45b33b354395b68)DailyNotableRelationBonus
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.DailyNotableRelationBonus | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a064a49194d3dad037a80b65b8001b542)DailyNotableRelationPenalty
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.DailyNotableRelationPenalty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#aeaa695786b8691f74dab12ab2c1c97ad)DailyNotablePowerBonus
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.DailyNotablePowerBonus | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html#a1a0647215eb72843d0e5c418f43a0c7f)DailyNotablePowerPenalty
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel.DailyNotablePowerPenalty | | getabstract |

