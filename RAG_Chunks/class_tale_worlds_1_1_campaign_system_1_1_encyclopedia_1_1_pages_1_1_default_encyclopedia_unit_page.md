--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html ---

TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage Class ReferenceInherits [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html).

|  |  |
| --- | --- |
| Classes | |
| class | [EncyclopediaListUnitComparer](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_p5b158368135130b6ec9b7a008f42c31e.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultEncyclopediaUnitPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#aefa067739d769f512f6f02258d812fef) () |
| override string | [GetViewFullyQualifiedName](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a4aac3cd3a9beba9d93ccea649e7a28fd) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#ab27e8fbbada307f44d53dc493eaac38a) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#aa3cbc281b89072a0df96aecb02d17ff2) () |
| override string | [GetStringID](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a3ff02a1a6f315bfd786e16d01e46b8b0) () |
| override bool | [IsValidEncyclopediaItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#ace12eb22de6d542d20e1f2c4d12ea0db) (object o) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html) | |
|  | [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6856c35b9a9933e6bf154cd1be1bae6d) () |
| virtual bool | [IsRelevant](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af6f0fc17457f66bde91b3b77d836e0ce) () |
| bool | [HasIdentifierType](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8bd66238b764cf7f722ad79a79e7acb) (Type identifierType) |
| string | [GetIdentifier](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a0b1d54194c8a321d152134efa5d8ddd1) (Type identifierType) |
| string[] | [GetIdentifierNames](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a4d2239b438ee765cbbaecf07c802be1e) () |
| bool | [IsFiltered](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#afd3e04c54687d70fc3926fbea9393c9c) (object o) |
| virtual [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [GetObject](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a39af5173d874d429e6a4d79f52936843) (string typeName, string stringID) |
| IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > | [GetListItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#aaed4b61b09a2596a6dedab3179ca9bf8) () |
| IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > | [GetFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#abb7630e35496fa823437b08e4332cbcd) () |
| IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > | [GetSortControllers](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ad6c4597491aa3a9d50bb58e919149c6b) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > | [InitializeListItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#ac4543adc5c66b49a20a55bdd6b5434a2) () |
| override IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > | [InitializeFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a9b2b6c61d981e04891331a26e8ad543e) () |
| virtual List< [EncyclopediaFilterItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_item.html) > | [GetTypeFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a50820f65c856200c9a558b6c60157ce2) () |
| virtual List< [EncyclopediaFilterItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_item.html) > | [GetOccupationFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#ab5d1b899576f913ea28a7b6eb44c1b6f) () |
| virtual List< [EncyclopediaFilterItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_item.html) > | [GetCultureFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#af6553eae06510617415e1267a4da5be5) () |
| virtual List< [EncyclopediaFilterItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_item.html) > | [GetOutlawFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a2efcf5b88b56f9eb3797dddea498021b) () |
| override IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > | [InitializeSortControllers](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a9ea772d78a62e02a62159f173c442fa3) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html) | |
| IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > | [InitializeListItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a0a5defaf1766215c2fdf8a3de84f9e08) () |
| IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > | [InitializeFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a160e3d8326c1552342dd70661a6743bd) () |
| IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > | [InitializeSortControllers](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a4cb7e8b088ca906eac4a6b9baf4a4c05) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html) | |
| int | [HomePageOrderIndex](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a9c0d3da28dd1182e601290973b735e6d) = 0 `[get, protected set]` |
| [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6856c35b9a9933e6bf154cd1be1bae6d) | [Parent](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a11f2df82559287f83cad16f160d29e71) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#aefa067739d769f512f6f02258d812fef)DefaultEncyclopediaUnitPage()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.DefaultEncyclopediaUnitPage | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#ac4543adc5c66b49a20a55bdd6b5434a2)InitializeListItems()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.InitializeListItems | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a9b2b6c61d981e04891331a26e8ad543e)InitializeFilterItems()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.InitializeFilterItems | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a50820f65c856200c9a558b6c60157ce2)GetTypeFilterItems()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual List< [EncyclopediaFilterItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_item.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.GetTypeFilterItems | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#ab5d1b899576f913ea28a7b6eb44c1b6f)GetOccupationFilterItems()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual List< [EncyclopediaFilterItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_item.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.GetOccupationFilterItems | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#af6553eae06510617415e1267a4da5be5)GetCultureFilterItems()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual List< [EncyclopediaFilterItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_item.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.GetCultureFilterItems | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a2efcf5b88b56f9eb3797dddea498021b)GetOutlawFilterItems()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual List< [EncyclopediaFilterItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_item.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.GetOutlawFilterItems | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a9ea772d78a62e02a62159f173c442fa3)InitializeSortControllers()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.InitializeSortControllers | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a4aac3cd3a9beba9d93ccea649e7a28fd)GetViewFullyQualifiedName()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.GetViewFullyQualifiedName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a078eac42c809a9a4f80d85410c86eb7a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#ab27e8fbbada307f44d53dc493eaac38a)GetName()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af812b516f54b9a3787a751da6a9aa2a5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#aa3cbc281b89072a0df96aecb02d17ff2)GetDescriptionText()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.GetDescriptionText | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8ce4c8cf9ea499278abb4521ec7b34e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a3ff02a1a6f315bfd786e16d01e46b8b0)GetStringID()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.GetStringID | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6482d1767de8dd24437816cae03e165a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#ace12eb22de6d542d20e1f2c4d12ea0db)IsValidEncyclopediaItem()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage.IsValidEncyclopediaItem | ( | object | *o* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a78f022419f315010a926df576fc73c0a).

