--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override bool | [ShouldConsiderAttacking](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a7a0d22c0faf696ccd157343c61657323) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetParty) |
| override bool | [ShouldConsiderAvoiding](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#ac2003ffde9cbe38eaa864075a5fd6972) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) targetParty) |
| override float | [GetPatrolRadius](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a80261f5f06a79f75805edf3248816699) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) patrolPoint) |
| override bool | [ShouldPartyCheckInitiativeBehavior](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a7d58667fabefc63cf34fdf64e983fadd) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override void | [GetBestInitiativeBehavior](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a2f7784449dbd5410ce0c89ffebb651f3) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, out [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) bestInitiativeBehavior, out [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) bestInitiativeTargetParty, out float bestInitiativeBehaviorScore, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) averageEnemyVec) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html) | |
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
| override float | [AiCheckInterval](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a142b258220a648b50752cd131d9cd3f1) `[get]` |
| override float | [FleeToNearbyPartyRadius](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a5071d72fdfe85cb83bde117462cf9413) `[get]` |
| override float | [FleeToNearbySettlementRadius](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a91befa95101bd71967e21f00562de764) `[get]` |
| override float | [HideoutPatrolDistanceAsDays](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a160ba0b8aa286f2af28b5c04766cbb9f) `[get]` |
| override float | [FortificationPatrolDistanceAsDays](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a59f668856c30b878daedb79cdee62f59) `[get]` |
| override float | [VillagePatrolDistanceAsDays](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a204b75e6e92c2cc5a02d81eae777f8d7) `[get]` |
| override float | [SettlementDefendingNearbyPartyCheckRadius](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a6b9ce5c1522b87dff55c5ce0c6b5c551) `[get]` |
| override float | [SettlementDefendingWaitingPositionRadius](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a86b741e2236863fff35835b5f3e7835c) `[get]` |
| override float | [NeededFoodsInDaysThresholdForSiege](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a918d4ba258a8ff9c561bb3dd0bdbc192) `[get]` |
| override float | [NeededFoodsInDaysThresholdForRaid](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a88f6bc9d539e4177ad0ea3789b0618e9) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MobilePartyAIModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_mobile_party_a_i_model.html) | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a7a0d22c0faf696ccd157343c61657323)ShouldConsiderAttacking()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.ShouldConsiderAttacking | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *targetParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#ac2003ffde9cbe38eaa864075a5fd6972)ShouldConsiderAvoiding()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.ShouldConsiderAvoiding | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *targetParty* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a80261f5f06a79f75805edf3248816699)GetPatrolRadius()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.GetPatrolRadius | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *patrolPoint* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a7d58667fabefc63cf34fdf64e983fadd)ShouldPartyCheckInitiativeBehavior()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.ShouldPartyCheckInitiativeBehavior | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a2f7784449dbd5410ce0c89ffebb651f3)GetBestInitiativeBehavior()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.GetBestInitiativeBehavior | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | out [AiBehavior](namespace_tale_worlds_1_1_campaign_system_1_1_party.html#a26b17169ec73bfcd7683184258b8f571) | *bestInitiativeBehavior*, |
|  |  | out [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *bestInitiativeTargetParty*, |
|  |  | out float | *bestInitiativeBehaviorScore*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *averageEnemyVec* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a142b258220a648b50752cd131d9cd3f1)AiCheckInterval
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.AiCheckInterval | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a5071d72fdfe85cb83bde117462cf9413)FleeToNearbyPartyRadius
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.FleeToNearbyPartyRadius | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a91befa95101bd71967e21f00562de764)FleeToNearbySettlementRadius
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.FleeToNearbySettlementRadius | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a160ba0b8aa286f2af28b5c04766cbb9f)HideoutPatrolDistanceAsDays
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.HideoutPatrolDistanceAsDays | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a59f668856c30b878daedb79cdee62f59)FortificationPatrolDistanceAsDays
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.FortificationPatrolDistanceAsDays | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a204b75e6e92c2cc5a02d81eae777f8d7)VillagePatrolDistanceAsDays
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.VillagePatrolDistanceAsDays | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a6b9ce5c1522b87dff55c5ce0c6b5c551)SettlementDefendingNearbyPartyCheckRadius
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.SettlementDefendingNearbyPartyCheckRadius | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a86b741e2236863fff35835b5f3e7835c)SettlementDefendingWaitingPositionRadius
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.SettlementDefendingWaitingPositionRadius | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a918d4ba258a8ff9c561bb3dd0bdbc192)NeededFoodsInDaysThresholdForSiege
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.NeededFoodsInDaysThresholdForSiege | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_mobile_party_a_i_model.html#a88f6bc9d539e4177ad0ea3789b0618e9)NeededFoodsInDaysThresholdForRaid
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | override float TaleWorlds.CampaignSystem.GameComponents.DefaultMobilePartyAIModel.NeededFoodsInDaysThresholdForRaid | | get |

