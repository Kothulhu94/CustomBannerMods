--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html ---

TaleWorlds.CampaignSystem.MapEvents.MapEventParty Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Update](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a195583b1888bb3e17680febc0b3f016d) () |
| void | [OnTroopKilled](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ab7f763b3389cad448e9ad5575c552e94) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed) |
| void | [OnTroopWounded](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a6f7fbbb1c161148f3b26f91dc0b139e5) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed) |
| void | [OnTroopRouted](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a77ab265544613bce0c319bb75de8c9be) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed) |
| void | [OnShipSunk](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a9a2a853bff06cb81828b140a02719414) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| void | [OnShipDamaged](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a648a87a9d4343732d8739b94c91c9e49) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, int damage) |
| void | [OnShipScoreHit](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a715de70a2a7137ce72798e9ea1e3f5b5) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) struckShip, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, int damage, bool isFinishingStrike) |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetTroop](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a98c9d1dd86260f7d4de59023363da82e) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed) |
| [RosterTroopState](namespace_tale_worlds_1_1_campaign_system_1_1_roster.html#a36e8f9e538bd39b1bc74cc15ef0deae4) | [GetTroopState](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a8ea887560c1042027adc22aaf5840d6d) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopSeed) |
| void | [OnRoundEnd](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#afcf0a0cc570bf70f8c75370edd5c1858) ([MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) partySide, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) roundWinner) |
| void | [OnTroopScoreHit](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ac8ead7a8956d1eb365e4d0974b68675c) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) attackerTroopDesc, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackedTroop, int damage, bool isFatal, bool isTeamKill, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, bool isSimulatedHit) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a991ac5c37a8e0f0d4283aad0106469fe) () |

