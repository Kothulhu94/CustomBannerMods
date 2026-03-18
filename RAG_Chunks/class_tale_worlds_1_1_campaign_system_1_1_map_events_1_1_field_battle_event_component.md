--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html ---

TaleWorlds.CampaignSystem.MapEvents.FieldBattleEventComponent Class ReferenceInherits [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html).

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [FieldBattleEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a98e26b8fa1513d1a21b273ac1af2c012) | [CreateFieldBattleEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a439f5e7c3b9f9fa4b228038a0c9f187f) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |
| static [FieldBattleEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a98e26b8fa1513d1a21b273ac1af2c012) | [CreateComponentForOldSaves](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a70b4d8c4d21cc39b1587ad7f2d023635) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [FieldBattleEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a98e26b8fa1513d1a21b273ac1af2c012) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |
| override void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a52fb86ad6c492b5b2de55b7adf9b8485) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a0ea5e4ab76c654dbe90bc36639a4327a) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | |
|  | [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a04ce5f7286860bb13e8c09cc416417b4) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |
| virtual void | [OnBeforeFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a608243f9d25a7913e54337f72a98b70a) () |

|  |  |
| --- | --- |
| Properties | |
| override [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#ad5ec296f4cb97857e213f0112423edf0) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | |
| MapEvent | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) `[get]` |
| [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a5a894e37fd33ff302ddf2e575804d98c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a98e26b8fa1513d1a21b273ac1af2c012)FieldBattleEventComponent()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.MapEvents.FieldBattleEventComponent.FieldBattleEventComponent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) | *mapEvent* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a439f5e7c3b9f9fa4b228038a0c9f187f)CreateFieldBattleEvent()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [FieldBattleEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a98e26b8fa1513d1a21b273ac1af2c012) TaleWorlds.CampaignSystem.MapEvents.FieldBattleEventComponent.CreateFieldBattleEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a70b4d8c4d21cc39b1587ad7f2d023635)CreateComponentForOldSaves()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [FieldBattleEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a98e26b8fa1513d1a21b273ac1af2c012) TaleWorlds.CampaignSystem.MapEvents.FieldBattleEventComponent.CreateComponentForOldSaves | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) | *mapEvent* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a52fb86ad6c492b5b2de55b7adf9b8485)OnInitialize()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.MapEvents.FieldBattleEventComponent.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a63743e7e9b72896ba8ef1a6b838b1c95).

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a0ea5e4ab76c654dbe90bc36639a4327a)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.MapEvents.FieldBattleEventComponent.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#af6cf498e95a584c027f19f965ccbe618).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#ad5ec296f4cb97857e213f0112423edf0)SimulationContext
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) TaleWorlds.CampaignSystem.MapEvents.FieldBattleEventComponent.SimulationContext | | get |

