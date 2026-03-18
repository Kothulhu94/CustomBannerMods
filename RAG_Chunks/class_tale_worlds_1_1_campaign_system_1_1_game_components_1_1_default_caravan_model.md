--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultCaravanModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetEliteCaravanSpawnChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#a370403728e9b11a824654d6387e3b802) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetPowerChangeAfterCaravanCreation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#ace11bcfe88b694c5db45173b069c201f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) caravanParty) |
| override bool | [CanHeroCreateCaravan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#acd267b66a5d3ed499a7c3256f61ca7c9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override int | [GetCaravanFormingCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#a69754bdb47fadaf5ef23c9ab820854e1) (bool largerCaravan, bool navalCaravan) |
| override int | [GetInitialTradeGold](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#ae866a438d30ea1fcae65c082105dcfc7) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, bool navalCaravan, bool largeCaravan) |
| override int | [GetMaxGoldToSpendOnOneItemCategory](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#a42c05682251b32836aca564b25212f98) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) caravan, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html) | |
| int | [GetMaxGoldToSpendOnOneItemCategory](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#a61bd76c9fe2d56c7fae32fdd6ac29050) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) caravan, [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory) |
| int | [GetInitialTradeGold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#a065fc3966324f23bcbaa931bcb0999b9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) owner, bool isNavalCaravan, bool eliteCaravan) |
| int | [GetCaravanFormingCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#a5416a303ac3da9c8aaa04e14fff01d05) (bool eliteCaravan, bool navalCaravan) |
| int | [GetPowerChangeAfterCaravanCreation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#a77bd67cffcb09e7c9533f67f8a553203) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) caravanParty) |
| bool | [CanHeroCreateCaravan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#a6bb783797a9fa93df4f61c6f1eab93a0) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| float | [GetEliteCaravanSpawnChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#af993f34354652739398c64ce7f038e0c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [MaxNumberOfItemsToBuyFromSingleCategory](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#a6ea76a531995f47e16b699d4ead906a8) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html) | |
| int | [MaxNumberOfItemsToBuyFromSingleCategory](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#ac3b9f0bf3a4f8e8cec460f06d38e57db) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#a370403728e9b11a824654d6387e3b802)GetEliteCaravanSpawnChance()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultCaravanModel.GetEliteCaravanSpawnChance | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#ace11bcfe88b694c5db45173b069c201f)GetPowerChangeAfterCaravanCreation()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCaravanModel.GetPowerChangeAfterCaravanCreation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *caravanParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#acd267b66a5d3ed499a7c3256f61ca7c9)CanHeroCreateCaravan()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultCaravanModel.CanHeroCreateCaravan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#a69754bdb47fadaf5ef23c9ab820854e1)GetCaravanFormingCost()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCaravanModel.GetCaravanFormingCost | ( | bool | *largerCaravan*, |
|  |  | bool | *navalCaravan* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#ae866a438d30ea1fcae65c082105dcfc7)GetInitialTradeGold()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCaravanModel.GetInitialTradeGold | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, |
|  |  | bool | *navalCaravan*, |
|  |  | bool | *largeCaravan* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#a42c05682251b32836aca564b25212f98)GetMaxGoldToSpendOnOneItemCategory()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCaravanModel.GetMaxGoldToSpendOnOneItemCategory | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *caravan*, |
|  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html#a6ea76a531995f47e16b699d4ead906a8)MaxNumberOfItemsToBuyFromSingleCategory
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultCaravanModel.MaxNumberOfItemsToBuyFromSingleCategory | | get |

