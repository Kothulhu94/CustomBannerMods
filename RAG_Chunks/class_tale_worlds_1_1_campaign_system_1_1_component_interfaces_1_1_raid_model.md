--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_raid_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.RaidModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultRaidModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_raid_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| MBReadOnlyList<([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), float)> | [GetCommonLootItemScores](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_raid_model.html#a438258f9971be0f2a571373dc9368223) () |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateHitDamage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_raid_model.html#a9f06a5d28222673dd0f0463b8f5a286c) ([MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) attackerSide, float settlementHitPoints) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [GoldRewardForEachLostHearth](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_raid_model.html#a9806d19462bf793b1ae64f07481f1d54) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_raid_model.html#a438258f9971be0f2a571373dc9368223)GetCommonLootItemScores()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | MBReadOnlyList<([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html), float)> TaleWorlds.CampaignSystem.ComponentInterfaces.RaidModel.GetCommonLootItemScores | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_raid_model.html#a9f06a5d28222673dd0f0463b8f5a286c)CalculateHitDamage()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.RaidModel.CalculateHitDamage | ( | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | *attackerSide*, | |  |  | float | *settlementHitPoints* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_raid_model.html#a9806d19462bf793b1ae64f07481f1d54)GoldRewardForEachLostHearth
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.RaidModel.GoldRewardForEachLostHearth | | getabstract |

