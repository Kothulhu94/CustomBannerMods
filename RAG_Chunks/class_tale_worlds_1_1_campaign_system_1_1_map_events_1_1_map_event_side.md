--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html ---

TaleWorlds.CampaignSystem.MapEvents.MapEventSide Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| int | [CountTroops](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ac9520887ea96263004e9b876596f3edf) (Func< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html), bool > pred) |
| int | [GetTotalHealthyTroopCountOfSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a97384f73e246150b5808f8a14bde4b0c) () |
| int | [GetTotalHealthyHeroCountOfSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#aa4aeac8cc4f0710d2e7230eff5191a27) () |
| int | [RecalculateMemberCountOfSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a364abd82181db6020a6b59dcfe9c52a3) () |
| float | [RecalculateStrengthOfSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a1c2512b327693f2cd1be0e48e0b8abac) () |
| bool | [IsMainPartyAmongParties](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#abd12c4f046d9b94225bca2833d095c33) () |
| float | [GetPlayerPartyContributionRate](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#aaa423969aaff0fb2fe19538b822101ff) () |
| void | [CalculateRenownAndInfluenceValues](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ad3d55b99aca1274fd552e43861da259a) (float[] strengthOfSide) |
| virtual void | [DistributeRenownAndInfluence](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#aca8a651d93fd385978a6a554488d1898) ([MapEventResultExplainer](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_result_explainer.html) resultExplainers=null) |
| void | [ApplyRenownAndInfluenceChanges](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#afb17e5eeada75853b7915636275ac94a) () |
| float | [GetSideMorale](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a7c121997c179a964081c90d5294486a6) () |
| void | [ApplyFinalRewardsAndChanges](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a37724e657becea9482153241d711d59e) () |
| void | [HandleMapEventEnd](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a13a00f5028ed9520ef017f0f5005130c) () |
| void | [AllocateShips](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a18a3e0a4045a123a3ac30aa17d32a3ae) () |
| void | [AllocateSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#afc492ac1343e2285379b251f1a07779c) () |
| void | [AllocateTroops](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a0f51f3d0033b2d47eb3728a8a53b9741) (ref List< [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) > troopsList, int number=-1, Func< [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), bool > customAllocationConditions=null) |
| void | [GetAllTroops](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ab49460f489e20397eedd8e5aee3ce1ed) (ref List< [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) > troopsList) |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetAllocatedTroop](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#addc3d6dc2670b4051012d9b21975023d) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDesc0) |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | [GetReadyTroop](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#afa2776f0da094097532082f5e7855bbf) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDesc0) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetAllocatedTroopParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a18e9237f1685475cdbcb1ab0e7606d82) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDescriptor) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetReadyTroopParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a85291dee529dda53ff033a766f3f37d4) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDescriptor) |
| void | [OnTroopWounded](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a4aa22506b4a121250dab6318efbaddd7) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDesc1) |
| void | [OnTroopKilled](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a78a5968f8a0fc1197cc174cc04a7d1f5) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDesc1) |
| void | [OnTroopRouted](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#af810640109645e65c7ac94e6c3af13ef) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDesc1, bool isOrderRetreat) |
| void | [OnTroopScoreHit](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a7c4f0b71f4accc17ace9ccc976e5b106) ([UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) troopDesc1, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) attackedTroop, int damage, bool isFatal, bool isTeamKill, [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) attackerWeapon, bool isSimulatedHit) |
| void | [OnShipScoreHit](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ad2f0accc8bb69d2d3906b6f284e46564) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) strikerShip, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) struckShip, [SiegeEngineType](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a3a75417498669e3fd1229222004bf19c) siegeEngine, int damage, bool isFinishingStrike) |
| void | [OnShipDamaged](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#aed7b8e1dbe7e37ff358057b204ef7226) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) struckShip, [SiegeEngineType](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a3a75417498669e3fd1229222004bf19c) siegeEngine, int damage) |
| void | [MakeReadyForSimulation](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a4d1358859344b15d46d76c916308b974) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) priorTroops, int sizeOfSide=-1) |
| void | [MakeReadyForMission](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a8a1385e3e00f4cf42ca013a979bb93fd) ([FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) priorTroops) |
| void | [EndSimulation](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a516f3aa0030f6337db03554d0b0f8bd4) () |
| [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | [ItemRosterForPlayerLootShare](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a6ef5a09ac331a87350436f4f8d830a36) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) playerParty) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [MemberRosterForPlayerLootShare](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#abadc3f43564b2eaaa184dd6902bb1f83) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) playerParty) |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | [PrisonerRosterForPlayerLootShare](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a944646d8b4f518e15ca60f7cfbf884ec) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) playerParty) |
| void | [Clear](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a56861c525835a9f6106532bda336784e) () |
| [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | [SelectRandomSimulationTroop](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a52e1d4ada12d3310d118ed49708adcf0) () |
| [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | [GetRandomSimulationSiegeEngine](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a7114bdafc2556a21aa86afc599bbdec6) () |
| [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | [GetRandomSimulationShip](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ae2a034c004253ed9935e27a03f8a684c) () |
| void | [Surrender](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a48ab417cd4352a56f39318f6124f2e27) () |
| void | [Route](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a6884f8f6fe5fb2e7ac9e38193d84176d) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [AddHeroDamage](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a7ee9d9bfc79a3262f4d5a0d6b3d36ef2) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) character, int damage) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [StrengthRatio](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a9fab37bc5b45ef9ec049ae094fc2077a) = 1.0f |
| float | [RenownValue](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a34e899edfe097862b90a0927a38b8dfa) |
| float | [InfluenceValue](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#af825f87f6fba850fbc3f128a7e70e462) |
| int | [TroopCasualties](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ac75631bf67ea949f770a25f232a6a73f) |
| int | [ShipCasualties](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a00a4172af5d392c8a17cdbed7dec3641) |
|  | [SiegeEngineType](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a3a75417498669e3fd1229222004bf19c) |

|  |  |
| --- | --- |
| Properties | |
| MBList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | [SimulationShipList](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ade7494eac7ba3009ea586ac907a32f92) = new MBList<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html)>() `[get]` |
| float | [WeightedShipCombatFactor](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a66ef857d81968bc892820983df02036d) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [LeaderParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a1138aa95ae82cf71068344c08f6133fe) `[get]` |
| MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | [Parties](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ab76224416c8ff340cda715b8f99a648a) `[get]` |
| [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | [MissionSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a94a2ba3de0ed24fb00db96c45fd977ce) `[get]` |
| int | [TroopCount](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ae9886a9111ed60fa78bb46dd988556b3) `[get]` |
| bool | [HasReadyTroops](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a07695ac902cd022f4e45c7f263928ae0) `[get]` |
| int | [NumRemainingSimulationTroops](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ab3d81abad3d51961dfb30cb60104be16) `[get]` |
| int | [NumRemainingSimulationShips](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a1501ae55caa26af6cf56d81b82623a68) `[get]` |
| int | [NumRemainingSimulationSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ae7f27e49ce80667168c6a05eb588aae9) `[get]` |
| float | [CasualtyStrength](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#aea553c07c915f3dcd6ee2890a348ca94) `[get]` |
| int | [HealthyTroopCountAtMapEventStart](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a2d8467369299979badfcdb5146a2f5d0) `[get]` |
| MapEvent | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a465eae3dc91cb82a02ad67f52f9585a4) `[get]` |
| MapEventSide | [OtherSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#abd669434bb60aec7f8ee73ee1a13d646) `[get]` |
| [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | [MapFaction](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a9a0ad374b467e22cd7d321914dfda382) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ac9520887ea96263004e9b876596f3edf)CountTroops()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.CountTroops | ( | Func< [FlattenedTroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster_element.html), bool > | *pred* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a97384f73e246150b5808f8a14bde4b0c)GetTotalHealthyTroopCountOfSide()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetTotalHealthyTroopCountOfSide | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#aa4aeac8cc4f0710d2e7230eff5191a27)GetTotalHealthyHeroCountOfSide()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetTotalHealthyHeroCountOfSide | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a364abd82181db6020a6b59dcfe9c52a3)RecalculateMemberCountOfSide()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.RecalculateMemberCountOfSide | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a1c2512b327693f2cd1be0e48e0b8abac)RecalculateStrengthOfSide()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.MapEvents.MapEventSide.RecalculateStrengthOfSide | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#abd12c4f046d9b94225bca2833d095c33)IsMainPartyAmongParties()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.MapEvents.MapEventSide.IsMainPartyAmongParties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#aaa423969aaff0fb2fe19538b822101ff)GetPlayerPartyContributionRate()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetPlayerPartyContributionRate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ad3d55b99aca1274fd552e43861da259a)CalculateRenownAndInfluenceValues()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.CalculateRenownAndInfluenceValues | ( | float[] | *strengthOfSide* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#aca8a651d93fd385978a6a554488d1898)DistributeRenownAndInfluence()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.DistributeRenownAndInfluence | ( | [MapEventResultExplainer](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_result_explainer.html) | *resultExplainers* = null | ) |  | | virtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#afb17e5eeada75853b7915636275ac94a)ApplyRenownAndInfluenceChanges()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.ApplyRenownAndInfluenceChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a7c121997c179a964081c90d5294486a6)GetSideMorale()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetSideMorale | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a37724e657becea9482153241d711d59e)ApplyFinalRewardsAndChanges()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.ApplyFinalRewardsAndChanges | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a13a00f5028ed9520ef017f0f5005130c)HandleMapEventEnd()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.HandleMapEventEnd | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a7ee9d9bfc79a3262f4d5a0d6b3d36ef2)AddHeroDamage()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.AddHeroDamage | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *character*, | |  |  | int | *damage* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a18a3e0a4045a123a3ac30aa17d32a3ae)AllocateShips()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.AllocateShips | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#afc492ac1343e2285379b251f1a07779c)AllocateSiegeEngines()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.AllocateSiegeEngines | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a0f51f3d0033b2d47eb3728a8a53b9741)AllocateTroops()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.AllocateTroops | ( | ref List< [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) > | *troopsList*, |
|  |  | int | *number* = -1, |
|  |  | Func< [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), bool > | *customAllocationConditions* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ab49460f489e20397eedd8e5aee3ce1ed)GetAllTroops()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetAllTroops | ( | ref List< [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) > | *troopsList* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#addc3d6dc2670b4051012d9b21975023d)GetAllocatedTroop()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetAllocatedTroop | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDesc0* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#afa2776f0da094097532082f5e7855bbf)GetReadyTroop()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetReadyTroop | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDesc0* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a18e9237f1685475cdbcb1ab0e7606d82)GetAllocatedTroopParty()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetAllocatedTroopParty | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDescriptor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a85291dee529dda53ff033a766f3f37d4)GetReadyTroopParty()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetReadyTroopParty | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDescriptor* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a4aa22506b4a121250dab6318efbaddd7)OnTroopWounded()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.OnTroopWounded | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDesc1* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a78a5968f8a0fc1197cc174cc04a7d1f5)OnTroopKilled()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.OnTroopKilled | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDesc1* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#af810640109645e65c7ac94e6c3af13ef)OnTroopRouted()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.OnTroopRouted | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDesc1*, |
|  |  | bool | *isOrderRetreat* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a7c4f0b71f4accc17ace9ccc976e5b106)OnTroopScoreHit()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.OnTroopScoreHit | ( | [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) | *troopDesc1*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *attackedTroop*, |
|  |  | int | *damage*, |
|  |  | bool | *isFatal*, |
|  |  | bool | *isTeamKill*, |
|  |  | [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html) | *attackerWeapon*, |
|  |  | bool | *isSimulatedHit* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ad2f0accc8bb69d2d3906b6f284e46564)OnShipScoreHit()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.OnShipScoreHit | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *strikerShip*, |
|  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *struckShip*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a3a75417498669e3fd1229222004bf19c) | *siegeEngine*, |
|  |  | int | *damage*, |
|  |  | bool | *isFinishingStrike* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#aed7b8e1dbe7e37ff358057b204ef7226)OnShipDamaged()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.OnShipDamaged | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *struckShip*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a3a75417498669e3fd1229222004bf19c) | *siegeEngine*, |
|  |  | int | *damage* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a4d1358859344b15d46d76c916308b974)MakeReadyForSimulation()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.MakeReadyForSimulation | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *priorTroops*, |
|  |  | int | *sizeOfSide* = -1 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a8a1385e3e00f4cf42ca013a979bb93fd)MakeReadyForMission()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.MakeReadyForMission | ( | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | *priorTroops* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a516f3aa0030f6337db03554d0b0f8bd4)EndSimulation()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.EndSimulation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a6ef5a09ac331a87350436f4f8d830a36)ItemRosterForPlayerLootShare()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.ItemRosterForPlayerLootShare | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *playerParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#abadc3f43564b2eaaa184dd6902bb1f83)MemberRosterForPlayerLootShare()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.MemberRosterForPlayerLootShare | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *playerParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a944646d8b4f518e15ca60f7cfbf884ec)PrisonerRosterForPlayerLootShare()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.PrisonerRosterForPlayerLootShare | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *playerParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a56861c525835a9f6106532bda336784e)Clear()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a52e1d4ada12d3310d118ed49708adcf0)SelectRandomSimulationTroop()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [UniqueTroopDescriptor](struct_tale_worlds_1_1_core_1_1_unique_troop_descriptor.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.SelectRandomSimulationTroop | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a7114bdafc2556a21aa86afc599bbdec6)GetRandomSimulationSiegeEngine()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetRandomSimulationSiegeEngine | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ae2a034c004253ed9935e27a03f8a684c)GetRandomSimulationShip()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.GetRandomSimulationShip | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a48ab417cd4352a56f39318f6124f2e27)Surrender()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.Surrender | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a6884f8f6fe5fb2e7ac9e38193d84176d)Route()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.MapEvents.MapEventSide.Route | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a9fab37bc5b45ef9ec049ae094fc2077a)StrengthRatio
--------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.MapEvents.MapEventSide.StrengthRatio = 1.0f |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a34e899edfe097862b90a0927a38b8dfa)RenownValue
------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.MapEvents.MapEventSide.RenownValue |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#af825f87f6fba850fbc3f128a7e70e462)InfluenceValue
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.MapEvents.MapEventSide.InfluenceValue |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ac75631bf67ea949f770a25f232a6a73f)TroopCasualties
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.TroopCasualties |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a00a4172af5d392c8a17cdbed7dec3641)ShipCasualties
---------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.ShipCasualties |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a3a75417498669e3fd1229222004bf19c)SiegeEngineType
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| TaleWorlds.CampaignSystem.MapEvents.MapEventSide.SiegeEngineType |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ade7494eac7ba3009ea586ac907a32f92)SimulationShipList
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBList<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html)> TaleWorlds.CampaignSystem.MapEvents.MapEventSide.SimulationShipList = new MBList<[Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html)>() | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a66ef857d81968bc892820983df02036d)WeightedShipCombatFactor
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.MapEvents.MapEventSide.WeightedShipCombatFactor | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a1138aa95ae82cf71068344c08f6133fe)LeaderParty
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.LeaderParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ab76224416c8ff340cda715b8f99a648a)Parties
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html)> TaleWorlds.CampaignSystem.MapEvents.MapEventSide.Parties | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a94a2ba3de0ed24fb00db96c45fd977ce)MissionSide
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.MissionSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ae9886a9111ed60fa78bb46dd988556b3)TroopCount
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.TroopCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a07695ac902cd022f4e45c7f263928ae0)HasReadyTroops
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.MapEvents.MapEventSide.HasReadyTroops | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ab3d81abad3d51961dfb30cb60104be16)NumRemainingSimulationTroops
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.NumRemainingSimulationTroops | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a1501ae55caa26af6cf56d81b82623a68)NumRemainingSimulationShips
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.NumRemainingSimulationShips | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#ae7f27e49ce80667168c6a05eb588aae9)NumRemainingSimulationSiegeEngines
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.NumRemainingSimulationSiegeEngines | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#aea553c07c915f3dcd6ee2890a348ca94)CasualtyStrength
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.MapEvents.MapEventSide.CasualtyStrength | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a2d8467369299979badfcdb5146a2f5d0)HealthyTroopCountAtMapEventStart
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.MapEvents.MapEventSide.HealthyTroopCountAtMapEventStart | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a465eae3dc91cb82a02ad67f52f9585a4)MapEvent
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapEvent TaleWorlds.CampaignSystem.MapEvents.MapEventSide.MapEvent | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#abd669434bb60aec7f8ee73ee1a13d646)OtherSide
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MapEventSide TaleWorlds.CampaignSystem.MapEvents.MapEventSide.OtherSide | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html#a9a0ad374b467e22cd7d321914dfda382)MapFaction
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) TaleWorlds.CampaignSystem.MapEvents.MapEventSide.MapFaction | | get |

