--- SOURCE: class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html ---

SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a8fe8fa3fe761d5824c705492322955fc) () |
| override void | [SyncData](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a965fd223aa54e3a4875ac8d578ca7149) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnSessionLaunched](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a8fc3c1b54ae00c4cb541ee4ac0efbf20) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| void | [OnSettlementOwnerChanged](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a43abc5ac7d00c88cd9a1f218bd638f29) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool openToClaim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) newOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) oldOwner, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) capturerHero, ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail detail) |
| bool | [conversation\_town\_or\_village\_escort\_complete\_on\_condition](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a97f62eb09c0bcb25a033d2c5b3cd5e65) () |
| void | [conversation\_town\_or\_village\_escort\_complete\_on\_consequence](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a15777efb64b200e6b4866f44558fd92a) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [VillagerSpawnPercentageMale](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#acddaeedb7399479b9046c9f2167e717c) = 0.25f |
| const float | [VillagerSpawnPercentageFemale](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a9a28617b497c7009684b15dfecb98ed2) = 0.20f |
| const float | [VillagerSpawnPercentageLimited](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#acb7425ab62035ff6b39d29ee87c71327) = 0.2f |
| const float | [VillageOtherPeopleSpawnPercentage](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a70bfd92a8a1f0deb2c6b14020b106eae) = 0.05f |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddDialogs](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#aa3ceb6ac28eb06b2abc57bc6340300c7) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a8fe8fa3fe761d5824c705492322955fc)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a965fd223aa54e3a4875ac8d578ca7149)SyncData()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a8fc3c1b54ae00c4cb541ee4ac0efbf20)OnSessionLaunched()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a43abc5ac7d00c88cd9a1f218bd638f29)OnSettlementOwnerChanged()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.OnSettlementOwnerChanged | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *openToClaim*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *newOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *oldOwner*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *capturerHero*, |
|  |  | ChangeOwnerOfSettlementAction.ChangeOwnerOfSettlementDetail | *detail* ) |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#aa3ceb6ac28eb06b2abc57bc6340300c7)AddDialogs()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a97f62eb09c0bcb25a033d2c5b3cd5e65)conversation\_town\_or\_village\_escort\_complete\_on\_condition()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.conversation\_town\_or\_village\_escort\_complete\_on\_condition | ( |  | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a15777efb64b200e6b4866f44558fd92a)conversation\_town\_or\_village\_escort\_complete\_on\_consequence()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.conversation\_town\_or\_village\_escort\_complete\_on\_consequence | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#acddaeedb7399479b9046c9f2167e717c)VillagerSpawnPercentageMale
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.VillagerSpawnPercentageMale = 0.25f | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a9a28617b497c7009684b15dfecb98ed2)VillagerSpawnPercentageFemale
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.VillagerSpawnPercentageFemale = 0.20f | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#acb7425ab62035ff6b39d29ee87c71327)VillagerSpawnPercentageLimited
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.VillagerSpawnPercentageLimited = 0.2f | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_common_villagers_campaign_behavior.html#a70bfd92a8a1f0deb2c6b14020b106eae)VillageOtherPeopleSpawnPercentage
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float SandBox.CampaignBehaviors.CommonVillagersCampaignBehavior.VillageOtherPeopleSpawnPercentage = 0.05f | | static |

