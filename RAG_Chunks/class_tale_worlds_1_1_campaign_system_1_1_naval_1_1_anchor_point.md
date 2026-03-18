--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html ---

TaleWorlds.CampaignSystem.Naval.AnchorPoint Class ReferenceInherits [TaleWorlds.CampaignSystem.Map.IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html), and [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [CallFleet](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a194877d88bbb7a2e3f10764d0330acb6) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
|  | [AnchorPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#adcd93b78f36d390bc4154c30850fc06a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) owner) |
|  | [AnchorPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a782d46803c969c0efcfcc8200036d618) (AnchorPoint anchor) |
| void | [SetPosition](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#aac100c153c836ee9a4dc6a358f271b07) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| void | [SetSettlement](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a391ea7c4bcfc3e170da961a123bf2687) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [InitializeOnLoad](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ad680716fd838d1b3fe2bcd1e222823f3) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) owner) |
| bool | [CanPartyInteract](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a2aa4fb698c3ab367e5d875ba9c54b50b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, float dt) |
| void | [SetLastUsedDisembarkPosition](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#adb73dbf8c1b1930b935827ac41d63494) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) pos) |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetLastUsedDisembarkPosition](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ac0e6076569fb9243a012a2d4e62e663e) () |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetInteractionPosition](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a9ade1771c2f7f0346fa4f98e91a57b72) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) interactingParty) |
| void | [OnPartyInteraction](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ae46f8aae5a37dc3354830b01aed2cd7a) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPosition](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a799eeddc564d50a0aa955292d2052cb6) () |
| bool | [IsAtSettlement](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a42ec2d97180d2f3e7325e4e31a11eab7) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| bool | [IsTargetingSettlement](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a16d1aede6c515bb7dfa89d4cf2f09ba5) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [CheckPositionsForMapChangeAndUpdateIfNeeded](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a6b752db2e2b2faafb90a97373307bce2) () |
| void | [ResetPosition](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a54f02a5c9f4fd8d262de16428ebcf201) () |
| void | [ResetMoveTarget](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#acd1ecec3d0e861ce109695176cdf686c) () |

|  |  |
| --- | --- |
| Properties | |
| [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | [Owner](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a30dcf72ead1f67276e879ab5d15fc1b4) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [Position](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a2d7a060157f48269b142133877ee1c07) `[get]` |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [TargetPosition](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a0abd1e559a9ecd2afb9b25c72dad7e7a) `[get]` |
| bool | [IsMovingToPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ab92ccefe6dd3374c8638377da1f79bd4) `[get]` |
| bool | [IsReady](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#af8ddacc2b6c66498dff67cef42632ea9) `[get]` |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [ArrivalTime](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#af73e9ef9de53747923d8e9cff31e3e48) = [CampaignTime.Zero](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a4a9e01e38a255d6f60447d96049a68a5) `[get]` |
| bool | [IsDisabled](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a474bf1dee44c6efdcea00acaa7205363) `[get, set]` |
| bool | [IsValid](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a64cc04b3b59a3dedff1f4016cf433e2b) `[get]` |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [Name](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ab96b99d0cedeac9462df3fe1b2e7a3ea) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#adcd93b78f36d390bc4154c30850fc06a)AnchorPoint() [1/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Naval.AnchorPoint.AnchorPoint | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *owner* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a782d46803c969c0efcfcc8200036d618)AnchorPoint() [2/2]
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Naval.AnchorPoint.AnchorPoint | ( | AnchorPoint | *anchor* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a194877d88bbb7a2e3f10764d0330acb6)CallFleet()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.AnchorPoint.CallFleet | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#aac100c153c836ee9a4dc6a358f271b07)SetPosition()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.AnchorPoint.SetPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a391ea7c4bcfc3e170da961a123bf2687)SetSettlement()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.AnchorPoint.SetSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ad680716fd838d1b3fe2bcd1e222823f3)InitializeOnLoad()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.AnchorPoint.InitializeOnLoad | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *owner* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a2aa4fb698c3ab367e5d875ba9c54b50b)CanPartyInteract()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Naval.AnchorPoint.CanPartyInteract | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | float | *dt* ) |

Implements [TaleWorlds.CampaignSystem.Map.IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html#aa47ac67abc11ab368ea92ef209fbecd7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#adb73dbf8c1b1930b935827ac41d63494)SetLastUsedDisembarkPosition()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.AnchorPoint.SetLastUsedDisembarkPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *pos* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ac0e6076569fb9243a012a2d4e62e663e)GetLastUsedDisembarkPosition()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Naval.AnchorPoint.GetLastUsedDisembarkPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a9ade1771c2f7f0346fa4f98e91a57b72)GetInteractionPosition()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Naval.AnchorPoint.GetInteractionPosition | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *interactingParty* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html#a491ca02617f382b8f9d2272c76171f29).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ae46f8aae5a37dc3354830b01aed2cd7a)OnPartyInteraction()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.AnchorPoint.OnPartyInteraction | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IInteractablePoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html#af1f6ddb3c35241d1c87d1c37f80d730f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a799eeddc564d50a0aa955292d2052cb6)GetPosition()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.CampaignSystem.Naval.AnchorPoint.GetPosition | ( |  | ) |  |

Implements [TaleWorlds.Core.ITrackableBase](interface_tale_worlds_1_1_core_1_1_i_trackable_base.html#a2c1f3cba0651fa9caa3fb054640f9ea1).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a42ec2d97180d2f3e7325e4e31a11eab7)IsAtSettlement()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Naval.AnchorPoint.IsAtSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a16d1aede6c515bb7dfa89d4cf2f09ba5)IsTargetingSettlement()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Naval.AnchorPoint.IsTargetingSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a6b752db2e2b2faafb90a97373307bce2)CheckPositionsForMapChangeAndUpdateIfNeeded()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.AnchorPoint.CheckPositionsForMapChangeAndUpdateIfNeeded | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a54f02a5c9f4fd8d262de16428ebcf201)ResetPosition()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.AnchorPoint.ResetPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#acd1ecec3d0e861ce109695176cdf686c)ResetMoveTarget()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Naval.AnchorPoint.ResetMoveTarget | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a30dcf72ead1f67276e879ab5d15fc1b4)Owner
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) TaleWorlds.CampaignSystem.Naval.AnchorPoint.Owner | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a2d7a060157f48269b142133877ee1c07)Position
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Naval.AnchorPoint.Position | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a0abd1e559a9ecd2afb9b25c72dad7e7a)TargetPosition
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Naval.AnchorPoint.TargetPosition | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ab92ccefe6dd3374c8638377da1f79bd4)IsMovingToPoint
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Naval.AnchorPoint.IsMovingToPoint | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#af8ddacc2b6c66498dff67cef42632ea9)IsReady
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Naval.AnchorPoint.IsReady | | get |

Implements [TaleWorlds.CampaignSystem.ITrackableCampaignObject](interface_tale_worlds_1_1_campaign_system_1_1_i_trackable_campaign_object.html#a69166dbcedc127fea26c01d2428d01d7).

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#af73e9ef9de53747923d8e9cff31e3e48)ArrivalTime
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.Naval.AnchorPoint.ArrivalTime = [CampaignTime.Zero](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html#a4a9e01e38a255d6f60447d96049a68a5) | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a474bf1dee44c6efdcea00acaa7205363)IsDisabled
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Naval.AnchorPoint.IsDisabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a64cc04b3b59a3dedff1f4016cf433e2b)IsValid
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.Naval.AnchorPoint.IsValid | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ab96b99d0cedeac9462df3fe1b2e7a3ea)Name
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.CampaignSystem.Naval.AnchorPoint.Name | | get |

