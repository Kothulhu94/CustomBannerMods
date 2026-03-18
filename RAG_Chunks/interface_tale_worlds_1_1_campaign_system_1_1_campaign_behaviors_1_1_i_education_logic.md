--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic Interface ReferenceInherited by [TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Finalize](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a9f93bfc3bbace9e6dfcada07c619fa32) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, List< string > chosenOptions) |
| void | [GetOptionProperties](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#af88bdb10177aee63efa755957f6c06da) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, string optionKey, List< string > previousChoices, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) optionTitle, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) effect, out([CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html), int)[] attributes, out([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)[] skills, out([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)[] focusPoints, out [EducationCampaignBehavior.EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[] characterProperties) |
| void | [GetPageProperties](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a0f7b55b4059b05d44a99f55a23d4906a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, List< string > previousChoices, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) title, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) instruction, out [EducationCampaignBehavior.EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[] defaultProperties, out string[] availableOptions) |
| void | [GetStageProperties](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a1fb63cb41805c4b920fd086b4495eb36) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, out int pageCount) |
| bool | [IsValidEducationNotification](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a8bfb0713c2e915dcbd11023434b2c21d) ([EducationMapNotification](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_education_map_notification.html) educationMapNotification) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a9f93bfc3bbace9e6dfcada07c619fa32)Finalize()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic.Finalize | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *child*, |
|  |  | List< string > | *chosenOptions* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#a3a5f00947e205241acbcec89d478e36b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#af88bdb10177aee63efa755957f6c06da)GetOptionProperties()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic.GetOptionProperties | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *child*, |
|  |  | string | *optionKey*, |
|  |  | List< string > | *previousChoices*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *optionTitle*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *effect*, |
|  |  | out([CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html), int)[] | *attributes*, |
|  |  | out([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)[] | *skills*, |
|  |  | out([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)[] | *focusPoints*, |
|  |  | out [EducationCampaignBehavior.EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[] | *characterProperties* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a0f7b55b4059b05d44a99f55a23d4906a)GetPageProperties()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic.GetPageProperties | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *child*, |
|  |  | List< string > | *previousChoices*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *title*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *instruction*, |
|  |  | out [EducationCampaignBehavior.EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[] | *defaultProperties*, |
|  |  | out string[] | *availableOptions* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a1fb63cb41805c4b920fd086b4495eb36)GetStageProperties()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic.GetStageProperties | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *child*, |
|  |  | out int | *pageCount* ) |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#ae3481598fa01d61be4b643d665e18e77).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a8bfb0713c2e915dcbd11023434b2c21d)IsValidEducationNotification()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic.IsValidEducationNotification | ( | [EducationMapNotification](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_education_map_notification.html) | *educationMapNotification* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#aa4782f328228517fa0c6705241f45c52).

