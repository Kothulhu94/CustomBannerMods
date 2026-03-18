--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_wage_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPartyWageModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetCharacterWage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_wage_model.html#ad825dacfb7110026a97af3ced5c3ed6c) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTotalWage](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_wage_model.html#a54628eeafd2a298856d96f9a37d7c50b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster, bool includeDescriptions=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTroopRecruitmentCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_wage_model.html#a40c5f7fa497f2c52a023b1842d2f7de0) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) buyerHero, bool withoutItemCost=false) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html) | |
| int | [GetCharacterWage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#a48727177f1d5c92986c1dd143cf1c708) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) character) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTotalWage](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#aa780b8d948395b1999c57acb45308928) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) troopRoster, bool includeDescriptions=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetTroopRecruitmentCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#a2b1bf35d253cb3a752dcb4899b272f00) ([CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) troop, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) buyerHero, bool withoutItemCost=false) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [MaxWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_wage_model.html#abef1247eef4f66c4c4f6ca8acffa72cc) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyWageModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html) | |
| int | [MaxWagePaymentLimit](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_wage_model.html#ad4e7d1c1c9cbc7434e97820fdd4c49cb) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_wage_model.html#ad825dacfb7110026a97af3ced5c3ed6c)GetCharacterWage()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartyWageModel.GetCharacterWage | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *character* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_wage_model.html#a54628eeafd2a298856d96f9a37d7c50b)GetTotalWage()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyWageModel.GetTotalWage | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [TroopRoster](class_tale_worlds_1_1_campaign_system_1_1_roster_1_1_troop_roster.html) | *troopRoster*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_wage_model.html#a40c5f7fa497f2c52a023b1842d2f7de0)GetTroopRecruitmentCost()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyWageModel.GetTroopRecruitmentCost | ( | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *troop*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *buyerHero*, |
|  |  | bool | *withoutItemCost* = false ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_wage_model.html#abef1247eef4f66c4c4f6ca8acffa72cc)MaxWagePaymentLimit
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultPartyWageModel.MaxWagePaymentLimit | | get |

