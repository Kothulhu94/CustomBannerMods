--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PartyFoodBuyingModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultPartyFoodBuyingModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_food_buying_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [FindItemToBuy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#ad28b8e615b6eca19fc1097ba7c108a80) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) itemRosterElement, out float itemElementsPrice) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| float | [MinimumDaysFoodToLastWhileBuyingFoodFromTown](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#a2897b3974ec00a5e23fb921343f721d3) `[get]` |
| float | [MinimumDaysFoodToLastWhileBuyingFoodFromVillage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#abb987f40f935809e67fa22b9014980f3) `[get]` |
| float | [LowCostFoodPriceAverage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#aa850b066fa178fe27492f9a37d91e008) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#ad28b8e615b6eca19fc1097ba7c108a80)FindItemToBuy()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.PartyFoodBuyingModel.FindItemToBuy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | out [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *itemRosterElement*, | |  |  | out float | *itemElementsPrice* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#a2897b3974ec00a5e23fb921343f721d3)MinimumDaysFoodToLastWhileBuyingFoodFromTown
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyFoodBuyingModel.MinimumDaysFoodToLastWhileBuyingFoodFromTown | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#abb987f40f935809e67fa22b9014980f3)MinimumDaysFoodToLastWhileBuyingFoodFromVillage
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyFoodBuyingModel.MinimumDaysFoodToLastWhileBuyingFoodFromVillage | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_food_buying_model.html#aa850b066fa178fe27492f9a37d91e008)LowCostFoodPriceAverage
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyFoodBuyingModel.LowCostFoodPriceAverage | | getabstract |

