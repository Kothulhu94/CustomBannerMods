--- SOURCE: class_sand_box_1_1_campaign_mission_manager.html ---

SandBox.CampaignMissionManager Class ReferenceInherits ICampaignMissionManager.

|  |  |
| --- | --- |
| Public Member Functions | |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenArenaDuelMission](class_sand_box_1_1_campaign_mission_manager.html#a5f554a10caaed585a0fea1c1db773f5b) (string scene, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) duelCharacter, bool requireCivilianEquipment, bool spawnBOthSidesWithHorse, Action< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > onDuelEndAction, float customAgentHealth) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenDisguiseMission](class_sand_box_1_1_campaign_mission_manager.html#a1fa9f225039132ce7d12300320a1089d) (string scene, bool willSetUpContact, string sceneLevels, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) fromLocation) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenNavalBattleMission](class_sand_box_1_1_campaign_mission_manager.html#a130a3430ff59ab94d8e2a9ba22af09af) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec) |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [OpenNavalSetPieceBattleMission](class_sand_box_1_1_campaign_mission_manager.html#a76a0aae3407d14947877f11456a7da22) ([MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) rec, MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > playerShips, MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > playerAllyShips, MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > enemyShips) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_campaign_mission_manager.html#a5f554a10caaed585a0fea1c1db773f5b)OpenArenaDuelMission()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) SandBox.CampaignMissionManager.OpenArenaDuelMission | ( | string | *scene*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *location*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *duelCharacter*, |
|  |  | bool | *requireCivilianEquipment*, |
|  |  | bool | *spawnBOthSidesWithHorse*, |
|  |  | Action< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | *onDuelEndAction*, |
|  |  | float | *customAgentHealth* ) |

[◆](class_sand_box_1_1_campaign_mission_manager.html#a1fa9f225039132ce7d12300320a1089d)OpenDisguiseMission()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) SandBox.CampaignMissionManager.OpenDisguiseMission | ( | string | *scene*, |
|  |  | bool | *willSetUpContact*, |
|  |  | string | *sceneLevels*, |
|  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *fromLocation* ) |

[◆](class_sand_box_1_1_campaign_mission_manager.html#a130a3430ff59ab94d8e2a9ba22af09af)OpenNavalBattleMission()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) SandBox.CampaignMissionManager.OpenNavalBattleMission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec* | ) |  |

[◆](class_sand_box_1_1_campaign_mission_manager.html#a76a0aae3407d14947877f11456a7da22)OpenNavalSetPieceBattleMission()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) SandBox.CampaignMissionManager.OpenNavalSetPieceBattleMission | ( | [MissionInitializerRecord](struct_tale_worlds_1_1_core_1_1_mission_initializer_record.html) | *rec*, |
|  |  | MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > | *playerShips*, |
|  |  | MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > | *playerAllyShips*, |
|  |  | MBList< [IShipOrigin](interface_tale_worlds_1_1_core_1_1_i_ship_origin.html) > | *enemyShips* ) |

