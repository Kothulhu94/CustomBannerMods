--- SOURCE: class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html ---

StoryMode.GameComponents.StoryModePrisonerRecruitmentCalculationModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerRecruitmentCalculationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [CalculateRecruitableNumber](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#a4a44f30ebc0ffc6e0cf2dc294a20c7a6) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetConformityChangePerHour](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#a41ade08226ea795cc721fc4adcf2678d) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| override int | [GetConformityNeededToRecruitPrisoner](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#a14a26f889a876ff192cc88c1ecf3bc1c) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| override int | [GetPrisonerRecruitmentMoraleEffect](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#a97201371ce9a148b10058b3f99f6e95c) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, int num) |
| override bool | [IsPrisonerRecruitable](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#a06d6b2ca39051da7878f8af2d34f5d5e) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, out int conformityNeeded) |
| override bool | [ShouldPartyRecruitPrisoners](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#aa6eda879863d5685d8aad69773cfa16d) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerRecruitmentCalculationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html) | |
| int | [GetConformityNeededToRecruitPrisoner](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#aca66148843f03708b345198724bc9f33) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetConformityChangePerHour](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#adabddbe0e709bad402feede2e51fa194) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| int | [GetPrisonerRecruitmentMoraleEffect](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#a49fe9063ca6595481611e295fbe8aa93) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, int num) |
| bool | [IsPrisonerRecruitable](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#a26229c4ace25580cf5a423196eda052d) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, out int conformityNeeded) |
| bool | [ShouldPartyRecruitPrisoners](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#ab09b553d6e63102952bfb1eb85dd71ab) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| int | [CalculateRecruitableNumber](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#a29f15dfefd3ba6f01b5a28ac64fb046a) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#a4a44f30ebc0ffc6e0cf2dc294a20c7a6)CalculateRecruitableNumber()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModePrisonerRecruitmentCalculationModel.CalculateRecruitableNumber | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#a41ade08226ea795cc721fc4adcf2678d)GetConformityChangePerHour()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) StoryMode.GameComponents.StoryModePrisonerRecruitmentCalculationModel.GetConformityChangePerHour | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#a14a26f889a876ff192cc88c1ecf3bc1c)GetConformityNeededToRecruitPrisoner()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModePrisonerRecruitmentCalculationModel.GetConformityNeededToRecruitPrisoner | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#a97201371ce9a148b10058b3f99f6e95c)GetPrisonerRecruitmentMoraleEffect()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModePrisonerRecruitmentCalculationModel.GetPrisonerRecruitmentMoraleEffect | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | int | *num* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#a06d6b2ca39051da7878f8af2d34f5d5e)IsPrisonerRecruitable()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModePrisonerRecruitmentCalculationModel.IsPrisonerRecruitable | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | out int | *conformityNeeded* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html#aa6eda879863d5685d8aad69773cfa16d)ShouldPartyRecruitPrisoners()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool StoryMode.GameComponents.StoryModePrisonerRecruitmentCalculationModel.ShouldPartyRecruitPrisoners | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

