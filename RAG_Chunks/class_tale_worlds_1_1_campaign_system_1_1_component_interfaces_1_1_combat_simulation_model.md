--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [SimulateHit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a010fe62cd7f0496437f4de0dc292790d) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) strikerTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) struckTroop, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) strikerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) struckParty, float strikerAdvantage, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) battle, float strikerSideMorale, float struckSideMorale) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [SimulateHit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#aed5d8caddf8c0c03006b33e9048bc8c4) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) strikerShip, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) struckShip, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) strikerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) struckParty, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, float strikerAdvantage, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) battle, out int troopCasualties) |
| int int attackerRounds | [GetSimulationTicksForBattleRound](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#aa8baf0bb8b302398ad3ef6e6ce3afc0a) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| int | [GetNumberOfEquipmentsBuilt](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a6cc930fffc5e9d9861989f0ddd6a76b5) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| float | [GetMaximumSiegeEquipmentProgress](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a8184d6d6c400461331173e42613be624) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| float | [GetSettlementAdvantage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a2c115d1360423bdb447c6276d2cf30e9) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [GetBattleAdvantage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a425e21f75980f4a5614298cdbc283671) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, out [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) defenderAdvantage, out [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) attackerAdvantage) |
| float | [GetShipSiegeEngineHitChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a54edc14948747088e00c1d8804f4bd00) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| int | [GetPursuitRoundCount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a62a6081a55a7b26693134ece14c3f9f3) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| float | [GetBluntDamageChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#abf6243d5f383a738113b1f4f908c7f7a) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) strikerTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) strikedTroop, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) strikerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) strikedParty, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) battle) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [defenderRounds](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a2805e5ce2b04ab6c7b46242cd9531fc0) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a010fe62cd7f0496437f4de0dc292790d)SimulateHit() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.SimulateHit | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *strikerTroop*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *struckTroop*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *strikerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *struckParty*, | |  |  | float | *strikerAdvantage*, | |  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *battle*, | |  |  | float | *strikerSideMorale*, | |  |  | float | *struckSideMorale* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#aed5d8caddf8c0c03006b33e9048bc8c4)SimulateHit() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.SimulateHit | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *strikerShip*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *struckShip*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *strikerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *struckParty*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, | |  |  | float | *strikerAdvantage*, | |  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *battle*, | |  |  | out int | *troopCasualties* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#aa8baf0bb8b302398ad3ef6e6ce3afc0a)GetSimulationTicksForBattleRound()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int int attackerRounds TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.GetSimulationTicksForBattleRound | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a6cc930fffc5e9d9861989f0ddd6a76b5)GetNumberOfEquipmentsBuilt()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.GetNumberOfEquipmentsBuilt | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a8184d6d6c400461331173e42613be624)GetMaximumSiegeEquipmentProgress()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.GetMaximumSiegeEquipmentProgress | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a2c115d1360423bdb447c6276d2cf30e9)GetSettlementAdvantage()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.GetSettlementAdvantage | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a425e21f75980f4a5614298cdbc283671)GetBattleAdvantage()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.GetBattleAdvantage | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, | |  |  | out [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *defenderAdvantage*, | |  |  | out [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *attackerAdvantage* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a54edc14948747088e00c1d8804f4bd00)GetShipSiegeEngineHitChance()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.GetShipSiegeEngineHitChance | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a62a6081a55a7b26693134ece14c3f9f3)GetPursuitRoundCount()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.GetPursuitRoundCount | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#abf6243d5f383a738113b1f4f908c7f7a)GetBluntDamageChance()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.GetBluntDamageChance | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *strikerTroop*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *strikedTroop*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *strikerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *strikedParty*, | |  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *battle* ) | | abstract |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a2805e5ce2b04ab6c7b46242cd9531fc0)defenderRounds
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel.defenderRounds | | abstract |

