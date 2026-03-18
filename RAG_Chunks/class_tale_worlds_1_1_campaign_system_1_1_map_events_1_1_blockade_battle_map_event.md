--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html ---

TaleWorlds.CampaignSystem.MapEvents.BlockadeBattleMapEvent Class ReferenceInherits [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html).

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [BlockadeBattleMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#a11b568de38ff619a454650128ab6c42f) | [CreateBlockadeBattleMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#aa8347a5d801e91aa60ce0ad45488eea8) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) besiegerParty, bool isSallyOut) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [BlockadeBattleMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#a11b568de38ff619a454650128ab6c42f) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |
| override void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#aa938f156d382fe3b5d2b1ed7b04b5718) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#a3c641f2ef0c121b2020a5a65fd6901c5) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | |
|  | [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a04ce5f7286860bb13e8c09cc416417b4) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |
| virtual void | [OnBeforeFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a608243f9d25a7913e54337f72a98b70a) () |

|  |  |
| --- | --- |
| Properties | |
| override [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#ae149ae19289eaa5ec83e1fb2e8526a8d) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | |
| MapEvent | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) `[get]` |
| [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a5a894e37fd33ff302ddf2e575804d98c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#a11b568de38ff619a454650128ab6c42f)BlockadeBattleMapEvent()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.MapEvents.BlockadeBattleMapEvent.BlockadeBattleMapEvent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) | *mapEvent* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#aa8347a5d801e91aa60ce0ad45488eea8)CreateBlockadeBattleMapEvent()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [BlockadeBattleMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#a11b568de38ff619a454650128ab6c42f) TaleWorlds.CampaignSystem.MapEvents.BlockadeBattleMapEvent.CreateBlockadeBattleMapEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *besiegerParty*, | |  |  | bool | *isSallyOut* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#aa938f156d382fe3b5d2b1ed7b04b5718)OnInitialize()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.MapEvents.BlockadeBattleMapEvent.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a63743e7e9b72896ba8ef1a6b838b1c95).

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#a3c641f2ef0c121b2020a5a65fd6901c5)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.MapEvents.BlockadeBattleMapEvent.OnFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#af6cf498e95a584c027f19f965ccbe618).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_blockade_battle_map_event.html#ae149ae19289eaa5ec83e1fb2e8526a8d)SimulationContext
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) TaleWorlds.CampaignSystem.MapEvents.BlockadeBattleMapEvent.SimulationContext | | get |

