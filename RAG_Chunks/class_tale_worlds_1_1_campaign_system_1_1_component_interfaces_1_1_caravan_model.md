--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultCaravanModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_caravan_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| int | [MaxNumberOfItemsToBuyFromSingleCategory](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#ac3b9f0bf3a4f8e8cec460f06d38e57db) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#a61bd76c9fe2d56c7fae32fdd6ac29050)GetMaxGoldToSpendOnOneItemCategory()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel.GetMaxGoldToSpendOnOneItemCategory | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *caravan*, | |  |  | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#a065fc3966324f23bcbaa931bcb0999b9)GetInitialTradeGold()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel.GetInitialTradeGold | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *owner*, | |  |  | bool | *isNavalCaravan*, | |  |  | bool | *eliteCaravan* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#a5416a303ac3da9c8aaa04e14fff01d05)GetCaravanFormingCost()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel.GetCaravanFormingCost | ( | bool | *eliteCaravan*, | |  |  | bool | *navalCaravan* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#a77bd67cffcb09e7c9533f67f8a553203)GetPowerChangeAfterCaravanCreation()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel.GetPowerChangeAfterCaravanCreation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *caravanParty* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#a6bb783797a9fa93df4f61c6f1eab93a0)CanHeroCreateCaravan()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel.CanHeroCreateCaravan | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#af993f34354652739398c64ce7f038e0c)GetEliteCaravanSpawnChance()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel.GetEliteCaravanSpawnChance | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_caravan_model.html#ac3b9f0bf3a4f8e8cec460f06d38e57db)MaxNumberOfItemsToBuyFromSingleCategory
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CaravanModel.MaxNumberOfItemsToBuyFromSingleCategory | | getabstract |

