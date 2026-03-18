--- SOURCE: class_tale_worlds_1_1_engine_1_1_camera.html ---

TaleWorlds.Engine.Camera Class ReferencesealedInherits NativeObject.

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [ReleaseCamera](class_tale_worlds_1_1_engine_1_1_camera.html#af43bb697029f2ca95c5d53e495c63552) () |
| void | [ReleaseCameraEntity](class_tale_worlds_1_1_engine_1_1_camera.html#a5c7686d2bd44eb1ec4d9e2bafde142dc) () |
| void | [LookAt](class_tale_worlds_1_1_engine_1_1_camera.html#afc9c09d60b2ed5acf19abb7dddcc4825) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) target, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) upVector) |
| void | [ScreenSpaceRayProjection](class_tale_worlds_1_1_engine_1_1_camera.html#a31a76d8ffcc680222ae6cd8217896ac1) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) screenPosition, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayBegin, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayEnd) |
|  | Casts a ray from screen point to the world/scene. |
| bool | [CheckEntityVisibility](class_tale_worlds_1_1_engine_1_1_camera.html#aa32d110ba830897ad6af10dce2d46003) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
| void | [SetViewVolume](class_tale_worlds_1_1_engine_1_1_camera.html#aed99a487627c7b4d6dcf7627fc927647) (bool perspective, float dLeft, float dRight, float dBottom, float dTop, float dNear, float dFar) |
| void | [GetNearPlanePoints](class_tale_worlds_1_1_engine_1_1_camera.html#a3b8f78f3ed32ca542576cbf82a2b89d7) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] nearPlanePoints) |
| void | [SetFovVertical](class_tale_worlds_1_1_engine_1_1_camera.html#af5000ea535d41e1e1dc3ed91444be97c) (float verticalFov, float aspectRatioXY, float newDNear, float newDFar) |
| void | [SetFovHorizontal](class_tale_worlds_1_1_engine_1_1_camera.html#ab2b38b4483372391bf175c68c32115f6) (float horizontalFov, float aspectRatioXY, float newDNear, float newDFar) |
| void | [GetViewProjMatrix](class_tale_worlds_1_1_engine_1_1_camera.html#aca13ad8c850f3d030f00b5ca775155af) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) viewProj) |
| float | [GetFovVertical](class_tale_worlds_1_1_engine_1_1_camera.html#ae5f30f0083365e74792e2db2372b49c2) () |
| float | [GetFovHorizontal](class_tale_worlds_1_1_engine_1_1_camera.html#abbcb1b9fe7b671e7656e94a84d9fb7e7) () |
| float | [GetAspectRatio](class_tale_worlds_1_1_engine_1_1_camera.html#ab546f1bf8a9ac224fd9204dc5ba2f38e) () |
| void | [FillParametersFrom](class_tale_worlds_1_1_engine_1_1_camera.html#a6976105ebc5d90010c5eeb8ec1c2e5f0) (Camera otherCamera) |
| void | [RenderFrustrum](class_tale_worlds_1_1_engine_1_1_camera.html#a06fbe44d496d6fa645d8fa953c546f1c) () |
| void | [ViewportPointToWorldRay](class_tale_worlds_1_1_engine_1_1_camera.html#adfacc2d8c16af4b80ebe041048c911a6) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayBegin, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayEnd, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) viewportPoint) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [WorldPointToViewPortPoint](class_tale_worlds_1_1_engine_1_1_camera.html#a62505902a0dd0f8f83e43e493ceec29b) (ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldPoint) |
| bool | [EnclosesPoint](class_tale_worlds_1_1_engine_1_1_camera.html#a87c77d9bb384aebd716f8bc4acc0db2e) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) pointInWorldSpace) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Camera | [CreateCamera](class_tale_worlds_1_1_engine_1_1_camera.html#a6756dcf710d972497739b7e93194ab73) () |
| static void | [GetNearPlanePointsStatic](class_tale_worlds_1_1_engine_1_1_camera.html#a4731fc4fcb27a9deb14207db5e11aa93) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) cameraFrame, float verticalFov, float aspectRatioXY, float newDNear, float newDFar, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] nearPlanePoints) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [ConstructCameraFromPositionElevationBearing](class_tale_worlds_1_1_engine_1_1_camera.html#aa767ed11bbed2e6f4370fbba54c2abe3) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, float elevation, float bearing) |

|  |  |
| --- | --- |
| Properties | |
| [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | [Entity](class_tale_worlds_1_1_engine_1_1_camera.html#a4af67b9c96f98936989ac8b07f667e64) `[get, set]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Position](class_tale_worlds_1_1_engine_1_1_camera.html#a684a5327ae59492082a56dbcc057d074) `[get, set]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Direction](class_tale_worlds_1_1_engine_1_1_camera.html#aeb664e347bc19935525e632a5a4ec43f) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [Frame](class_tale_worlds_1_1_engine_1_1_camera.html#a3bb86555498e40917310f6e6ca2dd3ba) `[get, set]` |
| float | [Near](class_tale_worlds_1_1_engine_1_1_camera.html#a3655f72584e877cad3c8425f330748f2) `[get]` |
| float | [Far](class_tale_worlds_1_1_engine_1_1_camera.html#a25d11f5e091830a35ed8bb5b7dd316f6) `[get]` |
| float | [HorizontalFov](class_tale_worlds_1_1_engine_1_1_camera.html#a0bf6842ae1c17f97e7cc4173e4a8d6cb) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a6756dcf710d972497739b7e93194ab73)CreateCamera()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | Camera TaleWorlds.Engine.Camera.CreateCamera | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#af43bb697029f2ca95c5d53e495c63552)ReleaseCamera()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.ReleaseCamera | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a5c7686d2bd44eb1ec4d9e2bafde142dc)ReleaseCameraEntity()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.ReleaseCameraEntity | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#afc9c09d60b2ed5acf19abb7dddcc4825)LookAt()
-------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.LookAt | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *target*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *upVector* ) |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a31a76d8ffcc680222ae6cd8217896ac1)ScreenSpaceRayProjection()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.ScreenSpaceRayProjection | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *screenPosition*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayBegin*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayEnd* ) |

Parameters
:   |  |  |
    | --- | --- |
    | screenPosition | Position of the ray on the screen. {(x,y)| 0<=x<=1 and 0<=y<=1}. |
    | rayBegin | Initial point of the ray. It lies on viewport/projection plane of the camera. |
    | rayEnd | End point of the ray which is in the view frustum of the camera. It lies on the clipping plane of the camera. |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#aa32d110ba830897ad6af10dce2d46003)CheckEntityVisibility()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Camera.CheckEntityVisibility | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#aed99a487627c7b4d6dcf7627fc927647)SetViewVolume()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.SetViewVolume | ( | bool | *perspective*, |
|  |  | float | *dLeft*, |
|  |  | float | *dRight*, |
|  |  | float | *dBottom*, |
|  |  | float | *dTop*, |
|  |  | float | *dNear*, |
|  |  | float | *dFar* ) |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a4731fc4fcb27a9deb14207db5e11aa93)GetNearPlanePointsStatic()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.Camera.GetNearPlanePointsStatic | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *cameraFrame*, | |  |  | float | *verticalFov*, | |  |  | float | *aspectRatioXY*, | |  |  | float | *newDNear*, | |  |  | float | *newDFar*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] | *nearPlanePoints* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a3b8f78f3ed32ca542576cbf82a2b89d7)GetNearPlanePoints()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.GetNearPlanePoints | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] | *nearPlanePoints* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#af5000ea535d41e1e1dc3ed91444be97c)SetFovVertical()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.SetFovVertical | ( | float | *verticalFov*, |
|  |  | float | *aspectRatioXY*, |
|  |  | float | *newDNear*, |
|  |  | float | *newDFar* ) |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#ab2b38b4483372391bf175c68c32115f6)SetFovHorizontal()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.SetFovHorizontal | ( | float | *horizontalFov*, |
|  |  | float | *aspectRatioXY*, |
|  |  | float | *newDNear*, |
|  |  | float | *newDFar* ) |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#aca13ad8c850f3d030f00b5ca775155af)GetViewProjMatrix()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.GetViewProjMatrix | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *viewProj* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#ae5f30f0083365e74792e2db2372b49c2)GetFovVertical()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Camera.GetFovVertical | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#abbcb1b9fe7b671e7656e94a84d9fb7e7)GetFovHorizontal()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Camera.GetFovHorizontal | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#ab546f1bf8a9ac224fd9204dc5ba2f38e)GetAspectRatio()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Camera.GetAspectRatio | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a6976105ebc5d90010c5eeb8ec1c2e5f0)FillParametersFrom()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.FillParametersFrom | ( | Camera | *otherCamera* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a06fbe44d496d6fa645d8fa953c546f1c)RenderFrustrum()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.RenderFrustrum | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#adfacc2d8c16af4b80ebe041048c911a6)ViewportPointToWorldRay()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Camera.ViewportPointToWorldRay | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayBegin*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayEnd*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *viewportPoint* ) |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a62505902a0dd0f8f83e43e493ceec29b)WorldPointToViewPortPoint()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Camera.WorldPointToViewPortPoint | ( | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldPoint* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a87c77d9bb384aebd716f8bc4acc0db2e)EnclosesPoint()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Camera.EnclosesPoint | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *pointInWorldSpace* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#aa767ed11bbed2e6f4370fbba54c2abe3)ConstructCameraFromPositionElevationBearing()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Camera.ConstructCameraFromPositionElevationBearing | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, | |  |  | float | *elevation*, | |  |  | float | *bearing* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a4af67b9c96f98936989ac8b07f667e64)Entity
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) TaleWorlds.Engine.Camera.Entity | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a684a5327ae59492082a56dbcc057d074)Position
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Camera.Position | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#aeb664e347bc19935525e632a5a4ec43f)Direction
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Camera.Direction | | get |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a3bb86555498e40917310f6e6ca2dd3ba)Frame
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Camera.Frame | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a3655f72584e877cad3c8425f330748f2)Near
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.Camera.Near | | get |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a25d11f5e091830a35ed8bb5b7dd316f6)Far
--------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.Camera.Far | | get |

[◆](class_tale_worlds_1_1_engine_1_1_camera.html#a0bf6842ae1c17f97e7cc4173e4a8d6cb)HorizontalFov
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.Camera.HorizontalFov | | get |

