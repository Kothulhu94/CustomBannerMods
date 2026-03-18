--- SOURCE: class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html ---

SandBox.CampaignBehaviors.TavernEmployeesCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#a8d1834b55e7ff69098ad812e0e63599e) () |
| override void | [SyncData](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#a2e7a3795776295514759d447173dd24f) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [DailyTick](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#a75ea60d4088d49d0c6a251d41c89a570) () |
| void | [WeeklyTick](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#a38657468a5c85ec759484fd58f321d6a) () |
| void | [OnSessionLaunched](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#a9ffd49b6634fe0368206fcb0c3c44a31) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| void | [OnMissionStarted](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#afa7de3af4aa5703c7105a3e6c9d6565b) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) mission) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddDialogs](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#aac29a54d73fa3cd39899f120f4380138) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) cgs) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#a8d1834b55e7ff69098ad812e0e63599e)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.TavernEmployeesCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#a2e7a3795776295514759d447173dd24f)SyncData()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.TavernEmployeesCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#a75ea60d4088d49d0c6a251d41c89a570)DailyTick()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.TavernEmployeesCampaignBehavior.DailyTick | ( |  | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#a38657468a5c85ec759484fd58f321d6a)WeeklyTick()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.TavernEmployeesCampaignBehavior.WeeklyTick | ( |  | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#a9ffd49b6634fe0368206fcb0c3c44a31)OnSessionLaunched()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.TavernEmployeesCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#afa7de3af4aa5703c7105a3e6c9d6565b)OnMissionStarted()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.TavernEmployeesCampaignBehavior.OnMissionStarted | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *mission* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_tavern_employees_campaign_behavior.html#aac29a54d73fa3cd39899f120f4380138)AddDialogs()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.TavernEmployeesCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *cgs* | ) |  | | protected |

