--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.TradeAgreementModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultTradeAgreementModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetTradeAgreementDurationInYears](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html#accdc0953ccfd29ebec63033de6648647) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) iniatatingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) otherKingdom) |
| int | [GetMaximumTradeAgreementCount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html#ae4655b537dd3176b5ba37182db7fb443) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| int | [GetInfluenceCostOfProposingTradeAgreement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html#a822efac0449f9e366a5f0d63584874f7) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| float | [GetScoreOfStartingTradeAgreement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html#a42d3ea8a97cf2d498a0ad681d25f7d43) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) targetKingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation, bool includeExplanation=false) |
| bool | [CanMakeTradeAgreement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html#a8fc0b90c484f6fa09b49b908b8c4a8d4) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) other, bool checkOtherSideTradeSupport, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason, bool includeReason=false) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html#accdc0953ccfd29ebec63033de6648647)GetTradeAgreementDurationInYears()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.TradeAgreementModel.GetTradeAgreementDurationInYears | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *iniatatingKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *otherKingdom* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html#ae4655b537dd3176b5ba37182db7fb443)GetMaximumTradeAgreementCount()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.TradeAgreementModel.GetMaximumTradeAgreementCount | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html#a822efac0449f9e366a5f0d63584874f7)GetInfluenceCostOfProposingTradeAgreement()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.TradeAgreementModel.GetInfluenceCostOfProposingTradeAgreement | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html#a42d3ea8a97cf2d498a0ad681d25f7d43)GetScoreOfStartingTradeAgreement()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TradeAgreementModel.GetScoreOfStartingTradeAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *targetKingdom*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation*, | |  |  | bool | *includeExplanation* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html#a8fc0b90c484f6fa09b49b908b8c4a8d4)CanMakeTradeAgreement()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.TradeAgreementModel.CanMakeTradeAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *other*, | |  |  | bool | *checkOtherSideTradeSupport*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason*, | |  |  | bool | *includeReason* = false ) | | abstract |

