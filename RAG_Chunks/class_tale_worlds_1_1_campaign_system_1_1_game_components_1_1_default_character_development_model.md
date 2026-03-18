--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultCharacterDevelopmentModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a518e0127489dc8649f32ee684a7bea3b) () |
| void | [InitializeSkillsRequiredForLevel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a3f5366416448c1a2bd16ce7ffaed06da) () |
| void | [InitializeXpRequiredForSkillLevel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a99c106af6aaf00d319b54cbb912da2c4) () |
| override int | [SkillsRequiredForLevel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a240008a9aa9033c9da0d29958307d099) (int level) |
| override int | [GetMaxSkillPoint](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a41425c27ccbb60b0020847353c5704fc) () |
| override int | [GetXpRequiredForSkillLevel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a5e445f76e6c4e21213a48d238bdc93ec) (int skillLevel) |
| override int | [GetSkillLevelChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#aa02f610e44d96e2e8947e8fc8d0ca710) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, float skillXp) |
| override int | [GetXpAmountForSkillLevelChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#ac433e8f0287f0904bb2091c02ccc729b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int skillLevelChange) |
| override void | [GetTraitLevelForTraitXp](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a7afb2d1d94fd5dfc30cbaa0fd9e9e5a5) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int xpValue, out int traitLevel, out int clampedTraitXp) |
| override int | [GetTraitXpRequiredForTraitLevel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a78419c8a6f8017501e170d85bea9096a) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int traitLevel) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateLearningLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a073289f1fdd3881a6d466b0464614594) (IReadOnlyPropertyOwner< [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) > characterAttributes, int focusValue, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, bool includeDescriptions=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateLearningRate](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a2bd303a675aa2f8a667dcff439cb09b3) (IReadOnlyPropertyOwner< [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) > characterAttributes, int focusValue, int skillValue, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, bool includeDescriptions=false) |
| override [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [GetNextSkillToAddFocus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a9d18355224d3641972170179c8214ddf) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) | [GetNextAttributeToUpgrade](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a587ff4f474edf0a9ac4089df430c02ac) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | [GetNextPerkToChoose](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#aebc2fbed656548392aae3bbd26beb212) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html) | |
| int | [SkillsRequiredForLevel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a08e121c83cd115fd8aa0f256d2c156fc) (int level) |
| int | [GetMaxSkillPoint](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a826b8ac332f02a8aa23e61cec7dbfca6) () |
| int | [GetXpRequiredForSkillLevel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a7e55ad6c3f86ec1d12fae9a420f006c3) (int skillLevel) |
| int | [GetSkillLevelChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#af26c8c6c04fceb5869e124f5b588171a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, float skillXp) |
| int | [GetXpAmountForSkillLevelChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#ab062fca941090c587dac05cea2c63427) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, int skillLevelChange) |
| void | [GetTraitLevelForTraitXp](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#ae58f87c24d31031dfc05159b45940b25) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int newValue, out int traitLevel, out int traitXp) |
| int | [GetTraitXpRequiredForTraitLevel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a512038bd6567966bc6a87b3decfb2c27) ([TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) trait, int traitLevel) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateLearningLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a612a92456c1acd471ab48159f3078618) (IReadOnlyPropertyOwner< [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) > characterAttributes, int focusValue, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, bool includeDescriptions=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateLearningRate](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a8f824e6197afff4e1ee4f2b3d1190e36) (IReadOnlyPropertyOwner< [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) > characterAttributes, int focusValue, int skillValue, [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) skill, bool includeDescriptions=false) |
| [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | [GetNextSkillToAddFocus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a79780ca67328fa3320522bdfa6c146f9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) | [GetNextAttributeToUpgrade](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a0f97c9153161f78973b30d5f52287d3a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | [GetNextPerkToChoose](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a65b41bf2b746c985378daddb7246da9c) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) perk) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [MaxFocusPerSkill](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#abbaf9a4a491373f7153e66e260bc8222) `[get]` |
| override int | [MaxAttribute](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a6d6baeb686aead8c8b1be729b75ecadf) `[get]` |
| override int | [AttributePointsAtStart](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#ac271b05cc6a913f932ea225c31fe96ff) `[get]` |
| override int | [LevelsPerAttributePoint](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a90fc429a26f555ee8a8d8798a68ea1e2) `[get]` |
| override int | [FocusPointsPerLevel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a8314058eb6ea393c794458b276d51adf) `[get]` |
| override int | [FocusPointsAtStart](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a2dd4565d54b23ecde0436159b829c861) `[get]` |
| override int | [MaxSkillRequiredForEpicPerkBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a41ed378907d9cc9b9851c7f9de7e3dae) `[get]` |
| override int | [MinSkillRequiredForEpicPerkBonus](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a2225a423a96763c73845b3ae819ad6eb) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html) | |
| int | [MaxAttribute](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#ae868158cb26012ecb0340063f134d3cc) `[get]` |
| int | [MaxFocusPerSkill](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a058a5db1d9947de66ec65136737881e7) `[get]` |
| int | [MaxSkillRequiredForEpicPerkBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a308dd07ad838337e0c99997572cd04a6) `[get]` |
| int | [MinSkillRequiredForEpicPerkBonus](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#aea205304f5fd646d784afc436fefddbb) `[get]` |
| int | [FocusPointsPerLevel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a9a2378644203b7c767f95be20e04aded) `[get]` |
| int | [FocusPointsAtStart](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a3cc7d14463dd53a4f851756a7850d926) `[get]` |
| int | [AttributePointsAtStart](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#ab031e822641b131c2230709b157d48a6) `[get]` |
| int | [LevelsPerAttributePoint](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a9f058a9ea04b64764f1871b82f44569b) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a518e0127489dc8649f32ee684a7bea3b)DefaultCharacterDevelopmentModel()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.DefaultCharacterDevelopmentModel | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a3f5366416448c1a2bd16ce7ffaed06da)InitializeSkillsRequiredForLevel()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.InitializeSkillsRequiredForLevel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a99c106af6aaf00d319b54cbb912da2c4)InitializeXpRequiredForSkillLevel()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.InitializeXpRequiredForSkillLevel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a240008a9aa9033c9da0d29958307d099)SkillsRequiredForLevel()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.SkillsRequiredForLevel | ( | int | *level* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a41425c27ccbb60b0020847353c5704fc)GetMaxSkillPoint()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.GetMaxSkillPoint | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a5e445f76e6c4e21213a48d238bdc93ec)GetXpRequiredForSkillLevel()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.GetXpRequiredForSkillLevel | ( | int | *skillLevel* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#aa02f610e44d96e2e8947e8fc8d0ca710)GetSkillLevelChange()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.GetSkillLevelChange | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | float | *skillXp* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#ac433e8f0287f0904bb2091c02ccc729b)GetXpAmountForSkillLevelChange()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.GetXpAmountForSkillLevelChange | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | int | *skillLevelChange* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a7afb2d1d94fd5dfc30cbaa0fd9e9e5a5)GetTraitLevelForTraitXp()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.GetTraitLevelForTraitXp | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, |
|  |  | int | *xpValue*, |
|  |  | out int | *traitLevel*, |
|  |  | out int | *clampedTraitXp* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a78419c8a6f8017501e170d85bea9096a)GetTraitXpRequiredForTraitLevel()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.GetTraitXpRequiredForTraitLevel | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, |
|  |  | int | *traitLevel* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a073289f1fdd3881a6d466b0464614594)CalculateLearningLimit()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.CalculateLearningLimit | ( | IReadOnlyPropertyOwner< [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) > | *characterAttributes*, |
|  |  | int | *focusValue*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a2bd303a675aa2f8a667dcff439cb09b3)CalculateLearningRate()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.CalculateLearningRate | ( | IReadOnlyPropertyOwner< [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) > | *characterAttributes*, |
|  |  | int | *focusValue*, |
|  |  | int | *skillValue*, |
|  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a9d18355224d3641972170179c8214ddf)GetNextSkillToAddFocus()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.GetNextSkillToAddFocus | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a587ff4f474edf0a9ac4089df430c02ac)GetNextAttributeToUpgrade()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.GetNextAttributeToUpgrade | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#aebc2fbed656548392aae3bbd26beb212)GetNextPerkToChoose()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.GetNextPerkToChoose | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, |
|  |  | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#abbaf9a4a491373f7153e66e260bc8222)MaxFocusPerSkill
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.MaxFocusPerSkill | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a6d6baeb686aead8c8b1be729b75ecadf)MaxAttribute
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.MaxAttribute | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#ac271b05cc6a913f932ea225c31fe96ff)AttributePointsAtStart
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.AttributePointsAtStart | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a90fc429a26f555ee8a8d8798a68ea1e2)LevelsPerAttributePoint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.LevelsPerAttributePoint | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a8314058eb6ea393c794458b276d51adf)FocusPointsPerLevel
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.FocusPointsPerLevel | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a2dd4565d54b23ecde0436159b829c861)FocusPointsAtStart
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.FocusPointsAtStart | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a41ed378907d9cc9b9851c7f9de7e3dae)MaxSkillRequiredForEpicPerkBonus
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.MaxSkillRequiredForEpicPerkBonus | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html#a2225a423a96763c73845b3ae819ad6eb)MinSkillRequiredForEpicPerkBonus
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel.MinSkillRequiredForEpicPerkBonus | | get |

