--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomCreationModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [IsPlayerKingdomCreationPossible](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#a68e017444875836ab7351d98fbda93fe) (out List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > explanations) |
| override bool | [IsPlayerKingdomAbdicationPossible](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#a54597d640c92d7c452b355fd5340decb) (out List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > explanations) |
| override IEnumerable< [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) > | [GetAvailablePlayerKingdomCultures](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#a1eaec45bee6ff4a0fa48ad6db8a63fad) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html) | |
| bool | [IsPlayerKingdomCreationPossible](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a32ca34ca819c0c455ffb5a537b4ea88d) (out List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > explanations) |
| bool | [IsPlayerKingdomAbdicationPossible](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a99453e6bebb032e0878ce5aa12836375) (out List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > explanations) |
| IEnumerable< [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) > | [GetAvailablePlayerKingdomCultures](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a292386cc9f9c583723261e15e3a2be87) () |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [MinimumClanTierToCreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#ae1e37214cda31f438878be654dee1aec) `[get]` |
| override int | [MinimumNumberOfSettlementsOwnedToCreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#ab5157abb3e6dde3af54e5609dd2f7e37) `[get]` |
| override int | [MinimumTroopCountToCreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#a46639aec90bf835deec7690beeac76be) `[get]` |
| override int | [MaximumNumberOfInitialPolicies](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#ad40fcd09ae171ed60ee753e105dd93cc) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.KingdomCreationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html) | |
| int | [MinimumClanTierToCreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#ac09d9363ded85790182162f37af19c78) `[get]` |
| int | [MinimumNumberOfSettlementsOwnedToCreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#adaf111fc42d6e4eeb30faf0156d1700e) `[get]` |
| int | [MinimumTroopCountToCreateKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#ae5f7fe220755e7995c21bac998344dca) `[get]` |
| int | [MaximumNumberOfInitialPolicies](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_kingdom_creation_model.html#a918b92ce11f7203114bcb9d43b7bcf08) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#a68e017444875836ab7351d98fbda93fe)IsPlayerKingdomCreationPossible()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomCreationModel.IsPlayerKingdomCreationPossible | ( | out List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *explanations* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#a54597d640c92d7c452b355fd5340decb)IsPlayerKingdomAbdicationPossible()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomCreationModel.IsPlayerKingdomAbdicationPossible | ( | out List< [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) > | *explanations* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#a1eaec45bee6ff4a0fa48ad6db8a63fad)GetAvailablePlayerKingdomCultures()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override IEnumerable< [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomCreationModel.GetAvailablePlayerKingdomCultures | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#ae1e37214cda31f438878be654dee1aec)MinimumClanTierToCreateKingdom
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomCreationModel.MinimumClanTierToCreateKingdom | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#ab5157abb3e6dde3af54e5609dd2f7e37)MinimumNumberOfSettlementsOwnedToCreateKingdom
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomCreationModel.MinimumNumberOfSettlementsOwnedToCreateKingdom | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#a46639aec90bf835deec7690beeac76be)MinimumTroopCountToCreateKingdom
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomCreationModel.MinimumTroopCountToCreateKingdom | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_kingdom_creation_model.html#ad40fcd09ae171ed60ee753e105dd93cc)MaximumNumberOfInitialPolicies
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultKingdomCreationModel.MaximumNumberOfInitialPolicies | | get |

