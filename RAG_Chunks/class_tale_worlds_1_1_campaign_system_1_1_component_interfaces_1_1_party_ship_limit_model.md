--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_ship_limit_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PartyShipLimitModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultPartyShipLimitModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_ship_limit_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetIdealShipNumber](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_ship_limit_model.html#a94d4f7b19f3bd375813bf0ea014924ae) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| int | [GetIdealShipNumber](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_ship_limit_model.html#a72433e19b5cc0c82b4f4106b5d3fd177) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| float | [GetShipPriority](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_ship_limit_model.html#a852ad860224fbf1781ed0730642284c7) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, bool isSelling) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_ship_limit_model.html#a94d4f7b19f3bd375813bf0ea014924ae)GetIdealShipNumber() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyShipLimitModel.GetIdealShipNumber | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_ship_limit_model.html#a72433e19b5cc0c82b4f4106b5d3fd177)GetIdealShipNumber() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyShipLimitModel.GetIdealShipNumber | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_ship_limit_model.html#a852ad860224fbf1781ed0730642284c7)GetShipPriority()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PartyShipLimitModel.GetShipPriority | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | bool | *isSelling* ) | | abstract |

