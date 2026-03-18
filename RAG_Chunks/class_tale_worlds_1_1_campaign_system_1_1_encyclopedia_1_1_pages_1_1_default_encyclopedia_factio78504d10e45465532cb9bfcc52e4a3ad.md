--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_factio78504d10e45465532cb9bfcc52e4a3ad.html ---

TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaFactionPage.EncyclopediaListKingdomComparer Class ReferenceabstractInherits [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [CompareKingdoms](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_factio78504d10e45465532cb9bfcc52e4a3ad.html#a2f453bce8276f75c3105f53be705185b) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) x, [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) y, Func< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), int > comparison) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html) | |
| void | [SetSortOrder](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#ac9be7f94840b81763d6f0bba76d036a4) (bool isAscending) |
| void | [SwitchSortOrder](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a9aed77c98aaf29cb7a51fee759bcb22c) () |
| void | [SetDefaultSortOrder](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a9c1e259c5b6bae13bfea9ce13a7d0b76) () |
| int | [Compare](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#aacb377458e3ebfe6836fd62c66169230) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) x, [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) y) |
| string | [GetComparedValueText](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#abc38b7ee89f29a511f283aa682339156) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) item) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html) | |
| int | [ResolveEquality](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a24eee02e2bd97ac5c13bef41163ab335) ([EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) x, [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) y) |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html) | |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_emptyValue](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a460503e281c0586076609a20f6c3fa16) = new [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)("{=4NaOKslb}-") |
| readonly [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [\_missingValue](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#a99165db94134cee70884efcc733b07df) = new [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html)("{=keqS2dGa}???") |
| Properties inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaListItemComparerBase](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html) | |
| bool | [IsAscending](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item_comparer_base.html#aff9668dc40cc9668bf289115f2b85ee7) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_factio78504d10e45465532cb9bfcc52e4a3ad.html#a2f453bce8276f75c3105f53be705185b)CompareKingdoms()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaFactionPage.EncyclopediaListKingdomComparer.CompareKingdoms | ( | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *x*, |
|  |  | [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) | *y*, |
|  |  | Func< [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_kingdom.html), int > | *comparison* ) |

