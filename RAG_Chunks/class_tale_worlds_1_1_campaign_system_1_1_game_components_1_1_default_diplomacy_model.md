--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetStrengthThresholdForNonMutualWarsToBeIgnoredToJoinKingdom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ad52395d64cd637ab64435bf3cba8e4d6) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToJoin) |
| override float | [GetClanStrength](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a06787039bbc0616f243ab056ee96eebc) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override float | [GetHeroCommandingStrengthForClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aee20cb8706129d8fe9b5c30899b1993f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override float | [GetHeroGoverningStrengthForClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a352d44ea81742c01cf20917f3d67cdb0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override float | [GetRelationIncreaseFactor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7ae2fbb58a224544afd1ab3b254b76e4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2, float relationChange) |
| override int | [GetInfluenceAwardForSettlementCapturer](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a8d74919cec893541d8505c772518faa3) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override float | [GetHourlyInfluenceAwardForBeingArmyMember](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7f8a017515a60d678b3b6e3e076983c4) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override float | [GetHourlyInfluenceAwardForRaidingEnemyVillage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aa817c2b6f57cea96bc40542a7ae37852) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override float | [GetHourlyInfluenceAwardForBesiegingEnemyFortification](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ab73dd9eb9429980deb6d6f75cdb4da19) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override float | [GetScoreOfClanToJoinKingdom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a390685581e36dffd239f245b456f7666) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| override float | [GetScoreOfClanToLeaveKingdom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a8227a7e3a2eb3a6bb4d6bd2ecbc0dfc6) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| override float | [GetScoreOfKingdomToGetClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a4b4adb4a876f4b7215fbacc3e5c1a767) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override float | [GetScoreOfKingdomToSackClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7bf9224aacc136f151f84574b79e67f6) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override float | [GetScoreOfMercenaryToJoinKingdom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aa5d2c377d949dad17700f4533e8555a3) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| override float | [GetScoreOfMercenaryToLeaveKingdom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a2d1f03a8849a064301068c66326ba251) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| override float | [GetScoreOfKingdomToHireMercenary](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ad0361a6a63c708406d702f325e27e055) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan) |
| override float | [GetScoreOfKingdomToSackMercenary](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ab9333dae3f87a61797ea1c7fb01188a7) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan) |
| override float | [GetScoreOfDeclaringPeaceForClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ace4101d7f2e9686b92886bcceb7c604b) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaresPeace, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaredPeace, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) evaluatingClan, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason, bool includeReason=false) |
| override float | [GetScoreOfDeclaringPeace](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a05b991263d8f80db8392989c49d7c91c) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaresPeace, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaredPeace) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetWarProgressScore](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a736bf987faf7b462f872b1d7d0ed9a8e) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaresWar, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaredWar, bool includeDescriptions=false) |
| override float | [GetScoreOfDeclaringWar](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a26cade3852bbab293e26eb65f7f31cbc) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaresWar, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaredWar, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) evaluatingClan, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) reason, bool includeReason=false) |
| override float | [GetScoreOfLettingPartyGo](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ac2c316f8ec9f137cedcb244764929606) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) partyToLetGo) |
| override float | [GetValueOfHeroForFaction](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aceef28e669c78232ed67d13fddbbc2ca) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) examinedHero, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) targetFaction, bool forMarriage=false) |
| override int | [GetRelationCostOfExpellingClanFromKingdom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a5bdbac489f1b231da6f39f3823b30b2e) () |
| override int | [GetInfluenceCostOfSupportingClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a10c8dc8b393377cb7a417f568907581b) () |
| override int | [GetInfluenceCostOfExpellingClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7b6af07c6b3cd9e907a956afe11ff804) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| override int | [GetInfluenceCostOfProposingPeace](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a660a1723378e87ec3853ffd1d7d13d12) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| override int | [GetInfluenceCostOfProposingWar](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a97c9995f8e8773c8b25494da4d0c8c2b) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| override int | [GetInfluenceValueOfSupportingClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a4379fa099bdf0f7dfc43e9c4afc844f3) () |
| override int | [GetRelationValueOfSupportingClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7869b738f268245900fa50460ae425a6) () |
| override int | [GetInfluenceCostOfAnnexation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a707cc9b112225c0b42c8933d2e7fa784) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposingClan) |
| override int | [GetInfluenceCostOfChangingLeaderOfArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7bb73df41adbc8468ab967192db8ca2e) () |
| override int | [GetInfluenceCostOfDisbandingArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a52efde713f2377f98b121f6c080d0164) () |
| override int | [GetRelationCostOfDisbandingArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#abacc169be28a637121b627c96b3ddc55) (bool isLeaderParty) |
| override int | [GetInfluenceCostOfPolicyProposalAndDisavowal](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ae450138a0013f3cdd325d1cc62f7e7fd) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) proposerClan) |
| override int | [GetInfluenceCostOfAbandoningArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aa799310fa1b812f4dcc467b2cfde4947) () |
| override int | [GetBaseRelation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a3aaaf7af071435139ab098e788e5fa44) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2) |
| override int | [GetEffectiveRelation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a54e82e2f2f8c078bc9750ee9c328114b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2) |
| override void | [GetHeroesForEffectiveRelation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ad5ff5184223da2dd5d56fd1bd4b09abb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2, out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) effectiveHero1, out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) effectiveHero2) |
| override int | [GetRelationChangeAfterClanLeaderIsDead](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a0c0a84e72c0a3f340256fc0a7b63b201) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) deadLeader, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) relationHero) |
| override int | [GetRelationChangeAfterVotingInSettlementOwnerPreliminaryDecision](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#afd506f01b4c21c6020f5c204e75a4edb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) supporter, bool hasHeroVotedAgainstOwner) |
| override int | [GetCharmExperienceFromRelationGain](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aa1bb90b442494d53367ad5e5587f7f41) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float relationChange, [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) detail) |
| override uint | [GetNotificationColor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a77259a70c39ecf3e6b1c212b537d70a9) ([ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) notificationType) |
| override float | [DenarsToInfluence](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a199e1c1073c793c281a458d56199e5e2) () |
| override float | [GetDecisionMakingThreshold](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aa07157d691ed27f875d9b708f1d21aee) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) consideringFaction) |
| override bool | [CanSettlementBeGifted](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a9c498f4cd82dad02e62d71633835a286) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlementToGift) |
| override float | [GetValueOfSettlementsForFaction](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#acd078cf9b4ad262d833e5c6e473ca76e) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| override IEnumerable< [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) > | [GetBarterGroups](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a3cdf5c4372419001393b7097362416bb) () |
| override bool | [IsPeaceSuitable](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a94dd53d10c6ef59768322841bd33751d) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaresPeace, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) factionDeclaredPeace) |
| override int | [GetDailyTributeToPay](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a43c52eeccaaaefaa1d0efbcd2c908224) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) factionToPay, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) factionToReceive, out int tributeDurationInDays) |
| override bool | [IsClanEligibleToBecomeRuler](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a2bf2aa5633713516419da723b8e3998a) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override? [DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083) | [GetShallowDiplomaticStance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a8606699acf70c4830f1a3d770789ed74) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| override [DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083) | [GetDefaultDiplomaticStance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#abc05ef37ca3e5ad681f3127812d20a52) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| override bool | [IsAtConstantWar](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#afe11b6c93d0496ec8be9e28c90ff8de6) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html) | |
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
| override int | [MinimumRelationWithConversationCharacterToJoinKingdom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a57c43d2ed1b17e6c2f77914a100516e8) `[get]` |
| override int | [GiftingTownRelationshipBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#afba5579187ef0f4d88ee640fd073c9e8) `[get]` |
| override int | [GiftingCastleRelationshipBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a3f2699d8a8a0ab3298ee8540d45fb38a) `[get]` |
| override int | [MaxRelationLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a344b57dcc2e3bdf4972c8abad739b905) `[get]` |
| override int | [MinRelationLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a46e51a8a16341260e38772da1bc280d3) `[get]` |
| override int | [MaxNeutralRelationLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a17021be8ee29017c91023ac278869d00) `[get]` |
| override int | [MinNeutralRelationLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a4522ca899d978692c5ce6760814f349e) `[get]` |
| override float | [WarDeclarationScorePenaltyAgainstAllies](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a11cb9b22b2fa812f92e856ba89d5a6b5) `[get]` |
| override float | [WarDeclarationScoreBonusAgainstEnemiesOfAllies](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a4b413c83a25e45e216744dd5f0c272de) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html) | |
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

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.DiplomacyModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html) | |
| enum | [DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083) {     [Neutral](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083ae9bb5320b3890b6747c91b5a71ae5a01) ,     [War](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083aab4b1482cb2ba3f1ee7fd9201c8a1fad)   } |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ad52395d64cd637ab64435bf3cba8e4d6)GetStrengthThresholdForNonMutualWarsToBeIgnoredToJoinKingdom()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetStrengthThresholdForNonMutualWarsToBeIgnoredToJoinKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToJoin* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a06787039bbc0616f243ab056ee96eebc)GetClanStrength()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetClanStrength | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aee20cb8706129d8fe9b5c30899b1993f)GetHeroCommandingStrengthForClan()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetHeroCommandingStrengthForClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a352d44ea81742c01cf20917f3d67cdb0)GetHeroGoverningStrengthForClan()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetHeroGoverningStrengthForClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7ae2fbb58a224544afd1ab3b254b76e4)GetRelationIncreaseFactor()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetRelationIncreaseFactor | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2*, |
|  |  | float | *relationChange* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a8d74919cec893541d8505c772518faa3)GetInfluenceAwardForSettlementCapturer()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceAwardForSettlementCapturer | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7f8a017515a60d678b3b6e3e076983c4)GetHourlyInfluenceAwardForBeingArmyMember()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetHourlyInfluenceAwardForBeingArmyMember | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aa817c2b6f57cea96bc40542a7ae37852)GetHourlyInfluenceAwardForRaidingEnemyVillage()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetHourlyInfluenceAwardForRaidingEnemyVillage | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ab73dd9eb9429980deb6d6f75cdb4da19)GetHourlyInfluenceAwardForBesiegingEnemyFortification()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetHourlyInfluenceAwardForBesiegingEnemyFortification | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a390685581e36dffd239f245b456f7666)GetScoreOfClanToJoinKingdom()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfClanToJoinKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a8227a7e3a2eb3a6bb4d6bd2ecbc0dfc6)GetScoreOfClanToLeaveKingdom()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfClanToLeaveKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a4b4adb4a876f4b7215fbacc3e5c1a767)GetScoreOfKingdomToGetClan()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfKingdomToGetClan | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7bf9224aacc136f151f84574b79e67f6)GetScoreOfKingdomToSackClan()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfKingdomToSackClan | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aa5d2c377d949dad17700f4533e8555a3)GetScoreOfMercenaryToJoinKingdom()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfMercenaryToJoinKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a2d1f03a8849a064301068c66326ba251)GetScoreOfMercenaryToLeaveKingdom()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfMercenaryToLeaveKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan*, |
|  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ad0361a6a63c708406d702f325e27e055)GetScoreOfKingdomToHireMercenary()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfKingdomToHireMercenary | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ab9333dae3f87a61797ea1c7fb01188a7)GetScoreOfKingdomToSackMercenary()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfKingdomToSackMercenary | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ace4101d7f2e9686b92886bcceb7c604b)GetScoreOfDeclaringPeaceForClan()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfDeclaringPeaceForClan | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaresPeace*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaredPeace*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *evaluatingClan*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason*, |
|  |  | bool | *includeReason* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a05b991263d8f80db8392989c49d7c91c)GetScoreOfDeclaringPeace()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfDeclaringPeace | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaresPeace*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaredPeace* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a736bf987faf7b462f872b1d7d0ed9a8e)GetWarProgressScore()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetWarProgressScore | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaresWar*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaredWar*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a26cade3852bbab293e26eb65f7f31cbc)GetScoreOfDeclaringWar()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfDeclaringWar | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaresWar*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaredWar*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *evaluatingClan*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *reason*, |
|  |  | bool | *includeReason* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ac2c316f8ec9f137cedcb244764929606)GetScoreOfLettingPartyGo()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetScoreOfLettingPartyGo | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *partyToLetGo* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aceef28e669c78232ed67d13fddbbc2ca)GetValueOfHeroForFaction()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetValueOfHeroForFaction | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *examinedHero*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *targetFaction*, |
|  |  | bool | *forMarriage* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a5bdbac489f1b231da6f39f3823b30b2e)GetRelationCostOfExpellingClanFromKingdom()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetRelationCostOfExpellingClanFromKingdom | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a10c8dc8b393377cb7a417f568907581b)GetInfluenceCostOfSupportingClan()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceCostOfSupportingClan | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7b6af07c6b3cd9e907a956afe11ff804)GetInfluenceCostOfExpellingClan()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceCostOfExpellingClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a660a1723378e87ec3853ffd1d7d13d12)GetInfluenceCostOfProposingPeace()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceCostOfProposingPeace | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a97c9995f8e8773c8b25494da4d0c8c2b)GetInfluenceCostOfProposingWar()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceCostOfProposingWar | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a4379fa099bdf0f7dfc43e9c4afc844f3)GetInfluenceValueOfSupportingClan()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceValueOfSupportingClan | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7869b738f268245900fa50460ae425a6)GetRelationValueOfSupportingClan()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetRelationValueOfSupportingClan | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a707cc9b112225c0b42c8933d2e7fa784)GetInfluenceCostOfAnnexation()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceCostOfAnnexation | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposingClan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a7bb73df41adbc8468ab967192db8ca2e)GetInfluenceCostOfChangingLeaderOfArmy()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceCostOfChangingLeaderOfArmy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a52efde713f2377f98b121f6c080d0164)GetInfluenceCostOfDisbandingArmy()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceCostOfDisbandingArmy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#abacc169be28a637121b627c96b3ddc55)GetRelationCostOfDisbandingArmy()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetRelationCostOfDisbandingArmy | ( | bool | *isLeaderParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ae450138a0013f3cdd325d1cc62f7e7fd)GetInfluenceCostOfPolicyProposalAndDisavowal()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceCostOfPolicyProposalAndDisavowal | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *proposerClan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aa799310fa1b812f4dcc467b2cfde4947)GetInfluenceCostOfAbandoningArmy()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetInfluenceCostOfAbandoningArmy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a3aaaf7af071435139ab098e788e5fa44)GetBaseRelation()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetBaseRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a54e82e2f2f8c078bc9750ee9c328114b)GetEffectiveRelation()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetEffectiveRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#ad5ff5184223da2dd5d56fd1bd4b09abb)GetHeroesForEffectiveRelation()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetHeroesForEffectiveRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2*, |
|  |  | out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *effectiveHero1*, |
|  |  | out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *effectiveHero2* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a0c0a84e72c0a3f340256fc0a7b63b201)GetRelationChangeAfterClanLeaderIsDead()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetRelationChangeAfterClanLeaderIsDead | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *deadLeader*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *relationHero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#afd506f01b4c21c6020f5c204e75a4edb)GetRelationChangeAfterVotingInSettlementOwnerPreliminaryDecision()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetRelationChangeAfterVotingInSettlementOwnerPreliminaryDecision | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *supporter*, |
|  |  | bool | *hasHeroVotedAgainstOwner* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aa1bb90b442494d53367ad5e5587f7f41)GetCharmExperienceFromRelationGain()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetCharmExperienceFromRelationGain | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | float | *relationChange*, |
|  |  | [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) | *detail* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a77259a70c39ecf3e6b1c212b537d70a9)GetNotificationColor()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override uint TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetNotificationColor | ( | [ChatNotificationType](namespace_tale_worlds_1_1_campaign_system_1_1_log_entries.html#a628fd036253f36676e3955c26502d24b) | *notificationType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a199e1c1073c793c281a458d56199e5e2)DenarsToInfluence()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.DenarsToInfluence | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#aa07157d691ed27f875d9b708f1d21aee)GetDecisionMakingThreshold()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetDecisionMakingThreshold | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *consideringFaction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a9c498f4cd82dad02e62d71633835a286)CanSettlementBeGifted()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.CanSettlementBeGifted | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlementToGift* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#acd078cf9b4ad262d833e5c6e473ca76e)GetValueOfSettlementsForFaction()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetValueOfSettlementsForFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a3cdf5c4372419001393b7097362416bb)GetBarterGroups()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override IEnumerable< [BarterGroup](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_group.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetBarterGroups | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a94dd53d10c6ef59768322841bd33751d)IsPeaceSuitable()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.IsPeaceSuitable | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaresPeace*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *factionDeclaredPeace* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a43c52eeccaaaefaa1d0efbcd2c908224)GetDailyTributeToPay()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetDailyTributeToPay | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *factionToPay*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *factionToReceive*, |
|  |  | out int | *tributeDurationInDays* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a2bf2aa5633713516419da723b8e3998a)IsClanEligibleToBecomeRuler()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.IsClanEligibleToBecomeRuler | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a8606699acf70c4830f1a3d770789ed74)GetShallowDiplomaticStance()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override? [DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083) TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetShallowDiplomaticStance | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#abc05ef37ca3e5ad681f3127812d20a52)GetDefaultDiplomaticStance()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [DiplomacyStance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_diplomacy_model.html#ade9f105f6b92e0bd41b93b5591a93083) TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GetDefaultDiplomaticStance | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#afe11b6c93d0496ec8be9e28c90ff8de6)IsAtConstantWar()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.IsAtConstantWar | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a57c43d2ed1b17e6c2f77914a100516e8)MinimumRelationWithConversationCharacterToJoinKingdom
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.MinimumRelationWithConversationCharacterToJoinKingdom | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#afba5579187ef0f4d88ee640fd073c9e8)GiftingTownRelationshipBonus
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GiftingTownRelationshipBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a3f2699d8a8a0ab3298ee8540d45fb38a)GiftingCastleRelationshipBonus
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.GiftingCastleRelationshipBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a344b57dcc2e3bdf4972c8abad739b905)MaxRelationLimit
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.MaxRelationLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a46e51a8a16341260e38772da1bc280d3)MinRelationLimit
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.MinRelationLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a17021be8ee29017c91023ac278869d00)MaxNeutralRelationLimit
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.MaxNeutralRelationLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a4522ca899d978692c5ce6760814f349e)MinNeutralRelationLimit
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.MinNeutralRelationLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a11cb9b22b2fa812f92e856ba89d5a6b5)WarDeclarationScorePenaltyAgainstAllies
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.WarDeclarationScorePenaltyAgainstAllies | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_diplomacy_model.html#a4b413c83a25e45e216744dd5f0c272de)WarDeclarationScoreBonusAgainstEnemiesOfAllies
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultDiplomacyModel.WarDeclarationScoreBonusAgainstEnemiesOfAllies | | get |

