--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting120b2449a7fa6e412f2b5d77f41266c8.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.Smelting.SmeltingSortControllerVM.ItemComparerBase Class ReferenceabstractInherits IComparer.

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.Smelting.SmeltingSortControllerVM.ItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting668c2ea97d365ef933ea07f853d703ea.html), [TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.Smelting.SmeltingSortControllerVM.ItemTypeComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting4252bf28d1982de9c589eae9ecf8fd20.html), and [TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.Smelting.SmeltingSortControllerVM.ItemYieldComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting626ceddbd246e0b6b48e5dfeb5fdd651.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetSortMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting120b2449a7fa6e412f2b5d77f41266c8.html#a67867cecfea42aeee3e07caad80c56c0) (bool isAscending) |
| int | [Compare](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting120b2449a7fa6e412f2b5d77f41266c8.html#a158a374e300a9006c1bd3126057429e2) ([SmeltingItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting_1_1_smelting_item_v_m.html) x, [SmeltingItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting_1_1_smelting_item_v_m.html) y) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| int | [ResolveEquality](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting120b2449a7fa6e412f2b5d77f41266c8.html#a9f60d5279287fe66f289fe5b0d3430eb) ([SmeltingItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting_1_1_smelting_item_v_m.html) x, [SmeltingItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting_1_1_smelting_item_v_m.html) y) |

|  |  |
| --- | --- |
| Protected Attributes | |
| bool | [\_isAscending](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting120b2449a7fa6e412f2b5d77f41266c8.html#a2dab8484ab2937d3c4c9eaa6d84fc38e) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting120b2449a7fa6e412f2b5d77f41266c8.html#a67867cecfea42aeee3e07caad80c56c0)SetSortMode()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.Smelting.SmeltingSortControllerVM.ItemComparerBase.SetSortMode | ( | bool | *isAscending* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting120b2449a7fa6e412f2b5d77f41266c8.html#a158a374e300a9006c1bd3126057429e2)Compare()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.Smelting.SmeltingSortControllerVM.ItemComparerBase.Compare | ( | [SmeltingItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting_1_1_smelting_item_v_m.html) | *x*, | |  |  | [SmeltingItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting_1_1_smelting_item_v_m.html) | *y* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting120b2449a7fa6e412f2b5d77f41266c8.html#a9f60d5279287fe66f289fe5b0d3430eb)ResolveEquality()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.Smelting.SmeltingSortControllerVM.ItemComparerBase.ResolveEquality | ( | [SmeltingItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting_1_1_smelting_item_v_m.html) | *x*, | |  |  | [SmeltingItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting_1_1_smelting_item_v_m.html) | *y* ) | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting120b2449a7fa6e412f2b5d77f41266c8.html#a2dab8484ab2937d3c4c9eaa6d84fc38e)\_isAscending
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.Smelting.SmeltingSortControllerVM.ItemComparerBase.\_isAscending | | protected |

