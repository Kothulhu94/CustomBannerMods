--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.MilitaryPowerModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultMilitaryPowerModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_military_power_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetTroopPower](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#a903e784b3948a7a2e5c6d8a096a7cdae) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, MapEvent.PowerCalculationContext context, float leaderModifier) |
| float | [GetPowerOfParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#abd089b2ef407784d2a0a6aefaa68bd95) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, MapEvent.PowerCalculationContext context) |
| float | [GetContextModifier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#aaf83ffad9555549450a08cfe35527e5c) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSideEnum, MapEvent.PowerCalculationContext context) |
| float | [GetContextModifier](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#af0da1ce94b493cbf02c79ec9ad801028) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSideEnum, MapEvent.PowerCalculationContext context) |
| MapEvent.PowerCalculationContext | [GetContextForPosition](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#a7cd7bf88f9b5da502fc6c9b9941d8696) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| float | [GetDefaultTroopPower](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#ab736c6eeeafd96fa33dba33cd61cc7a9) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop) |
| float | [GetPowerModifierOfHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#a76356e51c370173f420ddfae07e33863) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) leaderHero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#a903e784b3948a7a2e5c6d8a096a7cdae)GetTroopPower()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MilitaryPowerModel.GetTroopPower | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | MapEvent.PowerCalculationContext | *context*, | |  |  | float | *leaderModifier* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#abd089b2ef407784d2a0a6aefaa68bd95)GetPowerOfParty()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MilitaryPowerModel.GetPowerOfParty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | MapEvent.PowerCalculationContext | *context* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#aaf83ffad9555549450a08cfe35527e5c)GetContextModifier() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MilitaryPowerModel.GetContextModifier | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSideEnum*, | |  |  | MapEvent.PowerCalculationContext | *context* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#af0da1ce94b493cbf02c79ec9ad801028)GetContextModifier() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MilitaryPowerModel.GetContextModifier | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSideEnum*, | |  |  | MapEvent.PowerCalculationContext | *context* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#a7cd7bf88f9b5da502fc6c9b9941d8696)GetContextForPosition()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MapEvent.PowerCalculationContext TaleWorlds.CampaignSystem.ComponentInterfaces.MilitaryPowerModel.GetContextForPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#ab736c6eeeafd96fa33dba33cd61cc7a9)GetDefaultTroopPower()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MilitaryPowerModel.GetDefaultTroopPower | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_military_power_model.html#a76356e51c370173f420ddfae07e33863)GetPowerModifierOfHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MilitaryPowerModel.GetPowerModifierOfHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *leaderHero* | ) |  | | abstract |

