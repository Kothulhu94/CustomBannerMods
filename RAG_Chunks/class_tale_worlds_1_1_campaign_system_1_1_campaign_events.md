--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html ---

TaleWorlds.CampaignSystem.CampaignEvents Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RemoveListeners](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8346eef0ee8f1ac0a90679669d628555) (object obj) |
| override void | [OnPlayerBodyPropertiesChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3c1ea7f70bdf56bd222b5d5e5525e746) () |
| override void | [OnBarterablesRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2981d4d336f58aab209b8f380d91e9e9) ([BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args) |
| override void | [OnHeroLevelledUp](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac85b9a556ee7b3c7ca4ea9b1da835350) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool shouldNotify=true) |
| override void | [OnHomeHideoutChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac840fa48a1462879f109353002b6da7f) ([BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html) banditPartyComponent, [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) oldHomeHideout) |
| override void | [OnHeroGainedSkill](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a96173d89ea13e0f41b9a05d5411cd25b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int change=1, bool shouldNotify=true) |
| override void | [OnCharacterCreationIsOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5c1a7ca330dc6b8bfb8e4a0d6066d9d7) () |
| override void | [OnHeroCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2f4a4efc3d64e82e3c534be8f9a85764) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isBornNaturally=false) |
| override void | [OnHeroOccupationChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a38b8e68d3e01c00caad1679cd848a20f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) oldOccupation) |
| override void | [OnHeroWounded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7a303e1e131c48e7d9cf617f108e5861) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) woundedHero) |
| override void | [OnBarterAccepted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab100922c27f9953f0bb2d67e91b2c970) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offererHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > barters) |
| override void | [OnBarterCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a493fd41084040dba18f9185b436b2cfb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offererHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > barters) |
| override void | [OnHeroRelationChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a763d7ac8c45c2c45043b1a5cb83e108d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) effectiveHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) effectiveHeroGainedRelationWith, int relationChange, bool showNotification, [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) detail, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) originalHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) originalGainedRelationWith) |
| override void | [OnQuestLogAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0963a7a5fc481248968d699ce1fa93c7) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest, bool hideInformation) |
| override void | [OnIssueLogAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a51c12739f27a94d824425da0bd5d822b) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue, bool hideInformation) |
| override void | [OnClanTierChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aeefe58bbd5980ef22be5334a33f4a370) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool shouldNotify=true) |
| override void | [OnClanChangedKingdom](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a079e40a3ebbd830f6ca2e024bba877ae) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) oldKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom, [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) detail, bool showNotification=true) |
| override void | [OnClanDefected](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a56052c54559ccbfc1c6c2acf6ea5cf2a) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) oldKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom) |
| override void | [OnClanCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a206c73905348185766f66bfaf995de7d) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool isCompanion) |
| override void | [OnHeroJoinedParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3cbc07bcd3b3a4bb983868117d3bce86) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnHeroOrPartyTradedGold](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac58e9a8811801a4625421e08539c3594) (ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > giver, ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > recipient, ValueTuple< int, string > goldAmount, bool showNotification) |
| override void | [OnHeroOrPartyGaveItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aff4b6babc3f06decf02cea60ae5c6b36) (ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > giver, ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > receiver, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, bool showNotification) |
| override void | [OnBanditPartyRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac69bd759ed45c3d0abb53bffc2b04d23) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) banditParty) |
| override void | [OnKingdomDecisionAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a798a4cde36bfcb83d31798f46351bbd7) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, bool isPlayerInvolved) |
| override void | [OnKingdomDecisionCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa05d050e0f8b8bacdf3847c22c1810fd) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, bool isPlayerInvolved) |
| override void | [OnKingdomDecisionConcluded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0c9ddf213f601b47c7ff98d601b8b4bc) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome, bool isPlayerInvolved) |
| override void | [OnPartyAttachedAnotherParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af3c660cacc08ec66f427b06cbf56d7f6) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnNearbyPartyAddedToPlayerMapEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a59586a0b9838a010532169e0500e14fb) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnArmyCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a30f79e5f3ac7d501f309e98f33f83e72) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army) |
| override void | [OnArmyDispersed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a603fa574650d370e8cc734cdaf4ec791) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, [Army.ArmyDispersionReason](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798) reason, bool isPlayersArmy) |
| override void | [OnArmyGathered](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6509f1ac57a054b170cd3e1b93a763e9) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) gatheringPoint) |
| override void | [OnPerkOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4eea87dcb1db32d609eb7df4a06d3dba) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| override void | [OnPerkReset](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aabbce1eb5f89ff3727426bdf1a473ef8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| override void | [OnPlayerTraitChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaf60413fe379de18485402869b375142) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int previousLevel) |
| override void | [OnVillageStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad8b2af435839f3c377b3a2e81bfc9a7c) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village, [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) oldState, [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) newState, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) raiderParty) |
| override void | [OnSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5812c9e3206bbf0838e54b8829b3d99a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnAfterSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2375fdadcd9f0679cc0e674ff641c64e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnBeforeSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4ec6825f18a2bd08cd70c7c7877ed8ee) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnMercenaryTroopChangedInTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a574f7ec0c28d8095637b4ea63861f195) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) oldTroopType, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) newTroopType) |
| override void | [OnMercenaryNumberChangedInTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a086e74029d42499eb89d9c597b4c6aad) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, int oldNumber, int newNumber) |
| override void | [OnAlleyOccupiedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8250042741b6911b35984b7a04b48046) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troops) |
| override void | [OnAlleyOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a49df3ed48687b5faba1ab94db7dfdb3d) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner) |
| override void | [OnAlleyClearedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa52c39d1771552118c004125be2a23d5) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| override void | [OnRomanticStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf617617b85c60d0e0a823a1f0776584) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2, [Romance.RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) romanceLevel) |
| override void | [OnBeforeHeroesMarried](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9fb9d4bbe901bd38c6163b08c58baacd) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2, bool showNotification=true) |
| override void | [OnPlayerEliminatedFromTournament](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adcf56bcc29bf7e1858b5a991ad5e1556) (int round, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [OnPlayerStartedTournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3995a4ee9f88fbff4d9fc9f0fb95a608) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [OnTournamentStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8092f0b2b6d6eba05cc278b9b0b074ac) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [OnWarDeclared](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8ea1eea17b591f6dc693164903f51682) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2, [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) declareWarDetail) |
| override void | [OnTournamentFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af17ef3249af0167b3239d941c6fc9d78) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) winner, MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > participants, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) prize) |
| override void | [OnTournamentCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab5df63590d819bbc5b4f1ffb05bdb70a) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [OnStartBattle](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab75d9ccd2f631cdfba6799bd77c9f2bb) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty, object subject, bool showNotification) |
| override void | [OnRebellionFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae80aa4ba6eca322fce4d563a4e87d86b) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) oldOwnerClan) |
| override void | [TownRebelliousStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a46473129645c0420e6ad853ee93ee2dc) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool rebelliousState) |
| override void | [OnRebelliousClanDisbandedAtSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aef6072df4e4251343c7636d1b2b8d0a8) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override void | [OnItemsLooted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae4e5170b70100fede9ffbf9edcff097) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) items) |
| override void | [OnMobilePartyDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a67c0870e45c7a54013fc75cdd1249396) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) destroyerParty) |
| override void | [OnMobilePartyCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a073cb8430ac23e18ad7e48b86d4da941) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override void | [OnMapInteractableCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3f713372ceae90a98284cd43ec574766) ([IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) interactable) |
| override void | [OnMapInteractableDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad14b798aa0847cc633df408ced8c4548) ([IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) interactable) |
| override void | [OnMobilePartyQuestStatusChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a93184b1fad08f2a69499e45fd7bef810) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isUsedByQuest) |
| override void | [OnHeroKilled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0586e8d199052b9001a658b2a2a57182) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool showNotification=true) |
| override void | [OnBeforeHeroKilled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#add1e7d161736b7f6c669dfa3ed07c461) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool showNotification=true) |
| override void | [OnChildEducationCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf8f6ce436135739bada622b89745b71) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int age) |
| override void | [OnHeroComesOfAge](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae83a9348e9c5632cdfb4e6ad4e93620a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnHeroGrowsOutOfInfancy](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad7307bb4a07349a0474b6529ad96452a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnHeroReachesTeenAge](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a37a00c938245fe47986ecbadb93116ea) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnCharacterDefeated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0abdf23b2adec440d4a5b079fae74c00) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) loser) |
| override void | [OnRulingClanChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1d66130086f3a94b0e5a18aa990c011a) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) newRulingClan) |
| override void | [OnHeroPrisonerTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aeed9185d0aff8a0d0dc57e1a191daa31) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) capturer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisoner) |
| override void | [OnHeroPrisonerReleased](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad9ae5888ec3958f7c21ea4f9279fdb19) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisoner, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) capturerFaction, [EndCaptivityDetail](namespace_tale_worlds_1_1_campaign_system_1_1_actions.html#a6a6556b279f5fa0db2c5ae9a933508fe) detail, bool showNotification=true) |
| override void | [OnCharacterBecameFugitive](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab61f3610a278094999878f4d486d9220) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool showNotification) |
| override void | [OnPlayerMetHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab7b4cd1589ec41a5a90ee8ac24841b6e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnPlayerLearnsAboutHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a27b4ca095a76fc9ed83564ca9acd9e34) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnRenownGained](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a96606a1b8cd2f528744e6e0c19741b9b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int gainedRenown, bool doNotNotify) |
| override void | [OnCrimeRatingChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3f1c9cc9ef9d0cb91da2632de53722a4) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) kingdom, float deltaCrimeAmount) |
| override void | [OnNewCompanionAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aea25cf62b7866d409eced1b3fabb0c83) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newCompanion) |
| override void | [OnAfterMissionStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a29e7aed1396da14d0e3bd394c716dabc) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) iMission) |
| override void | [OnGameMenuOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae01a64fd87a3881fa60ea97260858c90) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| override void | [AfterGameMenuInitialized](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a80e7dc0e4c62ae6704259453e8b8ec26) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| override void | [BeforeGameMenuOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5e2ca78337f6d3539c0f1ea8a3fe3a63) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| override void | [OnMakePeace](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac06b94b658e2afe684ced36d5c160313) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) side1Faction, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) side2Faction, [MakePeaceAction.MakePeaceDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff) detail) |
| override void | [OnKingdomDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5905a51cd7ba8b0565d6929a0dc4c034) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) destroyedKingdom) |
| override void | [CanKingdomBeDiscontinued](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a84952dc2de1a1a005971d9f83cbec207) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, ref bool result) |
| override void | [OnKingdomCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae5d1aedffc331b78a10e60059f7ae69d) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) createdKingdom) |
| override void | [OnVillageBecomeNormal](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7b7d36593a58eb081b60f833f87f011c) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| override void | [OnVillageBeingRaided](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8829a43e20fa385e73cd0718fe1baaae) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| override void | [OnVillageLooted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#affdbdf5672d2b48c22d64ed5d5510c5c) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| override void | [OnCompanionRemoved](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9e1a55a0a980fd9e138b44f352765dd4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) companion, [RemoveCompanionAction.RemoveCompanionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_remove_companion_action.html#afebe445a9fd9044486e94c0db1b931ef) detail) |
| override void | [OnAgentJoinedConversation](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acfbac12ed4c933c1c27fac368bdc00a5) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| override void | [OnConversationEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac416c7c7ec196fd2b984565de2fa6e78) (IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > characters) |
| override void | [OnMapEventEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d764f40b523943c39bdb65375c2c333) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| override void | [OnMapEventStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a12fbd1fda187e7a85c9052df1b367082) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |
| override void | [OnPrisonersChangeInSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4314706b7c0b9df5b2f9cccbe8aa5a7b) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) prisonerRoster, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero, bool takenFromDungeon) |
| override void | [OnPlayerBoardGameOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1f7c391a2ccdd3e63c2d404590982e96) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) opposingHero, [BoardGameHelper.BoardGameState](class_helpers_1_1_board_game_helper.html#ab045b68fb522a41152b0557241b92db2) state) |
| override void | [OnRansomOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2d4f06a2f35a3592e140c5ecfb5ce6d6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) captiveHero) |
| override void | [OnRansomOfferCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aab20e270eb96c796f00c37e850f3f772) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) captiveHero) |
| override void | [OnPeaceOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a517fd64f21706375a45e0b4388ef6d92) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) opponentFaction, int tributeAmount, int tributeDurationInDays) |
| override void | [OnTradeAgreementSigned](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3f1c8113796cfa2b05b96eb8c57243de) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) other) |
| override void | [OnPeaceOfferResolved](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af6997b5594f2e1cdd70ddc0bc0128cc0) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) opponentFaction) |
| override void | [OnMarriageOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9416a8942712af0f8a5a0b2fc2def22f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden) |
| override void | [OnMarriageOfferCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a63aea9cf76876742082b4f285663cd23) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden) |
| override void | [OnVassalOrMercenaryServiceOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a56568444e5ebe650314327c95666cf1b) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) offeredKingdom) |
| override void | [OnVassalOrMercenaryServiceOfferCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5678e3ba11d77e28f63f91ad1e33e28f) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) offeredKingdom) |
| override void | [OnMercenaryServiceStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8d0ff302086846dfb8d38c418835707c) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan, [StartMercenaryServiceAction.StartMercenaryServiceActionDetails](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_start_mercenary_service_action.html#a5861e61ec787655431332d6abb63721a) details) |
| override void | [OnMercenaryServiceEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a63c05aaf01ba940da08b86af0e84b1a6) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan, EndMercenaryServiceAction.EndMercenaryServiceActionDetails details) |
| override void | [OnMissionStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab658a499ef66e6ce0e208c94afc29857) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) mission) |
| override void | [BeforeMissionOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa8fc9aecad33a4500bfc7fee2c0fe97c) () |
| override void | [OnPartyRemoved](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a366a7fd4a4759db08a443cdecd4361dd) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override void | [OnPartySizeChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6d024c9d62f97ce846d166bda11361a9) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override void | [OnSettlementOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a42326f8401f7cb41e7500c30b774f980) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool openToClaim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) capturerHero, ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail detail) |
| override void | [OnGovernorChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8ae50eabf1ee7f3a95f2a9c934ad9f06) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) fortification, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldGovernor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newGovernor) |
| override void | [OnSettlementLeft](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a23d17e5033a55769d56dc9c835c58c1a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override void | [WeeklyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7c29dbd1e6a65888ac64d2eb2b011816) () |
| override void | [DailyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3e06ad4c97c8c69d360c6a40e870a4b9) () |
| override void | [DailyTickParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7290e87cf0c7faf8ec6a0cec197a3371) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [DailyTickTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a94a5498e6e72138c909ed6a671700e80) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [DailyTickSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4abfc80ccb94823085307639a4cb56ef) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override void | [DailyTickHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7e0d4234db4e6b1f26a2d24ed3de654b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [DailyTickClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a563dbd72cd8648cd0f9e3eaf247cf9bb) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override void | [CollectAvailableTutorials](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac578eda7cdbbf6d2931ac7467ce2af4f) (ref List< [CampaignTutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign_tutorial.html) > tutorials) |
| override void | [OnTutorialCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af31962e7a9be267f0411f636c7a976bb) (string tutorial) |
| override void | [OnBuildingLevelChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a452fdc29faee509003739fb3eb35416d) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) building, int levelChange) |
| override void | [HourlyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aad723d766000f4e6d0682b21ddf558cb) () |
| override void | [QuarterHourlyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4c992591ed185f80d6956a1265777f46) () |
| override void | [HourlyTickParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2cf540a8f0ef526f7e57858e62c4dea2) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [HourlyTickSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8fa49412559859bc7dbe8712555e0266) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override void | [HourlyTickClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adda2b33b5f748245946287ef5f0b473e) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override void | [Tick](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab1446a4e44ff8fe93ab7c54fd047b7cd) (float dt) |
| override void | [OnSessionStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7976e45d7475b95dd21aa89d0e1e50ed) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnAfterSessionStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a90e9619b1fabc284d833a4f55e32b695) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnNewGameCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac376b6294e8cc979693e99e252f38642) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnGameEarlyLoaded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acc4e80ad6cde74e063398c89846897e3) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnGameLoaded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adecbe92c3b13b4a5604225a5ec208c5b) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnGameLoadFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1cd243613aa602cf19f07f6b2975ed80) () |
| override void | [AiHourlyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ade3a332a43f4dcda2914e6fed8b0e592) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) partyThinkParams) |
| override void | [TickPartialHourlyAi](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae99ab550043cca1ca3fc8453dc6a26b8) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override void | [OnPartyJoinedArmy](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abb913bb44a8da6a7098cb169a94b5dd0) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnPartyRemovedFromArmy](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4a56776bef64dc01145f43f0063c3d69) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnPlayerArmyLeaderChangedBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aab9879a75a179badaeb5f3284b07c395) () |
| override void | [OnMissionEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5fc927af05ae7412962d6818ecff79c7) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) mission) |
| override void | [QuarterDailyPartyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab98ec41074e42da81ee9b09f003aeac9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnPlayerBattleEnd](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a08f718b07c7a1fdd737e4a2653477d11) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| override void | [OnUnitRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5bf2844e9edeccb524d975f198248db0) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, int amount) |
| override void | [OnChildConceived](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac157502e07ccc9cb8cdc9f5151b83ffc) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) mother) |
| override void | [OnGivenBirth](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae9f2d1954e01d6d0955025b1bba2487) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) mother, List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > aliveChildren, int stillbornCount) |
| override void | [MissionTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab7503ef6a1cf487269340ca882929fe5) (float dt) |
| override void | [OnArmyOverlaySetDirty](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3cb6b0f6446b83418f9e2aa64c29f92a) () |
| override void | [OnPlayerDesertedBattle](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afba953fa6ba9ffe4ce4c579c8dd01a43) (int sacrificedMenCount) |
| override void | [OnPartyVisibilityChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a669c06128c66b12f9c8ec4499e3506fd) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override void | [TrackDetected](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a55712afcdfa91a01d1696e637d8cf42c) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| override void | [TrackLost](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf86ef22f2cb211d8bb0d3a7daf29dd7) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| override void | [LocationCharactersAreReadyToSpawn](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8184b7310de2764ad405fe8fe51e72b2) (Dictionary< string, int > unusedUsablePointCount) |
| override void | [OnBeforePlayerAgentSpawn](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac89cdb1b6dd5b40718ac702dbc549aba) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) spawnFrame) |
| override void | [OnPlayerAgentSpawned](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aea30d2899ca249abbf1b17cfb159f24d) () |
| override void | [LocationCharactersSimulated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a73f74401ffa0b0dc8f118d0b13375fae) () |
| override void | [OnPlayerUpgradedTroops](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3075599224bb4b78b7716db45a5f580c) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgradeFromTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgradeToTroop, int number) |
| override void | [OnHeroCombatHit](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5991b65f5382060d2f1df4b463efc70f) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackerTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackedTroop, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) usedWeapon, bool isFatal, int xp) |
| override void | [OnCharacterPortraitPopUpOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aed3010eaf7cbd14884058de55d9a19ce) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| override void | [OnCharacterPortraitPopUpClosed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9d19b34ca706bc37143b34f07b58b614) () |
| override void | [OnPlayerStartTalkFromMenu](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a980b851ed81c28dcbc66294275f41d79) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnGameMenuOptionSelected](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a740099b28f0a10fb6e99485ceaed58ed) ([GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) gameMenu, [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) gameMenuOption) |
| override void | [OnPlayerStartRecruitment](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae2eea29b669d7044b783379c82083a9) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) recruitTroopCharacter) |
| override void | [OnBeforePlayerCharacterChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9d56bad917fb3c175ac0caceb1a30b4c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldPlayer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newPlayer) |
| override void | [OnPlayerCharacterChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a771df6167dfdba0b359b413f6eb56704) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldPlayer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newPlayer, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) newMainParty, bool isMainPartyChanged) |
| override void | [OnClanLeaderChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a35fab67f070c9d67534dfd8886f333ed) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldLeader, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |
| override void | [OnSiegeEventStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3b09c1a1dcbce3556fc480f19397d57e) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| override void | [OnPlayerSiegeStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7b4519cfe927e26c5b8cc3fb6394650e) () |
| override void | [OnSiegeEventEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8600568a132addc1aea60863c4a7b818) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| override void | [OnSiegeAftermathApplied](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aff754b01912ed5af7251d863166311c2) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, SiegeAftermathAction.SiegeAftermath aftermathType, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) previousSettlementOwner, Dictionary< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), float > partyContributions) |
| override void | [OnSiegeBombardmentHit](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a70f899b167bdd6abd751cc4ec474b9d8) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) besiegerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) besiegedSettlement, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) weapon, [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) target) |
| override void | [OnSiegeBombardmentWallHit](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a21bb973fad9fa70cc171f161f487a7cf) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) besiegerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) besiegedSettlement, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) weapon, bool isWallCracked) |
| override void | [OnSiegeEngineDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abe788fb9a05f48347ce374811cd18140) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) besiegerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) besiegedSettlement, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) destroyedEngine) |
| override void | [OnTradeRumorIsTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aff39be1c69fcc01ae82c1977c97be715) (List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > newRumors, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) sourceSettlement=null) |
| override void | [OnCheckForIssue](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d8cbbe23ae0d7f976b4b321d8d85041) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnIssueUpdated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa44a138f7db89c7d904ef4959d9d38d9) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue, [IssueBase.IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b) details, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) issueSolver=null) |
| override void | [OnTroopsDeserted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac08af8453b61667d41daed2da2dc1423) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) desertedTroops) |
| override void | [OnTroopRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a885237729c71891b4d890a95e5d8df9c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) recruiterHero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) recruitmentSettlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) recruitmentSource, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int amount) |
| override void | [OnTroopGivenToSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acc7311fbc1afa9f86313818ee0e407ee) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) giverHero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) recipientSettlement, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) roster) |
| override void | [OnItemSold](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af3f8ff1f75d0c27fdc9daee01cf0ff05) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) receiverParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) payerParty, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, int number, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) currentSettlement) |
| override void | [OnCaravanTransactionCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a64dadd17a96e6f7d020c0a231ff1ab46) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) caravanParty, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, List< ValueTuple< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), int > > itemRosterElements) |
| override void | [OnPrisonerSold](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a307479f9a6b4e59b8605c7c701b4c053) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) sellerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) buyerParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) prisoners) |
| override void | [OnPartyDisbandStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a435f6000810da2d250a72add787ea4e9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) disbandParty) |
| override void | [OnPartyDisbanded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab8ebc6ef8478faf1a98707ebf2e25f35) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) disbandParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) relatedSettlement) |
| override void | [OnPartyDisbandCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3977bcfdc68a5e5c0a90621bbce0c1ef) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) disbandParty) |
| override void | [OnHideoutSpotted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a107d54d1af82cefe302890f102becce8) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) hideoutParty) |
| override void | [OnHideoutDeactivated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad45c246ac81b2700b130b527e7e4fbff) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) hideout) |
| override void | [OnHeroSharedFoodWithAnother](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac23827b7d0840d3b62a05719f697c650) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) supporterHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) supportedHero, float influence) |
| override void | [OnPlayerInventoryExchange](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5bbe4343eb8104ed525b6f0685736a8e) (List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > purchasedItems, List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > soldItems, bool isTrading) |
| override void | [OnItemsDiscardedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9c4b7274b83dec958c5edcc0bbce40cf) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) discardedItems) |
| override void | [OnPersuasionProgressCommitted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aba49afafe5df9abc79f9a6d7e0133402) (Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > progress) |
| override void | [OnQuestCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a590163c2f429e98618eb171012cf2fef) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest, [QuestBase.QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) detail) |
| override void | [OnQuestStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a95a52b5bf670b4813849f148044a4b2a) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest) |
| override void | [OnItemProduced](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af970d6e677f9701e31154b0d25674b58) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, int count) |
| override void | [OnItemConsumed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6bbccc22ee524c01f5794a5d2c4a4221) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, int count) |
| override void | [OnPartyConsumedFood](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3fab1e550f8d0a9c0cedb988a006739e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override void | [OnBeforeMainCharacterDied](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aef0c1a585b3255257bdb0ad3c9201f83) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool showNotification=true) |
| override void | [OnNewIssueCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abc0ff17b85929f8d4abd1266440c612f) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| override void | [OnIssueOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2e2a9e8bcdc8ce02f8a1e2a27b55b261) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner) |
| override void | [OnGameOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2d9dcc25bb52fe26844a5b37d2dae455) () |
| override void | [SiegeCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a48e629d0cc07881c079897e4c7dd6a40) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) siegeSettlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, bool isWin, BattleTypes battleType) |
| override void | [AfterSiegeCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab68f5a364a913a868eae27dd9d1d7a1b) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) siegeSettlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, bool isWin, BattleTypes battleType) |
| override void | [SiegeEngineBuilt](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7ee58a8e2e02a0f58f1178a6ef811ce8) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType) |
| override void | [RaidCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a08926b9adb1e89de8902d1988ef7863e) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html) raidEvent) |
| override void | [ForceVolunteersCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1c2a775f5f0f4275d2b134c1370ea6c6) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html) forceVolunteersEvent) |
| override void | [ForceSuppliesCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aadc9886963dd925a2035d3e697b144e3) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html) forceSuppliesEvent) |
| override void | [OnHideoutBattleCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad2a823d8ba95841343603d955ee86164) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html) hideoutEventComponent) |
| override void | [OnClanDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a47bd07c99a4646f9a1c54f1294e30b8c) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) destroyedClan) |
| override void | [OnNewItemCrafted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae38df8a3f3b010c8057558b55fd30c28) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) overriddenItemModifier, bool isCraftingOrderItem) |
| override void | [CraftingPartUnlocked](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a367a81bff4b70539bab2ca4732eb829f) ([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) craftingPiece) |
| override void | [OnWorkshopInitialized](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a20b71a38397105f87e43f3097e523863) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| override void | [OnWorkshopOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afc07d766c9aeba8c29c7538529accdb1) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner) |
| override void | [OnWorkshopTypeChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a754d36b51ec66c6e7186bd57733b4c0f) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| override void | [OnBeforeSave](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6baca90336dae590cc1eda727acc7ed4) () |
| override void | [OnSaveStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5b716570f1d56f4771ce15f0485c0a6a) () |
| override void | [OnSaveOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3c6e4e27a8a51ea5c0acb4d477afde4f) (bool isSuccessful, string saveName) |
| override void | [OnPrisonerTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afe2e2e61e4b0bb44292758a1de74ac35) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) roster) |
| override void | [OnPrisonerReleased](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aba719cb40f5c268051fb2589f01a619a) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) roster) |
| override void | [OnMainPartyPrisonerRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae880ee9d300bf88029e5bcee2d4ede7b) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) roster) |
| override void | [OnPrisonerDonatedToSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaa7455ce9f24cb66cd84478dd9866a08) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) donatingParty, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) donatedPrisoners, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) donatedSettlement) |
| override void | [OnEquipmentSmeltedByHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d7eed04b14753e71ce77cdf5f4de78f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) smeltedEquipmentElement) |
| override void | [OnPlayerTradeProfit](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1a37c65ce2a218dd73acb04ad249a7f3) (int profit) |
| override void | [OnHeroChangedClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a74e8eb9bb1b8a35d74beaba53f0567ce) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) oldClan) |
| override void | [OnHeroGetsBusy](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a666c6764f22ac2518d67c2f702f5685d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [HeroGetsBusyReasons](namespace_tale_worlds_1_1_campaign_system.html#a74f96a6c3de3af13ac985228276ee611) heroGetsBusyReason) |
| override void | [OnCollectLootItems](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af413d80eaa6bb562de87e9c5d2b9e889) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) winnerParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) gainedLoots) |
| override void | [OnLootDistributedToParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abbf01e33a0ee2e404837ffa6e9d7bc61) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) winnerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) lootedItems) |
| override void | [OnHeroTeleportationRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af00814a5685f3517528100648d549428) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetParty, [TeleportHeroAction.TeleportationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90) detail) |
| override void | [OnPartyLeaderChangeOfferCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae1b0f4b6029170ca040c45c088565323) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override void | [OnPartyLeaderChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af7f0c2dca43d3ab6f4e987712fb019b5) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldLeader) |
| override void | [OnClanInfluenceChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac1ef125cf47fb19c4ca6cd4b34dc1727) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, float change) |
| override void | [OnPlayerPartyKnockedOrKilledTroop](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6bfac288f3b477ade7d4b6a951dc7225) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) strikedTroop) |
| override void | [OnPlayerEarnedGoldFromAsset](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a714a13cfe1733fb5e5c1bccba85c4aec) ([GameComponents.DefaultClanFinanceModel.AssetIncomeType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50) incomeType, int incomeAmount) |
| override void | [OnClanEarnedGoldFromTribute](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2e244df9b61b9fce3a98d3311e7ff02f) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) receiverClan, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) payingFaction) |
| override void | [OnMainPartyStarving](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa2d3c6bbb233e913bf84f1f50864d97e) () |
| override void | [OnPlayerJoinedTournament](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa1ea406df227702480c5060e0c765134) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool isParticipant) |
| override void | [OnHeroUnregistered](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8f918ef9a6674adbe46ee21f23548c87) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnConfigChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aac6ba2a5762cda5ea247ef2f9d4e2006) () |
| override void | [OnCraftingOrderCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afcced854fd093fdc6c3c588678b01626) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) completerHero) |
| override void | [OnItemsRefined](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0c78c0402dd94259fe82c3c665fd5b63) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, RefiningFormula refineFormula) |
| override void | [OnHeirSelectionRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a52c927982c9ed2a86cd506eaca0408c0) (Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > heirApparents) |
| override void | [OnHeirSelectionOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a52be4b7dfdaa648a7449a7e44e92b4e2) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) selectedHero) |
| override void | [OnMobilePartyRaftStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9be9362f53d1f154f2dacd0512bb735a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnCharacterCreationInitialized](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a82a3649d2950a413904ca588159217ef) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| override void | [OnShipDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a288bd16bf1f01d0b663c6ae9ab896f89) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) owner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [DestroyShipAction.ShipDestroyDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_destroy_ship_action.html#a52f9b7dcd67d7a49fc241de25137f7d1) detail) |
| override void | [OnShipOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6d65a54de0b4220df0286d86bf9a6065) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) oldOwner, [ChangeShipOwnerAction.ShipOwnerChangeDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f) changeDetail) |
| override void | [OnShipRepaired](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2674612a72b7ce207753f103b6021e7a) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) repairPort) |
| override void | [OnShipCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac39af14e59490ef9c76fc5e35319be03) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) createdSettlement) |
| override void | [OnFigureheadUnlocked](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a303dde4b23a13858a2028ab9a737cd24) ([Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) figurehead) |
| override void | [OnPartyLeftArmy](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a83262ca5921e46d62b2f206628c37263) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army) |
| override void | [OnPartyAddedToMapEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0be68db04a54a9d784d642ab527ec013) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase) |
| override void | [OnIncidentResolved](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af6fc2561f174c11931e07734e33f42d4) ([Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) incident) |
| override void | [OnMobilePartyNavigationStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a201c380db46ce38ddcbe118fd61d1e73) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnMobilePartyJoinedToSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2c36af71d321b981547fe36a88aba290) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnMobilePartyLeftSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a490bbdd1ff5e23125c1f44b1ba3e18f9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [OnBlockadeActivated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a196ac6529370b56fd8897ec8a4d313e1) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| override void | [OnBlockadeDeactivated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4af8ecc5487a11bb09af354fcecba08f) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| override void | [OnMapMarkerCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab8df8071674190bb91d81b67f632cb4d) ([MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) mapMarker) |
| override void | [OnMapMarkerRemoved](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a92823548d071b26ed58fcf554badeaf5) ([MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) mapMarker) |
| override void | [OnAllianceStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab19d2e524c42aae3d196cbac276dabfa) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| override void | [OnAllianceEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7d30fd14412cd6fcd6c1c49db1452a47) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| override void | [OnCallToWarAgreementStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac4b263e6f660ca58d20e97e12ae7236d) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| override void | [OnCallToWarAgreementEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7c4bf247b0f77d2d9c58b90a769c61c8) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| override void | [CanHeroLeadParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae199ffd877366b7eecf95be012108ef3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroMarry](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab5b640f02a7f00a59d396111d4a407ab) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroEquipmentBeChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab73b22257fac8821ea196fbe1fb43600) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanBeGovernorOrHavePartyRole](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a760a2c75593934dfe47204d529e392aa) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroDie](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a307419eaf4b9f064ab01038a3122de6a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) causeOfDeath, ref bool result) |
| override void | [CanPlayerMeetWithHeroAfterConversation](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a74af2b301b82cae5cbc62d3590233fba) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroBecomePrisoner](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf22960a231b4f8b92d2cbb7139c2548) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanMoveToSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af3bf4ff02accf19f9618a4f1e5526e78) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHaveCampaignIssues](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac799d3b8e891ed7075889dcc4cada033) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [IsSettlementBusy](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9feb4249dd8f2350df3edb3ca8907889) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, object asker, ref int priority) |
| override void | [OnMapEventContinuityNeedsUpdate](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9062b09aae280c4e15d36f1d347ad1b9) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html) | |
| virtual void | [RemoveListeners](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a30c010ec60d81a1f6cbf2317efd3ddeb) (Object o) |
| virtual void | [OnCommonAreaStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a64b860a87c28b7eb6af8b0816c50b817) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) oldState, [Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) newState) |
| virtual void | [SiegeCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a296e155991bcadbcd057db1306bdb53e) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) siegeSettlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, bool isWin, [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) battleType) |
|  | SiegeCompleted event triggers when a siege ends with a normal outcome. If attackers are defeated "partially", it won't be fired, because the siege event doesn't actually end, and battle state is set to none. |
| virtual void | [OnNewItemCrafted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a501a665e70d0c652e349c3b321f34430) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject) |
| virtual void | [OnItemsRefined](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a052182b302597c0703512d8df6277f38) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, Crafting.RefiningFormula refineFormula) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [OnNewGameCreatedPartialFollowUpEventMaxIndex](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a799bec52b3b8a70fe45d8098dce779c7) = 100 |

