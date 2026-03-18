--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html ---

TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T > Class Template ReferenceabstractInherited by [TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| MBReadOnlyList< T > | [GetNeighbors](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a8529ace4c7bf38e4f921a27a6b3ce88e) (T settlement) |
| T | [GetClosestSettlementToFaceIndex](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ab120a02f4d7bb69958d6332437a11657) (int faceId, out bool isAtSea) |
| void | [GenerateCacheData](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ad1a525ba13575ad3a6547d23e71b691f) () |
| void | [GetSceneXmlCrcValues](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ac40ab4ba616f73e8aad0bac794fd9ab8) (out uint sceneXmlCrc, out uint sceneNavigationMeshCrc) |
| bool | [GetSettlementsDistanceCacheFileForCapability](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ae2ea06f56ca0d689738e80a3e7a85931) (string moduleId, out string filePath) |
| void | [Serialize](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#af06200f087e8e4be85dc87a9a1600589) (string path) |
| void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a868e57735607c623b5055a949e753826) (string path) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [CopyTo< T1 >](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#accdee35d9e32fcb7b1f3b6a6764f5dc0) ([NavigationCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5089b9f8d62e43b4ad10a25d94b20755)< T1 > source, [NavigationCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5089b9f8d62e43b4ad10a25d94b20755)< T > target) |

|  |  |
| --- | --- |
| Protected Member Functions | |
|  | [NavigationCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5089b9f8d62e43b4ad10a25d94b20755) (NavigationType navigationType) |
| void | [FinalizeCacheInitialization](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5ae87c7c4ed890c7cbed9853541c221a) () |
| float | [GetSettlementToSettlementDistanceWithLandRatio](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#aa009b36afd28c570feb5923fd25f840e) (NavigationCacheElement< T > settlement1, NavigationCacheElement< T > settlement2, out float landRatio) |
| void | [SetSettlementToSettlementDistanceWithLandRatio](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5a2eb01ec42203aae711762b632a9f15) (NavigationCacheElement< T > settlement1, NavigationCacheElement< T > settlement2, float distance, float landRatio) |
| void | [AddNeighbor](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#afe8a658c8b19605a01e17a298b9e7e5f) (T settlement1, T settlement2) |
| void | [SetClosestSettlementToFaceIndex](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a2ea2671178cd747c0bc762c16bd83ed1) (int faceId, NavigationCacheElement< T > settlement) |
| float | [GetRealDistanceAndLandRatioBetweenSettlements](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a9716da90d028b07c48e280602d47209a) (NavigationCacheElement< T > settlement1, NavigationCacheElement< T > settlement2, out float landRatio) |
| T | [GetCacheElement](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a0dd0301cc8be2b077cb1e8a61070fd29) (string settlementId) |
| NavigationCacheElement< T > | [GetCacheElement](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a792491c545512a6e1486a1a493c42cb0) (T settlement, bool isPortUsed) |
| float | [GetLandRatioOfPath](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ab644861ca064b7a69d25db0d1979cb82) ([NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) path, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) startPosition) |
| void | [GetFaceRecordForPoint](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ad3a1894a421d466723f59b00a759340f) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, out bool isOnRegion1) |
| void | [GenerateClosestSettlementToFaceCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ad3bc141abb6b994a8a3fae110310424e) () |
| int | [GetNavMeshFaceCount](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a198401395cfaf3de75ad49a2b90b0348) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetNavMeshFaceCenterPosition](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a9ddd897743931a618ab7dfe2008f6894) (int faceIndex) |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [GetFaceRecordAtIndex](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a566acbb1a4164e8701537e61c3e8ef6e) (int faceIndex) |
| int[] | [GetExcludedFaceIds](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5809de804bd22b39198e67e73212dc57) () |
| int | [GetRegionSwitchCostTo0](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a92989d95e4e23cddf9c72f74b7ca5234) () |
| int | [GetRegionSwitchCostTo1](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a082eb4bc34241f86b470dd49cf80714f) () |
| void | [GenerateSettlementToSettlementDistanceCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#add1de4409c8607b25c12af01e6961fb3) () |
| void | [GenerateNeighborSettlementsCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a608bc3d5af4bac373803a34e0490b67b) () |
| bool | [CheckBeingNeighbor](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a8bc173ed02a8c6a8c379766741fac766) (List< T > settlementsToConsider, T settlement1, T settlement2) |
| List< T > | [GetAllRegisteredSettlements](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#aee0a993e50cbdc1d7246eb6c4898d9bd) () |
| List< T > | [GetUpdatedSettlementsForNeighborDetection](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ab6432bcaeb5eb7603bae2f07d83f45d6) (List< T > settlements) |
| bool | [CheckBeingNeighbor](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ac0956893dda58707da3241b8935e83ea) (List< T > settlementsToConsider, T settlement1, T settlement2, bool useGate1, bool useGate2, out float foundDistance) |
| float | [GetRealPathDistanceFromPositionToSettlement](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#afc79ab90900ad662869f3e5384506f15) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) checkPosition, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) currentFaceRecord, float maxDistanceToLookForPathDetection, T currentSettlementToLook, out bool isPort) |
| T | [GetClosestSettlementToPosition](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#aeae33658ba7080c2e41287d8d6e0f983) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) checkPosition, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) currentFaceRecord, int[] excludedFaceIds, List< T > settlementRecords, int regionSwitchCostTo0, int regionSwitchCostTo1, float minPathScoreEverFound, out bool isPort) |
| IEnumerable< T > | [GetClosestSettlementsToPositionInCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a1a2554d27b5305a394974651514b505b) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) checkPosition, List< T > settlements) |

|  |  |
| --- | --- |
| Static Protected Attributes | |
| const float | [AgentRadius](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#af0dea1b3a13451a922205f428e8cd6c3) = 0.3f |
| const float | [ExtraCostMultiplierForNeighborDetection](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ae97194da7d161b45c4cdfd9718b67fa6) = 2.0f |

|  |  |
| --- | --- |
| Properties | |
| float | [MaximumDistanceBetweenTwoConnectedSettlements](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a8b6fc7c5ba1fb9438377505c1faaa85c) `[get, protected set]` |
| NavigationType | [\_navigationType](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#afa5e773fc971ef4d2d69f96b09242a37) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5089b9f8d62e43b4ad10a25d94b20755)NavigationCache()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.NavigationCache | ( | NavigationType | *navigationType* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5ae87c7c4ed890c7cbed9853541c221a)FinalizeCacheInitialization()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.FinalizeCacheInitialization | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#accdee35d9e32fcb7b1f3b6a6764f5dc0)CopyTo< T1 >()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.CopyTo< T1 > | ( | [NavigationCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5089b9f8d62e43b4ad10a25d94b20755)< T1 > | *source*, | |  |  | [NavigationCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5089b9f8d62e43b4ad10a25d94b20755)< T > | *target* ) | | static |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T1* | : | *[ISettlementDataHolder](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_i_settlement_data_holder.html)* |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a8529ace4c7bf38e4f921a27a6b3ce88e)GetNeighbors()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| MBReadOnlyList< T > TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetNeighbors | ( | T | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ab120a02f4d7bb69958d6332437a11657)GetClosestSettlementToFaceIndex()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| T TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetClosestSettlementToFaceIndex | ( | int | *faceId*, |
|  |  | out bool | *isAtSea* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ad1a525ba13575ad3a6547d23e71b691f)GenerateCacheData()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GenerateCacheData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#aa009b36afd28c570feb5923fd25f840e)GetSettlementToSettlementDistanceWithLandRatio()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetSettlementToSettlementDistanceWithLandRatio | ( | NavigationCacheElement< T > | *settlement1*, | |  |  | NavigationCacheElement< T > | *settlement2*, | |  |  | out float | *landRatio* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5a2eb01ec42203aae711762b632a9f15)SetSettlementToSettlementDistanceWithLandRatio()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.SetSettlementToSettlementDistanceWithLandRatio | ( | NavigationCacheElement< T > | *settlement1*, | |  |  | NavigationCacheElement< T > | *settlement2*, | |  |  | float | *distance*, | |  |  | float | *landRatio* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#afe8a658c8b19605a01e17a298b9e7e5f)AddNeighbor()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.AddNeighbor | ( | T | *settlement1*, | |  |  | T | *settlement2* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a2ea2671178cd747c0bc762c16bd83ed1)SetClosestSettlementToFaceIndex()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.SetClosestSettlementToFaceIndex | ( | int | *faceId*, | |  |  | NavigationCacheElement< T > | *settlement* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a9716da90d028b07c48e280602d47209a)GetRealDistanceAndLandRatioBetweenSettlements()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetRealDistanceAndLandRatioBetweenSettlements | ( | NavigationCacheElement< T > | *settlement1*, | |  |  | NavigationCacheElement< T > | *settlement2*, | |  |  | out float | *landRatio* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a0dd0301cc8be2b077cb1e8a61070fd29)GetCacheElement() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | T TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetCacheElement | ( | string | *settlementId* | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a792491c545512a6e1486a1a493c42cb0)GetCacheElement() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | NavigationCacheElement< T > TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetCacheElement | ( | T | *settlement*, | |  |  | bool | *isPortUsed* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ab644861ca064b7a69d25db0d1979cb82)GetLandRatioOfPath()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetLandRatioOfPath | ( | [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) | *path*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *startPosition* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ad3a1894a421d466723f59b00a759340f)GetFaceRecordForPoint()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetFaceRecordForPoint | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, | |  |  | out bool | *isOnRegion1* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ad3bc141abb6b994a8a3fae110310424e)GenerateClosestSettlementToFaceCache()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GenerateClosestSettlementToFaceCache | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a198401395cfaf3de75ad49a2b90b0348)GetNavMeshFaceCount()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetNavMeshFaceCount | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a9ddd897743931a618ab7dfe2008f6894)GetNavMeshFaceCenterPosition()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetNavMeshFaceCenterPosition | ( | int | *faceIndex* | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a566acbb1a4164e8701537e61c3e8ef6e)GetFaceRecordAtIndex()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetFaceRecordAtIndex | ( | int | *faceIndex* | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5809de804bd22b39198e67e73212dc57)GetExcludedFaceIds()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int[] TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetExcludedFaceIds | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a92989d95e4e23cddf9c72f74b7ca5234)GetRegionSwitchCostTo0()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetRegionSwitchCostTo0 | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a082eb4bc34241f86b470dd49cf80714f)GetRegionSwitchCostTo1()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetRegionSwitchCostTo1 | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#add1de4409c8607b25c12af01e6961fb3)GenerateSettlementToSettlementDistanceCache()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GenerateSettlementToSettlementDistanceCache | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a608bc3d5af4bac373803a34e0490b67b)GenerateNeighborSettlementsCache()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GenerateNeighborSettlementsCache | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a8bc173ed02a8c6a8c379766741fac766)CheckBeingNeighbor() [1/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.CheckBeingNeighbor | ( | List< T > | *settlementsToConsider*, | |  |  | T | *settlement1*, | |  |  | T | *settlement2* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#aee0a993e50cbdc1d7246eb6c4898d9bd)GetAllRegisteredSettlements()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | List< T > TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetAllRegisteredSettlements | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ab6432bcaeb5eb7603bae2f07d83f45d6)GetUpdatedSettlementsForNeighborDetection()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | List< T > TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetUpdatedSettlementsForNeighborDetection | ( | List< T > | *settlements* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ac0956893dda58707da3241b8935e83ea)CheckBeingNeighbor() [2/2]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.CheckBeingNeighbor | ( | List< T > | *settlementsToConsider*, | |  |  | T | *settlement1*, | |  |  | T | *settlement2*, | |  |  | bool | *useGate1*, | |  |  | bool | *useGate2*, | |  |  | out float | *foundDistance* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#afc79ab90900ad662869f3e5384506f15)GetRealPathDistanceFromPositionToSettlement()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetRealPathDistanceFromPositionToSettlement | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *checkPosition*, | |  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *currentFaceRecord*, | |  |  | float | *maxDistanceToLookForPathDetection*, | |  |  | T | *currentSettlementToLook*, | |  |  | out bool | *isPort* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#aeae33658ba7080c2e41287d8d6e0f983)GetClosestSettlementToPosition()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | T TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetClosestSettlementToPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *checkPosition*, | |  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *currentFaceRecord*, | |  |  | int[] | *excludedFaceIds*, | |  |  | List< T > | *settlementRecords*, | |  |  | int | *regionSwitchCostTo0*, | |  |  | int | *regionSwitchCostTo1*, | |  |  | float | *minPathScoreEverFound*, | |  |  | out bool | *isPort* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a1a2554d27b5305a394974651514b505b)GetClosestSettlementsToPositionInCache()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< T > TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetClosestSettlementsToPositionInCache | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *checkPosition*, | |  |  | List< T > | *settlements* ) | | abstractprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ac40ab4ba616f73e8aad0bac794fd9ab8)GetSceneXmlCrcValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetSceneXmlCrcValues | ( | out uint | *sceneXmlCrc*, | |  |  | out uint | *sceneNavigationMeshCrc* ) | | abstract |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ae2ea06f56ca0d689738e80a3e7a85931)GetSettlementsDistanceCacheFileForCapability()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.GetSettlementsDistanceCacheFileForCapability | ( | string | *moduleId*, |
|  |  | out string | *filePath* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#af06200f087e8e4be85dc87a9a1600589)Serialize()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.Serialize | ( | string | *path* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a868e57735607c623b5055a949e753826)Deserialize()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.Deserialize | ( | string | *path* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#af0dea1b3a13451a922205f428e8cd6c3)AgentRadius
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.AgentRadius = 0.3f | | staticprotected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ae97194da7d161b45c4cdfd9718b67fa6)ExtraCostMultiplierForNeighborDetection
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.ExtraCostMultiplierForNeighborDetection = 2.0f | | staticprotected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a8b6fc7c5ba1fb9438377505c1faaa85c)MaximumDistanceBetweenTwoConnectedSettlements
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.MaximumDistanceBetweenTwoConnectedSettlements | | getprotected set |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#afa5e773fc971ef4d2d69f96b09242a37)\_navigationType
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | NavigationType TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >.\_navigationType | | getprotected |

