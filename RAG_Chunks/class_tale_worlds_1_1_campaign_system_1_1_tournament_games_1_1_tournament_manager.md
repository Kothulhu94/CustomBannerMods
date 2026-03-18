--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html ---

TaleWorlds.CampaignSystem.TournamentGames.TournamentManager Class ReferenceInherits [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TournamentManager](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a6e8dafe1f7e8f32d571a7ed31c73e23b) () |
| void | [AddTournament](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#ad6688eb17f7e849704dcc5fa0eb74d60) ([TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) game) |
| void | [RemoveTournament](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a99c31ed8dd3a07e5542486a24327269e) ([TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) game) |
| [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | [GetTournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a7c1dbfcd381b0cd0a4ec6f31a01570cd) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| void | [OnPlayerJoinMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a5387d812cc3a1569929a62b23253e6b2) (Type gameType) |
| void | [OnPlayerJoinTournament](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a345e600c717b0648a110142d6ae58e4e) (Type gameType, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [OnPlayerWatchTournament](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a9422ccf988d50dd966559f7bae1559e3) (Type gameType, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [OnPlayerWinMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a45495880824ee223068d63bdbe8099a5) (Type gameType) |
| void | [OnPlayerWinTournament](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#ada753a21183095f15cbfc11724bc1c09) (Type gameType) |
| List< KeyValuePair< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > > | [GetLeaderboard](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#ab8c20487430b1701e77bb23595ab9be3) () |
| int | [GetLeaderBoardRank](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a543f6cd8e1ccab7aba5c09dfbe587aae) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [GetLeaderBoardLeader](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a3c839c9d85825de822cfcecbc9b3d6a0) () |
| void | [InitializeLeaderboardEntry](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a7c491bd952cf517aa02f4f3d00931b9c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int initialVictories=0) |
| void | [AddLeaderboardEntry](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a4e42118323ee2c1b788de232790d09c8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [DeleteLeaderboardEntry](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a3a0f04e6408db2ddc85ccdea07fdfb97) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| void | [ResolveTournament](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a3bba320657d8af904af9f0933311ffba) ([TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) tournament, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| void | [GivePrizeToWinner](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a54d568a20a88132c0cc76ef922a87ec3) ([TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) tournament, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winner, bool isPlayerParticipated) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a6e8dafe1f7e8f32d571a7ed31c73e23b)TournamentManager()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.TournamentManager | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#ad6688eb17f7e849704dcc5fa0eb74d60)AddTournament()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.AddTournament | ( | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | *game* | ) |  |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a4e5e26456327e53416bca9458a6f379a).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a99c31ed8dd3a07e5542486a24327269e)RemoveTournament()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.RemoveTournament | ( | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | *game* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a7c1dbfcd381b0cd0a4ec6f31a01570cd)GetTournamentGame()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.GetTournamentGame | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#af4f586e38e2ca71c11a35741196fd430).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a5387d812cc3a1569929a62b23253e6b2)OnPlayerJoinMatch()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.OnPlayerJoinMatch | ( | Type | *gameType* | ) |  |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a2cf7ec2b562c7b96fe6d1479f0a2030b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a345e600c717b0648a110142d6ae58e4e)OnPlayerJoinTournament()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.OnPlayerJoinTournament | ( | Type | *gameType*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#ac8a08415e2e9a28542c0837990e02a1c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a9422ccf988d50dd966559f7bae1559e3)OnPlayerWatchTournament()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.OnPlayerWatchTournament | ( | Type | *gameType*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a114039aef004eff4347b65976785e747).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a45495880824ee223068d63bdbe8099a5)OnPlayerWinMatch()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.OnPlayerWinMatch | ( | Type | *gameType* | ) |  |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a4a729ec7626724c09c867c82393f68fe).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#ada753a21183095f15cbfc11724bc1c09)OnPlayerWinTournament()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.OnPlayerWinTournament | ( | Type | *gameType* | ) |  |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a59936b3d00caf0d4425e01ef53335865).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#ab8c20487430b1701e77bb23595ab9be3)GetLeaderboard()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< KeyValuePair< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html), int > > TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.GetLeaderboard | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a33f523202dc2766e63e60d0628b4de3d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a543f6cd8e1ccab7aba5c09dfbe587aae)GetLeaderBoardRank()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.GetLeaderBoardRank | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a2345bd10041ab1ccdd3e6b2ae69f12c3).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a3c839c9d85825de822cfcecbc9b3d6a0)GetLeaderBoardLeader()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.GetLeaderBoardLeader | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a8c715dbca3aac483a114c9fcf8ecf645).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a7c491bd952cf517aa02f4f3d00931b9c)InitializeLeaderboardEntry()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.InitializeLeaderboardEntry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | int | *initialVictories* = 0 ) |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#ae5a2a11005fa32f199294b8efb1c66a6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a4e42118323ee2c1b788de232790d09c8)AddLeaderboardEntry()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.AddLeaderboardEntry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#afc3e9597eaa75b503315254fa170ca29).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a3a0f04e6408db2ddc85ccdea07fdfb97)DeleteLeaderboardEntry()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.DeleteLeaderboardEntry | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a2ccbeebcf384d5bbcbc8414193b49b4d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a3bba320657d8af904af9f0933311ffba)ResolveTournament()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.ResolveTournament | ( | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | *tournament*, |
|  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#a09d3f7c55f393a1ddd5ab5e9ccf69d6e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_manager.html#a54d568a20a88132c0cc76ef922a87ec3)GivePrizeToWinner()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentManager.GivePrizeToWinner | ( | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | *tournament*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winner*, |
|  |  | bool | *isPlayerParticipated* ) |

Implements [TaleWorlds.CampaignSystem.TournamentGames.ITournamentManager](interface_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_i_tournament_manager.html#af18cf0add532b464e691b6f271d39158).

