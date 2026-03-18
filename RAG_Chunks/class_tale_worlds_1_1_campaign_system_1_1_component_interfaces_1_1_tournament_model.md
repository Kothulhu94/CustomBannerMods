--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultTournamentModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_tournament_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| Public Attributes | |
| [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [skill](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a77152dfc17f600916d596900c3e15523) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a369cbfaff6e7f4db2586012a42535543)GetTournamentStartChance()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.GetTournamentStartChance | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a55f11125d8a358ebdb27f532d798ddca)CreateTournament()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.CreateTournament | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a8fb15f116c6bfbb738342e9080022810)GetTournamentEndChance()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.GetTournamentEndChance | ( | [TournamentGame](class_tale_worlds_1_1_campaign_system_1_1_tournament_games_1_1_tournament_game.html) | *tournament* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a4be7304b844d5785e7e7949847004bff)GetNumLeaderboardVictoriesAtGameStart()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.GetNumLeaderboardVictoriesAtGameStart | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#af0e7769fca3ffaff8ad4de22935d45ac)GetTournamentSimulationScore()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.GetTournamentSimulationScore | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a4a2016114c4d13b574d5c3649791d29b)GetRenownReward()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.GetRenownReward | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winner*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a5eb6ee55a66001f534ffb2b3ac9bf3a8)GetInfluenceReward()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.GetInfluenceReward | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *winner*, | |  |  | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a9de5e7e88c034bba8a50c46e800ec53d)GetSkillXpGainFromTournament()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) int xp TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.GetSkillXpGainFromTournament | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#aafd382e35b001475aa0c76231b2942b0)GetParticipantArmor()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.GetParticipantArmor | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *participant* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a670d70231a97cc4f99cbcba2fb7b3c1b)GetRegularRewardItems()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.GetRegularRewardItems | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | int | *regularRewardMinValue*, | |  |  | int | *regularRewardMaxValue* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#af622ca899c7a019ffb652c1e38233083)GetEliteRewardItems()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBList< [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.GetEliteRewardItems | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | int | *regularRewardMinValue*, | |  |  | int | *regularRewardMaxValue* ) | | abstract |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_tournament_model.html#a77152dfc17f600916d596900c3e15523)skill
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.TournamentModel.skill | | abstract |

