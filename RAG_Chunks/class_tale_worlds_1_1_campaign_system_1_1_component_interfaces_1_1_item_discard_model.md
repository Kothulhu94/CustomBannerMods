--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_item_discard_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.ItemDiscardModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultItemDiscardModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_item_discard_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_item_discard_model.html#a3c15f2941fafade6b4ed2aea84aebe1b)GetXpBonusForDiscardingItems()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ItemDiscardModel.GetXpBonusForDiscardingItems | ( | [ItemRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_item_roster.html) | *itemRoster* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_item_discard_model.html#acd5a9729c518fc7981820dbfc745e2f0)GetXpBonusForDiscardingItem()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ItemDiscardModel.GetXpBonusForDiscardingItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | int | *amount* = 1 ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_item_discard_model.html#acbac31031471f0b57387e2edae07abb6)PlayerCanDonateItem()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.ItemDiscardModel.PlayerCanDonateItem | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  | | abstract |

