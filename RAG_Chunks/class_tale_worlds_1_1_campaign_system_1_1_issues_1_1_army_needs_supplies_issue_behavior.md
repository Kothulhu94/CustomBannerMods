--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior.html ---

TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [ArmyNeedsSuppliesIssueTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army45ca1ede59e16bbd0b989222875772e7.html) |
| class | [ArmyNeedsSuppliesIssue](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue.html) |
| class | [ArmyNeedsSuppliesIssueQuest](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior_1_1_army_needs_supplies_issue_quest.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior.html#a3d69b49dcdff78d6a8b5c6a7d1de93ec) () |
| void | [OnCheckForIssue](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior.html#a81560957688533b01604a475df64615e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior.html#ae0b96d92d4c4ca16d767893594bef485) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior.html#a3d69b49dcdff78d6a8b5c6a7d1de93ec)RegisterEvents()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior.html#a81560957688533b01604a475df64615e)OnCheckForIssue()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.OnCheckForIssue | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_army_needs_supplies_issue_behavior.html#ae0b96d92d4c4ca16d767893594bef485)SyncData()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Issues.ArmyNeedsSuppliesIssueBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

