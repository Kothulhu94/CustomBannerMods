--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonBreakModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonBreakModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prison_break_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html#a220a9e7e7140df61fff5d9ae94b8929c)GetNumberOfGuardsToSpawn()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonBreakModel.GetNumberOfGuardsToSpawn | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html#af9c5281eb4e6a5fc7013839d060079d6)CanPlayerStagePrisonBreak()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonBreakModel.CanPlayerStagePrisonBreak | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html#a51bd6ccc5676dc3e8b478211072e4cec)GetPrisonBreakStartCost()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonBreakModel.GetPrisonBreakStartCost | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html#abee8bed54931cec4d4c0a22fccad3b1e)GetRelationRewardOnPrisonBreak()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonBreakModel.GetRelationRewardOnPrisonBreak | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prison_break_model.html#a609a42918d668aa08733e451c5544501)GetRogueryRewardOnPrisonBreak()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonBreakModel.GetRogueryRewardOnPrisonBreak | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *prisonerHero*, | |  |  | bool | *isSuccess* ) | | abstract |

