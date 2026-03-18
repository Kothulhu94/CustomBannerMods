--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_garrison_recruitment_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.GarrisonRecruitmentCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.IGarrisonRecruitmentBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_garrison_recruitment_behavior.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [VolunteerTroop](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_garrison_recruitment_campaign_behavior_1_1_volunteer_troop.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_garrison_recruitment_campaign_behavior.html#a2c1d388726072bab998170ff40560778) () |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetGarrisonChangeExplainedNumber](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_garrison_recruitment_campaign_behavior.html#a140b38e48b021c6c758b37c53b6f0569) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_garrison_recruitment_campaign_behavior.html#af874ef1d331c67e7b13c2a8aef441a95) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_garrison_recruitment_campaign_behavior.html#a2c1d388726072bab998170ff40560778)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.GarrisonRecruitmentCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_garrison_recruitment_campaign_behavior.html#a140b38e48b021c6c758b37c53b6f0569)GetGarrisonChangeExplainedNumber()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.CampaignBehaviors.GarrisonRecruitmentCampaignBehavior.GetGarrisonChangeExplainedNumber | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IGarrisonRecruitmentBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_garrison_recruitment_behavior.html#ac9be33d0790f8aa893438594071d0170).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_garrison_recruitment_campaign_behavior.html#af874ef1d331c67e7b13c2a8aef441a95)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.GarrisonRecruitmentCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

