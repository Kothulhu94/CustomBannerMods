--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html ---

TaleWorlds.CampaignSystem.Siege.BesiegerCamp Class ReferenceInherits [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [GetInvolvedPartiesForEventType](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a8d0d9e7a1fdcb4af5c70829a3f44f6e3) (MapEvent.BattleTypes mapEventType=MapEvent.BattleTypes.Siege) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetNextInvolvedPartyForEventType](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a6a5836c5ca2bcb57b5aeb88a575edbcf) (ref int partyIndex, MapEvent.BattleTypes mapEventType=MapEvent.BattleTypes.Siege) |
| bool | [HasInvolvedPartyForEventType](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a833ff1b653f3dd2270f746ea42eeb7d3) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, MapEvent.BattleTypes mapEventType=MapEvent.BattleTypes.Siege) |
|  | [BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a82a01fb41b06a5ae927a45b01bd93dc8) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ad099af0df5039ad371c88b41b4b7bd5e) siegeEvent, [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) besiegerFaction) |
| bool | [IsBesiegerSideParty](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a7bb17a91ec15d81cdaf59bbc6b9ed3e9) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [InitializeSiegeEventSide](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a526478157f8c7bdfeda3b0c62a4c1874) () |
| void | [OnTroopsKilledOnSide](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a89d5dfd128c1baa61ad72e1c3508aba2) (int killCount) |
| void | [SetSiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a45f91197456d9fed2bcd1f7b0f62c638) ([SiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a5ab750a791f2f6767b1603cddbda7ad0) strategy) |
| void | [RemoveAllSiegeParties](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ac3ce3d85c906bbb29c1239c52b634de3) () |
| void | [AddSiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a4878b3b79376b9bf91636c9ad2ad01a7) ([SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) missile) |
| void | [RemoveDeprecatedMissiles](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a79df7b5ba76f2c0362acefe6ef3b28ed) () |
| void | [BombardHitWalls](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a71e923ebb96201ff5697c020b9f66065) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) attackerEngineType, int wallIndex) |
| void | [GetAttackTarget](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ad961370480e954c7341ae1ae92044c22) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, int siegeEngineSlot, out [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) targetType, out int targetIndex) |
| void | [FinalizeSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a4409f1749f7baa21c97a1f167676dfc4) () |
| void | [OnAfterLoad](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ac832ef3c4150505fb0e1aa330b2beb5d) () |
| void | [SetPositionAfterMapChange](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#af5b539d12f292bdd3700babe84b6abfd) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) newPosition) |

|  |  |
| --- | --- |
| Properties | |
| SiegeEvent | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ad099af0df5039ad371c88b41b4b7bd5e) `[get]` |
| [SiegeEvent.SiegeEnginesContainer](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html) | [SiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#afe0b8ae4669d3caf7421904170d24722) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [LeaderParty](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a85647e120ee5146bba6672cbf60a3443) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a23bf1f741422988e126bb6a954e12852) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [BattleSide](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a2a1ef4ccce9c18013ff0cdb79e7d12a7) `[get]` |
| MBReadOnlyList< [SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) > | [SiegeEngineMissiles](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a9a3c936af414575ce5cc54ec8558f6cb) `[get]` |
| SiegeStrategy | [SiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a5ab750a791f2f6767b1603cddbda7ad0) `[get]` |
| int | [NumberOfTroopsKilledOnSide](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a724eaea1ef4288184c1627c8c8d19732) `[get]` |
| bool | [IsPreparationComplete](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a09a1b67ae1ba3cbd2b35f523fbe8858a) `[get]` |
| bool | [IsReadyToBesiege](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a3d8aa8be1f86652bfb96e4438c1d431d) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a82a01fb41b06a5ae927a45b01bd93dc8)BesiegerCamp()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Siege.BesiegerCamp.BesiegerCamp | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ad099af0df5039ad371c88b41b4b7bd5e) | *siegeEvent*, |
|  |  | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *besiegerFaction* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a8d0d9e7a1fdcb4af5c70829a3f44f6e3)GetInvolvedPartiesForEventType()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > TaleWorlds.CampaignSystem.Siege.BesiegerCamp.GetInvolvedPartiesForEventType | ( | MapEvent.BattleTypes | *mapEventType* = MapEvent::BattleTypes::Siege | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a5d012939b5a82072426a2edf10a63fad).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a6a5836c5ca2bcb57b5aeb88a575edbcf)GetNextInvolvedPartyForEventType()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Siege.BesiegerCamp.GetNextInvolvedPartyForEventType | ( | ref int | *partyIndex*, |
|  |  | MapEvent.BattleTypes | *mapEventType* = MapEvent::BattleTypes::Siege ) |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a17d253f15e744eda68027a2cc4217234).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a833ff1b653f3dd2270f746ea42eeb7d3)HasInvolvedPartyForEventType()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Siege.BesiegerCamp.HasInvolvedPartyForEventType | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | MapEvent.BattleTypes | *mapEventType* = MapEvent::BattleTypes::Siege ) |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a9f91f1f246a99356126ba0acb70e33d6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a7bb17a91ec15d81cdaf59bbc6b9ed3e9)IsBesiegerSideParty()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Siege.BesiegerCamp.IsBesiegerSideParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a526478157f8c7bdfeda3b0c62a4c1874)InitializeSiegeEventSide()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.InitializeSiegeEventSide | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a07e0c5f04b13d9d1bc72772c775a2615).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a89d5dfd128c1baa61ad72e1c3508aba2)OnTroopsKilledOnSide()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.OnTroopsKilledOnSide | ( | int | *killCount* | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a9c879051003bd28dc76bfb5ff674899c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a45f91197456d9fed2bcd1f7b0f62c638)SetSiegeStrategy()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.SetSiegeStrategy | ( | [SiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a5ab750a791f2f6767b1603cddbda7ad0) | *strategy* | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#acdb1b4b9016470e9092ce421d9157817).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ac3ce3d85c906bbb29c1239c52b634de3)RemoveAllSiegeParties()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.RemoveAllSiegeParties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a4878b3b79376b9bf91636c9ad2ad01a7)AddSiegeEngineMissile()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.AddSiegeEngineMissile | ( | [SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) | *missile* | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a340a94abda07183b528f0049a1ca2489).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a79df7b5ba76f2c0362acefe6ef3b28ed)RemoveDeprecatedMissiles()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.RemoveDeprecatedMissiles | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a2d6407510a9af52b4e4a6540843b6083).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a71e923ebb96201ff5697c020b9f66065)BombardHitWalls()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.BombardHitWalls | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *attackerEngineType*, |
|  |  | int | *wallIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ad961370480e954c7341ae1ae92044c22)GetAttackTarget()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.GetAttackTarget | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, |
|  |  | int | *siegeEngineSlot*, |
|  |  | out [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *targetType*, |
|  |  | out int | *targetIndex* ) |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a7349aa664e0af23743a57feba79d278e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a4409f1749f7baa21c97a1f167676dfc4)FinalizeSiegeEvent()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.FinalizeSiegeEvent | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a3cc987a5db12fa1c39781d4e70a769f6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ac832ef3c4150505fb0e1aa330b2beb5d)OnAfterLoad()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.OnAfterLoad | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#af5b539d12f292bdd3700babe84b6abfd)SetPositionAfterMapChange()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.BesiegerCamp.SetPositionAfterMapChange | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *newPosition* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#ad099af0df5039ad371c88b41b4b7bd5e)SiegeEvent
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SiegeEvent TaleWorlds.CampaignSystem.Siege.BesiegerCamp.SiegeEvent | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#aad0ea0e43337b3924044b1401ae47158).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#afe0b8ae4669d3caf7421904170d24722)SiegeEngines
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeEvent.SiegeEnginesContainer](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html) TaleWorlds.CampaignSystem.Siege.BesiegerCamp.SiegeEngines | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#ab5780cdfb31550931179932b18a2d0c8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a85647e120ee5146bba6672cbf60a3443)LeaderParty
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.Siege.BesiegerCamp.LeaderParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a23bf1f741422988e126bb6a954e12852)MapFaction
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Siege.BesiegerCamp.MapFaction | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a2a1ef4ccce9c18013ff0cdb79e7d12a7)BattleSide
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.Siege.BesiegerCamp.BattleSide | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#aaf88767d86d2aa9c2a0aeed587fcc4c8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a9a3c936af414575ce5cc54ec8558f6cb)SiegeEngineMissiles
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html)> TaleWorlds.CampaignSystem.Siege.BesiegerCamp.SiegeEngineMissiles | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a5b161bd7909124344676c452d8c64f7b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a5ab750a791f2f6767b1603cddbda7ad0)SiegeStrategy
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SiegeStrategy TaleWorlds.CampaignSystem.Siege.BesiegerCamp.SiegeStrategy | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a59f6dff6d8f976cedfdb9e9941397e0c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a724eaea1ef4288184c1627c8c8d19732)NumberOfTroopsKilledOnSide
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Siege.BesiegerCamp.NumberOfTroopsKilledOnSide | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#ad71a13fe75819f069dc4f07c4f9954e7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a09a1b67ae1ba3cbd2b35f523fbe8858a)IsPreparationComplete
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Siege.BesiegerCamp.IsPreparationComplete | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html#a3d8aa8be1f86652bfb96e4438c1d431d)IsReadyToBesiege
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Siege.BesiegerCamp.IsReadyToBesiege | | get |

