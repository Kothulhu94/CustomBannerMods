--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html ---

TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage Class ReferenceInherits [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html).

|  |  |
| --- | --- |
| Classes | |
| class | [EncyclopediaListShipComparer](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_p055a722d1706fbe0d4e1815456baf99d.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultEncyclopediaShipPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a18f153e234c8874f34d38939e9535914) () |
| override bool | [IsRelevant](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a82d9b9b74e101f9c6aecc44453205c92) () |
| override string | [GetViewFullyQualifiedName](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a90ee8d3cf1b02aaee9b12ad0e5f030cb) () |
| override string | [GetStringID](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a3591d62272d5f593ff828c97d185f000) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#ac71ec79d718070c0825a2602faa1628f) () |
| override [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [GetObject](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#ac4fce1f6034167be7c5f9ca70ada2509) (string typeName, string stringID) |
| override bool | [IsValidEncyclopediaItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a6d240c7127af224e73b80f819cdd978a) (object o) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html) | |
|  | [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6856c35b9a9933e6bf154cd1be1bae6d) () |
| bool | [HasIdentifierType](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8bd66238b764cf7f722ad79a79e7acb) (Type identifierType) |
| string | [GetIdentifier](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a0b1d54194c8a321d152134efa5d8ddd1) (Type identifierType) |
| string[] | [GetIdentifierNames](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a4d2239b438ee765cbbaecf07c802be1e) () |
| bool | [IsFiltered](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#afd3e04c54687d70fc3926fbea9393c9c) (object o) |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8ce4c8cf9ea499278abb4521ec7b34e) () |
| IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > | [GetListItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#aaed4b61b09a2596a6dedab3179ca9bf8) () |
| IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > | [GetFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#abb7630e35496fa823437b08e4332cbcd) () |
| IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > | [GetSortControllers](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ad6c4597491aa3a9d50bb58e919149c6b) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > | [InitializeListItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a6704b31c481272242fd97fd79c812a7e) () |
| override IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > | [InitializeFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a19c88a916a4b2dde1933b1ab71e0bd1a) () |
| override IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > | [InitializeSortControllers](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#ac0de9f56c8bdde951023e8fae301912f) () |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a18f153e234c8874f34d38939e9535914)DefaultEncyclopediaShipPage()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.DefaultEncyclopediaShipPage | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a82d9b9b74e101f9c6aecc44453205c92)IsRelevant()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.IsRelevant | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af6f0fc17457f66bde91b3b77d836e0ce).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a6704b31c481272242fd97fd79c812a7e)InitializeListItems()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.InitializeListItems | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a19c88a916a4b2dde1933b1ab71e0bd1a)InitializeFilterItems()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.InitializeFilterItems | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#ac0de9f56c8bdde951023e8fae301912f)InitializeSortControllers()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.InitializeSortControllers | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a90ee8d3cf1b02aaee9b12ad0e5f030cb)GetViewFullyQualifiedName()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.GetViewFullyQualifiedName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a078eac42c809a9a4f80d85410c86eb7a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a3591d62272d5f593ff828c97d185f000)GetStringID()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.GetStringID | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6482d1767de8dd24437816cae03e165a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#ac71ec79d718070c0825a2602faa1628f)GetName()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af812b516f54b9a3787a751da6a9aa2a5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#ac4fce1f6034167be7c5f9ca70ada2509)GetObject()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.GetObject | ( | string | *typeName*, | |  |  | string | *stringID* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a39af5173d874d429e6a4d79f52936843).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a6d240c7127af224e73b80f819cdd978a)IsValidEncyclopediaItem()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage.IsValidEncyclopediaItem | ( | object | *o* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a78f022419f315010a926df576fc73c0a).

