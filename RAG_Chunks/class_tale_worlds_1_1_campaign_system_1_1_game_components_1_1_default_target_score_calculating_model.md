--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetPatrollingFactor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a3e12bf5643159a075c742e9bf1813639) (bool isNavalPatrolling) |
| override float | [CalculatePatrollingScoreForSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#aacef12a116b1d264b0052f946d5eab0f) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool isFromPort, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override float | [CurrentObjectiveValue](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a425472ea858254ae821e302f057890ed) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override float | [GetTargetScoreForFaction](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a253aa030034c03e0a5d773fa1d0416aa) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement, [Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) missionType, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, float ourStrength) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html) | |
| float | [GetPatrollingFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#aaa5d48697b1f8862b036650a972df86a) (bool isNavalPatrolling) |
| float | [GetTargetScoreForFaction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a7e8709dda75f8b084c059086fbf0987a) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement, [Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) missionType, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, float ourStrength) |
| float | [CalculatePatrollingScoreForSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a961e116abee19875e36254a75d4bfc30) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool isFromPort, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| float | [CurrentObjectiveValue](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#ae34c8ad353e131496d846470f3daa31e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| override float | [TravelingToAssignmentFactor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#ac9273f607fe2720fc350a757b9379fca) `[get]` |
| override float | [BesiegingFactor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a881aaaab8afae1c1d05078cd2adeb2b5) `[get]` |
| override float | [AssaultingTownFactor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a957d1c57fb537566ad6fd76d4e461ce0) `[get]` |
| override float | [RaidingFactor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#ac88ed63bb05a7008e3e81faadcb16782) `[get]` |
| override float | [DefendingFactor](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a37b7155e15c503cf10f88a1bf80047ca) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html) | |
| float | [TravelingToAssignmentFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#ac55337eba3a0e49a99224a07df88ac3c) `[get]` |
| float | [BesiegingFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a5c3d85ba092870134b9c2ffd705228af) `[get]` |
| float | [AssaultingTownFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#af776cb6456353d90e7d3b23db7429c71) `[get]` |
| float | [RaidingFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#af434ef43578f7a2acb49a54f088dd603) `[get]` |
| float | [DefendingFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a8fe79802114a71873c207d2a6549300f) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a3e12bf5643159a075c742e9bf1813639)GetPatrollingFactor()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel.GetPatrollingFactor | ( | bool | *isNavalPatrolling* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#aacef12a116b1d264b0052f946d5eab0f)CalculatePatrollingScoreForSettlement()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel.CalculatePatrollingScoreForSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *isFromPort*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a425472ea858254ae821e302f057890ed)CurrentObjectiveValue()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel.CurrentObjectiveValue | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a253aa030034c03e0a5d773fa1d0416aa)GetTargetScoreForFaction()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel.GetTargetScoreForFaction | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement*, |
|  |  | [Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) | *missionType*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | float | *ourStrength* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#ac9273f607fe2720fc350a757b9379fca)TravelingToAssignmentFactor
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel.TravelingToAssignmentFactor | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a881aaaab8afae1c1d05078cd2adeb2b5)BesiegingFactor
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel.BesiegingFactor | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a957d1c57fb537566ad6fd76d4e461ce0)AssaultingTownFactor
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel.AssaultingTownFactor | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#ac88ed63bb05a7008e3e81faadcb16782)RaidingFactor
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel.RaidingFactor | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html#a37b7155e15c503cf10f88a1bf80047ca)DefendingFactor
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel.DefendingFactor | | get |

