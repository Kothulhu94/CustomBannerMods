--- SOURCE: class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html ---

StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.TargetScoreCalculatingModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_target_score_calculating_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [GetPatrollingFactor](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#a768637399978cd6e8b99fe1029a0f3d6) (bool isNavalPatrolling) |
| override float | [CalculatePatrollingScoreForSettlement](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#a9abced52d16641d1ca16dd73d88f6419) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool isFromPort, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override float | [CurrentObjectiveValue](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#a895aad0013dfc4647fa3f7ed7aaccc39) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override float | [GetTargetScoreForFaction](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#ac56246ae377485e563ff5863bc936561) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement, [Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) missionType, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, float ourStrength) |
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
| override float | [TravelingToAssignmentFactor](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#ae531eff413470af59fed05eb9e8bfb48) `[get]` |
| override float | [BesiegingFactor](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#ae5eef528edd8c514df5cd909ad027f96) `[get]` |
| override float | [AssaultingTownFactor](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#a08aa063dee6be0b52791cd1b22e33f3a) `[get]` |
| override float | [RaidingFactor](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#a07430a5121f4b81f5e716dfeda4a2971) `[get]` |
| override float | [DefendingFactor](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#ab963df3d7dd46b40aa046391f8825070) `[get]` |
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

[◆](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#a768637399978cd6e8b99fe1029a0f3d6)GetPatrollingFactor()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel.GetPatrollingFactor | ( | bool | *isNavalPatrolling* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#a9abced52d16641d1ca16dd73d88f6419)CalculatePatrollingScoreForSettlement()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel.CalculatePatrollingScoreForSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | bool | *isFromPort*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* ) |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#a895aad0013dfc4647fa3f7ed7aaccc39)CurrentObjectiveValue()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel.CurrentObjectiveValue | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#ac56246ae377485e563ff5863bc936561)GetTargetScoreForFaction()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel.GetTargetScoreForFaction | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement*, |
|  |  | [Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) | *missionType*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | float | *ourStrength* ) |

Property Documentation
----------------------

[◆](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#ae531eff413470af59fed05eb9e8bfb48)TravelingToAssignmentFactor
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel.TravelingToAssignmentFactor | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#ae5eef528edd8c514df5cd909ad027f96)BesiegingFactor
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel.BesiegingFactor | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#a08aa063dee6be0b52791cd1b22e33f3a)AssaultingTownFactor
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel.AssaultingTownFactor | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#a07430a5121f4b81f5e716dfeda4a2971)RaidingFactor
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel.RaidingFactor | | get |

[◆](class_story_mode_1_1_game_components_1_1_story_mode_target_score_calculating_model.html#ab963df3d7dd46b40aa046391f8825070)DefendingFactor
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float StoryMode.GameComponents.StoryModeTargetScoreCalculatingModel.DefendingFactor | | get |

