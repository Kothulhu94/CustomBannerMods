--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_campaign_ship_damage_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultCampaignShipDamageModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.CampaignShipDamageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_campaign_ship_damage_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetHourlyShipDamage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_campaign_ship_damage_model.html#a4cb204672e15106fd21ae95d1758b906) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) owner, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| override float | [GetEstimatedSafeSailDuration](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_campaign_ship_damage_model.html#a7490ce84a6459e6f2df94c1fa788d48b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override float | [GetShipDamage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_campaign_ship_damage_model.html#a02c5900eaa21fca8f7b000c5dbd00050) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) rammingShip, float rawDamage) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CampaignShipDamageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_campaign_ship_damage_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_campaign_ship_damage_model.html#a4cb204672e15106fd21ae95d1758b906)GetHourlyShipDamage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCampaignShipDamageModel.GetHourlyShipDamage | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *owner*, |
|  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_campaign_ship_damage_model.html#a7490ce84a6459e6f2df94c1fa788d48b)GetEstimatedSafeSailDuration()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultCampaignShipDamageModel.GetEstimatedSafeSailDuration | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_campaign_ship_damage_model.html#a02c5900eaa21fca8f7b000c5dbd00050)GetShipDamage()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultCampaignShipDamageModel.GetShipDamage | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *rammingShip*, |
|  |  | float | *rawDamage* ) |

