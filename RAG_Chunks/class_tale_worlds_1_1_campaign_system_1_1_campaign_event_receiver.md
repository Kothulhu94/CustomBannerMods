--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html ---

TaleWorlds.CampaignSystem.CampaignEventReceiver Class ReferenceabstractInherited by [StoryMode.StoryModeEvents](class_story_mode_1_1_story_mode_events.html), [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual void | [RemoveListeners](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a30c010ec60d81a1f6cbf2317efd3ddeb) (Object o) |
| virtual void | [OnCharacterCreationIsOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8d7323ebc7d38c26760126df4427a633) () |
| virtual void | [OnHeroLevelledUp](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab566f030c822fd4cbb09513a4d2836bb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool shouldNotify=true) |
| virtual void | [OnHomeHideoutChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af54816c97132e599daecf0afd69e4288) ([BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html) banditPartyComponent, [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) oldHomeHideout) |
| virtual void | [OnHeroGainedSkill](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a774dde909dfe3a56e5f1f2855f37291d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int change=1, bool shouldNotify=true) |
| virtual void | [OnHeroCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a05e630443f776a6c1b9f9612cec60031) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isBornNaturally=false) |
| virtual void | [OnHeroWounded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a625e18d200941d39c69344d5b9433c2c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) woundedHero) |
| virtual void | [OnHeroRelationChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0847916b31147173736364528ec6ee49) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) effectiveHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) effectiveHeroGainedRelationWith, int relationChange, bool showNotification, [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) detail, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) originalHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) originalGainedRelationWith) |
| virtual void | [OnQuestLogAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a498dd4bb8db0b0f9764c5d430d6698a4) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest, bool hideInformation) |
| virtual void | [OnIssueLogAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add0408270dc933a0bac52deb7ca20058) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue, bool hideInformation) |
| virtual void | [OnClanTierChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab2e5269e3afaf90afacf70f862b6e846) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool shouldNotify=true) |
| virtual void | [OnClanChangedKingdom](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a015a602a70828d9e92b571cf5a1e1ca8) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) oldKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom, [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) actionDetail, bool showNotification=true) |
| virtual void | [OnClanDefected](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abc55047e4785adff779e0754451ea424) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) oldKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) newKingdom) |
| virtual void | [OnClanCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af7e7a45cbeaede6021ed4fbcf0eb5b0e) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, bool isCompanion) |
| virtual void | [OnHeroJoinedParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad7dcc8181382dbe9b9e0dd0439ef3586) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnKingdomDecisionAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9a8a4e5a1b7331d9873402430fdad319) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, bool isPlayerInvolved) |
| virtual void | [OnKingdomDecisionCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab405f44fe4a5bbe5c430afe873f6211f) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, bool isPlayerInvolved) |
| virtual void | [OnKingdomDecisionConcluded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a45c01f7262fea33c04e71f7a6404348b) ([KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) decision, [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) chosenOutcome, bool isPlayerInvolved) |
| virtual void | [OnHeroOrPartyTradedGold](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7ba4f835d34bde173d96329691e9c921) (ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > giver, ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > recipient, ValueTuple< int, string > goldAmount, bool showNotification) |
| virtual void | [OnHeroOrPartyGaveItem](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aefec55dd3f5ebe48fe1131de64f2724c) (ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > giver, ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > receiver, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, bool showNotification) |
| virtual void | [OnBanditPartyRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6d5c54c4922af962519c94d697da6a61) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) banditParty) |
| virtual void | [OnArmyCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae5c7c8c0623112a24b92f45775da9ef3) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army) |
| virtual void | [OnPartyAttachedAnotherParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a70e9cf8fa0db1f683469486d17370def) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnNearbyPartyAddedToPlayerMapEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa4aa33f9b5a7fa4fd152926e525c3bee) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnArmyDispersed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add2840f58e65bb5718ccdef8d8cdbb36) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, [Army.ArmyDispersionReason](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798) reason, bool isPlayersArmy) |
| virtual void | [OnArmyGathered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a54baf1826c91309838e376e75e57d9ef) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) gatheringPoint) |
| virtual void | [OnPerkOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aee81305bf3166d5e570ee5ecfe9b10a5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| virtual void | [OnPerkReset](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a46d6825fd7135c94d5c46b61af4da22b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| virtual void | [OnPlayerTraitChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae3c7084a4ba93a0cb9c43b54cc86f682) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int previousLevel) |
| virtual void | [OnVillageStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaaf549d05ae27a9de85ea15be155974d) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village, [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) oldState, [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) newState, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) raiderParty) |
| virtual void | [OnSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34a08aad1b66ef9fb1a0f77377041c80) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnAfterSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a81b5ae8709aa37f1ab97f244d5b4299c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnBeforeSettlementEntered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5cb188b4bddbe0e32a602eb89339ff08) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnMercenaryTroopChangedInTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a19f1714761ef9137b2a09c004880fdb7) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) oldTroopType, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) newTroopType) |
| virtual void | [OnMercenaryNumberChangedInTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afdeef75c68facf73a9a3da673fa64120) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, int oldNumber, int newNumber) |
| virtual void | [OnAlleyOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a12183794116453d1920425fb1a0f1c06) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner) |
| virtual void | [OnAlleyClearedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a94cecba044b9fb6b1d496718937aac6a) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| virtual void | [OnAlleyOccupiedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afb1c1846367ec6cb096c523dfeb75de8) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troops) |
| virtual void | [OnRomanticStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4ef69fd2052fed76b92492482b0d23a0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2, [Romance.RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) romanceLevel) |
| virtual void | [OnBeforeHeroesMarried](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a98d83294d0cc4c5c2829b5927310a925) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero1, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero2, bool showNotification=true) |
| virtual void | [OnPlayerEliminatedFromTournament](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a467f012c0ebec2f57b4eee9a0817136d) (int round, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| virtual void | [OnPlayerStartedTournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad65f3efd3ce650f123b8b20af29dbb2c) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| virtual void | [OnTournamentStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9d5972dfefb563fbd011cd2ff86dba72) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| virtual void | [OnTournamentFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab8a512aebcd7550547be2484477c7673) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) winner, MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > participants, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) prize) |
| virtual void | [OnTournamentCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a75f25270c3a7cc08c1a6b56c162cdbf0) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| virtual void | [OnWarDeclared](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1b454dafed5b1da0d3f7a16c142d6e72) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2, [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) declareWarDetail) |
| virtual void | [OnMakePeace](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0dcc68b946f5ceae0cd2f58f1f481bb6) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) side1Faction, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) side2Faction, [MakePeaceAction.MakePeaceDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff) detail) |
| virtual void | [OnKingdomCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae1182810cffabe7c541cf67f0244f80b) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) createdKingdom) |
| virtual void | [OnHeroOccupationChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a48aad6e8dbaf5703c46f3f2b374b9e9f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) oldOccupation) |
| virtual void | [OnKingdomDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af1717c6abfcbe84e0ac4565e1c2c8bc8) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| virtual void | [CanKingdomBeDiscontinued](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aeb013b5c5589e8980415990498ed4f3b) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, ref bool result) |
| virtual void | [OnBarterAccepted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a20f5223478e91a352f32b5d91df3f215) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offererHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > barters) |
| virtual void | [OnBarterCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7260af52532867d6d7a01fbb516c3d07) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offererHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) otherHero, List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > barters) |
| virtual void | [OnStartBattle](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afc6415a7dc758250a8adbac387f47004) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty, object subject, bool showNotification) |
| virtual void | [OnRebellionFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4c33911e4f68d8fb63b050d631bcc971) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) oldOwnerClan) |
| virtual void | [TownRebelliousStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af983512cf4a2250654d6f68d52cf8139) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool rebelliousState) |
| virtual void | [OnRebelliousClanDisbandedAtSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adca45c31fb5767cbaebd49fbc00f2af2) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| virtual void | [OnItemsLooted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2413d12700d18aea5d789566410076e2) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) items) |
| virtual void | [OnMobilePartyDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a83399ccb5af654bc810e1aa3695d73d2) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) destroyerParty) |
| virtual void | [OnMobilePartyCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae1a37302077e16224eae7622c70eddda) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| virtual void | [OnMapInteractableCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1ae04e92878f6098c97dd286e249fce0) ([IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) interactable) |
| virtual void | [OnMapInteractableDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3a06afc7142607764857ef5970c16cc3) ([IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) interactable) |
| virtual void | [OnMobilePartyQuestStatusChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae19e20a00d6fad6f78d25ffa08109bfd) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool isUsedByQuest) |
| virtual void | [OnHeroKilled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0bac5bea643a360776c14acb7b0f5291) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool showNotification=true) |
| virtual void | [OnBeforeHeroKilled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a725002864af0aa2a629f3d5448677172) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool showNotification=true) |
| virtual void | [OnChildEducationCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a11f91f90e077f050c33d67866c3e83aa) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int age) |
| virtual void | [OnHeroComesOfAge](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#addab04c615c3a47008e02cdac4ee9493) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnHeroReachesTeenAge](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4a1f249bacb71890d0e93146a43cf659) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnHeroGrowsOutOfInfancy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac9334bcdd529dc13fbd707f9b9dff547) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnCharacterDefeated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac22e666e7df0a779a3063af689a1f957) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) loser) |
| virtual void | [OnHeroPrisonerTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f4366bdf2d5ed8f40840385ca8c4f0c) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) capturer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisoner) |
| virtual void | [OnHeroPrisonerReleased](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afa8773a1e419eb74dcfcf1f42bccda00) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisoner, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) capturerFaction, [EndCaptivityDetail](namespace_tale_worlds_1_1_campaign_system_1_1_actions.html#a6a6556b279f5fa0db2c5ae9a933508fe) detail, bool showNotification=true) |
| virtual void | [OnCharacterBecameFugitive](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a87b8102e3a719199890062358b8d402b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool showNotification) |
| virtual void | [OnPlayerMetHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ade69c57127eb267ea9ef41bff3ff3bc6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnPlayerLearnsAboutHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad56fd9fadd8c85144e68e77a2ddecf32) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnRenownGained](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9b11f3154f636b85e22adcb1be2145a4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int gainedRenown, bool doNotNotify) |
| virtual void | [OnCrimeRatingChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a898868c9c0bb7ac1ab381e1fa9725f09) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) kingdom, float deltaCrimeAmount) |
| virtual void | [OnNewCompanionAdded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a706a5514966f701e5f4312bd1b8f7f4c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newCompanion) |
| virtual void | [OnAfterMissionStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6b438896c4aef7588eb6a6fc38418036) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) iMission) |
| virtual void | [OnGameMenuOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae3353fa62c4908b94dc2a74472bf3a3b) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| virtual void | [OnVillageBecomeNormal](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa24eb249f068c7dd709f5e2bdb48cbf7) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| virtual void | [OnVillageBeingRaided](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aec98069c7a4abdac6c55b1207b7f84dd) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| virtual void | [OnVillageLooted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acad0cd780e4c43833b7a95e9599faefb) ([Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) village) |
| virtual void | [OnAgentJoinedConversation](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7c5b7c0f078500eaf2ae9e810116aaf0) ([IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) agent) |
| virtual void | [OnConversationEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a390babfb91957aae89349c04a09990b8) (IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > characters) |
| virtual void | [OnMapEventEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a26ebfaf0450f26c8ef4ef737583f8e72) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| virtual void | [OnMapEventStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af1c1ca7805835f59aa9f333aada40a0c) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |
| virtual void | [OnRansomOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2a8d43ce96eeaea531a0d542a995e890) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) captiveHero) |
| virtual void | [OnPrisonersChangeInSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adcbb12df96fe6a8aad73da3adacf3ff3) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) prisonerRoster, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero, bool takenFromDungeon) |
| virtual void | [OnMissionStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6cab1213b307e0b741ac21a4c8ad31b1) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) mission) |
| virtual void | [OnRansomOfferCancelled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a097a5eb7e91ea9a0ecae7fe66b38b156) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) captiveHero) |
| virtual void | [OnPeaceOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac8802474d31ad115e291c358bab01b4a) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) opponentFaction, int tributeAmount, int tributeDuration) |
| virtual void | [OnTradeAgreementSigned](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a598142d74e60f16dd21d0a5378f37cb8) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) other) |
| virtual void | [OnPeaceOfferResolved](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0de37776761cd464c8fdaaf446a494c4) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) opponentFaction) |
| virtual void | [OnMarriageOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a721a30d9191eecd34940bbbc029772d9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden) |
| virtual void | [OnMarriageOfferCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3d90ef003543c413adb337f3a4be29fd) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) suitor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maiden) |
| virtual void | [OnVassalOrMercenaryServiceOfferedToPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a407630b92abd2671203f4b6d60e9ec9d) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) offeredKingdom) |
| virtual void | [OnVassalOrMercenaryServiceOfferCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a21f9d73d52efe1a4882847deda0a5489) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) offeredKingdom) |
| virtual void | [OnPlayerBoardGameOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aab862a653eab2a23dcbeb16661730194) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) opposingHero, [BoardGameHelper.BoardGameState](class_helpers_1_1_board_game_helper.html#ab045b68fb522a41152b0557241b92db2) state) |
| virtual void | [OnCommonAreaStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a64b860a87c28b7eb6af8b0816c50b817) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) oldState, [Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) newState) |
| virtual void | [BeforeMissionOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aea5f880348e4bafc1d978f67d3ac1f0c) () |
| virtual void | [OnPartyRemoved](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a179635aa914fb7bb8aaf12a12225762c) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| virtual void | [OnPartySizeChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3e0521786d62986195ca9761fd935196) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| virtual void | [OnSettlementOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac0baa866084a03780ffa210021a05f64) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool openToClaim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) capturerHero, ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail detail) |
| virtual void | [OnGovernorChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad0a73a2b35363cffcfc281ddb06b7349) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) fortification, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldGovernor, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newGovernor) |
| virtual void | [OnSettlementLeft](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a893bb6880175e5f7e7b9abe562e4e4ae) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| virtual void | [Tick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1a7d21c002a72891d40fc2a160179f49) (float dt) |
| virtual void | [OnSessionStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af6514672a01ba699cc915fbd282d2f95) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| virtual void | [OnAfterSessionStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa3cb8b037efd033c9a8232bee7d60eda) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| virtual void | [OnNewGameCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a356b56d81b6ddc3abc0e62b821229808) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| virtual void | [OnGameLoaded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4d442d24ad6a85982389a44c63a2eb14) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| virtual void | [OnGameEarlyLoaded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5f01de1db2ee2680e7c813a69df821e9) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| virtual void | [OnPlayerTradeProfit](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a572703ead6531bf2a5822ab01018a24c) (int profit) |
| virtual void | [OnRulingClanChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9bada74a737fe40043ba626c7734ef93) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) newRulingClan) |
| virtual void | [OnPrisonerReleased](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afef8ca1ccf2d6d9240b019eb501454ea) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) roster) |
| virtual void | [OnGameLoadFinished](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3ea634c601f4771590d6d3f9cabd7862) () |
| virtual void | [OnPartyJoinedArmy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a900ae35cc97fff74751105c0011d305f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnPartyRemovedFromArmy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2b6fed8a03b00b66ac14da2792c29191) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnArmyOverlaySetDirty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a48d87ca9b4e0190973077cad8d0d6946) () |
| virtual void | [OnPlayerDesertedBattle](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad8db9a572572bf68ae4a7c36dc869344) (int sacrificedMenCount) |
| virtual void | [OnPlayerArmyLeaderChangedBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a761fc245fa9776d0992839882747fdbd) () |
| virtual void | [MissionTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac49962f703db44ac19cd193e4505201a) (float dt) |
| virtual void | [OnChildConceived](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9b57951e17afe64ae22769ca11616785) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) mother) |
| virtual void | [OnGivenBirth](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a552912c267589be8430cabef7b08b981) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) mother, List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > aliveChildren, int stillbornCount) |
| virtual void | [OnUnitRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab72ecd3343c3d04c0e1ede65be378dc6) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, int amount) |
| virtual void | [OnPlayerBattleEnd](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9da462a29263d571d88a25ff8cc6fc39) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| virtual void | [OnMissionEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af4c7984de81c44b47d2a9656ecf6f54c) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) mission) |
| virtual void | [TickPartialHourlyAi](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7318f8837165f380a312160c0ad0b707) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| virtual void | [QuarterDailyPartyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad182750b43c6c39495c21838d4b33488) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| virtual void | [AiHourlyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a11d99dce4f8a008cfa53165641c5655b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) partyThinkParams) |
| virtual void | [HourlyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1c4ea3f46ce568e82cc17f2ed71449d9) () |
| virtual void | [QuarterHourlyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa74fe2e776ae40603801b2b9f9b5afa4) () |
| virtual void | [HourlyTickParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8eec0bf986fd3326ad97a265bb96cf26) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [HourlyTickSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1c4a127283bb458a6f213d4bf504a4d1) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| virtual void | [HourlyTickClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0f244bfb309f90d1cd1a53f8c3e8fc2d) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| virtual void | [DailyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6eedfe629de9e36844fb39cd0d928616) () |
| virtual void | [DailyTickParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a314bdcb0d4cc67abaebe8c105b181c2b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [DailyTickTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a366aa186af37cc2a654931cc6942c1a6) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| virtual void | [DailyTickSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afadb083b69a3716a035aa6311cb3bcea) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| virtual void | [DailyTickClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a50deef6dafd5a6b652961a76b03b28f7) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| virtual void | [OnPlayerBodyPropertiesChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a42192abcd3dc3b1b2afd793d4c6e2c34) () |
| virtual void | [WeeklyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5e9351f1758fd0d98bd9627365bc706e) () |
| virtual void | [CollectAvailableTutorials](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a21ff92c0a4d675ca6489ffde3e65f31f) (ref List< [CampaignTutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign_tutorial.html) > tutorials) |
| virtual void | [DailyTickHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a172bbe9254827d489a5c005b32f1ace5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnTutorialCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a616361c9445050c5a2c6f2ff6891f6cf) (string tutorial) |
| virtual void | [OnBuildingLevelChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a872484253aa14e7bb8be553a81b50cce) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) building, int levelChange) |
| virtual void | [BeforeGameMenuOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3582e248084d5133e87cd1c999f6e6a9) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| virtual void | [AfterGameMenuInitialized](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a405b9daff956f2a1a7c4d2e367311315) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| virtual void | [OnBarterablesRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a375225dfed41289db077577caf986ba0) ([BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) args) |
| virtual void | [OnPartyVisibilityChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a41385b937b64a01c0adf9b3ac60f809b) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| virtual void | [OnCompanionRemoved](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9d56353914130b307ef8862259573d14) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) companion, [RemoveCompanionAction.RemoveCompanionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_remove_companion_action.html#afebe445a9fd9044486e94c0db1b931ef) detail) |
| virtual void | [TrackDetected](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abea423068f95d08a933d05592fd1c75a) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| virtual void | [TrackLost](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5491752d533283178cc29f9bb6d068c2) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| virtual void | [LocationCharactersAreReadyToSpawn](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4144e9473f03cfb82de327978168a7b4) (Dictionary< string, int > unusedUsablePointCount) |
| virtual void | [LocationCharactersSimulated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a79acccb94610f2e4937cbd925dc759a2) () |
| virtual void | [OnBeforePlayerAgentSpawn](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9958864ae44837589d7187f2afa06a90) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) spawnFrame) |
| virtual void | [OnPlayerAgentSpawned](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab8ba2dd4267664efab7faf52d64808e5) () |
| virtual void | [OnPlayerUpgradedTroops](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab58f89386e7a027c6eceb6d20740b9cc) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgradeFromTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgradeToTroop, int number) |
| virtual void | [OnHeroCombatHit](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a98b7f06624c7d920d82aef18bd6f9a64) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackerTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackedTroop, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) usedWeapon, bool isFatal, int xp) |
| virtual void | [OnCharacterPortraitPopUpOpened](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afdb992d08aca0b0a06e2711b1268c293) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| virtual void | [OnCharacterPortraitPopUpClosed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aabf775870c5bb7dff811d5076b5883c7) () |
| virtual void | [OnPlayerStartTalkFromMenu](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1115abb47b46ddd62a512e67b58d7ea4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnGameMenuOptionSelected](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a694849371b5335c9b8e1f05b025fa5be) ([GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) gameMenu, [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) gameMenuOption) |
| virtual void | [OnPlayerStartRecruitment](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a14303cbfa6ff9454bbdabf6046e18652) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) recruitTroopCharacter) |
| virtual void | [OnBeforePlayerCharacterChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a64011b94834dfced52f276974f6d16b1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldPlayer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newPlayer) |
| virtual void | [OnPlayerCharacterChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a80a199ed5541ed86fb6cd5c820a8928c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldPlayer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newPlayer, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) newMainParty, bool isMainPartyChanged) |
| virtual void | [OnClanLeaderChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abcbcd369d0bc1189b867b0477520bafd) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldLeader, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newLeader) |
| virtual void | [OnSiegeEventStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f6bcb872fed496e606a9a1537bed3be) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| virtual void | [OnPlayerSiegeStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac056ce5c1c89bd4c99c37b126c6d9b4a) () |
| virtual void | [OnSiegeEventEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a04b227268da4e7079e1a66fcf80acc45) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| virtual void | [OnSiegeAftermathApplied](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a94d96e25e916273dac202b12353b91a0) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, SiegeAftermathAction.SiegeAftermath aftermathType, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) previousSettlementOwner, Dictionary< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), float > partyContributions) |
| virtual void | [OnSiegeBombardmentHit](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a666de6d9a062ea8ced4651f550b50dff) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) besiegerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) besiegedSettlement, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) weapon, [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) target) |
| virtual void | [OnSiegeBombardmentWallHit](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6a86873ff9207ea3882694d3e8bb5bcb) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) besiegerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) besiegedSettlement, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) weapon, bool isWallCracked) |
| virtual void | [OnSiegeEngineDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab18d10db3188ea0819948ff5d5ebce42) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) besiegerParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) besiegedSettlement, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) destroyedEngine) |
| virtual void | [OnTradeRumorIsTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae38e70e8830d80182e27fd29f6469ddd) (List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > newRumors, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) sourceSettlement=null) |
| virtual void | [OnCheckForIssue](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a047960b1b435d59d54408009dd5000dd) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| virtual void | [OnIssueUpdated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae96c0f4c1c348d7a55ba3434ed5f474d) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue, [IssueBase.IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b) details, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) issueSolver) |
| virtual void | [OnTroopsDeserted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acfda4979f29c66490f6e93d9cb80b513) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) desertedTroops) |
| virtual void | [OnTroopRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab649fa58127eb99c1b38175e73c0a38d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) recruiterHero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) recruitmentSettlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) recruitmentSource, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int amount) |
| virtual void | [OnTroopGivenToSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5f30a5817691a5b20153fb0d3d514980) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) giverHero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) recipientSettlement, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) roster) |
| virtual void | [OnItemSold](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aac3d9c50869d924aca98205bb4243972) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) receiverParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) payerParty, [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, int number, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) currentSettlement) |
| virtual void | [OnCaravanTransactionCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a154a99467bcefbb586b19b65b1cdbb90) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) caravanParty, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, List< ValueTuple< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), int > > itemRosterElements) |
| virtual void | [OnPrisonerSold](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0f9a29cdbe6e8f47af23132fcd73dc49) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) sellerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) buyerParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) prisoners) |
| virtual void | [OnPartyDisbanded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae580d6d15c25d986d63f801b137fbead) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) disbandParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) relatedSettlement) |
| virtual void | [OnPartyDisbandStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5843d230859c9560b27b7780fc5126bd) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) disbandParty) |
| virtual void | [OnPartyDisbandCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaf395a07d55b70154e54b9b1d6306d14) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) disbandParty) |
| virtual void | [OnHideoutSpotted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2cd2abd5833057f8bf87612f959882b7) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) hideoutParty) |
| virtual void | [OnHideoutDeactivated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a476b40c0e2eff03ccb62cd67198e7cd2) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) hideout) |
| virtual void | [OnHideoutBattleCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34507ce845f04b6117d04a0dbbbd438c) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html) hideoutEventComponent) |
| virtual void | [OnPlayerInventoryExchange](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a38a3c030c58c37d32509be7309108484) (List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > purchasedItems, List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > soldItems, bool isTrading) |
| virtual void | [OnItemsDiscardedByPlayer](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8b8d0b7de26833d92f2e1e533e2935f5) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) roster) |
| virtual void | [OnPersuasionProgressCommitted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6c488089d6f3fec0967dae048ddf15c7) (Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > progress) |
| virtual void | [OnHeroSharedFoodWithAnother](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad0562768c73b4c3bcb7f694365fbc158) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) supporterHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) supportedHero, float influence) |
| virtual void | [OnQuestCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0722f718cc643befffb3cf46532f0634) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest, [QuestBase.QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) detail) |
| virtual void | [OnQuestStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a80121601a110e1d9254a0da5a85cdaf4) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest) |
| virtual void | [OnItemProduced](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9169a1080e9bb2dadd9dc196d6b759e6) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, int count) |
| virtual void | [OnItemConsumed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a00a463efddac32f12cdb487ea3726c4f) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, int count) |
| virtual void | [OnPartyConsumedFood](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9ec42fd3a836317d6aabe6fa54cbd45c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| virtual void | [SiegeCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a296e155991bcadbcd057db1306bdb53e) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) siegeSettlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, bool isWin, [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) battleType) |
|  | SiegeCompleted event triggers when a siege ends with a normal outcome. If attackers are defeated "partially", it won't be fired, because the siege event doesn't actually end, and battle state is set to none. |
| virtual void | [AfterSiegeCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa3366fb9d461ec7a6de88bb42d561441) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) siegeSettlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, bool isWin, BattleTypes battleType) |
| virtual void | [SiegeEngineBuilt](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6543dce7ae5422f511800117488e01f8) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine) |
| virtual void | [RaidCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6631550f84b65e909d1c177602a6e6e2) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html) raidEvent) |
| virtual void | [ForceSuppliesCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a459da0fd4ab5b8a60b9c890f43a10ccf) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html) forceSuppliesEvent) |
| virtual void | [ForceVolunteersCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34850c45926553d8c8dc9e687bfd13fd) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winnerSide, [ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html) forceVolunteersEvent) |
| virtual void | [OnBeforeMainCharacterDied](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa290b1325d6b07ac06a0611c7b0449ee) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool showNotification=true) |
| virtual void | [OnGameOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3f72e0aff76dcdc8cf0019607b406435) () |
| virtual void | [OnClanDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6fd8e156fdfaa49ae41bf1e0d2b1beda) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) destroyedClan) |
| virtual void | [OnNewIssueCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a797486987494c0ebdb1c732af849f3b6) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue) |
| virtual void | [OnIssueOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8beb35652e74a4e2f93455849af59c0e) ([IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) issue, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner) |
| virtual void | [OnNewItemCrafted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a501a665e70d0c652e349c3b321f34430) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject) |
| virtual void | [OnWorkshopInitialized](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9618f4263e5934975be5401c61736fe7) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| virtual void | [OnWorkshopOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afcc35d1b1e67aaaaa91a55d551a11e2c) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner) |
| virtual void | [OnWorkshopTypeChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa16c9c5697a3ec6f58d0d2b1e96d7841) ([Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) workshop) |
| virtual void | [CraftingPartUnlocked](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aab97ff9ba3547cec53d5b9601e926110) ([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) craftingPiece) |
| virtual void | [OnNewItemCrafted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5980e578f147e20215ced59a04f0766f) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) overriddenItemModifier, bool isCraftingOrderItem) |
| virtual void | [OnEquipmentSmeltedByHero](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a46f4e356ccd54b097f802cd91fc9df46) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) equipmentElement) |
| virtual void | [OnBeforeSave](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a75e93c7e63b080e226b80f2dd339c568) () |
| virtual void | [OnMainPartyPrisonerRecruited](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af7bb92bc1db0a74d85b8c363bd8edb2d) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) roster) |
| virtual void | [OnPrisonerTaken](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac44d5c1dc977f3c195612e48fc80999e) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) roster) |
| virtual void | [OnPrisonerDonatedToSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad5622914ebc0442414760a747799d76f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) donatingParty, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) donatedPrisoners, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) donatedSettlement) |
| virtual void | [CanMoveToSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4793a0025d67692ca65cab7d9c866317) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnHeroChangedClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acb3aef6fb1a771ef7d0519491462ccf9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) oldClan) |
| virtual void | [CanHeroDie](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0b1778170b8b1e9f08d84a8485dc673c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) causeOfDeath, ref bool result) |
| virtual void | [CanPlayerMeetWithHeroAfterConversation](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af03a06a9e937ab8ceefeb1b2584fdf22) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [CanHeroBecomePrisoner](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ace775570f432474d242258663c80849e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [CanBeGovernorOrHavePartyRole](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad71470980290f2d55166a618d637db9e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnSaveOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2e7eeee5baaa97c7e5988c00ce06045c) (bool isSuccessful, string saveName) |
| virtual void | [OnSaveStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3800ff42e205d4cfb09aab0c7dd3c0c8) () |
| virtual void | [CanHeroMarry](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8527e4986c0e3cf7a581da7cf19187fa) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnHeroTeleportationRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab00fcec3aacef57c81c31a481511e086) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetParty, [TeleportHeroAction.TeleportationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90) detail) |
| virtual void | [OnPartyLeaderChangeOfferCanceled](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a278eba1bc1a9b773e8ddf8f77ec7a004) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| virtual void | [OnPartyLeaderChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1a54daf70ee1d2f5a28f1572d63180a1) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldLeader) |
| virtual void | [OnClanInfluenceChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad46b74e2a3930b813499c484338e6880) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, float change) |
| virtual void | [OnPlayerPartyKnockedOrKilledTroop](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5e085b092f6b313fb08f3104fa5989e4) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) strikedTroop) |
| virtual void | [OnPlayerEarnedGoldFromAsset](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac9abaf7d14174ccda495abd40f0fd4d3) ([GameComponents.DefaultClanFinanceModel.AssetIncomeType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50) incomeType, int incomeAmount) |
| virtual void | [OnClanEarnedGoldFromTribute](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8dc8752dc68807900227f4a48bedfd6d) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) receiverClan, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) payingFaction) |
| virtual void | [OnCollectLootItems](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaa48a85629d5eab820e833109536c1b3) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) winnerParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) gainedLoots) |
| virtual void | [OnLootDistributedToParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a520767a6cdf6339bc7b643a91eefe842) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) winnerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) lootedItems) |
| virtual void | [OnPlayerJoinedTournament](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adba59a048dccb310ae93e9e80adcd8b0) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, bool isParticipant) |
| virtual void | [OnConfigChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0534f5200e010106be8c7f7885edf1fc) () |
| virtual void | [OnMobilePartyRaftStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8e7ae269f45c9b02e1d9008c3f5bbd1f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnCharacterCreationInitialized](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a499f973fe9a231418750e8e36bae0416) ([CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) characterCreationManager) |
| virtual void | [OnShipDestroyed](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a948c718e3662d8dc65a58b64d8738b44) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) owner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [DestroyShipAction.ShipDestroyDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_destroy_ship_action.html#a52f9b7dcd67d7a49fc241de25137f7d1) detail) |
| virtual void | [OnShipOwnerChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a109dc611f24cb27bac0bbc8a498b0ac3) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) oldOwner, [ChangeShipOwnerAction.ShipOwnerChangeDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f) shipOwnerChangeDetail) |
| virtual void | [OnFigureheadUnlocked](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a04de735972ec8a5f3100bbfa85f6a245) ([Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) figurehead) |
| virtual void | [OnShipRepaired](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7af6a0e0fffc671bffadc3141d82ce9a) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) repairPort) |
| virtual void | [OnPartyLeftArmy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae9ffeade5f828b9a1fbd1f93ebf61428) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army) |
| virtual void | [OnIncidentResolved](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aeb1b212b7702dbb455fc139aebc86f5e) ([Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) incident) |
| virtual void | [OnPartyAddedToMapEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af224cc53faa894e55efbdc61df7c1420) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase) |
| virtual void | [OnMobilePartyNavigationStateChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a32a3229f31b225842e3719a8857e241c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnMobilePartyJoinedToSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acb9777179473e1e00f7a3f4eb3d80999) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnMobilePartyLeftSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a56a8dc304af6f4c9a38d3debc9366ba6) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [OnBlockadeActivated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8e869f7664427be678ff273ec340f732) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| virtual void | [OnBlockadeDeactivated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7b3c5394f44442467ae00a7603aebc5e) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| virtual void | [OnShipCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aafd518d9378b18cd54ae69ee53c05955) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) createdSettlement) |
| virtual void | [OnMercenaryServiceStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a38369e757c569b93cacdac7ebbcf4e44) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan, [StartMercenaryServiceAction.StartMercenaryServiceActionDetails](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_start_mercenary_service_action.html#a5861e61ec787655431332d6abb63721a) details) |
| virtual void | [OnMercenaryServiceEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a276e0fae65b514dc3315369517f5388c) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) mercenaryClan, EndMercenaryServiceAction.EndMercenaryServiceActionDetails details) |
| virtual void | [OnMapMarkerCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abf77449a7e77c1458bb7bb04b624099f) ([MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) mapMarker) |
| virtual void | [OnMapMarkerRemoved](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adc1a52dad5da10a6060d97348ab2b04b) ([MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) mapMarker) |
| virtual void | [OnAllianceStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a86b1385ce8466223b86bba96b23493d9) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| virtual void | [OnAllianceEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a776018fae9847480244d9ce0d6715e76) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom1, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom2) |
| virtual void | [OnCallToWarAgreementStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa0bce07a59e9752cf0ac7e4bfaa66e38) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| virtual void | [OnCallToWarAgreementEnded](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3ed5af5ad91883f12190c4cd2366cbda) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) callingKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) calledKingdom, [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdomToCallToWarAgainst) |
| virtual void | [CanHeroLeadParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a86e4f4782d0f1b2be099ef4fe30b8716) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnCraftingOrderCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa15c74a738056e3bd158de34e5cbad38) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) completerHero) |
| virtual void | [OnItemsRefined](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a052182b302597c0703512d8df6277f38) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, Crafting.RefiningFormula refineFormula) |
| virtual void | [OnMapEventContinuityNeedsUpdate](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4525748c4272953b82962a499a2616e9) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| virtual void | [OnHeirSelectionOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a093f73749d5a11dc6b783f76cda19891) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) selectedHeir) |
| virtual void | [OnHeirSelectionRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add98c2403df7ebb7ea5a106e5a1c6bac) (Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > heirApparents) |
| virtual void | [OnMainPartyStarving](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2a3dacfbcba36e34194be6ab18b190d2) () |
| virtual void | [OnHeroGetsBusy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f8b1fec51e016490693052fec3ee4ce) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [HeroGetsBusyReasons](namespace_tale_worlds_1_1_campaign_system.html#a74f96a6c3de3af13ac985228276ee611) heroGetsBusyReason) |
| virtual void | [CanHeroEquipmentBeChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a433faa50918c107ff0026aaac8470c27) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [CanHaveCampaignIssues](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6f50c9d7928844d7dab61293b71b90db) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [IsSettlementBusy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a45dd08fc640c47170fc82ce3fd764dda) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, object asker, ref int flags) |
| virtual void | [OnHeroUnregistered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0be0a6d8f2b46360e13a0a2c0405207c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a30c010ec60d81a1f6cbf2317efd3ddeb)RemoveListeners()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.RemoveListeners | ( | Object | *o* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a16c1840b259917e83e40f51fefcbc8b8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8d7323ebc7d38c26760126df4427a633)OnCharacterCreationIsOver()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCharacterCreationIsOver | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1d4458d03ce52d63977765d2ab82e556), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5c1a7ca330dc6b8bfb8e4a0d6066d9d7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab566f030c822fd4cbb09513a4d2836bb)OnHeroLevelledUp()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroLevelledUp | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *shouldNotify* = true ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac4db84b275e574a08d2803b6790f4184), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac85b9a556ee7b3c7ca4ea9b1da835350).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af54816c97132e599daecf0afd69e4288)OnHomeHideoutChanged()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHomeHideoutChanged | ( | [BanditPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_bandit_party_component.html) | *banditPartyComponent*, | |  |  | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_hideout.html) | *oldHomeHideout* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a368d92c4ffb3a6a4563234c55c6f4870), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac840fa48a1462879f109353002b6da7f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a774dde909dfe3a56e5f1f2855f37291d)OnHeroGainedSkill()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroGainedSkill | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, | |  |  | int | *change* = 1, | |  |  | bool | *shouldNotify* = true ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4e9ad7aaa042af9d41095437d41a16e0), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a96173d89ea13e0f41b9a05d5411cd25b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a05e630443f776a6c1b9f9612cec60031)OnHeroCreated()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroCreated | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *isBornNaturally* = false ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad32aead81cfc627b77cb97a20d92098b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2f4a4efc3d64e82e3c534be8f9a85764).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a625e18d200941d39c69344d5b9433c2c)OnHeroWounded()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroWounded | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *woundedHero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af62233f70f7ab4ee878af6c157714bff), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7a303e1e131c48e7d9cf617f108e5861).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0847916b31147173736364528ec6ee49)OnHeroRelationChanged()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroRelationChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *effectiveHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *effectiveHeroGainedRelationWith*, | |  |  | int | *relationChange*, | |  |  | bool | *showNotification*, | |  |  | [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) | *detail*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *originalHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *originalGainedRelationWith* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0abf26c43395c754901feda7e507dc80), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a763d7ac8c45c2c45043b1a5cb83e108d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a498dd4bb8db0b0f9764c5d430d6698a4)OnQuestLogAdded()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnQuestLogAdded | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest*, | |  |  | bool | *hideInformation* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aad113cfc0dae59058fe70a17a67d376b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0963a7a5fc481248968d699ce1fa93c7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add0408270dc933a0bac52deb7ca20058)OnIssueLogAdded()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnIssueLogAdded | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue*, | |  |  | bool | *hideInformation* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a70e0002ce49b8281a71c5f8707d2940a), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a51c12739f27a94d824425da0bd5d822b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab2e5269e3afaf90afacf70f862b6e846)OnClanTierChanged()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnClanTierChanged | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *shouldNotify* = true ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a831e4d87bc6d6b9f4ac90b7f45fd9534), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aeefe58bbd5980ef22be5334a33f4a370).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a015a602a70828d9e92b571cf5a1e1ca8)OnClanChangedKingdom()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnClanChangedKingdom | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *oldKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom*, | |  |  | [ChangeKingdomAction.ChangeKingdomActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_kingdom_action.html#a9b4b755abdfb7030dcc3a26bb9dad035) | *actionDetail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abbef9ec395808f5d992f1683f4f5d53c), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a079e40a3ebbd830f6ca2e024bba877ae).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abc55047e4785adff779e0754451ea424)OnClanDefected()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnClanDefected | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *oldKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *newKingdom* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#add22b54989f6f90876bdc31debc92c53), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a56052c54559ccbfc1c6c2acf6ea5cf2a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af7e7a45cbeaede6021ed4fbcf0eb5b0e)OnClanCreated()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnClanCreated | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | bool | *isCompanion* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab624fe1292eb01e44dbbc3a46ec392d6), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a206c73905348185766f66bfaf995de7d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad7dcc8181382dbe9b9e0dd0439ef3586)OnHeroJoinedParty()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroJoinedParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8fbf2ff7378048776d04b6e9512e8adf), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3cbc07bcd3b3a4bb983868117d3bce86).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9a8a4e5a1b7331d9873402430fdad319)OnKingdomDecisionAdded()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnKingdomDecisionAdded | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision*, | |  |  | bool | *isPlayerInvolved* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa4cba2c1a0075e0e1c62a5fc2b2336ad), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a798a4cde36bfcb83d31798f46351bbd7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab405f44fe4a5bbe5c430afe873f6211f)OnKingdomDecisionCancelled()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnKingdomDecisionCancelled | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision*, | |  |  | bool | *isPlayerInvolved* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1669d5acda8512a8b1c26b0aa6f650d4), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa05d050e0f8b8bacdf3847c22c1810fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a45c01f7262fea33c04e71f7a6404348b)OnKingdomDecisionConcluded()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnKingdomDecisionConcluded | ( | [KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) | *decision*, | |  |  | [DecisionOutcome](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_decision_outcome.html) | *chosenOutcome*, | |  |  | bool | *isPlayerInvolved* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa84011de5db86bb0b804bcea07b87eb1), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0c9ddf213f601b47c7ff98d601b8b4bc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7ba4f835d34bde173d96329691e9c921)OnHeroOrPartyTradedGold()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroOrPartyTradedGold | ( | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *giver*, | |  |  | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *recipient*, | |  |  | ValueTuple< int, string > | *goldAmount*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a78b9a9a92a1580bf0bc278709f708e62), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac58e9a8811801a4625421e08539c3594).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aefec55dd3f5ebe48fe1131de64f2724c)OnHeroOrPartyGaveItem()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroOrPartyGaveItem | ( | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *giver*, | |  |  | ValueTuple< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | *receiver*, | |  |  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abba905727861a99ffcf9f4900eea59a0), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aff4b6babc3f06decf02cea60ae5c6b36).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6d5c54c4922af962519c94d697da6a61)OnBanditPartyRecruited()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBanditPartyRecruited | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *banditParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a67d47a7b696d179d03728eccb01f17c9), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac69bd759ed45c3d0abb53bffc2b04d23).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae5c7c8c0623112a24b92f45775da9ef3)OnArmyCreated()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnArmyCreated | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7b21cc6863c8589cf7d4bd3371362313), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a30f79e5f3ac7d501f309e98f33f83e72).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a70e9cf8fa0db1f683469486d17370def)OnPartyAttachedAnotherParty()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyAttachedAnotherParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a64b034374cbc50d3a6cf0fb77c2c069b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af3c660cacc08ec66f427b06cbf56d7f6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa4aa33f9b5a7fa4fd152926e525c3bee)OnNearbyPartyAddedToPlayerMapEvent()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnNearbyPartyAddedToPlayerMapEvent | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a83f6bad94f59be66271cadf771a3ff61), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a59586a0b9838a010532169e0500e14fb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add2840f58e65bb5718ccdef8d8cdbb36)OnArmyDispersed()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnArmyDispersed | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, | |  |  | [Army.ArmyDispersionReason](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798) | *reason*, | |  |  | bool | *isPlayersArmy* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a983cfc465ade1ed807b2020afc1fef46), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a603fa574650d370e8cc734cdaf4ec791).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a54baf1826c91309838e376e75e57d9ef)OnArmyGathered()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnArmyGathered | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, | |  |  | [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) | *gatheringPoint* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae6213a2b79a21bffc74e062c379ac8c2), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6509f1ac57a054b170cd3e1b93a763e9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aee81305bf3166d5e570ee5ecfe9b10a5)OnPerkOpened()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPerkOpened | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab20a762c1bee6883b49bd945ef5fe44b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4eea87dcb1db32d609eb7df4a06d3dba).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a46d6825fd7135c94d5c46b61af4da22b)OnPerkReset()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPerkReset | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aca0f9fd1c549d9466ddf96a69540ee76), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aabbce1eb5f89ff3727426bdf1a473ef8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae3c7084a4ba93a0cb9c43b54cc86f682)OnPlayerTraitChanged()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerTraitChanged | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, | |  |  | int | *previousLevel* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3b021415e8b511636db2d05eb5888402), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaf60413fe379de18485402869b375142).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaaf549d05ae27a9de85ea15be155974d)OnVillageStateChanged()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnVillageStateChanged | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village*, | |  |  | [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | *oldState*, | |  |  | [Village.VillageStates](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html#ac15d9b68ef9ed2cc6fee07fd243c46e1) | *newState*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *raiderParty* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a32bb35d9dad07fbd5d2ab0ae8e63cdbd), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad8b2af435839f3c377b3a2e81bfc9a7c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34a08aad1b66ef9fb1a0f77377041c80)OnSettlementEntered()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1d1a8d1d57be8f12dce6a01c451e50d3), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5812c9e3206bbf0838e54b8829b3d99a), and [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a1ebb8726efb29a5a72957c38d033086c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a81b5ae8709aa37f1ab97f244d5b4299c)OnAfterSettlementEntered()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnAfterSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a677f670479ee4e0cd332f978a3d488d2), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2375fdadcd9f0679cc0e674ff641c64e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5cb188b4bddbe0e32a602eb89339ff08)OnBeforeSettlementEntered()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBeforeSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0b50ac2543f1acf8a29ee4a789bd7039), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4ec6825f18a2bd08cd70c7c7877ed8ee).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a19f1714761ef9137b2a09c004880fdb7)OnMercenaryTroopChangedInTown()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMercenaryTroopChangedInTown | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *oldTroopType*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *newTroopType* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8df2f81effeea1349a625b8d980da913), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a574f7ec0c28d8095637b4ea63861f195).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afdeef75c68facf73a9a3da673fa64120)OnMercenaryNumberChangedInTown()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMercenaryNumberChangedInTown | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | int | *oldNumber*, | |  |  | int | *newNumber* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad4ada8f69c8e3e838704673be63bdfa0), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a086e74029d42499eb89d9c597b4c6aad).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a12183794116453d1920425fb1a0f1c06)OnAlleyOwnerChanged()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnAlleyOwnerChanged | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acf56506b3725dd22369712e87a4aafea), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a49df3ed48687b5faba1ab94db7dfdb3d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a94cecba044b9fb6b1d496718937aac6a)OnAlleyClearedByPlayer()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnAlleyClearedByPlayer | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa373bdf85255a12c7f92e2b714889b11), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa52c39d1771552118c004125be2a23d5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afb1c1846367ec6cb096c523dfeb75de8)OnAlleyOccupiedByPlayer()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnAlleyOccupiedByPlayer | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troops* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae5577a4315cf45adb1fea5bd48d0a30e), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8250042741b6911b35984b7a04b48046).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4ef69fd2052fed76b92492482b0d23a0)OnRomanticStateChanged()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnRomanticStateChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2*, | |  |  | [Romance.RomanceLevelEnum](class_tale_worlds_1_1_campaign_system_1_1_romance.html#ad42c0267fbc71f2db0cd6f26841f9d5a) | *romanceLevel* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8a077024d0a027896a619fedc9815334), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf617617b85c60d0e0a823a1f0776584).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a98d83294d0cc4c5c2829b5927310a925)OnBeforeHeroesMarried()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBeforeHeroesMarried | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero1*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero2*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a71ec3ad493a55c3c31666130fef98436), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9fb9d4bbe901bd38c6163b08c58baacd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a467f012c0ebec2f57b4eee9a0817136d)OnPlayerEliminatedFromTournament()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerEliminatedFromTournament | ( | int | *round*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae7499eecf9c53b0d8f6a54d940dd655b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adcf56bcc29bf7e1858b5a991ad5e1556).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad65f3efd3ce650f123b8b20af29dbb2c)OnPlayerStartedTournamentMatch()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerStartedTournamentMatch | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9336ddc7a212ea58265d2cfdbd4d62ff), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3995a4ee9f88fbff4d9fc9f0fb95a608).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9d5972dfefb563fbd011cd2ff86dba72)OnTournamentStarted()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnTournamentStarted | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afc3e248142ca8dd9200214b0d5aa236e), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8092f0b2b6d6eba05cc278b9b0b074ac).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab8a512aebcd7550547be2484477c7673)OnTournamentFinished()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnTournamentFinished | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *winner*, | |  |  | MBReadOnlyList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *participants*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *prize* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b3c341549ab3cccb2c671cfae9d56b7), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af17ef3249af0167b3239d941c6fc9d78).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a75f25270c3a7cc08c1a6b56c162cdbf0)OnTournamentCancelled()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnTournamentCancelled | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2a1dc84c663c26bc528ef062d4947b41), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab5df63590d819bbc5b4f1ffb05bdb70a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1b454dafed5b1da0d3f7a16c142d6e72)OnWarDeclared()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnWarDeclared | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2*, | |  |  | [DeclareWarAction.DeclareWarDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_declare_war_action.html#ae14e6aaf7e6ab22a1bd112b413124ce4) | *declareWarDetail* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aba4b2ae1012c2717f4c4b808860e9847), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8ea1eea17b591f6dc693164903f51682).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0dcc68b946f5ceae0cd2f58f1f481bb6)OnMakePeace()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMakePeace | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *side1Faction*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *side2Faction*, | |  |  | [MakePeaceAction.MakePeaceDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_make_peace_action.html#a6899ba26eb5b509b23d7bc231a1c30ff) | *detail* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a222e2e5b54c186e9446b7a5ab30d5402), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac06b94b658e2afe684ced36d5c160313).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae1182810cffabe7c541cf67f0244f80b)OnKingdomCreated()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnKingdomCreated | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *createdKingdom* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac2392a0f94078803e3200e4b47fe2db9), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae5d1aedffc331b78a10e60059f7ae69d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a48aad6e8dbaf5703c46f3f2b374b9e9f)OnHeroOccupationChanged()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroOccupationChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) | *oldOccupation* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a66998c6770a3017039286594c35fe016), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a38b8e68d3e01c00caad1679cd848a20f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af1717c6abfcbe84e0ac4565e1c2c8bc8)OnKingdomDestroyed()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnKingdomDestroyed | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7f3d2f3d1c9f272c66f61eab8e7269a6), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5905a51cd7ba8b0565d6929a0dc4c034).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aeb013b5c5589e8980415990498ed4f3b)CanKingdomBeDiscontinued()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CanKingdomBeDiscontinued | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af8911c6310ba88b76c2fc675ad16df4d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a84952dc2de1a1a005971d9f83cbec207).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a20f5223478e91a352f32b5d91df3f215)OnBarterAccepted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBarterAccepted | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offererHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, | |  |  | List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | *barters* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acf5f156d3f12d72b9df56c69d9821f04), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab100922c27f9953f0bb2d67e91b2c970).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7260af52532867d6d7a01fbb516c3d07)OnBarterCanceled()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBarterCanceled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offererHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *otherHero*, | |  |  | List< [BarterSystem.Barterables.Barterable](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barterables_1_1_barterable.html) > | *barters* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a856f422d914bf3edebcb203d9893f44c), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a493fd41084040dba18f9185b436b2cfb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afc6415a7dc758250a8adbac387f47004)OnStartBattle()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnStartBattle | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty*, | |  |  | object | *subject*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a663e516c42e30392c3d7552418aabbbf), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab75d9ccd2f631cdfba6799bd77c9f2bb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4c33911e4f68d8fb63b050d631bcc971)OnRebellionFinished()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnRebellionFinished | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *oldOwnerClan* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae3eb9f48a143262cc4461d891e0654ff), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae80aa4ba6eca322fce4d563a4e87d86b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af983512cf4a2250654d6f68d52cf8139)TownRebelliousStateChanged()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.TownRebelliousStateChanged | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *rebelliousState* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0c86a21370e5ee6c177030d85c4277ed), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a46473129645c0420e6ad853ee93ee2dc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adca45c31fb5767cbaebd49fbc00f2af2)OnRebelliousClanDisbandedAtSettlement()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnRebelliousClanDisbandedAtSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a252198a36ffd7280630552db32d71daf), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aef6072df4e4251343c7636d1b2b8d0a8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2413d12700d18aea5d789566410076e2)OnItemsLooted()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnItemsLooted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *items* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5f7ff81d04f4ac6e2c6606526ea086ff), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae4e5170b70100fede9ffbf9edcff097).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a83399ccb5af654bc810e1aa3695d73d2)OnMobilePartyDestroyed()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMobilePartyDestroyed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *destroyerParty* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a194890dfceee16bf0a1b64fa08818313), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a67c0870e45c7a54013fc75cdd1249396).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae1a37302077e16224eae7622c70eddda)OnMobilePartyCreated()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMobilePartyCreated | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af71a267ccb59fdbfb2f3d8a39cf794d7), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a073cb8430ac23e18ad7e48b86d4da941).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1ae04e92878f6098c97dd286e249fce0)OnMapInteractableCreated()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMapInteractableCreated | ( | [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) | *interactable* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0f8fd9885e152863bb346b3250ec8551), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3f713372ceae90a98284cd43ec574766).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3a06afc7142607764857ef5970c16cc3)OnMapInteractableDestroyed()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMapInteractableDestroyed | ( | [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) | *interactable* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a54d5945da50724d1e7d9710892b18f54), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad14b798aa0847cc633df408ced8c4548).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae19e20a00d6fad6f78d25ffa08109bfd)OnMobilePartyQuestStatusChanged()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMobilePartyQuestStatusChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | bool | *isUsedByQuest* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6605e025b28928b45fda9b7b8713dbf8), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a93184b1fad08f2a69499e45fd7bef810).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0bac5bea643a360776c14acb7b0f5291)OnHeroKilled()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroKilled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac0f2f651f00d72b893a6f14d88b550f3), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0586e8d199052b9001a658b2a2a57182), and [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a0ea5c316901240913d50326b4175d417).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a725002864af0aa2a629f3d5448677172)OnBeforeHeroKilled()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBeforeHeroKilled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a96c7f1be9d6bd66650683c61d40f1896), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#add1e7d161736b7f6c669dfa3ed07c461).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a11f91f90e077f050c33d67866c3e83aa)OnChildEducationCompleted()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnChildEducationCompleted | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *age* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a769ffcc1c235c5991e06ae3f2f508c72), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf8f6ce436135739bada622b89745b71).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#addab04c615c3a47008e02cdac4ee9493)OnHeroComesOfAge()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroComesOfAge | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abaa98c6153ab812300d48e8f80bad6f1), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae83a9348e9c5632cdfb4e6ad4e93620a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4a1f249bacb71890d0e93146a43cf659)OnHeroReachesTeenAge()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroReachesTeenAge | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ade0956b3e567b4fc52ed0599e2f129fb), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a37a00c938245fe47986ecbadb93116ea).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac9334bcdd529dc13fbd707f9b9dff547)OnHeroGrowsOutOfInfancy()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroGrowsOutOfInfancy | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a009e962ae72f96c7754d2ce622730133), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad7307bb4a07349a0474b6529ad96452a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac22e666e7df0a779a3063af689a1f957)OnCharacterDefeated()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCharacterDefeated | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *loser* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a099ad46670b11e51331ffd51c080f0b4), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0abdf23b2adec440d4a5b079fae74c00).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f4366bdf2d5ed8f40840385ca8c4f0c)OnHeroPrisonerTaken()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroPrisonerTaken | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *capturer*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisoner* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#adb7dd67a23aa41fbb49102f0d8580263), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aeed9185d0aff8a0d0dc57e1a191daa31).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afa8773a1e419eb74dcfcf1f42bccda00)OnHeroPrisonerReleased()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroPrisonerReleased | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisoner*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *capturerFaction*, | |  |  | [EndCaptivityDetail](namespace_tale_worlds_1_1_campaign_system_1_1_actions.html#a6a6556b279f5fa0db2c5ae9a933508fe) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab91ddde7d00d6f67ca8f09ef95bec193), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad9ae5888ec3958f7c21ea4f9279fdb19).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a87b8102e3a719199890062358b8d402b)OnCharacterBecameFugitive()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCharacterBecameFugitive | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *showNotification* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a34cc21b08385164200afa7db9807b5ab), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab61f3610a278094999878f4d486d9220).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ade69c57127eb267ea9ef41bff3ff3bc6)OnPlayerMetHero()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerMetHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#add05e49f7ca64f193858221ee8918c5f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab7b4cd1589ec41a5a90ee8ac24841b6e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad56fd9fadd8c85144e68e77a2ddecf32)OnPlayerLearnsAboutHero()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerLearnsAboutHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab99158e83a458d70ae234bfe4496850a), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a27b4ca095a76fc9ed83564ca9acd9e34).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9b11f3154f636b85e22adcb1be2145a4)OnRenownGained()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnRenownGained | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *gainedRenown*, | |  |  | bool | *doNotNotify* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0e60e4fe86b1cf7bd2dc82101e16af7b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a96606a1b8cd2f528744e6e0c19741b9b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a898868c9c0bb7ac1ab381e1fa9725f09)OnCrimeRatingChanged()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCrimeRatingChanged | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *kingdom*, | |  |  | float | *deltaCrimeAmount* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aee7b91a5a7dbbcf2b122851a3b250684), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3f1c9cc9ef9d0cb91da2632de53722a4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a706a5514966f701e5f4312bd1b8f7f4c)OnNewCompanionAdded()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnNewCompanionAdded | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newCompanion* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a224e955316cf0d4ae7f2bdbb303e9c56), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aea25cf62b7866d409eced1b3fabb0c83).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6b438896c4aef7588eb6a6fc38418036)OnAfterMissionStarted()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnAfterMissionStarted | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *iMission* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af3ebda780987304e25a11fea71c08504), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a29e7aed1396da14d0e3bd394c716dabc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae3353fa62c4908b94dc2a74472bf3a3b)OnGameMenuOpened()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnGameMenuOpened | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a47f14a8b031ab901a9c503a922187a32), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae01a64fd87a3881fa60ea97260858c90).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa24eb249f068c7dd709f5e2bdb48cbf7)OnVillageBecomeNormal()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnVillageBecomeNormal | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0e8bcae9545784ca78665d72508a7095), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7b7d36593a58eb081b60f833f87f011c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aec98069c7a4abdac6c55b1207b7f84dd)OnVillageBeingRaided()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnVillageBeingRaided | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab5905dd19c4a8a102c52789ef46cd7ce), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8829a43e20fa385e73cd0718fe1baaae).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acad0cd780e4c43833b7a95e9599faefb)OnVillageLooted()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnVillageLooted | ( | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_village.html) | *village* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9a2834cec155e4e33432a149c89300ec), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#affdbdf5672d2b48c22d64ed5d5510c5c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7c5b7c0f078500eaf2ae9e810116aaf0)OnAgentJoinedConversation()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnAgentJoinedConversation | ( | [IAgent](interface_tale_worlds_1_1_core_1_1_i_agent.html) | *agent* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a05318ba5de68e2042bd0816725320f97), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acfbac12ed4c933c1c27fac368bdc00a5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a390babfb91957aae89349c04a09990b8)OnConversationEnded()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnConversationEnded | ( | IEnumerable< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *characters* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a03fcddb7078f92395d003e9237745f9f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac416c7c7ec196fd2b984565de2fa6e78).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a26ebfaf0450f26c8ef4ef737583f8e72)OnMapEventEnded()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMapEventEnded | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a21bd013cf48aa386c32b6e61ac1e8882), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d764f40b523943c39bdb65375c2c333).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af1c1ca7805835f59aa9f333aada40a0c)OnMapEventStarted()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMapEventStarted | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac0ca07a21f0cfb10a5fc1147c3c3c3d4), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a12fbd1fda187e7a85c9052df1b367082).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2a8d43ce96eeaea531a0d542a995e890)OnRansomOfferedToPlayer()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnRansomOfferedToPlayer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *captiveHero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a00ada9319af0a319c21aa11a11cf7157), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2d4f06a2f35a3592e140c5ecfb5ce6d6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adcbb12df96fe6a8aad73da3adacf3ff3)OnPrisonersChangeInSettlement()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPrisonersChangeInSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *prisonerRoster*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero*, | |  |  | bool | *takenFromDungeon* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a27eb26e4a440eac3bf45cd36adf65eab), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4314706b7c0b9df5b2f9cccbe8aa5a7b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6cab1213b307e0b741ac21a4c8ad31b1)OnMissionStarted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMissionStarted | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *mission* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9a98b71628b2c36f6220b5df78719cf3), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab658a499ef66e6ce0e208c94afc29857).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a097a5eb7e91ea9a0ecae7fe66b38b156)OnRansomOfferCancelled()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnRansomOfferCancelled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *captiveHero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4f2f5eae0944fe03bc1d667d3f168d3a), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aab20e270eb96c796f00c37e850f3f772).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac8802474d31ad115e291c358bab01b4a)OnPeaceOfferedToPlayer()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPeaceOfferedToPlayer | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *opponentFaction*, | |  |  | int | *tributeAmount*, | |  |  | int | *tributeDuration* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a635e6840cc52f97ba663fc048452e638), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a517fd64f21706375a45e0b4388ef6d92).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a598142d74e60f16dd21d0a5378f37cb8)OnTradeAgreementSigned()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnTradeAgreementSigned | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *other* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a130a91040bee7a538d07c88585f7f82a), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3f1c8113796cfa2b05b96eb8c57243de).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0de37776761cd464c8fdaaf446a494c4)OnPeaceOfferResolved()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPeaceOfferResolved | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *opponentFaction* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9afbb66157aff37cb8ed0b0ba91e1987), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af6997b5594f2e1cdd70ddc0bc0128cc0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a721a30d9191eecd34940bbbc029772d9)OnMarriageOfferedToPlayer()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMarriageOfferedToPlayer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6b845fef513f1089de460702fdc71c9e), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9416a8942712af0f8a5a0b2fc2def22f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3d90ef003543c413adb337f3a4be29fd)OnMarriageOfferCanceled()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMarriageOfferCanceled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *suitor*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maiden* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a062de1b7669732006fde163187f7bb66), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a63aea9cf76876742082b4f285663cd23).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a407630b92abd2671203f4b6d60e9ec9d)OnVassalOrMercenaryServiceOfferedToPlayer()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnVassalOrMercenaryServiceOfferedToPlayer | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *offeredKingdom* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9156772714bf003d140c862360479ebc), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a56568444e5ebe650314327c95666cf1b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a21f9d73d52efe1a4882847deda0a5489)OnVassalOrMercenaryServiceOfferCanceled()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnVassalOrMercenaryServiceOfferCanceled | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *offeredKingdom* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3d8014e55e9249ebb660bf13abb6a1e1), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5678e3ba11d77e28f63f91ad1e33e28f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aab862a653eab2a23dcbeb16661730194)OnPlayerBoardGameOver()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerBoardGameOver | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *opposingHero*, | |  |  | [BoardGameHelper.BoardGameState](class_helpers_1_1_board_game_helper.html#ab045b68fb522a41152b0557241b92db2) | *state* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4681a73d82e90462e2db183f8e2a970d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1f7c391a2ccdd3e63c2d404590982e96).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a64b860a87c28b7eb6af8b0816c50b817)OnCommonAreaStateChanged()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCommonAreaStateChanged | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | [Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) | *oldState*, | |  |  | [Alley.AreaState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html#a9b96332c80662fbdd85df936d5e544bc) | *newState* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af6f1962fafa9a98a61f357b974df6e1d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aea5f880348e4bafc1d978f67d3ac1f0c)BeforeMissionOpened()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.BeforeMissionOpened | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a548d0b24f62b703b0b2843b66d8277b8), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa8fc9aecad33a4500bfc7fee2c0fe97c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a179635aa914fb7bb8aaf12a12225762c)OnPartyRemoved()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyRemoved | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9fdff15633d16735bdbc0c9e10cfe3bf), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a366a7fd4a4759db08a443cdecd4361dd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3e0521786d62986195ca9761fd935196)OnPartySizeChanged()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartySizeChanged | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0f2c75aaf93eee0f53b5563afd3dec96), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6d024c9d62f97ce846d166bda11361a9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac0baa866084a03780ffa210021a05f64)OnSettlementOwnerChanged()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSettlementOwnerChanged | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *openToClaim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *capturerHero*, | |  |  | ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail | *detail* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aabf24ac38b7d432ecc27785a61fefbc1), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a42326f8401f7cb41e7500c30b774f980), and [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a90b3e82cb25dd3e8655ec6d7ccaaf4c1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad0a73a2b35363cffcfc281ddb06b7349)OnGovernorChanged()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnGovernorChanged | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *fortification*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldGovernor*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newGovernor* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab800ee3c3be11a6cc37fc20d4c858c11), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8ae50eabf1ee7f3a95f2a9c934ad9f06).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a893bb6880175e5f7e7b9abe562e4e4ae)OnSettlementLeft()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSettlementLeft | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad84b08377315563256ecda0f06b006e1), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a23d17e5033a55769d56dc9c835c58c1a), and [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a26fdea2fea568a0ebc9a9a3c19770e11).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1a7d21c002a72891d40fc2a160179f49)Tick()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.Tick | ( | float | *dt* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b058daf7a15380a7e9221543b720252), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab1446a4e44ff8fe93ab7c54fd047b7cd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af6514672a01ba699cc915fbd282d2f95)OnSessionStart()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSessionStart | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#addbb606605d2c20cef65b17a5ddaa90c), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7976e45d7475b95dd21aa89d0e1e50ed), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ad158ee6b7be9b5223260f5e8ac6bee0b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa3cb8b037efd033c9a8232bee7d60eda)OnAfterSessionStart()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnAfterSessionStart | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a951ea972f67d10b5de09232a4259a15f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a90e9619b1fabc284d833a4f55e32b695).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a356b56d81b6ddc3abc0e62b821229808)OnNewGameCreated()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnNewGameCreated | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4f1ecc8ed6f0fdae3cd0e953f113a7bf), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac376b6294e8cc979693e99e252f38642).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4d442d24ad6a85982389a44c63a2eb14)OnGameLoaded()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnGameLoaded | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2f3959ec85d3810ccbef838111fd2710), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adecbe92c3b13b4a5604225a5ec208c5b), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0904383965a9d3753f7ce59de7e4e54b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5f01de1db2ee2680e7c813a69df821e9)OnGameEarlyLoaded()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnGameEarlyLoaded | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6a78e0c9a3f6da469818b8074901ece8), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acc4e80ad6cde74e063398c89846897e3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a572703ead6531bf2a5822ab01018a24c)OnPlayerTradeProfit()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerTradeProfit | ( | int | *profit* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae306cc55b9c27304e2631e2a72f03cd2), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1a37c65ce2a218dd73acb04ad249a7f3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9bada74a737fe40043ba626c7734ef93)OnRulingClanChanged()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnRulingClanChanged | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *newRulingClan* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aca6b252d609fcbe9a9ba31dc9783edb0), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1d66130086f3a94b0e5a18aa990c011a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afef8ca1ccf2d6d9240b019eb501454ea)OnPrisonerReleased()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPrisonerReleased | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *roster* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acdd7c2446489a61d94a1acd709f46825), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aba719cb40f5c268051fb2589f01a619a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3ea634c601f4771590d6d3f9cabd7862)OnGameLoadFinished()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnGameLoadFinished | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a859c00334f78f9fafcff48d5c6c27f26), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1cd243613aa602cf19f07f6b2975ed80).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a900ae35cc97fff74751105c0011d305f)OnPartyJoinedArmy()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyJoinedArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aaa5151a9a086e4f632b5a7f284dd56f2), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abb913bb44a8da6a7098cb169a94b5dd0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2b6fed8a03b00b66ac14da2792c29191)OnPartyRemovedFromArmy()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyRemovedFromArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abcbba7a66f3ca627c2d69816e0a53eb5), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4a56776bef64dc01145f43f0063c3d69).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a48d87ca9b4e0190973077cad8d0d6946)OnArmyOverlaySetDirty()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnArmyOverlaySetDirty | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4745a9da06bdea51ec07429a999ef5c1), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3cb6b0f6446b83418f9e2aa64c29f92a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad8db9a572572bf68ae4a7c36dc869344)OnPlayerDesertedBattle()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerDesertedBattle | ( | int | *sacrificedMenCount* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afbef08d8b634851eb401aa1dd0b145ae), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afba953fa6ba9ffe4ce4c579c8dd01a43).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a761fc245fa9776d0992839882747fdbd)OnPlayerArmyLeaderChangedBehavior()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerArmyLeaderChangedBehavior | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aac2877550d5ec45262d6e73dc6c9cb7b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aab9879a75a179badaeb5f3284b07c395).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac49962f703db44ac19cd193e4505201a)MissionTick()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.MissionTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab4d76a6945672f9316be0927d2f30521), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab7503ef6a1cf487269340ca882929fe5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9b57951e17afe64ae22769ca11616785)OnChildConceived()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnChildConceived | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *mother* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6490e396e2fca65af871f32ff199c479), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac157502e07ccc9cb8cdc9f5151b83ffc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a552912c267589be8430cabef7b08b981)OnGivenBirth()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnGivenBirth | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *mother*, | |  |  | List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | *aliveChildren*, | |  |  | int | *stillbornCount* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abeff63dab03bea5d342bbc3e2a561ffa), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae9f2d1954e01d6d0955025b1bba2487).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab72ecd3343c3d04c0e1ede65be378dc6)OnUnitRecruited()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnUnitRecruited | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | int | *amount* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7983388ac7efc4b6dda108f6a360527d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5bf2844e9edeccb524d975f198248db0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9da462a29263d571d88a25ff8cc6fc39)OnPlayerBattleEnd()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerBattleEnd | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7b71d8771f34a39d0d023e168e816e8b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a08f718b07c7a1fdd737e4a2653477d11).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af4c7984de81c44b47d2a9656ecf6f54c)OnMissionEnded()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMissionEnded | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *mission* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4e0ee798d470b3eab979b06025bd829d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5fc927af05ae7412962d6818ecff79c7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7318f8837165f380a312160c0ad0b707)TickPartialHourlyAi()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.TickPartialHourlyAi | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6df5a545dfd322be529215b4f908db38), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae99ab550043cca1ca3fc8453dc6a26b8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad182750b43c6c39495c21838d4b33488)QuarterDailyPartyTick()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.QuarterDailyPartyTick | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9f7357b330be3fed497c4983b056decd), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab98ec41074e42da81ee9b09f003aeac9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a11d99dce4f8a008cfa53165641c5655b)AiHourlyTick()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.AiHourlyTick | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) | *partyThinkParams* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a21052b4a653f71e29a2138f9bee0e1d5), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ade3a332a43f4dcda2914e6fed8b0e592).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1c4ea3f46ce568e82cc17f2ed71449d9)HourlyTick()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.HourlyTick | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0411aa9c88131d89a4e9f53a845211d2), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aad723d766000f4e6d0682b21ddf558cb), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a5dbf0368fe7823323ef31cc0a74393e0), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ab13088bdd37386c067fc164f470001b1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa74fe2e776ae40603801b2b9f9b5afa4)QuarterHourlyTick()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.QuarterHourlyTick | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af0fe4dc2344867f3f6b65855578ae010), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4c992591ed185f80d6956a1265777f46).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8eec0bf986fd3326ad97a265bb96cf26)HourlyTickParty()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.HourlyTickParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#adbd2fdc691f8dcbbb092634f6f49c768), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2cf540a8f0ef526f7e57858e62c4dea2), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#aa80c84a1cdc853c10f4bc73f06de0aa9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1c4a127283bb458a6f213d4bf504a4d1)HourlyTickSettlement()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.HourlyTickSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae0ef4abec1bdf34389c0763a291c4a86), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8fa49412559859bc7dbe8712555e0266).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0f244bfb309f90d1cd1a53f8c3e8fc2d)HourlyTickClan()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.HourlyTickClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a60b7267cbd8bfa39f00704f59b80a893), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adda2b33b5f748245946287ef5f0b473e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6eedfe629de9e36844fb39cd0d928616)DailyTick()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.DailyTick | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aea2a985d99cd5b2362f822e43fbbb39e), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3e06ad4c97c8c69d360c6a40e870a4b9), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a979d4cf481fe3281953f925c3f521ac8), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a558fc3bbe450c949ccc7f475fd5a10e8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a314bdcb0d4cc67abaebe8c105b181c2b)DailyTickParty()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.DailyTickParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6dd05507ae9e999e11f1ae02546884a9), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7290e87cf0c7faf8ec6a0cec197a3371).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a366aa186af37cc2a654931cc6942c1a6)DailyTickTown()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.DailyTickTown | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac74fb6635bfd17667cb7e168dd57e62e), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a94a5498e6e72138c909ed6a671700e80).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afadb083b69a3716a035aa6311cb3bcea)DailyTickSettlement()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.DailyTickSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abe4d387a96bb3413c6baa01f46aae202), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4abfc80ccb94823085307639a4cb56ef).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a50deef6dafd5a6b652961a76b03b28f7)DailyTickClan()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.DailyTickClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a46e3959ac62d0df29b2f27a8d0267d2e), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a563dbd72cd8648cd0f9e3eaf247cf9bb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a42192abcd3dc3b1b2afd793d4c6e2c34)OnPlayerBodyPropertiesChanged()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerBodyPropertiesChanged | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1ebaffb3b6e98751ac57fc63dba500de), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3c1ea7f70bdf56bd222b5d5e5525e746).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5e9351f1758fd0d98bd9627365bc706e)WeeklyTick()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.WeeklyTick | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a14a84de507118ddcdf8e1da6343bd2d7), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7c29dbd1e6a65888ac64d2eb2b011816), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a40a666b92e130fa6ff711651ba445302).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a21ff92c0a4d675ca6489ffde3e65f31f)CollectAvailableTutorials()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CollectAvailableTutorials | ( | ref List< [CampaignTutorial](class_tale_worlds_1_1_campaign_system_1_1_campaign_tutorial.html) > | *tutorials* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9aec43c9e88434723e526916d889eb2f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac578eda7cdbbf6d2931ac7467ce2af4f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a172bbe9254827d489a5c005b32f1ace5)DailyTickHero()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.DailyTickHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8a61214d42e89804dca3fb9147b6199d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7e0d4234db4e6b1f26a2d24ed3de654b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a616361c9445050c5a2c6f2ff6891f6cf)OnTutorialCompleted()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnTutorialCompleted | ( | string | *tutorial* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afaad870aab2497fbc088b0a4aaf3be5f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af31962e7a9be267f0411f636c7a976bb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a872484253aa14e7bb8be553a81b50cce)OnBuildingLevelChanged()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBuildingLevelChanged | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [Building](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_buildings_1_1_building.html) | *building*, | |  |  | int | *levelChange* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab808591785e1a563c38740156f7cdab5), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a452fdc29faee509003739fb3eb35416d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3582e248084d5133e87cd1c999f6e6a9)BeforeGameMenuOpened()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.BeforeGameMenuOpened | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aea6a663ef8aea3d2cdfcf53f69ceee26), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5e2ca78337f6d3539c0f1ea8a3fe3a63).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a405b9daff956f2a1a7c4d2e367311315)AfterGameMenuInitialized()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.AfterGameMenuInitialized | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5e67818e26dc05be6b06a9d3e6368523), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a80e7dc0e4c62ae6704259453e8b8ec26).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a375225dfed41289db077577caf986ba0)OnBarterablesRequested()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBarterablesRequested | ( | [BarterData](class_tale_worlds_1_1_campaign_system_1_1_barter_system_1_1_barter_data.html) | *args* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afdc204663b150a7a82cb01c352d0f7da), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2981d4d336f58aab209b8f380d91e9e9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a41385b937b64a01c0adf9b3ac60f809b)OnPartyVisibilityChanged()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyVisibilityChanged | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a90f3623cf7f6f4eef906ed8cf4c8da26), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a669c06128c66b12f9c8ec4499e3506fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9d56353914130b307ef8862259573d14)OnCompanionRemoved()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCompanionRemoved | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *companion*, | |  |  | [RemoveCompanionAction.RemoveCompanionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_remove_companion_action.html#afebe445a9fd9044486e94c0db1b931ef) | *detail* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa9443d525d03fef6f92dc580eef79dfc), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9e1a55a0a980fd9e138b44f352765dd4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abea423068f95d08a933d05592fd1c75a)TrackDetected()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.TrackDetected | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a963019088b53482125f824856026b9bd), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a55712afcdfa91a01d1696e637d8cf42c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5491752d533283178cc29f9bb6d068c2)TrackLost()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.TrackLost | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a833acbbc202f81aa45288aac0b5aa43b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf86ef22f2cb211d8bb0d3a7daf29dd7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4144e9473f03cfb82de327978168a7b4)LocationCharactersAreReadyToSpawn()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.LocationCharactersAreReadyToSpawn | ( | Dictionary< string, int > | *unusedUsablePointCount* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b44c98610918d78c0bd3804217c140c), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8184b7310de2764ad405fe8fe51e72b2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a79acccb94610f2e4937cbd925dc759a2)LocationCharactersSimulated()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.LocationCharactersSimulated | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7918a471a0785842f08d4be6f3aa1ce7), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a73f74401ffa0b0dc8f118d0b13375fae).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9958864ae44837589d7187f2afa06a90)OnBeforePlayerAgentSpawn()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBeforePlayerAgentSpawn | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *spawnFrame* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aedeb8e4dcfaef223daa7e3153338d2c5), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac89cdb1b6dd5b40718ac702dbc549aba).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab8ba2dd4267664efab7faf52d64808e5)OnPlayerAgentSpawned()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerAgentSpawned | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5f7bfcbaa25433717e49c06175e75f3f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aea30d2899ca249abbf1b17cfb159f24d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab58f89386e7a027c6eceb6d20740b9cc)OnPlayerUpgradedTroops()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerUpgradedTroops | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgradeFromTroop*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgradeToTroop*, | |  |  | int | *number* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8d5608db958ea96c0ff8d7e0300e2eb9), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3075599224bb4b78b7716db45a5f580c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a98b7f06624c7d920d82aef18bd6f9a64)OnHeroCombatHit()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroCombatHit | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *attackerTroop*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *attackedTroop*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *usedWeapon*, | |  |  | bool | *isFatal*, | |  |  | int | *xp* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abf2a235f22b11798f137d1bd7c7f59d5), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5991b65f5382060d2f1df4b463efc70f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afdb992d08aca0b0a06e2711b1268c293)OnCharacterPortraitPopUpOpened()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCharacterPortraitPopUpOpened | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aee42ec6fac27bd4def6c835ba4984433), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aed3010eaf7cbd14884058de55d9a19ce), and [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a1b0e308cccbee5a47eb4d7bdb67364b2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aabf775870c5bb7dff811d5076b5883c7)OnCharacterPortraitPopUpClosed()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCharacterPortraitPopUpClosed | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa545bd48cbd7b54da14b0fb226dba612), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9d19b34ca706bc37143b34f07b58b614).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1115abb47b46ddd62a512e67b58d7ea4)OnPlayerStartTalkFromMenu()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerStartTalkFromMenu | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4e53e4fa3c398a5926d3ab891af6b685), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a980b851ed81c28dcbc66294275f41d79).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a694849371b5335c9b8e1f05b025fa5be)OnGameMenuOptionSelected()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnGameMenuOptionSelected | ( | [GameMenu](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html) | *gameMenu*, | |  |  | [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html) | *gameMenuOption* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3c1536ede88489a93f310134298eb86b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a740099b28f0a10fb6e99485ceaed58ed).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a14303cbfa6ff9454bbdabf6046e18652)OnPlayerStartRecruitment()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerStartRecruitment | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *recruitTroopCharacter* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afc70cf5e77451ff4231ffe27a9696fc4), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aae2eea29b669d7044b783379c82083a9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a64011b94834dfced52f276974f6d16b1)OnBeforePlayerCharacterChanged()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBeforePlayerCharacterChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldPlayer*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newPlayer* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6f2279cbd5f2a2a3b3c791065fabf19b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9d56bad917fb3c175ac0caceb1a30b4c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a80a199ed5541ed86fb6cd5c820a8928c)OnPlayerCharacterChanged()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerCharacterChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldPlayer*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newPlayer*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *newMainParty*, | |  |  | bool | *isMainPartyChanged* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5cab6f8aa84e658faf46598b846c8837), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a771df6167dfdba0b359b413f6eb56704), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#af06b3aa681b8c497cf7494797ac70967).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abcbcd369d0bc1189b867b0477520bafd)OnClanLeaderChanged()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnClanLeaderChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldLeader*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newLeader* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abd4d51e956e561ef152b0384f365455b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a35fab67f070c9d67534dfd8886f333ed).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f6bcb872fed496e606a9a1537bed3be)OnSiegeEventStarted()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSiegeEventStarted | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ace66dec7e920d1f2378e8a3db30644c1), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3b09c1a1dcbce3556fc480f19397d57e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac056ce5c1c89bd4c99c37b126c6d9b4a)OnPlayerSiegeStarted()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerSiegeStarted | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a272f1fc8ab96dd18ed97d36946254b4c), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7b4519cfe927e26c5b8cc3fb6394650e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a04b227268da4e7079e1a66fcf80acc45)OnSiegeEventEnded()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSiegeEventEnded | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4d0c053a6062e7faf949ffab9ad81471), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8600568a132addc1aea60863c4a7b818).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a94d96e25e916273dac202b12353b91a0)OnSiegeAftermathApplied()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSiegeAftermathApplied | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | SiegeAftermathAction.SiegeAftermath | *aftermathType*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *previousSettlementOwner*, | |  |  | Dictionary< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html), float > | *partyContributions* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad1929bcb5a03892b73de7f76f6b7f39d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aff754b01912ed5af7251d863166311c2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a666de6d9a062ea8ced4651f550b50dff)OnSiegeBombardmentHit()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSiegeBombardmentHit | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *besiegerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *besiegedSettlement*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *weapon*, | |  |  | [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *target* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acd912d196eb2c152c845103ed7caa544), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a70f899b167bdd6abd751cc4ec474b9d8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6a86873ff9207ea3882694d3e8bb5bcb)OnSiegeBombardmentWallHit()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSiegeBombardmentWallHit | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *besiegerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *besiegedSettlement*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *weapon*, | |  |  | bool | *isWallCracked* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa823e3be5dca46963329e2fd1ff22ce6), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a21bb973fad9fa70cc171f161f487a7cf).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab18d10db3188ea0819948ff5d5ebce42)OnSiegeEngineDestroyed()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSiegeEngineDestroyed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *besiegerParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *besiegedSettlement*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *destroyedEngine* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a03a8a8949b18133f7de5369972cd7696), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abe788fb9a05f48347ce374811cd18140).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae38e70e8830d80182e27fd29f6469ddd)OnTradeRumorIsTaken()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnTradeRumorIsTaken | ( | List< [TradeRumor](class_tale_worlds_1_1_campaign_system_1_1_trade_rumor.html) > | *newRumors*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *sourceSettlement* = null ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4bba1264c58536c13b508ca404bcbf5f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aff39be1c69fcc01ae82c1977c97be715).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a047960b1b435d59d54408009dd5000dd)OnCheckForIssue()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCheckForIssue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a92d92fe632b58f1b7b9f89be98f2c814), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d8cbbe23ae0d7f976b4b321d8d85041).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae96c0f4c1c348d7a55ba3434ed5f474d)OnIssueUpdated()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnIssueUpdated | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue*, | |  |  | [IssueBase.IssueUpdateDetails](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html#a5a6b26c5d1d5fad12cd7b6faffede41b) | *details*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *issueSolver* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4b71ea9b2fff16bc00c3d749dfd7c6ca), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa44a138f7db89c7d904ef4959d9d38d9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acfda4979f29c66490f6e93d9cb80b513)OnTroopsDeserted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnTroopsDeserted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *desertedTroops* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a076381bb90d0c999acb40b25040d5eb9), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac08af8453b61667d41daed2da2dc1423).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab649fa58127eb99c1b38175e73c0a38d)OnTroopRecruited()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnTroopRecruited | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *recruiterHero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *recruitmentSettlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *recruitmentSource*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, | |  |  | int | *amount* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab4950efc3ed45279f2bb907242c277a2), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a885237729c71891b4d890a95e5d8df9c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5f30a5817691a5b20153fb0d3d514980)OnTroopGivenToSettlement()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnTroopGivenToSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *giverHero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *recipientSettlement*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *roster* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4404084960b181592de35373f3aa1340), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#acc7311fbc1afa9f86313818ee0e407ee).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aac3d9c50869d924aca98205bb4243972)OnItemSold()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnItemSold | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *receiverParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *payerParty*, | |  |  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement*, | |  |  | int | *number*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *currentSettlement* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa7854538621ac8b06faaedb472518cc4), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af3f8ff1f75d0c27fdc9daee01cf0ff05).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a154a99467bcefbb586b19b65b1cdbb90)OnCaravanTransactionCompleted()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCaravanTransactionCompleted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *caravanParty*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | List< ValueTuple< [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html), int > > | *itemRosterElements* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a39495f637148b0797f701d8d1cafdb87), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a64dadd17a96e6f7d020c0a231ff1ab46).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0f9a29cdbe6e8f47af23132fcd73dc49)OnPrisonerSold()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPrisonerSold | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *sellerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *buyerParty*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *prisoners* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1b09139010797e1d65d04cbfdd4b3398), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a307479f9a6b4e59b8605c7c701b4c053).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae580d6d15c25d986d63f801b137fbead)OnPartyDisbanded()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyDisbanded | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *disbandParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *relatedSettlement* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afc97878261ab06e372226ff71212ffda), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab8ebc6ef8478faf1a98707ebf2e25f35).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5843d230859c9560b27b7780fc5126bd)OnPartyDisbandStarted()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyDisbandStarted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *disbandParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a29586fa84cebda55747921b596a7b2fa), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a435f6000810da2d250a72add787ea4e9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaf395a07d55b70154e54b9b1d6306d14)OnPartyDisbandCanceled()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyDisbandCanceled | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *disbandParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acbbc3536f26040ea1ae81e688086217f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3977bcfdc68a5e5c0a90621bbce0c1ef).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2cd2abd5833057f8bf87612f959882b7)OnHideoutSpotted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHideoutSpotted | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *hideoutParty* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afba487b749c0abf30692716ae896d188), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a107d54d1af82cefe302890f102becce8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a476b40c0e2eff03ccb62cd67198e7cd2)OnHideoutDeactivated()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHideoutDeactivated | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *hideout* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae0bcc7e4cf1c730f24eeabbe4f35e39f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad45c246ac81b2700b130b527e7e4fbff).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34507ce845f04b6117d04a0dbbbd438c)OnHideoutBattleCompleted()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHideoutBattleCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html) | *hideoutEventComponent* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abecd876d4296f4e1b06182051d5b2a23), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ad2a823d8ba95841343603d955ee86164).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a38a3c030c58c37d32509be7309108484)OnPlayerInventoryExchange()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerInventoryExchange | ( | List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > | *purchasedItems*, | |  |  | List< ValueTuple< [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html), int > > | *soldItems*, | |  |  | bool | *isTrading* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9c21fe1a074e3a8f382d9460c9001b08), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5bbe4343eb8104ed525b6f0685736a8e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8b8d0b7de26833d92f2e1e533e2935f5)OnItemsDiscardedByPlayer()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnItemsDiscardedByPlayer | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *roster* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aaab148dfd82a57d968fee2731d1a31ec), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9c4b7274b83dec958c5edcc0bbce40cf).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6c488089d6f3fec0967dae048ddf15c7)OnPersuasionProgressCommitted()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPersuasionProgressCommitted | ( | Tuple< [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html), [PersuasionOptionResult](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#af96cf6cbd7b80fb4690c9143ff5841c1) > | *progress* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afb339a525be1bde4c554ff2bed482263), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aba49afafe5df9abc79f9a6d7e0133402).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad0562768c73b4c3bcb7f694365fbc158)OnHeroSharedFoodWithAnother()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroSharedFoodWithAnother | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *supporterHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *supportedHero*, | |  |  | float | *influence* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aff803c5d7f11d4858632ad3f8143944c), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac23827b7d0840d3b62a05719f697c650).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0722f718cc643befffb3cf46532f0634)OnQuestCompleted()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnQuestCompleted | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest*, | |  |  | [QuestBase.QuestCompleteDetails](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html#a23d16828fddb30cec76b1a8089a9e398) | *detail* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a78e5a2408e695fee00734612798906e9), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a590163c2f429e98618eb171012cf2fef), and [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a0377011b68e748ea00e49a3c7145af36).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a80121601a110e1d9254a0da5a85cdaf4)OnQuestStarted()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnQuestStarted | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5cc70018223dc9bbdcda48958cadfcd3), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a95a52b5bf670b4813849f148044a4b2a), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0c24e4e0fcc9b330759fc3ad416175c2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9169a1080e9bb2dadd9dc196d6b759e6)OnItemProduced()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnItemProduced | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | int | *count* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a33c20ee111dd5292350325f31ff7c82e), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af970d6e677f9701e31154b0d25674b58).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a00a463efddac32f12cdb487ea3726c4f)OnItemConsumed()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnItemConsumed | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | int | *count* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a61d7763ac7805f212e845f72a65b5ac5), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6bbccc22ee524c01f5794a5d2c4a4221).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9ec42fd3a836317d6aabe6fa54cbd45c)OnPartyConsumedFood()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyConsumedFood | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae2a4bf82ece383d1cd8f4e255a5f3f4f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3fab1e550f8d0a9c0cedb988a006739e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a296e155991bcadbcd057db1306bdb53e)SiegeCompleted()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.SiegeCompleted | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *siegeSettlement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | bool | *isWin*, | |  |  | [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) | *battleType* ) | | virtual |

Parameters
:   |  |  |
    | --- | --- |
    | siegeSettlement |  |
    | isWin |  |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a92a93211e65baeb4824e8ff12bc7f385).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa3366fb9d461ec7a6de88bb42d561441)AfterSiegeCompleted()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.AfterSiegeCompleted | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *siegeSettlement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | bool | *isWin*, | |  |  | BattleTypes | *battleType* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0b7019d99b625d0bbecdd33eb3568bff), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab68f5a364a913a868eae27dd9d1d7a1b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6543dce7ae5422f511800117488e01f8)SiegeEngineBuilt()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.SiegeEngineBuilt | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a97ee2804147fb49b6bba6012d4649b0f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7ee58a8e2e02a0f58f1178a6ef811ce8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6631550f84b65e909d1c177602a6e6e2)RaidCompleted()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.RaidCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html) | *raidEvent* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1d17aebd3e0449f13286e4cacb3546e4), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a08926b9adb1e89de8902d1988ef7863e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a459da0fd4ab5b8a60b9c890f43a10ccf)ForceSuppliesCompleted()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.ForceSuppliesCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html) | *forceSuppliesEvent* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afeba6e9598f84547316035242929a13f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aadc9886963dd925a2035d3e697b144e3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a34850c45926553d8c8dc9e687bfd13fd)ForceVolunteersCompleted()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.ForceVolunteersCompleted | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winnerSide*, | |  |  | [ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html) | *forceVolunteersEvent* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9f2f63852995cad840181a069ed922c4), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a1c2a775f5f0f4275d2b134c1370ea6c6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa290b1325d6b07ac06a0611c7b0449ee)OnBeforeMainCharacterDied()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBeforeMainCharacterDied | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, | |  |  | bool | *showNotification* = true ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab739089858407aa99bc0dba3438bf7e2), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aef0c1a585b3255257bdb0ad3c9201f83).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3f72e0aff76dcdc8cf0019607b406435)OnGameOver()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnGameOver | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0ae0cc0b989968d012bc77a0610ff180), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2d9dcc25bb52fe26844a5b37d2dae455).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6fd8e156fdfaa49ae41bf1e0d2b1beda)OnClanDestroyed()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnClanDestroyed | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *destroyedClan* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0a222eb29ee8a8d745a1af9d64d5529a), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a47bd07c99a4646f9a1c54f1294e30b8c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a797486987494c0ebdb1c732af849f3b6)OnNewIssueCreated()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnNewIssueCreated | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a97b7235e67f3a00b092faee99037483d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abc0ff17b85929f8d4abd1266440c612f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8beb35652e74a4e2f93455849af59c0e)OnIssueOwnerChanged()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnIssueOwnerChanged | ( | [IssueBase](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_base.html) | *issue*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7b598a79bca3629cd2eaed574454ed58), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2e2a9e8bcdc8ce02f8a1e2a27b55b261).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a501a665e70d0c652e349c3b321f34430)OnNewItemCrafted() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnNewItemCrafted | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a9618f4263e5934975be5401c61736fe7)OnWorkshopInitialized()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnWorkshopInitialized | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9f8551264ae776b51dfb5963a0166857), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a20b71a38397105f87e43f3097e523863).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afcc35d1b1e67aaaaa91a55d551a11e2c)OnWorkshopOwnerChanged()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnWorkshopOwnerChanged | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2af2cf8a2bf8bbf4f5adf71b541b6b9a), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afc07d766c9aeba8c29c7538529accdb1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa16c9c5697a3ec6f58d0d2b1e96d7841)OnWorkshopTypeChanged()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnWorkshopTypeChanged | ( | [Workshop](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_workshops_1_1_workshop.html) | *workshop* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa545d792549ae463d12d372f518f3c24), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a754d36b51ec66c6e7186bd57733b4c0f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aab97ff9ba3547cec53d5b9601e926110)CraftingPartUnlocked()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CraftingPartUnlocked | ( | [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) | *craftingPiece* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2c30f4995fd1f019448b93034b190b8d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a367a81bff4b70539bab2ca4732eb829f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5980e578f147e20215ced59a04f0766f)OnNewItemCrafted() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnNewItemCrafted | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject*, | |  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *overriddenItemModifier*, | |  |  | bool | *isCraftingOrderItem* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af778c766565f0015798493416bf2a3ca), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae38df8a3f3b010c8057558b55fd30c28).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a46f4e356ccd54b097f802cd91fc9df46)OnEquipmentSmeltedByHero()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnEquipmentSmeltedByHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *equipmentElement* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4daf25e8a08e5dc3d4fc21dddfdb42c5), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3d7eed04b14753e71ce77cdf5f4de78f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a75e93c7e63b080e226b80f2dd339c568)OnBeforeSave()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBeforeSave | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aeaf7692287a7cf63ab883b50242ce3f4), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6baca90336dae590cc1eda727acc7ed4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af7bb92bc1db0a74d85b8c363bd8edb2d)OnMainPartyPrisonerRecruited()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMainPartyPrisonerRecruited | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *roster* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a147a5cd6e0aa9b636a0dd5c0b93b4c97), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae880ee9d300bf88029e5bcee2d4ede7b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac44d5c1dc977f3c195612e48fc80999e)OnPrisonerTaken()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPrisonerTaken | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *roster* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aafdefb5bc8ef4b43107e7c118e17839f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afe2e2e61e4b0bb44292758a1de74ac35).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad5622914ebc0442414760a747799d76f)OnPrisonerDonatedToSettlement()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPrisonerDonatedToSettlement | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *donatingParty*, | |  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *donatedPrisoners*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *donatedSettlement* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#afa9f4ef080192766792115d774e66b04), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aaa7455ce9f24cb66cd84478dd9866a08).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4793a0025d67692ca65cab7d9c866317)CanMoveToSettlement()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CanMoveToSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5eaafefa05ad0cc72705883be4639f22), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af3bf4ff02accf19f9618a4f1e5526e78), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#aeee346ff5b5f5b2437b4bd95d773d802), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a90e2446450f05584893bcef2dca012a2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acb3aef6fb1a771ef7d0519491462ccf9)OnHeroChangedClan()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroChangedClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *oldClan* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac3b4584cfa89b3ef602ee92da05bcceb), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a74e8eb9bb1b8a35d74beaba53f0567ce).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0b1778170b8b1e9f08d84a8485dc673c)CanHeroDie()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CanHeroDie | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *causeOfDeath*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab82b5bc212d25f8d608742885062daba), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a307419eaf4b9f064ab01038a3122de6a), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a5c982c2c0f88f6e0c39bf87a14335a63), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a55ead9728556fe2f11a263fa2b0ce53f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af03a06a9e937ab8ceefeb1b2584fdf22)CanPlayerMeetWithHeroAfterConversation()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CanPlayerMeetWithHeroAfterConversation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a02baa7b1ebdab83422754913248bb611), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a74af2b301b82cae5cbc62d3590233fba).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ace775570f432474d242258663c80849e)CanHeroBecomePrisoner()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CanHeroBecomePrisoner | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a247f7f30efe6d5dc4148d48e469b1204), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#adf22960a231b4f8b92d2cbb7139c2548), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a4cb5a2788d1cac85b6d12e53bebdce6a), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a77d97bd419b8c74e3ff005f14b707d0d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad71470980290f2d55166a618d637db9e)CanBeGovernorOrHavePartyRole()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CanBeGovernorOrHavePartyRole | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a93cd128b1a1b11505ce879cd240fe333), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a760a2c75593934dfe47204d529e392aa), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a491e0afa74a0f2d795e584c6a415855f), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a795f38aa9331676e7b85cc2cda490302).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2e7eeee5baaa97c7e5988c00ce06045c)OnSaveOver()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSaveOver | ( | bool | *isSuccessful*, | |  |  | string | *saveName* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ac8671e97871fd97c11437b24ce2c7eab), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a3c6e4e27a8a51ea5c0acb4d477afde4f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3800ff42e205d4cfb09aab0c7dd3c0c8)OnSaveStarted()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnSaveStarted | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4f67ad2a595842e4307c7713f3cf65f6), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a5b716570f1d56f4771ce15f0485c0a6a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8527e4986c0e3cf7a581da7cf19187fa)CanHeroMarry()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CanHeroMarry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#abb26f31b1a0230e4dd107af1591044be), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab5b640f02a7f00a59d396111d4a407ab), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a78017a5b429618f0a47d7bcd5b73d080), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#abb22d4ca9ca80450c00a57c7d34e0210).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ab00fcec3aacef57c81c31a481511e086)OnHeroTeleportationRequested()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroTeleportationRequested | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *targetParty*, | |  |  | [TeleportHeroAction.TeleportationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_teleport_hero_action.html#ac67518fca70154d9927550a575e50c90) | *detail* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad052fcee6c17979298ee5eeb08b712ea), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af00814a5685f3517528100648d549428).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a278eba1bc1a9b773e8ddf8f77ec7a004)OnPartyLeaderChangeOfferCanceled()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyLeaderChangeOfferCanceled | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9aa9955161536d87de2aaafed6141b9f), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae1b0f4b6029170ca040c45c088565323).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1a54daf70ee1d2f5a28f1572d63180a1)OnPartyLeaderChanged()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyLeaderChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldLeader* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a2bf55c46dfb35efc894298f5b1c4829d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af7f0c2dca43d3ab6f4e987712fb019b5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad46b74e2a3930b813499c484338e6880)OnClanInfluenceChanged()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnClanInfluenceChanged | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | float | *change* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a15def105aa99e64276d5ecd3b83bd34d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac1ef125cf47fb19c4ca6cd4b34dc1727).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5e085b092f6b313fb08f3104fa5989e4)OnPlayerPartyKnockedOrKilledTroop()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerPartyKnockedOrKilledTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *strikedTroop* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9e5e2e15a213d76e250f4314eaee0e5a), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6bfac288f3b477ade7d4b6a951dc7225).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ac9abaf7d14174ccda495abd40f0fd4d3)OnPlayerEarnedGoldFromAsset()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerEarnedGoldFromAsset | ( | [GameComponents.DefaultClanFinanceModel.AssetIncomeType](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_clan_finance_model.html#a159462a38a47083df801bdfad2d24e50) | *incomeType*, | |  |  | int | *incomeAmount* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acd08fd36d848e36cbbae86b12e7ae7c7), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a714a13cfe1733fb5e5c1bccba85c4aec).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8dc8752dc68807900227f4a48bedfd6d)OnClanEarnedGoldFromTribute()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnClanEarnedGoldFromTribute | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *receiverClan*, | |  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *payingFaction* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1da444193339c51c687f65f792246c64), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2e244df9b61b9fce3a98d3311e7ff02f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aaa48a85629d5eab820e833109536c1b3)OnCollectLootItems()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCollectLootItems | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *winnerParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *gainedLoots* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a40cd5d7d7cf74c2025f847ce81b5e92d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af413d80eaa6bb562de87e9c5d2b9e889).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a520767a6cdf6339bc7b643a91eefe842)OnLootDistributedToParty()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnLootDistributedToParty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *winnerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *lootedItems* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9b112d9cd54fd38369018413a4687b52), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#abbf01e33a0ee2e404837ffa6e9d7bc61).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adba59a048dccb310ae93e9e80adcd8b0)OnPlayerJoinedTournament()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPlayerJoinedTournament | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | bool | *isParticipant* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad0a706641928b5e8791d8c2784f96ad9), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa1ea406df227702480c5060e0c765134).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0534f5200e010106be8c7f7885edf1fc)OnConfigChanged()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnConfigChanged | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3b515d37668464af1081ca997d9aeb03), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aac6ba2a5762cda5ea247ef2f9d4e2006).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8e7ae269f45c9b02e1d9008c3f5bbd1f)OnMobilePartyRaftStateChanged()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMobilePartyRaftStateChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad5aa09a30e5b9ecee991d911b63881e8), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9be9362f53d1f154f2dacd0512bb735a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a499f973fe9a231418750e8e36bae0416)OnCharacterCreationInitialized()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCharacterCreationInitialized | ( | [CharacterCreationManager](class_tale_worlds_1_1_campaign_system_1_1_character_creation_content_1_1_character_creation_manager.html) | *characterCreationManager* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3ce8248851309a782a1ebade755e9051), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a82a3649d2950a413904ca588159217ef).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a948c718e3662d8dc65a58b64d8738b44)OnShipDestroyed()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnShipDestroyed | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *owner*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [DestroyShipAction.ShipDestroyDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_destroy_ship_action.html#a52f9b7dcd67d7a49fc241de25137f7d1) | *detail* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5a41695310f2fab3eaf292d1ed6e327a), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a288bd16bf1f01d0b663c6ae9ab896f89).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a109dc611f24cb27bac0bbc8a498b0ac3)OnShipOwnerChanged()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnShipOwnerChanged | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *oldOwner*, | |  |  | [ChangeShipOwnerAction.ShipOwnerChangeDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_ship_owner_action.html#a4c22b9d8d2c3ee8b9dbadb809d61235f) | *shipOwnerChangeDetail* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab31ae13444f0d6393628123731188a10), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a6d65a54de0b4220df0286d86bf9a6065).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a04de735972ec8a5f3100bbfa85f6a245)OnFigureheadUnlocked()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnFigureheadUnlocked | ( | [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) | *figurehead* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a08005455615c52a5903978d5eee30ef9), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a303dde4b23a13858a2028ab9a737cd24).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7af6a0e0fffc671bffadc3141d82ce9a)OnShipRepaired()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnShipRepaired | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *repairPort* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af89e7ba7713491182dfd738f8554b96d), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2674612a72b7ce207753f103b6021e7a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ae9ffeade5f828b9a1fbd1f93ebf61428)OnPartyLeftArmy()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyLeftArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a70859458ed6ac7cc68927c6b5c05e455), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a83262ca5921e46d62b2f206628c37263).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aeb1b212b7702dbb455fc139aebc86f5e)OnIncidentResolved()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnIncidentResolved | ( | [Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) | *incident* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4bd08f702d13ef00d9ae4161a38f1b69), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#af6fc2561f174c11931e07734e33f42d4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af224cc53faa894e55efbdc61df7c1420)OnPartyAddedToMapEvent()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnPartyAddedToMapEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0c9bad0bfc7aafeab89ba29d0b639cc3), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a0be68db04a54a9d784d642ab527ec013).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a32a3229f31b225842e3719a8857e241c)OnMobilePartyNavigationStateChanged()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMobilePartyNavigationStateChanged | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5fa5cf0d1b556a95699a076c7ef727c4), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a201c380db46ce38ddcbe118fd61d1e73).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acb9777179473e1e00f7a3f4eb3d80999)OnMobilePartyJoinedToSiegeEvent()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMobilePartyJoinedToSiegeEvent | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a855355f753c1e56611696cd3d69fb4e8), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a2c36af71d321b981547fe36a88aba290).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a56a8dc304af6f4c9a38d3debc9366ba6)OnMobilePartyLeftSiegeEvent()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMobilePartyLeftSiegeEvent | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4613ac289c2c9ad119e2768fe9e419a9), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a490bbdd1ff5e23125c1f44b1ba3e18f9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8e869f7664427be678ff273ec340f732)OnBlockadeActivated()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBlockadeActivated | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a8c4f535a4f65eeae738522c83f2084de), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a196ac6529370b56fd8897ec8a4d313e1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a7b3c5394f44442467ae00a7603aebc5e)OnBlockadeDeactivated()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnBlockadeDeactivated | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab2bce57b5c07c78554a729a5578940a2), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a4af8ecc5487a11bb09af354fcecba08f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aafd518d9378b18cd54ae69ee53c05955)OnShipCreated()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnShipCreated | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *createdSettlement* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a3e0b3640e3447c952f65fd1829c2908b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac39af14e59490ef9c76fc5e35319be03).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a38369e757c569b93cacdac7ebbcf4e44)OnMercenaryServiceStarted()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMercenaryServiceStarted | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan*, | |  |  | [StartMercenaryServiceAction.StartMercenaryServiceActionDetails](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_start_mercenary_service_action.html#a5861e61ec787655431332d6abb63721a) | *details* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a71152eeba9454b806890a25ad33f6727), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8d0ff302086846dfb8d38c418835707c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a276e0fae65b514dc3315369517f5388c)OnMercenaryServiceEnded()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMercenaryServiceEnded | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *mercenaryClan*, | |  |  | EndMercenaryServiceAction.EndMercenaryServiceActionDetails | *details* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a7042a8449525fa8b7193ab07286d5776), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a63c05aaf01ba940da08b86af0e84b1a6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#abf77449a7e77c1458bb7bb04b624099f)OnMapMarkerCreated()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMapMarkerCreated | ( | [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) | *mapMarker* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a0b67ac087f85fa21c314353522d1fe77), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab8df8071674190bb91d81b67f632cb4d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#adc1a52dad5da10a6060d97348ab2b04b)OnMapMarkerRemoved()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMapMarkerRemoved | ( | [MapMarker](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_marker.html) | *mapMarker* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a4d1023d60bad15ffe2a2c7b2ebeebf70), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a92823548d071b26ed58fcf554badeaf5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a86b1385ce8466223b86bba96b23493d9)OnAllianceStarted()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnAllianceStarted | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a5d298d2eac50c34dbd485486fdd82a9b), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab19d2e524c42aae3d196cbac276dabfa).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a776018fae9847480244d9ce0d6715e76)OnAllianceEnded()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnAllianceEnded | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom1*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom2* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ae014d1e48b109cf7b6daa4d2d9be5fca), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7d30fd14412cd6fcd6c1c49db1452a47).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa0bce07a59e9752cf0ac7e4bfaa66e38)OnCallToWarAgreementStarted()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCallToWarAgreementStarted | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa3315a732dad68a54c96023ec1e21911), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac4b263e6f660ca58d20e97e12ae7236d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3ed5af5ad91883f12190c4cd2366cbda)OnCallToWarAgreementEnded()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCallToWarAgreementEnded | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *callingKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *calledKingdom*, | |  |  | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdomToCallToWarAgainst* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#aa382b2df13be63e4f2a81fafba2d4805), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a7c4bf247b0f77d2d9c58b90a769c61c8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a86e4f4782d0f1b2be099ef4fe30b8716)CanHeroLeadParty()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CanHeroLeadParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a6f399d722d86f9d1162e2da45e5db878), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ae199ffd877366b7eecf95be012108ef3), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#aae549162caff248403115d0d912ef8fa), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0b7234e39d983d7ae8f3a823c687be0e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa15c74a738056e3bd158de34e5cbad38)OnCraftingOrderCompleted()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnCraftingOrderCompleted | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *craftingOrder*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItem*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *completerHero* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a60bd566f2131dfc18e0bfd684972429c), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#afcced854fd093fdc6c3c588678b01626).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a052182b302597c0703512d8df6277f38)OnItemsRefined()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnItemsRefined | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | Crafting.RefiningFormula | *refineFormula* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a57dc93db42ff464dbd3b041d56b59768).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4525748c4272953b82962a499a2616e9)OnMapEventContinuityNeedsUpdate()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMapEventContinuityNeedsUpdate | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a546e81985a1b03f3b5498726b61fb7ae), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9062b09aae280c4e15d36f1d347ad1b9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a093f73749d5a11dc6b783f76cda19891)OnHeirSelectionOver()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeirSelectionOver | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *selectedHeir* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a9fb6ed574fff7472bf2f33fb949603b1), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a52be4b7dfdaa648a7449a7e44e92b4e2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add98c2403df7ebb7ea5a106e5a1c6bac)OnHeirSelectionRequested()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeirSelectionRequested | ( | Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > | *heirApparents* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#acd431249bf5d9b400b4c133b9be8e4f6), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a52c927982c9ed2a86cd506eaca0408c0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2a3dacfbcba36e34194be6ab18b190d2)OnMainPartyStarving()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnMainPartyStarving | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#addeb4e9b75fa2ae3801a4593134f107e), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#aa2d3c6bbb233e913bf84f1f50864d97e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f8b1fec51e016490693052fec3ee4ce)OnHeroGetsBusy()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroGetsBusy | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [HeroGetsBusyReasons](namespace_tale_worlds_1_1_campaign_system.html#a74f96a6c3de3af13ac985228276ee611) | *heroGetsBusyReason* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a1a315e86747b4905b62af4c3d017491a), and [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a666c6764f22ac2518d67c2f702f5685d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a433faa50918c107ff0026aaac8470c27)CanHeroEquipmentBeChanged()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CanHeroEquipmentBeChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#af6ca841284bc788936f342e45f148222), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ab73b22257fac8821ea196fbe1fb43600), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a3305938f298af13e37cd7e1e0a2e4880), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a58577f1419d603d002f9102540e6d204).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6f50c9d7928844d7dab61293b71b90db)CanHaveCampaignIssues()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.CanHaveCampaignIssues | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ab0ca999f4b544e06e35592dec37e626b), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#ac799d3b8e891ed7075889dcc4cada033), [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#a72c8aaa11d19baa382259af5806e2180), and [TaleWorlds.CampaignSystem.QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a52824d51e6e5e15e8ae8e99c42c1af8d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a45dd08fc640c47170fc82ce3fd764dda)IsSettlementBusy()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.IsSettlementBusy | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | object | *asker*, | |  |  | ref int | *flags* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#ad4dce969b184fa3c80adce1bba493ca2), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a9feb4249dd8f2350df3edb3ca8907889), and [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#abeecda5eb749eb06cb96612f46fae354).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0be0a6d8f2b46360e13a0a2c0405207c)OnHeroUnregistered()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.CampaignEventReceiver.OnHeroUnregistered | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.CampaignEventDispatcher](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_dispatcher.html#a043b42b716d41e7f319567df181e8057), [TaleWorlds.CampaignSystem.CampaignEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_events.html#a8f918ef9a6674adbe46ee21f23548c87), and [TaleWorlds.CampaignSystem.Issues.IssueManager](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_issue_manager.html#ac110f0cbdde01aeae1d2b359a7b3d833).

