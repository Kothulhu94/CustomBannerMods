--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html ---

TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.SettlementClaimantPreliminaryOutcome Class ReferenceInherits [TaleWorlds.CampaignSystem.Election.DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#ae0794e9203f55d84f038b5d1b9683258) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#a51bee877b2e4d9b7713a07c0bea55ff7) () |
| override string | [GetDecisionLink](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#a517a1cfa448eac1166dd778beb7c33f0) () |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetDecisionImageIdentifier](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#a99ddf64231a30db929ef741b2baa83ae) () |
|  | [SettlementClaimantPreliminaryOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#ada760509aba0d3aa8f6be6817ea8543c) (bool shouldSettlementOwnerChange) |
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
| bool | [ShouldSettlementOwnerChange](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#acb625bcce35d0215770a94fc3f652111) = false |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#ada760509aba0d3aa8f6be6817ea8543c)SettlementClaimantPreliminaryOutcome()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.SettlementClaimantPreliminaryOutcome.SettlementClaimantPreliminaryOutcome | ( | bool | *shouldSettlementOwnerChange* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#ae0794e9203f55d84f038b5d1b9683258)GetDecisionTitle()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.SettlementClaimantPreliminaryOutcome.GetDecisionTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#a51bee877b2e4d9b7713a07c0bea55ff7)GetDecisionDescription()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.SettlementClaimantPreliminaryOutcome.GetDecisionDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#a517a1cfa448eac1166dd778beb7c33f0)GetDecisionLink()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.SettlementClaimantPreliminaryOutcome.GetDecisionLink | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#a99ddf64231a30db929ef741b2baa83ae)GetDecisionImageIdentifier()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.SettlementClaimantPreliminaryOutcome.GetDecisionImageIdentifier | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_settlement_claimant_preliminary_decision_3e3ea864bc18374c0522da1988f5dae4.html#acb625bcce35d0215770a94fc3f652111)ShouldSettlementOwnerChange
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Election.SettlementClaimantPreliminaryDecision.SettlementClaimantPreliminaryOutcome.ShouldSettlementOwnerChange = false |

