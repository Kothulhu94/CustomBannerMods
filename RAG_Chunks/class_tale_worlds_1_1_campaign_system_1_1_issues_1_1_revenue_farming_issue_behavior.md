--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior.html ---

TaleWorlds.CampaignSystem.Issues.RevenueFarmingIssueBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [RevenueFarmingIssueBehaviorTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior_1_1_revenue_66fb31afcf282ca63172367ba0e1ffdb.html) |
| class | [VillageEvent](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior_1_1_village_event.html) |
| struct | [VillageEventOptionData](struct_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior_1_1_village_event_option_data.html) |
| class | [RevenueVillage](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior_1_1_revenue_village.html) |
| class | [RevenueFarmingIssue](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior_1_1_revenue_farming_issue.html) |
| class | [RevenueFarmingIssueQuest](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior_1_1_revenue_farming_issue_quest.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior.html#a68831293e158f94e7f3ee4c6fcc55644) () |
| void | [OnVillageEventWithIdSpawned](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior.html#a07f82d77ba4b26e09b6f53d072f3040d) (string Id) |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior.html#a2fbf1334b03457755afcf3f2251364e1) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnCheckForIssue](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior.html#a00fdc9cf315edbf9fb82050270e35dd4) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior.html#a68831293e158f94e7f3ee4c6fcc55644)RegisterEvents()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Issues.RevenueFarmingIssueBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior.html#a07f82d77ba4b26e09b6f53d072f3040d)OnVillageEventWithIdSpawned()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Issues.RevenueFarmingIssueBehavior.OnVillageEventWithIdSpawned | ( | string | *Id* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior.html#a2fbf1334b03457755afcf3f2251364e1)SyncData()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Issues.RevenueFarmingIssueBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_revenue_farming_issue_behavior.html#a00fdc9cf315edbf9fb82050270e35dd4)OnCheckForIssue()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Issues.RevenueFarmingIssueBehavior.OnCheckForIssue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

