--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsCoupleSuitableForMarriage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#afd15e0244a4d58c58370125ecb85039b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) firstHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) secondHero) |
| int | [GetEffectiveRelationIncrease](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#ab3b9d6f2ade4d90b69323c379188f5e9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) firstHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) secondHero) |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [GetClanAfterMarriage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a164f52f161378e059cf6176ff468e1d6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) firstHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) secondHero) |
| bool | [IsSuitableForMarriage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#ae4dcb0a5c79ad5c9c4b3cb022b89d7ea) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| bool | [IsClanSuitableForMarriage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a122edb4ba8b8b0f42dffa0bec85423f3) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| float | [NpcCoupleMarriageChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a90aee24d880a399c57125064d60f6700) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) firstHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) secondHero) |
| bool | [ShouldNpcMarriageBetweenClansBeAllowed](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#ad96e0950bc4c1faa69e7ac44f2a6d3ad) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) consideringClan, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) targetClan) |
| List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [GetAdultChildrenSuitableForMarriage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#aad9534aebf35e533e853bc17ad5d649d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [MinimumMarriageAgeMale](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a9c3efbbd8ac497baca126f97b074b3a9) `[get]` |
| int | [MinimumMarriageAgeFemale](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a1b9527948095585cc74955d36be26420) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#afd15e0244a4d58c58370125ecb85039b)IsCoupleSuitableForMarriage()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel.IsCoupleSuitableForMarriage | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *firstHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *secondHero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#ab3b9d6f2ade4d90b69323c379188f5e9)GetEffectiveRelationIncrease()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel.GetEffectiveRelationIncrease | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *firstHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *secondHero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a164f52f161378e059cf6176ff468e1d6)GetClanAfterMarriage()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel.GetClanAfterMarriage | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *firstHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *secondHero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#ae4dcb0a5c79ad5c9c4b3cb022b89d7ea)IsSuitableForMarriage()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel.IsSuitableForMarriage | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a122edb4ba8b8b0f42dffa0bec85423f3)IsClanSuitableForMarriage()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel.IsClanSuitableForMarriage | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a90aee24d880a399c57125064d60f6700)NpcCoupleMarriageChance()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel.NpcCoupleMarriageChance | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *firstHero*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *secondHero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#ad96e0950bc4c1faa69e7ac44f2a6d3ad)ShouldNpcMarriageBetweenClansBeAllowed()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel.ShouldNpcMarriageBetweenClansBeAllowed | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *consideringClan*, | |  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *targetClan* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#aad9534aebf35e533e853bc17ad5d649d)GetAdultChildrenSuitableForMarriage()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel.GetAdultChildrenSuitableForMarriage | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a9c3efbbd8ac497baca126f97b074b3a9)MinimumMarriageAgeMale
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel.MinimumMarriageAgeMale | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a1b9527948095585cc74955d36be26420)MinimumMarriageAgeFemale
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel.MinimumMarriageAgeFemale | | getabstract |

