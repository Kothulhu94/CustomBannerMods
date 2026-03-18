--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html ---

TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [CreateEncyclopediaPages](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a005f04576c2c2101a44ee549f39513d9) () |
| IEnumerable< [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html) > | [GetEncyclopediaPages](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#ae38a2e03665ff1eac08019722b6fb867) () |
| [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html) | [GetPageOf](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a83562e490a7aa469a324131462dad01b) (Type type) |
| string | [GetIdentifier](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#ac024bf9056cf5383e4602accddd2a830) (Type type) |
| void | [GoToLink](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a5a3e3cb468668e472a81534cfcb4149d) (string pageType, string stringID) |
| void | [GoToLink](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a577b40acc8d68827d36ebe26a8051af3) (string link) |
| void | [SetLinkCallback](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a4dbb9a5fafa1f1d10520be3bc6e1a0c2) (Action< string, object > ExecuteLink) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const string | [HOME\_ID](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#afd4c337d0c021fd5bc37afc4eb20a2c9) = "Home" |
| const string | [LIST\_PAGE\_ID](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a669c6c4f3336fd514a6932a8b4ffb1cf) = "ListPage" |
| const string | [LAST\_PAGE\_ID](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a96c46a12fb851cb128375f869053ce34) = "LastPage" |

|  |  |
| --- | --- |
| Properties | |
| [IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html) | [ViewDataTracker](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#af59cc1a7210475a062e1c320145dc572) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a005f04576c2c2101a44ee549f39513d9)CreateEncyclopediaPages()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.CreateEncyclopediaPages | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#ae38a2e03665ff1eac08019722b6fb867)GetEncyclopediaPages()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html) > TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.GetEncyclopediaPages | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a83562e490a7aa469a324131462dad01b)GetPageOf()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [EncyclopediaPage](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_page.html) TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.GetPageOf | ( | Type | *type* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#ac024bf9056cf5383e4602accddd2a830)GetIdentifier()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.GetIdentifier | ( | Type | *type* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a5a3e3cb468668e472a81534cfcb4149d)GoToLink() [1/2]
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.GoToLink | ( | string | *pageType*, |
|  |  | string | *stringID* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a577b40acc8d68827d36ebe26a8051af3)GoToLink() [2/2]
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.GoToLink | ( | string | *link* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a4dbb9a5fafa1f1d10520be3bc6e1a0c2)SetLinkCallback()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.SetLinkCallback | ( | Action< string, object > | *ExecuteLink* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#afd4c337d0c021fd5bc37afc4eb20a2c9)HOME\_ID
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.HOME\_ID = "Home" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a669c6c4f3336fd514a6932a8b4ffb1cf)LIST\_PAGE\_ID
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.LIST\_PAGE\_ID = "ListPage" | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#a96c46a12fb851cb128375f869053ce34)LAST\_PAGE\_ID
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.LAST\_PAGE\_ID = "LastPage" | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_encyclopedia_1_1_encyclopedia_manager.html#af59cc1a7210475a062e1c320145dc572)ViewDataTracker
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html) TaleWorlds.CampaignSystem.Encyclopedia.EncyclopediaManager.ViewDataTracker | | get |

