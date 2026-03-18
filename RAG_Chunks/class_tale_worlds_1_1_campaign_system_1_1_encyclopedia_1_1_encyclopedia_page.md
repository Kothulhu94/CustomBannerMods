--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html ---

TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage Class ReferenceabstractInherited by [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaClanPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_clan_page.html), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaFactionPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_faction_page.html), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settlement_page.html), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html), and [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6856c35b9a9933e6bf154cd1be1bae6d) () |
| virtual bool | [IsRelevant](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af6f0fc17457f66bde91b3b77d836e0ce) () |
| bool | [HasIdentifierType](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8bd66238b764cf7f722ad79a79e7acb) (Type identifierType) |
| string | [GetIdentifier](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a0b1d54194c8a321d152134efa5d8ddd1) (Type identifierType) |
| string[] | [GetIdentifierNames](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a4d2239b438ee765cbbaecf07c802be1e) () |
| bool | [IsFiltered](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#afd3e04c54687d70fc3926fbea9393c9c) (object o) |
| virtual string | [GetViewFullyQualifiedName](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a078eac42c809a9a4f80d85410c86eb7a) () |
| virtual string | [GetStringID](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6482d1767de8dd24437816cae03e165a) () |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af812b516f54b9a3787a751da6a9aa2a5) () |
| virtual [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) | [GetObject](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a39af5173d874d429e6a4d79f52936843) (string typeName, string stringID) |
| virtual bool | [IsValidEncyclopediaItem](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a78f022419f315010a926df576fc73c0a) (object o) |
| virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetDescriptionText](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8ce4c8cf9ea499278abb4521ec7b34e) () |
| IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > | [GetListItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#aaed4b61b09a2596a6dedab3179ca9bf8) () |
| IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > | [GetFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#abb7630e35496fa823437b08e4332cbcd) () |
| IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > | [GetSortControllers](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ad6c4597491aa3a9d50bb58e919149c6b) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > | [InitializeListItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a0a5defaf1766215c2fdf8a3de84f9e08) () |
| IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > | [InitializeFilterItems](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a160e3d8326c1552342dd70661a6743bd) () |
| IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > | [InitializeSortControllers](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a4cb7e8b088ca906eac4a6b9baf4a4c05) () |

|  |  |
| --- | --- |
| Properties | |
| int | [HomePageOrderIndex](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a9c0d3da28dd1182e601290973b735e6d) = 0 `[get, protected set]` |
| [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6856c35b9a9933e6bf154cd1be1bae6d) | [Parent](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a11f2df82559287f83cad16f160d29e71) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6856c35b9a9933e6bf154cd1be1bae6d)EncyclopediaPage()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.EncyclopediaPage | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a0a5defaf1766215c2fdf8a3de84f9e08)InitializeListItems()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.InitializeListItems | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a160e3d8326c1552342dd70661a6743bd)InitializeFilterItems()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.InitializeFilterItems | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a4cb7e8b088ca906eac4a6b9baf4a4c05)InitializeSortControllers()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.InitializeSortControllers | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af6f0fc17457f66bde91b3b77d836e0ce)IsRelevant()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.IsRelevant | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a82d9b9b74e101f9c6aecc44453205c92).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8bd66238b764cf7f722ad79a79e7acb)HasIdentifierType()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.HasIdentifierType | ( | Type | *identifierType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a0b1d54194c8a321d152134efa5d8ddd1)GetIdentifier()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.GetIdentifier | ( | Type | *identifierType* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a4d2239b438ee765cbbaecf07c802be1e)GetIdentifierNames()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string[] TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.GetIdentifierNames | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#afd3e04c54687d70fc3926fbea9393c9c)IsFiltered()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.IsFiltered | ( | object | *o* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a078eac42c809a9a4f80d85410c86eb7a)GetViewFullyQualifiedName()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual string TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.GetViewFullyQualifiedName | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaClanPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_clan_page.html#ab69d5e9ff877272537f34df59c18700a), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a69a6fc7f3cdbe7ed258852cb0ff080e2), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaFactionPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_faction_page.html#a007a421e3a3bc47b1c280a662451fd50), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a2f087156e23c605be4f57cf9e0fa242a), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settlement_page.html#a961518627a21035523e3ddf4545689eb), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a90ee8d3cf1b02aaee9b12ad0e5f030cb), and [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a4aac3cd3a9beba9d93ccea649e7a28fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6482d1767de8dd24437816cae03e165a)GetStringID()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual string TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.GetStringID | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaClanPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_clan_page.html#a662f86d2c7d56630a214ce6d70f2f765), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a6782ad23c67c7ae902fef6caf6717de3), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaFactionPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_faction_page.html#a41d89415ef511de21b96bb644a837ad7), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a24bfe46a27f26fc6fad6404bfbd9b620), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settlement_page.html#a7ce400bfbd3bbbc37f5278c69ae85247), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a3591d62272d5f593ff828c97d185f000), and [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#a3ff02a1a6f315bfd786e16d01e46b8b0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#af812b516f54b9a3787a751da6a9aa2a5)GetName()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.GetName | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaClanPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_clan_page.html#a0f7128f353d4756cf74d28eaa89747df), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a657dce14f3fbb0b22bc9cbecda6104b1), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaFactionPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_faction_page.html#a2d3151963b70b7c6f4bd7268fb21e029), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a42a63614b5e3f884c3653c245d1b5db7), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settlement_page.html#a79598ae61c0b4b474d444f5aa47a3565), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#ac71ec79d718070c0825a2602faa1628f), and [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#ab27e8fbbada307f44d53dc493eaac38a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a39af5173d874d429e6a4d79f52936843)GetObject()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual [MBObjectBase](class_tale_worlds_1_1_object_system_1_1_m_b_object_base.html) TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.GetObject | ( | string | *typeName*, | |  |  | string | *stringID* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaClanPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_clan_page.html#ac6e177a9cf7a7c065b7d142100954770), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaFactionPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_faction_page.html#aca499aa80b13f2cdb378609e43bced14), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a006d296b72618a98935b3883f7746466), and [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#ac4fce1f6034167be7c5f9ca70ada2509).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a78f022419f315010a926df576fc73c0a)IsValidEncyclopediaItem()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.IsValidEncyclopediaItem | ( | object | *o* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaClanPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_clan_page.html#a23e6625d9098051539f34114baff3293), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a4597bff0408a6f8e9319aed6aad2c513), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaFactionPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_faction_page.html#ad3ab9950d0e10e84ce60df6a55768484), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#a43c5bd7e7a6afea758d7413173c8b6fc), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settlement_page.html#a2e592d63c625ea784070d4c3d244a89a), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaShipPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_ship_page.html#a6d240c7127af224e73b80f819cdd978a), and [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#ace12eb22de6d542d20e1f2c4d12ea0db).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ae8ce4c8cf9ea499278abb4521ec7b34e)GetDescriptionText()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.GetDescriptionText | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaClanPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_clan_page.html#a749b34264013f00dcfceab0547465fa6), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaConceptPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_concept_page.html#a3e929bf729e36832ce927b2039ea9850), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaFactionPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_faction_page.html#a91b0af9e30304e8497f58c3025e4b18f), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaHeroPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_hero_page.html#afc92b553ff964725e178086577ba7e52), [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaSettlementPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_settlement_page.html#a3c04d9701d4fc8c3ce21337b200bab19), and [TaleWorlds.CampaignSystem.Encyclopedia.Pages.DefaultEncyclopediaUnitPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_pages_1_1_default_encyclopedia_unit_page.html#aa3cbc281b89072a0df96aecb02d17ff2).

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#aaed4b61b09a2596a6dedab3179ca9bf8)GetListItems()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [EncyclopediaListItem](struct_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_list_item.html) > TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.GetListItems | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#abb7630e35496fa823437b08e4332cbcd)GetFilterItems()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [EncyclopediaFilterGroup](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_filter_group.html) > TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.GetFilterItems | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#ad6c4597491aa3a9d50bb58e919149c6b)GetSortControllers()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [EncyclopediaSortController](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_sort_controller.html) > TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.GetSortControllers | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a9c0d3da28dd1182e601290973b735e6d)HomePageOrderIndex
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.HomePageOrderIndex = 0 | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a11f2df82559287f83cad16f160d29e71)Parent
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html#a6856c35b9a9933e6bf154cd1be1bae6d) TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaPage.Parent | | get |

