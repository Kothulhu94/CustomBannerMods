--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html ---

TaleWorlds.CampaignSystem.MapEvents.SiegeAmbushEventComponent Class ReferenceInherits [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SiegeAmbushEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#ad975f1f961b2e27aff46f4f44b4b146b) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [SiegeAmbushEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#ad975f1f961b2e27aff46f4f44b4b146b) | [CreateSiegeAmbushEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#a350a317bb3d5e2f7e21581edc6895222) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#a50bf9eccc317806818ad177d49288a32) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | |
|  | [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a04ce5f7286860bb13e8c09cc416417b4) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |
| virtual void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a63743e7e9b72896ba8ef1a6b838b1c95) () |
| virtual void | [OnBeforeFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a608243f9d25a7913e54337f72a98b70a) () |

|  |  |
| --- | --- |
| Properties | |
| override [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#a5c9ed7a3e3d1cc4e3e355654348ce35a) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | |
| MapEvent | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) `[get]` |
| [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a5a894e37fd33ff302ddf2e575804d98c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#ad975f1f961b2e27aff46f4f44b4b146b)SiegeAmbushEventComponent()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.MapEvents.SiegeAmbushEventComponent.SiegeAmbushEventComponent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) | *mapEvent* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#a350a317bb3d5e2f7e21581edc6895222)CreateSiegeAmbushEvent()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [SiegeAmbushEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#ad975f1f961b2e27aff46f4f44b4b146b) TaleWorlds.CampaignSystem.MapEvents.SiegeAmbushEventComponent.CreateSiegeAmbushEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#a50bf9eccc317806818ad177d49288a32)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.MapEvents.SiegeAmbushEventComponent.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#af6cf498e95a584c027f19f965ccbe618).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#a5c9ed7a3e3d1cc4e3e355654348ce35a)SimulationContext
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) TaleWorlds.CampaignSystem.MapEvents.SiegeAmbushEventComponent.SimulationContext | | get |

