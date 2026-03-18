--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.OrderOfBattleCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Classes | |
| class | [OrderOfBattleFormationData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavi392608b1df454462902eb56a9c5aa58b.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [OrderOfBattleCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html#ad069660a4ff2886845675fcb20273572) () |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html#a29cf94f63e079a6f4238368221c6ddc0) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html#a58ac991046282dec268a13a34a0620fa) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| [OrderOfBattleFormationData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavi392608b1df454462902eb56a9c5aa58b.html) | [GetFormationDataAtIndex](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html#a6235bf27ec1b0b3f3888df41249abc9c) (int formationIndex, bool isSiegeBattle, bool isInArmy) |
| void | [SetFormationInfos](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html#ac39215f801f9d130b708ae943809d730) (List< [OrderOfBattleFormationData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavi392608b1df454462902eb56a9c5aa58b.html) > formationInfos, bool isSiegeBattle, bool isInArmy) |
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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html#ad069660a4ff2886845675fcb20273572)OrderOfBattleCampaignBehavior()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.CampaignBehaviors.OrderOfBattleCampaignBehavior.OrderOfBattleCampaignBehavior | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html#a29cf94f63e079a6f4238368221c6ddc0)RegisterEvents()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.OrderOfBattleCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html#a58ac991046282dec268a13a34a0620fa)SyncData()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.OrderOfBattleCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html#a6235bf27ec1b0b3f3888df41249abc9c)GetFormationDataAtIndex()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [OrderOfBattleFormationData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavi392608b1df454462902eb56a9c5aa58b.html) TaleWorlds.CampaignSystem.CampaignBehaviors.OrderOfBattleCampaignBehavior.GetFormationDataAtIndex | ( | int | *formationIndex*, |
|  |  | bool | *isSiegeBattle*, |
|  |  | bool | *isInArmy* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavior.html#ac39215f801f9d130b708ae943809d730)SetFormationInfos()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.OrderOfBattleCampaignBehavior.SetFormationInfos | ( | List< [OrderOfBattleFormationData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_order_of_battle_campaign_behavi392608b1df454462902eb56a9c5aa58b.html) > | *formationInfos*, |
|  |  | bool | *isSiegeBattle*, |
|  |  | bool | *isInArmy* ) |

