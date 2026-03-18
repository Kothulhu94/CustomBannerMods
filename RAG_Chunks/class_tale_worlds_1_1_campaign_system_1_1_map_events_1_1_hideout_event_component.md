--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html ---

TaleWorlds.CampaignSystem.MapEvents.HideoutEventComponent Class ReferenceInherits [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html).

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#ae185363260f4c32540814afd8d682e0e) | [CreateHideoutEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#a337b5da3d8a5fd11b3b87114ccd59e7e) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty, bool isSendTroops) |
| static [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#ae185363260f4c32540814afd8d682e0e) | [CreateComponentForOldSaves](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#ab4b581bcc2fa6983074e27414512b1f0) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent, bool isSendTroops) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly bool | [IsSendTroops](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#aaf0f0bf8caa51010d2981e58338ddcce) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#ae185363260f4c32540814afd8d682e0e) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent, bool isSendTroops) |
| override void | [OnBeforeFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#a6b6df2c6e14382973d7005f30fa9fdb2) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | |
|  | [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a04ce5f7286860bb13e8c09cc416417b4) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |
| virtual void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a63743e7e9b72896ba8ef1a6b838b1c95) () |
| virtual void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#af6cf498e95a584c027f19f965ccbe618) () |

|  |  |
| --- | --- |
| Properties | |
| override [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#a453b30b855d52b74f84626df963c424f) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | |
| MapEvent | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) `[get]` |
| [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a5a894e37fd33ff302ddf2e575804d98c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#ae185363260f4c32540814afd8d682e0e)HideoutEventComponent()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.MapEvents.HideoutEventComponent.HideoutEventComponent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) | *mapEvent*, | |  |  | bool | *isSendTroops* ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#a337b5da3d8a5fd11b3b87114ccd59e7e)CreateHideoutEvent()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#ae185363260f4c32540814afd8d682e0e) TaleWorlds.CampaignSystem.MapEvents.HideoutEventComponent.CreateHideoutEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty*, | |  |  | bool | *isSendTroops* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#ab4b581bcc2fa6983074e27414512b1f0)CreateComponentForOldSaves()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [HideoutEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#ae185363260f4c32540814afd8d682e0e) TaleWorlds.CampaignSystem.MapEvents.HideoutEventComponent.CreateComponentForOldSaves | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) | *mapEvent*, | |  |  | bool | *isSendTroops* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#a6b6df2c6e14382973d7005f30fa9fdb2)OnBeforeFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.MapEvents.HideoutEventComponent.OnBeforeFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a608243f9d25a7913e54337f72a98b70a).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#aaf0f0bf8caa51010d2981e58338ddcce)IsSendTroops
----------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.CampaignSystem.MapEvents.HideoutEventComponent.IsSendTroops |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_hideout_event_component.html#a453b30b855d52b74f84626df963c424f)SimulationContext
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) TaleWorlds.CampaignSystem.MapEvents.HideoutEventComponent.SimulationContext | | get |

