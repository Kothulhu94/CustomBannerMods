--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clansd0ffb2d487e95af791eada942bfbff6a.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanSortControllerVM.ItemComparerBase Class ReferenceabstractInherits IComparer.

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanSortControllerVM.ItemFiefsComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans05494dcc68cd4c35df347e196ec7d780.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanSortControllerVM.ItemInfluenceComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans0c699861830993e4b0c6e7b88b4a323e.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanSortControllerVM.ItemMembersComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans02e294fc645849268f73611948ee0569.html), [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanSortControllerVM.ItemNameComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans600c673027503addbdc0213d55720531.html), and [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanSortControllerVM.ItemTypeComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clansef78f336e160607106bda9f266a0cf1d.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetSortMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clansd0ffb2d487e95af791eada942bfbff6a.html#a17a24b7612ef1cc80264a1c029d99c17) (bool isAscending) |
| int | [Compare](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clansd0ffb2d487e95af791eada942bfbff6a.html#a6d83e3cee97d394e54f3444221c2bcdd) ([KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) x, [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) y) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| int | [ResolveEquality](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clansd0ffb2d487e95af791eada942bfbff6a.html#a3fa5aa15c0a071656801f19db5eb09e7) ([KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) x, [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) y) |

|  |  |
| --- | --- |
| Protected Attributes | |
| bool | [\_isAscending](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clansd0ffb2d487e95af791eada942bfbff6a.html#a5975ba1ae8bd08bec909735aa86af075) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clansd0ffb2d487e95af791eada942bfbff6a.html#a17a24b7612ef1cc80264a1c029d99c17)SetSortMode()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanSortControllerVM.ItemComparerBase.SetSortMode | ( | bool | *isAscending* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clansd0ffb2d487e95af791eada942bfbff6a.html#a6d83e3cee97d394e54f3444221c2bcdd)Compare()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanSortControllerVM.ItemComparerBase.Compare | ( | [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) | *x*, | |  |  | [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) | *y* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clansd0ffb2d487e95af791eada942bfbff6a.html#a3fa5aa15c0a071656801f19db5eb09e7)ResolveEquality()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanSortControllerVM.ItemComparerBase.ResolveEquality | ( | [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) | *x*, | |  |  | [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) | *y* ) | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clansd0ffb2d487e95af791eada942bfbff6a.html#a5975ba1ae8bd08bec909735aa86af075)\_isAscending
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanSortControllerVM.ItemComparerBase.\_isAscending | | protected |

