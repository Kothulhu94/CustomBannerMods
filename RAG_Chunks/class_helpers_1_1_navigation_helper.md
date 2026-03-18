--- SOURCE: class_helpers_1_1_navigation_helper.html ---

Helpers.NavigationHelper Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [EmbarkDisembarkData](class_helpers_1_1_navigation_helper_1_1_embark_disembark_data.html) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsPositionValidForNavigationType](class_helpers_1_1_navigation_helper.html#ab10c698fe8beaac76f61b9ebc865319e) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2, NavigationType navigationType) |
| static bool | [IsPositionValidForNavigationType](class_helpers_1_1_navigation_helper.html#a315b7413a4df455fa3eae10d85779bac) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) face, NavigationType navigationType) |
| static bool | [CanPlayerNavigateToPosition](class_helpers_1_1_navigation_helper.html#a5707a45c4f501354324a8778491a9efd) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2, out NavigationType navigationType) |
| static [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetClosestNavMeshFaceCenterPositionForPosition](class_helpers_1_1_navigation_helper.html#aa22427ea5e3696abfd2366ba18158ddd) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2, int[] excludedFaceIds) |
| static [EmbarkDisembarkData](class_helpers_1_1_navigation_helper_1_1_embark_disembark_data.html) | [GetEmbarkDisembarkDataForTick](class_helpers_1_1_navigation_helper.html#a8aaefec9fcb2f6a47263296f6e91161b) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
| static [EmbarkDisembarkData](class_helpers_1_1_navigation_helper_1_1_embark_disembark_data.html) | [GetEmbarkAndDisembarkDataForPlayer](class_helpers_1_1_navigation_helper.html#aea95fd1a18a0e03ff3e4c25292116798) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) moveTargetPointOfTheParty, bool isMoveTargetOnLand) |
| static [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [FindPointAroundPosition](class_helpers_1_1_navigation_helper.html#adbf6d71fe6906a9fd5467c6001ade70b) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) centerPosition, NavigationType navigationCapability, float maxDistance, float minDistance=0.0f, bool requirePath=true, bool useUniformDistribution=false) |
| static [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [FindReachablePointAroundPosition](class_helpers_1_1_navigation_helper.html#a88b0a3f2c3b7c03db978900aa61d1efd) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) center, int[] excludedFaceIds, float maxDistance, float minDistance=0.0f, bool useUniformDistribution=false) |
| static [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [FindReachablePointAroundPosition](class_helpers_1_1_navigation_helper.html#abfed62048818fb4af33dd4ec5cb89ad1) ([CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) center, NavigationType navigationCapability, float maxDistance, float minDistance=0.0f, bool useUniformDistribution=false) |
| static [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [FindPointInsideArea](class_helpers_1_1_navigation_helper.html#adecfbd63b7f1be5d65beb78b752b02a7) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) minBorder, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) maxBorder, NavigationType navigationCapability) |
| static bool | [IsPointInsideBorders](class_helpers_1_1_navigation_helper.html#a74db9ca274353c20ab75014679e0d7c9) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) minBorders, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) maxBorders) |
| static [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [FindPointInsideArea](class_helpers_1_1_navigation_helper.html#a7eeccefd7ef50176d896d8604fca32fe) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) minBorders, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) maxBorders, [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) center, NavigationType navigationCapability, float maxDistance, float minDistance=0f, bool requirePathFromCenter=false) |

Member Function Documentation
-----------------------------

[◆](class_helpers_1_1_navigation_helper.html#ab10c698fe8beaac76f61b9ebc865319e)IsPositionValidForNavigationType() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.NavigationHelper.IsPositionValidForNavigationType | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2*, | |  |  | NavigationType | *navigationType* ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#a315b7413a4df455fa3eae10d85779bac)IsPositionValidForNavigationType() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.NavigationHelper.IsPositionValidForNavigationType | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *face*, | |  |  | NavigationType | *navigationType* ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#a5707a45c4f501354324a8778491a9efd)CanPlayerNavigateToPosition()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.NavigationHelper.CanPlayerNavigateToPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2*, | |  |  | out NavigationType | *navigationType* ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#aa22427ea5e3696abfd2366ba18158ddd)GetClosestNavMeshFaceCenterPositionForPosition()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) Helpers.NavigationHelper.GetClosestNavMeshFaceCenterPositionForPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2*, | |  |  | int[] | *excludedFaceIds* ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#a8aaefec9fcb2f6a47263296f6e91161b)GetEmbarkDisembarkDataForTick()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [EmbarkDisembarkData](class_helpers_1_1_navigation_helper_1_1_embark_disembark_data.html) Helpers.NavigationHelper.GetEmbarkDisembarkDataForTick | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#aea95fd1a18a0e03ff3e4c25292116798)GetEmbarkAndDisembarkDataForPlayer()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [EmbarkDisembarkData](class_helpers_1_1_navigation_helper_1_1_embark_disembark_data.html) Helpers.NavigationHelper.GetEmbarkAndDisembarkDataForPlayer | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction*, | |  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *moveTargetPointOfTheParty*, | |  |  | bool | *isMoveTargetOnLand* ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#adbf6d71fe6906a9fd5467c6001ade70b)FindPointAroundPosition()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) Helpers.NavigationHelper.FindPointAroundPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *centerPosition*, | |  |  | NavigationType | *navigationCapability*, | |  |  | float | *maxDistance*, | |  |  | float | *minDistance* = 0::0f, | |  |  | bool | *requirePath* = true, | |  |  | bool | *useUniformDistribution* = false ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#a88b0a3f2c3b7c03db978900aa61d1efd)FindReachablePointAroundPosition() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) Helpers.NavigationHelper.FindReachablePointAroundPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *center*, | |  |  | int[] | *excludedFaceIds*, | |  |  | float | *maxDistance*, | |  |  | float | *minDistance* = 0::0f, | |  |  | bool | *useUniformDistribution* = false ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#abfed62048818fb4af33dd4ec5cb89ad1)FindReachablePointAroundPosition() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) Helpers.NavigationHelper.FindReachablePointAroundPosition | ( | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *center*, | |  |  | NavigationType | *navigationCapability*, | |  |  | float | *maxDistance*, | |  |  | float | *minDistance* = 0::0f, | |  |  | bool | *useUniformDistribution* = false ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#adecfbd63b7f1be5d65beb78b752b02a7)FindPointInsideArea() [1/2]
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) Helpers.NavigationHelper.FindPointInsideArea | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *minBorder*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *maxBorder*, | |  |  | NavigationType | *navigationCapability* ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#a74db9ca274353c20ab75014679e0d7c9)IsPointInsideBorders()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool Helpers.NavigationHelper.IsPointInsideBorders | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *minBorders*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *maxBorders* ) | | static |

[◆](class_helpers_1_1_navigation_helper.html#a7eeccefd7ef50176d896d8604fca32fe)FindPointInsideArea() [2/2]
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) Helpers.NavigationHelper.FindPointInsideArea | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *minBorders*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *maxBorders*, | |  |  | [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *center*, | |  |  | NavigationType | *navigationCapability*, | |  |  | float | *maxDistance*, | |  |  | float | *minDistance* = 0f, | |  |  | bool | *requirePathFromCenter* = false ) | | static |

