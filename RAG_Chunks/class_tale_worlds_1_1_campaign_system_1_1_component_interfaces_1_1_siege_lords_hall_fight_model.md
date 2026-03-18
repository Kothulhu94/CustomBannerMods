--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeLordsHallFightModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | [GetPriorityListForLordsHallFightMission](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a0edae859f82423301adfe211db83948b) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) playerMapEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, int troopCount) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| float | [AreaLostRatio](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a3a01ba644da77558b58779a92c2772f1) `[get]` |
| float | [AttackerDefenderTroopCountRatio](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a591f24bb9eae17b1966a1c4615c63e19) `[get]` |
| int | [DefenderTroopNumberForSuccessfulPullBack](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a051d88ba0a7ee03c7b65e05bda63dfdb) `[get]` |
| float | [DefenderMaxArcherRatio](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a2a4b955017ae0136bd342aafc3c14246) `[get]` |
| int | [MaxDefenderSideTroopCount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#aafdc8c1e9a49ec5a00fe93774c7cbddb) `[get]` |
| int | [MaxDefenderArcherCount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a606fdd8b27f6701085c034fb6ca08441) `[get]` |
| int | [MaxAttackerSideTroopCount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#acf86f0a795d04f6fbcf4e3011ffd723c) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a0edae859f82423301adfe211db83948b)GetPriorityListForLordsHallFightMission()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel.GetPriorityListForLordsHallFightMission | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *playerMapEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | int | *troopCount* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a3a01ba644da77558b58779a92c2772f1)AreaLostRatio
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel.AreaLostRatio | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a591f24bb9eae17b1966a1c4615c63e19)AttackerDefenderTroopCountRatio
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel.AttackerDefenderTroopCountRatio | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a051d88ba0a7ee03c7b65e05bda63dfdb)DefenderTroopNumberForSuccessfulPullBack
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel.DefenderTroopNumberForSuccessfulPullBack | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a2a4b955017ae0136bd342aafc3c14246)DefenderMaxArcherRatio
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel.DefenderMaxArcherRatio | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#aafdc8c1e9a49ec5a00fe93774c7cbddb)MaxDefenderSideTroopCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel.MaxDefenderSideTroopCount | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a606fdd8b27f6701085c034fb6ca08441)MaxDefenderArcherCount
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel.MaxDefenderArcherCount | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#acf86f0a795d04f6fbcf4e3011ffd723c)MaxAttackerSideTroopCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel.MaxAttackerSideTroopCount | | getabstract |

