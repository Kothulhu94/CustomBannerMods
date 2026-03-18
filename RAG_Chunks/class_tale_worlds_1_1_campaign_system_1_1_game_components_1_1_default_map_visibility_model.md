--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultMapVisibilityModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.MapVisibilityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| override float | [MaximumSeeingRange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#add97e66cc15487aea13acbcbd5c4ce3f) () |
| override float | [GetPartySpottingRangeBase](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#ab06480bfb18f30653ae7ecb422ef940b) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetPartySpottingRange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#a5ef0470bb9c85ff86bbca9cca305c242) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool includeDescriptions=false) |
| override float | [GetPartyRelativeInspectionRange](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#aeda978b301c756a11821d0b81bbf0162) ([IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) party) |
| override float | [GetPartySpottingDifficulty](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#a1dc410e1f813021aca621cfd2a70335f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) spottingParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| override float | [GetHideoutSpottingDistance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#aaeed2c9ba2fce760f8a858614bfb51eb) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MapVisibilityModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html) | |
| float | [MaximumSeeingRange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#a2e0aa0747c0356e3181e222b237fefce) () |
| float | [GetPartySpottingRangeBase](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#a910d9845602cc43437170e40d956bd33) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) | [GetPartySpottingRange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#aef101277d537e74bb3a0ba69f73b64b4) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party, bool includeDescriptions=false) |
| float | [GetPartyRelativeInspectionRange](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#a079d34f8dc62aba88958a7f46612c166) ([IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) party) |
| float | [GetPartySpottingDifficulty](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#a51a335fee01846f18004d24feaf33b29) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) spotterParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) party) |
| float | [GetHideoutSpottingDistance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#a3a2881caa52c925a18f6330364e15ba6) () |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#add97e66cc15487aea13acbcbd5c4ce3f)MaximumSeeingRange()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapVisibilityModel.MaximumSeeingRange | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#ab06480bfb18f30653ae7ecb422ef940b)GetPartySpottingRangeBase()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapVisibilityModel.GetPartySpottingRangeBase | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#a5ef0470bb9c85ff86bbca9cca305c242)GetPartySpottingRange()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.GameComponents.DefaultMapVisibilityModel.GetPartySpottingRange | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, |
|  |  | bool | *includeDescriptions* = false ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#aeda978b301c756a11821d0b81bbf0162)GetPartyRelativeInspectionRange()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapVisibilityModel.GetPartyRelativeInspectionRange | ( | [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) | *party* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#a1dc410e1f813021aca621cfd2a70335f)GetPartySpottingDifficulty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapVisibilityModel.GetPartySpottingDifficulty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *spottingParty*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html#aaeed2c9ba2fce760f8a858614bfb51eb)GetHideoutSpottingDistance()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override float TaleWorlds.CampaignSystem.GameComponents.DefaultMapVisibilityModel.GetHideoutSpottingDistance | ( |  | ) |  |

