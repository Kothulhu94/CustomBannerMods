--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html ---

TaleWorlds.CampaignSystem.Settlements.Settlement Class Referencesealed[Common](class_tale_worlds_1_1_library_1_1_common.html) class for villages and towns.

Inherits [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html), , [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html), [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html), [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html), and [TaleWorlds.CampaignSystem.IRandomOwner](interface_tale_worlds_1_1_campaign_system_1_1_i_random_owner.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [SiegeState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a108a090c22cdef6357de70403004efea) {     [OnTheWalls](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a108a090c22cdef6357de70403004efeaa7ffacd90ac97e6dbf46cbd78addd2b7c) ,     [InTheLordsHall](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a108a090c22cdef6357de70403004efeaaf7863439d0aa9f7ca9e24f8489255b96) ,     [Invalid](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a108a090c22cdef6357de70403004efeaa4bbb8f967da6d1a610596d7257179c2b)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetWallSectionHitPointsRatioAtIndex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a56bb1b78ac8ee4c76007b90b45dfdea3) (int index, float hitPointsRatio) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPositionAsVec3](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ac2791fdb24b3783a1dac4388be9ab06a) () |
| void | [SetGarrisonWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab4f8dc9e635a0ad41df94462393022c0) (int limit) |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [GetInvolvedPartiesForEventType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab7554a5d8df65165f70cbd1dd77130d4) (MapEvent.BattleTypes mapEventType=MapEvent.BattleTypes.Siege) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetNextInvolvedPartyForEventType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a4b1b2993ad607867fd9b2f82be666845) (ref int partyIndex, MapEvent.BattleTypes mapEventType=MapEvent.BattleTypes.Siege) |
| bool | [HasInvolvedPartyForEventType](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab461a3eac71e331f4b868eb2eb7c3109) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, MapEvent.BattleTypes mapEventType=MapEvent.BattleTypes.Siege) |
| bool | [IsUnderRebellionAttack](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a66014e17bbb80a4baf7681f501067752) () |
|  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) () |
|  | Initializes a new instance of the [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html "Common class for villages and towns.") class. |
|  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a3950d0529ff3dad6db950d287c44d85f) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad0c82ffb74f4ebd980d90da1fd34e208) locationComplex, [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) pt) |
|  | Initializes a new instance of the [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html "Common class for villages and towns.") class. |
| float | [GetSettlementValueForEnemyHero](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a2e086b7836ddc97e44961b6de54db31e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| bool | [IsSettlementBusy](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af42d388beb29397636d6058452f76dbc) (object asker) |
| bool | [IsSettlementBusy](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a767ede55b9a662b6cf3a7f18ccb5a7cb) (object asker, int limitingPriority) |
| int | [GetSettlementBusynessPriority](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a9b0c880f83b8330c006455603e457c61) (object asker) |
| float | [GetValue](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ade0227b9b0227079afebc6bd35c1700a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero=null, bool countAlsoBoundedSettlements=true) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad77f43172b31908a6104fa07a128cac2) () |
|  | This function is not same with get property of Name. It overrides the function in MBObjectBase class. It is used in encyclopedia etc. |
| float | [GetSettlementValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa72a7bf040494f451ae842533d3426c8) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af8f4f34db5716ba4699c25748e7bc51a) () |
| void | [OnPartyInteraction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a096b77494beaa711b88c5c4cfb420d50) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) engagingParty) |
| override void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a6854e11f1feb5c61f28e1db4ef550796) ([MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) objectManager, XmlNode node) |
| void | [OnFinishLoadState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a711650c725e5a39104e92b46d28dbb16) () |
| void | [OnGameCreated](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a51a88dc9f9a4efe12c6923401196ce65) () |
| void | [OnSessionStart](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a86414989f7e0afa986716846f91f2e3a) () |
| void | [CheckPositionsForMapChangeAndUpdateIfNeeded](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab5cfba852476fc0f8e52c4b4ffea8e74) () |
| void | [OnPlayerEncounterFinish](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a248a2936e49c20434cc30600dbd930e8) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPosition](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad8c999f7be17ada45f9bfaab7d58fec0) () |
| void | [SetNextSiegeState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a9e08c35bad7c16d6fefeda51cc9cde67) () |
| void | [ResetSiegeState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1174e5ad965713c52f0bc03f846a13de) () |
| void | [AddGarrisonParty](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a7dbd15701d779e2be0c037a96d61624e) () |
| void | [SetSiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ada0fee116f6cae8fa7dda6d701e9367f) ([SiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa6c252832f9944504fa4bd6261e299ac) strategy) |
| void | [InitializeSiegeEventSide](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#acf5aef15e900100a158cfc2bec85933b) () |
| void | [OnTroopsKilledOnSide](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a4c949ecd5164f5484a36f43ccbc39c5e) (int killCount) |
| void | [AddSiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af482b081aa29a504306fd9a7f01c6cd8) ([SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) missile) |
| void | [RemoveDeprecatedMissiles](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a2c50f5355856e4fe26851cddc27c8a57) () |
| void | [GetAttackTarget](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a012a12daf94809d63cdcca09bd58819d) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) siegeEventSide, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, int siegeEngineSlot, out [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) targetType, out int targetIndex) |
| void | [FinalizeSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a7926e5563e67b30e91c8421103b73145) () |
| Public Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a520e657fd5a750c8b7e2154b0f5629ea) () |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a134c5e806ba735219710d773e7075b00) (MBObjectBase other) |
|  | [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8e3c1b47f5d928e64d9d67fa7864c364) (string stringId) |
| void | [AfterInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab67141737ce51fe724e4a5b8026a973b) () |
| virtual void | [AfterRegister](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ab15f91cc9dbb7ff8763eec828c179216) () |
| virtual void | [Initialize](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aad39d5ca82d85853a9879e2670dd036e) () |
| override int | [GetHashCode](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a68e79a07f136aae5be4fe9eadb612def) () |
| void | [PreAfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af26d64a79291c4f6328fc151d2569ebf) () |
| void | [AfterLoadInternal](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a277b54134c76732e443019a7862cf388) () |
| void | [OnRegistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a586208e92e5041fd432127305aa8af16) () |
| void | [OnUnregistered](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a71bef09af9a896246fa7b18c324e565c) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | |
| void | [AddSiegeEngineMissile](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a340a94abda07183b528f0049a1ca2489) ([SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) missile) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) | [Find](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab6daea03b0b37c1c95fb23b600739982) (string idString) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) | [FindFirst](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a35e7a08e364fabe0cea636f997c7b7f7) (Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464), bool > predicate) |
| static IEnumerable< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) > | [FindAll](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0051fb62c303f67740c87c90ba8acbb7) (Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464), bool > predicate) |
| static LocatableSearchData< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) > | [StartFindingLocatablesAroundPosition](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a31273ec8822967874584ab48af137f10) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, float radius) |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) | [FindNextLocatable](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ae4f33a57005be1ff05cd525d2275f4e3) (ref LocatableSearchData< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) > data) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [NumberOfLordPartiesTargeting](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0854f5378f6255fd1fb114b507517129) |
| bool | [HasVisited](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a24cd9ad006773adcb67b9768cd50cbed) |
| float | [LastVisitTimeOfOwner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a66903139687d3f84d4377b6bb3f731ff) |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) | [Culture](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ae965d36d130cf1bd43807047a0e34659) |
| Town | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#afb39c0fdd9619cecc4260442cda6cc4b) |
| Village | [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af000c4338fc959e18925010a36beeba5) |
| Hideout | [Hideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a85809c0660ea42b90ad310036c513358) |
| MilitiaPartyComponent | [MilitiaPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0a22d1f71f3cdb6608f434226ab434cc) |
| readonly [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0b33a6fc21c83480f1fdab3986cc6e9b) | [Stash](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#acf360134de3988618a2044252860368b) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [AfterLoad](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab849b1f8d526ce0f46cfcce0e84e1b85) () |
| Protected Member Functions inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| virtual void | [OnBeforeLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad32c7b22bd64e771cc05ee54ae78058a) () |
| virtual void | [PreAfterLoad](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aeddc87ee0703c7f37d9129d9a5e024e4) () |

|  |  |
| --- | --- |
| Properties | |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [Party](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a47ee36a6fb25e2ae14a0306b711955d4) `[get]` |
| int | [NumberOfLordPartiesAt](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ae96945c556d3816d0aa87ee137000c5d) `[get]` |
| int | [BribePaid](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a83e04dcd8dca2009e84a01a058a2299d) `[get, set]` |
| SiegeEvent | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab241f30cec980e45dedd080a070af2bf) `[get, set]` |
| bool | [IsActive](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1a38bad728cf80965ce1df725f208ee8) `[get, set]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aafb71679ec0f41c05dd5f0bc9d78705b) `[get]` |
| Banner | [Banner](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#acff76122c53f619e01a83cf71a9eba26) `[get]` |
| bool | [IsVisible](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1070e0990dd6467f8559df4dba5e400d) `[get, set]` |
| bool | [IsInspected](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a160294c9b6ff0faee224b8712a42f07f) `[get, set]` |
| int | [WallSectionCount](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1c71915a41cf1f93ab853a3fc1dbc4d6) `[get]` |
| float | [NearbyLandThreatIntensity](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a9ff410b713c3e9c85e09666a8754bd5d) `[get, set]` |
| float | [NearbyNavalThreatIntensity](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a4da2c797255f6983c618d5d6adb78e15) `[get, set]` |
| float | [NearbyLandAllyIntensity](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a68bf2f4b2b669dbc6b288239305e20e2) `[get, set]` |
| float | [NearbyNavalAllyIntensity](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ae688408cac22b2a4cdde17bc7b8b8382) `[get, set]` |
| int | [RandomValue](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a6885c0bb33c7960cd7cb986efdeb2976) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetPosition2D](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af2c2cfdd7d2b2e54ec4a3e686c8d155a) `[get]` |
| float | [Militia](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a681c3fa1e6d3669479772d509897c598) `[get, set]` |
| MBReadOnlyList< float > | [SettlementWallSectionHitPointsRatioList](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af1616634c27671330fcc22cba558cdad) `[get]` |
| float | [SettlementTotalWallHitPoints](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ac7a3929b5c50f9af5a8530e48dec1f23) `[get]` |
| float | [MaxHitPointsOfOneWallSection](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a24140dd1eb162c817bdfc0f244d40b1c) `[get]` |
| float | [SettlementHitPoints](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a00471bfb0094557ebe3cf6851ae35041) `[get]` |
| float | [MaxWallHitPoints](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a610b5266cefc03ce2000014fed972c48) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [Parties](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a5f2ca6e051120ad5fc6c330e160c66df) `[get]` |
| [PatrolPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_patrol_party_component.html) | [PatrolParty](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a8cc1d9a00f34723b838f4553a5e0e670) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [HeroesWithoutParty](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a12a2a525a013a2c9da78b82b8f57ca52) `[get]` |
| MBReadOnlyList< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | [Notables](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a39c015f30d71057f185d25d8aa2c9796) `[get]` |
| SettlementComponent | [SettlementComponent](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a78b95a1d7b1aacb435e27857f67eeee8) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GatePosition](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1c4145f84f83dc3f96b2ffde1569a3bf) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [PortPosition](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a7cb01ddbf23e4a6b297e6e2056e8d422) `[get]` |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [CurrentNavigationFace](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aca6fe4bd030cae3d3bf23be92ca5539e) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [Position](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a2f9f0256ff1109297d9fa48d74ba932c) `[get]` |
| bool | [HasPort](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a19c1a14351fcfabf2d03fd0a1a4464ca) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa5fbaaee56f205969a2ddab2b0990549) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a89d2eeaa0144d1289211d5366e238f96) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaText](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a19194b18351460548ed0f6b09d10633e) `[get]` |
| string | [EncyclopediaLink](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1e5392c3c684059c68eaf40aa2cff1f4) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaLinkWithName](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a276946fb3c466b17c6f6105180420765) `[get]` |
| int | [GarrisonWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a90b16df633242e1a56e0d1de0e83f24a) `[get]` |
| ItemRoster | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0b33a6fc21c83480f1fdab3986cc6e9b) `[get]` |
| MBReadOnlyList< [Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af000c4338fc959e18925010a36beeba5) > | [BoundVillages](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1c835fbdcac3f1ef01a7cb284340cde1) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [LastAttackerParty](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a182aaa6e9a09dc32ce0d045feee0b7a3) `[get, set]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [LastThreatTime](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#abe395a54b4ebf6d486575ce1d1d3c05e) `[get]` |
| [SiegeEvent.SiegeEnginesContainer](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html) | [SiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab5b2d9d7972839e7fb1943bea1ee9694) `[get]` |
| MBReadOnlyList< [SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) > | [SiegeEngineMissiles](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a062dc1cfb9f056193a7b61868ed75c21) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [BattleSide](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aabc79369bf9353ea4f1e2d436957ea60) `[get]` |
| int | [NumberOfTroopsKilledOnSide](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad52c6f8745b5eccbe57affa0a5db4c0d) `[get]` |
| SiegeStrategy | [SiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa6c252832f9944504fa4bd6261e299ac) `[get]` |
| List< [Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html) > | [Alleys](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a732c0f5801d92650e965bd03187102d9) `[get]` |
| bool | [IsTown](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a00e4b4a7db870fb6f97edf92c500072d) `[get]` |
| bool | [IsCastle](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0d8e2692b2a798c805aa9ae3a91ca6dd) `[get]` |
| bool | [IsFortification](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa0265798534d65a93bb29f7e61766996) `[get]` |
| bool | [IsVillage](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a83be3ddc7cd37cee975b8a6e6c6b3545) `[get]` |
| bool | [IsHideout](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a24ece4ae7060de5deb76394bf1980cfd) `[get]` |
| bool | [IsStarving](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aae54011d2ee031be99cd520de7bf3175) `[get]` |
| bool | [IsRaided](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#afa07d13b2fc650134f6847f267b61673) `[get]` |
| bool | [InRebelliousState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a068061b2bd54683ccffdaab654bc0e7a) `[get]` |
| bool | [IsUnderRaid](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a43397c77e0f1abcde21076de98eca59b) `[get]` |
| bool | [IsUnderSiege](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a7f48d2f1318c0837ed29755a49a732a9) `[get]` |
| LocationComplex | [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad0c82ffb74f4ebd980d90da1fd34e208) `[get]` |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) | [CurrentSettlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a218f1a833d6d5f0c1e15932e91c85ba8) `[get]` |
| static MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) > | [All](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab92d9f98a5e04102bba39845c02fcff4) `[get]` |
| static [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) | [GetFirst](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a3d773ac0e27d0f5ca3ccc39189f4ba8c) `[get]` |
| [SiegeState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a108a090c22cdef6357de70403004efea) | [CurrentSiegeState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a04838ac12b38901ff82a3971f374a363) `[get]` |
| [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | [OwnerClan](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a08c1a519fd2c5bbe3b1e371fe1d76ec7) `[get]` |
| Properties inherited from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | |
| string | [StringId](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a8f7cc0266861eb249963e5ead3ab93f1) `[get, set]` |
| [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html) | [Id](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#af97fbe63c015ee5f4958ab6946b7f69a) `[get, set]` |
| bool | [IsInitialized](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aa6b3602c7cfd678c75bf91e1c3073606) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#abc67abca4d8d58d34835693808c0aa14) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html) | |
| bool | [IsReady](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html#a69166dbcedc127fea26c01d2428d01d7) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.Map.DistanceCache.ISettlementDataHolder](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_i_settlement_data_holder.html) | |
| string | [StringId](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_i_settlement_data_holder.html#a27e001d767a834a2ec26bfad09a5ebeb) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a108a090c22cdef6357de70403004efea)SiegeState
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Settlements.Settlement.SiegeState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a108a090c22cdef6357de70403004efea) |

| Enumerator | |
| --- | --- |
| OnTheWalls |  |
| InTheLordsHall |  |
| Invalid |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464)Settlement() [1/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Settlement.Settlement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a3950d0529ff3dad6db950d287c44d85f)Settlement() [2/2]
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.Settlement.Settlement | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | [LocationComplex](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad0c82ffb74f4ebd980d90da1fd34e208) | *locationComplex*, |
|  |  | [PartyTemplateObject](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_template_object.html) | *pt* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a56bb1b78ac8ee4c76007b90b45dfdea3)SetWallSectionHitPointsRatioAtIndex()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.SetWallSectionHitPointsRatioAtIndex | ( | int | *index*, |
|  |  | float | *hitPointsRatio* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ac2791fdb24b3783a1dac4388be9ab06a)GetPositionAsVec3()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.CampaignSystem.Settlements.Settlement.GetPositionAsVec3 | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#ae172008491c85da53167da47d59ee6d2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab4f8dc9e635a0ad41df94462393022c0)SetGarrisonWagePaymentLimit()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.SetGarrisonWagePaymentLimit | ( | int | *limit* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab7554a5d8df65165f70cbd1dd77130d4)GetInvolvedPartiesForEventType()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > TaleWorlds.CampaignSystem.Settlements.Settlement.GetInvolvedPartiesForEventType | ( | MapEvent.BattleTypes | *mapEventType* = MapEvent::BattleTypes::Siege | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a5d012939b5a82072426a2edf10a63fad).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a4b1b2993ad607867fd9b2f82be666845)GetNextInvolvedPartyForEventType()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Settlements.Settlement.GetNextInvolvedPartyForEventType | ( | ref int | *partyIndex*, |
|  |  | MapEvent.BattleTypes | *mapEventType* = MapEvent::BattleTypes::Siege ) |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a17d253f15e744eda68027a2cc4217234).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab461a3eac71e331f4b868eb2eb7c3109)HasInvolvedPartyForEventType()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Settlement.HasInvolvedPartyForEventType | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | MapEvent.BattleTypes | *mapEventType* = MapEvent::BattleTypes::Siege ) |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a9f91f1f246a99356126ba0acb70e33d6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a66014e17bbb80a4baf7681f501067752)IsUnderRebellionAttack()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsUnderRebellionAttack | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a2e086b7836ddc97e44961b6de54db31e)GetSettlementValueForEnemyHero()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.Settlement.GetSettlementValueForEnemyHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af42d388beb29397636d6058452f76dbc)IsSettlementBusy() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsSettlementBusy | ( | object | *asker* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a767ede55b9a662b6cf3a7f18ccb5a7cb)IsSettlementBusy() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsSettlementBusy | ( | object | *asker*, |
|  |  | int | *limitingPriority* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a9b0c880f83b8330c006455603e457c61)GetSettlementBusynessPriority()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.Settlement.GetSettlementBusynessPriority | ( | object | *asker* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ade0227b9b0227079afebc6bd35c1700a)GetValue()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.Settlement.GetValue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* = null, |
|  |  | bool | *countAlsoBoundedSettlements* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad77f43172b31908a6104fa07a128cac2)GetName()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Settlement.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#a0b72f9e386b6cefc4e6bfb52642b98db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa72a7bf040494f451ae842533d3426c8)GetSettlementValueForFaction()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.Settlement.GetSettlementValueForFaction | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af8f4f34db5716ba4699c25748e7bc51a)ToString()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Settlements.Settlement.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a096b77494beaa711b88c5c4cfb420d50)OnPartyInteraction()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.OnPartyInteraction | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *engagingParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a6854e11f1feb5c61f28e1db4ef550796)Deserialize()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Settlement.Deserialize | ( | [MBObjectManager](class_tale_worlds_1_1_object_system_1_1_m_b_object_manager.html) | *objectManager*, | |  |  | XmlNode | *node* ) | | virtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#ad1364026109401ca16d5a450d8b8f178).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a711650c725e5a39104e92b46d28dbb16)OnFinishLoadState()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.OnFinishLoadState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a51a88dc9f9a4efe12c6923401196ce65)OnGameCreated()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.OnGameCreated | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a86414989f7e0afa986716846f91f2e3a)OnSessionStart()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.OnSessionStart | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab5cfba852476fc0f8e52c4b4ffea8e74)CheckPositionsForMapChangeAndUpdateIfNeeded()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.CheckPositionsForMapChangeAndUpdateIfNeeded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab6daea03b0b37c1c95fb23b600739982)Find()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) TaleWorlds.CampaignSystem.Settlements.Settlement.Find | ( | string | *idString* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a35e7a08e364fabe0cea636f997c7b7f7)FindFirst()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) TaleWorlds.CampaignSystem.Settlements.Settlement.FindFirst | ( | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464), bool > | *predicate* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0051fb62c303f67740c87c90ba8acbb7)FindAll()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) > TaleWorlds.CampaignSystem.Settlements.Settlement.FindAll | ( | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464), bool > | *predicate* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a31273ec8822967874584ab48af137f10)StartFindingLocatablesAroundPosition()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | LocatableSearchData< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) > TaleWorlds.CampaignSystem.Settlements.Settlement.StartFindingLocatablesAroundPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, | |  |  | float | *radius* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ae4f33a57005be1ff05cd525d2275f4e3)FindNextLocatable()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) TaleWorlds.CampaignSystem.Settlements.Settlement.FindNextLocatable | ( | ref LocatableSearchData< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) > | *data* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a248a2936e49c20434cc30600dbd930e8)OnPlayerEncounterFinish()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.OnPlayerEncounterFinish | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad8c999f7be17ada45f9bfaab7d58fec0)GetPosition()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.CampaignSystem.Settlements.Settlement.GetPosition | ( |  | ) |  |

