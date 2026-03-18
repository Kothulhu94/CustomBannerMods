--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_ship_cost_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultShipCostModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.ShipCostModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetShipTradeValue](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_ship_cost_model.html#ae9303f781b27905c755cda7285f343eb) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) seller, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) buyer) |
| override float | [GetShipRepairCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_ship_cost_model.html#a4ceed79bef4afd788c66241a86d07a90) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) owner) |
| override int | [GetShipUpgradePieceCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_ship_cost_model.html#ac6dc30365a9396d10928e311060b979c) ([Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) ship, [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) piece, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) owner) |
| override float | [GetShipSellingPenalty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_ship_cost_model.html#ae220a9134d820755db3a11844f98b710) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ShipCostModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_ship_cost_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_ship_cost_model.html#ae9303f781b27905c755cda7285f343eb)GetShipTradeValue()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultShipCostModel.GetShipTradeValue | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *seller*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *buyer* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_ship_cost_model.html#a4ceed79bef4afd788c66241a86d07a90)GetShipRepairCost()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultShipCostModel.GetShipRepairCost | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *owner* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_ship_cost_model.html#ac6dc30365a9396d10928e311060b979c)GetShipUpgradePieceCost()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultShipCostModel.GetShipUpgradePieceCost | ( | [Ship](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_ship.html) | *ship*, |
|  |  | [ShipUpgradePiece](class_tale_worlds_1_1_core_1_1_ship_upgrade_piece.html) | *piece*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *owner* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_ship_cost_model.html#ae220a9134d820755db3a11844f98b710)GetShipSellingPenalty()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultShipCostModel.GetShipSellingPenalty | ( |  | ) |  |

