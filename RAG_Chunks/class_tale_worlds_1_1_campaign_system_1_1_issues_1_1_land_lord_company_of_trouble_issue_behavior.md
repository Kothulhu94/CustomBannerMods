--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior.html ---

TaleWorlds.CampaignSystem.Issues.LandLordCompanyOfTroubleIssueBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [LandLordCompanyOfTroubleIssueTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior5189f945cbc63eec3234490d0df3a115.html) |
| class | [LandLordCompanyOfTroubleIssue](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behaviorcbf648b6f4c7e850db77da92875c9786.html) |
| class | [LandLordCompanyOfTroubleIssueQuest](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior3b245eec881862d78a0fa4ca5a35759f.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior.html#ad59a155f14211313ed2996f476a68602) () |
| void | [OnCheckForIssue](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior.html#a737243f5c90f00cbe5b102a01b4b45f6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior.html#a5ba06502ebb0dd2c38d2a5d598b17d3c) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [company\_of\_trouble\_menu\_game\_menu\_on\_init\_background](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior.html#a2b318a3a2ebb9863665d4738bd14521c) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior.html#ad59a155f14211313ed2996f476a68602)RegisterEvents()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Issues.LandLordCompanyOfTroubleIssueBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior.html#a2b318a3a2ebb9863665d4738bd14521c)company\_of\_trouble\_menu\_game\_menu\_on\_init\_background()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Issues.LandLordCompanyOfTroubleIssueBehavior.company\_of\_trouble\_menu\_game\_menu\_on\_init\_background | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior.html#a737243f5c90f00cbe5b102a01b4b45f6)OnCheckForIssue()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Issues.LandLordCompanyOfTroubleIssueBehavior.OnCheckForIssue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_land_lord_company_of_trouble_issue_behavior.html#a5ba06502ebb0dd2c38d2a5d598b17d3c)SyncData()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Issues.LandLordCompanyOfTroubleIssueBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

