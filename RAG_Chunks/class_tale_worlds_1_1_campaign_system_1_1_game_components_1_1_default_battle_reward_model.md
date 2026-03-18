--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetPlayerGainedRelationAmount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a2fa8934193c444a71609447bd46ee00c) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateRenownGain](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a43b90ded0eeb13d301d214691d35315c) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, float renownValueOfBattle, float contributionShare) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateInfluenceGain](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#acb2a573982866b504111197cb85dca49) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, float influenceValueOfBattle, float contributionShare) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateMoraleGainVictory](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#aeca298d02a087b5a7c96209436d7d30a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, float renownValueOfBattle, float contributionShare, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) battle) |
| override int | [CalculateGoldLossAfterDefeat](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a5a3b99f0ab59a2b81e4bfc9be3132f47) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) partyLeaderHero) |
| override [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | [GetLootedItemFromTroop](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a2203983e51292d7cc8f5d22ac379e687) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, float targetValue) |
| override float | [GetExpectedLootedItemValueFromCasualty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a6332a15a20a839d2ded392c4b1039fbd) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winnerPartyLeaderHero, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) casualtyCharacter) |
| override float | [GetAITradePenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a2908c30075e7f11f6bbe083cdcc661eb) () |
| override float | [GetMainPartyMemberScatterChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a37108ec3e7ce9a579fb11d7f390c45e2) () |
| override int | [CalculatePlunderedGoldAmountFromDefeatedParty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#af11d98f232ee40c16e7866ab206e0620) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootGoldChances](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#ae22c1333dc1b200b0cdb0fb39c45c3e9) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootMemberChancesForWinnerParties](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#af89672c1a1d530aa4f7eb9769300681d) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootPrisonerChances](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a25920bfa5bef3014405c7420ce3f023a) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties, [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) prisonerElement) |
| override MBList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootItemChancesForWinnerParties](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a16129f832a2e019742ea8763b714e746) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootCasualtyChances](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#ab6276787d9b455d4e303dd8febcb88b5) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| override float | [CalculateShipDamageAfterDefeat](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#ad3d9aea4166f5cd11986c3f29e89c8aa) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| override MBReadOnlyList< KeyValuePair< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > > | [DistributeDefeatedPartyShipsAmongWinners](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#af96462d4a7668324d93efb6e871f3681) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > shipsToLoot, MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| override float | [GetBannerLootChanceFromDefeatedHero](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#aca238e00775bc399ad71049dec72959a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) defeatedHero) |
| override [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetBannerRewardForWinningMapEvent](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a966122d44df996bebdcc39086af710d8) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| override float | [GetSunkenShipMoraleEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a0acf3555984e0db6d55617ec8e4f31f8) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) shipOwner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateMoraleChangeOnRoundVictory](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a3c489bd7d52a88917524f3bf43644e40) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) partySide, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) roundWinner) |
| override float | [GetShipSiegeEngineHitMoraleEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a7e21f77ff6945bac704a8625dbec8e82) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType) |
| override [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) | [GetFigureheadLoot](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#aa44af16dba3b4da247b6feff0a92cea8) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > defeatedParties, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedSideLeaderParty) |
| override MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | [GetWinnerPartiesThatCanPlunderGoldFromShips](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#ae35669ba83934463119809a2075e5a97) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a2fa8934193c444a71609447bd46ee00c)GetPlayerGainedRelationAmount()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetPlayerGainedRelationAmount | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a43b90ded0eeb13d301d214691d35315c)CalculateRenownGain()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.CalculateRenownGain | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | float | *renownValueOfBattle*, |
|  |  | float | *contributionShare* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#acb2a573982866b504111197cb85dca49)CalculateInfluenceGain()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.CalculateInfluenceGain | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | float | *influenceValueOfBattle*, |
|  |  | float | *contributionShare* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#aeca298d02a087b5a7c96209436d7d30a)CalculateMoraleGainVictory()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.CalculateMoraleGainVictory | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | float | *renownValueOfBattle*, |
|  |  | float | *contributionShare*, |
|  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *battle* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a5a3b99f0ab59a2b81e4bfc9be3132f47)CalculateGoldLossAfterDefeat()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.CalculateGoldLossAfterDefeat | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *partyLeaderHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a2203983e51292d7cc8f5d22ac379e687)GetLootedItemFromTroop()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetLootedItemFromTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | float | *targetValue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a6332a15a20a839d2ded392c4b1039fbd)GetExpectedLootedItemValueFromCasualty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetExpectedLootedItemValueFromCasualty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winnerPartyLeaderHero*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *casualtyCharacter* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a2908c30075e7f11f6bbe083cdcc661eb)GetAITradePenalty()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetAITradePenalty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a37108ec3e7ce9a579fb11d7f390c45e2)GetMainPartyMemberScatterChance()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetMainPartyMemberScatterChance | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#af11d98f232ee40c16e7866ab206e0620)CalculatePlunderedGoldAmountFromDefeatedParty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.CalculatePlunderedGoldAmountFromDefeatedParty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#ae22c1333dc1b200b0cdb0fb39c45c3e9)GetLootGoldChances()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetLootGoldChances | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#af89672c1a1d530aa4f7eb9769300681d)GetLootMemberChancesForWinnerParties()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetLootMemberChancesForWinnerParties | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a25920bfa5bef3014405c7420ce3f023a)GetLootPrisonerChances()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetLootPrisonerChances | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties*, |
|  |  | [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) | *prisonerElement* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a16129f832a2e019742ea8763b714e746)GetLootItemChancesForWinnerParties()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override MBList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetLootItemChancesForWinnerParties | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#ab6276787d9b455d4e303dd8febcb88b5)GetLootCasualtyChances()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetLootCasualtyChances | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#ad3d9aea4166f5cd11986c3f29e89c8aa)CalculateShipDamageAfterDefeat()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.CalculateShipDamageAfterDefeat | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#af96462d4a7668324d93efb6e871f3681)DistributeDefeatedPartyShipsAmongWinners()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override MBReadOnlyList< KeyValuePair< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > > TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.DistributeDefeatedPartyShipsAmongWinners | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, |
|  |  | MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | *shipsToLoot*, |
|  |  | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#aca238e00775bc399ad71049dec72959a)GetBannerLootChanceFromDefeatedHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetBannerLootChanceFromDefeatedHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *defeatedHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a966122d44df996bebdcc39086af710d8)GetBannerRewardForWinningMapEvent()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetBannerRewardForWinningMapEvent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a0acf3555984e0db6d55617ec8e4f31f8)GetSunkenShipMoraleEffect()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetSunkenShipMoraleEffect | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *shipOwner*, |
|  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a3c489bd7d52a88917524f3bf43644e40)CalculateMoraleChangeOnRoundVictory()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.CalculateMoraleChangeOnRoundVictory | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | *partySide*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *roundWinner* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#a7e21f77ff6945bac704a8625dbec8e82)GetShipSiegeEngineHitMoraleEffect()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetShipSiegeEngineHitMoraleEffect | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#aa44af16dba3b4da247b6feff0a92cea8)GetFigureheadLoot()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetFigureheadLoot | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *defeatedParties*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedSideLeaderParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_battle_reward_model.html#ae35669ba83934463119809a2075e5a97)GetWinnerPartiesThatCanPlunderGoldFromShips()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultBattleRewardModel.GetWinnerPartiesThatCanPlunderGoldFromShips | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* | ) |  |

