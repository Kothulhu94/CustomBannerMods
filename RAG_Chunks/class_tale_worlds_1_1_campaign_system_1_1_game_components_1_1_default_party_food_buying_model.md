--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_food_buying_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPartyFoodBuyingModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyFoodBuyingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [FindItemToBuy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_food_buying_model.html#a2a5a8c1cb76847ce78484a863f677350) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemElement, out float itemElementsPrice) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyFoodBuyingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html) | |
| void | [FindItemToBuy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#ad28b8e615b6eca19fc1097ba7c108a80) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, out float itemElementsPrice) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override float | [MinimumDaysFoodToLastWhileBuyingFoodFromTown](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_food_buying_model.html#a2c4a8778d79efb889c8160201d2492f7) `[get]` |
| override float | [MinimumDaysFoodToLastWhileBuyingFoodFromVillage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_food_buying_model.html#aa1f672c229b9482ed4c165b7fa5248f7) `[get]` |
| override float | [LowCostFoodPriceAverage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_food_buying_model.html#a72b5be9159f3a68b2f8213cc506176b0) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyFoodBuyingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html) | |
| float | [MinimumDaysFoodToLastWhileBuyingFoodFromTown](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#a2897b3974ec00a5e23fb921343f721d3) `[get]` |
| float | [MinimumDaysFoodToLastWhileBuyingFoodFromVillage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#abb987f40f935809e67fa22b9014980f3) `[get]` |
| float | [LowCostFoodPriceAverage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#aa850b066fa178fe27492f9a37d91e008) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_food_buying_model.html#a2a5a8c1cb76847ce78484a863f677350)FindItemToBuy()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultPartyFoodBuyingModel.FindItemToBuy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | out [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemElement*, |
|  |  | out float | *itemElementsPrice* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_food_buying_model.html#a2c4a8778d79efb889c8160201d2492f7)MinimumDaysFoodToLastWhileBuyingFoodFromTown
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyFoodBuyingModel.MinimumDaysFoodToLastWhileBuyingFoodFromTown | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_food_buying_model.html#aa1f672c229b9482ed4c165b7fa5248f7)MinimumDaysFoodToLastWhileBuyingFoodFromVillage
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyFoodBuyingModel.MinimumDaysFoodToLastWhileBuyingFoodFromVillage | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_food_buying_model.html#a72b5be9159f3a68b2f8213cc506176b0)LowCostFoodPriceAverage
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultPartyFoodBuyingModel.LowCostFoodPriceAverage | | get |

