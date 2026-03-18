--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultNotablePowerModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyPowerChangeForHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#a10cba5a29b9d288c7fc0d87c96488454) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool includeDescriptions=false) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetPowerRankName](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#a933cd42e2e9315d434bd8e0b16baaaa3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override float | [GetInfluenceBonusToClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#ae06a6d623829049763a488f3cee795d5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetInitialPower](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#a7e0f41488a64a887b2d869a80b9606f7) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetInitialNotableSupporterCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#a21954fac1c155e0f499b7a09ee57874d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyPowerChangeForHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#a9c8b3323d7f7952b146d5a8ff5828e6f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, bool includeDescriptions=false) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetPowerRankName](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#aaee4bb1a2965a56ceea470c1e4596336) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| float | [GetInfluenceBonusToClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#a37b24a456da9fec8e45ece5f83e249b9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| int | [GetInitialPower](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#ad4f8794021da609e0378a6be3757c8ed) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| int | [GetInitialNotableSupporterCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#a8728714e0e834029d3a92229214f2c27) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [NotableDisappearPowerLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#af4e0f1dcbe65091072f8ac0ac0db38c5) `[get]` |
| override int | [RegularNotableMaxPowerLevel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#ac37ebbe7d44d0705a19cfa7703f5a645) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html) | |
| int | [RegularNotableMaxPowerLevel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#a8fc0ea0ed03887cb7be0cf607004d520) `[get]` |
| int | [NotableDisappearPowerLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#ac6583a106fbce4e146cf61c02a2d21da) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#a10cba5a29b9d288c7fc0d87c96488454)CalculateDailyPowerChangeForHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultNotablePowerModel.CalculateDailyPowerChangeForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#a933cd42e2e9315d434bd8e0b16baaaa3)GetPowerRankName()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.GameComponents.DefaultNotablePowerModel.GetPowerRankName | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#ae06a6d623829049763a488f3cee795d5)GetInfluenceBonusToClan()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultNotablePowerModel.GetInfluenceBonusToClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#a7e0f41488a64a887b2d869a80b9606f7)GetInitialPower()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultNotablePowerModel.GetInitialPower | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#a21954fac1c155e0f499b7a09ee57874d)GetInitialNotableSupporterCost()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultNotablePowerModel.GetInitialNotableSupporterCost | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#af4e0f1dcbe65091072f8ac0ac0db38c5)NotableDisappearPowerLimit
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultNotablePowerModel.NotableDisappearPowerLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html#ac37ebbe7d44d0705a19cfa7703f5a645)RegularNotableMaxPowerLevel
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultNotablePowerModel.RegularNotableMaxPowerLevel | | get |

