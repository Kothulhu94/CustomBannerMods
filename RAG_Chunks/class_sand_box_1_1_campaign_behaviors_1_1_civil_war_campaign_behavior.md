--- SOURCE: class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html ---

SandBox.CampaignBehaviors.CivilWarCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.ICivilWarCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_civil_war_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html#a4a11be06e002a4fad5fc88c48ed5c053) () |
| override void | [SyncData](class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html#ab95718ec61b47706a184168e015bb290) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| bool | [IsThereOnGoingCivilWar](class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html#ad0b3dee426cdb4353b8d9bec00005aa5) () |
| bool | [IsFactionSeceeding](class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html#a5bad444c43007260ed0f51f6d9b91f21) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
| bool | [IsFactionIsInACivilWar](class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html#ae6542e84a0e5d350fa389886d1422f5f) ([IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) faction) |
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

[◆](class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html#a4a11be06e002a4fad5fc88c48ed5c053)RegisterEvents()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.CivilWarCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html#ab95718ec61b47706a184168e015bb290)SyncData()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.CivilWarCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html#ad0b3dee426cdb4353b8d9bec00005aa5)IsThereOnGoingCivilWar()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.CampaignBehaviors.CivilWarCampaignBehavior.IsThereOnGoingCivilWar | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICivilWarCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_civil_war_campaign_behavior.html#a856786864c5e0913896c8e20193e96e6).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html#a5bad444c43007260ed0f51f6d9b91f21)IsFactionSeceeding()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.CampaignBehaviors.CivilWarCampaignBehavior.IsFactionSeceeding | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICivilWarCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_civil_war_campaign_behavior.html#af5f0efe6fe777f477115f49182b02ce7).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_civil_war_campaign_behavior.html#ae6542e84a0e5d350fa389886d1422f5f)IsFactionIsInACivilWar()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool SandBox.CampaignBehaviors.CivilWarCampaignBehavior.IsFactionIsInACivilWar | ( | [IFaction](interface_tale_worlds_1_1_campaign_system_1_1_i_faction.html) | *faction* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.ICivilWarCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_civil_war_campaign_behavior.html#aafc4057616176019bd6fd0af69f07245).

