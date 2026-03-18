--- SOURCE: class_tale_worlds_1_1_engine_1_1_mesh.html ---

TaleWorlds.Engine.Mesh Class ReferencesealedInherits [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| Mesh | [GetBaseMesh](class_tale_worlds_1_1_engine_1_1_mesh.html#ac4f1338d189d1dffd3ef278f61eda25d) () |
| void | [SetColorAndStroke](class_tale_worlds_1_1_engine_1_1_mesh.html#a300ed72e457b97990144db3f3726496d) (uint color, uint strokeColor, bool drawStroke) |
| void | [SetMeshRenderOrder](class_tale_worlds_1_1_engine_1_1_mesh.html#aa530430e0334c3fbfe50e1141a2eea54) (int renderOrder) |
| bool | [HasTag](class_tale_worlds_1_1_engine_1_1_mesh.html#a63a00f9c7ba89bb3aa3bdb8f96814223) (string str) |
| Mesh | [CreateCopy](class_tale_worlds_1_1_engine_1_1_mesh.html#a0410446422ee77a9372c523e77ed5ef7) () |
|  | Creates and returns a separate copy of this mesh. |
| void | [SetMaterial](class_tale_worlds_1_1_engine_1_1_mesh.html#ab8e5ecb463260fadb237c93dc13f5cd1) (string newMaterialName) |
| void | [SetVectorArgument](class_tale_worlds_1_1_engine_1_1_mesh.html#af37bfb87bb623aae111ea9c3f7135270) (float vectorArgument0, float vectorArgument1, float vectorArgument2, float vectorArgument3) |
| void | [SetVectorArgument2](class_tale_worlds_1_1_engine_1_1_mesh.html#a158be45f06134585ece74a14ad285d51) (float vectorArgument0, float vectorArgument1, float vectorArgument2, float vectorArgument3) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVectorArgument](class_tale_worlds_1_1_engine_1_1_mesh.html#a709fe2c1ddb6450fabbb6e4727891ef0) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVectorArgument2](class_tale_worlds_1_1_engine_1_1_mesh.html#a2bfa3807de9cd0930951c78dc4cfcf7e) () |
| void | [SetupAdditionalBoneBuffer](class_tale_worlds_1_1_engine_1_1_mesh.html#a308dd8fe9faa2e15cbd2aa12e03b80db) (int numBones) |
| void | [SetAdditionalBoneFrame](class_tale_worlds_1_1_engine_1_1_mesh.html#abc84b0804687646f025de8fcbfb5089b) (int boneIndex, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [SetMaterial](class_tale_worlds_1_1_engine_1_1_mesh.html#aeefeff4c3708f3713608ecb2274d2a3d) ([Material](class_tale_worlds_1_1_engine_1_1_material.html) material) |
|  | Sets 'material' as the material of this mesh. |
| [Material](class_tale_worlds_1_1_engine_1_1_material.html) | [GetMaterial](class_tale_worlds_1_1_engine_1_1_mesh.html#af45af681382f2d7b50334fc560a6f56e) () |
| [Material](class_tale_worlds_1_1_engine_1_1_material.html) | [GetSecondMaterial](class_tale_worlds_1_1_engine_1_1_mesh.html#aed619894b14e682cc76a51e375c2613b) () |
| int | [AddFaceCorner](class_tale_worlds_1_1_engine_1_1_mesh.html#ab3d73faf528129c7a16d7bb7a5847fa4) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) normal, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uvCoord, uint color, System.UIntPtr lockHandle) |
| int | [AddFace](class_tale_worlds_1_1_engine_1_1_mesh.html#a93f8ce9396cb3a8b69ba0ff6b5d625a7) (int patchNode0, int patchNode1, int patchNode2, System.UIntPtr lockHandle) |
| void | [ClearMesh](class_tale_worlds_1_1_engine_1_1_mesh.html#a2108f1db328bcd5863adc8abeca54768) () |
| void | [SetColorAlpha](class_tale_worlds_1_1_engine_1_1_mesh.html#aab5eb27353c5abe9002050ea2b0dfca2) (uint newAlpha) |
| uint | [GetFaceCount](class_tale_worlds_1_1_engine_1_1_mesh.html#aa9bfe6b86475ffafa7fa70a547d1cb31) () |
| uint | [GetFaceCornerCount](class_tale_worlds_1_1_engine_1_1_mesh.html#ac412dfaec6ac351559dc69d8726fa229) () |
| void | [ComputeNormals](class_tale_worlds_1_1_engine_1_1_mesh.html#aef6b5de52c60af395cc9ae55067f2873) () |
| void | [ComputeTangents](class_tale_worlds_1_1_engine_1_1_mesh.html#a45d4d4bf24fe47ddacb620701157e536) () |
| void | [AddMesh](class_tale_worlds_1_1_engine_1_1_mesh.html#a33cf9fc532ea74331b54de73e5a598b7) (string meshResourceName, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) meshFrame) |
| void | [AddMesh](class_tale_worlds_1_1_engine_1_1_mesh.html#a4d9c53f7f3e2cb6375a264c95e7fdad7) (Mesh mesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) meshFrame) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetLocalFrame](class_tale_worlds_1_1_engine_1_1_mesh.html#af6821c1324699309f36d5ec8931923f0) () |
| void | [SetLocalFrame](class_tale_worlds_1_1_engine_1_1_mesh.html#ae7bc60acc32d66c1588d761b05bc83a7) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) meshFrame) |
| void | [SetVisibilityMask](class_tale_worlds_1_1_engine_1_1_mesh.html#a29c3d88c77844910b4e943dd2bfe571f) ([VisibilityMaskFlags](namespace_tale_worlds_1_1_engine.html#a4f08a181fb3293a5be29538dca70d788) visibilityMask) |
| void | [UpdateBoundingBox](class_tale_worlds_1_1_engine_1_1_mesh.html#a0316a719acac0d1e9a19e14b5f924021) () |
| void | [SetAsNotEffectedBySeason](class_tale_worlds_1_1_engine_1_1_mesh.html#ab2fba8c10c01ba59dca8318416955d0d) () |
| float | [GetBoundingBoxWidth](class_tale_worlds_1_1_engine_1_1_mesh.html#ac830e49aa3af00a9744132a02c3f3331) () |
| float | [GetBoundingBoxHeight](class_tale_worlds_1_1_engine_1_1_mesh.html#ad2835787f22c11cf2f50c45796527aa3) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetBoundingBoxMin](class_tale_worlds_1_1_engine_1_1_mesh.html#a66c9b128db74cbb72adb928705cc68c2) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetBoundingBoxMax](class_tale_worlds_1_1_engine_1_1_mesh.html#a9975fb5dc15767af49dce7a47bb77311) () |
| void | [AddTriangle](class_tale_worlds_1_1_engine_1_1_mesh.html#aa031737249f350bfe2ed377c1576ad9d) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p2, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p3, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv2, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv3, uint color, System.UIntPtr lockHandle) |
| void | [AddTriangleWithVertexColors](class_tale_worlds_1_1_engine_1_1_mesh.html#a440d7536eef78fcb2a19914aa8ce4fe3) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p2, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p3, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv2, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv3, uint c1, uint c2, uint c3, System.UIntPtr lockHandle) |
| void | [HintIndicesDynamic](class_tale_worlds_1_1_engine_1_1_mesh.html#a5bf1cbe901d0f634503a29fe158514d4) () |
| void | [HintVerticesDynamic](class_tale_worlds_1_1_engine_1_1_mesh.html#a497c532e4efd602e346381a590adf630) () |
| void | [RecomputeBoundingBox](class_tale_worlds_1_1_engine_1_1_mesh.html#aa5c8c10d3e0daf9893faed27861d2c1a) () |
| void | [SetEditDataFaceCornerVertexColor](class_tale_worlds_1_1_engine_1_1_mesh.html#ad7d4060b44c5bfdbebd0c21fe28d928c) (int index, uint color) |
| uint | [GetEditDataFaceCornerVertexColor](class_tale_worlds_1_1_engine_1_1_mesh.html#aada662cc95904dc3c02b73b18b94de60) (int index) |
| void | [PreloadForRendering](class_tale_worlds_1_1_engine_1_1_mesh.html#add9ad8ce9e64b395eb0d220642eb3f75) () |
| void | [SetContourColor](class_tale_worlds_1_1_engine_1_1_mesh.html#a7596cebb31c24fcc2c80be91afe3e360) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color, bool alwaysVisible, bool maskMesh) |
| void | [DisableContour](class_tale_worlds_1_1_engine_1_1_mesh.html#a9176106d6ec46cc5e9f633e8f565cdac) () |
| void | [SetExternalBoundingBox](class_tale_worlds_1_1_engine_1_1_mesh.html#a69bd54325677f46c2a74551e9a762b1e) ([BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) bbox) |
| void | [AddEditDataUser](class_tale_worlds_1_1_engine_1_1_mesh.html#ae94eb821821a99a449cac5f25f13549c) () |
| void | [ReleaseEditDataUser](class_tale_worlds_1_1_engine_1_1_mesh.html#a4a8e6f885a37d50ef286b98d10497c20) () |
| void | [SetEditDataPolicy](class_tale_worlds_1_1_engine_1_1_mesh.html#a37755beaf3f7287807ac1c5075a15841) ([EditDataPolicy](namespace_tale_worlds_1_1_engine.html#a154f0d3da1f401b48419a3304237eea4) policy) |
| System.UIntPtr | [LockEditDataWrite](class_tale_worlds_1_1_engine_1_1_mesh.html#a26ce7496bc35a80576da4238dcb8741a) () |
| void | [UnlockEditDataWrite](class_tale_worlds_1_1_engine_1_1_mesh.html#a094fe7d517f56eb9ac07da94716f6d0d) (System.UIntPtr handle) |
| void | [SetCustomClipPlane](class_tale_worlds_1_1_engine_1_1_mesh.html#a28a217a4566ca472b93f56a9cc7279b2) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) clipPlanePosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) clipPlaneNormal, int planeIndex) |
| float | [GetClothLinearVelocityMultiplier](class_tale_worlds_1_1_engine_1_1_mesh.html#ad6c391a7e9fe3245395a72e4ef9e09cd) () |
| bool | [HasCloth](class_tale_worlds_1_1_engine_1_1_mesh.html#a6f6022328f20071968292fd7eee13334) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static Mesh | [CreateMeshWithMaterial](class_tale_worlds_1_1_engine_1_1_mesh.html#ab7d211c992cde826d2cfc31ee90a338b) ([Material](class_tale_worlds_1_1_engine_1_1_material.html) material) |
| static Mesh | [CreateMesh](class_tale_worlds_1_1_engine_1_1_mesh.html#a286619e39577489d069b6be2f28c1e70) (bool editable=true) |
| static Mesh | [GetFromResource](class_tale_worlds_1_1_engine_1_1_mesh.html#ab480be88e7d483af580cc6e400d0399e) (string meshName) |
|  | Initializes a new instance of the MBMesh class. Creates an empty mesh. Since each mesh need to have a material, it should be provided by 'material'. |
| static Mesh | [GetRandomMeshWithVdecl](class_tale_worlds_1_1_engine_1_1_mesh.html#a36b4d09c45f5d5eec7a74c7a7e9a26ff) (int inputLayout) |

|  |  |
| --- | --- |
| Properties | |
| string | [Name](class_tale_worlds_1_1_engine_1_1_mesh.html#a923626fd9dd8192fce4a3759b521cb24) `[get, set]` |
| [MBMeshCullingMode](namespace_tale_worlds_1_1_engine.html#a8363ee42e6331c6a31ed88216accec29) | [CullingMode](class_tale_worlds_1_1_engine_1_1_mesh.html#ab2f63f43196868c2c42f7f4773496be2) `[set]` |
| float | [MorphTime](class_tale_worlds_1_1_engine_1_1_mesh.html#a597d1623d5aab89e4c07f831cbca3b1f) `[set]` |
| uint | [Color](class_tale_worlds_1_1_engine_1_1_mesh.html#a604b51d890d188aecc0bced025a88ea9) `[get, set]` |
|  | Primary color. |
| uint | [Color2](class_tale_worlds_1_1_engine_1_1_mesh.html#afce1b6453f24e92fbafb52febb0b8a0d) `[get, set]` |
|  | Secondary color. |
| [BillboardType](namespace_tale_worlds_1_1_engine.html#a3ed50bcc37546412a4aa400d33f3a001) | [Billboard](class_tale_worlds_1_1_engine_1_1_mesh.html#a82b91ea486cfb307055da4d1ee6609a9) `[get, set]` |
| [VisibilityMaskFlags](namespace_tale_worlds_1_1_engine.html#a4f08a181fb3293a5be29538dca70d788) | [VisibilityMask](class_tale_worlds_1_1_engine_1_1_mesh.html#ae0cca8a110d0899c0d25347b4cfd8fb5) `[get, set]` |
| int | [EditDataFaceCornerCount](class_tale_worlds_1_1_engine_1_1_mesh.html#a857378948ed0d7b79d5c9a9f204de825) `[get]` |
| Properties inherited from [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html) | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_resource.html#ad0c94ab0bd3bcdd26b02ac6117e7662f) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html) | |
|  | [Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) () |
| void | [CheckResourceParameter](class_tale_worlds_1_1_engine_1_1_resource.html#acb4f0c2d802a8a8530c3813f8c7e9c5d) ([Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) param, string paramName="") |
|  | Check if the parameter 'param' is null or invalid and throws an exception containing 'paramName' as further information. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ab7d211c992cde826d2cfc31ee90a338b)CreateMeshWithMaterial()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Mesh TaleWorlds.Engine.Mesh.CreateMeshWithMaterial | ( | [Material](class_tale_worlds_1_1_engine_1_1_material.html) | *material* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a286619e39577489d069b6be2f28c1e70)CreateMesh()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Mesh TaleWorlds.Engine.Mesh.CreateMesh | ( | bool | *editable* = true | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ac4f1338d189d1dffd3ef278f61eda25d)GetBaseMesh()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Mesh TaleWorlds.Engine.Mesh.GetBaseMesh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ab480be88e7d483af580cc6e400d0399e)GetFromResource()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Mesh TaleWorlds.Engine.Mesh.GetFromResource | ( | string | *meshName* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | material | The material. |

Returns a MBMesh instance whose name is 'meshName'.

Parameters
:   |  |  |
    | --- | --- |
    | meshName | Name of the mesh to get |

Returns
:   Returns the MBMesh representation of the mesh named 'meshName'. Returns the previously retrieved instance. A new instance is created if there is none previously or its has been GCed. Returns null if there is no mesh named 'meshName'

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a36b4d09c45f5d5eec7a74c7a7e9a26ff)GetRandomMeshWithVdecl()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | Mesh TaleWorlds.Engine.Mesh.GetRandomMeshWithVdecl | ( | int | *inputLayout* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a300ed72e457b97990144db3f3726496d)SetColorAndStroke()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetColorAndStroke | ( | uint | *color*, |
|  |  | uint | *strokeColor*, |
|  |  | bool | *drawStroke* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#aa530430e0334c3fbfe50e1141a2eea54)SetMeshRenderOrder()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetMeshRenderOrder | ( | int | *renderOrder* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a63a00f9c7ba89bb3aa3bdb8f96814223)HasTag()
-----------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Mesh.HasTag | ( | string | *str* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a0410446422ee77a9372c523e77ed5ef7)CreateCopy()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Mesh TaleWorlds.Engine.Mesh.CreateCopy | ( |  | ) |  |

Returns
:   Returns a separate copy of this mesh

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ab8e5ecb463260fadb237c93dc13f5cd1)SetMaterial() [1/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetMaterial | ( | string | *newMaterialName* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#af37bfb87bb623aae111ea9c3f7135270)SetVectorArgument()
----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetVectorArgument | ( | float | *vectorArgument0*, |
|  |  | float | *vectorArgument1*, |
|  |  | float | *vectorArgument2*, |
|  |  | float | *vectorArgument3* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a158be45f06134585ece74a14ad285d51)SetVectorArgument2()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetVectorArgument2 | ( | float | *vectorArgument0*, |
|  |  | float | *vectorArgument1*, |
|  |  | float | *vectorArgument2*, |
|  |  | float | *vectorArgument3* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a709fe2c1ddb6450fabbb6e4727891ef0)GetVectorArgument()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Mesh.GetVectorArgument | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a2bfa3807de9cd0930951c78dc4cfcf7e)GetVectorArgument2()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Mesh.GetVectorArgument2 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a308dd8fe9faa2e15cbd2aa12e03b80db)SetupAdditionalBoneBuffer()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetupAdditionalBoneBuffer | ( | int | *numBones* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#abc84b0804687646f025de8fcbfb5089b)SetAdditionalBoneFrame()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetAdditionalBoneFrame | ( | int | *boneIndex*, |
|  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#aeefeff4c3708f3713608ecb2274d2a3d)SetMaterial() [2/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetMaterial | ( | [Material](class_tale_worlds_1_1_engine_1_1_material.html) | *material* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | material | The material to set |

Returns

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#af45af681382f2d7b50334fc560a6f56e)GetMaterial()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Material](class_tale_worlds_1_1_engine_1_1_material.html) TaleWorlds.Engine.Mesh.GetMaterial | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#aed619894b14e682cc76a51e375c2613b)GetSecondMaterial()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Material](class_tale_worlds_1_1_engine_1_1_material.html) TaleWorlds.Engine.Mesh.GetSecondMaterial | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ab3d73faf528129c7a16d7bb7a5847fa4)AddFaceCorner()
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.Mesh.AddFaceCorner | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *normal*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uvCoord*, |
|  |  | uint | *color*, |
|  |  | System.UIntPtr | *lockHandle* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a93f8ce9396cb3a8b69ba0ff6b5d625a7)AddFace()
------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.Mesh.AddFace | ( | int | *patchNode0*, |
|  |  | int | *patchNode1*, |
|  |  | int | *patchNode2*, |
|  |  | System.UIntPtr | *lockHandle* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a2108f1db328bcd5863adc8abeca54768)ClearMesh()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.ClearMesh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#aab5eb27353c5abe9002050ea2b0dfca2)SetColorAlpha()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetColorAlpha | ( | uint | *newAlpha* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#aa9bfe6b86475ffafa7fa70a547d1cb31)GetFaceCount()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.Mesh.GetFaceCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ac412dfaec6ac351559dc69d8726fa229)GetFaceCornerCount()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.Mesh.GetFaceCornerCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#aef6b5de52c60af395cc9ae55067f2873)ComputeNormals()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.ComputeNormals | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a45d4d4bf24fe47ddacb620701157e536)ComputeTangents()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.ComputeTangents | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a33cf9fc532ea74331b54de73e5a598b7)AddMesh() [1/2]
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.AddMesh | ( | string | *meshResourceName*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *meshFrame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a4d9c53f7f3e2cb6375a264c95e7fdad7)AddMesh() [2/2]
------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.AddMesh | ( | Mesh | *mesh*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *meshFrame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#af6821c1324699309f36d5ec8931923f0)GetLocalFrame()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Mesh.GetLocalFrame | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ae7bc60acc32d66c1588d761b05bc83a7)SetLocalFrame()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetLocalFrame | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *meshFrame* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a29c3d88c77844910b4e943dd2bfe571f)SetVisibilityMask()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetVisibilityMask | ( | [VisibilityMaskFlags](namespace_tale_worlds_1_1_engine.html#a4f08a181fb3293a5be29538dca70d788) | *visibilityMask* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a0316a719acac0d1e9a19e14b5f924021)UpdateBoundingBox()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.UpdateBoundingBox | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ab2fba8c10c01ba59dca8318416955d0d)SetAsNotEffectedBySeason()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetAsNotEffectedBySeason | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ac830e49aa3af00a9744132a02c3f3331)GetBoundingBoxWidth()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Mesh.GetBoundingBoxWidth | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ad2835787f22c11cf2f50c45796527aa3)GetBoundingBoxHeight()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Mesh.GetBoundingBoxHeight | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a66c9b128db74cbb72adb928705cc68c2)GetBoundingBoxMin()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Mesh.GetBoundingBoxMin | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a9975fb5dc15767af49dce7a47bb77311)GetBoundingBoxMax()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.Mesh.GetBoundingBoxMax | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#aa031737249f350bfe2ed377c1576ad9d)AddTriangle()
----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.AddTriangle | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p1*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p2*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p3*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv1*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv2*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv3*, |
|  |  | uint | *color*, |
|  |  | System.UIntPtr | *lockHandle* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a440d7536eef78fcb2a19914aa8ce4fe3)AddTriangleWithVertexColors()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.AddTriangleWithVertexColors | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p1*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p2*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p3*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv1*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv2*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv3*, |
|  |  | uint | *c1*, |
|  |  | uint | *c2*, |
|  |  | uint | *c3*, |
|  |  | System.UIntPtr | *lockHandle* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a5bf1cbe901d0f634503a29fe158514d4)HintIndicesDynamic()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.HintIndicesDynamic | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a497c532e4efd602e346381a590adf630)HintVerticesDynamic()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.HintVerticesDynamic | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#aa5c8c10d3e0daf9893faed27861d2c1a)RecomputeBoundingBox()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.RecomputeBoundingBox | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ad7d4060b44c5bfdbebd0c21fe28d928c)SetEditDataFaceCornerVertexColor()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetEditDataFaceCornerVertexColor | ( | int | *index*, |
|  |  | uint | *color* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#aada662cc95904dc3c02b73b18b94de60)GetEditDataFaceCornerVertexColor()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| uint TaleWorlds.Engine.Mesh.GetEditDataFaceCornerVertexColor | ( | int | *index* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#add9ad8ce9e64b395eb0d220642eb3f75)PreloadForRendering()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.PreloadForRendering | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a7596cebb31c24fcc2c80be91afe3e360)SetContourColor()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetContourColor | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color*, |
|  |  | bool | *alwaysVisible*, |
|  |  | bool | *maskMesh* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a9176106d6ec46cc5e9f633e8f565cdac)DisableContour()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.DisableContour | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a69bd54325677f46c2a74551e9a762b1e)SetExternalBoundingBox()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetExternalBoundingBox | ( | [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | *bbox* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ae94eb821821a99a449cac5f25f13549c)AddEditDataUser()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.AddEditDataUser | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a4a8e6f885a37d50ef286b98d10497c20)ReleaseEditDataUser()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.ReleaseEditDataUser | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a37755beaf3f7287807ac1c5075a15841)SetEditDataPolicy()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetEditDataPolicy | ( | [EditDataPolicy](namespace_tale_worlds_1_1_engine.html#a154f0d3da1f401b48419a3304237eea4) | *policy* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a26ce7496bc35a80576da4238dcb8741a)LockEditDataWrite()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| System.UIntPtr TaleWorlds.Engine.Mesh.LockEditDataWrite | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a094fe7d517f56eb9ac07da94716f6d0d)UnlockEditDataWrite()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.UnlockEditDataWrite | ( | System.UIntPtr | *handle* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a28a217a4566ca472b93f56a9cc7279b2)SetCustomClipPlane()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Mesh.SetCustomClipPlane | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *clipPlanePosition*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *clipPlaneNormal*, |
|  |  | int | *planeIndex* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ad6c391a7e9fe3245395a72e4ef9e09cd)GetClothLinearVelocityMultiplier()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Mesh.GetClothLinearVelocityMultiplier | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a6f6022328f20071968292fd7eee13334)HasCloth()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Engine.Mesh.HasCloth | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a923626fd9dd8192fce4a3759b521cb24)Name
-------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Engine.Mesh.Name | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ab2f63f43196868c2c42f7f4773496be2)CullingMode
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MBMeshCullingMode](namespace_tale_worlds_1_1_engine.html#a8363ee42e6331c6a31ed88216accec29) TaleWorlds.Engine.Mesh.CullingMode | | set |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a597d1623d5aab89e4c07f831cbca3b1f)MorphTime
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.Mesh.MorphTime | | set |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a604b51d890d188aecc0bced025a88ea9)Color
--------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Engine.Mesh.Color | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#afce1b6453f24e92fbafb52febb0b8a0d)Color2
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Engine.Mesh.Color2 | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a82b91ea486cfb307055da4d1ee6609a9)Billboard
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BillboardType](namespace_tale_worlds_1_1_engine.html#a3ed50bcc37546412a4aa400d33f3a001) TaleWorlds.Engine.Mesh.Billboard | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#ae0cca8a110d0899c0d25347b4cfd8fb5)VisibilityMask
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [VisibilityMaskFlags](namespace_tale_worlds_1_1_engine.html#a4f08a181fb3293a5be29538dca70d788) TaleWorlds.Engine.Mesh.VisibilityMask | | getset |

[◆](class_tale_worlds_1_1_engine_1_1_mesh.html#a857378948ed0d7b79d5c9a9f204de825)EditDataFaceCornerCount
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.Mesh.EditDataFaceCornerCount | | get |

