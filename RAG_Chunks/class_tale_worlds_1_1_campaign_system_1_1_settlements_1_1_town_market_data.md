--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html ---

TaleWorlds.CampaignSystem.Settlements.TownMarketData Class ReferenceInherits [TaleWorlds.CampaignSystem.Settlements.IMarketData](interface_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_i_market_data.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TownMarketData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a81004185e655ca71bcec9ffa3faf427c) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| [ItemData](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_item_data.html) | [GetCategoryData](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#afcd2a5b144d79be199280e817b57c999) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory) |
| int | [GetItemCountOfCategory](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a141010b8251522f51184fc4f394e90c0) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory) |
| void | [OnTownInventoryUpdated](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a94b18d4f080ff3d1cf08b8d1cb618f36) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) item, int count) |
| void | [AddDemand](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#af30b70593c01eaad8325ac47d8b038d6) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory, float demandAmount) |
| void | [AddSupply](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a44a7a47ca9201be8671f28da84b23def) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory, float supplyAmount) |
| void | [AddNumberInStore](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#ae70e0a8df7169d772c3f5dd1094aa374) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory, int number, int value) |
| void | [SetSupplyDemand](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a00b45e34c19671ee404d09296be0acae) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory, float supply, float demand) |
| void | [SetDemand](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a17ab7d2ac1c9dc2a1e2d0aa524959bdf) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory, float demand) |
| float | [GetDemand](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a50f61f2c8b10d598327f9e7e31e8aa09) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory) |
| float | [GetSupply](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a2de4d4febc31d74c4c47f9ffa2c8cd10) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory) |
| float | [GetPriceFactor](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a7e766e47285f1bb891774921fb03d6df) ([ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) itemCategory) |
| int | [GetPrice](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a3a6048f64b4f63d9406446a25a17419c) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) tradingParty=null, bool isSelling=false, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) merchantParty=null) |
| int | [GetPrice](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#ae86f4744a3015f89eb636c1f77559888) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) itemRosterElement, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) tradingParty=null, bool isSelling=false, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) merchantParty=null) |
| void | [UpdateStores](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#aed7ec9e13075e434b88def7c9b0c6a23) () |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a81004185e655ca71bcec9ffa3faf427c)TownMarketData()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Settlements.TownMarketData.TownMarketData | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#afcd2a5b144d79be199280e817b57c999)GetCategoryData()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ItemData](struct_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_item_data.html) TaleWorlds.CampaignSystem.Settlements.TownMarketData.GetCategoryData | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a141010b8251522f51184fc4f394e90c0)GetItemCountOfCategory()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.TownMarketData.GetItemCountOfCategory | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a94b18d4f080ff3d1cf08b8d1cb618f36)OnTownInventoryUpdated()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.TownMarketData.OnTownInventoryUpdated | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html) | *item*, |
|  |  | int | *count* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#af30b70593c01eaad8325ac47d8b038d6)AddDemand()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.TownMarketData.AddDemand | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory*, |
|  |  | float | *demandAmount* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a44a7a47ca9201be8671f28da84b23def)AddSupply()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.TownMarketData.AddSupply | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory*, |
|  |  | float | *supplyAmount* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#ae70e0a8df7169d772c3f5dd1094aa374)AddNumberInStore()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.TownMarketData.AddNumberInStore | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory*, |
|  |  | int | *number*, |
|  |  | int | *value* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a00b45e34c19671ee404d09296be0acae)SetSupplyDemand()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.TownMarketData.SetSupplyDemand | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory*, |
|  |  | float | *supply*, |
|  |  | float | *demand* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a17ab7d2ac1c9dc2a1e2d0aa524959bdf)SetDemand()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.TownMarketData.SetDemand | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory*, |
|  |  | float | *demand* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a50f61f2c8b10d598327f9e7e31e8aa09)GetDemand()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.TownMarketData.GetDemand | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a2de4d4febc31d74c4c47f9ffa2c8cd10)GetSupply()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.TownMarketData.GetSupply | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a7e766e47285f1bb891774921fb03d6df)GetPriceFactor()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Settlements.TownMarketData.GetPriceFactor | ( | [ItemCategory](class_tale_worlds_1_1_core_1_1_item_category.html) | *itemCategory* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#a3a6048f64b4f63d9406446a25a17419c)GetPrice() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.TownMarketData.GetPrice | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *tradingParty* = null, |
|  |  | bool | *isSelling* = false, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *merchantParty* = null ) |

Implements [TaleWorlds.CampaignSystem.Settlements.IMarketData](interface_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_i_market_data.html#a408f215fe4a9e41f9d50133bf1f6f5d4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#ae86f4744a3015f89eb636c1f77559888)GetPrice() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Settlements.TownMarketData.GetPrice | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_equipment_element.html) | *itemRosterElement*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *tradingParty* = null, |
|  |  | bool | *isSelling* = false, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *merchantParty* = null ) |

Implements [TaleWorlds.CampaignSystem.Settlements.IMarketData](interface_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_i_market_data.html#a37f939383d36ef3a2a9c5b9270f92496).

[◆](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town_market_data.html#aed7ec9e13075e434b88def7c9b0c6a23)UpdateStores()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Settlements.TownMarketData.UpdateStores | ( |  | ) |  |

