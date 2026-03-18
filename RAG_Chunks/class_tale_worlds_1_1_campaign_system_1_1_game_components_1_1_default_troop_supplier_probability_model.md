--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_supplier_probability_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSupplierProbabilityModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSupplierProbabilityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_supplier_probability_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [EnqueueTroopSpawnProbabilitiesAccordingToUnitSpawnPrioritization](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_supplier_probability_model.html#af36473a6dff146dd31ec8e6fb12a5b60) ([MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) battleParty, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) priorityTroops, bool includePlayer, int sizeOfSide, bool forcePriorityTroops, List< ValueTuple< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > priorityList) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.TroopSupplierProbabilityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_supplier_probability_model.html) | |
| void | [EnqueueTroopSpawnProbabilitiesAccordingToUnitSpawnPrioritization](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_troop_supplier_probability_model.html#a48ed3247f6bd4998ce5a9083313408f6) ([MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) battleParty, [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) priorityTroops, bool includePlayers, int sizeOfSide, bool forcePriorityTroops, List< ValueTuple< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > priorityList) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_troop_supplier_probability_model.html#af36473a6dff146dd31ec8e6fb12a5b60)EnqueueTroopSpawnProbabilitiesAccordingToUnitSpawnPrioritization()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultTroopSupplierProbabilityModel.EnqueueTroopSpawnProbabilitiesAccordingToUnitSpawnPrioritization | ( | [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) | *battleParty*, |
|  |  | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *priorityTroops*, |
|  |  | bool | *includePlayer*, |
|  |  | int | *sizeOfSide*, |
|  |  | bool | *forcePriorityTroops*, |
|  |  | List< ValueTuple< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | *priorityList* ) |

