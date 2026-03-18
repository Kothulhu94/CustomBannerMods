--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [IsEncounterExemptFromHostileActions](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a1c5241121ddbb611afbdd38260059356) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) side1, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) side2) |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetLeaderOfSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a810c2a1c7800098f2f1d7631ef85da14) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| override bool | [CanMainHeroDoParleyWithParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#ae380af684e0e40de8ae6beb740d1e4f4) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetLeaderOfMapEvent](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#acc7ed4a2a8a813d4517aca2f1802d33b) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| override int | [GetCharacterSergeantScore](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#aa3a0942e62d0f8c44075e9f1147b4bab) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [GetDefenderPartiesOfSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#ad835b595d01f2548b1331e6030b20308) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) mapEventType) |
| override [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetNextDefenderPartyOfSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a530ac0fc7b06029338885fd9978c90cc) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, ref int partyIndex, [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) mapEventType) |
| override [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | [CreateMapEventComponentForEncounter](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#ad414f29e797d56149004034f51815e8d) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty, [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) battleType) |
| override float | [GetSurrenderChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a65c68ac96f4cf2f2f639932e6c3d46f6) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) defenderParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetBribeChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a0e3cf16a6936f6f42e12a083a4aadfc5) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) defenderParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty) |
| override float | [GetMapEventSideRunAwayChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a06d04c5a108b04dc5328e633d3ffcd26) ([MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) mapEventSide) |
| override void | [FindNonAttachedNpcPartiesWhoWillJoinPlayerEncounter](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a9f9cc32e43b8ee07baccba0c4225b663) (List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > partiesToJoinPlayerSide, List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > partiesToJoinEnemySide) |
|  | Populates the lists for each side only with base mobile parties - excluding their attached parties. Nearby party search does not include main party. |
| override bool | [CanPlayerForceBanditsToJoin](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a3b8f17f723a3123b8acaeda136c5259b) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| override bool | [IsPartyUnderPlayerCommand](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a718cf079e25fa446c5d31337a0431df7) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html) | |
| bool | [IsEncounterExemptFromHostileActions](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#abe88d1506de4d09741d335cd86e3dca8) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) side1, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) side2) |
| bool | [CanMainHeroDoParleyWithParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#ac7780388dbfaceedecf93bade4ad3151) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) partyBase, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetLeaderOfSiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#ae2f4d2b29f067bd3b59a0e913138124e) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetLeaderOfMapEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#acf02a6bc07e71b6073fca4f99a556ddb) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| int | [GetCharacterSergeantScore](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a5a6365f6840b04c6f3427f829efe7325) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > | [GetDefenderPartiesOfSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#ac266c5531c80604a4e58f7435948d512) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, MapEvent.BattleTypes mapEventType) |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [GetNextDefenderPartyOfSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a81d9c0471d03c2c55974f65d775126bc) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, ref int partyIndex, MapEvent.BattleTypes mapEventType) |
| [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) | [CreateMapEventComponentForEncounter](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a6c69bd5d7ce12c88596de7e98bb1ed2f) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) attackerParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defenderParty, MapEvent.BattleTypes battleType) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetBribeChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a67bca0662acea55ef795f301cfbd6ced) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) defenderParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty) |
| float | [GetSurrenderChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a672ad126138f5e6fa5f845aaa23bfae5) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) defenderParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty) |
| float | [GetMapEventSideRunAwayChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a4d968be0f8d63e2218b8ade2e60d0db2) ([MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) mapEventside) |
| void | [FindNonAttachedNpcPartiesWhoWillJoinPlayerEncounter](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a394237b7b4e05ae20fb24ec2a8460f7f) (List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > partiesToJoinPlayerSide, List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > partiesToJoinEnemySide) |
| bool | [CanPlayerForceBanditsToJoin](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a0f3177d1350433e3dbbc2a7a1ee0cb9c) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| bool | [IsPartyUnderPlayerCommand](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a86a9da7163ad7d80a196d86ec9665c3e) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override float | [NeededMaximumDistanceForEncounteringMobileParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#ab0158bac454a6dbe5d134e2df36996cc) `[get]` |
| override float | [MaximumAllowedDistanceForEncounteringMobilePartyInArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a5a8ced2e38aece97bbfce3697b791483) `[get]` |
| override float | [NeededMaximumDistanceForEncounteringTown](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#adcfb13eeee5800082e6fafeb3e8647aa) `[get]` |
| override float | [NeededMaximumDistanceForEncounteringBlockade](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#aac2a3300a56630596cf3c56dc5e868a3) `[get]` |
| override float | [NeededMaximumDistanceForEncounteringVillage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#ae13bd77ddbb31200ee7f238d718c3877) `[get]` |
| override float | [GetEncounterJoiningRadius](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a2aadea9a27d8cdcf675ff1c859c09489) `[get]` |
| override float | [PlayerParleyDistance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#aaf8d19b1f26d9482484ef8145b752c2d) `[get]` |
| override float | [GetSettlementBeingNearFieldBattleRadius](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#aac723e9d80039ec0dd655981cbfa71f1) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html) | |
| float | [NeededMaximumDistanceForEncounteringMobileParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a24afae5eb09477811f63c99aeb921644) `[get]` |
| float | [MaximumAllowedDistanceForEncounteringMobilePartyInArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a53e530fc819f975804cfefe446da4a90) `[get]` |
| float | [NeededMaximumDistanceForEncounteringTown](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a6b3b2790929ed01e0d0730aeefd4be4d) `[get]` |
| float | [NeededMaximumDistanceForEncounteringBlockade](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a01dcc46fb1dd1a7dbb73221e8c435f8b) `[get]` |
| float | [NeededMaximumDistanceForEncounteringVillage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#abec0aa547500a8aebfaafe4cd277c6f7) `[get]` |
| float | [GetEncounterJoiningRadius](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#ac348f77baf5237a6223988d63234cafc) `[get]` |
| float | [GetSettlementBeingNearFieldBattleRadius](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a91d8b54ae3494e03483189b8c4ecc76b) `[get]` |
| float | [PlayerParleyDistance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#af7906b7546b80a7fa2b07d71548ff3a3) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a1c5241121ddbb611afbdd38260059356)IsEncounterExemptFromHostileActions()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.IsEncounterExemptFromHostileActions | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *side1*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *side2* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a810c2a1c7800098f2f1d7631ef85da14)GetLeaderOfSiegeEvent()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.GetLeaderOfSiegeEvent | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#ae380af684e0e40de8ae6beb740d1e4f4)CanMainHeroDoParleyWithParty()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.CanMainHeroDoParleyWithParty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#acc7ed4a2a8a813d4517aca2f1802d33b)GetLeaderOfMapEvent()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.GetLeaderOfMapEvent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#aa3a0942e62d0f8c44075e9f1147b4bab)GetCharacterSergeantScore()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.GetCharacterSergeantScore | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#ad835b595d01f2548b1331e6030b20308)GetDefenderPartiesOfSettlement()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.GetDefenderPartiesOfSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) | *mapEventType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a530ac0fc7b06029338885fd9978c90cc)GetNextDefenderPartyOfSettlement()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.GetNextDefenderPartyOfSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | ref int | *partyIndex*, |
|  |  | [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) | *mapEventType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#ad414f29e797d56149004034f51815e8d)CreateMapEventComponentForEncounter()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.CreateMapEventComponentForEncounter | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty*, |
|  |  | [MapEvent.BattleTypes](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html#a8273b0743d73bead9a7782312d488851) | *battleType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a65c68ac96f4cf2f2f639932e6c3d46f6)GetSurrenderChance()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.GetSurrenderChance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *defenderParty*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a0e3cf16a6936f6f42e12a083a4aadfc5)GetBribeChance()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.GetBribeChance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *defenderParty*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a06d04c5a108b04dc5328e633d3ffcd26)GetMapEventSideRunAwayChance()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.GetMapEventSideRunAwayChance | ( | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | *mapEventSide* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a9f9cc32e43b8ee07baccba0c4225b663)FindNonAttachedNpcPartiesWhoWillJoinPlayerEncounter()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.FindNonAttachedNpcPartiesWhoWillJoinPlayerEncounter | ( | List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | *partiesToJoinPlayerSide*, |
|  |  | List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | *partiesToJoinEnemySide* ) |

Parameters
:   |  |  |
    | --- | --- |
    | partiesToJoinPlayerSide | Returns all non-attached ally parties in map event including nearby ones that will join |
    | partiesToJoinEnemySide | Returns all non-attached enemy parties in map event including nearby ones that will join |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a3b8f17f723a3123b8acaeda136c5259b)CanPlayerForceBanditsToJoin()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.CanPlayerForceBanditsToJoin | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a718cf079e25fa446c5d31337a0431df7)IsPartyUnderPlayerCommand()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.IsPartyUnderPlayerCommand | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#ab0158bac454a6dbe5d134e2df36996cc)NeededMaximumDistanceForEncounteringMobileParty
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.NeededMaximumDistanceForEncounteringMobileParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a5a8ced2e38aece97bbfce3697b791483)MaximumAllowedDistanceForEncounteringMobilePartyInArmy
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.MaximumAllowedDistanceForEncounteringMobilePartyInArmy | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#adcfb13eeee5800082e6fafeb3e8647aa)NeededMaximumDistanceForEncounteringTown
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.NeededMaximumDistanceForEncounteringTown | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#aac2a3300a56630596cf3c56dc5e868a3)NeededMaximumDistanceForEncounteringBlockade
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.NeededMaximumDistanceForEncounteringBlockade | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#ae13bd77ddbb31200ee7f238d718c3877)NeededMaximumDistanceForEncounteringVillage
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.NeededMaximumDistanceForEncounteringVillage | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#a2aadea9a27d8cdcf675ff1c859c09489)GetEncounterJoiningRadius
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.GetEncounterJoiningRadius | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#aaf8d19b1f26d9482484ef8145b752c2d)PlayerParleyDistance
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.PlayerParleyDistance | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html#aac723e9d80039ec0dd655981cbfa71f1)GetSettlementBeingNearFieldBattleRadius
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel.GetSettlementBeingNearFieldBattleRadius | | get |

