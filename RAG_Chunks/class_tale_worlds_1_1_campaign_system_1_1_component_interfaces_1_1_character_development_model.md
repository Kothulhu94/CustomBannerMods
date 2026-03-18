--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultCharacterDevelopmentModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_character_development_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a08e121c83cd115fd8aa0f256d2c156fc)SkillsRequiredForLevel()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.SkillsRequiredForLevel | ( | int | *level* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a826b8ac332f02a8aa23e61cec7dbfca6)GetMaxSkillPoint()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.GetMaxSkillPoint | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a7e55ad6c3f86ec1d12fae9a420f006c3)GetXpRequiredForSkillLevel()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.GetXpRequiredForSkillLevel | ( | int | *skillLevel* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#af26c8c6c04fceb5869e124f5b588171a)GetSkillLevelChange()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.GetSkillLevelChange | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, | |  |  | float | *skillXp* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#ab062fca941090c587dac05cea2c63427)GetXpAmountForSkillLevelChange()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.GetXpAmountForSkillLevelChange | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, | |  |  | int | *skillLevelChange* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#ae58f87c24d31031dfc05159b45940b25)GetTraitLevelForTraitXp()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.GetTraitLevelForTraitXp | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, | |  |  | int | *newValue*, | |  |  | out int | *traitLevel*, | |  |  | out int | *traitXp* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a512038bd6567966bc6a87b3decfb2c27)GetTraitXpRequiredForTraitLevel()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.GetTraitXpRequiredForTraitLevel | ( | [TraitObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_trait_object.html) | *trait*, | |  |  | int | *traitLevel* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a612a92456c1acd471ab48159f3078618)CalculateLearningLimit()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.CalculateLearningLimit | ( | IReadOnlyPropertyOwner< [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) > | *characterAttributes*, | |  |  | int | *focusValue*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a8f824e6197afff4e1ee4f2b3d1190e36)CalculateLearningRate()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.CalculateLearningRate | ( | IReadOnlyPropertyOwner< [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) > | *characterAttributes*, | |  |  | int | *focusValue*, | |  |  | int | *skillValue*, | |  |  | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) | *skill*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a79780ca67328fa3320522bdfa6c146f9)GetNextSkillToAddFocus()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.GetNextSkillToAddFocus | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a0f97c9153161f78973b30d5f52287d3a)GetNextAttributeToUpgrade()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html) TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.GetNextAttributeToUpgrade | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a65b41bf2b746c985378daddb7246da9c)GetNextPerkToChoose()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.GetNextPerkToChoose | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | [PerkObject](class_tale_worlds_1_1_campaign_system_1_1_character_development_1_1_perk_object.html) | *perk* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#ae868158cb26012ecb0340063f134d3cc)MaxAttribute
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.MaxAttribute | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a058a5db1d9947de66ec65136737881e7)MaxFocusPerSkill
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.MaxFocusPerSkill | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a308dd07ad838337e0c99997572cd04a6)MaxSkillRequiredForEpicPerkBonus
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.MaxSkillRequiredForEpicPerkBonus | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#aea205304f5fd646d784afc436fefddbb)MinSkillRequiredForEpicPerkBonus
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.MinSkillRequiredForEpicPerkBonus | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a9a2378644203b7c767f95be20e04aded)FocusPointsPerLevel
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.FocusPointsPerLevel | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a3cc7d14463dd53a4f851756a7850d926)FocusPointsAtStart
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.FocusPointsAtStart | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#ab031e822641b131c2230709b157d48a6)AttributePointsAtStart
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.AttributePointsAtStart | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_character_development_model.html#a9f058a9ea04b64764f1871b82f44569b)LevelsPerAttributePoint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.CharacterDevelopmentModel.LevelsPerAttributePoint | | getabstract |

