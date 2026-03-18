--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSacrificeModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetLostTroopCountForBreakingInBesiegedSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a749155ce0bf14d0a59587773acd9407e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetLostTroopCountForBreakingOutOfBesiegedSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a3ecaaa27d8458ce75bf7ca5400560ed7) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, bool isBreakingOutFromPort) |
| int | [GetNumberOfTroopsSacrificedForTryingToGetAway](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a619f9b40211cc9bf5931c9fa58cb7432) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) playerBattleSide, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| void | [GetShipsToSacrificeForTryingToGetAway](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#afe2092d8c36080b8a5110482d0bcad40) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) playerBattleSide, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, out MBList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > shipsToCapture, out [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) shipToTakeDamage, out float damageToApplyForLastShip) |
| bool | [CanPlayerGetAwayFromEncounter](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a266d6e5f168eb29b4d8e65b0f7352a5f) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [BreakOutArmyLeaderRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a7debe42e9b9885fe7ab050e8c47717e1) `[get]` |
| int | [BreakOutArmyMemberRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a1d06e539713d6a110ce0bf1c61e0f0a8) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a749155ce0bf14d0a59587773acd9407e)GetLostTroopCountForBreakingInBesiegedSettlement()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel.GetLostTroopCountForBreakingInBesiegedSettlement | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a3ecaaa27d8458ce75bf7ca5400560ed7)GetLostTroopCountForBreakingOutOfBesiegedSettlement()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel.GetLostTroopCountForBreakingOutOfBesiegedSettlement | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | bool | *isBreakingOutFromPort* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a619f9b40211cc9bf5931c9fa58cb7432)GetNumberOfTroopsSacrificedForTryingToGetAway()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel.GetNumberOfTroopsSacrificedForTryingToGetAway | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *playerBattleSide*, | |  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#afe2092d8c36080b8a5110482d0bcad40)GetShipsToSacrificeForTryingToGetAway()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel.GetShipsToSacrificeForTryingToGetAway | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *playerBattleSide*, | |  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, | |  |  | out MBList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | *shipsToCapture*, | |  |  | out [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *shipToTakeDamage*, | |  |  | out float | *damageToApplyForLastShip* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a266d6e5f168eb29b4d8e65b0f7352a5f)CanPlayerGetAwayFromEncounter()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel.CanPlayerGetAwayFromEncounter | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a7debe42e9b9885fe7ab050e8c47717e1)BreakOutArmyLeaderRelationPenalty
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel.BreakOutArmyLeaderRelationPenalty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a1d06e539713d6a110ce0bf1c61e0f0a8)BreakOutArmyMemberRelationPenalty
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel.BreakOutArmyMemberRelationPenalty | | getabstract |

