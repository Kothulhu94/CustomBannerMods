--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultTradeAgreementModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.TradeAgreementModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetInfluenceCostOfProposingTradeAgreement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html#a7c1e21c7b5f1ffd7bd25dbb7e99dac03) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposerClan) |
| override int | [GetMaximumTradeAgreementCount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html#aeaf3fbd0b5e3fd9fafa2fea4619fdb25) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| override bool | [CanMakeTradeAgreement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html#a7fe9268a65f7d1ea4c0e189836bf58dc) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) other, bool checkOtherSideTradeSupport, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason, bool includeReason=false) |
| override float | [GetScoreOfStartingTradeAgreement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html#a4ffcb8bce1f3e7d67fa921e4a96fe22f) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) targetKingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation, bool includeExplanation=false) |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetTradeAgreementDurationInYears](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html#a28fffc921104b9f0fb74f0374e0ddd11) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) iniatatingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) otherKingdom) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.TradeAgreementModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_agreement_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html#a7c1e21c7b5f1ffd7bd25dbb7e99dac03)GetInfluenceCostOfProposingTradeAgreement()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultTradeAgreementModel.GetInfluenceCostOfProposingTradeAgreement | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposerClan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html#aeaf3fbd0b5e3fd9fafa2fea4619fdb25)GetMaximumTradeAgreementCount()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultTradeAgreementModel.GetMaximumTradeAgreementCount | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html#a7fe9268a65f7d1ea4c0e189836bf58dc)CanMakeTradeAgreement()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultTradeAgreementModel.CanMakeTradeAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *other*, |
|  |  | bool | *checkOtherSideTradeSupport*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason*, |
|  |  | bool | *includeReason* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html#a4ffcb8bce1f3e7d67fa921e4a96fe22f)GetScoreOfStartingTradeAgreement()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultTradeAgreementModel.GetScoreOfStartingTradeAgreement | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *targetKingdom*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation*, |
|  |  | bool | *includeExplanation* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_agreement_model.html#a28fffc921104b9f0fb74f0374e0ddd11)GetTradeAgreementDurationInYears()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultTradeAgreementModel.GetTradeAgreementDurationInYears | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *iniatatingKingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *otherKingdom* ) |

