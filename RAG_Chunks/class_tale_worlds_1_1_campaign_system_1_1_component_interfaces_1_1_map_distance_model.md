--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel Class ReferenceabstractInherits [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html).

Inherited by [TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html).

|  |  |
| --- | --- |
| Classes | |
| interface | [INavigationCache](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetMaximumDistanceBetweenTwoConnectedSettlements](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a407e1bed641179ccfc3ce61e47dc0cde) (NavigationType navigationType) |
| float | [GetLandRatioOfPathBetweenSettlements](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ae497adfabaf3193d92ed67984d2c9901) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) fromSettlement, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) toSettlement, bool isFromPort, bool isTargetingPort) |
| float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#abf328d5c2e7ce3021a07de54f5c9d994) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) fromMobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) toSettlement, bool isTargetingPort, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) customCapability, out float estimatedLandRatio) |
| float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ade3abf5acf9fb19c95db68fb36bdec4c) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) fromMobileParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) toMobileParty, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) customCapability, out float landRatio) |
| bool | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a174e54978aa281cebc46f2e7b6b294a5) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) fromMobileParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) toMobileParty, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) customCapability, float maxDistance, out float distance, out float landRatio) |
| float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ae80c84ba14895b6910a63c25411811e7) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) fromSettlement, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) toSettlement, bool isFromPort, bool isTargetingPort, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationCapability) |
| float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#aeee6c3162691c01fe297c7ab611cb1f7) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) fromSettlement, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) toSettlement, bool isFromPort, bool isTargetingPort, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationCapability, out float landRatio) |
| float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ac69c61a03db8e07ea262902e1443c228) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) fromMobileParty, in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) toPoint, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType, out float landRatio) |
| float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a6182c5d619f03aee21eb90b992144d1c) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) fromSettlement, in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) toPoint, bool isFromPort, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
| float | [GetPortToGateDistanceForSettlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ad0464aa35f8a4e6513477d53a7dc99ec) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) settlement) |
| bool | [PathExistBetweenPoints](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#aab21e2d62436df67a4856ab93c38e243) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) fromPoint, in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) toPoint, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationType) |
| void | [RegisterDistanceCache](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5198b7c444bbb33e2cfd631a55cd9fda) ([MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationCapability, INavigationCache cacheToRegister) |
| bool | [GetClosestEntranceToFace](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a18ad4b9542b8b6387b7d3358ba095af9) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) face, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationCapabilities) |
| MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) > | [GetNeighborsOfFortification](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ab7cca21962659247e2d1eff504cd0183) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) navigationCapabilities) |
| float | [GetTransitionCostAdjustment](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a2831c2a6dac3970fd5a1f3736933c335) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) settlement1, bool isFromPort, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) settlement2, bool isTargetingPort, bool fromIsCurrentlyAtSea, bool toIsCurrentlyAtSea) |
| Public Member Functions inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| void | [Initialize](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#a2a1d8dfc874146b1aadd5e6aa2cbc630) (T baseModel) |

|  |  |
| --- | --- |
| Public Attributes | |
|  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [PossibleMaximumMapBoundary](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a714d5282962eb5d08d110dfe7d91495d) = 100000000 |

|  |  |
| --- | --- |
| Properties | |
| int | [RegionSwitchCostFromLandToSea](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a36e3d2987321569432ce45261a0333cc) `[get]` |
| int | [RegionSwitchCostFromSeaToLand](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a788e83be5b29f74fe31e949939d6ef5e) `[get]` |
| float | [MaximumSpawnDistanceForCompanionsAfterDisband](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#acb6273fda6c9e2ec82554146580ca49b) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a407e1bed641179ccfc3ce61e47dc0cde)GetMaximumDistanceBetweenTwoConnectedSettlements()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetMaximumDistanceBetweenTwoConnectedSettlements | ( | NavigationType | *navigationType* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ae497adfabaf3193d92ed67984d2c9901)GetLandRatioOfPathBetweenSettlements()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetLandRatioOfPathBetweenSettlements | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *fromSettlement*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *toSettlement*, | |  |  | bool | *isFromPort*, | |  |  | bool | *isTargetingPort* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#abf328d5c2e7ce3021a07de54f5c9d994)GetDistance() [1/7]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetDistance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *fromMobileParty*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *toSettlement*, | |  |  | bool | *isTargetingPort*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *customCapability*, | |  |  | out float | *estimatedLandRatio* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ade3abf5acf9fb19c95db68fb36bdec4c)GetDistance() [2/7]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetDistance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *fromMobileParty*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *toMobileParty*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *customCapability*, | |  |  | out float | *landRatio* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a174e54978aa281cebc46f2e7b6b294a5)GetDistance() [3/7]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetDistance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *fromMobileParty*, | |  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *toMobileParty*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *customCapability*, | |  |  | float | *maxDistance*, | |  |  | out float | *distance*, | |  |  | out float | *landRatio* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ae80c84ba14895b6910a63c25411811e7)GetDistance() [4/7]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetDistance | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *fromSettlement*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *toSettlement*, | |  |  | bool | *isFromPort*, | |  |  | bool | *isTargetingPort*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationCapability* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#aeee6c3162691c01fe297c7ab611cb1f7)GetDistance() [5/7]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetDistance | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *fromSettlement*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *toSettlement*, | |  |  | bool | *isFromPort*, | |  |  | bool | *isTargetingPort*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationCapability*, | |  |  | out float | *landRatio* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ac69c61a03db8e07ea262902e1443c228)GetDistance() [6/7]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetDistance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *fromMobileParty*, | |  |  | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *toPoint*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType*, | |  |  | out float | *landRatio* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a6182c5d619f03aee21eb90b992144d1c)GetDistance() [7/7]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetDistance | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *fromSettlement*, | |  |  | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *toPoint*, | |  |  | bool | *isFromPort*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ad0464aa35f8a4e6513477d53a7dc99ec)GetPortToGateDistanceForSettlement()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetPortToGateDistanceForSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *settlement* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#aab21e2d62436df67a4856ab93c38e243)PathExistBetweenPoints()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.PathExistBetweenPoints | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *fromPoint*, | |  |  | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *toPoint*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationType* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5198b7c444bbb33e2cfd631a55cd9fda)RegisterDistanceCache()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.RegisterDistanceCache | ( | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationCapability*, | |  |  | INavigationCache | *cacheToRegister* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a18ad4b9542b8b6387b7d3358ba095af9)GetClosestEntranceToFace()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetClosestEntranceToFace | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *face*, |
|  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationCapabilities* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#ab7cca21962659247e2d1eff504cd0183)GetNeighborsOfFortification()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) > TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetNeighborsOfFortification | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, | |  |  | [MobileParty.NavigationType](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html#ab1d10d3f7abe295880dda3ddc6051848) | *navigationCapabilities* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a2831c2a6dac3970fd5a1f3736933c335)GetTransitionCostAdjustment()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.GetTransitionCostAdjustment | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *settlement1*, | |  |  | bool | *isFromPort*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *settlement2*, | |  |  | bool | *isTargetingPort*, | |  |  | bool | *fromIsCurrentlyAtSea*, | |  |  | bool | *toIsCurrentlyAtSea* ) | | abstract |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a714d5282962eb5d08d110dfe7d91495d)PossibleMaximumMapBoundary
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.PossibleMaximumMapBoundary = 100000000 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725)Settlement
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.Settlement | | abstract |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a36e3d2987321569432ce45261a0333cc)RegionSwitchCostFromLandToSea
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.RegionSwitchCostFromLandToSea | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a788e83be5b29f74fe31e949939d6ef5e)RegionSwitchCostFromSeaToLand
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.RegionSwitchCostFromSeaToLand | | getabstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#acb6273fda6c9e2ec82554146580ca49b)MaximumSpawnDistanceForCompanionsAfterDisband
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.MaximumSpawnDistanceForCompanionsAfterDisband | | getabstract |

