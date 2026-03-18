--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultBannerItemModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.BannerItemModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override IEnumerable< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [GetPossibleRewardBannerItems](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#a88c60f5a7db6b5b20a74fd1844a888ed) () |
| override IEnumerable< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [GetPossibleRewardBannerItemsForHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#ae725efa044dfc6b048fdb2a74c620427) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetBannerItemLevelForHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#a271f547b8e62b18461a3a7f2feb3cfb3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override bool | [CanBannerBeUpdated](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#a503c436465449f7df58836b42d90c495) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.BannerItemModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html) | |
| IEnumerable< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [GetPossibleRewardBannerItems](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#a6bba611cfc230b5360a48f88b9b96d18) () |
| IEnumerable< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [GetPossibleRewardBannerItemsForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#aa7940a33e24034c51f35406edafbfbdb) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| int | [GetBannerItemLevelForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#a00bb5a181c3ae647a6177d5d29b033ac) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| bool | [CanBannerBeUpdated](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_banner_item_model.html#a87dccc877c666691583c1309f82be2a6) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [BannerLevel1](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#ad465b0708c652a9fd9297bcf61804df7) = 1 |
| const int | [BannerLevel2](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#a5f54dbaa585994fdbd0ec6beda2db6a8) = 2 |
| const int | [BannerLevel3](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#a66ad9685cb960964ffafe4bb3910eb29) = 3 |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#a88c60f5a7db6b5b20a74fd1844a888ed)GetPossibleRewardBannerItems()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override IEnumerable< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultBannerItemModel.GetPossibleRewardBannerItems | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#ae725efa044dfc6b048fdb2a74c620427)GetPossibleRewardBannerItemsForHero()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override IEnumerable< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultBannerItemModel.GetPossibleRewardBannerItemsForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#a271f547b8e62b18461a3a7f2feb3cfb3)GetBannerItemLevelForHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBannerItemModel.GetBannerItemLevelForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#a503c436465449f7df58836b42d90c495)CanBannerBeUpdated()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultBannerItemModel.CanBannerBeUpdated | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#ad465b0708c652a9fd9297bcf61804df7)BannerLevel1
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.GameComponents.DefaultBannerItemModel.BannerLevel1 = 1 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#a5f54dbaa585994fdbd0ec6beda2db6a8)BannerLevel2
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.GameComponents.DefaultBannerItemModel.BannerLevel2 = 2 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_banner_item_model.html#a66ad9685cb960964ffafe4bb3910eb29)BannerLevel3
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.GameComponents.DefaultBannerItemModel.BannerLevel3 = 3 | | static |

