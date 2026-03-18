--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html ---

TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame Class ReferenceInherits [TaleWorlds.CampaignSystem.TournamentGames.TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FightTournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#aa9e2b677a1fbd3559768b7949b4ec53a) ([Town](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aabe0f7f5ad695c65563cd5b037127a94) town) |
| override bool | [CanBeAParticipant](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a791821f862b43e6fbf344b9d1a58888c) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, bool considerSkills) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetMenuText](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#ad3725dc69e7e7dca9a5d751d9b936d4e) () |
| override void | [OpenMission](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a67c720b88374cf8c5e143a3d2764deea) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool isPlayerParticipating) |
| override MBList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [GetParticipantCharacters](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#ab04841a497d80f4d6e5f449efde1c4e9) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includePlayer=true) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.TournamentGames.TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetMenuText](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ae16d9e73f4935858e81fd8cad268d497) () |
| void | [OpenMission](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ac2f4f6adc9a56a5d8c3f3215553fbfb2) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool isPlayerParticipating) |
| MBList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > | [GetParticipantCharacters](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#afa90848ac259c7b3d7d55f7e34d42a70) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includePlayer=true) |
| void | [PrepareForTournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a8af8122189ac2b020e3965b6311a3465) (bool isPlayerParticipating) |
| void | [UpdateTournamentPrize](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a691414eb773ba7703b062448528ee93a) (bool includePlayer, bool removeCurrentPrize=false) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [ParticipantTroopMinimumTierLimit](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a026ab3b4236f0e59a19a967b002f0a9c) = 3 |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetTournamentPrize](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a67a74a4acfff6aa54409d7af14bc7204) (bool includePlayer, int lastRecordedLordCountForTournamentPrize) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.TournamentGames.TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [GetTournamentPrize](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aa1969fcccbc2dc57e6fbb75b07d73ebb) (bool includePlayer, int lastRecordedLordCountForTournamentPrize) |
|  | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ac49c0d99587a6d916caa0b8cfa906675) ([Town](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aabe0f7f5ad695c65563cd5b037127a94) town, [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) prize=null) |

|  |  |
| --- | --- |
| Properties | |
| override int | [MaxTeamSize](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a781e9353612cce1037c74874ea20866d) `[get]` |
| override int | [MaxTeamNumberPerMatch](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a21179087ec5518c5f1080eb284cfd831) `[get]` |
| override int | [RemoveTournamentAfterDays](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a9f9a37fa06b4ba02f6a18e064499102a) `[get]` |
| override int | [MaximumParticipantCount](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#af94000e6b620cb26c704854f8e76f33e) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.TournamentGames.TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | |
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

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.CampaignSystem.TournamentGames.TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | |
| enum | [QualificationMode](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950) {     [IndividualScore](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950ac85eeeaa1d74630f5e1538ef212a048d) ,     [TeamScore](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a518b4e0f94d3e5d007fb82eb18a70950a9f6b9dd59346822ecbf4cddb4da60ccb)   } |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.TournamentGames.TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | |
| int | [\_lastRecordedLordCountForTournamentPrize](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#a300223ef6df57d8551ccef6cd016ab99) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#aa9e2b677a1fbd3559768b7949b4ec53a)FightTournamentGame()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.FightTournamentGame | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#aabe0f7f5ad695c65563cd5b037127a94) | *town* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a791821f862b43e6fbf344b9d1a58888c)CanBeAParticipant()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.CanBeAParticipant | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | bool | *considerSkills* ) | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.TournamentGames.TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html#ae2479b0033b9dbea08f003c3cccf2faf).

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#ad3725dc69e7e7dca9a5d751d9b936d4e)GetMenuText()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.GetMenuText | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a67c720b88374cf8c5e143a3d2764deea)OpenMission()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.OpenMission | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *isPlayerParticipating* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#ab04841a497d80f4d6e5f449efde1c4e9)GetParticipantCharacters()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override MBList< [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) > TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.GetParticipantCharacters | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *includePlayer* = true ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a67a74a4acfff6aa54409d7af14bc7204)GetTournamentPrize()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.GetTournamentPrize | ( | bool | *includePlayer*, | |  |  | int | *lastRecordedLordCountForTournamentPrize* ) | | protected |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a026ab3b4236f0e59a19a967b002f0a9c)ParticipantTroopMinimumTierLimit
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.ParticipantTroopMinimumTierLimit = 3 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a781e9353612cce1037c74874ea20866d)MaxTeamSize
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.MaxTeamSize | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a21179087ec5518c5f1080eb284cfd831)MaxTeamNumberPerMatch
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.MaxTeamNumberPerMatch | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#a9f9a37fa06b4ba02f6a18e064499102a)RemoveTournamentAfterDays
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.RemoveTournamentAfterDays | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_fight_tournament_game.html#af94000e6b620cb26c704854f8e76f33e)MaximumParticipantCount
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.TournamentGames.FightTournamentGame.MaximumParticipantCount | | get |

