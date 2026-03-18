--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_mand7f4b12368e1552de3731dbe22b1e4d8.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemComparerBase Class ReferenceabstractInherits IComparer.

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemClanComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_man1dcf1c5461afbf40b292ab93f75ec5b5.html), [TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemCostComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_man659b116e25c19d767af2de2cc80d0ff5.html), [TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemDistanceComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_man417e4e1f97b85b3fad006bdeca5a404b.html), [TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_man48cef6c2d4e9a69a620afcabf842a74a.html), [TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemShipCountComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_manb6c4290ff9f64cedfd37ed84be7b9cfa.html), and [TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemStrengthComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_man363ab4a3e62d9b4c7f97a5108826e2d0.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetSortMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_mand7f4b12368e1552de3731dbe22b1e4d8.html#a9bdea28bd14d4506b7d6e89b45f0237b) (bool isAscending) |
| int | [Compare](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_mand7f4b12368e1552de3731dbe22b1e4d8.html#adef2b4b1df001baf9f5dd9ae75e613e0) ([ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) x, [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) y) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| int | [ResolveEquality](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_mand7f4b12368e1552de3731dbe22b1e4d8.html#ac7def7484bccd2101754fcfc8769fde6) ([ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) x, [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) y) |

|  |  |
| --- | --- |
| Protected Attributes | |
| bool | [\_isAscending](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_mand7f4b12368e1552de3731dbe22b1e4d8.html#ab051b82fac670bc36720314ddcf8c632) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_mand7f4b12368e1552de3731dbe22b1e4d8.html#a9bdea28bd14d4506b7d6e89b45f0237b)SetSortMode()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemComparerBase.SetSortMode | ( | bool | *isAscending* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_mand7f4b12368e1552de3731dbe22b1e4d8.html#adef2b4b1df001baf9f5dd9ae75e613e0)Compare()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemComparerBase.Compare | ( | [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) | *x*, | |  |  | [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) | *y* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_mand7f4b12368e1552de3731dbe22b1e4d8.html#ac7def7484bccd2101754fcfc8769fde6)ResolveEquality()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemComparerBase.ResolveEquality | ( | [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) | *x*, | |  |  | [ArmyManagementItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_management_item_v_m.html) | *y* ) | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_army_management_1_1_army_mand7f4b12368e1552de3731dbe22b1e4d8.html#ab051b82fac670bc36720314ddcf8c632)\_isAscending
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ArmyManagement.ArmyManagementSortControllerVM.ItemComparerBase.\_isAscending | | protected |