Implements [TaleWorlds.Core.ITrackableBase](interface_tale_worlds_1_1_core_1_1_i_trackable_base.html#a2c1f3cba0651fa9caa3fb054640f9ea1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a9e08c35bad7c16d6fefeda51cc9cde67)SetNextSiegeState()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.SetNextSiegeState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1174e5ad965713c52f0bc03f846a13de)ResetSiegeState()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.ResetSiegeState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a7dbd15701d779e2be0c037a96d61624e)AddGarrisonParty()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.AddGarrisonParty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab849b1f8d526ce0f46cfcce0e84e1b85)AfterLoad()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Settlements.Settlement.AfterLoad | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.ObjectSystem.MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html#aae8a0aa22e7a659e1edbedfe9739d413).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ada0fee116f6cae8fa7dda6d701e9367f)SetSiegeStrategy()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.SetSiegeStrategy | ( | [SiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa6c252832f9944504fa4bd6261e299ac) | *strategy* | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#acdb1b4b9016470e9092ce421d9157817).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#acf5aef15e900100a158cfc2bec85933b)InitializeSiegeEventSide()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.InitializeSiegeEventSide | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a07e0c5f04b13d9d1bc72772c775a2615).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a4c949ecd5164f5484a36f43ccbc39c5e)OnTroopsKilledOnSide()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.OnTroopsKilledOnSide | ( | int | *killCount* | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a9c879051003bd28dc76bfb5ff674899c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af482b081aa29a504306fd9a7f01c6cd8)AddSiegeEngineMissile()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.AddSiegeEngineMissile | ( | [SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html) | *missile* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a2c50f5355856e4fe26851cddc27c8a57)RemoveDeprecatedMissiles()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.RemoveDeprecatedMissiles | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a2d6407510a9af52b4e4a6540843b6083).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a012a12daf94809d63cdcca09bd58819d)GetAttackTarget()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.GetAttackTarget | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *siegeEventSide*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, |
|  |  | int | *siegeEngineSlot*, |
|  |  | out [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *targetType*, |
|  |  | out int | *targetIndex* ) |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a7349aa664e0af23743a57feba79d278e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a7926e5563e67b30e91c8421103b73145)FinalizeSiegeEvent()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.Settlement.FinalizeSiegeEvent | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a3cc987a5db12fa1c39781d4e70a769f6).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0854f5378f6255fd1fb114b507517129)NumberOfLordPartiesTargeting
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Settlements.Settlement.NumberOfLordPartiesTargeting |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a24cd9ad006773adcb67b9768cd50cbed)HasVisited
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.Settlements.Settlement.HasVisited |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a66903139687d3f84d4377b6bb3f731ff)LastVisitTimeOfOwner
------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.Settlements.Settlement.LastVisitTimeOfOwner |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ae965d36d130cf1bd43807047a0e34659)Culture
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [CultureObject](class_tale_worlds_1_1_campaign_system_1_1_culture_object.html) TaleWorlds.CampaignSystem.Settlements.Settlement.Culture |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#afb39c0fdd9619cecc4260442cda6cc4b)Town
--------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Town TaleWorlds.CampaignSystem.Settlements.Settlement.Town |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af000c4338fc959e18925010a36beeba5)Village
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Village TaleWorlds.CampaignSystem.Settlements.Settlement.Village |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a85809c0660ea42b90ad310036c513358)Hideout
-----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Hideout TaleWorlds.CampaignSystem.Settlements.Settlement.Hideout |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0a22d1f71f3cdb6608f434226ab434cc)MilitiaPartyComponent
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| MilitiaPartyComponent TaleWorlds.CampaignSystem.Settlements.Settlement.MilitiaPartyComponent |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#acf360134de3988618a2044252860368b)Stash
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0b33a6fc21c83480f1fdab3986cc6e9b) TaleWorlds.CampaignSystem.Settlements.Settlement.Stash |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a47ee36a6fb25e2ae14a0306b711955d4)Party
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Settlements.Settlement.Party | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ae96945c556d3816d0aa87ee137000c5d)NumberOfLordPartiesAt
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Settlement.NumberOfLordPartiesAt | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a83e04dcd8dca2009e84a01a058a2299d)BribePaid
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Settlement.BribePaid | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab241f30cec980e45dedd080a070af2bf)SiegeEvent
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SiegeEvent TaleWorlds.CampaignSystem.Settlements.Settlement.SiegeEvent | | getset |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#aad0ea0e43337b3924044b1401ae47158).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1a38bad728cf80965ce1df725f208ee8)IsActive
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsActive | | getset |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a9a94a3139781933fc6095d4a190ed447).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aafb71679ec0f41c05dd5f0bc9d78705b)Owner
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Settlements.Settlement.Owner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#acff76122c53f619e01a83cf71a9eba26)Banner
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Banner TaleWorlds.CampaignSystem.Settlements.Settlement.Banner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1070e0990dd6467f8559df4dba5e400d)IsVisible
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsVisible | | getset |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a3a703415b6c660034bba2b73841d0005).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a160294c9b6ff0faee224b8712a42f07f)IsInspected
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsInspected | | getset |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a52a27327b9546405aca825138d341bd9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1c71915a41cf1f93ab853a3fc1dbc4d6)WallSectionCount
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Settlement.WallSectionCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a9ff410b713c3e9c85e09666a8754bd5d)NearbyLandThreatIntensity
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Settlement.NearbyLandThreatIntensity | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a4da2c797255f6983c618d5d6adb78e15)NearbyNavalThreatIntensity
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Settlement.NearbyNavalThreatIntensity | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a68bf2f4b2b669dbc6b288239305e20e2)NearbyLandAllyIntensity
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Settlement.NearbyLandAllyIntensity | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ae688408cac22b2a4cdde17bc7b8b8382)NearbyNavalAllyIntensity
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Settlement.NearbyNavalAllyIntensity | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a6885c0bb33c7960cd7cb986efdeb2976)RandomValue
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Settlement.RandomValue | | get |

