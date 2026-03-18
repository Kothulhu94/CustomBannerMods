--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html ---

TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage Class ReferenceInherits [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultEncyclopediaConceptPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#ac5e796112e33970b51f6fcd0983b8dfe) () |
| override string | [GetViewFullyQualifiedName](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a69a6fc7f3cdbe7ed258852cb0ff080e2) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a657dce14f3fbb0b22bc9cbecda6104b1) () |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a3e929bf729e36832ce927b2039ea9850) () |
| override string | [GetStringID](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a6782ad23c67c7ae902fef6caf6717de3) () |
| override bool | [IsValidEncyclopediaItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a4597bff0408a6f8e9319aed6aad2c513) (object o) |
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
| override IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > | [InitializeListItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#ab4d90ece4753cbc8c98a747fde9c3953) () |
| override IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > | [InitializeFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#afe43ab4c796f0faa4e7273dbd95e1a41) () |
| override IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > | [InitializeSortControllers](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#aa6e6eaf3100384e25bccd0efef983123) () |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#ac5e796112e33970b51f6fcd0983b8dfe)DefaultEncyclopediaConceptPage()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage.DefaultEncyclopediaConceptPage | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#ab4d90ece4753cbc8c98a747fde9c3953)InitializeListItems()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage.InitializeListItems | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#afe43ab4c796f0faa4e7273dbd95e1a41)InitializeFilterItems()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage.InitializeFilterItems | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#aa6e6eaf3100384e25bccd0efef983123)InitializeSortControllers()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage.InitializeSortControllers | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a69a6fc7f3cdbe7ed258852cb0ff080e2)GetViewFullyQualifiedName()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage.GetViewFullyQualifiedName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a078eac42c809a9a4f80d85410c86eb7a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a657dce14f3fbb0b22bc9cbecda6104b1)GetName()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af812b516f54b9a3787a751da6a9aa2a5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a3e929bf729e36832ce927b2039ea9850)GetDescriptionText()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage.GetDescriptionText | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8ce4c8cf9ea499278abb4521ec7b34e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a6782ad23c67c7ae902fef6caf6717de3)GetStringID()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage.GetStringID | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6482d1767de8dd24437816cae03e165a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a4597bff0408a6f8e9319aed6aad2c513)IsValidEncyclopediaItem()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage.IsValidEncyclopediaItem | ( | object | *o* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a78f022419f315010a926df576fc73c0a).

