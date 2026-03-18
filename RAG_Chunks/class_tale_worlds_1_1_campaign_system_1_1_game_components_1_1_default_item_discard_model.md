--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_item_discard_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultItemDiscardModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.ItemDiscardModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_item_discard_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [PlayerCanDonateItem](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_item_discard_model.html#a4f86764fc7a604f9a3f5cef8f76415b4) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| override int | [GetXpBonusForDiscardingItem](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_item_discard_model.html#a53be76c94d2ea221a6a19cfe454dd6d0) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, int amount=1) |
| override int | [GetXpBonusForDiscardingItems](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_item_discard_model.html#aafc3844109bbb1c4d247142965432ac9) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) itemRoster) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ItemDiscardModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_item_discard_model.html) | |
| int | [GetXpBonusForDiscardingItems](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_item_discard_model.html#a3c15f2941fafade6b4ed2aea84aebe1b) ([ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) itemRoster) |
| int | [GetXpBonusForDiscardingItem](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_item_discard_model.html#acd5a9729c518fc7981820dbfc745e2f0) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, int amount=1) |
| bool | [PlayerCanDonateItem](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_item_discard_model.html#acbac31031471f0b57387e2edae07abb6) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_item_discard_model.html#a4f86764fc7a604f9a3f5cef8f76415b4)PlayerCanDonateItem()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultItemDiscardModel.PlayerCanDonateItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_item_discard_model.html#a53be76c94d2ea221a6a19cfe454dd6d0)GetXpBonusForDiscardingItem()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultItemDiscardModel.GetXpBonusForDiscardingItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | int | *amount* = 1 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_item_discard_model.html#aafc3844109bbb1c4d247142965432ac9)GetXpBonusForDiscardingItems()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultItemDiscardModel.GetXpBonusForDiscardingItems | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *itemRoster* | ) |  |

