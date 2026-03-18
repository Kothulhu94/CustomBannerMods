--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_item_price_factor_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.TradeItemPriceFactorModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultTradeItemPriceFactorModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_trade_item_price_factor_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetTradePenalty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_item_price_factor_model.html#ac789546e557a182797ffc0367ae4cc3a) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) clientParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) merchant, bool isSelling, float inStore, float supply, float demand) |
| float | [GetBasePriceFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_item_price_factor_model.html#ae63448269d2c9e05b120ece5ace36ae3) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory, float inStoreValue, float supply, float demand, bool isSelling, int transferValue) |
| int | [GetPrice](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_item_price_factor_model.html#a1d15319f22869c022789f40d4ffdcab3) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) itemRosterElement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) clientParty, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) merchant, bool isSelling, float inStoreValue, float supply, float demand) |
| int | [GetTheoreticalMaxItemMarketValue](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_item_price_factor_model.html#a43dbb7edf2e176dcd4b7d7977227104b) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_item_price_factor_model.html#ac789546e557a182797ffc0367ae4cc3a)GetTradePenalty()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TradeItemPriceFactorModel.GetTradePenalty | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *clientParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *merchant*, | |  |  | bool | *isSelling*, | |  |  | float | *inStore*, | |  |  | float | *supply*, | |  |  | float | *demand* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_item_price_factor_model.html#ae63448269d2c9e05b120ece5ace36ae3)GetBasePriceFactor()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TradeItemPriceFactorModel.GetBasePriceFactor | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory*, | |  |  | float | *inStoreValue*, | |  |  | float | *supply*, | |  |  | float | *demand*, | |  |  | bool | *isSelling*, | |  |  | int | *transferValue* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_item_price_factor_model.html#a1d15319f22869c022789f40d4ffdcab3)GetPrice()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.TradeItemPriceFactorModel.GetPrice | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *itemRosterElement*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *clientParty*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *merchant*, | |  |  | bool | *isSelling*, | |  |  | float | *inStoreValue*, | |  |  | float | *supply*, | |  |  | float | *demand* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_trade_item_price_factor_model.html#a43dbb7edf2e176dcd4b7d7977227104b)GetTheoreticalMaxItemMarketValue()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.TradeItemPriceFactorModel.GetTheoreticalMaxItemMarketValue | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item* | ) |  | | abstract |

