--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_army.html ---

TaleWorlds.CampaignSystem.Army Class ReferenceInherits [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) : int {     [Besieger](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4aa641dc8c113f3868a0313a25246efeaca) = 0 ,     [Raider](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4aa53ee1f6d941b631ed8148da497853787) ,     [Defender](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4aaee90445284a3f5eb04b08417e16ecb95) ,     [Patrolling](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4aaa97f35cf92005d4f3a99bb9c18992e6f) ,     [NumberOfArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4aa2e41906a780aa13217ddd69e6867c4dc)   } |
| enum | [ArmyDispersionReason](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798) {     [Unknown](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798a88183b946cc5f0e8c96b2e66e1c74a7e) ,     [DismissalRequestedWithInfluence](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798a69ea2d43e2330b208b033aef712dde28) ,     [NotEnoughParty](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798a552603908484cda8e0296db962ec72cb) ,     [KingdomChanged](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798afb9c81b38a034b657c3e3fafefadabea) ,     [CohesionDepleted](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798ad508a2deb5f4dcb603786eab530c1b76) ,     [ObjectiveFinished](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798a792447eb23d57925ca7dd718ec9562ab) ,     [LeaderPartyRemoved](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798a42e16e787647ce11913951199752375b) ,     [PlayerTakenPrisoner](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798a1a9d715ec30aa040c5c6a27f284292e5) ,     [CannotElectNewLeader](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798ad8a4aa3d8923f6f167b121f7e3ce0cb6) ,     [LeaderCannotArrivePointOnTime](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798a909e8c434d373b43bce6c7dc53400789) ,     [ArmyLeaderIsDead](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798ab53d709c0b3de1cdcb32a67c1c4b8c6b) ,     [FoodProblem](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798a66022b4bbf2428b570cd343185f2d6ed) ,     [NotEnoughTroop](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798aed8a06b5384796988e696c693bd40c5d) ,     [NoActiveWar](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798afbed72e15da0b68982f4e9576721137e) ,     [NoShipToUse](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798aabe3fbcec9c46642524ce20025e3664e) ,     [Inactivity](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798ac84542b61231d947bcc1c8226d0c3760)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| override string | [ToString](class_tale_worlds_1_1_campaign_system_1_1_army.html#ab111be4bc14def8556c42d401f91d740) () |
| float | [CalculateCurrentStrength](class_tale_worlds_1_1_campaign_system_1_1_army.html#a797ab099a77fe1663005a6826ba8eed3) () |
| float | [GetCustomStrength](class_tale_worlds_1_1_campaign_system_1_1_army.html#a067b4b419890359e30385359327ae69d) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) side, MapEvent.PowerCalculationContext context) |
|  | [Army](class_tale_worlds_1_1_campaign_system_1_1_army.html#ac94269efd1a1492c56b7047084c93cda) ([Kingdom](class_tale_worlds_1_1_campaign_system_1_1_army.html#a5ac7ca9836836c6aa505d92644ce0524) kingdom, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) leaderParty, [ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) armyType) |
| void | [UpdateName](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7930499aacd9f65f6ebf6dddd63bdbaf) () |
| bool | [DoesLeaderPartyAndAttachedPartiesContain](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7f9c5ca4442d1ea04dc431da26ce3f20) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| void | [BoostCohesionWithInfluence](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3f5e15cc683972a30dff19536fce05bd) (float cohesionToGain, int cost) |
| void | [RecalculateArmyMorale](class_tale_worlds_1_1_campaign_system_1_1_army.html#a84bce3f9e119f8a2f8b01dcb1a3c7b60) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetNotificationText](class_tale_worlds_1_1_campaign_system_1_1_army.html#aaf504b4ef508c6159a28fe2fc23a84a5) () |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetLongTermBehaviorText](class_tale_worlds_1_1_campaign_system_1_1_army.html#ab088b3103e92ff8ddb408794ac7dddde) (bool setWithLink=false) |
| void | [Gather](class_tale_worlds_1_1_campaign_system_1_1_army.html#af9c25d5dcdc2cdc2c299e746d50c50e5) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) initialHostileSettlement, MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > partiesToCallToArmy=null) |
| bool | [IsWaitingForArmyMembers](class_tale_worlds_1_1_campaign_system_1_1_army.html#a559cc8f8e6b9dcdb0dedd3008cae95e6) () |
| void | [FinishArmyObjective](class_tale_worlds_1_1_campaign_system_1_1_army.html#adb2851791dda2ea6784e1a1a4e72c9a5) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetRelativePositionForParty](class_tale_worlds_1_1_campaign_system_1_1_army.html#a2e18ddc65c0420ed17256cd87e7eee22) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) armyFacing) |
| void | [AddPartyToMergedParties](class_tale_worlds_1_1_campaign_system_1_1_army.html#a5f5d2de65ce12013d1b9371405a5f164) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [SetPositionAfterMapChange](class_tale_worlds_1_1_campaign_system_1_1_army.html#aaf608a87acc29677a9411e4ebfb3cf63) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) newPosition) |
| void | [CheckPositionsForMapChangeAndUpdateIfNeeded](class_tale_worlds_1_1_campaign_system_1_1_army.html#aac46c6a29a8375205d3436a9464d2db9) () |

|  |  |
| --- | --- |
| Properties | |
| float | [GatheringPositionMaxDistanceToTheSettlement](class_tale_worlds_1_1_campaign_system_1_1_army.html#a971b0cafdbbc2ef0a9023149c93cc1fa) `[get]` |
| float | [GatheringPositionMinDistanceToTheSettlement](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3e30895f22b7c5918760166ca7e805a1) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [Parties](class_tale_worlds_1_1_campaign_system_1_1_army.html#af6f0d7963737e0a024358ff2f79cfcc8) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [EncyclopediaLinkWithName](class_tale_worlds_1_1_campaign_system_1_1_army.html#a9cb48fed5869a341c6d4a38bc199dbf6) `[get]` |
| [ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) | [ArmyType](class_tale_worlds_1_1_campaign_system_1_1_army.html#aae313a91b6dffb6ca4e3c4e37527946d) `[get, set]` |
| [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | [ArmyOwner](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7e007fd9a522f1bd556559713680bcfd) `[get, set]` |
| float | [Cohesion](class_tale_worlds_1_1_campaign_system_1_1_army.html#ae20a0a8253cef5afd89b06dfde4f901f) `[get, set]` |
| float | [DailyCohesionChange](class_tale_worlds_1_1_campaign_system_1_1_army.html#a4a781619f545c2d431df75d65c25c9fe) `[get]` |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [DailyCohesionChangeExplanation](class_tale_worlds_1_1_campaign_system_1_1_army.html#a5bbfb7d173aab09a330552fb259cfd22) `[get]` |
| int | [CohesionThresholdForDispersion](class_tale_worlds_1_1_campaign_system_1_1_army.html#a072adad60554aa412fdddc492409df2f) `[get]` |
| float | [Morale](class_tale_worlds_1_1_campaign_system_1_1_army.html#a8df08eb5602c78557cc4319ace0d2825) `[get]` |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [LeaderParty](class_tale_worlds_1_1_campaign_system_1_1_army.html#a49c6458198162a6d1eeb1038b87fddf1) `[get]` |
| int | [LeaderPartyAndAttachedPartiesCount](class_tale_worlds_1_1_campaign_system_1_1_army.html#a0ce344663b5e6379e194627aab62cd15) `[get]` |
| float | [EstimatedStrength](class_tale_worlds_1_1_campaign_system_1_1_army.html#a5d6f100121b6270a1ee2e8a63d9ee0bf) `[get]` |
| Kingdom | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_army.html#a5ac7ca9836836c6aa505d92644ce0524) `[get, set]` |
| [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) | [AiBehaviorObject](class_tale_worlds_1_1_campaign_system_1_1_army.html#aa7e9936be78a573eacbe9203b291cd5e) `[get, set]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_army.html#a32230d3879dc77ec577bc2dd221b5cf5) `[get]` |
| int | [TotalHealthyMembers](class_tale_worlds_1_1_campaign_system_1_1_army.html#aa847c04e80937005244362701495bf1f) `[get]` |
| int | [TotalManCount](class_tale_worlds_1_1_campaign_system_1_1_army.html#ac0dcc62af971d84a6ef8b7e38fbf2191) `[get]` |
| int | [TotalRegularCount](class_tale_worlds_1_1_campaign_system_1_1_army.html#a88bdf005f029d5ea0ebe92cf540ce21c) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_campaign_system_1_1_army.html#a970605a75435575fb20809a55079cb98) `[get]` |
| bool | [IsArmyInGatheringState](class_tale_worlds_1_1_campaign_system_1_1_army.html#a50006fc517158264042faf4fff95284e) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a)ArmyTypes
---------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Army.ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) : int |

| Enumerator | |
| --- | --- |
| Besieger |  |
| Raider |  |
| Defender |  |
| Patrolling |  |
| NumberOfArmyTypes |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798)ArmyDispersionReason
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.CampaignSystem.Army.ArmyDispersionReason](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7de83bf41d7efbfc767ec4607de42798) |

| Enumerator | |
| --- | --- |
| Unknown |  |
| DismissalRequestedWithInfluence |  |
| NotEnoughParty |  |
| KingdomChanged |  |
| CohesionDepleted |  |
| ObjectiveFinished |  |
| LeaderPartyRemoved |  |
| PlayerTakenPrisoner |  |
| CannotElectNewLeader |  |
| LeaderCannotArrivePointOnTime |  |
| ArmyLeaderIsDead |  |
| FoodProblem |  |
| NotEnoughTroop |  |
| NoActiveWar |  |
| NoShipToUse |  |
| Inactivity |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#ac94269efd1a1492c56b7047084c93cda)Army()
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Army.Army | ( | [Kingdom](class_tale_worlds_1_1_campaign_system_1_1_army.html#a5ac7ca9836836c6aa505d92644ce0524) | *kingdom*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *leaderParty*, |
|  |  | [ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) | *armyType* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#ab111be4bc14def8556c42d401f91d740)ToString()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.CampaignSystem.Army.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a797ab099a77fe1663005a6826ba8eed3)CalculateCurrentStrength()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Army.CalculateCurrentStrength | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a067b4b419890359e30385359327ae69d)GetCustomStrength()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Army.GetCustomStrength | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *side*, |
|  |  | MapEvent.PowerCalculationContext | *context* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7930499aacd9f65f6ebf6dddd63bdbaf)UpdateName()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Army.UpdateName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7f9c5ca4442d1ea04dc431da26ce3f20)DoesLeaderPartyAndAttachedPartiesContain()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Army.DoesLeaderPartyAndAttachedPartiesContain | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3f5e15cc683972a30dff19536fce05bd)BoostCohesionWithInfluence()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Army.BoostCohesionWithInfluence | ( | float | *cohesionToGain*, |
|  |  | int | *cost* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a84bce3f9e119f8a2f8b01dcb1a3c7b60)RecalculateArmyMorale()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Army.RecalculateArmyMorale | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#aaf504b4ef508c6159a28fe2fc23a84a5)GetNotificationText()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Army.GetNotificationText | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#ab088b3103e92ff8ddb408794ac7dddde)GetLongTermBehaviorText()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Army.GetLongTermBehaviorText | ( | bool | *setWithLink* = false | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#af9c25d5dcdc2cdc2c299e746d50c50e5)Gather()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Army.Gather | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *initialHostileSettlement*, |
|  |  | MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | *partiesToCallToArmy* = null ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a559cc8f8e6b9dcdb0dedd3008cae95e6)IsWaitingForArmyMembers()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Army.IsWaitingForArmyMembers | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#adb2851791dda2ea6784e1a1a4e72c9a5)FinishArmyObjective()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Army.FinishArmyObjective | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a2e18ddc65c0420ed17256cd87e7eee22)GetRelativePositionForParty()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Army.GetRelativePositionForParty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *armyFacing* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a5f5d2de65ce12013d1b9371405a5f164)AddPartyToMergedParties()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Army.AddPartyToMergedParties | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#aaf608a87acc29677a9411e4ebfb3cf63)SetPositionAfterMapChange()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Army.SetPositionAfterMapChange | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *newPosition* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#aac46c6a29a8375205d3436a9464d2db9)CheckPositionsForMapChangeAndUpdateIfNeeded()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Army.CheckPositionsForMapChangeAndUpdateIfNeeded | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a971b0cafdbbc2ef0a9023149c93cc1fa)GatheringPositionMaxDistanceToTheSettlement
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Army.GatheringPositionMaxDistanceToTheSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3e30895f22b7c5918760166ca7e805a1)GatheringPositionMinDistanceToTheSettlement
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Army.GatheringPositionMinDistanceToTheSettlement | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#af6f0d7963737e0a024358ff2f79cfcc8)Parties
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.Army.Parties | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a9cb48fed5869a341c6d4a38bc199dbf6)EncyclopediaLinkWithName
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Army.EncyclopediaLinkWithName | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#aae313a91b6dffb6ca4e3c4e37527946d)ArmyType
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ArmyTypes](class_tale_worlds_1_1_campaign_system_1_1_army.html#a3ac67be2f16059a5b268539b03930b4a) TaleWorlds.CampaignSystem.Army.ArmyType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a7e007fd9a522f1bd556559713680bcfd)ArmyOwner
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) TaleWorlds.CampaignSystem.Army.ArmyOwner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#ae20a0a8253cef5afd89b06dfde4f901f)Cohesion
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Army.Cohesion | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a4a781619f545c2d431df75d65c25c9fe)DailyCohesionChange
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Army.DailyCohesionChange | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a5bbfb7d173aab09a330552fb259cfd22)DailyCohesionChangeExplanation
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.Army.DailyCohesionChangeExplanation | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a072adad60554aa412fdddc492409df2f)CohesionThresholdForDispersion
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Army.CohesionThresholdForDispersion | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a8df08eb5602c78557cc4319ace0d2825)Morale
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Army.Morale | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a49c6458198162a6d1eeb1038b87fddf1)LeaderParty
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.Army.LeaderParty | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a0ce344663b5e6379e194627aab62cd15)LeaderPartyAndAttachedPartiesCount
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Army.LeaderPartyAndAttachedPartiesCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a5d6f100121b6270a1ee2e8a63d9ee0bf)EstimatedStrength
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Army.EstimatedStrength | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a5ac7ca9836836c6aa505d92644ce0524)Kingdom
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Kingdom TaleWorlds.CampaignSystem.Army.Kingdom | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#aa7e9936be78a573eacbe9203b291cd5e)AiBehaviorObject
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) TaleWorlds.CampaignSystem.Army.AiBehaviorObject | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a32230d3879dc77ec577bc2dd221b5cf5)Name
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Army.Name | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#aa847c04e80937005244362701495bf1f)TotalHealthyMembers
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Army.TotalHealthyMembers | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#ac0dcc62af971d84a6ef8b7e38fbf2191)TotalManCount
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Army.TotalManCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a88bdf005f029d5ea0ebe92cf540ce21c)TotalRegularCount
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.Army.TotalRegularCount | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a970605a75435575fb20809a55079cb98)IsReady
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Army.IsReady | | get |

Implements [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html#a69166dbcedc127fea26c01d2428d01d7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_army.html#a50006fc517158264042faf4fff95284e)IsArmyInGatheringState
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Army.IsArmyInGatheringState | | get |

