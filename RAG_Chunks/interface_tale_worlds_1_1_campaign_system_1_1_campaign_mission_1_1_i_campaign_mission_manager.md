--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html ---

TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager Interface Reference|  |  |
| --- | --- |
| Public Member Functions | |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenSiegeMissionWithDeployment](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a4be2b67c77243c96349c25a696bc0d7b) (string scene, float[] wallHitPointsPercentages, bool hasAnySiegeTower, List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > siegeWeaponsOfAttackers, List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > siegeWeaponsOfDefenders, bool isPlayerAttacker, int upgradeLevel=0, bool isSallyOut=false, bool isReliefForceAttack=false) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenSiegeMissionNoDeployment](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a50325627b7fb32ed40172d4a77c4efe9) (string scene, bool isSallyOut=false, bool isReliefForceAttack=false) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenSiegeLordsHallFightMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#adc0bda42cdf5eb8d4358f1ff8e1dc07d) (string scene, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) attackerPriorityList) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenBattleMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a9fa3854d11fb1320f065f8e4b88cdfe5) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenCaravanBattleMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#aa4db610f12f7bb803c24e352af7ff839) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec, bool isCaravan) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenBattleMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a1a48c87e049204c48727d4a45d08d5ec) (string scene, bool usesTownDecalAtlas) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenNavalBattleMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a19a9b1ff500b3f6ec6ec997359d7f8ba) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenNavalSetPieceBattleMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a57ba3e5ebd2f21fcf1a1e7bf6e25ea30) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec, MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > playerShips, MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > playerAllyShips, MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > enemyShips) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenHideoutBattleMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#ae7b7ad469a12a0f405ae791b7aa4da7b) (string scene, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) playerTroops, bool isTutorial) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenTownCenterMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a0ad72ed0f22c93fe74e43b7af5b3a242) (string scene, int townUpgradeLevel, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar, string playerSpawnTag) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenCastleCourtyardMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a5f9d85d3e5b677ea3abff2174d408c0b) (string scene, int castleUpgradeLevel, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenVillageMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#af0688061fe75ee3df9ad4463387c39d6) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenIndoorMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#abe62557abfa015b553976996d4e1011a) (string scene, int upgradeLevel, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenPrisonBreakMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a28d212cb7519aa59f8e5428ab69df058) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) prisonerCharacter) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenArenaStartMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#abfe9261bac786cd74bea166916e42ab2) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenArenaDuelMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#aaaa95c7a8e3e31774b6f0c93f4b33518) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) duelCharacter, bool requireCivilianEquipment, bool spawnBOthSidesWithHorse, Action< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > onDuelEndAction, float customAgentHealth) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenConversationMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a515e2f4a829b6a9f1f7c10d483ba07ce) ([ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) playerCharacterData, [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) conversationPartnerData, string specialScene="", string sceneLevels="", bool isMultiAgentConversation=false) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenMeetingMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#ad8d4b6f9a43691299393864a5a413b4d) (string scene, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenAlleyFightMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a5dc4859b170956990edade418daf4011) (string scene, int upgradeLevel, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) playerSideTroops, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) rivalSideTroops) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenCombatMissionWithDialogue](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a763e65958b0c784174261bc93efcaad9) (string scene, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) characterToTalkTo, int upgradeLevel) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenBattleMissionWhileEnteringSettlement](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a078751345dde3a702c39bb64dd7de1e5) (string scene, int upgradeLevel, int numberOfMaxTroopToBeSpawnedForPlayer, int numberOfMaxTroopToBeSpawnedForOpponent) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenRetirementMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a307dd604a59000d36af946b0a0f87771) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar=null, string sceneLevels=null, string unconsciousMenuId="") |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenHideoutAmbushMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#ab4032042f59fc28aa56f5302cc0e88b4) (string sceneName, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) playerTroops, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenDisguiseMission](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a43cae5fa770495b78e928bf5f9c5427e) (string scene, bool willSetUpContact, string sceneLevels, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) fromLocation) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a4be2b67c77243c96349c25a696bc0d7b)OpenSiegeMissionWithDeployment()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenSiegeMissionWithDeployment | ( | string | *scene*, |
|  |  | float[] | *wallHitPointsPercentages*, |
|  |  | bool | *hasAnySiegeTower*, |
|  |  | List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > | *siegeWeaponsOfAttackers*, |
|  |  | List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > | *siegeWeaponsOfDefenders*, |
|  |  | bool | *isPlayerAttacker*, |
|  |  | int | *upgradeLevel* = 0, |
|  |  | bool | *isSallyOut* = false, |
|  |  | bool | *isReliefForceAttack* = false ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a50325627b7fb32ed40172d4a77c4efe9)OpenSiegeMissionNoDeployment()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenSiegeMissionNoDeployment | ( | string | *scene*, |
|  |  | bool | *isSallyOut* = false, |
|  |  | bool | *isReliefForceAttack* = false ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#adc0bda42cdf5eb8d4358f1ff8e1dc07d)OpenSiegeLordsHallFightMission()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenSiegeLordsHallFightMission | ( | string | *scene*, |
|  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *attackerPriorityList* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a9fa3854d11fb1320f065f8e4b88cdfe5)OpenBattleMission() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenBattleMission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#aa4db610f12f7bb803c24e352af7ff839)OpenCaravanBattleMission()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenCaravanBattleMission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec*, |
|  |  | bool | *isCaravan* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a1a48c87e049204c48727d4a45d08d5ec)OpenBattleMission() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenBattleMission | ( | string | *scene*, |
|  |  | bool | *usesTownDecalAtlas* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a19a9b1ff500b3f6ec6ec997359d7f8ba)OpenNavalBattleMission()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenNavalBattleMission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a57ba3e5ebd2f21fcf1a1e7bf6e25ea30)OpenNavalSetPieceBattleMission()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenNavalSetPieceBattleMission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec*, |
|  |  | MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > | *playerShips*, |
|  |  | MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > | *playerAllyShips*, |
|  |  | MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > | *enemyShips* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#ae7b7ad469a12a0f405ae791b7aa4da7b)OpenHideoutBattleMission()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenHideoutBattleMission | ( | string | *scene*, |
|  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *playerTroops*, |
|  |  | bool | *isTutorial* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a0ad72ed0f22c93fe74e43b7af5b3a242)OpenTownCenterMission()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenTownCenterMission | ( | string | *scene*, |
|  |  | int | *townUpgradeLevel*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar*, |
|  |  | string | *playerSpawnTag* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a5f9d85d3e5b677ea3abff2174d408c0b)OpenCastleCourtyardMission()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenCastleCourtyardMission | ( | string | *scene*, |
|  |  | int | *castleUpgradeLevel*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#af0688061fe75ee3df9ad4463387c39d6)OpenVillageMission()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenVillageMission | ( | string | *scene*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#abe62557abfa015b553976996d4e1011a)OpenIndoorMission()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenIndoorMission | ( | string | *scene*, |
|  |  | int | *upgradeLevel*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a28d212cb7519aa59f8e5428ab69df058)OpenPrisonBreakMission()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenPrisonBreakMission | ( | string | *scene*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *prisonerCharacter* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#abfe9261bac786cd74bea166916e42ab2)OpenArenaStartMission()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenArenaStartMission | ( | string | *scene*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#aaaa95c7a8e3e31774b6f0c93f4b33518)OpenArenaDuelMission()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenArenaDuelMission | ( | string | *scene*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *duelCharacter*, |
|  |  | bool | *requireCivilianEquipment*, |
|  |  | bool | *spawnBOthSidesWithHorse*, |
|  |  | Action< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *onDuelEndAction*, |
|  |  | float | *customAgentHealth* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a515e2f4a829b6a9f1f7c10d483ba07ce)OpenConversationMission()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenConversationMission | ( | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *playerCharacterData*, |
|  |  | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *conversationPartnerData*, |
|  |  | string | *specialScene* = "", |
|  |  | string | *sceneLevels* = "", |
|  |  | bool | *isMultiAgentConversation* = false ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#ad8d4b6f9a43691299393864a5a413b4d)OpenMeetingMission()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenMeetingMission | ( | string | *scene*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a5dc4859b170956990edade418daf4011)OpenAlleyFightMission()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenAlleyFightMission | ( | string | *scene*, |
|  |  | int | *upgradeLevel*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *playerSideTroops*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *rivalSideTroops* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a763e65958b0c784174261bc93efcaad9)OpenCombatMissionWithDialogue()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenCombatMissionWithDialogue | ( | string | *scene*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *characterToTalkTo*, |
|  |  | int | *upgradeLevel* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a078751345dde3a702c39bb64dd7de1e5)OpenBattleMissionWhileEnteringSettlement()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenBattleMissionWhileEnteringSettlement | ( | string | *scene*, |
|  |  | int | *upgradeLevel*, |
|  |  | int | *numberOfMaxTroopToBeSpawnedForPlayer*, |
|  |  | int | *numberOfMaxTroopToBeSpawnedForOpponent* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a307dd604a59000d36af946b0a0f87771)OpenRetirementMission()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenRetirementMission | ( | string | *scene*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar* = null, |
|  |  | string | *sceneLevels* = null, |
|  |  | string | *unconsciousMenuId* = "" ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#ab4032042f59fc28aa56f5302cc0e88b4)OpenHideoutAmbushMission()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenHideoutAmbushMission | ( | string | *sceneName*, |
|  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *playerTroops*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html#a43cae5fa770495b78e928bf5f9c5427e)OpenDisguiseMission()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.ICampaignMissionManager.OpenDisguiseMission | ( | string | *scene*, |
|  |  | bool | *willSetUpContact*, |
|  |  | string | *sceneLevels*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *fromLocation* ) |

