--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.VolunteerModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultVolunteerModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [MaximumIndexHeroCanRecruitFromHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a7b301508bf943c835a392bdc51613733) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) buyerHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) sellerHero, int useValueAsRelation=-101) |
| int | [MaximumIndexGarrisonCanRecruitFromHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a4db707db8b95da69fdb39703b750c272) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) sellerHero) |
| float | [GetDailyVolunteerProductionProbability](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a7d8d5e90015d646070fcd3f620b1d7ae) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int index, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetBasicVolunteer](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a17f7d2deb4f2b1eef951cb3c3ed6fddb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| bool | [CanHaveRecruits](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#adfc7558098976080b9492b31c665d302) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [MaxVolunteerTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a3960c35f84f738536b54e7fcc3459614) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a7b301508bf943c835a392bdc51613733)MaximumIndexHeroCanRecruitFromHero()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.VolunteerModel.MaximumIndexHeroCanRecruitFromHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *buyerHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *sellerHero*, | |  |  | int | *useValueAsRelation* = -101 ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a4db707db8b95da69fdb39703b750c272)MaximumIndexGarrisonCanRecruitFromHero()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.VolunteerModel.MaximumIndexGarrisonCanRecruitFromHero | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *sellerHero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a7d8d5e90015d646070fcd3f620b1d7ae)GetDailyVolunteerProductionProbability()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.VolunteerModel.GetDailyVolunteerProductionProbability | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *index*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a17f7d2deb4f2b1eef951cb3c3ed6fddb)GetBasicVolunteer()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.VolunteerModel.GetBasicVolunteer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#adfc7558098976080b9492b31c665d302)CanHaveRecruits()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.VolunteerModel.CanHaveRecruits | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a3960c35f84f738536b54e7fcc3459614)MaxVolunteerTier
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.VolunteerModel.MaxVolunteerTier | | getabstract |

