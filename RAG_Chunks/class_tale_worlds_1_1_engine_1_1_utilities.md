--- SOURCE: class_tale_worlds_1_1_engine_1_1_utilities.html ---

TaleWorlds.Engine.Utilities Class Reference|  |  |
| --- | --- |
| Classes | |
| class | [MemoryLogger](class_tale_worlds_1_1_engine_1_1_utilities_1_1_memory_logger.html) |
| class | [MainThreadPerformanceQuery](class_tale_worlds_1_1_engine_1_1_utilities_1_1_main_thread_performance_query.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [EngineRenderDisplayMode](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75) {     [ShowNone](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a408ee0dd1b357bb25566cd9c7bc00bc2) = 0 ,     [ShowAlbedo](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a14f8c3397eb85cd86bb6f3220107cc17) ,     [ShowNormals](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a8303dc584812f297685520e876fde002) ,     [ShowVertexNormals](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75ae22180214fe350fc65df75196ba54457) ,     [ShowSpecular](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a0edc44fd4a981d749b3cba139bf5432e) ,     [ShowGloss](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a93770c944ddd5b4616f813155ae72f22) ,     [ShowOcclusion](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a0e67b07d67e56cfb0b3579c026735b67) ,     [ShowGbufferShadowMask](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75abcc89f78dee25b3e74c580bdebe8e55c) ,     [ShowTranslucency](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75ae8de6271af75178c9553b15a14a5556b) ,     [ShowMotionVector](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75ac05ad8473f31df6700eb0905c96da407) ,     [ShowVertexColor](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a1b9d64aed5898e41ee4c208686f92792) ,     [ShowDepth](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75ad284d9747d52f2fad24d44957b9326ff) ,     [ShowTiledLightOverdraw](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a8229f7c71f3a58fe98d521565133104d) ,     [ShowTiledDecalOverdraw](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75af06d05e482b7fa4f3aef662628a80772) ,     [ShowMeshId](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75adfa4d78c7549c4df8064054f9402f6be) ,     [ShowDisableSunLighting](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75ad25ff732de38362a61652dba62a72604) ,     [ShowDebugTexture](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75ae0ee5c1d252a13bda6af85ba756c8f4d) ,     [ShowTextureDensity](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a19a16f5e61f025f8098216c1b8da0d72) ,     [ShowOverdraw](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a2bc95dfdede1163692a3063a60fb9441) ,     [ShowVsComplexity](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75acc168f7d0f6785706ebedff75c0971fe) ,     [ShowPsComplexity](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a571d46d15b9f757df5820e6861238c61) ,     [ShowDisableAmbientLighting](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a21788c534d1d7259d6704a038c019424) ,     [ShowEntityId](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a3e55606ba9ab2f0522278d4dbb1be673) ,     [ShowPrtDiffuseAmbient](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a8e15440494a1cf3ad94ca86d50de6914) ,     [ShowLightDebugMode](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a3ca1a17d37ccb1b8c0b428b8c31608de) ,     [ShowParticleShadingAtlas](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a8a4f126bc78573eb2e41ac4a5d06d509) ,     [ShowTerrainAngle](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a07d0b254c02dd3f002b71ffeae8094db) ,     [ShowParallaxDebug](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75ad5ca0542a479c2eaa6d41face316870f) ,     [ShowAlbedoValidation](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75aff9fd356bbb32920d9f424c3bb7537d0) ,     [NumDebugModes](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75a1fbf9659d3f6b652e540e70eccb391ec)   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [InitializeMemoryLogger](class_tale_worlds_1_1_engine_1_1_utilities.html#a541bc1a5d47f7091172530ba00b8cd43) () |
| static void | [CaptureMemory](class_tale_worlds_1_1_engine_1_1_utilities.html#acff2ab0e442f3b465716a384e9228c60) (string name) |
| static void | [ConstructMainThreadJob](class_tale_worlds_1_1_engine_1_1_utilities.html#a2efacf9535e8a91284034bca00e0aaf1) (Delegate function, params object[] parameters) |
| static void | [ConstructMainThreadJob](class_tale_worlds_1_1_engine_1_1_utilities.html#a6ae828f3ffec3114242abb4ae762f03b) (Semaphore semaphore, Delegate function, params object[] parameters) |
| static void | [RunJobs](class_tale_worlds_1_1_engine_1_1_utilities.html#a977f4c25f999ed33bfa902d7f5d18d90) () |
| static void | [WaitJobs](class_tale_worlds_1_1_engine_1_1_utilities.html#aa3c7a6d9aece90e2cb243a0f91665fed) () |
| static void | [OutputBenchmarkValuesToPerformanceReporter](class_tale_worlds_1_1_engine_1_1_utilities.html#a5a2671acb5047b370c66dac221be682f) () |
| static void | [SetLoadingScreenPercentage](class_tale_worlds_1_1_engine_1_1_utilities.html#a4e118903ca63298786d86414036f19ec) (float value) |
| static void | [SetFixedDt](class_tale_worlds_1_1_engine_1_1_utilities.html#a1d7ee500c161e9ea5040b476e3bdc59e) (bool enabled, float dt) |
| static void | [SetBenchmarkStatus](class_tale_worlds_1_1_engine_1_1_utilities.html#a3f348d32d08cfef373e7cf76a8f18bcd) (int status, string def) |
| static int | [GetBenchmarkStatus](class_tale_worlds_1_1_engine_1_1_utilities.html#a78688c65f3d72a68f13a241fe14d7570) () |
| static string | [GetApplicationMemoryStatistics](class_tale_worlds_1_1_engine_1_1_utilities.html#a9fb14fd72f02db5a59098550a22e8325) () |
| static bool | [IsBenchmarkQuited](class_tale_worlds_1_1_engine_1_1_utilities.html#a688275e642eb61121872052a5f8072f8) () |
| static string | [GetNativeMemoryStatistics](class_tale_worlds_1_1_engine_1_1_utilities.html#aa5277142386c2b5374e7334b95b0fac9) () |
| static bool | [CommandLineArgumentExists](class_tale_worlds_1_1_engine_1_1_utilities.html#a29facfb73b9d58600d3b3d3fd4b2e967) (String str) |
| static string | [GetConsoleHostMachine](class_tale_worlds_1_1_engine_1_1_utilities.html#ae003b2fda528d82e375a5c5a2aa19aee) () |
| static string | [ExportNavMeshFaceMarks](class_tale_worlds_1_1_engine_1_1_utilities.html#a70c6d6fa981b25b2b3a647987a363edf) (string file\_name) |
| static string | [TakeSSFromTop](class_tale_worlds_1_1_engine_1_1_utilities.html#a49c20f0ddc8b7124efec2594e80af090) (string file\_name) |
| static void | [CheckIfAssetsAndSourcesAreSame](class_tale_worlds_1_1_engine_1_1_utilities.html#a9b0e75a4d795155d6c266056c71dde2d) () |
| static void | [DisableCoreGame](class_tale_worlds_1_1_engine_1_1_utilities.html#a38ab3ce75700655756e6d48e3f5b610c) () |
| static float | [GetApplicationMemory](class_tale_worlds_1_1_engine_1_1_utilities.html#a84e087cbe7b654598f06ee819a8fb7e9) () |
| static void | [GatherCoreGameReferences](class_tale_worlds_1_1_engine_1_1_utilities.html#aeb49f4be59e35e8c618c34aa8ae4344e) (string scene\_names) |
| static bool | [IsOnlyCoreContentEnabled](class_tale_worlds_1_1_engine_1_1_utilities.html#a4196861d6bf55c363bfb2d4e0c478b56) () |
| static void | [FindMeshesWithoutLods](class_tale_worlds_1_1_engine_1_1_utilities.html#a71de8e86d76c329f45792eb84b556b4a) (string module\_name) |
| static void | [SetDisableDumpGeneration](class_tale_worlds_1_1_engine_1_1_utilities.html#abb37839d35801b6539ef289534705efc) (bool value) |
| static void | [SetPrintCallstackAtCrahses](class_tale_worlds_1_1_engine_1_1_utilities.html#a45e7c0f7598ad1c53704b7903efbdeb8) (bool value) |
| static string[] | [GetModulesNames](class_tale_worlds_1_1_engine_1_1_utilities.html#ae405cbedecf4dde42cf0fa342fca7ef2) () |
| static string | [GetFullFilePathOfScene](class_tale_worlds_1_1_engine_1_1_utilities.html#a1de5be3d21c6bf051299b4aa0753f260) (string sceneName) |
| static bool | [TryGetFullFilePathOfScene](class_tale_worlds_1_1_engine_1_1_utilities.html#a569ccbf2ea56c999e8533fdda624d0af) (string sceneName, out string fullPath) |
| static bool | [TryGetUniqueIdentifiersForScene](class_tale_worlds_1_1_engine_1_1_utilities.html#a0dae7220a56a44b47fe7a1b341d1dd69) (string sceneName, out [UniqueSceneId](class_tale_worlds_1_1_library_1_1_unique_scene_id.html) identifiers) |
| static bool | [TryGetUniqueIdentifiersForSceneFile](class_tale_worlds_1_1_engine_1_1_utilities.html#ada0d6348bf178e6cb29baec7b20a8188) (string xsceneFilePath, out [UniqueSceneId](class_tale_worlds_1_1_library_1_1_unique_scene_id.html) identifiers) |
| static void | [PairSceneNameToModuleName](class_tale_worlds_1_1_engine_1_1_utilities.html#a388d48535541a826c7e7ba2fe69e1db8) (string sceneName, string moduleName) |
| static string[] | [GetSingleModuleScenesOfModule](class_tale_worlds_1_1_engine_1_1_utilities.html#ac7be2f6e5b9bfbcbd379957d3ada7bb1) (string moduleName) |
| static string | [GetFullCommandLineString](class_tale_worlds_1_1_engine_1_1_utilities.html#a686098dfc3645d426bb0e25565395163) () |
| static void | [SetScreenTextRenderingState](class_tale_worlds_1_1_engine_1_1_utilities.html#a45014e3af172ca73427b5842cdf90f73) (bool state) |
| static void | [SetMessageLineRenderingState](class_tale_worlds_1_1_engine_1_1_utilities.html#a14801d1ce28ca85a4656d359132b0ece) (bool state) |
| static bool | [CheckIfTerrainShaderHeaderGenerationFinished](class_tale_worlds_1_1_engine_1_1_utilities.html#a8b73ae45f17074c0daa95c4febe85c18) () |
| static void | [GenerateTerrainShaderHeaders](class_tale_worlds_1_1_engine_1_1_utilities.html#adfa16df1c61fc19b9db80940efe9e909) (string targetPlatform, string targetConfig, string output\_path) |
| static void | [CompileTerrainShadersDist](class_tale_worlds_1_1_engine_1_1_utilities.html#acced2d5e4e4823d054d0a7f4c0da7c86) (string targetPlatform, string targetConfig, string output\_path) |
| static void | [SetCrashOnAsserts](class_tale_worlds_1_1_engine_1_1_utilities.html#a06c4688f68cd28fe462627df9662c294) (bool val) |
| static void | [SetCrashOnWarnings](class_tale_worlds_1_1_engine_1_1_utilities.html#a9795dbb98693f3cccc021599ec932c70) (bool val) |
| static void | [SetCreateDumpOnWarnings](class_tale_worlds_1_1_engine_1_1_utilities.html#a23fd8bd7382d284f5d26c892c516b9cd) (bool val) |
| static void | [ToggleRender](class_tale_worlds_1_1_engine_1_1_utilities.html#adc60ea9032b587ce7cfd1f544c07e035) () |
| static void | [SetRenderAgents](class_tale_worlds_1_1_engine_1_1_utilities.html#aa148797e6b1b0f894becb0401c0af828) (bool value) |
| static bool | [CheckShaderCompilation](class_tale_worlds_1_1_engine_1_1_utilities.html#aac8831af6bf8af0b6076be93e6e00501) () |
| static void | [CompileAllShaders](class_tale_worlds_1_1_engine_1_1_utilities.html#a70fcd78bc5a88a108a01aadd749dfa54) (string targetPlatform) |
| static string | [GetExecutableWorkingDirectory](class_tale_worlds_1_1_engine_1_1_utilities.html#a76917413aefddcc7351c5237a69df9dd) () |
| static void | [SetDumpFolderPath](class_tale_worlds_1_1_engine_1_1_utilities.html#a4bed69096c1908852acd30be45012bda) (string path) |
| static void | [CheckSceneForProblems](class_tale_worlds_1_1_engine_1_1_utilities.html#abdc07e9b2fd605eaf849f23ca0a9632a) (string sceneName) |
| static void | [SetCoreGameState](class_tale_worlds_1_1_engine_1_1_utilities.html#a7853739474f4ba9b94db7339b93db0eb) (int state) |
| static int | [GetCoreGameState](class_tale_worlds_1_1_engine_1_1_utilities.html#ae9bcdf8a663ae48c82474e2a148a1696) () |
| static string | [ExecuteCommandLineCommand](class_tale_worlds_1_1_engine_1_1_utilities.html#aa6ff6d3d78b09996e7b9a7a3ce0682a4) (string command) |
| static void | [QuitGame](class_tale_worlds_1_1_engine_1_1_utilities.html#a1cbefe242ef476c918870e1eceab7564) () |
| static void | [ExitProcess](class_tale_worlds_1_1_engine_1_1_utilities.html#ae0ea4b278bf61351beff2b95829dea39) (int exitCode) |
| static string | [GetBasePath](class_tale_worlds_1_1_engine_1_1_utilities.html#a3437335edb80299baa3d003af3b5e24d) () |
| static string | [GetVisualTestsValidatePath](class_tale_worlds_1_1_engine_1_1_utilities.html#ae20d71f43569b5dd45dd2197069f2439) () |
| static string | [GetVisualTestsTestFilesPath](class_tale_worlds_1_1_engine_1_1_utilities.html#aa515206f77e5fb29c3d32b4c4ef20719) () |
| static string | [GetAttachmentsPath](class_tale_worlds_1_1_engine_1_1_utilities.html#a68640afc749fbcf9bf069ace15cd27c8) () |
| static void | [StartScenePerformanceReport](class_tale_worlds_1_1_engine_1_1_utilities.html#aeda6d086d1b2abbe0075c913c64ebdd8) (string folderPath) |
| static bool | [IsSceneReportFinished](class_tale_worlds_1_1_engine_1_1_utilities.html#ad62358502e05c4d0545c860a4902a5d2) () |
| static float | [GetFps](class_tale_worlds_1_1_engine_1_1_utilities.html#acf6cdc7a36c3ff454993bc2822633de5) () |
| static float | [GetMainFps](class_tale_worlds_1_1_engine_1_1_utilities.html#ae21dcc33d30478f2ddbbd95fc8c66e7a) () |
| static float | [GetRendererFps](class_tale_worlds_1_1_engine_1_1_utilities.html#a794d00d893f3417d3b87a76b0294be48) () |
| static void | [EnableSingleGPUQueryPerFrame](class_tale_worlds_1_1_engine_1_1_utilities.html#af983efc99adb6cb06a42c5d6536edeb5) () |
| static void | [ClearDecalAtlas](class_tale_worlds_1_1_engine_1_1_utilities.html#aaec59cad32d37f88bcb577b6f8abc4cc) ([DecalAtlasGroup](namespace_tale_worlds_1_1_engine.html#a4e991dea1484f83dd32afa4020ec8bef) atlasGroup) |
| static void | [FlushManagedObjectsMemory](class_tale_worlds_1_1_engine_1_1_utilities.html#af92bda619e727e7468622b9d400b3dc0) () |
| static void | [OnLoadingWindowEnabled](class_tale_worlds_1_1_engine_1_1_utilities.html#a03c1f2169eb6cb845bd3ec95267a61d4) () |
| static void | [DebugSetGlobalLoadingWindowState](class_tale_worlds_1_1_engine_1_1_utilities.html#a9512b1169fa1f7b8021bfc2adcc7c658) (bool newState) |
| static void | [OnLoadingWindowDisabled](class_tale_worlds_1_1_engine_1_1_utilities.html#ae9c9a73a720cfe904a7ae3ad2e8f8b06) () |
| static void | [DisableGlobalLoadingWindow](class_tale_worlds_1_1_engine_1_1_utilities.html#aff0bbf155dc8d35186408b4f38379b85) () |
| static void | [EnableGlobalLoadingWindow](class_tale_worlds_1_1_engine_1_1_utilities.html#a248d410be6e07de0376cf75affeb9d12) () |
| static void | [EnableGlobalEditDataCacher](class_tale_worlds_1_1_engine_1_1_utilities.html#acf86eec4dd67e018daf3949c53e483c2) () |
| static void | [DoFullBakeAllLevelsAutomated](class_tale_worlds_1_1_engine_1_1_utilities.html#aabd24fe165697c9af43886d2fb927e78) (string module, string scene) |
| static int | [GetReturnCode](class_tale_worlds_1_1_engine_1_1_utilities.html#a0b78369cbd02bc5ffad569c1d5af165d) () |
| static void | [DisableGlobalEditDataCacher](class_tale_worlds_1_1_engine_1_1_utilities.html#a60ee9f2b2609106f33ccd78d8d33534d) () |
| static void | [DoFullBakeSingleLevelAutomated](class_tale_worlds_1_1_engine_1_1_utilities.html#a1d32a81b6d26afa21cda908e505e56d0) (string module, string scene) |
| static void | [DoLightOnlyBakeSingleLevelAutomated](class_tale_worlds_1_1_engine_1_1_utilities.html#a10520f6d8e1be317d6d07391fb46e259) (string module, string scene) |
| static void | [DoLightOnlyBakeAllLevelsAutomated](class_tale_worlds_1_1_engine_1_1_utilities.html#a098bae36f61f5147eac912982341fc4c) (string module, string scene) |
| static bool | [DidAutomatedGIBakeFinished](class_tale_worlds_1_1_engine_1_1_utilities.html#a941b024d9f404b4c254703503027cd97) () |
| static void | [GetSelectedEntities](class_tale_worlds_1_1_engine_1_1_utilities.html#a94d7a8c80e8b7b40f0dcddd6ed13ccff) (ref List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > gameEntities) |
| static void | [DeleteEntitiesInEditorScene](class_tale_worlds_1_1_engine_1_1_utilities.html#a64fa9472dc9359866ce2cffc2c2bacce) (List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > gameEntities) |
| static void | [CreateSelectionInEditor](class_tale_worlds_1_1_engine_1_1_utilities.html#a0c3e9b1f154d752e920defcd3674b2ca) (List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > gameEntities, string name) |
| static void | [SelectEntities](class_tale_worlds_1_1_engine_1_1_utilities.html#aea1ff8cb842fd006257c4f8d140e610d) (List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > gameEntities) |
| static void | [GetEntitiesOfSelectionSet](class_tale_worlds_1_1_engine_1_1_utilities.html#a195d0d1352c9a1285a339846b1615b78) (string selectionSetName, ref List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > gameEntities) |
| static void | [AddCommandLineFunction](class_tale_worlds_1_1_engine_1_1_utilities.html#a4974935ff7f768adc578b50d4fbb0afe) (string concatName) |
| static int | [GetNumberOfShaderCompilationsInProgress](class_tale_worlds_1_1_engine_1_1_utilities.html#afd9b3b45b0d5dbf61478609a041adb3e) () |
| static int | [IsDetailedSoundLogOn](class_tale_worlds_1_1_engine_1_1_utilities.html#aa9230cf09379524f10915a2571f163a5) () |
| static UInt64 | [GetCurrentCpuMemoryUsageMB](class_tale_worlds_1_1_engine_1_1_utilities.html#a5d6879751bffef0e60dc7ee80387d0d8) () |
| static UInt64 | [GetGpuMemoryOfAllocationGroup](class_tale_worlds_1_1_engine_1_1_utilities.html#a67643571fa6ee5c015e85919e3d865fd) (string name) |
| static void | [GetGPUMemoryStats](class_tale_worlds_1_1_engine_1_1_utilities.html#af2943580476a65f6e4d1bc6f58fb94c7) (ref float totalMemory, ref float renderTargetMemory, ref float depthTargetMemory, ref float srvMemory, ref float bufferMemory) |
| static void | [GetDetailedGPUMemoryData](class_tale_worlds_1_1_engine_1_1_utilities.html#a7b22a30fe221f57cadd3283d4ac23045) (ref int totalMemoryAllocated, ref int totalMemoryUsed, ref int emptyChunkTotalSize) |
| static void | [SetRenderMode](class_tale_worlds_1_1_engine_1_1_utilities.html#ae8892e429bb3079b59cf4d513f93b6e5) ([EngineRenderDisplayMode](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75) mode) |
| static void | [SetForceDrawEntityID](class_tale_worlds_1_1_engine_1_1_utilities.html#ae8716b01c9c50e27d81c96db09d6cfcc) (bool value) |
| static void | [AddPerformanceReportToken](class_tale_worlds_1_1_engine_1_1_utilities.html#ada25eabb4de4212793b328f0db3e4517) (string performance\_type, string name, float loading\_time) |
| static void | [AddSceneObjectReport](class_tale_worlds_1_1_engine_1_1_utilities.html#abde1df176ac1747202f7b46243b19acd) (string scene\_name, string report\_name, float report\_value) |
| static void | [OutputPerformanceReports](class_tale_worlds_1_1_engine_1_1_utilities.html#a60c386af14d23194005348bfbcd7e552) () |
| static void | [TakeScreenshot](class_tale_worlds_1_1_engine_1_1_utilities.html#aa41e4a4e431fb1b2ddc52d2c2aa16af1) ([PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) path) |
| static void | [TakeScreenshot](class_tale_worlds_1_1_engine_1_1_utilities.html#a835132d20eab4de804df796cc6a95da8) (string path) |
| static void | [SetAllocationAlwaysValidScene](class_tale_worlds_1_1_engine_1_1_utilities.html#aeeb50aecb86dcd4abd6049e69632e903) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| static void | [CheckResourceModifications](class_tale_worlds_1_1_engine_1_1_utilities.html#a43da3ef44c3be595f5fe5168fa538320) () |
| static void | [SetGraphicsPreset](class_tale_worlds_1_1_engine_1_1_utilities.html#ab3785c5bc582407bfb9ac600248e5bfa) (int preset) |
| static string | [GetLocalOutputPath](class_tale_worlds_1_1_engine_1_1_utilities.html#a32b6a2d22e6655495f8634aa18e9e953) () |
| static string | [GetPCInfo](class_tale_worlds_1_1_engine_1_1_utilities.html#a62e531d154ace4669c3fde7528580edc) () |
| static int | [GetGPUMemoryMB](class_tale_worlds_1_1_engine_1_1_utilities.html#a1aa5dc3ee9cb7058e606f7fdf289baa2) () |
| static int | [GetCurrentEstimatedGPUMemoryCostMB](class_tale_worlds_1_1_engine_1_1_utilities.html#a2d5ea95b2f28aba9a16e951f7aee1a41) () |
| static void | [DumpGPUMemoryStatistics](class_tale_worlds_1_1_engine_1_1_utilities.html#a0b8144ab7039431cc1718ddeaf20c06a) (string filePath) |
| static int | [SaveDataAsTexture](class_tale_worlds_1_1_engine_1_1_utilities.html#a338a5dac5de37b139a5f867367ab5d1d) (string path, int width, int height, float[] data) |
| static void | [ClearOldResourcesAndObjects](class_tale_worlds_1_1_engine_1_1_utilities.html#add19848e553db20402844e5f661e392a) () |
| static void | [LoadVirtualTextureTileset](class_tale_worlds_1_1_engine_1_1_utilities.html#a80f158ff024537ae83f8bdfe3fc74edf) (string name) |
| static float | [GetDeltaTime](class_tale_worlds_1_1_engine_1_1_utilities.html#a8809add3d9fbabdc0ec0c6bebda134ee) (int timerId) |
| static void | [LoadSkyBoxes](class_tale_worlds_1_1_engine_1_1_utilities.html#af3ceb66e9432a9d63aca4445e5b1c186) () |
| static string | [GetApplicationName](class_tale_worlds_1_1_engine_1_1_utilities.html#a90945da0a6b40730e1893fa18bfe4ee2) () |
| static void | [OpenNavalDlcPurchasePage](class_tale_worlds_1_1_engine_1_1_utilities.html#a726cacb0ecb150c3033ab71075399c16) () |
| static void | [SetWindowTitle](class_tale_worlds_1_1_engine_1_1_utilities.html#af0e487b2ab5eb6ee54e81559d751f966) (string title) |
| static string | [ProcessWindowTitle](class_tale_worlds_1_1_engine_1_1_utilities.html#a8c0f909e9602918f1d8ca7048f7f3859) (string title) |
| static uint | [GetCurrentProcessID](class_tale_worlds_1_1_engine_1_1_utilities.html#a1afb94b338d9a0a1dbdb5342c6308c23) () |
| static void | [DoDelayedexit](class_tale_worlds_1_1_engine_1_1_utilities.html#a6c7d6f910a23c1751887e59e1bceaa6e) (int returnCode) |
| static void | [SetAssertionsAndWarningsSetExitCode](class_tale_worlds_1_1_engine_1_1_utilities.html#ae8d276139f56a9e608983ed238ce41a4) (bool value) |
| static void | [SetReportMode](class_tale_worlds_1_1_engine_1_1_utilities.html#a2344bae4ffe661057a5654dcbd5099bf) (bool reportMode) |
| static void | [SetAssertionAtShaderCompile](class_tale_worlds_1_1_engine_1_1_utilities.html#a11c593169c33359ac8918ccfcf878e83) (bool value) |
| static void | [SetCrashReportCustomString](class_tale_worlds_1_1_engine_1_1_utilities.html#ad4c74826a8abd20c95273d35e0f82a68) (string customString) |
| static void | [SetCrashReportCustomStack](class_tale_worlds_1_1_engine_1_1_utilities.html#a7631580d165708f24f5fb7485a8a5d28) (string customStack) |
| static int | [GetSteamAppId](class_tale_worlds_1_1_engine_1_1_utilities.html#ac1d9c64f28e5fe95e86a753be12582cb) () |
| static void | [SetForceVsync](class_tale_worlds_1_1_engine_1_1_utilities.html#a1c2695a02245f8c0e518f20adf02882a) (bool value) |
| static string | [LoadBannerlordConfigFile](class_tale_worlds_1_1_engine_1_1_utilities.html#ae8da2a970462ca2e9a4030d4664699d2) () |
| static [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) | [SaveConfigFile](class_tale_worlds_1_1_engine_1_1_utilities.html#a2665e9fdcfded43445114c6a7be898d7) (string configProperties) |
| static void | [OpenOnscreenKeyboard](class_tale_worlds_1_1_engine_1_1_utilities.html#a412474ec95e18d5442fe4b6f6d52819d) (string initialText, string descriptionText, int maxLength, int keyboardTypeEnum) |
| static string | [GetSystemLanguage](class_tale_worlds_1_1_engine_1_1_utilities.html#a082ed2b650bc2b2dfc5dc0ec2c18a5ca) () |
| static int | [RegisterGPUAllocationGroup](class_tale_worlds_1_1_engine_1_1_utilities.html#ac4b3e18c76adc46208506a91607be951) (string name) |
| static int | [GetMemoryUsageOfCategory](class_tale_worlds_1_1_engine_1_1_utilities.html#a9a69c0008b1476399fbcc313616cdbee) (int category) |
| static string | [GetDetailedXBOXMemoryInfo](class_tale_worlds_1_1_engine_1_1_utilities.html#af0e644c3332aa4545f0c4cbc23c979d8) () |
| static void | [SetFrameLimiterWithSleep](class_tale_worlds_1_1_engine_1_1_utilities.html#a98d27de0f19d74cb06447220ce416354) (bool value) |
| static bool | [GetFrameLimiterWithSleep](class_tale_worlds_1_1_engine_1_1_utilities.html#a7e362d89881b8178d5679efd8076fb6f) () |
| static string | [GetPossibleCommandLineStartingWith](class_tale_worlds_1_1_engine_1_1_utilities.html#a93497f35bef300000055c291a7327e25) (string command, int index) |
| static bool | [IsDevkit](class_tale_worlds_1_1_engine_1_1_utilities.html#a4623c4181e161bbfb93507899b8c63a4) () |
| static bool | [IsLockhartPlatform](class_tale_worlds_1_1_engine_1_1_utilities.html#a18f68655e3a211001845af72f1444e18) () |
| static int | [GetVertexBufferChunkSystemMemoryUsage](class_tale_worlds_1_1_engine_1_1_utilities.html#a0a6dca0a292bc919b4afc1c192ad22f5) () |
| static int | [GetBuildNumber](class_tale_worlds_1_1_engine_1_1_utilities.html#a6174b165d9cfa5fa4b59fe206a11d17b) () |
| static [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html) | [GetApplicationVersionWithBuildNumber](class_tale_worlds_1_1_engine_1_1_utilities.html#ad85ef9f027683f1d1f67593fdbeaebcb) () |
| static void | [ParallelFor](class_tale_worlds_1_1_engine_1_1_utilities.html#a4c7fadebed9166a66c89fc543f6793e1) (int startIndex, int endIndex, long curKey, int grainSize) |
| static void | [ParallelForWithoutRenderThread](class_tale_worlds_1_1_engine_1_1_utilities.html#af922dd9df5b28af0dde86f7e0ebd48b8) (int startIndex, int endIndex, long curKey, int grainSize) |
| static void | [ClearShaderMemory](class_tale_worlds_1_1_engine_1_1_utilities.html#affa29f7ac05bd90ffe6e926a61b6e0ff) () |
| static void | [RegisterMeshForGPUMorph](class_tale_worlds_1_1_engine_1_1_utilities.html#a71885f46bf502ea5bdc6e385f7a8d86e) (string metaMeshName) |
| static void | [ParallelForWithDt](class_tale_worlds_1_1_engine_1_1_utilities.html#af02c67a1e13d327cfeccd79d5a3a4140) (int startIndex, int endIndex, long curKey, int grainSize) |
| static ulong | [GetMainThreadId](class_tale_worlds_1_1_engine_1_1_utilities.html#a9a5b15b42081c432600fe601304bb4e7) () |
| static ulong | [GetCurrentThreadId](class_tale_worlds_1_1_engine_1_1_utilities.html#a62236126d8234324af88d7be8686ba60) () |
| static void | [SetWatchdogValue](class_tale_worlds_1_1_engine_1_1_utilities.html#add9a413eb97ac14ebaef0eebc5fe149d) (string fileName, string groupName, string key, string value) |
| static void | [SetWatchdogAutoreport](class_tale_worlds_1_1_engine_1_1_utilities.html#ab396c16d329ad7aa1d142222832fed12) (bool enabled) |
| static void | [DetachWatchdog](class_tale_worlds_1_1_engine_1_1_utilities.html#a5f3c68d69cc728c491512777f523fb31) () |
| static string | [GetPlatformModulePaths](class_tale_worlds_1_1_engine_1_1_utilities.html#a0c1fcfbf3e6eeed0012d000ebc1cb726) () |
| static bool | [IsAsyncPhysicsThread](class_tale_worlds_1_1_engine_1_1_utilities.html#a91fc014a3af2bed0c88de569f25392b0) () |
| static void | [StartLoadingStuckCheckState](class_tale_worlds_1_1_engine_1_1_utilities.html#af2b2bddd973b6956d915800158f460aa) (float timeoutThresholdSeconds) |
| static void | [EndLoadingStuckCheckState](class_tale_worlds_1_1_engine_1_1_utilities.html#ae12efaf3e8a8a96f0f895469b219856a) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [renderingActive](class_tale_worlds_1_1_engine_1_1_utilities.html#ac8b4799a257533ad4e5a408df12d4bea) = true |

|  |  |
| --- | --- |
| Properties | |
| static int | [EngineFrameNo](class_tale_worlds_1_1_engine_1_1_utilities.html#acade7cbdef3b52065d0a520062fd5cd5) `[get]` |
| static bool | [EditModeEnabled](class_tale_worlds_1_1_engine_1_1_utilities.html#a015025dff3d8b81eca140bc18bcadb31) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75)EngineRenderDisplayMode
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.Utilities.EngineRenderDisplayMode](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75) |

| Enumerator | |
| --- | --- |
| ShowNone |  |
| ShowAlbedo |  |
| ShowNormals |  |
| ShowVertexNormals |  |
| ShowSpecular |  |
| ShowGloss |  |
| ShowOcclusion |  |
| ShowGbufferShadowMask |  |
| ShowTranslucency |  |
| ShowMotionVector |  |
| ShowVertexColor |  |
| ShowDepth |  |
| ShowTiledLightOverdraw |  |
| ShowTiledDecalOverdraw |  |
| ShowMeshId |  |
| ShowDisableSunLighting |  |
| ShowDebugTexture |  |
| ShowTextureDensity |  |
| ShowOverdraw |  |
| ShowVsComplexity |  |
| ShowPsComplexity |  |
| ShowDisableAmbientLighting |  |
| ShowEntityId |  |
| ShowPrtDiffuseAmbient |  |
| ShowLightDebugMode |  |
| ShowParticleShadingAtlas |  |
| ShowTerrainAngle |  |
| ShowParallaxDebug |  |
| ShowAlbedoValidation |  |
| NumDebugModes |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a541bc1a5d47f7091172530ba00b8cd43)InitializeMemoryLogger()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.InitializeMemoryLogger | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#acff2ab0e442f3b465716a384e9228c60)CaptureMemory()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.CaptureMemory | ( | string | *name* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a2efacf9535e8a91284034bca00e0aaf1)ConstructMainThreadJob() [1/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.ConstructMainThreadJob | ( | Delegate | *function*, | |  |  | params object[] | *parameters* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a6ae828f3ffec3114242abb4ae762f03b)ConstructMainThreadJob() [2/2]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.ConstructMainThreadJob | ( | Semaphore | *semaphore*, | |  |  | Delegate | *function*, | |  |  | params object[] | *parameters* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a977f4c25f999ed33bfa902d7f5d18d90)RunJobs()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.RunJobs | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aa3c7a6d9aece90e2cb243a0f91665fed)WaitJobs()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.WaitJobs | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a5a2671acb5047b370c66dac221be682f)OutputBenchmarkValuesToPerformanceReporter()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.OutputBenchmarkValuesToPerformanceReporter | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a4e118903ca63298786d86414036f19ec)SetLoadingScreenPercentage()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetLoadingScreenPercentage | ( | float | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a1d7ee500c161e9ea5040b476e3bdc59e)SetFixedDt()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetFixedDt | ( | bool | *enabled*, | |  |  | float | *dt* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a3f348d32d08cfef373e7cf76a8f18bcd)SetBenchmarkStatus()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetBenchmarkStatus | ( | int | *status*, | |  |  | string | *def* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a78688c65f3d72a68f13a241fe14d7570)GetBenchmarkStatus()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.GetBenchmarkStatus | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a9fb14fd72f02db5a59098550a22e8325)GetApplicationMemoryStatistics()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetApplicationMemoryStatistics | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a688275e642eb61121872052a5f8072f8)IsBenchmarkQuited()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.IsBenchmarkQuited | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aa5277142386c2b5374e7334b95b0fac9)GetNativeMemoryStatistics()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetNativeMemoryStatistics | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a29facfb73b9d58600d3b3d3fd4b2e967)CommandLineArgumentExists()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.CommandLineArgumentExists | ( | String | *str* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae003b2fda528d82e375a5c5a2aa19aee)GetConsoleHostMachine()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetConsoleHostMachine | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a70c6d6fa981b25b2b3a647987a363edf)ExportNavMeshFaceMarks()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.ExportNavMeshFaceMarks | ( | string | *file\_name* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a49c20f0ddc8b7124efec2594e80af090)TakeSSFromTop()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.TakeSSFromTop | ( | string | *file\_name* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a9b0e75a4d795155d6c266056c71dde2d)CheckIfAssetsAndSourcesAreSame()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.CheckIfAssetsAndSourcesAreSame | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a38ab3ce75700655756e6d48e3f5b610c)DisableCoreGame()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DisableCoreGame | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a84e087cbe7b654598f06ee819a8fb7e9)GetApplicationMemory()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.Utilities.GetApplicationMemory | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aeb49f4be59e35e8c618c34aa8ae4344e)GatherCoreGameReferences()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.GatherCoreGameReferences | ( | string | *scene\_names* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a4196861d6bf55c363bfb2d4e0c478b56)IsOnlyCoreContentEnabled()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.IsOnlyCoreContentEnabled | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a71de8e86d76c329f45792eb84b556b4a)FindMeshesWithoutLods()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.FindMeshesWithoutLods | ( | string | *module\_name* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#abb37839d35801b6539ef289534705efc)SetDisableDumpGeneration()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetDisableDumpGeneration | ( | bool | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a45e7c0f7598ad1c53704b7903efbdeb8)SetPrintCallstackAtCrahses()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetPrintCallstackAtCrahses | ( | bool | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae405cbedecf4dde42cf0fa342fca7ef2)GetModulesNames()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string[] TaleWorlds.Engine.Utilities.GetModulesNames | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a1de5be3d21c6bf051299b4aa0753f260)GetFullFilePathOfScene()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetFullFilePathOfScene | ( | string | *sceneName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a569ccbf2ea56c999e8533fdda624d0af)TryGetFullFilePathOfScene()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.TryGetFullFilePathOfScene | ( | string | *sceneName*, | |  |  | out string | *fullPath* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a0dae7220a56a44b47fe7a1b341d1dd69)TryGetUniqueIdentifiersForScene()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.TryGetUniqueIdentifiersForScene | ( | string | *sceneName*, | |  |  | out [UniqueSceneId](class_tale_worlds_1_1_library_1_1_unique_scene_id.html) | *identifiers* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ada0d6348bf178e6cb29baec7b20a8188)TryGetUniqueIdentifiersForSceneFile()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.TryGetUniqueIdentifiersForSceneFile | ( | string | *xsceneFilePath*, | |  |  | out [UniqueSceneId](class_tale_worlds_1_1_library_1_1_unique_scene_id.html) | *identifiers* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a388d48535541a826c7e7ba2fe69e1db8)PairSceneNameToModuleName()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.PairSceneNameToModuleName | ( | string | *sceneName*, | |  |  | string | *moduleName* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ac7be2f6e5b9bfbcbd379957d3ada7bb1)GetSingleModuleScenesOfModule()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string[] TaleWorlds.Engine.Utilities.GetSingleModuleScenesOfModule | ( | string | *moduleName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a686098dfc3645d426bb0e25565395163)GetFullCommandLineString()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetFullCommandLineString | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a45014e3af172ca73427b5842cdf90f73)SetScreenTextRenderingState()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetScreenTextRenderingState | ( | bool | *state* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a14801d1ce28ca85a4656d359132b0ece)SetMessageLineRenderingState()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetMessageLineRenderingState | ( | bool | *state* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a8b73ae45f17074c0daa95c4febe85c18)CheckIfTerrainShaderHeaderGenerationFinished()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.CheckIfTerrainShaderHeaderGenerationFinished | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#adfa16df1c61fc19b9db80940efe9e909)GenerateTerrainShaderHeaders()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.GenerateTerrainShaderHeaders | ( | string | *targetPlatform*, | |  |  | string | *targetConfig*, | |  |  | string | *output\_path* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#acced2d5e4e4823d054d0a7f4c0da7c86)CompileTerrainShadersDist()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.CompileTerrainShadersDist | ( | string | *targetPlatform*, | |  |  | string | *targetConfig*, | |  |  | string | *output\_path* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a06c4688f68cd28fe462627df9662c294)SetCrashOnAsserts()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetCrashOnAsserts | ( | bool | *val* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a9795dbb98693f3cccc021599ec932c70)SetCrashOnWarnings()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetCrashOnWarnings | ( | bool | *val* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a23fd8bd7382d284f5d26c892c516b9cd)SetCreateDumpOnWarnings()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetCreateDumpOnWarnings | ( | bool | *val* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#adc60ea9032b587ce7cfd1f544c07e035)ToggleRender()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.ToggleRender | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aa148797e6b1b0f894becb0401c0af828)SetRenderAgents()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetRenderAgents | ( | bool | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aac8831af6bf8af0b6076be93e6e00501)CheckShaderCompilation()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.CheckShaderCompilation | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a70fcd78bc5a88a108a01aadd749dfa54)CompileAllShaders()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.CompileAllShaders | ( | string | *targetPlatform* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a76917413aefddcc7351c5237a69df9dd)GetExecutableWorkingDirectory()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetExecutableWorkingDirectory | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a4bed69096c1908852acd30be45012bda)SetDumpFolderPath()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetDumpFolderPath | ( | string | *path* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#abdc07e9b2fd605eaf849f23ca0a9632a)CheckSceneForProblems()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.CheckSceneForProblems | ( | string | *sceneName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a7853739474f4ba9b94db7339b93db0eb)SetCoreGameState()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetCoreGameState | ( | int | *state* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae9bcdf8a663ae48c82474e2a148a1696)GetCoreGameState()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.GetCoreGameState | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aa6ff6d3d78b09996e7b9a7a3ce0682a4)ExecuteCommandLineCommand()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.ExecuteCommandLineCommand | ( | string | *command* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a1cbefe242ef476c918870e1eceab7564)QuitGame()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.QuitGame | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae0ea4b278bf61351beff2b95829dea39)ExitProcess()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.ExitProcess | ( | int | *exitCode* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a3437335edb80299baa3d003af3b5e24d)GetBasePath()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetBasePath | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae20d71f43569b5dd45dd2197069f2439)GetVisualTestsValidatePath()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetVisualTestsValidatePath | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aa515206f77e5fb29c3d32b4c4ef20719)GetVisualTestsTestFilesPath()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetVisualTestsTestFilesPath | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a68640afc749fbcf9bf069ace15cd27c8)GetAttachmentsPath()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetAttachmentsPath | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aeda6d086d1b2abbe0075c913c64ebdd8)StartScenePerformanceReport()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.StartScenePerformanceReport | ( | string | *folderPath* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ad62358502e05c4d0545c860a4902a5d2)IsSceneReportFinished()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.IsSceneReportFinished | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#acf6cdc7a36c3ff454993bc2822633de5)GetFps()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.Utilities.GetFps | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae21dcc33d30478f2ddbbd95fc8c66e7a)GetMainFps()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.Utilities.GetMainFps | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a794d00d893f3417d3b87a76b0294be48)GetRendererFps()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.Utilities.GetRendererFps | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#af983efc99adb6cb06a42c5d6536edeb5)EnableSingleGPUQueryPerFrame()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.EnableSingleGPUQueryPerFrame | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aaec59cad32d37f88bcb577b6f8abc4cc)ClearDecalAtlas()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.ClearDecalAtlas | ( | [DecalAtlasGroup](namespace_tale_worlds_1_1_engine.html#a4e991dea1484f83dd32afa4020ec8bef) | *atlasGroup* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#af92bda619e727e7468622b9d400b3dc0)FlushManagedObjectsMemory()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.FlushManagedObjectsMemory | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a03c1f2169eb6cb845bd3ec95267a61d4)OnLoadingWindowEnabled()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.OnLoadingWindowEnabled | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a9512b1169fa1f7b8021bfc2adcc7c658)DebugSetGlobalLoadingWindowState()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DebugSetGlobalLoadingWindowState | ( | bool | *newState* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae9c9a73a720cfe904a7ae3ad2e8f8b06)OnLoadingWindowDisabled()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.OnLoadingWindowDisabled | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aff0bbf155dc8d35186408b4f38379b85)DisableGlobalLoadingWindow()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DisableGlobalLoadingWindow | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a248d410be6e07de0376cf75affeb9d12)EnableGlobalLoadingWindow()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.EnableGlobalLoadingWindow | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#acf86eec4dd67e018daf3949c53e483c2)EnableGlobalEditDataCacher()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.EnableGlobalEditDataCacher | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aabd24fe165697c9af43886d2fb927e78)DoFullBakeAllLevelsAutomated()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DoFullBakeAllLevelsAutomated | ( | string | *module*, | |  |  | string | *scene* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a0b78369cbd02bc5ffad569c1d5af165d)GetReturnCode()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.GetReturnCode | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a60ee9f2b2609106f33ccd78d8d33534d)DisableGlobalEditDataCacher()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DisableGlobalEditDataCacher | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a1d32a81b6d26afa21cda908e505e56d0)DoFullBakeSingleLevelAutomated()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DoFullBakeSingleLevelAutomated | ( | string | *module*, | |  |  | string | *scene* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a10520f6d8e1be317d6d07391fb46e259)DoLightOnlyBakeSingleLevelAutomated()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DoLightOnlyBakeSingleLevelAutomated | ( | string | *module*, | |  |  | string | *scene* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a098bae36f61f5147eac912982341fc4c)DoLightOnlyBakeAllLevelsAutomated()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DoLightOnlyBakeAllLevelsAutomated | ( | string | *module*, | |  |  | string | *scene* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a941b024d9f404b4c254703503027cd97)DidAutomatedGIBakeFinished()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.DidAutomatedGIBakeFinished | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a94d7a8c80e8b7b40f0dcddd6ed13ccff)GetSelectedEntities()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.GetSelectedEntities | ( | ref List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *gameEntities* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a64fa9472dc9359866ce2cffc2c2bacce)DeleteEntitiesInEditorScene()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DeleteEntitiesInEditorScene | ( | List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *gameEntities* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a0c3e9b1f154d752e920defcd3674b2ca)CreateSelectionInEditor()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.CreateSelectionInEditor | ( | List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *gameEntities*, | |  |  | string | *name* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aea1ff8cb842fd006257c4f8d140e610d)SelectEntities()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SelectEntities | ( | List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *gameEntities* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a195d0d1352c9a1285a339846b1615b78)GetEntitiesOfSelectionSet()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.GetEntitiesOfSelectionSet | ( | string | *selectionSetName*, | |  |  | ref List< [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) > | *gameEntities* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a4974935ff7f768adc578b50d4fbb0afe)AddCommandLineFunction()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.AddCommandLineFunction | ( | string | *concatName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#afd9b3b45b0d5dbf61478609a041adb3e)GetNumberOfShaderCompilationsInProgress()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.GetNumberOfShaderCompilationsInProgress | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aa9230cf09379524f10915a2571f163a5)IsDetailedSoundLogOn()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.IsDetailedSoundLogOn | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a5d6879751bffef0e60dc7ee80387d0d8)GetCurrentCpuMemoryUsageMB()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | UInt64 TaleWorlds.Engine.Utilities.GetCurrentCpuMemoryUsageMB | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a67643571fa6ee5c015e85919e3d865fd)GetGpuMemoryOfAllocationGroup()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | UInt64 TaleWorlds.Engine.Utilities.GetGpuMemoryOfAllocationGroup | ( | string | *name* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#af2943580476a65f6e4d1bc6f58fb94c7)GetGPUMemoryStats()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.GetGPUMemoryStats | ( | ref float | *totalMemory*, | |  |  | ref float | *renderTargetMemory*, | |  |  | ref float | *depthTargetMemory*, | |  |  | ref float | *srvMemory*, | |  |  | ref float | *bufferMemory* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a7b22a30fe221f57cadd3283d4ac23045)GetDetailedGPUMemoryData()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.GetDetailedGPUMemoryData | ( | ref int | *totalMemoryAllocated*, | |  |  | ref int | *totalMemoryUsed*, | |  |  | ref int | *emptyChunkTotalSize* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae8892e429bb3079b59cf4d513f93b6e5)SetRenderMode()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetRenderMode | ( | [EngineRenderDisplayMode](class_tale_worlds_1_1_engine_1_1_utilities.html#a74c5b49a9b64eb789664664f96087a75) | *mode* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae8716b01c9c50e27d81c96db09d6cfcc)SetForceDrawEntityID()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetForceDrawEntityID | ( | bool | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ada25eabb4de4212793b328f0db3e4517)AddPerformanceReportToken()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.AddPerformanceReportToken | ( | string | *performance\_type*, | |  |  | string | *name*, | |  |  | float | *loading\_time* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#abde1df176ac1747202f7b46243b19acd)AddSceneObjectReport()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.AddSceneObjectReport | ( | string | *scene\_name*, | |  |  | string | *report\_name*, | |  |  | float | *report\_value* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a60c386af14d23194005348bfbcd7e552)OutputPerformanceReports()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.OutputPerformanceReports | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aa41e4a4e431fb1b2ddc52d2c2aa16af1)TakeScreenshot() [1/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.TakeScreenshot | ( | [PlatformFilePath](struct_tale_worlds_1_1_library_1_1_platform_file_path.html) | *path* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a835132d20eab4de804df796cc6a95da8)TakeScreenshot() [2/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.TakeScreenshot | ( | string | *path* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#aeeb50aecb86dcd4abd6049e69632e903)SetAllocationAlwaysValidScene()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetAllocationAlwaysValidScene | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a43da3ef44c3be595f5fe5168fa538320)CheckResourceModifications()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.CheckResourceModifications | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ab3785c5bc582407bfb9ac600248e5bfa)SetGraphicsPreset()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetGraphicsPreset | ( | int | *preset* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a32b6a2d22e6655495f8634aa18e9e953)GetLocalOutputPath()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetLocalOutputPath | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a62e531d154ace4669c3fde7528580edc)GetPCInfo()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetPCInfo | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a1aa5dc3ee9cb7058e606f7fdf289baa2)GetGPUMemoryMB()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.GetGPUMemoryMB | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a2d5ea95b2f28aba9a16e951f7aee1a41)GetCurrentEstimatedGPUMemoryCostMB()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.GetCurrentEstimatedGPUMemoryCostMB | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a0b8144ab7039431cc1718ddeaf20c06a)DumpGPUMemoryStatistics()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DumpGPUMemoryStatistics | ( | string | *filePath* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a338a5dac5de37b139a5f867367ab5d1d)SaveDataAsTexture()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.SaveDataAsTexture | ( | string | *path*, | |  |  | int | *width*, | |  |  | int | *height*, | |  |  | float[] | *data* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#add19848e553db20402844e5f661e392a)ClearOldResourcesAndObjects()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.ClearOldResourcesAndObjects | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a80f158ff024537ae83f8bdfe3fc74edf)LoadVirtualTextureTileset()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.LoadVirtualTextureTileset | ( | string | *name* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a8809add3d9fbabdc0ec0c6bebda134ee)GetDeltaTime()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Engine.Utilities.GetDeltaTime | ( | int | *timerId* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#af3ceb66e9432a9d63aca4445e5b1c186)LoadSkyBoxes()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.LoadSkyBoxes | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a90945da0a6b40730e1893fa18bfe4ee2)GetApplicationName()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetApplicationName | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a726cacb0ecb150c3033ab71075399c16)OpenNavalDlcPurchasePage()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.OpenNavalDlcPurchasePage | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#af0e487b2ab5eb6ee54e81559d751f966)SetWindowTitle()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetWindowTitle | ( | string | *title* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a8c0f909e9602918f1d8ca7048f7f3859)ProcessWindowTitle()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.ProcessWindowTitle | ( | string | *title* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a1afb94b338d9a0a1dbdb5342c6308c23)GetCurrentProcessID()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | uint TaleWorlds.Engine.Utilities.GetCurrentProcessID | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a6c7d6f910a23c1751887e59e1bceaa6e)DoDelayedexit()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DoDelayedexit | ( | int | *returnCode* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae8d276139f56a9e608983ed238ce41a4)SetAssertionsAndWarningsSetExitCode()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetAssertionsAndWarningsSetExitCode | ( | bool | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a2344bae4ffe661057a5654dcbd5099bf)SetReportMode()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetReportMode | ( | bool | *reportMode* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a11c593169c33359ac8918ccfcf878e83)SetAssertionAtShaderCompile()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetAssertionAtShaderCompile | ( | bool | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ad4c74826a8abd20c95273d35e0f82a68)SetCrashReportCustomString()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetCrashReportCustomString | ( | string | *customString* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a7631580d165708f24f5fb7485a8a5d28)SetCrashReportCustomStack()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetCrashReportCustomStack | ( | string | *customStack* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ac1d9c64f28e5fe95e86a753be12582cb)GetSteamAppId()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.GetSteamAppId | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a1c2695a02245f8c0e518f20adf02882a)SetForceVsync()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetForceVsync | ( | bool | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae8da2a970462ca2e9a4030d4664699d2)LoadBannerlordConfigFile()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.LoadBannerlordConfigFile | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a2665e9fdcfded43445114c6a7be898d7)SaveConfigFile()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [SaveResult](namespace_tale_worlds_1_1_library.html#a1fede41b93a35a4b6f9d87fcab58a5bc) TaleWorlds.Engine.Utilities.SaveConfigFile | ( | string | *configProperties* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a412474ec95e18d5442fe4b6f6d52819d)OpenOnscreenKeyboard()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.OpenOnscreenKeyboard | ( | string | *initialText*, | |  |  | string | *descriptionText*, | |  |  | int | *maxLength*, | |  |  | int | *keyboardTypeEnum* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a082ed2b650bc2b2dfc5dc0ec2c18a5ca)GetSystemLanguage()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetSystemLanguage | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ac4b3e18c76adc46208506a91607be951)RegisterGPUAllocationGroup()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.RegisterGPUAllocationGroup | ( | string | *name* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a9a69c0008b1476399fbcc313616cdbee)GetMemoryUsageOfCategory()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.GetMemoryUsageOfCategory | ( | int | *category* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#af0e644c3332aa4545f0c4cbc23c979d8)GetDetailedXBOXMemoryInfo()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetDetailedXBOXMemoryInfo | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a98d27de0f19d74cb06447220ce416354)SetFrameLimiterWithSleep()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetFrameLimiterWithSleep | ( | bool | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a7e362d89881b8178d5679efd8076fb6f)GetFrameLimiterWithSleep()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.GetFrameLimiterWithSleep | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a93497f35bef300000055c291a7327e25)GetPossibleCommandLineStartingWith()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetPossibleCommandLineStartingWith | ( | string | *command*, | |  |  | int | *index* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a4623c4181e161bbfb93507899b8c63a4)IsDevkit()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.IsDevkit | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a18f68655e3a211001845af72f1444e18)IsLockhartPlatform()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.IsLockhartPlatform | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a0a6dca0a292bc919b4afc1c192ad22f5)GetVertexBufferChunkSystemMemoryUsage()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.GetVertexBufferChunkSystemMemoryUsage | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a6174b165d9cfa5fa4b59fe206a11d17b)GetBuildNumber()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.Engine.Utilities.GetBuildNumber | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ad85ef9f027683f1d1f67593fdbeaebcb)GetApplicationVersionWithBuildNumber()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [ApplicationVersion](struct_tale_worlds_1_1_library_1_1_application_version.html) TaleWorlds.Engine.Utilities.GetApplicationVersionWithBuildNumber | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a4c7fadebed9166a66c89fc543f6793e1)ParallelFor()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.ParallelFor | ( | int | *startIndex*, | |  |  | int | *endIndex*, | |  |  | long | *curKey*, | |  |  | int | *grainSize* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#af922dd9df5b28af0dde86f7e0ebd48b8)ParallelForWithoutRenderThread()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.ParallelForWithoutRenderThread | ( | int | *startIndex*, | |  |  | int | *endIndex*, | |  |  | long | *curKey*, | |  |  | int | *grainSize* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#affa29f7ac05bd90ffe6e926a61b6e0ff)ClearShaderMemory()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.ClearShaderMemory | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a71885f46bf502ea5bdc6e385f7a8d86e)RegisterMeshForGPUMorph()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.RegisterMeshForGPUMorph | ( | string | *metaMeshName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#af02c67a1e13d327cfeccd79d5a3a4140)ParallelForWithDt()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.ParallelForWithDt | ( | int | *startIndex*, | |  |  | int | *endIndex*, | |  |  | long | *curKey*, | |  |  | int | *grainSize* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a9a5b15b42081c432600fe601304bb4e7)GetMainThreadId()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | ulong TaleWorlds.Engine.Utilities.GetMainThreadId | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a62236126d8234324af88d7be8686ba60)GetCurrentThreadId()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | ulong TaleWorlds.Engine.Utilities.GetCurrentThreadId | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#add9a413eb97ac14ebaef0eebc5fe149d)SetWatchdogValue()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetWatchdogValue | ( | string | *fileName*, | |  |  | string | *groupName*, | |  |  | string | *key*, | |  |  | string | *value* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ab396c16d329ad7aa1d142222832fed12)SetWatchdogAutoreport()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.SetWatchdogAutoreport | ( | bool | *enabled* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a5f3c68d69cc728c491512777f523fb31)DetachWatchdog()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.DetachWatchdog | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a0c1fcfbf3e6eeed0012d000ebc1cb726)GetPlatformModulePaths()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.Engine.Utilities.GetPlatformModulePaths | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a91fc014a3af2bed0c88de569f25392b0)IsAsyncPhysicsThread()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Utilities.IsAsyncPhysicsThread | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#af2b2bddd973b6956d915800158f460aa)StartLoadingStuckCheckState()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.StartLoadingStuckCheckState | ( | float | *timeoutThresholdSeconds* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ae12efaf3e8a8a96f0f895469b219856a)EndLoadingStuckCheckState()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.Utilities.EndLoadingStuckCheckState | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#ac8b4799a257533ad4e5a408df12d4bea)renderingActive
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Utilities.renderingActive = true | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#acade7cbdef3b52065d0a520062fd5cd5)EngineFrameNo
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.Utilities.EngineFrameNo | | staticget |

[◆](class_tale_worlds_1_1_engine_1_1_utilities.html#a015025dff3d8b81eca140bc18bcadb31)EditModeEnabled
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Utilities.EditModeEnabled | | staticget |

