--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_military_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiMilitaryBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_military_behavior.html#af3a7c3545f8b06fa39bf103b4521b01c) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_military_behavior.html#aaf06ef475931186dbf71b5e138e9fe3c) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [FindBestTargetAndItsValueForFaction](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_military_behavior.html#a8902845b6d5ea7beb18343e09102f7df) ([Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) missionType, [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) p, float ourStrength, float newArmyCreatingAdditionalConstant=1.0f) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_military_behavior.html#af3a7c3545f8b06fa39bf103b4521b01c)RegisterEvents()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiMilitaryBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_military_behavior.html#aaf06ef475931186dbf71b5e138e9fe3c)SyncData()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiMilitaryBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_ai_behaviors_1_1_ai_military_behavior.html#a8902845b6d5ea7beb18343e09102f7df)FindBestTargetAndItsValueForFaction()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.AiBehaviors.AiMilitaryBehavior.FindBestTargetAndItsValueForFaction | ( | [Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) | *missionType*, |
|  |  | [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html) | *p*, |
|  |  | float | *ourStrength*, |
|  |  | float | *newArmyCreatingAdditionalConstant* = 1::0f ) |

