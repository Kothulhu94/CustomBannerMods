--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html ---

TaleWorlds.CampaignSystem.Election.TradeAgreementDecision.TradeAgreementDecisionOutcome Class ReferenceInherits [TaleWorlds.CampaignSystem.Election.DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TradeAgreementDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#ac43a89b2faddf9c6d650acda3d3fbeb6) (bool shouldStart, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) kingdom2) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#ab787e5da4c1cce6602b15adcdf124de0) () |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetDecisionImageIdentifier](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#ae7307a20c4161d3dcd43c62f3e592148) () |
| override string | [GetDecisionLink](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#ab8494ffd9462759a2367391386e13efc) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#a8977404457c0fa34a578d8a0a5842c27) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Election.DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a8d1cf584e4a64aecb8ac8965a5e27b72) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a5b9288b04ce8b687832f578fe01b548c) () |
| string | [GetDecisionLink](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a2a4dbd73d7f87ac0cf96e199be0f1f8b) () |
| [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetDecisionImageIdentifier](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#ac932d02bc8628e93315b235c93edc40f) () |
| void | [AddSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a5567e8a92f2c7c64f707af90e6af3b3f) ([Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html) supporter) |
| void | [ResetSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a609c373ec5a32fced132d21897d5e23b) ([Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html) supporter) |
| void | [SetSponsor](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a7b73716de2328a455e2b531cf9dcce13) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) sponsorClan) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly bool | [ShouldTradeAgreementStart](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#a4b21adfae35899bc88436b4975b9dda6) |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) | [Kingdom1](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#accf56c570fda95fbe86c395eabb87f74) |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) | [Kingdom2](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#ad0fe35be504343584dcdb696bcdf93f2) |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.Election.DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | |
| float | [InitialMerit](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#ae3d4818fe44d37ca1e082ee47d4b6700) |
| List< [Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html) > | [SupporterList](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a20857ef54e820007a3c32d6b6d337d0b) = new List<[Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html)>() |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.CampaignSystem.Election.DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | |
| float | [Support](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a7dda63145358d95d3f2705f95a22898d) `[get]` |
| float | [Merit](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#af419d29e47b2428c363ec8c460238085) `[get]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [SponsorClan](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a96fae31537a9f2b89839a4e1adae6daf) `[get]` |
| float | [InitialSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a1b777726746d6b093b44a86f799b4117) `[get]` |
| float | [Likelihood](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a4702087df9b6832121c06ae82668b628) `[get]` |
| float | [TotalSupportPoints](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a368d0d924de26f6bf3c178a9e68d9a27) `[get]` |
| float | [WinChance](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a18b2d8fce220929c9d072176fa68550c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#ac43a89b2faddf9c6d650acda3d3fbeb6)TradeAgreementDecisionOutcome()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Election.TradeAgreementDecision.TradeAgreementDecisionOutcome.TradeAgreementDecisionOutcome | ( | bool | *shouldStart*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) | *kingdom1*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) | *kingdom2* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#ab787e5da4c1cce6602b15adcdf124de0)GetDecisionDescription()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.TradeAgreementDecision.TradeAgreementDecisionOutcome.GetDecisionDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#ae7307a20c4161d3dcd43c62f3e592148)GetDecisionImageIdentifier()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) TaleWorlds.CampaignSystem.Election.TradeAgreementDecision.TradeAgreementDecisionOutcome.GetDecisionImageIdentifier | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#ab8494ffd9462759a2367391386e13efc)GetDecisionLink()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Election.TradeAgreementDecision.TradeAgreementDecisionOutcome.GetDecisionLink | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#a8977404457c0fa34a578d8a0a5842c27)GetDecisionTitle()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.TradeAgreementDecision.TradeAgreementDecisionOutcome.GetDecisionTitle | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#a4b21adfae35899bc88436b4975b9dda6)ShouldTradeAgreementStart
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.Election.TradeAgreementDecision.TradeAgreementDecisionOutcome.ShouldTradeAgreementStart |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#accf56c570fda95fbe86c395eabb87f74)Kingdom1
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) TaleWorlds.CampaignSystem.Election.TradeAgreementDecision.TradeAgreementDecisionOutcome.Kingdom1 |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html#ad0fe35be504343584dcdb696bcdf93f2)Kingdom2
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html#a21836dcdd18325a03c202ff260a986c6) TaleWorlds.CampaignSystem.Election.TradeAgreementDecision.TradeAgreementDecisionOutcome.Kingdom2 |

