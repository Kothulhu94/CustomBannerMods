--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html ---

TaleWorlds.CampaignSystem.MapEvents.MapEventManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnMapEventCreated](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#ad823eb9dc7f5d231d420476bc02f20b3) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | [GetMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#aafc38b6ecfbe18a02eb264a32d097c2d) (int attackerPartyIndex) |
| List< [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) > | [GetMapEventsBetweenFactions](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#a300120074856681eabe9a8277bd0f8eb) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction1, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction2) |
| void | [FinalizePlayerMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#a81cb407e92b52d2d31453b6f951436d2) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent=null) |
| [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | [StartSiegeMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#adcbe52424a956fc438e238c977066366) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |
| [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | [StartSallyOutMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#a0e2f4a6a5f0c10b8f866982cc4b21560) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |
| [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | [StartSiegeOutsideMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#ab496b8c85da7c6002825b6da6cc22660) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |
| [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | [StartBlockadeBattleMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#a5a8d92437aa2abf4b6cea03470a266b1) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) > | [MapEvents](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#a776f70d68b4a29ff3a1929d718e035c7) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#ad823eb9dc7f5d231d420476bc02f20b3)OnMapEventCreated()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventManager.OnMapEventCreated | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#aafc38b6ecfbe18a02eb264a32d097c2d)GetMapEvent()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) TaleWorlds.CampaignSystem.MapEvents.MapEventManager.GetMapEvent | ( | int | *attackerPartyIndex* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#a300120074856681eabe9a8277bd0f8eb)GetMapEventsBetweenFactions()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) > TaleWorlds.CampaignSystem.MapEvents.MapEventManager.GetMapEventsBetweenFactions | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction1*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction2* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#a81cb407e92b52d2d31453b6f951436d2)FinalizePlayerMapEvent()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventManager.FinalizePlayerMapEvent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* = null | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#adcbe52424a956fc438e238c977066366)StartSiegeMapEvent()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) TaleWorlds.CampaignSystem.MapEvents.MapEventManager.StartSiegeMapEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#a0e2f4a6a5f0c10b8f866982cc4b21560)StartSallyOutMapEvent()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) TaleWorlds.CampaignSystem.MapEvents.MapEventManager.StartSallyOutMapEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#ab496b8c85da7c6002825b6da6cc22660)StartSiegeOutsideMapEvent()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) TaleWorlds.CampaignSystem.MapEvents.MapEventManager.StartSiegeOutsideMapEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#a5a8d92437aa2abf4b6cea03470a266b1)StartBlockadeBattleMapEvent()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) TaleWorlds.CampaignSystem.MapEvents.MapEventManager.StartBlockadeBattleMapEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_manager.html#a776f70d68b4a29ff3a1929d718e035c7)MapEvents
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html)> TaleWorlds.CampaignSystem.MapEvents.MapEventManager.MapEvents | | get |

