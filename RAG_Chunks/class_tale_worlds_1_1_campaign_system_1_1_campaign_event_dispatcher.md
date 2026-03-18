--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html ---

TaleWorlds.CampaignSystem.CampaignEventDispatcher Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RemoveListeners](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a16c1840b259917e83e40f51fefcbc8b8) (Object o) |
| override void | [OnPlayerBodyPropertiesChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1ebaffb3b6e98751ac57fc63dba500de) () |
| override void | [OnHeroLevelledUp](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac4db84b275e574a08d2803b6790f4184) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool shouldNotify=true) |
| override void | [OnHomeHideoutChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a368d92c4ffb3a6a4563234c55c6f4870) ([BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html) banditPartyComponent, [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) oldHomeHideout) |
| override void | [OnCharacterCreationIsOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1d4458d03ce52d63977765d2ab82e556) () |
| override void | [OnHeroGainedSkill](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4e9ad7aaa042af9d41095437d41a16e0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int change=1, bool shouldNotify=true) |
| override void | [OnHeroWounded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af62233f70f7ab4ee878af6c157714bff) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) woundedHero) |
| override void | [OnHeroRelationChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0abf26c43395c754901feda7e507dc80) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) effectiveHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) effectiveHeroGainedRelationWith, int relationChange, bool showNotification, [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) detail, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) originalHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) originalGainedRelationWith) |
| override void | [OnLootDistributedToParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9b112d9cd54fd38369018413a4687b52) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) winnerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) lootedItems) |
| override void | [OnHeroOccupationChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a66998c6770a3017039286594c35fe016) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) oldOccupation) |
| override void | [OnBarterAccepted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acf5f156d3f12d72b9df56c69d9821f04) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offererHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > barters) |
| override void | [OnBarterCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a856f422d914bf3edebcb203d9893f44c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offererHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > barters) |
| override void | [OnHeroCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad32aead81cfc627b77cb97a20d92098b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isBornNaturally=false) |
| override void | [OnQuestLogAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aad113cfc0dae59058fe70a17a67d376b) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest, bool hideInformation) |
| override void | [OnIssueLogAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a70e0002ce49b8281a71c5f8707d2940a) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue, bool hideInformation) |
| override void | [OnClanTierChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a831e4d87bc6d6b9f4ac90b7f45fd9534) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool shouldNotify=true) |
| override void | [OnClanChangedKingdom](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abbef9ec395808f5d992f1683f4f5d53c) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) oldKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom, [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) actionDetail, bool showNotification=true) |
| override void | [OnClanDefected](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#add22b54989f6f90876bdc31debc92c53) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) oldKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom) |
| override void | [OnClanCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab624fe1292eb01e44dbbc3a46ec392d6) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool isCompanion) |
| override void | [OnHeroJoinedParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8fbf2ff7378048776d04b6e9512e8adf) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override void | [OnKingdomDecisionAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa4cba2c1a0075e0e1c62a5fc2b2336ad) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, bool isPlayerInvolved) |
| override void | [OnKingdomDecisionCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1669d5acda8512a8b1c26b0aa6f650d4) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, bool isPlayerInvolved) |
| override void | [OnKingdomDecisionConcluded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa84011de5db86bb0b804bcea07b87eb1) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome, bool isPlayerInvolved) |
| override void | [OnHeroOrPartyTradedGold](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a78b9a9a92a1580bf0bc278709f708e62) (ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > giver, ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > recipient, ValueTuple< int, string > goldAmount, bool showNotification) |
| override void | [OnHeroOrPartyGaveItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abba905727861a99ffcf9f4900eea59a0) (ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > giver, ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > receiver, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, bool showNotification) |
| override void | [OnBanditPartyRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a67d47a7b696d179d03728eccb01f17c9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) banditParty) |
| override void | [OnArmyCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7b21cc6863c8589cf7d4bd3371362313) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army) |
| override void | [OnPartyAttachedAnotherParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a64b034374cbc50d3a6cf0fb77c2c069b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnNearbyPartyAddedToPlayerMapEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a83f6bad94f59be66271cadf771a3ff61) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnArmyDispersed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a983cfc465ade1ed807b2020afc1fef46) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, [Army.ArmyDispersionReason](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798) reason, bool isPlayersArmy) |
| override void | [OnArmyGathered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae6213a2b79a21bffc74e062c379ac8c2) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) gatheringPoint) |
| override void | [OnPerkOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab20a762c1bee6883b49bd945ef5fe44b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| override void | [OnPerkReset](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aca0f9fd1c549d9466ddf96a69540ee76) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| override void | [OnPlayerTraitChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3b021415e8b511636db2d05eb5888402) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int previousLevel) |
| override void | [OnVillageStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a32bb35d9dad07fbd5d2ab0ae8e63cdbd) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village, [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) oldState, [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) newState, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) raiderParty) |
| override void | [OnSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1d1a8d1d57be8f12dce6a01c451e50d3) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnAfterSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a677f670479ee4e0cd332f978a3d488d2) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnBeforeSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0b50ac2543f1acf8a29ee4a789bd7039) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnMercenaryTroopChangedInTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8df2f81effeea1349a625b8d980da913) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) oldTroopType, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) newTroopType) |
| override void | [OnMercenaryNumberChangedInTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad4ada8f69c8e3e838704673be63bdfa0) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, int oldNumber, int newNumber) |
| override void | [OnAlleyOccupiedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae5577a4315cf45adb1fea5bd48d0a30e) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troops) |
| override void | [OnAlleyOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acf56506b3725dd22369712e87a4aafea) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner) |
| override void | [OnAlleyClearedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa373bdf85255a12c7f92e2b714889b11) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| override void | [OnRomanticStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8a077024d0a027896a619fedc9815334) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2, [Romance.RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) romanceLevel) |
| override void | [OnBeforeHeroesMarried](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a71ec3ad493a55c3c31666130fef98436) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2, bool showNotification) |
| override void | [OnPlayerEliminatedFromTournament](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae7499eecf9c53b0d8f6a54d940dd655b) (int round, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [OnPlayerStartedTournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9336ddc7a212ea58265d2cfdbd4d62ff) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [OnTournamentStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afc3e248142ca8dd9200214b0d5aa236e) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [OnTournamentFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b3c341549ab3cccb2c671cfae9d56b7) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) winner, MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > participants, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) prize) |
| override void | [OnTournamentCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2a1dc84c663c26bc528ef062d4947b41) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [OnWarDeclared](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aba4b2ae1012c2717f4c4b808860e9847) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2, [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) declareWarDetail) |
| override void | [OnRulingClanChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aca6b252d609fcbe9a9ba31dc9783edb0) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) newRulingClan) |
| override void | [OnStartBattle](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a663e516c42e30392c3d7552418aabbbf) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty, object subject, bool showNotification) |
| override void | [OnRebellionFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae3eb9f48a143262cc4461d891e0654ff) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) oldOwnerClan) |
| override void | [TownRebelliousStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0c86a21370e5ee6c177030d85c4277ed) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool rebelliousState) |
| override void | [OnRebelliousClanDisbandedAtSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a252198a36ffd7280630552db32d71daf) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) rebelliousClan) |
| override void | [OnItemsLooted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5f7ff81d04f4ac6e2c6606526ea086ff) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) items) |
| override void | [OnMobilePartyDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a194890dfceee16bf0a1b64fa08818313) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) destroyerParty) |
| override void | [OnMobilePartyCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af71a267ccb59fdbfb2f3d8a39cf794d7) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override void | [OnMapInteractableCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0f8fd9885e152863bb346b3250ec8551) ([IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) interactable) |
| override void | [OnMapInteractableDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a54d5945da50724d1e7d9710892b18f54) ([IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) interactable) |
| override void | [OnMobilePartyQuestStatusChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6605e025b28928b45fda9b7b8713dbf8) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isUsedByQuest) |
| override void | [OnHeroKilled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac0f2f651f00d72b893a6f14d88b550f3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool showNotification=true) |
| override void | [OnBeforeHeroKilled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a96c7f1be9d6bd66650683c61d40f1896) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool showNotification=true) |
| override void | [OnChildEducationCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a769ffcc1c235c5991e06ae3f2f508c72) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int age) |
| override void | [OnHeroComesOfAge](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abaa98c6153ab812300d48e8f80bad6f1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnHeroReachesTeenAge](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ade0956b3e567b4fc52ed0599e2f129fb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnHeroGrowsOutOfInfancy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a009e962ae72f96c7754d2ce622730133) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnCharacterDefeated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a099ad46670b11e51331ffd51c080f0b4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) loser) |
| override void | [OnHeroPrisonerTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#adb7dd67a23aa41fbb49102f0d8580263) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) capturer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisoner) |
| override void | [OnHeroPrisonerReleased](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab91ddde7d00d6f67ca8f09ef95bec193) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisoner, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) capturerFaction, [EndCaptivityDetail](namespace_tale_worlds_1_1_campaign_system_1_1_actions.html#a6a6556b279f5fa0db2c5ae9a933508fe) detail, bool showNotification=true) |
| override void | [OnCharacterBecameFugitive](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a34cc21b08385164200afa7db9807b5ab) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool showNotification) |
| override void | [OnPlayerLearnsAboutHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab99158e83a458d70ae234bfe4496850a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnPlayerMetHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#add05e49f7ca64f193858221ee8918c5f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnRenownGained](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0e60e4fe86b1cf7bd2dc82101e16af7b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int gainedRenown, bool doNotNotify) |
| override void | [OnCrimeRatingChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aee7b91a5a7dbbcf2b122851a3b250684) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) kingdom, float deltaCrimeAmount) |
| override void | [OnNewCompanionAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a224e955316cf0d4ae7f2bdbb303e9c56) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newCompanion) |
| override void | [OnAfterMissionStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af3ebda780987304e25a11fea71c08504) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) iMission) |
| override void | [OnGameMenuOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a47f14a8b031ab901a9c503a922187a32) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| override void | [OnMakePeace](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a222e2e5b54c186e9446b7a5ab30d5402) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) side1Faction, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) side2Faction, [MakePeaceAction.MakePeaceDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff) detail) |
| override void | [OnKingdomDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7f3d2f3d1c9f272c66f61eab8e7269a6) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) destroyedKingdom) |
| override void | [CanKingdomBeDiscontinued](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af8911c6310ba88b76c2fc675ad16df4d) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, ref bool result) |
| override void | [OnKingdomCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac2392a0f94078803e3200e4b47fe2db9) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) createdKingdom) |
| override void | [OnVillageBecomeNormal](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0e8bcae9545784ca78665d72508a7095) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| override void | [OnVillageBeingRaided](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab5905dd19c4a8a102c52789ef46cd7ce) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| override void | [OnVillageLooted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9a2834cec155e4e33432a149c89300ec) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| override void | [OnConversationEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a03fcddb7078f92395d003e9237745f9f) (IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > characters) |
| override void | [OnAgentJoinedConversation](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a05318ba5de68e2042bd0816725320f97) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| override void | [OnMapEventEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a21bd013cf48aa386c32b6e61ac1e8882) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| override void | [OnMapEventStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac0ca07a21f0cfb10a5fc1147c3c3c3d4) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |
| override void | [OnPrisonersChangeInSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a27eb26e4a440eac3bf45cd36adf65eab) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) prisonerRoster, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero, bool takenFromDungeon) |
| override void | [OnMissionStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9a98b71628b2c36f6220b5df78719cf3) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) mission) |
| override void | [OnPlayerBoardGameOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4681a73d82e90462e2db183f8e2a970d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) opposingHero, [BoardGameHelper.BoardGameState](class_helpers_1_1_board_game_helper.html#ab045b68fb522a41152b0557241b92db2) state) |
| override void | [OnRansomOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a00ada9319af0a319c21aa11a11cf7157) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) captiveHero) |
| override void | [OnRansomOfferCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4f2f5eae0944fe03bc1d667d3f168d3a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) captiveHero) |
| override void | [OnPeaceOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a635e6840cc52f97ba663fc048452e638) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) opponentFaction, int tributeAmount, int tributeDurationInDays) |
| override void | [OnTradeAgreementSigned](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a130a91040bee7a538d07c88585f7f82a) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) other) |
| override void | [OnPeaceOfferResolved](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9afbb66157aff37cb8ed0b0ba91e1987) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) opponentFaction) |
| override void | [OnMarriageOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6b845fef513f1089de460702fdc71c9e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden) |
| override void | [OnMarriageOfferCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a062de1b7669732006fde163187f7bb66) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden) |
| override void | [OnVassalOrMercenaryServiceOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9156772714bf003d140c862360479ebc) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) offeredKingdom) |
| override void | [OnCommonAreaStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af6f1962fafa9a98a61f357b974df6e1d) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) oldState, [Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) newState) |
| override void | [OnVassalOrMercenaryServiceOfferCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3d8014e55e9249ebb660bf13abb6a1e1) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) offeredKingdom) |
| override void | [BeforeMissionOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a548d0b24f62b703b0b2843b66d8277b8) () |
| override void | [OnPartyRemoved](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9fdff15633d16735bdbc0c9e10cfe3bf) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override void | [OnPartySizeChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0f2c75aaf93eee0f53b5563afd3dec96) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override void | [OnSettlementOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aabf24ac38b7d432ecc27785a61fefbc1) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool openToClaim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) capturerHero, ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail detail) |
| override void | [OnGovernorChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab800ee3c3be11a6cc37fc20d4c858c11) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) fortification, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldGovernor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newGovernor) |
| override void | [OnSettlementLeft](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad84b08377315563256ecda0f06b006e1) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override void | [Tick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b058daf7a15380a7e9221543b720252) (float dt) |
| override void | [OnSessionStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#addbb606605d2c20cef65b17a5ddaa90c) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnAfterSessionStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a951ea972f67d10b5de09232a4259a15f) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnNewGameCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4f1ecc8ed6f0fdae3cd0e953f113a7bf) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnGameEarlyLoaded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6a78e0c9a3f6da469818b8074901ece8) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnGameLoaded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2f3959ec85d3810ccbef838111fd2710) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnGameLoadFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a859c00334f78f9fafcff48d5c6c27f26) () |
| override void | [OnPartyJoinedArmy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aaa5151a9a086e4f632b5a7f284dd56f2) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnPartyRemovedFromArmy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abcbba7a66f3ca627c2d69816e0a53eb5) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnPlayerArmyLeaderChangedBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aac2877550d5ec45262d6e73dc6c9cb7b) () |
| override void | [OnArmyOverlaySetDirty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4745a9da06bdea51ec07429a999ef5c1) () |
| override void | [OnPlayerDesertedBattle](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afbef08d8b634851eb401aa1dd0b145ae) (int sacrificedMenCount) |
| override void | [MissionTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab4d76a6945672f9316be0927d2f30521) (float dt) |
| override void | [OnChildConceived](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6490e396e2fca65af871f32ff199c479) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) mother) |
| override void | [OnGivenBirth](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abeff63dab03bea5d342bbc3e2a561ffa) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) mother, List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > aliveChildren, int stillbornCount) |
| override void | [OnUnitRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7983388ac7efc4b6dda108f6a360527d) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, int amount) |
| override void | [OnPlayerBattleEnd](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7b71d8771f34a39d0d023e168e816e8b) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| override void | [OnMissionEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4e0ee798d470b3eab979b06025bd829d) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) mission) |
| override void | [TickPartialHourlyAi](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6df5a545dfd322be529215b4f908db38) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override void | [QuarterDailyPartyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9f7357b330be3fed497c4983b056decd) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override void | [AiHourlyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a21052b4a653f71e29a2138f9bee0e1d5) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) partyThinkParams) |
| override void | [HourlyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0411aa9c88131d89a4e9f53a845211d2) () |
| override void | [QuarterHourlyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af0fe4dc2344867f3f6b65855578ae010) () |
| override void | [HourlyTickParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#adbd2fdc691f8dcbbb092634f6f49c768) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [HourlyTickSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae0ef4abec1bdf34389c0763a291c4a86) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override void | [HourlyTickClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a60b7267cbd8bfa39f00704f59b80a893) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override void | [DailyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aea2a985d99cd5b2362f822e43fbbb39e) () |
| override void | [DailyTickParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6dd05507ae9e999e11f1ae02546884a9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [DailyTickTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac74fb6635bfd17667cb7e168dd57e62e) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [DailyTickSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abe4d387a96bb3413c6baa01f46aae202) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override void | [DailyTickHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8a61214d42e89804dca3fb9147b6199d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [DailyTickClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a46e3959ac62d0df29b2f27a8d0267d2e) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override void | [WeeklyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a14a84de507118ddcdf8e1da6343bd2d7) () |
| override void | [CollectAvailableTutorials](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9aec43c9e88434723e526916d889eb2f) (ref List< [CampaignTutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign_tutorial.html) > tutorials) |
| override void | [OnTutorialCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afaad870aab2497fbc088b0a4aaf3be5f) (string tutorial) |
| override void | [BeforeGameMenuOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aea6a663ef8aea3d2cdfcf53f69ceee26) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| override void | [AfterGameMenuInitialized](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5e67818e26dc05be6b06a9d3e6368523) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| override void | [OnBarterablesRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afdc204663b150a7a82cb01c352d0f7da) ([BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args) |
| override void | [OnPartyVisibilityChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a90f3623cf7f6f4eef906ed8cf4c8da26) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override void | [OnCompanionRemoved](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa9443d525d03fef6f92dc580eef79dfc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) companion, [RemoveCompanionAction.RemoveCompanionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_remove_companion_action.html#afebe445a9fd9044486e94c0db1b931ef) detail) |
| override void | [TrackDetected](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a963019088b53482125f824856026b9bd) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| override void | [TrackLost](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a833acbbc202f81aa45288aac0b5aa43b) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| override void | [LocationCharactersAreReadyToSpawn](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b44c98610918d78c0bd3804217c140c) (Dictionary< string, int > unusedUsablePointCount) |
| override void | [LocationCharactersSimulated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7918a471a0785842f08d4be6f3aa1ce7) () |
| override void | [OnBeforePlayerAgentSpawn](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aedeb8e4dcfaef223daa7e3153338d2c5) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) spawnFrame) |
| override void | [OnPlayerAgentSpawned](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5f7bfcbaa25433717e49c06175e75f3f) () |
| override void | [OnPlayerUpgradedTroops](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8d5608db958ea96c0ff8d7e0300e2eb9) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgradeFromTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgradeToTroop, int number) |
| override void | [OnHeroCombatHit](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abf2a235f22b11798f137d1bd7c7f59d5) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackerTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackedTroop, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) usedWeapon, bool isFatal, int xp) |
| override void | [OnCharacterPortraitPopUpOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aee42ec6fac27bd4def6c835ba4984433) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| override void | [OnCharacterPortraitPopUpClosed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa545bd48cbd7b54da14b0fb226dba612) () |
| override void | [OnPlayerStartTalkFromMenu](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4e53e4fa3c398a5926d3ab891af6b685) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnGameMenuOptionSelected](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3c1536ede88489a93f310134298eb86b) ([GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) gameMenu, [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) gameMenuOption) |
| override void | [OnPlayerStartRecruitment](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afc70cf5e77451ff4231ffe27a9696fc4) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) recruitTroopCharacter) |
| override void | [OnBeforePlayerCharacterChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6f2279cbd5f2a2a3b3c791065fabf19b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldPlayer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newPlayer) |
| override void | [OnPlayerCharacterChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5cab6f8aa84e658faf46598b846c8837) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldPlayer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newPlayer, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) newPlayerParty, bool isMainPartyChanged) |
| override void | [OnClanLeaderChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abd4d51e956e561ef152b0384f365455b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldLeader, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |
| override void | [OnSiegeEventStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ace66dec7e920d1f2378e8a3db30644c1) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| override void | [OnPlayerSiegeStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a272f1fc8ab96dd18ed97d36946254b4c) () |
| override void | [OnSiegeEventEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4d0c053a6062e7faf949ffab9ad81471) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| override void | [OnSiegeAftermathApplied](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad1929bcb5a03892b73de7f76f6b7f39d) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, SiegeAftermathAction.SiegeAftermath aftermathType, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) previousSettlementOwner, Dictionary< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), float > partyContributions) |
| override void | [OnSiegeBombardmentHit](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acd912d196eb2c152c845103ed7caa544) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) besiegerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) besiegedSettlement, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) weapon, [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) target) |
| override void | [OnSiegeBombardmentWallHit](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa823e3be5dca46963329e2fd1ff22ce6) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) besiegerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) besiegedSettlement, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) weapon, bool isWallCracked) |
| override void | [OnSiegeEngineDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a03a8a8949b18133f7de5369972cd7696) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) besiegerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) besiegedSettlement, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) destroyedEngine) |
| override void | [OnTradeRumorIsTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4bba1264c58536c13b508ca404bcbf5f) (List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > newRumors, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) sourceSettlement=null) |
| override void | [OnCheckForIssue](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a92d92fe632b58f1b7b9f89be98f2c814) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnIssueUpdated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b71ea9b2fff16bc00c3d749dfd7c6ca) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue, [IssueBase.IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b) details, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) issueSolver) |
| override void | [OnTroopsDeserted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a076381bb90d0c999acb40b25040d5eb9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) desertedTroops) |
| override void | [OnTroopRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab4950efc3ed45279f2bb907242c277a2) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) recruiterHero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) recruitmentSettlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) recruitmentSource, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int amount) |
| override void | [OnTroopGivenToSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4404084960b181592de35373f3aa1340) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) giverHero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) recipientSettlement, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) roster) |
| override void | [OnItemSold](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa7854538621ac8b06faaedb472518cc4) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) receiverParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) payerParty, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, int number, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) currentSettlement) |
| override void | [OnCaravanTransactionCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a39495f637148b0797f701d8d1cafdb87) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) caravanParty, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, List< ValueTuple< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), int > > itemRosterElements) |
| override void | [OnPrisonerSold](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1b09139010797e1d65d04cbfdd4b3398) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) sellerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) buyerParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) prisoners) |
| override void | [OnPartyDisbanded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afc97878261ab06e372226ff71212ffda) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) disbandParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) relatedSettlement) |
| override void | [OnPartyDisbandStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a29586fa84cebda55747921b596a7b2fa) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) disbandParty) |
| override void | [OnPartyDisbandCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acbbc3536f26040ea1ae81e688086217f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) disbandParty) |
| override void | [OnBuildingLevelChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab808591785e1a563c38740156f7cdab5) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) building, int levelChange) |
| override void | [OnHideoutSpotted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afba487b749c0abf30692716ae896d188) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) hideoutParty) |
| override void | [OnHideoutDeactivated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae0bcc7e4cf1c730f24eeabbe4f35e39f) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) hideout) |
| override void | [OnHeroSharedFoodWithAnother](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aff803c5d7f11d4858632ad3f8143944c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) supporterHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) supportedHero, float influence) |
| override void | [OnItemsDiscardedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aaab148dfd82a57d968fee2731d1a31ec) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) roster) |
| override void | [OnPlayerInventoryExchange](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9c21fe1a074e3a8f382d9460c9001b08) (List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > purchasedItems, List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > soldItems, bool isTrading) |
| override void | [OnPersuasionProgressCommitted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afb339a525be1bde4c554ff2bed482263) (Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > progress) |
| override void | [OnQuestCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a78e5a2408e695fee00734612798906e9) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest, [QuestBase.QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) detail) |
| override void | [OnQuestStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5cc70018223dc9bbdcda48958cadfcd3) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest) |
| override void | [OnItemProduced](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a33c20ee111dd5292350325f31ff7c82e) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, int count) |
| override void | [OnItemConsumed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a61d7763ac7805f212e845f72a65b5ac5) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, int count) |
| override void | [OnPartyConsumedFood](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae2a4bf82ece383d1cd8f4e255a5f3f4f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override void | [OnNewIssueCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a97b7235e67f3a00b092faee99037483d) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| override void | [OnIssueOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7b598a79bca3629cd2eaed574454ed58) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner) |
| override void | [OnBeforeMainCharacterDied](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab739089858407aa99bc0dba3438bf7e2) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool showNotification=true) |
| override void | [OnGameOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0ae0cc0b989968d012bc77a0610ff180) () |
| override void | [SiegeCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a92a93211e65baeb4824e8ff12bc7f385) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) siegeSettlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, bool isWin, [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) battleType) |
|  | SiegeCompleted event triggers when a siege ends with a normal outcome. If attackers are defeated "partially", it won't be fired, because the siege event doesn't actually end, and battle state is set to none. |
| override void | [AfterSiegeCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0b7019d99b625d0bbecdd33eb3568bff) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) siegeSettlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, bool isWin, BattleTypes battleType) |
| override void | [SiegeEngineBuilt](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a97ee2804147fb49b6bba6012d4649b0f) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine) |
| override void | [RaidCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1d17aebd3e0449f13286e4cacb3546e4) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html) raidEvent) |
| override void | [ForceSuppliesCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afeba6e9598f84547316035242929a13f) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html) forceSuppliesEvent) |
| override void | [ForceVolunteersCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9f2f63852995cad840181a069ed922c4) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html) forceVolunteersEvent) |
| override void | [OnHideoutBattleCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abecd876d4296f4e1b06182051d5b2a23) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html) hideoutEventComponent) |
| override void | [OnClanDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0a222eb29ee8a8d745a1af9d64d5529a) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) destroyedClan) |
| override void | [OnNewItemCrafted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af778c766565f0015798493416bf2a3ca) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) overriddenItemModifier, bool isCraftingOrderItem) |
| override void | [OnWorkshopOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2af2cf8a2bf8bbf4f5adf71b541b6b9a) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner) |
| override void | [OnWorkshopInitialized](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9f8551264ae776b51dfb5963a0166857) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| override void | [OnWorkshopTypeChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa545d792549ae463d12d372f518f3c24) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| override void | [OnMainPartyPrisonerRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a147a5cd6e0aa9b636a0dd5c0b93b4c97) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) roster) |
| override void | [OnPrisonerDonatedToSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afa9f4ef080192766792115d774e66b04) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) donatingParty, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) donatedPrisoners, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) donatedSettlement) |
| override void | [OnEquipmentSmeltedByHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4daf25e8a08e5dc3d4fc21dddfdb42c5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) equipmentElement) |
| override void | [OnPrisonerTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aafdefb5bc8ef4b43107e7c118e17839f) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) roster) |
| override void | [OnBeforeSave](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aeaf7692287a7cf63ab883b50242ce3f4) () |
| override void | [OnSaveStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4f67ad2a595842e4307c7713f3cf65f6) () |
| override void | [OnSaveOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac8671e97871fd97c11437b24ce2c7eab) (bool isSuccessful, string saveName) |
| override void | [OnPrisonerReleased](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acdd7c2446489a61d94a1acd709f46825) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) roster) |
| override void | [OnHeroChangedClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac3b4584cfa89b3ef602ee92da05bcceb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) oldClan) |
| override void | [OnHeroGetsBusy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1a315e86747b4905b62af4c3d017491a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [HeroGetsBusyReasons](namespace_tale_worlds_1_1_campaign_system.html#a74f96a6c3de3af13ac985228276ee611) heroGetsBusyReason) |
| override void | [OnPlayerTradeProfit](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae306cc55b9c27304e2631e2a72f03cd2) (int profit) |
| override void | [CraftingPartUnlocked](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2c30f4995fd1f019448b93034b190b8d) ([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) craftingPiece) |
| override void | [OnClanEarnedGoldFromTribute](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1da444193339c51c687f65f792246c64) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) receiverClan, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) payingFaction) |
| override void | [OnCollectLootItems](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a40cd5d7d7cf74c2025f847ce81b5e92d) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) winnerParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) gainedLoots) |
| override void | [OnHeroTeleportationRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad052fcee6c17979298ee5eeb08b712ea) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetParty, [TeleportHeroAction.TeleportationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90) detail) |
| override void | [OnClanInfluenceChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a15def105aa99e64276d5ecd3b83bd34d) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, float change) |
| override void | [OnPlayerPartyKnockedOrKilledTroop](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9e5e2e15a213d76e250f4314eaee0e5a) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) strikedTroop) |
| override void | [OnPlayerEarnedGoldFromAsset](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acd08fd36d848e36cbbae86b12e7ae7c7) ([GameComponents.DefaultClanFinanceModel.AssetIncomeType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50) incomeType, int incomeAmount) |
| override void | [OnPartyLeaderChangeOfferCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9aa9955161536d87de2aaafed6141b9f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override void | [OnPartyLeaderChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2bf55c46dfb35efc894298f5b1c4829d) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldLeader) |
| override void | [OnMainPartyStarving](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#addeb4e9b75fa2ae3801a4593134f107e) () |
| override void | [OnPlayerJoinedTournament](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad0a706641928b5e8791d8c2784f96ad9) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool isParticipant) |
| override void | [OnCraftingOrderCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a60bd566f2131dfc18e0bfd684972429c) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) completerHero) |
| override void | [OnItemsRefined](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a57dc93db42ff464dbd3b041d56b59768) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, Crafting.RefiningFormula refineFormula) |
| override void | [OnMapEventContinuityNeedsUpdate](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a546e81985a1b03f3b5498726b61fb7ae) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| override void | [OnHeirSelectionRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acd431249bf5d9b400b4c133b9be8e4f6) (Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > heirApparents) |
| override void | [OnHeirSelectionOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9fb6ed574fff7472bf2f33fb949603b1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) selectedHeir) |
| override void | [OnCharacterCreationInitialized](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3ce8248851309a782a1ebade755e9051) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| override void | [OnShipDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5a41695310f2fab3eaf292d1ed6e327a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) owner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [DestroyShipAction.ShipDestroyDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_destroy_ship_action.html#a52f9b7dcd67d7a49fc241de25137f7d1) detail) |
| override void | [OnPartyLeftArmy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a70859458ed6ac7cc68927c6b5c05e455) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army) |
| override void | [OnShipOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab31ae13444f0d6393628123731188a10) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) oldOwner, [ChangeShipOwnerAction.ShipOwnerChangeDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f) changeDetail) |
| override void | [OnShipRepaired](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af89e7ba7713491182dfd738f8554b96d) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) repairPort) |
| override void | [OnFigureheadUnlocked](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a08005455615c52a5903978d5eee30ef9) ([Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) figurehead) |
| override void | [OnPartyAddedToMapEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0c9bad0bfc7aafeab89ba29d0b639cc3) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override void | [OnIncidentResolved](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4bd08f702d13ef00d9ae4161a38f1b69) ([Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) incident) |
| override void | [OnMobilePartyNavigationStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5fa5cf0d1b556a95699a076c7ef727c4) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnMobilePartyJoinedToSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a855355f753c1e56611696cd3d69fb4e8) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnMobilePartyLeftSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4613ac289c2c9ad119e2768fe9e419a9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnBlockadeActivated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8c4f535a4f65eeae738522c83f2084de) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| override void | [OnBlockadeDeactivated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab2bce57b5c07c78554a729a5578940a2) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| override void | [OnMapMarkerCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0b67ac087f85fa21c314353522d1fe77) ([MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) mapMarker) |
| override void | [OnMapMarkerRemoved](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4d1023d60bad15ffe2a2c7b2ebeebf70) ([MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) mapMarker) |
| override void | [OnMercenaryServiceStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a71152eeba9454b806890a25ad33f6727) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan, [StartMercenaryServiceAction.StartMercenaryServiceActionDetails](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_start_mercenary_service_action.html#a5861e61ec787655431332d6abb63721a) details) |
| override void | [OnMercenaryServiceEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7042a8449525fa8b7193ab07286d5776) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan, EndMercenaryServiceAction.EndMercenaryServiceActionDetails details) |
| override void | [OnAllianceStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5d298d2eac50c34dbd485486fdd82a9b) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| override void | [OnAllianceEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae014d1e48b109cf7b6daa4d2d9be5fca) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| override void | [OnCallToWarAgreementStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa3315a732dad68a54c96023ec1e21911) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| override void | [OnCallToWarAgreementEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa382b2df13be63e4f2a81fafba2d4805) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| override void | [CanHeroLeadParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6f399d722d86f9d1162e2da45e5db878) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroMarry](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abb26f31b1a0230e4dd107af1591044be) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroEquipmentBeChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af6ca841284bc788936f342e45f148222) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanBeGovernorOrHavePartyRole](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a93cd128b1a1b11505ce879cd240fe333) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroDie](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab82b5bc212d25f8d608742885062daba) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) causeOfDeath, ref bool result) |
| override void | [CanHeroBecomePrisoner](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a247f7f30efe6d5dc4148d48e469b1204) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanPlayerMeetWithHeroAfterConversation](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a02baa7b1ebdab83422754913248bb611) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanMoveToSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5eaafefa05ad0cc72705883be4639f22) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHaveCampaignIssues](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab0ca999f4b544e06e35592dec37e626b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [IsSettlementBusy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad4dce969b184fa3c80adce1bba493ca2) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, object asker, ref int priority) |
| override void | [OnHeroUnregistered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a043b42b716d41e7f319567df181e8057) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnShipCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3e0b3640e3447c952f65fd1829c2908b) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) createdSettlement) |
| override void | [OnConfigChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3b515d37668464af1081ca997d9aeb03) () |
| override void | [OnMobilePartyRaftStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad5aa09a30e5b9ecee991d911b63881e8) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html) | |
| virtual void | [OnNewItemCrafted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a501a665e70d0c652e349c3b321f34430) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject) |

