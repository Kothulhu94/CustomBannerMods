--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie0a63085537cb4666fce4ab64b357da51.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Armies.KingdomArmySortControllerVM.ItemComparerBase Class ReferenceabstractInherits IComparer.

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Armies.KingdomArmySortControllerVM.ItemDistanceComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie9f3855871817f950c651e36e20d2fe0d.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Armies.KingdomArmySortControllerVM.ItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie9c2fe656fe28075b2428a9d4b642448f.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Armies.KingdomArmySortControllerVM.ItemOwnerComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armiebfb7a9c10db87e8c193975d11549c0ae.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Armies.KingdomArmySortControllerVM.ItemPartiesComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armiec74d3cfba2925b7719845efcd414f0aa.html), and [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Armies.KingdomArmySortControllerVM.ItemStrengthComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armief1329f55f68e44c3214fff4e22af0abb.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetSortMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie0a63085537cb4666fce4ab64b357da51.html#a7bee0fb3f1ea80a6b2c95e7302a9741e) (bool isAscending) |
| int | [Compare](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie0a63085537cb4666fce4ab64b357da51.html#a633e8f3019ce4e57b1340be20503863f) ([KingdomArmyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armies_1_1_kingdom_army_item_v_m.html) x, [KingdomArmyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armies_1_1_kingdom_army_item_v_m.html) y) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| int | [ResolveEquality](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie0a63085537cb4666fce4ab64b357da51.html#a1dd27a01b71bd88d5c62ecade0afc580) ([KingdomArmyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armies_1_1_kingdom_army_item_v_m.html) x, [KingdomArmyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armies_1_1_kingdom_army_item_v_m.html) y) |

|  |  |
| --- | --- |
| Protected Attributes | |
| bool | [\_isAscending](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie0a63085537cb4666fce4ab64b357da51.html#a64ce6064a14406e908e3f855d1fedfd8) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie0a63085537cb4666fce4ab64b357da51.html#a7bee0fb3f1ea80a6b2c95e7302a9741e)SetSortMode()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Armies.KingdomArmySortControllerVM.ItemComparerBase.SetSortMode | ( | bool | *isAscending* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie0a63085537cb4666fce4ab64b357da51.html#a633e8f3019ce4e57b1340be20503863f)Compare()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Armies.KingdomArmySortControllerVM.ItemComparerBase.Compare | ( | [KingdomArmyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armies_1_1_kingdom_army_item_v_m.html) | *x*, | |  |  | [KingdomArmyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armies_1_1_kingdom_army_item_v_m.html) | *y* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie0a63085537cb4666fce4ab64b357da51.html#a1dd27a01b71bd88d5c62ecade0afc580)ResolveEquality()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Armies.KingdomArmySortControllerVM.ItemComparerBase.ResolveEquality | ( | [KingdomArmyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armies_1_1_kingdom_army_item_v_m.html) | *x*, | |  |  | [KingdomArmyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armies_1_1_kingdom_army_item_v_m.html) | *y* ) | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_armie0a63085537cb4666fce4ab64b357da51.html#a64ce6064a14406e908e3f855d1fedfd8)\_isAscending
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Armies.KingdomArmySortControllerVM.ItemComparerBase.\_isAscending | | protected |

