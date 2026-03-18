--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html ---

TaleWorlds.MountAndBlade.MBEditor Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [UpdateSceneTree](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a8a75fc089528985df3aa9335417b16b4) (bool doNextFrame) |
| static bool | [IsEntitySelected](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#aeea1e8ddbb4b0c7e10c233a93569a9e8) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity) |
| static bool | [IsEntitySelected](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a169f9191e66d169e64e7d4e3a2f1ae84) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entity) |
| static void | [RenderEditorMesh](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a4a368740c190120f85d3782724fbaf25) ([MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) mesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| static void | [ApplyDeltaToEditorCamera](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a5433806da8208281b3b41fc8ad74e646) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) delta) |
| static void | [EnterEditMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#ae0f4864a47e7371e1015ffcef4243dc0) ([SceneView](class_tale_worlds_1_1_engine_1_1_scene_view.html) sceneView, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) initialCameraFrame, float initialCameraElevation, float initialCameraBearing) |
| static void | [TickEditMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a5549a7a04e32b225e0a23c30bcd0cd0d) (float dt) |
| static void | [LeaveEditMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a66bce09e879fefd8e512370614ff06e3) () |
| static void | [EnterEditMissionMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a24b146a7e7054ecc4aac6e3e9d38c4bd) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| static void | [LeaveEditMissionMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a10bb5e421aaa6352fcb04e3eee1e81ff) () |
| static bool | [IsEditorMissionOn](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#afd9ef7c69a3f106a89cc99cf22cf0918) () |
| static void | [ActivateSceneEditorPresentation](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a974714970456ecb24b84a591956580af) () |
| static void | [DeactivateSceneEditorPresentation](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#adec18b97a57fbb6899df60a0520d4601) () |
| static void | [TickSceneEditorPresentation](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a808161b3172eba62ae2ddf4fde4adf06) (float dt) |
| static [SceneView](class_tale_worlds_1_1_engine_1_1_scene_view.html) | [GetEditorSceneView](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a714c9eb4d0b3a154265b4af3c40a5a48) () |
| static bool | [HelpersEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a73747660ec6c150745fe63f32370f162) () |
| static bool | [BorderHelpersEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a078e4abf800ff7a6458534983ced1df0) () |
| static void | [ZoomToPosition](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#aae210edbb85c0f83474b8b07a27e53d9) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) pos) |
| static bool | [IsReplayManagerReplaying](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a595ac0ccfac51bcfd7e5dcc587a9ff81) () |
| static bool | [IsReplayManagerRendering](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a8573dc6c232e8e18a7dad01e0f8621d9) () |
| static bool | [IsReplayManagerRecording](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a933144ca8f46d9a1dd477c868a63339f) () |
| static void | [AddEditorWarning](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a2a4f2f531f723ef9be3857a80cb28def) (string msg) |
| static void | [AddEntityWarning](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a8cdb49b6d191a0f4383ffe3023489ead) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) entityId, string msg) |
| static void | [AddNavMeshWarning](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a239e07c40db3b6a4632ff7f5394c5115) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) record, string msg) |
| static string | [GetAllPrefabsAndChildWithTag](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a2c5550c131ba210cd2a00fdd5f268d8d) (string tag) |
| static void | [ExitEditMode](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a1b7e1315bc81356c8d2d2cb524d1e94f) () |
| static void | [SetUpgradeLevelVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a403d86e9b602df8053f0391778cc067e) (List< string > levels) |
| static void | [SetLevelVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a5a7df295756b40425cf9bd22054115ce) (List< string > levels) |
| static void | [ToggleEnableEditorPhysics](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a3b259b74beccfc2d65093b1cc5029a51) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | [\_editorScene](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#ac0f6508687ce4dd785048e2abd20b4ab) |
| static bool | [\_isEditorMissionOn](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a1c99dcda402b5e121a4d9f0d766e2745) = false |

|  |  |
| --- | --- |
| Properties | |
| static bool | [IsEditModeOn](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#afb370a52aeb76d253360b12b0e63c37d) `[get]` |
| static bool | [EditModeEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a86bef5ca36ffc028d763624e986c32d6) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a8a75fc089528985df3aa9335417b16b4)UpdateSceneTree()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.UpdateSceneTree | ( | bool | *doNextFrame* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#aeea1e8ddbb4b0c7e10c233a93569a9e8)IsEntitySelected() [1/2]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBEditor.IsEntitySelected | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a169f9191e66d169e64e7d4e3a2f1ae84)IsEntitySelected() [2/2]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBEditor.IsEntitySelected | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entity* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a4a368740c190120f85d3782724fbaf25)RenderEditorMesh()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.RenderEditorMesh | ( | [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | *mesh*, | |  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a5433806da8208281b3b41fc8ad74e646)ApplyDeltaToEditorCamera()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.ApplyDeltaToEditorCamera | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *delta* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#ae0f4864a47e7371e1015ffcef4243dc0)EnterEditMode()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.EnterEditMode | ( | [SceneView](class_tale_worlds_1_1_engine_1_1_scene_view.html) | *sceneView*, | |  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *initialCameraFrame*, | |  |  | float | *initialCameraElevation*, | |  |  | float | *initialCameraBearing* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a5549a7a04e32b225e0a23c30bcd0cd0d)TickEditMode()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.TickEditMode | ( | float | *dt* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a66bce09e879fefd8e512370614ff06e3)LeaveEditMode()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.LeaveEditMode | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a24b146a7e7054ecc4aac6e3e9d38c4bd)EnterEditMissionMode()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.EnterEditMissionMode | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a10bb5e421aaa6352fcb04e3eee1e81ff)LeaveEditMissionMode()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.LeaveEditMissionMode | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#afd9ef7c69a3f106a89cc99cf22cf0918)IsEditorMissionOn()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBEditor.IsEditorMissionOn | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a974714970456ecb24b84a591956580af)ActivateSceneEditorPresentation()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.ActivateSceneEditorPresentation | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#adec18b97a57fbb6899df60a0520d4601)DeactivateSceneEditorPresentation()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.DeactivateSceneEditorPresentation | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a808161b3172eba62ae2ddf4fde4adf06)TickSceneEditorPresentation()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.TickSceneEditorPresentation | ( | float | *dt* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a714c9eb4d0b3a154265b4af3c40a5a48)GetEditorSceneView()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [SceneView](class_tale_worlds_1_1_engine_1_1_scene_view.html) TaleWorlds.MountAndBlade.MBEditor.GetEditorSceneView | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a73747660ec6c150745fe63f32370f162)HelpersEnabled()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBEditor.HelpersEnabled | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a078e4abf800ff7a6458534983ced1df0)BorderHelpersEnabled()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBEditor.BorderHelpersEnabled | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#aae210edbb85c0f83474b8b07a27e53d9)ZoomToPosition()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.ZoomToPosition | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *pos* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a595ac0ccfac51bcfd7e5dcc587a9ff81)IsReplayManagerReplaying()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBEditor.IsReplayManagerReplaying | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a8573dc6c232e8e18a7dad01e0f8621d9)IsReplayManagerRendering()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBEditor.IsReplayManagerRendering | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a933144ca8f46d9a1dd477c868a63339f)IsReplayManagerRecording()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBEditor.IsReplayManagerRecording | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a2a4f2f531f723ef9be3857a80cb28def)AddEditorWarning()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.AddEditorWarning | ( | string | *msg* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a8cdb49b6d191a0f4383ffe3023489ead)AddEntityWarning()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.AddEntityWarning | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *entityId*, | |  |  | string | *msg* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a239e07c40db3b6a4632ff7f5394c5115)AddNavMeshWarning()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.AddNavMeshWarning | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | [PathFaceRecord](struct_tale_worlds_1_1_library_1_1_path_face_record.html) | *record*, | |  |  | string | *msg* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a2c5550c131ba210cd2a00fdd5f268d8d)GetAllPrefabsAndChildWithTag()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.MBEditor.GetAllPrefabsAndChildWithTag | ( | string | *tag* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a1b7e1315bc81356c8d2d2cb524d1e94f)ExitEditMode()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.ExitEditMode | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a403d86e9b602df8053f0391778cc067e)SetUpgradeLevelVisibility()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.SetUpgradeLevelVisibility | ( | List< string > | *levels* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a5a7df295756b40425cf9bd22054115ce)SetLevelVisibility()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.SetLevelVisibility | ( | List< string > | *levels* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a3b259b74beccfc2d65093b1cc5029a51)ToggleEnableEditorPhysics()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBEditor.ToggleEnableEditorPhysics | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#ac0f6508687ce4dd785048e2abd20b4ab)\_editorScene
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) TaleWorlds.MountAndBlade.MBEditor.\_editorScene | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a1c99dcda402b5e121a4d9f0d766e2745)\_isEditorMissionOn
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MBEditor.\_isEditorMissionOn = false | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#afb370a52aeb76d253360b12b0e63c37d)IsEditModeOn
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MBEditor.IsEditModeOn | | staticget |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_editor.html#a86bef5ca36ffc028d763624e986c32d6)EditModeEnabled
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.MBEditor.EditModeEnabled | | staticget |

