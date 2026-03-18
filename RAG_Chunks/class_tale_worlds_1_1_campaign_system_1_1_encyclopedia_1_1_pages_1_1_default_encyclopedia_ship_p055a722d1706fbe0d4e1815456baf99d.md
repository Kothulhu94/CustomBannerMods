--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_p055a722d1706fbe0d4e1815456baf99d.html ---

TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.EncyclopediaListShipComparer Class ReferenceabstractInherits [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html).

|  |  |
| --- | --- |
| Protected Member Functions | |
| delegate bool | [ShipVisibilityComparerDelegate](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_p055a722d1706fbe0d4e1815456baf99d.html#adf5f4c2ad9db40e28fd6d69a47b30fb4) ([ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) s1, [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) s2, out int comparisonResult) |
| bool | [CompareVisibility](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_p055a722d1706fbe0d4e1815456baf99d.html#a1c45891a71ec8da88f8c57a014024433) ([ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) s1, [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) s2, out int comparisonResult) |
| int | [CompareShips](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_p055a722d1706fbe0d4e1815456baf99d.html#a04fdeea11a89e6cd19ddf5f59641eaeb) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) x, [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) y, Func< [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html), [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html), int > comparison) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html) | |
| int | [ResolveEquality](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a24eee02e2bd97ac5c13bef41163ab335) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) x, [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) y) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html) | |
| void | [SetSortOrder](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#ac9be7f94840b81763d6f0bba76d036a4) (bool isAscending) |
| void | [SwitchSortOrder](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a9aed77c98aaf29cb7a51fee759bcb22c) () |
| void | [SetDefaultSortOrder](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a9c1e259c5b6bae13bfea9ce13a7d0b76) () |
| int | [Compare](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#aacb377458e3ebfe6836fd62c66169230) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) x, [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) y) |
| string | [GetComparedValueText](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#abc38b7ee89f29a511f283aa682339156) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) item) |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html) | |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_emptyValue](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a460503e281c0586076609a20f6c3fa16) = new [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)("{=4NaOKslb}-") |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_missingValue](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a99165db94134cee70884efcc733b07df) = new [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)("{=keqS2dGa}???") |
| Properties inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html) | |
| bool | [IsAscending](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#aff9668dc40cc9668bf289115f2b85ee7) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_p055a722d1706fbe0d4e1815456baf99d.html#adf5f4c2ad9db40e28fd6d69a47b30fb4)ShipVisibilityComparerDelegate()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | delegate bool TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.EncyclopediaListShipComparer.ShipVisibilityComparerDelegate | ( | [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) | *s1*, | |  |  | [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) | *s2*, | |  |  | out int | *comparisonResult* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_p055a722d1706fbe0d4e1815456baf99d.html#a1c45891a71ec8da88f8c57a014024433)CompareVisibility()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.EncyclopediaListShipComparer.CompareVisibility | ( | [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) | *s1*, | |  |  | [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html) | *s2*, | |  |  | out int | *comparisonResult* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_p055a722d1706fbe0d4e1815456baf99d.html#a04fdeea11a89e6cd19ddf5f59641eaeb)CompareShips()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.EncyclopediaListShipComparer.CompareShips | ( | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *x*, | |  |  | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *y*, | |  |  | Func< [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html), [ShipHull](class_tale_worlds_1_1_core_1_1_ship_hull.html), int > | *comparison* ) | | protected |

