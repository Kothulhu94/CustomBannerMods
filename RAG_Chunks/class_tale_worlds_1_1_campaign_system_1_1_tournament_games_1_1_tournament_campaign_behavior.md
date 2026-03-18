--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html ---

TaleWorlds.CampaignSystem.TournamentGames.TournamentCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#a410b54bd352dd1b1da983efeb80d9e3a) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#a1631deb8089079d814e61aad804285cc) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [OnSessionLaunched](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#af25a4e613b6da050a23bcfe344180980) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameStarter) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [game\_menu\_ui\_town\_arena\_see\_leaderboard\_on\_consequence](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#ab76d20d0a00cb763230f0c7283d1ece7) ([MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) args) |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [AddDialogs](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#a93ab5cdc3d4b79ddfc0cfe01ff361b00) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameSystemStarter) |
| void | [AddGameMenus](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#a70d0c44e746698b83c27cb162bc40147) ([CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) campaignGameSystemStarter) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#a410b54bd352dd1b1da983efeb80d9e3a)RegisterEvents()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.TournamentGames.TournamentCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#a1631deb8089079d814e61aad804285cc)SyncData()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.TournamentGames.TournamentCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#af25a4e613b6da050a23bcfe344180980)OnSessionLaunched()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentCampaignBehavior.OnSessionLaunched | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameStarter* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#a93ab5cdc3d4b79ddfc0cfe01ff361b00)AddDialogs()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.TournamentGames.TournamentCampaignBehavior.AddDialogs | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameSystemStarter* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#a70d0c44e746698b83c27cb162bc40147)AddGameMenus()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.TournamentGames.TournamentCampaignBehavior.AddGameMenus | ( | [CampaignGameStarter](class_tale_worlds_1_1_campaign_system_1_1_campaign_game_starter.html) | *campaignGameSystemStarter* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_campaign_behavior.html#ab76d20d0a00cb763230f0c7283d1ece7)game\_menu\_ui\_town\_arena\_see\_leaderboard\_on\_consequence()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.TournamentGames.TournamentCampaignBehavior.game\_menu\_ui\_town\_arena\_see\_leaderboard\_on\_consequence | ( | [MenuCallbackArgs](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_menu_callback_args.html) | *args* | ) |  | | static |

