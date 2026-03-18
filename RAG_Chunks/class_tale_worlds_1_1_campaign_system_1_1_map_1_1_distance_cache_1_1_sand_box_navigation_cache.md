--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html ---

TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache Class ReferenceInherits [TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html), and INavigationCache.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SandBoxNavigationCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a905bcc4c058c2bc239cd10296824ed69) (NavigationType navigationType) |
| override void | [GetSceneXmlCrcValues](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#ac2fd18a45ed3d5400b918832c57f2270) (out uint sceneXmlCrc, out uint sceneNavigationMeshCrc) |
| void | [FinalizeInitialization](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#aa6cb0b6978e9c6b7ff24fe178f7787f1) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html) | |
| MBReadOnlyList< T > | [GetNeighbors](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a8529ace4c7bf38e4f921a27a6b3ce88e) (T settlement) |
| T | [GetClosestSettlementToFaceIndex](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ab120a02f4d7bb69958d6332437a11657) (int faceId, out bool isAtSea) |
| void | [GenerateCacheData](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ad1a525ba13575ad3a6547d23e71b691f) () |
| void | [GetSceneXmlCrcValues](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ac40ab4ba616f73e8aad0bac794fd9ab8) (out uint sceneXmlCrc, out uint sceneNavigationMeshCrc) |
| bool | [GetSettlementsDistanceCacheFileForCapability](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ae2ea06f56ca0d689738e80a3e7a85931) (string moduleId, out string filePath) |
| void | [Serialize](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#af06200f087e8e4be85dc87a9a1600589) (string path) |
| void | [Deserialize](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a868e57735607c623b5055a949e753826) (string path) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [GetCacheElement](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#ad74be83335f29f23caf38035ce1c501b) (string settlementId) |
| override NavigationCacheElement< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [GetCacheElement](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#aa04459f3abe556c0cefb70edb39e2de2) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, bool isPortUsed) |
| override int | [GetNavMeshFaceCount](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a3b86624b04cfbc3df849bc9b0f5ffeb8) () |
| override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetNavMeshFaceCenterPosition](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a4f9661cdac28a4b8327e1d6bfb2a2162) (int faceIndex) |
| override [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [GetFaceRecordAtIndex](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a34a890edb05523d2a9ecdcff7f5f6005) (int faceIndex) |
| override int | [GetRegionSwitchCostTo0](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#ae23ee1629d027924dd8318f4d96d92ee) () |
| override int | [GetRegionSwitchCostTo1](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a5c37dbafb25883cc417daee87c1f69a2) () |
| override int[] | [GetExcludedFaceIds](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#ae32ab0647bc3316d97a2a70f8c3acf92) () |
| override float | [GetRealDistanceAndLandRatioBetweenSettlements](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a36d39dd33c3ec83397daf824b1adb653) (NavigationCacheElement< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > settlement1, NavigationCacheElement< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > settlement2, out float landRatio) |
| override void | [GetFaceRecordForPoint](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#aea50d3963a73d693e0c36d22084dc79c) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, out bool isOnRegion1) |
| override bool | [CheckBeingNeighbor](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#aa6f1bf87018ec59cd44ccf6e618c3697) (List< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > settlementsToConsider, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement1, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement2, bool useGate1, bool useGate2, out float distance) |
| override float | [GetRealPathDistanceFromPositionToSettlement](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#ad410a2dc9c83a7eb2465b0895c3ff5a5) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) checkPosition, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) currentFaceRecord, float maxDistanceToLookForPathDetection, [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) currentSettlementToLook, out bool isPort) |
| override IEnumerable< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [GetClosestSettlementsToPositionInCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a9085aa2442ccb46dc94633b9cd8c18de) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) checkPosition, List< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > settlements) |
| override List< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | [GetAllRegisteredSettlements](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a9a31179bd4e926f51d9c35dfa5052b63) () |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html) | |
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
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html) | |
| static void | [CopyTo< T1 >](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#accdee35d9e32fcb7b1f3b6a6764f5dc0) ([NavigationCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5089b9f8d62e43b4ad10a25d94b20755)< T1 > source, [NavigationCache](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a5089b9f8d62e43b4ad10a25d94b20755)< T > target) |
| Static Protected Attributes inherited from [TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html) | |
| const float | [AgentRadius](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#af0dea1b3a13451a922205f428e8cd6c3) = 0.3f |
| const float | [ExtraCostMultiplierForNeighborDetection](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#ae97194da7d161b45c4cdfd9718b67fa6) = 2.0f |
| Properties inherited from [TaleWorlds.CampaignSystem.Map.DistanceCache.NavigationCache< T >](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html) | |
| float | [MaximumDistanceBetweenTwoConnectedSettlements](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#a8b6fc7c5ba1fb9438377505c1faaa85c) `[get, protected set]` |
| NavigationType | [\_navigationType](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_navigation_cache-1-g.html#afa5e773fc971ef4d2d69f96b09242a37) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a905bcc4c058c2bc239cd10296824ed69)SandBoxNavigationCache()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.SandBoxNavigationCache | ( | NavigationType | *navigationType* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#ad74be83335f29f23caf38035ce1c501b)GetCacheElement() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetCacheElement | ( | string | *settlementId* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#aa04459f3abe556c0cefb70edb39e2de2)GetCacheElement() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override NavigationCacheElement< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetCacheElement | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, | |  |  | bool | *isPortUsed* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#ac2fd18a45ed3d5400b918832c57f2270)GetSceneXmlCrcValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetSceneXmlCrcValues | ( | out uint | *sceneXmlCrc*, |
|  |  | out uint | *sceneNavigationMeshCrc* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a3b86624b04cfbc3df849bc9b0f5ffeb8)GetNavMeshFaceCount()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetNavMeshFaceCount | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a4f9661cdac28a4b8327e1d6bfb2a2162)GetNavMeshFaceCenterPosition()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetNavMeshFaceCenterPosition | ( | int | *faceIndex* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a34a890edb05523d2a9ecdcff7f5f6005)GetFaceRecordAtIndex()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetFaceRecordAtIndex | ( | int | *faceIndex* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#ae23ee1629d027924dd8318f4d96d92ee)GetRegionSwitchCostTo0()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetRegionSwitchCostTo0 | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a5c37dbafb25883cc417daee87c1f69a2)GetRegionSwitchCostTo1()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override int TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetRegionSwitchCostTo1 | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#ae32ab0647bc3316d97a2a70f8c3acf92)GetExcludedFaceIds()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override int[] TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetExcludedFaceIds | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a36d39dd33c3ec83397daf824b1adb653)GetRealDistanceAndLandRatioBetweenSettlements()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override float TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetRealDistanceAndLandRatioBetweenSettlements | ( | NavigationCacheElement< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | *settlement1*, | |  |  | NavigationCacheElement< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | *settlement2*, | |  |  | out float | *landRatio* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#aea50d3963a73d693e0c36d22084dc79c)GetFaceRecordForPoint()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetFaceRecordForPoint | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, | |  |  | out bool | *isOnRegion1* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#aa6f1bf87018ec59cd44ccf6e618c3697)CheckBeingNeighbor()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override bool TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.CheckBeingNeighbor | ( | List< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | *settlementsToConsider*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement1*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement2*, | |  |  | bool | *useGate1*, | |  |  | bool | *useGate2*, | |  |  | out float | *distance* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#ad410a2dc9c83a7eb2465b0895c3ff5a5)GetRealPathDistanceFromPositionToSettlement()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override float TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetRealPathDistanceFromPositionToSettlement | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *checkPosition*, | |  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *currentFaceRecord*, | |  |  | float | *maxDistanceToLookForPathDetection*, | |  |  | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *currentSettlementToLook*, | |  |  | out bool | *isPort* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a9085aa2442ccb46dc94633b9cd8c18de)GetClosestSettlementsToPositionInCache()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | override IEnumerable< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetClosestSettlementsToPositionInCache | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *checkPosition*, | |  |  | List< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > | *settlements* ) | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#a9a31179bd4e926f51d9c35dfa5052b63)GetAllRegisteredSettlements()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override List< [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) > TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.GetAllRegisteredSettlements | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_map_1_1_distance_cache_1_1_sand_box_navigation_cache.html#aa6cb0b6978e9c6b7ff24fe178f7787f1)FinalizeInitialization()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.DistanceCache.SandBoxNavigationCache.FinalizeInitialization | ( |  | ) |  |

