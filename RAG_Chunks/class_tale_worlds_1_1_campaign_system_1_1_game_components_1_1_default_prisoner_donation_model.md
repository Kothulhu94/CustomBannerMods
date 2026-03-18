--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_donation_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerDonationModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerDonationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_donation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [CalculateRelationGainAfterHeroPrisonerDonate](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_donation_model.html#af990800b114ce1a417ffea9f4d5a2c4e) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) donatingParty, [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) donatedHero, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) donatedSettlement) |
| override float | [CalculateInfluenceGainAfterPrisonerDonation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_donation_model.html#a3320394f09824f04502becbcecb3a097) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) donatingParty, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) donatedPrisoner, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) donatedSettlement) |
| override float | [CalculateInfluenceGainAfterTroopDonation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_donation_model.html#afe256c103d0e49fbfef3c8e87c8003f7) ([PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) donatingParty, [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) donatedCharacter, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) donatedSettlement) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PrisonerDonationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_prisoner_donation_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_donation_model.html#af990800b114ce1a417ffea9f4d5a2c4e)CalculateRelationGainAfterHeroPrisonerDonate()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerDonationModel.CalculateRelationGainAfterHeroPrisonerDonate | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *donatingParty*, |
|  |  | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *donatedHero*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *donatedSettlement* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_donation_model.html#a3320394f09824f04502becbcecb3a097)CalculateInfluenceGainAfterPrisonerDonation()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerDonationModel.CalculateInfluenceGainAfterPrisonerDonation | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *donatingParty*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *donatedPrisoner*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *donatedSettlement* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_prisoner_donation_model.html#afe256c103d0e49fbfef3c8e87c8003f7)CalculateInfluenceGainAfterTroopDonation()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultPrisonerDonationModel.CalculateInfluenceGainAfterTroopDonation | ( | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *donatingParty*, |
|  |  | [CharacterObject](class_tale_worlds_1_1_campaign_system_1_1_character_object.html) | *donatedCharacter*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *donatedSettlement* ) |

