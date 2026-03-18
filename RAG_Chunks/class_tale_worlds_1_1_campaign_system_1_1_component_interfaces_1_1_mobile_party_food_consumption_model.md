--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyFoodConsumptionModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyFoodConsumptionModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_food_consumption_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyBaseFoodConsumptionf](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#af8431f36a63e788aff223bd9580d8035) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool includeDescription=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyFoodConsumptionf](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#a2a51a56da7a86fd03dea05ddf0663bf8) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) baseConsumption) |
| bool | [DoesPartyConsumeFood](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#a5bec106ed3ca4e082cc9aba1027611ab) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| int | [NumberOfMenOnMapToEatOneFood](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#aaf911787e5a5192d4e09e8169adda71b) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#af8431f36a63e788aff223bd9580d8035)CalculateDailyBaseFoodConsumptionf()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyFoodConsumptionModel.CalculateDailyBaseFoodConsumptionf | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | bool | *includeDescription* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#a2a51a56da7a86fd03dea05ddf0663bf8)CalculateDailyFoodConsumptionf()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyFoodConsumptionModel.CalculateDailyFoodConsumptionf | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *baseConsumption* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#a5bec106ed3ca4e082cc9aba1027611ab)DoesPartyConsumeFood()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyFoodConsumptionModel.DoesPartyConsumeFood | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#aaf911787e5a5192d4e09e8169adda71b)NumberOfMenOnMapToEatOneFood
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyFoodConsumptionModel.NumberOfMenOnMapToEatOneFood | | getabstract |

