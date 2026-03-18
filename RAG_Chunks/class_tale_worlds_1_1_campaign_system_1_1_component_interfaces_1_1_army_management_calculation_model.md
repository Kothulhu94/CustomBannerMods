--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultArmyManagementCalculationModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_army_management_calculation_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a1dd4d931b2ee4b45266ab5211c927ed9)CanPlayerCreateArmy()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.CanPlayerCreateArmy | ( | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *disabledReason* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a0fd4a75ac1a3000100826a13c6fbe498)CalculatePartyInfluenceCost()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.CalculatePartyInfluenceCost | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *armyLeaderParty*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#ad56440a50f502f963866cbcc5d849a0d)DailyBeingAtArmyInfluenceAward()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.DailyBeingAtArmyInfluenceAward | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *armyMemberParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a361ca6361ec4bd48849674cd934b4da4)GetMobilePartiesToCallToArmy()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.GetMobilePartiesToCallToArmy | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *leaderParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#af939fb7966105f232627956ac65d3afc)CalculateTotalInfluenceCost()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.CalculateTotalInfluenceCost | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, | |  |  | float | *percentage* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a6990995edae375da914fc6da7a77a937)GetPartySizeScore()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.GetPartySizeScore | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#adf0585d0aff9361e7fed9212d75bde6c)CheckPartyEligibility()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.CheckPartyEligibility | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | out [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *explanation* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#aea4de6837bb53639de8beaa58a36f5cf)GetPartyRelation()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.GetPartyRelation | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#ae20cc3ad6d8d8106f9bcf47b684de5a8)CalculateDailyCohesionChange()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.CalculateDailyCohesionChange | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a81c3738d2ee67d785bb7dcecf05153b2)CalculateNewCohesion()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.CalculateNewCohesion | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, | |  |  | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | *newParty*, | |  |  | int | *calculatedCohesion*, | |  |  | int | *sign* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#abc7bbfd2425fa7938af80eeafead4d1e)GetCohesionBoostInfluenceCost()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.GetCohesionBoostInfluenceCost | ( | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html) | *army*, | |  |  | int | *percentageToBoost* = 100 ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a4616912c1353562ce51d0d3d04779b51)AIMobilePartySizeRatioToCallToArmy
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.AIMobilePartySizeRatioToCallToArmy | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a874af88dbd4c0781fd75ac54aaf42585)PlayerMobilePartySizeRatioToCallToArmy
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.PlayerMobilePartySizeRatioToCallToArmy | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#abe83ce76a694e8729c9e8f7d1c47b063)MinimumNeededFoodInDaysToCallToArmy
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.MinimumNeededFoodInDaysToCallToArmy | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a01d63647f3d9c682859123671eb1c85e)MaximumDistanceToCallToArmy
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.MaximumDistanceToCallToArmy | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a0bb9a71c3579b066b3a6dcc048f5047e)InfluenceValuePerGold
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.InfluenceValuePerGold | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#ad090a864d44422ad0fa7acef351c4445)AverageCallToArmyCost
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.AverageCallToArmyCost | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#a509ef2040c02dba440b366d4f0582da5)CohesionThresholdForDispersion
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.CohesionThresholdForDispersion | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_army_management_calculation_model.html#abf61fc050b645674c621d1df33909482)MaximumWaitTime
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.ArmyManagementCalculationModel.MaximumWaitTime | | getabstract |

