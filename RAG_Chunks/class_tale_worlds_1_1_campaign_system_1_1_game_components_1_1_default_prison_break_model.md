--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonBreakModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonBreakModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetNumberOfGuardsToSpawn](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html#a21c93ca1ec863081c9742a0230a98d48) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override bool | [CanPlayerStagePrisonBreak](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html#af074e51ad99a1458f311a857c917b173) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override int | [GetPrisonBreakStartCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html#a3314bef1185ba85a61d2dc19aa6d150b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero) |
| override int | [GetRelationRewardOnPrisonBreak](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html#a13707e74356aa1465ccc7f57b436c74c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero) |
| override float | [GetRogueryRewardOnPrisonBreak](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html#a90e05068be00e76ce605a31bc93d0d39) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero, bool isSuccess) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonBreakModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html) | |
| int | [GetNumberOfGuardsToSpawn](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html#a220a9e7e7140df61fff5d9ae94b8929c) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| bool | [CanPlayerStagePrisonBreak](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html#af9c5281eb4e6a5fc7013839d060079d6) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| int | [GetPrisonBreakStartCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html#a51bd6ccc5676dc3e8b478211072e4cec) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero) |
| int | [GetRelationRewardOnPrisonBreak](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html#abee8bed54931cec4d4c0a22fccad3b1e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero) |
| float | [GetRogueryRewardOnPrisonBreak](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html#a609a42918d668aa08733e451c5544501) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) prisonerHero, bool isSuccess) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html#a21c93ca1ec863081c9742a0230a98d48)GetNumberOfGuardsToSpawn()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonBreakModel.GetNumberOfGuardsToSpawn | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html#af074e51ad99a1458f311a857c917b173)CanPlayerStagePrisonBreak()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonBreakModel.CanPlayerStagePrisonBreak | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html#a3314bef1185ba85a61d2dc19aa6d150b)GetPrisonBreakStartCost()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonBreakModel.GetPrisonBreakStartCost | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html#a13707e74356aa1465ccc7f57b436c74c)GetRelationRewardOnPrisonBreak()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonBreakModel.GetRelationRewardOnPrisonBreak | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html#a90e05068be00e76ce605a31bc93d0d39)GetRogueryRewardOnPrisonBreak()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonBreakModel.GetRogueryRewardOnPrisonBreak | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero*, |
|  |  | bool | *isSuccess* ) |

