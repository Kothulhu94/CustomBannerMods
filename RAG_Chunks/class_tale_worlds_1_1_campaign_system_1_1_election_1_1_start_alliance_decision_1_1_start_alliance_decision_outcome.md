--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html ---

TaleWorlds.CampaignSystem.Election.StartAllianceDecision.StartAllianceDecisionOutcome Class ReferenceInherits [TaleWorlds.CampaignSystem.Election.DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [StartAllianceDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#aa7ff678b27d56c46b958d33e32923101) (bool shouldAllianceBeStarted, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#aef3d15036d3ab19ad72b1f17c3fcf15e) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#aef3d15036d3ab19ad72b1f17c3fcf15e) kingdomToStartAllianceWith) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#a5802271a02d70b2f235c93d91589f321) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#ae32f33cbc0a28f64d41e80c02da9a400) () |
| override string | [GetDecisionLink](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#abf18b9f86464396254b6778493de2fbd) () |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetDecisionImageIdentifier](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#a70e1bc01a7098985922c188875eca41b) () |
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
| readonly bool | [ShouldAllianceBeStarted](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#ad50b5e8aefe978fcb858d9e6a1c9a2c9) |
| readonly Kingdom | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#aef3d15036d3ab19ad72b1f17c3fcf15e) |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#aef3d15036d3ab19ad72b1f17c3fcf15e) | [KingdomToStartAllianceWith](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#a712ac40dbcd8f5a0cfe44acd08f9dbb4) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#aa7ff678b27d56c46b958d33e32923101)StartAllianceDecisionOutcome()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Election.StartAllianceDecision.StartAllianceDecisionOutcome.StartAllianceDecisionOutcome | ( | bool | *shouldAllianceBeStarted*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#aef3d15036d3ab19ad72b1f17c3fcf15e) | *kingdom*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#aef3d15036d3ab19ad72b1f17c3fcf15e) | *kingdomToStartAllianceWith* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#a5802271a02d70b2f235c93d91589f321)GetDecisionTitle()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.StartAllianceDecision.StartAllianceDecisionOutcome.GetDecisionTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#ae32f33cbc0a28f64d41e80c02da9a400)GetDecisionDescription()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.StartAllianceDecision.StartAllianceDecisionOutcome.GetDecisionDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#abf18b9f86464396254b6778493de2fbd)GetDecisionLink()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Election.StartAllianceDecision.StartAllianceDecisionOutcome.GetDecisionLink | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#a70e1bc01a7098985922c188875eca41b)GetDecisionImageIdentifier()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) TaleWorlds.CampaignSystem.Election.StartAllianceDecision.StartAllianceDecisionOutcome.GetDecisionImageIdentifier | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#ad50b5e8aefe978fcb858d9e6a1c9a2c9)ShouldAllianceBeStarted
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.Election.StartAllianceDecision.StartAllianceDecisionOutcome.ShouldAllianceBeStarted |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#aef3d15036d3ab19ad72b1f17c3fcf15e)Kingdom
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Kingdom TaleWorlds.CampaignSystem.Election.StartAllianceDecision.StartAllianceDecisionOutcome.Kingdom |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#a712ac40dbcd8f5a0cfe44acd08f9dbb4)KingdomToStartAllianceWith
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_start_alliance_decision_1_1_start_alliance_decision_outcome.html#aef3d15036d3ab19ad72b1f17c3fcf15e) TaleWorlds.CampaignSystem.Election.StartAllianceDecision.StartAllianceDecisionOutcome.KingdomToStartAllianceWith |

