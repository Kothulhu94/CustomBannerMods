--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html ---

TaleWorlds.CampaignSystem.QuestManager Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [QuestManager](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a8121faffe939f9501bdb17b77692a354) () |
| override void | [OnQuestStarted](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0c24e4e0fcc9b330759fc3ad416175c2) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest) |
| bool | [IsThereActiveQuestWithType](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a26da4edea5a9d9bffd0b16555f9d591f) (Type type) |
| bool | [IsQuestGiver](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a545f3581b672824cef93ef6d6d1c240b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) offeringHero) |
| override void | [OnGameLoaded](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0904383965a9d3753f7ce59de7e4e54b) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [OnSessionStart](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ad158ee6b7be9b5223260f5e8ac6bee0b) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| override void | [HourlyTick](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ab13088bdd37386c067fc164f470001b1) () |
| override void | [HourlyTickParty](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#aa80c84a1cdc853c10f4bc73f06de0aa9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [DailyTick](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a558fc3bbe450c949ccc7f475fd5a10e8) () |
| override void | [WeeklyTick](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a40a666b92e130fa6ff711651ba445302) () |
| [GameMenus.GameMenuOption.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510) | [CheckQuestForMenuLocations](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a8f7c3e3573e060fa86418909c0d8fbc1) (List< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) > currentLocations) |
| void | [OnQuestFinalized](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a016d3b1eaa3c6662e6d25cef1103e897) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest) |
| override void | [OnPlayerCharacterChanged](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#af06b3aa681b8c497cf7494797ac70967) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldPlayer, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newPlayer, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) newPlayerParty, bool isMainPartyChanged) |
| override void | [CanHaveCampaignIssues](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a52824d51e6e5e15e8ae8e99c42c1af8d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroDie](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a55ead9728556fe2f11a263fa2b0ce53f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) causeOfDeath, ref bool result) |
| override void | [CanHeroBecomePrisoner](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a77d97bd419b8c74e3ff005f14b707d0d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroEquipmentBeChanged](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a58577f1419d603d002f9102540e6d204) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroLeadParty](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0b7234e39d983d7ae8f3a823c687be0e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanHeroMarry](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#abb22d4ca9ca80450c00a57c7d34e0210) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanMoveToSettlement](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a90e2446450f05584893bcef2dca012a2) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| override void | [CanBeGovernorOrHavePartyRole](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a795f38aa9331676e7b85cc2cda490302) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| void | [AddTrackedObjectForQuest](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#abb981937de22ca05c8f0ae6be6c937a8) ([ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) trackedObject, [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) relatedQuest) |
| void | [RemoveTrackedObjectForQuest](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0704aebf1b9e9cd3f8dff7a1c72656e8) ([ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) trackedObject, [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) relatedQuest) |
| void | [RemoveAllTrackedObjectsForQuest](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#af605a0a56e2c237ff5e184712a42b7af) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest) |
| List< [ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) > | [GetAllTrackedObjectsOfAQuest](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#af232314d3f28e924511b283ab99acef5) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) quest) |
| IEnumerable< [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) > | [GetQuestGiverQuests](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a60025c7751344b3b32d38e82d653d080) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html) | |
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
| virtual void | [OnAfterSessionStart](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa3cb8b037efd033c9a8232bee7d60eda) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| virtual void | [OnNewGameCreated](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a356b56d81b6ddc3abc0e62b821229808) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
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
| virtual void | [QuarterHourlyTick](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa74fe2e776ae40603801b2b9f9b5afa4) () |
| virtual void | [HourlyTickSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1c4a127283bb458a6f213d4bf504a4d1) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| virtual void | [HourlyTickClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0f244bfb309f90d1cd1a53f8c3e8fc2d) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| virtual void | [DailyTickParty](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a314bdcb0d4cc67abaebe8c105b181c2b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| virtual void | [DailyTickTown](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a366aa186af37cc2a654931cc6942c1a6) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| virtual void | [DailyTickSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#afadb083b69a3716a035aa6311cb3bcea) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| virtual void | [DailyTickClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a50deef6dafd5a6b652961a76b03b28f7) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| virtual void | [OnPlayerBodyPropertiesChanged](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a42192abcd3dc3b1b2afd793d4c6e2c34) () |
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
| virtual void | [OnHeroChangedClan](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#acb3aef6fb1a771ef7d0519491462ccf9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) oldClan) |
| virtual void | [CanPlayerMeetWithHeroAfterConversation](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af03a06a9e937ab8ceefeb1b2584fdf22) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, ref bool result) |
| virtual void | [OnSaveOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2e7eeee5baaa97c7e5988c00ce06045c) (bool isSuccessful, string saveName) |
| virtual void | [OnSaveStarted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a3800ff42e205d4cfb09aab0c7dd3c0c8) () |
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
| virtual void | [OnCraftingOrderCompleted](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#aa15c74a738056e3bd158de34e5cbad38) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) craftingOrder, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) completerHero) |
| virtual void | [OnItemsRefined](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a052182b302597c0703512d8df6277f38) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, Crafting.RefiningFormula refineFormula) |
| virtual void | [OnMapEventContinuityNeedsUpdate](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4525748c4272953b82962a499a2616e9) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| virtual void | [OnHeirSelectionOver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a093f73749d5a11dc6b783f76cda19891) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) selectedHeir) |
| virtual void | [OnHeirSelectionRequested](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#add98c2403df7ebb7ea5a106e5a1c6bac) (Dictionary< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > heirApparents) |
| virtual void | [OnMainPartyStarving](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a2a3dacfbcba36e34194be6ab18b190d2) () |
| virtual void | [OnHeroGetsBusy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8f8b1fec51e016490693052fec3ee4ce) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [HeroGetsBusyReasons](namespace_tale_worlds_1_1_campaign_system.html#a74f96a6c3de3af13ac985228276ee611) heroGetsBusyReason) |
| virtual void | [IsSettlementBusy](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a45dd08fc640c47170fc82ce3fd764dda) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, object asker, ref int flags) |
| virtual void | [OnHeroUnregistered](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0be0a6d8f2b46360e13a0a2c0405207c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [QuestExistInSettlementNotables](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a11b4ff4c4b2836508fc5b31da52314cb) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) questBase, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static bool | [QuestExistInClan](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a4b24781778db6f96934fd5124c49d6d5) ([QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) questBase, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [QuestOfferToken](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a2476846372a314ba1ae4a15b785bc418) = "quest\_offer" |
| const string | [QuestDiscussToken](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ad3fe2a16ee23bbae73b37019f40fa68b) = "quest\_discuss" |
| const string | [HeroMainOptionsToken](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a3483bcbd076414d48612c408be00a683) = "hero\_main\_options" |
| const string | [NpcLordStartToken](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a1be89195ee0d37f5b840ec29e3bda863) = "lord\_start" |
| const string | [CharacterTalkToken](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a35ef8d2b76813346f99681060001eb97) = "start" |
| static string | [PriorQuestName](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ad152347c1a596f30896c74acf836e971) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) > | [Quests](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#aa6590f015255e4732a5e37f1df0067d3) `[get]` |
| bool | [QuestDebugMode](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ab3dfe14edb04c163f110c84899794f98) `[get, set]` |
| MBReadOnlyDictionary< [ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html), List< [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) > > | [TrackedObjects](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a86e48a592c0f7d09b4ef8b04d996c574) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a8121faffe939f9501bdb17b77692a354)QuestManager()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.QuestManager.QuestManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0c24e4e0fcc9b330759fc3ad416175c2)OnQuestStarted()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.OnQuestStarted | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a80121601a110e1d9254a0da5a85cdaf4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a26da4edea5a9d9bffd0b16555f9d591f)IsThereActiveQuestWithType()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.QuestManager.IsThereActiveQuestWithType | ( | Type | *type* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a545f3581b672824cef93ef6d6d1c240b)IsQuestGiver()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.QuestManager.IsQuestGiver | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *offeringHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0904383965a9d3753f7ce59de7e4e54b)OnGameLoaded()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.OnGameLoaded | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4d442d24ad6a85982389a44c63a2eb14).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ad158ee6b7be9b5223260f5e8ac6bee0b)OnSessionStart()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.OnSessionStart | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#af6514672a01ba699cc915fbd282d2f95).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ab13088bdd37386c067fc164f470001b1)HourlyTick()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.HourlyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a1c4ea3f46ce568e82cc17f2ed71449d9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#aa80c84a1cdc853c10f4bc73f06de0aa9)HourlyTickParty()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.HourlyTickParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8eec0bf986fd3326ad97a265bb96cf26).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a558fc3bbe450c949ccc7f475fd5a10e8)DailyTick()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.DailyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6eedfe629de9e36844fb39cd0d928616).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a40a666b92e130fa6ff711651ba445302)WeeklyTick()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.WeeklyTick | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a5e9351f1758fd0d98bd9627365bc706e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a8f7c3e3573e060fa86418909c0d8fbc1)CheckQuestForMenuLocations()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameMenus.GameMenuOption.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a3ae8dc662b498f4848e37c9e527b4510) TaleWorlds.CampaignSystem.QuestManager.CheckQuestForMenuLocations | ( | List< [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) > | *currentLocations* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a016d3b1eaa3c6662e6d25cef1103e897)OnQuestFinalized()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.QuestManager.OnQuestFinalized | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#af06b3aa681b8c497cf7494797ac70967)OnPlayerCharacterChanged()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.OnPlayerCharacterChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldPlayer*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newPlayer*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *newPlayerParty*, | |  |  | bool | *isMainPartyChanged* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a80a199ed5541ed86fb6cd5c820a8928c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a52824d51e6e5e15e8ae8e99c42c1af8d)CanHaveCampaignIssues()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.CanHaveCampaignIssues | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a6f50c9d7928844d7dab61293b71b90db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a55ead9728556fe2f11a263fa2b0ce53f)CanHeroDie()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.CanHeroDie | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *causeOfDeath*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a0b1778170b8b1e9f08d84a8485dc673c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a77d97bd419b8c74e3ff005f14b707d0d)CanHeroBecomePrisoner()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.CanHeroBecomePrisoner | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ace775570f432474d242258663c80849e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a58577f1419d603d002f9102540e6d204)CanHeroEquipmentBeChanged()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.CanHeroEquipmentBeChanged | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a433faa50918c107ff0026aaac8470c27).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0b7234e39d983d7ae8f3a823c687be0e)CanHeroLeadParty()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.CanHeroLeadParty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a86e4f4782d0f1b2be099ef4fe30b8716).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#abb22d4ca9ca80450c00a57c7d34e0210)CanHeroMarry()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.CanHeroMarry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a8527e4986c0e3cf7a581da7cf19187fa).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a90e2446450f05584893bcef2dca012a2)CanMoveToSettlement()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.CanMoveToSettlement | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#a4793a0025d67692ca65cab7d9c866317).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a795f38aa9331676e7b85cc2cda490302)CanBeGovernorOrHavePartyRole()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.QuestManager.CanBeGovernorOrHavePartyRole | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | ref bool | *result* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.CampaignEventReceiver](class_tale_worlds_1_1_campaign_system_1_1_campaign_event_receiver.html#ad71470980290f2d55166a618d637db9e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#abb981937de22ca05c8f0ae6be6c937a8)AddTrackedObjectForQuest()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.QuestManager.AddTrackedObjectForQuest | ( | [ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) | *trackedObject*, |
|  |  | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *relatedQuest* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a0704aebf1b9e9cd3f8dff7a1c72656e8)RemoveTrackedObjectForQuest()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.QuestManager.RemoveTrackedObjectForQuest | ( | [ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) | *trackedObject*, |
|  |  | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *relatedQuest* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#af605a0a56e2c237ff5e184712a42b7af)RemoveAllTrackedObjectsForQuest()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.QuestManager.RemoveAllTrackedObjectsForQuest | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#af232314d3f28e924511b283ab99acef5)GetAllTrackedObjectsOfAQuest()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) > TaleWorlds.CampaignSystem.QuestManager.GetAllTrackedObjectsOfAQuest | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *quest* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a60025c7751344b3b32d38e82d653d080)GetQuestGiverQuests()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) > TaleWorlds.CampaignSystem.QuestManager.GetQuestGiverQuests | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a11b4ff4c4b2836508fc5b31da52314cb)QuestExistInSettlementNotables()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.QuestManager.QuestExistInSettlementNotables | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *questBase*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a4b24781778db6f96934fd5124c49d6d5)QuestExistInClan()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.QuestManager.QuestExistInClan | ( | [QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html) | *questBase*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a2476846372a314ba1ae4a15b785bc418)QuestOfferToken
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.QuestManager.QuestOfferToken = "quest\_offer" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ad3fe2a16ee23bbae73b37019f40fa68b)QuestDiscussToken
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.QuestManager.QuestDiscussToken = "quest\_discuss" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a3483bcbd076414d48612c408be00a683)HeroMainOptionsToken
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.QuestManager.HeroMainOptionsToken = "hero\_main\_options" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a1be89195ee0d37f5b840ec29e3bda863)NpcLordStartToken
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.QuestManager.NpcLordStartToken = "lord\_start" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a35ef8d2b76813346f99681060001eb97)CharacterTalkToken
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.QuestManager.CharacterTalkToken = "start" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ad152347c1a596f30896c74acf836e971)PriorQuestName
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.QuestManager.PriorQuestName | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#aa6590f015255e4732a5e37f1df0067d3)Quests
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html)> TaleWorlds.CampaignSystem.QuestManager.Quests | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#ab3dfe14edb04c163f110c84899794f98)QuestDebugMode
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.QuestManager.QuestDebugMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_quest_manager.html#a86e48a592c0f7d09b4ef8b04d996c574)TrackedObjects
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyDictionary<[ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html), List<[QuestBase](class_tale_worlds_1_1_campaign_system_1_1_quest_base.html)> > TaleWorlds.CampaignSystem.QuestManager.TrackedObjects | | get |

