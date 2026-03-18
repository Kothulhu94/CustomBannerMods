--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_name_generator.html ---

TaleWorlds.CampaignSystem.NameGenerator Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NameGenerator](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a0897d15a6075ac05c506e35cc6212cdf) () |
| void | [GenerateHeroNameAndHeroFullName](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a1e0d164773983afa86bc85551afe9804) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) firstName, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) fullName, bool useDeterministicValues=true) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GenerateHeroFirstName](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a961c094700d5208f9c60e654f2b2adef) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GenerateFirstNameForPlayer](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a36fb45d7ce0f0391902242b3ce9b982e) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, bool isFemale) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GenerateClanName](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a5bb910efffd6f68e92a2bdb02c405001) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) culture, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) clanOriginSettlement) |
| MBReadOnlyList< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | [GetNameListForCulture](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#addca99da99bb90932b6b9c4040fd1424) ([CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) npcCulture, bool isFemale) |
| void | [AddName](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a42ac60bd1605d65b7ad8a8941cc54083) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |

|  |  |
| --- | --- |
| Properties | |
| static [NameGenerator](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a0897d15a6075ac05c506e35cc6212cdf) | [Current](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#ae566fdf0bb22f5091901d14967b99062) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a0897d15a6075ac05c506e35cc6212cdf)NameGenerator()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.NameGenerator.NameGenerator | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a1e0d164773983afa86bc85551afe9804)GenerateHeroNameAndHeroFullName()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.NameGenerator.GenerateHeroNameAndHeroFullName | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *firstName*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *fullName*, |
|  |  | bool | *useDeterministicValues* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a961c094700d5208f9c60e654f2b2adef)GenerateHeroFirstName()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.NameGenerator.GenerateHeroFirstName | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a36fb45d7ce0f0391902242b3ce9b982e)GenerateFirstNameForPlayer()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.NameGenerator.GenerateFirstNameForPlayer | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | bool | *isFemale* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a5bb910efffd6f68e92a2bdb02c405001)GenerateClanName()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.NameGenerator.GenerateClanName | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *culture*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *clanOriginSettlement* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#addca99da99bb90932b6b9c4040fd1424)GetNameListForCulture()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| MBReadOnlyList< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > TaleWorlds.CampaignSystem.NameGenerator.GetNameListForCulture | ( | [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | *npcCulture*, |
|  |  | bool | *isFemale* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a42ac60bd1605d65b7ad8a8941cc54083)AddName()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.NameGenerator.AddName | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#ae566fdf0bb22f5091901d14967b99062)Current
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [NameGenerator](class_tale_worlds_1_1_campaign_system_1_1_name_generator.html#a0897d15a6075ac05c506e35cc6212cdf) TaleWorlds.CampaignSystem.NameGenerator.Current | | staticget |

