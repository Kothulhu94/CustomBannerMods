--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html ---

TaleWorlds.CampaignSystem.Map.IInteractablePoint Interface ReferenceInherited by [TaleWorlds.CampaignSystem.Naval.AnchorPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html), [TaleWorlds.CampaignSystem.Party.PartyBase](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_party_base.html), and [TaleWorlds.CampaignSystem.Track](class_tale_worlds_1_1_campaign_system_1_1_track.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetInteractionPosition](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html#a491ca02617f382b8f9d2272c76171f29) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) interactingParty) |
| bool | [CanPartyInteract](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html#aa47ac67abc11ab368ea92ef209fbecd7) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, float dt) |
| void | [OnPartyInteraction](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html#af1f6ddb3c35241d1c87d1c37f80d730f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html#a491ca02617f382b8f9d2272c76171f29)GetInteractionPosition()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Map.IInteractablePoint.GetInteractionPosition | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *interactingParty* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Naval.AnchorPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a9ade1771c2f7f0346fa4f98e91a57b72).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html#aa47ac67abc11ab368ea92ef209fbecd7)CanPartyInteract()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Map.IInteractablePoint.CanPartyInteract | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | float | *dt* ) |

Implemented in [TaleWorlds.CampaignSystem.Naval.AnchorPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#a2aa4fb698c3ab367e5d875ba9c54b50b), and [TaleWorlds.CampaignSystem.Track](class_tale_worlds_1_1_campaign_system_1_1_track.html#a961ec9af1b5d7912793a73e9ba8a021d).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_interactable_point.html#af1f6ddb3c35241d1c87d1c37f80d730f)OnPartyInteraction()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.IInteractablePoint.OnPartyInteraction | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

Implemented in [TaleWorlds.CampaignSystem.Naval.AnchorPoint](class_tale_worlds_1_1_campaign_system_1_1_naval_1_1_anchor_point.html#ae46f8aae5a37dc3354830b01aed2cd7a).