Implements [TaleWorlds.CampaignSystem.IRandomOwner](interface_tale_worlds_1_1_campaign_system_1_1_i_random_owner.html#ad9f2a476dc29e7b3268949ab048d5ac7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af2c2cfdd7d2b2e54ec4a3e686c8d155a)GetPosition2D
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Settlements.Settlement.GetPosition2D | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a681c3fa1e6d3669479772d509897c598)Militia
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Settlement.Militia | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af1616634c27671330fcc22cba558cdad)SettlementWallSectionHitPointsRatioList
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<float> TaleWorlds.CampaignSystem.Settlements.Settlement.SettlementWallSectionHitPointsRatioList | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ac7a3929b5c50f9af5a8530e48dec1f23)SettlementTotalWallHitPoints
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Settlement.SettlementTotalWallHitPoints | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a24140dd1eb162c817bdfc0f244d40b1c)MaxHitPointsOfOneWallSection
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Settlement.MaxHitPointsOfOneWallSection | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a00471bfb0094557ebe3cf6851ae35041)SettlementHitPoints
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Settlement.SettlementHitPoints | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a610b5266cefc03ce2000014fed972c48)MaxWallHitPoints
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Settlements.Settlement.MaxWallHitPoints | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a5f2ca6e051120ad5fc6c330e160c66df)Parties
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.Settlements.Settlement.Parties | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a8cc1d9a00f34723b838f4553a5e0e670)PatrolParty
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PatrolPartyComponent](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_components_1_1_patrol_party_component.html) TaleWorlds.CampaignSystem.Settlements.Settlement.PatrolParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a12a2a525a013a2c9da78b82b8f57ca52)HeroesWithoutParty
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.Settlements.Settlement.HeroesWithoutParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a39c015f30d71057f185d25d8aa2c9796)Notables
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html)> TaleWorlds.CampaignSystem.Settlements.Settlement.Notables | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a78b95a1d7b1aacb435e27857f67eeee8)SettlementComponent
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SettlementComponent TaleWorlds.CampaignSystem.Settlements.Settlement.SettlementComponent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1c4145f84f83dc3f96b2ffde1569a3bf)GatePosition
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Settlements.Settlement.GatePosition | | get |

