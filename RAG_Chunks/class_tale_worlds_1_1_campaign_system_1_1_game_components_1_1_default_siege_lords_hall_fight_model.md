--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeLordsHallFightModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | [GetPriorityListForLordsHallFightMission](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a3c5356059f5e79b7e737886bcc40e685) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) playerMapEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, int troopCount) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html) | |
| [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | [GetPriorityListForLordsHallFightMission](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html#a0edae859f82423301adfe211db83948b) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) playerMapEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, int troopCount) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override float | [AreaLostRatio](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#afe2065e9879f06a99fbbf0808c66d670) `[get]` |
| override float | [AttackerDefenderTroopCountRatio](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a42c191ada6a418185541c04b26e718ce) `[get]` |
| override float | [DefenderMaxArcherRatio](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a0696db2b9ea5c7ee59a64aa32462e766) `[get]` |
| override int | [MaxDefenderSideTroopCount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#aaa36fbd0184a52767de2c8bb6b95bbaf) `[get]` |
| override int | [MaxDefenderArcherCount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a35a2af1c0bca4ed9033af386e94340da) `[get]` |
| override int | [MaxAttackerSideTroopCount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a5a093b6209839e2ff1fa8ecceb74cd2c) `[get]` |
| override int | [DefenderTroopNumberForSuccessfulPullBack](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a53748340f8395a5cb4e568af24e0b77b) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeLordsHallFightModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_lords_hall_fight_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a3c5356059f5e79b7e737886bcc40e685)GetPriorityListForLordsHallFightMission()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeLordsHallFightModel.GetPriorityListForLordsHallFightMission | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *playerMapEvent*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | int | *troopCount* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#afe2065e9879f06a99fbbf0808c66d670)AreaLostRatio
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeLordsHallFightModel.AreaLostRatio | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a42c191ada6a418185541c04b26e718ce)AttackerDefenderTroopCountRatio
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeLordsHallFightModel.AttackerDefenderTroopCountRatio | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a0696db2b9ea5c7ee59a64aa32462e766)DefenderMaxArcherRatio
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeLordsHallFightModel.DefenderMaxArcherRatio | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#aaa36fbd0184a52767de2c8bb6b95bbaf)MaxDefenderSideTroopCount
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeLordsHallFightModel.MaxDefenderSideTroopCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a35a2af1c0bca4ed9033af386e94340da)MaxDefenderArcherCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeLordsHallFightModel.MaxDefenderArcherCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a5a093b6209839e2ff1fa8ecceb74cd2c)MaxAttackerSideTroopCount
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeLordsHallFightModel.MaxAttackerSideTroopCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_lords_hall_fight_model.html#a53748340f8395a5cb4e568af24e0b77b)DefenderTroopNumberForSuccessfulPullBack
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeLordsHallFightModel.DefenderTroopNumberForSuccessfulPullBack | | get |

