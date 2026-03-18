--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html ---

TaleWorlds.CampaignSystem.HeroCreator Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [CreateNotable](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#a995d72181ccde62ae7664fd1d200469a) ([Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) occupation, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement=null) |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [CreateSpecialHero](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#a62c0d5137d91b492a11c7c31a9904dc9) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) template, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) bornSettlement=null, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) faction=null, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) supporterOfClan=null, int age=-1) |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [CreateChild](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#a4c06dcc4623c414fe64cfdab2869a1e8) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) template, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) bornSettlement, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan, int age) |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [CreateRelativeNotableHero](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#a060da30ba98a05a3160707cb69aee004) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) relative) |
| static bool | [CreateBasicHero](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#adc9d475233b6dee0bb5fe0c033462e51) (string stringId, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool isAlive=true) |
|  | Returns true if a new hero created. Returns false if a hero with the given StringId is already exists. |
| static [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [DeliverOffSpring](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#a2e6913a99536946cf68c2073873a7404) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) mother, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) father, bool isOffspringFemale) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#a995d72181ccde62ae7664fd1d200469a)CreateNotable()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.HeroCreator.CreateNotable | ( | [Occupation](namespace_tale_worlds_1_1_campaign_system.html#aec98373ba979379d4fc6ada5620d672f) | *occupation*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* = null ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#a62c0d5137d91b492a11c7c31a9904dc9)CreateSpecialHero()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.HeroCreator.CreateSpecialHero | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *template*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *bornSettlement* = null, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *faction* = null, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *supporterOfClan* = null, | |  |  | int | *age* = -1 ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#a4c06dcc4623c414fe64cfdab2869a1e8)CreateChild()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.HeroCreator.CreateChild | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *template*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *bornSettlement*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan*, | |  |  | int | *age* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#a060da30ba98a05a3160707cb69aee004)CreateRelativeNotableHero()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.HeroCreator.CreateRelativeNotableHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *relative* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#adc9d475233b6dee0bb5fe0c033462e51)CreateBasicHero()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.HeroCreator.CreateBasicHero | ( | string | *stringId*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | out [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *isAlive* = true ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_hero_creator.html#a2e6913a99536946cf68c2073873a7404)DeliverOffSpring()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.HeroCreator.DeliverOffSpring | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *mother*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *father*, | |  |  | bool | *isOffspringFemale* ) | | static |

