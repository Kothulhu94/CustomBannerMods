--- SOURCE: class_sand_box_1_1_map_scene.html ---

SandBox.MapScene Class ReferenceInherits [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapScene](class_sand_box_1_1_map_scene.html#a81f1613ae067d0e87d90e914e55acdc6) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetTerrainSize](class_sand_box_1_1_map_scene.html#a0c3458854c714cd065c8fe45bf0e12eb) () |
| uint | [GetSceneLevel](class_sand_box_1_1_map_scene.html#ac18be4a13c8b7fce1f8009edbab93a9b) (string name) |
| void | [SetSceneLevels](class_sand_box_1_1_map_scene.html#a529d08a55f4f5e3c7d64ff5eb8551d95) (List< string > levels) |
| List< [AtmosphereState](class_tale_worlds_1_1_core_1_1_atmosphere_state.html) > | [GetAtmosphereStates](class_sand_box_1_1_map_scene.html#a0fc01ebf2ce5a7408bbb5dab98060c83) () |
| void | [ValidateAgentVisualsReseted](class_sand_box_1_1_map_scene.html#a4709a9eff562391e037375e83701aca2) () |
| void | [SetAtmosphereColorgrade](class_sand_box_1_1_map_scene.html#a3f83f9da727becf83d530719f15cc834) ([TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) terrainType) |
| void | [AddNewEntityToMapScene](class_sand_box_1_1_map_scene.html#aa827fb60598ecdea0bb70b87ab7c51ff) (string entityId, in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| void | [GetMapBorders](class_sand_box_1_1_map_scene.html#a70705944b3341ebf5716818d6784d65e) (out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) minimumPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) maximumPosition, out float maximumHeight) |
| void | [Load](class_sand_box_1_1_map_scene.html#a59372e4162666339a3df4fcdfd9aaae4) () |
| void | [SetSnowAndRainDataWithDimension](class_sand_box_1_1_map_scene.html#a4f51168eafbb1d4c8dce4a1908193082) ([Texture](class_tale_worlds_1_1_engine_1_1_texture.html) snowRainTexture, int weatherNodeGridWidthAndHeight) |
| void | [AfterLoad](class_sand_box_1_1_map_scene.html#ae6ead8528dcc0644e442d23955202986) () |
| void | [Destroy](class_sand_box_1_1_map_scene.html#a14b858a31fb73a43a1538b97409d348f) () |
| void | [DisableUnwalkableNavigationMeshes](class_sand_box_1_1_map_scene.html#a389fd6c0d7b45331837f185daf9c14ee) () |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [GetFaceIndex](class_sand_box_1_1_map_scene.html#a936596249ed29b4c0357a13df7366177) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) vec2) |
| [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | [GetTerrainTypeAtPosition](class_sand_box_1_1_map_scene.html#ab3fcef393603419228e9ea57cf5b379a) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | [GetFaceTerrainType](class_sand_box_1_1_map_scene.html#a4d0ebd49540cc29717fc458093f28783) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) navMeshFace) |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetNearestFaceCenterForPosition](class_sand_box_1_1_map_scene.html#aab2b8f4e2e6153667aa0cb9e9d8dc549) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position, int[] excludedFaceIds) |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetNearestFaceCenterForPositionWithPath](class_sand_box_1_1_map_scene.html#a3b93facf2c520f816238862abbae7546) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) pathFaceRecord, bool targetIsLand, float maxDist, int[] excludedFaceIds) |
| List< [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) > | [GetEnvironmentTerrainTypes](class_sand_box_1_1_map_scene.html#aad54ccd0622ee5a4c2040af072220770) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) originPosition) |
| List< [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) > | [GetEnvironmentTerrainTypesCount](class_sand_box_1_1_map_scene.html#a5ed146de68947a5d6cbf72f1cbb6d733) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) originPosition, out [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) currentPositionTerrainType) |
| [MapPatchData](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_patch_data.html) | [GetMapPatchAtPosition](class_sand_box_1_1_map_scene.html#a318a75adda67169591b70dd1d742b231) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) position) |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | [GetAccessiblePointNearPosition](class_sand_box_1_1_map_scene.html#aae9bc2045011d940c6f52b6af8a16795) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) pos, float radius) |
| bool | [GetPathBetweenAIFaces](class_sand_box_1_1_map_scene.html#a4b1c018e3623364cfe62eb8dc23201e5) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) startingFace, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) endingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) startingPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) endingPosition, float agentRadius, [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) path, int[] excludedFaceIds, float extraCostMultiplier, int regionSwitchCostFromLandToSea, int regionSwitchCostFromSeaToLand) |
|  | The path between pointA to pointB and pointB to pointA may differ but the path between pointA to pointB will always return same. |
| bool | [GetPathDistanceBetweenAIFaces](class_sand_box_1_1_map_scene.html#a65767aaeb15d18d82455ad52ca6e34ec) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) startingAiFace, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) endingAiFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) startingPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) endingPosition, float agentRadius, float distanceLimit, out float distance, int[] excludedFaceIds, int regionSwitchCostFromLandToSea, int regionSwitchCostFromSeaToLand) |
|  | The distance between pointA to pointB and pointB to pointA may differ but distance between pointA to pointB will always return same. |
| bool | [IsLineToPointClear](class_sand_box_1_1_map_scene.html#aa6ecdc70d2c962876895250940fb656b) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) startingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination, float agentRadius) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLastPointOnNavigationMeshFromPositionToDestination](class_sand_box_1_1_map_scene.html#af1d1110669244fd887a9bcd109153f83) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) startingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination, int[] excludedFaceIds=null) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLastPositionOnNavMeshFaceForPointAndDirection](class_sand_box_1_1_map_scene.html#a04f765cd659917afaae3e3d083abac71) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) startingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetNavigationMeshCenterPosition](class_sand_box_1_1_map_scene.html#a64402ea930d90a6fe15518fc727024f5) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) face) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetNavigationMeshCenterPosition](class_sand_box_1_1_map_scene.html#a2f6cdf6b93b728a3c5ade54d2696ed83) (int faceIndex) |
| int | [GetNumberOfNavigationMeshFaces](class_sand_box_1_1_map_scene.html#afa103e83783cf4f7f54bd6430e952caa) () |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [GetFaceAtIndex](class_sand_box_1_1_map_scene.html#aadb3c034f24405e0ed222e6569db72e0) (int faceIndex) |
| bool | [GetHeightAtPoint](class_sand_box_1_1_map_scene.html#aef72e3cce2306a031284663490d22e17) (in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) point, ref float height) |
| float | [GetWinterTimeFactor](class_sand_box_1_1_map_scene.html#a99669b4142020ae516c44973c34e5a49) () |
| float | [GetFaceVertexZ](class_sand_box_1_1_map_scene.html#a77c218bd0be2052a7cff1769b85b092e) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) navMeshFace) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetGroundNormal](class_sand_box_1_1_map_scene.html#a7aae4353a76af384aadf76aa74d9cd9f) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| void | [GetSiegeCampFrames](class_sand_box_1_1_map_scene.html#ad65e0d072b55bb69d9f2559f0aee5ea8) ([Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement, out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > siegeCamp1GlobalFrames, out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > siegeCamp2GlobalFrames) |
| void | [GetTerrainHeightAndNormal](class_sand_box_1_1_map_scene.html#af404750310621be2d9be3b21801a4e05) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, out float height, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) normal) |
| string | [GetTerrainTypeName](class_sand_box_1_1_map_scene.html#aa432964ed75afd69d1effce2d07a7079) ([TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) type) |
| uint | [GetSceneXmlCrc](class_sand_box_1_1_map_scene.html#ab7b5dc4322b0c5d7a487531aeef03d1a) () |
| uint | [GetSceneNavigationMeshCrc](class_sand_box_1_1_map_scene.html#ad8890334ddb5d673a64a93552a9a5416) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetWindAtPosition](class_sand_box_1_1_map_scene.html#aca2fc240ddd13584edd012b9ff822a1b) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| float | [GetSnowAmountAtPosition](class_sand_box_1_1_map_scene.html#a2bef7b21db57e7d5cc86b25bea73e23e) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| float | [GetRainAmountAtPosition](class_sand_box_1_1_map_scene.html#a1a5dc0f5084daae3691b327e60618d53) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| void | [SetupWaterWake](class_sand_box_1_1_map_scene.html#a0b4d2ab4ff0861cdf9574c968dc1344a) (float wakeWorldSize, float wakeCameraOffset) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [FlowMapTextureDimension](class_sand_box_1_1_map_scene.html#a3c7bf9d8dd31aaa64f84be4c9f1fc540) = 512 |

|  |  |
| --- | --- |
| Properties | |
| Scene | [Scene](class_sand_box_1_1_map_scene.html#a56c92c881cd3d13d05428865edbbc05c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_map_scene.html#a81f1613ae067d0e87d90e914e55acdc6)MapScene()
----------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.MapScene.MapScene | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_map_scene.html#a0c3458854c714cd065c8fe45bf0e12eb)GetTerrainSize()
----------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.MapScene.GetTerrainSize | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#af675ec20fca6107f49fe61ed7edc15f4).

[◆](class_sand_box_1_1_map_scene.html#ac18be4a13c8b7fce1f8009edbab93a9b)GetSceneLevel()
---------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| uint SandBox.MapScene.GetSceneLevel | ( | string | *name* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#af04cd522722c7d5dfffe35a5985a6a90).

[◆](class_sand_box_1_1_map_scene.html#a529d08a55f4f5e3c7d64ff5eb8551d95)SetSceneLevels()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.MapScene.SetSceneLevels | ( | List< string > | *levels* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a04bc196928a600b3f6dbfc5d8789c3c5).

[◆](class_sand_box_1_1_map_scene.html#a0fc01ebf2ce5a7408bbb5dab98060c83)GetAtmosphereStates()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| List< [AtmosphereState](class_tale_worlds_1_1_core_1_1_atmosphere_state.html) > SandBox.MapScene.GetAtmosphereStates | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ad649d77f4d632afaaf619d12e03b7b80).

[◆](class_sand_box_1_1_map_scene.html#a4709a9eff562391e037375e83701aca2)ValidateAgentVisualsReseted()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.MapScene.ValidateAgentVisualsReseted | ( |  | ) |  |

[◆](class_sand_box_1_1_map_scene.html#a3f83f9da727becf83d530719f15cc834)SetAtmosphereColorgrade()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.MapScene.SetAtmosphereColorgrade | ( | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *terrainType* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a0aa965832f7e6d8f47b7b62ab3730d7c).

[◆](class_sand_box_1_1_map_scene.html#aa827fb60598ecdea0bb70b87ab7c51ff)AddNewEntityToMapScene()
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.MapScene.AddNewEntityToMapScene | ( | string | *entityId*, |
|  |  | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a3d55ff8e170cae4f54a0f4a919f56a98).

[◆](class_sand_box_1_1_map_scene.html#a70705944b3341ebf5716818d6784d65e)GetMapBorders()
---------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.MapScene.GetMapBorders | ( | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *minimumPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *maximumPosition*, |
|  |  | out float | *maximumHeight* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#abd9181f09bfaa1eea17f236d8400b73e).

[◆](class_sand_box_1_1_map_scene.html#a59372e4162666339a3df4fcdfd9aaae4)Load()
------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.MapScene.Load | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a53dc69d8351115de483a8c4f9add9482).

[◆](class_sand_box_1_1_map_scene.html#a4f51168eafbb1d4c8dce4a1908193082)SetSnowAndRainDataWithDimension()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.MapScene.SetSnowAndRainDataWithDimension | ( | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *snowRainTexture*, |
|  |  | int | *weatherNodeGridWidthAndHeight* ) |

[◆](class_sand_box_1_1_map_scene.html#ae6ead8528dcc0644e442d23955202986)AfterLoad()
-----------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.MapScene.AfterLoad | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a74ac6a99c113e714cff6f7c7bf11b400).

[◆](class_sand_box_1_1_map_scene.html#a14b858a31fb73a43a1538b97409d348f)Destroy()
---------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.MapScene.Destroy | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ad77d0af886e85fe9c2e13d08be2870fd).

[◆](class_sand_box_1_1_map_scene.html#a389fd6c0d7b45331837f185daf9c14ee)DisableUnwalkableNavigationMeshes()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.MapScene.DisableUnwalkableNavigationMeshes | ( |  | ) |  |

[◆](class_sand_box_1_1_map_scene.html#a936596249ed29b4c0357a13df7366177)GetFaceIndex()
--------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) SandBox.MapScene.GetFaceIndex | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *vec2* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a63515d41c6b4ba10609f99f25c3f21b6).

[◆](class_sand_box_1_1_map_scene.html#ab3fcef393603419228e9ea57cf5b379a)GetTerrainTypeAtPosition()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) SandBox.MapScene.GetTerrainTypeAtPosition | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ab79cb03898767e4350f279ce740f330e).

[◆](class_sand_box_1_1_map_scene.html#a4d0ebd49540cc29717fc458093f28783)GetFaceTerrainType()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) SandBox.MapScene.GetFaceTerrainType | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *navMeshFace* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a6989fcb60fd469d465c0d5fdba5cc745).

[◆](class_sand_box_1_1_map_scene.html#aab2b8f4e2e6153667aa0cb9e9d8dc549)GetNearestFaceCenterForPosition()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) SandBox.MapScene.GetNearestFaceCenterForPosition | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position*, |
|  |  | int[] | *excludedFaceIds* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a03f17ce3740dbd2ccecfcdc820b62c93).

[◆](class_sand_box_1_1_map_scene.html#a3b93facf2c520f816238862abbae7546)GetNearestFaceCenterForPositionWithPath()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) SandBox.MapScene.GetNearestFaceCenterForPositionWithPath | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *pathFaceRecord*, |
|  |  | bool | *targetIsLand*, |
|  |  | float | *maxDist*, |
|  |  | int[] | *excludedFaceIds* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a0db6f5482a43730a0c6b820c6c29177e).

[◆](class_sand_box_1_1_map_scene.html#aad54ccd0622ee5a4c2040af072220770)GetEnvironmentTerrainTypes()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| List< [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) > SandBox.MapScene.GetEnvironmentTerrainTypes | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *originPosition* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#aa56913e998ffdb28719032cbb5590a4d).

[◆](class_sand_box_1_1_map_scene.html#a5ed146de68947a5d6cbf72f1cbb6d733)GetEnvironmentTerrainTypesCount()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| List< [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) > SandBox.MapScene.GetEnvironmentTerrainTypesCount | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *originPosition*, |
|  |  | out [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *currentPositionTerrainType* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a620fafa5c4975d2a4489a78426b95edf).

[◆](class_sand_box_1_1_map_scene.html#a318a75adda67169591b70dd1d742b231)GetMapPatchAtPosition()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MapPatchData](struct_tale_worlds_1_1_campaign_system_1_1_map_1_1_map_patch_data.html) SandBox.MapScene.GetMapPatchAtPosition | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *position* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a591c3af791d0c5564e838bf71c80eee0).

[◆](class_sand_box_1_1_map_scene.html#aae9bc2045011d940c6f52b6af8a16795)GetAccessiblePointNearPosition()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) SandBox.MapScene.GetAccessiblePointNearPosition | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *pos*, |
|  |  | float | *radius* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a65c0b3eaea41e7f4ca2147c83ea00114).

[◆](class_sand_box_1_1_map_scene.html#a4b1c018e3623364cfe62eb8dc23201e5)GetPathBetweenAIFaces()
-----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.MapScene.GetPathBetweenAIFaces | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *startingFace*, |
|  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *endingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *startingPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *endingPosition*, |
|  |  | float | *agentRadius*, |
|  |  | [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) | *path*, |
|  |  | int[] | *excludedFaceIds*, |
|  |  | float | *extraCostMultiplier*, |
|  |  | int | *regionSwitchCostFromLandToSea*, |
|  |  | int | *regionSwitchCostFromSeaToLand* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a97ddf2721ff09f6e25e50a66d78c39f5).

[◆](class_sand_box_1_1_map_scene.html#a65767aaeb15d18d82455ad52ca6e34ec)GetPathDistanceBetweenAIFaces()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.MapScene.GetPathDistanceBetweenAIFaces | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *startingAiFace*, |
|  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *endingAiFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *startingPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *endingPosition*, |
|  |  | float | *agentRadius*, |
|  |  | float | *distanceLimit*, |
|  |  | out float | *distance*, |
|  |  | int[] | *excludedFaceIds*, |
|  |  | int | *regionSwitchCostFromLandToSea*, |
|  |  | int | *regionSwitchCostFromSeaToLand* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ad545405636825438e307611686a609c7).

[◆](class_sand_box_1_1_map_scene.html#aa6ecdc70d2c962876895250940fb656b)IsLineToPointClear()
--------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.MapScene.IsLineToPointClear | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *startingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination*, |
|  |  | float | *agentRadius* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ac68a298fd594db5e9061fa616fbec9e2).

[◆](class_sand_box_1_1_map_scene.html#af1d1110669244fd887a9bcd109153f83)GetLastPointOnNavigationMeshFromPositionToDestination()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.MapScene.GetLastPointOnNavigationMeshFromPositionToDestination | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *startingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination*, |
|  |  | int[] | *excludedFaceIds* = null ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a7d88d9a3f1b92f4fbe0931676fbc16fb).

[◆](class_sand_box_1_1_map_scene.html#a04f765cd659917afaae3e3d083abac71)GetLastPositionOnNavMeshFaceForPointAndDirection()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.MapScene.GetLastPositionOnNavMeshFaceForPointAndDirection | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *startingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#ac6108b392c30123e6807f7b830daaef3).

[◆](class_sand_box_1_1_map_scene.html#a64402ea930d90a6fe15518fc727024f5)GetNavigationMeshCenterPosition() [1/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.MapScene.GetNavigationMeshCenterPosition | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *face* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a473f32323db47acf327f86bd4cf98955).

[◆](class_sand_box_1_1_map_scene.html#a2f6cdf6b93b728a3c5ade54d2696ed83)GetNavigationMeshCenterPosition() [2/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.MapScene.GetNavigationMeshCenterPosition | ( | int | *faceIndex* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a52b92a69fb6c9aa296f339099cddc295).

[◆](class_sand_box_1_1_map_scene.html#afa103e83783cf4f7f54bd6430e952caa)GetNumberOfNavigationMeshFaces()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int SandBox.MapScene.GetNumberOfNavigationMeshFaces | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a92de8ee927e01000fbefab26ff2196ef).

[◆](class_sand_box_1_1_map_scene.html#aadb3c034f24405e0ed222e6569db72e0)GetFaceAtIndex()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) SandBox.MapScene.GetFaceAtIndex | ( | int | *faceIndex* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#add04b86d4459859b154f3d1fdcc59132).

[◆](class_sand_box_1_1_map_scene.html#aef72e3cce2306a031284663490d22e17)GetHeightAtPoint()
------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool SandBox.MapScene.GetHeightAtPoint | ( | in [CampaignVec2](struct_tale_worlds_1_1_campaign_system_1_1_campaign_vec2.html) | *point*, |
|  |  | ref float | *height* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a34fad1d3da4b78af966a7e8b250603e8).

[◆](class_sand_box_1_1_map_scene.html#a99669b4142020ae516c44973c34e5a49)GetWinterTimeFactor()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float SandBox.MapScene.GetWinterTimeFactor | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#acf2e57dfe7185769a4fff062af800aef).

[◆](class_sand_box_1_1_map_scene.html#a77c218bd0be2052a7cff1769b85b092e)GetFaceVertexZ()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float SandBox.MapScene.GetFaceVertexZ | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *navMeshFace* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a4cfa6184f2b6216c53c5c0989ced9294).

[◆](class_sand_box_1_1_map_scene.html#a7aae4353a76af384aadf76aa74d9cd9f)GetGroundNormal()
-----------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) SandBox.MapScene.GetGroundNormal | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#af1802c6c53ddab2d6b3a614f15eb153d).

[◆](class_sand_box_1_1_map_scene.html#ad65e0d072b55bb69d9f2559f0aee5ea8)GetSiegeCampFrames()
--------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.MapScene.GetSiegeCampFrames | ( | [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement*, |
|  |  | out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | *siegeCamp1GlobalFrames*, |
|  |  | out List< [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) > | *siegeCamp2GlobalFrames* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a0ac4794732af23165dffdab8c433dd4e).

[◆](class_sand_box_1_1_map_scene.html#af404750310621be2d9be3b21801a4e05)GetTerrainHeightAndNormal()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.MapScene.GetTerrainHeightAndNormal | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | out float | *height*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *normal* ) |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a79b6d514a7cc8eb546246987acabea4b).

[◆](class_sand_box_1_1_map_scene.html#aa432964ed75afd69d1effce2d07a7079)GetTerrainTypeName()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string SandBox.MapScene.GetTerrainTypeName | ( | [TerrainType](namespace_tale_worlds_1_1_core.html#a8419f242a6422ae249b492b235be7d20) | *type* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a7f0e3341bd33f715ffa7e79b315020e3).

[◆](class_sand_box_1_1_map_scene.html#ab7b5dc4322b0c5d7a487531aeef03d1a)GetSceneXmlCrc()
----------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint SandBox.MapScene.GetSceneXmlCrc | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a887e88672d10ebd804e66274fb3b1b87).

[◆](class_sand_box_1_1_map_scene.html#ad8890334ddb5d673a64a93552a9a5416)GetSceneNavigationMeshCrc()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint SandBox.MapScene.GetSceneNavigationMeshCrc | ( |  | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a80b30d813f014eac8a556e8812b4f6ad).

[◆](class_sand_box_1_1_map_scene.html#aca2fc240ddd13584edd012b9ff822a1b)GetWindAtPosition()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.MapScene.GetWindAtPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

[◆](class_sand_box_1_1_map_scene.html#a2bef7b21db57e7d5cc86b25bea73e23e)GetSnowAmountAtPosition()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float SandBox.MapScene.GetSnowAmountAtPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a1cf3539d2b2a8901be5d160aab09d921).

[◆](class_sand_box_1_1_map_scene.html#a1a5dc0f5084daae3691b327e60618d53)GetRainAmountAtPosition()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float SandBox.MapScene.GetRainAmountAtPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

Implements [TaleWorlds.CampaignSystem.Map.IMapScene](interface_tale_worlds_1_1_campaign_system_1_1_map_1_1_i_map_scene.html#a578bbc71e72871b30345dcd4affc12e8).

[◆](class_sand_box_1_1_map_scene.html#a0b4d2ab4ff0861cdf9574c968dc1344a)SetupWaterWake()
----------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.MapScene.SetupWaterWake | ( | float | *wakeWorldSize*, |
|  |  | float | *wakeCameraOffset* ) |

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_map_scene.html#a3c7bf9d8dd31aaa64f84be4c9f1fc540)FlowMapTextureDimension
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int SandBox.MapScene.FlowMapTextureDimension = 512 | | static |

Property Documentation
----------------------

[◆](class_sand_box_1_1_map_scene.html#a56c92c881cd3d13d05428865edbbc05c)Scene
-----------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Scene SandBox.MapScene.Scene | | get |

