--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html ---

TaleWorlds.CampaignSystem.Election.DecisionOutcome Class ReferenceabstractInherited by [TaleWorlds.CampaignSystem.Election.AcceptCallToWarAgreementDecision.AcceptCallToWarAgreementDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_accept_call_to_war_agreement_decision_1_111ee14ece78d43de779f1cbdc5e0db65.html), [TaleWorlds.CampaignSystem.Election.DeclareWarDecision.DeclareWarDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html), [TaleWorlds.CampaignSystem.Election.ExpelClanFromKingdomDecision.ExpelClanDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_expel_clan_from_kingdom_decision_1_1_expel_clan_decision_outcome.html), [TaleWorlds.CampaignSystem.Election.KingSelectionKingdomDecision.KingSelectionDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_king_selection_kingdom_decision_1_1_king_selection_decision_outcome.html), [TaleWorlds.CampaignSystem.Election.KingdomPolicyDecision.PolicyDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_policy_decision_1_1_policy_decision_outcome.html), [TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html), [TaleWorlds.CampaignSystem.Election.ProposeCallToWarAgreementDecision.ProposeCallToWarAgreementDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_propose_call_to_war_agreement_decision_1_93243446ab16f5556ab3d4d2cad0c6d2.html), [TaleWorlds.CampaignSystem.Election.SettlementClaimantDecision.ClanAsDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_decision_1_1_clan_as_decision_outcome.html), [TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.SettlementClaimantPreliminaryOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html), [TaleWorlds.CampaignSystem.Election.StartAllianceDecision.StartAllianceDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html), and [TaleWorlds.CampaignSystem.Election.TradeAgreementDecision.TradeAgreementDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_trade_agreement_decision_1_1_trade_agreement_decision_outcome.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| float | [InitialMerit](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#ae3d4818fe44d37ca1e082ee47d4b6700) |
| List< [Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html) > | [SupporterList](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a20857ef54e820007a3c32d6b6d337d0b) = new List<[Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html)>() |

|  |  |
| --- | --- |
| Properties | |
| float | [Support](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a7dda63145358d95d3f2705f95a22898d) `[get]` |
| float | [Merit](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#af419d29e47b2428c363ec8c460238085) `[get]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [SponsorClan](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a96fae31537a9f2b89839a4e1adae6daf) `[get]` |
| float | [InitialSupport](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a1b777726746d6b093b44a86f799b4117) `[get]` |
| float | [Likelihood](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a4702087df9b6832121c06ae82668b628) `[get]` |
| float | [TotalSupportPoints](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a368d0d924de26f6bf3c178a9e68d9a27) `[get]` |
| float | [WinChance](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a18b2d8fce220929c9d072176fa68550c) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a8d1cf584e4a64aecb8ac8965a5e27b72)GetDecisionTitle()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.DecisionOutcome.GetDecisionTitle | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a5b9288b04ce8b687832f578fe01b548c)GetDecisionDescription()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.DecisionOutcome.GetDecisionDescription | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a2a4dbd73d7f87ac0cf96e199be0f1f8b)GetDecisionLink()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.Election.DecisionOutcome.GetDecisionLink | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#ac932d02bc8628e93315b235c93edc40f)GetDecisionImageIdentifier()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) TaleWorlds.CampaignSystem.Election.DecisionOutcome.GetDecisionImageIdentifier | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a5567e8a92f2c7c64f707af90e6af3b3f)AddSupport()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Election.DecisionOutcome.AddSupport | ( | [Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html) | *supporter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a609c373ec5a32fced132d21897d5e23b)ResetSupport()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Election.DecisionOutcome.ResetSupport | ( | [Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html) | *supporter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a7b73716de2328a455e2b531cf9dcce13)SetSponsor()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Election.DecisionOutcome.SetSponsor | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *sponsorClan* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#ae3d4818fe44d37ca1e082ee47d4b6700)InitialMerit
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.Election.DecisionOutcome.InitialMerit |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a20857ef54e820007a3c32d6b6d337d0b)SupporterList
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html)> TaleWorlds.CampaignSystem.Election.DecisionOutcome.SupporterList = new List<[Supporter](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_supporter.html)>() |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a7dda63145358d95d3f2705f95a22898d)Support
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Election.DecisionOutcome.Support | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#af419d29e47b2428c363ec8c460238085)Merit
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Election.DecisionOutcome.Merit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a96fae31537a9f2b89839a4e1adae6daf)SponsorClan
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.Election.DecisionOutcome.SponsorClan | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a1b777726746d6b093b44a86f799b4117)InitialSupport
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Election.DecisionOutcome.InitialSupport | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a4702087df9b6832121c06ae82668b628)Likelihood
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Election.DecisionOutcome.Likelihood | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a368d0d924de26f6bf3c178a9e68d9a27)TotalSupportPoints
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Election.DecisionOutcome.TotalSupportPoints | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html#a18b2d8fce220929c9d072176fa68550c)WinChance
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Election.DecisionOutcome.WinChance | | get |

