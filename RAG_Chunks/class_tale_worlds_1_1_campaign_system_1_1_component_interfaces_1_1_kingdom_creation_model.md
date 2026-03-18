--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomCreationModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsPlayerKingdomCreationPossible](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a32ca34ca819c0c455ffb5a537b4ea88d) (out List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > explanations) |
| bool | [IsPlayerKingdomAbdicationPossible](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a99453e6bebb032e0878ce5aa12836375) (out List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > explanations) |
| IEnumerable< [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) > | [GetAvailablePlayerKingdomCultures](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a292386cc9f9c583723261e15e3a2be87) () |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [MinimumClanTierToCreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#ac09d9363ded85790182162f37af19c78) `[get]` |
| int | [MinimumNumberOfSettlementsOwnedToCreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#adaf111fc42d6e4eeb30faf0156d1700e) `[get]` |
| int | [MinimumTroopCountToCreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#ae5f7fe220755e7995c21bac998344dca) `[get]` |
| int | [MaximumNumberOfInitialPolicies](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a918b92ce11f7203114bcb9d43b7bcf08) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a32ca34ca819c0c455ffb5a537b4ea88d)IsPlayerKingdomCreationPossible()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel.IsPlayerKingdomCreationPossible | ( | out List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *explanations* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a99453e6bebb032e0878ce5aa12836375)IsPlayerKingdomAbdicationPossible()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel.IsPlayerKingdomAbdicationPossible | ( | out List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *explanations* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a292386cc9f9c583723261e15e3a2be87)GetAvailablePlayerKingdomCultures()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | IEnumerable< [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel.GetAvailablePlayerKingdomCultures | ( |  | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#ac09d9363ded85790182162f37af19c78)MinimumClanTierToCreateKingdom
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel.MinimumClanTierToCreateKingdom | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#adaf111fc42d6e4eeb30faf0156d1700e)MinimumNumberOfSettlementsOwnedToCreateKingdom
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel.MinimumNumberOfSettlementsOwnedToCreateKingdom | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#ae5f7fe220755e7995c21bac998344dca)MinimumTroopCountToCreateKingdom
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel.MinimumTroopCountToCreateKingdom | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a918b92ce11f7203114bcb9d43b7bcf08)MaximumNumberOfInitialPolicies
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel.MaximumNumberOfInitialPolicies | | getabstract |

