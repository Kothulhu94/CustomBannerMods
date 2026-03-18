--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [SandBox.GameComponents.DefaultClaimantModel](class_sand_box_1_1_game_components_1_1_default_claimant_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| string | [GetClaimantHeroStringId](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a77b40b899ec6f5e8a0c49d17b4844a4d) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetIncumbentHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#acc797145383829befcf9217a77bcb2d6) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| bool | [CanStartClaimantQuestOfKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#ac82847436fc744c5bc3409940cfaccde) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [ClanTierRequiredForQuestActivation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#ad9697b83003a45c2e9c7c0a8f17bf8c2) `[get]` |
| int | [QuestDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#ad3918bd2f30dc48c26d5196804c9850b) `[get]` |
| int | [QuestInvalidateDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a6abf79ca70f7c287afb25a70369c97fb) `[get]` |
| int | [FortificationLimitOfTargetKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a170a7e9c9253ba64ac6b3a019aefae2e) `[get]` |
| int | [RescueClaimantTimeInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a48f0e467555b841f01320a4cf0d32712) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a77b40b899ec6f5e8a0c49d17b4844a4d)GetClaimantHeroStringId()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel.GetClaimantHeroStringId | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#acc797145383829befcf9217a77bcb2d6)GetIncumbentHero()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel.GetIncumbentHero | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#ac82847436fc744c5bc3409940cfaccde)CanStartClaimantQuestOfKingdom()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel.CanStartClaimantQuestOfKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#ad9697b83003a45c2e9c7c0a8f17bf8c2)ClanTierRequiredForQuestActivation
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel.ClanTierRequiredForQuestActivation | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#ad3918bd2f30dc48c26d5196804c9850b)QuestDurationInDays
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel.QuestDurationInDays | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a6abf79ca70f7c287afb25a70369c97fb)QuestInvalidateDurationInDays
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel.QuestInvalidateDurationInDays | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a170a7e9c9253ba64ac6b3a019aefae2e)FortificationLimitOfTargetKingdom
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel.FortificationLimitOfTargetKingdom | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a48f0e467555b841f01320a4cf0d32712)RescueClaimantTimeInDays
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel.RescueClaimantTimeInDays | | getabstract |

