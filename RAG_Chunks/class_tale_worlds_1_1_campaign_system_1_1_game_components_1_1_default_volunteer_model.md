--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultVolunteerModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.VolunteerModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [MaximumIndexHeroCanRecruitFromHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#a5fffa345c228d4fecd94f3611ee75214) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) buyerHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) sellerHero, int useValueAsRelation=-101) |
| override int | [MaximumIndexGarrisonCanRecruitFromHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#ab571b0886d4a237dc515356b32b2653b) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) sellerHero) |
| override float | [GetDailyVolunteerProductionProbability](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#a1272258da62de24c0b70094abe301a0b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int index, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetBasicVolunteer](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#ab6fa21ef0b5906bf7864ec7be5573aa1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) sellerHero) |
| override bool | [CanHaveRecruits](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#aaa8c80d017680286f88f3125b1f65c69) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.VolunteerModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html) | |
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
| override int | [MaxVolunteerTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#a472787dbdac08fef570c33f6b698bf37) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.VolunteerModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html) | |
| int | [MaxVolunteerTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_volunteer_model.html#a3960c35f84f738536b54e7fcc3459614) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#a5fffa345c228d4fecd94f3611ee75214)MaximumIndexHeroCanRecruitFromHero()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultVolunteerModel.MaximumIndexHeroCanRecruitFromHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *buyerHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *sellerHero*, |
|  |  | int | *useValueAsRelation* = -101 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#ab571b0886d4a237dc515356b32b2653b)MaximumIndexGarrisonCanRecruitFromHero()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultVolunteerModel.MaximumIndexGarrisonCanRecruitFromHero | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *sellerHero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#a1272258da62de24c0b70094abe301a0b)GetDailyVolunteerProductionProbability()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultVolunteerModel.GetDailyVolunteerProductionProbability | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | int | *index*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#ab6fa21ef0b5906bf7864ec7be5573aa1)GetBasicVolunteer()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.GameComponents.DefaultVolunteerModel.GetBasicVolunteer | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *sellerHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#aaa8c80d017680286f88f3125b1f65c69)CanHaveRecruits()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultVolunteerModel.CanHaveRecruits | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_volunteer_model.html#a472787dbdac08fef570c33f6b698bf37)MaxVolunteerTier
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultVolunteerModel.MaxVolunteerTier | | get |

