--- SOURCE: interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html ---

TaleWorlds.CampaignSystem.Map.IMapScene Interface ReferenceInherited by [SandBox.MapScene](class_sand_box_1_1_map_scene.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Load](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a53dc69d8351115de483a8c4f9add9482) () |
| void | [AfterLoad](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a74ac6a99c113e714cff6f7c7bf11b400) () |
| void | [Destroy](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ad77d0af886e85fe9c2e13d08be2870fd) () |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [GetFaceIndex](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a63515d41c6b4ba10609f99f25c3f21b6) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2) |
| [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | [GetTerrainTypeAtPosition](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ab79cb03898767e4350f279ce740f330e) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2) |
| List< [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) > | [GetEnvironmentTerrainTypes](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#aa56913e998ffdb28719032cbb5590a4d) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2) |
| List< [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) > | [GetEnvironmentTerrainTypesCount](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a620fafa5c4975d2a4489a78426b95edf) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2, out [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) currentPositionTerrainType) |
| [MapPatchData](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_patch_data.html) | [GetMapPatchAtPosition](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a591c3af791d0c5564e838bf71c80eee0) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | [GetFaceTerrainType](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a6989fcb60fd469d465c0d5fdba5cc745) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) faceIndex) |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetNearestFaceCenterForPosition](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a03f17ce3740dbd2ccecfcdc820b62c93) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2, int[] excludedFaceIds) |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetNearestFaceCenterForPositionWithPath](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a0db6f5482a43730a0c6b820c6c29177e) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) pathFaceRecord, bool targetIsLand, float maxDist, int[] excludedFaceIds) |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetAccessiblePointNearPosition](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a65c0b3eaea41e7f4ca2147c83ea00114) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2, float radius) |
| bool | [GetPathBetweenAIFaces](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a97ddf2721ff09f6e25e50a66d78c39f5) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) startingFace, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) endingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) startingPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) endingPosition, float agentRadius, [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) path, int[] excludedFaceIds, float extraCostMultiplier, int regionSwitchCostFromLandToSea, int regionSwitchCostFromSeaToLand) |
|  | The path between pointA to pointB and pointB to pointA may differ but the path between pointA to pointB will always return same. |
| bool | [GetPathDistanceBetweenAIFaces](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ad545405636825438e307611686a609c7) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) startingAiFace, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) endingAiFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) startingPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) endingPosition, float agentRadius, float distanceLimit, out float distance, int[] excludedFaceIds, int regionSwitchCostFromLandToSea, int regionSwitchCostFromSeaToLand) |
|  | The distance between pointA to pointB and pointB to pointA may differ but distance between pointA to pointB will always return same. |
| bool | [IsLineToPointClear](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ac68a298fd594db5e9061fa616fbec9e2) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) startingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination, float agentRadius) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLastPointOnNavigationMeshFromPositionToDestination](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a7d88d9a3f1b92f4fbe0931676fbc16fb) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) startingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination, int[] excludedFaceIds=null) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLastPositionOnNavMeshFaceForPointAndDirection](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ac6108b392c30123e6807f7b830daaef3) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) startingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetNavigationMeshCenterPosition](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a473f32323db47acf327f86bd4cf98955) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) face) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetNavigationMeshCenterPosition](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a52b92a69fb6c9aa296f339099cddc295) (int faceIndex) |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [GetFaceAtIndex](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#add04b86d4459859b154f3d1fdcc59132) (int faceIndex) |
| int | [GetNumberOfNavigationMeshFaces](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a92de8ee927e01000fbefab26ff2196ef) () |
| bool | [GetHeightAtPoint](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a34fad1d3da4b78af966a7e8b250603e8) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) point, ref float height) |
| float | [GetWinterTimeFactor](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#acf2e57dfe7185769a4fff062af800aef) () |
| void | [GetTerrainHeightAndNormal](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a79b6d514a7cc8eb546246987acabea4b) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, out float height, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) normal) |
| float | [GetFaceVertexZ](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a4cfa6184f2b6216c53c5c0989ced9294) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) navMeshFace) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetGroundNormal](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#af1802c6c53ddab2d6b3a614f15eb153d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| void | [GetSiegeCampFrames](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a0ac4794732af23165dffdab8c433dd4e) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > siegeCamp1GlobalFrames, out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > siegeCamp2GlobalFrames) |
| string | [GetTerrainTypeName](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a7f0e3341bd33f715ffa7e79b315020e3) ([TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) type) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetTerrainSize](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#af675ec20fca6107f49fe61ed7edc15f4) () |
| uint | [GetSceneLevel](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#af04cd522722c7d5dfffe35a5985a6a90) (string name) |
| void | [SetSceneLevels](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a04bc196928a600b3f6dbfc5d8789c3c5) (List< string > levels) |
| List< [AtmosphereState](class_tale_worlds_1_1_core_1_1_atmosphere_state.html) > | [GetAtmosphereStates](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ad649d77f4d632afaaf619d12e03b7b80) () |
| void | [SetAtmosphereColorgrade](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a0aa965832f7e6d8f47b7b62ab3730d7c) ([TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) terrainType) |
| void | [AddNewEntityToMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a3d55ff8e170cae4f54a0f4a919f56a98) (string entityId, in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| void | [GetMapBorders](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#abd9181f09bfaa1eea17f236d8400b73e) (out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) minimumPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) maximumPosition, out float maximumHeight) |
| uint | [GetSceneXmlCrc](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a887e88672d10ebd804e66274fb3b1b87) () |
| uint | [GetSceneNavigationMeshCrc](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a80b30d813f014eac8a556e8812b4f6ad) () |
| float | [GetSnowAmountAtPosition](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a1cf3539d2b2a8901be5d160aab09d921) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| float | [GetRainAmountAtPosition](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a578bbc71e72871b30345dcd4affc12e8) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a53dc69d8351115de483a8c4f9add9482)Load()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.IMapScene.Load | ( |  | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a59372e4162666339a3df4fcdfd9aaae4).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a74ac6a99c113e714cff6f7c7bf11b400)AfterLoad()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.IMapScene.AfterLoad | ( |  | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#ae6ead8528dcc0644e442d23955202986).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ad77d0af886e85fe9c2e13d08be2870fd)Destroy()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.IMapScene.Destroy | ( |  | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a14b858a31fb73a43a1538b97409d348f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a63515d41c6b4ba10609f99f25c3f21b6)GetFaceIndex()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetFaceIndex | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a936596249ed29b4c0357a13df7366177).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ab79cb03898767e4350f279ce740f330e)GetTerrainTypeAtPosition()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) TaleWorlds.CampaignSystem.Map.IMapScene.GetTerrainTypeAtPosition | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#ab3fcef393603419228e9ea57cf5b379a).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#aa56913e998ffdb28719032cbb5590a4d)GetEnvironmentTerrainTypes()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) > TaleWorlds.CampaignSystem.Map.IMapScene.GetEnvironmentTerrainTypes | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#aad54ccd0622ee5a4c2040af072220770).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a620fafa5c4975d2a4489a78426b95edf)GetEnvironmentTerrainTypesCount()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) > TaleWorlds.CampaignSystem.Map.IMapScene.GetEnvironmentTerrainTypesCount | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2*, |
|  |  | out [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *currentPositionTerrainType* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a5ed146de68947a5d6cbf72f1cbb6d733).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a591c3af791d0c5564e838bf71c80eee0)GetMapPatchAtPosition()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MapPatchData](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_patch_data.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetMapPatchAtPosition | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a318a75adda67169591b70dd1d742b231).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a6989fcb60fd469d465c0d5fdba5cc745)GetFaceTerrainType()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) TaleWorlds.CampaignSystem.Map.IMapScene.GetFaceTerrainType | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *faceIndex* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a4d0ebd49540cc29717fc458093f28783).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a03f17ce3740dbd2ccecfcdc820b62c93)GetNearestFaceCenterForPosition()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetNearestFaceCenterForPosition | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2*, |
|  |  | int[] | *excludedFaceIds* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#aab2b8f4e2e6153667aa0cb9e9d8dc549).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a0db6f5482a43730a0c6b820c6c29177e)GetNearestFaceCenterForPositionWithPath()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetNearestFaceCenterForPositionWithPath | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *pathFaceRecord*, |
|  |  | bool | *targetIsLand*, |
|  |  | float | *maxDist*, |
|  |  | int[] | *excludedFaceIds* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a3b93facf2c520f816238862abbae7546).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a65c0b3eaea41e7f4ca2147c83ea00114)GetAccessiblePointNearPosition()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetAccessiblePointNearPosition | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2*, |
|  |  | float | *radius* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#aae9bc2045011d940c6f52b6af8a16795).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a97ddf2721ff09f6e25e50a66d78c39f5)GetPathBetweenAIFaces()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Map.IMapScene.GetPathBetweenAIFaces | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *startingFace*, |
|  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *endingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *startingPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *endingPosition*, |
|  |  | float | *agentRadius*, |
|  |  | [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) | *path*, |
|  |  | int[] | *excludedFaceIds*, |
|  |  | float | *extraCostMultiplier*, |
|  |  | int | *regionSwitchCostFromLandToSea*, |
|  |  | int | *regionSwitchCostFromSeaToLand* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a4b1c018e3623364cfe62eb8dc23201e5).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ad545405636825438e307611686a609c7)GetPathDistanceBetweenAIFaces()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Map.IMapScene.GetPathDistanceBetweenAIFaces | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *startingAiFace*, |
|  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *endingAiFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *startingPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *endingPosition*, |
|  |  | float | *agentRadius*, |
|  |  | float | *distanceLimit*, |
|  |  | out float | *distance*, |
|  |  | int[] | *excludedFaceIds*, |
|  |  | int | *regionSwitchCostFromLandToSea*, |
|  |  | int | *regionSwitchCostFromSeaToLand* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a65767aaeb15d18d82455ad52ca6e34ec).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ac68a298fd594db5e9061fa616fbec9e2)IsLineToPointClear()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Map.IMapScene.IsLineToPointClear | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *startingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination*, |
|  |  | float | *agentRadius* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#aa6ecdc70d2c962876895250940fb656b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a7d88d9a3f1b92f4fbe0931676fbc16fb)GetLastPointOnNavigationMeshFromPositionToDestination()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetLastPointOnNavigationMeshFromPositionToDestination | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *startingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination*, |
|  |  | int[] | *excludedFaceIds* = null ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#af1d1110669244fd887a9bcd109153f83).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ac6108b392c30123e6807f7b830daaef3)GetLastPositionOnNavMeshFaceForPointAndDirection()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetLastPositionOnNavMeshFaceForPointAndDirection | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *startingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a04f765cd659917afaae3e3d083abac71).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a473f32323db47acf327f86bd4cf98955)GetNavigationMeshCenterPosition() [1/2]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetNavigationMeshCenterPosition | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *face* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a64402ea930d90a6fe15518fc727024f5).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a52b92a69fb6c9aa296f339099cddc295)GetNavigationMeshCenterPosition() [2/2]
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetNavigationMeshCenterPosition | ( | int | *faceIndex* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a2f6cdf6b93b728a3c5ade54d2696ed83).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#add04b86d4459859b154f3d1fdcc59132)GetFaceAtIndex()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetFaceAtIndex | ( | int | *faceIndex* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#aadb3c034f24405e0ed222e6569db72e0).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a92de8ee927e01000fbefab26ff2196ef)GetNumberOfNavigationMeshFaces()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.CampaignSystem.Map.IMapScene.GetNumberOfNavigationMeshFaces | ( |  | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#afa103e83783cf4f7f54bd6430e952caa).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a34fad1d3da4b78af966a7e8b250603e8)GetHeightAtPoint()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.Map.IMapScene.GetHeightAtPoint | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *point*, |
|  |  | ref float | *height* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#aef72e3cce2306a031284663490d22e17).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#acf2e57dfe7185769a4fff062af800aef)GetWinterTimeFactor()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Map.IMapScene.GetWinterTimeFactor | ( |  | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a99669b4142020ae516c44973c34e5a49).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a79b6d514a7cc8eb546246987acabea4b)GetTerrainHeightAndNormal()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.IMapScene.GetTerrainHeightAndNormal | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | out float | *height*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *normal* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#af404750310621be2d9be3b21801a4e05).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a4cfa6184f2b6216c53c5c0989ced9294)GetFaceVertexZ()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Map.IMapScene.GetFaceVertexZ | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *navMeshFace* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a77c218bd0be2052a7cff1769b85b092e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#af1802c6c53ddab2d6b3a614f15eb153d)GetGroundNormal()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetGroundNormal | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a7aae4353a76af384aadf76aa74d9cd9f).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a0ac4794732af23165dffdab8c433dd4e)GetSiegeCampFrames()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.IMapScene.GetSiegeCampFrames | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | *siegeCamp1GlobalFrames*, |
|  |  | out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | *siegeCamp2GlobalFrames* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#ad65e0d072b55bb69d9f2559f0aee5ea8).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a7f0e3341bd33f715ffa7e79b315020e3)GetTerrainTypeName()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.CampaignSystem.Map.IMapScene.GetTerrainTypeName | ( | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *type* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#aa432964ed75afd69d1effce2d07a7079).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#af675ec20fca6107f49fe61ed7edc15f4)GetTerrainSize()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.CampaignSystem.Map.IMapScene.GetTerrainSize | ( |  | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a0c3458854c714cd065c8fe45bf0e12eb).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#af04cd522722c7d5dfffe35a5985a6a90)GetSceneLevel()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| uint TaleWorlds.CampaignSystem.Map.IMapScene.GetSceneLevel | ( | string | *name* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#ac18be4a13c8b7fce1f8009edbab93a9b).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a04bc196928a600b3f6dbfc5d8789c3c5)SetSceneLevels()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.IMapScene.SetSceneLevels | ( | List< string > | *levels* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a529d08a55f4f5e3c7d64ff5eb8551d95).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ad649d77f4d632afaaf619d12e03b7b80)GetAtmosphereStates()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [AtmosphereState](class_tale_worlds_1_1_core_1_1_atmosphere_state.html) > TaleWorlds.CampaignSystem.Map.IMapScene.GetAtmosphereStates | ( |  | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a0fc01ebf2ce5a7408bbb5dab98060c83).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a0aa965832f7e6d8f47b7b62ab3730d7c)SetAtmosphereColorgrade()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.IMapScene.SetAtmosphereColorgrade | ( | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *terrainType* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a3f83f9da727becf83d530719f15cc834).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a3d55ff8e170cae4f54a0f4a919f56a98)AddNewEntityToMapScene()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.IMapScene.AddNewEntityToMapScene | ( | string | *entityId*, |
|  |  | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#aa827fb60598ecdea0bb70b87ab7c51ff).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#abd9181f09bfaa1eea17f236d8400b73e)GetMapBorders()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.Map.IMapScene.GetMapBorders | ( | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *minimumPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *maximumPosition*, |
|  |  | out float | *maximumHeight* ) |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a70705944b3341ebf5716818d6784d65e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a887e88672d10ebd804e66274fb3b1b87)GetSceneXmlCrc()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.CampaignSystem.Map.IMapScene.GetSceneXmlCrc | ( |  | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#ab7b5dc4322b0c5d7a487531aeef03d1a).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a80b30d813f014eac8a556e8812b4f6ad)GetSceneNavigationMeshCrc()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.CampaignSystem.Map.IMapScene.GetSceneNavigationMeshCrc | ( |  | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#ad8890334ddb5d673a64a93552a9a5416).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a1cf3539d2b2a8901be5d160aab09d921)GetSnowAmountAtPosition()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Map.IMapScene.GetSnowAmountAtPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a2bef7b21db57e7d5cc86b25bea73e23e).

[◆](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a578bbc71e72871b30345dcd4affc12e8)GetRainAmountAtPosition()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.CampaignSystem.Map.IMapScene.GetRainAmountAtPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

Implemented in [SandBox.MapScene](class_sand_box_1_1_map_scene.html#a1a5dc0f5084daae3691b327e60618d53).

