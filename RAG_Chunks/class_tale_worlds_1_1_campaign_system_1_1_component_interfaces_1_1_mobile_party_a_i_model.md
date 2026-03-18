--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [ShouldConsiderAvoiding](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a6d9c16a7181528e798365a55ddbcc872) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetParty) |
| bool | [ShouldConsiderAttacking](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a7c58a12050ed4f622a1b12017679994c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetParty) |
| float | [GetPatrolRadius](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a4397555758d3d5aa9e0be8ab4f01ddd7) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) patrolPoint) |
| bool | [ShouldPartyCheckInitiativeBehavior](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a2686ebb7972b66a35ad71ee38501813b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [GetBestInitiativeBehavior](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#ad140436ccab03b7f75217f78fc7a563c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, out [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) bestInitiativeBehavior, out [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) bestInitiativeTargetParty, out float bestInitiativeBehaviorScore, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) averageEnemyVec) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Properties | |
| float | [AiCheckInterval](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a5f349bbbb5685b57193108e8befc8ad9) `[get]` |
| float | [FleeToNearbyPartyRadius](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#ab80b650f6f783a55ab5f21fdecd91c60) `[get]` |
| float | [FleeToNearbySettlementRadius](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a3aa78ccce43326e04a171f3a85d71307) `[get]` |
| float | [HideoutPatrolDistanceAsDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a31bda6838415d0ebdab01afe2c08fd7b) `[get]` |
| float | [FortificationPatrolDistanceAsDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a47a4ca7033989579e57a56e5c057d75c) `[get]` |
| float | [VillagePatrolDistanceAsDays](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a19fb22e70151eb8b965bc674bf273315) `[get]` |
| float | [SettlementDefendingNearbyPartyCheckRadius](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a76b1e8431b8b55abd373bc6c395d859d) `[get]` |
| float | [SettlementDefendingWaitingPositionRadius](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#ab9775371028083fbd71173828d6a9ad3) `[get]` |
| float | [NeededFoodsInDaysThresholdForSiege](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#abfa667445496564c42d71d8a59e724fb) `[get]` |
| float | [NeededFoodsInDaysThresholdForRaid](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#adac22885a522077fcd4f32a61dcf11bc) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a6d9c16a7181528e798365a55ddbcc872)ShouldConsiderAvoiding()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.ShouldConsiderAvoiding | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *targetParty* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a7c58a12050ed4f622a1b12017679994c)ShouldConsiderAttacking()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.ShouldConsiderAttacking | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *targetParty* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a4397555758d3d5aa9e0be8ab4f01ddd7)GetPatrolRadius()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.GetPatrolRadius | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *patrolPoint* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a2686ebb7972b66a35ad71ee38501813b)ShouldPartyCheckInitiativeBehavior()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.ShouldPartyCheckInitiativeBehavior | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#ad140436ccab03b7f75217f78fc7a563c)GetBestInitiativeBehavior()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.GetBestInitiativeBehavior | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, | |  |  | out [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) | *bestInitiativeBehavior*, | |  |  | out [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *bestInitiativeTargetParty*, | |  |  | out float | *bestInitiativeBehaviorScore*, | |  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *averageEnemyVec* ) | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a5f349bbbb5685b57193108e8befc8ad9)AiCheckInterval
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.AiCheckInterval | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#ab80b650f6f783a55ab5f21fdecd91c60)FleeToNearbyPartyRadius
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.FleeToNearbyPartyRadius | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a3aa78ccce43326e04a171f3a85d71307)FleeToNearbySettlementRadius
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.FleeToNearbySettlementRadius | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a31bda6838415d0ebdab01afe2c08fd7b)HideoutPatrolDistanceAsDays
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.HideoutPatrolDistanceAsDays | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a47a4ca7033989579e57a56e5c057d75c)FortificationPatrolDistanceAsDays
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.FortificationPatrolDistanceAsDays | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a19fb22e70151eb8b965bc674bf273315)VillagePatrolDistanceAsDays
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.VillagePatrolDistanceAsDays | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#a76b1e8431b8b55abd373bc6c395d859d)SettlementDefendingNearbyPartyCheckRadius
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.SettlementDefendingNearbyPartyCheckRadius | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#ab9775371028083fbd71173828d6a9ad3)SettlementDefendingWaitingPositionRadius
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.SettlementDefendingWaitingPositionRadius | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#abfa667445496564c42d71d8a59e724fb)NeededFoodsInDaysThresholdForSiege
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.NeededFoodsInDaysThresholdForSiege | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html#adac22885a522077fcd4f32a61dcf11bc)NeededFoodsInDaysThresholdForRaid
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel.NeededFoodsInDaysThresholdForRaid | | getabstract |

