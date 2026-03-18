--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PersuasionModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultPersuasionModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetSkillXpFromPersuasion](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#ab672ad68ffd4a0f5f3b0889c42d431e4) ([PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) difficulty, int argumentDifficultyBonusCoefficient) |
| void | [GetChances](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#ac09fed599c674c2c2181553e17d3f341) ([PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) optionArgs, out float successChance, out float critSuccessChance, out float critFailChance, out float failChance, float difficultyMultiplier) |
| void | [GetEffectChances](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#a65376b1704640309e178e328dda4f16d) ([PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) option, out float moveToNextStageChance, out float blockRandomOptionChance, float difficultyMultiplier) |
| [PersuasionArgumentStrength](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#aa3e0a107d9ed27b893b0b17fcc7e86b5) | [GetArgumentStrengthBasedOnTargetTraits](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#abf24a9b45135daf2c6a71f29600aafbf) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] traitCorrelation) |
| float | [GetDifficulty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#ab0f232e91de4902d34952e707f3e4eee) ([PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) difficulty) |
| float | [CalculateInitialPersuasionProgress](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#a81f280fb6c2a1fd0ccf1264a7a3522b4) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, float goalValue, float successValue) |
| float | [CalculatePersuasionGoalValue](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#a8ae1e543cc9b139262bdcda3432043ce) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) oneToOneConversationCharacter, float successValue) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#ab672ad68ffd4a0f5f3b0889c42d431e4)GetSkillXpFromPersuasion()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PersuasionModel.GetSkillXpFromPersuasion | ( | [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) | *difficulty*, | |  |  | int | *argumentDifficultyBonusCoefficient* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#ac09fed599c674c2c2181553e17d3f341)GetChances()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.PersuasionModel.GetChances | ( | [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) | *optionArgs*, | |  |  | out float | *successChance*, | |  |  | out float | *critSuccessChance*, | |  |  | out float | *critFailChance*, | |  |  | out float | *failChance*, | |  |  | float | *difficultyMultiplier* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#a65376b1704640309e178e328dda4f16d)GetEffectChances()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.PersuasionModel.GetEffectChances | ( | [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) | *option*, | |  |  | out float | *moveToNextStageChance*, | |  |  | out float | *blockRandomOptionChance*, | |  |  | float | *difficultyMultiplier* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#abf24a9b45135daf2c6a71f29600aafbf)GetArgumentStrengthBasedOnTargetTraits()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [PersuasionArgumentStrength](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#aa3e0a107d9ed27b893b0b17fcc7e86b5) TaleWorlds.CampaignSystem.ComponentInterfaces.PersuasionModel.GetArgumentStrengthBasedOnTargetTraits | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] | *traitCorrelation* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#ab0f232e91de4902d34952e707f3e4eee)GetDifficulty()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PersuasionModel.GetDifficulty | ( | [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) | *difficulty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#a81f280fb6c2a1fd0ccf1264a7a3522b4)CalculateInitialPersuasionProgress()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PersuasionModel.CalculateInitialPersuasionProgress | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | float | *goalValue*, | |  |  | float | *successValue* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html#a8ae1e543cc9b139262bdcda3432043ce)CalculatePersuasionGoalValue()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PersuasionModel.CalculatePersuasionGoalValue | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *oneToOneConversationCharacter*, | |  |  | float | *successValue* ) | | abstract |

