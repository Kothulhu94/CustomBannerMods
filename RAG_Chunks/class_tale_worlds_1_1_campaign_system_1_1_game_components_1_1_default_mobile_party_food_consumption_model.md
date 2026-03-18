--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_food_consumption_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyFoodConsumptionModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyFoodConsumptionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyBaseFoodConsumptionf](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_food_consumption_model.html#a459bcda6cb96fe73f339dfb139657b12) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool includeDescription=false) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyFoodConsumptionf](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_food_consumption_model.html#a8b7f28d2e88b6e2a453d4d515cd310a1) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) baseConsumption) |
| override bool | [DoesPartyConsumeFood](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_food_consumption_model.html#af5b77c86e5b42df6ce238206d5083bca) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyFoodConsumptionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html) | |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyBaseFoodConsumptionf](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#af8431f36a63e788aff223bd9580d8035) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool includeDescription=false) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyFoodConsumptionf](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#a2a51a56da7a86fd03dea05ddf0663bf8) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) baseConsumption) |
| bool | [DoesPartyConsumeFood](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#a5bec106ed3ca4e082cc9aba1027611ab) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override int | [NumberOfMenOnMapToEatOneFood](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_food_consumption_model.html#a6ebb755df6dd85780ce8b27858ae0053) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyFoodConsumptionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html) | |
| int | [NumberOfMenOnMapToEatOneFood](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_food_consumption_model.html#aaf911787e5a5192d4e09e8169adda71b) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_food_consumption_model.html#a459bcda6cb96fe73f339dfb139657b12)CalculateDailyBaseFoodConsumptionf()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyFoodConsumptionModel.CalculateDailyBaseFoodConsumptionf | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | bool | *includeDescription* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_food_consumption_model.html#a8b7f28d2e88b6e2a453d4d515cd310a1)CalculateDailyFoodConsumptionf()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyFoodConsumptionModel.CalculateDailyFoodConsumptionf | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | *baseConsumption* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_food_consumption_model.html#af5b77c86e5b42df6ce238206d5083bca)DoesPartyConsumeFood()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyFoodConsumptionModel.DoesPartyConsumeFood | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_food_consumption_model.html#a6ebb755df6dd85780ce8b27858ae0053)NumberOfMenOnMapToEatOneFood
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyFoodConsumptionModel.NumberOfMenOnMapToEatOneFood | | get |

