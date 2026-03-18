--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [SimulateHit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#abbbf4296d3ee0959bb6865f7d08048bf) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) strikerTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) struckTroop, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) strikerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) struckParty, float strikerAdvantage, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) battle, float strikerSideMorale, float struckSideMorale) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [SimulateHit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a70ceaf0322ad43c86abd0b3dc35d1e6d) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) strikerShip, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) struckShip, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) strikerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) struckParty, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, float strikerAdvantage, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) battle, out int troopCasualties) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) float | [GetMaximumSiegeEquipmentProgress](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a95a7e5cacc1ebd7c17f2d41e343f39b0) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) int | [GetNumberOfEquipmentsBuilt](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#ae6ded4a6414f4575ca9e18aaf59f853a) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) float | [GetSettlementAdvantage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#afae94187f55d91a29f6f8ed776b33fa8) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
|  | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) (int [defenderRounds](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a2805e5ce2b04ab6c7b46242cd9531fc0), int attackerRounds) [GetSimulationTicksForBattleRound](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#aa8baf0bb8b302398ad3ef6e6ce3afc0a)([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) void | [GetBattleAdvantage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#af14aff8cecdf7a215ff658e163ea622d) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, out [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) defenderAdvantage, out [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) attackerAdvantage) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) float | [GetShipSiegeEngineHitChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#ad3e69ac3459ac040f8a06a6a6fd2f5fc) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) int | [GetPursuitRoundCount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#ad64021e0af08dc342d7567c2c6d74d09) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) float | [GetBluntDamageChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#ad6cf6a04893d1d0d4e6d065c26698b3d) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) strikerTroop, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) strikedTroop, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) strikerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) strikedParty, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) battle) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html) | |
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
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CombatSimulationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html) | |
| int | [defenderRounds](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_combat_simulation_model.html#a2805e5ce2b04ab6c7b46242cd9531fc0) |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#abbbf4296d3ee0959bb6865f7d08048bf)SimulateHit() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel.SimulateHit | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *strikerTroop*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *struckTroop*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *strikerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *struckParty*, |
|  |  | float | *strikerAdvantage*, |
|  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *battle*, |
|  |  | float | *strikerSideMorale*, |
|  |  | float | *struckSideMorale* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a70ceaf0322ad43c86abd0b3dc35d1e6d)SimulateHit() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel.SimulateHit | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *strikerShip*, |
|  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *struckShip*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *strikerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *struckParty*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, |
|  |  | float | *strikerAdvantage*, |
|  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *battle*, |
|  |  | out int | *troopCasualties* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a95a7e5cacc1ebd7c17f2d41e343f39b0)GetMaximumSiegeEquipmentProgress()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) float TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel.GetMaximumSiegeEquipmentProgress | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#ae6ded4a6414f4575ca9e18aaf59f853a)GetNumberOfEquipmentsBuilt()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) int TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel.GetNumberOfEquipmentsBuilt | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#afae94187f55d91a29f6f8ed776b33fa8)GetSettlementAdvantage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) float TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel.GetSettlementAdvantage | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65)override()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel.override | ( | int | *defenderRounds*, |
|  |  | int | *attackerRounds* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#af14aff8cecdf7a215ff658e163ea622d)GetBattleAdvantage()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) void TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel.GetBattleAdvantage | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, |
|  |  | out [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *defenderAdvantage*, |
|  |  | out [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *attackerAdvantage* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#ad3e69ac3459ac040f8a06a6a6fd2f5fc)GetShipSiegeEngineHitChance()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) float TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel.GetShipSiegeEngineHitChance | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#ad64021e0af08dc342d7567c2c6d74d09)GetPursuitRoundCount()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) int TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel.GetPursuitRoundCount | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#ad6cf6a04893d1d0d4e6d065c26698b3d)GetBluntDamageChance()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_combat_simulation_model.html#a48e09cd2636ea8d01f06b8490df32f65) float TaleWorlds.CampaignSystem.GameComponents.DefaultCombatSimulationModel.GetBluntDamageChance | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *strikerTroop*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *strikedTroop*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *strikerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *strikedParty*, |
|  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *battle* ) |

