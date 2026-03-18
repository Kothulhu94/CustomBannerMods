--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html ---

TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior Class ReferenceInherits [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html), and [TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| override void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#ab1fd3ee24f0610072a4c8687abdc9853) () |
| override void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#a1896b4a428549699b9259bcfa31bf190) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| void | [GetOptionProperties](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#a72dad59da4c66cb888012ab9533e924f) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, string optionKey, List< string > previousOptions, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) optionTitle, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) effect, out([CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html), int)[] attributes, out([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)[] skills, out([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)[] focusPoints, out [EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[] educationCharacterProperties) |
| void | [GetPageProperties](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#ad452a061f5cbcd6e092ad8db9b9018d9) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, List< string > previousChoices, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) title, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) instruction, out [EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[] defaultCharacterProperties, out string[] availableOptions) |
| bool | [IsValidEducationNotification](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#aa4782f328228517fa0c6705241f45c52) ([EducationMapNotification](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_education_map_notification.html) data) |
| void | [GetStageProperties](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#ae3481598fa01d61be4b643d665e18e77) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, out int pageCount) |
| void | [Finalize](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#a3a5f00947e205241acbcec89d478e36b) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, List< string > chosenOptions) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a053965730807cc40179cb1ee0495c376) (string stringId) |
|  | [CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab8914958880a708aaf68f676e6c29df1) () |
| void | [RegisterEvents](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a402e03be483527df560a46a7a01004a6) () |
| void | [SyncData](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#a5f2a833b5a67619021c6c437a1232877) ([IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) dataStore) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html) | |
| void | [GetOptionProperties](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#af88bdb10177aee63efa755957f6c06da) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, string optionKey, List< string > previousChoices, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) optionTitle, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) effect, out([CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html), int)[] attributes, out([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)[] skills, out([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)[] focusPoints, out [EducationCampaignBehavior.EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[] characterProperties) |
| void | [GetPageProperties](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a0f7b55b4059b05d44a99f55a23d4906a) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) child, List< string > previousChoices, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) title, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) description, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) instruction, out [EducationCampaignBehavior.EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[] defaultProperties, out string[] availableOptions) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [SetHeroBirthdayForAge](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#a27d729aaff7299a3e850882dee9b40b6) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero, int age) |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| static T | [GetCampaignBehavior< T >](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#af9fd34472faff4ae39b627e8d3091b7e) () |

|  |  |
| --- | --- |
| Properties | |
| static IEnumerable< int > | [Stages](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#ae667ee0dddddbe9b89ffbcc78b6c5212) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.CampaignBehaviorBase](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html) | |
| readonly string | [StringId](class_tale_worlds_1_1_campaign_system_1_1_campaign_behavior_base.html#ab1c3b0a4161f58781148a9499be70fa3) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#ab1fd3ee24f0610072a4c8687abdc9853)RegisterEvents()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior.RegisterEvents | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.ICampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_i_campaign_behavior.html#a142019440678d62c2740ff3fce1f8522).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#a1896b4a428549699b9259bcfa31bf190)SyncData()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior.SyncData | ( | [IDataStore](interface_tale_worlds_1_1_campaign_system_1_1_i_data_store.html) | *dataStore* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#a72dad59da4c66cb888012ab9533e924f)GetOptionProperties()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior.GetOptionProperties | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *child*, |
|  |  | string | *optionKey*, |
|  |  | List< string > | *previousOptions*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *optionTitle*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *effect*, |
|  |  | out([CharacterAttribute](class_tale_worlds_1_1_core_1_1_character_attribute.html), int)[] | *attributes*, |
|  |  | out([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)[] | *skills*, |
|  |  | out([SkillObject](class_tale_worlds_1_1_core_1_1_skill_object.html), int)[] | *focusPoints*, |
|  |  | out [EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[] | *educationCharacterProperties* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#ad452a061f5cbcd6e092ad8db9b9018d9)GetPageProperties()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior.GetPageProperties | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *child*, |
|  |  | List< string > | *previousChoices*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *title*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *description*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *instruction*, |
|  |  | out [EducationCharacterProperties](struct_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior_1_283bc35bc5e591173d724c8986f1043e.html)[] | *defaultCharacterProperties*, |
|  |  | out string[] | *availableOptions* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#aa4782f328228517fa0c6705241f45c52)IsValidEducationNotification()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior.IsValidEducationNotification | ( | [EducationMapNotification](class_tale_worlds_1_1_campaign_system_1_1_map_notification_types_1_1_education_map_notification.html) | *data* | ) |  |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a8bfb0713c2e915dcbd11023434b2c21d).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#ae3481598fa01d61be4b643d665e18e77)GetStageProperties()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior.GetStageProperties | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *child*, |
|  |  | out int | *pageCount* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a1fb63cb41805c4b920fd086b4495eb36).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#a3a5f00947e205241acbcec89d478e36b)Finalize()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior.Finalize | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *child*, |
|  |  | List< string > | *chosenOptions* ) |

Implements [TaleWorlds.CampaignSystem.CampaignBehaviors.IEducationLogic](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_education_logic.html#a9f93bfc3bbace9e6dfcada07c619fa32).

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#a27d729aaff7299a3e850882dee9b40b6)SetHeroBirthdayForAge()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior.SetHeroBirthdayForAge | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero*, | |  |  | int | *age* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_education_campaign_behavior.html#ae667ee0dddddbe9b89ffbcc78b6c5212)Stages
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<int> TaleWorlds.CampaignSystem.CampaignBehaviors.EducationCampaignBehavior.Stages | | staticget |

