--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html ---

TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent Class ReferenceInherits [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html).

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#ab4b24788990f3573cc2fbb5baa000295) | [CreateRaidEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a7d47dc591ef64e5f0e212e41a8edbde0) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty) |
| static [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#ab4b24788990f3573cc2fbb5baa000295) | [CreateComponentForOldSaves](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#abf22db1a086f4beb6f9ed4ab90a26182) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent, float nextSettlementDamage, int lootedItemCount, float raidDamage) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#ab4b24788990f3573cc2fbb5baa000295) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |
| override void | [OnInitialize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a85bd5201d3f2891b261b8380812b444f) () |
| override void | [OnBeforeFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#acd3a6adcce6dd780b9579c2904e9e932) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | |
|  | [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a04ce5f7286860bb13e8c09cc416417b4) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) mapEvent) |
| virtual void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#af6cf498e95a584c027f19f965ccbe618) () |

|  |  |
| --- | --- |
| Properties | |
| float | [RaidDamage](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a15931592dae00ed01f6ffc826ee7a38a) `[get]` |
| [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | [DefenderSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a7c4b858c4f252efcc0aaabeb73ac867b) `[get]` |
| [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | [AttackerSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a22470d020a8d2f86179d4814da48b4aa) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [MapEventSettlement](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#aa25062fabf89df84a917a51af1c4bf0b) `[get]` |
| bool | [IsPlayerMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a812e365e19634af04bd73deb79afa69a) `[get]` |
| [BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) | [BattleState](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a4f60a64cd8636318ac2d7283ac0ca26a) `[get]` |
| override [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#ab8ff05b2926e0da5006da4a309d50059) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | |
| MapEvent | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) `[get]` |
| [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) | [SimulationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a5a894e37fd33ff302ddf2e575804d98c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#ab4b24788990f3573cc2fbb5baa000295)RaidEventComponent()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.RaidEventComponent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) | *mapEvent* | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a7d47dc591ef64e5f0e212e41a8edbde0)CreateRaidEvent()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#ab4b24788990f3573cc2fbb5baa000295) TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.CreateRaidEvent | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#abf22db1a086f4beb6f9ed4ab90a26182)CreateComponentForOldSaves()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [RaidEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#ab4b24788990f3573cc2fbb5baa000295) TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.CreateComponentForOldSaves | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a66f95a31acbd5743df560c5fd36c90dc) | *mapEvent*, | |  |  | float | *nextSettlementDamage*, | |  |  | int | *lootedItemCount*, | |  |  | float | *raidDamage* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a85bd5201d3f2891b261b8380812b444f)OnInitialize()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.OnInitialize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a63743e7e9b72896ba8ef1a6b838b1c95).

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#acd3a6adcce6dd780b9579c2904e9e932)OnBeforeFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.OnBeforeFinalize | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.MapEvents.MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html#a608243f9d25a7913e54337f72a98b70a).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a15931592dae00ed01f6ffc826ee7a38a)RaidDamage
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.RaidDamage | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a7c4b858c4f252efcc0aaabeb73ac867b)DefenderSide
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.DefenderSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a22470d020a8d2f86179d4814da48b4aa)AttackerSide
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.AttackerSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#aa25062fabf89df84a917a51af1c4bf0b)MapEventSettlement
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.MapEventSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a812e365e19634af04bd73deb79afa69a)IsPlayerMapEvent
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.IsPlayerMapEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#a4f60a64cd8636318ac2d7283ac0ca26a)BattleState
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.BattleState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_raid_event_component.html#ab8ff05b2926e0da5006da4a309d50059)SimulationContext
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override [MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) TaleWorlds.CampaignSystem.MapEvents.RaidEventComponent.SimulationContext | | get |

