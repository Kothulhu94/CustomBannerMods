--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSiegeEventModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_siege_event_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a61d776658d157712eb4989959b175d15)GetSiegeEngineDestructionCasualties()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetSiegeEngineDestructionCasualties | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *destroyedSiegeEngine* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a339da1c93e3fe1e624964178dcd0799c)GetCasualtyChance()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetCasualtyChance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *siegeParty*, | |  |  | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#afed27b46596b3e33f064892038542d35)GetColleteralDamageCasualties()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetColleteralDamageCasualties | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *attackerSiegeEngine*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *attackerParty* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a65d28e251cb427659dcf4f0bb37d7c71)GetSiegeEngineHitChance()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetSiegeEngineHitChance | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, | |  |  | [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *target*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a5860b56026ec699074bcd2d92fe64b82)GetSiegeEngineMapPrefabName()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetSiegeEngineMapPrefabName | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, | |  |  | int | *wallLevel*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a252287475f208798e326fed0ca783e6a)GetSiegeEngineMapProjectilePrefabName()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetSiegeEngineMapProjectilePrefabName | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a24d2302c28c5ec69688e5c86df24e72b)GetSiegeEngineMapReloadAnimationName()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetSiegeEngineMapReloadAnimationName | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#ad36633bc35b4f166753f17ace6d0940b)GetSiegeEngineMapFireAnimationName()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetSiegeEngineMapFireAnimationName | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a47fcaa27621bbc3e08a6ffa0642ab06c)GetSiegeEngineMapProjectileBoneIndex()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | sbyte TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetSiegeEngineMapProjectileBoneIndex | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngineType*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#ab1e75ab3eb0a5dd4f4ea563b12d2f814)GetSiegeStrategyScore()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetSiegeStrategyScore | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siege*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeStrategy](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_strategy.html) | *strategy* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a20b0b4b1e7fbee8e569175604979c608)GetConstructionProgressPerHour()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetConstructionProgressPerHour | ( | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *type*, | |  |  | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *side* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#aac9487c1744bdb87b3c673399c31c3e4)GetEffectiveSiegePartyForSide()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetEffectiveSiegePartyForSide | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a2a3e011d3358bf3cc1627c4241c9969c)GetAvailableManDayPower()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetAvailableManDayPower | ( | [ISiegeEventSide](interface_tale_worlds_1_1_campaign_system_1_1_siege_1_1_i_siege_event_side.html) | *side* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a4b35c57b9cec4a9dcf1be3b896768c57)GetAvailableAttackerRangedSiegeEngines()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetAvailableAttackerRangedSiegeEngines | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a451914b4837cfa02f17cd46a5168693e)GetAvailableDefenderSiegeEngines()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetAvailableDefenderSiegeEngines | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#aa56c1f4328411faa960664f3da5a0edd)GetAvailableAttackerRamSiegeEngines()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetAvailableAttackerRamSiegeEngines | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a9ce6ec73452b63e923465fd922648d81)GetAvailableAttackerTowerSiegeEngines()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetAvailableAttackerTowerSiegeEngines | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a080a2e88d511e16fa674d2c925d43d5d)GetPrebuiltSiegeEnginesOfSettlement()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetPrebuiltSiegeEnginesOfSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a128ca65acfdb57605ab218a0df2db8a5)GetPrebuiltSiegeEnginesOfSiegeCamp()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | IEnumerable< [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetPrebuiltSiegeEnginesOfSiegeCamp | ( | [BesiegerCamp](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_besieger_camp.html) | *camp* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#add8d3f591a0afd034111af0e4d6e50ba)GetSiegeEngineHitPoints()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetSiegeEngineHitPoints | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a9147683a19752467fde2bf815383b1aa)GetRangedSiegeEngineReloadTime()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetRangedSiegeEngineReloadTime | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#a35f1e3927c9377d41868ff5d1d8698ab)GetSiegeEngineDamage()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetSiegeEngineDamage | ( | [SiegeEvent](class_tale_worlds_1_1_campaign_system_1_1_siege_1_1_siege_event.html) | *siegeEvent*, | |  |  | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide*, | |  |  | [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | *siegeEngine*, | |  |  | [SiegeBombardTargets](namespace_tale_worlds_1_1_campaign_system_1_1_siege.html#acf175cba0ae0d92d36103f5606dda4f6) | *target* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_siege_event_model.html#adc26184ad73b51e2afbb716204c6252b)GetPriorityTroopsForSallyOutAmbush()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [FlattenedTroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_flattened_troop_roster.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SiegeEventModel.GetPriorityTroopsForSallyOutAmbush | ( |  | ) |  | | abstract |

