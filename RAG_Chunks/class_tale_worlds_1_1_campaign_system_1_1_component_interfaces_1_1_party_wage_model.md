--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [StoryMode.GameComponents.StoryModePartyWageModel](class_story_mode_1_1_game_components_1_1_story_mode_party_wage_model.html), and [TaleWorlds.CampaignSystem.GameComponents.DefaultPartyWageModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_wage_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetCharacterWage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#a48727177f1d5c92986c1dd143cf1c708) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTotalWage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#aa780b8d948395b1999c57acb45308928) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster, bool includeDescriptions=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTroopRecruitmentCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#a2b1bf35d253cb3a752dcb4899b272f00) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) buyerHero, bool withoutItemCost=false) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [MaxWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#ad4e7d1c1c9cbc7434e97820fdd4c49cb) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#a48727177f1d5c92986c1dd143cf1c708)GetCharacterWage()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel.GetCharacterWage | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#aa780b8d948395b1999c57acb45308928)GetTotalWage()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel.GetTotalWage | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troopRoster*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#a2b1bf35d253cb3a752dcb4899b272f00)GetTroopRecruitmentCost()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel.GetTroopRecruitmentCost | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *buyerHero*, | |  |  | bool | *withoutItemCost* = false ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#ad4e7d1c1c9cbc7434e97820fdd4c49cb)MaxWagePaymentLimit
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel.MaxWagePaymentLimit | | getabstract |

