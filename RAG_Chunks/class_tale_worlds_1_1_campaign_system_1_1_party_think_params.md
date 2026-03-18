--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html ---

TaleWorlds.CampaignSystem.PartyThinkParams Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PartyThinkParams](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#acc02f600df00e7bfd2c66fd5153b37de) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [Reset](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a28d1dd796aee218f1166c0a86fdc788c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| void | [Initialization](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a862e01a2425ab91831a69a72c3483fb9) () |
| void | [AddPotentialArmyMember](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a594567a8b89d246fab97cb870cfd168f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) armyMember) |
| bool | [TryGetBehaviorScore](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a04552df2710d7f92a8dcaf14d3c6fc17) (in [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html) aiBehaviorData, out float score) |
| void | [SetBehaviorScore](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#ac5fef2492744667f613c412076c42481) (in [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html) aiBehaviorData, float score) |
| void | [AddBehaviorScore](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a4476de15b4cb7d86a33fb1cfa9b07725) (in ValueTuple< [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html), float > value) |

|  |  |
| --- | --- |
| Public Attributes | |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [MobilePartyOf](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a050faa8f1f502f1b56a2c2808607c89a) |
| float | [CurrentObjectiveValue](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a017a929c78fb628c9d51c672b79bcd14) |
| bool | [WillGatherAnArmy](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#ae4b7447ebc0e67e4d24b6d93ea1fd055) |
| bool | [DoNotChangeBehavior](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#aa83da8f43658b5384f0f9fedba5d99fc) |
| float | [StrengthOfLordsWithoutArmy](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#ad402178ea591be98eb6058b6a61473c8) |
| float | [StrengthOfLordsWithArmy](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a6c067b310374f2e3d480fe0fd358c973) |
| float | [StrengthOfLordsAtSameClanWithoutArmy](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a72bb914f6e32d4d467c51f429c772a9f) |

|  |  |
| --- | --- |
| Properties | |
| MBReadOnlyList< ValueTuple< [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html), float > > | [AIBehaviorScores](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#ae47f5aa83891d612fe1095eb163a7c1e) `[get]` |
| MBReadOnlyList< [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) > | [PossibleArmyMembersUponArmyCreation](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a7ee869a86063e6d852e557ec716c8faa) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#acc02f600df00e7bfd2c66fd5153b37de)PartyThinkParams()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.PartyThinkParams.PartyThinkParams | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a28d1dd796aee218f1166c0a86fdc788c)Reset()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.PartyThinkParams.Reset | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a862e01a2425ab91831a69a72c3483fb9)Initialization()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.PartyThinkParams.Initialization | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a594567a8b89d246fab97cb870cfd168f)AddPotentialArmyMember()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.PartyThinkParams.AddPotentialArmyMember | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *armyMember* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a04552df2710d7f92a8dcaf14d3c6fc17)TryGetBehaviorScore()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.PartyThinkParams.TryGetBehaviorScore | ( | in [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html) | *aiBehaviorData*, |
|  |  | out float | *score* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#ac5fef2492744667f613c412076c42481)SetBehaviorScore()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.PartyThinkParams.SetBehaviorScore | ( | in [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html) | *aiBehaviorData*, |
|  |  | float | *score* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a4476de15b4cb7d86a33fb1cfa9b07725)AddBehaviorScore()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.PartyThinkParams.AddBehaviorScore | ( | in ValueTuple< [AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html), float > | *value* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a050faa8f1f502f1b56a2c2808607c89a)MobilePartyOf
---------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.PartyThinkParams.MobilePartyOf |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a017a929c78fb628c9d51c672b79bcd14)CurrentObjectiveValue
-----------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.PartyThinkParams.CurrentObjectiveValue |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#ae4b7447ebc0e67e4d24b6d93ea1fd055)WillGatherAnArmy
------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.PartyThinkParams.WillGatherAnArmy |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#aa83da8f43658b5384f0f9fedba5d99fc)DoNotChangeBehavior
---------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.PartyThinkParams.DoNotChangeBehavior |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#ad402178ea591be98eb6058b6a61473c8)StrengthOfLordsWithoutArmy
----------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.PartyThinkParams.StrengthOfLordsWithoutArmy |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a6c067b310374f2e3d480fe0fd358c973)StrengthOfLordsWithArmy
-------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.PartyThinkParams.StrengthOfLordsWithArmy |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a72bb914f6e32d4d467c51f429c772a9f)StrengthOfLordsAtSameClanWithoutArmy
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.CampaignSystem.PartyThinkParams.StrengthOfLordsAtSameClanWithoutArmy |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#ae47f5aa83891d612fe1095eb163a7c1e)AIBehaviorScores
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<ValueTuple<[AIBehaviorData](struct_tale_worlds_1_1_campaign_system_1_1_a_i_behavior_data.html), float> > TaleWorlds.CampaignSystem.PartyThinkParams.AIBehaviorScores | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_think_params.html#a7ee869a86063e6d852e557ec716c8faa)PossibleArmyMembersUponArmyCreation
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBReadOnlyList<[MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html)> TaleWorlds.CampaignSystem.PartyThinkParams.PossibleArmyMembersUponArmyCreation | | get |

