--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.BannerItemModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [StoryMode.GameComponents.StoryModeBannerItemModel](class_story_mode_1_1_game_components_1_1_story_mode_banner_item_model.html), and [TaleWorlds.CampaignSystem.GameComponents.DefaultBannerItemModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| IEnumerable< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [GetPossibleRewardBannerItems](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#a6bba611cfc230b5360a48f88b9b96d18) () |
| IEnumerable< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [GetPossibleRewardBannerItemsForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#aa7940a33e24034c51f35406edafbfbdb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| int | [GetBannerItemLevelForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#a00bb5a181c3ae647a6177d5d29b033ac) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| bool | [CanBannerBeUpdated](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#a87dccc877c666691583c1309f82be2a6) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#a6bba611cfc230b5360a48f88b9b96d18)GetPossibleRewardBannerItems()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | IEnumerable< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.BannerItemModel.GetPossibleRewardBannerItems | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#aa7940a33e24034c51f35406edafbfbdb)GetPossibleRewardBannerItemsForHero()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.BannerItemModel.GetPossibleRewardBannerItemsForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#a00bb5a181c3ae647a6177d5d29b033ac)GetBannerItemLevelForHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BannerItemModel.GetBannerItemLevelForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#a87dccc877c666691583c1309f82be2a6)CanBannerBeUpdated()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.BannerItemModel.CanBannerBeUpdated | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  | | abstract |

