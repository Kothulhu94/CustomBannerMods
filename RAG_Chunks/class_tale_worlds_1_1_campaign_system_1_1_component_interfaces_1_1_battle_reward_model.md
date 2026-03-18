--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [StoryMode.GameComponents.StoryModeBattleRewardModel](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html), and [TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetBannerLootChanceFromDefeatedHero](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a1a9f7fdffc7265489f9e2dff157249d8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) defeatedHero) |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetBannerRewardForWinningMapEvent](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a2d0015da49af0ec0c7e23cdb94beb7fa) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| int | [GetPlayerGainedRelationAmount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a5ffee904cb270f9bfb49b7f8dda57088) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateRenownGain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a0a1d5e347ec772e453ad79ced54c55d8) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, float renownValueOfBattle, float contributionShare) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateInfluenceGain](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#afbfd1fdc69557053777c449cad3c3182) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, float influenceValueOfBattle, float contributionShare) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateMoraleGainVictory](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a81c685024438aa7495adb1605ee0d0d2) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, float renownValueOfBattle, float contributionShare, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) battle) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateMoraleChangeOnRoundVictory](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a7cdc0911af28ea1ab08033721b9df5e7) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) partySide, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) roundWinner) |
| int | [CalculateGoldLossAfterDefeat](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a166dfe657f91e14863be9074596853aa) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) partyLeaderHero) |
| [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | [GetLootedItemFromTroop](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a40b934c8fb50416a7f66afc18b0f0334) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, float targetValue) |
| float | [GetExpectedLootedItemValueFromCasualty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a4e8cd9cbe5957c47a0cb29b75482cb70) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winnerPartyLeaderHero, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) casualtyCharacter) |
| int | [CalculatePlunderedGoldAmountFromDefeatedParty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a9e7035534e33b5a2018508f6093af7b3) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootGoldChances](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a10be730b2c95cae86792eaf61c8d4b5b) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| float | [GetMainPartyMemberScatterChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a9652cd9f49f1680e117eb2fd02fb480d) () |
| float | [GetAITradePenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a3af923b034a227724b4c6575c2a2fdbe) () |
| MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootMemberChancesForWinnerParties](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a6c24c67f33dd9bc97b67179d57a8e230) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootPrisonerChances](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a0b8be9b2a0ecf159e6eee415ccbf6d75) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties, [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) prisonerElement) |
| MBList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootItemChancesForWinnerParties](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a8017acb7ebe198f752fb9bb8462cc567) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootCasualtyChances](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a139a08d86674686d9366deba547d3044) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| float | [CalculateShipDamageAfterDefeat](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#ac4ef7211a74e9ef4385c7c86b0597e59) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| MBReadOnlyList< KeyValuePair< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > > | [DistributeDefeatedPartyShipsAmongWinners](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a77e4307c55aeaab3680cdff8c6969ee3) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > shipsToLoot, MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| float | [GetSunkenShipMoraleEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#ae3f6e32a87287590d4fcfe3182878da2) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) shipOwner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| float | [GetShipSiegeEngineHitMoraleEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a4a1df2cf4448025215f0c1267709b5c6) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType) |
| [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) | [GetFigureheadLoot](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#adafc662c2eceae7e4c2a537c5016fc2b) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > defeatedParties, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedSideLeaderParty) |
| MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | [GetWinnerPartiesThatCanPlunderGoldFromShips](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a23b4aa9f7441a047bf1163eb4e81d447) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a1a9f7fdffc7265489f9e2dff157249d8)GetBannerLootChanceFromDefeatedHero()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetBannerLootChanceFromDefeatedHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *defeatedHero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a2d0015da49af0ec0c7e23cdb94beb7fa)GetBannerRewardForWinningMapEvent()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetBannerRewardForWinningMapEvent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a5ffee904cb270f9bfb49b7f8dda57088)GetPlayerGainedRelationAmount()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetPlayerGainedRelationAmount | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a0a1d5e347ec772e453ad79ced54c55d8)CalculateRenownGain()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.CalculateRenownGain | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | float | *renownValueOfBattle*, | |  |  | float | *contributionShare* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#afbfd1fdc69557053777c449cad3c3182)CalculateInfluenceGain()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.CalculateInfluenceGain | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | float | *influenceValueOfBattle*, | |  |  | float | *contributionShare* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a81c685024438aa7495adb1605ee0d0d2)CalculateMoraleGainVictory()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.CalculateMoraleGainVictory | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | float | *renownValueOfBattle*, | |  |  | float | *contributionShare*, | |  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *battle* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a7cdc0911af28ea1ab08033721b9df5e7)CalculateMoraleChangeOnRoundVictory()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.CalculateMoraleChangeOnRoundVictory | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | *partySide*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *roundWinner* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a166dfe657f91e14863be9074596853aa)CalculateGoldLossAfterDefeat()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.CalculateGoldLossAfterDefeat | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *partyLeaderHero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a40b934c8fb50416a7f66afc18b0f0334)GetLootedItemFromTroop()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetLootedItemFromTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | float | *targetValue* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a4e8cd9cbe5957c47a0cb29b75482cb70)GetExpectedLootedItemValueFromCasualty()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetExpectedLootedItemValueFromCasualty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winnerPartyLeaderHero*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *casualtyCharacter* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a9e7035534e33b5a2018508f6093af7b3)CalculatePlunderedGoldAmountFromDefeatedParty()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.CalculatePlunderedGoldAmountFromDefeatedParty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a10be730b2c95cae86792eaf61c8d4b5b)GetLootGoldChances()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetLootGoldChances | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a9652cd9f49f1680e117eb2fd02fb480d)GetMainPartyMemberScatterChance()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetMainPartyMemberScatterChance | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a3af923b034a227724b4c6575c2a2fdbe)GetAITradePenalty()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetAITradePenalty | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a6c24c67f33dd9bc97b67179d57a8e230)GetLootMemberChancesForWinnerParties()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetLootMemberChancesForWinnerParties | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a0b8be9b2a0ecf159e6eee415ccbf6d75)GetLootPrisonerChances()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetLootPrisonerChances | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties*, | |  |  | [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) | *prisonerElement* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a8017acb7ebe198f752fb9bb8462cc567)GetLootItemChancesForWinnerParties()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetLootItemChancesForWinnerParties | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a139a08d86674686d9366deba547d3044)GetLootCasualtyChances()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetLootCasualtyChances | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#ac4ef7211a74e9ef4385c7c86b0597e59)CalculateShipDamageAfterDefeat()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.CalculateShipDamageAfterDefeat | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a77e4307c55aeaab3680cdff8c6969ee3)DistributeDefeatedPartyShipsAmongWinners()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBReadOnlyList< KeyValuePair< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > > TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.DistributeDefeatedPartyShipsAmongWinners | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, | |  |  | MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | *shipsToLoot*, | |  |  | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#ae3f6e32a87287590d4fcfe3182878da2)GetSunkenShipMoraleEffect()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetSunkenShipMoraleEffect | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *shipOwner*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a4a1df2cf4448025215f0c1267709b5c6)GetShipSiegeEngineHitMoraleEffect()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetShipSiegeEngineHitMoraleEffect | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#adafc662c2eceae7e4c2a537c5016fc2b)GetFigureheadLoot()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetFigureheadLoot | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *defeatedParties*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedSideLeaderParty* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html#a23b4aa9f7441a047bf1163eb4e81d447)GetWinnerPartiesThatCanPlunderGoldFromShips()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel.GetWinnerPartiesThatCanPlunderGoldFromShips | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* | ) |  | | abstract |

