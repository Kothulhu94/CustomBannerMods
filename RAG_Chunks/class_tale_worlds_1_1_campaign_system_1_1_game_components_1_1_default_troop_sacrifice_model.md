--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSacrificeModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetLostTroopCountForBreakingInBesiegedSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#a4f89a9091f814d536a9bdd0949e97175) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetLostTroopCountForBreakingOutOfBesiegedSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#a75b6ab5fc285fa2cbed8d87a69e0fe4a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, bool isBreakingOutFromPort) |
| override int | [GetNumberOfTroopsSacrificedForTryingToGetAway](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#a978b6bcb247e70a4cf1ca223fef0567c) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) playerBattleSide, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| override bool | [CanPlayerGetAwayFromEncounter](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#ad827d4736ff3d7c7f2a3b69bee33e216) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| override void | [GetShipsToSacrificeForTryingToGetAway](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#a87120ef2e9fdf3f09f31adf6a44d861d) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) playerBattleSide, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, out MBList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > shipsToCapture, out [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) shipToTakeDamage, out float damageToApplyForLastShip) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetLostTroopCountForBreakingInBesiegedSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a749155ce0bf14d0a59587773acd9407e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetLostTroopCountForBreakingOutOfBesiegedSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a3ecaaa27d8458ce75bf7ca5400560ed7) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, bool isBreakingOutFromPort) |
| int | [GetNumberOfTroopsSacrificedForTryingToGetAway](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a619f9b40211cc9bf5931c9fa58cb7432) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) playerBattleSide, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| void | [GetShipsToSacrificeForTryingToGetAway](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#afe2092d8c36080b8a5110482d0bcad40) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) playerBattleSide, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, out MBList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > shipsToCapture, out [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) shipToTakeDamage, out float damageToApplyForLastShip) |
| bool | [CanPlayerGetAwayFromEncounter](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a266d6e5f168eb29b4d8e65b0f7352a5f) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MinimumNumberOfTroopsRequiredForGetAway](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#aa4bee04d84a6a486b8b9db99aa1ab868) = 8 |

|  |  |
| --- | --- |
| Properties | |
| override int | [BreakOutArmyLeaderRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#aa46131fb9072a3f62fd7c8db8286dcb7) `[get]` |
| override int | [BreakOutArmyMemberRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#a963283f69788889551e4ee31e105ff18) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSacrificeModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html) | |
| int | [BreakOutArmyLeaderRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a7debe42e9b9885fe7ab050e8c47717e1) `[get]` |
| int | [BreakOutArmyMemberRelationPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_sacrifice_model.html#a1d06e539713d6a110ce0bf1c61e0f0a8) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#a4f89a9091f814d536a9bdd0949e97175)GetLostTroopCountForBreakingInBesiegedSettlement()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSacrificeModel.GetLostTroopCountForBreakingInBesiegedSettlement | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#a75b6ab5fc285fa2cbed8d87a69e0fe4a)GetLostTroopCountForBreakingOutOfBesiegedSettlement()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSacrificeModel.GetLostTroopCountForBreakingOutOfBesiegedSettlement | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, |
|  |  | bool | *isBreakingOutFromPort* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#a978b6bcb247e70a4cf1ca223fef0567c)GetNumberOfTroopsSacrificedForTryingToGetAway()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSacrificeModel.GetNumberOfTroopsSacrificedForTryingToGetAway | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *playerBattleSide*, |
|  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#ad827d4736ff3d7c7f2a3b69bee33e216)CanPlayerGetAwayFromEncounter()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSacrificeModel.CanPlayerGetAwayFromEncounter | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#a87120ef2e9fdf3f09f31adf6a44d861d)GetShipsToSacrificeForTryingToGetAway()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSacrificeModel.GetShipsToSacrificeForTryingToGetAway | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *playerBattleSide*, |
|  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, |
|  |  | out MBList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | *shipsToCapture*, |
|  |  | out [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *shipToTakeDamage*, |
|  |  | out float | *damageToApplyForLastShip* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#aa4bee04d84a6a486b8b9db99aa1ab868)MinimumNumberOfTroopsRequiredForGetAway
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSacrificeModel.MinimumNumberOfTroopsRequiredForGetAway = 8 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#aa46131fb9072a3f62fd7c8db8286dcb7)BreakOutArmyLeaderRelationPenalty
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSacrificeModel.BreakOutArmyLeaderRelationPenalty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_sacrifice_model.html#a963283f69788889551e4ee31e105ff18)BreakOutArmyMemberRelationPenalty
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSacrificeModel.BreakOutArmyMemberRelationPenalty | | get |

