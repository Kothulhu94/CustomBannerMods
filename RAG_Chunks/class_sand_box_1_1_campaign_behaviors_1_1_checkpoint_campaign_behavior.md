--- SOURCE: class_sand_box_1_1_campaign_behaviors_1_1_checkpoint_campaign_behavior.html ---

SandBox.CampaignBehaviors.CheckpointCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_checkpoint_campaign_behavior.html#a2656dbde7f025ee55e368fa50182ff95) () |
| override void | [SyncData](class_sand_box_1_1_campaign_behaviors_1_1_checkpoint_campaign_behavior.html#afeb12810bb9eadd22614b1fa416d3297) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [LastUsedMissionCheckpointId](class_sand_box_1_1_campaign_behaviors_1_1_checkpoint_campaign_behavior.html#ac27bb15d560114bb9d654f74d8f633c4) = -1 |
| List< [AgentSaveData](struct_tale_worlds_1_1_core_1_1_agent_save_data.html) > | [CorpseList](class_sand_box_1_1_campaign_behaviors_1_1_checkpoint_campaign_behavior.html#a16643d964c328ae09c0872fbc1eaf21f) = new List<[AgentSaveData](struct_tale_worlds_1_1_core_1_1_agent_save_data.html)>() |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_checkpoint_campaign_behavior.html#a2656dbde7f025ee55e368fa50182ff95)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.CheckpointCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_checkpoint_campaign_behavior.html#afeb12810bb9eadd22614b1fa416d3297)SyncData()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.CheckpointCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_checkpoint_campaign_behavior.html#ac27bb15d560114bb9d654f74d8f633c4)LastUsedMissionCheckpointId
---------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int SandBox.CampaignBehaviors.CheckpointCampaignBehavior.LastUsedMissionCheckpointId = -1 |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_checkpoint_campaign_behavior.html#a16643d964c328ae09c0872fbc1eaf21f)CorpseList
----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| List<[AgentSaveData](struct_tale_worlds_1_1_core_1_1_agent_save_data.html)> SandBox.CampaignBehaviors.CheckpointCampaignBehavior.CorpseList = new List<[AgentSaveData](struct_tale_worlds_1_1_core_1_1_agent_save_data.html)>() |

