--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html ---

TaleWorlds.CampaignSystem.Siege.SiegeEvent Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) |
| class | [RangedSiegeEngine](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_ranged_siege_engine.html) |
| class | [SiegeEnginesContainer](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html) |
| class | [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [ActivateBlockade](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#aeec16473bdcc63dde4f810d015613ce1) () |
| void | [DeactivateBlockade](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ab1df21c5c0a8233ad08b11c26928e2fe) () |
| List< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [GetInvolvedPartiesForEventType](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ab418a9a74abdf5cf01fc369bea0d627b) (MapEvent.BattleTypes battleType) |
| MapEvent.BattleTypes | [GetCurrentBattleType](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a4d59f3ffac9d1b97f6e69cdae5c93e59) () |
|  | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a720bf52bf173c646e724fce033925507) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) besiegerParty) |
| [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | [GetSiegeEventSide](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a4f9bce3bfb722b9c691b9fde8549a98e) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| bool | [CanPartyJoinSide](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a61a7900d03b5e8d26c0e139c453adf99) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [Tick](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#abc1f1d4f2d1ef4ebdf4101d2ccae2799) (float dt) |
| void | [OnAfterLoad](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#aa0c5ec7688fd0c67100bff8382ae1ec7) () |
| void | [OnBeforeSiegeEventEnd](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ad1e95fac0c022c7a3ad18b37edc21f56) ([BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) winnerSide, MapEvent.BattleTypes battleType) |
| void | [FinalizeSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ad2ae7cb4fb803655c5e7963789e2c463) () |
| bool | [IsPartyInvolved](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a30123e156302d3291cbda7efd237ae5a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| void | [SetPositionAfterMapChange](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ac505d35a7391432cc7364d91ff7d9e8a) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) newPosition) |
| void | [DoSiegeAction](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a84f531f88accb173a86704ea9cb823a2) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide, [SiegeStrategyActionModel.SiegeAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3ed) siegeAction, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, int deploymentIndex, int reserveIndex) |
| void | [AdvanceStrategy](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a15a16c2967dfbc290ca2782d71b71b45) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide) |
| void | [BreakSiegeEngine](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#acb94801c38f9f9fdcd77a14f36019a56) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType) |
| Dictionary< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html), int > | [GetPreparedSiegeEnginesAsDictionary](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ac85435f1bccea244d6c21f72bd8329ef) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide) |
| List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > | [GetPreparedAndActiveSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#aacd21932cd44a79200936a722fcc2102) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide) |
| void | [SetSiegeEngineStatesAfterSiegeMission](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ac7cf121e9e2f332f80cbd20a540c7e23) (IEnumerable< [IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html) > attackerMissionSiegeEngineData, IEnumerable< [IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html) > defenderMissionSiegeEngineData) |
| void | [CreateSiegeObject](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a1f7021f4ffe79ce38bfaf6a4f16d4ca0) ([SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) siegeEngineConstructionProgress, [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeSide) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#adcc0abf62bbe8d58b7f61e569d9c5e53) () |
| void | [ConstructionTick](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a1a7a7f4f77a66fa3335f290fac01d300) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide) |
| void | [BombardTick](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a4d1924bc744c5b1e8d3a3c976a669bb5) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide) |
| void | [FindAttackableRangedEngineWithHighestPriority](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a64855456cb1b3a936d36bb50cbe37a45) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide, int attackerSlotIndex, out int targetIndex, out float targetPriority) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [BesiegedSettlement](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a896e15f8a9526fc4e22e90b18c8bc51f) |
| readonly BesiegerCamp | [BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a451642e6468046239f13a411978338e8) |

