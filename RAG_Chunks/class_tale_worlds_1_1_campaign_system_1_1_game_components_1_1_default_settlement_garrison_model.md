--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementGarrisonModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementGarrisonModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override int | [GetMaximumDailyAutoRecruitmentCount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html#aaefebcb3478f371ca68d406109b38b48) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateBaseGarrisonChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html#aac58f765165ca0e7c880effec87e1ff5) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includeDescriptions=false) |
| override int | [FindNumberOfTroopsToTakeFromGarrison](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html#a5cc042833b9622200540592034150952) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, float defaultIdealGarrisonStrengthPerWalledCenter=0.0f) |
| override int | [FindNumberOfTroopsToLeaveToGarrison](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html#a469b0545ba05e764d85a86524ddc4415) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| override float | [GetMaximumDailyRepairAmount](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html#a3b5a953354338066d2285f2c21dacf6f) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementGarrisonModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html) | |
| int | [GetMaximumDailyAutoRecruitmentCount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html#a7823a536335257a9b2733a552ec5edfd) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateBaseGarrisonChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html#a57c8e171c30bcc9c93a3f617cf55ba1b) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool includeDescriptions=false) |
| int | [FindNumberOfTroopsToTakeFromGarrison](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html#a8f86bc92ebcd7f19631548d0dac8c810) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, float idealGarrisonStrengthPerWalledCenter=0.0f) |
| int | [FindNumberOfTroopsToLeaveToGarrison](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html#ad5ecad6471f460903425f4c3e07f1f69) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| float | [GetMaximumDailyRepairAmount](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html#ac5df4918d8a35ce33f35b9757ae1b716) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html#aaefebcb3478f371ca68d406109b38b48)GetMaximumDailyAutoRecruitmentCount()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementGarrisonModel.GetMaximumDailyAutoRecruitmentCount | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html#aac58f765165ca0e7c880effec87e1ff5)CalculateBaseGarrisonChange()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementGarrisonModel.CalculateBaseGarrisonChange | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html#a5cc042833b9622200540592034150952)FindNumberOfTroopsToTakeFromGarrison()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementGarrisonModel.FindNumberOfTroopsToTakeFromGarrison | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | float | *defaultIdealGarrisonStrengthPerWalledCenter* = 0::0f ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html#a469b0545ba05e764d85a86524ddc4415)FindNumberOfTroopsToLeaveToGarrison()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementGarrisonModel.FindNumberOfTroopsToLeaveToGarrison | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html#a3b5a953354338066d2285f2c21dacf6f)GetMaximumDailyRepairAmount()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementGarrisonModel.GetMaximumDailyRepairAmount | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

