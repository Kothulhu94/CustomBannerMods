--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html ---

TaleWorlds.CampaignSystem.TournamentGames.TournamentRound Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TournamentRound](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#a6ed88646ead3ba7c3414f49cdc7018f9) (int participantCount, int numberOfMatches, int numberOfTeamsPerMatch, int numberOfWinnerParticipants, [TournamentGame.QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) qualificationMode) |
| void | [OnMatchEnded](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#af4ad318a6a3ce84674ad4b0cd2e2e96f) () |
| void | [EndMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#a97b6219bea0f2e3c734fdecf6f356224) () |
| void | [AddParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#a8c316fcd28af8ebdd4ca9344ea7ba189) ([TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html) participant, bool firstTime=false) |

|  |  |
| --- | --- |
| Properties | |
| [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html)[] | [Matches](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#a79e65d84a480b00688a15d8663c91616) `[get]` |
| int | [CurrentMatchIndex](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#a9f4cfa5b2c11dc9beb29549cd2cda3d6) `[get]` |
| [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) | [CurrentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#af01e2fd290341e8419b464624840dc12) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#a6ed88646ead3ba7c3414f49cdc7018f9)TournamentRound()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.TournamentGames.TournamentRound.TournamentRound | ( | int | *participantCount*, |
|  |  | int | *numberOfMatches*, |
|  |  | int | *numberOfTeamsPerMatch*, |
|  |  | int | *numberOfWinnerParticipants*, |
|  |  | [TournamentGame.QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) | *qualificationMode* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#af4ad318a6a3ce84674ad4b0cd2e2e96f)OnMatchEnded()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentRound.OnMatchEnded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#a97b6219bea0f2e3c734fdecf6f356224)EndMatch()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentRound.EndMatch | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#a8c316fcd28af8ebdd4ca9344ea7ba189)AddParticipant()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentRound.AddParticipant | ( | [TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html) | *participant*, |
|  |  | bool | *firstTime* = false ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#a79e65d84a480b00688a15d8663c91616)Matches
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) [] TaleWorlds.CampaignSystem.TournamentGames.TournamentRound.Matches | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#a9f4cfa5b2c11dc9beb29549cd2cda3d6)CurrentMatchIndex
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.TournamentGames.TournamentRound.CurrentMatchIndex | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_round.html#af01e2fd290341e8419b464624840dc12)CurrentMatch
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) TaleWorlds.CampaignSystem.TournamentGames.TournamentRound.CurrentMatch | | get |

