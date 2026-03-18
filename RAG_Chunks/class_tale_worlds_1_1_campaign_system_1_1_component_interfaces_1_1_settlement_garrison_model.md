--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementGarrisonModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultSettlementGarrisonModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_settlement_garrison_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html#a7823a536335257a9b2733a552ec5edfd)GetMaximumDailyAutoRecruitmentCount()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementGarrisonModel.GetMaximumDailyAutoRecruitmentCount | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html#a57c8e171c30bcc9c93a3f617cf55ba1b)CalculateBaseGarrisonChange()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementGarrisonModel.CalculateBaseGarrisonChange | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html#a8f86bc92ebcd7f19631548d0dac8c810)FindNumberOfTroopsToTakeFromGarrison()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementGarrisonModel.FindNumberOfTroopsToTakeFromGarrison | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | float | *idealGarrisonStrengthPerWalledCenter* = 0.0f ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html#ad5ecad6471f460903425f4c3e07f1f69)FindNumberOfTroopsToLeaveToGarrison()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementGarrisonModel.FindNumberOfTroopsToLeaveToGarrison | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_settlement_garrison_model.html#ac5df4918d8a35ce33f35b9757ae1b716)GetMaximumDailyRepairAmount()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.SettlementGarrisonModel.GetMaximumDailyRepairAmount | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  | | abstract |

