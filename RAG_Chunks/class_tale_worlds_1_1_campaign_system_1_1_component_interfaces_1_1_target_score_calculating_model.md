--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html), and [TaleWorlds.CampaignSystem.GameComponents.DefaultTargetScoreCalculatingModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_target_score_calculating_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetPatrollingFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#aaa5d48697b1f8862b036650a972df86a) (bool isNavalPatrolling) |
| float | [GetTargetScoreForFaction](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a7e8709dda75f8b084c059086fbf0987a) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement, [Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) missionType, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, float ourStrength) |
| float | [CalculatePatrollingScoreForSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a961e116abee19875e36254a75d4bfc30) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool isFromPort, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| float | [CurrentObjectiveValue](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#ae34c8ad353e131496d846470f3daa31e) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| float | [TravelingToAssignmentFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#ac55337eba3a0e49a99224a07df88ac3c) `[get]` |
| float | [BesiegingFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a5c3d85ba092870134b9c2ffd705228af) `[get]` |
| float | [AssaultingTownFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#af776cb6456353d90e7d3b23db7429c71) `[get]` |
| float | [RaidingFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#af434ef43578f7a2acb49a54f088dd603) `[get]` |
| float | [DefendingFactor](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a8fe79802114a71873c207d2a6549300f) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#aaa5d48697b1f8862b036650a972df86a)GetPatrollingFactor()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel.GetPatrollingFactor | ( | bool | *isNavalPatrolling* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a7e8709dda75f8b084c059086fbf0987a)GetTargetScoreForFaction()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel.GetTargetScoreForFaction | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement*, | |  |  | [Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) | *missionType*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | float | *ourStrength* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a961e116abee19875e36254a75d4bfc30)CalculatePatrollingScoreForSettlement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel.CalculatePatrollingScoreForSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *isFromPort*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#ae34c8ad353e131496d846470f3daa31e)CurrentObjectiveValue()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel.CurrentObjectiveValue | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#ac55337eba3a0e49a99224a07df88ac3c)TravelingToAssignmentFactor
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel.TravelingToAssignmentFactor | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a5c3d85ba092870134b9c2ffd705228af)BesiegingFactor
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel.BesiegingFactor | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#af776cb6456353d90e7d3b23db7429c71)AssaultingTownFactor
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel.AssaultingTownFactor | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#af434ef43578f7a2acb49a54f088dd603)RaidingFactor
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel.RaidingFactor | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html#a8fe79802114a71873c207d2a6549300f)DefendingFactor
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel.DefendingFactor | | getabstract |

