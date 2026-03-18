--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html ---

TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage Class ReferenceInherits [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html).

|  |  |
| --- | --- |
| Classes | |
| class | [EncyclopediaListHeroComparer](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_pa060d058ed69ab166cfb524cfac75322.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultEncyclopediaHeroPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a040f327a89afdd49f340e2f2b524f728) () |
| override string | [GetViewFullyQualifiedName](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a2f087156e23c605be4f57cf9e0fa242a) () |
| override string | [GetStringID](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a24bfe46a27f26fc6fad6404bfbd9b620) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a42a63614b5e3f884c3653c245d1b5db7) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#afc92b553ff964725e178086577ba7e52) () |
| override [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [GetObject](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a006d296b72618a98935b3883f7746466) (string typeName, string stringID) |
| override bool | [IsValidEncyclopediaItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a43c5bd7e7a6afea758d7413173c8b6fc) (object o) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html) | |
|  | [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6856c35b9a9933e6bf154cd1be1bae6d) () |
| virtual bool | [IsRelevant](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af6f0fc17457f66bde91b3b77d836e0ce) () |
| bool | [HasIdentifierType](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8bd66238b764cf7f722ad79a79e7acb) (Type identifierType) |
| string | [GetIdentifier](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a0b1d54194c8a321d152134efa5d8ddd1) (Type identifierType) |
| string[] | [GetIdentifierNames](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a4d2239b438ee765cbbaecf07c802be1e) () |
| bool | [IsFiltered](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#afd3e04c54687d70fc3926fbea9393c9c) (object o) |
| IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > | [GetListItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#aaed4b61b09a2596a6dedab3179ca9bf8) () |
| IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > | [GetFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#abb7630e35496fa823437b08e4332cbcd) () |
| IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > | [GetSortControllers](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ad6c4597491aa3a9d50bb58e919149c6b) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > | [InitializeListItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#af8df9a9f147184f36c04852ccd358e09) () |
| override IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > | [InitializeFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#ab80770632981dbc9460fa2fc5b738a23) () |
| override IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > | [InitializeSortControllers](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a59b5939d4c6f5134cae5ea378f3c90d8) () |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a040f327a89afdd49f340e2f2b524f728)DefaultEncyclopediaHeroPage()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.DefaultEncyclopediaHeroPage | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#af8df9a9f147184f36c04852ccd358e09)InitializeListItems()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.InitializeListItems | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#ab80770632981dbc9460fa2fc5b738a23)InitializeFilterItems()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.InitializeFilterItems | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a59b5939d4c6f5134cae5ea378f3c90d8)InitializeSortControllers()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.InitializeSortControllers | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a2f087156e23c605be4f57cf9e0fa242a)GetViewFullyQualifiedName()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.GetViewFullyQualifiedName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a078eac42c809a9a4f80d85410c86eb7a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a24bfe46a27f26fc6fad6404bfbd9b620)GetStringID()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.GetStringID | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6482d1767de8dd24437816cae03e165a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a42a63614b5e3f884c3653c245d1b5db7)GetName()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af812b516f54b9a3787a751da6a9aa2a5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#afc92b553ff964725e178086577ba7e52)GetDescriptionText()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.GetDescriptionText | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8ce4c8cf9ea499278abb4521ec7b34e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a006d296b72618a98935b3883f7746466)GetObject()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.GetObject | ( | string | *typeName*, | |  |  | string | *stringID* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a39af5173d874d429e6a4d79f52936843).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a43c5bd7e7a6afea758d7413173c8b6fc)IsValidEncyclopediaItem()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage.IsValidEncyclopediaItem | ( | object | *o* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a78f022419f315010a926df576fc73c0a).

