--- SOURCE: class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html ---

SandBox.CampaignBehaviors.BoardGameCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#a62d8846f06e7f4061971f52d31273d9d) () |
| override void | [SyncData](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#a69f0a8aff92446449967383822543562) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnSessionLaunched](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#ab79d0db773fd9a1134ad138fcb78f3b8) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| void | [InitializeConversationVars](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#af773c42225ca77aa9fa4d25e8061130f) () |
| void | [OnMissionStarted](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#a379b208780dc911af52b60ddd55f8046) ([IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) mission) |
| void | [OnHeroKilled](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#a32c86810da126e48a1c0271a41cb32d1) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) victim, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) killer, [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) detail, bool showNotification=true) |
| void | [PlayerWonAgainstTavernChampion](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#aa93563480b644d2a4fafa554c2bd3666) () |
| void | [SetBetAmount](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#ac41674f418fcf7ff8641a94e93c6b8e6) (int bet) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [taverngamehost\_player\_sitting\_now\_on\_condition](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#a94627be7b1b66257776ff09a0a9bbbc8) () |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddDialogs](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#ae4933d05abb6defb255bf1e9d80e221d) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |

|  |  |
| --- | --- |
| Properties | |
| IEnumerable< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [WonBoardGamesInOneWeekInSettlement](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#ae6d06df7411ca4de1048e82697dea189) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#a62d8846f06e7f4061971f52d31273d9d)RegisterEvents()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.BoardGameCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#a69f0a8aff92446449967383822543562)SyncData()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void SandBox.CampaignBehaviors.BoardGameCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#ab79d0db773fd9a1134ad138fcb78f3b8)OnSessionLaunched()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.BoardGameCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#af773c42225ca77aa9fa4d25e8061130f)InitializeConversationVars()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.BoardGameCampaignBehavior.InitializeConversationVars | ( |  | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#a379b208780dc911af52b60ddd55f8046)OnMissionStarted()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.BoardGameCampaignBehavior.OnMissionStarted | ( | [IMission](interface_tale_worlds_1_1_core_1_1_i_mission.html) | *mission* | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#a32c86810da126e48a1c0271a41cb32d1)OnHeroKilled()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.BoardGameCampaignBehavior.OnHeroKilled | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *victim*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *killer*, |
|  |  | [KillCharacterAction.KillCharacterActionDetail](class_tale_worlds_1_1_campaign_system_1_1_actions_1_1_kill_character_action.html#ac3c76f0cf50d7184c3ed2e7339b824d1) | *detail*, |
|  |  | bool | *showNotification* = true ) |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#ae4933d05abb6defb255bf1e9d80e221d)AddDialogs()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.CampaignBehaviors.BoardGameCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  | | protected |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#a94627be7b1b66257776ff09a0a9bbbc8)taverngamehost\_player\_sitting\_now\_on\_condition()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool SandBox.CampaignBehaviors.BoardGameCampaignBehavior.taverngamehost\_player\_sitting\_now\_on\_condition | ( |  | ) |  | | static |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#aa93563480b644d2a4fafa554c2bd3666)PlayerWonAgainstTavernChampion()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.BoardGameCampaignBehavior.PlayerWonAgainstTavernChampion | ( |  | ) |  |

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#ac41674f418fcf7ff8641a94e93c6b8e6)SetBetAmount()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.CampaignBehaviors.BoardGameCampaignBehavior.SetBetAmount | ( | int | *bet* | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_campaign_behaviors_1_1_board_game_campaign_behavior.html#ae6d06df7411ca4de1048e82697dea189)WonBoardGamesInOneWeekInSettlement
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html)> SandBox.CampaignBehaviors.BoardGameCampaignBehavior.WonBoardGamesInOneWeekInSettlement | | get |