|  |  |
| --- | --- |
| Properties | |
| static CampaignEventDispatcher | [Instance](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3ac86076bbbc0849c63da284ce197aca) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a16c1840b259917e83e40f51fefcbc8b8)RemoveListeners()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.RemoveListeners | ( | Object | *o* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a30c010ec60d81a1f6cbf2317efd3ddeb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1ebaffb3b6e98751ac57fc63dba500de)OnPlayerBodyPropertiesChanged()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerBodyPropertiesChanged | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a42192abcd3dc3b1b2afd793d4c6e2c34).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac4db84b275e574a08d2803b6790f4184)OnHeroLevelledUp()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroLevelledUp | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *shouldNotify* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab566f030c822fd4cbb09513a4d2836bb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a368d92c4ffb3a6a4563234c55c6f4870)OnHomeHideoutChanged()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHomeHideoutChanged | ( | [BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html) | *banditPartyComponent*, | |  |  | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) | *oldHomeHideout* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af54816c97132e599daecf0afd69e4288).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1d4458d03ce52d63977765d2ab82e556)OnCharacterCreationIsOver()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCharacterCreationIsOver | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8d7323ebc7d38c26760126df4427a633).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4e9ad7aaa042af9d41095437d41a16e0)OnHeroGainedSkill()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroGainedSkill | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, | |  |  | int | *change* = 1, | |  |  | bool | *shouldNotify* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a774dde909dfe3a56e5f1f2855f37291d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af62233f70f7ab4ee878af6c157714bff)OnHeroWounded()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroWounded | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *woundedHero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a625e18d200941d39c69344d5b9433c2c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0abf26c43395c754901feda7e507dc80)OnHeroRelationChanged()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroRelationChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *effectiveHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *effectiveHeroGainedRelationWith*, | |  |  | int | *relationChange*, | |  |  | bool | *showNotification*, | |  |  | [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) | *detail*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *originalHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *originalGainedRelationWith* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0847916b31147173736364528ec6ee49).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9b112d9cd54fd38369018413a4687b52)OnLootDistributedToParty()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnLootDistributedToParty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *winnerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *lootedItems* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a520767a6cdf6339bc7b643a91eefe842).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a66998c6770a3017039286594c35fe016)OnHeroOccupationChanged()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroOccupationChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) | *oldOccupation* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a48aad6e8dbaf5703c46f3f2b374b9e9f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acf5f156d3f12d72b9df56c69d9821f04)OnBarterAccepted()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBarterAccepted | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offererHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, | |  |  | List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | *barters* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a20f5223478e91a352f32b5d91df3f215).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a856f422d914bf3edebcb203d9893f44c)OnBarterCanceled()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBarterCanceled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offererHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, | |  |  | List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | *barters* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7260af52532867d6d7a01fbb516c3d07).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad32aead81cfc627b77cb97a20d92098b)OnHeroCreated()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroCreated | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *isBornNaturally* = false ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a05e630443f776a6c1b9f9612cec60031).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aad113cfc0dae59058fe70a17a67d376b)OnQuestLogAdded()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnQuestLogAdded | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest*, | |  |  | bool | *hideInformation* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a498dd4bb8db0b0f9764c5d430d6698a4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a70e0002ce49b8281a71c5f8707d2940a)OnIssueLogAdded()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnIssueLogAdded | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue*, | |  |  | bool | *hideInformation* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add0408270dc933a0bac52deb7ca20058).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a831e4d87bc6d6b9f4ac90b7f45fd9534)OnClanTierChanged()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnClanTierChanged | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *shouldNotify* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab2e5269e3afaf90afacf70f862b6e846).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abbef9ec395808f5d992f1683f4f5d53c)OnClanChangedKingdom()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnClanChangedKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *oldKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom*, | |  |  | [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) | *actionDetail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a015a602a70828d9e92b571cf5a1e1ca8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#add22b54989f6f90876bdc31debc92c53)OnClanDefected()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnClanDefected | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *oldKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abc55047e4785adff779e0754451ea424).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab624fe1292eb01e44dbbc3a46ec392d6)OnClanCreated()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnClanCreated | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *isCompanion* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af7e7a45cbeaede6021ed4fbcf0eb5b0e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8fbf2ff7378048776d04b6e9512e8adf)OnHeroJoinedParty()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroJoinedParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad7dcc8181382dbe9b9e0dd0439ef3586).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa4cba2c1a0075e0e1c62a5fc2b2336ad)OnKingdomDecisionAdded()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnKingdomDecisionAdded | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision*, | |  |  | bool | *isPlayerInvolved* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9a8a4e5a1b7331d9873402430fdad319).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1669d5acda8512a8b1c26b0aa6f650d4)OnKingdomDecisionCancelled()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnKingdomDecisionCancelled | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision*, | |  |  | bool | *isPlayerInvolved* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab405f44fe4a5bbe5c430afe873f6211f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa84011de5db86bb0b804bcea07b87eb1)OnKingdomDecisionConcluded()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnKingdomDecisionConcluded | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision*, | |  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome*, | |  |  | bool | *isPlayerInvolved* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a45c01f7262fea33c04e71f7a6404348b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a78b9a9a92a1580bf0bc278709f708e62)OnHeroOrPartyTradedGold()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroOrPartyTradedGold | ( | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *giver*, | |  |  | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *recipient*, | |  |  | ValueTuple< int, string > | *goldAmount*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7ba4f835d34bde173d96329691e9c921).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abba905727861a99ffcf9f4900eea59a0)OnHeroOrPartyGaveItem()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroOrPartyGaveItem | ( | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *giver*, | |  |  | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *receiver*, | |  |  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aefec55dd3f5ebe48fe1131de64f2724c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a67d47a7b696d179d03728eccb01f17c9)OnBanditPartyRecruited()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBanditPartyRecruited | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *banditParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6d5c54c4922af962519c94d697da6a61).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7b21cc6863c8589cf7d4bd3371362313)OnArmyCreated()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnArmyCreated | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae5c7c8c0623112a24b92f45775da9ef3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a64b034374cbc50d3a6cf0fb77c2c069b)OnPartyAttachedAnotherParty()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyAttachedAnotherParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a70e9cf8fa0db1f683469486d17370def).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a83f6bad94f59be66271cadf771a3ff61)OnNearbyPartyAddedToPlayerMapEvent()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnNearbyPartyAddedToPlayerMapEvent | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa4aa33f9b5a7fa4fd152926e525c3bee).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a983cfc465ade1ed807b2020afc1fef46)OnArmyDispersed()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnArmyDispersed | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, | |  |  | [Army.ArmyDispersionReason](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798) | *reason*, | |  |  | bool | *isPlayersArmy* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add2840f58e65bb5718ccdef8d8cdbb36).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae6213a2b79a21bffc74e062c379ac8c2)OnArmyGathered()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnArmyGathered | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, | |  |  | [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) | *gatheringPoint* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a54baf1826c91309838e376e75e57d9ef).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab20a762c1bee6883b49bd945ef5fe44b)OnPerkOpened()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPerkOpened | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aee81305bf3166d5e570ee5ecfe9b10a5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aca0f9fd1c549d9466ddf96a69540ee76)OnPerkReset()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPerkReset | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a46d6825fd7135c94d5c46b61af4da22b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3b021415e8b511636db2d05eb5888402)OnPlayerTraitChanged()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerTraitChanged | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, | |  |  | int | *previousLevel* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae3c7084a4ba93a0cb9c43b54cc86f682).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a32bb35d9dad07fbd5d2ab0ae8e63cdbd)OnVillageStateChanged()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnVillageStateChanged | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village*, | |  |  | [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | *oldState*, | |  |  | [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | *newState*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *raiderParty* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaaf549d05ae27a9de85ea15be155974d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1d1a8d1d57be8f12dce6a01c451e50d3)OnSettlementEntered()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34a08aad1b66ef9fb1a0f77377041c80).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a677f670479ee4e0cd332f978a3d488d2)OnAfterSettlementEntered()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnAfterSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a81b5ae8709aa37f1ab97f244d5b4299c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0b50ac2543f1acf8a29ee4a789bd7039)OnBeforeSettlementEntered()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBeforeSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5cb188b4bddbe0e32a602eb89339ff08).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8df2f81effeea1349a625b8d980da913)OnMercenaryTroopChangedInTown()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMercenaryTroopChangedInTown | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *oldTroopType*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *newTroopType* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a19f1714761ef9137b2a09c004880fdb7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad4ada8f69c8e3e838704673be63bdfa0)OnMercenaryNumberChangedInTown()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMercenaryNumberChangedInTown | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | int | *oldNumber*, | |  |  | int | *newNumber* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afdeef75c68facf73a9a3da673fa64120).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae5577a4315cf45adb1fea5bd48d0a30e)OnAlleyOccupiedByPlayer()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnAlleyOccupiedByPlayer | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troops* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afb1c1846367ec6cb096c523dfeb75de8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acf56506b3725dd22369712e87a4aafea)OnAlleyOwnerChanged()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnAlleyOwnerChanged | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a12183794116453d1920425fb1a0f1c06).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa373bdf85255a12c7f92e2b714889b11)OnAlleyClearedByPlayer()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnAlleyClearedByPlayer | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a94cecba044b9fb6b1d496718937aac6a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8a077024d0a027896a619fedc9815334)OnRomanticStateChanged()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnRomanticStateChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2*, | |  |  | [Romance.RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) | *romanceLevel* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4ef69fd2052fed76b92492482b0d23a0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a71ec3ad493a55c3c31666130fef98436)OnBeforeHeroesMarried()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBeforeHeroesMarried | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a98d83294d0cc4c5c2829b5927310a925).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae7499eecf9c53b0d8f6a54d940dd655b)OnPlayerEliminatedFromTournament()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerEliminatedFromTournament | ( | int | *round*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a467f012c0ebec2f57b4eee9a0817136d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9336ddc7a212ea58265d2cfdbd4d62ff)OnPlayerStartedTournamentMatch()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerStartedTournamentMatch | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad65f3efd3ce650f123b8b20af29dbb2c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afc3e248142ca8dd9200214b0d5aa236e)OnTournamentStarted()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnTournamentStarted | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9d5972dfefb563fbd011cd2ff86dba72).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b3c341549ab3cccb2c671cfae9d56b7)OnTournamentFinished()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnTournamentFinished | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *winner*, | |  |  | MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *participants*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *prize* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab8a512aebcd7550547be2484477c7673).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2a1dc84c663c26bc528ef062d4947b41)OnTournamentCancelled()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnTournamentCancelled | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a75f25270c3a7cc08c1a6b56c162cdbf0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aba4b2ae1012c2717f4c4b808860e9847)OnWarDeclared()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnWarDeclared | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2*, | |  |  | [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) | *declareWarDetail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1b454dafed5b1da0d3f7a16c142d6e72).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aca6b252d609fcbe9a9ba31dc9783edb0)OnRulingClanChanged()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnRulingClanChanged | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *newRulingClan* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9bada74a737fe40043ba626c7734ef93).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a663e516c42e30392c3d7552418aabbbf)OnStartBattle()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnStartBattle | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty*, | |  |  | object | *subject*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afc6415a7dc758250a8adbac387f47004).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae3eb9f48a143262cc4461d891e0654ff)OnRebellionFinished()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnRebellionFinished | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *oldOwnerClan* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4c33911e4f68d8fb63b050d631bcc971).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0c86a21370e5ee6c177030d85c4277ed)TownRebelliousStateChanged()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.TownRebelliousStateChanged | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *rebelliousState* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af983512cf4a2250654d6f68d52cf8139).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a252198a36ffd7280630552db32d71daf)OnRebelliousClanDisbandedAtSettlement()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnRebelliousClanDisbandedAtSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *rebelliousClan* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adca45c31fb5767cbaebd49fbc00f2af2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5f7ff81d04f4ac6e2c6606526ea086ff)OnItemsLooted()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnItemsLooted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *items* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2413d12700d18aea5d789566410076e2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a194890dfceee16bf0a1b64fa08818313)OnMobilePartyDestroyed()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMobilePartyDestroyed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *destroyerParty* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a83399ccb5af654bc810e1aa3695d73d2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af71a267ccb59fdbfb2f3d8a39cf794d7)OnMobilePartyCreated()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMobilePartyCreated | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae1a37302077e16224eae7622c70eddda).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0f8fd9885e152863bb346b3250ec8551)OnMapInteractableCreated()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMapInteractableCreated | ( | [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) | *interactable* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1ae04e92878f6098c97dd286e249fce0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a54d5945da50724d1e7d9710892b18f54)OnMapInteractableDestroyed()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMapInteractableDestroyed | ( | [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) | *interactable* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3a06afc7142607764857ef5970c16cc3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6605e025b28928b45fda9b7b8713dbf8)OnMobilePartyQuestStatusChanged()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMobilePartyQuestStatusChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | bool | *isUsedByQuest* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae19e20a00d6fad6f78d25ffa08109bfd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac0f2f651f00d72b893a6f14d88b550f3)OnHeroKilled()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroKilled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0bac5bea643a360776c14acb7b0f5291).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a96c7f1be9d6bd66650683c61d40f1896)OnBeforeHeroKilled()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBeforeHeroKilled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a725002864af0aa2a629f3d5448677172).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a769ffcc1c235c5991e06ae3f2f508c72)OnChildEducationCompleted()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnChildEducationCompleted | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *age* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a11f91f90e077f050c33d67866c3e83aa).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abaa98c6153ab812300d48e8f80bad6f1)OnHeroComesOfAge()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroComesOfAge | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#addab04c615c3a47008e02cdac4ee9493).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ade0956b3e567b4fc52ed0599e2f129fb)OnHeroReachesTeenAge()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroReachesTeenAge | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4a1f249bacb71890d0e93146a43cf659).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a009e962ae72f96c7754d2ce622730133)OnHeroGrowsOutOfInfancy()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroGrowsOutOfInfancy | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac9334bcdd529dc13fbd707f9b9dff547).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a099ad46670b11e51331ffd51c080f0b4)OnCharacterDefeated()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCharacterDefeated | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *loser* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac22e666e7df0a779a3063af689a1f957).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#adb7dd67a23aa41fbb49102f0d8580263)OnHeroPrisonerTaken()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroPrisonerTaken | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *capturer*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisoner* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f4366bdf2d5ed8f40840385ca8c4f0c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab91ddde7d00d6f67ca8f09ef95bec193)OnHeroPrisonerReleased()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroPrisonerReleased | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisoner*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *capturerFaction*, | |  |  | [EndCaptivityDetail](namespace_tale_worlds_1_1_campaign_system_1_1_actions.html#a6a6556b279f5fa0db2c5ae9a933508fe) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afa8773a1e419eb74dcfcf1f42bccda00).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a34cc21b08385164200afa7db9807b5ab)OnCharacterBecameFugitive()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCharacterBecameFugitive | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a87b8102e3a719199890062358b8d402b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab99158e83a458d70ae234bfe4496850a)OnPlayerLearnsAboutHero()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerLearnsAboutHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad56fd9fadd8c85144e68e77a2ddecf32).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#add05e49f7ca64f193858221ee8918c5f)OnPlayerMetHero()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerMetHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ade69c57127eb267ea9ef41bff3ff3bc6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0e60e4fe86b1cf7bd2dc82101e16af7b)OnRenownGained()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnRenownGained | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *gainedRenown*, | |  |  | bool | *doNotNotify* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9b11f3154f636b85e22adcb1be2145a4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aee7b91a5a7dbbcf2b122851a3b250684)OnCrimeRatingChanged()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCrimeRatingChanged | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *kingdom*, | |  |  | float | *deltaCrimeAmount* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a898868c9c0bb7ac1ab381e1fa9725f09).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a224e955316cf0d4ae7f2bdbb303e9c56)OnNewCompanionAdded()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnNewCompanionAdded | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newCompanion* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a706a5514966f701e5f4312bd1b8f7f4c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af3ebda780987304e25a11fea71c08504)OnAfterMissionStarted()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnAfterMissionStarted | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *iMission* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6b438896c4aef7588eb6a6fc38418036).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a47f14a8b031ab901a9c503a922187a32)OnGameMenuOpened()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnGameMenuOpened | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae3353fa62c4908b94dc2a74472bf3a3b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a222e2e5b54c186e9446b7a5ab30d5402)OnMakePeace()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMakePeace | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *side1Faction*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *side2Faction*, | |  |  | [MakePeaceAction.MakePeaceDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff) | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0dcc68b946f5ceae0cd2f58f1f481bb6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7f3d2f3d1c9f272c66f61eab8e7269a6)OnKingdomDestroyed()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnKingdomDestroyed | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *destroyedKingdom* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af1717c6abfcbe84e0ac4565e1c2c8bc8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af8911c6310ba88b76c2fc675ad16df4d)CanKingdomBeDiscontinued()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CanKingdomBeDiscontinued | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aeb013b5c5589e8980415990498ed4f3b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac2392a0f94078803e3200e4b47fe2db9)OnKingdomCreated()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnKingdomCreated | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *createdKingdom* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae1182810cffabe7c541cf67f0244f80b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0e8bcae9545784ca78665d72508a7095)OnVillageBecomeNormal()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnVillageBecomeNormal | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa24eb249f068c7dd709f5e2bdb48cbf7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab5905dd19c4a8a102c52789ef46cd7ce)OnVillageBeingRaided()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnVillageBeingRaided | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aec98069c7a4abdac6c55b1207b7f84dd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9a2834cec155e4e33432a149c89300ec)OnVillageLooted()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnVillageLooted | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acad0cd780e4c43833b7a95e9599faefb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a03fcddb7078f92395d003e9237745f9f)OnConversationEnded()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnConversationEnded | ( | IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *characters* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a390babfb91957aae89349c04a09990b8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a05318ba5de68e2042bd0816725320f97)OnAgentJoinedConversation()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnAgentJoinedConversation | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7c5b7c0f078500eaf2ae9e810116aaf0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a21bd013cf48aa386c32b6e61ac1e8882)OnMapEventEnded()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMapEventEnded | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a26ebfaf0450f26c8ef4ef737583f8e72).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac0ca07a21f0cfb10a5fc1147c3c3c3d4)OnMapEventStarted()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMapEventStarted | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af1c1ca7805835f59aa9f333aada40a0c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a27eb26e4a440eac3bf45cd36adf65eab)OnPrisonersChangeInSettlement()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPrisonersChangeInSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *prisonerRoster*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero*, | |  |  | bool | *takenFromDungeon* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adcbb12df96fe6a8aad73da3adacf3ff3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9a98b71628b2c36f6220b5df78719cf3)OnMissionStarted()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMissionStarted | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *mission* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6cab1213b307e0b741ac21a4c8ad31b1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4681a73d82e90462e2db183f8e2a970d)OnPlayerBoardGameOver()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerBoardGameOver | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *opposingHero*, | |  |  | [BoardGameHelper.BoardGameState](class_helpers_1_1_board_game_helper.html#ab045b68fb522a41152b0557241b92db2) | *state* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aab862a653eab2a23dcbeb16661730194).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a00ada9319af0a319c21aa11a11cf7157)OnRansomOfferedToPlayer()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnRansomOfferedToPlayer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *captiveHero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2a8d43ce96eeaea531a0d542a995e890).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4f2f5eae0944fe03bc1d667d3f168d3a)OnRansomOfferCancelled()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnRansomOfferCancelled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *captiveHero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a097a5eb7e91ea9a0ecae7fe66b38b156).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a635e6840cc52f97ba663fc048452e638)OnPeaceOfferedToPlayer()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPeaceOfferedToPlayer | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *opponentFaction*, | |  |  | int | *tributeAmount*, | |  |  | int | *tributeDurationInDays* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac8802474d31ad115e291c358bab01b4a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a130a91040bee7a538d07c88585f7f82a)OnTradeAgreementSigned()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnTradeAgreementSigned | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *other* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a598142d74e60f16dd21d0a5378f37cb8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9afbb66157aff37cb8ed0b0ba91e1987)OnPeaceOfferResolved()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPeaceOfferResolved | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *opponentFaction* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0de37776761cd464c8fdaaf446a494c4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6b845fef513f1089de460702fdc71c9e)OnMarriageOfferedToPlayer()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMarriageOfferedToPlayer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a721a30d9191eecd34940bbbc029772d9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a062de1b7669732006fde163187f7bb66)OnMarriageOfferCanceled()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMarriageOfferCanceled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3d90ef003543c413adb337f3a4be29fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9156772714bf003d140c862360479ebc)OnVassalOrMercenaryServiceOfferedToPlayer()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnVassalOrMercenaryServiceOfferedToPlayer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *offeredKingdom* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a407630b92abd2671203f4b6d60e9ec9d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af6f1962fafa9a98a61f357b974df6e1d)OnCommonAreaStateChanged()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCommonAreaStateChanged | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | [Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) | *oldState*, | |  |  | [Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) | *newState* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a64b860a87c28b7eb6af8b0816c50b817).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3d8014e55e9249ebb660bf13abb6a1e1)OnVassalOrMercenaryServiceOfferCanceled()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnVassalOrMercenaryServiceOfferCanceled | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *offeredKingdom* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a21f9d73d52efe1a4882847deda0a5489).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a548d0b24f62b703b0b2843b66d8277b8)BeforeMissionOpened()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.BeforeMissionOpened | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aea5f880348e4bafc1d978f67d3ac1f0c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9fdff15633d16735bdbc0c9e10cfe3bf)OnPartyRemoved()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyRemoved | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a179635aa914fb7bb8aaf12a12225762c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0f2c75aaf93eee0f53b5563afd3dec96)OnPartySizeChanged()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartySizeChanged | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3e0521786d62986195ca9761fd935196).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aabf24ac38b7d432ecc27785a61fefbc1)OnSettlementOwnerChanged()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSettlementOwnerChanged | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *openToClaim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *capturerHero*, | |  |  | ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac0baa866084a03780ffa210021a05f64).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab800ee3c3be11a6cc37fc20d4c858c11)OnGovernorChanged()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnGovernorChanged | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *fortification*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldGovernor*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newGovernor* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad0a73a2b35363cffcfc281ddb06b7349).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad84b08377315563256ecda0f06b006e1)OnSettlementLeft()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSettlementLeft | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a893bb6880175e5f7e7b9abe562e4e4ae).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b058daf7a15380a7e9221543b720252)Tick()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1a7d21c002a72891d40fc2a160179f49).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#addbb606605d2c20cef65b17a5ddaa90c)OnSessionStart()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSessionStart | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af6514672a01ba699cc915fbd282d2f95).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a951ea972f67d10b5de09232a4259a15f)OnAfterSessionStart()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnAfterSessionStart | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa3cb8b037efd033c9a8232bee7d60eda).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4f1ecc8ed6f0fdae3cd0e953f113a7bf)OnNewGameCreated()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnNewGameCreated | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a356b56d81b6ddc3abc0e62b821229808).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6a78e0c9a3f6da469818b8074901ece8)OnGameEarlyLoaded()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnGameEarlyLoaded | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5f01de1db2ee2680e7c813a69df821e9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2f3959ec85d3810ccbef838111fd2710)OnGameLoaded()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnGameLoaded | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4d442d24ad6a85982389a44c63a2eb14).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a859c00334f78f9fafcff48d5c6c27f26)OnGameLoadFinished()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnGameLoadFinished | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3ea634c601f4771590d6d3f9cabd7862).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aaa5151a9a086e4f632b5a7f284dd56f2)OnPartyJoinedArmy()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyJoinedArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a900ae35cc97fff74751105c0011d305f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abcbba7a66f3ca627c2d69816e0a53eb5)OnPartyRemovedFromArmy()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyRemovedFromArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2b6fed8a03b00b66ac14da2792c29191).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aac2877550d5ec45262d6e73dc6c9cb7b)OnPlayerArmyLeaderChangedBehavior()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerArmyLeaderChangedBehavior | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a761fc245fa9776d0992839882747fdbd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4745a9da06bdea51ec07429a999ef5c1)OnArmyOverlaySetDirty()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnArmyOverlaySetDirty | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a48d87ca9b4e0190973077cad8d0d6946).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afbef08d8b634851eb401aa1dd0b145ae)OnPlayerDesertedBattle()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerDesertedBattle | ( | int | *sacrificedMenCount* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad8db9a572572bf68ae4a7c36dc869344).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab4d76a6945672f9316be0927d2f30521)MissionTick()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.MissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac49962f703db44ac19cd193e4505201a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6490e396e2fca65af871f32ff199c479)OnChildConceived()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnChildConceived | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *mother* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9b57951e17afe64ae22769ca11616785).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abeff63dab03bea5d342bbc3e2a561ffa)OnGivenBirth()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnGivenBirth | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *mother*, | |  |  | List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | *aliveChildren*, | |  |  | int | *stillbornCount* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a552912c267589be8430cabef7b08b981).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7983388ac7efc4b6dda108f6a360527d)OnUnitRecruited()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnUnitRecruited | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | int | *amount* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab72ecd3343c3d04c0e1ede65be378dc6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7b71d8771f34a39d0d023e168e816e8b)OnPlayerBattleEnd()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerBattleEnd | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9da462a29263d571d88a25ff8cc6fc39).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4e0ee798d470b3eab979b06025bd829d)OnMissionEnded()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMissionEnded | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *mission* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af4c7984de81c44b47d2a9656ecf6f54c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6df5a545dfd322be529215b4f908db38)TickPartialHourlyAi()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.TickPartialHourlyAi | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7318f8837165f380a312160c0ad0b707).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9f7357b330be3fed497c4983b056decd)QuarterDailyPartyTick()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.QuarterDailyPartyTick | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad182750b43c6c39495c21838d4b33488).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a21052b4a653f71e29a2138f9bee0e1d5)AiHourlyTick()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.AiHourlyTick | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) | *partyThinkParams* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a11d99dce4f8a008cfa53165641c5655b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0411aa9c88131d89a4e9f53a845211d2)HourlyTick()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.HourlyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1c4ea3f46ce568e82cc17f2ed71449d9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af0fe4dc2344867f3f6b65855578ae010)QuarterHourlyTick()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.QuarterHourlyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa74fe2e776ae40603801b2b9f9b5afa4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#adbd2fdc691f8dcbbb092634f6f49c768)HourlyTickParty()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.HourlyTickParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8eec0bf986fd3326ad97a265bb96cf26).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae0ef4abec1bdf34389c0763a291c4a86)HourlyTickSettlement()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.HourlyTickSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1c4a127283bb458a6f213d4bf504a4d1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a60b7267cbd8bfa39f00704f59b80a893)HourlyTickClan()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.HourlyTickClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0f244bfb309f90d1cd1a53f8c3e8fc2d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aea2a985d99cd5b2362f822e43fbbb39e)DailyTick()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.DailyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6eedfe629de9e36844fb39cd0d928616).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6dd05507ae9e999e11f1ae02546884a9)DailyTickParty()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.DailyTickParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a314bdcb0d4cc67abaebe8c105b181c2b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac74fb6635bfd17667cb7e168dd57e62e)DailyTickTown()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.DailyTickTown | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a366aa186af37cc2a654931cc6942c1a6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abe4d387a96bb3413c6baa01f46aae202)DailyTickSettlement()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.DailyTickSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afadb083b69a3716a035aa6311cb3bcea).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8a61214d42e89804dca3fb9147b6199d)DailyTickHero()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.DailyTickHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a172bbe9254827d489a5c005b32f1ace5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a46e3959ac62d0df29b2f27a8d0267d2e)DailyTickClan()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.DailyTickClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a50deef6dafd5a6b652961a76b03b28f7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a14a84de507118ddcdf8e1da6343bd2d7)WeeklyTick()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.WeeklyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5e9351f1758fd0d98bd9627365bc706e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9aec43c9e88434723e526916d889eb2f)CollectAvailableTutorials()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CollectAvailableTutorials | ( | ref List< [CampaignTutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign_tutorial.html) > | *tutorials* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a21ff92c0a4d675ca6489ffde3e65f31f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afaad870aab2497fbc088b0a4aaf3be5f)OnTutorialCompleted()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnTutorialCompleted | ( | string | *tutorial* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a616361c9445050c5a2c6f2ff6891f6cf).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aea6a663ef8aea3d2cdfcf53f69ceee26)BeforeGameMenuOpened()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.BeforeGameMenuOpened | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3582e248084d5133e87cd1c999f6e6a9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5e67818e26dc05be6b06a9d3e6368523)AfterGameMenuInitialized()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.AfterGameMenuInitialized | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a405b9daff956f2a1a7c4d2e367311315).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afdc204663b150a7a82cb01c352d0f7da)OnBarterablesRequested()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBarterablesRequested | ( | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a375225dfed41289db077577caf986ba0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a90f3623cf7f6f4eef906ed8cf4c8da26)OnPartyVisibilityChanged()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyVisibilityChanged | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a41385b937b64a01c0adf9b3ac60f809b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa9443d525d03fef6f92dc580eef79dfc)OnCompanionRemoved()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCompanionRemoved | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *companion*, | |  |  | [RemoveCompanionAction.RemoveCompanionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_remove_companion_action.html#afebe445a9fd9044486e94c0db1b931ef) | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9d56353914130b307ef8862259573d14).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a963019088b53482125f824856026b9bd)TrackDetected()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.TrackDetected | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abea423068f95d08a933d05592fd1c75a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a833acbbc202f81aa45288aac0b5aa43b)TrackLost()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.TrackLost | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5491752d533283178cc29f9bb6d068c2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b44c98610918d78c0bd3804217c140c)LocationCharactersAreReadyToSpawn()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.LocationCharactersAreReadyToSpawn | ( | Dictionary< string, int > | *unusedUsablePointCount* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4144e9473f03cfb82de327978168a7b4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7918a471a0785842f08d4be6f3aa1ce7)LocationCharactersSimulated()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.LocationCharactersSimulated | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a79acccb94610f2e4937cbd925dc759a2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aedeb8e4dcfaef223daa7e3153338d2c5)OnBeforePlayerAgentSpawn()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBeforePlayerAgentSpawn | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *spawnFrame* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9958864ae44837589d7187f2afa06a90).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5f7bfcbaa25433717e49c06175e75f3f)OnPlayerAgentSpawned()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerAgentSpawned | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab8ba2dd4267664efab7faf52d64808e5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8d5608db958ea96c0ff8d7e0300e2eb9)OnPlayerUpgradedTroops()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerUpgradedTroops | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgradeFromTroop*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgradeToTroop*, | |  |  | int | *number* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab58f89386e7a027c6eceb6d20740b9cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abf2a235f22b11798f137d1bd7c7f59d5)OnHeroCombatHit()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroCombatHit | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *attackerTroop*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *attackedTroop*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *usedWeapon*, | |  |  | bool | *isFatal*, | |  |  | int | *xp* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a98b7f06624c7d920d82aef18bd6f9a64).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aee42ec6fac27bd4def6c835ba4984433)OnCharacterPortraitPopUpOpened()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCharacterPortraitPopUpOpened | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afdb992d08aca0b0a06e2711b1268c293).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa545bd48cbd7b54da14b0fb226dba612)OnCharacterPortraitPopUpClosed()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCharacterPortraitPopUpClosed | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aabf775870c5bb7dff811d5076b5883c7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4e53e4fa3c398a5926d3ab891af6b685)OnPlayerStartTalkFromMenu()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerStartTalkFromMenu | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1115abb47b46ddd62a512e67b58d7ea4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3c1536ede88489a93f310134298eb86b)OnGameMenuOptionSelected()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnGameMenuOptionSelected | ( | [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) | *gameMenu*, | |  |  | [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) | *gameMenuOption* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a694849371b5335c9b8e1f05b025fa5be).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afc70cf5e77451ff4231ffe27a9696fc4)OnPlayerStartRecruitment()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerStartRecruitment | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *recruitTroopCharacter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a14303cbfa6ff9454bbdabf6046e18652).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6f2279cbd5f2a2a3b3c791065fabf19b)OnBeforePlayerCharacterChanged()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBeforePlayerCharacterChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldPlayer*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newPlayer* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a64011b94834dfced52f276974f6d16b1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5cab6f8aa84e658faf46598b846c8837)OnPlayerCharacterChanged()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerCharacterChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldPlayer*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newPlayer*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *newPlayerParty*, | |  |  | bool | *isMainPartyChanged* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a80a199ed5541ed86fb6cd5c820a8928c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abd4d51e956e561ef152b0384f365455b)OnClanLeaderChanged()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnClanLeaderChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldLeader*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newLeader* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abcbcd369d0bc1189b867b0477520bafd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ace66dec7e920d1f2378e8a3db30644c1)OnSiegeEventStarted()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSiegeEventStarted | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f6bcb872fed496e606a9a1537bed3be).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a272f1fc8ab96dd18ed97d36946254b4c)OnPlayerSiegeStarted()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerSiegeStarted | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac056ce5c1c89bd4c99c37b126c6d9b4a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4d0c053a6062e7faf949ffab9ad81471)OnSiegeEventEnded()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSiegeEventEnded | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a04b227268da4e7079e1a66fcf80acc45).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad1929bcb5a03892b73de7f76f6b7f39d)OnSiegeAftermathApplied()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSiegeAftermathApplied | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | SiegeAftermathAction.SiegeAftermath | *aftermathType*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *previousSettlementOwner*, | |  |  | Dictionary< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), float > | *partyContributions* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a94d96e25e916273dac202b12353b91a0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acd912d196eb2c152c845103ed7caa544)OnSiegeBombardmentHit()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSiegeBombardmentHit | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *besiegerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *besiegedSettlement*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *weapon*, | |  |  | [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *target* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a666de6d9a062ea8ced4651f550b50dff).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa823e3be5dca46963329e2fd1ff22ce6)OnSiegeBombardmentWallHit()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSiegeBombardmentWallHit | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *besiegerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *besiegedSettlement*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *weapon*, | |  |  | bool | *isWallCracked* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6a86873ff9207ea3882694d3e8bb5bcb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a03a8a8949b18133f7de5369972cd7696)OnSiegeEngineDestroyed()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSiegeEngineDestroyed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *besiegerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *besiegedSettlement*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *destroyedEngine* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab18d10db3188ea0819948ff5d5ebce42).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4bba1264c58536c13b508ca404bcbf5f)OnTradeRumorIsTaken()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnTradeRumorIsTaken | ( | List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > | *newRumors*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *sourceSettlement* = null ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae38e70e8830d80182e27fd29f6469ddd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a92d92fe632b58f1b7b9f89be98f2c814)OnCheckForIssue()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCheckForIssue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a047960b1b435d59d54408009dd5000dd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b71ea9b2fff16bc00c3d749dfd7c6ca)OnIssueUpdated()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnIssueUpdated | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue*, | |  |  | [IssueBase.IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b) | *details*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *issueSolver* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae96c0f4c1c348d7a55ba3434ed5f474d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a076381bb90d0c999acb40b25040d5eb9)OnTroopsDeserted()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnTroopsDeserted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *desertedTroops* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acfda4979f29c66490f6e93d9cb80b513).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab4950efc3ed45279f2bb907242c277a2)OnTroopRecruited()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnTroopRecruited | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *recruiterHero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *recruitmentSettlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *recruitmentSource*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, | |  |  | int | *amount* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab649fa58127eb99c1b38175e73c0a38d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4404084960b181592de35373f3aa1340)OnTroopGivenToSettlement()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnTroopGivenToSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *giverHero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *recipientSettlement*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *roster* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5f30a5817691a5b20153fb0d3d514980).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa7854538621ac8b06faaedb472518cc4)OnItemSold()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnItemSold | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *receiverParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *payerParty*, | |  |  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement*, | |  |  | int | *number*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *currentSettlement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aac3d9c50869d924aca98205bb4243972).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a39495f637148b0797f701d8d1cafdb87)OnCaravanTransactionCompleted()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCaravanTransactionCompleted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *caravanParty*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | List< ValueTuple< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), int > > | *itemRosterElements* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a154a99467bcefbb586b19b65b1cdbb90).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1b09139010797e1d65d04cbfdd4b3398)OnPrisonerSold()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPrisonerSold | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *sellerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *buyerParty*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *prisoners* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0f9a29cdbe6e8f47af23132fcd73dc49).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afc97878261ab06e372226ff71212ffda)OnPartyDisbanded()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyDisbanded | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *disbandParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *relatedSettlement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae580d6d15c25d986d63f801b137fbead).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a29586fa84cebda55747921b596a7b2fa)OnPartyDisbandStarted()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyDisbandStarted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *disbandParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5843d230859c9560b27b7780fc5126bd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acbbc3536f26040ea1ae81e688086217f)OnPartyDisbandCanceled()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyDisbandCanceled | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *disbandParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaf395a07d55b70154e54b9b1d6306d14).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab808591785e1a563c38740156f7cdab5)OnBuildingLevelChanged()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBuildingLevelChanged | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) | *building*, | |  |  | int | *levelChange* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a872484253aa14e7bb8be553a81b50cce).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afba487b749c0abf30692716ae896d188)OnHideoutSpotted()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHideoutSpotted | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *hideoutParty* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2cd2abd5833057f8bf87612f959882b7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae0bcc7e4cf1c730f24eeabbe4f35e39f)OnHideoutDeactivated()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHideoutDeactivated | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *hideout* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a476b40c0e2eff03ccb62cd67198e7cd2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aff803c5d7f11d4858632ad3f8143944c)OnHeroSharedFoodWithAnother()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroSharedFoodWithAnother | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *supporterHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *supportedHero*, | |  |  | float | *influence* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad0562768c73b4c3bcb7f694365fbc158).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aaab148dfd82a57d968fee2731d1a31ec)OnItemsDiscardedByPlayer()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnItemsDiscardedByPlayer | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *roster* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8b8d0b7de26833d92f2e1e533e2935f5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9c21fe1a074e3a8f382d9460c9001b08)OnPlayerInventoryExchange()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerInventoryExchange | ( | List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > | *purchasedItems*, | |  |  | List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > | *soldItems*, | |  |  | bool | *isTrading* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a38a3c030c58c37d32509be7309108484).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afb339a525be1bde4c554ff2bed482263)OnPersuasionProgressCommitted()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPersuasionProgressCommitted | ( | Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > | *progress* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6c488089d6f3fec0967dae048ddf15c7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a78e5a2408e695fee00734612798906e9)OnQuestCompleted()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnQuestCompleted | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest*, | |  |  | [QuestBase.QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0722f718cc643befffb3cf46532f0634).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5cc70018223dc9bbdcda48958cadfcd3)OnQuestStarted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnQuestStarted | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a80121601a110e1d9254a0da5a85cdaf4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a33c20ee111dd5292350325f31ff7c82e)OnItemProduced()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnItemProduced | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | int | *count* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9169a1080e9bb2dadd9dc196d6b759e6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a61d7763ac7805f212e845f72a65b5ac5)OnItemConsumed()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnItemConsumed | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | int | *count* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a00a463efddac32f12cdb487ea3726c4f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae2a4bf82ece383d1cd8f4e255a5f3f4f)OnPartyConsumedFood()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyConsumedFood | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9ec42fd3a836317d6aabe6fa54cbd45c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a97b7235e67f3a00b092faee99037483d)OnNewIssueCreated()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnNewIssueCreated | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a797486987494c0ebdb1c732af849f3b6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7b598a79bca3629cd2eaed574454ed58)OnIssueOwnerChanged()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnIssueOwnerChanged | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8beb35652e74a4e2f93455849af59c0e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab739089858407aa99bc0dba3438bf7e2)OnBeforeMainCharacterDied()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBeforeMainCharacterDied | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa290b1325d6b07ac06a0611c7b0449ee).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0ae0cc0b989968d012bc77a0610ff180)OnGameOver()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnGameOver | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3f72e0aff76dcdc8cf0019607b406435).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a92a93211e65baeb4824e8ff12bc7f385)SiegeCompleted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.SiegeCompleted | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *siegeSettlement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | bool | *isWin*, | |  |  | [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) | *battleType* ) | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | siegeSettlement |  |
    | isWin |  |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a296e155991bcadbcd057db1306bdb53e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0b7019d99b625d0bbecdd33eb3568bff)AfterSiegeCompleted()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.AfterSiegeCompleted | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *siegeSettlement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | bool | *isWin*, | |  |  | BattleTypes | *battleType* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa3366fb9d461ec7a6de88bb42d561441).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a97ee2804147fb49b6bba6012d4649b0f)SiegeEngineBuilt()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.SiegeEngineBuilt | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6543dce7ae5422f511800117488e01f8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1d17aebd3e0449f13286e4cacb3546e4)RaidCompleted()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.RaidCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html) | *raidEvent* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6631550f84b65e909d1c177602a6e6e2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afeba6e9598f84547316035242929a13f)ForceSuppliesCompleted()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.ForceSuppliesCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html) | *forceSuppliesEvent* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a459da0fd4ab5b8a60b9c890f43a10ccf).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9f2f63852995cad840181a069ed922c4)ForceVolunteersCompleted()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.ForceVolunteersCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html) | *forceVolunteersEvent* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34850c45926553d8c8dc9e687bfd13fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abecd876d4296f4e1b06182051d5b2a23)OnHideoutBattleCompleted()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHideoutBattleCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html) | *hideoutEventComponent* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34507ce845f04b6117d04a0dbbbd438c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0a222eb29ee8a8d745a1af9d64d5529a)OnClanDestroyed()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnClanDestroyed | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *destroyedClan* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6fd8e156fdfaa49ae41bf1e0d2b1beda).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af778c766565f0015798493416bf2a3ca)OnNewItemCrafted()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnNewItemCrafted | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *overriddenItemModifier*, | |  |  | bool | *isCraftingOrderItem* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5980e578f147e20215ced59a04f0766f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2af2cf8a2bf8bbf4f5adf71b541b6b9a)OnWorkshopOwnerChanged()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnWorkshopOwnerChanged | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afcc35d1b1e67aaaaa91a55d551a11e2c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9f8551264ae776b51dfb5963a0166857)OnWorkshopInitialized()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnWorkshopInitialized | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9618f4263e5934975be5401c61736fe7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa545d792549ae463d12d372f518f3c24)OnWorkshopTypeChanged()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnWorkshopTypeChanged | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa16c9c5697a3ec6f58d0d2b1e96d7841).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a147a5cd6e0aa9b636a0dd5c0b93b4c97)OnMainPartyPrisonerRecruited()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMainPartyPrisonerRecruited | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *roster* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af7bb92bc1db0a74d85b8c363bd8edb2d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afa9f4ef080192766792115d774e66b04)OnPrisonerDonatedToSettlement()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPrisonerDonatedToSettlement | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *donatingParty*, | |  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *donatedPrisoners*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *donatedSettlement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad5622914ebc0442414760a747799d76f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4daf25e8a08e5dc3d4fc21dddfdb42c5)OnEquipmentSmeltedByHero()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnEquipmentSmeltedByHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *equipmentElement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a46f4e356ccd54b097f802cd91fc9df46).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aafdefb5bc8ef4b43107e7c118e17839f)OnPrisonerTaken()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPrisonerTaken | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *roster* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac44d5c1dc977f3c195612e48fc80999e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aeaf7692287a7cf63ab883b50242ce3f4)OnBeforeSave()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBeforeSave | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a75e93c7e63b080e226b80f2dd339c568).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4f67ad2a595842e4307c7713f3cf65f6)OnSaveStarted()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSaveStarted | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3800ff42e205d4cfb09aab0c7dd3c0c8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac8671e97871fd97c11437b24ce2c7eab)OnSaveOver()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnSaveOver | ( | bool | *isSuccessful*, | |  |  | string | *saveName* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2e7eeee5baaa97c7e5988c00ce06045c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acdd7c2446489a61d94a1acd709f46825)OnPrisonerReleased()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPrisonerReleased | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *roster* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afef8ca1ccf2d6d9240b019eb501454ea).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac3b4584cfa89b3ef602ee92da05bcceb)OnHeroChangedClan()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroChangedClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *oldClan* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acb3aef6fb1a771ef7d0519491462ccf9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1a315e86747b4905b62af4c3d017491a)OnHeroGetsBusy()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroGetsBusy | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [HeroGetsBusyReasons](namespace_tale_worlds_1_1_campaign_system.html#a74f96a6c3de3af13ac985228276ee611) | *heroGetsBusyReason* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f8b1fec51e016490693052fec3ee4ce).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae306cc55b9c27304e2631e2a72f03cd2)OnPlayerTradeProfit()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerTradeProfit | ( | int | *profit* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a572703ead6531bf2a5822ab01018a24c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2c30f4995fd1f019448b93034b190b8d)CraftingPartUnlocked()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CraftingPartUnlocked | ( | [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) | *craftingPiece* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aab97ff9ba3547cec53d5b9601e926110).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1da444193339c51c687f65f792246c64)OnClanEarnedGoldFromTribute()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnClanEarnedGoldFromTribute | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *receiverClan*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *payingFaction* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8dc8752dc68807900227f4a48bedfd6d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a40cd5d7d7cf74c2025f847ce81b5e92d)OnCollectLootItems()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCollectLootItems | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *winnerParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *gainedLoots* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaa48a85629d5eab820e833109536c1b3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad052fcee6c17979298ee5eeb08b712ea)OnHeroTeleportationRequested()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroTeleportationRequested | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *targetParty*, | |  |  | [TeleportHeroAction.TeleportationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90) | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab00fcec3aacef57c81c31a481511e086).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a15def105aa99e64276d5ecd3b83bd34d)OnClanInfluenceChanged()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnClanInfluenceChanged | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | float | *change* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad46b74e2a3930b813499c484338e6880).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9e5e2e15a213d76e250f4314eaee0e5a)OnPlayerPartyKnockedOrKilledTroop()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerPartyKnockedOrKilledTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *strikedTroop* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5e085b092f6b313fb08f3104fa5989e4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acd08fd36d848e36cbbae86b12e7ae7c7)OnPlayerEarnedGoldFromAsset()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerEarnedGoldFromAsset | ( | [GameComponents.DefaultClanFinanceModel.AssetIncomeType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50) | *incomeType*, | |  |  | int | *incomeAmount* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac9abaf7d14174ccda495abd40f0fd4d3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9aa9955161536d87de2aaafed6141b9f)OnPartyLeaderChangeOfferCanceled()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyLeaderChangeOfferCanceled | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a278eba1bc1a9b773e8ddf8f77ec7a004).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2bf55c46dfb35efc894298f5b1c4829d)OnPartyLeaderChanged()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyLeaderChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldLeader* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1a54daf70ee1d2f5a28f1572d63180a1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#addeb4e9b75fa2ae3801a4593134f107e)OnMainPartyStarving()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMainPartyStarving | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2a3dacfbcba36e34194be6ab18b190d2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad0a706641928b5e8791d8c2784f96ad9)OnPlayerJoinedTournament()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPlayerJoinedTournament | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *isParticipant* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adba59a048dccb310ae93e9e80adcd8b0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a60bd566f2131dfc18e0bfd684972429c)OnCraftingOrderCompleted()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCraftingOrderCompleted | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItem*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *completerHero* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa15c74a738056e3bd158de34e5cbad38).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a57dc93db42ff464dbd3b041d56b59768)OnItemsRefined()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnItemsRefined | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | Crafting.RefiningFormula | *refineFormula* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a052182b302597c0703512d8df6277f38).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a546e81985a1b03f3b5498726b61fb7ae)OnMapEventContinuityNeedsUpdate()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMapEventContinuityNeedsUpdate | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4525748c4272953b82962a499a2616e9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acd431249bf5d9b400b4c133b9be8e4f6)OnHeirSelectionRequested()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeirSelectionRequested | ( | Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > | *heirApparents* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add98c2403df7ebb7ea5a106e5a1c6bac).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9fb6ed574fff7472bf2f33fb949603b1)OnHeirSelectionOver()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeirSelectionOver | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *selectedHeir* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a093f73749d5a11dc6b783f76cda19891).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3ce8248851309a782a1ebade755e9051)OnCharacterCreationInitialized()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCharacterCreationInitialized | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a499f973fe9a231418750e8e36bae0416).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5a41695310f2fab3eaf292d1ed6e327a)OnShipDestroyed()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnShipDestroyed | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *owner*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [DestroyShipAction.ShipDestroyDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_destroy_ship_action.html#a52f9b7dcd67d7a49fc241de25137f7d1) | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a948c718e3662d8dc65a58b64d8738b44).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a70859458ed6ac7cc68927c6b5c05e455)OnPartyLeftArmy()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyLeftArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae9ffeade5f828b9a1fbd1f93ebf61428).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab31ae13444f0d6393628123731188a10)OnShipOwnerChanged()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnShipOwnerChanged | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *oldOwner*, | |  |  | [ChangeShipOwnerAction.ShipOwnerChangeDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f) | *changeDetail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a109dc611f24cb27bac0bbc8a498b0ac3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af89e7ba7713491182dfd738f8554b96d)OnShipRepaired()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnShipRepaired | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *repairPort* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7af6a0e0fffc671bffadc3141d82ce9a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a08005455615c52a5903978d5eee30ef9)OnFigureheadUnlocked()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnFigureheadUnlocked | ( | [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) | *figurehead* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a04de735972ec8a5f3100bbfa85f6a245).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0c9bad0bfc7aafeab89ba29d0b639cc3)OnPartyAddedToMapEvent()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnPartyAddedToMapEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af224cc53faa894e55efbdc61df7c1420).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4bd08f702d13ef00d9ae4161a38f1b69)OnIncidentResolved()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnIncidentResolved | ( | [Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) | *incident* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aeb1b212b7702dbb455fc139aebc86f5e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5fa5cf0d1b556a95699a076c7ef727c4)OnMobilePartyNavigationStateChanged()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMobilePartyNavigationStateChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a32a3229f31b225842e3719a8857e241c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a855355f753c1e56611696cd3d69fb4e8)OnMobilePartyJoinedToSiegeEvent()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMobilePartyJoinedToSiegeEvent | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acb9777179473e1e00f7a3f4eb3d80999).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4613ac289c2c9ad119e2768fe9e419a9)OnMobilePartyLeftSiegeEvent()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMobilePartyLeftSiegeEvent | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a56a8dc304af6f4c9a38d3debc9366ba6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8c4f535a4f65eeae738522c83f2084de)OnBlockadeActivated()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBlockadeActivated | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8e869f7664427be678ff273ec340f732).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab2bce57b5c07c78554a729a5578940a2)OnBlockadeDeactivated()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnBlockadeDeactivated | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7b3c5394f44442467ae00a7603aebc5e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0b67ac087f85fa21c314353522d1fe77)OnMapMarkerCreated()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMapMarkerCreated | ( | [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) | *mapMarker* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abf77449a7e77c1458bb7bb04b624099f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4d1023d60bad15ffe2a2c7b2ebeebf70)OnMapMarkerRemoved()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMapMarkerRemoved | ( | [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) | *mapMarker* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adc1a52dad5da10a6060d97348ab2b04b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a71152eeba9454b806890a25ad33f6727)OnMercenaryServiceStarted()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMercenaryServiceStarted | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan*, | |  |  | [StartMercenaryServiceAction.StartMercenaryServiceActionDetails](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_start_mercenary_service_action.html#a5861e61ec787655431332d6abb63721a) | *details* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a38369e757c569b93cacdac7ebbcf4e44).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7042a8449525fa8b7193ab07286d5776)OnMercenaryServiceEnded()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMercenaryServiceEnded | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan*, | |  |  | EndMercenaryServiceAction.EndMercenaryServiceActionDetails | *details* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a276e0fae65b514dc3315369517f5388c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5d298d2eac50c34dbd485486fdd82a9b)OnAllianceStarted()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnAllianceStarted | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a86b1385ce8466223b86bba96b23493d9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae014d1e48b109cf7b6daa4d2d9be5fca)OnAllianceEnded()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnAllianceEnded | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a776018fae9847480244d9ce0d6715e76).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa3315a732dad68a54c96023ec1e21911)OnCallToWarAgreementStarted()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCallToWarAgreementStarted | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa0bce07a59e9752cf0ac7e4bfaa66e38).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa382b2df13be63e4f2a81fafba2d4805)OnCallToWarAgreementEnded()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnCallToWarAgreementEnded | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3ed5af5ad91883f12190c4cd2366cbda).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6f399d722d86f9d1162e2da45e5db878)CanHeroLeadParty()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CanHeroLeadParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a86e4f4782d0f1b2be099ef4fe30b8716).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abb26f31b1a0230e4dd107af1591044be)CanHeroMarry()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CanHeroMarry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8527e4986c0e3cf7a581da7cf19187fa).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af6ca841284bc788936f342e45f148222)CanHeroEquipmentBeChanged()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CanHeroEquipmentBeChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a433faa50918c107ff0026aaac8470c27).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a93cd128b1a1b11505ce879cd240fe333)CanBeGovernorOrHavePartyRole()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CanBeGovernorOrHavePartyRole | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad71470980290f2d55166a618d637db9e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab82b5bc212d25f8d608742885062daba)CanHeroDie()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CanHeroDie | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *causeOfDeath*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0b1778170b8b1e9f08d84a8485dc673c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a247f7f30efe6d5dc4148d48e469b1204)CanHeroBecomePrisoner()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CanHeroBecomePrisoner | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ace775570f432474d242258663c80849e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a02baa7b1ebdab83422754913248bb611)CanPlayerMeetWithHeroAfterConversation()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CanPlayerMeetWithHeroAfterConversation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af03a06a9e937ab8ceefeb1b2584fdf22).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5eaafefa05ad0cc72705883be4639f22)CanMoveToSettlement()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CanMoveToSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4793a0025d67692ca65cab7d9c866317).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab0ca999f4b544e06e35592dec37e626b)CanHaveCampaignIssues()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.CanHaveCampaignIssues | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6f50c9d7928844d7dab61293b71b90db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad4dce969b184fa3c80adce1bba493ca2)IsSettlementBusy()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.IsSettlementBusy | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | object | *asker*, | |  |  | ref int | *priority* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a45dd08fc640c47170fc82ce3fd764dda).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a043b42b716d41e7f319567df181e8057)OnHeroUnregistered()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnHeroUnregistered | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0be0a6d8f2b46360e13a0a2c0405207c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3e0b3640e3447c952f65fd1829c2908b)OnShipCreated()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnShipCreated | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *createdSettlement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aafd518d9378b18cd54ae69ee53c05955).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3b515d37668464af1081ca997d9aeb03)OnConfigChanged()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnConfigChanged | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0534f5200e010106be8c7f7885edf1fc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad5aa09a30e5b9ecee991d911b63881e8)OnMobilePartyRaftStateChanged()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEventDispatcher.OnMobilePartyRaftStateChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8e7ae269f45c9b02e1d9008c3f5bbd1f).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3ac86076bbbc0849c63da284ce197aca)Instance
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CampaignEventDispatcher TaleWorlds.CampaignSystem.CampaignEventDispatcher.Instance | | staticget |

