--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.FleetManagementModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultFleetManagementModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_fleet_management_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [CanTroopsReturn](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a98775e6210cbff6081b58bd41e8b2b44) () |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetReturnTimeForTroops](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a5aa9000b04d9c18534a99f741c257d0f) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| bool | [CanSendShipToPlayerClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a71bdd60cc43237175cfc394b29edae36) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, int playerShipsCount, int troopsCountToSend, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) hint) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [MinimumTroopCountRequiredToSendShips](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a67614d61462a0641bab2959e81e0068d) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a98775e6210cbff6081b58bd41e8b2b44)CanTroopsReturn()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.FleetManagementModel.CanTroopsReturn | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a5aa9000b04d9c18534a99f741c257d0f)GetReturnTimeForTroops()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.ComponentInterfaces.FleetManagementModel.GetReturnTimeForTroops | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a71bdd60cc43237175cfc394b29edae36)CanSendShipToPlayerClan()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.FleetManagementModel.CanSendShipToPlayerClan | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | int | *playerShipsCount*, | |  |  | int | *troopsCountToSend*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *hint* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a67614d61462a0641bab2959e81e0068d)MinimumTroopCountRequiredToSendShips
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.FleetManagementModel.MinimumTroopCountRequiredToSendShips | | getabstract |

