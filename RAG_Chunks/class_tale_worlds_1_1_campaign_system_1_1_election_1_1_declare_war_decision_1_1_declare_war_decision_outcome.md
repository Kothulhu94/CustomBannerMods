--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html ---

TaleWorlds.CampaignSystem.Election.DeclareWarDecision.DeclareWarDecisionOutcome Class ReferenceInherits [TaleWorlds.CampaignSystem.Election.DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DeclareWarDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a766ab4ed8733ab79e2bca11fa1259a6b) (bool shouldWarBeDeclared, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#aeed407ef1d4cb43f928b32ee5482da88) kingdom, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionToDeclareWarOn) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a648e01bb854f9262bda5aed090908d51) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a67091a4846a1e894b5ac01e87125c1ce) () |
| override string | [GetDecisionLink](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a9594d721fe458ef7ceb8cafef3714251) () |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetDecisionImageIdentifier](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a7ebe1bfb9d477800839cbe9535eee55c) () |
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
| readonly bool | [ShouldWarBeDeclared](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a035ccd77dea299d4f6587f0fb04227b6) |
| readonly Kingdom | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#aeed407ef1d4cb43f928b32ee5482da88) |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [FactionToDeclareWarOn](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a4ecaf244dfbffba247bb0a7d49b2d03e) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a766ab4ed8733ab79e2bca11fa1259a6b)DeclareWarDecisionOutcome()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Election.DeclareWarDecision.DeclareWarDecisionOutcome.DeclareWarDecisionOutcome | ( | bool | *shouldWarBeDeclared*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#aeed407ef1d4cb43f928b32ee5482da88) | *kingdom*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionToDeclareWarOn* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a648e01bb854f9262bda5aed090908d51)GetDecisionTitle()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.DeclareWarDecision.DeclareWarDecisionOutcome.GetDecisionTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a67091a4846a1e894b5ac01e87125c1ce)GetDecisionDescription()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.DeclareWarDecision.DeclareWarDecisionOutcome.GetDecisionDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a9594d721fe458ef7ceb8cafef3714251)GetDecisionLink()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Election.DeclareWarDecision.DeclareWarDecisionOutcome.GetDecisionLink | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a7ebe1bfb9d477800839cbe9535eee55c)GetDecisionImageIdentifier()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) TaleWorlds.CampaignSystem.Election.DeclareWarDecision.DeclareWarDecisionOutcome.GetDecisionImageIdentifier | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a035ccd77dea299d4f6587f0fb04227b6)ShouldWarBeDeclared
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.Election.DeclareWarDecision.DeclareWarDecisionOutcome.ShouldWarBeDeclared |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#aeed407ef1d4cb43f928b32ee5482da88)Kingdom
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Kingdom TaleWorlds.CampaignSystem.Election.DeclareWarDecision.DeclareWarDecisionOutcome.Kingdom |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_declare_war_decision_1_1_declare_war_decision_outcome.html#a4ecaf244dfbffba247bb0a7d49b2d03e)FactionToDeclareWarOn
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Election.DeclareWarDecision.DeclareWarDecisionOutcome.FactionToDeclareWarOn |