Implements [TaleWorlds.CampaignSystem.Map.DistanceCache.ISettlementDataHolder](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_i_settlement_data_holder.html#a2129eb6e49e9d057b0904104234dde3e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a7cb01ddbf23e4a6b297e6e2056e8d422)PortPosition
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Settlements.Settlement.PortPosition | | get |

Implements [TaleWorlds.CampaignSystem.Map.DistanceCache.ISettlementDataHolder](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_i_settlement_data_holder.html#ac5d48c444213eddc1858f7409f027e6e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aca6fe4bd030cae3d3bf23be92ca5539e)CurrentNavigationFace
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) TaleWorlds.CampaignSystem.Settlements.Settlement.CurrentNavigationFace | | get |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#aafc1ce3465c81b843115c55e18f63da1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a2f9f0256ff1109297d9fa48d74ba932c)Position
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Settlements.Settlement.Position | | get |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a4b2b24b574807e41e0c1b4afe629adb1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a19c1a14351fcfabf2d03fd0a1a4464ca)HasPort
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.HasPort | | get |

Implements [TaleWorlds.CampaignSystem.Map.DistanceCache.ISettlementDataHolder](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_i_settlement_data_holder.html#a63e760c32cf1396580b39b27f1e31ee9).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa5fbaaee56f205969a2ddab2b0990549)MapFaction
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.Settlements.Settlement.MapFaction | | get |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a779a86170e3020b297abca9923ff4f47).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a89d2eeaa0144d1289211d5366e238f96)Name
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Settlement.Name | | get |

