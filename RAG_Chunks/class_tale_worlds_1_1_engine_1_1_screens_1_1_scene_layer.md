--- SOURCE: class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html ---

TaleWorlds.Engine.Screens.SceneLayer Class ReferenceInherits ScreenLayer.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SceneLayer](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a51c575ffa9ab036222092afa21cb173d) (bool clearSceneOnFinalize=true, bool autoToggleSceneView=true) |
| void | [SetScene](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a47870bbd5b2fbaaa09b52c917ac5b1a6) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| void | [SetRenderWithPostfx](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a5dd366114d0cd0da08f9436df76fd682) (bool value) |
| void | [SetPostfxConfigParams](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a901aa4b1bd6cdf13ffaee84f7d140ddd) (int value) |
| void | [SetCamera](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a7ed75f5c2045cf4988803554e7edae9d) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera) |
| void | [SetPostfxFromConfig](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#af0306ee6308c16c3377be7a5136c7941) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [WorldPointToScreenPoint](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a78cec837a9e37b006e0a072aee08c3af) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [ScreenPointToViewportPoint](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#af28234ec3f002b9a0c0db2d11c9cfafb) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |
| bool | [ProjectedMousePositionOnGround](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ad6ec3b4699e2e4eb9e5d48f929fd95e1) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) groundPosition, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) groundNormal, bool mouseVisible, [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) excludeBodyOwnerFlags, bool checkOccludedSurface) |
| void | [TranslateMouse](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a9426564b47307e33c82e1662c470ecc0) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseNear, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldMouseFar, float maxDistance=-1) |
| void | [SetSceneUsesSkybox](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#adc244b752c23069c13a1b5d6b9d56487) (bool value) |
| void | [SetSceneUsesShadows](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ad7c3979cd2e2ddb91d42cf10d7ba0504) (bool value) |
| void | [SetSceneUsesContour](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a168aae8ce175651fbed10590ff914115) (bool value) |
| void | [SetShadowmapResolutionMultiplier](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ae252c5a503a86bdb1a9d33a89bef39af) (float value) |
| void | [SetFocusedShadowmap](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a1d7a8a6e8cabb03226ac7a3908d79e76) (bool enable, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) center, float radius) |
| void | [DoNotClear](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a15ae89cdc2e7cd39aef04b9d0e3e84c0) (bool value) |
| bool | [ReadyToRender](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ab67c6613bdbbd209ff439e0c937eb72e) () |
| void | [SetCleanScreenUntilLoadingDone](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a156bfcc06df76ae7ff794ca1424d47e5) (bool value) |
| void | [ClearAll](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#aefa86dc057816d2eace1361f8898a3ca) () |
| void | [ClearRuntimeGPUMemory](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ab3ec96fb7c8915885584e86fb1930ebe) (bool remove\_terrain) |
| override bool | [HitTest](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ad3b428cb54b12d4edf8d867e7c716e22) (Vector2 position) |
| override bool | [HitTest](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a4790f162c21f043f1c937fc3de48aefc) () |
| override bool | [FocusTest](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a74a715c71fab3ccfa86fa0e672fe1e49) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnActivate](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a90ca0f0b2a1ead1447d183579dcbf5a8) () |
| override void | [OnDeactivate](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#aa604fc50521283c4c170e58b7ac3bb8c) () |
| override void | [OnFinalize](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a6d76049eeaec48af7c4c459c8d4a2d8c) () |
| override void | [RefreshGlobalOrder](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a59c26053762cf61df01db6a32754de27) (ref int currentOrder) |

|  |  |
| --- | --- |
| Properties | |
| bool | [ClearSceneOnFinalize](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a5a67f56c1aea17e80ea112ddf65c921e) `[get]` |
| bool | [AutoToggleSceneView](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a5939b944731f6c9b44dc3523e3270433) `[get]` |
|  | If false, scene view declared in this scene layer won't be Enabled/Disabled automatically on OnActivate and OnDeactivate. |
| SceneView | [SceneView](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#adeb03e5c5ef6a0f5f0181f5898181adc) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a51c575ffa9ab036222092afa21cb173d)SceneLayer()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Engine.Screens.SceneLayer.SceneLayer | ( | bool | *clearSceneOnFinalize* = true, |
|  |  | bool | *autoToggleSceneView* = true ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a90ca0f0b2a1ead1447d183579dcbf5a8)OnActivate()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.Screens.SceneLayer.OnActivate | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#aa604fc50521283c4c170e58b7ac3bb8c)OnDeactivate()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.Screens.SceneLayer.OnDeactivate | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a6d76049eeaec48af7c4c459c8d4a2d8c)OnFinalize()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.Screens.SceneLayer.OnFinalize | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a47870bbd5b2fbaaa09b52c917ac5b1a6)SetScene()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetScene | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a5dd366114d0cd0da08f9436df76fd682)SetRenderWithPostfx()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetRenderWithPostfx | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a901aa4b1bd6cdf13ffaee84f7d140ddd)SetPostfxConfigParams()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetPostfxConfigParams | ( | int | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a7ed75f5c2045cf4988803554e7edae9d)SetCamera()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetCamera | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#af0306ee6308c16c3377be7a5136c7941)SetPostfxFromConfig()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetPostfxFromConfig | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a78cec837a9e37b006e0a072aee08c3af)WorldPointToScreenPoint()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.Screens.SceneLayer.WorldPointToScreenPoint | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#af28234ec3f002b9a0c0db2d11c9cfafb)ScreenPointToViewportPoint()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.Screens.SceneLayer.ScreenPointToViewportPoint | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ad6ec3b4699e2e4eb9e5d48f929fd95e1)ProjectedMousePositionOnGround()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Screens.SceneLayer.ProjectedMousePositionOnGround | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *groundPosition*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *groundNormal*, |
|  |  | bool | *mouseVisible*, |
|  |  | [BodyFlags](namespace_tale_worlds_1_1_engine.html#ad225808c3d58dc638860892bcb806b7a) | *excludeBodyOwnerFlags*, |
|  |  | bool | *checkOccludedSurface* ) |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a9426564b47307e33c82e1662c470ecc0)TranslateMouse()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.TranslateMouse | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseNear*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldMouseFar*, |
|  |  | float | *maxDistance* = -1 ) |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#adc244b752c23069c13a1b5d6b9d56487)SetSceneUsesSkybox()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetSceneUsesSkybox | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ad7c3979cd2e2ddb91d42cf10d7ba0504)SetSceneUsesShadows()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetSceneUsesShadows | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a168aae8ce175651fbed10590ff914115)SetSceneUsesContour()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetSceneUsesContour | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ae252c5a503a86bdb1a9d33a89bef39af)SetShadowmapResolutionMultiplier()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetShadowmapResolutionMultiplier | ( | float | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a1d7a8a6e8cabb03226ac7a3908d79e76)SetFocusedShadowmap()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetFocusedShadowmap | ( | bool | *enable*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *center*, |
|  |  | float | *radius* ) |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a15ae89cdc2e7cd39aef04b9d0e3e84c0)DoNotClear()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.DoNotClear | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ab67c6613bdbbd209ff439e0c937eb72e)ReadyToRender()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Screens.SceneLayer.ReadyToRender | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a156bfcc06df76ae7ff794ca1424d47e5)SetCleanScreenUntilLoadingDone()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.SetCleanScreenUntilLoadingDone | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#aefa86dc057816d2eace1361f8898a3ca)ClearAll()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.ClearAll | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ab3ec96fb7c8915885584e86fb1930ebe)ClearRuntimeGPUMemory()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Screens.SceneLayer.ClearRuntimeGPUMemory | ( | bool | *remove\_terrain* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a59c26053762cf61df01db6a32754de27)RefreshGlobalOrder()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.Engine.Screens.SceneLayer.RefreshGlobalOrder | ( | ref int | *currentOrder* | ) |  | | protected |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#ad3b428cb54b12d4edf8d867e7c716e22)HitTest() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Engine.Screens.SceneLayer.HitTest | ( | Vector2 | *position* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a4790f162c21f043f1c937fc3de48aefc)HitTest() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.Engine.Screens.SceneLayer.HitTest | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a74a715c71fab3ccfa86fa0e672fe1e49)FocusTest()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.Engine.Screens.SceneLayer.FocusTest | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a5a67f56c1aea17e80ea112ddf65c921e)ClearSceneOnFinalize
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Screens.SceneLayer.ClearSceneOnFinalize | | get |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#a5939b944731f6c9b44dc3523e3270433)AutoToggleSceneView
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Screens.SceneLayer.AutoToggleSceneView | | get |

[◆](class_tale_worlds_1_1_engine_1_1_screens_1_1_scene_layer.html#adeb03e5c5ef6a0f5f0181f5898181adc)SceneView
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SceneView TaleWorlds.Engine.Screens.SceneLayer.SceneView | | get |

