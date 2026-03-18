--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [DailyBeingAtArmyInfluenceAward](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#addfecb4b09231f215cd25b0decaeca0f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) armyMemberParty) |
| override int | [CalculatePartyInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a3b055b7ffd267a4168761f34514aba49) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) armyLeaderParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [GetMobilePartiesToCallToArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#ac8c81ffc40185f60e5a32831946563db) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) leaderParty) |
| override int | [CalculateTotalInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#ae544061c0ee62276c612b475d0884139) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, float percentage) |
| override float | [GetPartySizeScore](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#abc4610220b8ece26ab8b2e1afb5b8b4f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyCohesionChange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#adfb717dcb137f484e740df20fc78dd2f) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, bool includeDescriptions=false) |
| override int | [CalculateNewCohesion](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a8077fef821154cf60c99f828ff8d7309) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) newParty, int calculatedCohesion, int sign) |
| override int | [GetCohesionBoostInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a94e37bb65372c8a5b9418419ca0e2017) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, int percentageToBoost=100) |
| override int | [GetPartyRelation](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a08a07bfc75133c03b984d4b29c88ba77) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override bool | [CanPlayerCreateArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a834f99ca3421d062e012e0360d8eedc7) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) disabledReason) |
| override bool | [CheckPartyEligibility](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a145b20eaffd46cfdf36c34bc04137eea) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html) | |
| bool | [CanPlayerCreateArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a1dd4d931b2ee4b45266ab5211c927ed9) (out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) disabledReason) |
| int | [CalculatePartyInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a0fd4a75ac1a3000100826a13c6fbe498) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) armyLeaderParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| float | [DailyBeingAtArmyInfluenceAward](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#ad56440a50f502f963866cbcc5d849a0d) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) armyMemberParty) |
| List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [GetMobilePartiesToCallToArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a361ca6361ec4bd48849674cd934b4da4) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) leaderParty) |
| int | [CalculateTotalInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#af939fb7966105f232627956ac65d3afc) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, float percentage) |
| float | [GetPartySizeScore](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a6990995edae375da914fc6da7a77a937) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| bool | [CheckPartyEligibility](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#adf0585d0aff9361e7fed9212d75bde6c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) explanation) |
| int | [GetPartyRelation](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#aea4de6837bb53639de8beaa58a36f5cf) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [CalculateDailyCohesionChange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#ae20cc3ad6d8d8106f9bcf47b684de5a8) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, bool includeDescriptions=false) |
| int | [CalculateNewCohesion](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a81c3738d2ee67d785bb7dcecf05153b2) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) newParty, int calculatedCohesion, int sign) |
| int | [GetCohesionBoostInfluenceCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#abc7bbfd2425fa7938af80eeafead4d1e) ([Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) army, int percentageToBoost=100) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override float | [AIMobilePartySizeRatioToCallToArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a7a73707398752d888290fbde5610871e) `[get]` |
| override float | [PlayerMobilePartySizeRatioToCallToArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a1f63a077a180b132ce5d2c49704cd689) `[get]` |
| override float | [MinimumNeededFoodInDaysToCallToArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#afd7f633dd7643466a1fa80e8d6f09b7c) `[get]` |
| override float | [MaximumDistanceToCallToArmy](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a494fc81c490c1dc8da8dfe5b00f6216c) `[get]` |
| override int | [InfluenceValuePerGold](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a5d5d698886124c4c53aa37d6f228de76) `[get]` |
| override int | [AverageCallToArmyCost](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a27d59eb6b9ad5a4029751f54cb826e7f) `[get]` |
| override int | [CohesionThresholdForDispersion](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#aa0dc2593ad6fbfef43bc15a6274b2c05) `[get]` |
| override float | [MaximumWaitTime](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#af8118872dd63173a7bcad91f1dc20528) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html) | |
| float | [AIMobilePartySizeRatioToCallToArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a4616912c1353562ce51d0d3d04779b51) `[get]` |
| float | [PlayerMobilePartySizeRatioToCallToArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a874af88dbd4c0781fd75ac54aaf42585) `[get]` |
| float | [MinimumNeededFoodInDaysToCallToArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#abe83ce76a694e8729c9e8f7d1c47b063) `[get]` |
| float | [MaximumDistanceToCallToArmy](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a01d63647f3d9c682859123671eb1c85e) `[get]` |
| int | [InfluenceValuePerGold](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a0bb9a71c3579b066b3a6dcc048f5047e) `[get]` |
| int | [AverageCallToArmyCost](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#ad090a864d44422ad0fa7acef351c4445) `[get]` |
| int | [CohesionThresholdForDispersion](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a509ef2040c02dba440b366d4f0582da5) `[get]` |
| float | [MaximumWaitTime](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#abf61fc050b645674c621d1df33909482) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#addfecb4b09231f215cd25b0decaeca0f)DailyBeingAtArmyInfluenceAward()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.DailyBeingAtArmyInfluenceAward | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *armyMemberParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a3b055b7ffd267a4168761f34514aba49)CalculatePartyInfluenceCost()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.CalculatePartyInfluenceCost | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *armyLeaderParty*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#ac8c81ffc40185f60e5a32831946563db)GetMobilePartiesToCallToArmy()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.GetMobilePartiesToCallToArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *leaderParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#ae544061c0ee62276c612b475d0884139)CalculateTotalInfluenceCost()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.CalculateTotalInfluenceCost | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, |
|  |  | float | *percentage* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#abc4610220b8ece26ab8b2e1afb5b8b4f)GetPartySizeScore()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.GetPartySizeScore | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#adfb717dcb137f484e740df20fc78dd2f)CalculateDailyCohesionChange()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.CalculateDailyCohesionChange | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a8077fef821154cf60c99f828ff8d7309)CalculateNewCohesion()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.CalculateNewCohesion | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, |
|  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *newParty*, |
|  |  | int | *calculatedCohesion*, |
|  |  | int | *sign* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a94e37bb65372c8a5b9418419ca0e2017)GetCohesionBoostInfluenceCost()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.GetCohesionBoostInfluenceCost | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, |
|  |  | int | *percentageToBoost* = 100 ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a08a07bfc75133c03b984d4b29c88ba77)GetPartyRelation()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override int TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.GetPartyRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a834f99ca3421d062e012e0360d8eedc7)CanPlayerCreateArmy()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.CanPlayerCreateArmy | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *disabledReason* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a145b20eaffd46cfdf36c34bc04137eea)CheckPartyEligibility()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.CheckPartyEligibility | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a7a73707398752d888290fbde5610871e)AIMobilePartySizeRatioToCallToArmy
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.AIMobilePartySizeRatioToCallToArmy | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a1f63a077a180b132ce5d2c49704cd689)PlayerMobilePartySizeRatioToCallToArmy
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.PlayerMobilePartySizeRatioToCallToArmy | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#afd7f633dd7643466a1fa80e8d6f09b7c)MinimumNeededFoodInDaysToCallToArmy
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.MinimumNeededFoodInDaysToCallToArmy | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a494fc81c490c1dc8da8dfe5b00f6216c)MaximumDistanceToCallToArmy
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.MaximumDistanceToCallToArmy | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a5d5d698886124c4c53aa37d6f228de76)InfluenceValuePerGold
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.InfluenceValuePerGold | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#a27d59eb6b9ad5a4029751f54cb826e7f)AverageCallToArmyCost
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.AverageCallToArmyCost | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#aa0dc2593ad6fbfef43bc15a6274b2c05)CohesionThresholdForDispersion
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override int TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.CohesionThresholdForDispersion | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html#af8118872dd63173a7bcad91f1dc20528)MaximumWaitTime
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel.MaximumWaitTime | | get |