|  |  |
| --- | --- |
| Properties | |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [OnPlayerBodyPropertiesChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1d3acae7ba50d04b62b16cc5e5c2fb51) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) > | [BarterablesRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6c3d1e61117cec8ce175c1a093ae3eae) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [HeroLevelledUp](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aab1ced1a07c377b3e7df9b6f03bc9c00) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html), [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) > | [OnHomeHideoutChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aeefa8364e9329504c8ff3d03709c4f21) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int, bool > | [HeroGainedSkill](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a82c289a38cbcd6fcc1366955eb7fed8b) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [OnCharacterCreationIsOverEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaaa51e810d5b8f96fa6f2c434b670826) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [HeroCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a678b52a42fe572a5803a84943fc41e59) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) > | [HeroOccupationChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4b990ccb436e11b7b6d4a3eee2221274) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [HeroWounded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2ef2175fd613ee3770443b96d7603412) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > > | [OnBarterAcceptedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aed47ec17978148470fd436745d752993) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > > | [OnBarterCanceledEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9e99293bc036050a094f4053a1a5b722) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int, bool, [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [HeroRelationChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac6318731f8b67f6eb85f670c0217f2da) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html), bool > | [QuestLogAddedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab108586a1888b133b1e383d97c9ef1f0) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html), bool > | [IssueLogAddedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0868734dc943fbd25d9043be36d02ef2) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), bool > | [ClanTierIncrease](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa40bca1bebda744234180d88c9a4137a) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035), bool > | [OnClanChangedKingdomEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aead2be8111cfb660c5639ec5c5ef2243) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [OnClanDefectedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae920f0857c0ea9020053af900b7cf76d) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), bool > | [OnClanCreatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af2f71cff2d96f9ad98078241bd8822ea) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnHeroJoinedPartyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8e0b121a43bc68394c120f0933da3ea8) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) >, ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) >, ValueTuple< int, string >, bool > | [HeroOrPartyTradedGold](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afcaf61013c51189c711090b3ab1b30c0) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) >, ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) >, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), bool > | [HeroOrPartyGaveItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a866f9de3f1f2462fc68ef99d2e4e1b85) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [BanditPartyRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3c9e61b0ef6bfd2681d3bb3033a7aa7f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html), bool > | [KingdomDecisionAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a40a35a5fcccb065abd11e5fc342a9c08) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html), bool > | [KingdomDecisionCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acbd7ec95d0a226ff9ea99e4d74c25302) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html), [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html), bool > | [KingdomDecisionConcluded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac6b707b5dd63d9388312f9b0b07dd195) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [PartyAttachedAnotherParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a71ee7bb10d203b2619c40ce577f4c54d) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [NearbyPartyAddedToPlayerMapEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9a9daf7f707085eaf98b9dccb0570929) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) > | [ArmyCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3aaeae7bff65b2760a06c1e9d47d658f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html), [Army.ArmyDispersionReason](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798), bool > | [ArmyDispersed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab381886a89acede04b05c400c5fc8282) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html), [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) > | [ArmyGathered](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a29a30424257272e5bdae32f207b4e582) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) > | [PerkOpenedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab9c2905f0c2d2461c38ac630067fe758) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) > | [PerkResetEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a428f607677a879d534de4f78ac14c49c) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int > | [PlayerTraitChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf8f0ab185f5c336e73316df6c18678b) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html), [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1), [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [VillageStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adfd0f835ff55919ec66d982fd888e5af) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [SettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6c9bf3112e3a13ee8e7529871a226a7a) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [AfterSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0ed1e0179433ebf368b75db672dd3469) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [BeforeSettlementEnteredEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a03065460685381bfd697b7b3bcf1a273) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [MercenaryTroopChangedInTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a48f2dec52e90c17d32ae30a21664e6c3) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), int, int > | [MercenaryNumberChangedInTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abae8c95530f8993e83cc79d13b63f4ba) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [AlleyOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aacb3887b742d3934b9186c08be4d70a2) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html), [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) > | [AlleyOccupiedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa2ec6be7a63ae71f356f40ba8e0022d3) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) > | [AlleyClearedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a552ad72e88037811c8c28126fcf35c99) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Romance.RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) > | [RomanticStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8488b3598f4424bb1ae9044e39c6f05b) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [BeforeHeroesMarried](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a485df837bd35118b8c025aa9b1ab881f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< int, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | [PlayerEliminatedFromTournament](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac0a90e800d603588b56a7d25892d2569) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | [PlayerStartedTournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1dd0814dc94faed5f85eb5604b21dc19) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | [TournamentStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae9778c30dc84bbcd7460abfeeaf04f0f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) > | [WarDeclared](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af1a1e84b975afb05ccf5ab706ae5b1b6) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) >, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [TournamentFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a15b1573ec151e5a88327f2f14ae0bdf9) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | [TournamentCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a060efef1a9e610332df313c47db319fe) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), object, bool > | [BattleStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a64bc65119d6f36437c47a97180508e86) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [RebellionFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1f0a6cc44af5815dffd7fec82e07e294) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), bool > | [TownRebelliosStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8db2ee48f999e1a299b948031ad70d4f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [RebelliousClanDisbandedAtSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9ae0727cd360e5593b023279f00eefbd) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) > | [ItemsLooted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aef1ae2b9a233391f4e4d1dee517f9333) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [MobilePartyDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a54389bc1179244aafd2fdbdece515c57) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [MobilePartyCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2d521b51c4901f91519f3aeadae0dac7) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) > | [MapInteractableCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa22fd0e4fa31b57d4f637513f8859db2) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) > | [MapInteractableDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a495558b8f0e66a3fc5fe53a112f1f961) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), bool > | [MobilePartyQuestStatusChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2a69ee5c825be4d811c2b257a817fed5) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1), bool > | [HeroKilledEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d3c7583d88bdc779907e67c3d078822) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1), bool > | [BeforeHeroKilledEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad2baa67112011edd56d72c018437d257) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > | [ChildEducationCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a92e964cfaa972f070733a49d512e65e4) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [HeroComesOfAgeEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#add930e60c75ede3e6b0d46bccb65c35d) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [HeroGrowsOutOfInfancyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3bbb37569787d4cb6a94dc303b03f480) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [HeroReachesTeenAgeEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa9c71c447f3dd50fc5bc99283e4ed0c6) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [CharacterDefeated](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7a89dc091a0520b6e5de83ca6fdff937) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [RulingClanChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac6dd36b0951ac32ed67dd33e86bb5530) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [HeroPrisonerTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae94f9b6c465680752f9fdd9bc23dbead) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [EndCaptivityDetail](namespace_tale_worlds_1_1_campaign_system_1_1_actions.html#a6a6556b279f5fa0db2c5ae9a933508fe), bool > | [HeroPrisonerReleased](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a44779a8cf4d998690fcfba95caf623a8) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [CharacterBecameFugitiveEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3c41aaf1df00c2143a290c19fe75d07f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnPlayerMetHeroEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abae9fe50a24d3f1fb5ebdfa46f9d9d76) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnPlayerLearnsAboutHeroEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afb06edfb7ed8cbde3cf2786f1c495e90) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int, bool > | [RenownGained](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae9834f097b65ba9e5bfba571405aec6) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), float > | [CrimeRatingChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a93227f30fb31005ad307698f02450beb) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [NewCompanionAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5cad4b4318758ec9450d6b1c5bf0cffe) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) > | [AfterMissionStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad7e7cb48c97a2fa2613382a2bac9aca5) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) > | [GameMenuOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab885cd4b59102dfe3c8cf20f7f0dfce4) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) > | [AfterGameMenuInitializedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acb0a3dbc1a81598b4f6ebf83d5f8cd12) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) > | [BeforeGameMenuOpenedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aad32afcbaf408c3d3499db2711406b69) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [MakePeaceAction.MakePeaceDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff) > | [MakePeace](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a816083d0af781d9d641076375b94fce7) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [KingdomDestroyedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a73905ae7ece44f55e3483dde9a8f4b15) `[get]` |
| static ReferenceIMBEvent< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), bool > | [CanKingdomBeDiscontinuedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abd9026d3f0326c1668ad43ef148d3434) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [KingdomCreatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab909d2a74ae9d5b59656dd4863b28487) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) > | [VillageBecomeNormal](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acaf5b3f058c6ce4d4e4acc1b6442b5f4) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) > | [VillageBeingRaided](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1234e034d5812666c795757f381f800e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) > | [VillageLooted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abeeda638cc5a1066a61dd02d911a1593) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [RemoveCompanionAction.RemoveCompanionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_remove_companion_action.html#afebe445a9fd9044486e94c0db1b931ef) > | [CompanionRemoved](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa68c8f427c476978f589febc66cf5fa7) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) > | [OnAgentJoinedConversationEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab6188eadb0a76df9a23882190ae33eb8) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > > | [ConversationEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a13c97ad056c9ee5163038308a80662dd) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) > | [MapEventEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3bcca05fb29cfa6edd153d076a1df349) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [MapEventStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1491c1570929bf8e7131e7349ef952da) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [PrisonersChangeInSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a53093d0fb9908b44d90935ab01626706) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [BoardGameHelper.BoardGameState](class_helpers_1_1_board_game_helper.html#ab045b68fb522a41152b0557241b92db2) > | [OnPlayerBoardGameOverEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4e06aef0a63378c78f39e7d2b1d7c08b) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnRansomOfferedToPlayerEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab83c349fc55f1b91e8e2cbc301a1158a) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnRansomOfferCancelledEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afd05e6441c197eb3de1188d1417a9349) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), int, int > | [OnPeaceOfferedToPlayerEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8cb7bb3a458f057de0dcb65bef7df35f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [OnTradeAgreementSignedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adc42be1efe3610c921c430aadbbed305) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | [OnPeaceOfferResolvedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6ccd8c6205264a320bc6f22ac13d02da) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnMarriageOfferedToPlayerEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a48caab761fda1471b37c73679a171ca9) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnMarriageOfferCanceledEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a55bef7773df4996f99fa805ea98496e4) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [OnVassalOrMercenaryServiceOfferedToPlayerEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a83f433927cb905f85a11dfc4d4de4fbd) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [OnVassalOrMercenaryServiceOfferCanceledEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9f6599c29f5f9326ebab57331b011fb2) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), [StartMercenaryServiceAction.StartMercenaryServiceActionDetails](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_start_mercenary_service_action.html#a5861e61ec787655431332d6abb63721a) > | [OnMercenaryServiceStartedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab68857d7022e8667155ab313e2119735) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), EndMercenaryServiceAction.EndMercenaryServiceActionDetails > | [OnMercenaryServiceEndedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a824c1d3f960bf7194646fe68f163d107) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) > | [OnMissionStartedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5654d6a5d11c00c9579b110fd0fa3860) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [BeforeMissionOpenedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a21356a3516c2b96f3fef334bd097fe5c) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [OnPartyRemovedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a57b6011136068e9f94c4347ac85ccd3f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [OnPartySizeChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abfaea6ad7af28ed82ad0611161e4622b) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail > | [OnSettlementOwnerChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad0d22f83e3fca4724c519554fdcb33ba) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnGovernorChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2728b284cb144c59c380a2c4259a218a) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [OnSettlementLeftEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a87609d48cf8393d47f9f7a9718c38a49) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [WeeklyTickEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad92ba75ccc453955d866191d0b80bd15) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [DailyTickEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a066faf3d0b292fca2e7a0ab91a34f125) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [DailyTickPartyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a61d8c50e12c34c81549dcda6337cda50) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) > | [DailyTickTownEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a07041b4e18de0e0e95cc6d8b4c2fa80a) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [DailyTickSettlementEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5c4539a696383f54e6188b231a974e8e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [DailyTickHeroEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a52a5a55e39fccc096eddfed384d06b5b) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [DailyTickClanEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a50e81d38dc860d12fe144cfd0b37ada1) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< List< [CampaignTutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign_tutorial.html) > > | [CollectAvailableTutorialsEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5a01801a80a76493a9ab21737e05aeb4) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< string > | [OnTutorialCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab05f157f2e15907601d9997add503c73) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html), int > | [OnBuildingLevelChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a500b6301048d5a4d2f9442529751308b) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [HourlyTickEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2a19b3ca69ed2fd20e485b1b864a4a53) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [QuarterHourlyTickEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9c9646e6cedbd25d1170fc81fd7f58a8) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [HourlyTickPartyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8fd96077bf0e9737ab7ea2fc1579a74f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [HourlyTickSettlementEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6a0560482f519a235083fe554967a817) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [HourlyTickClanEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a359c8d390a29996234c4a38a46058de8) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< float > | [TickEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab2974617aac83f71805192f8227ef14e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) > | [OnSessionLaunchedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5ee11ba5d377f63277221fd1a0e1c030) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) > | [OnAfterSessionLaunchedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a629159e395397cf761a2ac8e330aa1f0) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) > | [OnNewGameCreatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5c23c0363387d0587d28adce3be40248) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html), int > | [OnNewGameCreatedPartialFollowUpEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab7fd1042b69bab2a30b9e9f504de7079) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) > | [OnNewGameCreatedPartialFollowUpEndEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9f3298b0f5b30d037bf7823a46c4ac1c) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) > | [OnGameEarlyLoadedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a97d860be04c5d325e8d18a308983599f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) > | [OnGameLoadedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a03892d3dc4740993e0241392f4af16c2) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [OnGameLoadFinishedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aca967a298cd5acc2f86a3a526588cd12) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) > | [AiHourlyTickEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae9e658b3c0a235b5492dae4714c1e4ea) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [TickPartialHourlyAiEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a58e2517b783134252055d814699dc611) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnPartyJoinedArmyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a70e7828fcda35eb50745b0cc6b059003) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [PartyRemovedFromArmyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa89220dbb6480b1cd4aecea55ad2f82e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [OnPlayerArmyLeaderChangedBehaviorEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab4a563cb88b4a584a5533f25e9383e69) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) > | [OnMissionEndedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab8faeb0ef57b59482041119013fec86c) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnQuarterDailyPartyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9048c300efecad97dcb2e4a4d6326189) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) > | [OnPlayerBattleEndEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0ff4dd920dd09ad4db14f456dac2449e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), int > | [OnUnitRecruitedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4d406aa6a19e39f73a649dbc23ddcc05) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnChildConceivedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae911b46330d8703e353ead91548e11c3) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) >, int > | [OnGivenBirthEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a341713630b40d7a29a540bf6d61518c2) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< float > | [MissionTickEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3450cd6dd2838ad53621f1f95e5d3e54) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [ArmyOverlaySetDirtyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abd1dc3751d3beb0df47a854f8b88307e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< int > | [PlayerDesertedBattleEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad39accc22262f503a417754e23073e0c) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [PartyVisibilityChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0cea7baaa82c5578b9253eec3c1a20ee) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) > | [TrackDetectedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a63b5cb4af264251c2efab469b3c09c33) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) > | [TrackLostEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a31464bac5819dab4d9fc0153f6f0b367) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< Dictionary< string, int > > | [LocationCharactersAreReadyToSpawnEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a839bfe8ac2f31027b87a48e0fc51f9e4) `[get]` |
| static ReferenceIMBEvent< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | [BeforePlayerAgentSpawnEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7e2a1d1e69cf932d5e8ba082bbcd7541) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [PlayerAgentSpawned](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af54f32656f86c6abdc3abbfbfca81b0f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [LocationCharactersSimulatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad078d25f679c8015ea96611c477af8ab) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), int > | [PlayerUpgradedTroopsEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a797d821cadbb97099612fed725c1515e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html), bool, int > | [OnHeroCombatHitEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af87433e986da270a81c1e88dbf67c659) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [CharacterPortraitPopUpOpenedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab768a04d3190377df2a4c944dcab4389) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [CharacterPortraitPopUpClosedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa9063ebaebcba0f8b4546ea72bf616f8) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [PlayerStartTalkFromMenu](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a856ad2625223fb8f21569b60abae531b) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html), [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) > | [GameMenuOptionSelectedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3fb1b347cc97782b1b557ff4e8d57528) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [PlayerStartRecruitmentEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acd65cf6a26c823d8d8fef2d4533cb8c6) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnBeforePlayerCharacterChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a097e2592bc829e4d0d479d13afc7e263) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), bool > | [OnPlayerCharacterChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a497575a8fdd7764b36fff8ed35f94657) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnClanLeaderChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ade76694211cb6f779eec06cb963ff970) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) > | [OnSiegeEventStartedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abd87d6f3c431e56a3b636baa86166fe3) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [OnPlayerSiegeStartedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a50da30bd86409f0796dd71c13c7f0e65) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) > | [OnSiegeEventEndedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2ea483de37fdecc7eec05c77c7f64207) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), SiegeAftermathAction.SiegeAftermath, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), Dictionary< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), float > > | [OnSiegeAftermathAppliedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afb94ca0b51ef8de99f9629938b515235) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html), [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) > | [OnSiegeBombardmentHitEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acb769424f15f8410e1f15d922ef91eba) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html), bool > | [OnSiegeBombardmentWallHitEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a119f56b7e3f02540351a5259ad55cfc5) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [OnSiegeEngineDestroyedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a234ef9f756de1681155c00f80420b321) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) >, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [OnTradeRumorIsTakenEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1555beba967349b48cf56e1f47da6dd2) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnCheckForIssueEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a01a6b22c2c7472898a08fb78bcab3a21) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html), [IssueBase.IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnIssueUpdatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a80467ac21b21088cacd4a8bdc106f891) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) > | [OnTroopsDesertedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7322fe1666b2b3816eaf118cca5321a0) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), int > | [OnTroopRecruitedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af13bb39b5da4ee47a6372e32057ad18f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) > | [OnTroopGivenToSettlementEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac42516364965b571c7afb3d56e89b45f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [OnItemSoldEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a25801cee0676736fc87b21f06e80a4ab) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), List< ValueTuple< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), int > > > | [OnCaravanTransactionCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6254b7d43c35b02577672f714b9d6086) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) > | [OnPrisonerSoldEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a895be247cd0895818b624887f8d8224e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnPartyDisbandStartedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a207a3e5846c3f30fee3dce62c1600bad) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [OnPartyDisbandedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a186ef8cd3395f0a44e620a78f5c705db) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnPartyDisbandCanceledEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae680916f05e0afc35ff6f8aa9f359728) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [OnHideoutSpottedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac05060383b368f06e08a8cfc6d0ed9ae) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [OnHideoutDeactivatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa9a9f9f2e2fd395164aff62ad360d943) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), float > | [OnHeroSharedFoodWithAnotherHeroEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2f88fe33c351220926946cfac3573ba1) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > >, List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > >, bool > | [PlayerInventoryExchangeEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aac978338ca29008cc568954abe8b6e40) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) > | [OnItemsDiscardedByPlayerEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a825390397cc74bb4301b0ed18194ec8c) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > > | [PersuasionProgressCommittedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a79eb2671ba7fe478034d1c8b29e4edd0) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html), [QuestBase.QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) > | [OnQuestCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a09a33735fd11f1f8f54a97e28f759010) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) > | [OnQuestStartedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abab4f68227bf312bc85a37504586212a) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), int > | [OnItemProducedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a69f4e296934352fe960af79984dc1937) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), int > | [OnItemConsumedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a282254bd2529838a06fc38407f40b633) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnPartyConsumedFoodEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad0f51ba7872aab1b6a3f435de1ec16c0) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1), bool > | [OnBeforeMainCharacterDiedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a094bc0a9c56683d9757cac0b3a2c41c7) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) > | [OnNewIssueCreatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a287db6fe6299e56f0688d164b824e6cb) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnIssueOwnerChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a39f6b898d19f9b59db5cbed4fa94d903) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [OnGameOverEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a071ac25ad20ccfced8863416f98c7799) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), bool, BattleTypes > | [SiegeCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa7ea9a3c8053af0371c81c822058c5c3) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), bool, BattleTypes > | [AfterSiegeCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a49599fe0346fc04ec2300d49f922642e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html), [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [SiegeEngineBuiltEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ade51289135a8ca5f91258d494428641a) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html) > | [RaidCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a92a991dde48352ed233b8f92dc3c6f84) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html) > | [ForceVolunteersCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3dbbabaf237cbdddea98e892be0ba928) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html) > | [ForceSuppliesCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a31c01242471a9273285242c3759880cb) `[get]` |
| static [MbEvent](class_tale_worlds_1_1_campaign_system_1_1_mb_event.html)< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html) > | [OnHideoutBattleCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a185655f612325873cb9eef7cf2083e9c) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [OnClanDestroyedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7c1fb0527dc20ce943a0acb34dfff6fb) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html), bool > | [OnNewItemCraftedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a03c699a01be31c653f2bdefc378fcbc7) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) > | [CraftingPartUnlockedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa550eddc1f332789dfa795d0e3e9e7a4) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) > | [WorkshopInitializedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6331cae3f95db8da3ed38eb78b3c00c8) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [WorkshopOwnerChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad9a81685ebaea7ce36a2f1b451dc8c7f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) > | [WorkshopTypeChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab62b40f5f9af044e4db02c0a687905ab) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [OnBeforeSaveEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad6c8036e5e7cae687f324e71e52af0d9) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [OnSaveStartedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a333958b453f308d13d0d2e7585f63d0b) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< bool, string > | [OnSaveOverEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae157d5c4b7656368a26f086a12c56b07) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) > | [OnPrisonerTakenEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5110df9c7a1128714a6bea1d7d67e02a) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) > | [OnPrisonerReleasedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a55f4f63635306715ca115c7fb735c037) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) > | [OnMainPartyPrisonerRecruitedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abb38ee0b53ba04a625d5e6fad5b2a3c8) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [OnPrisonerDonatedToSettlementEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2b8315824f27d0d67f00043529cf857f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) > | [OnEquipmentSmeltedByHeroEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aed634ba9aa360544c1be6ec697fab14d) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< int > | [OnPlayerTradeProfitEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac2d140031b82d819987b6f892d5868a7) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) > | [OnHeroChangedClanEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a057facab3c46ab9387c661d01f918918) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [HeroGetsBusyReasons](namespace_tale_worlds_1_1_campaign_system.html#a74f96a6c3de3af13ac985228276ee611) > | [OnHeroGetsBusyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aebc4adc290910501823c6ff791f7a422) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) > | [OnCollectLootsItemsEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7eafc4dbc1f08f8c738c360b09cbb031) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) > | [OnLootDistributedToPartyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0aca18fad12145da4ecc1c20b56a9a16) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [TeleportHeroAction.TeleportationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90) > | [OnHeroTeleportationRequestedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a367293e0c0db810d0fa94e3747957eff) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnPartyLeaderChangeOfferCanceledEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4cdca1a168aca8735bd6bb0730f2a57d) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnPartyLeaderChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a60a9fa24fb29fb638455b2369dc16ca3) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), float > | [OnClanInfluenceChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5f54524fd19bcaebd06990efbba7994e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [OnPlayerPartyKnockedOrKilledTroopEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a25e3c005297b576634ec957f5777d474) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [GameComponents.DefaultClanFinanceModel.AssetIncomeType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50), int > | [OnPlayerEarnedGoldFromAssetEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afae0875e0e0a99529e4a8a2c56333e28) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | [OnClanEarnedGoldFromTributeEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af1724f0c74e943fc6200f57f47a2eba1) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [OnMainPartyStarvingEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abc5da03d813b463a36b171b33e8e9e75) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), bool > | [OnPlayerJoinedTournamentEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad0970852e5926e408593b757584b295e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnHeroUnregisteredEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1375e1e0914507665e06f8d5180ace14) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) | [OnConfigChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9a738099c91a8f90548633aa4f8a3de8) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html), [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnCraftingOrderCompletedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5de0256ab71a7ff710bd614e77f5b8cf) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), RefiningFormula > | [OnItemsRefinedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1d879b26d589d66e80d7ca3f1ead12b6) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > > | [OnHeirSelectionRequestedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afa077daf071c418eab12230d20d4bac4) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [OnHeirSelectionOverEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad7f74dc7a8271a506fd189905dd81946) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) > | [OnCharacterCreationInitializedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa35b2507b89abb114fc1359ef1dc324d) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnMobilePartyRaftStateChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af254eb6374015082095863dda0ac2333) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [DestroyShipAction.ShipDestroyDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_destroy_ship_action.html#a52f9b7dcd67d7a49fc241de25137f7d1) > | [OnShipDestroyedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adb32a2c07a24e97f81f2ea1b7d8f092b) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [ChangeShipOwnerAction.ShipOwnerChangeDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f) > | [OnShipOwnerChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a814be86e81d4618a25d065db79b23aac) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [OnShipRepairedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8f5186c4e76714152747c6adbead88fe) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [OnShipCreatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8b785eb97cb85165c4850f32ed365e54) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) > | [OnFigureheadUnlockedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae78a412c4b30c96b86472e67fdb9178a) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) > | [OnPartyLeftArmyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad2665539b2f01573edb6da4f2d0b86a4) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [OnPartyAddedToMapEventEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4f214e71db4dee98b70d092de6c1f2ec) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) > | [OnIncidentResolvedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad19e6337460316aa0bcdd286b201c4a3) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnMobilePartyNavigationStateChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a710728006df5b2a3be80ed54995a019e) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnMobilePartyJoinedToSiegeEventEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaa63005a136a6895c161c419a0ec3f72) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [OnMobilePartyLeftSiegeEventEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af34c3f93bed3d19ad97ec6b78e2a0214) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) > | [OnBlockadeActivatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4313d61f135bdd3180796ca03f855f6f) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) > | [OnBlockadeDeactivatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1ec96878082b4097b9877d9424ff6780) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) > | [OnMapMarkerCreatedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a59c94835300f26a8b4f84d0a8f629819) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) > | [OnMapMarkerRemovedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abba96681abfade7eb86ddaa672374fc4) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [OnAllianceStartedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf77aaadd15f411c1b926744586bffc9) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [OnAllianceEndedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a28c617382a9befd3cdf44f5d76ad5692) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [OnCallToWarAgreementStartedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa713b74e92b3cef121a8a82061d187a9) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) > | [OnCallToWarAgreementEndedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac73358481ec88b5fcee934b37bfd83e1) `[get]` |
| static ReferenceIMBEvent< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [CanHeroLeadPartyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac924ee60d3ad21559733b7dc46ba7c2d) `[get]` |
| static ReferenceIMBEvent< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [CanHeroMarryEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaa585af947147ea4a8215398cb4d752b) `[get]` |
| static ReferenceIMBEvent< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [CanHeroEquipmentBeChangedEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a75f3b1b892212ff1ffb82f77f3cb76d6) `[get]` |
| static ReferenceIMBEvent< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [CanBeGovernorOrHavePartyRoleEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af87529c77c5ae9f2d5b4f47d00fdacf1) `[get]` |
| static ReferenceIMBEvent< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1), bool > | [CanHeroDieEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a090f92b9f3e92a2f8cd645dfed59bb64) `[get]` |
| static ReferenceIMBEvent< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [CanPlayerMeetWithHeroAfterConversationEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afec442e33315c0bbbb3a29c6d439408f) `[get]` |
| static ReferenceIMBEvent< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [CanHeroBecomePrisonerEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abe4807c3a2e5e8e66e0b0e00e4e30f2e) `[get]` |
| static ReferenceIMBEvent< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [CanMoveToSettlementEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a52068cb387fd9809219d97c7464d8df9) `[get]` |
| static ReferenceIMBEvent< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool > | [CanHaveCampaignIssuesEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa7e28c44562134487d0d7ad7d9a5cda7) `[get]` |
| static ReferenceIMBEvent< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), object, int > | [IsSettlementBusyEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a60ba123762f773949b5973e7311a7c9a) `[get]` |
| static [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)< [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) > | [OnMapEventContinuityNeedsUpdateEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa54ee3a048dbeca5d589eb63556b1b26) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8346eef0ee8f1ac0a90679669d628555)RemoveListeners()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignEvents.RemoveListeners | ( | object | *obj* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3c1ea7f70bdf56bd222b5d5e5525e746)OnPlayerBodyPropertiesChanged()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerBodyPropertiesChanged | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a42192abcd3dc3b1b2afd793d4c6e2c34).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2981d4d336f58aab209b8f380d91e9e9)OnBarterablesRequested()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBarterablesRequested | ( | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a375225dfed41289db077577caf986ba0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac85b9a556ee7b3c7ca4ea9b1da835350)OnHeroLevelledUp()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroLevelledUp | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *shouldNotify* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab566f030c822fd4cbb09513a4d2836bb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac840fa48a1462879f109353002b6da7f)OnHomeHideoutChanged()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHomeHideoutChanged | ( | [BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html) | *banditPartyComponent*, | |  |  | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) | *oldHomeHideout* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af54816c97132e599daecf0afd69e4288).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a96173d89ea13e0f41b9a05d5411cd25b)OnHeroGainedSkill()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroGainedSkill | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, | |  |  | int | *change* = 1, | |  |  | bool | *shouldNotify* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a774dde909dfe3a56e5f1f2855f37291d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5c1a7ca330dc6b8bfb8e4a0d6066d9d7)OnCharacterCreationIsOver()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCharacterCreationIsOver | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8d7323ebc7d38c26760126df4427a633).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2f4a4efc3d64e82e3c534be8f9a85764)OnHeroCreated()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroCreated | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *isBornNaturally* = false ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a05e630443f776a6c1b9f9612cec60031).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a38b8e68d3e01c00caad1679cd848a20f)OnHeroOccupationChanged()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroOccupationChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) | *oldOccupation* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a48aad6e8dbaf5703c46f3f2b374b9e9f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7a303e1e131c48e7d9cf617f108e5861)OnHeroWounded()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroWounded | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *woundedHero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a625e18d200941d39c69344d5b9433c2c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab100922c27f9953f0bb2d67e91b2c970)OnBarterAccepted()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBarterAccepted | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offererHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, | |  |  | List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | *barters* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a20f5223478e91a352f32b5d91df3f215).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a493fd41084040dba18f9185b436b2cfb)OnBarterCanceled()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBarterCanceled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offererHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, | |  |  | List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | *barters* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7260af52532867d6d7a01fbb516c3d07).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a763d7ac8c45c2c45043b1a5cb83e108d)OnHeroRelationChanged()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroRelationChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *effectiveHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *effectiveHeroGainedRelationWith*, | |  |  | int | *relationChange*, | |  |  | bool | *showNotification*, | |  |  | [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) | *detail*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *originalHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *originalGainedRelationWith* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0847916b31147173736364528ec6ee49).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0963a7a5fc481248968d699ce1fa93c7)OnQuestLogAdded()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnQuestLogAdded | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest*, | |  |  | bool | *hideInformation* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a498dd4bb8db0b0f9764c5d430d6698a4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a51c12739f27a94d824425da0bd5d822b)OnIssueLogAdded()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnIssueLogAdded | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue*, | |  |  | bool | *hideInformation* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add0408270dc933a0bac52deb7ca20058).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aeefe58bbd5980ef22be5334a33f4a370)OnClanTierChanged()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnClanTierChanged | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *shouldNotify* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab2e5269e3afaf90afacf70f862b6e846).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a079e40a3ebbd830f6ca2e024bba877ae)OnClanChangedKingdom()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnClanChangedKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *oldKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom*, | |  |  | [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a015a602a70828d9e92b571cf5a1e1ca8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a56052c54559ccbfc1c6c2acf6ea5cf2a)OnClanDefected()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnClanDefected | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *oldKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abc55047e4785adff779e0754451ea424).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a206c73905348185766f66bfaf995de7d)OnClanCreated()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnClanCreated | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *isCompanion* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af7e7a45cbeaede6021ed4fbcf0eb5b0e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3cbc07bcd3b3a4bb983868117d3bce86)OnHeroJoinedParty()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroJoinedParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad7dcc8181382dbe9b9e0dd0439ef3586).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac58e9a8811801a4625421e08539c3594)OnHeroOrPartyTradedGold()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroOrPartyTradedGold | ( | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *giver*, | |  |  | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *recipient*, | |  |  | ValueTuple< int, string > | *goldAmount*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7ba4f835d34bde173d96329691e9c921).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aff4b6babc3f06decf02cea60ae5c6b36)OnHeroOrPartyGaveItem()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroOrPartyGaveItem | ( | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *giver*, | |  |  | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *receiver*, | |  |  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aefec55dd3f5ebe48fe1131de64f2724c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac69bd759ed45c3d0abb53bffc2b04d23)OnBanditPartyRecruited()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBanditPartyRecruited | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *banditParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6d5c54c4922af962519c94d697da6a61).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a798a4cde36bfcb83d31798f46351bbd7)OnKingdomDecisionAdded()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnKingdomDecisionAdded | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision*, | |  |  | bool | *isPlayerInvolved* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9a8a4e5a1b7331d9873402430fdad319).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa05d050e0f8b8bacdf3847c22c1810fd)OnKingdomDecisionCancelled()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnKingdomDecisionCancelled | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision*, | |  |  | bool | *isPlayerInvolved* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab405f44fe4a5bbe5c430afe873f6211f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0c9ddf213f601b47c7ff98d601b8b4bc)OnKingdomDecisionConcluded()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnKingdomDecisionConcluded | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision*, | |  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome*, | |  |  | bool | *isPlayerInvolved* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a45c01f7262fea33c04e71f7a6404348b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af3c660cacc08ec66f427b06cbf56d7f6)OnPartyAttachedAnotherParty()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyAttachedAnotherParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a70e9cf8fa0db1f683469486d17370def).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a59586a0b9838a010532169e0500e14fb)OnNearbyPartyAddedToPlayerMapEvent()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnNearbyPartyAddedToPlayerMapEvent | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa4aa33f9b5a7fa4fd152926e525c3bee).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a30f79e5f3ac7d501f309e98f33f83e72)OnArmyCreated()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnArmyCreated | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae5c7c8c0623112a24b92f45775da9ef3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a603fa574650d370e8cc734cdaf4ec791)OnArmyDispersed()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnArmyDispersed | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, | |  |  | [Army.ArmyDispersionReason](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798) | *reason*, | |  |  | bool | *isPlayersArmy* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add2840f58e65bb5718ccdef8d8cdbb36).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6509f1ac57a054b170cd3e1b93a763e9)OnArmyGathered()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnArmyGathered | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, | |  |  | [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) | *gatheringPoint* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a54baf1826c91309838e376e75e57d9ef).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4eea87dcb1db32d609eb7df4a06d3dba)OnPerkOpened()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPerkOpened | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aee81305bf3166d5e570ee5ecfe9b10a5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aabbce1eb5f89ff3727426bdf1a473ef8)OnPerkReset()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPerkReset | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a46d6825fd7135c94d5c46b61af4da22b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaf60413fe379de18485402869b375142)OnPlayerTraitChanged()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerTraitChanged | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, | |  |  | int | *previousLevel* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae3c7084a4ba93a0cb9c43b54cc86f682).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad8b2af435839f3c377b3a2e81bfc9a7c)OnVillageStateChanged()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnVillageStateChanged | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village*, | |  |  | [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | *oldState*, | |  |  | [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | *newState*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *raiderParty* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaaf549d05ae27a9de85ea15be155974d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5812c9e3206bbf0838e54b8829b3d99a)OnSettlementEntered()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34a08aad1b66ef9fb1a0f77377041c80).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2375fdadcd9f0679cc0e674ff641c64e)OnAfterSettlementEntered()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnAfterSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a81b5ae8709aa37f1ab97f244d5b4299c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4ec6825f18a2bd08cd70c7c7877ed8ee)OnBeforeSettlementEntered()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBeforeSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5cb188b4bddbe0e32a602eb89339ff08).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a574f7ec0c28d8095637b4ea63861f195)OnMercenaryTroopChangedInTown()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMercenaryTroopChangedInTown | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *oldTroopType*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *newTroopType* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a19f1714761ef9137b2a09c004880fdb7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a086e74029d42499eb89d9c597b4c6aad)OnMercenaryNumberChangedInTown()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMercenaryNumberChangedInTown | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | int | *oldNumber*, | |  |  | int | *newNumber* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afdeef75c68facf73a9a3da673fa64120).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8250042741b6911b35984b7a04b48046)OnAlleyOccupiedByPlayer()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnAlleyOccupiedByPlayer | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troops* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afb1c1846367ec6cb096c523dfeb75de8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a49df3ed48687b5faba1ab94db7dfdb3d)OnAlleyOwnerChanged()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnAlleyOwnerChanged | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a12183794116453d1920425fb1a0f1c06).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa52c39d1771552118c004125be2a23d5)OnAlleyClearedByPlayer()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnAlleyClearedByPlayer | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a94cecba044b9fb6b1d496718937aac6a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf617617b85c60d0e0a823a1f0776584)OnRomanticStateChanged()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnRomanticStateChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2*, | |  |  | [Romance.RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) | *romanceLevel* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4ef69fd2052fed76b92492482b0d23a0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9fb9d4bbe901bd38c6163b08c58baacd)OnBeforeHeroesMarried()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBeforeHeroesMarried | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a98d83294d0cc4c5c2829b5927310a925).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adcf56bcc29bf7e1858b5a991ad5e1556)OnPlayerEliminatedFromTournament()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerEliminatedFromTournament | ( | int | *round*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a467f012c0ebec2f57b4eee9a0817136d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3995a4ee9f88fbff4d9fc9f0fb95a608)OnPlayerStartedTournamentMatch()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerStartedTournamentMatch | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad65f3efd3ce650f123b8b20af29dbb2c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8092f0b2b6d6eba05cc278b9b0b074ac)OnTournamentStarted()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnTournamentStarted | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9d5972dfefb563fbd011cd2ff86dba72).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8ea1eea17b591f6dc693164903f51682)OnWarDeclared()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnWarDeclared | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2*, | |  |  | [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) | *declareWarDetail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1b454dafed5b1da0d3f7a16c142d6e72).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af17ef3249af0167b3239d941c6fc9d78)OnTournamentFinished()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnTournamentFinished | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *winner*, | |  |  | MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *participants*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *prize* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab8a512aebcd7550547be2484477c7673).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab5df63590d819bbc5b4f1ffb05bdb70a)OnTournamentCancelled()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnTournamentCancelled | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a75f25270c3a7cc08c1a6b56c162cdbf0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab75d9ccd2f631cdfba6799bd77c9f2bb)OnStartBattle()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnStartBattle | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty*, | |  |  | object | *subject*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afc6415a7dc758250a8adbac387f47004).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae80aa4ba6eca322fce4d563a4e87d86b)OnRebellionFinished()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnRebellionFinished | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *oldOwnerClan* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4c33911e4f68d8fb63b050d631bcc971).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a46473129645c0420e6ad853ee93ee2dc)TownRebelliousStateChanged()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.TownRebelliousStateChanged | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *rebelliousState* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af983512cf4a2250654d6f68d52cf8139).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aef6072df4e4251343c7636d1b2b8d0a8)OnRebelliousClanDisbandedAtSettlement()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnRebelliousClanDisbandedAtSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adca45c31fb5767cbaebd49fbc00f2af2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae4e5170b70100fede9ffbf9edcff097)OnItemsLooted()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnItemsLooted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *items* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2413d12700d18aea5d789566410076e2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a67c0870e45c7a54013fc75cdd1249396)OnMobilePartyDestroyed()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyDestroyed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *destroyerParty* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a83399ccb5af654bc810e1aa3695d73d2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a073cb8430ac23e18ad7e48b86d4da941)OnMobilePartyCreated()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyCreated | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae1a37302077e16224eae7622c70eddda).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3f713372ceae90a98284cd43ec574766)OnMapInteractableCreated()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMapInteractableCreated | ( | [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) | *interactable* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1ae04e92878f6098c97dd286e249fce0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad14b798aa0847cc633df408ced8c4548)OnMapInteractableDestroyed()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMapInteractableDestroyed | ( | [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) | *interactable* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3a06afc7142607764857ef5970c16cc3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a93184b1fad08f2a69499e45fd7bef810)OnMobilePartyQuestStatusChanged()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyQuestStatusChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | bool | *isUsedByQuest* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae19e20a00d6fad6f78d25ffa08109bfd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0586e8d199052b9001a658b2a2a57182)OnHeroKilled()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroKilled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0bac5bea643a360776c14acb7b0f5291).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#add1e7d161736b7f6c669dfa3ed07c461)OnBeforeHeroKilled()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBeforeHeroKilled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a725002864af0aa2a629f3d5448677172).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf8f6ce436135739bada622b89745b71)OnChildEducationCompleted()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnChildEducationCompleted | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *age* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a11f91f90e077f050c33d67866c3e83aa).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae83a9348e9c5632cdfb4e6ad4e93620a)OnHeroComesOfAge()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroComesOfAge | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#addab04c615c3a47008e02cdac4ee9493).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad7307bb4a07349a0474b6529ad96452a)OnHeroGrowsOutOfInfancy()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroGrowsOutOfInfancy | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac9334bcdd529dc13fbd707f9b9dff547).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a37a00c938245fe47986ecbadb93116ea)OnHeroReachesTeenAge()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroReachesTeenAge | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4a1f249bacb71890d0e93146a43cf659).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0abdf23b2adec440d4a5b079fae74c00)OnCharacterDefeated()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCharacterDefeated | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *loser* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac22e666e7df0a779a3063af689a1f957).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1d66130086f3a94b0e5a18aa990c011a)OnRulingClanChanged()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnRulingClanChanged | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *newRulingClan* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9bada74a737fe40043ba626c7734ef93).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aeed9185d0aff8a0d0dc57e1a191daa31)OnHeroPrisonerTaken()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroPrisonerTaken | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *capturer*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisoner* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f4366bdf2d5ed8f40840385ca8c4f0c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad9ae5888ec3958f7c21ea4f9279fdb19)OnHeroPrisonerReleased()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroPrisonerReleased | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisoner*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *capturerFaction*, | |  |  | [EndCaptivityDetail](namespace_tale_worlds_1_1_campaign_system_1_1_actions.html#a6a6556b279f5fa0db2c5ae9a933508fe) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afa8773a1e419eb74dcfcf1f42bccda00).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab61f3610a278094999878f4d486d9220)OnCharacterBecameFugitive()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCharacterBecameFugitive | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a87b8102e3a719199890062358b8d402b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab7b4cd1589ec41a5a90ee8ac24841b6e)OnPlayerMetHero()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerMetHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ade69c57127eb267ea9ef41bff3ff3bc6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a27b4ca095a76fc9ed83564ca9acd9e34)OnPlayerLearnsAboutHero()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerLearnsAboutHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad56fd9fadd8c85144e68e77a2ddecf32).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a96606a1b8cd2f528744e6e0c19741b9b)OnRenownGained()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnRenownGained | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *gainedRenown*, | |  |  | bool | *doNotNotify* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9b11f3154f636b85e22adcb1be2145a4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3f1c9cc9ef9d0cb91da2632de53722a4)OnCrimeRatingChanged()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCrimeRatingChanged | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *kingdom*, | |  |  | float | *deltaCrimeAmount* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a898868c9c0bb7ac1ab381e1fa9725f09).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aea25cf62b7866d409eced1b3fabb0c83)OnNewCompanionAdded()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnNewCompanionAdded | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newCompanion* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a706a5514966f701e5f4312bd1b8f7f4c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a29e7aed1396da14d0e3bd394c716dabc)OnAfterMissionStarted()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnAfterMissionStarted | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *iMission* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6b438896c4aef7588eb6a6fc38418036).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae01a64fd87a3881fa60ea97260858c90)OnGameMenuOpened()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnGameMenuOpened | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae3353fa62c4908b94dc2a74472bf3a3b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a80e7dc0e4c62ae6704259453e8b8ec26)AfterGameMenuInitialized()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.AfterGameMenuInitialized | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a405b9daff956f2a1a7c4d2e367311315).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5e2ca78337f6d3539c0f1ea8a3fe3a63)BeforeGameMenuOpened()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.BeforeGameMenuOpened | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3582e248084d5133e87cd1c999f6e6a9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac06b94b658e2afe684ced36d5c160313)OnMakePeace()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMakePeace | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *side1Faction*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *side2Faction*, | |  |  | [MakePeaceAction.MakePeaceDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff) | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0dcc68b946f5ceae0cd2f58f1f481bb6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5905a51cd7ba8b0565d6929a0dc4c034)OnKingdomDestroyed()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnKingdomDestroyed | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *destroyedKingdom* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af1717c6abfcbe84e0ac4565e1c2c8bc8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a84952dc2de1a1a005971d9f83cbec207)CanKingdomBeDiscontinued()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CanKingdomBeDiscontinued | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aeb013b5c5589e8980415990498ed4f3b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae5d1aedffc331b78a10e60059f7ae69d)OnKingdomCreated()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnKingdomCreated | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *createdKingdom* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae1182810cffabe7c541cf67f0244f80b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7b7d36593a58eb081b60f833f87f011c)OnVillageBecomeNormal()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnVillageBecomeNormal | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa24eb249f068c7dd709f5e2bdb48cbf7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8829a43e20fa385e73cd0718fe1baaae)OnVillageBeingRaided()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnVillageBeingRaided | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aec98069c7a4abdac6c55b1207b7f84dd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#affdbdf5672d2b48c22d64ed5d5510c5c)OnVillageLooted()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnVillageLooted | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acad0cd780e4c43833b7a95e9599faefb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9e1a55a0a980fd9e138b44f352765dd4)OnCompanionRemoved()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCompanionRemoved | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *companion*, | |  |  | [RemoveCompanionAction.RemoveCompanionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_remove_companion_action.html#afebe445a9fd9044486e94c0db1b931ef) | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9d56353914130b307ef8862259573d14).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acfbac12ed4c933c1c27fac368bdc00a5)OnAgentJoinedConversation()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnAgentJoinedConversation | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7c5b7c0f078500eaf2ae9e810116aaf0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac416c7c7ec196fd2b984565de2fa6e78)OnConversationEnded()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnConversationEnded | ( | IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *characters* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a390babfb91957aae89349c04a09990b8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d764f40b523943c39bdb65375c2c333)OnMapEventEnded()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMapEventEnded | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a26ebfaf0450f26c8ef4ef737583f8e72).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a12fbd1fda187e7a85c9052df1b367082)OnMapEventStarted()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMapEventStarted | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af1c1ca7805835f59aa9f333aada40a0c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4314706b7c0b9df5b2f9cccbe8aa5a7b)OnPrisonersChangeInSettlement()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPrisonersChangeInSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *prisonerRoster*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero*, | |  |  | bool | *takenFromDungeon* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adcbb12df96fe6a8aad73da3adacf3ff3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1f7c391a2ccdd3e63c2d404590982e96)OnPlayerBoardGameOver()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerBoardGameOver | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *opposingHero*, | |  |  | [BoardGameHelper.BoardGameState](class_helpers_1_1_board_game_helper.html#ab045b68fb522a41152b0557241b92db2) | *state* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aab862a653eab2a23dcbeb16661730194).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2d4f06a2f35a3592e140c5ecfb5ce6d6)OnRansomOfferedToPlayer()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnRansomOfferedToPlayer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *captiveHero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2a8d43ce96eeaea531a0d542a995e890).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aab20e270eb96c796f00c37e850f3f772)OnRansomOfferCancelled()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnRansomOfferCancelled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *captiveHero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a097a5eb7e91ea9a0ecae7fe66b38b156).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a517fd64f21706375a45e0b4388ef6d92)OnPeaceOfferedToPlayer()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPeaceOfferedToPlayer | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *opponentFaction*, | |  |  | int | *tributeAmount*, | |  |  | int | *tributeDurationInDays* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac8802474d31ad115e291c358bab01b4a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3f1c8113796cfa2b05b96eb8c57243de)OnTradeAgreementSigned()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnTradeAgreementSigned | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *other* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a598142d74e60f16dd21d0a5378f37cb8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af6997b5594f2e1cdd70ddc0bc0128cc0)OnPeaceOfferResolved()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPeaceOfferResolved | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *opponentFaction* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0de37776761cd464c8fdaaf446a494c4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9416a8942712af0f8a5a0b2fc2def22f)OnMarriageOfferedToPlayer()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMarriageOfferedToPlayer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a721a30d9191eecd34940bbbc029772d9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a63aea9cf76876742082b4f285663cd23)OnMarriageOfferCanceled()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMarriageOfferCanceled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3d90ef003543c413adb337f3a4be29fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a56568444e5ebe650314327c95666cf1b)OnVassalOrMercenaryServiceOfferedToPlayer()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnVassalOrMercenaryServiceOfferedToPlayer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *offeredKingdom* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a407630b92abd2671203f4b6d60e9ec9d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5678e3ba11d77e28f63f91ad1e33e28f)OnVassalOrMercenaryServiceOfferCanceled()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnVassalOrMercenaryServiceOfferCanceled | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *offeredKingdom* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a21f9d73d52efe1a4882847deda0a5489).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8d0ff302086846dfb8d38c418835707c)OnMercenaryServiceStarted()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMercenaryServiceStarted | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan*, | |  |  | [StartMercenaryServiceAction.StartMercenaryServiceActionDetails](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_start_mercenary_service_action.html#a5861e61ec787655431332d6abb63721a) | *details* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a38369e757c569b93cacdac7ebbcf4e44).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a63c05aaf01ba940da08b86af0e84b1a6)OnMercenaryServiceEnded()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMercenaryServiceEnded | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan*, | |  |  | EndMercenaryServiceAction.EndMercenaryServiceActionDetails | *details* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a276e0fae65b514dc3315369517f5388c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab658a499ef66e6ce0e208c94afc29857)OnMissionStarted()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMissionStarted | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *mission* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6cab1213b307e0b741ac21a4c8ad31b1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa8fc9aecad33a4500bfc7fee2c0fe97c)BeforeMissionOpened()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.BeforeMissionOpened | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aea5f880348e4bafc1d978f67d3ac1f0c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a366a7fd4a4759db08a443cdecd4361dd)OnPartyRemoved()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyRemoved | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a179635aa914fb7bb8aaf12a12225762c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6d024c9d62f97ce846d166bda11361a9)OnPartySizeChanged()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartySizeChanged | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3e0521786d62986195ca9761fd935196).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a42326f8401f7cb41e7500c30b774f980)OnSettlementOwnerChanged()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSettlementOwnerChanged | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *openToClaim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *capturerHero*, | |  |  | ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac0baa866084a03780ffa210021a05f64).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8ae50eabf1ee7f3a95f2a9c934ad9f06)OnGovernorChanged()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnGovernorChanged | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *fortification*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldGovernor*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newGovernor* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad0a73a2b35363cffcfc281ddb06b7349).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a23d17e5033a55769d56dc9c835c58c1a)OnSettlementLeft()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSettlementLeft | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a893bb6880175e5f7e7b9abe562e4e4ae).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7c29dbd1e6a65888ac64d2eb2b011816)WeeklyTick()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.WeeklyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5e9351f1758fd0d98bd9627365bc706e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3e06ad4c97c8c69d360c6a40e870a4b9)DailyTick()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.DailyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6eedfe629de9e36844fb39cd0d928616).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7290e87cf0c7faf8ec6a0cec197a3371)DailyTickParty()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.DailyTickParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a314bdcb0d4cc67abaebe8c105b181c2b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a94a5498e6e72138c909ed6a671700e80)DailyTickTown()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.DailyTickTown | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a366aa186af37cc2a654931cc6942c1a6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4abfc80ccb94823085307639a4cb56ef)DailyTickSettlement()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.DailyTickSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afadb083b69a3716a035aa6311cb3bcea).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7e0d4234db4e6b1f26a2d24ed3de654b)DailyTickHero()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.DailyTickHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a172bbe9254827d489a5c005b32f1ace5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a563dbd72cd8648cd0f9e3eaf247cf9bb)DailyTickClan()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.DailyTickClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a50deef6dafd5a6b652961a76b03b28f7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac578eda7cdbbf6d2931ac7467ce2af4f)CollectAvailableTutorials()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CollectAvailableTutorials | ( | ref List< [CampaignTutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign_tutorial.html) > | *tutorials* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a21ff92c0a4d675ca6489ffde3e65f31f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af31962e7a9be267f0411f636c7a976bb)OnTutorialCompleted()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnTutorialCompleted | ( | string | *tutorial* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a616361c9445050c5a2c6f2ff6891f6cf).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a452fdc29faee509003739fb3eb35416d)OnBuildingLevelChanged()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBuildingLevelChanged | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) | *building*, | |  |  | int | *levelChange* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a872484253aa14e7bb8be553a81b50cce).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aad723d766000f4e6d0682b21ddf558cb)HourlyTick()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.HourlyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1c4ea3f46ce568e82cc17f2ed71449d9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4c992591ed185f80d6956a1265777f46)QuarterHourlyTick()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.QuarterHourlyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa74fe2e776ae40603801b2b9f9b5afa4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2cf540a8f0ef526f7e57858e62c4dea2)HourlyTickParty()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.HourlyTickParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8eec0bf986fd3326ad97a265bb96cf26).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8fa49412559859bc7dbe8712555e0266)HourlyTickSettlement()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.HourlyTickSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1c4a127283bb458a6f213d4bf504a4d1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adda2b33b5f748245946287ef5f0b473e)HourlyTickClan()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.HourlyTickClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0f244bfb309f90d1cd1a53f8c3e8fc2d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab1446a4e44ff8fe93ab7c54fd047b7cd)Tick()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1a7d21c002a72891d40fc2a160179f49).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7976e45d7475b95dd21aa89d0e1e50ed)OnSessionStart()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSessionStart | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af6514672a01ba699cc915fbd282d2f95).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a90e9619b1fabc284d833a4f55e32b695)OnAfterSessionStart()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnAfterSessionStart | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa3cb8b037efd033c9a8232bee7d60eda).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac376b6294e8cc979693e99e252f38642)OnNewGameCreated()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnNewGameCreated | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a356b56d81b6ddc3abc0e62b821229808).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acc4e80ad6cde74e063398c89846897e3)OnGameEarlyLoaded()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnGameEarlyLoaded | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5f01de1db2ee2680e7c813a69df821e9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adecbe92c3b13b4a5604225a5ec208c5b)OnGameLoaded()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnGameLoaded | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4d442d24ad6a85982389a44c63a2eb14).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1cd243613aa602cf19f07f6b2975ed80)OnGameLoadFinished()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnGameLoadFinished | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3ea634c601f4771590d6d3f9cabd7862).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ade3a332a43f4dcda2914e6fed8b0e592)AiHourlyTick()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.AiHourlyTick | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) | *partyThinkParams* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a11d99dce4f8a008cfa53165641c5655b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae99ab550043cca1ca3fc8453dc6a26b8)TickPartialHourlyAi()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.TickPartialHourlyAi | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7318f8837165f380a312160c0ad0b707).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abb913bb44a8da6a7098cb169a94b5dd0)OnPartyJoinedArmy()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyJoinedArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a900ae35cc97fff74751105c0011d305f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4a56776bef64dc01145f43f0063c3d69)OnPartyRemovedFromArmy()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyRemovedFromArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2b6fed8a03b00b66ac14da2792c29191).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aab9879a75a179badaeb5f3284b07c395)OnPlayerArmyLeaderChangedBehavior()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerArmyLeaderChangedBehavior | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a761fc245fa9776d0992839882747fdbd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5fc927af05ae7412962d6818ecff79c7)OnMissionEnded()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMissionEnded | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *mission* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af4c7984de81c44b47d2a9656ecf6f54c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab98ec41074e42da81ee9b09f003aeac9)QuarterDailyPartyTick()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.QuarterDailyPartyTick | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad182750b43c6c39495c21838d4b33488).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a08f718b07c7a1fdd737e4a2653477d11)OnPlayerBattleEnd()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerBattleEnd | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9da462a29263d571d88a25ff8cc6fc39).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5bf2844e9edeccb524d975f198248db0)OnUnitRecruited()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnUnitRecruited | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | int | *amount* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab72ecd3343c3d04c0e1ede65be378dc6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac157502e07ccc9cb8cdc9f5151b83ffc)OnChildConceived()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnChildConceived | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *mother* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9b57951e17afe64ae22769ca11616785).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae9f2d1954e01d6d0955025b1bba2487)OnGivenBirth()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnGivenBirth | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *mother*, | |  |  | List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | *aliveChildren*, | |  |  | int | *stillbornCount* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a552912c267589be8430cabef7b08b981).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab7503ef6a1cf487269340ca882929fe5)MissionTick()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.MissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac49962f703db44ac19cd193e4505201a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3cb6b0f6446b83418f9e2aa64c29f92a)OnArmyOverlaySetDirty()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnArmyOverlaySetDirty | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a48d87ca9b4e0190973077cad8d0d6946).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afba953fa6ba9ffe4ce4c579c8dd01a43)OnPlayerDesertedBattle()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerDesertedBattle | ( | int | *sacrificedMenCount* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad8db9a572572bf68ae4a7c36dc869344).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a669c06128c66b12f9c8ec4499e3506fd)OnPartyVisibilityChanged()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyVisibilityChanged | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a41385b937b64a01c0adf9b3ac60f809b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a55712afcdfa91a01d1696e637d8cf42c)TrackDetected()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.TrackDetected | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abea423068f95d08a933d05592fd1c75a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf86ef22f2cb211d8bb0d3a7daf29dd7)TrackLost()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.TrackLost | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5491752d533283178cc29f9bb6d068c2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8184b7310de2764ad405fe8fe51e72b2)LocationCharactersAreReadyToSpawn()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.LocationCharactersAreReadyToSpawn | ( | Dictionary< string, int > | *unusedUsablePointCount* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4144e9473f03cfb82de327978168a7b4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac89cdb1b6dd5b40718ac702dbc549aba)OnBeforePlayerAgentSpawn()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBeforePlayerAgentSpawn | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *spawnFrame* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9958864ae44837589d7187f2afa06a90).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aea30d2899ca249abbf1b17cfb159f24d)OnPlayerAgentSpawned()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerAgentSpawned | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab8ba2dd4267664efab7faf52d64808e5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a73f74401ffa0b0dc8f118d0b13375fae)LocationCharactersSimulated()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.LocationCharactersSimulated | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a79acccb94610f2e4937cbd925dc759a2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3075599224bb4b78b7716db45a5f580c)OnPlayerUpgradedTroops()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerUpgradedTroops | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgradeFromTroop*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgradeToTroop*, | |  |  | int | *number* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab58f89386e7a027c6eceb6d20740b9cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5991b65f5382060d2f1df4b463efc70f)OnHeroCombatHit()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroCombatHit | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *attackerTroop*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *attackedTroop*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *usedWeapon*, | |  |  | bool | *isFatal*, | |  |  | int | *xp* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a98b7f06624c7d920d82aef18bd6f9a64).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aed3010eaf7cbd14884058de55d9a19ce)OnCharacterPortraitPopUpOpened()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCharacterPortraitPopUpOpened | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afdb992d08aca0b0a06e2711b1268c293).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9d19b34ca706bc37143b34f07b58b614)OnCharacterPortraitPopUpClosed()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCharacterPortraitPopUpClosed | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aabf775870c5bb7dff811d5076b5883c7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a980b851ed81c28dcbc66294275f41d79)OnPlayerStartTalkFromMenu()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerStartTalkFromMenu | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1115abb47b46ddd62a512e67b58d7ea4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a740099b28f0a10fb6e99485ceaed58ed)OnGameMenuOptionSelected()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnGameMenuOptionSelected | ( | [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) | *gameMenu*, | |  |  | [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) | *gameMenuOption* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a694849371b5335c9b8e1f05b025fa5be).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae2eea29b669d7044b783379c82083a9)OnPlayerStartRecruitment()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerStartRecruitment | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *recruitTroopCharacter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a14303cbfa6ff9454bbdabf6046e18652).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9d56bad917fb3c175ac0caceb1a30b4c)OnBeforePlayerCharacterChanged()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBeforePlayerCharacterChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldPlayer*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newPlayer* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a64011b94834dfced52f276974f6d16b1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a771df6167dfdba0b359b413f6eb56704)OnPlayerCharacterChanged()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerCharacterChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldPlayer*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newPlayer*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *newMainParty*, | |  |  | bool | *isMainPartyChanged* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a80a199ed5541ed86fb6cd5c820a8928c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a35fab67f070c9d67534dfd8886f333ed)OnClanLeaderChanged()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnClanLeaderChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldLeader*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newLeader* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abcbcd369d0bc1189b867b0477520bafd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3b09c1a1dcbce3556fc480f19397d57e)OnSiegeEventStarted()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeEventStarted | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f6bcb872fed496e606a9a1537bed3be).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7b4519cfe927e26c5b8cc3fb6394650e)OnPlayerSiegeStarted()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerSiegeStarted | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac056ce5c1c89bd4c99c37b126c6d9b4a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8600568a132addc1aea60863c4a7b818)OnSiegeEventEnded()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeEventEnded | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a04b227268da4e7079e1a66fcf80acc45).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aff754b01912ed5af7251d863166311c2)OnSiegeAftermathApplied()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeAftermathApplied | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | SiegeAftermathAction.SiegeAftermath | *aftermathType*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *previousSettlementOwner*, | |  |  | Dictionary< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), float > | *partyContributions* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a94d96e25e916273dac202b12353b91a0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a70f899b167bdd6abd751cc4ec474b9d8)OnSiegeBombardmentHit()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeBombardmentHit | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *besiegerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *besiegedSettlement*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *weapon*, | |  |  | [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *target* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a666de6d9a062ea8ced4651f550b50dff).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a21bb973fad9fa70cc171f161f487a7cf)OnSiegeBombardmentWallHit()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeBombardmentWallHit | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *besiegerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *besiegedSettlement*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *weapon*, | |  |  | bool | *isWallCracked* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6a86873ff9207ea3882694d3e8bb5bcb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abe788fb9a05f48347ce374811cd18140)OnSiegeEngineDestroyed()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeEngineDestroyed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *besiegerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *besiegedSettlement*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *destroyedEngine* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab18d10db3188ea0819948ff5d5ebce42).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aff39be1c69fcc01ae82c1977c97be715)OnTradeRumorIsTaken()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnTradeRumorIsTaken | ( | List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > | *newRumors*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *sourceSettlement* = null ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae38e70e8830d80182e27fd29f6469ddd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d8cbbe23ae0d7f976b4b321d8d85041)OnCheckForIssue()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCheckForIssue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a047960b1b435d59d54408009dd5000dd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa44a138f7db89c7d904ef4959d9d38d9)OnIssueUpdated()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnIssueUpdated | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue*, | |  |  | [IssueBase.IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b) | *details*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *issueSolver* = null ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae96c0f4c1c348d7a55ba3434ed5f474d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac08af8453b61667d41daed2da2dc1423)OnTroopsDeserted()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnTroopsDeserted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *desertedTroops* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acfda4979f29c66490f6e93d9cb80b513).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a885237729c71891b4d890a95e5d8df9c)OnTroopRecruited()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnTroopRecruited | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *recruiterHero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *recruitmentSettlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *recruitmentSource*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, | |  |  | int | *amount* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab649fa58127eb99c1b38175e73c0a38d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acc7311fbc1afa9f86313818ee0e407ee)OnTroopGivenToSettlement()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnTroopGivenToSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *giverHero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *recipientSettlement*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *roster* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5f30a5817691a5b20153fb0d3d514980).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af3f8ff1f75d0c27fdc9daee01cf0ff05)OnItemSold()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnItemSold | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *receiverParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *payerParty*, | |  |  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement*, | |  |  | int | *number*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *currentSettlement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aac3d9c50869d924aca98205bb4243972).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a64dadd17a96e6f7d020c0a231ff1ab46)OnCaravanTransactionCompleted()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCaravanTransactionCompleted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *caravanParty*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | List< ValueTuple< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), int > > | *itemRosterElements* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a154a99467bcefbb586b19b65b1cdbb90).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a307479f9a6b4e59b8605c7c701b4c053)OnPrisonerSold()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPrisonerSold | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *sellerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *buyerParty*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *prisoners* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0f9a29cdbe6e8f47af23132fcd73dc49).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a435f6000810da2d250a72add787ea4e9)OnPartyDisbandStarted()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyDisbandStarted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *disbandParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5843d230859c9560b27b7780fc5126bd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab8ebc6ef8478faf1a98707ebf2e25f35)OnPartyDisbanded()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyDisbanded | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *disbandParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *relatedSettlement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae580d6d15c25d986d63f801b137fbead).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3977bcfdc68a5e5c0a90621bbce0c1ef)OnPartyDisbandCanceled()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyDisbandCanceled | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *disbandParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaf395a07d55b70154e54b9b1d6306d14).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a107d54d1af82cefe302890f102becce8)OnHideoutSpotted()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHideoutSpotted | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *hideoutParty* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2cd2abd5833057f8bf87612f959882b7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad45c246ac81b2700b130b527e7e4fbff)OnHideoutDeactivated()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHideoutDeactivated | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *hideout* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a476b40c0e2eff03ccb62cd67198e7cd2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac23827b7d0840d3b62a05719f697c650)OnHeroSharedFoodWithAnother()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroSharedFoodWithAnother | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *supporterHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *supportedHero*, | |  |  | float | *influence* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad0562768c73b4c3bcb7f694365fbc158).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5bbe4343eb8104ed525b6f0685736a8e)OnPlayerInventoryExchange()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerInventoryExchange | ( | List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > | *purchasedItems*, | |  |  | List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > | *soldItems*, | |  |  | bool | *isTrading* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a38a3c030c58c37d32509be7309108484).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9c4b7274b83dec958c5edcc0bbce40cf)OnItemsDiscardedByPlayer()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnItemsDiscardedByPlayer | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *discardedItems* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8b8d0b7de26833d92f2e1e533e2935f5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aba49afafe5df9abc79f9a6d7e0133402)OnPersuasionProgressCommitted()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPersuasionProgressCommitted | ( | Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > | *progress* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6c488089d6f3fec0967dae048ddf15c7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a590163c2f429e98618eb171012cf2fef)OnQuestCompleted()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnQuestCompleted | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest*, | |  |  | [QuestBase.QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0722f718cc643befffb3cf46532f0634).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a95a52b5bf670b4813849f148044a4b2a)OnQuestStarted()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnQuestStarted | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a80121601a110e1d9254a0da5a85cdaf4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af970d6e677f9701e31154b0d25674b58)OnItemProduced()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnItemProduced | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | int | *count* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9169a1080e9bb2dadd9dc196d6b759e6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6bbccc22ee524c01f5794a5d2c4a4221)OnItemConsumed()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnItemConsumed | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | int | *count* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a00a463efddac32f12cdb487ea3726c4f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3fab1e550f8d0a9c0cedb988a006739e)OnPartyConsumedFood()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyConsumedFood | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9ec42fd3a836317d6aabe6fa54cbd45c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aef0c1a585b3255257bdb0ad3c9201f83)OnBeforeMainCharacterDied()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBeforeMainCharacterDied | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa290b1325d6b07ac06a0611c7b0449ee).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abc0ff17b85929f8d4abd1266440c612f)OnNewIssueCreated()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnNewIssueCreated | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a797486987494c0ebdb1c732af849f3b6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2e2a9e8bcdc8ce02f8a1e2a27b55b261)OnIssueOwnerChanged()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnIssueOwnerChanged | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8beb35652e74a4e2f93455849af59c0e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2d9dcc25bb52fe26844a5b37d2dae455)OnGameOver()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnGameOver | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3f72e0aff76dcdc8cf0019607b406435).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a48e629d0cc07881c079897e4c7dd6a40)SiegeCompleted()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignEvents.SiegeCompleted | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *siegeSettlement*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, |
|  |  | bool | *isWin*, |
|  |  | BattleTypes | *battleType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab68f5a364a913a868eae27dd9d1d7a1b)AfterSiegeCompleted()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.AfterSiegeCompleted | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *siegeSettlement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | bool | *isWin*, | |  |  | BattleTypes | *battleType* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa3366fb9d461ec7a6de88bb42d561441).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7ee58a8e2e02a0f58f1178a6ef811ce8)SiegeEngineBuilt()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.SiegeEngineBuilt | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6543dce7ae5422f511800117488e01f8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a08926b9adb1e89de8902d1988ef7863e)RaidCompleted()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.RaidCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html) | *raidEvent* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6631550f84b65e909d1c177602a6e6e2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1c2a775f5f0f4275d2b134c1370ea6c6)ForceVolunteersCompleted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.ForceVolunteersCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html) | *forceVolunteersEvent* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34850c45926553d8c8dc9e687bfd13fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aadc9886963dd925a2035d3e697b144e3)ForceSuppliesCompleted()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.ForceSuppliesCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html) | *forceSuppliesEvent* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a459da0fd4ab5b8a60b9c890f43a10ccf).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad2a823d8ba95841343603d955ee86164)OnHideoutBattleCompleted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHideoutBattleCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html) | *hideoutEventComponent* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34507ce845f04b6117d04a0dbbbd438c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a47bd07c99a4646f9a1c54f1294e30b8c)OnClanDestroyed()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnClanDestroyed | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *destroyedClan* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6fd8e156fdfaa49ae41bf1e0d2b1beda).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae38df8a3f3b010c8057558b55fd30c28)OnNewItemCrafted()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnNewItemCrafted | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *overriddenItemModifier*, | |  |  | bool | *isCraftingOrderItem* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5980e578f147e20215ced59a04f0766f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a367a81bff4b70539bab2ca4732eb829f)CraftingPartUnlocked()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CraftingPartUnlocked | ( | [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) | *craftingPiece* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aab97ff9ba3547cec53d5b9601e926110).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a20b71a38397105f87e43f3097e523863)OnWorkshopInitialized()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnWorkshopInitialized | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9618f4263e5934975be5401c61736fe7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afc07d766c9aeba8c29c7538529accdb1)OnWorkshopOwnerChanged()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnWorkshopOwnerChanged | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afcc35d1b1e67aaaaa91a55d551a11e2c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a754d36b51ec66c6e7186bd57733b4c0f)OnWorkshopTypeChanged()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnWorkshopTypeChanged | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa16c9c5697a3ec6f58d0d2b1e96d7841).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6baca90336dae590cc1eda727acc7ed4)OnBeforeSave()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBeforeSave | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a75e93c7e63b080e226b80f2dd339c568).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5b716570f1d56f4771ce15f0485c0a6a)OnSaveStarted()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSaveStarted | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3800ff42e205d4cfb09aab0c7dd3c0c8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3c6e4e27a8a51ea5c0acb4d477afde4f)OnSaveOver()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnSaveOver | ( | bool | *isSuccessful*, | |  |  | string | *saveName* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2e7eeee5baaa97c7e5988c00ce06045c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afe2e2e61e4b0bb44292758a1de74ac35)OnPrisonerTaken()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPrisonerTaken | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *roster* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac44d5c1dc977f3c195612e48fc80999e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aba719cb40f5c268051fb2589f01a619a)OnPrisonerReleased()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPrisonerReleased | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *roster* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afef8ca1ccf2d6d9240b019eb501454ea).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae880ee9d300bf88029e5bcee2d4ede7b)OnMainPartyPrisonerRecruited()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMainPartyPrisonerRecruited | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *roster* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af7bb92bc1db0a74d85b8c363bd8edb2d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaa7455ce9f24cb66cd84478dd9866a08)OnPrisonerDonatedToSettlement()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPrisonerDonatedToSettlement | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *donatingParty*, | |  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *donatedPrisoners*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *donatedSettlement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad5622914ebc0442414760a747799d76f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d7eed04b14753e71ce77cdf5f4de78f)OnEquipmentSmeltedByHero()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnEquipmentSmeltedByHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *smeltedEquipmentElement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a46f4e356ccd54b097f802cd91fc9df46).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1a37c65ce2a218dd73acb04ad249a7f3)OnPlayerTradeProfit()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerTradeProfit | ( | int | *profit* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a572703ead6531bf2a5822ab01018a24c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a74e8eb9bb1b8a35d74beaba53f0567ce)OnHeroChangedClan()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroChangedClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *oldClan* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acb3aef6fb1a771ef7d0519491462ccf9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a666c6764f22ac2518d67c2f702f5685d)OnHeroGetsBusy()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroGetsBusy | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [HeroGetsBusyReasons](namespace_tale_worlds_1_1_campaign_system.html#a74f96a6c3de3af13ac985228276ee611) | *heroGetsBusyReason* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f8b1fec51e016490693052fec3ee4ce).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af413d80eaa6bb562de87e9c5d2b9e889)OnCollectLootItems()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCollectLootItems | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *winnerParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *gainedLoots* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaa48a85629d5eab820e833109536c1b3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abbf01e33a0ee2e404837ffa6e9d7bc61)OnLootDistributedToParty()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnLootDistributedToParty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *winnerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *lootedItems* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a520767a6cdf6339bc7b643a91eefe842).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af00814a5685f3517528100648d549428)OnHeroTeleportationRequested()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroTeleportationRequested | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *targetParty*, | |  |  | [TeleportHeroAction.TeleportationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90) | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab00fcec3aacef57c81c31a481511e086).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae1b0f4b6029170ca040c45c088565323)OnPartyLeaderChangeOfferCanceled()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyLeaderChangeOfferCanceled | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a278eba1bc1a9b773e8ddf8f77ec7a004).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af7f0c2dca43d3ab6f4e987712fb019b5)OnPartyLeaderChanged()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyLeaderChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldLeader* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1a54daf70ee1d2f5a28f1572d63180a1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac1ef125cf47fb19c4ca6cd4b34dc1727)OnClanInfluenceChanged()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnClanInfluenceChanged | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | float | *change* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad46b74e2a3930b813499c484338e6880).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6bfac288f3b477ade7d4b6a951dc7225)OnPlayerPartyKnockedOrKilledTroop()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerPartyKnockedOrKilledTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *strikedTroop* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5e085b092f6b313fb08f3104fa5989e4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a714a13cfe1733fb5e5c1bccba85c4aec)OnPlayerEarnedGoldFromAsset()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerEarnedGoldFromAsset | ( | [GameComponents.DefaultClanFinanceModel.AssetIncomeType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50) | *incomeType*, | |  |  | int | *incomeAmount* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac9abaf7d14174ccda495abd40f0fd4d3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2e244df9b61b9fce3a98d3311e7ff02f)OnClanEarnedGoldFromTribute()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnClanEarnedGoldFromTribute | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *receiverClan*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *payingFaction* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8dc8752dc68807900227f4a48bedfd6d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa2d3c6bbb233e913bf84f1f50864d97e)OnMainPartyStarving()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMainPartyStarving | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2a3dacfbcba36e34194be6ab18b190d2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa1ea406df227702480c5060e0c765134)OnPlayerJoinedTournament()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerJoinedTournament | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *isParticipant* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adba59a048dccb310ae93e9e80adcd8b0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8f918ef9a6674adbe46ee21f23548c87)OnHeroUnregistered()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeroUnregistered | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0be0a6d8f2b46360e13a0a2c0405207c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aac6ba2a5762cda5ea247ef2f9d4e2006)OnConfigChanged()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnConfigChanged | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0534f5200e010106be8c7f7885edf1fc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afcced854fd093fdc6c3c588678b01626)OnCraftingOrderCompleted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCraftingOrderCompleted | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItem*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *completerHero* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa15c74a738056e3bd158de34e5cbad38).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0c78c0402dd94259fe82c3c665fd5b63)OnItemsRefined()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignEvents.OnItemsRefined | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | RefiningFormula | *refineFormula* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a52c927982c9ed2a86cd506eaca0408c0)OnHeirSelectionRequested()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeirSelectionRequested | ( | Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > | *heirApparents* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add98c2403df7ebb7ea5a106e5a1c6bac).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a52be4b7dfdaa648a7449a7e44e92b4e2)OnHeirSelectionOver()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnHeirSelectionOver | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *selectedHero* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a093f73749d5a11dc6b783f76cda19891).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9be9362f53d1f154f2dacd0512bb735a)OnMobilePartyRaftStateChanged()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyRaftStateChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8e7ae269f45c9b02e1d9008c3f5bbd1f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a82a3649d2950a413904ca588159217ef)OnCharacterCreationInitialized()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCharacterCreationInitialized | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a499f973fe9a231418750e8e36bae0416).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a288bd16bf1f01d0b663c6ae9ab896f89)OnShipDestroyed()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnShipDestroyed | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *owner*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [DestroyShipAction.ShipDestroyDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_destroy_ship_action.html#a52f9b7dcd67d7a49fc241de25137f7d1) | *detail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a948c718e3662d8dc65a58b64d8738b44).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6d65a54de0b4220df0286d86bf9a6065)OnShipOwnerChanged()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnShipOwnerChanged | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *oldOwner*, | |  |  | [ChangeShipOwnerAction.ShipOwnerChangeDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f) | *changeDetail* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a109dc611f24cb27bac0bbc8a498b0ac3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2674612a72b7ce207753f103b6021e7a)OnShipRepaired()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnShipRepaired | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *repairPort* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7af6a0e0fffc671bffadc3141d82ce9a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac39af14e59490ef9c76fc5e35319be03)OnShipCreated()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnShipCreated | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *createdSettlement* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aafd518d9378b18cd54ae69ee53c05955).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a303dde4b23a13858a2028ab9a737cd24)OnFigureheadUnlocked()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnFigureheadUnlocked | ( | [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) | *figurehead* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a04de735972ec8a5f3100bbfa85f6a245).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a83262ca5921e46d62b2f206628c37263)OnPartyLeftArmy()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyLeftArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae9ffeade5f828b9a1fbd1f93ebf61428).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0be68db04a54a9d784d642ab527ec013)OnPartyAddedToMapEvent()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnPartyAddedToMapEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af224cc53faa894e55efbdc61df7c1420).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af6fc2561f174c11931e07734e33f42d4)OnIncidentResolved()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnIncidentResolved | ( | [Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) | *incident* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aeb1b212b7702dbb455fc139aebc86f5e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a201c380db46ce38ddcbe118fd61d1e73)OnMobilePartyNavigationStateChanged()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyNavigationStateChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a32a3229f31b225842e3719a8857e241c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2c36af71d321b981547fe36a88aba290)OnMobilePartyJoinedToSiegeEvent()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyJoinedToSiegeEvent | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acb9777179473e1e00f7a3f4eb3d80999).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a490bbdd1ff5e23125c1f44b1ba3e18f9)OnMobilePartyLeftSiegeEvent()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyLeftSiegeEvent | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a56a8dc304af6f4c9a38d3debc9366ba6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a196ac6529370b56fd8897ec8a4d313e1)OnBlockadeActivated()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBlockadeActivated | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8e869f7664427be678ff273ec340f732).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4af8ecc5487a11bb09af354fcecba08f)OnBlockadeDeactivated()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnBlockadeDeactivated | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7b3c5394f44442467ae00a7603aebc5e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab8df8071674190bb91d81b67f632cb4d)OnMapMarkerCreated()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMapMarkerCreated | ( | [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) | *mapMarker* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abf77449a7e77c1458bb7bb04b624099f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a92823548d071b26ed58fcf554badeaf5)OnMapMarkerRemoved()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMapMarkerRemoved | ( | [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) | *mapMarker* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adc1a52dad5da10a6060d97348ab2b04b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab19d2e524c42aae3d196cbac276dabfa)OnAllianceStarted()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnAllianceStarted | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a86b1385ce8466223b86bba96b23493d9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7d30fd14412cd6fcd6c1c49db1452a47)OnAllianceEnded()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnAllianceEnded | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a776018fae9847480244d9ce0d6715e76).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac4b263e6f660ca58d20e97e12ae7236d)OnCallToWarAgreementStarted()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCallToWarAgreementStarted | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa0bce07a59e9752cf0ac7e4bfaa66e38).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7c4bf247b0f77d2d9c58b90a769c61c8)OnCallToWarAgreementEnded()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnCallToWarAgreementEnded | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3ed5af5ad91883f12190c4cd2366cbda).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae199ffd877366b7eecf95be012108ef3)CanHeroLeadParty()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CanHeroLeadParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a86e4f4782d0f1b2be099ef4fe30b8716).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab5b640f02a7f00a59d396111d4a407ab)CanHeroMarry()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CanHeroMarry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8527e4986c0e3cf7a581da7cf19187fa).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab73b22257fac8821ea196fbe1fb43600)CanHeroEquipmentBeChanged()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CanHeroEquipmentBeChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a433faa50918c107ff0026aaac8470c27).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a760a2c75593934dfe47204d529e392aa)CanBeGovernorOrHavePartyRole()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CanBeGovernorOrHavePartyRole | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad71470980290f2d55166a618d637db9e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a307419eaf4b9f064ab01038a3122de6a)CanHeroDie()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CanHeroDie | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *causeOfDeath*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0b1778170b8b1e9f08d84a8485dc673c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a74af2b301b82cae5cbc62d3590233fba)CanPlayerMeetWithHeroAfterConversation()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CanPlayerMeetWithHeroAfterConversation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af03a06a9e937ab8ceefeb1b2584fdf22).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf22960a231b4f8b92d2cbb7139c2548)CanHeroBecomePrisoner()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CanHeroBecomePrisoner | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ace775570f432474d242258663c80849e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af3bf4ff02accf19f9618a4f1e5526e78)CanMoveToSettlement()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CanMoveToSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4793a0025d67692ca65cab7d9c866317).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac799d3b8e891ed7075889dcc4cada033)CanHaveCampaignIssues()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.CanHaveCampaignIssues | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6f50c9d7928844d7dab61293b71b90db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9feb4249dd8f2350df3edb3ca8907889)IsSettlementBusy()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.IsSettlementBusy | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | object | *asker*, | |  |  | ref int | *priority* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a45dd08fc640c47170fc82ce3fd764dda).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9062b09aae280c4e15d36f1d347ad1b9)OnMapEventContinuityNeedsUpdate()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.CampaignEvents.OnMapEventContinuityNeedsUpdate | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4525748c4272953b82962a499a2616e9).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a799bec52b3b8a70fe45d8098dce779c7)OnNewGameCreatedPartialFollowUpEventMaxIndex
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.CampaignEvents.OnNewGameCreatedPartialFollowUpEventMaxIndex = 100 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1d3acae7ba50d04b62b16cc5e5c2fb51)OnPlayerBodyPropertiesChangedEvent
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerBodyPropertiesChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6c3d1e61117cec8ce175c1a093ae3eae)BarterablesRequested
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html)> TaleWorlds.CampaignSystem.CampaignEvents.BarterablesRequested | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aab1ced1a07c377b3e7df9b6f03bc9c00)HeroLevelledUp
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.HeroLevelledUp | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aeefa8364e9329504c8ff3d03709c4f21)OnHomeHideoutChangedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html), [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnHomeHideoutChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a82c289a38cbcd6fcc1366955eb7fed8b)HeroGainedSkill
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int, bool> TaleWorlds.CampaignSystem.CampaignEvents.HeroGainedSkill | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaaa51e810d5b8f96fa6f2c434b670826)OnCharacterCreationIsOverEvent
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.OnCharacterCreationIsOverEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a678b52a42fe572a5803a84943fc41e59)HeroCreated
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.HeroCreated | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4b990ccb436e11b7b6d4a3eee2221274)HeroOccupationChangedEvent
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f)> TaleWorlds.CampaignSystem.CampaignEvents.HeroOccupationChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2ef2175fd613ee3770443b96d7603412)HeroWounded
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.HeroWounded | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aed47ec17978148470fd436745d752993)OnBarterAcceptedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), List<[BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html)> > TaleWorlds.CampaignSystem.CampaignEvents.OnBarterAcceptedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9e99293bc036050a094f4053a1a5b722)OnBarterCanceledEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), List<[BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html)> > TaleWorlds.CampaignSystem.CampaignEvents.OnBarterCanceledEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac6318731f8b67f6eb85f670c0217f2da)HeroRelationChanged
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int, bool, [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.HeroRelationChanged | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab108586a1888b133b1e383d97c9ef1f0)QuestLogAddedEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.QuestLogAddedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0868734dc943fbd25d9043be36d02ef2)IssueLogAddedEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.IssueLogAddedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa40bca1bebda744234180d88c9a4137a)ClanTierIncrease
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.ClanTierIncrease | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aead2be8111cfb660c5639ec5c5ef2243)OnClanChangedKingdomEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035), bool> TaleWorlds.CampaignSystem.CampaignEvents.OnClanChangedKingdomEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae920f0857c0ea9020053af900b7cf76d)OnClanDefectedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnClanDefectedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af2f71cff2d96f9ad98078241bd8822ea)OnClanCreatedEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.OnClanCreatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8e0b121a43bc68394c120f0933da3ea8)OnHeroJoinedPartyEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnHeroJoinedPartyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afcaf61013c51189c711090b3ab1b30c0)HeroOrPartyTradedGold
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<ValueTuple<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)>, ValueTuple<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)>, ValueTuple<int, string>, bool> TaleWorlds.CampaignSystem.CampaignEvents.HeroOrPartyTradedGold | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a866f9de3f1f2462fc68ef99d2e4e1b85)HeroOrPartyGaveItem
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<ValueTuple<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)>, ValueTuple<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)>, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.HeroOrPartyGaveItem | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3c9e61b0ef6bfd2681d3bb3033a7aa7f)BanditPartyRecruited
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.BanditPartyRecruited | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a40a35a5fcccb065abd11e5fc342a9c08)KingdomDecisionAdded
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.KingdomDecisionAdded | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acbd7ec95d0a226ff9ea99e4d74c25302)KingdomDecisionCancelled
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.KingdomDecisionCancelled | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac6b707b5dd63d9388312f9b0b07dd195)KingdomDecisionConcluded
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html), [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.KingdomDecisionConcluded | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a71ee7bb10d203b2619c40ce577f4c54d)PartyAttachedAnotherParty
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.PartyAttachedAnotherParty | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9a9daf7f707085eaf98b9dccb0570929)NearbyPartyAddedToPlayerMapEvent
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.NearbyPartyAddedToPlayerMapEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3aaeae7bff65b2760a06c1e9d47d658f)ArmyCreated
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Army](class_tale_worlds_1_1_campaign_system_1_1_army.html)> TaleWorlds.CampaignSystem.CampaignEvents.ArmyCreated | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab381886a89acede04b05c400c5fc8282)ArmyDispersed
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Army](class_tale_worlds_1_1_campaign_system_1_1_army.html), [Army.ArmyDispersionReason](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798), bool> TaleWorlds.CampaignSystem.CampaignEvents.ArmyDispersed | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a29a30424257272e5bdae32f207b4e582)ArmyGathered
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Army](class_tale_worlds_1_1_campaign_system_1_1_army.html), [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html)> TaleWorlds.CampaignSystem.CampaignEvents.ArmyGathered | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab9c2905f0c2d2461c38ac630067fe758)PerkOpenedEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html)> TaleWorlds.CampaignSystem.CampaignEvents.PerkOpenedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a428f607677a879d534de4f78ac14c49c)PerkResetEvent
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html)> TaleWorlds.CampaignSystem.CampaignEvents.PerkResetEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf8f0ab185f5c336e73316df6c18678b)PlayerTraitChangedEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int> TaleWorlds.CampaignSystem.CampaignEvents.PlayerTraitChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adfd0f835ff55919ec66d982fd888e5af)VillageStateChanged
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html), [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1), [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.VillageStateChanged | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6c9bf3112e3a13ee8e7529871a226a7a)SettlementEntered
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.SettlementEntered | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0ed1e0179433ebf368b75db672dd3469)AfterSettlementEntered
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.AfterSettlementEntered | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a03065460685381bfd697b7b3bcf1a273)BeforeSettlementEnteredEvent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.BeforeSettlementEnteredEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a48f2dec52e90c17d32ae30a21664e6c3)MercenaryTroopChangedInTown
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CampaignEvents.MercenaryTroopChangedInTown | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abae8c95530f8993e83cc79d13b63f4ba)MercenaryNumberChangedInTown
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), int, int> TaleWorlds.CampaignSystem.CampaignEvents.MercenaryNumberChangedInTown | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aacb3887b742d3934b9186c08be4d70a2)AlleyOwnerChanged
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.AlleyOwnerChanged | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa2ec6be7a63ae71f356f40ba8e0022d3)AlleyOccupiedByPlayer
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html), [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.AlleyOccupiedByPlayer | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a552ad72e88037811c8c28126fcf35c99)AlleyClearedByPlayer
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html)> TaleWorlds.CampaignSystem.CampaignEvents.AlleyClearedByPlayer | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8488b3598f4424bb1ae9044e39c6f05b)RomanticStateChanged
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Romance.RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a)> TaleWorlds.CampaignSystem.CampaignEvents.RomanticStateChanged | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a485df837bd35118b8c025aa9b1ab881f)BeforeHeroesMarried
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.BeforeHeroesMarried | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac0a90e800d603588b56a7d25892d2569)PlayerEliminatedFromTournament
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<int, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html)> TaleWorlds.CampaignSystem.CampaignEvents.PlayerEliminatedFromTournament | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1dd0814dc94faed5f85eb5604b21dc19)PlayerStartedTournamentMatch
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html)> TaleWorlds.CampaignSystem.CampaignEvents.PlayerStartedTournamentMatch | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae9778c30dc84bbcd7460abfeeaf04f0f)TournamentStarted
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html)> TaleWorlds.CampaignSystem.CampaignEvents.TournamentStarted | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af1a1e84b975afb05ccf5ab706ae5b1b6)WarDeclared
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4)> TaleWorlds.CampaignSystem.CampaignEvents.WarDeclared | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a15b1573ec151e5a88327f2f14ae0bdf9)TournamentFinished
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), MBReadOnlyList<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)>, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html)> TaleWorlds.CampaignSystem.CampaignEvents.TournamentFinished | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a060efef1a9e610332df313c47db319fe)TournamentCancelled
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html)> TaleWorlds.CampaignSystem.CampaignEvents.TournamentCancelled | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a64bc65119d6f36437c47a97180508e86)BattleStarted
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), object, bool> TaleWorlds.CampaignSystem.CampaignEvents.BattleStarted | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1f0a6cc44af5815dffd7fec82e07e294)RebellionFinished
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html)> TaleWorlds.CampaignSystem.CampaignEvents.RebellionFinished | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8db2ee48f999e1a299b948031ad70d4f)TownRebelliosStateChanged
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.TownRebelliosStateChanged | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9ae0727cd360e5593b023279f00eefbd)RebelliousClanDisbandedAtSettlement
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html)> TaleWorlds.CampaignSystem.CampaignEvents.RebelliousClanDisbandedAtSettlement | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aef1ae2b9a233391f4e4d1dee517f9333)ItemsLooted
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.ItemsLooted | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a54389bc1179244aafd2fdbdece515c57)MobilePartyDestroyed
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)> TaleWorlds.CampaignSystem.CampaignEvents.MobilePartyDestroyed | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2d521b51c4901f91519f3aeadae0dac7)MobilePartyCreated
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.MobilePartyCreated | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa22fd0e4fa31b57d4f637513f8859db2)MapInteractableCreated
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html)> TaleWorlds.CampaignSystem.CampaignEvents.MapInteractableCreated | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a495558b8f0e66a3fc5fe53a112f1f961)MapInteractableDestroyed
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html)> TaleWorlds.CampaignSystem.CampaignEvents.MapInteractableDestroyed | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2a69ee5c825be4d811c2b257a817fed5)MobilePartyQuestStatusChanged
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.MobilePartyQuestStatusChanged | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d3c7583d88bdc779907e67c3d078822)HeroKilledEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1), bool> TaleWorlds.CampaignSystem.CampaignEvents.HeroKilledEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad2baa67112011edd56d72c018437d257)BeforeHeroKilledEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1), bool> TaleWorlds.CampaignSystem.CampaignEvents.BeforeHeroKilledEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a92e964cfaa972f070733a49d512e65e4)ChildEducationCompletedEvent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int> TaleWorlds.CampaignSystem.CampaignEvents.ChildEducationCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#add930e60c75ede3e6b0d46bccb65c35d)HeroComesOfAgeEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.HeroComesOfAgeEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3bbb37569787d4cb6a94dc303b03f480)HeroGrowsOutOfInfancyEvent
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.HeroGrowsOutOfInfancyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa9c71c447f3dd50fc5bc99283e4ed0c6)HeroReachesTeenAgeEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.HeroReachesTeenAgeEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7a89dc091a0520b6e5de83ca6fdff937)CharacterDefeated
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.CharacterDefeated | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac6dd36b0951ac32ed67dd33e86bb5530)RulingClanChanged
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html)> TaleWorlds.CampaignSystem.CampaignEvents.RulingClanChanged | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae94f9b6c465680752f9fdd9bc23dbead)HeroPrisonerTaken
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.HeroPrisonerTaken | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a44779a8cf4d998690fcfba95caf623a8)HeroPrisonerReleased
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [EndCaptivityDetail](namespace_tale_worlds_1_1_campaign_system_1_1_actions.html#a6a6556b279f5fa0db2c5ae9a933508fe), bool> TaleWorlds.CampaignSystem.CampaignEvents.HeroPrisonerReleased | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3c41aaf1df00c2143a290c19fe75d07f)CharacterBecameFugitiveEvent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.CharacterBecameFugitiveEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abae9fe50a24d3f1fb5ebdfa46f9d9d76)OnPlayerMetHeroEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerMetHeroEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afb06edfb7ed8cbde3cf2786f1c495e90)OnPlayerLearnsAboutHeroEvent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerLearnsAboutHeroEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae9834f097b65ba9e5bfba571405aec6)RenownGained
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int, bool> TaleWorlds.CampaignSystem.CampaignEvents.RenownGained | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a93227f30fb31005ad307698f02450beb)CrimeRatingChanged
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), float> TaleWorlds.CampaignSystem.CampaignEvents.CrimeRatingChanged | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5cad4b4318758ec9450d6b1c5bf0cffe)NewCompanionAdded
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.NewCompanionAdded | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad7e7cb48c97a2fa2613382a2bac9aca5)AfterMissionStarted
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html)> TaleWorlds.CampaignSystem.CampaignEvents.AfterMissionStarted | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab885cd4b59102dfe3c8cf20f7f0dfce4)GameMenuOpened
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html)> TaleWorlds.CampaignSystem.CampaignEvents.GameMenuOpened | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acb0a3dbc1a81598b4f6ebf83d5f8cd12)AfterGameMenuInitializedEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html)> TaleWorlds.CampaignSystem.CampaignEvents.AfterGameMenuInitializedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aad32afcbaf408c3d3499db2711406b69)BeforeGameMenuOpenedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html)> TaleWorlds.CampaignSystem.CampaignEvents.BeforeGameMenuOpenedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a816083d0af781d9d641076375b94fce7)MakePeace
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), [MakePeaceAction.MakePeaceDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff)> TaleWorlds.CampaignSystem.CampaignEvents.MakePeace | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a73905ae7ece44f55e3483dde9a8f4b15)KingdomDestroyedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html)> TaleWorlds.CampaignSystem.CampaignEvents.KingdomDestroyedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abd9026d3f0326c1668ad43ef148d3434)CanKingdomBeDiscontinuedEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.CanKingdomBeDiscontinuedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab909d2a74ae9d5b59656dd4863b28487)KingdomCreatedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html)> TaleWorlds.CampaignSystem.CampaignEvents.KingdomCreatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acaf5b3f058c6ce4d4e4acc1b6442b5f4)VillageBecomeNormal
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html)> TaleWorlds.CampaignSystem.CampaignEvents.VillageBecomeNormal | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1234e034d5812666c795757f381f800e)VillageBeingRaided
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html)> TaleWorlds.CampaignSystem.CampaignEvents.VillageBeingRaided | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abeeda638cc5a1066a61dd02d911a1593)VillageLooted
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html)> TaleWorlds.CampaignSystem.CampaignEvents.VillageLooted | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa68c8f427c476978f589febc66cf5fa7)CompanionRemoved
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [RemoveCompanionAction.RemoveCompanionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_remove_companion_action.html#afebe445a9fd9044486e94c0db1b931ef)> TaleWorlds.CampaignSystem.CampaignEvents.CompanionRemoved | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab6188eadb0a76df9a23882190ae33eb8)OnAgentJoinedConversationEvent
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnAgentJoinedConversationEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a13c97ad056c9ee5163038308a80662dd)ConversationEnded
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<IEnumerable<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> > TaleWorlds.CampaignSystem.CampaignEvents.ConversationEnded | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3bcca05fb29cfa6edd153d076a1df349)MapEventEnded
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html)> TaleWorlds.CampaignSystem.CampaignEvents.MapEventEnded | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1491c1570929bf8e7131e7349ef952da)MapEventStarted
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)> TaleWorlds.CampaignSystem.CampaignEvents.MapEventStarted | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a53093d0fb9908b44d90935ab01626706)PrisonersChangeInSettlement
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.PrisonersChangeInSettlement | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4e06aef0a63378c78f39e7d2b1d7c08b)OnPlayerBoardGameOverEvent
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [BoardGameHelper.BoardGameState](class_helpers_1_1_board_game_helper.html#ab045b68fb522a41152b0557241b92db2)> TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerBoardGameOverEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab83c349fc55f1b91e8e2cbc301a1158a)OnRansomOfferedToPlayerEvent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnRansomOfferedToPlayerEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afd05e6441c197eb3de1188d1417a9349)OnRansomOfferCancelledEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnRansomOfferCancelledEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8cb7bb3a458f057de0dcb65bef7df35f)OnPeaceOfferedToPlayerEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html), int, int> TaleWorlds.CampaignSystem.CampaignEvents.OnPeaceOfferedToPlayerEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adc42be1efe3610c921c430aadbbed305)OnTradeAgreementSignedEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnTradeAgreementSignedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6ccd8c6205264a320bc6f22ac13d02da)OnPeaceOfferResolvedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPeaceOfferResolvedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a48caab761fda1471b37c73679a171ca9)OnMarriageOfferedToPlayerEvent
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMarriageOfferedToPlayerEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a55bef7773df4996f99fa805ea98496e4)OnMarriageOfferCanceledEvent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMarriageOfferCanceledEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a83f433927cb905f85a11dfc4d4de4fbd)OnVassalOrMercenaryServiceOfferedToPlayerEvent
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnVassalOrMercenaryServiceOfferedToPlayerEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9f6599c29f5f9326ebab57331b011fb2)OnVassalOrMercenaryServiceOfferCanceledEvent
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnVassalOrMercenaryServiceOfferCanceledEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab68857d7022e8667155ab313e2119735)OnMercenaryServiceStartedEvent
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), [StartMercenaryServiceAction.StartMercenaryServiceActionDetails](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_start_mercenary_service_action.html#a5861e61ec787655431332d6abb63721a)> TaleWorlds.CampaignSystem.CampaignEvents.OnMercenaryServiceStartedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a824c1d3f960bf7194646fe68f163d107)OnMercenaryServiceEndedEvent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), EndMercenaryServiceAction.EndMercenaryServiceActionDetails> TaleWorlds.CampaignSystem.CampaignEvents.OnMercenaryServiceEndedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5654d6a5d11c00c9579b110fd0fa3860)OnMissionStartedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMissionStartedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a21356a3516c2b96f3fef334bd097fe5c)BeforeMissionOpenedEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.BeforeMissionOpenedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a57b6011136068e9f94c4347ac85ccd3f)OnPartyRemovedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartyRemovedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abfaea6ad7af28ed82ad0611161e4622b)OnPartySizeChangedEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartySizeChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad0d22f83e3fca4724c519554fdcb33ba)OnSettlementOwnerChangedEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), bool, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail> TaleWorlds.CampaignSystem.CampaignEvents.OnSettlementOwnerChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2728b284cb144c59c380a2c4259a218a)OnGovernorChangedEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnGovernorChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a87609d48cf8393d47f9f7a9718c38a49)OnSettlementLeftEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnSettlementLeftEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad92ba75ccc453955d866191d0b80bd15)WeeklyTickEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.WeeklyTickEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a066faf3d0b292fca2e7a0ab91a34f125)DailyTickEvent
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.DailyTickEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a61d8c50e12c34c81549dcda6337cda50)DailyTickPartyEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.DailyTickPartyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a07041b4e18de0e0e95cc6d8b4c2fa80a)DailyTickTownEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html)> TaleWorlds.CampaignSystem.CampaignEvents.DailyTickTownEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5c4539a696383f54e6188b231a974e8e)DailyTickSettlementEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.CampaignEvents.DailyTickSettlementEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a52a5a55e39fccc096eddfed384d06b5b)DailyTickHeroEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.DailyTickHeroEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a50e81d38dc860d12fe144cfd0b37ada1)DailyTickClanEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html)> TaleWorlds.CampaignSystem.CampaignEvents.DailyTickClanEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5a01801a80a76493a9ab21737e05aeb4)CollectAvailableTutorialsEvent
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<List<[CampaignTutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign_tutorial.html)> > TaleWorlds.CampaignSystem.CampaignEvents.CollectAvailableTutorialsEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab05f157f2e15907601d9997add503c73)OnTutorialCompletedEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<string> TaleWorlds.CampaignSystem.CampaignEvents.OnTutorialCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a500b6301048d5a4d2f9442529751308b)OnBuildingLevelChangedEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html), int> TaleWorlds.CampaignSystem.CampaignEvents.OnBuildingLevelChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2a19b3ca69ed2fd20e485b1b864a4a53)HourlyTickEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.HourlyTickEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9c9646e6cedbd25d1170fc81fd7f58a8)QuarterHourlyTickEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.QuarterHourlyTickEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8fd96077bf0e9737ab7ea2fc1579a74f)HourlyTickPartyEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.HourlyTickPartyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6a0560482f519a235083fe554967a817)HourlyTickSettlementEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.CampaignEvents.HourlyTickSettlementEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a359c8d390a29996234c4a38a46058de8)HourlyTickClanEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html)> TaleWorlds.CampaignSystem.CampaignEvents.HourlyTickClanEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab2974617aac83f71805192f8227ef14e)TickEvent
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<float> TaleWorlds.CampaignSystem.CampaignEvents.TickEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5ee11ba5d377f63277221fd1a0e1c030)OnSessionLaunchedEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnSessionLaunchedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a629159e395397cf761a2ac8e330aa1f0)OnAfterSessionLaunchedEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnAfterSessionLaunchedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5c23c0363387d0587d28adce3be40248)OnNewGameCreatedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnNewGameCreatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab7fd1042b69bab2a30b9e9f504de7079)OnNewGameCreatedPartialFollowUpEvent
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html), int> TaleWorlds.CampaignSystem.CampaignEvents.OnNewGameCreatedPartialFollowUpEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9f3298b0f5b30d037bf7823a46c4ac1c)OnNewGameCreatedPartialFollowUpEndEvent
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnNewGameCreatedPartialFollowUpEndEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a97d860be04c5d325e8d18a308983599f)OnGameEarlyLoadedEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnGameEarlyLoadedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a03892d3dc4740993e0241392f4af16c2)OnGameLoadedEvent
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnGameLoadedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aca967a298cd5acc2f86a3a526588cd12)OnGameLoadFinishedEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.OnGameLoadFinishedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae9e658b3c0a235b5492dae4714c1e4ea)AiHourlyTickEvent
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html)> TaleWorlds.CampaignSystem.CampaignEvents.AiHourlyTickEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a58e2517b783134252055d814699dc611)TickPartialHourlyAiEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.TickPartialHourlyAiEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a70e7828fcda35eb50745b0cc6b059003)OnPartyJoinedArmyEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartyJoinedArmyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa89220dbb6480b1cd4aecea55ad2f82e)PartyRemovedFromArmyEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.PartyRemovedFromArmyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab4a563cb88b4a584a5533f25e9383e69)OnPlayerArmyLeaderChangedBehaviorEvent
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerArmyLeaderChangedBehaviorEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab8faeb0ef57b59482041119013fec86c)OnMissionEndedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMissionEndedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9048c300efecad97dcb2e4a4d6326189)OnQuarterDailyPartyTick
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnQuarterDailyPartyTick | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0ff4dd920dd09ad4db14f456dac2449e)OnPlayerBattleEndEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerBattleEndEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4d406aa6a19e39f73a649dbc23ddcc05)OnUnitRecruitedEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), int> TaleWorlds.CampaignSystem.CampaignEvents.OnUnitRecruitedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae911b46330d8703e353ead91548e11c3)OnChildConceivedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnChildConceivedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a341713630b40d7a29a540bf6d61518c2)OnGivenBirthEvent
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), List<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)>, int> TaleWorlds.CampaignSystem.CampaignEvents.OnGivenBirthEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3450cd6dd2838ad53621f1f95e5d3e54)MissionTickEvent
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<float> TaleWorlds.CampaignSystem.CampaignEvents.MissionTickEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abd1dc3751d3beb0df47a854f8b88307e)ArmyOverlaySetDirtyEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.ArmyOverlaySetDirtyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad39accc22262f503a417754e23073e0c)PlayerDesertedBattleEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<int> TaleWorlds.CampaignSystem.CampaignEvents.PlayerDesertedBattleEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0cea7baaa82c5578b9253eec3c1a20ee)PartyVisibilityChangedEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)> TaleWorlds.CampaignSystem.CampaignEvents.PartyVisibilityChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a63b5cb4af264251c2efab469b3c09c33)TrackDetectedEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Track](class_tale_worlds_1_1_campaign_system_1_1_track.html)> TaleWorlds.CampaignSystem.CampaignEvents.TrackDetectedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a31464bac5819dab4d9fc0153f6f0b367)TrackLostEvent
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Track](class_tale_worlds_1_1_campaign_system_1_1_track.html)> TaleWorlds.CampaignSystem.CampaignEvents.TrackLostEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a839bfe8ac2f31027b87a48e0fc51f9e4)LocationCharactersAreReadyToSpawnEvent
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<Dictionary<string, int> > TaleWorlds.CampaignSystem.CampaignEvents.LocationCharactersAreReadyToSpawnEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7e2a1d1e69cf932d5e8ba082bbcd7541)BeforePlayerAgentSpawnEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)> TaleWorlds.CampaignSystem.CampaignEvents.BeforePlayerAgentSpawnEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af54f32656f86c6abdc3abbfbfca81b0f)PlayerAgentSpawned
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.PlayerAgentSpawned | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad078d25f679c8015ea96611c477af8ab)LocationCharactersSimulatedEvent
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.LocationCharactersSimulatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a797d821cadbb97099612fed725c1515e)PlayerUpgradedTroopsEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), int> TaleWorlds.CampaignSystem.CampaignEvents.PlayerUpgradedTroopsEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af87433e986da270a81c1e88dbf67c659)OnHeroCombatHitEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html), bool, int> TaleWorlds.CampaignSystem.CampaignEvents.OnHeroCombatHitEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab768a04d3190377df2a4c944dcab4389)CharacterPortraitPopUpOpenedEvent
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CampaignEvents.CharacterPortraitPopUpOpenedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa9063ebaebcba0f8b4546ea72bf616f8)CharacterPortraitPopUpClosedEvent
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.CharacterPortraitPopUpClosedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a856ad2625223fb8f21569b60abae531b)PlayerStartTalkFromMenu
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.PlayerStartTalkFromMenu | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3fb1b347cc97782b1b557ff4e8d57528)GameMenuOptionSelectedEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html), [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html)> TaleWorlds.CampaignSystem.CampaignEvents.GameMenuOptionSelectedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acd65cf6a26c823d8d8fef2d4533cb8c6)PlayerStartRecruitmentEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CampaignEvents.PlayerStartRecruitmentEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a097e2592bc829e4d0d479d13afc7e263)OnBeforePlayerCharacterChangedEvent
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnBeforePlayerCharacterChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a497575a8fdd7764b36fff8ed35f94657)OnPlayerCharacterChangedEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerCharacterChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ade76694211cb6f779eec06cb963ff970)OnClanLeaderChangedEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnClanLeaderChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abd87d6f3c431e56a3b636baa86166fe3)OnSiegeEventStartedEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeEventStartedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a50da30bd86409f0796dd71c13c7f0e65)OnPlayerSiegeStartedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerSiegeStartedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2ea483de37fdecc7eec05c77c7f64207)OnSiegeEventEndedEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeEventEndedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afb94ca0b51ef8de99f9629938b515235)OnSiegeAftermathAppliedEvent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), SiegeAftermathAction.SiegeAftermath, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), Dictionary<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), float> > TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeAftermathAppliedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acb769424f15f8410e1f15d922ef91eba)OnSiegeBombardmentHitEvent
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html), [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6)> TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeBombardmentHitEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a119f56b7e3f02540351a5259ad55cfc5)OnSiegeBombardmentWallHitEvent
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeBombardmentWallHitEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a234ef9f756de1681155c00f80420b321)OnSiegeEngineDestroyedEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnSiegeEngineDestroyedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1555beba967349b48cf56e1f47da6dd2)OnTradeRumorIsTakenEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<List<[TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html)>, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnTradeRumorIsTakenEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a01a6b22c2c7472898a08fb78bcab3a21)OnCheckForIssueEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnCheckForIssueEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a80467ac21b21088cacd4a8bdc106f891)OnIssueUpdatedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html), [IssueBase.IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnIssueUpdatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7322fe1666b2b3816eaf118cca5321a0)OnTroopsDesertedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnTroopsDesertedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af13bb39b5da4ee47a6372e32057ad18f)OnTroopRecruitedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), int> TaleWorlds.CampaignSystem.CampaignEvents.OnTroopRecruitedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac42516364965b571c7afb3d56e89b45f)OnTroopGivenToSettlementEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnTroopGivenToSettlementEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a25801cee0676736fc87b21f06e80a4ab)OnItemSoldEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnItemSoldEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6254b7d43c35b02577672f714b9d6086)OnCaravanTransactionCompletedEvent
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), List<ValueTuple<[EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), int> > > TaleWorlds.CampaignSystem.CampaignEvents.OnCaravanTransactionCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a895be247cd0895818b624887f8d8224e)OnPrisonerSoldEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPrisonerSoldEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a207a3e5846c3f30fee3dce62c1600bad)OnPartyDisbandStartedEvent
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartyDisbandStartedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a186ef8cd3395f0a44e620a78f5c705db)OnPartyDisbandedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartyDisbandedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae680916f05e0afc35ff6f8aa9f359728)OnPartyDisbandCanceledEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartyDisbandCanceledEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac05060383b368f06e08a8cfc6d0ed9ae)OnHideoutSpottedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnHideoutSpottedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa9a9f9f2e2fd395164aff62ad360d943)OnHideoutDeactivatedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnHideoutDeactivatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2f88fe33c351220926946cfac3573ba1)OnHeroSharedFoodWithAnotherHeroEvent
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), float> TaleWorlds.CampaignSystem.CampaignEvents.OnHeroSharedFoodWithAnotherHeroEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aac978338ca29008cc568954abe8b6e40)PlayerInventoryExchangeEvent
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<List<ValueTuple<[ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int> >, List<ValueTuple<[ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int> >, bool> TaleWorlds.CampaignSystem.CampaignEvents.PlayerInventoryExchangeEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a825390397cc74bb4301b0ed18194ec8c)OnItemsDiscardedByPlayerEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnItemsDiscardedByPlayerEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a79eb2671ba7fe478034d1c8b29e4edd0)PersuasionProgressCommittedEvent
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<Tuple<[PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1)> > TaleWorlds.CampaignSystem.CampaignEvents.PersuasionProgressCommittedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a09a33735fd11f1f8f54a97e28f759010)OnQuestCompletedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html), [QuestBase.QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398)> TaleWorlds.CampaignSystem.CampaignEvents.OnQuestCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abab4f68227bf312bc85a37504586212a)OnQuestStartedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnQuestStartedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a69f4e296934352fe960af79984dc1937)OnItemProducedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), int> TaleWorlds.CampaignSystem.CampaignEvents.OnItemProducedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a282254bd2529838a06fc38407f40b633)OnItemConsumedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), int> TaleWorlds.CampaignSystem.CampaignEvents.OnItemConsumedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad0f51ba7872aab1b6a3f435de1ec16c0)OnPartyConsumedFoodEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartyConsumedFoodEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a094bc0a9c56683d9757cac0b3a2c41c7)OnBeforeMainCharacterDiedEvent
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1), bool> TaleWorlds.CampaignSystem.CampaignEvents.OnBeforeMainCharacterDiedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a287db6fe6299e56f0688d164b824e6cb)OnNewIssueCreatedEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnNewIssueCreatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a39f6b898d19f9b59db5cbed4fa94d903)OnIssueOwnerChangedEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnIssueOwnerChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a071ac25ad20ccfced8863416f98c7799)OnGameOverEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.OnGameOverEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa7ea9a3c8053af0371c81c822058c5c3)SiegeCompletedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), bool, BattleTypes> TaleWorlds.CampaignSystem.CampaignEvents.SiegeCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a49599fe0346fc04ec2300d49f922642e)AfterSiegeCompletedEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), bool, BattleTypes> TaleWorlds.CampaignSystem.CampaignEvents.AfterSiegeCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ade51289135a8ca5f91258d494428641a)SiegeEngineBuiltEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html), [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html)> TaleWorlds.CampaignSystem.CampaignEvents.SiegeEngineBuiltEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a92a991dde48352ed233b8f92dc3c6f84)RaidCompletedEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html)> TaleWorlds.CampaignSystem.CampaignEvents.RaidCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3dbbabaf237cbdddea98e892be0ba928)ForceVolunteersCompletedEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html)> TaleWorlds.CampaignSystem.CampaignEvents.ForceVolunteersCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a31c01242471a9273285242c3759880cb)ForceSuppliesCompletedEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html)> TaleWorlds.CampaignSystem.CampaignEvents.ForceSuppliesCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a185655f612325873cb9eef7cf2083e9c)OnHideoutBattleCompletedEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MbEvent](class_tale_worlds_1_1_campaign_system_1_1_mb_event.html)<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c), [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnHideoutBattleCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7c1fb0527dc20ce943a0acb34dfff6fb)OnClanDestroyedEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnClanDestroyedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a03c699a01be31c653f2bdefc378fcbc7)OnNewItemCraftedEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.OnNewItemCraftedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa550eddc1f332789dfa795d0e3e9e7a4)CraftingPartUnlockedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html)> TaleWorlds.CampaignSystem.CampaignEvents.CraftingPartUnlockedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6331cae3f95db8da3ed38eb78b3c00c8)WorkshopInitializedEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html)> TaleWorlds.CampaignSystem.CampaignEvents.WorkshopInitializedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad9a81685ebaea7ce36a2f1b451dc8c7f)WorkshopOwnerChangedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.WorkshopOwnerChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab62b40f5f9af044e4db02c0a687905ab)WorkshopTypeChangedEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html)> TaleWorlds.CampaignSystem.CampaignEvents.WorkshopTypeChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad6c8036e5e7cae687f324e71e52af0d9)OnBeforeSaveEvent
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.OnBeforeSaveEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a333958b453f308d13d0d2e7585f63d0b)OnSaveStartedEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.OnSaveStartedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae157d5c4b7656368a26f086a12c56b07)OnSaveOverEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<bool, string> TaleWorlds.CampaignSystem.CampaignEvents.OnSaveOverEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5110df9c7a1128714a6bea1d7d67e02a)OnPrisonerTakenEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPrisonerTakenEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a55f4f63635306715ca115c7fb735c037)OnPrisonerReleasedEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPrisonerReleasedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abb38ee0b53ba04a625d5e6fad5b2a3c8)OnMainPartyPrisonerRecruitedEvent
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMainPartyPrisonerRecruitedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2b8315824f27d0d67f00043529cf857f)OnPrisonerDonatedToSettlementEvent
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPrisonerDonatedToSettlementEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aed634ba9aa360544c1be6ec697fab14d)OnEquipmentSmeltedByHeroEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnEquipmentSmeltedByHeroEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac2d140031b82d819987b6f892d5868a7)OnPlayerTradeProfitEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<int> TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerTradeProfitEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a057facab3c46ab9387c661d01f918918)OnHeroChangedClanEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnHeroChangedClanEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aebc4adc290910501823c6ff791f7a422)OnHeroGetsBusyEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [HeroGetsBusyReasons](namespace_tale_worlds_1_1_campaign_system.html#a74f96a6c3de3af13ac985228276ee611)> TaleWorlds.CampaignSystem.CampaignEvents.OnHeroGetsBusyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7eafc4dbc1f08f8c738c360b09cbb031)OnCollectLootsItemsEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnCollectLootsItemsEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0aca18fad12145da4ecc1c20b56a9a16)OnLootDistributedToPartyEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnLootDistributedToPartyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a367293e0c0db810d0fa94e3747957eff)OnHeroTeleportationRequestedEvent
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [TeleportHeroAction.TeleportationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90)> TaleWorlds.CampaignSystem.CampaignEvents.OnHeroTeleportationRequestedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4cdca1a168aca8735bd6bb0730f2a57d)OnPartyLeaderChangeOfferCanceledEvent
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartyLeaderChangeOfferCanceledEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a60a9fa24fb29fb638455b2369dc16ca3)OnPartyLeaderChangedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartyLeaderChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5f54524fd19bcaebd06990efbba7994e)OnClanInfluenceChangedEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), float> TaleWorlds.CampaignSystem.CampaignEvents.OnClanInfluenceChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a25e3c005297b576634ec957f5777d474)OnPlayerPartyKnockedOrKilledTroopEvent
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerPartyKnockedOrKilledTroopEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afae0875e0e0a99529e4a8a2c56333e28)OnPlayerEarnedGoldFromAssetEvent
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[GameComponents.DefaultClanFinanceModel.AssetIncomeType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50), int> TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerEarnedGoldFromAssetEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af1724f0c74e943fc6200f57f47a2eba1)OnClanEarnedGoldFromTributeEvent
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html), [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnClanEarnedGoldFromTributeEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abc5da03d813b463a36b171b33e8e9e75)OnMainPartyStarvingEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.OnMainPartyStarvingEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad0970852e5926e408593b757584b295e)OnPlayerJoinedTournamentEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.OnPlayerJoinedTournamentEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1375e1e0914507665e06f8d5180ace14)OnHeroUnregisteredEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnHeroUnregisteredEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9a738099c91a8f90548633aa4f8a3de8)OnConfigChangedEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html) TaleWorlds.CampaignSystem.CampaignEvents.OnConfigChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5de0256ab71a7ff710bd614e77f5b8cf)OnCraftingOrderCompletedEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html), [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnCraftingOrderCompletedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1d879b26d589d66e80d7ca3f1ead12b6)OnItemsRefinedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), RefiningFormula> TaleWorlds.CampaignSystem.CampaignEvents.OnItemsRefinedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afa077daf071c418eab12230d20d4bac4)OnHeirSelectionRequestedEvent
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<Dictionary<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int> > TaleWorlds.CampaignSystem.CampaignEvents.OnHeirSelectionRequestedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad7f74dc7a8271a506fd189905dd81946)OnHeirSelectionOverEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnHeirSelectionOverEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa35b2507b89abb114fc1359ef1dc324d)OnCharacterCreationInitializedEvent
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnCharacterCreationInitializedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af254eb6374015082095863dda0ac2333)OnMobilePartyRaftStateChangedEvent
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyRaftStateChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adb32a2c07a24e97f81f2ea1b7d8f092b)OnShipDestroyedEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [DestroyShipAction.ShipDestroyDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_destroy_ship_action.html#a52f9b7dcd67d7a49fc241de25137f7d1)> TaleWorlds.CampaignSystem.CampaignEvents.OnShipDestroyedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a814be86e81d4618a25d065db79b23aac)OnShipOwnerChangedEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), [ChangeShipOwnerAction.ShipOwnerChangeDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f)> TaleWorlds.CampaignSystem.CampaignEvents.OnShipOwnerChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8f5186c4e76714152747c6adbead88fe)OnShipRepairedEvent
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnShipRepairedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8b785eb97cb85165c4850f32ed365e54)OnShipCreatedEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnShipCreatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae78a412c4b30c96b86472e67fdb9178a)OnFigureheadUnlockedEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnFigureheadUnlockedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad2665539b2f01573edb6da4f2d0b86a4)OnPartyLeftArmyEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartyLeftArmyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4f214e71db4dee98b70d092de6c1f2ec)OnPartyAddedToMapEventEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnPartyAddedToMapEventEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad19e6337460316aa0bcdd286b201c4a3)OnIncidentResolvedEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnIncidentResolvedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a710728006df5b2a3be80ed54995a019e)OnMobilePartyNavigationStateChangedEvent
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyNavigationStateChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaa63005a136a6895c161c419a0ec3f72)OnMobilePartyJoinedToSiegeEventEvent
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyJoinedToSiegeEventEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af34c3f93bed3d19ad97ec6b78e2a0214)OnMobilePartyLeftSiegeEventEvent
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMobilePartyLeftSiegeEventEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4313d61f135bdd3180796ca03f855f6f)OnBlockadeActivatedEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnBlockadeActivatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1ec96878082b4097b9877d9424ff6780)OnBlockadeDeactivatedEvent
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnBlockadeDeactivatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a59c94835300f26a8b4f84d0a8f629819)OnMapMarkerCreatedEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMapMarkerCreatedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abba96681abfade7eb86ddaa672374fc4)OnMapMarkerRemovedEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMapMarkerRemovedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf77aaadd15f411c1b926744586bffc9)OnAllianceStartedEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnAllianceStartedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a28c617382a9befd3cdf44f5d76ad5692)OnAllianceEndedEvent
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnAllianceEndedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa713b74e92b3cef121a8a82061d187a9)OnCallToWarAgreementStartedEvent
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnCallToWarAgreementStartedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac73358481ec88b5fcee934b37bfd83e1)OnCallToWarAgreementEndedEvent
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnCallToWarAgreementEndedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac924ee60d3ad21559733b7dc46ba7c2d)CanHeroLeadPartyEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.CanHeroLeadPartyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaa585af947147ea4a8215398cb4d752b)CanHeroMarryEvent
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.CanHeroMarryEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a75f3b1b892212ff1ffb82f77f3cb76d6)CanHeroEquipmentBeChangedEvent
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.CanHeroEquipmentBeChangedEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af87529c77c5ae9f2d5b4f47d00fdacf1)CanBeGovernorOrHavePartyRoleEvent
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.CanBeGovernorOrHavePartyRoleEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a090f92b9f3e92a2f8cd645dfed59bb64)CanHeroDieEvent
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1), bool> TaleWorlds.CampaignSystem.CampaignEvents.CanHeroDieEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afec442e33315c0bbbb3a29c6d439408f)CanPlayerMeetWithHeroAfterConversationEvent
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.CanPlayerMeetWithHeroAfterConversationEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abe4807c3a2e5e8e66e0b0e00e4e30f2e)CanHeroBecomePrisonerEvent
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.CanHeroBecomePrisonerEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a52068cb387fd9809219d97c7464d8df9)CanMoveToSettlementEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.CanMoveToSettlementEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa7e28c44562134487d0d7ad7d9a5cda7)CanHaveCampaignIssuesEvent
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), bool> TaleWorlds.CampaignSystem.CampaignEvents.CanHaveCampaignIssuesEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a60ba123762f773949b5973e7311a7c9a)IsSettlementBusyEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReferenceIMBEvent<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), object, int> TaleWorlds.CampaignSystem.CampaignEvents.IsSettlementBusyEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa54ee3a048dbeca5d589eb63556b1b26)OnMapEventContinuityNeedsUpdateEvent
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMbEvent](interface_tale_worlds_1_1_campaign_system_1_1_i_mb_event.html)<[IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html)> TaleWorlds.CampaignSystem.CampaignEvents.OnMapEventContinuityNeedsUpdateEvent | | staticget |

