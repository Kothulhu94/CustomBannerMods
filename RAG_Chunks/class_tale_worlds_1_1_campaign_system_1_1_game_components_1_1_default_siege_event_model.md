--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override string | [GetSiegeEngineMapPrefabName](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a35a66d99eba7c6905563daa083064b2d) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) type, int wallLevel, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| override string | [GetSiegeEngineMapProjectilePrefabName](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a7e32ff5c9e273965295259e7f7a7081f) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) type) |
| override string | [GetSiegeEngineMapReloadAnimationName](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a0dbc7c3f847d05a2c99debb70be96e27) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) type, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| override string | [GetSiegeEngineMapFireAnimationName](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#abbbf737654ac7df096d8bbcfa8dcbdb7) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) type, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| override sbyte | [GetSiegeEngineMapProjectileBoneIndex](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#aaf7a3850afd419ff53d244a38f2bc29a) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) type, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| override [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [GetEffectiveSiegePartyForSide](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a6a0087a3022546282d6dc90cf17d1359) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| override float | [GetCasualtyChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a67328aa6e34e7591ad15c7cced5d034a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) siegeParty, [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| override int | [GetSiegeEngineDestructionCasualties](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#ad4a525b12513a0ba1f69360a7c18f577) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) destroyedSiegeEngine) |
| override int | [GetColleteralDamageCasualties](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a697b7873a62021ce8036653ec9caa957) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override float | [GetSiegeEngineHitChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#afce31e42fe733d0999226ed203fea9cc) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) target, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override float | [GetSiegeStrategyScore](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#ae7b831844dcb451b377913779763fd1d) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siege, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_strategy.html) strategy) |
| override float | [GetConstructionProgressPerHour](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a4bb685af7630384e25cf8475b5ad8858) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) type, [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) side) |
| override float | [GetAvailableManDayPower](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a32580a955b93a182835e15458413f272) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) side) |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetPrebuiltSiegeEnginesOfSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a0c3f1bc4ba5a32e794317528c9758d3a) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetPrebuiltSiegeEnginesOfSiegeCamp](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a52ee1457a9d4c1a95928209af26dd99f) ([BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html) besiegerCamp) |
| override float | [GetSiegeEngineHitPoints](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a8bdd746120ef709884f366b1fcb501ee) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| override float | [GetSiegeEngineDamage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a28823cf780e6b6fc1244a5851ab79298) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) target) |
| override int | [GetRangedSiegeEngineReloadTime](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a073cc5814aff6d7285299e66cbb7d6d0) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine) |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetAvailableAttackerRangedSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a91e5d424b5be400d4bb5a39b9c06f34f) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetAvailableDefenderSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#afa868da4f5a445753140e755dbe4abe9) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetAvailableAttackerRamSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a60f1f03496564821cdafdfde2f8c64bd) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetAvailableAttackerTowerSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a630d16a099a67e63ba57c3fa5ef4c8b5) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | [GetPriorityTroopsForSallyOutAmbush](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a24ce15ce30a3d37171ec151e1d9a6bdc) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html) | |
| int | [GetSiegeEngineDestructionCasualties](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a61d776658d157712eb4989959b175d15) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) destroyedSiegeEngine) |
| float | [GetCasualtyChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a339da1c93e3fe1e624964178dcd0799c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) siegeParty, [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| int | [GetColleteralDamageCasualties](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#afed27b46596b3e33f064892038542d35) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) attackerSiegeEngine, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) attackerParty) |
| float | [GetSiegeEngineHitChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a65d28e251cb427659dcf4f0bb37d7c71) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) target, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| string | [GetSiegeEngineMapPrefabName](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a5860b56026ec699074bcd2d92fe64b82) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, int wallLevel, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| string | [GetSiegeEngineMapProjectilePrefabName](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a252287475f208798e326fed0ca783e6a) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType) |
| string | [GetSiegeEngineMapReloadAnimationName](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a24d2302c28c5ec69688e5c86df24e72b) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| string | [GetSiegeEngineMapFireAnimationName](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#ad36633bc35b4f166753f17ace6d0940b) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| sbyte | [GetSiegeEngineMapProjectileBoneIndex](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a47fcaa27621bbc3e08a6ffa0642ab06c) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngineType, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| float | [GetSiegeStrategyScore](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#ab1e75ab3eb0a5dd4f4ea563b12d2f814) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siege, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_strategy.html) strategy) |
| float | [GetConstructionProgressPerHour](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a20b0b4b1e7fbee8e569175604979c608) ([SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) type, [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) side) |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [GetEffectiveSiegePartyForSide](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#aac9487c1744bdb87b3c673399c31c3e4) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side) |
| float | [GetAvailableManDayPower](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a2a3e011d3358bf3cc1627c4241c9969c) ([ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) side) |
| IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetAvailableAttackerRangedSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a4b35c57b9cec4a9dcf1be3b896768c57) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetAvailableDefenderSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a451914b4837cfa02f17cd46a5168693e) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetAvailableAttackerRamSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#aa56c1f4328411faa960664f3da5a0edd) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetAvailableAttackerTowerSiegeEngines](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a9ce6ec73452b63e923465fd922648d81) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetPrebuiltSiegeEnginesOfSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a080a2e88d511e16fa674d2c925d43d5d) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > | [GetPrebuiltSiegeEnginesOfSiegeCamp](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a128ca65acfdb57605ab218a0df2db8a5) ([BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html) camp) |
| float | [GetSiegeEngineHitPoints](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#add8d3f591a0afd034111af0e4d6e50ba) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| int | [GetRangedSiegeEngineReloadTime](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a9147683a19752467fde2bf815383b1aa) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine) |
| float | [GetSiegeEngineDamage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a35f1e3927c9377d41868ff5d1d8698ab) ([SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) siegeEvent, [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide, [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) siegeEngine, [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) target) |
| [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) | [GetPriorityTroopsForSallyOutAmbush](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#adc26184ad73b51e2afbb716204c6252b) () |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a35a66d99eba7c6905563daa083064b2d)GetSiegeEngineMapPrefabName()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetSiegeEngineMapPrefabName | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *type*, |
|  |  | int | *wallLevel*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a7e32ff5c9e273965295259e7f7a7081f)GetSiegeEngineMapProjectilePrefabName()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetSiegeEngineMapProjectilePrefabName | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *type* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a0dbc7c3f847d05a2c99debb70be96e27)GetSiegeEngineMapReloadAnimationName()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetSiegeEngineMapReloadAnimationName | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *type*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#abbbf737654ac7df096d8bbcfa8dcbdb7)GetSiegeEngineMapFireAnimationName()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetSiegeEngineMapFireAnimationName | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *type*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#aaf7a3850afd419ff53d244a38f2bc29a)GetSiegeEngineMapProjectileBoneIndex()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override sbyte TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetSiegeEngineMapProjectileBoneIndex | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *type*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a6a0087a3022546282d6dc90cf17d1359)GetEffectiveSiegePartyForSide()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetEffectiveSiegePartyForSide | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a67328aa6e34e7591ad15c7cced5d034a)GetCasualtyChance()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetCasualtyChance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *siegeParty*, |
|  |  | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#ad4a525b12513a0ba1f69360a7c18f577)GetSiegeEngineDestructionCasualties()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetSiegeEngineDestructionCasualties | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *destroyedSiegeEngine* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a697b7873a62021ce8036653ec9caa957)GetColleteralDamageCasualties()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetColleteralDamageCasualties | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#afce31e42fe733d0999226ed203fea9cc)GetSiegeEngineHitChance()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetSiegeEngineHitChance | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, |
|  |  | [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *target*, |
|  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#ae7b831844dcb451b377913779763fd1d)GetSiegeStrategyScore()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetSiegeStrategyScore | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siege*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [SiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_strategy.html) | *strategy* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a4bb685af7630384e25cf8475b5ad8858)GetConstructionProgressPerHour()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetConstructionProgressPerHour | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *type*, |
|  |  | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, |
|  |  | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *side* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a32580a955b93a182835e15458413f272)GetAvailableManDayPower()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetAvailableManDayPower | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *side* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a0c3f1bc4ba5a32e794317528c9758d3a)GetPrebuiltSiegeEnginesOfSettlement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetPrebuiltSiegeEnginesOfSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a52ee1457a9d4c1a95928209af26dd99f)GetPrebuiltSiegeEnginesOfSiegeCamp()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetPrebuiltSiegeEnginesOfSiegeCamp | ( | [BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html) | *besiegerCamp* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a8bdd746120ef709884f366b1fcb501ee)GetSiegeEngineHitPoints()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetSiegeEngineHitPoints | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a28823cf780e6b6fc1244a5851ab79298)GetSiegeEngineDamage()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetSiegeEngineDamage | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, |
|  |  | [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *target* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a073cc5814aff6d7285299e66cbb7d6d0)GetRangedSiegeEngineReloadTime()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetRangedSiegeEngineReloadTime | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, |
|  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a91e5d424b5be400d4bb5a39b9c06f34f)GetAvailableAttackerRangedSiegeEngines()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetAvailableAttackerRangedSiegeEngines | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#afa868da4f5a445753140e755dbe4abe9)GetAvailableDefenderSiegeEngines()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetAvailableDefenderSiegeEngines | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a60f1f03496564821cdafdfde2f8c64bd)GetAvailableAttackerRamSiegeEngines()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetAvailableAttackerRamSiegeEngines | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a630d16a099a67e63ba57c3fa5ef4c8b5)GetAvailableAttackerTowerSiegeEngines()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetAvailableAttackerTowerSiegeEngines | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html#a24ce15ce30a3d37171ec151e1d9a6bdc)GetPriorityTroopsForSallyOutAmbush()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel.GetPriorityTroopsForSallyOutAmbush | ( |  | ) |  |

