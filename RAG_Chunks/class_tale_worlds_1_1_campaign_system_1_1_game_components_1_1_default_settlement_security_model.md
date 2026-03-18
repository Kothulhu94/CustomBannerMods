--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateSecurityChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#aed6efe20b0543721df096c6c5a9340d8) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool includeDescriptions=false) |
| override float | [GetLootedNearbyPartySecurityEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a98ed36ef07b2455f776a95c74d178db9) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, float sumOfAttackedPartyStrengths) |
| override float | [GetNearbyBanditPartyDefeatedSecurityEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#ab9fc89d30a5f6e859af6283d5c9b772d) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, float sumOfAttackedPartyStrengths) |
| override void | [CalculateGoldGainDueToHighSecurity](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#ad895920f63d0c1d3effab6189d677ec1) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| override void | [CalculateGoldCutDueToLowSecurity](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a52c9311f83113eed531207775f47798c) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) explainedNumber) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html) | |
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
| override int | [MaximumSecurityInSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a0f8aaece7a4a27665f9cf6f9af9681fa) `[get]` |
| override int | [SecurityDriftMedium](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#ad6c18644432e4a155d45a5b198ab797e) `[get]` |
| override float | [MapEventSecurityEffectRadius](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a1bbecb7e24b24a4feffe2e9363739939) `[get]` |
| override float | [HideoutClearedSecurityEffectRadius](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a54809f5be4c81a762ed5f7392bbe6a59) `[get]` |
| override int | [HideoutClearedSecurityGain](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#afec2b1ac2b2cbf1efd4281459f7ce2f2) `[get]` |
| override int | [ThresholdForTaxCorruption](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a550ef5fe0038bd90f85eb606d481a904) `[get]` |
| override int | [ThresholdForHigherTaxCorruption](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a076d259a0eb2c4d187e0f8bbc79877cf) `[get]` |
| override int | [ThresholdForTaxBoost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#aecd0d754b096637a48faed4acc49bb36) `[get]` |
| override int | [SettlementTaxBoostPercentage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a2d1fff16b02d6cac8a95740af0111af0) `[get]` |
| override int | [SettlementTaxPenaltyPercentage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a4a6990013d38b05af23493a18f7b01df) `[get]` |
| override int | [ThresholdForNotableRelationBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a930f7e9209a25bd33619cca45785e068) `[get]` |
| override int | [ThresholdForNotableRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#aa729ee3684764d2b8342a61805c48332) `[get]` |
| override int | [DailyNotableRelationBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a1b274ee75b4ed4a19e62716b9bb7ffcd) `[get]` |
| override int | [DailyNotableRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a53aac4ae435b4848f752125ef62fffd2) `[get]` |
| override int | [DailyNotablePowerBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a6fd7a3fff1b06ff7da00e8df035be8d8) `[get]` |
| override int | [DailyNotablePowerPenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#ab3c41452163de2f67971d8ae4e8dbcd2) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementSecurityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_security_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#aed6efe20b0543721df096c6c5a9340d8)CalculateSecurityChange()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.CalculateSecurityChange | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a98ed36ef07b2455f776a95c74d178db9)GetLootedNearbyPartySecurityEffect()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.GetLootedNearbyPartySecurityEffect | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | float | *sumOfAttackedPartyStrengths* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#ab9fc89d30a5f6e859af6283d5c9b772d)GetNearbyBanditPartyDefeatedSecurityEffect()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.GetNearbyBanditPartyDefeatedSecurityEffect | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | float | *sumOfAttackedPartyStrengths* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#ad895920f63d0c1d3effab6189d677ec1)CalculateGoldGainDueToHighSecurity()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.CalculateGoldGainDueToHighSecurity | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a52c9311f83113eed531207775f47798c)CalculateGoldCutDueToLowSecurity()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.CalculateGoldCutDueToLowSecurity | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | ref [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *explainedNumber* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a0f8aaece7a4a27665f9cf6f9af9681fa)MaximumSecurityInSettlement
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.MaximumSecurityInSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#ad6c18644432e4a155d45a5b198ab797e)SecurityDriftMedium
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.SecurityDriftMedium | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a1bbecb7e24b24a4feffe2e9363739939)MapEventSecurityEffectRadius
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.MapEventSecurityEffectRadius | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a54809f5be4c81a762ed5f7392bbe6a59)HideoutClearedSecurityEffectRadius
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.HideoutClearedSecurityEffectRadius | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#afec2b1ac2b2cbf1efd4281459f7ce2f2)HideoutClearedSecurityGain
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.HideoutClearedSecurityGain | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a550ef5fe0038bd90f85eb606d481a904)ThresholdForTaxCorruption
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.ThresholdForTaxCorruption | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a076d259a0eb2c4d187e0f8bbc79877cf)ThresholdForHigherTaxCorruption
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.ThresholdForHigherTaxCorruption | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#aecd0d754b096637a48faed4acc49bb36)ThresholdForTaxBoost
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.ThresholdForTaxBoost | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a2d1fff16b02d6cac8a95740af0111af0)SettlementTaxBoostPercentage
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.SettlementTaxBoostPercentage | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a4a6990013d38b05af23493a18f7b01df)SettlementTaxPenaltyPercentage
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.SettlementTaxPenaltyPercentage | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a930f7e9209a25bd33619cca45785e068)ThresholdForNotableRelationBonus
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.ThresholdForNotableRelationBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#aa729ee3684764d2b8342a61805c48332)ThresholdForNotableRelationPenalty
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.ThresholdForNotableRelationPenalty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a1b274ee75b4ed4a19e62716b9bb7ffcd)DailyNotableRelationBonus
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.DailyNotableRelationBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a53aac4ae435b4848f752125ef62fffd2)DailyNotableRelationPenalty
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.DailyNotableRelationPenalty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#a6fd7a3fff1b06ff7da00e8df035be8d8)DailyNotablePowerBonus
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.DailyNotablePowerBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_security_model.html#ab3c41452163de2f67971d8ae4e8dbcd2)DailyNotablePowerPenalty
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementSecurityModel.DailyNotablePowerPenalty | | get |

