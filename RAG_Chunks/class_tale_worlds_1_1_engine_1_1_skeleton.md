--- SOURCE: class_tale_worlds_1_1_engine_1_1_skeleton.html ---

TaleWorlds.Engine.Skeleton Class ReferencesealedInherits NativeObject.

|  |  |
| --- | --- |
| Public Member Functions | |
| string | [GetName](class_tale_worlds_1_1_engine_1_1_skeleton.html#a63fa25dc3ce826b8409feb98e6333c47) () |
| string | [GetBoneName](class_tale_worlds_1_1_engine_1_1_skeleton.html#a73ac69d8765faf319529966034a2d80c) (sbyte boneIndex) |
| sbyte | [GetBoneChildAtIndex](class_tale_worlds_1_1_engine_1_1_skeleton.html#a6fa235b9571c29d2a92eb06c6908cb2f) (sbyte boneIndex, sbyte childIndex) |
| sbyte | [GetBoneChildCount](class_tale_worlds_1_1_engine_1_1_skeleton.html#a777257e9b97e1d4f871673baa8867b8e) (sbyte boneIndex) |
| sbyte | [GetParentBoneIndex](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9eb8f48ab7a73d8c3cac767edf679735) (sbyte boneIndex) |
| void | [AddMeshToBone](class_tale_worlds_1_1_engine_1_1_skeleton.html#a804927cf4124a0f052e251d96d1712a1) (UIntPtr mesh, sbyte boneIndex) |
| void | [Freeze](class_tale_worlds_1_1_engine_1_1_skeleton.html#ae201592173b4b143251a027e868c81c5) (bool p) |
| bool | [IsFrozen](class_tale_worlds_1_1_engine_1_1_skeleton.html#a53aa0b0ee76676a92c234e69d4cc99ba) () |
| void | [SetBoneLocalFrame](class_tale_worlds_1_1_engine_1_1_skeleton.html#a911fc3f94a715f63fbb8489378c1a5ce) (sbyte boneIndex, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) localFrame) |
| sbyte | [GetBoneCount](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9d74c8aefb835b4fea5826a039d54153) () |
| void | [GetBoneBody](class_tale_worlds_1_1_engine_1_1_skeleton.html#ad85fc46abf49b309a1a7464f5fc560ba) (sbyte boneIndex, ref [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) data) |
| void | [ForceUpdateBoneFrames](class_tale_worlds_1_1_engine_1_1_skeleton.html#a0900d17e55d6f86b515135649cb09035) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrameWithIndex](class_tale_worlds_1_1_engine_1_1_skeleton.html#a3451c307b2d819d9966adf4eb4326e98) (sbyte boneIndex) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrameWithName](class_tale_worlds_1_1_engine_1_1_skeleton.html#a199a9e9edc003e28811c05d553b98307) (string boneName) |
| [RagdollState](namespace_tale_worlds_1_1_engine.html#aa91e9ce98f5025cfa023318f053636ae) | [GetCurrentRagdollState](class_tale_worlds_1_1_engine_1_1_skeleton.html#a15ec7e04a27d9c7770e5332b60c89038) () |
| void | [ActivateRagdoll](class_tale_worlds_1_1_engine_1_1_skeleton.html#a336ab067080a68616e9b179a57e63957) () |
| sbyte | [GetSkeletonBoneMapping](class_tale_worlds_1_1_engine_1_1_skeleton.html#ae4f2b7dbd082ca0d23546eea54140c0a) (sbyte boneIndex) |
| void | [AddMesh](class_tale_worlds_1_1_engine_1_1_skeleton.html#aadf13c7898773205c0517a3b7d4950b9) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh) |
| void | [ClearComponents](class_tale_worlds_1_1_engine_1_1_skeleton.html#a6201723679228dd981c03125aee783c4) () |
| void | [AddComponent](class_tale_worlds_1_1_engine_1_1_skeleton.html#a7e53c2b64e0f87b8fd7928db02bb5a63) ([GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) component) |
| bool | [HasComponent](class_tale_worlds_1_1_engine_1_1_skeleton.html#a4093a705c0342faad7ef77f8e902ebfb) ([GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) component) |
| void | [RemoveComponent](class_tale_worlds_1_1_engine_1_1_skeleton.html#a972b21cd9c66f4d0eed5091c037c0e65) ([GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) component) |
| void | [ClearMeshes](class_tale_worlds_1_1_engine_1_1_skeleton.html#aef127e92958c8085231817e9f655c5dc) (bool clearBoneComponents=true) |
| int | [GetComponentCount](class_tale_worlds_1_1_engine_1_1_skeleton.html#a32cb75d56abf48fda490e64bce9f2d04) ([GameEntity.ComponentType](class_tale_worlds_1_1_engine_1_1_game_entity.html#ac6f57c8912eaaf5a59c14ec2f153350b) componentType) |
| void | [UpdateEntitialFramesFromLocalFrames](class_tale_worlds_1_1_engine_1_1_skeleton.html#afc598986aa34d651edf3909ef1cdf172) () |
| void | [ResetFrames](class_tale_worlds_1_1_engine_1_1_skeleton.html#aa1d0308dd2c0cd845ab0dc4f4eac951b) () |
| [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | [GetComponentAtIndex](class_tale_worlds_1_1_engine_1_1_skeleton.html#ad678d00fe103ff6f483b8fd6e9e3da7d) ([GameEntity.ComponentType](class_tale_worlds_1_1_engine_1_1_game_entity.html#ac6f57c8912eaaf5a59c14ec2f153350b) componentType, int index) |
| void | [SetUsePreciseBoundingVolume](class_tale_worlds_1_1_engine_1_1_skeleton.html#a67d0476525c2e5d3f3b411270aba3c2a) (bool value) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialRestFrame](class_tale_worlds_1_1_engine_1_1_skeleton.html#aa46741d28622b608aac5f64ed5ce68f6) (sbyte boneIndex, bool useBoneMapping) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneLocalRestFrame](class_tale_worlds_1_1_engine_1_1_skeleton.html#a6b4c27e0c91f1f2a3fa666d635d7b531) (sbyte boneIndex, bool useBoneMapping=true) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialRestFrame](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9f0ea0c6c10e391fa1a52e9987831895) (sbyte boneIndex) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrameAtChannel](class_tale_worlds_1_1_engine_1_1_skeleton.html#a231cd2fd0a96e027584ae53e780c78b5) (int channelNo, sbyte boneIndex) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetBoneEntitialFrame](class_tale_worlds_1_1_engine_1_1_skeleton.html#a232f6e124a4814364d56d146622aaa91) (sbyte boneIndex) |
| int | [GetBoneComponentCount](class_tale_worlds_1_1_engine_1_1_skeleton.html#aff5669f4cee3de964f396b403c944583) (sbyte boneIndex) |
| [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | [GetBoneComponentAtIndex](class_tale_worlds_1_1_engine_1_1_skeleton.html#a905d4a9d71234875a7404f74f33c1c55) (sbyte boneIndex, int componentIndex) |
| bool | [HasBoneComponent](class_tale_worlds_1_1_engine_1_1_skeleton.html#a1300741737b0f9dcc21cb82a42f67783) (sbyte boneIndex, [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) component) |
| void | [AddComponentToBone](class_tale_worlds_1_1_engine_1_1_skeleton.html#acbceab6b6c536bdebc7bb1107682f616) (sbyte boneIndex, [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) component) |
| void | [RemoveBoneComponent](class_tale_worlds_1_1_engine_1_1_skeleton.html#a2af77cf3e1445b62041039363eb158d8) (sbyte boneIndex, [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) component) |
| void | [ClearMeshesAtBone](class_tale_worlds_1_1_engine_1_1_skeleton.html#a43b3db1cbc19e75dbd100b94a703310b) (sbyte boneIndex) |
| void | [TickAnimations](class_tale_worlds_1_1_engine_1_1_skeleton.html#ac9fb5fd7241d38254da9421a5b4ce1f9) (float dt, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) globalFrame, bool tickAnimsForChildren) |
| void | [TickAnimationsAndForceUpdate](class_tale_worlds_1_1_engine_1_1_skeleton.html#a535172b4e72549b0664de1b51dcbf0d8) (float dt, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) globalFrame, bool tickAnimsForChildren) |
| float | [GetAnimationParameterAtChannel](class_tale_worlds_1_1_engine_1_1_skeleton.html#ab7c1f6e9506efe2d4cc8247952876057) (int channelNo) |
| void | [SetAnimationParameterAtChannel](class_tale_worlds_1_1_engine_1_1_skeleton.html#a251bfaaa6f7fd1e545a9f5c443581b45) (int channelNo, float parameter) |
| float | [GetAnimationSpeedAtChannel](class_tale_worlds_1_1_engine_1_1_skeleton.html#aa93eb92ca06fabff921168c5d9fca9bb) (int channelNo) |
| void | [SetAnimationSpeedAtChannel](class_tale_worlds_1_1_engine_1_1_skeleton.html#a85108ea47c168d063c265b5908f1c04f) (int channelNo, float speed) |
| void | [SetUptoDate](class_tale_worlds_1_1_engine_1_1_skeleton.html#ac1d41b75136489773ba5cbc947639f2f) (bool value) |
| string | [GetAnimationAtChannel](class_tale_worlds_1_1_engine_1_1_skeleton.html#a2f1e8cd98a9c5dad82892fe7828f03ec) (int channelNo) |
| int | [GetAnimationIndexAtChannel](class_tale_worlds_1_1_engine_1_1_skeleton.html#a6576bffb2ffbdc0aea3f0796f4f78010) (int channelNo) |
| void | [EnableScriptDrivenPostIntegrateCallback](class_tale_worlds_1_1_engine_1_1_skeleton.html#af64898e4425c6d7ab5ef586e26a8dec3) () |
| void | [ResetCloths](class_tale_worlds_1_1_engine_1_1_skeleton.html#aed9ca04f2e2cbd33ff02dc981ff9e837) () |
| IEnumerable< [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) > | [GetAllMeshes](class_tale_worlds_1_1_engine_1_1_skeleton.html#a05eeba55552609d50bfe8d9c1a620f3c) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Skeleton | [CreateFromModel](class_tale_worlds_1_1_engine_1_1_skeleton.html#ac085d5f45f74d2573da1f1327e38368b) (string modelName) |
| static Skeleton | [CreateFromModelWithNullAnimTree](class_tale_worlds_1_1_engine_1_1_skeleton.html#a3108c54e2aac2a0b11f26b4b4060e71c) ([GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) entity, string modelName, float boneScale=1.0f) |
| static bool | [SkeletonModelExist](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9178bd83e55d35f1b1edb56ea2ada4ce) (string skeletonModelName) |
| static sbyte | [GetBoneIndexFromName](class_tale_worlds_1_1_engine_1_1_skeleton.html#aaae4cce8774497c7b6f600cdc29f4876) (string skeletonModelName, string boneName) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const sbyte | [MaxBoneCount](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9977148fe283392a2ee2607dca227121) = 64 |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_skeleton.html#a0aacc8570af9f3f5c4f6aba9295841c5) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#ac085d5f45f74d2573da1f1327e38368b)CreateFromModel()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Skeleton TaleWorlds.Engine.Skeleton.CreateFromModel | ( | string | *modelName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a3108c54e2aac2a0b11f26b4b4060e71c)CreateFromModelWithNullAnimTree()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | Skeleton TaleWorlds.Engine.Skeleton.CreateFromModelWithNullAnimTree | ( | [GameEntity](class_tale_worlds_1_1_engine_1_1_game_entity.html) | *entity*, | |  |  | string | *modelName*, | |  |  | float | *boneScale* = 1::0f ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a63fa25dc3ce826b8409feb98e6333c47)GetName()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.Skeleton.GetName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a73ac69d8765faf319529966034a2d80c)GetBoneName()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.Skeleton.GetBoneName | ( | sbyte | *boneIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a6fa235b9571c29d2a92eb06c6908cb2f)GetBoneChildAtIndex()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| sbyte TaleWorlds.Engine.Skeleton.GetBoneChildAtIndex | ( | sbyte | *boneIndex*, |
|  |  | sbyte | *childIndex* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a777257e9b97e1d4f871673baa8867b8e)GetBoneChildCount()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| sbyte TaleWorlds.Engine.Skeleton.GetBoneChildCount | ( | sbyte | *boneIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9eb8f48ab7a73d8c3cac767edf679735)GetParentBoneIndex()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| sbyte TaleWorlds.Engine.Skeleton.GetParentBoneIndex | ( | sbyte | *boneIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a804927cf4124a0f052e251d96d1712a1)AddMeshToBone()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.AddMeshToBone | ( | UIntPtr | *mesh*, |
|  |  | sbyte | *boneIndex* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#ae201592173b4b143251a027e868c81c5)Freeze()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.Freeze | ( | bool | *p* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a53aa0b0ee76676a92c234e69d4cc99ba)IsFrozen()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Skeleton.IsFrozen | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a911fc3f94a715f63fbb8489378c1a5ce)SetBoneLocalFrame()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.SetBoneLocalFrame | ( | sbyte | *boneIndex*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *localFrame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9d74c8aefb835b4fea5826a039d54153)GetBoneCount()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| sbyte TaleWorlds.Engine.Skeleton.GetBoneCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#ad85fc46abf49b309a1a7464f5fc560ba)GetBoneBody()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.GetBoneBody | ( | sbyte | *boneIndex*, |
|  |  | ref [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) | *data* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9178bd83e55d35f1b1edb56ea2ada4ce)SkeletonModelExist()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Engine.Skeleton.SkeletonModelExist | ( | string | *skeletonModelName* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a0900d17e55d6f86b515135649cb09035)ForceUpdateBoneFrames()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.ForceUpdateBoneFrames | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a3451c307b2d819d9966adf4eb4326e98)GetBoneEntitialFrameWithIndex()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Skeleton.GetBoneEntitialFrameWithIndex | ( | sbyte | *boneIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a199a9e9edc003e28811c05d553b98307)GetBoneEntitialFrameWithName()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Skeleton.GetBoneEntitialFrameWithName | ( | string | *boneName* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a15ec7e04a27d9c7770e5332b60c89038)GetCurrentRagdollState()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [RagdollState](namespace_tale_worlds_1_1_engine.html#aa91e9ce98f5025cfa023318f053636ae) TaleWorlds.Engine.Skeleton.GetCurrentRagdollState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a336ab067080a68616e9b179a57e63957)ActivateRagdoll()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.ActivateRagdoll | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#ae4f2b7dbd082ca0d23546eea54140c0a)GetSkeletonBoneMapping()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| sbyte TaleWorlds.Engine.Skeleton.GetSkeletonBoneMapping | ( | sbyte | *boneIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#aadf13c7898773205c0517a3b7d4950b9)AddMesh()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.AddMesh | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a6201723679228dd981c03125aee783c4)ClearComponents()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.ClearComponents | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a7e53c2b64e0f87b8fd7928db02bb5a63)AddComponent()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.AddComponent | ( | [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | *component* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a4093a705c0342faad7ef77f8e902ebfb)HasComponent()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Skeleton.HasComponent | ( | [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | *component* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a972b21cd9c66f4d0eed5091c037c0e65)RemoveComponent()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.RemoveComponent | ( | [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | *component* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#aef127e92958c8085231817e9f655c5dc)ClearMeshes()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.ClearMeshes | ( | bool | *clearBoneComponents* = true | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a32cb75d56abf48fda490e64bce9f2d04)GetComponentCount()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Skeleton.GetComponentCount | ( | [GameEntity.ComponentType](class_tale_worlds_1_1_engine_1_1_game_entity.html#ac6f57c8912eaaf5a59c14ec2f153350b) | *componentType* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#afc598986aa34d651edf3909ef1cdf172)UpdateEntitialFramesFromLocalFrames()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.UpdateEntitialFramesFromLocalFrames | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#aa1d0308dd2c0cd845ab0dc4f4eac951b)ResetFrames()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.ResetFrames | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#ad678d00fe103ff6f483b8fd6e9e3da7d)GetComponentAtIndex()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) TaleWorlds.Engine.Skeleton.GetComponentAtIndex | ( | [GameEntity.ComponentType](class_tale_worlds_1_1_engine_1_1_game_entity.html#ac6f57c8912eaaf5a59c14ec2f153350b) | *componentType*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a67d0476525c2e5d3f3b411270aba3c2a)SetUsePreciseBoundingVolume()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.SetUsePreciseBoundingVolume | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#aa46741d28622b608aac5f64ed5ce68f6)GetBoneEntitialRestFrame() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Skeleton.GetBoneEntitialRestFrame | ( | sbyte | *boneIndex*, |
|  |  | bool | *useBoneMapping* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a6b4c27e0c91f1f2a3fa666d635d7b531)GetBoneLocalRestFrame()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Skeleton.GetBoneLocalRestFrame | ( | sbyte | *boneIndex*, |
|  |  | bool | *useBoneMapping* = true ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9f0ea0c6c10e391fa1a52e9987831895)GetBoneEntitialRestFrame() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Skeleton.GetBoneEntitialRestFrame | ( | sbyte | *boneIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a231cd2fd0a96e027584ae53e780c78b5)GetBoneEntitialFrameAtChannel()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Skeleton.GetBoneEntitialFrameAtChannel | ( | int | *channelNo*, |
|  |  | sbyte | *boneIndex* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a232f6e124a4814364d56d146622aaa91)GetBoneEntitialFrame()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Skeleton.GetBoneEntitialFrame | ( | sbyte | *boneIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#aff5669f4cee3de964f396b403c944583)GetBoneComponentCount()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Skeleton.GetBoneComponentCount | ( | sbyte | *boneIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a905d4a9d71234875a7404f74f33c1c55)GetBoneComponentAtIndex()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) TaleWorlds.Engine.Skeleton.GetBoneComponentAtIndex | ( | sbyte | *boneIndex*, |
|  |  | int | *componentIndex* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a1300741737b0f9dcc21cb82a42f67783)HasBoneComponent()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Skeleton.HasBoneComponent | ( | sbyte | *boneIndex*, |
|  |  | [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | *component* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#acbceab6b6c536bdebc7bb1107682f616)AddComponentToBone()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.AddComponentToBone | ( | sbyte | *boneIndex*, |
|  |  | [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | *component* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a2af77cf3e1445b62041039363eb158d8)RemoveBoneComponent()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.RemoveBoneComponent | ( | sbyte | *boneIndex*, |
|  |  | [GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | *component* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a43b3db1cbc19e75dbd100b94a703310b)ClearMeshesAtBone()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.ClearMeshesAtBone | ( | sbyte | *boneIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#ac9fb5fd7241d38254da9421a5b4ce1f9)TickAnimations()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.TickAnimations | ( | float | *dt*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *globalFrame*, |
|  |  | bool | *tickAnimsForChildren* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a535172b4e72549b0664de1b51dcbf0d8)TickAnimationsAndForceUpdate()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.TickAnimationsAndForceUpdate | ( | float | *dt*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *globalFrame*, |
|  |  | bool | *tickAnimsForChildren* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#ab7c1f6e9506efe2d4cc8247952876057)GetAnimationParameterAtChannel()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Skeleton.GetAnimationParameterAtChannel | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a251bfaaa6f7fd1e545a9f5c443581b45)SetAnimationParameterAtChannel()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.SetAnimationParameterAtChannel | ( | int | *channelNo*, |
|  |  | float | *parameter* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#aa93eb92ca06fabff921168c5d9fca9bb)GetAnimationSpeedAtChannel()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Skeleton.GetAnimationSpeedAtChannel | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a85108ea47c168d063c265b5908f1c04f)SetAnimationSpeedAtChannel()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.SetAnimationSpeedAtChannel | ( | int | *channelNo*, |
|  |  | float | *speed* ) |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#ac1d41b75136489773ba5cbc947639f2f)SetUptoDate()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.SetUptoDate | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a2f1e8cd98a9c5dad82892fe7828f03ec)GetAnimationAtChannel()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.Skeleton.GetAnimationAtChannel | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a6576bffb2ffbdc0aea3f0796f4f78010)GetAnimationIndexAtChannel()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Skeleton.GetAnimationIndexAtChannel | ( | int | *channelNo* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#af64898e4425c6d7ab5ef586e26a8dec3)EnableScriptDrivenPostIntegrateCallback()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.EnableScriptDrivenPostIntegrateCallback | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#aed9ca04f2e2cbd33ff02dc981ff9e837)ResetCloths()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Skeleton.ResetCloths | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a05eeba55552609d50bfe8d9c1a620f3c)GetAllMeshes()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| IEnumerable< [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) > TaleWorlds.Engine.Skeleton.GetAllMeshes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#aaae4cce8774497c7b6f600cdc29f4876)GetBoneIndexFromName()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | sbyte TaleWorlds.Engine.Skeleton.GetBoneIndexFromName | ( | string | *skeletonModelName*, | |  |  | string | *boneName* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a9977148fe283392a2ee2607dca227121)MaxBoneCount
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const sbyte TaleWorlds.Engine.Skeleton.MaxBoneCount = 64 | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_skeleton.html#a0aacc8570af9f3f5c4f6aba9295841c5)IsValid
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.Skeleton.IsValid | | get |

