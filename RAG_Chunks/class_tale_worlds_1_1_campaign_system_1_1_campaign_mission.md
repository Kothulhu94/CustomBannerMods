--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html ---

TaleWorlds.CampaignSystem.CampaignMission Class Reference|  |  |
| --- | --- |
| Classes | |
| interface | [ICampaignMissionManager](interface_tale_worlds_1_1_campaign_system_1_1_campaign_mission_1_1_i_campaign_mission_manager.html) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenBattleMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a6d2a5f52afb43fd3a2e65a978d725032) (string scene, bool usesTownDecalAtlas) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenAlleyFightMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aaf241f85e13247407a5b89481d550922) (string scene, int upgradeLevel, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) playerSideTroops, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) rivalSideTroops) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenCombatMissionWithDialogue](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a57faec3d2abf8c4f3903041abd7710d0) (string scene, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) characterToTalkTo, int upgradeLevel) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenBattleMissionWhileEnteringSettlement](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a133339d6f054df9e483acdc40584b6c2) (string scene, int upgradeLevel, int numberOfMaxTroopToBeSpawnedForPlayer, int numberOfMaxTroopToBeSpawnedForOpponent) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenHideoutBattleMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ab348f8683f43171e6f26b4118f7f86fb) (string scene, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) playerTroops, bool isTutorial) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenSiegeMissionWithDeployment](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a3b1273409ae2946727880ceb997dbd03) (string scene, float[] wallHitPointsPercentages, bool hasAnySiegeTower, List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > siegeWeaponsOfAttackers, List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > siegeWeaponsOfDefenders, bool isPlayerAttacker, int upgradeLevel=0, bool isSallyOut=false, bool isReliefForceAttack=false) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenSiegeMissionNoDeployment](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ae3309d9549acadd74190b6ea94d632b9) (string scene, bool isSallyOut=false, bool isReliefForceAttack=false) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenSiegeLordsHallFightMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ac213b6bc72cbcdeacb894b25293a38fc) (string scene, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) attackerPriorityList) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenBattleMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aa45692c33ee505981765638cd09f5088) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenNavalBattleMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a19809be2511cb73874543a178b5d56e6) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenNavalSetPieceBattleMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a9619b28fd07b6698d0f95d441521dddf) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec, MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > playerShips, MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > playerAllyShips, MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > enemyShips) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenCaravanBattleMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ab239e8e4d84f67edba41a2bb18f84dab) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec, bool isCaravan) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenTownCenterMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a020507d7941c21e7f2d31232a0f7dbb8) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar, int townUpgradeLevel, string playerSpawnTag) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenCastleCourtyardMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a58b569d2fde5fd643d465f11496c6f15) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar, int castleUpgradeLevel) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenVillageMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ac10ceb84d0a65a4804475d9c65052d61) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenIndoorMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a9c63dc9409a3a6e4ff732692ee9de8cb) (string scene, int upgradeLevel, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenPrisonBreakMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aa5498a2cf63af5b73b895e802761700b) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) prisonerCharacter) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenArenaStartMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aa303095a6da3f6d96427984aa0c5563f) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenArenaDuelMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ab4efdaed4b313863a3a5cdc626b5dd20) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar, bool requireCivilianEquipment, bool spawnBothSidesWithHorse, Action< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > onDuelEnd, float customAgentHealth) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenConversationMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aca588d851a50f9d0ac43b78475fcf0c5) ([ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) playerCharacterData, [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) conversationPartnerData, string specialScene="", string sceneLevels="", bool isMultiAgentConversation=false) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenRetirementMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ab5f317041b83688f8e89bdb507737388) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar=null, string sceneLevels=null, string unconsciousMenuId="") |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenHideoutAmbushMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a2a7f010f1a410a4f9ba1b17e16fe84b0) (string sceneName, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) playerTroops, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| static [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenDisguiseMission](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a961a1eb02100a40d754a1140af0cac8d) (string scene, bool willSetUpContact, string sceneLevels, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) fromLocation) |

