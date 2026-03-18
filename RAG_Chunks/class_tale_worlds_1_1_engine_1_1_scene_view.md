--- SOURCE: class_tale_worlds_1_1_engine_1_1_scene_view.html ---

TaleWorlds.Engine.SceneView Class ReferenceInherits [TaleWorlds.Engine.View](class_tale_worlds_1_1_engine_1_1_view.html).

Inherited by [TaleWorlds.Engine.TableauView](class_tale_worlds_1_1_engine_1_1_tableau_view.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetScene](class_tale_worlds_1_1_engine_1_1_scene_view.html#a3bc9656ac0393f734c79645c38e2024e) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| void | [SetAcceptGlobalDebugRenderObjects](class_tale_worlds_1_1_engine_1_1_scene_view.html#a30dc9980087bae58b4efce648dbbe527) (bool value) |
| void | [SetRenderWithPostfx](class_tale_worlds_1_1_engine_1_1_scene_view.html#abf531b462ff455ff18fa348cbbee4d17) (bool value) |
| void | [SetPostfxConfigParams](class_tale_worlds_1_1_engine_1_1_scene_view.html#afa0c78f3265e70b26ead548422286df1) (int value) |
| void | [SetForceShaderCompilation](class_tale_worlds_1_1_engine_1_1_scene_view.html#a57db9e76095a26d839652c7387a5b72a) (bool value) |
| bool | [CheckSceneReadyToRender](class_tale_worlds_1_1_engine_1_1_scene_view.html#aa0f3e30990f6d456d1c6a13d179b26d9) () |
| void | [SetDoQuickExposure](class_tale_worlds_1_1_engine_1_1_scene_view.html#a63dea462a78de4b0f422032681d62f18) (bool value) |
| void | [SetCamera](class_tale_worlds_1_1_engine_1_1_scene_view.html#a64dd576e49e15b692ea0587103db6a0a) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera) |
| void | [SetResolutionScaling](class_tale_worlds_1_1_engine_1_1_scene_view.html#ad11967544371b99ec72c1264664e9fab) (bool value) |
| void | [SetPostfxFromConfig](class_tale_worlds_1_1_engine_1_1_scene_view.html#a5fc2b67e9a69c4bcc81ca7e8b3db3b61) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [WorldPointToScreenPoint](class_tale_worlds_1_1_engine_1_1_scene_view.html#aadeb58b7ab4ee5d8331b2f92e830f1d7) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [ScreenPointToViewportPoint](class_tale_worlds_1_1_engine_1_1_scene_view.html#a96c237ebea603f14abeaeaf5aad7cda4) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| bool | [ProjectedMousePositionOnGround](class_tale_worlds_1_1_engine_1_1_scene_view.html#a61615b66502adbee49bc3b99a636a71c) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) groundPosition, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) groundNormal, bool mouseVisible, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyOwnerFlags, bool checkOccludedSurface) |
| bool | [ProjectedMousePositionOnWater](class_tale_worlds_1_1_engine_1_1_scene_view.html#a9ab77e6192aab1f243e3b4492ab39831) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) waterPosition, bool mouseVisible) |
| void | [TranslateMouse](class_tale_worlds_1_1_engine_1_1_scene_view.html#a16835010e3b40775bcb931d52a87c1d0) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseNear, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseFar, float maxDistance=-1) |
| void | [SetSceneUsesSkybox](class_tale_worlds_1_1_engine_1_1_scene_view.html#ac8cabd8e75a688e35173f2363a388963) (bool value) |
| void | [SetSceneUsesShadows](class_tale_worlds_1_1_engine_1_1_scene_view.html#a8efe5b4b0064520f34c115a8a5eb5f2f) (bool value) |
| void | [SetSceneUsesContour](class_tale_worlds_1_1_engine_1_1_scene_view.html#a3777f5bf514a4e658a5ae1b71c27ce72) (bool value) |
| void | [DoNotClear](class_tale_worlds_1_1_engine_1_1_scene_view.html#a35ca35e15f2532bb9a977a7acf1eadf5) (bool value) |
| void | [AddClearTask](class_tale_worlds_1_1_engine_1_1_scene_view.html#a233e8d11e592c3ea58288d0d6e5170ab) (bool clearOnlySceneview=false) |
| bool | [ReadyToRender](class_tale_worlds_1_1_engine_1_1_scene_view.html#a61799175eb558aca44201ffd72c9e3ee) () |
| void | [SetClearAndDisableAfterSucessfullRender](class_tale_worlds_1_1_engine_1_1_scene_view.html#a8368491860507354161a1e046f5da3be) (bool value) |
| void | [SetClearGbuffer](class_tale_worlds_1_1_engine_1_1_scene_view.html#a58d0149f22191fa04599da9c5a340f8d) (bool value) |
| void | [SetShadowmapResolutionMultiplier](class_tale_worlds_1_1_engine_1_1_scene_view.html#a2c331f1d6eb237532694a180acd95ca9) (float value) |
| void | [SetPointlightResolutionMultiplier](class_tale_worlds_1_1_engine_1_1_scene_view.html#a2935ce8ed51f914b1eb2c05fb872e25e) (float value) |
| void | [SetCleanScreenUntilLoadingDone](class_tale_worlds_1_1_engine_1_1_scene_view.html#a0de19718da088f78ad900c2bc713d7da) (bool value) |
| void | [ClearAll](class_tale_worlds_1_1_engine_1_1_scene_view.html#a26ef9f69680de602a6511562ba31b264) (bool clearScene, bool removeTerrain) |
| void | [SetFocusedShadowmap](class_tale_worlds_1_1_engine_1_1_scene_view.html#a6bb5b6e4c196c78daea0433d096c8961) (bool enable, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) center, float radius) |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | [GetScene](class_tale_worlds_1_1_engine_1_1_scene_view.html#ab3cc4257fd47b30fd2120c5a2be3c78f) () |
| bool | [RayCastForClosestEntityOrTerrain](class_tale_worlds_1_1_engine_1_1_scene_view.html#a746991f36b9bbe7d1d0f641fafd50c08) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) sourcePoint, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, out float collisionDistance, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) closestPoint, float rayThickness=0.01f, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyFlags=[BodyFlags.CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2)) |
| Public Member Functions inherited from [TaleWorlds.Engine.View](class_tale_worlds_1_1_engine_1_1_view.html) | |
| void | [SetScale](class_tale_worlds_1_1_engine_1_1_view.html#aa8a790209e9e64d43f00e905827af0c1) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scale) |
| void | [SetOffset](class_tale_worlds_1_1_engine_1_1_view.html#a86b8ea55866eaa59af32f88b4d59d646) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) offset) |
| void | [SetRenderOrder](class_tale_worlds_1_1_engine_1_1_view.html#a99360adc077bf86de9affce51d920e22) (int value) |
| void | [SetRenderOption](class_tale_worlds_1_1_engine_1_1_view.html#a2877539f9ae2038a866d340f938403a2) ([ViewRenderOptions](class_tale_worlds_1_1_engine_1_1_view.html#a745fafaaeab0d0c4bb8e90399a3476c4) optionEnum, bool value) |
| void | [SetRenderTarget](class_tale_worlds_1_1_engine_1_1_view.html#a5acd413e0d1c0330f80dfc34ebd9d310) ([Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture) |
| void | [SetDepthTarget](class_tale_worlds_1_1_engine_1_1_view.html#aec1e3d8beabfae798d36bd6fd41afa02) ([Texture](class_tale_worlds_1_1_engine_1_1_texture.html) texture) |
| void | [DontClearBackground](class_tale_worlds_1_1_engine_1_1_view.html#a02bf56d39133d1096f32a12895047815) () |
| void | [SetClearColor](class_tale_worlds_1_1_engine_1_1_view.html#a8c0e54a03615c9926b0f6b5cbee060aa) (uint rgba) |
| void | [SetEnable](class_tale_worlds_1_1_engine_1_1_view.html#ad1538d9258f5bc3e3732c56d4bbe07ce) (bool value) |
| void | [SetRenderOnDemand](class_tale_worlds_1_1_engine_1_1_view.html#a3c4e2f2eac2c81871410b7848c06ea02) (bool value) |
| void | [SetAutoDepthTargetCreation](class_tale_worlds_1_1_engine_1_1_view.html#a1defe19e821039659fd9b1bfb2967eed) (bool value) |
| void | [SetSaveFinalResultToDisk](class_tale_worlds_1_1_engine_1_1_view.html#adaeb3e7431b75674d210bcc3a1cdf38f) (bool value) |
| void | [SetFileNameToSaveResult](class_tale_worlds_1_1_engine_1_1_view.html#a1380c8ec27667c1255fc3703adad3472) (string name) |
| void | [SetFileTypeToSave](class_tale_worlds_1_1_engine_1_1_view.html#a3b910c2f976828a04daa9b8b6868ac12) ([TextureSaveFormat](class_tale_worlds_1_1_engine_1_1_view.html#a785fed3d7240bf2a414cc2aaaf360283) format) |
| void | [SetFilePathToSaveResult](class_tale_worlds_1_1_engine_1_1_view.html#a6487a322c0cb3628683a0c58a2ac995b) (string name) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static SceneView | [CreateSceneView](class_tale_worlds_1_1_engine_1_1_scene_view.html#a8218e754e473e655790875b1e7746fd1) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Public Types inherited from [TaleWorlds.Engine.View](class_tale_worlds_1_1_engine_1_1_view.html) | |
| enum | [TextureSaveFormat](class_tale_worlds_1_1_engine_1_1_view.html#a785fed3d7240bf2a414cc2aaaf360283) {     [TextureTypeUnknown](class_tale_worlds_1_1_engine_1_1_view.html#a785fed3d7240bf2a414cc2aaaf360283a138e196228213d0118510d12632a5813) ,     [TextureTypeBmp](class_tale_worlds_1_1_engine_1_1_view.html#a785fed3d7240bf2a414cc2aaaf360283a0afaada6eb3dd71439f17f16aa9dc3a1) ,     [TextureTypeJpg](class_tale_worlds_1_1_engine_1_1_view.html#a785fed3d7240bf2a414cc2aaaf360283a3833602d9331e6f373f09e4216bb0324) ,     [TextureTypePng](class_tale_worlds_1_1_engine_1_1_view.html#a785fed3d7240bf2a414cc2aaaf360283a2b76e9483be64f19faf44c488dc402ea) ,     [TextureTypeDds](class_tale_worlds_1_1_engine_1_1_view.html#a785fed3d7240bf2a414cc2aaaf360283a9fe5dde234c1054043adbd53ade14596) ,     [TextureTypeTif](class_tale_worlds_1_1_engine_1_1_view.html#a785fed3d7240bf2a414cc2aaaf360283aa49c2a8ab91f981f8afbd5c4b2576e6c) ,     [TextureTypePsd](class_tale_worlds_1_1_engine_1_1_view.html#a785fed3d7240bf2a414cc2aaaf360283ae5f5bb6b99005ef9a03ba16ce5848e5a) ,     [TextureTypeRaw](class_tale_worlds_1_1_engine_1_1_view.html#a785fed3d7240bf2a414cc2aaaf360283a503aac7770cded34469bcc8cae38fea1)   } |
| enum | [PostfxConfig](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245f) : uint {     [pfx\_config\_bloom](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa89f424165962dc3749330f4a822f80fc) = 0x00000001 ,     [pfx\_config\_sunshafts](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fad921f7037c92bd24af01ae834b2c8ad5) = 0x00000002 ,     [pfx\_config\_motionblur](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa2eafe4b85dad26d3e4e8a93a91262398) = 0x00000004 ,     [pfx\_config\_dof](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa95342359dc7f7f123b47cd9c05f27e1d) = 0x00000008 ,     [pfx\_config\_tsao](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245faafcff88aeb0f3f321f0ce33954719621) = 0x00000010 ,     [pfx\_config\_fxaa](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa3942060c82bee511d06a86396ad19090) = 0x00000040 ,     [pfx\_config\_smaa](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa19ee59f0196c89d4578abe16c73c8afc) = 0x00000080 ,     [pfx\_config\_temporal\_smaa](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245faaa42727c849582c96b23f74ca1a3d011) = 0x00000100 ,     [pfx\_config\_temporal\_resolve](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa2ca26eb605071aff89589468d83e655b) = 0x00000200 ,     [pfx\_config\_temporal\_filter](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245faed0be0a0f7a2aa449b40978b9f7a0583) = 0x00000400 ,     [pfx\_config\_contour](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fadad99f492395b2acbede143e14c98fbc) = 0x00000800 ,     [pfx\_config\_ssr](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa53ca9d0ec7f2cb42bdb0be1b276ec299) = 0x00001000 ,     [pfx\_config\_sssss](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa79e01d5685d92dfe5aa38f865a572352) = 0x00002000 ,     [pfx\_config\_streaks](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa91cdd9e6085979106c368c4e6242dd58) = 0x00004000 ,     [pfx\_config\_lens\_flares](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fad5e33a2e9e08ac451e2cdcb039aa1217) = 0x00008000 ,     [pfx\_config\_chromatic\_aberration](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fad24d64cb0038dfae43d7977ebaa1fc13) = 0x00010000 ,     [pfx\_config\_vignette](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fafcfb65f3d7bcbe5c9eb861d6ca26193a) = 0x00020000 ,     [pfx\_config\_sharpen](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa96124b7caaf9ff7ed3b229af19a04f34) = 0x00040000 ,     [pfx\_config\_grain](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa6ff4e2a98ff15177fbfe2301d5b7a932) = 0x00080000 ,     [pfx\_config\_temporal\_shadow](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa987df5fe1aee91e8280f043a48637a13) = 0x00100000 ,     [pfx\_config\_editor\_scene](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa19b23787215961c9e490544112b3e10f) = 0x00200000 ,     [pfx\_config\_custom1](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa9451cbbdc8f7e34d54c6c6f0337c3c23) = 0x01000000 ,     [pfx\_config\_custom2](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fac07700e865d5154d18724189da114a0e) = 0x02000000 ,     [pfx\_config\_custom3](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa1a6e3ed2a680bad58d8ee741662a4ea2) = 0x04000000 ,     [pfx\_config\_custom4](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa45b58c58c172066a070ee03cbfacc5f3) = 0x08000000 ,     [pfx\_config\_hexagon\_vignette](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa798341de30fcfda37e92c61cb5c8d940) = 0x10000000 ,     [pfx\_config\_screen\_rt\_injection](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fab944896584583d0a57e1f1d68334647e) = 0x20000000 ,     [pfx\_config\_high\_dof](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245faa23eab2e44eefde566847038f234a0f5) = 0x40000000 ,     [pfx\_lower\_bound](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa0b9172966fc6555056e4354e788bf283) = pfx\_config\_bloom ,     [pfx\_upper\_bound](class_tale_worlds_1_1_engine_1_1_view.html#a98d3e2ca7953520ad05863e6056b245fa1637083f05a655b52b4dd0def33e2670) = pfx\_config\_screen\_rt\_injection   } |
| enum | [ViewRenderOptions](class_tale_worlds_1_1_engine_1_1_view.html#a745fafaaeab0d0c4bb8e90399a3476c4) : int {     [ClearColor](class_tale_worlds_1_1_engine_1_1_view.html#a745fafaaeab0d0c4bb8e90399a3476c4a03d4c1c09e8eda328c9faa596fe8e5ac) = 0 ,     [ClearDepth](class_tale_worlds_1_1_engine_1_1_view.html#a745fafaaeab0d0c4bb8e90399a3476c4a14a82d8dde0c2fd50fc22bd275155226)   } |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a8218e754e473e655790875b1e7746fd1)CreateSceneView()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | SceneView TaleWorlds.Engine.SceneView.CreateSceneView | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a3bc9656ac0393f734c79645c38e2024e)SetScene()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetScene | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a30dc9980087bae58b4efce648dbbe527)SetAcceptGlobalDebugRenderObjects()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetAcceptGlobalDebugRenderObjects | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#abf531b462ff455ff18fa348cbbee4d17)SetRenderWithPostfx()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetRenderWithPostfx | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#afa0c78f3265e70b26ead548422286df1)SetPostfxConfigParams()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetPostfxConfigParams | ( | int | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a57db9e76095a26d839652c7387a5b72a)SetForceShaderCompilation()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetForceShaderCompilation | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#aa0f3e30990f6d456d1c6a13d179b26d9)CheckSceneReadyToRender()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.SceneView.CheckSceneReadyToRender | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a63dea462a78de4b0f422032681d62f18)SetDoQuickExposure()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetDoQuickExposure | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a64dd576e49e15b692ea0587103db6a0a)SetCamera()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetCamera | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#ad11967544371b99ec72c1264664e9fab)SetResolutionScaling()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetResolutionScaling | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a5fc2b67e9a69c4bcc81ca7e8b3db3b61)SetPostfxFromConfig()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetPostfxFromConfig | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#aadeb58b7ab4ee5d8331b2f92e830f1d7)WorldPointToScreenPoint()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.SceneView.WorldPointToScreenPoint | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a96c237ebea603f14abeaeaf5aad7cda4)ScreenPointToViewportPoint()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.SceneView.ScreenPointToViewportPoint | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a61615b66502adbee49bc3b99a636a71c)ProjectedMousePositionOnGround()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.SceneView.ProjectedMousePositionOnGround | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *groundPosition*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *groundNormal*, |
|  |  | bool | *mouseVisible*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyOwnerFlags*, |
|  |  | bool | *checkOccludedSurface* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a9ab77e6192aab1f243e3b4492ab39831)ProjectedMousePositionOnWater()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.SceneView.ProjectedMousePositionOnWater | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *waterPosition*, |
|  |  | bool | *mouseVisible* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a16835010e3b40775bcb931d52a87c1d0)TranslateMouse()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.TranslateMouse | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseNear*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseFar*, |
|  |  | float | *maxDistance* = -1 ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#ac8cabd8e75a688e35173f2363a388963)SetSceneUsesSkybox()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetSceneUsesSkybox | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a8efe5b4b0064520f34c115a8a5eb5f2f)SetSceneUsesShadows()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetSceneUsesShadows | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a3777f5bf514a4e658a5ae1b71c27ce72)SetSceneUsesContour()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetSceneUsesContour | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a35ca35e15f2532bb9a977a7acf1eadf5)DoNotClear()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.DoNotClear | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a233e8d11e592c3ea58288d0d6e5170ab)AddClearTask()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.AddClearTask | ( | bool | *clearOnlySceneview* = false | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a61799175eb558aca44201ffd72c9e3ee)ReadyToRender()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.SceneView.ReadyToRender | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a8368491860507354161a1e046f5da3be)SetClearAndDisableAfterSucessfullRender()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetClearAndDisableAfterSucessfullRender | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a58d0149f22191fa04599da9c5a340f8d)SetClearGbuffer()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetClearGbuffer | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a2c331f1d6eb237532694a180acd95ca9)SetShadowmapResolutionMultiplier()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetShadowmapResolutionMultiplier | ( | float | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a2935ce8ed51f914b1eb2c05fb872e25e)SetPointlightResolutionMultiplier()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetPointlightResolutionMultiplier | ( | float | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a0de19718da088f78ad900c2bc713d7da)SetCleanScreenUntilLoadingDone()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetCleanScreenUntilLoadingDone | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a26ef9f69680de602a6511562ba31b264)ClearAll()
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.ClearAll | ( | bool | *clearScene*, |
|  |  | bool | *removeTerrain* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a6bb5b6e4c196c78daea0433d096c8961)SetFocusedShadowmap()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.SceneView.SetFocusedShadowmap | ( | bool | *enable*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *center*, |
|  |  | float | *radius* ) |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#ab3cc4257fd47b30fd2120c5a2be3c78f)GetScene()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) TaleWorlds.Engine.SceneView.GetScene | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_scene_view.html#a746991f36b9bbe7d1d0f641fafd50c08)RayCastForClosestEntityOrTerrain()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.SceneView.RayCastForClosestEntityOrTerrain | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *sourcePoint*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | out float | *collisionDistance*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *closestPoint*, |
|  |  | float | *rayThickness* = 0::01f, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyFlags* = [BodyFlags::CommonFocusRayCastExcludeFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7aacd8a16c55eb9f62ceeb5e4adb0c7bad2) ) |

