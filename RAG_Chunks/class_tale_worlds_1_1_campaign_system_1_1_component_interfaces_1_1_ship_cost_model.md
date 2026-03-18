--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.ShipCostModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultShipCostModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_ship_cost_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetShipTradeValue](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html#a82e2c60e1410be86bb8436e16e41894b) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) seller, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) buyer) |
| float | [GetShipRepairCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html#a973fa428f7e71f5feaae1edd42af8b6b) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) owner) |
| int | [GetShipUpgradePieceCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html#a1793801b86e6b90022285e6209f3148f) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) piece, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) owner) |
| float | [GetShipSellingPenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html#aaecd0b45d18c32e22f832294a07cdb76) () |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html#a82e2c60e1410be86bb8436e16e41894b)GetShipTradeValue()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ShipCostModel.GetShipTradeValue | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *seller*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *buyer* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html#a973fa428f7e71f5feaae1edd42af8b6b)GetShipRepairCost()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ShipCostModel.GetShipRepairCost | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *owner* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html#a1793801b86e6b90022285e6209f3148f)GetShipUpgradePieceCost()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ShipCostModel.GetShipUpgradePieceCost | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, | |  |  | [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) | *piece*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *owner* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html#aaecd0b45d18c32e22f832294a07cdb76)GetShipSellingPenalty()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ShipCostModel.GetShipSellingPenalty | ( |  | ) |  | | abstract |

