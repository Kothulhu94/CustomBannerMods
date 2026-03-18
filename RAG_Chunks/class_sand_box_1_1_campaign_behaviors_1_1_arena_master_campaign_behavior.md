--- SOURCE: class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html ---

SandBox.CampaignBehaviors.ArenaMasterCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#a50427c828ffea77bf1da91165ead4fae) () |
| override void | [SyncData](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#ab91ba7b170bae7e04091c6c42b9848cb) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnSessionLaunched](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#aa1864173ddf15fcdbdb35b5958246faa) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| void | [OnSettlementEntered](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#aea8ae3cfc283e5b22995b9380cc85b4f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [conversation\_tournament\_soon\_on\_condition](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#a46a11fcd9a6a2e6343d5cf382342a700) () |
| static void | [conversation\_arena\_join\_tournament\_on\_consequence](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#aff1488bfb1864038b919ad5e0cf8b625) () |
| static void | [conversation\_arena\_join\_fight\_on\_consequence](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#adbfd3c0639cd1b21a74abc46f2a32f93) () |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddDialogs](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#ae2438e6c62f525c67c1af478dd30313f) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#a50427c828ffea77bf1da91165ead4fae)RegisterEvents()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.ArenaMasterCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#ab91ba7b170bae7e04091c6c42b9848cb)SyncData()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.ArenaMasterCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#aa1864173ddf15fcdbdb35b5958246faa)OnSessionLaunched()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.ArenaMasterCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#aea8ae3cfc283e5b22995b9380cc85b4f)OnSettlementEntered()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.ArenaMasterCampaignBehavior.OnSettlementEntered | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* ) |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#ae2438e6c62f525c67c1af478dd30313f)AddDialogs()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.ArenaMasterCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#a46a11fcd9a6a2e6343d5cf382342a700)conversation\_tournament\_soon\_on\_condition()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.CampaignBehaviors.ArenaMasterCampaignBehavior.conversation\_tournament\_soon\_on\_condition | ( |  | ) |  | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#aff1488bfb1864038b919ad5e0cf8b625)conversation\_arena\_join\_tournament\_on\_consequence()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.ArenaMasterCampaignBehavior.conversation\_arena\_join\_tournament\_on\_consequence | ( |  | ) |  | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_arena_master_campaign_behavior.html#adbfd3c0639cd1b21a74abc46f2a32f93)conversation\_arena\_join\_fight\_on\_consequence()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.ArenaMasterCampaignBehavior.conversation\_arena\_join\_fight\_on\_consequence | ( |  | ) |  | | static |

