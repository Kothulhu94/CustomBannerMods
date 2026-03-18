--- SOURCE: interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html ---

SandBox.Tournaments.ITournamentGameBehavior Interface ReferenceInherited by [SandBox.Tournaments.MissionLogics.TournamentArcheryMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_archery_mission_controller.html), [SandBox.Tournaments.MissionLogics.TournamentFightMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_fight_mission_controller.html), [SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html), and [SandBox.Tournaments.MissionLogics.TownHorseRaceMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_town_horse_race_mission_controller.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [StartMatch](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#ac5643da94fdafc656b12114f3ceef49b) ([TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) match, bool isLastRound) |
| void | [SkipMatch](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#a7a0ee090e74a072417c9f3ce00bc653f) ([TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) match) |
| bool | [IsMatchEnded](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#ad30da905f5159eb7cb5553a415bcc9eb) () |
| void | [OnMatchEnded](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#a0c303ce7e640229731602a6f945a5a45) () |

Member Function Documentation
-----------------------------

[◆](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#ac5643da94fdafc656b12114f3ceef49b)StartMatch()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.Tournaments.ITournamentGameBehavior.StartMatch | ( | [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) | *match*, |
|  |  | bool | *isLastRound* ) |

Implemented in [SandBox.Tournaments.MissionLogics.TournamentArcheryMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_archery_mission_controller.html#ae50e623680169d18702f6b997b81d608), [SandBox.Tournaments.MissionLogics.TournamentFightMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_fight_mission_controller.html#a29067e85677b26d3604d71dff880ce25), [SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#aa7e0a5e65c3b386aa86c51c8faf2e054), and [SandBox.Tournaments.MissionLogics.TownHorseRaceMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_town_horse_race_mission_controller.html#abc1cb842d21d7862f0edc7165d5205e9).

[◆](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#a7a0ee090e74a072417c9f3ce00bc653f)SkipMatch()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.Tournaments.ITournamentGameBehavior.SkipMatch | ( | [TournamentMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_match.html) | *match* | ) |  |

Implemented in [SandBox.Tournaments.MissionLogics.TournamentArcheryMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_archery_mission_controller.html#a47df2d0583d9be69b35a351486616f73), [SandBox.Tournaments.MissionLogics.TournamentFightMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_fight_mission_controller.html#af9c013d6d89ab1941f2edfba0abc7081), [SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a72cc3d072563d41210015f87141005cc), and [SandBox.Tournaments.MissionLogics.TownHorseRaceMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_town_horse_race_mission_controller.html#aee41c2998bfd92989f3edfdc463b916b).

[◆](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#ad30da905f5159eb7cb5553a415bcc9eb)IsMatchEnded()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool SandBox.Tournaments.ITournamentGameBehavior.IsMatchEnded | ( |  | ) |  |

Implemented in [SandBox.Tournaments.MissionLogics.TournamentArcheryMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_archery_mission_controller.html#abe0b3c790bc2948e7d8f3062ae890164), [SandBox.Tournaments.MissionLogics.TournamentFightMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_fight_mission_controller.html#a27fbd30d3b0e2fc4e8a938b975ae0777), [SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#ae6f7b75b0862ccd84e29f46538ff2435), and [SandBox.Tournaments.MissionLogics.TownHorseRaceMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_town_horse_race_mission_controller.html#a7185e077782e16f23b1bb181db9b5b4f).

[◆](interface_sand_box_1_1_tournaments_1_1_i_tournament_game_behavior.html#a0c303ce7e640229731602a6f945a5a45)OnMatchEnded()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.Tournaments.ITournamentGameBehavior.OnMatchEnded | ( |  | ) |  |

Implemented in [SandBox.Tournaments.MissionLogics.TournamentArcheryMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_archery_mission_controller.html#a21a8242fd986f082f0aef058ee54e90f), [SandBox.Tournaments.MissionLogics.TournamentFightMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_fight_mission_controller.html#a567b15c72c34099507860e5bb9be5bee), [SandBox.Tournaments.MissionLogics.TournamentJoustingMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_tournament_jousting_mission_controller.html#a147c9dce4514ed816a830a18938c2593), and [SandBox.Tournaments.MissionLogics.TownHorseRaceMissionController](class_sand_box_1_1_tournaments_1_1_mission_logics_1_1_town_horse_race_mission_controller.html#afe3a9f4cfc2ff24a5a7141e71e2fecd9).

