--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html ---

TaleWorlds.CampaignSystem.MapEvents.MapEventComponent Class ReferenceabstractInherited by [TaleWorlds.CampaignSystem.MapEvents.BlockadeBattleMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html), [TaleWorlds.CampaignSystem.MapEvents.FieldBattleEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html), [TaleWorlds.CampaignSystem.MapEvents.ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html), [TaleWorlds.CampaignSystem.MapEvents.ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html), [TaleWorlds.CampaignSystem.MapEvents.HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html), [TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html), and [TaleWorlds.CampaignSystem.MapEvents.SiegeAmbushEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html).

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a04ce5f7286860bb13e8c09cc416417b4) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |
| virtual void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a63743e7e9b72896ba8ef1a6b838b1c95) () |
| virtual void | [OnBeforeFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a608243f9d25a7913e54337f72a98b70a) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#af6cf498e95a584c027f19f965ccbe618) () |

|  |  |
| --- | --- |
| Properties | |
| MapEvent | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) `[get]` |
| [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a5a894e37fd33ff302ddf2e575804d98c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a04ce5f7286860bb13e8c09cc416417b4)MapEventComponent()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.MapEvents.MapEventComponent.MapEventComponent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) | *mapEvent* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a63743e7e9b72896ba8ef1a6b838b1c95)OnInitialize()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.MapEvents.MapEventComponent.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.MapEvents.BlockadeBattleMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#aa938f156d382fe3b5d2b1ed7b04b5718), [TaleWorlds.CampaignSystem.MapEvents.FieldBattleEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a52fb86ad6c492b5b2de55b7adf9b8485), [TaleWorlds.CampaignSystem.MapEvents.ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html#aace03be5e71ddded6cac3adce90ffdbe), [TaleWorlds.CampaignSystem.MapEvents.ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html#a66e43560bb3b221d764ace535bf8c667), and [TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a85bd5201d3f2891b261b8380812b444f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a608243f9d25a7913e54337f72a98b70a)OnBeforeFinalize()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.MapEvents.MapEventComponent.OnBeforeFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.MapEvents.ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html#ad9f0b7ff9e371e2bb97b75c532e6e187), [TaleWorlds.CampaignSystem.MapEvents.ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html#ae0e81cb17926eeec8b4dd47747af7272), [TaleWorlds.CampaignSystem.MapEvents.HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#a6b6df2c6e14382973d7005f30fa9fdb2), and [TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#acd3a6adcce6dd780b9579c2904e9e932).

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#af6cf498e95a584c027f19f965ccbe618)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.MapEvents.MapEventComponent.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.MapEvents.BlockadeBattleMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#a3c641f2ef0c121b2020a5a65fd6901c5), [TaleWorlds.CampaignSystem.MapEvents.FieldBattleEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_field_battle_event_component.html#a0ea5e4ab76c654dbe90bc36639a4327a), [TaleWorlds.CampaignSystem.MapEvents.ForceSuppliesEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_supplies_event_component.html#af2e734b2dc569a62dcfdd58599cbf0a9), [TaleWorlds.CampaignSystem.MapEvents.ForceVolunteersEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_force_volunteers_event_component.html#a57aac72686cd1ac0ebc4b1dd5e54c28d), and [TaleWorlds.CampaignSystem.MapEvents.SiegeAmbushEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_siege_ambush_event_component.html#a50bf9eccc317806818ad177d49288a32).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc)MapEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapEvent TaleWorlds.CampaignSystem.MapEvents.MapEventComponent.MapEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a5a894e37fd33ff302ddf2e575804d98c)SimulationContext
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) TaleWorlds.CampaignSystem.MapEvents.MapEventComponent.SimulationContext | | getabstract |

