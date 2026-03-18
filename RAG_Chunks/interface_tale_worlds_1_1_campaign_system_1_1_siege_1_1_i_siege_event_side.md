--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html ---

TaleWorlds.CampaignSystem.Siege.ISiegeEventSide Interface ReferenceInherited by [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [GetInvolvedPartiesForEventType](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a5d012939b5a82072426a2edf10a63fad) (MapEvent.BattleTypes mapEventType=MapEvent.BattleTypes.Siege) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetNextInvolvedPartyForEventType](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a17d253f15e744eda68027a2cc4217234) (ref int partyIndex, MapEvent.BattleTypes mapEventType=MapEvent.BattleTypes.Siege) |
| bool | [HasInvolvedPartyForEventType](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a9f91f1f246a99356126ba0acb70e33d6) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, MapEvent.BattleTypes mapEventType=MapEvent.BattleTypes.Siege) |
| void | [OnTroopsKilledOnSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a9c879051003bd28dc76bfb5ff674899c) (int killCount) |
| void | [AddSiegeEngineMissile](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a340a94abda07183b528f0049a1ca2489) ([SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) missile) |
| void | [RemoveDeprecatedMissiles](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a2d6407510a9af52b4e4a6540843b6083) () |
| void | [SetSiegeStrategy](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#acdb1b4b9016470e9092ce421d9157817) ([SiegeStrategy](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a59f6dff6d8f976cedfdb9e9941397e0c) strategy) |
| void | [InitializeSiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a07e0c5f04b13d9d1bc72772c775a2615) () |
| void | [GetAttackTarget](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a7349aa664e0af23743a57feba79d278e) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, int siegeEngineSlot, out [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) targetType, out int targetIndex) |
| void | [FinalizeSiegeEvent](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a3cc987a5db12fa1c39781d4e70a769f6) () |

|  |  |
| --- | --- |
| Properties | |
| SiegeEvent | [SiegeEvent](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#aad0ea0e43337b3924044b1401ae47158) `[get]` |
| SiegeStrategy | [SiegeStrategy](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a59f6dff6d8f976cedfdb9e9941397e0c) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [BattleSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#aaf88767d86d2aa9c2a0aeed587fcc4c8) `[get]` |
| int | [NumberOfTroopsKilledOnSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#ad71a13fe75819f069dc4f07c4f9954e7) `[get]` |
| [SiegeEvent.SiegeEnginesContainer](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html) | [SiegeEngines](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#ab5780cdfb31550931179932b18a2d0c8) `[get]` |
| MBReadOnlyList< [SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) > | [SiegeEngineMissiles](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a5b161bd7909124344676c452d8c64f7b) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a5d012939b5a82072426a2edf10a63fad)GetInvolvedPartiesForEventType()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.GetInvolvedPartiesForEventType | ( | MapEvent.BattleTypes | *mapEventType* = MapEvent.BattleTypes.Siege | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab7554a5d8df65165f70cbd1dd77130d4), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a8d0d9e7a1fdcb4af5c70829a3f44f6e3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a17d253f15e744eda68027a2cc4217234)GetNextInvolvedPartyForEventType()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.GetNextInvolvedPartyForEventType | ( | ref int | *partyIndex*, |
|  |  | MapEvent.BattleTypes | *mapEventType* = MapEvent.BattleTypes.Siege ) |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a4b1b2993ad607867fd9b2f82be666845), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a6a5836c5ca2bcb57b5aeb88a575edbcf).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a9f91f1f246a99356126ba0acb70e33d6)HasInvolvedPartyForEventType()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.HasInvolvedPartyForEventType | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | MapEvent.BattleTypes | *mapEventType* = MapEvent.BattleTypes.Siege ) |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab461a3eac71e331f4b868eb2eb7c3109), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a833ff1b653f3dd2270f746ea42eeb7d3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a9c879051003bd28dc76bfb5ff674899c)OnTroopsKilledOnSide()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.OnTroopsKilledOnSide | ( | int | *killCount* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a4c949ecd5164f5484a36f43ccbc39c5e), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a89d5dfd128c1baa61ad72e1c3508aba2).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a340a94abda07183b528f0049a1ca2489)AddSiegeEngineMissile()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.AddSiegeEngineMissile | ( | [SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) | *missile* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a4878b3b79376b9bf91636c9ad2ad01a7).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a2d6407510a9af52b4e4a6540843b6083)RemoveDeprecatedMissiles()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.RemoveDeprecatedMissiles | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a2c50f5355856e4fe26851cddc27c8a57), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a79df7b5ba76f2c0362acefe6ef3b28ed).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#acdb1b4b9016470e9092ce421d9157817)SetSiegeStrategy()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.SetSiegeStrategy | ( | [SiegeStrategy](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a59f6dff6d8f976cedfdb9e9941397e0c) | *strategy* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ada0fee116f6cae8fa7dda6d701e9367f), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a45f91197456d9fed2bcd1f7b0f62c638).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a07e0c5f04b13d9d1bc72772c775a2615)InitializeSiegeEventSide()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.InitializeSiegeEventSide | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#acf5aef15e900100a158cfc2bec85933b), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a526478157f8c7bdfeda3b0c62a4c1874).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a7349aa664e0af23743a57feba79d278e)GetAttackTarget()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.GetAttackTarget | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, |
|  |  | int | *siegeEngineSlot*, |
|  |  | out [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *targetType*, |
|  |  | out int | *targetIndex* ) |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a012a12daf94809d63cdcca09bd58819d), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ad961370480e954c7341ae1ae92044c22).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a3cc987a5db12fa1c39781d4e70a769f6)FinalizeSiegeEvent()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.FinalizeSiegeEvent | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a7926e5563e67b30e91c8421103b73145), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a4409f1749f7baa21c97a1f167676dfc4).

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#aad0ea0e43337b3924044b1401ae47158)SiegeEvent
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SiegeEvent TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.SiegeEvent | | get |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab241f30cec980e45dedd080a070af2bf), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ad099af0df5039ad371c88b41b4b7bd5e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a59f6dff6d8f976cedfdb9e9941397e0c)SiegeStrategy
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SiegeStrategy TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.SiegeStrategy | | get |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa6c252832f9944504fa4bd6261e299ac), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a5ab750a791f2f6767b1603cddbda7ad0).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#aaf88767d86d2aa9c2a0aeed587fcc4c8)BattleSide
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.BattleSide | | get |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aabc79369bf9353ea4f1e2d436957ea60), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a2a1ef4ccce9c18013ff0cdb79e7d12a7).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#ad71a13fe75819f069dc4f07c4f9954e7)NumberOfTroopsKilledOnSide
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.NumberOfTroopsKilledOnSide | | get |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad52c6f8745b5eccbe57affa0a5db4c0d), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a724eaea1ef4288184c1627c8c8d19732).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#ab5780cdfb31550931179932b18a2d0c8)SiegeEngines
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeEvent.SiegeEnginesContainer](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html) TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.SiegeEngines | | get |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab5b2d9d7972839e7fb1943bea1ee9694), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#afe0b8ae4669d3caf7421904170d24722).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a5b161bd7909124344676c452d8c64f7b)SiegeEngineMissiles
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html)> TaleWorlds.CampaignSystem.Siege.ISiegeEventSide.SiegeEngineMissiles | | get |

Implemented in [TaleWorlds.CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a062dc1cfb9f056193a7b61868ed75c21), and [TaleWorlds.CampaignSystem.Siege.BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a9a3c936af414575ce5cc54ec8558f6cb).

