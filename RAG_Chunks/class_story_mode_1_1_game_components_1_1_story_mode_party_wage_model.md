--- SOURCE: class_story_mode_1_1_game_components_1_1_story_mode_party_wage_model.html ---

StoryMode.GameComponents.StoryModePartyWageModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetCharacterWage](class_story_mode_1_1_game_components_1_1_story_mode_party_wage_model.html#a2f6a44d424fa7baf42b59e0393d171df) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTotalWage](class_story_mode_1_1_game_components_1_1_story_mode_party_wage_model.html#a494729a13a234b3b0b19f8358f8da3d8) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster, bool includeDescriptions=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTroopRecruitmentCost](class_story_mode_1_1_game_components_1_1_story_mode_party_wage_model.html#aab29322b07f4f1f99070370bd539adf8) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) buyerHero, bool withoutItemCost=false) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html) | |
| int | [GetCharacterWage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#a48727177f1d5c92986c1dd143cf1c708) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTotalWage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#aa780b8d948395b1999c57acb45308928) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster, bool includeDescriptions=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTroopRecruitmentCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#a2b1bf35d253cb3a752dcb4899b272f00) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) buyerHero, bool withoutItemCost=false) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [MaxWagePaymentLimit](class_story_mode_1_1_game_components_1_1_story_mode_party_wage_model.html#a9622dbd697757c058f14c9dec71a05ea) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html) | |
| int | [MaxWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#ad4e7d1c1c9cbc7434e97820fdd4c49cb) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_wage_model.html#a2f6a44d424fa7baf42b59e0393d171df)GetCharacterWage()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int StoryMode.GameComponents.StoryModePartyWageModel.GetCharacterWage | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_wage_model.html#a494729a13a234b3b0b19f8358f8da3d8)GetTotalWage()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) StoryMode.GameComponents.StoryModePartyWageModel.GetTotalWage | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troopRoster*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_wage_model.html#aab29322b07f4f1f99070370bd539adf8)GetTroopRecruitmentCost()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) StoryMode.GameComponents.StoryModePartyWageModel.GetTroopRecruitmentCost | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *buyerHero*, |
|  |  | bool | *withoutItemCost* = false ) |

Property Documentation
----------------------

[◆](class_story_mode_1_1_game_components_1_1_story_mode_party_wage_model.html#a9622dbd697757c058f14c9dec71a05ea)MaxWagePaymentLimit
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int StoryMode.GameComponents.StoryModePartyWageModel.MaxWagePaymentLimit | | get |

