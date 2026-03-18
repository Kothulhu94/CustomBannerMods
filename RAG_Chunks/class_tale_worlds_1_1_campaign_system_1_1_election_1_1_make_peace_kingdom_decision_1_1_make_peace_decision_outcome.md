--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html ---

TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceDecisionOutcome Class ReferenceInherits [TaleWorlds.CampaignSystem.Election.DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MakePeaceDecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a866671de52b2877127c728b3556e5f43) (bool shouldPeaceBeDeclared, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#add78f253bd0c85ee21170e9dbe0219d0) kingdom, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionToMakePeaceWith) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionTitle](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a77876055ed548bb39775863f6cd9fe9a) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDecisionDescription](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a926336af043eaf8140fcedf1ce156e41) () |
| override string | [GetDecisionLink](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a71636f3c89ee33d499c4cb14731e4e5c) () |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) | [GetDecisionImageIdentifier](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a3d59ef18618b187c8021ce5422fea4da) () |
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
| readonly bool | [ShouldPeaceBeDeclared](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a820d38b2579cb623ac4ee80dca5b90d6) |
| readonly Kingdom | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#add78f253bd0c85ee21170e9dbe0219d0) |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [FactionToMakePeaceWith](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#ad2b4d21bef53a5d8d87c76a99878af3e) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a866671de52b2877127c728b3556e5f43)MakePeaceDecisionOutcome()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceDecisionOutcome.MakePeaceDecisionOutcome | ( | bool | *shouldPeaceBeDeclared*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#add78f253bd0c85ee21170e9dbe0219d0) | *kingdom*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionToMakePeaceWith* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a77876055ed548bb39775863f6cd9fe9a)GetDecisionTitle()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceDecisionOutcome.GetDecisionTitle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a926336af043eaf8140fcedf1ce156e41)GetDecisionDescription()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceDecisionOutcome.GetDecisionDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a71636f3c89ee33d499c4cb14731e4e5c)GetDecisionLink()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceDecisionOutcome.GetDecisionLink | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a3d59ef18618b187c8021ce5422fea4da)GetDecisionImageIdentifier()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [ImageIdentifier](class_tale_worlds_1_1_core_1_1_image_identifiers_1_1_image_identifier.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceDecisionOutcome.GetDecisionImageIdentifier | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#a820d38b2579cb623ac4ee80dca5b90d6)ShouldPeaceBeDeclared
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceDecisionOutcome.ShouldPeaceBeDeclared |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#add78f253bd0c85ee21170e9dbe0219d0)Kingdom
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Kingdom TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceDecisionOutcome.Kingdom |

[◆](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_make_peace_kingdom_decision_1_1_make_peace_decision_outcome.html#ad2b4d21bef53a5d8d87c76a99878af3e)FactionToMakePeaceWith
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Election.MakePeaceKingdomDecision.MakePeaceDecisionOutcome.FactionToMakePeaceWith |

