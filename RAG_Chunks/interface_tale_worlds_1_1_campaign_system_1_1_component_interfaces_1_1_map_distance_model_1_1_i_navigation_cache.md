--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html ---

TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.INavigationCache Interface Reference|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetSettlementToSettlementDistanceWithLandRatio](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html#a80c8c150bb13da94f04fbc7bbeae1a44) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) settlement1, bool isAtSea1, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) settlement2, bool isAtSea2, out float landRatio) |
| MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) > | [GetNeighbors](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html#a597af7d6f6835a679ff54bfb90aad11d) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) settlement) |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | [GetClosestSettlementToFaceIndex](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html#ad14703bf208044eb7ed5bd129387a88a) (int faceId, out bool isAtSea) |
| void | [FinalizeInitialization](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html#a2300a227812be1c5ab8d63353f15919f) () |

|  |  |
| --- | --- |
| Properties | |
| float | [MaximumDistanceBetweenTwoConnectedSettlements](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html#a348b7868ceb6b18d9c5f137b17f235f3) `[get]` |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html#a80c8c150bb13da94f04fbc7bbeae1a44)GetSettlementToSettlementDistanceWithLandRatio()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.INavigationCache.GetSettlementToSettlementDistanceWithLandRatio | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *settlement1*, |
|  |  | bool | *isAtSea1*, |
|  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *settlement2*, |
|  |  | bool | *isAtSea2*, |
|  |  | out float | *landRatio* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html#a597af7d6f6835a679ff54bfb90aad11d)GetNeighbors()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBReadOnlyList< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) > TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.INavigationCache.GetNeighbors | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) | *settlement* | ) |  |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html#ad14703bf208044eb7ed5bd129387a88a)GetClosestSettlementToFaceIndex()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Settlement](class_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model.html#a5f40a93167125895f5a0e99787634725) TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.INavigationCache.GetClosestSettlementToFaceIndex | ( | int | *faceId*, |
|  |  | out bool | *isAtSea* ) |

[◆](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html#a2300a227812be1c5ab8d63353f15919f)FinalizeInitialization()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.INavigationCache.FinalizeInitialization | ( |  | ) |  |

Property Documentation
----------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_component_interfaces_1_1_map_distance_model_1_1_i_navigation_cache.html#a348b7868ceb6b18d9c5f137b17f235f3)MaximumDistanceBetweenTwoConnectedSettlements
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.ComponentInterfaces.MapDistanceModel.INavigationCache.MaximumDistanceBetweenTwoConnectedSettlements | | get |

