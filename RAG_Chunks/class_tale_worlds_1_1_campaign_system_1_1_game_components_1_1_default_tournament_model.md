--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | [CreateTournament](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a51348edb0fb5b95c855fdc6a653b85a0) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) float | [GetTournamentStartChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a1cae2d446531865687471505308c7b20) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) int | [GetNumLeaderboardVictoriesAtGameStart](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a7f3099bdfd843d0f3259f58c0444eaaa) () |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) float | [GetTournamentEndChance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a51b6592adc450f759bed45126df896a4) ([TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) tournament) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) float | [GetTournamentSimulationScore](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a03e3dafdc5305ea2afc0ed7b715e088d) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) int | [GetRenownReward](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#af8190b4f4568840a9c8c8b7cb28533ae) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winner, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) int | [GetInfluenceReward](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#aa50534846f4de56a2e819c00e558f52e) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winner, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
|  | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) ([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) [skill](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a77152dfc17f600916d596900c3e15523), int xp) [GetSkillXpGainFromTournament](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a9de5e7e88c034bba8a50c46e800ec53d)([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [GetParticipantArmor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6772a33c10d8b491b77c3789b1c28553) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) participant) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) MBList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [GetRegularRewardItems](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#ada31cc8d71be3151165e9ae6fe3b331d) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, int regularRewardMinValue, int regularRewardMaxValue) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) MBList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [GetEliteRewardItems](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a0657241e27cba04693c804c248355346) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, int regularRewardMinValue, int regularRewardMaxValue) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html) | |
| float | [GetTournamentStartChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a369cbfaff6e7f4db2586012a42535543) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | [CreateTournament](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a55f11125d8a358ebdb27f532d798ddca) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| float | [GetTournamentEndChance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a8fb15f116c6bfbb738342e9080022810) ([TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) tournament) |
| int | [GetNumLeaderboardVictoriesAtGameStart](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a4be7304b844d5785e7e7949847004bff) () |
| float | [GetTournamentSimulationScore](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#af0e7769fca3ffaff8ad4de22935d45ac) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| int | [GetRenownReward](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a4a2016114c4d13b574d5c3649791d29b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winner, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| int | [GetInfluenceReward](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a5eb6ee55a66001f534ffb2b3ac9bf3a8) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) winner, [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) int xp | [GetSkillXpGainFromTournament](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a9de5e7e88c034bba8a50c46e800ec53d) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | [GetParticipantArmor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#aafd382e35b001475aa0c76231b2942b0) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) participant) |
| MBList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [GetRegularRewardItems](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a670d70231a97cc4f99cbcba2fb7b3c1b) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, int regularRewardMinValue, int regularRewardMaxValue) |
| MBList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > | [GetEliteRewardItems](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#af622ca899c7a019ffb652c1e38233083) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, int regularRewardMinValue, int regularRewardMaxValue) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html) | |
| [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [skill](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a77152dfc17f600916d596900c3e15523) |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a51348edb0fb5b95c855fdc6a653b85a0)CreateTournament()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.CreateTournament | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a1cae2d446531865687471505308c7b20)GetTournamentStartChance()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) float TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.GetTournamentStartChance | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a7f3099bdfd843d0f3259f58c0444eaaa)GetNumLeaderboardVictoriesAtGameStart()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) int TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.GetNumLeaderboardVictoriesAtGameStart | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a51b6592adc450f759bed45126df896a4)GetTournamentEndChance()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) float TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.GetTournamentEndChance | ( | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | *tournament* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a03e3dafdc5305ea2afc0ed7b715e088d)GetTournamentSimulationScore()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) float TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.GetTournamentSimulationScore | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#af8190b4f4568840a9c8c8b7cb28533ae)GetRenownReward()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) int TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.GetRenownReward | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winner*, |
|  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#aa50534846f4de56a2e819c00e558f52e)GetInfluenceReward()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) int TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.GetInfluenceReward | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winner*, |
|  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483)override()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.override | ( | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | int | *xp* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6772a33c10d8b491b77c3789b1c28553)GetParticipantArmor()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.GetParticipantArmor | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *participant* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#ada31cc8d71be3151165e9ae6fe3b331d)GetRegularRewardItems()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) MBList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.GetRegularRewardItems | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | int | *regularRewardMinValue*, |
|  |  | int | *regularRewardMaxValue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a0657241e27cba04693c804c248355346)GetEliteRewardItems()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html#a6fa35f975dc4fa11fade607c3b99b483) MBList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel.GetEliteRewardItems | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | int | *regularRewardMinValue*, |
|  |  | int | *regularRewardMaxValue* ) |

