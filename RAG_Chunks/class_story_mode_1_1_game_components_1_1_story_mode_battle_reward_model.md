--- SOURCE: class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html ---

StoryMode.GameComponents.StoryModeBattleRewardModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.BattleRewardModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_battle_reward_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [CalculateGoldLossAfterDefeat](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a0d6ee029ddd3ec371dcd864c0ecdb741) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) partyLeaderHero) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateInfluenceGain](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#aeeab1eecc1e5e4c903621d21ea7d0fa0) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, float influenceValueOfBattle, float contributionShare) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateMoraleChangeOnRoundVictory](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a1fcbd30cb40df81ec6aedd1ced203973) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) partySide, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) roundWinner) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateMoraleGainVictory](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#aa048600f5ad92168a019a7b09349d409) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, float renownValueOfBattle, float contributionShare, [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) battle) |
| override int | [CalculatePlunderedGoldAmountFromDefeatedParty](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#af761beedd5f6378e0f11ad46f248e034) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateRenownGain](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#aca56d917d099b74932725c17ebad0dca) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, float renownValueOfBattle, float contributionShare) |
| override float | [CalculateShipDamageAfterDefeat](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#afcb17226c2e7318e94f194610e13660e) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| override MBReadOnlyList< KeyValuePair< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > > | [DistributeDefeatedPartyShipsAmongWinners](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#afe4daf2e7fe5abc3257e52d79518b64a) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > shipsToLoot, MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| override float | [GetAITradePenalty](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a97ec41351f84c38a9563212b00dc8d43) () |
| override float | [GetBannerLootChanceFromDefeatedHero](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a624d8f9e5ab14e83449de0561d0966ee) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) defeatedHero) |
| override [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetBannerRewardForWinningMapEvent](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a57ac46a44244a73a41d83e4aed2938ac) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent) |
| override float | [GetExpectedLootedItemValueFromCasualty](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a3919360c8118f1250b0252ef21ab932a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winnerPartyLeaderHero, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) casualtyCharacter) |
| override [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) | [GetFigureheadLoot](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#ad89df50886085e2495577fe2955bef60) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > defeatedParties, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedSideLeaderParty) |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootCasualtyChances](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#aa9ba58d22a1c4451b5fda955ab724e1d) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| override [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | [GetLootedItemFromTroop](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a2929dad64a06f00ab351cbe745bb1117) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, float targetValue) |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootGoldChances](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a99cb6a244260f153dac3f3e3230d61d8) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| override MBList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootItemChancesForWinnerParties](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a94ef2dccd9b7db5b10588fa179929a85) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) defeatedParty) |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootMemberChancesForWinnerParties](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a29eb4842addc0c39334ce38b2a326ee9) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > | [GetLootPrisonerChances](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a0eda8fbcda976396ec78085d120be53f) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties, [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) prisonerElement) |
| override float | [GetMainPartyMemberScatterChance](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a8efce06a12104f0b2fd255ddc39b1ce0) () |
| override int | [GetPlayerGainedRelationAmount](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a1aca1b73e7f8b44b3cbdfda3020e960a) ([MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) mapEvent, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override float | [GetShipSiegeEngineHitMoraleEffect](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a875b19fb1530268927ab93ec6da99c87) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType) |
| override float | [GetSunkenShipMoraleEffect](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#ae86b02ec60b65dac8b7003716c060f11) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) shipOwner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| override MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | [GetWinnerPartiesThatCanPlunderGoldFromShips](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#aee025f6d62b3d838eb1cc62207d9742e) (MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > winnerParties) |
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

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a0d6ee029ddd3ec371dcd864c0ecdb741)CalculateGoldLossAfterDefeat()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModeBattleRewardModel.CalculateGoldLossAfterDefeat | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *partyLeaderHero* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#aeeab1eecc1e5e4c903621d21ea7d0fa0)CalculateInfluenceGain()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) StoryMode.GameComponents.StoryModeBattleRewardModel.CalculateInfluenceGain | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | float | *influenceValueOfBattle*, |
|  |  | float | *contributionShare* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a1fcbd30cb40df81ec6aedd1ced203973)CalculateMoraleChangeOnRoundVictory()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) StoryMode.GameComponents.StoryModeBattleRewardModel.CalculateMoraleChangeOnRoundVictory | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [MapEventSide](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_side.html) | *partySide*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *roundWinner* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#aa048600f5ad92168a019a7b09349d409)CalculateMoraleGainVictory()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) StoryMode.GameComponents.StoryModeBattleRewardModel.CalculateMoraleGainVictory | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | float | *renownValueOfBattle*, |
|  |  | float | *contributionShare*, |
|  |  | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *battle* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#af761beedd5f6378e0f11ad46f248e034)CalculatePlunderedGoldAmountFromDefeatedParty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModeBattleRewardModel.CalculatePlunderedGoldAmountFromDefeatedParty | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#aca56d917d099b74932725c17ebad0dca)CalculateRenownGain()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) StoryMode.GameComponents.StoryModeBattleRewardModel.CalculateRenownGain | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | float | *renownValueOfBattle*, |
|  |  | float | *contributionShare* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#afcb17226c2e7318e94f194610e13660e)CalculateShipDamageAfterDefeat()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeBattleRewardModel.CalculateShipDamageAfterDefeat | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#afe4daf2e7fe5abc3257e52d79518b64a)DistributeDefeatedPartyShipsAmongWinners()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override MBReadOnlyList< KeyValuePair< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html), [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > > StoryMode.GameComponents.StoryModeBattleRewardModel.DistributeDefeatedPartyShipsAmongWinners | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, |
|  |  | MBReadOnlyList< [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) > | *shipsToLoot*, |
|  |  | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a97ec41351f84c38a9563212b00dc8d43)GetAITradePenalty()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeBattleRewardModel.GetAITradePenalty | ( |  | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a624d8f9e5ab14e83449de0561d0966ee)GetBannerLootChanceFromDefeatedHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeBattleRewardModel.GetBannerLootChanceFromDefeatedHero | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *defeatedHero* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a57ac46a44244a73a41d83e4aed2938ac)GetBannerRewardForWinningMapEvent()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) StoryMode.GameComponents.StoryModeBattleRewardModel.GetBannerRewardForWinningMapEvent | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a3919360c8118f1250b0252ef21ab932a)GetExpectedLootedItemValueFromCasualty()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeBattleRewardModel.GetExpectedLootedItemValueFromCasualty | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winnerPartyLeaderHero*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *casualtyCharacter* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#ad89df50886085e2495577fe2955bef60)GetFigureheadLoot()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [Figurehead](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_figurehead.html) StoryMode.GameComponents.StoryModeBattleRewardModel.GetFigureheadLoot | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *defeatedParties*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedSideLeaderParty* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#aa9ba58d22a1c4451b5fda955ab724e1d)GetLootCasualtyChances()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > StoryMode.GameComponents.StoryModeBattleRewardModel.GetLootCasualtyChances | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a2929dad64a06f00ab351cbe745bb1117)GetLootedItemFromTroop()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) StoryMode.GameComponents.StoryModeBattleRewardModel.GetLootedItemFromTroop | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | float | *targetValue* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a99cb6a244260f153dac3f3e3230d61d8)GetLootGoldChances()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > StoryMode.GameComponents.StoryModeBattleRewardModel.GetLootGoldChances | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a94ef2dccd9b7db5b10588fa179929a85)GetLootItemChancesForWinnerParties()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override MBList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > StoryMode.GameComponents.StoryModeBattleRewardModel.GetLootItemChancesForWinnerParties | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *defeatedParty* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a29eb4842addc0c39334ce38b2a326ee9)GetLootMemberChancesForWinnerParties()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > StoryMode.GameComponents.StoryModeBattleRewardModel.GetLootMemberChancesForWinnerParties | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a0eda8fbcda976396ec78085d120be53f)GetLootPrisonerChances()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override MBReadOnlyList< KeyValuePair< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html), float > > StoryMode.GameComponents.StoryModeBattleRewardModel.GetLootPrisonerChances | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties*, |
|  |  | [TroopRosterElement](struct_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster_element.html) | *prisonerElement* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a8efce06a12104f0b2fd255ddc39b1ce0)GetMainPartyMemberScatterChance()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeBattleRewardModel.GetMainPartyMemberScatterChance | ( |  | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a1aca1b73e7f8b44b3cbdfda3020e960a)GetPlayerGainedRelationAmount()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModeBattleRewardModel.GetPlayerGainedRelationAmount | ( | [MapEvent](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event.html) | *mapEvent*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#a875b19fb1530268927ab93ec6da99c87)GetShipSiegeEngineHitMoraleEffect()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeBattleRewardModel.GetShipSiegeEngineHitMoraleEffect | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#ae86b02ec60b65dac8b7003716c060f11)GetSunkenShipMoraleEffect()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeBattleRewardModel.GetSunkenShipMoraleEffect | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *shipOwner*, |
|  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_battle_reward_model.html#aee025f6d62b3d838eb1cc62207d9742e)GetWinnerPartiesThatCanPlunderGoldFromShips()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > StoryMode.GameComponents.StoryModeBattleRewardModel.GetWinnerPartiesThatCanPlunderGoldFromShips | ( | MBReadOnlyList< [MapEventParty](class_tale_worlds_1_1_campaign_system_1_1_map_events_1_1_map_event_party.html) > | *winnerParties* | ) |  |

