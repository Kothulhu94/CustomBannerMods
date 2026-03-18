--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_transition_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultPartyTransitionModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTransitionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_transition_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetFleetTravelTimeToPoint](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_transition_model.html#a7f364ed01bbc659bc88c6abe62ff64d4) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) target) |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetTransitionTimeDisembarking](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_transition_model.html#a9722e937f03be42cd80bff07d7a99060) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetTransitionTimeForEmbarking](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_transition_model.html#a34991b8afc6fa381f875f8defa082fe6) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.PartyTransitionModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_transition_model.html) | |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetTransitionTimeForEmbarking](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_transition_model.html#a88021dbb6473cbc860864fd972879e28) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetTransitionTimeDisembarking](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_transition_model.html#a0b1248799b9928d73b6730cd5917c579) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) mobileParty) |
| [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) | [GetFleetTravelTimeToPoint](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_party_transition_model.html#ad1338af6925a1219a9ea858d7463b869) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) owner, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) target) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_transition_model.html#a7f364ed01bbc659bc88c6abe62ff64d4)GetFleetTravelTimeToPoint()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyTransitionModel.GetFleetTravelTimeToPoint | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty*, |
|  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *target* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_transition_model.html#a9722e937f03be42cd80bff07d7a99060)GetTransitionTimeDisembarking()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyTransitionModel.GetTransitionTimeDisembarking | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_party_transition_model.html#a34991b8afc6fa381f875f8defa082fe6)GetTransitionTimeForEmbarking()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [CampaignTime](struct_tale_worlds_1_1_campaign_system_1_1_campaign_time.html) TaleWorlds.CampaignSystem.GameComponents.DefaultPartyTransitionModel.GetTransitionTimeForEmbarking | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *mobileParty* | ) |  |

