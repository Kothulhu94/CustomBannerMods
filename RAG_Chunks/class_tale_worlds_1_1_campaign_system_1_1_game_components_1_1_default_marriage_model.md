--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [IsCoupleSuitableForMarriage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#ad9e38b1f53f235e41594000a4bfb67f6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) firstHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) secondHero) |
| override bool | [IsClanSuitableForMarriage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#af9f5a81f46f683c5699b38e9aaea37ea) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override float | [NpcCoupleMarriageChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#a8aa628315eeeb01cdcc4fcc8669c62f3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) firstHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) secondHero) |
| override bool | [ShouldNpcMarriageBetweenClansBeAllowed](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#abec033e21b5732bb1a74f2824079ec01) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) consideringClan, [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) targetClan) |
| override List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [GetAdultChildrenSuitableForMarriage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#afda587d549baabfaa75f18aef4ac1a98) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetEffectiveRelationIncrease](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#ab18f3a8271f9f0dbb63cfcf304ca704d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) firstHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) secondHero) |
| override bool | [IsSuitableForMarriage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#ae1c2e89642bd959d02553a0294914af0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) maidenOrSuitor) |
| override [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [GetClanAfterMarriage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#a8dc999e28e955a7bb8044d6152cd6a72) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) firstHero, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) secondHero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html) | |
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
| override int | [MinimumMarriageAgeMale](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#ad02f259c4b63b610cf08c99f79327afe) `[get]` |
| override int | [MinimumMarriageAgeFemale](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#a184d6f24336a95ac1100dc9ab0d1c9b0) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MarriageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html) | |
| int | [MinimumMarriageAgeMale](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a9c3efbbd8ac497baca126f97b074b3a9) `[get]` |
| int | [MinimumMarriageAgeFemale](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_marriage_model.html#a1b9527948095585cc74955d36be26420) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#ad9e38b1f53f235e41594000a4bfb67f6)IsCoupleSuitableForMarriage()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel.IsCoupleSuitableForMarriage | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *firstHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *secondHero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#af9f5a81f46f683c5699b38e9aaea37ea)IsClanSuitableForMarriage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel.IsClanSuitableForMarriage | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#a8aa628315eeeb01cdcc4fcc8669c62f3)NpcCoupleMarriageChance()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel.NpcCoupleMarriageChance | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *firstHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *secondHero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#abec033e21b5732bb1a74f2824079ec01)ShouldNpcMarriageBetweenClansBeAllowed()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel.ShouldNpcMarriageBetweenClansBeAllowed | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *consideringClan*, |
|  |  | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *targetClan* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#afda587d549baabfaa75f18aef4ac1a98)GetAdultChildrenSuitableForMarriage()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override List< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel.GetAdultChildrenSuitableForMarriage | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#ab18f3a8271f9f0dbb63cfcf304ca704d)GetEffectiveRelationIncrease()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel.GetEffectiveRelationIncrease | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *firstHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *secondHero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#ae1c2e89642bd959d02553a0294914af0)IsSuitableForMarriage()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel.IsSuitableForMarriage | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *maidenOrSuitor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#a8dc999e28e955a7bb8044d6152cd6a72)GetClanAfterMarriage()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel.GetClanAfterMarriage | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *firstHero*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *secondHero* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#ad02f259c4b63b610cf08c99f79327afe)MinimumMarriageAgeMale
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel.MinimumMarriageAgeMale | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_marriage_model.html#a184d6f24336a95ac1100dc9ab0d1c9b0)MinimumMarriageAgeFemale
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultMarriageModel.MinimumMarriageAgeFemale | | get |

