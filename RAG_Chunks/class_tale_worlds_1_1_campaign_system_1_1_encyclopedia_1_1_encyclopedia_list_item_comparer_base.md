--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html ---

TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase Class ReferenceabstractInherits IComparer.

Inherited by [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaClanPage.EncyclopediaListClanComparer](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_clan_pc00cd1ae76cd68fc0ca31adf0a74fece.html), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaFactionPage.EncyclopediaListKingdomComparer](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_factio78504d10e45465532cb9bfcc52e4a3ad.html), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.EncyclopediaListHeroComparer](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_pa060d058ed69ab166cfb524cfac75322.html), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage.EncyclopediaListSettlementComparer](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settle841635440b56aa24da6d1cb57ffda840.html), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.EncyclopediaListShipComparer](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_p055a722d1706fbe0d4e1815456baf99d.html), and [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.EncyclopediaListUnitComparer](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_p5b158368135130b6ec9b7a008f42c31e.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetSortOrder](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#ac9be7f94840b81763d6f0bba76d036a4) (bool isAscending) |
| void | [SwitchSortOrder](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a9aed77c98aaf29cb7a51fee759bcb22c) () |
| void | [SetDefaultSortOrder](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a9c1e259c5b6bae13bfea9ce13a7d0b76) () |
| int | [Compare](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#aacb377458e3ebfe6836fd62c66169230) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) x, [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) y) |
| string | [GetComparedValueText](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#abc38b7ee89f29a511f283aa682339156) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) item) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| int | [ResolveEquality](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a24eee02e2bd97ac5c13bef41163ab335) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) x, [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) y) |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_emptyValue](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a460503e281c0586076609a20f6c3fa16) = new [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)("{=4NaOKslb}-") |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_missingValue](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a99165db94134cee70884efcc733b07df) = new [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)("{=keqS2dGa}???") |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsAscending](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#aff9668dc40cc9668bf289115f2b85ee7) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#ac9be7f94840b81763d6f0bba76d036a4)SetSortOrder()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase.SetSortOrder | ( | bool | *isAscending* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a9aed77c98aaf29cb7a51fee759bcb22c)SwitchSortOrder()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase.SwitchSortOrder | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a9c1e259c5b6bae13bfea9ce13a7d0b76)SetDefaultSortOrder()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase.SetDefaultSortOrder | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#aacb377458e3ebfe6836fd62c66169230)Compare()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase.Compare | ( | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *x*, | |  |  | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *y* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#abc38b7ee89f29a511f283aa682339156)GetComparedValueText()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase.GetComparedValueText | ( | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *item* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a24eee02e2bd97ac5c13bef41163ab335)ResolveEquality()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase.ResolveEquality | ( | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *x*, | |  |  | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *y* ) | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a460503e281c0586076609a20f6c3fa16)\_emptyValue
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase.\_emptyValue = new [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)("{=4NaOKslb}-") | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a99165db94134cee70884efcc733b07df)\_missingValue
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase.\_missingValue = new [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)("{=keqS2dGa}???") | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#aff9668dc40cc9668bf289115f2b85ee7)IsAscending
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase.IsAscending | | get |

