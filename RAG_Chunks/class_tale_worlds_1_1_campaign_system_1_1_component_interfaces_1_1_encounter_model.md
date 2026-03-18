--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultEncounterModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_encounter_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#abe88d1506de4d09741d335cd86e3dca8)IsEncounterExemptFromHostileActions()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.IsEncounterExemptFromHostileActions | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *side1*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *side2* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#ac7780388dbfaceedecf93bade4ad3151)CanMainHeroDoParleyWithParty()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.CanMainHeroDoParleyWithParty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *partyBase*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#ae2f4d2b29f067bd3b59a0e913138124e)GetLeaderOfSiegeEvent()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.GetLeaderOfSiegeEvent | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#acf02a6bc07e71b6073fca4f99a556ddb)GetLeaderOfMapEvent()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.GetLeaderOfMapEvent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a5a6365f6840b04c6f3427f829efe7325)GetCharacterSergeantScore()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.GetCharacterSergeantScore | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#ac266c5531c80604a4e58f7435948d512)GetDefenderPartiesOfSettlement()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.GetDefenderPartiesOfSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | MapEvent.BattleTypes | *mapEventType* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a81d9c0471d03c2c55974f65d775126bc)GetNextDefenderPartyOfSettlement()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.GetNextDefenderPartyOfSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | ref int | *partyIndex*, | |  |  | MapEvent.BattleTypes | *mapEventType* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a6c69bd5d7ce12c88596de7e98bb1ed2f)CreateMapEventComponentForEncounter()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MapEventComponent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_component.html) TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.CreateMapEventComponentForEncounter | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *attackerParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defenderParty*, | |  |  | MapEvent.BattleTypes | *battleType* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a67bca0662acea55ef795f301cfbd6ced)GetBribeChance()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.GetBribeChance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *defenderParty*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a672ad126138f5e6fa5f845aaa23bfae5)GetSurrenderChance()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.GetSurrenderChance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *defenderParty*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a4d968be0f8d63e2218b8ade2e60d0db2)GetMapEventSideRunAwayChance()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.GetMapEventSideRunAwayChance | ( | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | *mapEventside* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a394237b7b4e05ae20fb24ec2a8460f7f)FindNonAttachedNpcPartiesWhoWillJoinPlayerEncounter()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.FindNonAttachedNpcPartiesWhoWillJoinPlayerEncounter | ( | List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | *partiesToJoinPlayerSide*, | |  |  | List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | *partiesToJoinEnemySide* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a0f3177d1350433e3dbbc2a7a1ee0cb9c)CanPlayerForceBanditsToJoin()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.CanPlayerForceBanditsToJoin | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a86a9da7163ad7d80a196d86ec9665c3e)IsPartyUnderPlayerCommand()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.IsPartyUnderPlayerCommand | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a24afae5eb09477811f63c99aeb921644)NeededMaximumDistanceForEncounteringMobileParty
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.NeededMaximumDistanceForEncounteringMobileParty | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a53e530fc819f975804cfefe446da4a90)MaximumAllowedDistanceForEncounteringMobilePartyInArmy
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.MaximumAllowedDistanceForEncounteringMobilePartyInArmy | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a6b3b2790929ed01e0d0730aeefd4be4d)NeededMaximumDistanceForEncounteringTown
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.NeededMaximumDistanceForEncounteringTown | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a01dcc46fb1dd1a7dbb73221e8c435f8b)NeededMaximumDistanceForEncounteringBlockade
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.NeededMaximumDistanceForEncounteringBlockade | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#abec0aa547500a8aebfaafe4cd277c6f7)NeededMaximumDistanceForEncounteringVillage
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.NeededMaximumDistanceForEncounteringVillage | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#ac348f77baf5237a6223988d63234cafc)GetEncounterJoiningRadius
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.GetEncounterJoiningRadius | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#a91d8b54ae3494e03483189b8c4ecc76b)GetSettlementBeingNearFieldBattleRadius
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.GetSettlementBeingNearFieldBattleRadius | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_encounter_model.html#af7906b7546b80a7fa2b07d71548ff3a3)PlayerParleyDistance
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.EncounterModel.PlayerParleyDistance | | getabstract |

