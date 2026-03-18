--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultNotablePowerModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_notable_power_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| int | [RegularNotableMaxPowerLevel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#a8fc0ea0ed03887cb7be0cf607004d520) `[get]` |
| int | [NotableDisappearPowerLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#ac6583a106fbce4e146cf61c02a2d21da) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#a9c8b3323d7f7952b146d5a8ff5828e6f)CalculateDailyPowerChangeForHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel.CalculateDailyPowerChangeForHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#aaee4bb1a2965a56ceea470c1e4596336)GetPowerRankName()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel.GetPowerRankName | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#a37b24a456da9fec8e45ece5f83e249b9)GetInfluenceBonusToClan()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel.GetInfluenceBonusToClan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#ad4f8794021da609e0378a6be3757c8ed)GetInitialPower()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel.GetInitialPower | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#a8728714e0e834029d3a92229214f2c27)GetInitialNotableSupporterCost()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel.GetInitialNotableSupporterCost | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#a8fc0ea0ed03887cb7be0cf607004d520)RegularNotableMaxPowerLevel
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel.RegularNotableMaxPowerLevel | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_notable_power_model.html#ac6583a106fbce4e146cf61c02a2d21da)NotableDisappearPowerLimit
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.NotablePowerModel.NotableDisappearPowerLimit | | getabstract |

