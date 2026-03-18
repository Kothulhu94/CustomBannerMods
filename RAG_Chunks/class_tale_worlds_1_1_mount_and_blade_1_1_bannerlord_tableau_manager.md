--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html ---

TaleWorlds.MountAndBlade.BannerlordTableauManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [RequestCharacterTableauSetupDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#ac6940aab7daf52eecc24e750498051f3) (int characterCodeId, [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) poseEntity) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [RequestCharacterTableauRender](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#a302f161cc2cd5aa10077b0e8c4e91daf) (int characterCodeId, string path, [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) poseEntity, [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) cameraObject, int tableauType) |
| static void | [ClearManager](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#a02594bc9f89055a9b12f0ade6857941f) () |
| static void | [InitializeCharacterTableauRenderSystem](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#a34d7fc11b81d8c0b44e95111a3c05c2d) () |
| static int | [GetNumberOfPendingTableauRequests](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#af2de83c3f72a23a83fd8bddeb547c440) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static [RequestCharacterTableauSetupDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#ac6940aab7daf52eecc24e750498051f3) | [RequestCallback](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#a4d5e021b27dc43c162ba958e10bf6000) |

|  |  |
| --- | --- |
| Properties | |
| static [Scene](class_tale_worlds_1_1_engine_1_1_scene.html)[] | [TableauCharacterScenes](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#a80913d47ded74bc76419a437f826c5d8) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#ac6940aab7daf52eecc24e750498051f3)RequestCharacterTableauSetupDelegate()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.BannerlordTableauManager.RequestCharacterTableauSetupDelegate | ( | int | *characterCodeId*, |
|  |  | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, |
|  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *poseEntity* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#a302f161cc2cd5aa10077b0e8c4e91daf)RequestCharacterTableauRender()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.BannerlordTableauManager.RequestCharacterTableauRender | ( | int | *characterCodeId*, | |  |  | string | *path*, | |  |  | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *poseEntity*, | |  |  | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *cameraObject*, | |  |  | int | *tableauType* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#a02594bc9f89055a9b12f0ade6857941f)ClearManager()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.BannerlordTableauManager.ClearManager | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#a34d7fc11b81d8c0b44e95111a3c05c2d)InitializeCharacterTableauRenderSystem()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.BannerlordTableauManager.InitializeCharacterTableauRenderSystem | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#af2de83c3f72a23a83fd8bddeb547c440)GetNumberOfPendingTableauRequests()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | int TaleWorlds.MountAndBlade.BannerlordTableauManager.GetNumberOfPendingTableauRequests | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#a4d5e021b27dc43c162ba958e10bf6000)RequestCallback
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RequestCharacterTableauSetupDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#ac6940aab7daf52eecc24e750498051f3) TaleWorlds.MountAndBlade.BannerlordTableauManager.RequestCallback | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_bannerlord_tableau_manager.html#a80913d47ded74bc76419a437f826c5d8)TableauCharacterScenes
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) [] TaleWorlds.MountAndBlade.BannerlordTableauManager.TableauCharacterScenes | | staticget |

