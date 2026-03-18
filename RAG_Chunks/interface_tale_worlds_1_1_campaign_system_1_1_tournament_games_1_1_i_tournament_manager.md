--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html ---

TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager Interface ReferenceInherited by [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [AddTournament](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a4e5e26456327e53416bca9458a6f379a) ([TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) game) |
| [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | [GetTournamentGame](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#af4f586e38e2ca71c11a35741196fd430) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| void | [OnPlayerJoinMatch](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a2cf7ec2b562c7b96fe6d1479f0a2030b) (Type gameType) |
| void | [OnPlayerJoinTournament](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#ac8a08415e2e9a28542c0837990e02a1c) (Type gameType, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [OnPlayerWatchTournament](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a114039aef004eff4347b65976785e747) (Type gameType, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [OnPlayerWinMatch](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a4a729ec7626724c09c867c82393f68fe) (Type gameType) |
| void | [OnPlayerWinTournament](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a59936b3d00caf0d4425e01ef53335865) (Type gameType) |
| void | [InitializeLeaderboardEntry](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#ae5a2a11005fa32f199294b8efb1c66a6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int initialVictories=0) |
| void | [AddLeaderboardEntry](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#afc3e9597eaa75b503315254fa170ca29) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [GivePrizeToWinner](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#af18cf0add532b464e691b6f271d39158) ([TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) tournament, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winner, bool isPlayerParticipated) |
| void | [DeleteLeaderboardEntry](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a2ccbeebcf384d5bbcbc8414193b49b4d) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| List< KeyValuePair< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > > | [GetLeaderboard](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a33f523202dc2766e63e60d0628b4de3d) () |
| int | [GetLeaderBoardRank](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a2345bd10041ab1ccdd3e6b2ae69f12c3) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetLeaderBoardLeader](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a8c715dbca3aac483a114c9fcf8ecf645) () |
| void | [ResolveTournament](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a09d3f7c55f393a1ddd5ab5e9ccf69d6e) ([TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) tournament, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a4e5e26456327e53416bca9458a6f379a)AddTournament()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.AddTournament | ( | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | *game* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#ad6688eb17f7e849704dcc5fa0eb74d60).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#af4f586e38e2ca71c11a35741196fd430)GetTournamentGame()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.GetTournamentGame | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a7c1dbfcd381b0cd0a4ec6f31a01570cd).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a2cf7ec2b562c7b96fe6d1479f0a2030b)OnPlayerJoinMatch()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.OnPlayerJoinMatch | ( | Type | *gameType* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a5387d812cc3a1569929a62b23253e6b2).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#ac8a08415e2e9a28542c0837990e02a1c)OnPlayerJoinTournament()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.OnPlayerJoinTournament | ( | Type | *gameType*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a345e600c717b0648a110142d6ae58e4e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a114039aef004eff4347b65976785e747)OnPlayerWatchTournament()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.OnPlayerWatchTournament | ( | Type | *gameType*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a9422ccf988d50dd966559f7bae1559e3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a4a729ec7626724c09c867c82393f68fe)OnPlayerWinMatch()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.OnPlayerWinMatch | ( | Type | *gameType* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a45495880824ee223068d63bdbe8099a5).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a59936b3d00caf0d4425e01ef53335865)OnPlayerWinTournament()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.OnPlayerWinTournament | ( | Type | *gameType* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#ada753a21183095f15cbfc11724bc1c09).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#ae5a2a11005fa32f199294b8efb1c66a6)InitializeLeaderboardEntry()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.InitializeLeaderboardEntry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | int | *initialVictories* = 0 ) |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a7c491bd952cf517aa02f4f3d00931b9c).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#afc3e9597eaa75b503315254fa170ca29)AddLeaderboardEntry()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.AddLeaderboardEntry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a4e42118323ee2c1b788de232790d09c8).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#af18cf0add532b464e691b6f271d39158)GivePrizeToWinner()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.GivePrizeToWinner | ( | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | *tournament*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winner*, |
|  |  | bool | *isPlayerParticipated* ) |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a54d568a20a88132c0cc76ef922a87ec3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a2ccbeebcf384d5bbcbc8414193b49b4d)DeleteLeaderboardEntry()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.DeleteLeaderboardEntry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a3a0f04e6408db2ddc85ccdea07fdfb97).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a33f523202dc2766e63e60d0628b4de3d)GetLeaderboard()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< KeyValuePair< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > > TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.GetLeaderboard | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#ab8c20487430b1701e77bb23595ab9be3).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a2345bd10041ab1ccdd3e6b2ae69f12c3)GetLeaderBoardRank()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.GetLeaderBoardRank | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a543f6cd8e1ccab7aba5c09dfbe587aae).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a8c715dbca3aac483a114c9fcf8ecf645)GetLeaderBoardLeader()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.GetLeaderBoardLeader | ( |  | ) |  |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a3c839c9d85825de822cfcecbc9b3d6a0).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a09d3f7c55f393a1ddd5ab5e9ccf69d6e)ResolveTournament()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager.ResolveTournament | ( | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | *tournament*, |
|  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) |

Implemented in [TaleWorlds.CampaignSystem.TournamentGames.TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a3bba320657d8af904af9f0933311ffba).

