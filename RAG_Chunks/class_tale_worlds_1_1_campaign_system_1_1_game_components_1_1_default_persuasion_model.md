--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPersuasionModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PersuasionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetSkillXpFromPersuasion](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#ad54da83a1c19f4429e9aefbbf7449a4c) ([PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) difficulty, int argumentDifficultyBonusCoefficient) |
| override void | [GetChances](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#a4feac4dc8c0853bcbf7d1f847ff8ef75) ([PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) optionArgs, out float successChance, out float critSuccessChance, out float critFailChance, out float failChance, float difficultyMultiplier) |
| override void | [GetEffectChances](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#a4c5be6ce3aba2fc407cf32d84a412b42) ([PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) option, out float moveToNextStageChance, out float blockRandomOptionChance, float difficultyMultiplier) |
| override [PersuasionArgumentStrength](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#aa3e0a107d9ed27b893b0b17fcc7e86b5) | [GetArgumentStrengthBasedOnTargetTraits](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#a627224fd0d015d77485587a574a5ad21) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] traitCorrelations) |
| override float | [CalculateInitialPersuasionProgress](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#aaa2212c1b109fbf35733683e77fbabd8) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, float goalValue, float successValue) |
| override float | [CalculatePersuasionGoalValue](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#aeece7e979bd1bcd084214cb13bb9abc4) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) oneToOneConversationCharacter, float successValue) |
| override float | [GetDifficulty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#aae2efeb76c01a681293fd698a8ccd859) ([PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) difficulty) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PersuasionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_persuasion_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#ad54da83a1c19f4429e9aefbbf7449a4c)GetSkillXpFromPersuasion()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPersuasionModel.GetSkillXpFromPersuasion | ( | [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) | *difficulty*, |
|  |  | int | *argumentDifficultyBonusCoefficient* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#a4feac4dc8c0853bcbf7d1f847ff8ef75)GetChances()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultPersuasionModel.GetChances | ( | [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) | *optionArgs*, |
|  |  | out float | *successChance*, |
|  |  | out float | *critSuccessChance*, |
|  |  | out float | *critFailChance*, |
|  |  | out float | *failChance*, |
|  |  | float | *difficultyMultiplier* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#a4c5be6ce3aba2fc407cf32d84a412b42)GetEffectChances()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultPersuasionModel.GetEffectChances | ( | [PersuasionOptionArgs](class_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion_1_1_persuasion_option_args.html) | *option*, |
|  |  | out float | *moveToNextStageChance*, |
|  |  | out float | *blockRandomOptionChance*, |
|  |  | float | *difficultyMultiplier* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#a627224fd0d015d77485587a574a5ad21)GetArgumentStrengthBasedOnTargetTraits()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [PersuasionArgumentStrength](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#aa3e0a107d9ed27b893b0b17fcc7e86b5) TaleWorlds.CampaignSystem.GameComponents.DefaultPersuasionModel.GetArgumentStrengthBasedOnTargetTraits | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | Tuple< [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html), int >[] | *traitCorrelations* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#aaa2212c1b109fbf35733683e77fbabd8)CalculateInitialPersuasionProgress()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPersuasionModel.CalculateInitialPersuasionProgress | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | float | *goalValue*, |
|  |  | float | *successValue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#aeece7e979bd1bcd084214cb13bb9abc4)CalculatePersuasionGoalValue()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPersuasionModel.CalculatePersuasionGoalValue | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *oneToOneConversationCharacter*, |
|  |  | float | *successValue* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_persuasion_model.html#aae2efeb76c01a681293fd698a8ccd859)GetDifficulty()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPersuasionModel.GetDifficulty | ( | [PersuasionDifficulty](namespace_tale_worlds_1_1_campaign_system_1_1_conversation_1_1_persuasion.html#ae8284e7d59bf7ae3a6c134ddc77c2a4f) | *difficulty* | ) |  |

