--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_98b02397f0786822ad96017d264a59d9.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ItemComparer Class ReferenceabstractInherits IComparer.

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ItemCostComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_24c70effe4ce087ca0e873e765bfe127.html), [TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_114780c65517d23ec12a743bdb8150e4.html), [TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ItemQuantityComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_44dcddba5f9924006bf9cdfcb0aa9225.html), and [TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ItemTypeComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_5b6da37e50395ebabc1f7c4cc4508d9b.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetSortMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_98b02397f0786822ad96017d264a59d9.html#ad92814e12df075fc594db2b61206688d) (bool isAscending) |
| int | [Compare](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_98b02397f0786822ad96017d264a59d9.html#ac079513b80b54d3bebca42b5abb1985e) ([SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) x, [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) y) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| int | [ResolveEquality](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_98b02397f0786822ad96017d264a59d9.html#a58966ca6f456a7865a60a728366a5e44) ([SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) x, [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) y) |

|  |  |
| --- | --- |
| Protected Attributes | |
| bool | [\_isAscending](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_98b02397f0786822ad96017d264a59d9.html#a4ca0f0e44d5db8733366b588f5e44218) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_98b02397f0786822ad96017d264a59d9.html#ad92814e12df075fc594db2b61206688d)SetSortMode()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ItemComparer.SetSortMode | ( | bool | *isAscending* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_98b02397f0786822ad96017d264a59d9.html#ac079513b80b54d3bebca42b5abb1985e)Compare()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ItemComparer.Compare | ( | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | *x*, | |  |  | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | *y* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_98b02397f0786822ad96017d264a59d9.html#a58966ca6f456a7865a60a728366a5e44)ResolveEquality()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ItemComparer.ResolveEquality | ( | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | *x*, | |  |  | [SPItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_item_v_m.html) | *y* ) | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_s_p_inventory_98b02397f0786822ad96017d264a59d9.html#a4ca0f0e44d5db8733366b588f5e44218)\_isAscending
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Inventory.SPInventorySortControllerVM.ItemComparer.\_isAscending | | protected |

