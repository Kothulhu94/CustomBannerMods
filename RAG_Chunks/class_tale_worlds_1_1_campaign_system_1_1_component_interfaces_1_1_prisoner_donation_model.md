--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_donation_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerDonationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerDonationModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_donation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [CalculateRelationGainAfterHeroPrisonerDonate](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_donation_model.html#a7980ea5792a55071483488fd0eb12151) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) donatingParty, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) donatedHero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) donatedSettlement) |
| float | [CalculateInfluenceGainAfterPrisonerDonation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_donation_model.html#ad989c000189db54b3f1ad9c742aaa100) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) donatingParty, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) donatedPrisoner, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) donatedSettlement) |
| float | [CalculateInfluenceGainAfterTroopDonation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_donation_model.html#ab7724d7c21251a2b0bf1545ee7be5fd0) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) donatingParty, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) donatedTroop, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) donatedSettlement) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_donation_model.html#a7980ea5792a55071483488fd0eb12151)CalculateRelationGainAfterHeroPrisonerDonate()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerDonationModel.CalculateRelationGainAfterHeroPrisonerDonate | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *donatingParty*, | |  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *donatedHero*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *donatedSettlement* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_donation_model.html#ad989c000189db54b3f1ad9c742aaa100)CalculateInfluenceGainAfterPrisonerDonation()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerDonationModel.CalculateInfluenceGainAfterPrisonerDonation | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *donatingParty*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *donatedPrisoner*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *donatedSettlement* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_donation_model.html#ab7724d7c21251a2b0bf1545ee7be5fd0)CalculateInfluenceGainAfterTroopDonation()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerDonationModel.CalculateInfluenceGainAfterTroopDonation | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *donatingParty*, | |  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *donatedTroop*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *donatedSettlement* ) | | abstract |

