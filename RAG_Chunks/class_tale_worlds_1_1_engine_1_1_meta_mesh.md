--- SOURCE: class_tale_worlds_1_1_engine_1_1_meta_mesh.html ---

TaleWorlds.Engine.MetaMesh Class ReferencesealedInherits [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetLodMaskForMeshAtIndex](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a6450de8c709771217e4e4de2fed578ee) (int index) |
| int | [GetTotalGpuSize](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a0d7ad7bd166c8b06a05919fa10e2cf99) () |
| int | [RemoveMeshesWithTag](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a4b6e7eda07c456144b44e86df0a587ec) (string tag) |
| int | [RemoveMeshesWithoutTag](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a124c6eb203862e6548e88f46b63d35d9) (string tag) |
| int | [GetMeshCountWithTag](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#af852f50f67e6186303d7a773f836406b) (string tag) |
| bool | [HasVertexBufferOrEditDataOrPackageItem](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a3f9bd146101f63682d6585cf2f3fbc44) () |
| bool | [HasAnyGeneratedLods](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a0bd32e8234057e84165bcf5403d7a6b6) () |
| bool | [HasAnyLods](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#abb698bc17666cdc2105ac479caa84457) () |
| void | [CopyTo](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aababb816999554765005cb1eb12470b5) (MetaMesh res, bool copyMeshes=true) |
| void | [ClearMeshesForOtherLods](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#abe11663190afe582d3ad9f9641b98270) (int lodToKeep) |
| void | [ClearMeshesForLod](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ac310f4c57e69030100e6f55e553d1239) (int lodToClear) |
| void | [ClearMeshesForLowerLods](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a612a52d96850350007efdf8ba26c6f42) (int lodToClear) |
| void | [ClearMeshes](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a75022d70c1aea5f97d9d30ff20242c8d) () |
| void | [SetNumLods](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a02330ff8f3f8154141e2ab5d628c314e) (int lodToClear) |
| MetaMesh | [CreateCopy](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ab9a77cc0f551f56808443f49ed8dfabc) () |
| void | [AddMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#adaa5ae25010effd82710de3eb9ed4ef4) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh) |
| void | [AddMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a0128f6db5e21002677950ed1cfd1ff67) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, uint lodLevel) |
| void | [AddMetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a01e374979300d98a636d0fa5f31bd550) (MetaMesh metaMesh) |
| void | [SetCullMode](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a2ca01e84cb9c84c45e8bb707ce0562d5) ([MBMeshCullingMode](namespace_tale_worlds_1_1_engine.html#a8363ee42e6331c6a31ed88216accec29) cullMode) |
| void | [AddMaterialShaderFlag](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ab49c0e830d9c0804066127173b40909a) (String materialShaderFlag) |
| void | [MergeMultiMeshes](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ae74db02ea8b27714aec27952e80960d0) (MetaMesh metaMesh) |
| void | [AssignClothBodyFrom](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ae3b3c8d6a5d818c7964e89d9fadc752f) (MetaMesh metaMesh) |
| void | [BatchMultiMeshes](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aadb84a7d5dbd18f0dde97f7e6db7d78b) (MetaMesh metaMesh) |
| bool | [HasClothData](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a1bcf7809e4bcab2b60f9f4f8336de816) () |
| void | [BatchMultiMeshesMultiple](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a2d65262ac774eb70a57730eefcd599cb) (List< MetaMesh > metaMeshes) |
| void | [ClearEditData](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#afed434c10aa3868d9c9fcca99bebb70c) () |
| [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | [GetMeshAtIndex](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a2ee31472f508021ac01191007b9a594b) (int meshIndex) |
| [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | [GetFirstMeshWithTag](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aa654127975418c94b1094d52794a4613) (string tag) |
| uint | [GetFactor1](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ad152ecfbfac9c3b8be7c8159bee4365b) () |
| void | [SetGlossMultiplier](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aeb8b923fa51ecad23639538d40a38d72) (float value) |
| uint | [GetFactor2](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ab358f7b0f441e7a463f2c9b3d421ce3f) () |
| void | [SetFactor1Linear](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a731868c5c82d8a48ad87e3af1044156e) (uint linearFactorColor1) |
| void | [SetFactor2Linear](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aa7233f4432d71d94f759271c786c1ff6) (uint linearFactorColor2) |
| void | [SetFactor1](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ae69d1585caa3cda2337f6532e7372dc4) (uint factorColor1) |
| void | [SetFactor2](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aa0084696e9a97711f90df83207051172) (uint factorColor2) |
| void | [SetVectorArgument](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ab21fb2980ddc42b507c1b10d7fff6429) (float vectorArgument0, float vectorArgument1, float vectorArgument2, float vectorArgument3) |
| void | [SetVectorArgument2](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aaeb3a5e77c5eb6bb057d62b587511f86) (float vectorArgument0, float vectorArgument1, float vectorArgument2, float vectorArgument3) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVectorArgument2](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a34ddf4c335cf26290701f653fe7d8057) () |
| void | [SetMaterial](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a61625dda1f3795e6a940a33121862450) ([Material](class_tale_worlds_1_1_engine_1_1_material.html) material) |
| void | [SetShaderToMaterial](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#abc65d9d1a788c5d74a505f2578121f17) (string shaderName) |
| void | [SetLodBias](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a0580d461988f4f705b469eecbd7a941d) (int lodBias) |
| void | [SetBillboarding](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ac801daeff458abfeadf319cf4a9eceed) ([BillboardType](namespace_tale_worlds_1_1_engine.html#a3ed50bcc37546412a4aa400d33f3a001) billboard) |
| void | [UseHeadBoneFaceGenScaling](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a980a39fae7782b3535c6a388ef55f364) ([Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton, sbyte headLookDirectionBoneIndex, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [DrawTextWithDefaultFont](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a10dc4ac6ad9c4eccf8fe20feb4ef1d63) (string text, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) textPositionMin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) textPositionMax, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) size, uint color, [TextFlags](namespace_tale_worlds_1_1_engine.html#a12dc4c9892109f507c128ef79eb47ad7) flags) |
| void | [PreloadForRendering](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ad8d522209f3a9097b64ce87e75442d95) () |
| int | [CheckResources](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a37e6067db23dff98b34c63cc22280b9a) () |
| void | [PreloadShaders](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aa71d8219ab6f91a6d3f05e903d54d7bb) (bool useTableau, bool useTeamColor) |
| void | [RecomputeBoundingBox](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a126a749aee880242e6a6dbdff105cacd) (bool recomputeMeshes) |
| void | [AddEditDataUser](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ae73d85ebe0dff09adb1608ad2471c8c8) () |
| void | [ReleaseEditDataUser](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a3c92e42e1a8f5d990fe4f753eebb7413) () |
| void | [SetEditDataPolicy](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ab0c8304ab9d049f7fec0738b4b30ba68) ([EditDataPolicy](namespace_tale_worlds_1_1_engine.html#a154f0d3da1f401b48419a3304237eea4) policy) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [Fit](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a8e796326957969a6b9fb40e9dda33964) () |
| [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | [GetBoundingBox](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a061fccf15542eaea5a150ad6fd4cdf6d) () |
| [VisibilityMaskFlags](namespace_tale_worlds_1_1_engine.html#a4f08a181fb3293a5be29538dca70d788) | [GetVisibilityMask](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a5fca8819ee9e83030f19523e9b4e583a) () |
| void | [SetVisibilityMask](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a9d6f1e2ab4c51e3c7001355d6f0fdcef) ([VisibilityMaskFlags](namespace_tale_worlds_1_1_engine.html#a4f08a181fb3293a5be29538dca70d788) visibilityMask) |
| string | [GetName](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aae2c6bf4920e3b1c7a9563bb5ae32a3b) () |
| void | [SetContourState](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a3224b54ad44a894f1ab0d52b5f4fe1c4) (bool alwaysVisible) |
| void | [SetContourColor](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a586e9ebfc19c4bd6b72711ca4cdad7a7) (uint color) |
| void | [SetMaterialToSubMeshesWithTag](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a5cba1b7539bed7bd3d8e2b775787b55a) ([Material](class_tale_worlds_1_1_engine_1_1_material.html) bodyMaterial, string tag) |
| void | [SetFactorColorToSubMeshesWithTag](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a971fffde0ad5337d082e50bac45628b5) (uint color, string tag) |
| Public Member Functions inherited from [TaleWorlds.Engine.GameEntityComponent](class_tale_worlds_1_1_engine_1_1_game_entity_component.html) | |
| [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | [GetEntity](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa0b6323b87a63cb1e3ecba9b07328583) () |
| virtual [MetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html) | [GetFirstMetaMesh](class_tale_worlds_1_1_engine_1_1_game_entity_component.html#aa70e6c4e14725db6c11c3638d4336c03) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static MetaMesh | [CreateMetaMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a9cb8ed313c189cba9862a3245b599f90) (string name=null) |
| static MetaMesh | [GetCopy](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a4fbcae19186a582a3293dea2f9c2fdb6) (string metaMeshName, bool showErrors=true, bool mayReturnNull=false) |
| static void | [CheckMetaMeshExistence](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a40fe08b58128f83c577a20fcbc8c9adc) (string metaMeshName, int lod\_count\_check) |
| static MetaMesh | [GetMorphedCopy](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a17e51876d495ba1444130f87bf8abbf7) (string metaMeshName, float morphTarget, bool showErrors) |
| static void | [GetAllMultiMeshes](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#af861bd48af11a82f1c7135aa80cb8cab) (ref List< MetaMesh > multiMeshList) |
| static MetaMesh | [GetMultiMesh](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aeb4cb2ef4fe85bbf3909c1adb68a8f61) (string name) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a4a228646623ced1bfda7bf7a36f29aed) `[get]` |
| int | [MeshCount](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a9fba7a72107a41ec088928b90e9b0d77) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [Frame](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a5a8e84404f1c071ad5c0cf1657b4247f) `[get, set]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [VectorUserData](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a8052bc8736697cd4bdedb2feac4d567e) `[get, set]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a9cb8ed313c189cba9862a3245b599f90)CreateMetaMesh()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MetaMesh TaleWorlds.Engine.MetaMesh.CreateMetaMesh | ( | string | *name* = null | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a6450de8c709771217e4e4de2fed578ee)GetLodMaskForMeshAtIndex()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.MetaMesh.GetLodMaskForMeshAtIndex | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a0d7ad7bd166c8b06a05919fa10e2cf99)GetTotalGpuSize()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.MetaMesh.GetTotalGpuSize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a4b6e7eda07c456144b44e86df0a587ec)RemoveMeshesWithTag()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.MetaMesh.RemoveMeshesWithTag | ( | string | *tag* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a124c6eb203862e6548e88f46b63d35d9)RemoveMeshesWithoutTag()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.MetaMesh.RemoveMeshesWithoutTag | ( | string | *tag* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#af852f50f67e6186303d7a773f836406b)GetMeshCountWithTag()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.MetaMesh.GetMeshCountWithTag | ( | string | *tag* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a3f9bd146101f63682d6585cf2f3fbc44)HasVertexBufferOrEditDataOrPackageItem()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.MetaMesh.HasVertexBufferOrEditDataOrPackageItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a0bd32e8234057e84165bcf5403d7a6b6)HasAnyGeneratedLods()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.MetaMesh.HasAnyGeneratedLods | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#abb698bc17666cdc2105ac479caa84457)HasAnyLods()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.MetaMesh.HasAnyLods | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a4fbcae19186a582a3293dea2f9c2fdb6)GetCopy()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MetaMesh TaleWorlds.Engine.MetaMesh.GetCopy | ( | string | *metaMeshName*, | |  |  | bool | *showErrors* = true, | |  |  | bool | *mayReturnNull* = false ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aababb816999554765005cb1eb12470b5)CopyTo()
----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.CopyTo | ( | MetaMesh | *res*, |
|  |  | bool | *copyMeshes* = true ) |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#abe11663190afe582d3ad9f9641b98270)ClearMeshesForOtherLods()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.ClearMeshesForOtherLods | ( | int | *lodToKeep* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ac310f4c57e69030100e6f55e553d1239)ClearMeshesForLod()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.ClearMeshesForLod | ( | int | *lodToClear* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a612a52d96850350007efdf8ba26c6f42)ClearMeshesForLowerLods()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.ClearMeshesForLowerLods | ( | int | *lodToClear* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a75022d70c1aea5f97d9d30ff20242c8d)ClearMeshes()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.ClearMeshes | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a02330ff8f3f8154141e2ab5d628c314e)SetNumLods()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetNumLods | ( | int | *lodToClear* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a40fe08b58128f83c577a20fcbc8c9adc)CheckMetaMeshExistence()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.MetaMesh.CheckMetaMeshExistence | ( | string | *metaMeshName*, | |  |  | int | *lod\_count\_check* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a17e51876d495ba1444130f87bf8abbf7)GetMorphedCopy()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MetaMesh TaleWorlds.Engine.MetaMesh.GetMorphedCopy | ( | string | *metaMeshName*, | |  |  | float | *morphTarget*, | |  |  | bool | *showErrors* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ab9a77cc0f551f56808443f49ed8dfabc)CreateCopy()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| MetaMesh TaleWorlds.Engine.MetaMesh.CreateCopy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#adaa5ae25010effd82710de3eb9ed4ef4)AddMesh() [1/2]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.AddMesh | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a0128f6db5e21002677950ed1cfd1ff67)AddMesh() [2/2]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.AddMesh | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | uint | *lodLevel* ) |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a01e374979300d98a636d0fa5f31bd550)AddMetaMesh()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.AddMetaMesh | ( | MetaMesh | *metaMesh* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a2ca01e84cb9c84c45e8bb707ce0562d5)SetCullMode()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetCullMode | ( | [MBMeshCullingMode](namespace_tale_worlds_1_1_engine.html#a8363ee42e6331c6a31ed88216accec29) | *cullMode* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ab49c0e830d9c0804066127173b40909a)AddMaterialShaderFlag()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.AddMaterialShaderFlag | ( | String | *materialShaderFlag* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ae74db02ea8b27714aec27952e80960d0)MergeMultiMeshes()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.MergeMultiMeshes | ( | MetaMesh | *metaMesh* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ae3b3c8d6a5d818c7964e89d9fadc752f)AssignClothBodyFrom()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.AssignClothBodyFrom | ( | MetaMesh | *metaMesh* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aadb84a7d5dbd18f0dde97f7e6db7d78b)BatchMultiMeshes()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.BatchMultiMeshes | ( | MetaMesh | *metaMesh* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a1bcf7809e4bcab2b60f9f4f8336de816)HasClothData()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.MetaMesh.HasClothData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a2d65262ac774eb70a57730eefcd599cb)BatchMultiMeshesMultiple()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.BatchMultiMeshesMultiple | ( | List< MetaMesh > | *metaMeshes* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#afed434c10aa3868d9c9fcca99bebb70c)ClearEditData()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.ClearEditData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a2ee31472f508021ac01191007b9a594b)GetMeshAtIndex()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) TaleWorlds.Engine.MetaMesh.GetMeshAtIndex | ( | int | *meshIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aa654127975418c94b1094d52794a4613)GetFirstMeshWithTag()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) TaleWorlds.Engine.MetaMesh.GetFirstMeshWithTag | ( | string | *tag* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ad152ecfbfac9c3b8be7c8159bee4365b)GetFactor1()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.MetaMesh.GetFactor1 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aeb8b923fa51ecad23639538d40a38d72)SetGlossMultiplier()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetGlossMultiplier | ( | float | *value* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ab358f7b0f441e7a463f2c9b3d421ce3f)GetFactor2()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.MetaMesh.GetFactor2 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a731868c5c82d8a48ad87e3af1044156e)SetFactor1Linear()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetFactor1Linear | ( | uint | *linearFactorColor1* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aa7233f4432d71d94f759271c786c1ff6)SetFactor2Linear()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetFactor2Linear | ( | uint | *linearFactorColor2* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ae69d1585caa3cda2337f6532e7372dc4)SetFactor1()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetFactor1 | ( | uint | *factorColor1* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aa0084696e9a97711f90df83207051172)SetFactor2()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetFactor2 | ( | uint | *factorColor2* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ab21fb2980ddc42b507c1b10d7fff6429)SetVectorArgument()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetVectorArgument | ( | float | *vectorArgument0*, |
|  |  | float | *vectorArgument1*, |
|  |  | float | *vectorArgument2*, |
|  |  | float | *vectorArgument3* ) |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aaeb3a5e77c5eb6bb057d62b587511f86)SetVectorArgument2()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetVectorArgument2 | ( | float | *vectorArgument0*, |
|  |  | float | *vectorArgument1*, |
|  |  | float | *vectorArgument2*, |
|  |  | float | *vectorArgument3* ) |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a34ddf4c335cf26290701f653fe7d8057)GetVectorArgument2()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.MetaMesh.GetVectorArgument2 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a61625dda1f3795e6a940a33121862450)SetMaterial()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetMaterial | ( | [Material](class_tale_worlds_1_1_engine_1_1_material.html) | *material* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#abc65d9d1a788c5d74a505f2578121f17)SetShaderToMaterial()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetShaderToMaterial | ( | string | *shaderName* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a0580d461988f4f705b469eecbd7a941d)SetLodBias()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetLodBias | ( | int | *lodBias* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ac801daeff458abfeadf319cf4a9eceed)SetBillboarding()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetBillboarding | ( | [BillboardType](namespace_tale_worlds_1_1_engine.html#a3ed50bcc37546412a4aa400d33f3a001) | *billboard* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a980a39fae7782b3535c6a388ef55f364)UseHeadBoneFaceGenScaling()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.UseHeadBoneFaceGenScaling | ( | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton*, |
|  |  | sbyte | *headLookDirectionBoneIndex*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a10dc4ac6ad9c4eccf8fe20feb4ef1d63)DrawTextWithDefaultFont()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.DrawTextWithDefaultFont | ( | string | *text*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *textPositionMin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *textPositionMax*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *size*, |
|  |  | uint | *color*, |
|  |  | [TextFlags](namespace_tale_worlds_1_1_engine.html#a12dc4c9892109f507c128ef79eb47ad7) | *flags* ) |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ad8d522209f3a9097b64ce87e75442d95)PreloadForRendering()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.PreloadForRendering | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a37e6067db23dff98b34c63cc22280b9a)CheckResources()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.MetaMesh.CheckResources | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aa71d8219ab6f91a6d3f05e903d54d7bb)PreloadShaders()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.PreloadShaders | ( | bool | *useTableau*, |
|  |  | bool | *useTeamColor* ) |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a126a749aee880242e6a6dbdff105cacd)RecomputeBoundingBox()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.RecomputeBoundingBox | ( | bool | *recomputeMeshes* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ae73d85ebe0dff09adb1608ad2471c8c8)AddEditDataUser()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.AddEditDataUser | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a3c92e42e1a8f5d990fe4f753eebb7413)ReleaseEditDataUser()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.ReleaseEditDataUser | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#ab0c8304ab9d049f7fec0738b4b30ba68)SetEditDataPolicy()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetEditDataPolicy | ( | [EditDataPolicy](namespace_tale_worlds_1_1_engine.html#a154f0d3da1f401b48419a3304237eea4) | *policy* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a8e796326957969a6b9fb40e9dda33964)Fit()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.MetaMesh.Fit | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a061fccf15542eaea5a150ad6fd4cdf6d)GetBoundingBox()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) TaleWorlds.Engine.MetaMesh.GetBoundingBox | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a5fca8819ee9e83030f19523e9b4e583a)GetVisibilityMask()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [VisibilityMaskFlags](namespace_tale_worlds_1_1_engine.html#a4f08a181fb3293a5be29538dca70d788) TaleWorlds.Engine.MetaMesh.GetVisibilityMask | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a9d6f1e2ab4c51e3c7001355d6f0fdcef)SetVisibilityMask()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetVisibilityMask | ( | [VisibilityMaskFlags](namespace_tale_worlds_1_1_engine.html#a4f08a181fb3293a5be29538dca70d788) | *visibilityMask* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aae2c6bf4920e3b1c7a9563bb5ae32a3b)GetName()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.MetaMesh.GetName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#af861bd48af11a82f1c7135aa80cb8cab)GetAllMultiMeshes()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.MetaMesh.GetAllMultiMeshes | ( | ref List< MetaMesh > | *multiMeshList* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#aeb4cb2ef4fe85bbf3909c1adb68a8f61)GetMultiMesh()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MetaMesh TaleWorlds.Engine.MetaMesh.GetMultiMesh | ( | string | *name* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a3224b54ad44a894f1ab0d52b5f4fe1c4)SetContourState()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetContourState | ( | bool | *alwaysVisible* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a586e9ebfc19c4bd6b72711ca4cdad7a7)SetContourColor()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetContourColor | ( | uint | *color* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a5cba1b7539bed7bd3d8e2b775787b55a)SetMaterialToSubMeshesWithTag()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetMaterialToSubMeshesWithTag | ( | [Material](class_tale_worlds_1_1_engine_1_1_material.html) | *bodyMaterial*, |
|  |  | string | *tag* ) |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a971fffde0ad5337d082e50bac45628b5)SetFactorColorToSubMeshesWithTag()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.MetaMesh.SetFactorColorToSubMeshesWithTag | ( | uint | *color*, |
|  |  | string | *tag* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a4a228646623ced1bfda7bf7a36f29aed)IsValid
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.MetaMesh.IsValid | | get |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a9fba7a72107a41ec088928b90e9b0d77)MeshCount
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.MetaMesh.MeshCount | | get |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a5a8e84404f1c071ad5c0cf1657b4247f)Frame
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.MetaMesh.Frame | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_meta_mesh.html#a8052bc8736697cd4bdedb2feac4d567e)VectorUserData
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.MetaMesh.VectorUserData | | getset |

