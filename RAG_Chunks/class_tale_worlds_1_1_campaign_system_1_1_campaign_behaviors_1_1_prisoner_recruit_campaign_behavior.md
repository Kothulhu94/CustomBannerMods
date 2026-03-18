--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.PrisonerRecruitCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#af79f2e865ce5389801d6f18270a539cb) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#a296601e8ddb8fd1a3d01cd934003d7d1) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnSessionLaunched](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#a0ee628c228c5967ec45c96ead224e6ca) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| bool | [conversation\_prisoner\_recruit\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#a89838b713f8a5e80f3183edd26950968) () |
| bool | [conversation\_prisoner\_recruit\_no\_on\_condition](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#ad8840c5a7f0aebb00b44743fd3aea29b) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Public Attributes | |
| Dictionary< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), float > | [PrisonerTalkRecords](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#a09c39558cc5e181ca5f16eafecd32b08) = new Dictionary<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), float>() |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddDialogs](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#ac8ad8c09c5910468de0c32b89b0fce82) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#af79f2e865ce5389801d6f18270a539cb)RegisterEvents()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.PrisonerRecruitCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#a296601e8ddb8fd1a3d01cd934003d7d1)SyncData()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.PrisonerRecruitCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#a0ee628c228c5967ec45c96ead224e6ca)OnSessionLaunched()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.PrisonerRecruitCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#ac8ad8c09c5910468de0c32b89b0fce82)AddDialogs()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.PrisonerRecruitCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#a89838b713f8a5e80f3183edd26950968)conversation\_prisoner\_recruit\_on\_condition()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.PrisonerRecruitCampaignBehavior.conversation\_prisoner\_recruit\_on\_condition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#ad8840c5a7f0aebb00b44743fd3aea29b)conversation\_prisoner\_recruit\_no\_on\_condition()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.PrisonerRecruitCampaignBehavior.conversation\_prisoner\_recruit\_no\_on\_condition | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_prisoner_recruit_campaign_behavior.html#a09c39558cc5e181ca5f16eafecd32b08)PrisonerTalkRecords
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Dictionary<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), float> TaleWorlds.CampaignSystem.CampaignBehaviors.PrisonerRecruitCampaignBehavior.PrisonerTalkRecords = new Dictionary<[CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html), float>() |

