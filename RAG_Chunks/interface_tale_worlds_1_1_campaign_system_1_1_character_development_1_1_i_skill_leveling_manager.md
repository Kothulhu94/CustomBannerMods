--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html ---

TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager Interface ReferenceInherited by [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnCombatHit](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a21f0c2c6b96199b8657fec83bad4a3b8) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) affectorCharacter, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) affectedCharacter, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) captain, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) commander, float speedBonusFromMovement, float shotDifficulty, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) affectorWeapon, float hitPointRatio, [CombatXpModel.MissionTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645) missionType, bool isAffectorMounted, bool isTeamKill, bool isAffectorUnderCommand, float damageAmount, bool isFatal, bool isSiegeEngineHit, bool isHorseCharge, bool isSneakAttack) |
| void | [OnSiegeEngineDestroyed](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a53251d3c960aaaa7e426ccae3628b0b5) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) destroyedSiegeEngine) |
| void | [OnSimulationCombatKill](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ab6790a69485ce17febcfb652abe26b5e) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) affectorCharacter, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) affectedCharacter, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) affectorParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) commanderParty) |
| void | [OnTradeProfitMade](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aeab63d81d04f67327c2b32e65cb282ac) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, int tradeProfit) |
| void | [OnTradeProfitMade](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a6c2e81eba40befa4d75f2656907cbb77) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int tradeProfit) |
| void | [OnSettlementProjectFinished](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ad3c2b6696d55831f5b673db99814a8aa) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [OnSettlementGoverned](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a2c53bb6be59bff1df318d52c10196fa7) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) governor, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [OnInfluenceSpent](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aee9602b77fb004906d86df74d7e604f8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float amountSpent) |
| void | [OnGainRelation](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aabdaf03848c981268aba1b943cd61e29) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) gainedRelationWith, float relationChange, [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) detail=ChangeRelationAction.ChangeRelationDetail.Default) |
| void | [OnTroopRecruited](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ad9436d0b491d31a1fc12543bc3948e0e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int amount, int tier) |
| void | [OnBribeGiven](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aabf5d0780012af9cbf10c64f90d73613) (int amount) |
| void | [OnWarehouseProduction](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a8d6c9aad96dba1e902fc5c69a907e518) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) production) |
| void | [OnAIPartyLootCasualties](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a897b2f7d1e26844f5615dd564dcfe5c0) (int goldAmount, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winnerPartyLeader, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| void | [OnBanditsRecruited](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a2cadf3253ab05d4801ceb81aaf594c84) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) bandit, int count) |
| void | [OnMainHeroReleasedFromCaptivity](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a378d5caeb336a169c6c448eaac376ad9) (float captivityTime) |
| void | [OnMainHeroTortured](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a77dc698d80566d18c99aaafd263d66b0) () |
| void | [OnMainHeroDisguised](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aa45ffaaad3e9e6821beafaa56d986346) (bool isNotCaught) |
| void | [OnRaid](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a3857682b2ba99f16814200b7842e1915) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) lootedItems) |
| void | [OnLoot](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a0aa55a552a08b3a4f3b9a128c7df48a5) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) forcedParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) lootedItems, bool attacked) |
| void | [OnPrisonerSell](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a66ed0a10c819f81b26ef1debf9e68a3d) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, in [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) prisonerRoster) |
| void | [OnSurgeryApplied](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#af6340419f31b27e2434cf47f4712f29d) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool surgerySuccess, int troopTier) |
| void | [OnTacticsUsed](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a5290e6b74339186b6a030817a11cebe7) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, float xp) |
| void | [OnHideoutSpotted](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#affc10335eb3ad15154b0b89094143b2c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) spottedParty) |
| void | [OnTrackDetected](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a63b5fb2161fb698929a51a6a03512871) ([Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) track) |
| void | [OnTravelOnFoot](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a6190f3abbf23c52e3d388f07a97af7f4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float speed) |
| void | [OnTravelOnHorse](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ad5271afd268de73a06476682f52f106d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float speed) |
| void | [OnTravelOnWater](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aa61374946a0a7211b20dc0e199bd5512) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, float speed) |
| void | [OnHeroHealedWhileWaiting](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a57b7eec8691793eb7f1286af67cf4359) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int healingAmount) |
| void | [OnRegularTroopHealedWhileWaiting](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#adbd52b8a8b09cbb97f3d9e64197d97e7) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, int healedTroopCount, float averageTier) |
| void | [OnLeadingArmy](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a2d7aa1877d0d7f21d29a9daa728e5006) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [OnSieging](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#af661415c1438cf5df9f3dcf3470743f9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [OnSiegeEngineBuilt](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a3809e7609ec5391a71629aa94cc3add3) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine) |
| void | [OnUpgradeTroops](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a08c9d3eaba975ab9ea93fb7bc03fecf5) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) upgrade, int numberOfTroops) |
| void | [OnPersuasionSucceeded](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a6885c20a896006426f4d6836180df8f0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) targetHero, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) difficulty, int argumentDifficultyBonusCoefficient) |
| void | [OnPrisonBreakEnd](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#af02a56413cf537387fa42fbd7356463a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero, bool isSucceeded) |
| void | [OnWallBreached](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ac086d52ad49630e9a2e0aacad865fda6) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| void | [OnForceVolunteers](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#af63da91c0e1e3420acae05acac0879ad) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) forcedParty) |
| void | [OnForceSupplies](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a9d62318565f1e408cdeb0e8773c17be0) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty, [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) lootedItems, bool attacked) |
| void | [OnAIPartiesTravel](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a04455a30be4e6247f0c6b6151cde4c30) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isCaravanParty, [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) currentTerrainType) |
| void | [OnTraverseTerrain](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a9739fa78027417212fe9e2cb51f5f75a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) currentTerrainType) |
| void | [OnBattleEnded](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a3afdadfa332fb19af9c1ff5f6c3dac52) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, int excessXp) |
| void | [OnFoodConsumed](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#acae525de21851fd9426160395da7011e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, bool wasStarving) |
| void | [OnAlleyCleared](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a2be658f2c0083a7519446c7bb246c5cf) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley) |
| void | [OnDailyAlleyTick](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ad2eb7bf401e98ea14eaa8259aec4967b) ([Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) alley, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) alleyLeader) |
| void | [OnBoardGameWonAgainstLord](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a0b355ab1db3a4347f7af0959a95976b4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) lord, [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) difficulty, bool extraXpGain) |
| void | [OnShipDamaged](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aa7453a83c8e5a654c7bba63dc2a8b27e) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, float rawDamage, float finalDamage) |
| void | [OnShipRepaired](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ac552f7d5f1f64f34cf72adf97b08ff8e) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, float repairedHitPoints) |
| void | [OnHideoutMissionEnd](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a93b3c744d7cf12b750cacabc882b3edb) (bool isSucceeded) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a21f0c2c6b96199b8657fec83bad4a3b8)OnCombatHit()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnCombatHit | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *affectorCharacter*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *affectedCharacter*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *captain*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *commander*, |
|  |  | float | *speedBonusFromMovement*, |
|  |  | float | *shotDifficulty*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *affectorWeapon*, |
|  |  | float | *hitPointRatio*, |
|  |  | [CombatXpModel.MissionTypeEnum](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_xp_model.html#a60eca0ad4973ff90398917d4ff4ec645) | *missionType*, |
|  |  | bool | *isAffectorMounted*, |
|  |  | bool | *isTeamKill*, |
|  |  | bool | *isAffectorUnderCommand*, |
|  |  | float | *damageAmount*, |
|  |  | bool | *isFatal*, |
|  |  | bool | *isSiegeEngineHit*, |
|  |  | bool | *isHorseCharge*, |
|  |  | bool | *isSneakAttack* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a9ff9eb031df0cae4b0bc333303906576).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a53251d3c960aaaa7e426ccae3628b0b5)OnSiegeEngineDestroyed()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnSiegeEngineDestroyed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *destroyedSiegeEngine* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a522a5f6839d2a933d29225f056071164).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ab6790a69485ce17febcfb652abe26b5e)OnSimulationCombatKill()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnSimulationCombatKill | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *affectorCharacter*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *affectedCharacter*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *affectorParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *commanderParty* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#aed28727a18ac5d2f6591e327638c7340).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aeab63d81d04f67327c2b32e65cb282ac)OnTradeProfitMade() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnTradeProfitMade | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | int | *tradeProfit* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#ab1427c8e8a1baf3a2cad86bf75182b22).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a6c2e81eba40befa4d75f2656907cbb77)OnTradeProfitMade() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnTradeProfitMade | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | int | *tradeProfit* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#af91dd80b7402c26a9def2a72b815745b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ad3c2b6696d55831f5b673db99814a8aa)OnSettlementProjectFinished()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnSettlementProjectFinished | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a2d8b734609f692d9db3dbdafe193ccbd).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a2c53bb6be59bff1df318d52c10196fa7)OnSettlementGoverned()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnSettlementGoverned | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *governor*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a7fca4b8a2e6bd55762b8b6d7402d7b71).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aee9602b77fb004906d86df74d7e604f8)OnInfluenceSpent()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnInfluenceSpent | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | float | *amountSpent* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a47980ce51848229650a21e062276bfdb).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aabdaf03848c981268aba1b943cd61e29)OnGainRelation()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnGainRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *gainedRelationWith*, |
|  |  | float | *relationChange*, |
|  |  | [ChangeRelationAction.ChangeRelationDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_change_relation_action.html#a100270168fa2e76ed3a405267f2109ed) | *detail* = ChangeRelationAction.ChangeRelationDetail.Default ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#aecf3e14eca76d0b924753786a7c41611).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ad9436d0b491d31a1fc12543bc3948e0e)OnTroopRecruited()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnTroopRecruited | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | int | *amount*, |
|  |  | int | *tier* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#aa0fddcf4b1d398c50613313dde03b331).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aabf5d0780012af9cbf10c64f90d73613)OnBribeGiven()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnBribeGiven | ( | int | *amount* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a24921b21512cd7f2697ca12bac698309).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a8d6c9aad96dba1e902fc5c69a907e518)OnWarehouseProduction()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnWarehouseProduction | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *production* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a446fcd4eaeb175c1c5b95084d2c094f9).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a897b2f7d1e26844f5615dd564dcfe5c0)OnAIPartyLootCasualties()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnAIPartyLootCasualties | ( | int | *goldAmount*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winnerPartyLeader*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a08498bfac995e65257e0edc6827b519c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a2cadf3253ab05d4801ceb81aaf594c84)OnBanditsRecruited()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnBanditsRecruited | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *bandit*, |
|  |  | int | *count* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a0e3c60398c96b51f7354e1adf659b847).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a378d5caeb336a169c6c448eaac376ad9)OnMainHeroReleasedFromCaptivity()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnMainHeroReleasedFromCaptivity | ( | float | *captivityTime* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#aab7c9896ccc6e786c43a4fb8fefe085f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a77dc698d80566d18c99aaafd263d66b0)OnMainHeroTortured()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnMainHeroTortured | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#af1be9b3f039da682cc101b4c4d43a1cd).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aa45ffaaad3e9e6821beafaa56d986346)OnMainHeroDisguised()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnMainHeroDisguised | ( | bool | *isNotCaught* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a30fa05bb9a23ac6e6f7d113fa9f6982b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a3857682b2ba99f16814200b7842e1915)OnRaid()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnRaid | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, |
|  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *lootedItems* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a10911680132ce1614362abb38206be4c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a0aa55a552a08b3a4f3b9a128c7df48a5)OnLoot()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnLoot | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *forcedParty*, |
|  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *lootedItems*, |
|  |  | bool | *attacked* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#ae687b2db7532b6ed5369d0f65b15bbfc).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a66ed0a10c819f81b26ef1debf9e68a3d)OnPrisonerSell()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnPrisonerSell | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | in [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *prisonerRoster* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a71385fb8a02c77d01c61b907ee3eb17d).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#af6340419f31b27e2434cf47f4712f29d)OnSurgeryApplied()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnSurgeryApplied | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | bool | *surgerySuccess*, |
|  |  | int | *troopTier* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#ae0a5703139e2ffb0247a8986c8242fdc).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a5290e6b74339186b6a030817a11cebe7)OnTacticsUsed()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnTacticsUsed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | float | *xp* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a576ad2bdc193fa568a25ad06ce2c1656).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#affc10335eb3ad15154b0b89094143b2c)OnHideoutSpotted()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnHideoutSpotted | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *spottedParty* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a5a93cd4df631ff68285c1e8cc8e7209b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a63b5fb2161fb698929a51a6a03512871)OnTrackDetected()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnTrackDetected | ( | [Track](class_tale_worlds_1_1_campaign_system_1_1_track.html) | *track* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a602de9cb8a31d8e5e299227a0d97d49b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a6190f3abbf23c52e3d388f07a97af7f4)OnTravelOnFoot()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnTravelOnFoot | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | float | *speed* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a3409713c172a078a27690a2ddf8be611).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ad5271afd268de73a06476682f52f106d)OnTravelOnHorse()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnTravelOnHorse | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | float | *speed* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#acc6d4299e95a11a4d3ac327e7be66184).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aa61374946a0a7211b20dc0e199bd5512)OnTravelOnWater()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnTravelOnWater | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | float | *speed* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a9c4b2288a6d79445c84dcb1c75e01daa).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a57b7eec8691793eb7f1286af67cf4359)OnHeroHealedWhileWaiting()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnHeroHealedWhileWaiting | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | int | *healingAmount* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a0a19f0c97ef65492aa902518951268a1).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#adbd52b8a8b09cbb97f3d9e64197d97e7)OnRegularTroopHealedWhileWaiting()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnRegularTroopHealedWhileWaiting | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | int | *healedTroopCount*, |
|  |  | float | *averageTier* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#ae6c275deee1d6422721a110a134892ff).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a2d7aa1877d0d7f21d29a9daa728e5006)OnLeadingArmy()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnLeadingArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#af044a5e31b09a2e0f40d8d47540e4d25).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#af661415c1438cf5df9f3dcf3470743f9)OnSieging()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnSieging | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a8e9a89a47395920db4feb41aa5963a31).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a3809e7609ec5391a71629aa94cc3add3)OnSiegeEngineBuilt()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnSiegeEngineBuilt | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#aabee01d383ad96a3babb3caff015af5d).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a08c9d3eaba975ab9ea93fb7bc03fecf5)OnUpgradeTroops()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnUpgradeTroops | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *upgrade*, |
|  |  | int | *numberOfTroops* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#ac895ac786d1f43fcd1cddf5ff6ca6fdf).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a6885c20a896006426f4d6836180df8f0)OnPersuasionSucceeded()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnPersuasionSucceeded | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *targetHero*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) | *difficulty*, |
|  |  | int | *argumentDifficultyBonusCoefficient* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a47a24b06b801412bc9c6ef53ea3ce028).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#af02a56413cf537387fa42fbd7356463a)OnPrisonBreakEnd()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnPrisonBreakEnd | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero*, |
|  |  | bool | *isSucceeded* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a6390f00c4d9e329582d858e39fa064c2).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ac086d52ad49630e9a2e0aacad865fda6)OnWallBreached()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnWallBreached | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a93a1dbdd41fca5470bc6d4b23daefcb9).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#af63da91c0e1e3420acae05acac0879ad)OnForceVolunteers()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnForceVolunteers | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *forcedParty* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#affceafc07549433f83df152c036d2d92).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a9d62318565f1e408cdeb0e8773c17be0)OnForceSupplies()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnForceSupplies | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty*, |
|  |  | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *lootedItems*, |
|  |  | bool | *attacked* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a213401085d7ad9d1f9ec9d90c294c5b9).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a04455a30be4e6247f0c6b6151cde4c30)OnAIPartiesTravel()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnAIPartiesTravel | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | bool | *isCaravanParty*, |
|  |  | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *currentTerrainType* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a3e7812e07b496c202587a8a165eb822d).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a9739fa78027417212fe9e2cb51f5f75a)OnTraverseTerrain()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnTraverseTerrain | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *currentTerrainType* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a695495492f60b8b56af9ba2ae77b96e6).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a3afdadfa332fb19af9c1ff5f6c3dac52)OnBattleEnded()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnBattleEnded | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | int | *excessXp* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a564288c12554ca27e16998e7331d8c11).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#acae525de21851fd9426160395da7011e)OnFoodConsumed()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnFoodConsumed | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | bool | *wasStarving* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a1d736fb356d04dd289ebdf265769091b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a2be658f2c0083a7519446c7bb246c5cf)OnAlleyCleared()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnAlleyCleared | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#acc8ec99b370470b48f5b6e2096a8b88e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ad2eb7bf401e98ea14eaa8259aec4967b)OnDailyAlleyTick()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnDailyAlleyTick | ( | [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) | *alley*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *alleyLeader* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a4d2d7e77e4abe37d17925ae3919a3c19).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a0b355ab1db3a4347f7af0959a95976b4)OnBoardGameWonAgainstLord()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnBoardGameWonAgainstLord | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *lord*, |
|  |  | [BoardGameHelper.AIDifficulty](class_helpers_1_1_board_game_helper.html#a4eae119f51c59e72692b19fd9f1cc9c8) | *difficulty*, |
|  |  | bool | *extraXpGain* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a58065fcde8af73c3516b01bcf9a89a32).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#aa7453a83c8e5a654c7bba63dc2a8b27e)OnShipDamaged()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnShipDamaged | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | float | *rawDamage*, |
|  |  | float | *finalDamage* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#aa16ad3374a809a9ff29c4a5be27531b8).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#ac552f7d5f1f64f34cf72adf97b08ff8e)OnShipRepaired()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnShipRepaired | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | float | *repairedHitPoints* ) |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a5527c7f2975d2a80aa8b2c30095a76fa).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_i_skill_leveling_manager.html#a93b3c744d7cf12b750cacabc882b3edb)OnHideoutMissionEnd()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CharacterDevelopment.ISkillLevelingManager.OnHideoutMissionEnd | ( | bool | *isSucceeded* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CharacterDevelopment.DefaultSkillLevelingManager](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_default_skill_leveling_manager.html#a00fc76b81fae6c885798ede4b4b37f77).

