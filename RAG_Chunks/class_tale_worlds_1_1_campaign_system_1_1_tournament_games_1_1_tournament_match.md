--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html ---

TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [MatchState](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#adcffa88050ab547dc52d9a98aa18fbc4) {     [Ready](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#adcffa88050ab547dc52d9a98aa18fbc4ae7d31fc0602fb2ede144d18cdffd816b) ,     [Started](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#adcffa88050ab547dc52d9a98aa18fbc4a8428552d86c0d262a542a528af490afa) ,     [Finished](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#adcffa88050ab547dc52d9a98aa18fbc4a8f3d10eb21bd36347c258679eba9e92b)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#aec61ad521761db7ee6e154fc3423955b) (int participantCount, int numberOfTeamsPerMatch, int numberOfWinnerParticipants, [TournamentGame.QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) qualificationMode) |
| void | [End](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a8a9ddbbc55b4f1b74e2d6bc702c81f5e) () |
| void | [Start](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a56af5dee3a0cb7a6e1f2384dee546f5c) () |
| [TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html) | [GetParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a1f4785cf4d2dbd46b9e175802b605ccd) (int uniqueSeed) |
| bool | [IsParticipantRequired](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#aaf1e76244b8ac47294fc9b3c742a132a) () |
| void | [AddParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#afb6e96dc0f491300d91f197959fbf2bf) ([TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html) participant, bool firstTime) |
| bool | [IsPlayerParticipating](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#ad733040fbc2160e80083dbc4f66cee16) () |
| bool | [IsPlayerWinner](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a0c6d12f44e2f3bc75524487bb1fda348) () |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [TournamentGame.QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) | [QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a437efae8eab812c50a74796bf4e4a421) |

|  |  |
| --- | --- |
| Properties | |
| IEnumerable< [TournamentTeam](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_team.html) > | [Teams](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#ade29e77a15e3d76454ae5877451782f2) `[get]` |
| IEnumerable< [TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html) > | [Participants](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a39eb2f4850d33b6965b28fd15d147be6) `[get]` |
| [MatchState](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#adcffa88050ab547dc52d9a98aa18fbc4) | [State](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#ae458d96424f0b7b912ba0a167d81155a) `[get]` |
| IEnumerable< [TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html) > | [Winners](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#aa61a39f9ca01f9369fa536b2addcc6b1) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a4b1762343948922004aef71873867063) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#adcffa88050ab547dc52d9a98aa18fbc4)MatchState
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.MatchState](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#adcffa88050ab547dc52d9a98aa18fbc4) |

| Enumerator | |
| --- | --- |
| Ready |  |
| Started |  |
| Finished |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#aec61ad521761db7ee6e154fc3423955b)TournamentMatch()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.TournamentMatch | ( | int | *participantCount*, |
|  |  | int | *numberOfTeamsPerMatch*, |
|  |  | int | *numberOfWinnerParticipants*, |
|  |  | [TournamentGame.QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) | *qualificationMode* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a8a9ddbbc55b4f1b74e2d6bc702c81f5e)End()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.End | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a56af5dee3a0cb7a6e1f2384dee546f5c)Start()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.Start | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a1f4785cf4d2dbd46b9e175802b605ccd)GetParticipant()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html) TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.GetParticipant | ( | int | *uniqueSeed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#aaf1e76244b8ac47294fc9b3c742a132a)IsParticipantRequired()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.IsParticipantRequired | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#afb6e96dc0f491300d91f197959fbf2bf)AddParticipant()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.AddParticipant | ( | [TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html) | *participant*, |
|  |  | bool | *firstTime* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#ad733040fbc2160e80083dbc4f66cee16)IsPlayerParticipating()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.IsPlayerParticipating | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a0c6d12f44e2f3bc75524487bb1fda348)IsPlayerWinner()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.IsPlayerWinner | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a437efae8eab812c50a74796bf4e4a421)QualificationMode
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [TournamentGame.QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.QualificationMode |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#ade29e77a15e3d76454ae5877451782f2)Teams
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[TournamentTeam](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_team.html)> TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.Teams | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a39eb2f4850d33b6965b28fd15d147be6)Participants
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html)> TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.Participants | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#ae458d96424f0b7b912ba0a167d81155a)State
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatchState](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#adcffa88050ab547dc52d9a98aa18fbc4) TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.State | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#aa61a39f9ca01f9369fa536b2addcc6b1)Winners
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<[TournamentParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_participant.html)> TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.Winners | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html#a4b1762343948922004aef71873867063)IsReady
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.TournamentGames.TournamentMatch.IsReady | | get |

