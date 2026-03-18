--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_caravan_ambush_issue_behavior.html ---

TaleWorlds.CampaignSystem.Issues.CaravanAmbushIssueBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [CaravanAmbushIssueTypeDefiner](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_caravan_ambush_issue_behavior_1_1_caravan_ambush_issue_type_definer.html) |
| class | [CaravanAmbushIssue](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_caravan_ambush_issue_behavior_1_1_caravan_ambush_issue.html) |
| class | [CaravanAmbushIssueQuest](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_caravan_ambush_issue_behavior_1_1_caravan_ambush_issue_quest.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_caravan_ambush_issue_behavior.html#a5a5397c72f5566ee98d82163133b2ff9) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_caravan_ambush_issue_behavior.html#a69935f2a58579e52ee9cdd043b7a3093) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [UtilizePartyEscortBehavior](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_caravan_ambush_issue_behavior.html#abcb597b53f564dca66cb411dd7ca0d27) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) escortedParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) escortParty, ref bool isWaitingForEscortParty, float innerRadius, float outerRadius, [MobilePartyHelper.ResumePartyEscortBehaviorDelegate](class_helpers_1_1_mobile_party_helper.html#a31a30e280695e8ccd331211d6a80dad6) onPartyEscortBehaviorResumed, bool showDebugSpheres=false) |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_caravan_ambush_issue_behavior.html#a5a5397c72f5566ee98d82163133b2ff9)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Issues.CaravanAmbushIssueBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_caravan_ambush_issue_behavior.html#a69935f2a58579e52ee9cdd043b7a3093)SyncData()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Issues.CaravanAmbushIssueBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_issues_1_1_caravan_ambush_issue_behavior.html#abcb597b53f564dca66cb411dd7ca0d27)UtilizePartyEscortBehavior()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Issues.CaravanAmbushIssueBehavior.UtilizePartyEscortBehavior | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *escortedParty*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *escortParty*, | |  |  | ref bool | *isWaitingForEscortParty*, | |  |  | float | *innerRadius*, | |  |  | float | *outerRadius*, | |  |  | [MobilePartyHelper.ResumePartyEscortBehaviorDelegate](class_helpers_1_1_mobile_party_helper.html#a31a30e280695e8ccd331211d6a80dad6) | *onPartyEscortBehaviorResumed*, | |  |  | bool | *showDebugSpheres* = false ) | | static |

