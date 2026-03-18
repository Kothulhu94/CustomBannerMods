--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html ---

TaleWorlds.CampaignSystem.Party.MobilePartyAi Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [FleeingData](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai_1_1_fleeing_data.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [CacheAiBehaviorPartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a805a866719f901d66c852ef58fcbef4a) () |
| void | [CheckPartyNeedsUpdate](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#afff2bc4b30c0a9192a3c4aab0e7824ed) () |
| void | [CalculateFleePosition](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a658b14e7ad1785b9adac2fce51b3a0e6) (out [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) fleeTargetPoint, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) partyToFleeFrom, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) averageEnemyVec) |
| bool | [GetNearbyPartyDataWhileDefendingSettlement](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#afcb4d720a668027e8dfc890722aa2259) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) targetSettlement, out bool shouldConsiderJoiningNearbyAllyParties, out bool shouldJoinLandSide, out bool shouldEngage, out [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mostPowerfulLandAlly, out [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mostPowerfulNavalAlly) |
| void | [DisableForHours](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#afafe6429caf2df407af6f000d6d529f5) (int hours) |
| void | [DisableAi](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a1f5e078fc123c8dd2584988f47316298) () |
| void | [EnableAi](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a530f4c0ac8cec7457d8488c090cb678f) () |
| bool | [EnableAgainAtHourIsPast](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#ad32f76a8ad08a49e761d49c7657a3d45) () |
| void | [SetDoNotAttackMainParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#ac6f5cb49bd08adff5d49707904cbcbaa) (int hours) |
| void | [SetInitiative](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a8b42d3a1c654939043dd9465be290c86) (float attackInitiative, float avoidInitiative, float hoursUntilReset) |
| void | [SetDoNotMakeNewDecisions](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#adbcc90d0bad5f3a61df17a88b07d4936) (bool doNotMakeNewDecisions) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [HourCounter](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a3d87bcbf178fdb94c8eb8862d6f575d9) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly List< ValueTuple< float, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > > | [DangerousPartiesAndTheirVecs](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#ad463e77d6ce5688e59df014fb42c39d9) = new List<(float, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html))>() |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsDisabled](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a01512ba238fb008c28f4bf2432a415ec) `[get]` |
| bool | [RethinkAtNextHourlyTick](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a0fbc9bfac30a9b04486d9ff40e3bef49) `[get, set]` |
| bool | [DoNotMakeNewDecisions](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a93aeae164a80f10b7e2a267fdb8e1add) `[get]` |
| bool | [IsAlerted](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a89deb1bd8095889e6bd0e64afbce37ef) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [DoNotAttackMainPartyUntil](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a05b6775bad415a9997f3cf66a6fb3862) `[get]` |
| float | [AvoidInitiative](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a32257e002100b28a5d9bd00d271f5776) `[get]` |
| float | [AttackInitiative](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#aeda8e1fff06d1bb8dd56115ea6d8fa55) `[get]` |
| [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) | [AiBehaviorPartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a3b5dca0905f1e497cdcc0f0dcf12ce92) `[get]` |
| [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) | [AiBehaviorInteractable](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a9b6dac51efb101a553ff107cde22f546) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a805a866719f901d66c852ef58fcbef4a)CacheAiBehaviorPartyBase()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobilePartyAi.CacheAiBehaviorPartyBase | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#afff2bc4b30c0a9192a3c4aab0e7824ed)CheckPartyNeedsUpdate()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobilePartyAi.CheckPartyNeedsUpdate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a658b14e7ad1785b9adac2fce51b3a0e6)CalculateFleePosition()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobilePartyAi.CalculateFleePosition | ( | out [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *fleeTargetPoint*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *partyToFleeFrom*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *averageEnemyVec* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#afcb4d720a668027e8dfc890722aa2259)GetNearbyPartyDataWhileDefendingSettlement()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.MobilePartyAi.GetNearbyPartyDataWhileDefendingSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *targetSettlement*, |
|  |  | out bool | *shouldConsiderJoiningNearbyAllyParties*, |
|  |  | out bool | *shouldJoinLandSide*, |
|  |  | out bool | *shouldEngage*, |
|  |  | out [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mostPowerfulLandAlly*, |
|  |  | out [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mostPowerfulNavalAlly* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#afafe6429caf2df407af6f000d6d529f5)DisableForHours()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobilePartyAi.DisableForHours | ( | int | *hours* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a1f5e078fc123c8dd2584988f47316298)DisableAi()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobilePartyAi.DisableAi | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a530f4c0ac8cec7457d8488c090cb678f)EnableAi()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobilePartyAi.EnableAi | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#ad32f76a8ad08a49e761d49c7657a3d45)EnableAgainAtHourIsPast()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Party.MobilePartyAi.EnableAgainAtHourIsPast | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#ac6f5cb49bd08adff5d49707904cbcbaa)SetDoNotAttackMainParty()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobilePartyAi.SetDoNotAttackMainParty | ( | int | *hours* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a8b42d3a1c654939043dd9465be290c86)SetInitiative()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobilePartyAi.SetInitiative | ( | float | *attackInitiative*, |
|  |  | float | *avoidInitiative*, |
|  |  | float | *hoursUntilReset* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#adbcc90d0bad5f3a61df17a88b07d4936)SetDoNotMakeNewDecisions()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Party.MobilePartyAi.SetDoNotMakeNewDecisions | ( | bool | *doNotMakeNewDecisions* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#ad463e77d6ce5688e59df014fb42c39d9)DangerousPartiesAndTheirVecs
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly List<ValueTuple<float, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)> > TaleWorlds.CampaignSystem.Party.MobilePartyAi.DangerousPartiesAndTheirVecs = new List<(float, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html))>() | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a3d87bcbf178fdb94c8eb8862d6f575d9)HourCounter
--------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.Party.MobilePartyAi.HourCounter |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a01512ba238fb008c28f4bf2432a415ec)IsDisabled
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobilePartyAi.IsDisabled | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a0fbc9bfac30a9b04486d9ff40e3bef49)RethinkAtNextHourlyTick
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobilePartyAi.RethinkAtNextHourlyTick | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a93aeae164a80f10b7e2a267fdb8e1add)DoNotMakeNewDecisions
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobilePartyAi.DoNotMakeNewDecisions | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a89deb1bd8095889e6bd0e64afbce37ef)IsAlerted
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Party.MobilePartyAi.IsAlerted | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a05b6775bad415a9997f3cf66a6fb3862)DoNotAttackMainPartyUntil
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Party.MobilePartyAi.DoNotAttackMainPartyUntil | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a32257e002100b28a5d9bd00d271f5776)AvoidInitiative
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobilePartyAi.AvoidInitiative | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#aeda8e1fff06d1bb8dd56115ea6d8fa55)AttackInitiative
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Party.MobilePartyAi.AttackInitiative | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a3b5dca0905f1e497cdcc0f0dcf12ce92)AiBehaviorPartyBase
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html) TaleWorlds.CampaignSystem.Party.MobilePartyAi.AiBehaviorPartyBase | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party_ai.html#a9b6dac51efb101a553ff107cde22f546)AiBehaviorInteractable
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html) TaleWorlds.CampaignSystem.Party.MobilePartyAi.AiBehaviorInteractable | | getset |

