--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_fleet_management_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultFleetManagementModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.FleetManagementModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [CanSendShipToPlayerClan](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_fleet_management_model.html#a8a33e10e70167bcb92ce9f7e71575bf6) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, int playerShipsCount, int troopsCountToSend, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) hint) |
| override bool | [CanTroopsReturn](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_fleet_management_model.html#aeb0f4d32a8a89e12c16037be768f9dd4) () |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetReturnTimeForTroops](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_fleet_management_model.html#abef106401534dba162439b402ff5f5d2) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.FleetManagementModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html) | |
| bool | [CanTroopsReturn](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a98775e6210cbff6081b58bd41e8b2b44) () |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetReturnTimeForTroops](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a5aa9000b04d9c18534a99f741c257d0f) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship) |
| bool | [CanSendShipToPlayerClan](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a71bdd60cc43237175cfc394b29edae36) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, int playerShipsCount, int troopsCountToSend, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) hint) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [MinimumTroopCountRequiredToSendShips](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_fleet_management_model.html#a2314f47d19dc01d5b5a8a2ec9c388888) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.FleetManagementModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html) | |
| int | [MinimumTroopCountRequiredToSendShips](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_fleet_management_model.html#a67614d61462a0641bab2959e81e0068d) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_fleet_management_model.html#a8a33e10e70167bcb92ce9f7e71575bf6)CanSendShipToPlayerClan()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultFleetManagementModel.CanSendShipToPlayerClan | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | int | *playerShipsCount*, |
|  |  | int | *troopsCountToSend*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *hint* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_fleet_management_model.html#aeb0f4d32a8a89e12c16037be768f9dd4)CanTroopsReturn()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultFleetManagementModel.CanTroopsReturn | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_fleet_management_model.html#abef106401534dba162439b402ff5f5d2)GetReturnTimeForTroops()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultFleetManagementModel.GetReturnTimeForTroops | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_fleet_management_model.html#a2314f47d19dc01d5b5a8a2ec9c388888)MinimumTroopCountRequiredToSendShips
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultFleetManagementModel.MinimumTroopCountRequiredToSendShips | | get |

