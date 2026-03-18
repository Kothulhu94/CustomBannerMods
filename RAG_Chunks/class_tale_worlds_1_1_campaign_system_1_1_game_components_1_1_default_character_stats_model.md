--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_stats_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterStatsModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterStatsModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_stats_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [WoundedHitPointLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_stats_model.html#a02a930b12f71710d232d6989bd2b6d43) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_stats_model.html#a02678ace14ac1646ca740963db32699e) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [MaxHitpoints](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_stats_model.html#a0bfa66c74ede4beab5e7a48f1c23a1c7) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool includeDescriptions=false) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterStatsModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_stats_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [MaxHitpoints](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_stats_model.html#ab82e189232bfb6cf743b7d1a858351c1) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool includeDescriptions=false) |
| int | [GetTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_stats_model.html#ace19219eb9b88435b8a74753edcb0af9) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| int | [WoundedHitPointLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_stats_model.html#ae1494b4134c97274f3d37a3bf4ca9d3c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [MaxCharacterTier](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_stats_model.html#ab4d95493033b85ba518113c9e9a16f7b) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterStatsModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_stats_model.html) | |
| int | [MaxCharacterTier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_stats_model.html#a990d1995d496a01e5d37d907902538d5) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_stats_model.html#a02a930b12f71710d232d6989bd2b6d43)WoundedHitPointLimit()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterStatsModel.WoundedHitPointLimit | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_stats_model.html#a02678ace14ac1646ca740963db32699e)GetTier()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterStatsModel.GetTier | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_stats_model.html#a0bfa66c74ede4beab5e7a48f1c23a1c7)MaxHitpoints()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterStatsModel.MaxHitpoints | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | bool | *includeDescriptions* = false ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_stats_model.html#ab4d95493033b85ba518113c9e9a16f7b)MaxCharacterTier
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterStatsModel.MaxCharacterTier | | get |

