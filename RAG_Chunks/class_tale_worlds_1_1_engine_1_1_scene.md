--- SOURCE: class_tale_worlds_1_1_engine_1_1_scene.html ---

TaleWorlds.Engine.Scene Class ReferencesealedInherits NativeObject.

|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [IsDefaultEditorScene](class_tale_worlds_1_1_engine_1_1_scene.html#a5897c4e5ba028f78c52d1783f149bdea) () |
| bool | [IsMultiplayerScene](class_tale_worlds_1_1_engine_1_1_scene.html#aa233efdd21694071f8b8dc2a0c336bdf) () |
| string | [TakePhotoModePicture](class_tale_worlds_1_1_engine_1_1_scene.html#a472e6fde9f7417dd2d3eef487eebee72) (bool saveAmbientOcclusionPass, bool savingObjectIdPass, bool saveShadowPass) |
| string | [GetAllColorGradeNames](class_tale_worlds_1_1_engine_1_1_scene.html#a8623577bebd2c97181d93ea1867b1f8c) () |
| string | [GetAllFilterNames](class_tale_worlds_1_1_engine_1_1_scene.html#a7951dc009d78c9192d2043284d444e6c) () |
| float | [GetPhotoModeRoll](class_tale_worlds_1_1_engine_1_1_scene.html#a7813f6bdcbf515ab5195b80819ac952b) () |
| bool | [GetPhotoModeOrbit](class_tale_worlds_1_1_engine_1_1_scene.html#a7b5425bcfe7e653fdbd0fcd5e02a4856) () |
| bool | [GetPhotoModeOn](class_tale_worlds_1_1_engine_1_1_scene.html#a709dcb8b06540b04a20b826d7d322610) () |
| void | [GetPhotoModeFocus](class_tale_worlds_1_1_engine_1_1_scene.html#a1153e896b2cb27daf13d99c97e2eabcf) (ref float focus, ref float focusStart, ref float focusEnd, ref float exposure, ref bool vignetteOn) |
| int | [GetSceneColorGradeIndex](class_tale_worlds_1_1_engine_1_1_scene.html#a58ba6499304dc3844466c41d6d9c9ce1) () |
| int | [GetSceneFilterIndex](class_tale_worlds_1_1_engine_1_1_scene.html#a465859867dd3a882159c7ce5f3cf2cb3) () |
| void | [EnableFixedTick](class_tale_worlds_1_1_engine_1_1_scene.html#a36d94a925c0e28942aa309f150e61883) () |
| string | [GetLoadingStateName](class_tale_worlds_1_1_engine_1_1_scene.html#aa49187f7ecc3de980b09af9719f9a7e4) () |
| bool | [IsLoadingFinished](class_tale_worlds_1_1_engine_1_1_scene.html#a2f3ca9bc9fefdb96b1fb46e0cd244c31) () |
| void | [SetPhotoModeRoll](class_tale_worlds_1_1_engine_1_1_scene.html#a2f6c647b74d7dcb4f85901edaafef6c2) (float roll) |
| void | [SetPhotoModeOrbit](class_tale_worlds_1_1_engine_1_1_scene.html#a4fc6bf2d935397ae252649c4313b7c0c) (bool orbit) |
| float | [GetFallDensity](class_tale_worlds_1_1_engine_1_1_scene.html#aabd1f0d8272b3c2ee257cf75eccb36ef) () |
| void | [SetPhotoModeOn](class_tale_worlds_1_1_engine_1_1_scene.html#adf744006b1fb20af5a9c3e071fc7e871) (bool on) |
| void | [SetPhotoModeFocus](class_tale_worlds_1_1_engine_1_1_scene.html#af723138381dbfd85bf3db98db846e677) (float focusStart, float focusEnd, float focus, float exposure) |
| void | [SetPhotoModeFov](class_tale_worlds_1_1_engine_1_1_scene.html#a09c2708fd4601786458c9742ee4a281f) (float verticalFov) |
| float | [GetPhotoModeFov](class_tale_worlds_1_1_engine_1_1_scene.html#a376161666c12dafc30ffd9ec3a41b90c) () |
| bool | [HasDecalRenderer](class_tale_worlds_1_1_engine_1_1_scene.html#a88d91062cb1dfc50a3509bd36b20dced) () |
| void | [SetPhotoModeVignette](class_tale_worlds_1_1_engine_1_1_scene.html#a72ba5a2d4b14d00b70933e4a9ae2b586) (bool vignetteOn) |
| void | [SetSceneColorGradeIndex](class_tale_worlds_1_1_engine_1_1_scene.html#a7b1c8dcea30d72723b65b1132d09ce26) (int index) |
| int | [SetSceneFilterIndex](class_tale_worlds_1_1_engine_1_1_scene.html#abcf0512da100890827863ada35313e0d) (int index) |
| void | [SetSceneColorGrade](class_tale_worlds_1_1_engine_1_1_scene.html#a1a777273686556715736519518687405) (string textureName) |
| void | [SetUpgradeLevel](class_tale_worlds_1_1_engine_1_1_scene.html#a8de7cd738f41dcf6cc57cca4e290ca76) (int level) |
| void | [CreateBurstParticle](class_tale_worlds_1_1_engine_1_1_scene.html#a9629c31a81f0cc17e20dd364b2f063ba) (int particleId, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| float[] | [GetTerrainHeightData](class_tale_worlds_1_1_engine_1_1_scene.html#ade5563f78443276a277b8d9f4652ca09) (int nodeXIndex, int nodeYIndex) |
| short[] | [GetTerrainPhysicsMaterialIndexData](class_tale_worlds_1_1_engine_1_1_scene.html#a28dbe6604f58ff097f3d002d33b53ea3) (int nodeXIndex, int nodeYIndex) |
| void | [GetTerrainData](class_tale_worlds_1_1_engine_1_1_scene.html#a28031d16a9c4b8f1a997acf82dff4ad7) (out [Vec2i](struct_tale_worlds_1_1_library_1_1_vec2i.html) nodeDimension, out float nodeSize, out int layerCount, out int layerVersion) |
| void | [GetTerrainNodeData](class_tale_worlds_1_1_engine_1_1_scene.html#a2f31a35eb067e82e94c3b85a8e0bd2bd) (int xIndex, int yIndex, out int vertexCountAlongAxis, out float quadLength, out float minHeight, out float maxHeight) |
| [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) | [GetTerrainPhysicsMaterialAtLayer](class_tale_worlds_1_1_engine_1_1_scene.html#a47023c3f7f2a1ec25b479a053547e990) (int layerIndex) |
| void | [SetSceneColorGrade](class_tale_worlds_1_1_engine_1_1_scene.html#a357b6accc41752570750ef976e2bf93d) (Scene scene, string textureName) |
| float | [GetWaterLevel](class_tale_worlds_1_1_engine_1_1_scene.html#a6d835d147be526cc77895610fbe52fc6) () |
| float | [GetWaterLevelAtPosition](class_tale_worlds_1_1_engine_1_1_scene.html#a17044e3ff8e7f1a90270ff4a3165cec0) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, bool useWaterRenderer, bool checkWaterBodyEntities) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetWaterSpeedAtPosition](class_tale_worlds_1_1_engine_1_1_scene.html#abdc1c1bb0ec63df18d7c9017e70d6183) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, bool doChoppinessCorrection) |
| void | [GetBulkWaterLevelAtPositions](class_tale_worlds_1_1_engine_1_1_scene.html#a567198b5d3d333a2af56c39fcdcce3ab) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)[] waterHeightQueryArray, ref float[] waterHeightsAtVolumes, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] waterSurfaceNormals) |
| void | [GetInterpolationFactorForBodyWorldTransformSmoothing](class_tale_worlds_1_1_engine_1_1_scene.html#a9c71f47e503a8ba0852157a736275126) (out float interpolationFactor, out float fixedDt) |
| void | [GetBulkWaterLevelAtVolumes](class_tale_worlds_1_1_engine_1_1_scene.html#a9b65313499d3c1976659df012ade4cf3) (UIntPtr waterHeightQueryArray, int waterHeightQueryArrayCount, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) globalFrame) |
| float | [GetWaterStrength](class_tale_worlds_1_1_engine_1_1_scene.html#a9b176da3d1c00bbe1563b37d14e6207b) () |
| void | [DeRegisterShipVisual](class_tale_worlds_1_1_engine_1_1_scene.html#af6268eecbf17ac7fb7dc0a38d2509fe0) (UIntPtr visualPointer) |
| UIntPtr | [RegisterShipVisualToWaterRenderer](class_tale_worlds_1_1_engine_1_1_scene.html#ab13ed483217bb72a996934bacc9f1039) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) waterEffectBB) |
| void | [SetWaterStrength](class_tale_worlds_1_1_engine_1_1_scene.html#ae5001ef524f10d56726dfdae7c0f913b) (float newWaterStrength) |
| void | [AddWaterWakeWithSphere](class_tale_worlds_1_1_engine_1_1_scene.html#a847fd9c0966466e8687fd5dabaa97fda) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, float radius, float wakeVisibility, float foamVisibility) |
| void | [AddWaterWakeWithCapsule](class_tale_worlds_1_1_engine_1_1_scene.html#ad14edabf816e8ee63a9856a5412bec84) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) positionA, float radiusA, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) positionB, float radiusB, float wakeVisibility, float foamVisibility) |
| bool | [GetPathBetweenAIFaces](class_tale_worlds_1_1_engine_1_1_scene.html#ad868aa8a53f7290805a4d352e15adbe5) (UIntPtr startingFace, UIntPtr endingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) startingPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) endingPosition, float agentRadius, [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) path, int[] excludedFaceIds) |
| bool | [HasNavmeshFaceUnsharedEdges](class_tale_worlds_1_1_engine_1_1_scene.html#ae21cca4fd47211b06e4b5510a5a12179) (in [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) faceRecord) |
| int | [GetNavmeshFaceCountBetweenTwoIds](class_tale_worlds_1_1_engine_1_1_scene.html#a25e180365de0dfe5f64c6c4ff6435689) (int firstId, int secondId) |
| void | [GetNavmeshFaceRecordsBetweenTwoIds](class_tale_worlds_1_1_engine_1_1_scene.html#a854f086754989dcc68fe3c8141011046) (int firstId, int secondId, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html)[] faceRecords) |
| void | [SetFixedTickCallbackActive](class_tale_worlds_1_1_engine_1_1_scene.html#a70d5930a923be2dbb956a97cbc02a58c) (bool isActive) |
| void | [SetOnCollisionFilterCallbackActive](class_tale_worlds_1_1_engine_1_1_scene.html#a3f0f85578f5eee4caab7dd47a07154df) (bool isActive) |
| bool | [GetPathBetweenAIFaces](class_tale_worlds_1_1_engine_1_1_scene.html#aff26935405d7bbbeec853058c47b0b02) (UIntPtr startingFace, UIntPtr endingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) startingPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) endingPosition, float agentRadius, [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) path, int[] excludedFaceIds, int regionSwitchCostTo0, int regionSwitchCostTo1) |
| bool | [GetPathBetweenAIFaces](class_tale_worlds_1_1_engine_1_1_scene.html#a9fc31b93004aa87fb47c6417c3d33ffe) (int startingFace, int endingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) startingPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) endingPosition, float agentRadius, [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) path, int[] excludedFaceIds, float extraCostMultiplier) |
| bool | [GetPathBetweenAIFaces](class_tale_worlds_1_1_engine_1_1_scene.html#aaa8df00d33ed0f502c24a8056fee192b) (int startingFace, int endingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) startingPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) endingPosition, float agentRadius, [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) path, int[] excludedFaceIds, float extraCostMultiplier, int regionSwitchCostTo0, int regionSwitchCostTo1) |
| bool | [GetPathDistanceBetweenAIFaces](class_tale_worlds_1_1_engine_1_1_scene.html#acfd2dbf3f2e2372542864f332843630c) (int startingAiFace, int endingAiFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) startingPosition, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) endingPosition, float agentRadius, float distanceLimit, out float distance, int[] excludedFaceIds, int regionSwitchCostTo0, int regionSwitchCostTo1) |
|  | Distance between pointA to pointB and pointB to pointA may differ but distance between pointA to pointB will always return same. |
| void | [GetNavMeshFaceIndex](class_tale_worlds_1_1_engine_1_1_scene.html#ad421a3b83a4e5282530f62850e1c7d0f) (ref [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) record, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, bool isRegion1, bool checkIfDisabled, bool ignoreHeight=false) |
| void | [GetNavMeshFaceIndex](class_tale_worlds_1_1_engine_1_1_scene.html#a61c1d56ed351178b1c4a914175770a17) (ref [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) record, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, bool checkIfDisabled) |
| void | [AddAlwaysRenderedSkeleton](class_tale_worlds_1_1_engine_1_1_scene.html#a3a5919722baabdcf60c0b833e4a28262) ([Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton) |
| void | [RemoveAlwaysRenderedSkeleton](class_tale_worlds_1_1_engine_1_1_scene.html#a75e2cb3ced6d0f36a64ae0fb2f684828) ([Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton) |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [CreatePathMesh](class_tale_worlds_1_1_engine_1_1_scene.html#ad1611e2b9c1999066deddcc2a82d3320) (string baseEntityName, bool isWaterPath) |
| void | [SetActiveVisibilityLevels](class_tale_worlds_1_1_engine_1_1_scene.html#afe006be7535fa4fc7e94bea36761f483) (List< String > levelsToActivate) |
| void | [SetDoNotWaitForLoadingStatesToRender](class_tale_worlds_1_1_engine_1_1_scene.html#a9bce61755158ad39d188982f34c12959) (bool value) |
| void | [SetDynamicSnowTexture](class_tale_worlds_1_1_engine_1_1_scene.html#aedaad80cdd452e093234f68737b9cb6b) ([Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture) |
| void | [GetWindFlowMapData](class_tale_worlds_1_1_engine_1_1_scene.html#a66e6e09e7211af48b6df986d2368101e) (float[] flowMapData) |
| void | [CreateDynamicRainTexture](class_tale_worlds_1_1_engine_1_1_scene.html#a0938607e2f38ecb1820fd1fa58747ed5) (int w, int h) |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [CreatePathMesh](class_tale_worlds_1_1_engine_1_1_scene.html#a655e485942c0eebeebf0ddf145ed279a) (IList< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > pathNodes, bool isWaterPath=false) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetEntityWithGuid](class_tale_worlds_1_1_engine_1_1_scene.html#addfdbeb2acf2cabbdf0a5db0e4fcdfe5) (string guid) |
| bool | [IsEntityFrameChanged](class_tale_worlds_1_1_engine_1_1_scene.html#a426264de0956b0acac3b81f101de22f1) (string containsName) |
|  | This function checks all the game entities whose names contain the given string, and returns if any of their frames has changed or not. |
| void | [GetTerrainHeightAndNormal](class_tale_worlds_1_1_engine_1_1_scene.html#a806bcc4b7fcff1f74286d1fc53d0999d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, out float height, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) normal) |
| int | [GetFloraInstanceCount](class_tale_worlds_1_1_engine_1_1_scene.html#ae86076b7c0214ad20fc5ea54a3ecfd0a) () |
| int | [GetFloraRendererTextureUsage](class_tale_worlds_1_1_engine_1_1_scene.html#abc8619bbc907680f2ced7f439ac4d45d) () |
| int | [GetTerrainMemoryUsage](class_tale_worlds_1_1_engine_1_1_scene.html#a4ea9d31b5de2b09631ed71a91212423e) () |
| void | [SetFetchCrcInfoOfScene](class_tale_worlds_1_1_engine_1_1_scene.html#a647204dbfbae7a43744e0f50095f3996) (bool value) |
| uint | [GetSceneXMLCRC](class_tale_worlds_1_1_engine_1_1_scene.html#ae92214b4713ea61197f28095057e6b82) () |
| uint | [GetNavigationMeshCRC](class_tale_worlds_1_1_engine_1_1_scene.html#ae699da3585144d765972eaa7888db3b3) () |
| void | [SetGlobalWindStrengthVector](class_tale_worlds_1_1_engine_1_1_scene.html#a592949572dc653eed326bef085f0cbbe) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) windVector) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetGlobalWindStrengthVector](class_tale_worlds_1_1_engine_1_1_scene.html#aa4298830ad8c8959556e6f413c1ac697) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetGlobalWindVelocity](class_tale_worlds_1_1_engine_1_1_scene.html#a9c38d92cf237148c7d327b457e563baa) () |
| void | [SetGlobalWindVelocity](class_tale_worlds_1_1_engine_1_1_scene.html#a8960849a8b92ced3e36141731e4893ee) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) windVector) |
| bool | [GetEnginePhysicsEnabled](class_tale_worlds_1_1_engine_1_1_scene.html#a8300f527e8abbef9925894ec1dd56e2c) () |
| void | [ClearNavMesh](class_tale_worlds_1_1_engine_1_1_scene.html#aa6175671d2a72f2325e89da781c8ccff) () |
| void | [StallLoadingRenderingsUntilFurtherNotice](class_tale_worlds_1_1_engine_1_1_scene.html#a405e657d26b8d1a69c804ba2229d4900) () |
| int | [GetNavMeshFaceCount](class_tale_worlds_1_1_engine_1_1_scene.html#a3528efcd6afd59619bab43076d6ee968) () |
| void | [ResumeLoadingRenderings](class_tale_worlds_1_1_engine_1_1_scene.html#abe32900592669b66d2fee802eef5f97d) () |
| uint | [GetUpgradeLevelMask](class_tale_worlds_1_1_engine_1_1_scene.html#aab6a3eb06f0121cc56291269f5941323) () |
| void | [SetUpgradeLevelVisibility](class_tale_worlds_1_1_engine_1_1_scene.html#a084d0b18607e80aa1000d219a8d869e1) (uint mask) |
| void | [SetUpgradeLevelVisibility](class_tale_worlds_1_1_engine_1_1_scene.html#aa609c584e1ba69897d49477e814afed3) (List< string > levels) |
| int | [GetIdOfNavMeshFace](class_tale_worlds_1_1_engine_1_1_scene.html#ab2cddc48a4cee5f3599a0750e819fb70) (int faceIndex) |
| void | [SetClothSimulationState](class_tale_worlds_1_1_engine_1_1_scene.html#a12822106e745f88ea0075672b5ccca4a) (bool state) |
| void | [GetNavMeshCenterPosition](class_tale_worlds_1_1_engine_1_1_scene.html#aa7b25f654f5c0826d4529b4e5afeda0c) (int faceIndex, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) centerPosition) |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [GetNavMeshPathFaceRecord](class_tale_worlds_1_1_engine_1_1_scene.html#afbf748a275e4c59884b214843eda2a66) (int faceIndex) |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | [GetPathFaceRecordFromNavMeshFacePointer](class_tale_worlds_1_1_engine_1_1_scene.html#a7e8097b2072cd3d21681b48bfaacfdf1) (UIntPtr navMeshFacePointer) |
| void | [GetAllNavmeshFaceRecords](class_tale_worlds_1_1_engine_1_1_scene.html#ab4c44428441eb1c2562bb968db76e7df) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html)[] faceRecords) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetFirstEntityWithName](class_tale_worlds_1_1_engine_1_1_scene.html#a2083366f78214af390eefea2e7279afd) (string name) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetCampaignEntityWithName](class_tale_worlds_1_1_engine_1_1_scene.html#a676a8325873a98f19c2696d2b2f5c168) (string name) |
| void | [GetAllEntitiesWithScriptComponent< T >](class_tale_worlds_1_1_engine_1_1_scene.html#ae08ee00ee18f6f097968f50a9e548cc9) (ref List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > entities) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetFirstEntityWithScriptComponent< T >](class_tale_worlds_1_1_engine_1_1_scene.html#acf6196f229567f2b4f589b487a670a2b) () |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [GetFirstEntityWithScriptComponent](class_tale_worlds_1_1_engine_1_1_scene.html#a74adefd3c915f36935c04f8446565e6f) (string scriptName) |
| uint | [GetUpgradeLevelMaskOfLevelName](class_tale_worlds_1_1_engine_1_1_scene.html#ad30a2fb99453f99ef247b397cf02be45) (string levelName) |
| string | [GetUpgradeLevelNameOfIndex](class_tale_worlds_1_1_engine_1_1_scene.html#a3a631d0c6440fab2386867b1140cb0ce) (int index) |
| int | [GetUpgradeLevelCount](class_tale_worlds_1_1_engine_1_1_scene.html#aa205dddfc33270a4c6148b6b8c6ea69c) () |
| float | [GetWinterTimeFactor](class_tale_worlds_1_1_engine_1_1_scene.html#a69472daa9e2b2193bd268f3a5381d6ac) () |
| float | [GetNavMeshFaceFirstVertexZ](class_tale_worlds_1_1_engine_1_1_scene.html#acbfdca68d38a90d93e714573ef6e48c3) (int faceIndex) |
| void | [SetWinterTimeFactor](class_tale_worlds_1_1_engine_1_1_scene.html#a1b8d4ee3d2cf676f92020d3be0e4d3aa) (float winterTimeFactor) |
| void | [SetDrynessFactor](class_tale_worlds_1_1_engine_1_1_scene.html#a41629458850ea32a562b8ae00a038b3c) (float drynessFactor) |
| float | [GetFog](class_tale_worlds_1_1_engine_1_1_scene.html#ae2405a54b90e681b2ea09a286fd169de) () |
| void | [SetFog](class_tale_worlds_1_1_engine_1_1_scene.html#a0cb80649542fee37b321df43505d11c0) (float fogDensity, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) fogColor, float fogFalloff) |
| void | [SetFogAdvanced](class_tale_worlds_1_1_engine_1_1_scene.html#a18013e7926202ab300392359e1741365) (float fogFalloffOffset, float fogFalloffMinFog, float fogFalloffStartDist) |
| void | [SetFogAmbientColor](class_tale_worlds_1_1_engine_1_1_scene.html#ad2e7d8082c0bb8cb2b44a2e958f4bff7) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) fogAmbientColor) |
| void | [SetTemperature](class_tale_worlds_1_1_engine_1_1_scene.html#a9050226e428cb7e9bcaa21f886cf5381) (float temperature) |
| void | [SetHumidity](class_tale_worlds_1_1_engine_1_1_scene.html#a9dc244df56da269ad1395c831c12b8d3) (float humidity) |
| void | [SetDynamicShadowmapCascadesRadiusMultiplier](class_tale_worlds_1_1_engine_1_1_scene.html#a060440c252677c728d4367781ca2ad72) (float multiplier) |
| void | [SetEnvironmentMultiplier](class_tale_worlds_1_1_engine_1_1_scene.html#ac5cc6b5cc633cfbfa91c34d17a42cd63) (bool useMultiplier, float multiplier) |
| void | [SetSkyRotation](class_tale_worlds_1_1_engine_1_1_scene.html#a2718ae45edc456b249b6738f0331d2ff) (float rotation) |
| void | [SetSkyBrightness](class_tale_worlds_1_1_engine_1_1_scene.html#a14ddd0b6feb68f60ede60ccf84fee0a0) (float brightness) |
| void | [SetForcedSnow](class_tale_worlds_1_1_engine_1_1_scene.html#af2a8f17515db391dd3435cb461818576) (bool value) |
| void | [SetSunLight](class_tale_worlds_1_1_engine_1_1_scene.html#a3d72afce59d9496ec5ecbd090c2c1182) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction) |
| void | [SetSunDirection](class_tale_worlds_1_1_engine_1_1_scene.html#abf9648a1b5f8651a344ba4872ea34435) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction) |
| void | [SetSun](class_tale_worlds_1_1_engine_1_1_scene.html#ae941f591ca1f6351c52bea690027a8ac) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color, float altitude, float angle, float intensity) |
| void | [SetSunAngleAltitude](class_tale_worlds_1_1_engine_1_1_scene.html#a2bf6be0a577559d3dcbcc610f55b5d1b) (float angle, float altitude) |
| void | [SetSunSize](class_tale_worlds_1_1_engine_1_1_scene.html#ac8e9da36397172206e42602cc64ac789) (float size) |
| void | [SetSunShaftStrength](class_tale_worlds_1_1_engine_1_1_scene.html#aaa6328015921aa5f1e3e406271fb5339) (float strength) |
| float | [GetRainDensity](class_tale_worlds_1_1_engine_1_1_scene.html#ad432aa14a7c10e1ed653bd0384e85dfa) () |
| void | [SetRainDensity](class_tale_worlds_1_1_engine_1_1_scene.html#ae19a1e3ac5ee96ff95809967860bcd8f) (float density) |
| float | [GetSnowDensity](class_tale_worlds_1_1_engine_1_1_scene.html#a9259d9b6da271b20ba3b5aa735996b2f) () |
| void | [SetSnowDensity](class_tale_worlds_1_1_engine_1_1_scene.html#ac9c5d0bad57e8d197178828a7e387d46) (float density) |
| void | [AddDecalInstance](class_tale_worlds_1_1_engine_1_1_scene.html#af4bc9b93fd8a1d792625c7a9ee1c77ed) ([Decal](class_tale_worlds_1_1_engine_1_1_decal.html) decal, string decalSetID, bool deletable) |
| void | [RemoveDecalInstance](class_tale_worlds_1_1_engine_1_1_scene.html#acbbc73aff5dd8df2f6c4c615876bef88) ([Decal](class_tale_worlds_1_1_engine_1_1_decal.html) decal, string decalSetID) |
| void | [SetShadow](class_tale_worlds_1_1_engine_1_1_scene.html#a14e84426c2107c805ae11393f39210c6) (bool shadowEnabled) |
| int | [AddPointLight](class_tale_worlds_1_1_engine_1_1_scene.html#ab9407e214cdb050688bc8ae8307267f9) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, float radius) |
| int | [AddDirectionalLight](class_tale_worlds_1_1_engine_1_1_scene.html#acfb3f98a3b285b8c2921b56360c2c4e3) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, float radius) |
| void | [SetLightPosition](class_tale_worlds_1_1_engine_1_1_scene.html#a16ce914897afe4f4e82e7bcddddcda43) (int lightIndex, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| void | [SetLightDiffuseColor](class_tale_worlds_1_1_engine_1_1_scene.html#a85a2c992be982400e84ad5c150dd2763) (int lightIndex, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) diffuseColor) |
| void | [SetLightDirection](class_tale_worlds_1_1_engine_1_1_scene.html#a474c3c9fa34c6d12122cb0a214ddb2b7) (int lightIndex, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction) |
| void | [SetMieScatterFocus](class_tale_worlds_1_1_engine_1_1_scene.html#af5b99b0614fc260d48baf7d305398c09) (float strength) |
| void | [SetMieScatterStrength](class_tale_worlds_1_1_engine_1_1_scene.html#a2e5650cbd559a84787c3a45ed86b17c2) (float strength) |
| void | [SetBrightpassThreshold](class_tale_worlds_1_1_engine_1_1_scene.html#a9b30bb960d0c3d7fca32bc30cb1512b4) (float threshold) |
| void | [SetLensDistortion](class_tale_worlds_1_1_engine_1_1_scene.html#a20ad96ed2a95c2ca10b3761fcb7207f1) (float amount) |
| void | [SetHexagonVignetteAlpha](class_tale_worlds_1_1_engine_1_1_scene.html#a1716b3d5ca44078b72fec830c01f9e8d) (float amount) |
| void | [SetMinExposure](class_tale_worlds_1_1_engine_1_1_scene.html#a5502aca9e35e6b46e05747a4d513e580) (float minExposure) |
| void | [SetMaxExposure](class_tale_worlds_1_1_engine_1_1_scene.html#a476b04b1df303b52f186a19c0280abf4) (float maxExposure) |
| void | [SetTargetExposure](class_tale_worlds_1_1_engine_1_1_scene.html#ab9e8912f6202794a6dc4c795bf10e449) (float targetExposure) |
| void | [SetMiddleGray](class_tale_worlds_1_1_engine_1_1_scene.html#a646b53db00378dca9530b557d698f78c) (float middleGray) |
| void | [SetBloomStrength](class_tale_worlds_1_1_engine_1_1_scene.html#a453ed850b7204e500f275fa813288b04) (float bloomStrength) |
| void | [SetBloomAmount](class_tale_worlds_1_1_engine_1_1_scene.html#ae101cd17dc3a155e5e959057deeca793) (float bloomAmount) |
| void | [SetGrainAmount](class_tale_worlds_1_1_engine_1_1_scene.html#a4a167ac5af92e09f4d4582ffff227267) (float grainAmount) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [AddItemEntity](class_tale_worlds_1_1_engine_1_1_scene.html#adff730a4858e4b3d3f2c0c24761f3c8c) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) placementFrame, [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) metaMesh) |
| void | [RemoveEntity](class_tale_worlds_1_1_engine_1_1_scene.html#aea645a70e01091a0464276ad7be87060) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, int removeReason) |
| void | [RemoveEntity](class_tale_worlds_1_1_engine_1_1_scene.html#adbdc0931f851bf1a921b99d3c64a4232) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity, int removeReason) |
| bool | [AttachEntity](class_tale_worlds_1_1_engine_1_1_scene.html#a73b842d34afc956547f9fd94bbb1e05a) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, bool showWarnings=false) |
| bool | [AttachEntity](class_tale_worlds_1_1_engine_1_1_scene.html#a1e777800411d916aa3a719e34590b30d) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity, bool showWarnings=false) |
| void | [AddEntityWithMesh](class_tale_worlds_1_1_engine_1_1_scene.html#a5cb16db75c39ae3b88c0114a4e7f3dd0) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [AddEntityWithMultiMesh](class_tale_worlds_1_1_engine_1_1_scene.html#a667f29721550b8ac11fc66886a985cc9) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) mesh, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [Tick](class_tale_worlds_1_1_engine_1_1_scene.html#a260f317ccc40ba08efe44199d6a9cf70) (float dt) |
| void | [ClearAll](class_tale_worlds_1_1_engine_1_1_scene.html#ac8b29e2bf595b1536380f06b0c12d621) () |
| void | [SetDefaultLighting](class_tale_worlds_1_1_engine_1_1_scene.html#a441706d9c2bbb9b2da9ccefd5c899370) () |
| bool | [CalculateEffectiveLighting](class_tale_worlds_1_1_engine_1_1_scene.html#a32514e65a1149ca3e4e9839b2c91096c) () |
| bool | [GetPathDistanceBetweenPositions](class_tale_worlds_1_1_engine_1_1_scene.html#a8372ed993add2060ad9286675088445f) (ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) point0, ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) point1, float agentRadius, out float pathDistance) |
| bool | [IsLineToPointClear](class_tale_worlds_1_1_engine_1_1_scene.html#afed58cc0641a42821caf83da204b0cce) (ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) destination, float agentRadius) |
| bool | [IsLineToPointClear](class_tale_worlds_1_1_engine_1_1_scene.html#a8ab29de196f7fe2ab6a82430b73bbc8b) (UIntPtr startingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination, float agentRadius) |
| bool | [IsLineToPointClear](class_tale_worlds_1_1_engine_1_1_scene.html#a2157113770782acaf51084cb1ceb988e) (int startingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination, float agentRadius) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLastPointOnNavigationMeshFromPositionToDestination](class_tale_worlds_1_1_engine_1_1_scene.html#a2f166df4406e6de7f2e5d2596870af40) (int startingFace, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination, int[] excludedFaceIds) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetLastPositionOnNavMeshFaceForPointAndDirection](class_tale_worlds_1_1_engine_1_1_scene.html#a8df4a8ee947acace962617954b12540b) ([PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) record, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetLastPointOnNavigationMeshFromWorldPositionToDestination](class_tale_worlds_1_1_engine_1_1_scene.html#a8c373e71706a2c30c40959a612e672d7) (ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) destination) |
| bool | [DoesPathExistBetweenFaces](class_tale_worlds_1_1_engine_1_1_scene.html#ab8147b36d998c6ae4c1b732989c93597) (int firstNavMeshFace, int secondNavMeshFace, bool ignoreDisabled) |
| bool | [GetHeightAtPoint](class_tale_worlds_1_1_engine_1_1_scene.html#a35658c86f177ee33225a3521c4349f24) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags, ref float height) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetNormalAt](class_tale_worlds_1_1_engine_1_1_scene.html#a215b1f026124e48068e39aa377d68964) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| void | [GetEntities](class_tale_worlds_1_1_engine_1_1_scene.html#ad102f0b228b0938a32425698d50d9da6) (ref List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > entities) |
| void | [GetRootEntities](class_tale_worlds_1_1_engine_1_1_scene.html#a5b7f1874db0f55defe01680434a5c20e) (NativeObjectArray entities) |
| int | [SelectEntitiesInBoxWithScriptComponent< T >](class_tale_worlds_1_1_engine_1_1_scene.html#adc6241ef63f8afd35999c16afb347b02) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) boundingBoxMin, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) boundingBoxMax, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html)[] entitiesOutput, UIntPtr[] entityIds) |
| int | [SelectEntitiesCollidedWith](class_tale_worlds_1_1_engine_1_1_scene.html#aad696b80103cb43935ec53fa57d8c078) (ref [Ray](struct_tale_worlds_1_1_library_1_1_ray.html) ray, [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] intersectionsOutput, UIntPtr[] entityIds) |
| bool | [RayCastExcludingTwoEntities](class_tale_worlds_1_1_engine_1_1_scene.html#a9e56a3420ecd42d15d44588d9f3c69d9) ([BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) flags, in [Ray](struct_tale_worlds_1_1_library_1_1_ray.html) ray, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity1, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity2) |
| int | [GenerateContactsWithCapsule](class_tale_worlds_1_1_engine_1_1_scene.html#af9ea92b0a7df0f6711e06ace99f0526d) (ref [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) capsule, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) exclude\_flags, bool isFixedTick, [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] intersectionsOutput, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html)[] gameEntities, UIntPtr[] entityPointers) |
| int | [GenerateContactsWithCapsuleAgainstEntity](class_tale_worlds_1_1_engine_1_1_scene.html#a7bed13b3c69c050f0a27a34e5197ae98) (ref [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) capsule, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeFlags, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity, [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] intersectionsOutput) |
| void | [InvalidateTerrainPhysicsMaterials](class_tale_worlds_1_1_engine_1_1_scene.html#a24981cd7cfae02c2164d6474e2ac17c7) () |
| void | [Read](class_tale_worlds_1_1_engine_1_1_scene.html#a2363355297d38fe6c11d78cc4c90bda4) (string sceneName) |
| void | [Read](class_tale_worlds_1_1_engine_1_1_scene.html#a29eaf0b8b4213cec1421fd8aea43699e) (string sceneName, string moduleId, ref [SceneInitializationData](struct_tale_worlds_1_1_engine_1_1_scene_initialization_data.html) initData, string forcedAtmoName="") |
| void | [Read](class_tale_worlds_1_1_engine_1_1_scene.html#a9b19994877aa85101651508c6ca84ce6) (string sceneName, ref [SceneInitializationData](struct_tale_worlds_1_1_engine_1_1_scene_initialization_data.html) initData, string forcedAtmoName="") |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ReadAndCalculateInitialCamera](class_tale_worlds_1_1_engine_1_1_scene.html#a8055365bf85dee5a2f11ba9f448b1ccf) () |
| void | [OptimizeScene](class_tale_worlds_1_1_engine_1_1_scene.html#a781a1a7842201cab3302e53f095b9081) (bool optimizeFlora=true, bool optimizeOro=false) |
| float | [GetTerrainHeight](class_tale_worlds_1_1_engine_1_1_scene.html#a3edd84a200c18d5ceabaa9772b84b27e) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, bool checkHoles=true) |
| void | [CheckResources](class_tale_worlds_1_1_engine_1_1_scene.html#a2c5973ee67e737c9a54c0976896271a8) (bool checkInvisibleEntities) |
| void | [ForceLoadResources](class_tale_worlds_1_1_engine_1_1_scene.html#a455f32992619acfc46a3d3b18f190def) (bool checkInvisibleEntities) |
| void | [SetDepthOfFieldParameters](class_tale_worlds_1_1_engine_1_1_scene.html#a9f986fa9d016c3311a586758f4bf584b) (float depthOfFieldFocusStart, float depthOfFieldFocusEnd, bool isVignetteOn) |
| void | [SetDepthOfFieldFocus](class_tale_worlds_1_1_engine_1_1_scene.html#acd2edea60d8d480a9f74eb980db301c4) (float depthOfFieldFocus) |
| void | [ResetDepthOfFieldParams](class_tale_worlds_1_1_engine_1_1_scene.html#a2ab8e9d9875fe229da40505fa55e51b7) () |
| void | [PreloadForRendering](class_tale_worlds_1_1_engine_1_1_scene.html#a5ed8196c5ffa15923fb433f006bcaa74) () |
| void | [SetColorGradeBlend](class_tale_worlds_1_1_engine_1_1_scene.html#a5b6a8acbaed9946f7a8fce11a00ddaba) (string texture1, string texture2, float alpha) |
| float | [GetGroundHeightAtPosition](class_tale_worlds_1_1_engine_1_1_scene.html#a1952b4e6f05e2ccc40822b37f7f3cd35) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeFlags=[BodyFlags.CommonCollisionExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aae54cc4731531ae94d358f7102801d5b4)) |
| float | [GetGroundHeightAndBodyFlagsAtPosition](class_tale_worlds_1_1_engine_1_1_scene.html#a038f312a953b97e157a44127f5d6513c) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, out [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) contactPointFlags, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeFlags=[BodyFlags.CommonCollisionExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aae54cc4731531ae94d358f7102801d5b4)) |
| float | [GetGroundHeightAtPosition](class_tale_worlds_1_1_engine_1_1_scene.html#aafeb5fd2bca21b0217298be7bad8d9a6) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) normal, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeFlags=[BodyFlags.CommonCollisionExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aae54cc4731531ae94d358f7102801d5b4)) |
| void | [PauseSceneSounds](class_tale_worlds_1_1_engine_1_1_scene.html#a5a2702c100a77e684542fa234d03427d) () |
| void | [ResumeSceneSounds](class_tale_worlds_1_1_engine_1_1_scene.html#ad805bc4bbea6f2f9b8ab1e7f57a08469) () |
| void | [FinishSceneSounds](class_tale_worlds_1_1_engine_1_1_scene.html#a8f59e58644247f44d7673064ef0efaf4) () |
| bool | [BoxCastOnlyForCamera](class_tale_worlds_1_1_engine_1_1_scene.html#a92ad8c2347051b95ea1c42eeb512a805) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] boxPoints, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) centerPoint, bool castSupportRay, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) supportRaycastPoint, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) dir, float distance, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) ignoredEntity, out float collisionDistance, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) closestPoint, out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) collidedEntity, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludedBodyFlags=[BodyFlags.CameraCollisionRayCastExludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aa1d89464bebbfb608ed2308a739149600)|[BodyFlags.DontCollideWithCamera](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aa09d20b41cb853019e78b838387db28ed)) |
| bool | [BoxCast](class_tale_worlds_1_1_engine_1_1_scene.html#a0327cf5007505b1d49b282fd0562e2df) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) boxMin, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) boxMax, bool castSupportRay, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) supportRaycastPoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) dir, float distance, out float collisionDistance, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) closestPoint, out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) collidedEntity, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludedBodyFlags=[BodyFlags.CameraCollisionRayCastExludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aa1d89464bebbfb608ed2308a739149600)) |
| bool | [RayCastForClosestEntityOrTerrain](class_tale_worlds_1_1_engine_1_1_scene.html#a43b3fb1ed1b7634a43c906d90dfdda79) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, out float collisionDistance, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) closestPoint, out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) collidedEntity, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| bool | [RayCastForClosestEntityOrTerrainFixedPhysics](class_tale_worlds_1_1_engine_1_1_scene.html#aba717c33e5e021a9be5a8b3b0946b7bf) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, out float collisionDistance, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) closestPoint, out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) collidedEntity, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| bool | [FocusRayCastForFixedPhysics](class_tale_worlds_1_1_engine_1_1_scene.html#a5664f829d1a50eaea2100f682c4160de) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, out float collisionDistance, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) closestPoint, out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) collidedEntity, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| bool | [RayCastForClosestEntityOrTerrain](class_tale_worlds_1_1_engine_1_1_scene.html#a3102342131788e68fbd2861eaef99e23) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, out float collisionDistance, out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) collidedEntity, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| bool | [RayCastForClosestEntityOrTerrainFixedPhysics](class_tale_worlds_1_1_engine_1_1_scene.html#aff294dcd84367913e083bb8a25c8cab1) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, out float collisionDistance, out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) collidedEntity, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| bool | [RayCastForRamming](class_tale_worlds_1_1_engine_1_1_scene.html#ade53db5cb2d90e86a0f2b1cc929903b2) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) ignoredEntity, float rayThickness, out float collisionDistance, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) intersectionPoint, out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) collidedEntity, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2), [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) includeBodyFlags=[BodyFlags.None](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aa6adf97f83acf6453d4a6a4b1070f3754)) |
| bool | [RayCastForClosestEntityOrTerrainIgnoreEntity](class_tale_worlds_1_1_engine_1_1_scene.html#af21462d6f242b397932ad4f4641ef08d) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) ignoredEntity, out float collisionDistance, out [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) collidedEntity, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| bool | [RayCastForClosestEntityOrTerrain](class_tale_worlds_1_1_engine_1_1_scene.html#a2de14cc1384b167aed9c17626122ce0d) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, out float collisionDistance, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) closestPoint, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| bool | [RayCastForClosestEntityOrTerrainFixedPhysics](class_tale_worlds_1_1_engine_1_1_scene.html#a7b0216a6a4a17bd6d72898368e823319) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, out float collisionDistance, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) closestPoint, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| bool | [RayCastForClosestEntityOrTerrainFixedPhysics](class_tale_worlds_1_1_engine_1_1_scene.html#a04c0866857540ebbb9f274bd5f09adc9) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, out float collisionDistance, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| bool | [RayCastForClosestEntityOrTerrain](class_tale_worlds_1_1_engine_1_1_scene.html#af3697e8cd9178e02ae469cb74a9bb1b6) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, out float collisionDistance, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| void | [ImportNavigationMeshPrefab](class_tale_worlds_1_1_engine_1_1_scene.html#aff576a825633906c641ed0237a3a3841) (string navMeshPrefabName, int navMeshGroupShift) |
| void | [ImportNavigationMeshPrefabWithFrame](class_tale_worlds_1_1_engine_1_1_scene.html#a7ba5ebdab50db8a811e20817afab5232) (string navMeshPrefabName, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [SaveNavMeshPrefabWithFrame](class_tale_worlds_1_1_engine_1_1_scene.html#a300e330b9e7f75da6c742ebc9ca35a4c) (string navMeshPrefabName, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [SetNavMeshRegionMap](class_tale_worlds_1_1_engine_1_1_scene.html#a85e87e6961f34924d7af28cf3bdd6435) (bool[] regionMap) |
| void | [MarkFacesWithIdAsLadder](class_tale_worlds_1_1_engine_1_1_scene.html#aef51b40aa186c7612d6f52c55055fd2e) (int faceGroupId, bool isLadder) |
| int | [SetAbilityOfFacesWithId](class_tale_worlds_1_1_engine_1_1_scene.html#ae748ef35e94ea94aa589365055c30989) (int faceGroupId, bool isEnabled) |
| bool | [SwapFaceConnectionsWithID](class_tale_worlds_1_1_engine_1_1_scene.html#a9586bd09372031ac1648e2e99c37c072) (int hubFaceGroupID, int toBeSeparatedFaceGroupId, int toBeMergedFaceGroupId, bool canFail) |
| void | [MergeFacesWithId](class_tale_worlds_1_1_engine_1_1_scene.html#a7defadfe0d588783bdbe8cc2430405cd) (int faceGroupId0, int faceGroupId1, int newFaceGroupId) |
| void | [SeparateFacesWithId](class_tale_worlds_1_1_engine_1_1_scene.html#a2f56a4182d48f01307c37e7331de3dbd) (int faceGroupId0, int faceGroupId1) |
| bool | [IsAnyFaceWithId](class_tale_worlds_1_1_engine_1_1_scene.html#a59aacb76e1deac6ed67630e153fda928) (int faceGroupId) |
| UIntPtr | [GetNavigationMeshForPosition](class_tale_worlds_1_1_engine_1_1_scene.html#a9b9cf24d5b8f9cb2e97b34b88f9674d7) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| UIntPtr | [GetNearestNavigationMeshForPosition](class_tale_worlds_1_1_engine_1_1_scene.html#a3939f3b225d606ed947ffbb4e0122513) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, float heightDifferenceLimit, bool excludeDynamicNavigationMeshes) |
| UIntPtr | [GetNavigationMeshForPosition](class_tale_worlds_1_1_engine_1_1_scene.html#a65eb58521e21003083f7fa586c6d3213) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, out int faceGroupId, float heightDifferenceLimit, bool excludeDynamicNavigationMeshes) |
| bool | [DoesPathExistBetweenPositions](class_tale_worlds_1_1_engine_1_1_scene.html#a46ed98563610ce97bf057bb0f0f0ffb2) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) position, [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) destination) |
| void | [SetLandscapeRainMaskData](class_tale_worlds_1_1_engine_1_1_scene.html#aad984e2ddec9ba3b56b9472518f75465) (byte[] data) |
| void | [EnsurePostfxSystem](class_tale_worlds_1_1_engine_1_1_scene.html#a1075278a6cb95c9757acb92cc2bfa602) () |
| void | [SetBloom](class_tale_worlds_1_1_engine_1_1_scene.html#a4cd4e3aed7b01709190fe2a44951083f) (bool mode) |
| void | [SetDofMode](class_tale_worlds_1_1_engine_1_1_scene.html#af4672985566ff19b88969663a8b94097) (bool mode) |
| void | [SetOcclusionMode](class_tale_worlds_1_1_engine_1_1_scene.html#a51c33c4660026dbb7ebd6fd26f63c1c2) (bool mode) |
| void | [SetExternalInjectionTexture](class_tale_worlds_1_1_engine_1_1_scene.html#a18e128aa3d8f4472d2732bb7c28c2188) ([Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture) |
| void | [SetSunshaftMode](class_tale_worlds_1_1_engine_1_1_scene.html#a9cd68731fd4b6db9ecb0db24229a1f23) (bool mode) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetSunDirection](class_tale_worlds_1_1_engine_1_1_scene.html#a72b1d440cfc0153eca8b51cbd82f84cb) () |
| float | [GetNorthAngle](class_tale_worlds_1_1_engine_1_1_scene.html#a03729182be787a75d4dc2c3a44e73280) () |
| float | [GetNorthRotation](class_tale_worlds_1_1_engine_1_1_scene.html#a41e8a3373dacd41a9bd572f9422ae0cd) () |
|  | Returns north angle as a counter-clock wise rotation in radians. |
| bool | [GetTerrainMinMaxHeight](class_tale_worlds_1_1_engine_1_1_scene.html#abd62d06bb47d9e5cd2a4bbf98f776431) (out float minHeight, out float maxHeight) |
| void | [GetPhysicsMinMax](class_tale_worlds_1_1_engine_1_1_scene.html#a99858390653dc19b6dfd7238355ea192) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) min\_max) |
| bool | [IsEditorScene](class_tale_worlds_1_1_engine_1_1_scene.html#ab4464ee831c19aa699c6a27ad91686dd) () |
| void | [SetMotionBlurMode](class_tale_worlds_1_1_engine_1_1_scene.html#a4f02cd0c698df2721c8b553f9f275c78) (bool mode) |
| void | [SetAntialiasingMode](class_tale_worlds_1_1_engine_1_1_scene.html#a9ca3c41c5dfd4e6851141e301bc69642) (bool mode) |
| void | [SetDLSSMode](class_tale_worlds_1_1_engine_1_1_scene.html#a129938460c3800aec2bbbcc95a017bfd) (bool mode) |
| IEnumerable< [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) > | [FindWeakEntitiesWithTag](class_tale_worlds_1_1_engine_1_1_scene.html#ac64eb8e8bd53a88550d99623771e69f5) (string tag) |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [FindWeakEntityWithTag](class_tale_worlds_1_1_engine_1_1_scene.html#a5ad492c3a7db400b2d29b55beabb546b) (string tag) |
| IEnumerable< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [FindEntitiesWithTag](class_tale_worlds_1_1_engine_1_1_scene.html#af985949737ae228136bbeb601cecb59d) (string tag) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [FindEntityWithTag](class_tale_worlds_1_1_engine_1_1_scene.html#ac96fcd62779f00c260d1f09a3ad01f11) (string tag) |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [FindEntityWithName](class_tale_worlds_1_1_engine_1_1_scene.html#aa3249e43d2a11175753c287892c512b4) (string name) |
| IEnumerable< [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) > | [FindWeakEntitiesWithTagExpression](class_tale_worlds_1_1_engine_1_1_scene.html#a5e7f867ff1e3df4bb8def05075b375d5) (string expression) |
| IEnumerable< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | [FindEntitiesWithTagExpression](class_tale_worlds_1_1_engine_1_1_scene.html#aa7fcfd0cc4a5f36f73a18ea1fc4f9f50) (string expression) |
| int | [GetSoftBoundaryVertexCount](class_tale_worlds_1_1_engine_1_1_scene.html#a6e5ffb57cf433f8990b8e8a9abf59d9c) () |
| int | [GetHardBoundaryVertexCount](class_tale_worlds_1_1_engine_1_1_scene.html#acc74452b21094ec9dfd0c17b5800cb19) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetSoftBoundaryVertex](class_tale_worlds_1_1_engine_1_1_scene.html#a33400563a3bad8c6ec2150a55bff77fd) (int index) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetHardBoundaryVertex](class_tale_worlds_1_1_engine_1_1_scene.html#a40e7615a007ee62f701e91d47571b90f) (int index) |
| [Path](class_tale_worlds_1_1_engine_1_1_path.html) | [GetPathWithName](class_tale_worlds_1_1_engine_1_1_scene.html#ab67d3291bc9ddc817c99cac6a5fa8fcd) (string name) |
| void | [DeletePathWithName](class_tale_worlds_1_1_engine_1_1_scene.html#a714b0f240cc8eb8a799cf781f9dc8b0b) (string name) |
| void | [AddPath](class_tale_worlds_1_1_engine_1_1_scene.html#a67281737b0e562102ba6f4b66c988407) (string name) |
| void | [AddPathPoint](class_tale_worlds_1_1_engine_1_1_scene.html#a8e6fe6ec5c3bf2e1b754b957f6f1eceb) (string name, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [GetBoundingBox](class_tale_worlds_1_1_engine_1_1_scene.html#ad89f74489e02f1966649cb9e693dbd49) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) min, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) max) |
| void | [GetSceneLimits](class_tale_worlds_1_1_engine_1_1_scene.html#ad95899767c6121a5285d3af175ba5ed9) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) min, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) max) |
| void | [SetName](class_tale_worlds_1_1_engine_1_1_scene.html#a6a75dd6311fab1e164de76e40927df87) (string name) |
| string | [GetName](class_tale_worlds_1_1_engine_1_1_scene.html#a4db7c88bc50f78ce21b37fa21ca000b1) () |
| string | [GetModulePath](class_tale_worlds_1_1_engine_1_1_scene.html#adbd9b737e2ccd5338001642fa53d8d95) () |
| void | [SetOwnerThread](class_tale_worlds_1_1_engine_1_1_scene.html#a39e9ec4f6537719247bc7dbe704c8231) () |
| [Path](class_tale_worlds_1_1_engine_1_1_path.html)[] | [GetPathsWithNamePrefix](class_tale_worlds_1_1_engine_1_1_scene.html#a3e3437508f076ffd9539dbc6e5a8fe15) (string prefix) |
| void | [SetUseConstantTime](class_tale_worlds_1_1_engine_1_1_scene.html#a85dabb3cac4c9da528eb9699b2022373) (bool value) |
| bool | [CheckPointCanSeePoint](class_tale_worlds_1_1_engine_1_1_scene.html#a5277551ea5ca7814f7ee43356646d63d) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) source, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) target, float? distanceToCheck=null) |
| void | [SetPlaySoundEventsAfterReadyToRender](class_tale_worlds_1_1_engine_1_1_scene.html#a02faf7d8b7b75111a0532b88d94e6c3b) (bool value) |
| void | [DisableStaticShadows](class_tale_worlds_1_1_engine_1_1_scene.html#a5223a73bf3bac13e8d33fe109f22f645) (bool value) |
| [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | [GetSkyboxMesh](class_tale_worlds_1_1_engine_1_1_scene.html#a007625a8be0286c3f9171eefa7ef377a) () |
| void | [SetAtmosphereWithName](class_tale_worlds_1_1_engine_1_1_scene.html#ac80b623b85fec8e2c84f7e03f0657ede) (string name) |
| void | [FillEntityWithHardBorderPhysicsBarrier](class_tale_worlds_1_1_engine_1_1_scene.html#a5a083ec01763803ea0f7c5fbbf4e850b) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
| void | [ClearDecals](class_tale_worlds_1_1_engine_1_1_scene.html#a93fd5ca09a53c661beb4575932341ecf) () |
| void | [SetPhotoAtmosphereViaTod](class_tale_worlds_1_1_engine_1_1_scene.html#a1b07510d39d92d1a2d1e5e63dac45ba8) (float tod, bool withStorm) |
| bool | [IsPositionOnADynamicNavMesh](class_tale_worlds_1_1_engine_1_1_scene.html#a8efa35f078be1494f61f054b47901758) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| void | [WaitWaterRendererCPUSimulation](class_tale_worlds_1_1_engine_1_1_scene.html#a3c0074d37d9629180ea2520ff24c9f38) () |
| void | [EnableInclusiveAsyncPhysx](class_tale_worlds_1_1_engine_1_1_scene.html#acb2b407a5454e8ad86131ff768ba6600) () |
| void | [EnsureWaterWakeRenderer](class_tale_worlds_1_1_engine_1_1_scene.html#aa957a4c93d47b2b3d04942a408b283bf) () |
| void | [DeleteWaterWakeRenderer](class_tale_worlds_1_1_engine_1_1_scene.html#a306ae16dba52eab1878385c8bfb6cfc0) () |
| bool | [SceneHadWaterWakeRenderer](class_tale_worlds_1_1_engine_1_1_scene.html#a7661fb1594f0b5656d7a0976593e7576) () |
| void | [SetWaterWakeWorldSize](class_tale_worlds_1_1_engine_1_1_scene.html#ad4309c2708e43c4b4c5502a070f70930) (float worldSize, float eraseFactor) |
| void | [SetWaterWakeCameraOffset](class_tale_worlds_1_1_engine_1_1_scene.html#af87b5af6626714c19538cf6fe7ea163f) (float cameraOffset) |
| void | [TickWake](class_tale_worlds_1_1_engine_1_1_scene.html#a116cc787114e177369aa5bdae56b89b6) (float dt) |
| void | [SetDoNotAddEntitiesToTickList](class_tale_worlds_1_1_engine_1_1_scene.html#ac88844f3db29640431caa7d57b9c49fd) (bool value) |
| void | [SetDontLoadInvisibleEntities](class_tale_worlds_1_1_engine_1_1_scene.html#acf0840a1897898ab2d821d4660570a0d) (bool value) |
| void | [SetUsesDeleteLaterSystem](class_tale_worlds_1_1_engine_1_1_scene.html#a21e634e927a7579f327b7905da6ac385) (bool value) |
| void | [ClearCurrentFrameTickEntities](class_tale_worlds_1_1_engine_1_1_scene.html#a34277f94b9f6aa0b2f0c5bb8bed8bf58) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [FindClosestExitPositionForPositionOnABoundaryFace](class_tale_worlds_1_1_engine_1_1_scene.html#ad3eb0ad842e6e817b833a75fe8244084) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, UIntPtr boundaryFacePointer) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Scene | [CreateNewScene](class_tale_worlds_1_1_engine_1_1_scene.html#a9ccac8cd05cd6c87b8e5ef51e7b2a1c7) (bool initialize\_physics=true, bool enable\_decals=true, [DecalAtlasGroup](namespace_tale_worlds_1_1_engine.html#a4e991dea1484f83dd32afa4020ec8bef) atlasGroup=0, string sceneName="mono\_renderscene") |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static float | [MaximumWindSpeed](class_tale_worlds_1_1_engine_1_1_scene.html#a1d86b6dc82051eea52b0b0874048d544) = 30.0f |
| const float | [AutoClimbHeight](class_tale_worlds_1_1_engine_1_1_scene.html#a59e02243cfdd26b54ac41f767dffde3e) = 1.5f |
| const float | [NavMeshHeightLimit](class_tale_worlds_1_1_engine_1_1_scene.html#aa7038b244d0b300d03eeb84cc0e7948c) = 1.5f |
| const int | [SunRise](class_tale_worlds_1_1_engine_1_1_scene.html#ad9e50ed0fe213820b1a3d4baee263235) = 2 |
| const int | [SunSet](class_tale_worlds_1_1_engine_1_1_scene.html#a038bbeea496de24944aaa01d60dd7d7e) = 22 |
| static readonly [TWSharedMutex](class_tale_worlds_1_1_library_1_1_t_w_shared_mutex.html) | [PhysicsAndRayCastLock](class_tale_worlds_1_1_engine_1_1_scene.html#a962e2b7b1b80283d875087603f736caf) = new [TWSharedMutex](class_tale_worlds_1_1_library_1_1_t_w_shared_mutex.html)() |

|  |  |
| --- | --- |
| Properties | |
| int | [RootEntityCount](class_tale_worlds_1_1_engine_1_1_scene.html#ab0907fdc363d57e9f35f7a6f73732fca) `[get]` |
| bool | [HasTerrainHeightmap](class_tale_worlds_1_1_engine_1_1_scene.html#a3803337257fe9ccff3633a24fbf29218) `[get]` |
| bool | [ContainsTerrain](class_tale_worlds_1_1_engine_1_1_scene.html#a8b637cd9d9cc19c46dd40540011f3c13) `[get]` |
| float | [TimeOfDay](class_tale_worlds_1_1_engine_1_1_scene.html#a7c94482fe3d29dc8ec4fb916d6d85e21) `[get, set]` |
| bool | [IsDayTime](class_tale_worlds_1_1_engine_1_1_scene.html#a58414c9a5b6b77604298af9ca9d44878) `[get]` |
| bool | [IsAtmosphereIndoor](class_tale_worlds_1_1_engine_1_1_scene.html#ad956c05f0ca25631cc9c5ef5e4a538b4) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [LastFinalRenderCameraPosition](class_tale_worlds_1_1_engine_1_1_scene.html#a4b0bc340b6cf1c07247d3e5a8223d541) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [LastFinalRenderCameraFrame](class_tale_worlds_1_1_engine_1_1_scene.html#a8bd97b933b3a7fa4f3ccd57353ab5955) `[get]` |
| float | [TimeSpeed](class_tale_worlds_1_1_engine_1_1_scene.html#a22d10f5d49aa93597a86d87e647f24b7) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5897c4e5ba028f78c52d1783f149bdea)IsDefaultEditorScene()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.IsDefaultEditorScene | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa233efdd21694071f8b8dc2a0c336bdf)IsMultiplayerScene()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.IsMultiplayerScene | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a472e6fde9f7417dd2d3eef487eebee72)TakePhotoModePicture()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| string TaleWorlds.Engine.Scene.TakePhotoModePicture | ( | bool | *saveAmbientOcclusionPass*, |
|  |  | bool | *savingObjectIdPass*, |
|  |  | bool | *saveShadowPass* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8623577bebd2c97181d93ea1867b1f8c)GetAllColorGradeNames()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.Scene.GetAllColorGradeNames | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7951dc009d78c9192d2043284d444e6c)GetAllFilterNames()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.Scene.GetAllFilterNames | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7813f6bdcbf515ab5195b80819ac952b)GetPhotoModeRoll()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetPhotoModeRoll | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7b5425bcfe7e653fdbd0fcd5e02a4856)GetPhotoModeOrbit()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetPhotoModeOrbit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a709dcb8b06540b04a20b826d7d322610)GetPhotoModeOn()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetPhotoModeOn | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a1153e896b2cb27daf13d99c97e2eabcf)GetPhotoModeFocus()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetPhotoModeFocus | ( | ref float | *focus*, |
|  |  | ref float | *focusStart*, |
|  |  | ref float | *focusEnd*, |
|  |  | ref float | *exposure*, |
|  |  | ref bool | *vignetteOn* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a58ba6499304dc3844466c41d6d9c9ce1)GetSceneColorGradeIndex()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetSceneColorGradeIndex | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a465859867dd3a882159c7ce5f3cf2cb3)GetSceneFilterIndex()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetSceneFilterIndex | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a36d94a925c0e28942aa309f150e61883)EnableFixedTick()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.EnableFixedTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa49187f7ecc3de980b09af9719f9a7e4)GetLoadingStateName()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.Scene.GetLoadingStateName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2f3ca9bc9fefdb96b1fb46e0cd244c31)IsLoadingFinished()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.IsLoadingFinished | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2f6c647b74d7dcb4f85901edaafef6c2)SetPhotoModeRoll()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetPhotoModeRoll | ( | float | *roll* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a4fc6bf2d935397ae252649c4313b7c0c)SetPhotoModeOrbit()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetPhotoModeOrbit | ( | bool | *orbit* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aabd1f0d8272b3c2ee257cf75eccb36ef)GetFallDensity()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetFallDensity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#adf744006b1fb20af5a9c3e071fc7e871)SetPhotoModeOn()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetPhotoModeOn | ( | bool | *on* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af723138381dbfd85bf3db98db846e677)SetPhotoModeFocus()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetPhotoModeFocus | ( | float | *focusStart*, |
|  |  | float | *focusEnd*, |
|  |  | float | *focus*, |
|  |  | float | *exposure* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a09c2708fd4601786458c9742ee4a281f)SetPhotoModeFov()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetPhotoModeFov | ( | float | *verticalFov* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a376161666c12dafc30ffd9ec3a41b90c)GetPhotoModeFov()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetPhotoModeFov | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a88d91062cb1dfc50a3509bd36b20dced)HasDecalRenderer()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.HasDecalRenderer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a72ba5a2d4b14d00b70933e4a9ae2b586)SetPhotoModeVignette()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetPhotoModeVignette | ( | bool | *vignetteOn* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7b1c8dcea30d72723b65b1132d09ce26)SetSceneColorGradeIndex()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSceneColorGradeIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#abcf0512da100890827863ada35313e0d)SetSceneFilterIndex()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.SetSceneFilterIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a1a777273686556715736519518687405)SetSceneColorGrade() [1/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSceneColorGrade | ( | string | *textureName* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8de7cd738f41dcf6cc57cca4e290ca76)SetUpgradeLevel()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetUpgradeLevel | ( | int | *level* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9629c31a81f0cc17e20dd364b2f063ba)CreateBurstParticle()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.CreateBurstParticle | ( | int | *particleId*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ade5563f78443276a277b8d9f4652ca09)GetTerrainHeightData()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float[] TaleWorlds.Engine.Scene.GetTerrainHeightData | ( | int | *nodeXIndex*, |
|  |  | int | *nodeYIndex* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a28dbe6604f58ff097f3d002d33b53ea3)GetTerrainPhysicsMaterialIndexData()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| short[] TaleWorlds.Engine.Scene.GetTerrainPhysicsMaterialIndexData | ( | int | *nodeXIndex*, |
|  |  | int | *nodeYIndex* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a28031d16a9c4b8f1a997acf82dff4ad7)GetTerrainData()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetTerrainData | ( | out [Vec2i](struct_tale_worlds_1_1_library_1_1_vec2i.html) | *nodeDimension*, |
|  |  | out float | *nodeSize*, |
|  |  | out int | *layerCount*, |
|  |  | out int | *layerVersion* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2f31a35eb067e82e94c3b85a8e0bd2bd)GetTerrainNodeData()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetTerrainNodeData | ( | int | *xIndex*, |
|  |  | int | *yIndex*, |
|  |  | out int | *vertexCountAlongAxis*, |
|  |  | out float | *quadLength*, |
|  |  | out float | *minHeight*, |
|  |  | out float | *maxHeight* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a47023c3f7f2a1ec25b479a053547e990)GetTerrainPhysicsMaterialAtLayer()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) TaleWorlds.Engine.Scene.GetTerrainPhysicsMaterialAtLayer | ( | int | *layerIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a357b6accc41752570750ef976e2bf93d)SetSceneColorGrade() [2/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSceneColorGrade | ( | Scene | *scene*, |
|  |  | string | *textureName* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a6d835d147be526cc77895610fbe52fc6)GetWaterLevel()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetWaterLevel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a17044e3ff8e7f1a90270ff4a3165cec0)GetWaterLevelAtPosition()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetWaterLevelAtPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | bool | *useWaterRenderer*, |
|  |  | bool | *checkWaterBodyEntities* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#abdc1c1bb0ec63df18d7c9017e70d6183)GetWaterSpeedAtPosition()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Scene.GetWaterSpeedAtPosition | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | bool | *doChoppinessCorrection* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a567198b5d3d333a2af56c39fcdcce3ab)GetBulkWaterLevelAtPositions()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetBulkWaterLevelAtPositions | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)[] | *waterHeightQueryArray*, |
|  |  | ref float[] | *waterHeightsAtVolumes*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] | *waterSurfaceNormals* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9c71f47e503a8ba0852157a736275126)GetInterpolationFactorForBodyWorldTransformSmoothing()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetInterpolationFactorForBodyWorldTransformSmoothing | ( | out float | *interpolationFactor*, |
|  |  | out float | *fixedDt* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9b65313499d3c1976659df012ade4cf3)GetBulkWaterLevelAtVolumes()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetBulkWaterLevelAtVolumes | ( | UIntPtr | *waterHeightQueryArray*, |
|  |  | int | *waterHeightQueryArrayCount*, |
|  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *globalFrame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9b176da3d1c00bbe1563b37d14e6207b)GetWaterStrength()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetWaterStrength | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af6268eecbf17ac7fb7dc0a38d2509fe0)DeRegisterShipVisual()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.DeRegisterShipVisual | ( | UIntPtr | *visualPointer* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ab13ed483217bb72a996934bacc9f1039)RegisterShipVisualToWaterRenderer()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| UIntPtr TaleWorlds.Engine.Scene.RegisterShipVisualToWaterRenderer | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *waterEffectBB* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae5001ef524f10d56726dfdae7c0f913b)SetWaterStrength()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetWaterStrength | ( | float | *newWaterStrength* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a847fd9c0966466e8687fd5dabaa97fda)AddWaterWakeWithSphere()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.AddWaterWakeWithSphere | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | float | *radius*, |
|  |  | float | *wakeVisibility*, |
|  |  | float | *foamVisibility* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad14edabf816e8ee63a9856a5412bec84)AddWaterWakeWithCapsule()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.AddWaterWakeWithCapsule | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *positionA*, |
|  |  | float | *radiusA*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *positionB*, |
|  |  | float | *radiusB*, |
|  |  | float | *wakeVisibility*, |
|  |  | float | *foamVisibility* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad868aa8a53f7290805a4d352e15adbe5)GetPathBetweenAIFaces() [1/4]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetPathBetweenAIFaces | ( | UIntPtr | *startingFace*, |
|  |  | UIntPtr | *endingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *startingPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *endingPosition*, |
|  |  | float | *agentRadius*, |
|  |  | [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) | *path*, |
|  |  | int[] | *excludedFaceIds* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae21cca4fd47211b06e4b5510a5a12179)HasNavmeshFaceUnsharedEdges()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.HasNavmeshFaceUnsharedEdges | ( | in [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *faceRecord* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a25e180365de0dfe5f64c6c4ff6435689)GetNavmeshFaceCountBetweenTwoIds()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetNavmeshFaceCountBetweenTwoIds | ( | int | *firstId*, |
|  |  | int | *secondId* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a854f086754989dcc68fe3c8141011046)GetNavmeshFaceRecordsBetweenTwoIds()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetNavmeshFaceRecordsBetweenTwoIds | ( | int | *firstId*, |
|  |  | int | *secondId*, |
|  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html)[] | *faceRecords* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a70d5930a923be2dbb956a97cbc02a58c)SetFixedTickCallbackActive()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetFixedTickCallbackActive | ( | bool | *isActive* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3f0f85578f5eee4caab7dd47a07154df)SetOnCollisionFilterCallbackActive()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetOnCollisionFilterCallbackActive | ( | bool | *isActive* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aff26935405d7bbbeec853058c47b0b02)GetPathBetweenAIFaces() [2/4]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetPathBetweenAIFaces | ( | UIntPtr | *startingFace*, |
|  |  | UIntPtr | *endingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *startingPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *endingPosition*, |
|  |  | float | *agentRadius*, |
|  |  | [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) | *path*, |
|  |  | int[] | *excludedFaceIds*, |
|  |  | int | *regionSwitchCostTo0*, |
|  |  | int | *regionSwitchCostTo1* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9fc31b93004aa87fb47c6417c3d33ffe)GetPathBetweenAIFaces() [3/4]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetPathBetweenAIFaces | ( | int | *startingFace*, |
|  |  | int | *endingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *startingPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *endingPosition*, |
|  |  | float | *agentRadius*, |
|  |  | [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) | *path*, |
|  |  | int[] | *excludedFaceIds*, |
|  |  | float | *extraCostMultiplier* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aaa8df00d33ed0f502c24a8056fee192b)GetPathBetweenAIFaces() [4/4]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetPathBetweenAIFaces | ( | int | *startingFace*, |
|  |  | int | *endingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *startingPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *endingPosition*, |
|  |  | float | *agentRadius*, |
|  |  | [NavigationPath](class_tale_worlds_1_1_library_1_1_navigation_path.html) | *path*, |
|  |  | int[] | *excludedFaceIds*, |
|  |  | float | *extraCostMultiplier*, |
|  |  | int | *regionSwitchCostTo0*, |
|  |  | int | *regionSwitchCostTo1* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#acfd2dbf3f2e2372542864f332843630c)GetPathDistanceBetweenAIFaces()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetPathDistanceBetweenAIFaces | ( | int | *startingAiFace*, |
|  |  | int | *endingAiFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *startingPosition*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *endingPosition*, |
|  |  | float | *agentRadius*, |
|  |  | float | *distanceLimit*, |
|  |  | out float | *distance*, |
|  |  | int[] | *excludedFaceIds*, |
|  |  | int | *regionSwitchCostTo0*, |
|  |  | int | *regionSwitchCostTo1* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad421a3b83a4e5282530f62850e1c7d0f)GetNavMeshFaceIndex() [1/2]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetNavMeshFaceIndex | ( | ref [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *record*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | bool | *isRegion1*, |
|  |  | bool | *checkIfDisabled*, |
|  |  | bool | *ignoreHeight* = false ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a61c1d56ed351178b1c4a914175770a17)GetNavMeshFaceIndex() [2/2]
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetNavMeshFaceIndex | ( | ref [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *record*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | bool | *checkIfDisabled* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9ccac8cd05cd6c87b8e5ef51e7b2a1c7)CreateNewScene()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Scene TaleWorlds.Engine.Scene.CreateNewScene | ( | bool | *initialize\_physics* = true, | |  |  | bool | *enable\_decals* = true, | |  |  | [DecalAtlasGroup](namespace_tale_worlds_1_1_engine.html#a4e991dea1484f83dd32afa4020ec8bef) | *atlasGroup* = 0, | |  |  | string | *sceneName* = "mono\_renderscene" ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3a5919722baabdcf60c0b833e4a28262)AddAlwaysRenderedSkeleton()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.AddAlwaysRenderedSkeleton | ( | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a75e2cb3ced6d0f36a64ae0fb2f684828)RemoveAlwaysRenderedSkeleton()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.RemoveAlwaysRenderedSkeleton | ( | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad1611e2b9c1999066deddcc2a82d3320)CreatePathMesh() [1/2]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.Engine.Scene.CreatePathMesh | ( | string | *baseEntityName*, |
|  |  | bool | *isWaterPath* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#afe006be7535fa4fc7e94bea36761f483)SetActiveVisibilityLevels()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetActiveVisibilityLevels | ( | List< String > | *levelsToActivate* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9bce61755158ad39d188982f34c12959)SetDoNotWaitForLoadingStatesToRender()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDoNotWaitForLoadingStatesToRender | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aedaad80cdd452e093234f68737b9cb6b)SetDynamicSnowTexture()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDynamicSnowTexture | ( | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *texture* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a66e6e09e7211af48b6df986d2368101e)GetWindFlowMapData()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetWindFlowMapData | ( | float[] | *flowMapData* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a0938607e2f38ecb1820fd1fa58747ed5)CreateDynamicRainTexture()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.CreateDynamicRainTexture | ( | int | *w*, |
|  |  | int | *h* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a655e485942c0eebeebf0ddf145ed279a)CreatePathMesh() [2/2]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) TaleWorlds.Engine.Scene.CreatePathMesh | ( | IList< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *pathNodes*, |
|  |  | bool | *isWaterPath* = false ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#addfdbeb2acf2cabbdf0a5db0e4fcdfe5)GetEntityWithGuid()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.Engine.Scene.GetEntityWithGuid | ( | string | *guid* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a426264de0956b0acac3b81f101de22f1)IsEntityFrameChanged()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.IsEntityFrameChanged | ( | string | *containsName* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | containsName | Only entities whose name contains this string will be checked |

Returns
:   `true` if any of the entities' frame has changed; otherwise, `false`.

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a806bcc4b7fcff1f74286d1fc53d0999d)GetTerrainHeightAndNormal()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetTerrainHeightAndNormal | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | out float | *height*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *normal* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae86076b7c0214ad20fc5ea54a3ecfd0a)GetFloraInstanceCount()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetFloraInstanceCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#abc8619bbc907680f2ced7f439ac4d45d)GetFloraRendererTextureUsage()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetFloraRendererTextureUsage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a4ea9d31b5de2b09631ed71a91212423e)GetTerrainMemoryUsage()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetTerrainMemoryUsage | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a647204dbfbae7a43744e0f50095f3996)SetFetchCrcInfoOfScene()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetFetchCrcInfoOfScene | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae92214b4713ea61197f28095057e6b82)GetSceneXMLCRC()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.Scene.GetSceneXMLCRC | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae699da3585144d765972eaa7888db3b3)GetNavigationMeshCRC()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.Scene.GetNavigationMeshCRC | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a592949572dc653eed326bef085f0cbbe)SetGlobalWindStrengthVector()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetGlobalWindStrengthVector | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *windVector* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa4298830ad8c8959556e6f413c1ac697)GetGlobalWindStrengthVector()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.Scene.GetGlobalWindStrengthVector | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9c38d92cf237148c7d327b457e563baa)GetGlobalWindVelocity()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.Scene.GetGlobalWindVelocity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8960849a8b92ced3e36141731e4893ee)SetGlobalWindVelocity()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetGlobalWindVelocity | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *windVector* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8300f527e8abbef9925894ec1dd56e2c)GetEnginePhysicsEnabled()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetEnginePhysicsEnabled | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa6175671d2a72f2325e89da781c8ccff)ClearNavMesh()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.ClearNavMesh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a405e657d26b8d1a69c804ba2229d4900)StallLoadingRenderingsUntilFurtherNotice()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.StallLoadingRenderingsUntilFurtherNotice | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3528efcd6afd59619bab43076d6ee968)GetNavMeshFaceCount()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetNavMeshFaceCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#abe32900592669b66d2fee802eef5f97d)ResumeLoadingRenderings()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.ResumeLoadingRenderings | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aab6a3eb06f0121cc56291269f5941323)GetUpgradeLevelMask()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.Scene.GetUpgradeLevelMask | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a084d0b18607e80aa1000d219a8d869e1)SetUpgradeLevelVisibility() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetUpgradeLevelVisibility | ( | uint | *mask* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa609c584e1ba69897d49477e814afed3)SetUpgradeLevelVisibility() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetUpgradeLevelVisibility | ( | List< string > | *levels* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ab2cddc48a4cee5f3599a0750e819fb70)GetIdOfNavMeshFace()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetIdOfNavMeshFace | ( | int | *faceIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a12822106e745f88ea0075672b5ccca4a)SetClothSimulationState()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetClothSimulationState | ( | bool | *state* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa7b25f654f5c0826d4529b4e5afeda0c)GetNavMeshCenterPosition()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetNavMeshCenterPosition | ( | int | *faceIndex*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *centerPosition* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#afbf748a275e4c59884b214843eda2a66)GetNavMeshPathFaceRecord()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) TaleWorlds.Engine.Scene.GetNavMeshPathFaceRecord | ( | int | *faceIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7e8097b2072cd3d21681b48bfaacfdf1)GetPathFaceRecordFromNavMeshFacePointer()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) TaleWorlds.Engine.Scene.GetPathFaceRecordFromNavMeshFacePointer | ( | UIntPtr | *navMeshFacePointer* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ab4c44428441eb1c2562bb968db76e7df)GetAllNavmeshFaceRecords()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetAllNavmeshFaceRecords | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html)[] | *faceRecords* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2083366f78214af390eefea2e7279afd)GetFirstEntityWithName()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.Engine.Scene.GetFirstEntityWithName | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a676a8325873a98f19c2696d2b2f5c168)GetCampaignEntityWithName()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.Engine.Scene.GetCampaignEntityWithName | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae08ee00ee18f6f097968f50a9e548cc9)GetAllEntitiesWithScriptComponent< T >()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetAllEntitiesWithScriptComponent< T > | ( | ref List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *entities* | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html)* |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#acf6196f229567f2b4f589b487a670a2b)GetFirstEntityWithScriptComponent< T >()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) [TaleWorlds.Engine.Scene.GetFirstEntityWithScriptComponent](class_tale_worlds_1_1_engine_1_1_scene.html#a74adefd3c915f36935c04f8446565e6f)< T > | ( |  | ) |  |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html)* |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a74adefd3c915f36935c04f8446565e6f)GetFirstEntityWithScriptComponent()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.Engine.Scene.GetFirstEntityWithScriptComponent | ( | string | *scriptName* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad30a2fb99453f99ef247b397cf02be45)GetUpgradeLevelMaskOfLevelName()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.Scene.GetUpgradeLevelMaskOfLevelName | ( | string | *levelName* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3a631d0c6440fab2386867b1140cb0ce)GetUpgradeLevelNameOfIndex()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.Scene.GetUpgradeLevelNameOfIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa205dddfc33270a4c6148b6b8c6ea69c)GetUpgradeLevelCount()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetUpgradeLevelCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a69472daa9e2b2193bd268f3a5381d6ac)GetWinterTimeFactor()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetWinterTimeFactor | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#acbfdca68d38a90d93e714573ef6e48c3)GetNavMeshFaceFirstVertexZ()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetNavMeshFaceFirstVertexZ | ( | int | *faceIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a1b8d4ee3d2cf676f92020d3be0e4d3aa)SetWinterTimeFactor()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetWinterTimeFactor | ( | float | *winterTimeFactor* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a41629458850ea32a562b8ae00a038b3c)SetDrynessFactor()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDrynessFactor | ( | float | *drynessFactor* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae2405a54b90e681b2ea09a286fd169de)GetFog()
------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetFog | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a0cb80649542fee37b321df43505d11c0)SetFog()
------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetFog | ( | float | *fogDensity*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *fogColor*, |
|  |  | float | *fogFalloff* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a18013e7926202ab300392359e1741365)SetFogAdvanced()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetFogAdvanced | ( | float | *fogFalloffOffset*, |
|  |  | float | *fogFalloffMinFog*, |
|  |  | float | *fogFalloffStartDist* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad2e7d8082c0bb8cb2b44a2e958f4bff7)SetFogAmbientColor()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetFogAmbientColor | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *fogAmbientColor* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9050226e428cb7e9bcaa21f886cf5381)SetTemperature()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetTemperature | ( | float | *temperature* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9dc244df56da269ad1395c831c12b8d3)SetHumidity()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetHumidity | ( | float | *humidity* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a060440c252677c728d4367781ca2ad72)SetDynamicShadowmapCascadesRadiusMultiplier()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDynamicShadowmapCascadesRadiusMultiplier | ( | float | *multiplier* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ac5cc6b5cc633cfbfa91c34d17a42cd63)SetEnvironmentMultiplier()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetEnvironmentMultiplier | ( | bool | *useMultiplier*, |
|  |  | float | *multiplier* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2718ae45edc456b249b6738f0331d2ff)SetSkyRotation()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSkyRotation | ( | float | *rotation* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a14ddd0b6feb68f60ede60ccf84fee0a0)SetSkyBrightness()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSkyBrightness | ( | float | *brightness* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af2a8f17515db391dd3435cb461818576)SetForcedSnow()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetForcedSnow | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3d72afce59d9496ec5ecbd090c2c1182)SetSunLight()
-----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSunLight | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#abf9648a1b5f8651a344ba4872ea34435)SetSunDirection()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSunDirection | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae941f591ca1f6351c52bea690027a8ac)SetSun()
------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSun | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color*, |
|  |  | float | *altitude*, |
|  |  | float | *angle*, |
|  |  | float | *intensity* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2bf6be0a577559d3dcbcc610f55b5d1b)SetSunAngleAltitude()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSunAngleAltitude | ( | float | *angle*, |
|  |  | float | *altitude* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ac8e9da36397172206e42602cc64ac789)SetSunSize()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSunSize | ( | float | *size* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aaa6328015921aa5f1e3e406271fb5339)SetSunShaftStrength()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSunShaftStrength | ( | float | *strength* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad432aa14a7c10e1ed653bd0384e85dfa)GetRainDensity()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetRainDensity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae19a1e3ac5ee96ff95809967860bcd8f)SetRainDensity()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetRainDensity | ( | float | *density* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9259d9b6da271b20ba3b5aa735996b2f)GetSnowDensity()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetSnowDensity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ac9c5d0bad57e8d197178828a7e387d46)SetSnowDensity()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSnowDensity | ( | float | *density* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af4bc9b93fd8a1d792625c7a9ee1c77ed)AddDecalInstance()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.AddDecalInstance | ( | [Decal](class_tale_worlds_1_1_engine_1_1_decal.html) | *decal*, |
|  |  | string | *decalSetID*, |
|  |  | bool | *deletable* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#acbbc73aff5dd8df2f6c4c615876bef88)RemoveDecalInstance()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.RemoveDecalInstance | ( | [Decal](class_tale_worlds_1_1_engine_1_1_decal.html) | *decal*, |
|  |  | string | *decalSetID* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a14e84426c2107c805ae11393f39210c6)SetShadow()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetShadow | ( | bool | *shadowEnabled* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ab9407e214cdb050688bc8ae8307267f9)AddPointLight()
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.AddPointLight | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | float | *radius* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#acfb3f98a3b285b8c2921b56360c2c4e3)AddDirectionalLight()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.AddDirectionalLight | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, |
|  |  | float | *radius* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a16ce914897afe4f4e82e7bcddddcda43)SetLightPosition()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetLightPosition | ( | int | *lightIndex*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a85a2c992be982400e84ad5c150dd2763)SetLightDiffuseColor()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetLightDiffuseColor | ( | int | *lightIndex*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *diffuseColor* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a474c3c9fa34c6d12122cb0a214ddb2b7)SetLightDirection()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetLightDirection | ( | int | *lightIndex*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af5b99b0614fc260d48baf7d305398c09)SetMieScatterFocus()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetMieScatterFocus | ( | float | *strength* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2e5650cbd559a84787c3a45ed86b17c2)SetMieScatterStrength()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetMieScatterStrength | ( | float | *strength* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9b30bb960d0c3d7fca32bc30cb1512b4)SetBrightpassThreshold()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetBrightpassThreshold | ( | float | *threshold* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a20ad96ed2a95c2ca10b3761fcb7207f1)SetLensDistortion()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetLensDistortion | ( | float | *amount* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a1716b3d5ca44078b72fec830c01f9e8d)SetHexagonVignetteAlpha()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetHexagonVignetteAlpha | ( | float | *amount* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5502aca9e35e6b46e05747a4d513e580)SetMinExposure()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetMinExposure | ( | float | *minExposure* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a476b04b1df303b52f186a19c0280abf4)SetMaxExposure()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetMaxExposure | ( | float | *maxExposure* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ab9e8912f6202794a6dc4c795bf10e449)SetTargetExposure()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetTargetExposure | ( | float | *targetExposure* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a646b53db00378dca9530b557d698f78c)SetMiddleGray()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetMiddleGray | ( | float | *middleGray* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a453ed850b7204e500f275fa813288b04)SetBloomStrength()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetBloomStrength | ( | float | *bloomStrength* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae101cd17dc3a155e5e959057deeca793)SetBloomAmount()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetBloomAmount | ( | float | *bloomAmount* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a4a167ac5af92e09f4d4582ffff227267)SetGrainAmount()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetGrainAmount | ( | float | *grainAmount* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#adff730a4858e4b3d3f2c0c24761f3c8c)AddItemEntity()
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.Engine.Scene.AddItemEntity | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *placementFrame*, |
|  |  | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *metaMesh* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aea645a70e01091a0464276ad7be87060)RemoveEntity() [1/2]
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.RemoveEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, |
|  |  | int | *removeReason* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#adbdc0931f851bf1a921b99d3c64a4232)RemoveEntity() [2/2]
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.RemoveEntity | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity*, |
|  |  | int | *removeReason* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a73b842d34afc956547f9fd94bbb1e05a)AttachEntity() [1/2]
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.AttachEntity | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, |
|  |  | bool | *showWarnings* = false ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a1e777800411d916aa3a719e34590b30d)AttachEntity() [2/2]
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.AttachEntity | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity*, |
|  |  | bool | *showWarnings* = false ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5cb16db75c39ae3b88c0114a4e7f3dd0)AddEntityWithMesh()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.AddEntityWithMesh | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a667f29721550b8ac11fc66886a985cc9)AddEntityWithMultiMesh()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.AddEntityWithMultiMesh | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *mesh*, |
|  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a260f317ccc40ba08efe44199d6a9cf70)Tick()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ac8b29e2bf595b1536380f06b0c12d621)ClearAll()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.ClearAll | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a441706d9c2bbb9b2da9ccefd5c899370)SetDefaultLighting()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDefaultLighting | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a32514e65a1149ca3e4e9839b2c91096c)CalculateEffectiveLighting()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.CalculateEffectiveLighting | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8372ed993add2060ad9286675088445f)GetPathDistanceBetweenPositions()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetPathDistanceBetweenPositions | ( | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *point0*, |
|  |  | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *point1*, |
|  |  | float | *agentRadius*, |
|  |  | out float | *pathDistance* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#afed58cc0641a42821caf83da204b0cce)IsLineToPointClear() [1/3]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.IsLineToPointClear | ( | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, |
|  |  | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *destination*, |
|  |  | float | *agentRadius* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8ab29de196f7fe2ab6a82430b73bbc8b)IsLineToPointClear() [2/3]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.IsLineToPointClear | ( | UIntPtr | *startingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination*, |
|  |  | float | *agentRadius* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2157113770782acaf51084cb1ceb988e)IsLineToPointClear() [3/3]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.IsLineToPointClear | ( | int | *startingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination*, |
|  |  | float | *agentRadius* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2f166df4406e6de7f2e5d2596870af40)GetLastPointOnNavigationMeshFromPositionToDestination()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.Scene.GetLastPointOnNavigationMeshFromPositionToDestination | ( | int | *startingFace*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination*, |
|  |  | int[] | *excludedFaceIds* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8df4a8ee947acace962617954b12540b)GetLastPositionOnNavMeshFaceForPointAndDirection()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.Scene.GetLastPositionOnNavMeshFaceForPointAndDirection | ( | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *record*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8c373e71706a2c30c40959a612e672d7)GetLastPointOnNavigationMeshFromWorldPositionToDestination()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Scene.GetLastPointOnNavigationMeshFromWorldPositionToDestination | ( | ref [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *destination* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ab8147b36d998c6ae4c1b732989c93597)DoesPathExistBetweenFaces()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.DoesPathExistBetweenFaces | ( | int | *firstNavMeshFace*, |
|  |  | int | *secondNavMeshFace*, |
|  |  | bool | *ignoreDisabled* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a35658c86f177ee33225a3521c4349f24)GetHeightAtPoint()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetHeightAtPoint | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags*, |
|  |  | ref float | *height* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a215b1f026124e48068e39aa377d68964)GetNormalAt()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Scene.GetNormalAt | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad102f0b228b0938a32425698d50d9da6)GetEntities()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetEntities | ( | ref List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *entities* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5b7f1874db0f55defe01680434a5c20e)GetRootEntities()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetRootEntities | ( | NativeObjectArray | *entities* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#adc6241ef63f8afd35999c16afb347b02)SelectEntitiesInBoxWithScriptComponent< T >()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.SelectEntitiesInBoxWithScriptComponent< T > | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *boundingBoxMin*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *boundingBoxMax*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html)[] | *entitiesOutput*, |
|  |  | UIntPtr[] | *entityIds* ) |

**Type Constraints**
:   |  |  |  |  |
    | --- | --- | --- | --- |
    | *T* | : | *[ScriptComponentBehavior](class_tale_worlds_1_1_engine_1_1_script_component_behavior.html)* |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aad696b80103cb43935ec53fa57d8c078)SelectEntitiesCollidedWith()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.SelectEntitiesCollidedWith | ( | ref [Ray](struct_tale_worlds_1_1_library_1_1_ray.html) | *ray*, |
|  |  | [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] | *intersectionsOutput*, |
|  |  | UIntPtr[] | *entityIds* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9e56a3420ecd42d15d44588d9f3c69d9)RayCastExcludingTwoEntities()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastExcludingTwoEntities | ( | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *flags*, |
|  |  | in [Ray](struct_tale_worlds_1_1_library_1_1_ray.html) | *ray*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity1*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity2* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af9ea92b0a7df0f6711e06ace99f0526d)GenerateContactsWithCapsule()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GenerateContactsWithCapsule | ( | ref [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) | *capsule*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *exclude\_flags*, |
|  |  | bool | *isFixedTick*, |
|  |  | [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] | *intersectionsOutput*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html)[] | *gameEntities*, |
|  |  | UIntPtr[] | *entityPointers* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7bed13b3c69c050f0a27a34e5197ae98)GenerateContactsWithCapsuleAgainstEntity()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GenerateContactsWithCapsuleAgainstEntity | ( | ref [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) | *capsule*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeFlags*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity*, |
|  |  | [Intersection](struct_tale_worlds_1_1_engine_1_1_intersection.html)[] | *intersectionsOutput* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a24981cd7cfae02c2164d6474e2ac17c7)InvalidateTerrainPhysicsMaterials()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.InvalidateTerrainPhysicsMaterials | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2363355297d38fe6c11d78cc4c90bda4)Read() [1/3]
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.Read | ( | string | *sceneName* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a29eaf0b8b4213cec1421fd8aea43699e)Read() [2/3]
----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.Read | ( | string | *sceneName*, |
|  |  | string | *moduleId*, |
|  |  | ref [SceneInitializationData](struct_tale_worlds_1_1_engine_1_1_scene_initialization_data.html) | *initData*, |
|  |  | string | *forcedAtmoName* = "" ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9b19994877aa85101651508c6ca84ce6)Read() [3/3]
----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.Read | ( | string | *sceneName*, |
|  |  | ref [SceneInitializationData](struct_tale_worlds_1_1_engine_1_1_scene_initialization_data.html) | *initData*, |
|  |  | string | *forcedAtmoName* = "" ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8055365bf85dee5a2f11ba9f448b1ccf)ReadAndCalculateInitialCamera()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Scene.ReadAndCalculateInitialCamera | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a781a1a7842201cab3302e53f095b9081)OptimizeScene()
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.OptimizeScene | ( | bool | *optimizeFlora* = true, |
|  |  | bool | *optimizeOro* = false ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3edd84a200c18d5ceabaa9772b84b27e)GetTerrainHeight()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetTerrainHeight | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, |
|  |  | bool | *checkHoles* = true ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2c5973ee67e737c9a54c0976896271a8)CheckResources()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.CheckResources | ( | bool | *checkInvisibleEntities* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a455f32992619acfc46a3d3b18f190def)ForceLoadResources()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.ForceLoadResources | ( | bool | *checkInvisibleEntities* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9f986fa9d016c3311a586758f4bf584b)SetDepthOfFieldParameters()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDepthOfFieldParameters | ( | float | *depthOfFieldFocusStart*, |
|  |  | float | *depthOfFieldFocusEnd*, |
|  |  | bool | *isVignetteOn* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#acd2edea60d8d480a9f74eb980db301c4)SetDepthOfFieldFocus()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDepthOfFieldFocus | ( | float | *depthOfFieldFocus* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2ab8e9d9875fe229da40505fa55e51b7)ResetDepthOfFieldParams()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.ResetDepthOfFieldParams | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5ed8196c5ffa15923fb433f006bcaa74)PreloadForRendering()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.PreloadForRendering | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5b6a8acbaed9946f7a8fce11a00ddaba)SetColorGradeBlend()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetColorGradeBlend | ( | string | *texture1*, |
|  |  | string | *texture2*, |
|  |  | float | *alpha* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a1952b4e6f05e2ccc40822b37f7f3cd35)GetGroundHeightAtPosition() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetGroundHeightAtPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeFlags* = [BodyFlags::CommonCollisionExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aae54cc4731531ae94d358f7102801d5b4) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a038f312a953b97e157a44127f5d6513c)GetGroundHeightAndBodyFlagsAtPosition()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetGroundHeightAndBodyFlagsAtPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | out [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *contactPointFlags*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeFlags* = [BodyFlags::CommonCollisionExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aae54cc4731531ae94d358f7102801d5b4) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aafeb5fd2bca21b0217298be7bad8d9a6)GetGroundHeightAtPosition() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetGroundHeightAtPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *normal*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeFlags* = [BodyFlags::CommonCollisionExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aae54cc4731531ae94d358f7102801d5b4) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5a2702c100a77e684542fa234d03427d)PauseSceneSounds()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.PauseSceneSounds | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad805bc4bbea6f2f9b8ab1e7f57a08469)ResumeSceneSounds()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.ResumeSceneSounds | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8f59e58644247f44d7673064ef0efaf4)FinishSceneSounds()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.FinishSceneSounds | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a92ad8c2347051b95ea1c42eeb512a805)BoxCastOnlyForCamera()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.BoxCastOnlyForCamera | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] | *boxPoints*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *centerPoint*, |
|  |  | bool | *castSupportRay*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *supportRaycastPoint*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *dir*, |
|  |  | float | *distance*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *ignoredEntity*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *closestPoint*, |
|  |  | out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *collidedEntity*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludedBodyFlags* = [BodyFlags::CameraCollisionRayCastExludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aa1d89464bebbfb608ed2308a739149600) | [BodyFlags::DontCollideWithCamera](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aa09d20b41cb853019e78b838387db28ed) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a0327cf5007505b1d49b282fd0562e2df)BoxCast()
-------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.BoxCast | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *boxMin*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *boxMax*, |
|  |  | bool | *castSupportRay*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *supportRaycastPoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *dir*, |
|  |  | float | *distance*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *closestPoint*, |
|  |  | out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *collidedEntity*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludedBodyFlags* = [BodyFlags::CameraCollisionRayCastExludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aa1d89464bebbfb608ed2308a739149600) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a43b3fb1ed1b7634a43c906d90dfdda79)RayCastForClosestEntityOrTerrain() [1/4]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastForClosestEntityOrTerrain | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *closestPoint*, |
|  |  | out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *collidedEntity*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aba717c33e5e021a9be5a8b3b0946b7bf)RayCastForClosestEntityOrTerrainFixedPhysics() [1/4]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastForClosestEntityOrTerrainFixedPhysics | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *closestPoint*, |
|  |  | out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *collidedEntity*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5664f829d1a50eaea2100f682c4160de)FocusRayCastForFixedPhysics()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.FocusRayCastForFixedPhysics | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *closestPoint*, |
|  |  | out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *collidedEntity*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3102342131788e68fbd2861eaef99e23)RayCastForClosestEntityOrTerrain() [2/4]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastForClosestEntityOrTerrain | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *collidedEntity*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aff294dcd84367913e083bb8a25c8cab1)RayCastForClosestEntityOrTerrainFixedPhysics() [2/4]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastForClosestEntityOrTerrainFixedPhysics | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *collidedEntity*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ade53db5cb2d90e86a0f2b1cc929903b2)RayCastForRamming()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastForRamming | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *ignoredEntity*, |
|  |  | float | *rayThickness*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *intersectionPoint*, |
|  |  | out [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *collidedEntity*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2), |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *includeBodyFlags* = [BodyFlags::None](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aa6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af21462d6f242b397932ad4f4641ef08d)RayCastForClosestEntityOrTerrainIgnoreEntity()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastForClosestEntityOrTerrainIgnoreEntity | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *ignoredEntity*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *collidedEntity*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2de14cc1384b167aed9c17626122ce0d)RayCastForClosestEntityOrTerrain() [3/4]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastForClosestEntityOrTerrain | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *closestPoint*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7b0216a6a4a17bd6d72898368e823319)RayCastForClosestEntityOrTerrainFixedPhysics() [3/4]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastForClosestEntityOrTerrainFixedPhysics | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *closestPoint*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a04c0866857540ebbb9f274bd5f09adc9)RayCastForClosestEntityOrTerrainFixedPhysics() [4/4]
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastForClosestEntityOrTerrainFixedPhysics | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | out float | *collisionDistance*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af3697e8cd9178e02ae469cb74a9bb1b6)RayCastForClosestEntityOrTerrain() [4/4]
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.RayCastForClosestEntityOrTerrain | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | out float | *collisionDistance*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aff576a825633906c641ed0237a3a3841)ImportNavigationMeshPrefab()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.ImportNavigationMeshPrefab | ( | string | *navMeshPrefabName*, |
|  |  | int | *navMeshGroupShift* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7ba5ebdab50db8a811e20817afab5232)ImportNavigationMeshPrefabWithFrame()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.ImportNavigationMeshPrefabWithFrame | ( | string | *navMeshPrefabName*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a300e330b9e7f75da6c742ebc9ca35a4c)SaveNavMeshPrefabWithFrame()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SaveNavMeshPrefabWithFrame | ( | string | *navMeshPrefabName*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a85e87e6961f34924d7af28cf3bdd6435)SetNavMeshRegionMap()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetNavMeshRegionMap | ( | bool[] | *regionMap* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aef51b40aa186c7612d6f52c55055fd2e)MarkFacesWithIdAsLadder()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.MarkFacesWithIdAsLadder | ( | int | *faceGroupId*, |
|  |  | bool | *isLadder* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ae748ef35e94ea94aa589365055c30989)SetAbilityOfFacesWithId()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.SetAbilityOfFacesWithId | ( | int | *faceGroupId*, |
|  |  | bool | *isEnabled* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9586bd09372031ac1648e2e99c37c072)SwapFaceConnectionsWithID()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.SwapFaceConnectionsWithID | ( | int | *hubFaceGroupID*, |
|  |  | int | *toBeSeparatedFaceGroupId*, |
|  |  | int | *toBeMergedFaceGroupId*, |
|  |  | bool | *canFail* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7defadfe0d588783bdbe8cc2430405cd)MergeFacesWithId()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.MergeFacesWithId | ( | int | *faceGroupId0*, |
|  |  | int | *faceGroupId1*, |
|  |  | int | *newFaceGroupId* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a2f56a4182d48f01307c37e7331de3dbd)SeparateFacesWithId()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SeparateFacesWithId | ( | int | *faceGroupId0*, |
|  |  | int | *faceGroupId1* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a59aacb76e1deac6ed67630e153fda928)IsAnyFaceWithId()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.IsAnyFaceWithId | ( | int | *faceGroupId* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9b9cf24d5b8f9cb2e97b34b88f9674d7)GetNavigationMeshForPosition() [1/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| UIntPtr TaleWorlds.Engine.Scene.GetNavigationMeshForPosition | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3939f3b225d606ed947ffbb4e0122513)GetNearestNavigationMeshForPosition()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| UIntPtr TaleWorlds.Engine.Scene.GetNearestNavigationMeshForPosition | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | float | *heightDifferenceLimit*, |
|  |  | bool | *excludeDynamicNavigationMeshes* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a65eb58521e21003083f7fa586c6d3213)GetNavigationMeshForPosition() [2/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| UIntPtr TaleWorlds.Engine.Scene.GetNavigationMeshForPosition | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | out int | *faceGroupId*, |
|  |  | float | *heightDifferenceLimit*, |
|  |  | bool | *excludeDynamicNavigationMeshes* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a46ed98563610ce97bf057bb0f0f0ffb2)DoesPathExistBetweenPositions()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.DoesPathExistBetweenPositions | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *position*, |
|  |  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *destination* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aad984e2ddec9ba3b56b9472518f75465)SetLandscapeRainMaskData()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetLandscapeRainMaskData | ( | byte[] | *data* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a1075278a6cb95c9757acb92cc2bfa602)EnsurePostfxSystem()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.EnsurePostfxSystem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a4cd4e3aed7b01709190fe2a44951083f)SetBloom()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetBloom | ( | bool | *mode* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af4672985566ff19b88969663a8b94097)SetDofMode()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDofMode | ( | bool | *mode* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a51c33c4660026dbb7ebd6fd26f63c1c2)SetOcclusionMode()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetOcclusionMode | ( | bool | *mode* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a18e128aa3d8f4472d2732bb7c28c2188)SetExternalInjectionTexture()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetExternalInjectionTexture | ( | [Texture](class_tale_worlds_1_1_engine_1_1_texture.html) | *texture* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9cd68731fd4b6db9ecb0db24229a1f23)SetSunshaftMode()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetSunshaftMode | ( | bool | *mode* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a72b1d440cfc0153eca8b51cbd82f84cb)GetSunDirection()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Scene.GetSunDirection | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a03729182be787a75d4dc2c3a44e73280)GetNorthAngle()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetNorthAngle | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a41e8a3373dacd41a9bd572f9422ae0cd)GetNorthRotation()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Scene.GetNorthRotation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#abd62d06bb47d9e5cd2a4bbf98f776431)GetTerrainMinMaxHeight()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.GetTerrainMinMaxHeight | ( | out float | *minHeight*, |
|  |  | out float | *maxHeight* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a99858390653dc19b6dfd7238355ea192)GetPhysicsMinMax()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetPhysicsMinMax | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *min\_max* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ab4464ee831c19aa699c6a27ad91686dd)IsEditorScene()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.IsEditorScene | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a4f02cd0c698df2721c8b553f9f275c78)SetMotionBlurMode()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetMotionBlurMode | ( | bool | *mode* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a9ca3c41c5dfd4e6851141e301bc69642)SetAntialiasingMode()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetAntialiasingMode | ( | bool | *mode* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a129938460c3800aec2bbbcc95a017bfd)SetDLSSMode()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDLSSMode | ( | bool | *mode* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ac64eb8e8bd53a88550d99623771e69f5)FindWeakEntitiesWithTag()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) > TaleWorlds.Engine.Scene.FindWeakEntitiesWithTag | ( | string | *tag* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5ad492c3a7db400b2d29b55beabb546b)FindWeakEntityWithTag()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) TaleWorlds.Engine.Scene.FindWeakEntityWithTag | ( | string | *tag* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af985949737ae228136bbeb601cecb59d)FindEntitiesWithTag()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > TaleWorlds.Engine.Scene.FindEntitiesWithTag | ( | string | *tag* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ac96fcd62779f00c260d1f09a3ad01f11)FindEntityWithTag()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.Engine.Scene.FindEntityWithTag | ( | string | *tag* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa3249e43d2a11175753c287892c512b4)FindEntityWithName()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.Engine.Scene.FindEntityWithName | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5e7f867ff1e3df4bb8def05075b375d5)FindWeakEntitiesWithTagExpression()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) > TaleWorlds.Engine.Scene.FindWeakEntitiesWithTagExpression | ( | string | *expression* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa7fcfd0cc4a5f36f73a18ea1fc4f9f50)FindEntitiesWithTagExpression()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| IEnumerable< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > TaleWorlds.Engine.Scene.FindEntitiesWithTagExpression | ( | string | *expression* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a6e5ffb57cf433f8990b8e8a9abf59d9c)GetSoftBoundaryVertexCount()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetSoftBoundaryVertexCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#acc74452b21094ec9dfd0c17b5800cb19)GetHardBoundaryVertexCount()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Scene.GetHardBoundaryVertexCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a33400563a3bad8c6ec2150a55bff77fd)GetSoftBoundaryVertex()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.Scene.GetSoftBoundaryVertex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a40e7615a007ee62f701e91d47571b90f)GetHardBoundaryVertex()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.Scene.GetHardBoundaryVertex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ab67d3291bc9ddc817c99cac6a5fa8fcd)GetPathWithName()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Path](class_tale_worlds_1_1_engine_1_1_path.html) TaleWorlds.Engine.Scene.GetPathWithName | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a714b0f240cc8eb8a799cf781f9dc8b0b)DeletePathWithName()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.DeletePathWithName | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a67281737b0e562102ba6f4b66c988407)AddPath()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.AddPath | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8e6fe6ec5c3bf2e1b754b957f6f1eceb)AddPathPoint()
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.AddPathPoint | ( | string | *name*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad89f74489e02f1966649cb9e693dbd49)GetBoundingBox()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetBoundingBox | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *min*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *max* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad95899767c6121a5285d3af175ba5ed9)GetSceneLimits()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.GetSceneLimits | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *min*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *max* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a6a75dd6311fab1e164de76e40927df87)SetName()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetName | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a4db7c88bc50f78ce21b37fa21ca000b1)GetName()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.Scene.GetName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#adbd9b737e2ccd5338001642fa53d8d95)GetModulePath()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.Scene.GetModulePath | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a39e9ec4f6537719247bc7dbe704c8231)SetOwnerThread()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetOwnerThread | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3e3437508f076ffd9539dbc6e5a8fe15)GetPathsWithNamePrefix()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Path](class_tale_worlds_1_1_engine_1_1_path.html)[] TaleWorlds.Engine.Scene.GetPathsWithNamePrefix | ( | string | *prefix* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a85dabb3cac4c9da528eb9699b2022373)SetUseConstantTime()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetUseConstantTime | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5277551ea5ca7814f7ee43356646d63d)CheckPointCanSeePoint()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.CheckPointCanSeePoint | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *source*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *target*, |
|  |  | float? | *distanceToCheck* = null ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a02faf7d8b7b75111a0532b88d94e6c3b)SetPlaySoundEventsAfterReadyToRender()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetPlaySoundEventsAfterReadyToRender | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5223a73bf3bac13e8d33fe109f22f645)DisableStaticShadows()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.DisableStaticShadows | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a007625a8be0286c3f9171eefa7ef377a)GetSkyboxMesh()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) TaleWorlds.Engine.Scene.GetSkyboxMesh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ac80b623b85fec8e2c84f7e03f0657ede)SetAtmosphereWithName()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetAtmosphereWithName | ( | string | *name* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a5a083ec01763803ea0f7c5fbbf4e850b)FillEntityWithHardBorderPhysicsBarrier()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.FillEntityWithHardBorderPhysicsBarrier | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a93fd5ca09a53c661beb4575932341ecf)ClearDecals()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.ClearDecals | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a1b07510d39d92d1a2d1e5e63dac45ba8)SetPhotoAtmosphereViaTod()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetPhotoAtmosphereViaTod | ( | float | *tod*, |
|  |  | bool | *withStorm* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8efa35f078be1494f61f054b47901758)IsPositionOnADynamicNavMesh()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.IsPositionOnADynamicNavMesh | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3c0074d37d9629180ea2520ff24c9f38)WaitWaterRendererCPUSimulation()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.WaitWaterRendererCPUSimulation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#acb2b407a5454e8ad86131ff768ba6600)EnableInclusiveAsyncPhysx()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.EnableInclusiveAsyncPhysx | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa957a4c93d47b2b3d04942a408b283bf)EnsureWaterWakeRenderer()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.EnsureWaterWakeRenderer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a306ae16dba52eab1878385c8bfb6cfc0)DeleteWaterWakeRenderer()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.DeleteWaterWakeRenderer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7661fb1594f0b5656d7a0976593e7576)SceneHadWaterWakeRenderer()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Scene.SceneHadWaterWakeRenderer | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad4309c2708e43c4b4c5502a070f70930)SetWaterWakeWorldSize()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetWaterWakeWorldSize | ( | float | *worldSize*, |
|  |  | float | *eraseFactor* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#af87b5af6626714c19538cf6fe7ea163f)SetWaterWakeCameraOffset()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetWaterWakeCameraOffset | ( | float | *cameraOffset* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a116cc787114e177369aa5bdae56b89b6)TickWake()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.TickWake | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ac88844f3db29640431caa7d57b9c49fd)SetDoNotAddEntitiesToTickList()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDoNotAddEntitiesToTickList | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#acf0840a1897898ab2d821d4660570a0d)SetDontLoadInvisibleEntities()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetDontLoadInvisibleEntities | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a21e634e927a7579f327b7905da6ac385)SetUsesDeleteLaterSystem()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.SetUsesDeleteLaterSystem | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a34277f94b9f6aa0b2f0c5bb8bed8bf58)ClearCurrentFrameTickEntities()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Scene.ClearCurrentFrameTickEntities | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad3eb0ad842e6e817b833a75fe8244084)FindClosestExitPositionForPositionOnABoundaryFace()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.Scene.FindClosestExitPositionForPositionOnABoundaryFace | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | UIntPtr | *boundaryFacePointer* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a1d86b6dc82051eea52b0b0874048d544)MaximumWindSpeed
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.Scene.MaximumWindSpeed = 30.0f | | static |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a59e02243cfdd26b54ac41f767dffde3e)AutoClimbHeight
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Engine.Scene.AutoClimbHeight = 1.5f | | static |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#aa7038b244d0b300d03eeb84cc0e7948c)NavMeshHeightLimit
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Engine.Scene.NavMeshHeightLimit = 1.5f | | static |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad9e50ed0fe213820b1a3d4baee263235)SunRise
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Engine.Scene.SunRise = 2 | | static |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a038bbeea496de24944aaa01d60dd7d7e)SunSet
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Engine.Scene.SunSet = 22 | | static |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a962e2b7b1b80283d875087603f736caf)PhysicsAndRayCastLock
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [TWSharedMutex](class_tale_worlds_1_1_library_1_1_t_w_shared_mutex.html) TaleWorlds.Engine.Scene.PhysicsAndRayCastLock = new [TWSharedMutex](class_tale_worlds_1_1_library_1_1_t_w_shared_mutex.html)() | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ab0907fdc363d57e9f35f7a6f73732fca)RootEntityCount
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.Scene.RootEntityCount | | get |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a3803337257fe9ccff3633a24fbf29218)HasTerrainHeightmap
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Scene.HasTerrainHeightmap | | get |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8b637cd9d9cc19c46dd40540011f3c13)ContainsTerrain
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Scene.ContainsTerrain | | get |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a7c94482fe3d29dc8ec4fb916d6d85e21)TimeOfDay
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.Scene.TimeOfDay | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a58414c9a5b6b77604298af9ca9d44878)IsDayTime
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Scene.IsDayTime | | get |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#ad956c05f0ca25631cc9c5ef5e4a538b4)IsAtmosphereIndoor
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Scene.IsAtmosphereIndoor | | get |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a4b0bc340b6cf1c07247d3e5a8223d541)LastFinalRenderCameraPosition
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Scene.LastFinalRenderCameraPosition | | get |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a8bd97b933b3a7fa4f3ccd57353ab5955)LastFinalRenderCameraFrame
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Scene.LastFinalRenderCameraFrame | | get |

[◆](class_tale_worlds_1_1_engine_1_1_scene.html#a22d10f5d49aa93597a86d87e647f24b7)TimeSpeed
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.Scene.TimeSpeed | | getset |

