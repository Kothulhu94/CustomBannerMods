--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html ---

TaleWorlds.MountAndBlade.MBMapScene Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetNearestFaceCenterForPosition](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a30276eb269bd983e538a62969c318384) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, bool isRegionMap0, int[] excludedFaceIds) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetNearestFaceCenterForPositionWithPath](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a737aca9a09aa3bb2429a2037d200bd43) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) pathFaceRecord, bool targetRegionMap0, float maxDist, int[] excludedFaceIds) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetAccessiblePointNearPosition](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a040cbccec9e3fd2a466b51302126f58f) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, bool isRegionMap1, float radius) |
| static void | [RemoveZeroCornerBodies](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#aa4e110ffaf4512c370e877351feaf04f) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene) |
| static void | [LoadAtmosphereData](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#abfec3300e657ab98ece65ccd33ff9e5a) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene) |
| static void | [TickStepSound](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a7e54c4a33a59cecaf653f9472d03c11a) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) visuals, int terrainType, [TerrainTypeSoundSlot](namespace_tale_worlds_1_1_mount_and_blade.html#ab2d5edc7998fc5dcc60f436808994070) soundType, int partySize) |
| static void | [TickAmbientSounds](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ac9523258d69be26b8839a7651d51adaf) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, int terrainType) |
| static bool | [GetMouseVisible](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ae951c8ea2554fce95ab6a7e90de00357) () |
| static bool | [GetApplyRainColorGrade](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ae7f3cbf6a57ac3c5cae81fab4716a5ce) () |
| static void | [SendMouseKeyEvent](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#adbfb6c5b6f833077563f90bfa6f17d8b) (int mouseKeyId, bool isDown) |
| static void | [SetMousePos](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#affa2ac993e01eaea8b016c3256b218f3) (int posX, int posY) |
| static void | [TickVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a18c0a7b3bd2c6cf2e7108565d42c88e6) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, float tod, [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html)[] tickedMapMeshes) |
| static void | [ValidateTerrainSoundIds](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ac6030e8ba3ff6c90db0ae7c7968f726f) () |
| static void | [GetGlobalIlluminationOfString](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a570a676d632c0439c899d3138e76d970) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, string value) |
| static void | [GetColorGradeGridData](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a28656e1efade9ae5ad369df3ddfe0515) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, Byte[] gridData, string textureName) |
| static void | [GetBattleSceneIndexMap](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ab900d625f958697b95383f2394936adc) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, ref Byte[] indexData, ref int width, ref int height) |
| static void | [SetFrameForAtmosphere](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#af10138ee43f5dbe86b2e0089e360775a) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, float tod, float cameraElevation, bool forceLoadTextures) |
| static void | [SetTerrainDynamicParams](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#af22e1efac135e2e5a679463736551b44) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) dynamic\_params) |
| static void | [SetSeasonTimeFactor](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ab87e3778d458c8e1a427d8b343cbbd4d) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene, float seasonTimeFactor) |
| static float | [GetSeasonTimeFactor](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ac72dcad9787c0ff0102291024fa3ad1d) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) mapScene) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static bool | [ApplyRainColorGrade](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a5ee5403798f8bb37d9d04c890771fb32) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a30276eb269bd983e538a62969c318384)GetNearestFaceCenterForPosition()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MBMapScene.GetNearestFaceCenterForPosition | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, | |  |  | bool | *isRegionMap0*, | |  |  | int[] | *excludedFaceIds* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a737aca9a09aa3bb2429a2037d200bd43)GetNearestFaceCenterForPositionWithPath()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MBMapScene.GetNearestFaceCenterForPositionWithPath | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *pathFaceRecord*, | |  |  | bool | *targetRegionMap0*, | |  |  | float | *maxDist*, | |  |  | int[] | *excludedFaceIds* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a040cbccec9e3fd2a466b51302126f58f)GetAccessiblePointNearPosition()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MBMapScene.GetAccessiblePointNearPosition | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, | |  |  | bool | *isRegionMap1*, | |  |  | float | *radius* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#aa4e110ffaf4512c370e877351feaf04f)RemoveZeroCornerBodies()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.RemoveZeroCornerBodies | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#abfec3300e657ab98ece65ccd33ff9e5a)LoadAtmosphereData()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.LoadAtmosphereData | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a7e54c4a33a59cecaf653f9472d03c11a)TickStepSound()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.TickStepSound | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | [MBAgentVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_agent_visuals.html) | *visuals*, | |  |  | int | *terrainType*, | |  |  | [TerrainTypeSoundSlot](namespace_tale_worlds_1_1_mount_and_blade.html#ab2d5edc7998fc5dcc60f436808994070) | *soundType*, | |  |  | int | *partySize* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ac9523258d69be26b8839a7651d51adaf)TickAmbientSounds()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.TickAmbientSounds | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | int | *terrainType* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ae951c8ea2554fce95ab6a7e90de00357)GetMouseVisible()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBMapScene.GetMouseVisible | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ae7f3cbf6a57ac3c5cae81fab4716a5ce)GetApplyRainColorGrade()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBMapScene.GetApplyRainColorGrade | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#adbfb6c5b6f833077563f90bfa6f17d8b)SendMouseKeyEvent()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.SendMouseKeyEvent | ( | int | *mouseKeyId*, | |  |  | bool | *isDown* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#affa2ac993e01eaea8b016c3256b218f3)SetMousePos()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.SetMousePos | ( | int | *posX*, | |  |  | int | *posY* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a18c0a7b3bd2c6cf2e7108565d42c88e6)TickVisuals()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.TickVisuals | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | float | *tod*, | |  |  | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html)[] | *tickedMapMeshes* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ac6030e8ba3ff6c90db0ae7c7968f726f)ValidateTerrainSoundIds()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.ValidateTerrainSoundIds | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a570a676d632c0439c899d3138e76d970)GetGlobalIlluminationOfString()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.GetGlobalIlluminationOfString | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | string | *value* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a28656e1efade9ae5ad369df3ddfe0515)GetColorGradeGridData()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.GetColorGradeGridData | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | Byte[] | *gridData*, | |  |  | string | *textureName* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ab900d625f958697b95383f2394936adc)GetBattleSceneIndexMap()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.GetBattleSceneIndexMap | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | ref Byte[] | *indexData*, | |  |  | ref int | *width*, | |  |  | ref int | *height* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#af10138ee43f5dbe86b2e0089e360775a)SetFrameForAtmosphere()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.SetFrameForAtmosphere | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | float | *tod*, | |  |  | float | *cameraElevation*, | |  |  | bool | *forceLoadTextures* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#af22e1efac135e2e5a679463736551b44)SetTerrainDynamicParams()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.SetTerrainDynamicParams | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *dynamic\_params* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ab87e3778d458c8e1a427d8b343cbbd4d)SetSeasonTimeFactor()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBMapScene.SetSeasonTimeFactor | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene*, | |  |  | float | *seasonTimeFactor* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#ac72dcad9787c0ff0102291024fa3ad1d)GetSeasonTimeFactor()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBMapScene.GetSeasonTimeFactor | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *mapScene* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_map_scene.html#a5ee5403798f8bb37d9d04c890771fb32)ApplyRainColorGrade
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MBMapScene.ApplyRainColorGrade | | static |

