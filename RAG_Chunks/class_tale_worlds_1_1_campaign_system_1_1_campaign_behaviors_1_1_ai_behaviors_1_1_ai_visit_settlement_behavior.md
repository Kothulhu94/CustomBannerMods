--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiVisitSettlementBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html#afbbd26015d54cf0e8d33a47903d05928) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html#aa79984dfae430a249ff05352341713f4) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [GoodEnoughScore](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html#ab4a58c875da679245fb14c71b4cb338e) = 8.0f |
| const float | [MeaningfulScoreThreshold](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html#a1cad0117477d931e4a9c34e4e3e09bbc) = 0.025f |
| const float | [BaseVisitScore](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html#abb3ccf9936df1283583f011cd007901c) = 1.6f |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html#afbbd26015d54cf0e8d33a47903d05928)RegisterEvents()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiVisitSettlementBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html#aa79984dfae430a249ff05352341713f4)SyncData()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiVisitSettlementBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html#ab4a58c875da679245fb14c71b4cb338e)GoodEnoughScore
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiVisitSettlementBehavior.GoodEnoughScore = 8.0f | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html#a1cad0117477d931e4a9c34e4e3e09bbc)MeaningfulScoreThreshold
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiVisitSettlementBehavior.MeaningfulScoreThreshold = 0.025f | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_visit_settlement_behavior.html#abb3ccf9936df1283583f011cd007901c)BaseVisitScore
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiVisitSettlementBehavior.BaseVisitScore = 1.6f | | static |

