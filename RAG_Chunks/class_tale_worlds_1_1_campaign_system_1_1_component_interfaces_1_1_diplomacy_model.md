--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083) {     [Neutral](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083ae9bb5320b3890b6747c91b5a71ae5a01) ,     [War](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083aab4b1482cb2ba3f1ee7fd9201c8a1fad)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetStrengthThresholdForNonMutualWarsToBeIgnoredToJoinKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a899daa68ae90dc53c5b151912c98596e) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToJoin) |
| float | [GetRelationIncreaseFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#aa513e510fb5747e98134b53dce86eb80) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2, float relationValue) |
| int | [GetInfluenceAwardForSettlementCapturer](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ac8ca6e99933a860d5e9e1d64c0cce5a9) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| float | [GetHourlyInfluenceAwardForRaidingEnemyVillage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a8c5644f7a9e1bfe66feae6698aaa93c1) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| float | [GetHourlyInfluenceAwardForBesiegingEnemyFortification](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a8fa364aad5e265668c448bd1f8d51ce6) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| float | [GetHourlyInfluenceAwardForBeingArmyMember](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#acfd73c79ffd4a12f5c274a07c24d14e9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| float | [GetScoreOfClanToJoinKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a8186df4db870f4f37c8f9ac72ccfa2c6) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| float | [GetScoreOfClanToLeaveKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a901e2b07f01d9ee2cfdb6c8e5710ac97) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| float | [GetScoreOfKingdomToGetClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ab418b948e47ab57eaa3921e347d9eed1) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| float | [GetScoreOfKingdomToSackClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a793d4fe54f7b7f433853a1813281f4f3) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| float | [GetScoreOfMercenaryToJoinKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#af1fc1c7728978172c1deb1fd2d232fa2) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| float | [GetScoreOfMercenaryToLeaveKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a5623ad5c0df1dc8b6ff010b21e0a97cd) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| float | [GetScoreOfKingdomToHireMercenary](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a2e5d3bfd2b90e1c8c5357fb0febaa623) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan) |
| float | [GetScoreOfKingdomToSackMercenary](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a33e2a7f6f9579ceff5703d690f265c88) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan) |
| float | [GetScoreOfDeclaringPeaceForClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#afc38062c5b1b3d4625124207206a8db0) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaresPeace, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaredPeace, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) evaluatingClan, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason, bool includeReason=false) |
| float | [GetScoreOfDeclaringPeace](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a72469b228de9d1e71313d51dc9f080fe) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaresPeace, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaredPeace) |
| bool | [IsPeaceSuitable](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ae39ac696805430692c80005c9c3f1f80) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaresPeace, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaredPeace) |
| float | [GetScoreOfDeclaringWar](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a8f80b62324965b2700ac5b8a18d83ee3) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaresWar, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaredWar, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) evaluatingClan, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason, bool includeReason=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetWarProgressScore](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a04f4d70d7a2f1a7760ea58793fd73f06) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaresWar, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaredWar, bool includeDescriptions=false) |
| float | [GetScoreOfLettingPartyGo](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a1b3d7a5de6f2c056d9a1ca59af651c10) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) partyToLetGo) |
| float | [GetValueOfHeroForFaction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a320a3c05aa40ad26675685a80116367c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) examinedHero, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) targetFaction, bool forMarriage=false) |
| int | [GetRelationCostOfExpellingClanFromKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a6ddb086ef67f83f382a365ab52883556) () |
| int | [GetInfluenceCostOfSupportingClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#af14c9174c82aa5e1bee5a65f032ce1b2) () |
| int | [GetInfluenceCostOfExpellingClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#abfa99c47f1798a95039e6b936ad68eb5) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| int | [GetInfluenceCostOfProposingPeace](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a646f170fbd50ebdad6d10667de8d8988) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| int | [GetInfluenceCostOfProposingWar](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#abf91787fe93626e46c392e350a9e77cd) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| int | [GetInfluenceValueOfSupportingClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a1527a732785273b5146959f864d1f41c) () |
| int | [GetRelationValueOfSupportingClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ad6dc6fa1059e1cebf918f867349359d4) () |
| int | [GetInfluenceCostOfAnnexation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a82d89876f6e0a560f5cc081bad150bd2) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| int | [GetInfluenceCostOfChangingLeaderOfArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a6008371391eb56aee580785d2e3afa5b) () |
| int | [GetInfluenceCostOfDisbandingArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a3f14ca1b7ac0fc57e3adb1f1384ae834) () |
| int | [GetRelationCostOfDisbandingArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ae96bfd4718765eea5c83a08e8867f082) (bool isLeaderParty) |
| int | [GetInfluenceCostOfPolicyProposalAndDisavowal](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a863cc58c2107e81890aa3db06d71df6d) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| int | [GetInfluenceCostOfAbandoningArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#aad7f689cc7fb2e045ed2593dc76ae4c8) () |
| int | [GetEffectiveRelation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a901e146e665a7682aafb9f9135823a3f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1) |
| int | [GetBaseRelation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a67b42b31f34ea9c80326af962778ffb9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1) |
| void | [GetHeroesForEffectiveRelation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a74d4dcc751296253a658211fe7747f9a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2, out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) effectiveHero1, out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) effectiveHero2) |
| int | [GetRelationChangeAfterClanLeaderIsDead](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ac9861157db5cdf1f9b921129a899810a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) deadLeader, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) relationHero) |
| int | [GetRelationChangeAfterVotingInSettlementOwnerPreliminaryDecision](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ad9ece5cacfb43556afc6dba19c6cab13) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) supporter, bool hasHeroVotedAgainstOwner) |
| float | [GetClanStrength](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#af77eea51525231a1ce8892da201b2f27) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| float | [GetHeroCommandingStrengthForClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#acacffb7fb568d3f5d83279f48f5e1f43) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| float | [GetHeroGoverningStrengthForClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ae324dabeb28ed1b75df70cf4399bf448) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| uint | [GetNotificationColor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ad1b90bae89ca3aedc8a94e5371518ba4) ([ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) notificationType) |
| int | [GetDailyTributeToPay](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a63c57ab93c24f221a9d728d47d5c7c05) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) factionToPay, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) factionToReceive, out int tributeDurationInDays) |
| float | [GetDecisionMakingThreshold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ab037cec52b0f14c81d916af2f61885f3) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) consideringFaction) |
| float | [GetValueOfSettlementsForFaction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#adec17cdf25091072cd9e95cdaf13d7b1) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| bool | [CanSettlementBeGifted](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a747387e909d0eb7c6fb718771a3e14d9) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| bool | [IsClanEligibleToBecomeRuler](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ae5b81d29721dcd7388e2b4594612af42) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| IEnumerable< [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) > | [GetBarterGroups](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a73e04373ae9321986ca36f2e0f7e5252) () |
| int | [GetCharmExperienceFromRelationGain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a4054ed4b7ba655bd0c22c5ac6d330f70) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float relationChange, [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) detail) |
| float | [DenarsToInfluence](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a02dc33165c7b2dccb1b71ac20d711a28) () |
| [DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083)? | [GetShallowDiplomaticStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ab1c95a738c171f3cae05e636172f506e) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| [DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083) | [GetDefaultDiplomaticStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a4aff4851e7f1d04266bb6e2526742179) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| bool | [IsAtConstantWar](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a699051d4b687e3b54f88fe17b19111d3) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [MaxRelationLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a9a2230ba832446fb6a3d38659416580a) `[get]` |
| int | [MinRelationLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#adda9912dac4d1bd0ee369560eb5520a0) `[get]` |
| int | [MaxNeutralRelationLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a9f24d629c2f76cdbfb15e39f13bd429e) `[get]` |
| int | [MinNeutralRelationLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#aa435cf0969f111cc5ad0640fd329f8db) `[get]` |
| int | [MinimumRelationWithConversationCharacterToJoinKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ab857b3fde430a585ae01d6d40a60841b) `[get]` |
| int | [GiftingTownRelationshipBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a2878da1c2f20389f04f97fc8c5b80ef0) `[get]` |
| int | [GiftingCastleRelationshipBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a87a07319f0f626f16c0584186e87dfb9) `[get]` |
| float | [WarDeclarationScorePenaltyAgainstAllies](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ada918f421b7565316aa7a110e1791138) `[get]` |
| float | [WarDeclarationScoreBonusAgainstEnemiesOfAllies](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a08adbebb132d8674d6a7c890a34eee5e) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083)DiplomacyStance
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083) |

