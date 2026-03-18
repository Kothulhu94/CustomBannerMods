--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html ---

TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage.EncyclopediaListSettlementComparer Class ReferenceabstractInherits [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html).

|  |  |
| --- | --- |
| Protected Member Functions | |
| delegate bool | [SettlementVisibilityComparerDelegate](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#aacd9dc24edf93e1be427701c400c8d01) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) s1, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) s2, out int comparisonResult) |
| virtual bool | [CompareVisibility](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#a74bdc0424aadf1af1ef2a1c6ff4bc1b1) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) s1, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) s2, out int comparisonResult) |
| int | [CompareSettlements](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#a9b5063c69de8a773d029587ddc4f0f65) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) x, [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) y, [SettlementVisibilityComparerDelegate](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#aacd9dc24edf93e1be427701c400c8d01) visibilityComparison, Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), int > comparison) |
| int | [CompareFiefs](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#ae267e931709ad55b50c7655580963dfb) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) x, [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) y, [SettlementVisibilityComparerDelegate](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#aacd9dc24edf93e1be427701c400c8d01) visibilityComparison, Func< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), int > comparison) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#aacd9dc24edf93e1be427701c400c8d01)SettlementVisibilityComparerDelegate()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | delegate bool TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage.EncyclopediaListSettlementComparer.SettlementVisibilityComparerDelegate | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *s1*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *s2*, | |  |  | out int | *comparisonResult* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#a74bdc0424aadf1af1ef2a1c6ff4bc1b1)CompareVisibility()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual bool TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage.EncyclopediaListSettlementComparer.CompareVisibility | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *s1*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *s2*, | |  |  | out int | *comparisonResult* ) | | protectedvirtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#a9b5063c69de8a773d029587ddc4f0f65)CompareSettlements()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage.EncyclopediaListSettlementComparer.CompareSettlements | ( | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *x*, | |  |  | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *y*, | |  |  | [SettlementVisibilityComparerDelegate](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#aacd9dc24edf93e1be427701c400c8d01) | *visibilityComparison*, | |  |  | Func< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html), int > | *comparison* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#ae267e931709ad55b50c7655580963dfb)CompareFiefs()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage.EncyclopediaListSettlementComparer.CompareFiefs | ( | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *x*, | |  |  | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *y*, | |  |  | [SettlementVisibilityComparerDelegate](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html#aacd9dc24edf93e1be427701c400c8d01) | *visibilityComparison*, | |  |  | Func< [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html), int > | *comparison* ) | | protected |

