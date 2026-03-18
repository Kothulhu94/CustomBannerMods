--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl66373fc34c646d2ae7fcbb56476ed769.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemComparerBase Class ReferenceabstractInherits IComparer.

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemClanComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl29e942e60da3918ea87bdd1f59150fa2.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemFoodComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl04452a4fda5e927851f8c18af1f0359f.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemGarrisonComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl63184d47444ffa4f50bb25dc423b2309.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl69802627bced14ddb170d9ce5f329032.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemOwnerComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settla6d352f3a328c14460b06ec8cd830366.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemProsperityComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl85074be375a3ce33aea831d67bb2a8d3.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemTypeComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl84aff88eac9a533494bcc6a7e35ff970.html), and [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemVillagesComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl744c316e7ec8f3ea0ae01f89edfc63e9.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetSortMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl66373fc34c646d2ae7fcbb56476ed769.html#a408c3b9d9d0d81b30d156348b8272297) (bool isAscending) |
| int | [Compare](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl66373fc34c646d2ae7fcbb56476ed769.html#aec94563f47bb9dfc0d2d81728ad9a2f9) ([KingdomSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html) x, [KingdomSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html) y) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| int | [ResolveEquality](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl66373fc34c646d2ae7fcbb56476ed769.html#a5008fb7e87cf29e19463597060ab9d2c) ([KingdomSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html) x, [KingdomSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html) y) |

|  |  |
| --- | --- |
| Protected Attributes | |
| bool | [\_isAscending](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl66373fc34c646d2ae7fcbb56476ed769.html#a027d19981f59bd08b3a1e8488aa1cce5) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl66373fc34c646d2ae7fcbb56476ed769.html#a408c3b9d9d0d81b30d156348b8272297)SetSortMode()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemComparerBase.SetSortMode | ( | bool | *isAscending* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl66373fc34c646d2ae7fcbb56476ed769.html#aec94563f47bb9dfc0d2d81728ad9a2f9)Compare()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemComparerBase.Compare | ( | [KingdomSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html) | *x*, | |  |  | [KingdomSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html) | *y* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl66373fc34c646d2ae7fcbb56476ed769.html#a5008fb7e87cf29e19463597060ab9d2c)ResolveEquality()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemComparerBase.ResolveEquality | ( | [KingdomSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html) | *x*, | |  |  | [KingdomSettlementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl426c6a34fc0678e299c7321b3010e460.html) | *y* ) | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_settl66373fc34c646d2ae7fcbb56476ed769.html#a027d19981f59bd08b3a1e8488aa1cce5)\_isAscending
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Settlements.KingdomSettlementSortControllerVM.ItemComparerBase.\_isAscending | | protected |

