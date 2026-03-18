--- SOURCE: class_sand_box_1_1_game_components_1_1_default_claimant_model.html ---

SandBox.GameComponents.DefaultClaimantModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override string | [GetClaimantHeroStringId](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a55b442df6dfdb2fcd5b8b133b90d3741) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetIncumbentHero](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#acbd4e50697e8a6eea6df154dacdbb13e) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| override bool | [CanStartClaimantQuestOfKingdom](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a6da88e019444475b8a8bf2f5d5d4cc3c) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html) | |
| string | [GetClaimantHeroStringId](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a77b40b899ec6f5e8a0c49d17b4844a4d) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetIncumbentHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#acc797145383829befcf9217a77bcb2d6) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| bool | [CanStartClaimantQuestOfKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#ac82847436fc744c5bc3409940cfaccde) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) kingdom) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [QuestDurationInDays](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a5fb2c79fe29a42fe2816ef10a063f67c) `[get]` |
| override int | [QuestInvalidateDurationInDays](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a9383a1880a75f0a1be312a614affdade) `[get]` |
| override int | [ClanTierRequiredForQuestActivation](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#ace233e928023b146b87d68f56fb76577) `[get]` |
| override int | [FortificationLimitOfTargetKingdom](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a003065e40586e8d8e426a2d24f804279) `[get]` |
| override int | [RescueClaimantTimeInDays](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a972512529797cdd9d0799e93cf97fe2d) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ClaimantModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html) | |
| int | [ClanTierRequiredForQuestActivation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#ad9697b83003a45c2e9c7c0a8f17bf8c2) `[get]` |
| int | [QuestDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#ad3918bd2f30dc48c26d5196804c9850b) `[get]` |
| int | [QuestInvalidateDurationInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a6abf79ca70f7c287afb25a70369c97fb) `[get]` |
| int | [FortificationLimitOfTargetKingdom](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a170a7e9c9253ba64ac6b3a019aefae2e) `[get]` |
| int | [RescueClaimantTimeInDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_claimant_model.html#a48f0e467555b841f01320a4cf0d32712) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a55b442df6dfdb2fcd5b8b133b90d3741)GetClaimantHeroStringId()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override string SandBox.GameComponents.DefaultClaimantModel.GetClaimantHeroStringId | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

[◆](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#acbd4e50697e8a6eea6df154dacdbb13e)GetIncumbentHero()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) SandBox.GameComponents.DefaultClaimantModel.GetIncumbentHero | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

[◆](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a6da88e019444475b8a8bf2f5d5d4cc3c)CanStartClaimantQuestOfKingdom()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool SandBox.GameComponents.DefaultClaimantModel.CanStartClaimantQuestOfKingdom | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html) | *kingdom* | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a5fb2c79fe29a42fe2816ef10a063f67c)QuestDurationInDays
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int SandBox.GameComponents.DefaultClaimantModel.QuestDurationInDays | | get |

[◆](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a9383a1880a75f0a1be312a614affdade)QuestInvalidateDurationInDays
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int SandBox.GameComponents.DefaultClaimantModel.QuestInvalidateDurationInDays | | get |

[◆](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#ace233e928023b146b87d68f56fb76577)ClanTierRequiredForQuestActivation
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int SandBox.GameComponents.DefaultClaimantModel.ClanTierRequiredForQuestActivation | | get |

[◆](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a003065e40586e8d8e426a2d24f804279)FortificationLimitOfTargetKingdom
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int SandBox.GameComponents.DefaultClaimantModel.FortificationLimitOfTargetKingdom | | get |

[◆](class_sand_box_1_1_game_components_1_1_default_claimant_model.html#a972512529797cdd9d0799e93cf97fe2d)RescueClaimantTimeInDays
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int SandBox.GameComponents.DefaultClaimantModel.RescueClaimantTimeInDays | | get |

