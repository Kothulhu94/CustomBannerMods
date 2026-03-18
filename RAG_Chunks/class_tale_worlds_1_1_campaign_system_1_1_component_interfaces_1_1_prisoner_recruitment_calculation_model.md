--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerRecruitmentCalculationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [StoryMode.GameComponents.StoryModePrisonerRecruitmentCalculationModel](class_story_mode_1_1_game_components_1_1_story_mode_prisoner_recruitment_calculation_model.html), and [TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerRecruitmentCalculationModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#aca66148843f03708b345198724bc9f33)GetConformityNeededToRecruitPrisoner()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerRecruitmentCalculationModel.GetConformityNeededToRecruitPrisoner | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#adabddbe0e709bad402feede2e51fa194)GetConformityChangePerHour()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerRecruitmentCalculationModel.GetConformityChangePerHour | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#a49fe9063ca6595481611e295fbe8aa93)GetPrisonerRecruitmentMoraleEffect()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerRecruitmentCalculationModel.GetPrisonerRecruitmentMoraleEffect | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | int | *num* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#a26229c4ace25580cf5a423196eda052d)IsPrisonerRecruitable()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerRecruitmentCalculationModel.IsPrisonerRecruitable | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, | |  |  | out int | *conformityNeeded* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#ab09b553d6e63102952bfb1eb85dd71ab)ShouldPartyRecruitPrisoners()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerRecruitmentCalculationModel.ShouldPartyRecruitPrisoners | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html#a29f15dfefd3ba6f01b5a28ac64fb046a)CalculateRecruitableNumber()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerRecruitmentCalculationModel.CalculateRecruitableNumber | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* ) | | abstract |

