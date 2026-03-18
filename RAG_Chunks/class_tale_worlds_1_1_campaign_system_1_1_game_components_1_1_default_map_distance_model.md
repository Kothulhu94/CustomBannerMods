--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html ---

TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel Class ReferenceInherits [TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DefaultMapDistanceModel](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#ac813e1a4cf3e9f8a980e7ea9d2edc052) () |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) void | [RegisterDistanceCache](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#ae0bb545fdfef12d2b8daffd6578aa24e) (MobileParty.NavigationType navigationCapability, INavigationCache cacheToRegister) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [GetMaximumDistanceBetweenTwoConnectedSettlements](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a5ec2b7d6a5d91355992a732cf753e476) (MobileParty.NavigationType navigationCapabilities) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [GetLandRatioOfPathBetweenSettlements](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a255a2f21d4972684516ae127aacee6a1) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) fromSettlement, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) toSettlement, bool isFromPort, bool isTargetingPort) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#ae9945db1c7f5188db5c398fa2612bac5) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) fromSettlement, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) toSettlement, bool isFromPort=false, bool isTargetingPort=false, MobileParty.NavigationType navigationCapability=MobileParty.NavigationType.Default) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#abfc8ab76e95ae2d72aed00e61937dba9) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) fromSettlement, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) toSettlement, bool isFromPort, bool isTargetingPort, MobileParty.NavigationType navigationCapability, out float landRatio) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a39649d2fe0f01b53575133a9d1e93f2f) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) fromMobileParty, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) toSettlement, bool isTargetingPort, MobileParty.NavigationType customCapability, out float estimatedLandRatio) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a730acb1e976386559dae23ca67481ac3) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) fromMobileParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) toMobileParty, MobileParty.NavigationType customCapability, out float landRatio) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) bool | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#ae04b3202a95c55477196aa48762f1083) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) fromMobileParty, [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) toMobileParty, MobileParty.NavigationType customCapability, float maxDistance, out float distance, out float landRatio) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a1af518484b1247fe590ab8ac14ca3dba) ([MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) fromMobileParty, in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) toPoint, MobileParty.NavigationType customCapability, out float landRatio) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [GetDistance](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0495bb36455813b02f75d12b875404c1) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) fromSettlement, in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) toPoint, bool isFromPort, MobileParty.NavigationType customCapability) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [GetPortToGateDistanceForSettlement](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a124d85e4c3736f70e7dab452479686a6) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) settlement) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) bool | [PathExistBetweenPoints](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#aeed171472de6b97d8ccc7e8a6fa22e14) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) fromPoint, in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) toPoint, MobileParty.NavigationType navigationType) |
|  | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725), bool) [GetClosestEntranceToFace](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a18ad4b9542b8b6387b7d3358ba095af9)([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) face |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) > | [GetNeighborsOfFortification](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a66da2f17f8721a31cebbe540820e4466) ([Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) town, MobileParty.NavigationType navigationCapabilities) |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [GetTransitionCostAdjustment](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#aeef425f642a4cd22175fe57a826e0641) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) settlement1, bool isFromPort, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) settlement2, bool isTargetingPort, bool fromIsCurrentlyAtSea, bool toIsCurrentlyAtSea) |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html) | |
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
| Properties | |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) int | [RegionSwitchCostFromLandToSea](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#aca23c77d67a422f028fb51bb6dc31bd5) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) int | [RegionSwitchCostFromSeaToLand](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a355a9d8a06d4072be3acbea8fbb2763d) `[get]` |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float | [MaximumSpawnDistanceForCompanionsAfterDisband](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#ae12816b7577be3c2d5292fcdb7bb3179) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html) | |
| int | [RegionSwitchCostFromLandToSea](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a36e3d2987321569432ce45261a0333cc) `[get]` |
| int | [RegionSwitchCostFromSeaToLand](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a788e83be5b29f74fe31e949939d6ef5e) `[get]` |
| float | [MaximumSpawnDistanceForCompanionsAfterDisband](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#acb6273fda6c9e2ec82554146580ca49b) `[get]` |
| Properties inherited from [TaleWorlds.Core.MBGameModel< T >](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html) | |
| T | [BaseModel](class_tale_worlds_1_1_core_1_1_m_b_game_model-1-g.html#ac05c0aa978adaec9efd3b7dba92ae721) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html) | |
|  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) |
| Static Public Attributes inherited from [TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html) | |
| const float | [PossibleMaximumMapBoundary](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a714d5282962eb5d08d110dfe7d91495d) = 100000000 |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#ac813e1a4cf3e9f8a980e7ea9d2edc052)DefaultMapDistanceModel()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.DefaultMapDistanceModel | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#ae0bb545fdfef12d2b8daffd6578aa24e)RegisterDistanceCache()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) void TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.RegisterDistanceCache | ( | MobileParty.NavigationType | *navigationCapability*, |
|  |  | INavigationCache | *cacheToRegister* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a5ec2b7d6a5d91355992a732cf753e476)GetMaximumDistanceBetweenTwoConnectedSettlements()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetMaximumDistanceBetweenTwoConnectedSettlements | ( | MobileParty.NavigationType | *navigationCapabilities* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a255a2f21d4972684516ae127aacee6a1)GetLandRatioOfPathBetweenSettlements()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetLandRatioOfPathBetweenSettlements | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *fromSettlement*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *toSettlement*, |
|  |  | bool | *isFromPort*, |
|  |  | bool | *isTargetingPort* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#ae9945db1c7f5188db5c398fa2612bac5)GetDistance() [1/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetDistance | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *fromSettlement*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *toSettlement*, |
|  |  | bool | *isFromPort* = false, |
|  |  | bool | *isTargetingPort* = false, |
|  |  | MobileParty.NavigationType | *navigationCapability* = MobileParty::NavigationType::Default ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#abfc8ab76e95ae2d72aed00e61937dba9)GetDistance() [2/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetDistance | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *fromSettlement*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *toSettlement*, |
|  |  | bool | *isFromPort*, |
|  |  | bool | *isTargetingPort*, |
|  |  | MobileParty.NavigationType | *navigationCapability*, |
|  |  | out float | *landRatio* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a39649d2fe0f01b53575133a9d1e93f2f)GetDistance() [3/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetDistance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *fromMobileParty*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *toSettlement*, |
|  |  | bool | *isTargetingPort*, |
|  |  | MobileParty.NavigationType | *customCapability*, |
|  |  | out float | *estimatedLandRatio* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a730acb1e976386559dae23ca67481ac3)GetDistance() [4/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetDistance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *fromMobileParty*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *toMobileParty*, |
|  |  | MobileParty.NavigationType | *customCapability*, |
|  |  | out float | *landRatio* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#ae04b3202a95c55477196aa48762f1083)GetDistance() [5/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) bool TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetDistance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *fromMobileParty*, |
|  |  | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *toMobileParty*, |
|  |  | MobileParty.NavigationType | *customCapability*, |
|  |  | float | *maxDistance*, |
|  |  | out float | *distance*, |
|  |  | out float | *landRatio* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a1af518484b1247fe590ab8ac14ca3dba)GetDistance() [6/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetDistance | ( | [MobileParty](class_tale_worlds_1_1_campaign_system_1_1_party_1_1_mobile_party.html) | *fromMobileParty*, |
|  |  | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *toPoint*, |
|  |  | MobileParty.NavigationType | *customCapability*, |
|  |  | out float | *landRatio* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0495bb36455813b02f75d12b875404c1)GetDistance() [7/7]
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetDistance | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *fromSettlement*, |
|  |  | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *toPoint*, |
|  |  | bool | *isFromPort*, |
|  |  | MobileParty.NavigationType | *customCapability* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a124d85e4c3736f70e7dab452479686a6)GetPortToGateDistanceForSettlement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetPortToGateDistanceForSettlement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#aeed171472de6b97d8ccc7e8a6fa22e14)PathExistBetweenPoints()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) bool TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.PathExistBetweenPoints | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *fromPoint*, |
|  |  | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *toPoint*, |
|  |  | MobileParty.NavigationType | *navigationType* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2)override()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.override | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | , |
|  |  | bool | ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a66da2f17f8721a31cebbe540820e4466)GetNeighborsOfFortification()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) > TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetNeighborsOfFortification | ( | [Town](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_town.html) | *town*, |
|  |  | MobileParty.NavigationType | *navigationCapabilities* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#aeef425f642a4cd22175fe57a826e0641)GetTransitionCostAdjustment()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.GetTransitionCostAdjustment | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *settlement1*, |
|  |  | bool | *isFromPort*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *settlement2*, |
|  |  | bool | *isTargetingPort*, |
|  |  | bool | *fromIsCurrentlyAtSea*, |
|  |  | bool | *toIsCurrentlyAtSea* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#aca23c77d67a422f028fb51bb6dc31bd5)RegionSwitchCostFromLandToSea
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) int TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.RegionSwitchCostFromLandToSea | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a355a9d8a06d4072be3acbea8fbb2763d)RegionSwitchCostFromSeaToLand
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) int TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.RegionSwitchCostFromSeaToLand | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#ae12816b7577be3c2d5292fcdb7bb3179)MaximumSpawnDistanceForCompanionsAfterDisband
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [override](class_tale_worlds_1_1_campaign_system_1_1_game_components_1_1_default_map_distance_model.html#a0ee84af234b1ee0c3c7a2780a7a0eff2) float TaleWorlds.CampaignSystem.GameComponents.DefaultMapDistanceModel.MaximumSpawnDistanceForCompanionsAfterDisband | | get |