Implements [TaleWorlds.CampaignSystem.Map.IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html#a9fb1af1ef552ebd3d10304da752defa7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a19194b18351460548ed0f6b09d10633e)EncyclopediaText
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Settlement.EncyclopediaText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1e5392c3c684059c68eaf40aa2cff1f4)EncyclopediaLink
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.Settlements.Settlement.EncyclopediaLink | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a276946fb3c466b17c6f6105180420765)EncyclopediaLinkWithName
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Settlements.Settlement.EncyclopediaLinkWithName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a90b16df633242e1a56e0d1de0e83f24a)GarrisonWagePaymentLimit
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Settlement.GarrisonWagePaymentLimit | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0b33a6fc21c83480f1fdab3986cc6e9b)ItemRoster
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ItemRoster TaleWorlds.CampaignSystem.Settlements.Settlement.ItemRoster | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a1c835fbdcac3f1ef01a7cb284340cde1)BoundVillages
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Village](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#af000c4338fc959e18925010a36beeba5)> TaleWorlds.CampaignSystem.Settlements.Settlement.BoundVillages | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a182aaa6e9a09dc32ce0d045feee0b7a3)LastAttackerParty
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.Settlements.Settlement.LastAttackerParty | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#abe395a54b4ebf6d486575ce1d1d3c05e)LastThreatTime
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Settlements.Settlement.LastThreatTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab5b2d9d7972839e7fb1943bea1ee9694)SiegeEngines
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeEvent.SiegeEnginesContainer](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engines_container.html) TaleWorlds.CampaignSystem.Settlements.Settlement.SiegeEngines | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#ab5780cdfb31550931179932b18a2d0c8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a062dc1cfb9f056193a7b61868ed75c21)SiegeEngineMissiles
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[SiegeEvent.SiegeEngineMissile](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event_1_1_siege_engine_missile.html)> TaleWorlds.CampaignSystem.Settlements.Settlement.SiegeEngineMissiles | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a5b161bd7909124344676c452d8c64f7b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aabc79369bf9353ea4f1e2d436957ea60)BattleSide
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.Settlements.Settlement.BattleSide | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#aaf88767d86d2aa9c2a0aeed587fcc4c8).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad52c6f8745b5eccbe57affa0a5db4c0d)NumberOfTroopsKilledOnSide
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Settlements.Settlement.NumberOfTroopsKilledOnSide | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#ad71a13fe75819f069dc4f07c4f9954e7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa6c252832f9944504fa4bd6261e299ac)SiegeStrategy
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SiegeStrategy TaleWorlds.CampaignSystem.Settlements.Settlement.SiegeStrategy | | get |

