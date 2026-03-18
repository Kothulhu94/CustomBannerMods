--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_retrain_outlaw_party_members_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.RetrainOutlawPartyMembersBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.IRetrainOutlawPartyMembersCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_retrain_outlaw_party_members_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_retrain_outlaw_party_members_behavior.html#a15438230d92ebbc850a01b843bd08c1a) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_retrain_outlaw_party_members_behavior.html#ad448986bc8f871fb79a3ec18b0d2d7d7) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| int | [GetRetrainedNumber](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_retrain_outlaw_party_members_behavior.html#a3c06185c7324327d5f25b29fef43ac21) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| void | [SetRetrainedNumber](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_retrain_outlaw_party_members_behavior.html#aebf57f92f7432535152cfbd4a719816c) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, int number) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_retrain_outlaw_party_members_behavior.html#a15438230d92ebbc850a01b843bd08c1a)RegisterEvents()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.RetrainOutlawPartyMembersBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_retrain_outlaw_party_members_behavior.html#ad448986bc8f871fb79a3ec18b0d2d7d7)SyncData()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.RetrainOutlawPartyMembersBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_retrain_outlaw_party_members_behavior.html#a3c06185c7324327d5f25b29fef43ac21)GetRetrainedNumber()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.CampaignBehaviors.RetrainOutlawPartyMembersBehavior.GetRetrainedNumber | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IRetrainOutlawPartyMembersCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_retrain_outlaw_party_members_campaign_behavior.html#ae09a2f207029a7e45684567f8a86ad8c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_retrain_outlaw_party_members_behavior.html#aebf57f92f7432535152cfbd4a719816c)SetRetrainedNumber()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.RetrainOutlawPartyMembersBehavior.SetRetrainedNumber | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | int | *number* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IRetrainOutlawPartyMembersCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_retrain_outlaw_party_members_campaign_behavior.html#a6d7f776cab8c25a2f2ca4c5ddda43a2b).

