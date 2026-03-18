--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html ---

TaleWorlds.CampaignSystem.MapEvents.MapEvent Class Referencesealed[MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html "MapEvent class. An instance of this class is created when a map event starts.") class. An instance of this class is created when a map event starts.

Inherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) {     [None](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851a6adf97f83acf6453d4a6a4b1070f3754) ,     [FieldBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851a91342baa157f7211d22515fb9e3e28c5) ,     [Raid](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851ac8a23798f7577fe951f173d3380bee0d) ,     [IsForcingVolunteers](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851a86646d549aa3cf373e1c070ecce37b1c) ,     [IsForcingSupplies](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851a51b014aeb80cf71157712217c6d27135) ,     [Siege](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851a7e86b036c23f9a7df08bff9baeaf98ad) ,     [Hideout](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851ac96b5dfdaf59e2be31cfb7dab11889d0) ,     [SallyOut](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851a3d6806e222f143afc07bd405190644b7) ,     [SiegeOutside](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851a06381517c9eb27b4ed5d502bf0c6374c) ,     [BlockadeBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851a8ac7c5590f7cea902de2fb8d5d1fa6ba) ,     [BlockadeSallyOutBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851acc3cb723a5eab9cf1bb74cd48fd7b4d1)   } |
| enum | [PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) {     [PlainBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fea4b303a148f7dfa3de942199787d0ba6b) ,     [SteppeBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fea4000f1405865d148385782493c40032b) ,     [DesertBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6feab99e65e0b1df0f9f381653c37d57e225) ,     [DuneBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fea28e5681fdfb7daef3454ac36f9fc78c1) ,     [SnowBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fea8eabdd49ec64765294de739b4736b2df) ,     [ForestBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fea9fc5db5f50fd09a6fd89d14d2da22344) ,     [RiverCrossingBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fea21ac76f05a16fc9e77aaf3e4f0ec5633) ,     [Village](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6feaabc63490c815af81276f930216c8d92b) ,     [Siege](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fea7e86b036c23f9a7df08bff9baeaf98ad) ,     [SeaBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fea52cec3be3f93d1bc626138d96724211f) ,     [OpenSeaBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6feab84788eb6a8c21b2b60f802551099b77) ,     [RiverBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fea9c6dec8eb4c195ded59dc56b2128b85a) ,     [Estimated](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fea3c311fbd0f9e51ce27b984f55164cf83)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [BeginWait](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a767ddc09b26b68ea442fe5c6ccded517) () |
| [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | [GetMapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aa61f9841783bbb80ee710dd53ccd99c8) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | [PartiesOnSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a1ed8964462012c3f576371ad73e39911) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [GetBattleRewards](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a4cb4469c63846ee9f6a8a32df987e197) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, out float renownChange, out float influenceChange, out float moraleChange, out float goldChange, out float playerEarnedLootPercentage) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a2d7debd59074d6a28325d2d8e99e283d) () |
| int | [GetNumberOfInvolvedMen](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aadb7a531832a28815ba5bfad620fe924) () |
| int | [GetNumberOfInvolvedMen](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#accf3f8004f6ad156e3a75ba98e2a6b00) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [FinishBattleAndKeepSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a77c6e573dde3e87e848bb89e5cf3850c) () |
| void | [SimulateBattleSetup](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ad34a661017f1ce8466458774cf3e50ad) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html)[] priorTroops) |
| void | [SimulateBattleRound](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a99bc587532d2356dc42caf709e97aa04) (int simulationTicksDefender, int simulationTicksAttacker) |
| void | [SetOverrideWinner](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#adbe561cc813c55f04ce874fb44bf8865) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) winner) |
| void | [SetDefenderPulledBack](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a29242982128f1fe73f2d0b6b251750a7) () |
| void | [ResetBattleState](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a26dc33a802eb9bf6196fde1f29d507bc) () |
| bool | [IsPlayerSergeant](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a275c98e2c1426a235e9a815a2a1d275c) () |
| void | [FinalizeEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a6cc0c8205dfe45dd60468f7d15f76c5b) () |
| bool | [HasTroopsOnBothSides](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aca2649a4efb0d3d4921fd4ae22fdac50) () |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetLeaderParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aaa299b3c492f87998abc2ef3fecab866) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| float | [GetRenownValue](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a5e7ef12da477d6854c8f01093500d65f) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [RecalculateRenownAndInfluenceValues](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aea5ab73083548c9501216a5b37e88f1a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| void | [RecalculateStrengthOfSides](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a66985c254c5216c11d68ed599fe857ac) () |
| void | [DoSurrender](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a917b1bea8931b1d5b5c732f107adab82) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [EndByRunAway](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ae54c4c2e1cf5c8314d8bbaa48f4d5ac0) () |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [GetOtherSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aef9bf060d819a1d97731cb760af20475) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| bool | [CanPartyJoinBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ac2fc9a267650a821d1c9fe0280075e7e) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| void | [GetStrengthsRelativeToParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a45fd70c0afc7c44a194d91750408e956) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) partySide, out float partySideStrength, out float opposingSideStrength) |
| bool | [CheckIfBattleShouldContinueAfterBattleMission](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aaa4953a382df4311fc22011386d1e27f) ([CampaignBattleResult](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_campaign_battle_result.html) campaignBattleResult) |
| void | [SetPositionAfterMapChange](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a0dc424fb98bbbd1100561d9b800619ed) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) newPosition) |
| void | [CheckPositionsForMapChangeAndUpdateIfNeeded](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ac66a952ac972f1ab6a96d916642d60d1) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| virtual void | [Deserialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [DiplomaticallyFinished](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a4dad71a138e2cbc04f5b09877e0c35c4) |
| [IMapEventVisual](interface_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_i_map_event_visual.html) | [MapEventVisual](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ad0fc23eaff03d13b687e9c6c2f31127d) |
| float[] | [StrengthOfSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a22bac4b638228e62260a38c926acc4db) = new float[(int)BattleSideEnum.NumSides] |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [SiegeAdvantage](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a5e46a0515df82145dfbf2cac8b43a0bf) = 1.5f |

|  |  |
| --- | --- |
| Properties | |
| TroopUpgradeTracker | [TroopUpgradeTracker](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a021e11810ca809846568d3b26e20ac6d) = new TroopUpgradeTracker() `[get]` |
| static MapEvent | [PlayerMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a3ad47c3821c19da9517c20863b38fd09) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [PlayerSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#afce18f41ec9d4bf54bc9f7a074ab7344) `[get]` |
| [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | [Component](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ab5fbba6ca33293e99f2bd2d42fd16a12) `[get]` |
| [MapEventState](namespace_tale_worlds_1_1_campaign_system_1_1_map_events.html#a97af7ec144561b3135225e9e6c6bb6ce) | [State](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a356c6ad84dde2804db6b533b9a575c48) `[get]` |
| [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | [AttackerSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a5b0b7cbe957cd4b1d6ddbcccc910a21a) `[get]` |
| [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | [DefenderSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a1057b41203c859cfd80444ddd0b7f584) `[get]` |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [InvolvedParties](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ac842bc69a88b4be223f47c1ba262ed22) `[get]` |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [MapEventSettlement](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ac7f2753a7c0f80afb4daa6e22b3bbe98) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [RetreatingSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aa114be3be56754bef9c6a7eafd3506be) = BattleSideEnum.None `[get]` |
| bool | [EndedByRetreat](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a225393c7873fca53f060ac1aee2b0af4) `[get]` |
| int | [PursuitRoundNumber](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a33b854e0b02c1c2aa925ef13bd6d9979) `[get]` |
| int | [UpdateCount](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aa2caf82a599e77dadae1b2d871e4a6be) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [Position](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#af4303913a3f3c7db66c71b435cee29a7) `[get]` |
| [BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) | [EventType](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a3af5e0bc20e98f308855f86531e6c947) `[get]` |
| [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | [EventTerrainType](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a88cdb88eeeb5e8fa448cffccc1207493) `[get]` |
| bool | [IsInvulnerable](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a6be9d1b3daa54fb58bd7e51d74bd4d4f) `[get, set]` |
| bool | [IsFieldBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a908fbac82e9ef8f0c6da9a296930a70e) `[get]` |
| bool | [IsRaid](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aaa8e06ee43a25efb3be9baa01a9c7961) `[get]` |
| bool | [IsForcingVolunteers](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a4d8e32c383bda7f39a0429d89d47f39e) `[get]` |
| bool | [IsForcingSupplies](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#adad195c0855336411fb53c2e835454ae) `[get]` |
| bool | [IsSiegeAssault](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a67c023754f9e3eec18ae98d5b4be14b5) `[get]` |
| bool | [IsHideoutBattle](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ac846adcc154feaedf66666dd633a8ea3) `[get]` |
| bool | [IsSallyOut](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a1b322aeba328ede1ddab75079fb44b5b) `[get]` |
| bool | [IsSiegeOutside](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a03a5cddff1305190d57f3b1e526ad98c) `[get]` |
| bool | [IsBlockade](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a25d2701bfec88a2f2f7fcf7282bdb995) `[get]` |
| bool | [IsBlockadeSallyOut](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a4e517cda9ba2b8c706843deeb0694ade) `[get]` |
| bool | [IsSiegeAmbush](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#afc5bafdad2c26fa23e266723c291a13f) `[get]` |
| bool | [IsVisible](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aabeba09874a32352f6f85656305237ab) `[get]` |
| bool | [IsPlayerMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a236d38f9ad271582fa642f146c52a397) `[get]` |
| [BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) | [BattleState](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a762b3edc202bc16a1091d22623682d37) `[get]` |
| [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | [Winner](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a21ee5ef1545e6aef1d09895def2bb8c8) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [WinningSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a6bfe55e844058bafe45f15235137668f) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [DefeatedSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a90ab154e54f9a5528c900c4fef043458) `[get]` |
| [MapEventResultExplainer](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_result_explainer.html) | [BattleResultExplainers](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a873879111d2668b4c66cbf9028f429aa) `[get]` |
| bool | [IsFinalized](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a74548fdae7494893c65821fd39e65f36) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [BattleStartTime](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ae785321805f4c596deef4221d6c77799) `[get]` |
| bool | [HasWinner](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aeea62c1ce4ff798bfc98c8f71156d202) `[get]` |
| bool | [IsPlayerSimulation](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a44d7a484789e14f30b3a692ed52be7e1) `[get, set]` |
| bool | [IsNavalMapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a6512606c9a1f00e912bff5ddd80a7b87) `[get]` |
| MBList< [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) > | [WonRounds](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a92c982775988b28b02608de749b9e435) = new MBList<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c)>() `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |
| virtual void | [AfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413) () |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851)BattleTypes
-------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.MapEvents.MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) |

| Enumerator | |
| --- | --- |
| None |  |
| FieldBattle |  |
| Raid |  |
| IsForcingVolunteers |  |
| IsForcingSupplies |  |
| Siege |  |
| Hideout |  |
| SallyOut |  |
| SiegeOutside |  |
| BlockadeBattle |  |
| BlockadeSallyOutBattle |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe)PowerCalculationContext
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.MapEvents.MapEvent.PowerCalculationContext](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a14657096432e5cd60d93ec49eaeda6fe) |

| Enumerator | |
| --- | --- |
| PlainBattle |  |
| SteppeBattle |  |
| DesertBattle |  |
| DuneBattle |  |
| SnowBattle |  |
| ForestBattle |  |
| RiverCrossingBattle |  |
| Village |  |
| Siege |  |
| SeaBattle |  |
| OpenSeaBattle |  |
| RiverBattle |  |
| Estimated |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a767ddc09b26b68ea442fe5c6ccded517)BeginWait()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.BeginWait | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aa61f9841783bbb80ee710dd53ccd99c8)GetMapEventSide()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.GetMapEventSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a1ed8964462012c3f576371ad73e39911)PartiesOnSide()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > TaleWorlds.CampaignSystem.MapEvents.MapEvent.PartiesOnSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a4cb4469c63846ee9f6a8a32df987e197)GetBattleRewards()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.GetBattleRewards | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | out float | *renownChange*, |
|  |  | out float | *influenceChange*, |
|  |  | out float | *moraleChange*, |
|  |  | out float | *goldChange*, |
|  |  | out float | *playerEarnedLootPercentage* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a2d7debd59074d6a28325d2d8e99e283d)ToString()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.MapEvents.MapEvent.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aadb7a531832a28815ba5bfad620fe924)GetNumberOfInvolvedMen() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.MapEvents.MapEvent.GetNumberOfInvolvedMen | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#accf3f8004f6ad156e3a75ba98e2a6b00)GetNumberOfInvolvedMen() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.MapEvents.MapEvent.GetNumberOfInvolvedMen | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a77c6e573dde3e87e848bb89e5cf3850c)FinishBattleAndKeepSiegeEvent()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.FinishBattleAndKeepSiegeEvent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ad34a661017f1ce8466458774cf3e50ad)SimulateBattleSetup()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.SimulateBattleSetup | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html)[] | *priorTroops* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a99bc587532d2356dc42caf709e97aa04)SimulateBattleRound()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.SimulateBattleRound | ( | int | *simulationTicksDefender*, |
|  |  | int | *simulationTicksAttacker* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#adbe561cc813c55f04ce874fb44bf8865)SetOverrideWinner()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.SetOverrideWinner | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *winner* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a29242982128f1fe73f2d0b6b251750a7)SetDefenderPulledBack()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.SetDefenderPulledBack | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a26dc33a802eb9bf6196fde1f29d507bc)ResetBattleState()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.ResetBattleState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a275c98e2c1426a235e9a815a2a1d275c)IsPlayerSergeant()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsPlayerSergeant | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a6cc0c8205dfe45dd60468f7d15f76c5b)FinalizeEvent()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.FinalizeEvent | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aca2649a4efb0d3d4921fd4ae22fdac50)HasTroopsOnBothSides()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.HasTroopsOnBothSides | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aaa299b3c492f87998abc2ef3fecab866)GetLeaderParty()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.GetLeaderParty | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a5e7ef12da477d6854c8f01093500d65f)GetRenownValue()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.MapEvents.MapEvent.GetRenownValue | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aea5ab73083548c9501216a5b37e88f1a)RecalculateRenownAndInfluenceValues()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.RecalculateRenownAndInfluenceValues | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a66985c254c5216c11d68ed599fe857ac)RecalculateStrengthOfSides()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.RecalculateStrengthOfSides | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a917b1bea8931b1d5b5c732f107adab82)DoSurrender()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.DoSurrender | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ae54c4c2e1cf5c8314d8bbaa48f4d5ac0)EndByRunAway()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.EndByRunAway | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aef9bf060d819a1d97731cb760af20475)GetOtherSide()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.MapEvents.MapEvent.GetOtherSide | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ac2fc9a267650a821d1c9fe0280075e7e)CanPartyJoinBattle()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.CanPartyJoinBattle | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a45fd70c0afc7c44a194d91750408e956)GetStrengthsRelativeToParty()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.GetStrengthsRelativeToParty | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *partySide*, |
|  |  | out float | *partySideStrength*, |
|  |  | out float | *opposingSideStrength* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aaa4953a382df4311fc22011386d1e27f)CheckIfBattleShouldContinueAfterBattleMission()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.CheckIfBattleShouldContinueAfterBattleMission | ( | [CampaignBattleResult](class_tale_worlds_1_1_campaign_system_1_1_encounters_1_1_campaign_battle_result.html) | *campaignBattleResult* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a0dc424fb98bbbd1100561d9b800619ed)SetPositionAfterMapChange()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.SetPositionAfterMapChange | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *newPosition* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ac66a952ac972f1ab6a96d916642d60d1)CheckPositionsForMapChangeAndUpdateIfNeeded()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEvent.CheckPositionsForMapChangeAndUpdateIfNeeded | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a5e46a0515df82145dfbf2cac8b43a0bf)SiegeAdvantage
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.MapEvents.MapEvent.SiegeAdvantage = 1.5f | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a4dad71a138e2cbc04f5b09877e0c35c4)DiplomaticallyFinished
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.DiplomaticallyFinished |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ad0fc23eaff03d13b687e9c6c2f31127d)MapEventVisual
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [IMapEventVisual](interface_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_i_map_event_visual.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.MapEventVisual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a22bac4b638228e62260a38c926acc4db)StrengthOfSide
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float [] TaleWorlds.CampaignSystem.MapEvents.MapEvent.StrengthOfSide = new float[(int)BattleSideEnum.NumSides] |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a021e11810ca809846568d3b26e20ac6d)TroopUpgradeTracker
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TroopUpgradeTracker TaleWorlds.CampaignSystem.MapEvents.MapEvent.TroopUpgradeTracker = new TroopUpgradeTracker() | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a3ad47c3821c19da9517c20863b38fd09)PlayerMapEvent
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapEvent TaleWorlds.CampaignSystem.MapEvents.MapEvent.PlayerMapEvent | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#afce18f41ec9d4bf54bc9f7a074ab7344)PlayerSide
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.MapEvents.MapEvent.PlayerSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ab5fbba6ca33293e99f2bd2d42fd16a12)Component
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.Component | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a356c6ad84dde2804db6b533b9a575c48)State
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEventState](namespace_tale_worlds_1_1_campaign_system_1_1_map_events.html#a97af7ec144561b3135225e9e6c6bb6ce) TaleWorlds.CampaignSystem.MapEvents.MapEvent.State | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a5b0b7cbe957cd4b1d6ddbcccc910a21a)AttackerSide
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.AttackerSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a1057b41203c859cfd80444ddd0b7f584)DefenderSide
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.DefenderSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ac842bc69a88b4be223f47c1ba262ed22)InvolvedParties
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html)> TaleWorlds.CampaignSystem.MapEvents.MapEvent.InvolvedParties | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ac7f2753a7c0f80afb4daa6e22b3bbe98)MapEventSettlement
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.MapEventSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aa114be3be56754bef9c6a7eafd3506be)RetreatingSide
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.MapEvents.MapEvent.RetreatingSide = BattleSideEnum.None | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a225393c7873fca53f060ac1aee2b0af4)EndedByRetreat
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.EndedByRetreat | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a33b854e0b02c1c2aa925ef13bd6d9979)PursuitRoundNumber
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEvent.PursuitRoundNumber | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aa2caf82a599e77dadae1b2d871e4a6be)UpdateCount
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEvent.UpdateCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#af4303913a3f3c7db66c71b435cee29a7)Position
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.Position | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a3af5e0bc20e98f308855f86531e6c947)EventType
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) TaleWorlds.CampaignSystem.MapEvents.MapEvent.EventType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a88cdb88eeeb5e8fa448cffccc1207493)EventTerrainType
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) TaleWorlds.CampaignSystem.MapEvents.MapEvent.EventTerrainType | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a6be9d1b3daa54fb58bd7e51d74bd4d4f)IsInvulnerable
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsInvulnerable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a908fbac82e9ef8f0c6da9a296930a70e)IsFieldBattle
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsFieldBattle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aaa8e06ee43a25efb3be9baa01a9c7961)IsRaid
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsRaid | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a4d8e32c383bda7f39a0429d89d47f39e)IsForcingVolunteers
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsForcingVolunteers | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#adad195c0855336411fb53c2e835454ae)IsForcingSupplies
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsForcingSupplies | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a67c023754f9e3eec18ae98d5b4be14b5)IsSiegeAssault
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsSiegeAssault | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ac846adcc154feaedf66666dd633a8ea3)IsHideoutBattle
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsHideoutBattle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a1b322aeba328ede1ddab75079fb44b5b)IsSallyOut
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsSallyOut | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a03a5cddff1305190d57f3b1e526ad98c)IsSiegeOutside
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsSiegeOutside | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a25d2701bfec88a2f2f7fcf7282bdb995)IsBlockade
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsBlockade | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a4e517cda9ba2b8c706843deeb0694ade)IsBlockadeSallyOut
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsBlockadeSallyOut | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#afc5bafdad2c26fa23e266723c291a13f)IsSiegeAmbush
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsSiegeAmbush | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aabeba09874a32352f6f85656305237ab)IsVisible
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsVisible | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a236d38f9ad271582fa642f146c52a397)IsPlayerMapEvent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsPlayerMapEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a762b3edc202bc16a1091d22623682d37)BattleState
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleState](namespace_tale_worlds_1_1_core.html#a53c64d3498c18a933d19dbf60e962fed) TaleWorlds.CampaignSystem.MapEvents.MapEvent.BattleState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a21ee5ef1545e6aef1d09895def2bb8c8)Winner
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.Winner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a6bfe55e844058bafe45f15235137668f)WinningSide
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.MapEvents.MapEvent.WinningSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a90ab154e54f9a5528c900c4fef043458)DefeatedSide
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.MapEvents.MapEvent.DefeatedSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a873879111d2668b4c66cbf9028f429aa)BattleResultExplainers
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapEventResultExplainer](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_result_explainer.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.BattleResultExplainers | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a74548fdae7494893c65821fd39e65f36)IsFinalized
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsFinalized | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#ae785321805f4c596deef4221d6c77799)BattleStartTime
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.MapEvents.MapEvent.BattleStartTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#aeea62c1ce4ff798bfc98c8f71156d202)HasWinner
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.HasWinner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a44d7a484789e14f30b3a692ed52be7e1)IsPlayerSimulation
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsPlayerSimulation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a6512606c9a1f00e912bff5ddd80a7b87)IsNavalMapEvent
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEvent.IsNavalMapEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a92c982775988b28b02608de749b9e435)WonRounds
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c)> TaleWorlds.CampaignSystem.MapEvents.MapEvent.WonRounds = new MBList<[BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c)>() | | get |

