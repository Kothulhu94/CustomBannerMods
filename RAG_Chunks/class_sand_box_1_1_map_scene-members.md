--- SOURCE: class_sand_box_1_1_map_scene-members.html ---

SandBox.MapScene Member ListThis is the complete list of members for [SandBox.MapScene](class_sand_box_1_1_map_scene.html), including all inherited members.

|  |  |  |
| --- | --- | --- |
| [AddNewEntityToMapScene](class_sand_box_1_1_map_scene.html#aa827fb60598ecdea0bb70b87ab7c51ff)(string entityId, in CampaignVec2 position) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [AfterLoad](class_sand_box_1_1_map_scene.html#ae6ead8528dcc0644e442d23955202986)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [Destroy](class_sand_box_1_1_map_scene.html#a14b858a31fb73a43a1538b97409d348f)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [DisableUnwalkableNavigationMeshes](class_sand_box_1_1_map_scene.html#a389fd6c0d7b45331837f185daf9c14ee)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [FlowMapTextureDimension](class_sand_box_1_1_map_scene.html#a3c7bf9d8dd31aaa64f84be4c9f1fc540) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) | static |
| [GetAccessiblePointNearPosition](class_sand_box_1_1_map_scene.html#aae9bc2045011d940c6f52b6af8a16795)(in CampaignVec2 pos, float radius) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetAtmosphereStates](class_sand_box_1_1_map_scene.html#a0fc01ebf2ce5a7408bbb5dab98060c83)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetEnvironmentTerrainTypes](class_sand_box_1_1_map_scene.html#aad54ccd0622ee5a4c2040af072220770)(in CampaignVec2 originPosition) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetEnvironmentTerrainTypesCount](class_sand_box_1_1_map_scene.html#a5ed146de68947a5d6cbf72f1cbb6d733)(in CampaignVec2 originPosition, out TerrainType currentPositionTerrainType) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetFaceAtIndex](class_sand_box_1_1_map_scene.html#aadb3c034f24405e0ed222e6569db72e0)(int faceIndex) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetFaceIndex](class_sand_box_1_1_map_scene.html#a936596249ed29b4c0357a13df7366177)(in CampaignVec2 vec2) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetFaceTerrainType](class_sand_box_1_1_map_scene.html#a4d0ebd49540cc29717fc458093f28783)(PathFaceRecord navMeshFace) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetFaceVertexZ](class_sand_box_1_1_map_scene.html#a77c218bd0be2052a7cff1769b85b092e)(PathFaceRecord navMeshFace) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetGroundNormal](class_sand_box_1_1_map_scene.html#a7aae4353a76af384aadf76aa74d9cd9f)(Vec2 position) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetHeightAtPoint](class_sand_box_1_1_map_scene.html#aef72e3cce2306a031284663490d22e17)(in CampaignVec2 point, ref float height) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetLastPointOnNavigationMeshFromPositionToDestination](class_sand_box_1_1_map_scene.html#af1d1110669244fd887a9bcd109153f83)(PathFaceRecord startingFace, Vec2 position, Vec2 destination, int[] excludedFaceIds=null) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetLastPositionOnNavMeshFaceForPointAndDirection](class_sand_box_1_1_map_scene.html#a04f765cd659917afaae3e3d083abac71)(PathFaceRecord startingFace, Vec2 position, Vec2 destination) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetMapBorders](class_sand_box_1_1_map_scene.html#a70705944b3341ebf5716818d6784d65e)(out Vec2 minimumPosition, out Vec2 maximumPosition, out float maximumHeight) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetMapPatchAtPosition](class_sand_box_1_1_map_scene.html#a318a75adda67169591b70dd1d742b231)(in CampaignVec2 position) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetNavigationMeshCenterPosition](class_sand_box_1_1_map_scene.html#a64402ea930d90a6fe15518fc727024f5)(PathFaceRecord face) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetNavigationMeshCenterPosition](class_sand_box_1_1_map_scene.html#a2f6cdf6b93b728a3c5ade54d2696ed83)(int faceIndex) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetNearestFaceCenterForPosition](class_sand_box_1_1_map_scene.html#aab2b8f4e2e6153667aa0cb9e9d8dc549)(in CampaignVec2 position, int[] excludedFaceIds) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetNearestFaceCenterForPositionWithPath](class_sand_box_1_1_map_scene.html#a3b93facf2c520f816238862abbae7546)(PathFaceRecord pathFaceRecord, bool targetIsLand, float maxDist, int[] excludedFaceIds) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetNumberOfNavigationMeshFaces](class_sand_box_1_1_map_scene.html#afa103e83783cf4f7f54bd6430e952caa)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetPathBetweenAIFaces](class_sand_box_1_1_map_scene.html#a4b1c018e3623364cfe62eb8dc23201e5)(PathFaceRecord startingFace, PathFaceRecord endingFace, Vec2 startingPosition, Vec2 endingPosition, float agentRadius, NavigationPath path, int[] excludedFaceIds, float extraCostMultiplier, int regionSwitchCostFromLandToSea, int regionSwitchCostFromSeaToLand) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetPathDistanceBetweenAIFaces](class_sand_box_1_1_map_scene.html#a65767aaeb15d18d82455ad52ca6e34ec)(PathFaceRecord startingAiFace, PathFaceRecord endingAiFace, Vec2 startingPosition, Vec2 endingPosition, float agentRadius, float distanceLimit, out float distance, int[] excludedFaceIds, int regionSwitchCostFromLandToSea, int regionSwitchCostFromSeaToLand) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetRainAmountAtPosition](class_sand_box_1_1_map_scene.html#a1a5dc0f5084daae3691b327e60618d53)(Vec2 position) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetSceneLevel](class_sand_box_1_1_map_scene.html#ac18be4a13c8b7fce1f8009edbab93a9b)(string name) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetSceneNavigationMeshCrc](class_sand_box_1_1_map_scene.html#ad8890334ddb5d673a64a93552a9a5416)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetSceneXmlCrc](class_sand_box_1_1_map_scene.html#ab7b5dc4322b0c5d7a487531aeef03d1a)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetSiegeCampFrames](class_sand_box_1_1_map_scene.html#ad65e0d072b55bb69d9f2559f0aee5ea8)(Settlement settlement, out List< MatrixFrame > siegeCamp1GlobalFrames, out List< MatrixFrame > siegeCamp2GlobalFrames) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetSnowAmountAtPosition](class_sand_box_1_1_map_scene.html#a2bef7b21db57e7d5cc86b25bea73e23e)(Vec2 position) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetTerrainHeightAndNormal](class_sand_box_1_1_map_scene.html#af404750310621be2d9be3b21801a4e05)(Vec2 position, out float height, out Vec3 normal) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetTerrainSize](class_sand_box_1_1_map_scene.html#a0c3458854c714cd065c8fe45bf0e12eb)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetTerrainTypeAtPosition](class_sand_box_1_1_map_scene.html#ab3fcef393603419228e9ea57cf5b379a)(in CampaignVec2 position) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetTerrainTypeName](class_sand_box_1_1_map_scene.html#aa432964ed75afd69d1effce2d07a7079)(TerrainType type) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetWindAtPosition](class_sand_box_1_1_map_scene.html#aca2fc240ddd13584edd012b9ff822a1b)(Vec2 position) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [GetWinterTimeFactor](class_sand_box_1_1_map_scene.html#a99669b4142020ae516c44973c34e5a49)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [IsLineToPointClear](class_sand_box_1_1_map_scene.html#aa6ecdc70d2c962876895250940fb656b)(PathFaceRecord startingFace, Vec2 position, Vec2 destination, float agentRadius) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [Load](class_sand_box_1_1_map_scene.html#a59372e4162666339a3df4fcdfd9aaae4)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [MapScene](class_sand_box_1_1_map_scene.html#a81f1613ae067d0e87d90e914e55acdc6)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [Scene](class_sand_box_1_1_map_scene.html#a56c92c881cd3d13d05428865edbbc05c) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [SetAtmosphereColorgrade](class_sand_box_1_1_map_scene.html#a3f83f9da727becf83d530719f15cc834)(TerrainType terrainType) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [SetSceneLevels](class_sand_box_1_1_map_scene.html#a529d08a55f4f5e3c7d64ff5eb8551d95)(List< string > levels) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [SetSnowAndRainDataWithDimension](class_sand_box_1_1_map_scene.html#a4f51168eafbb1d4c8dce4a1908193082)(Texture snowRainTexture, int weatherNodeGridWidthAndHeight) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [SetupWaterWake](class_sand_box_1_1_map_scene.html#a0b4d2ab4ff0861cdf9574c968dc1344a)(float wakeWorldSize, float wakeCameraOffset) | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |
| [ValidateAgentVisualsReseted](class_sand_box_1_1_map_scene.html#a4709a9eff562391e037375e83701aca2)() | [SandBox.MapScene](class_sand_box_1_1_map_scene.html) |  |

