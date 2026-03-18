--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html ---

TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView Class ReferenceInherits [TaleWorlds.MountAndBlade.IFaceGeneratorHandler](interface_tale_worlds_1_1_mount_and_blade_1_1_i_face_generator_handler.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BodyGeneratorView](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a9968c5dff28d918b150ef4f9db71e9f8) ([ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) affirmativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) affirmativeActionText, [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) negativeAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) negativeActionText, [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) character, bool openedFromMultiplayer, [IFaceGeneratorCustomFilter](interface_tale_worlds_1_1_core_1_1_i_face_generator_custom_filter.html) filter, [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) dressedEquipment=null, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getCurrentStageIndexAction=null, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getTotalStageCountAction=null, [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) getFurthestIndexAction=null, [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) goToIndexAction=null, [FaceGenHistory](class_tale_worlds_1_1_core_1_1_face_gen_history.html) faceGenHistory=null) |
| void | [ResetFaceToDefault](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a1e3797259fd095f80bb8d7a3ce4e4870) () |
| bool | [ReadyToRender](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a118d1056b706bea353b27bd6e0105892) () |
| void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a49f90d99d11d305fdc28ace9709540f3) (float dt) |
| void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a9d90b737f3fc28426b98c6d7f6c94a2a) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [FaceGenShowDebug](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#ab647d39f366f5be90e2e739ce3d3d27a) (List< string > strings) |
| static string | [FaceGenUpdateDeformKeys](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a33ad6aab7bc22eb7fca799881599aa40) (List< string > strings) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [InitCamera](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#aba226943f6fdd385b607d3579f864975) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) cameraPosition) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [IsDressed](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#ac9bf40a11442e1bfbd5d0af3c8b0bccc) |
| [SkeletonType](namespace_tale_worlds_1_1_mount_and_blade.html#a86fb27e23884dadc6430560adddb176a) | [SkeletonType](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#aa5c261282c9d5fded944682b3f22b3ee) |

|  |  |
| --- | --- |
| Properties | |
| [FaceGenVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html) | [DataSource](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a708a4c21b1b94adcf8d74b9a3c1e0784) `[get]` |
| GauntletLayer | [GauntletLayer](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a7e95c3a54c6e570787ee5e5b3f551e77) `[get]` |
| SceneLayer | [SceneLayer](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#ab681b2289194fb9e7d2d0286f8a2d2bd) `[get]` |
| [MountAndBlade.BodyGenerator](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html) | [BodyGen](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#af443fd80110033aaa9a6f1d6e2155efe) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a9968c5dff28d918b150ef4f9db71e9f8)BodyGeneratorView()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.BodyGeneratorView | ( | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *affirmativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *affirmativeActionText*, |
|  |  | [ControlCharacterCreationStage](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#aea5c229884ff593abf539a57fc1d65f7) | *negativeAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *negativeActionText*, |
|  |  | [BasicCharacterObject](class_tale_worlds_1_1_core_1_1_basic_character_object.html) | *character*, |
|  |  | bool | *openedFromMultiplayer*, |
|  |  | [IFaceGeneratorCustomFilter](interface_tale_worlds_1_1_core_1_1_i_face_generator_custom_filter.html) | *filter*, |
|  |  | [Equipment](class_tale_worlds_1_1_core_1_1_equipment.html) | *dressedEquipment* = null, |
|  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getCurrentStageIndexAction* = null, |
|  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getTotalStageCountAction* = null, |
|  |  | [ControlCharacterCreationStageReturnInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#afd6eb3d037b7169d0407de8483d88de6) | *getFurthestIndexAction* = null, |
|  |  | [ControlCharacterCreationStageWithInt](namespace_tale_worlds_1_1_core_1_1_view_model_collection.html#a4f8f1fb1c62a9074508b5c7faaacd519) | *goToIndexAction* = null, |
|  |  | [FaceGenHistory](class_tale_worlds_1_1_core_1_1_face_gen_history.html) | *faceGenHistory* = null ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a1e3797259fd095f80bb8d7a3ce4e4870)ResetFaceToDefault()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.ResetFaceToDefault | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#ab647d39f366f5be90e2e739ce3d3d27a)FaceGenShowDebug()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.FaceGenShowDebug | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a33ad6aab7bc22eb7fca799881599aa40)FaceGenUpdateDeformKeys()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.FaceGenUpdateDeformKeys | ( | List< string > | *strings* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a118d1056b706bea353b27bd6e0105892)ReadyToRender()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.ReadyToRender | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a49f90d99d11d305fdc28ace9709540f3)OnTick()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.OnTick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a9d90b737f3fc28426b98c6d7f6c94a2a)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.OnFinalize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#aba226943f6fdd385b607d3579f864975)InitCamera()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.InitCamera | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *cameraPosition* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#ac9bf40a11442e1bfbd5d0af3c8b0bccc)IsDressed
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.IsDressed |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#aa5c261282c9d5fded944682b3f22b3ee)SkeletonType
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SkeletonType](namespace_tale_worlds_1_1_mount_and_blade.html#a86fb27e23884dadc6430560adddb176a) TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.SkeletonType |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a708a4c21b1b94adcf8d74b9a3c1e0784)DataSource
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [FaceGenVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_v_m.html) TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.DataSource | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#a7e95c3a54c6e570787ee5e5b3f551e77)GauntletLayer
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GauntletLayer TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.GauntletLayer | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#ab681b2289194fb9e7d2d0286f8a2d2bd)SceneLayer
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SceneLayer TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.SceneLayer | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_gauntlet_u_i_1_1_body_generator_1_1_body_generator_view.html#af443fd80110033aaa9a6f1d6e2155efe)BodyGen
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MountAndBlade.BodyGenerator](class_tale_worlds_1_1_mount_and_blade_1_1_body_generator.html) TaleWorlds.MountAndBlade.GauntletUI.BodyGenerator.BodyGeneratorView.BodyGen | | get |

