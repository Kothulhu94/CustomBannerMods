--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_village_encounter.html ---

TaleWorlds.CampaignSystem.Encounters.VillageEncounter Class ReferenceInherits [TaleWorlds.CampaignSystem.Encounters.LocationEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [VillageEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_village_encounter.html#a0e0c218b75a30209525767b8d4f51f90) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#ae1293ef2c113a079c6874d8ac1b5f58e) settlement) |
| override [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | [CreateAndOpenMissionController](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_village_encounter.html#a1f5d30dd1d953c1a49fabfb6b45f4c10) ([Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) nextLocation, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) previousLocation=null, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) talkToChar=null, string playerSpecialSpawnTag=null) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Encounters.LocationEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html) | |
| void | [AddAccompanyingCharacter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#a0cbd1ecbf963cc5a56b8873301cbbdc0) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, bool isFollowing=false) |
| [AccompanyingCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_accompanying_character.html) | [GetAccompanyingCharacter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#ab238085eac1d94739934fb86bb128b64) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| [AccompanyingCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_accompanying_character.html) | [GetAccompanyingCharacter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#a8acbcb99956aab8f23281ba16700df94) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| void | [RemoveAccompanyingCharacter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#aa1d0e7b59166c7ba50d865f9ff0ece8e) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter) |
| void | [RemoveAccompanyingCharacter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#a61118f8409c71af8006a8ce2de6f032e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [RemoveAllAccompanyingCharacters](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#a50bd7648d8c0164c6583f97d8aa933d3) () |
| void | [OnCharacterLocationChanged](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#a3e12bddf9692093f1ab91b93c2087e2a) ([LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) locationCharacter, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) fromLocation, [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) toLocation) |
| virtual bool | [IsWorkshopLocation](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#a72cc4c0e7e211920fce0b21f0002218e) ([Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |
| virtual bool | [IsTavern](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#aeda94ab4acb78fe3354a1165cd28f0f9) ([Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) location) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.Encounters.LocationEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html) | |
| bool | [IsInsideOfASettlement](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#a3cd47ef0e047ac0bbad63d6f7f8c7b28) = false |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Encounters.LocationEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html) | |
|  | [LocationEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#a96829b4e516c9254cf4208e9c193174e) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#ae1293ef2c113a079c6874d8ac1b5f58e) settlement) |
| Properties inherited from [TaleWorlds.CampaignSystem.Encounters.LocationEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html) | |
| Settlement | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#ae1293ef2c113a079c6874d8ac1b5f58e) `[get]` |
| List< [AccompanyingCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_accompanying_character.html) > | [CharactersAccompanyingPlayer](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#abbe8c9b4c21c7fc174a2bf378e576dac) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_village_encounter.html#a0e0c218b75a30209525767b8d4f51f90)VillageEncounter()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Encounters.VillageEncounter.VillageEncounter | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#ae1293ef2c113a079c6874d8ac1b5f58e) | *settlement* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_village_encounter.html#a1f5d30dd1d953c1a49fabfb6b45f4c10)CreateAndOpenMissionController()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) TaleWorlds.CampaignSystem.Encounters.VillageEncounter.CreateAndOpenMissionController | ( | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *nextLocation*, | |  |  | [Location](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location.html) | *previousLocation* = null, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *talkToChar* = null, | |  |  | string | *playerSpecialSpawnTag* = null ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encounters.LocationEncounter](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_location_encounter.html#a86139aeabdc86fb4012582a0de98fe6c).

