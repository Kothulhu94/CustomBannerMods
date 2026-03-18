--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.MapVisibilityModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultMapVisibilityModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_visibility_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#a2e0aa0747c0356e3181e222b237fefce)MaximumSeeingRange()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapVisibilityModel.MaximumSeeingRange | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#a910d9845602cc43437170e40d956bd33)GetPartySpottingRangeBase()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapVisibilityModel.GetPartySpottingRangeBase | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#aef101277d537e74bb3a0ba69f73b64b4)GetPartySpottingRange()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [ExplainedNumber](struct_tale_worlds_1_1_campaign_system_1_1_explained_number.html) TaleWorlds.CampaignSystem.ComponentInterfaces.MapVisibilityModel.GetPartySpottingRange | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party*, | |  |  | bool | *includeDescriptions* = false ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#a079d34f8dc62aba88958a7f46612c166)GetPartyRelativeInspectionRange()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapVisibilityModel.GetPartyRelativeInspectionRange | ( | [IMapPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_point.html) | *party* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#a51a335fee01846f18004d24feaf33b29)GetPartySpottingDifficulty()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapVisibilityModel.GetPartySpottingDifficulty | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *spotterParty*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *party* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_visibility_model.html#a3a2881caa52c925a18f6330364e15ba6)GetHideoutSpottingDistance()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapVisibilityModel.GetHideoutSpottingDistance | ( |  | ) |  | | abstract |