|  |  |
| --- | --- |
| Properties | |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Party](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ac993ce7bb3cda2b39d4a5bdfe6bb648a) `[get]` |
| float | [GainedRenown](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#aa0c53210af0addd9b5c4a30627aa556d) `[get, set]` |
| float | [GainedInfluence](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ad321cc0f64418df35cfb86400009a0fa) `[get, set]` |
| float | [MoraleChange](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a027ee4bfd4429507c77ea1c167b5f27a) `[get, set]` |
| int | [PlunderedGold](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#aa5fdd6ce53e783048c269f45aaaf125f) `[get, set]` |
| int | [GoldLost](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ab5c391e352a29f72943e6100d32be818) `[get, set]` |
| int | [HealthyManCountAtStart](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#af141399abd7c8866f2580ddf24cafbbe) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [DiedInBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ad750b8586364af3c808b63042ea9852d) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [WoundedInBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#afdd0eb89a7f118c733cfa78868b2b16c) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [RoutedInBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a89c8c1a82139ddea390ab1ab96cb696d) `[get]` |
| int | [ContributionToBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a8a96b7085d0b7c9d65b0523c3c1d6376) `[get]` |
| bool | [IsNpcParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ac27c1814e8fd8f026054e5c512ddfff2) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [RosterToReceiveLootMembers](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ae1fd05c880e08e407e211865f9b9e15c) `[get]` |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [RosterToReceiveLootPrisoners](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a460c6a6118e8b46bec874e648c2f8629) `[get]` |
| [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | [RosterToReceiveLootItems](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a4a876165adafb479eb2316d598e08053) `[get]` |
| [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | [Troops](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a62f5e226e6a5545bf2cd16a36fc9485c) `[get]` |
| MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [Ships](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a83b96917f6b1d58333cb0e8aaf2f131a) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a195583b1888bb3e17680febc0b3f016d)Update()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventParty.Update | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ab7f763b3389cad448e9ad5575c552e94)OnTroopKilled()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventParty.OnTroopKilled | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a6f7fbbb1c161148f3b26f91dc0b139e5)OnTroopWounded()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventParty.OnTroopWounded | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a77ab265544613bce0c319bb75de8c9be)OnTroopRouted()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventParty.OnTroopRouted | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a9a2a853bff06cb81828b140a02719414)OnShipSunk()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventParty.OnShipSunk | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a648a87a9d4343732d8739b94c91c9e49)OnShipDamaged()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventParty.OnShipDamaged | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, |
|  |  | int | *damage* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a715de70a2a7137ce72798e9ea1e3f5b5)OnShipScoreHit()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventParty.OnShipScoreHit | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *struckShip*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, |
|  |  | int | *damage*, |
|  |  | bool | *isFinishingStrike* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a98c9d1dd86260f7d4de59023363da82e)GetTroop()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.MapEvents.MapEventParty.GetTroop | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a8ea887560c1042027adc22aaf5840d6d)GetTroopState()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [RosterTroopState](namespace_tale_worlds_1_1_campaign_system_1_1_roster.html#a36e8f9e538bd39b1bc74cc15ef0deae4) TaleWorlds.CampaignSystem.MapEvents.MapEventParty.GetTroopState | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopSeed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#afcf0a0cc570bf70f8c75370edd5c1858)OnRoundEnd()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventParty.OnRoundEnd | ( | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | *partySide*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *roundWinner* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ac8ead7a8956d1eb365e4d0974b68675c)OnTroopScoreHit()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventParty.OnTroopScoreHit | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *attackerTroopDesc*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *attackedTroop*, |
|  |  | int | *damage*, |
|  |  | bool | *isFatal*, |
|  |  | bool | *isTeamKill*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | bool | *isSimulatedHit* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a991ac5c37a8e0f0d4283aad0106469fe)ToString()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.MapEvents.MapEventParty.ToString | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ac993ce7bb3cda2b39d4a5bdfe6bb648a)Party
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.MapEvents.MapEventParty.Party | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#aa0c53210af0addd9b5c4a30627aa556d)GainedRenown
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.MapEvents.MapEventParty.GainedRenown | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ad321cc0f64418df35cfb86400009a0fa)GainedInfluence
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.MapEvents.MapEventParty.GainedInfluence | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a027ee4bfd4429507c77ea1c167b5f27a)MoraleChange
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.MapEvents.MapEventParty.MoraleChange | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#aa5fdd6ce53e783048c269f45aaaf125f)PlunderedGold
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEventParty.PlunderedGold | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ab5c391e352a29f72943e6100d32be818)GoldLost
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEventParty.GoldLost | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#af141399abd7c8866f2580ddf24cafbbe)HealthyManCountAtStart
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEventParty.HealthyManCountAtStart | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ad750b8586364af3c808b63042ea9852d)DiedInBattle
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.MapEvents.MapEventParty.DiedInBattle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#afdd0eb89a7f118c733cfa78868b2b16c)WoundedInBattle
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.MapEvents.MapEventParty.WoundedInBattle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a89c8c1a82139ddea390ab1ab96cb696d)RoutedInBattle
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.MapEvents.MapEventParty.RoutedInBattle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a8a96b7085d0b7c9d65b0523c3c1d6376)ContributionToBattle
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEventParty.ContributionToBattle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ac27c1814e8fd8f026054e5c512ddfff2)IsNpcParty
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEventParty.IsNpcParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#ae1fd05c880e08e407e211865f9b9e15c)RosterToReceiveLootMembers
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.MapEvents.MapEventParty.RosterToReceiveLootMembers | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a460c6a6118e8b46bec874e648c2f8629)RosterToReceiveLootPrisoners
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.MapEvents.MapEventParty.RosterToReceiveLootPrisoners | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a4a876165adafb479eb2316d598e08053)RosterToReceiveLootItems
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) TaleWorlds.CampaignSystem.MapEvents.MapEventParty.RosterToReceiveLootItems | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a62f5e226e6a5545bf2cd16a36fc9485c)Troops
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) TaleWorlds.CampaignSystem.MapEvents.MapEventParty.Troops | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html#a83b96917f6b1d58333cb0e8aaf2f131a)Ships
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html)> TaleWorlds.CampaignSystem.MapEvents.MapEventParty.Ships | | get |