|  |  |
| --- | --- |
| Properties | |
| static [ICampaignMission](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html) | [Current](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aa7fc38a31b6ccc1b0a2f40112c869c0d) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a6d2a5f52afb43fd3a2e65a978d725032)OpenBattleMission() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenBattleMission | ( | string | *scene*, | |  |  | bool | *usesTownDecalAtlas* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aaf241f85e13247407a5b89481d550922)OpenAlleyFightMission()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenAlleyFightMission | ( | string | *scene*, | |  |  | int | *upgradeLevel*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *playerSideTroops*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *rivalSideTroops* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a57faec3d2abf8c4f3903041abd7710d0)OpenCombatMissionWithDialogue()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenCombatMissionWithDialogue | ( | string | *scene*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *characterToTalkTo*, | |  |  | int | *upgradeLevel* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a133339d6f054df9e483acdc40584b6c2)OpenBattleMissionWhileEnteringSettlement()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenBattleMissionWhileEnteringSettlement | ( | string | *scene*, | |  |  | int | *upgradeLevel*, | |  |  | int | *numberOfMaxTroopToBeSpawnedForPlayer*, | |  |  | int | *numberOfMaxTroopToBeSpawnedForOpponent* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ab348f8683f43171e6f26b4118f7f86fb)OpenHideoutBattleMission()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenHideoutBattleMission | ( | string | *scene*, | |  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *playerTroops*, | |  |  | bool | *isTutorial* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a3b1273409ae2946727880ceb997dbd03)OpenSiegeMissionWithDeployment()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenSiegeMissionWithDeployment | ( | string | *scene*, | |  |  | float[] | *wallHitPointsPercentages*, | |  |  | bool | *hasAnySiegeTower*, | |  |  | List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > | *siegeWeaponsOfAttackers*, | |  |  | List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > | *siegeWeaponsOfDefenders*, | |  |  | bool | *isPlayerAttacker*, | |  |  | int | *upgradeLevel* = 0, | |  |  | bool | *isSallyOut* = false, | |  |  | bool | *isReliefForceAttack* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ae3309d9549acadd74190b6ea94d632b9)OpenSiegeMissionNoDeployment()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenSiegeMissionNoDeployment | ( | string | *scene*, | |  |  | bool | *isSallyOut* = false, | |  |  | bool | *isReliefForceAttack* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ac213b6bc72cbcdeacb894b25293a38fc)OpenSiegeLordsHallFightMission()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenSiegeLordsHallFightMission | ( | string | *scene*, | |  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *attackerPriorityList* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aa45692c33ee505981765638cd09f5088)OpenBattleMission() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenBattleMission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a19809be2511cb73874543a178b5d56e6)OpenNavalBattleMission()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenNavalBattleMission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a9619b28fd07b6698d0f95d441521dddf)OpenNavalSetPieceBattleMission()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenNavalSetPieceBattleMission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec*, | |  |  | MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > | *playerShips*, | |  |  | MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > | *playerAllyShips*, | |  |  | MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > | *enemyShips* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ab239e8e4d84f67edba41a2bb18f84dab)OpenCaravanBattleMission()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenCaravanBattleMission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec*, | |  |  | bool | *isCaravan* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a020507d7941c21e7f2d31232a0f7dbb8)OpenTownCenterMission()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenTownCenterMission | ( | string | *scene*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar*, | |  |  | int | *townUpgradeLevel*, | |  |  | string | *playerSpawnTag* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a58b569d2fde5fd643d465f11496c6f15)OpenCastleCourtyardMission()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenCastleCourtyardMission | ( | string | *scene*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar*, | |  |  | int | *castleUpgradeLevel* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ac10ceb84d0a65a4804475d9c65052d61)OpenVillageMission()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenVillageMission | ( | string | *scene*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a9c63dc9409a3a6e4ff732692ee9de8cb)OpenIndoorMission()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenIndoorMission | ( | string | *scene*, | |  |  | int | *upgradeLevel*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aa5498a2cf63af5b73b895e802761700b)OpenPrisonBreakMission()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenPrisonBreakMission | ( | string | *scene*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *prisonerCharacter* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aa303095a6da3f6d96427984aa0c5563f)OpenArenaStartMission()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenArenaStartMission | ( | string | *scene*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ab4efdaed4b313863a3a5cdc626b5dd20)OpenArenaDuelMission()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenArenaDuelMission | ( | string | *scene*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar*, | |  |  | bool | *requireCivilianEquipment*, | |  |  | bool | *spawnBothSidesWithHorse*, | |  |  | Action< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *onDuelEnd*, | |  |  | float | *customAgentHealth* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aca588d851a50f9d0ac43b78475fcf0c5)OpenConversationMission()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenConversationMission | ( | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *playerCharacterData*, | |  |  | [ConversationCharacterData](struct_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_conversation_character_data.html) | *conversationPartnerData*, | |  |  | string | *specialScene* = "", | |  |  | string | *sceneLevels* = "", | |  |  | bool | *isMultiAgentConversation* = false ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#ab5f317041b83688f8e89bdb507737388)OpenRetirementMission()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenRetirementMission | ( | string | *scene*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar* = null, | |  |  | string | *sceneLevels* = null, | |  |  | string | *unconsciousMenuId* = "" ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a2a7f010f1a410a4f9ba1b17e16fe84b0)OpenHideoutAmbushMission()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenHideoutAmbushMission | ( | string | *sceneName*, | |  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *playerTroops*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#a961a1eb02100a40d754a1140af0cac8d)OpenDisguiseMission()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.CampaignMission.OpenDisguiseMission | ( | string | *scene*, | |  |  | bool | *willSetUpContact*, | |  |  | string | *sceneLevels*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *fromLocation* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_mission.html#aa7fc38a31b6ccc1b0a2f40112c869c0d)Current
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ICampaignMission](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_mission.html) TaleWorlds.CampaignSystem.CampaignMission.Current | | staticgetset |