|  |  |
| --- | --- |
| Properties | |
| int | [SiegeWallSeed](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#acd9a01543d05cc0dd064a850bca9dc45) `[get]` |
| int | [SiegePeopleSeed](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a54a5b1f13a0ee2d4cec1493a31af0c4f) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [SiegeStartTime](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a37b8af926dc91ca7386dc0e17fbd3f01) `[get]` |
| bool | [IsPlayerSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ad7c07c6e3545c4d60967e25fd266f28d) `[get]` |
| bool | [BlockadeShouldBeActivated](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#acd39c93cc39e10ef7f6193d28a4d44d8) `[get]` |
| bool | [IsBlockadeActive](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ac2c363c057e8bcad6195da666c37f53c) `[get]` |
| bool | [ReadyToBeRemoved](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ae6d36490668e6978c63419a9ffa94cdd) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a720bf52bf173c646e724fce033925507)SiegeEvent()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeEvent | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *besiegerParty* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#aeec16473bdcc63dde4f810d015613ce1)ActivateBlockade()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.ActivateBlockade | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ab1df21c5c0a8233ad08b11c26928e2fe)DeactivateBlockade()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.DeactivateBlockade | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ab418a9a74abdf5cf01fc369bea0d627b)GetInvolvedPartiesForEventType()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > TaleWorlds.CampaignSystem.Siege.SiegeEvent.GetInvolvedPartiesForEventType | ( | MapEvent.BattleTypes | *battleType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a4d59f3ffac9d1b97f6e69cdae5c93e59)GetCurrentBattleType()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MapEvent.BattleTypes TaleWorlds.CampaignSystem.Siege.SiegeEvent.GetCurrentBattleType | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a4f9bce3bfb722b9c691b9fde8549a98e)GetSiegeEventSide()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) TaleWorlds.CampaignSystem.Siege.SiegeEvent.GetSiegeEventSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a61a7900d03b5e8d26c0e139c453adf99)CanPartyJoinSide()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Siege.SiegeEvent.CanPartyJoinSide | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#abc1f1d4f2d1ef4ebdf4101d2ccae2799)Tick()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#aa0c5ec7688fd0c67100bff8382ae1ec7)OnAfterLoad()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.OnAfterLoad | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ad1e95fac0c022c7a3ad18b37edc21f56)OnBeforeSiegeEventEnd()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.OnBeforeSiegeEventEnd | ( | [BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) | *winnerSide*, |
|  |  | MapEvent.BattleTypes | *battleType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ad2ae7cb4fb803655c5e7963789e2c463)FinalizeSiegeEvent()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.FinalizeSiegeEvent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a30123e156302d3291cbda7efd237ae5a)IsPartyInvolved()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Siege.SiegeEvent.IsPartyInvolved | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ac505d35a7391432cc7364d91ff7d9e8a)SetPositionAfterMapChange()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.SetPositionAfterMapChange | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *newPosition* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a84f531f88accb173a86704ea9cb823a2)DoSiegeAction()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.DoSiegeAction | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide*, |
|  |  | [SiegeStrategyActionModel.SiegeAction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_strategy_action_model.html#ada904f2e038ca0b8718960f10f18c3ed) | *siegeAction*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, |
|  |  | int | *deploymentIndex*, |
|  |  | int | *reserveIndex* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a15a16c2967dfbc290ca2782d71b71b45)AdvanceStrategy()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.AdvanceStrategy | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#acb94801c38f9f9fdcd77a14f36019a56)BreakSiegeEngine()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.BreakSiegeEngine | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ac85435f1bccea244d6c21f72bd8329ef)GetPreparedSiegeEnginesAsDictionary()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| Dictionary< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html), int > TaleWorlds.CampaignSystem.Siege.SiegeEvent.GetPreparedSiegeEnginesAsDictionary | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#aacd21932cd44a79200936a722fcc2102)GetPreparedAndActiveSiegeEngines()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [MissionSiegeWeapon](class_tale_worlds_1_1_core_1_1_mission_siege_weapon.html) > TaleWorlds.CampaignSystem.Siege.SiegeEvent.GetPreparedAndActiveSiegeEngines | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ac7cf121e9e2f332f80cbd20a540c7e23)SetSiegeEngineStatesAfterSiegeMission()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.SetSiegeEngineStatesAfterSiegeMission | ( | IEnumerable< [IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html) > | *attackerMissionSiegeEngineData*, |
|  |  | IEnumerable< [IMissionSiegeWeapon](interface_tale_worlds_1_1_core_1_1_i_mission_siege_weapon.html) > | *defenderMissionSiegeEngineData* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a1f7021f4ffe79ce38bfaf6a4f16d4ca0)CreateSiegeObject()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.CreateSiegeObject | ( | [SiegeEngineConstructionProgress](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_construction_progress.html) | *siegeEngineConstructionProgress*, |
|  |  | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeSide* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#adcc0abf62bbe8d58b7f61e569d9c5e53)ToString()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Siege.SiegeEvent.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a1a7a7f4f77a66fa3335f290fac01d300)ConstructionTick()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.ConstructionTick | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a4d1924bc744c5b1e8d3a3c976a669bb5)BombardTick()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.BombardTick | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a64855456cb1b3a936d36bb50cbe37a45)FindAttackableRangedEngineWithHighestPriority()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Siege.SiegeEvent.FindAttackableRangedEngineWithHighestPriority | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide*, |
|  |  | int | *attackerSlotIndex*, |
|  |  | out int | *targetIndex*, |
|  |  | out float | *targetPriority* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a896e15f8a9526fc4e22e90b18c8bc51f)BesiegedSettlement
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Siege.SiegeEvent.BesiegedSettlement |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a451642e6468046239f13a411978338e8)BesiegerCamp
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly BesiegerCamp TaleWorlds.CampaignSystem.Siege.SiegeEvent.BesiegerCamp |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#acd9a01543d05cc0dd064a850bca9dc45)SiegeWallSeed
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeWallSeed | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a54a5b1f13a0ee2d4cec1493a31af0c4f)SiegePeopleSeed
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegePeopleSeed | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#a37b8af926dc91ca7386dc0e17fbd3f01)SiegeStartTime
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Siege.SiegeEvent.SiegeStartTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ad7c07c6e3545c4d60967e25fd266f28d)IsPlayerSiegeEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Siege.SiegeEvent.IsPlayerSiegeEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#acd39c93cc39e10ef7f6193d28a4d44d8)BlockadeShouldBeActivated
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Siege.SiegeEvent.BlockadeShouldBeActivated | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ac2c363c057e8bcad6195da666c37f53c)IsBlockadeActive
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Siege.SiegeEvent.IsBlockadeActive | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html#ae6d36490668e6978c63419a9ffa94cdd)ReadyToBeRemoved
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Siege.SiegeEvent.ReadyToBeRemoved | | get |