Implements [TaleWorlds.CampaignSystem.Siege.ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html#a59f6dff6d8f976cedfdb9e9941397e0c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a732c0f5801d92650e965bd03187102d9)Alleys
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Alley](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_alley.html)> TaleWorlds.CampaignSystem.Settlements.Settlement.Alleys | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a00e4b4a7db870fb6f97edf92c500072d)IsTown
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsTown | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a0d8e2692b2a798c805aa9ae3a91ca6dd)IsCastle
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsCastle | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aa0265798534d65a93bb29f7e61766996)IsFortification
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsFortification | | get |

Implements [TaleWorlds.CampaignSystem.Map.DistanceCache.ISettlementDataHolder](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_i_settlement_data_holder.html#a9c95a1f6fa32c5e4c854c5e2db7f9e58).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a83be3ddc7cd37cee975b8a6e6c6b3545)IsVillage
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsVillage | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a24ece4ae7060de5deb76394bf1980cfd)IsHideout
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsHideout | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#aae54011d2ee031be99cd520de7bf3175)IsStarving
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsStarving | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#afa07d13b2fc650134f6847f267b61673)IsRaided
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsRaided | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a068061b2bd54683ccffdaab654bc0e7a)InRebelliousState
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.InRebelliousState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a43397c77e0f1abcde21076de98eca59b)IsUnderRaid
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsUnderRaid | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a7f48d2f1318c0837ed29755a49a732a9)IsUnderSiege
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Settlements.Settlement.IsUnderSiege | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ad0c82ffb74f4ebd980d90da1fd34e208)LocationComplex
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | LocationComplex TaleWorlds.CampaignSystem.Settlements.Settlement.LocationComplex | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a218f1a833d6d5f0c1e15932e91c85ba8)CurrentSettlement
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) TaleWorlds.CampaignSystem.Settlements.Settlement.CurrentSettlement | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#ab92d9f98a5e04102bba39845c02fcff4)All
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464)> TaleWorlds.CampaignSystem.Settlements.Settlement.All | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a3d773ac0e27d0f5ca3ccc39189f4ba8c)GetFirst
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a968466c6ddb571ad16eb151d471fb464) TaleWorlds.CampaignSystem.Settlements.Settlement.GetFirst | | staticget |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a04838ac12b38901ff82a3971f374a363)CurrentSiegeState
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SiegeState](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a108a090c22cdef6357de70403004efea) TaleWorlds.CampaignSystem.Settlements.Settlement.CurrentSiegeState | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html#a08c1a519fd2c5bbe3b1e371fe1d76ec7)OwnerClan
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) TaleWorlds.CampaignSystem.Settlements.Settlement.OwnerClan | | get |

