--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_campaign_ship_damage_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.CampaignShipDamageModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultCampaignShipDamageModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_campaign_ship_damage_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetHourlyShipDamage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_campaign_ship_damage_model.html#a869032ca766e056d96e0e90a33e9259c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) owner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| float | [GetEstimatedSafeSailDuration](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_campaign_ship_damage_model.html#adec883e135f606fa15733aeb6469313f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| float | [GetShipDamage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_campaign_ship_damage_model.html#a756ca7288a6fabf1e2e645ae3643a84e) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) rammingShip, float rawDamage) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_campaign_ship_damage_model.html#a869032ca766e056d96e0e90a33e9259c)GetHourlyShipDamage()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CampaignShipDamageModel.GetHourlyShipDamage | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *owner*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_campaign_ship_damage_model.html#adec883e135f606fa15733aeb6469313f)GetEstimatedSafeSailDuration()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CampaignShipDamageModel.GetEstimatedSafeSailDuration | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_campaign_ship_damage_model.html#a756ca7288a6fabf1e2e645ae3643a84e)GetShipDamage()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.CampaignShipDamageModel.GetShipDamage | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *rammingShip*, | |  |  | float | *rawDamage* ) | | abstract |

