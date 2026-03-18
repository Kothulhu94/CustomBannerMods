--- SOURCE: class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html ---

SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a967ac125cdbb41cafec5c951d84e4bf7) () |
| override void | [SyncData](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#ab8abb9abe6d456b5db56a9ccc729f5a6) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [GetActionSetSuffixAndMonsterForItem](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#af99625dfa77d4658f658de4d413db7e7) (string itemId, int race, bool isFemale, out [Monster](class_tale_worlds_1_1_core_1_1_monster.html) monster) |
| static Tuple< string, [Monster](class_tale_worlds_1_1_core_1_1_monster.html) > | [GetRandomTownsManActionSetAndMonster](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#aa865172dde88c8c9e2572e88607663db) (int race) |
| static Tuple< string, [Monster](class_tale_worlds_1_1_core_1_1_monster.html) > | [GetRandomTownsWomanActionSetAndMonster](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#ad8b1bed0c0b3c85a5a8dde7ca948e03f) (int race) |
| static [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [CreateBroomsWoman](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a26e5c24d64e9aa4f3a9790b2b8a39a6f) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, LocationCharacter.CharacterRelations relation) |
| static [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [CreateMaleBeggar](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a4fdb7c68c924a8a63b2be00d702049ba) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, LocationCharacter.CharacterRelations relation) |
| static [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) | [CreateFemaleBeggar](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#ad7a8121c8bfedc529e306cb669a6d4b0) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, LocationCharacter.CharacterRelations relation) |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [TownsmanSpawnPercentageMale](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a6ed2e48c3036137b2ccc6079d7450c89) = 0.20f |
| const float | [TownsmanSpawnPercentageFemale](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a0a678fae8d2ba51e46de3767c5f4df7f) = 0.15f |
| const float | [TownsmanSpawnPercentageLimitedMale](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#aafa81e0f86d207644eb54f07ca716b2f) = 0.15f |
| const float | [TownsmanSpawnPercentageLimitedFemale](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#ab775dda4319117b852a66842a3c1ee73) = 0.1f |
| const float | [TownOtherPeopleSpawnPercentage](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a9468ee6fa11f514ce0bbdb51a37ff0c5) = 0.05f |
| const float | [TownsmanSpawnPercentageTavernMale](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a0214ea787d3cc9c230f94e685d90fc1d) = 0.3f |
| const float | [TownsmanSpawnPercentageTavernFemale](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a3f1ca8430c2981e18ad079b57a569d87) = 0.1f |
| const float | [BeggarSpawnPercentage](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a6f71d7fa795e060283708473e56fca4d) = 0.33f |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a967ac125cdbb41cafec5c951d84e4bf7)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#ab8abb9abe6d456b5db56a9ccc729f5a6)SyncData()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#af99625dfa77d4658f658de4d413db7e7)GetActionSetSuffixAndMonsterForItem()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.GetActionSetSuffixAndMonsterForItem | ( | string | *itemId*, | |  |  | int | *race*, | |  |  | bool | *isFemale*, | |  |  | out [Monster](class_tale_worlds_1_1_core_1_1_monster.html) | *monster* ) | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#aa865172dde88c8c9e2572e88607663db)GetRandomTownsManActionSetAndMonster()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Tuple< string, [Monster](class_tale_worlds_1_1_core_1_1_monster.html) > SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.GetRandomTownsManActionSetAndMonster | ( | int | *race* | ) |  | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#ad8b1bed0c0b3c85a5a8dde7ca948e03f)GetRandomTownsWomanActionSetAndMonster()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Tuple< string, [Monster](class_tale_worlds_1_1_core_1_1_monster.html) > SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.GetRandomTownsWomanActionSetAndMonster | ( | int | *race* | ) |  | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a26e5c24d64e9aa4f3a9790b2b8a39a6f)CreateBroomsWoman()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.CreateBroomsWoman | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, | |  |  | LocationCharacter.CharacterRelations | *relation* ) | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a4fdb7c68c924a8a63b2be00d702049ba)CreateMaleBeggar()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.CreateMaleBeggar | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, | |  |  | LocationCharacter.CharacterRelations | *relation* ) | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#ad7a8121c8bfedc529e306cb669a6d4b0)CreateFemaleBeggar()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [LocationCharacter](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_locations_1_1_location_character.html) SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.CreateFemaleBeggar | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, | |  |  | LocationCharacter.CharacterRelations | *relation* ) | | static |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a6ed2e48c3036137b2ccc6079d7450c89)TownsmanSpawnPercentageMale
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.TownsmanSpawnPercentageMale = 0.20f | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a0a678fae8d2ba51e46de3767c5f4df7f)TownsmanSpawnPercentageFemale
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.TownsmanSpawnPercentageFemale = 0.15f | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#aafa81e0f86d207644eb54f07ca716b2f)TownsmanSpawnPercentageLimitedMale
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.TownsmanSpawnPercentageLimitedMale = 0.15f | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#ab775dda4319117b852a66842a3c1ee73)TownsmanSpawnPercentageLimitedFemale
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.TownsmanSpawnPercentageLimitedFemale = 0.1f | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a9468ee6fa11f514ce0bbdb51a37ff0c5)TownOtherPeopleSpawnPercentage
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.TownOtherPeopleSpawnPercentage = 0.05f | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a0214ea787d3cc9c230f94e685d90fc1d)TownsmanSpawnPercentageTavernMale
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.TownsmanSpawnPercentageTavernMale = 0.3f | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a3f1ca8430c2981e18ad079b57a569d87)TownsmanSpawnPercentageTavernFemale
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.TownsmanSpawnPercentageTavernFemale = 0.1f | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_townsfolk_campaign_behavior.html#a6f71d7fa795e060283708473e56fca4d)BeggarSpawnPercentage
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonTownsfolkCampaignBehavior.BeggarSpawnPercentage = 0.33f | | static |

