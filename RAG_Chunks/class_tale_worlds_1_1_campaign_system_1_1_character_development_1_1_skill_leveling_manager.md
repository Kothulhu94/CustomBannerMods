--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html ---

TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [OnCombatHit](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#af25510d27df186ce3fee1133b121bad7) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) affectorCharacter, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) affectedCharacter, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) captain, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) commander, float speedBonusFromMovement, float shotDifficulty, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) affectorWeapon, float hitPointRatio, [CombatXpModel.MissionTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645) missionType, bool isAffectorMounted, bool isTeamKill, bool isAffectorUnderCommand, float damageAmount, bool isFatal, bool isSiegeEngineHit, bool isHorseCharge, bool isSneakAttack) |
| static void | [OnSiegeEngineDestroyed](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a314165d534b7c3a58d9c03a44aed2a65) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) destroyedSiegeEngine) |
| static void | [OnWallBreached](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a7310b7d9f09e2436ec4b6ff56b92d8a3) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| static void | [OnSimulationCombatKill](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a08667a47f01918bc296b706e877f4418) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) affectorCharacter, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) affectedCharacter, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) affectorParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) commanderParty) |
| static void | [OnTradeProfitMade](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#ae397c3155c906eff4a8260c39926b9b1) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, int tradeProfit) |
| static void | [OnTradeProfitMade](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a6a6d0dc775f117a6b0d28bf1afe7a1a3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int tradeProfit) |
| static void | [OnSettlementProjectFinished](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#aa2976675da8cf5f1a4a252c3157d4957) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static void | [OnSettlementGoverned](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a702b81ab8be646016c7e4e79367f3960) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) governor, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| static void | [OnInfluenceSpent](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a0405069b603575baafc3c76754f5d623) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float amountSpent) |
| static void | [OnGainRelation](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#afaaa6d4994ebef2b293b838766aecd92) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) gainedRelationWith, float relationChange, [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) detail=ChangeRelationAction.ChangeRelationDetail.Default) |
| static void | [OnTroopRecruited](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a87d73a17f2b3d02e0b1e7b8a15e7cda0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int amount, int tier) |
| static void | [OnBribeGiven](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#aebb6953d9bb47934a6d6a6e8f1744d43) (int amount) |
| static void | [OnBanditsRecruited](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a415ae20d778d1fce4cf43d1a5562a262) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) bandit, int count) |
| static void | [OnMainHeroReleasedFromCaptivity](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a57cf60497733cf26c59c27bd17d3c72b) (float captivityTime) |
| static void | [OnMainHeroTortured](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a8f725da5f9e5938992515bb1becd8e29) () |
| static void | [OnMainHeroDisguised](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a7ec4d817f78ab8eabcfcf334a60cc317) (bool isNotCaught) |
| static void | [OnRaid](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a05351fb3f9188824b2f86692b14eff3e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) lootedItems) |
| static void | [OnLoot](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#acb7d32e2cb7c632dc19d38c9a1ccd06c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) forcedParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) lootedItems, bool attacked) |
| static void | [OnForceVolunteers](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a5db1b1406c08149ab046bf32ea31fb2c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) forcedParty) |
| static void | [OnForceSupplies](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a6d6683e59d02fd8ad00a3d5a5ca43b91) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) lootedItems, bool attacked) |
| static void | [OnPrisonerSell](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#af57e1b6300f6d12f7cd982fc19b30f1f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, in [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) prisonerRoster) |
| static void | [OnSurgeryApplied](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a6de94601cc7298e37af446180bdf4593) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool surgerySuccess, int troopTier) |
| static void | [OnTacticsUsed](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a47cd15c112ea4db62fcc106ddd2ea8dd) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, float xp) |
| static void | [OnHideoutSpotted](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a15df29ba674c27e4cdfe61cc3d90f527) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) spottedParty) |
| static void | [OnTrackDetected](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a775203a61606e121e55ed000ad9bd9ba) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| static void | [OnTravelOnFoot](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#ac1b3663f62df7878149d7061e2f52d82) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float speed) |
| static void | [OnTravelOnHorse](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a30774222a079cbcb02d3e7f06f7fbe18) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float speed) |
| static void | [OnTravelOnWater](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a2235e03b98ffdcf6db5f714cd61468af) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float speed) |
| static void | [OnAIPartiesTravel](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a10ef70908089954703a7fa8a3d45d3d9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isCaravanParty, [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) currentTerrainType) |
| static void | [OnTraverseTerrain](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a43d3da1b8264561c5647fb5be83791b4) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) currentTerrainType) |
| static void | [OnBattleEnded](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#af72b6f6b527dac94de7a3439d098c280) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int excessXp) |
| static void | [OnHeroHealedWhileWaiting](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a4fab516d66be885b2067cfcb83529ca6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int healingAmount) |
| static void | [OnRegularTroopHealedWhileWaiting](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#aae51bda1887b786302f833748c0c7b42) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, int healedTroopCount, float averageTier) |
| static void | [OnLeadingArmy](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a1dd2a28f844e6c64fde04c0adf0982b7) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| static void | [OnSieging](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#aed7d196f04a4a461ea846dfa35dd07bc) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| static void | [OnSiegeEngineBuilt](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a9cd35e6c4329efbd502438c81acae79a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine) |
| static void | [OnUpgradeTroops](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a3aa6e6c0e381c6d4aff8c6dcd6952932) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgrade, int numberOfTroops) |
| static void | [OnPersuasionSucceeded](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#af2e2f10703ef7d21deb057f56b6c8627) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) targetHero, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) difficulty, int argumentDifficultyBonusCoefficient) |
| static void | [OnPrisonBreakEnd](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a73083d88a0cf1bd6df961d3598e583aa) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero, bool isSucceeded) |
| static void | [OnFoodConsumed](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a5f2956d69eaafc835992f1cdbbf3beb3) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, bool wasStarving) |
| static void | [OnAlleyCleared](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#ac3747a1c0de30cb3585a8bc0bcd7ba21) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| static void | [OnDailyAlleyTick](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a8b1925b949cb06f93dbb0edb19df6fac) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) alleyLeader) |
| static void | [OnBoardGameWonAgainstLord](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#adc676777496d3425384137f455b88b94) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) lord, [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) difficulty, bool extraXpGain) |
| static void | [OnProductionProducedToWarehouse](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#aa06d7c04beefe3eb43eb9b8899d3b311) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) production) |
| static void | [OnAIPartyLootCasualties](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a302771c159a4ea52eef6fa9d9fdffc1a) (int goldAmount, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winnerPartyLeader, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| static void | [OnShipDamaged](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#ab405263e0e033ec15ec3ac39f27bd298) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, float rawDamage, float finalDamage) |
| static void | [OnShipRepaired](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a6547dada26db9c0902df4bb1ac30e890) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, float repairedHitPoints) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#af25510d27df186ce3fee1133b121bad7)OnCombatHit()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnCombatHit | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *affectorCharacter*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *affectedCharacter*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *captain*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *commander*, | |  |  | float | *speedBonusFromMovement*, | |  |  | float | *shotDifficulty*, | |  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *affectorWeapon*, | |  |  | float | *hitPointRatio*, | |  |  | [CombatXpModel.MissionTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645) | *missionType*, | |  |  | bool | *isAffectorMounted*, | |  |  | bool | *isTeamKill*, | |  |  | bool | *isAffectorUnderCommand*, | |  |  | float | *damageAmount*, | |  |  | bool | *isFatal*, | |  |  | bool | *isSiegeEngineHit*, | |  |  | bool | *isHorseCharge*, | |  |  | bool | *isSneakAttack* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a314165d534b7c3a58d9c03a44aed2a65)OnSiegeEngineDestroyed()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnSiegeEngineDestroyed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *destroyedSiegeEngine* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a7310b7d9f09e2436ec4b6ff56b92d8a3)OnWallBreached()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnWallBreached | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a08667a47f01918bc296b706e877f4418)OnSimulationCombatKill()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnSimulationCombatKill | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *affectorCharacter*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *affectedCharacter*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *affectorParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *commanderParty* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#ae397c3155c906eff4a8260c39926b9b1)OnTradeProfitMade() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnTradeProfitMade | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | int | *tradeProfit* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a6a6d0dc775f117a6b0d28bf1afe7a1a3)OnTradeProfitMade() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnTradeProfitMade | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *tradeProfit* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#aa2976675da8cf5f1a4a252c3157d4957)OnSettlementProjectFinished()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnSettlementProjectFinished | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a702b81ab8be646016c7e4e79367f3960)OnSettlementGoverned()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnSettlementGoverned | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *governor*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a0405069b603575baafc3c76754f5d623)OnInfluenceSpent()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnInfluenceSpent | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | float | *amountSpent* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#afaaa6d4994ebef2b293b838766aecd92)OnGainRelation()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnGainRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *gainedRelationWith*, | |  |  | float | *relationChange*, | |  |  | [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) | *detail* = ChangeRelationAction::ChangeRelationDetail::Default ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a87d73a17f2b3d02e0b1e7b8a15e7cda0)OnTroopRecruited()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnTroopRecruited | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *amount*, | |  |  | int | *tier* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#aebb6953d9bb47934a6d6a6e8f1744d43)OnBribeGiven()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnBribeGiven | ( | int | *amount* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a415ae20d778d1fce4cf43d1a5562a262)OnBanditsRecruited()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnBanditsRecruited | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *bandit*, | |  |  | int | *count* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a57cf60497733cf26c59c27bd17d3c72b)OnMainHeroReleasedFromCaptivity()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnMainHeroReleasedFromCaptivity | ( | float | *captivityTime* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a8f725da5f9e5938992515bb1becd8e29)OnMainHeroTortured()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnMainHeroTortured | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a7ec4d817f78ab8eabcfcf334a60cc317)OnMainHeroDisguised()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnMainHeroDisguised | ( | bool | *isNotCaught* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a05351fb3f9188824b2f86692b14eff3e)OnRaid()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnRaid | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *lootedItems* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#acb7d32e2cb7c632dc19d38c9a1ccd06c)OnLoot()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnLoot | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *forcedParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *lootedItems*, | |  |  | bool | *attacked* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a5db1b1406c08149ab046bf32ea31fb2c)OnForceVolunteers()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnForceVolunteers | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *forcedParty* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a6d6683e59d02fd8ad00a3d5a5ca43b91)OnForceSupplies()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnForceSupplies | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, | |  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *lootedItems*, | |  |  | bool | *attacked* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#af57e1b6300f6d12f7cd982fc19b30f1f)OnPrisonerSell()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnPrisonerSell | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | in [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *prisonerRoster* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a6de94601cc7298e37af446180bdf4593)OnSurgeryApplied()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnSurgeryApplied | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | bool | *surgerySuccess*, | |  |  | int | *troopTier* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a47cd15c112ea4db62fcc106ddd2ea8dd)OnTacticsUsed()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnTacticsUsed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | float | *xp* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a15df29ba674c27e4cdfe61cc3d90f527)OnHideoutSpotted()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnHideoutSpotted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *spottedParty* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a775203a61606e121e55ed000ad9bd9ba)OnTrackDetected()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnTrackDetected | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#ac1b3663f62df7878149d7061e2f52d82)OnTravelOnFoot()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnTravelOnFoot | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | float | *speed* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a30774222a079cbcb02d3e7f06f7fbe18)OnTravelOnHorse()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnTravelOnHorse | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | float | *speed* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a2235e03b98ffdcf6db5f714cd61468af)OnTravelOnWater()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnTravelOnWater | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | float | *speed* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a10ef70908089954703a7fa8a3d45d3d9)OnAIPartiesTravel()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnAIPartiesTravel | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *isCaravanParty*, | |  |  | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *currentTerrainType* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a43d3da1b8264561c5647fb5be83791b4)OnTraverseTerrain()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnTraverseTerrain | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *currentTerrainType* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#af72b6f6b527dac94de7a3439d098c280)OnBattleEnded()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnBattleEnded | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, | |  |  | int | *excessXp* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a4fab516d66be885b2067cfcb83529ca6)OnHeroHealedWhileWaiting()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnHeroHealedWhileWaiting | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *healingAmount* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#aae51bda1887b786302f833748c0c7b42)OnRegularTroopHealedWhileWaiting()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnRegularTroopHealedWhileWaiting | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | int | *healedTroopCount*, | |  |  | float | *averageTier* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a1dd2a28f844e6c64fde04c0adf0982b7)OnLeadingArmy()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnLeadingArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#aed7d196f04a4a461ea846dfa35dd07bc)OnSieging()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnSieging | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a9cd35e6c4329efbd502438c81acae79a)OnSiegeEngineBuilt()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnSiegeEngineBuilt | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a3aa6e6c0e381c6d4aff8c6dcd6952932)OnUpgradeTroops()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnUpgradeTroops | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgrade*, | |  |  | int | *numberOfTroops* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#af2e2f10703ef7d21deb057f56b6c8627)OnPersuasionSucceeded()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnPersuasionSucceeded | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *targetHero*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, | |  |  | [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) | *difficulty*, | |  |  | int | *argumentDifficultyBonusCoefficient* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a73083d88a0cf1bd6df961d3598e583aa)OnPrisonBreakEnd()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnPrisonBreakEnd | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero*, | |  |  | bool | *isSucceeded* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a5f2956d69eaafc835992f1cdbbf3beb3)OnFoodConsumed()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnFoodConsumed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | bool | *wasStarving* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#ac3747a1c0de30cb3585a8bc0bcd7ba21)OnAlleyCleared()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnAlleyCleared | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a8b1925b949cb06f93dbb0edb19df6fac)OnDailyAlleyTick()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnDailyAlleyTick | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *alleyLeader* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#adc676777496d3425384137f455b88b94)OnBoardGameWonAgainstLord()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnBoardGameWonAgainstLord | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *lord*, | |  |  | [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) | *difficulty*, | |  |  | bool | *extraXpGain* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#aa06d7c04beefe3eb43eb9b8899d3b311)OnProductionProducedToWarehouse()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnProductionProducedToWarehouse | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *production* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a302771c159a4ea52eef6fa9d9fdffc1a)OnAIPartyLootCasualties()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnAIPartyLootCasualties | ( | int | *goldAmount*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winnerPartyLeader*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#ab405263e0e033ec15ec3ac39f27bd298)OnShipDamaged()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnShipDamaged | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | float | *rawDamage*, | |  |  | float | *finalDamage* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_skill_leveling_manager.html#a6547dada26db9c0902df4bb1ac30e890)OnShipRepaired()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CharacterDevelopment.SkillLevelingManager.OnShipRepaired | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | float | *repairedHitPoints* ) | | static |

