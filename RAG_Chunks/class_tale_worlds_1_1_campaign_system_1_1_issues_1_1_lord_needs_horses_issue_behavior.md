--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior.html ---

TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [LordNeedsHorsesIssueBehaviorTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_naf7e4f6d0cef0a9eceffe33f809d8c0f.html) |
| class | [LordNeedsHorsesIssue](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue.html) |
| class | [LordNeedsHorsesIssueQuest](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior_1_1_lord_needs_horses_issue_quest.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior.html#a2db6d45c45b1e5084a911992bc8b8f7b) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior.html#ae7fff2f1555dd76d9b51057b9191b980) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [ComputeMountsOverInfantryCountRatio](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior.html#a22ebc40def00583a9cbea8cc2c8b688e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) issueParty, out int numInfantry) |
| static bool | [IsMountCamel](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior.html#ad45fca3f875ac8615b2c1ce57756a6b4) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) mountObject) |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior.html#a22ebc40def00583a9cbea8cc2c8b688e)ComputeMountsOverInfantryCountRatio()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.ComputeMountsOverInfantryCountRatio | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *issueParty*, | |  |  | out int | *numInfantry* ) | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior.html#ad45fca3f875ac8615b2c1ce57756a6b4)IsMountCamel()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.IsMountCamel | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *mountObject* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior.html#a2db6d45c45b1e5084a911992bc8b8f7b)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_lord_needs_horses_issue_behavior.html#ae7fff2f1555dd76d9b51057b9191b980)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Issues.LordNeedsHorsesIssueBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