| Enumerator | |
| --- | --- |
| Neutral |  |
| War |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a899daa68ae90dc53c5b151912c98596e)GetStrengthThresholdForNonMutualWarsToBeIgnoredToJoinKingdom()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetStrengthThresholdForNonMutualWarsToBeIgnoredToJoinKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToJoin* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#aa513e510fb5747e98134b53dce86eb80)GetRelationIncreaseFactor()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetRelationIncreaseFactor | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2*, | |  |  | float | *relationValue* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ac8ca6e99933a860d5e9e1d64c0cce5a9)GetInfluenceAwardForSettlementCapturer()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceAwardForSettlementCapturer | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a8c5644f7a9e1bfe66feae6698aaa93c1)GetHourlyInfluenceAwardForRaidingEnemyVillage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetHourlyInfluenceAwardForRaidingEnemyVillage | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a8fa364aad5e265668c448bd1f8d51ce6)GetHourlyInfluenceAwardForBesiegingEnemyFortification()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetHourlyInfluenceAwardForBesiegingEnemyFortification | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#acfd73c79ffd4a12f5c274a07c24d14e9)GetHourlyInfluenceAwardForBeingArmyMember()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetHourlyInfluenceAwardForBeingArmyMember | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a8186df4db870f4f37c8f9ac72ccfa2c6)GetScoreOfClanToJoinKingdom()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfClanToJoinKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a901e2b07f01d9ee2cfdb6c8e5710ac97)GetScoreOfClanToLeaveKingdom()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfClanToLeaveKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ab418b948e47ab57eaa3921e347d9eed1)GetScoreOfKingdomToGetClan()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfKingdomToGetClan | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a793d4fe54f7b7f433853a1813281f4f3)GetScoreOfKingdomToSackClan()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfKingdomToSackClan | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#af1fc1c7728978172c1deb1fd2d232fa2)GetScoreOfMercenaryToJoinKingdom()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfMercenaryToJoinKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a5623ad5c0df1dc8b6ff010b21e0a97cd)GetScoreOfMercenaryToLeaveKingdom()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfMercenaryToLeaveKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a2e5d3bfd2b90e1c8c5357fb0febaa623)GetScoreOfKingdomToHireMercenary()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfKingdomToHireMercenary | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a33e2a7f6f9579ceff5703d690f265c88)GetScoreOfKingdomToSackMercenary()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfKingdomToSackMercenary | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#afc38062c5b1b3d4625124207206a8db0)GetScoreOfDeclaringPeaceForClan()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfDeclaringPeaceForClan | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaresPeace*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaredPeace*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *evaluatingClan*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason*, | |  |  | bool | *includeReason* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a72469b228de9d1e71313d51dc9f080fe)GetScoreOfDeclaringPeace()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfDeclaringPeace | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaresPeace*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaredPeace* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ae39ac696805430692c80005c9c3f1f80)IsPeaceSuitable()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.IsPeaceSuitable | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaresPeace*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaredPeace* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a8f80b62324965b2700ac5b8a18d83ee3)GetScoreOfDeclaringWar()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfDeclaringWar | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaresWar*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaredWar*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *evaluatingClan*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason*, | |  |  | bool | *includeReason* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a04f4d70d7a2f1a7760ea58793fd73f06)GetWarProgressScore()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetWarProgressScore | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaresWar*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaredWar*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a1b3d7a5de6f2c056d9a1ca59af651c10)GetScoreOfLettingPartyGo()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetScoreOfLettingPartyGo | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *partyToLetGo* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a320a3c05aa40ad26675685a80116367c)GetValueOfHeroForFaction()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetValueOfHeroForFaction | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *examinedHero*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *targetFaction*, | |  |  | bool | *forMarriage* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a6ddb086ef67f83f382a365ab52883556)GetRelationCostOfExpellingClanFromKingdom()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetRelationCostOfExpellingClanFromKingdom | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#af14c9174c82aa5e1bee5a65f032ce1b2)GetInfluenceCostOfSupportingClan()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceCostOfSupportingClan | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#abfa99c47f1798a95039e6b936ad68eb5)GetInfluenceCostOfExpellingClan()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceCostOfExpellingClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a646f170fbd50ebdad6d10667de8d8988)GetInfluenceCostOfProposingPeace()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceCostOfProposingPeace | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#abf91787fe93626e46c392e350a9e77cd)GetInfluenceCostOfProposingWar()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceCostOfProposingWar | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a1527a732785273b5146959f864d1f41c)GetInfluenceValueOfSupportingClan()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceValueOfSupportingClan | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ad6dc6fa1059e1cebf918f867349359d4)GetRelationValueOfSupportingClan()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetRelationValueOfSupportingClan | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a82d89876f6e0a560f5cc081bad150bd2)GetInfluenceCostOfAnnexation()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceCostOfAnnexation | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a6008371391eb56aee580785d2e3afa5b)GetInfluenceCostOfChangingLeaderOfArmy()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceCostOfChangingLeaderOfArmy | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a3f14ca1b7ac0fc57e3adb1f1384ae834)GetInfluenceCostOfDisbandingArmy()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceCostOfDisbandingArmy | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ae96bfd4718765eea5c83a08e8867f082)GetRelationCostOfDisbandingArmy()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetRelationCostOfDisbandingArmy | ( | bool | *isLeaderParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a863cc58c2107e81890aa3db06d71df6d)GetInfluenceCostOfPolicyProposalAndDisavowal()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceCostOfPolicyProposalAndDisavowal | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#aad7f689cc7fb2e045ed2593dc76ae4c8)GetInfluenceCostOfAbandoningArmy()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetInfluenceCostOfAbandoningArmy | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a901e146e665a7682aafb9f9135823a3f)GetEffectiveRelation()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetEffectiveRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a67b42b31f34ea9c80326af962778ffb9)GetBaseRelation()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetBaseRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a74d4dcc751296253a658211fe7747f9a)GetHeroesForEffectiveRelation()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetHeroesForEffectiveRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2*, | |  |  | out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *effectiveHero1*, | |  |  | out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *effectiveHero2* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ac9861157db5cdf1f9b921129a899810a)GetRelationChangeAfterClanLeaderIsDead()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetRelationChangeAfterClanLeaderIsDead | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *deadLeader*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *relationHero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ad9ece5cacfb43556afc6dba19c6cab13)GetRelationChangeAfterVotingInSettlementOwnerPreliminaryDecision()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetRelationChangeAfterVotingInSettlementOwnerPreliminaryDecision | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *supporter*, | |  |  | bool | *hasHeroVotedAgainstOwner* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#af77eea51525231a1ce8892da201b2f27)GetClanStrength()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetClanStrength | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#acacffb7fb568d3f5d83279f48f5e1f43)GetHeroCommandingStrengthForClan()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetHeroCommandingStrengthForClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ae324dabeb28ed1b75df70cf4399bf448)GetHeroGoverningStrengthForClan()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetHeroGoverningStrengthForClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ad1b90bae89ca3aedc8a94e5371518ba4)GetNotificationColor()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | uint TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetNotificationColor | ( | [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | *notificationType* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a63c57ab93c24f221a9d728d47d5c7c05)GetDailyTributeToPay()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetDailyTributeToPay | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *factionToPay*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *factionToReceive*, | |  |  | out int | *tributeDurationInDays* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ab037cec52b0f14c81d916af2f61885f3)GetDecisionMakingThreshold()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetDecisionMakingThreshold | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *consideringFaction* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#adec17cdf25091072cd9e95cdaf13d7b1)GetValueOfSettlementsForFaction()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetValueOfSettlementsForFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a747387e909d0eb7c6fb718771a3e14d9)CanSettlementBeGifted()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.CanSettlementBeGifted | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ae5b81d29721dcd7388e2b4594612af42)IsClanEligibleToBecomeRuler()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.IsClanEligibleToBecomeRuler | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a73e04373ae9321986ca36f2e0f7e5252)GetBarterGroups()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | IEnumerable< [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetBarterGroups | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a4054ed4b7ba655bd0c22c5ac6d330f70)GetCharmExperienceFromRelationGain()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetCharmExperienceFromRelationGain | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | float | *relationChange*, | |  |  | [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) | *detail* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a02dc33165c7b2dccb1b71ac20d711a28)DenarsToInfluence()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.DenarsToInfluence | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ab1c95a738c171f3cae05e636172f506e)GetShallowDiplomaticStance()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083)? TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetShallowDiplomaticStance | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a4aff4851e7f1d04266bb6e2526742179)GetDefaultDiplomaticStance()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083) TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GetDefaultDiplomaticStance | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a699051d4b687e3b54f88fe17b19111d3)IsAtConstantWar()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.IsAtConstantWar | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a9a2230ba832446fb6a3d38659416580a)MaxRelationLimit
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.MaxRelationLimit | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#adda9912dac4d1bd0ee369560eb5520a0)MinRelationLimit
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.MinRelationLimit | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a9f24d629c2f76cdbfb15e39f13bd429e)MaxNeutralRelationLimit
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.MaxNeutralRelationLimit | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#aa435cf0969f111cc5ad0640fd329f8db)MinNeutralRelationLimit
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.MinNeutralRelationLimit | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ab857b3fde430a585ae01d6d40a60841b)MinimumRelationWithConversationCharacterToJoinKingdom
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.MinimumRelationWithConversationCharacterToJoinKingdom | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a2878da1c2f20389f04f97fc8c5b80ef0)GiftingTownRelationshipBonus
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GiftingTownRelationshipBonus | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a87a07319f0f626f16c0584186e87dfb9)GiftingCastleRelationshipBonus
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.GiftingCastleRelationshipBonus | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ada918f421b7565316aa7a110e1791138)WarDeclarationScorePenaltyAgainstAllies
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.WarDeclarationScorePenaltyAgainstAllies | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#a08adbebb132d8674d6a7c890a34eee5e)WarDeclarationScoreBonusAgainstEnemiesOfAllies
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel.WarDeclarationScoreBonusAgainstEnemiesOfAllies | | getabstract |

