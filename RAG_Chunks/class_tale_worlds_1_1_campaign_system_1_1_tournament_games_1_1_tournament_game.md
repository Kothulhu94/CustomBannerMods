--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html ---

TaleWorlds.CampaignSystem.TournamentGames.TournamentGame Class ReferenceabstractInherited by [TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) {     [IndividualScore](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950ac85eeeaa1d74630f5e1538ef212a048d) ,     [TeamScore](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950a9f6b9dd59346822ecbf4cddb4da60ccb)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetMenuText](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ae16d9e73f4935858e81fd8cad268d497) () |
| void | [OpenMission](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ac2f4f6adc9a56a5d8c3f3215553fbfb2) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool isPlayerParticipating) |
| MBList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [GetParticipantCharacters](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#afa90848ac259c7b3d7d55f7e34d42a70) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includePlayer=true) |
| virtual bool | [CanBeAParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ae2479b0033b9dbea08f003c3cccf2faf) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool considerSkills) |
| void | [PrepareForTournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a8af8122189ac2b020e3965b6311a3465) (bool isPlayerParticipating) |
| void | [UpdateTournamentPrize](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a691414eb773ba7703b062448528ee93a) (bool includePlayer, bool removeCurrentPrize=false) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetTournamentPrize](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aa1969fcccbc2dc57e6fbb75b07d73ebb) (bool includePlayer, int lastRecordedLordCountForTournamentPrize) |
|  | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ac49c0d99587a6d916caa0b8cfa906675) ([Town](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aabe0f7f5ad695c65563cd5b037127a94) town, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) prize=null) |

|  |  |
| --- | --- |
| Protected Attributes | |
| int | [\_lastRecordedLordCountForTournamentPrize](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a300223ef6df57d8551ccef6cd016ab99) |

|  |  |
| --- | --- |
| Properties | |
| Town | [Town](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aabe0f7f5ad695c65563cd5b037127a94) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [CreationTime](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a07816d403ce9a735aaabcb423561c033) `[get]` |
| [QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) | [Mode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aa39d0cba148f9ea05986cb34a7400711) `[get, protected set]` |
| virtual int | [MaxTeamSize](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aadddc7fea7b4760f16be533c8199521b) `[get]` |
|  | Max Team Size always should be a number power of 2. |
| virtual int | [MaxTeamNumberPerMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a198d4d5ff51875c2abcd53d413aee6b4) `[get]` |
|  | MaxTeamNumberPerMatch always should be equal or greater than 2. |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [Prize](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a1464a9fdef356d13f31a278df7747bd1) `[get]` |
| virtual float | [TournamentWinRenown](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a6daadcee2a379876d832ad723ed37eba) `[get]` |
| virtual float | [TournamentWinInfluence](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a76213b8282b4113ee07996b22aed3845) `[get]` |
| int | [RemoveTournamentAfterDays](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ab9ecdecca39bf0919252224dc6640b55) `[get]` |
| int | [MaximumParticipantCount](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a7a985845fd103a84fc49fa224ae0e874) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950)QualificationMode
-------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) |

| Enumerator | |
| --- | --- |
| IndividualScore |  |
| TeamScore |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ac49c0d99587a6d916caa0b8cfa906675)TournamentGame()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.TournamentGame | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aabe0f7f5ad695c65563cd5b037127a94) | *town*, | |  |  | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *prize* = null ) | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ae16d9e73f4935858e81fd8cad268d497)GetMenuText()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.GetMenuText | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ac2f4f6adc9a56a5d8c3f3215553fbfb2)OpenMission()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.OpenMission | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *isPlayerParticipating* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#afa90848ac259c7b3d7d55f7e34d42a70)GetParticipantCharacters()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.GetParticipantCharacters | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *includePlayer* = true ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aa1969fcccbc2dc57e6fbb75b07d73ebb)GetTournamentPrize()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.GetTournamentPrize | ( | bool | *includePlayer*, | |  |  | int | *lastRecordedLordCountForTournamentPrize* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ae2479b0033b9dbea08f003c3cccf2faf)CanBeAParticipant()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual bool TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.CanBeAParticipant | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | bool | *considerSkills* ) | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a791821f862b43e6fbf344b9d1a58888c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a8af8122189ac2b020e3965b6311a3465)PrepareForTournamentGame()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.PrepareForTournamentGame | ( | bool | *isPlayerParticipating* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a691414eb773ba7703b062448528ee93a)UpdateTournamentPrize()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.UpdateTournamentPrize | ( | bool | *includePlayer*, |
|  |  | bool | *removeCurrentPrize* = false ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a300223ef6df57d8551ccef6cd016ab99)\_lastRecordedLordCountForTournamentPrize
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.\_lastRecordedLordCountForTournamentPrize | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aabe0f7f5ad695c65563cd5b037127a94)Town
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Town TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.Town | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a07816d403ce9a735aaabcb423561c033)CreationTime
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.CreationTime | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aa39d0cba148f9ea05986cb34a7400711)Mode
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.Mode | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aadddc7fea7b4760f16be533c8199521b)MaxTeamSize
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual int TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.MaxTeamSize | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a198d4d5ff51875c2abcd53d413aee6b4)MaxTeamNumberPerMatch
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual int TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.MaxTeamNumberPerMatch | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a1464a9fdef356d13f31a278df7747bd1)Prize
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.Prize | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a6daadcee2a379876d832ad723ed37eba)TournamentWinRenown
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.TournamentWinRenown | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a76213b8282b4113ee07996b22aed3845)TournamentWinInfluence
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual float TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.TournamentWinInfluence | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ab9ecdecca39bf0919252224dc6640b55)RemoveTournamentAfterDays
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.RemoveTournamentAfterDays | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a7a985845fd103a84fc49fa224ae0e874)MaximumParticipantCount
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.TournamentGames.TournamentGame.MaximumParticipantCount | | getabstract |

