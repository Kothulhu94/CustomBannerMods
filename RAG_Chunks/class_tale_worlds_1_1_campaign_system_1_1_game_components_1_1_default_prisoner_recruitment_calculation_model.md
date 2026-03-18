--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerRecruitmentCalculationModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerRecruitmentCalculationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_recruitment_calculation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetConformityNeededToRecruitPrisoner](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#a0de225873d3e4974dc373f67da4f2e4f) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetConformityChangePerHour](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#ad373662cb976c5870cf8f1f8732feeec) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troopToBoost) |
| override int | [GetPrisonerRecruitmentMoraleEffect](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#ae51a12b0524597944f1c4172b2630a95) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, int num) |
| override bool | [IsPrisonerRecruitable](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#a758c8c5c8432c7b1ee4dbd00ccec66c1) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character, out int conformityNeeded) |
| override bool | [ShouldPartyRecruitPrisoners](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#aec915debcea639b969bbf315893d198d) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party) |
| override int | [CalculateRecruitableNumber](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#a5ead24f04712bb94510db33a3b4b4c30) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) party, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#a0de225873d3e4974dc373f67da4f2e4f)GetConformityNeededToRecruitPrisoner()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerRecruitmentCalculationModel.GetConformityNeededToRecruitPrisoner | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#ad373662cb976c5870cf8f1f8732feeec)GetConformityChangePerHour()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerRecruitmentCalculationModel.GetConformityChangePerHour | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troopToBoost* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#ae51a12b0524597944f1c4172b2630a95)GetPrisonerRecruitmentMoraleEffect()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerRecruitmentCalculationModel.GetPrisonerRecruitmentMoraleEffect | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | int | *num* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#a758c8c5c8432c7b1ee4dbd00ccec66c1)IsPrisonerRecruitable()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerRecruitmentCalculationModel.IsPrisonerRecruitable | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character*, |
|  |  | out int | *conformityNeeded* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#aec915debcea639b969bbf315893d198d)ShouldPartyRecruitPrisoners()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerRecruitmentCalculationModel.ShouldPartyRecruitPrisoners | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_recruitment_calculation_model.html#a5ead24f04712bb94510db33a3b4b4c30)CalculateRecruitableNumber()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerRecruitmentCalculationModel.CalculateRecruitableNumber | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *party*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* ) |

